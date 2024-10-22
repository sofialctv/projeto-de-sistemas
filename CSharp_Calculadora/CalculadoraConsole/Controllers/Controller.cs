using CalculadoraConsole.Model;
using CalculadoraConsole.DTOs;
using System;
using System.Linq;
using System.Reflection;

namespace CalculadoraConsole.Controller
{
    public class CalculadoraController
    {
        private readonly string _namespaceOperacoes = "CalculadoraConsole.Model";

        // Este método agora usa o OperacaoRequestDTO para a entrada e OperacaoResponseDTO para a saída
        public OperacaoResponseDTO ExecutarOperacao(OperacaoRequestDTO request)
        {
            var response = new OperacaoResponseDTO();
            try
            {
                // Busca a classe da operação correspondente usando Reflection
                var tipoOperacao = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FirstOrDefault(t => typeof(IOperacao).IsAssignableFrom(t)
                                         && t.IsClass
                                         && t.Namespace == _namespaceOperacoes
                                         && t.Name.Equals(request.TipoOperacao, StringComparison.OrdinalIgnoreCase));

                if (tipoOperacao == null)
                {
                    response.Mensagem = $"\nOperação '{request.TipoOperacao}' não encontrada.";
                    return response;
                }

                // Cria a instância da operação
                var operacao = (IOperacao)Activator.CreateInstance(tipoOperacao);
                if (operacao == null)
                {
                    response.Mensagem = $"\nErro ao instanciar a operação '{request.TipoOperacao}'.";
                    return response;
                }

                // Executa a operação e popula o DTO de resposta
                int resultado = operacao.Calcular(request.Numero1, request.Numero2);
                response.Resultado = resultado;
                response.Mensagem = $"\nOperação '{request.TipoOperacao}' executada com sucesso.";
            }
            catch (Exception ex)
            {
                response.Mensagem = $"\nErro durante a operação: {ex.Message}";
            }

            return response;
        }
    }
}
