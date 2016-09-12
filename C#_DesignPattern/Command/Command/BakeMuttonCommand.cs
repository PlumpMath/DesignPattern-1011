using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class BakeMuttonCommand:Command
    {
        public BakeMuttonCommand(Barbecuer receiver)
            : base(receiver)
        { }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
