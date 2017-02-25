using System;
using System.Collections.Generic;

namespace array_construction
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var sw = new SWalker();
            sw.GenerateResearch(5, 41);

            //var kw = new KWalker();
            //foreach (var arr in kw.WalkByK(13, 19, 34))
            //{
            //    Console.WriteLine(string.Join(" ", (IEnumerable<string>)arr));
            //}
        }

        private static IEnumerable<int> Query(int n, int s, int k)
        {
            throw new NotImplementedException();
        }
    }
}
