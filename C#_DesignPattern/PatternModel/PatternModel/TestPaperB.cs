using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternModel
{
    class TestPaperB:TestPaper
    {
        public new void TestQuestion1()
        {
            base.TestQuestion1();
            Console.WriteLine("答案：" + Answer1());
        }
        public new void TestQuestion2()
        {
            base.TestQuestion2();
            Console.WriteLine("答案：" + Answer2());
        }
        public new void TestQuestion3()
        {
            base.TestQuestion3();
            Console.WriteLine("答案：" + Answer3());
        }
    }
}
