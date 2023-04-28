

namespace SistemaPagamento
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;

        public void Registrar()
        {
            Console.WriteLine($"o valor e igual a: {pagamento * (1- 0.12f) }");
            Random random = new Random();
            int codigoBarras = random.Next(1, 999999999);
        }
    }
}