using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternModel
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("Question1");
            Console.WriteLine("答案：" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("Question2");
            Console.WriteLine("答案：" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("Question3");
            Console.WriteLine("答案：" + Answer3());
        }

        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}
