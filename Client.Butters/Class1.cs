using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Borex;

public class Program
{
    public static void Main()
    {
        var server = new BorexServer();
        var account = new Account();
        account[Currencies.USD] = 100;
        server.Exchange(account, Currencies.USD, Currencies.EUR, 50);
        Console.ReadKey();
    }

}