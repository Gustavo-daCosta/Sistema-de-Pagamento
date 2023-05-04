using ClasseFuncionalidades;
using ClasseCartao;
using System.Globalization;

namespace CartaoCredito
{
    public class Credito : Cartao
    {
        public float Limite { get; set; }

        public void DefinirLimite() {
            limite:
            Console.Write($"Qual é o limite do cartão de crédito? R$");
            this.Limite = float.Parse(Console.ReadLine()!);

            if (this.Limite <= 0) {
                Funcionalidades.Mensagem($"Limite inválido! Digite um valor maior que zero.");
                goto limite;
            }
        }

        public override bool Pagar() {
            Funcionalidades.Titulo($"Pagar - Cartão de crédito");

            Console.Write($"\nDigite a bandeira do cartão: ");
            this.Bandeira = Console.ReadLine()!;

            Console.Write($"Digite número do cartão: ");
            this.NumeroCartao = Console.ReadLine()!;

            Console.Write($"Digite o titular do cartão: ");
            this.Titular = Console.ReadLine()!;

            Console.Write($"Digite o CVV do cartão: ");
            this.Cvv = Console.ReadLine()!;

            valor:
            Console.Write($"Digite o valor da transação: R$");
            this.Valor = float.Parse(Console.ReadLine()!);

            if (this.Valor <= 0) {
                Funcionalidades.Mensagem($"Valor inválido! Digite um valor maior que zero.");
                goto valor;
            }

            parcelas:
            Console.Write($"Em quantas prestações deseja fazer? ");
            int parcelas = int.Parse(Console.ReadLine()!);

            if (parcelas < 0 || parcelas > 12) {
                Funcionalidades.Mensagem($"Quantidade de parcelas inválida, digite um valor entre 1 e 12");
                goto parcelas;
            }
            
            float taxa = 0f;

            if (parcelas <= 6) {
                taxa = 0.05F;
            }
            else if (parcelas >= 7 && parcelas <= 12){
                taxa = 0.08F;
            }

            this.Valor += this.Valor * taxa;
            float valorParcela = this.Valor / parcelas;

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
            Console.WriteLine($"Valor de cada parcela: {valorParcela.ToString("C2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Número de parcelas: {parcelas} parcelas");
            Console.WriteLine($"Taxa de juros: {taxa * 100}%");

            Console.Write($"\nAperte ENTER para continuar...");
            Console.ReadLine();

            return valorParcela < this.Limite;
        }
    }
}