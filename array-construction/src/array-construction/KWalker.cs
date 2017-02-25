using System;
using System.Collections.Generic;
using System.Linq;

namespace array_construction
{
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