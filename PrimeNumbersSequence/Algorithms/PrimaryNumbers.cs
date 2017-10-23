using System;

namespace PrimeNumbersSequence.Algorithms
{
    internal static class PrimaryNumbers
    {
        // Dobule iteration method to generate n-th Prime Numbers
        internal static void GenerateSequence(ulong iterationNumber)
        {
            for (ulong num = 2, counter = 1; counter <= iterationNumber; num++) // [num = 2]: 0 and 1 cannot be prime numbers
            {
                for (ulong div = 2; div <= num; div++)  // [div = 2]: cannot divide by 0 and every number is divisible by 1
                {
                    if (num != div)
                    {
                        if (num % div == 0)
                        {
                            break;
                        }
                        continue;
                    }
                    Console.WriteLine($"{counter}. {num}");
                    counter++;
                    break;
                }
            }
        }

        // Iteration method to return answer if digit is a Prime Number
        internal static bool CheckIfPrimeNumber(ulong number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (ulong div = 2; div <= number; div++)  // [div = 2]: cannot divide by 0 and every number is divisible by 1
            {
                if (number != div)
                {
                    if (number % div == 0)
                    {
                        return false;
                    }
                    continue;
                }
                break;
            }
            return true;
        }
    }
}
