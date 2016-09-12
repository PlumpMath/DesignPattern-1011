using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dress
{
    class Sneakers:Finery
    {
        public override void Show()
        {
            Console.WriteLine("运动鞋");
            base.Show();
        }
    }
}
