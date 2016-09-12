using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace Abstract_Factory
{
    class DataAccess
    {
        private static readonly string AssemblyName = "Abstract_Factory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static Iuser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (Iuser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
