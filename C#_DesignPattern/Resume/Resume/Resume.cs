using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Resume
{
    [Serializable]
    class Resume
    {
        private string name;
        private string sex;
        private string age;
        //private string timeArea;
        //private string company;

        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        public Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        //设置个人信息
        public void SetPersonalInfo(string sex,string age)
        {
            this.age = age;
            this.sex = sex;
        }

        //设置工作经历
        public void SetWorkExperience(string workDate, string company)
        {
            work.workDate = workDate;
            work.Company = company;
        }

        //显示
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0} {1}", work.workDate, work.Company);
        }

        public Object Clone()
        {
            /*Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;*/

            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as Resume;


        }
    }
}
