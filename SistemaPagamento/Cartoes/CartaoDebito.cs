using System.Globalization;
using ClasseCartao;
using ClasseFuncionalidades;

namespace CartaoDebito
{
    public class Debito : Cartao 
    {
        private float Saldo;

        public void DefinirSaldo() {
            Funcionalidades.Titulo($"Pagar - Cartão de débito");

            Console.Write($"\nDigite a bandeira do cartão: ");
            this.Bandeira = Console.ReadLine()!;

            Console.Write($"Digite número do cartão: ");
            this.NumeroCartao = Console.ReadLine()!;

            Console.Write($"Digite o titular do cartão: ");
            this.Titular = Console.ReadLine()!;

            Console.Write($"Digite o CVV do cartão: ");
            this.Cvv = Console.ReadLine()!;

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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dados do cartão:");
            Console.ResetColor();
            Console.WriteLine($"Bandeira do cartão: {this.Bandeira}");
            Console.WriteLine($"Número do cartão: {this.NumeroCartao}");
            Console.WriteLine($"Bandeira do cartão: {this.Bandeira}");
            Console.WriteLine($"Cvv do cartão: {this.Cvv}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nDados da transação:");
            Console.ResetColor();
            Console.WriteLine($"Valor total: {this.Valor.ToString("C2", new CultureInfo("pt-BR"))}");

            return this.Saldo >= Valor;
        }
 
    }
}
