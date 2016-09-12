using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class Proxy : GiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            this.gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

    }
}
