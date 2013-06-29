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
            yield return new Rate(Currencies.USD, 35, 2);
            yield return new Rate(Currencies.EUR, 45, -1);
            yield return new Rate(Currencies.PLN, 11, -1);
            yield return new Rate(Currencies.CZK, 1.6, 0.5);
        }

        public void Exchange(Account account, Currencies from, Currencies to, double amount)
        {
            Console.Write("{0,-5}{1,-5}{2}", from, to, amount);
            account[from] -= amount;
            amount *= GetRates().Where(z => z.Currency == from).FirstOrDefault().ExchangeRate;
            amount *= 0.9;
            amount /= GetRates().Where(z => z.Currency == to).FirstOrDefault().ExchangeRate;
            account[to] += amount;
        }
    }
}
