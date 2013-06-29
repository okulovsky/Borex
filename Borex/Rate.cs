using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borex
{
    public class Rate
    {
        public readonly Currencies Currency;
        public readonly double BuyRate;
        public readonly double SellRate;
        public Rate(Currencies currency, double buyRate, double sellRate)
        {
            Currency = currency;
            BuyRate = buyRate;
            SellRate = sellRate;
        }
    }
}
