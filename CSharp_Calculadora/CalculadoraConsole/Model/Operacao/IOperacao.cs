using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Application.Model.Operation
{
    public interface IOperacao
    {
        public int Calcular(int Valor1, int Valor2);
    }
}
