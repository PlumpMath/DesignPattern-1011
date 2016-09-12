using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Boss:Subject
    {
        //声明一事件Update,类型为委托EventHander
        public event EventHandler Update;

        private string action;

        //通知
        public void Notify()
        {
            Update();
        }

        //老板状态
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
