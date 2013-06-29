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
            foreach(var e in server.GetRates())
                Console.WriteLine("{0,-5}{1,7}{2,7}", e.Currency, e.ExchangeRate, e.Growth);
            Console.ReadKey();
        }
    }
}
