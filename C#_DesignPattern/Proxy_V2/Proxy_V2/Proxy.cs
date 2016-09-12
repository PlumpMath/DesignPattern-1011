using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_V2
{
    class Proxy
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
