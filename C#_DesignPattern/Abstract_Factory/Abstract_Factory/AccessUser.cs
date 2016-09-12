﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class AccessUser:Iuser
    {
        public override void Insert(User user)
        {
            Console.WriteLine("在Access中给User表增加一条记录");
        }

        public override User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID得到User表一条记录");
            return null;
        }
    }
}
