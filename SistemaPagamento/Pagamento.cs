namespace SistemaPagamento
{
    public class Pagamento
    {
        public DateTime Data { get; private set; } = DateTime.Now.Date;

        public float Valor { get; set; }

        public string Cancelar() => "Operação Cancelada !";
    }
}