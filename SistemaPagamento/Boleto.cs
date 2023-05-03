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

            Console.Write($"Digite o valor do boleto: R$");
            boleto.Valor = float.Parse(Console.ReadLine()!);

            boleto.CodigoDeBarras = GerarCodigoDeBarras();

            Console.WriteLine($"\n Dados do boleto:");
            Console.WriteLine($"Valor: {boleto.Valor.ToString("C2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Data: {boleto.Data}");
            Console.WriteLine($"Código de barras: {boleto.CodigoDeBarras}");

            Globals.boletos.Add(boleto);
            Funcionalidades.Mensagem($"Boleto Registrado com sucesso!", ConsoleColor.Green);
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