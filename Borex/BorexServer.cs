using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borex
{
    public class BorexServer
    {
        public IEnumerable<Rate> GetRates()
        {
            yield return new Rate(Currencies.USD, 35, 34);
            yield return new Rate(Currencies.EUR, 45, 44);
            yield return new Rate(Currencies.PLN, 11, 10);
            yield return new Rate(Currencies.CZK, 1.6, 1.5);
        }

        public void Exchange(Account account, Currencies from, Currencies to, double amount)
        {
            account[from] -= amount;
            amount *= GetRates().Where(z => z.Currency == from).FirstOrDefault().BuyRate;
            amount /= GetRates().Where(z => z.Currency == to).FirstOrDefault().SellRate;
            account[to] += amount;
        }
    }
}
