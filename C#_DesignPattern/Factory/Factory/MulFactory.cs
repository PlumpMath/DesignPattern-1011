using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class MulFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
