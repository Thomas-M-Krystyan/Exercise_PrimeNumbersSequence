using System;

namespace PrimeNumbersSequence.Utilities
{
    internal static class HelperMethods
    {
        // Helper method to asking user for input (length of Fibonacci sequence)
        internal static ulong GetInput()
        {
            Console.WriteLine(Messages.QuestionUserInput);
            string userInput = Console.ReadLine();

            try
            {
                return Convert.ToUInt64(userInput == "" ? "0" : userInput.Contains("-") ? "0" : userInput);
            }
            catch (FormatException exception)  // If digit is not typed
            {
                Console.WriteLine(exception.Message);
                return 0UL;
            }
        }

        // Helper method to preventing known runtime crashes or system slowdown
        internal static void AskIfContinue()
        {
            Program.Run = true;

            while (true)
            {
                Console.WriteLine($"{Messages.QuestionChangeNumber} ({Program.Number})? {Messages.OptionKeysToPress}");
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.KeyChar == Convert.ToChar('Y'.ToString().ToLower()))
                {
                    Console.WriteLine();
                    break;
                }
                if (userInput.KeyChar == Convert.ToChar('N'.ToString().ToLower()))
                {
                    Console.WriteLine();
                    Program.Number = GetInput();
                }
                if (userInput.KeyChar == Convert.ToChar('S'.ToString().ToLower()))
                {
                    Program.Run = false;
                    break;
                }
                if (userInput.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

        // Helper method to displaying separator between algorithms
        internal static void Separator(bool waitForKey = true)
        {
            if (waitForKey)
            {
                Console.ReadKey();
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
