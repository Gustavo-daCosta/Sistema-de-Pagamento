using GlobalVariables;

namespace SistemaPagamento
{
    public abstract class Cartao : Pagamento
    {
        public string? Bandeira;
        public string? NumeroCartao;
        public string? Titular;
        public string? Cvv;
        public abstract void Pagar();
        public bool SalvarCartao(Cartao cartaoInput)
        {
            foreach (Cartao cartaoChecado in Globals.cartoes)
            {
                if (cartaoChecado == cartaoInput)
                {
                    return true;
                }
            }
            return false;
        }
    }
}