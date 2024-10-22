namespace CalculadoraConsole.Model
{
    public class Somar : IOperacao
    {
        public int Calcular(int Valor1, int Valor2)
        {
            return Valor1 + Valor2;
        }
    }
}
