using System;
using System.Collections.Generic;
using System.IO;

namespace array_construction
{
    public class SWalker
    {
        public void GenerateResearch(int n, int s)
        {
            var outputFile = $"temp/swalk_{n}_{s}.txt";
            File.Delete(outputFile);
            var i = 0;
            foreach (var tuple in LxgWalkForS(n, s))
            {
                File.AppendAllLines(outputFile, new[]
                {
                    $"{i++.ToString().PadRight(7)}" +
                    $"{string.Join(" ", tuple.Item1).PadRight(40)}" +
                    $"{tuple.Item2.ToString().PadRight(60)}"
                });
            }
        }

        private static IEnumerable<Tuple<int[], int>> LxgWalkForS(int n, int s)
        {
            var arr = new int[n];
            arr[n - 1] = s;
            do yield return new Tuple<int[], int>(arr, GetK(arr));
            while (Increment(arr));
        }

        private static int GetK(IReadOnlyList<int> arr)
        {
            var res = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                for (var j = i + 1; j < arr.Count; j++)
                {
                    res += Math.Abs(arr[i] - arr[j]);
                }
            }
            return res;
        }

        private static bool Increment(IList<int> current)
        {
            for (var i = current.Count - 2; i >= 0; i--)
            {
                if (current[current.Count - 1] - current[i] > 1)
                {
                    var incremented = current[i] + 1;
                    var disbalance = 0;
                    for (var j = i; j < current.Count - 1; j++)
                    {
                        disbalance += current[j] - incremented;
                        current[j] = incremented;
                    }
                    current[current.Count - 1] += disbalance;
                    return true;
                }
            }
            return false;
        }
    }
}