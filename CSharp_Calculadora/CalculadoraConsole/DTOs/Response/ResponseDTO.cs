using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Application.DTOs.Response
{
    public class ResponseDTO
    {
        public int Result;
        
        public ResponseDTO(int Result)
        {
            this.Result = Result;
        }

        public int getResult()
        {
            return Result;
        }
    }
}
