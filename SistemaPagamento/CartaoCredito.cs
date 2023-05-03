using ClasseFuncionalidades;
using ClasseCartao;
using System.Globalization;

namespace CartaoCredito
{
    public class Credito : Cartao
    {
        public float Limite { get; set; }

        public override bool Pagar() {
            Funcionalidades.Titulo($"Pagar - Cartão de crédito");
            Credito cartaoCredito = new Credito();

            parcelas:
            Console.WriteLine($"Em quantas prestações deseja fazer?");
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

            this.Valor *= taxa;
            float valorParcela = this.Valor / parcelas;

            Console.WriteLine($"Dados da transação:");
            Console.WriteLine($"Valor total: {this.Valor.ToString("C2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Valor de cada parcela: {valorParcela.ToString("C2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Número de parcelas: {parcelas} parcelas");
            Console.WriteLine($"Taxa de juros: {taxa * 100}%");
            
            return parcelas <= 12 ? true : false;
        }
    }
}