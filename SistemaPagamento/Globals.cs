using System.Collections.Generic;
using ClasseBoleto;
using ClasseCartao;

namespace GlobalVariables
{
    public class Globals
    {
        public static List<Cartao> cartoes = new List<Cartao>();

        public static List<Boleto> boletos = new List<Boleto>();

        public static void Titulo(string mensagem, ConsoleColor color = ConsoleColor.Blue) {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine($" === {mensagem} ===");
            Console.ResetColor();
        }
    }
}