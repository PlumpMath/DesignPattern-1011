﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_V2
{
    class RealSubject:Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}
