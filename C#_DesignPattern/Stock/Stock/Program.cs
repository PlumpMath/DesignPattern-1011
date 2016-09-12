using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.Buyfund();
            fund.SellFund();

            Console.Read();
        }
    }
}
