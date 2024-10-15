using CalculadoraConsole.Application.DTOs.Request;
using CalculadoraConsole.Application.DTOs.Response;
using CalculadoraConsole.Application.Model.Operation;
using System;

namespace CalculadoraConsole.Controller
{
    public class Controller
    {
        public ResponseDTO Calc(RequestDTO requestDTO) {
            try
            {
                string nomeIOperation = GetOperationClassName(requestDTO.Opcao);
                Type classIOperation = Type.GetType(nomeIOperation);

                if (classIOperation == null)
                {
                    throw new InvalidOperationException("Operação Inválida!");
                }

                IOperacao instanciaOperation = (IOperacao)Activator.CreateInstance(classIOperation);
                int result = instanciaOperation.Calcular(requestDTO.Valor1, requestDTO.Valor2);
                return new ResponseDTO(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new ResponseDTO(-1);
            }
        }

        private string GetOperationClassName(int Opcao) {
            return Opcao switch
            {
                1 => "CalculadoraConsole.Application.Model.Operation.Somar",
                2 => "CalculadoraConsole.Application.Model.Operation.Subtrair",
                3 => "CalculadoraConsole.Application.Model.Operation.Multiplicar",
                4 => "CalculadoraConsole.Application.Model.Operation.Dividir",
                _ => throw new InvalidOperationException("Operação inválida!")
            };
        }
    }
}
