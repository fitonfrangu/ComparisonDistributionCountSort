using System;
using System.Diagnostics;
using System.Linq;

namespace ComparisonDistributionCountSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ComparisonCountSort.fillArray(50000);
            int u = array.Max();
            int l = array.Min();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //var sortedArrayComparison = ComparisonCountSort.ComparisonCountingSort(array);
            var sortedArrayDistribution = DistributionCountingSort.DistributionCountSort(array, l, u);

            stopwatch.Stop();
            var elapsed_time = stopwatch.ElapsedMilliseconds;

            string returnString = "[";

            foreach (var item in sortedArrayDistribution)
            {
                returnString += item + ",";
            }

            returnString += "]";

            Console.WriteLine(returnString + Environment.NewLine + "Time elapsed: " + elapsed_time);
        }
    }
}
