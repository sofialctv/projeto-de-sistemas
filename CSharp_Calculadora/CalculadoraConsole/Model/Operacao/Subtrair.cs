using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Application.Model.Operation
{
    public class Subtrair : IOperacao 
    {
        public int Calcular(int Valor1, int Valor2)
        { 
            return Valor1 - Valor2; 
        }
    }
}
