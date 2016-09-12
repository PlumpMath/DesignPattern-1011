using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    abstract class Country
    {
        protected UnitedNations mediator;

        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }
}
