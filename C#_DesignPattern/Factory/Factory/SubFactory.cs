using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class SubFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
