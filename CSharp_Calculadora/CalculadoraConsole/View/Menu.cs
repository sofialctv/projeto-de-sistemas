using System;
using CalculadoraConsole.Application.DTOs.Request;
using CalculadoraConsole.Application.DTOs.Response;

namespace CalculadoraConsole.Application.View
{
    internal class Menu
    {
        public static RequestDTO Show()
        {
            Console.WriteLine("#    C# CALC    #");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - SAIR");

            int Opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o primeiro valor:");
            int Valor1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nInforme o segundo valor:");
            int Valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(Opcao, Valor1, Valor2);
        }

        public static void ShowResult(ResponseDTO responseDTO)
        {
            if (responseDTO.Result == -1)
            {
                Console.WriteLine("Erro ao calcular");
            }
            else
            {
                Console.WriteLine($"\nRESULTADO = {responseDTO.Result}");
            }
        }
    }
}
