using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class USA:Country
    {
        public USA(UnitedNations mediator)
            : base(mediator)
        { }

        //声明
        public void Declare(string message)
        {
            mediator.Declare(message,this);
        }

        //获得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方信息：" + message);
        }

    }
}
