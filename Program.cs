using System;
using System.Diagnostics;
using System.Linq;

namespace ComparisonDistributionCountSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ComparisonCountSort.fillArray(1000000);
            int u = array.Max();
            int l = array.Min();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var sortedArray = ComparisonCountSort.ComparisonCountingSort(array);
            //var sortedArray = DistributionCountingSort.DistributionCountSort(array, l, u);

            stopwatch.Stop();
            var elapsed_time = stopwatch.ElapsedMilliseconds;

            string returnString = "[";

            //for (int i = 0; i < sortedArray.Length; i++)
            //{
            //    returnString += sortedArray[i] + ",";
            //}


            returnString += "]";

            Console.WriteLine(returnString + Environment.NewLine + "Time elapsed: " + elapsed_time);

            //Array.ForEach(sortedArrayDistribution, Console.WriteLine);

            //DistributionCountingSort.PrintNext(0, sortedArrayDistribution, 1000000);

        }
    }
}
