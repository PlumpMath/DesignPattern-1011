using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h1.SetSuccessor(h3);

            int[] requests = { 2,5,14,22,18,3,27,20};

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }

            Console.Read();
        }
    }
}
