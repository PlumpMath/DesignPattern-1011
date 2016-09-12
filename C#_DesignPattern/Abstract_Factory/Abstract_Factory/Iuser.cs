using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    abstract class Iuser
    {
        public abstract void Insert(User user);
        public abstract User GetUser(int id);
    }
}
