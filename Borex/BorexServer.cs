using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borex
{
    public class BorexServer
    {
        public List<Rate> GetRates()
        {
            return new List<Rate>
            {
                new Rate(Currencies.USD, 35, 34),
                new Rate(Currencies.EUR, 45, 44),
                new Rate(Currencies.PLN, 11, 10),
                new Rate(Currencies.CZK, 1.6, 1.5),
            };

        }
    }
}
