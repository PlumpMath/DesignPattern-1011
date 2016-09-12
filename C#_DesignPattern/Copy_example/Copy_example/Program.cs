using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copy_example
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass a = new DemoClass();
            a.i = 10;
            a.iArr = new int[] {8,9,10};
            DemoClass b = a.Shallow_copy();
            DemoClass c = a.Deep_clone();
            a.iArr[0] = 88;

            Console.WriteLine("MemberwiseClone");
            Console.WriteLine(b.i);

            foreach (var item in b.iArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Deep Clone");
            Console.WriteLine(c.i);
            foreach (var item in c.iArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
