using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Application.Model.Operation
{
    public class Dividir : IOperacao
    {
        public int Calcular(int Valor1, int Valor2) {
            if (Valor2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero!");
            }
            return Valor1 / Valor2;
        }
    }
}
