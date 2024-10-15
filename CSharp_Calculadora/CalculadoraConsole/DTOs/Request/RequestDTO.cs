using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Application.DTOs.Request
{
    public class RequestDTO
    {
        public int Opcao;
        public int Valor1;
        public int Valor2;

        public RequestDTO(int Opcao, int Valor1, int Valor2) 
        { 
            this.Opcao = Opcao;
            this.Valor1 = Valor1;
            this.Valor2 = Valor2;
        }

        public int getOpcao()
        {
            return Opcao;
        }

        public int getValor1()
        {
            return Valor1;
        }

        public int getValor2()
        {
            return Valor2;
        }
    }
}
