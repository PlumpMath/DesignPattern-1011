using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class RoleStateCaretakercs
    {
        private RoleStateMemento memento;

        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
