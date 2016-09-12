using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class FinanceDepartment:Company
    {
        public FinanceDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            Console.WriteLine("Cannot add to action leaf FinanceDepartment");
        }

        public override void Remove(Company c)
        {
            Console.WriteLine("Cannot remove from a leaf FinanceDepartment");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }
    }
}
