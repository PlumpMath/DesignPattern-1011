using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class SqlserverFactory:IFactory
    {
        public Iuser CreateUser()
        {
            return new SqlserverUser();
        }

        public IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }
    }
}
