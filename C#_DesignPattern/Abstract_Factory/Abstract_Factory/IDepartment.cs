using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
