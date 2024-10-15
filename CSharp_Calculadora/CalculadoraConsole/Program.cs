using CalculadoraConsole.Application.DTOs.Request;
using CalculadoraConsole.Application.DTOs.Response;
using CalculadoraConsole.Application.View;
using System;

namespace CalculadoraConsole.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new();
            RequestDTO requestDTO = Menu.Show();
            Controller.Controller controllerCalc = new Controller.Controller();
            ResponseDTO responseDTO = controllerCalc.Calc(requestDTO);
            Menu.ShowResult(responseDTO);
        }
    }
}
