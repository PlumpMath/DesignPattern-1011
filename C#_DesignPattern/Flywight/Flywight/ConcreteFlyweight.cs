using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flywight
{
    class ConcreteFlyweight:Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体Flyweight："+extrinsicstate);
        }
    }
}
