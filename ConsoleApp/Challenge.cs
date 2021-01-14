using System.Collections.Generic;
using static UtilityLibrary.NumericalUtility;
using static System.Convert;
using static System.Console;

namespace ConsoleApp
{
    public class Challenge
    {
        private string message;
        private bool endApp = false;

        public Challenge()
        {

        }

        /// <summary>
        /// Lê os dados inseridos no console da aplicação.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="chosen"></param>
        public void MainChallenge(out string line, out string chosen)
        {
            line = "";
            chosen = "";
            message = string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? "\nPor favor informe um número\n" : message;
            ReadSimpleDataEntry(ref line, ref chosen);
        }

        private void ReadSimpleDataEntry(ref string line, ref string chosen)
        {
            WriteLine(message);
            line = ReadLine();

            if (!string.IsNullOrEmpty(line) && !string.IsNullOrWhiteSpace(line))
            {
                if (IsNaturalNumber(line))
                {
                    PrintDividers(ToInt32(line));
                }
            }
        }

        private void RepeatReadingDataEntry(ref string line, ref string chosen)
        {
            while (!endApp)
            {
                WriteLine(message);
                line = ReadLine();

                EndApplication(line);

                if (!string.IsNullOrEmpty(line) && !string.IsNullOrWhiteSpace(line))
                {

                    WriteLine("\nSelecione o tipo de informacao de decomposição do número informado:\n");
                    Write("\n\t0. Todos os Divisores\n\t1. Divisores primos\n\t2. Divisores pares\n");
                    chosen = ReadLine();

                    EndApplication(chosen);

                    if (IsNaturalNumber(line))
                    {
                        PrintDividers(ToInt32(line), chosen);
                        message = "\nInforme um novo número\n";
                        MainChallenge(out _, out _);
                    }
                    else
                    {
                        message = "Por favor insira novamente um número";
                        MainChallenge(out _, out _);
                    }
                }

            }
        }


        /// <summary>
        /// Finaliza a aplicação console.
        /// </summary>
        /// <param name="text"></param>
        private void EndApplication(string text)
        {
            if (text.ToUpper() == "EXIT")
            {
                endApp = true;
                MainChallenge(out _, out _);
            }
        }

        /// <summary>
        /// Exibe todos os tipos de divisores (inteiros naturais, ímpares e pares) do número informando no parâmetro <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Número inteiro natural</param>
        private void PrintDividers(int value)
        {
            var allDivisors = DivasorNumbers(value);
            var evenDivisors = EvenDividers(value);
            var primeDivisors = PrimeDividers(value);

            PrintAllDivisors(value, allDivisors);
            PrintPrimeDividers(value, primeDivisors);
            PrintEvenDividers(value, evenDivisors);

            static void PrintAllDivisors(int value, IList<int> allDivisors)
            {
                string text = "";
                foreach (var num in allDivisors)
                    text += $"{num} ";
                WriteLine($"Todos os divisores de {value}:\n\t{text}");
            }

            static void PrintPrimeDividers(int value, IList<int> primeDivisors)
            {
                string text = "";
                if (primeDivisors.Count > 0)
                {
                    foreach (var num in primeDivisors)
                        text += $"{num} ";
                }
                else
                {
                    text = "\t Não há divisores.";
                }
                WriteLine($"Todos os divisores primos de {value}:\n\t{text}");
            }

            static void PrintEvenDividers(int value, IList<int> evenDivisors)
            {
                string text = "";
                if (evenDivisors.Count > 0)
                {
                    foreach (var num in evenDivisors)
                        text += $"{num} ";

                }
                else
                {
                    text = "\t Não há divisores.";
                }
                WriteLine($"Todos os divisores pares de {value}:\n\t{text}");
            }
        }

        /// <summary>
        /// Exibe os divisores (de acordo com o tipo informado no parâmetro <paramref name="type"/>) do número informado no parâmetro <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Número inteiro natural</param>
        /// <param name="type">0. Todos os divisores; 1. Divisores primos; 2. Divisores pares</param>
        private void PrintDividers(int value, string type)
        {
            string text = "";
            IList<int> numbers = TypeOfDividers(value, type);

            if (numbers.Count > 0)
                foreach (var number in numbers)
                    text += $"{number} ";
            else
                text = "\t Não há divisores para opção selecionada.";

            WriteLine(MoutMessageToPrint(value, type));
            WriteLine("\t{0}", text);

            static IList<int> TypeOfDividers(int value, string type)
            {
                return type switch
                {
                    "0" => DivasorNumbers(value),
                    "1" => PrimeDividers(value),
                    "2" => EvenDividers(value),
                    _ => new List<int>(),
                };
            }

            static string MoutMessageToPrint(int value, string type)
            {
                return type == "0" ? $"Divisores de {value}:\n" : type == "1" ? $"Divisores primos de {value}:\n" : $"Divisores pares de {value}:\n";
            }
        }
    }
}
