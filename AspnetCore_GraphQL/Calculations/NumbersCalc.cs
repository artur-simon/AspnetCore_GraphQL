using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public static class NumbersCalc
    {
        private static bool found = false;
        private static int[] _match = new int[]{};
        private static int[] _range;
        public static int[] Calculate(int[] range, int target)
        {
            range = range.Where(c => c > 0).ToArray()
                .Distinct().ToArray();
            Array.Sort(range);
            _range = range;
            _match = new int[]{};
            found = false;
            CalcRecursive(target, _range.Length - 1, new int[0]);

            return _match;
        }

        static void CalcRecursive(int target, int denom, int[] coins)
        {
            if (found) return;
            if (target == 0)
            {
                found = true;
                _match = coins;
                return;
            }
            if (target < 0 || (denom < 0 && target >= 1)) return;
            int[] coinsAdded = new int[coins.Length + 1];
            if (coins.Length > 0)
                Array.Copy(coins, coinsAdded, coins.Length);
            coinsAdded[coinsAdded.Length - 1] = _range[denom];
            CalcRecursive(target - _range[denom], denom, coinsAdded);
            CalcRecursive(target, denom - 1, coins);
        }

    }
}
