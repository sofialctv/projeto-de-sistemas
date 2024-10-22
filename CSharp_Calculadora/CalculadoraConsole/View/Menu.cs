using CalculadoraConsole.Controller;
using CalculadoraConsole.DTOs;
using System;

namespace CalculadoraConsole.View
{
    public class Menu
    {
        public static void Show()
        {
            var controller = new CalculadoraController();
            
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("# Somar");
            Console.WriteLine("# Subtrair");
            Console.WriteLine("# Multiplicar");
            Console.WriteLine("# Dividir");
            Console.WriteLine("# SAIR");

            string operacaoEscolhida = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            // Cria o DTO de request (entrada)
            var request = new OperacaoRequestDTO()
            {
                Numero1 = numero1,
                Numero2 = numero2,
                TipoOperacao = operacaoEscolhida
            };

            // Chama o controller e obtém o DTO de response (saída)
            var response = controller.ExecutarOperacao(request);

            // Exibe o resultado
            Console.WriteLine(response.Mensagem);
            if (response.Mensagem.Contains("sucesso"))
            {
                Console.WriteLine($"Resultado: {response.Resultado}");
            }
        }
    }
}