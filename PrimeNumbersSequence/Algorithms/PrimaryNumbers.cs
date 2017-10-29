using System;
using System.Collections.Generic;

namespace PrimeNumbersSequence.Algorithms
{
    internal static class PrimaryNumbers
    {
        // Dobule iteration method to generate n-th Prime Numbers
        internal static void GenerateSequence1(ulong iterationNumber)
        {
            for (ulong num = 2, counter = 1; counter <= iterationNumber; num++)  // [num = 2]: 0 and 1 cannot be prime numbers
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

        // Sieve of Eratosthenes' algorithm
        internal static void GenerateSequence2(ulong maxNumber)
        {
            // Generate list of numbers from 2 to maxNumber
            List<ulong> numbers = new List<ulong>();
            for (ulong i = 2; i <= maxNumber; i++)  // [num = 2]: 0 and 1 cannot be prime numbers
            {
                numbers.Add(i);
            }

            // Sieve non-Prime Numbers from generated list of numbers
            bool isRunning = true;
            int currentNumberIndex = 0;
            while (isRunning && numbers[currentNumberIndex] != maxNumber)
            {
                for (int x = numbers.Count - 1; x >= 0; x--)
                {
                    if (numbers[x] != numbers[currentNumberIndex] && numbers[x] % numbers[currentNumberIndex] == 0)
                    {
                        numbers.RemoveAt(x);
                    }
                }
                currentNumberIndex++;

                if (currentNumberIndex > numbers.Count - 1)
                {
                    isRunning = false;
                }
            }

            foreach (ulong number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Iteration method to return answer if digit is a Prime Number
        internal static bool CheckIfPrimeNumber(ulong number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (ulong div = 2; div < number; div++)  // [div = 2]: cannot divide by 0 and every number is divisible by 1
            {
                if (number != div && number % div == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
