using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borex
{
    public class Account
    {
        double[] deposits = new double[5];
        public double this[Currencies Currency]
        {
            get { return deposits[(int)Currency]; }
            set { deposits[(int)Currency] = value; }
        }
    }
}
