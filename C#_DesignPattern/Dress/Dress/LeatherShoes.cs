using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dress
{
    class LeatherShoes:Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
            base.Show();
        }
    }
}
