using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Ifactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
        }
    }
}
