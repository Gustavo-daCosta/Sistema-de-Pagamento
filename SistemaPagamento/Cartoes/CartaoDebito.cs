using ClasseCartao;
using ClasseFuncionalidades;

namespace CartaoDebito
{
    public class Debito : Cartao 
    {
        private float Saldo;

        public void DefinirSaldo() {
            saldo:
            Console.Write($"Informe seu saldo: R$");
            this.Saldo = float.Parse(Console.ReadLine()!);
            
            if (this.Saldo < 0) {
                Funcionalidades.Mensagem($"Saldo inválido! Digite um valor maior ou igual a zero.");
                goto saldo;
            }
        }

        public override bool Pagar() {
            valor:
            Console.Write($"Digite o valor da transação: R$");
            this.Valor = float.Parse(Console.ReadLine()!);

            if (this.Valor <= 0) {
                Funcionalidades.Mensagem($"Valor inválido! Digite um valor maior que zero.");
                goto valor;
            }
            return this.Saldo >= Valor;
        }
 
    }
}
