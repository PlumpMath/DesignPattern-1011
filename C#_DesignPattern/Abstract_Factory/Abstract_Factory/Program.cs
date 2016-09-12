using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            Iuser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            //IFactory factory = new SqlserverFactory();
            //IFactory factory = new AccessFactory();




            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
