namespace CalculadoraConsole.DTOs
{
    public class OperacaoRequestDTO
    {
        public int Numero1 {get; set;}
        public int Numero2 { get; set; }
        public string TipoOperacao { get; set; } = string.Empty;
    }
}
