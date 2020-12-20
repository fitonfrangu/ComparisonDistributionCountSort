using System;
using System.Collections.Generic;
using System.Text;

namespace ComparisonDistributionCountSort
{
    public static class ComparisonCountSort
    {
        public static int[] fillArray(int arrayLength)
        {
            int[] returnArray = new int[arrayLength];
            Random rnd = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                returnArray[i] = rnd.Next(1000);
            }

            return returnArray;
        }

        public static int[] ComparisonCountingSort(int[] input)
        {
            var count = new int[input.Length];
            var output = new int[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i <= input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                    {
                        count[j] = count[j] + 1;
                    }
                    else
                    {
                        count[i] = count[i] + 1;
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                output[count[i]] = input[i];
            }

            return output;
            
        }

        public static void PrintNext(int i, int[] array, int length)
        {
            if (i <= length - 1)
            {
                Console.Write(array[i] + " ");
                PrintNext(i + 1, array, length);
            }
        }
    }
}
