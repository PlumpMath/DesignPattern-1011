using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dress
{
    class Tie:Finery
    {
        public override void Show()
        {
            Console.WriteLine("领带");
            base.Show();
        }
    }
}
