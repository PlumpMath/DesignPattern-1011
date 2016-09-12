using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Copy_example
{
    [Serializable]
    class DemoClass
    {
        public int i = 0;
        public int[] iArr = {1,2,3};

        public DemoClass Shallow_copy()
        {
            return this.MemberwiseClone() as DemoClass;
        }

        public DemoClass Deep_clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as DemoClass;
        }
    }
}
