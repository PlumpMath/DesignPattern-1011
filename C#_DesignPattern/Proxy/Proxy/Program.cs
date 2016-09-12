using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Proxy daili = new Proxy(jiaojiao);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();

            Console.Read();
        }
    }
}
