using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dress
{
    class Suit:Finery
    {
        public override void Show()
        {
            Console.WriteLine("西装");
             base.Show();
        }
    }
}
