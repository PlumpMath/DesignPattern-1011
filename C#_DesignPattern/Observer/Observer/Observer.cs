using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    abstract class Observer
    {
        protected string name;
        protected Subject sub;

        public Observer(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
