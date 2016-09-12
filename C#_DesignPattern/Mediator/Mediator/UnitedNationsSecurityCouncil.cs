using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class UnitedNationsSecurityCouncil:UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        //美国
        public USA Colleague1
        { set { colleague1 = value; } }

        //伊拉克
        public Iraq Colleague2
        { set { colleague2 = value; } }

        //声明
        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
