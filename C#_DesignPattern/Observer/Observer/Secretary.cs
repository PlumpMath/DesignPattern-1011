using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Secretary:Subject
    {
        private string action;

        //声明一事件Update,类型为委托EventHander
        public event EventHandler Update;

        //通知
        public void Notify()
        {
            Update();
        }

        //前台状态
        public string SubjectState
        {
            get{return action;}
            set{action = value;}
        }
    }
}
