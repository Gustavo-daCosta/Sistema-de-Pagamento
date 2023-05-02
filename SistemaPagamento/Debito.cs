

using ClasseCartao;

namespace SistemaPagamento
{
    public class Debito : Cartao 
    {
        private float Saldo;

        private float MostrarSaldo()
        {
            Console.WriteLine($"Informe seu Saldo:");
            Saldo = float.Parse(Console.ReadLine()!);
            
            
            return this.Saldo;
        }

        public override bool Pagar()
        {
            float saldo = MostrarSaldo();
            return saldo >= Valor ? true : false;
        }
 
    }
}
