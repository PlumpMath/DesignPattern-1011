using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    delegate void EventHandler();

    interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
}
