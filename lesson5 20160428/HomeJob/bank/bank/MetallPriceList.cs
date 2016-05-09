using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
        public static class MetallPriceList
    {
        private static Dictionary<Metalls, decimal> _prices = new Dictionary<Metalls, decimal>();

        static MetallPriceList()
        {
            _prices.Add(Metalls.Gold, 2);
            _prices.Add(Metalls.Silver, 1);
            _prices.Add(Metalls.Platinum, 5);
            _prices.Add(Metalls.Palladium, 7);
        }
        public static decimal GetValue(Metalls key)
        {
            return _prices[key];
        }


    }


}

