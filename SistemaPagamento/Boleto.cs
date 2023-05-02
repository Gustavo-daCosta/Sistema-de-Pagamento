using SistemaPagamento;

namespace SistemaPagamento
{
    public class Boleto : Pagamento
    {
        private string? CodigoDeBarras;

        public void Registrar()
        {
            Console.WriteLine($"o valor e igual a: {Valor * (1- 0.12f) }");
            Random random = new Random();
            this.CodigoDeBarras = random.Next(1, 999999999).ToString();
        }
    }
}