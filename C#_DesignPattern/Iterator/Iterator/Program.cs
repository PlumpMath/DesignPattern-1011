using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "11";
            a[1] = "22";
            a[2] = "33";
            a[3] = "44";
            a[4] = "55";
            a[5] = "66";

            Iterator i = new ConcreteIteratorDesc(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0}请买车票！",i.CurrentItem());
                i.Next();
            }

            Console.Read();
        }
    }
}
