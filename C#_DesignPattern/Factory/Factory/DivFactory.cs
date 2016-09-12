using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class DivFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
