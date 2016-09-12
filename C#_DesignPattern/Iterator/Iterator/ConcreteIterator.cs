using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ConcreteIterator:Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            current++;
            object ret = null;
            if (current < aggregate.Count)
                ret =  aggregate[current];

            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count?true:false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

    }
}
