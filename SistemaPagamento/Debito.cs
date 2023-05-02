

using ClasseCartao;

namespace SistemaPagamento
{
    public class Debito : Cartao
    {
        private float Saldo;

        public override void Pagar()
        {
            throw new NotImplementedException();
        }
 
        private float MostrarSaldo()
        {
            return this.Saldo;
        }
    }
}
