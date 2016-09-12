using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class ConcreteCompany:Company
    {
        public List<Company>Subcompany = new List<Company>();

        public ConcreteCompany(string name)
            :base(name)
        { }

        public override void Add(Company c)
        {
            Subcompany.Add(c);
        }

        public override void Remove(Company c)
        {
            Subcompany.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Company company in Subcompany)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company component in Subcompany)
            {
                component.LineOfDuty();
            }
        }
    }
}
