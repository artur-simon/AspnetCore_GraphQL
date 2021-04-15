using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public static class CoinCalculation
    {
        private static bool _found = false;
        private static int[] _selectedCoins;
        private static int[] _range;
        public static int[] Calculate(int[] range, int target)
        {
            range = range.Where(c => c > 0).ToArray()
                .Distinct().ToArray();
            Array.Sort(range);
            _range = range;
            _selectedCoins = new int[]{};
            _found = false;
            CalculateRecursive(target, _range.Length - 1, new int[0]);

            return _selectedCoins;
        }

        static void CalculateRecursive(int target, int denom, int[] coins)
        {
            if (_found || target < 0 || (denom < 0 && target >= 1)) return;
            if (target == 0)
            {
                _found = true;
                _selectedCoins = coins;
                return;
            }
            int[] coinAddedArray = new int[coins.Length + 1];
            if (coins.Length > 0)
                Array.Copy(coins, coinAddedArray, coins.Length);
            coinAddedArray[coinAddedArray.Length - 1] = _range[denom];
            CalculateRecursive(target - _range[denom], denom, coinAddedArray);
            CalculateRecursive(target, denom - 1, coins);
        }

    }
}
