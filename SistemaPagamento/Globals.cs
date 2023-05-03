using System.Collections.Generic;
using ClasseCartao;

namespace GlobalVariables
{
    public class Globals
    {
        public static List<Cartao> cartoes = new List<Cartao>();

        public static void Titulo(string mensagem, ConsoleColor color = ConsoleColor.Blue) {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine($" === {mensagem} ===");
            Console.ResetColor();
        }
    }
}