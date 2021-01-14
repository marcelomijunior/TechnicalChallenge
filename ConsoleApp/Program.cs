using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\tWelcome To Technical Challenge");
            WriteLine("\nCaso queira encerrar a aplicação pressione CTRL+C.");
            var challenge = new Challenge();
            challenge.MainChallenge(out string _, out string _);
        }
    }
}
