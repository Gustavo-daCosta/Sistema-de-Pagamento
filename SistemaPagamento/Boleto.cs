using System;
using SistemaPagamento;
using GlobalVariables;
using ClasseFuncionalidades;
using System.Globalization;

namespace ClasseBoleto
{
    public class Boleto : Pagamento
    {
        private string? CodigoDeBarras;

        public void Registrar() {
            Funcionalidades.Titulo($"Registrar boleto");
            Boleto boleto = new Boleto();

            valor:
            Console.Write($"Digite o valor do boleto: R$");
            boleto.Valor = float.Parse(Console.ReadLine()!);

            if (boleto.Valor <= 0) {
                Funcionalidades.Mensagem($"Valor inválido! Digite um valor maior que zero.");
                goto valor;
            }

            boleto.CodigoDeBarras = GerarCodigoDeBarras();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nDados do boleto:");
            Console.ResetColor();
            Console.WriteLine($"Valor: {boleto.Valor.ToString("C2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Data: {boleto.Data.ToShortDateString()}");
            Console.WriteLine($"Código de barras: {boleto.CodigoDeBarras}\n");

            Globals.boletos.Add(boleto);
            Funcionalidades.Mensagem($"Boleto Registrado com sucesso!", ConsoleColor.Green, limparConsole: false);
        }

        public void VerBoletos() {
            if (Globals.boletos.Any()) {
                Console.Clear();
                int i = 0;
                foreach (Boleto boleto in Globals.boletos) {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n{i}º Boleto:");
                    Console.ResetColor();
                    Console.WriteLine($"Valor: {boleto.Valor.ToString("C2", new CultureInfo("pt-BR"))}");
                    Console.WriteLine($"Data: {boleto.Data.ToShortDateString()}");
                    Console.WriteLine($"Código de barras: {boleto.CodigoDeBarras}");
                }
                Funcionalidades.Mensagem($"\nFim da lista de boletos!", ConsoleColor.Green, limparConsole: false);
            } else {
                Funcionalidades.Mensagem($"Nenhum boleto foi registrado até o momento!", ConsoleColor.Blue);
            }
        }

        private string GerarCodigoDeBarras() {
            string codigoBarras = "";
            Random random = new Random();

            // 1º Sequência - 10 dígitos
            codigoBarras += $"{random.NextInt64(1000000000, 9999999999)} ";
            // 2º Sequência - 10 dígitos
            codigoBarras += $"{random.NextInt64(1000000000, 9999999999)} ";
            // 3º Sequência - 10 dígitos
            codigoBarras += $"{random.NextInt64(1000000000, 9999999999)} ";
            // 4º Sequência - 1 dígito
            codigoBarras += $"{random.NextInt64(0, 9)} ";
            // 5º Sequência - 10 dígitos
            codigoBarras += $"{random.NextInt64(1000000000, 9999999999)} ";
            // 6º Sequência - 5 dígitos
            codigoBarras += random.NextInt64(10000, 99999);
            
            return codigoBarras;
        }
    }
}