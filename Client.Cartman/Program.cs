using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Borex.BorexServer();
            var rates = server.GetRates();
            for (int i=0;i<rates.Count;i++)
                Console.WriteLine("{0,-5}{1,7}{2,7}", rates[i].Currency, rates[i].BuyRate, rates[i].SellRate);
            Console.ReadKey();
        }
    }
}
