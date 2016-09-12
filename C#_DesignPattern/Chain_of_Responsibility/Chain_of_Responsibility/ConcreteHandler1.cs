using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsibility
{
    class ConcreteHandler1:Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0}处理请求{1}",this.GetType().Name,request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}
