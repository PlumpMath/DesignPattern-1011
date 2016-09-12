using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不为0。");
            result = NumberA / NumberB;
            return result;
        }
    }
}
