﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    interface IFactory
    {
        Iuser CreateUser();
        IDepartment CreateDepartment();
    }
}
