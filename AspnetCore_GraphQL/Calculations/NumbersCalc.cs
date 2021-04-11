using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public static class NumbersCalc
    {
        public static int[] Calculate(int[] range, int target)
        {
            //Conform array
            range = range.Where(c => c > 0).ToArray()
                .Distinct().ToArray();
            Array.Sort(range);
            //decompose target with range's values
            List<int> result = new List<int>();
            for (int x = range.Length - 1; x >= 0; x--)
            {
                while (target / range[x] > 0)
                {
                    target -= range[x];
                    result.Add(range[x]);
                }
            }
            if (target > 0)
                return new int[] { -1 };
            int[] returnSorted = result.ToArray();
            Array.Sort(returnSorted);
            return returnSorted;
        }

    }
}
