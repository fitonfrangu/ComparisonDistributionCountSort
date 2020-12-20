using System;
using System.Collections.Generic;
using System.Text;

namespace ComparisonDistributionCountSort
{
    public static class DistributionCountingSort
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

        public static int[] DistributionCountSort(int[] input, int l, int u)
        {
            var d = new int[u + 1]; // count array ku i shtojme numrimet
            var S = new int[input.Length];

            for (int j = 0; j <= (u - l); j++)
            {
                d[j] = 0;
            }

            //gjetja e frekuences
            for (int i = 0; i <= input.Length - 1; i++)
            {
                d[input[i] - l] = d[input[i] - l] + 1;
            }

            //mbledhja e elementeve paraprake (cumulative frequency distribution)
            for (int j = 1; j < (u - l); j++)
            {
                d[j] = d[j - 1] + d[j];
            }

            //vendosja sipas frekuences ne array-in perfundimtar s[]
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int j = input[i] - l;
                S[d[j] - 1] = input[i];
                d[j] = d[j] - 1;
            }

            return S;
        }
    }
}
