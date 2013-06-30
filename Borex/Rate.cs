using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borex
{
    public class Rate
    {
        public readonly Currencies Currency;
        public readonly double ExchangeRate;
        public readonly double Growth;
        public readonly double RelativeGrowth;
        public Rate(Currencies currency, double rate, double growth)
        {
            Currency = currency;
            ExchangeRate = rate;
            Growth = growth;
            RelativeGrowth = Growth / ExchangeRate;
        }
    }
}
