using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsibility
{
    class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandlerRequest(int resquest);
    }
}
