using System;
using System.Text.RegularExpressions;
using BanqUP_exercise.Code;

namespace BanqUP_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naciśnij enter po wprowadzeniu działania aby otrzymać wynik. Jeśli chcesz zakończyć program naciśnij x");

            var inputString = "";
            ConsoleKeyInfo key;
            do
            {
                /*
                 * Wpisywanie przez uzytkownika dzialania do obliczenia.
                 */
                inputString = "";
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        Match match = Regex.Match(key.KeyChar.ToString(), @"[\d\+\-\*\/]|x");

                        if( match.Value.ToUpper() == "X")
                            return;
                        else if (match.Value !="")
                        {
                            inputString += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && inputString.Length > 0)
                        {
                            inputString = inputString.Substring(0, (inputString.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                while (key.Key != ConsoleKey.Enter);

                OperationManager makeResult = new OperationManager(inputString);

                Console.WriteLine("\n" + "Wpisane działanie: " + inputString);
                Console.WriteLine("Wynik= " + makeResult.GetResult());
            }
            while (key.Key != ConsoleKey.X);
        }
    }
}
