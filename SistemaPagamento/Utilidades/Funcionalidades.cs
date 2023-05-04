namespace ClasseFuncionalidades
{
    public class Funcionalidades
    {
        public static void Mensagem(string mensagem, ConsoleColor color = ConsoleColor.Red, bool limparConsole = true) {
            if (limparConsole) { Console.Clear(); }
            Console.ForegroundColor = color;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.Write($"Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Titulo(string mensagem, ConsoleColor color = ConsoleColor.Blue) {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine($" === {mensagem.ToUpper()} ===");
            Console.ResetColor();
        }
    }
}