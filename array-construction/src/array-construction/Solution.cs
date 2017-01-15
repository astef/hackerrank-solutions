using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace array_construction
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            //const string outputFile = "temp/data_4_29.txt";
            //File.Delete(outputFile);
            //var n = 0;
            //foreach (var tuple in AnalyzeK(4, 29))
            //{
            //    File.AppendAllLines(outputFile, new[]
            //    {
            //        $"{n++.ToString().PadRight(7)}" +
            //        $"{string.Join(" ", tuple.Item1).PadRight(40)}" +
            //        $"{tuple.Item2.ToString().PadRight(60)}"
            //    });
            //    //File.AppendAllLines(outputFile, new[]
            //    //{
            //    //    $"{tuple.Item2}"
            //    //});
            //}

            var kw = new KWalker();
            foreach (var arr in kw.WalkByK(13, 19, 34))
            {
                Console.WriteLine(string.Join(" ", (IEnumerable<string>)arr));
            }
        }


        private static IEnumerable<int> Run(int n, int s, int k)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<Tuple<int[], int>> AnalyzeK(int n, int s)
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

    public class KWalker
    {

        public IEnumerable<IReadOnlyList<int>> WalkByK(int n, int s, int k)
        {
            var arr = new int[n];
            var coeffs = new int[n].Select((x, i) => (n + 1) % 2 - (n / 2 - i) * 2).ToArray();

            var negas = new int[n - n / 2]; // e<=d<=c<=..
            var posis = new int[n / 2]; // ..b<=a

            for (var i = negas.Length - 1; i >= 0; i--)
            {
                if (!TryIncrementNegas(negas, i, s, n))
                    continue;
                for (var j = posis.Length - 1; j >= 0; j--)
                {
                    // increment posis
                }
            }


            throw new NotImplementedException();
        }

        private static bool TryIncrementNegas(int[] negas, int candidateIndex, int s, int n)
        {
            var prefixNegasSum = negas.Take(candidateIndex).Sum();
            var incrementedValue = negas[candidateIndex] + 1;
            var incrementedNegasSum = incrementedValue * (negas.Length - candidateIndex);
            var incrementedPosisSum = (n / 2) * incrementedValue;

            throw new NotImplementedException();

        }

    }
}
