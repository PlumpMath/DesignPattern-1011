using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ConcreteAggregate:Aggregate
    {
        private List<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        //声明一个索引器
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }


    }
}
