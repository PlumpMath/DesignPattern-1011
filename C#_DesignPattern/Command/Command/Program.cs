using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer boy = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);
            Waiter girl = new Waiter();

            //开店营业
            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenWingCommand1);
            girl.Notify();

            Console.Read();
        }
    }
}
