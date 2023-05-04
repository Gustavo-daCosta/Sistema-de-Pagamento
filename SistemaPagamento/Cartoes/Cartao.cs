using SistemaPagamento;
using GlobalVariables;
using CartaoCredito;
using CartaoDebito;

namespace ClasseCartao
{
    public abstract class Cartao : Pagamento
    {
        public string? Bandeira;
        public string? NumeroCartao;
        public string? Titular;
        public string? Cvv;

        public abstract bool Pagar();
        public string SalvarCartao(string tipoCartao)
        {
            Cartao cartaoCriado;
            if (tipoCartao == "C")
            {
                cartaoCriado = new Credito();
            }
            else
            {
                cartaoCriado = new Debito();
            }
            bool loopSalvando = true;
            while (loopSalvando == true)
            {
                Console.Clear();
                Console.Write($"Informe a bandeira do cartão: ");
                this.Bandeira = Console.ReadLine();
                Console.Clear();
                Console.Write($"Informe o número do cartão: ");
                this.NumeroCartao = Console.ReadLine();
                Console.Clear();
                Console.Write($"Informe o titular do cartão: ");
                this.Titular = Console.ReadLine();
                Console.Clear();
                Console.Write($"Informe o CVV do cartão: ");
                this.Cvv = Console.ReadLine();
                Console.Clear();
                foreach (Cartao cartaoChecado in Globals.cartoes)
                {
                    if (cartaoChecado.NumeroCartao == cartaoCriado.NumeroCartao)
                    {
                        Console.WriteLine($"Cartão invalido por duplicidade");
                    }
                }
            }
            return "Cartão informado válido";
        }
    }
}