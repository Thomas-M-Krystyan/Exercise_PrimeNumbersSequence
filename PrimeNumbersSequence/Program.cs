using System;
using PrimeNumbersSequence.Algorithms;
using PrimeNumbersSequence.Utilities;
using static PrimeNumbersSequence.Utilities.Messages;

namespace PrimeNumbersSequence
{
    internal static class Program
    {
        // Global variables
        internal static ulong Number;
        internal static bool Run;

        internal static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Returning answer to question: "If digit is a Prime Number"
            // ----------------------------------------------------------------
            HelperMethods.Separator(false);
            Console.WriteLine(CheckIfDigitIsPrimaryNumber);
            Number = HelperMethods.GetInput();
            Console.WriteLine("\n" + PrimaryNumbers.CheckIfPrimeNumber(Number));

            // ----------------------------------------------------------------
            // Displaying Prime Numbers
            // ----------------------------------------------------------------
            HelperMethods.Separator();
            Console.WriteLine(DisplayPrimeNumbersSequence);
            HelperMethods.AskIfContinue();
            if (Run)
            {
                PrimaryNumbers.GenerateSequence(Number);
            }

            // ----------------------------------------------------------------
            // End of program
            // ----------------------------------------------------------------
            Console.ReadLine();
        }
    }
}
