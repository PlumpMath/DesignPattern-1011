using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class HRDepartment:Company
    {
        public HRDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            Console.WriteLine("Cannot add to action leaf HRDepartment");
        }

        public override void Remove(Company c)
        {
            Console.WriteLine("Cannot remove from a leaf HRDepartment");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0}员工招聘培训管理", name);
        }
    }
}
