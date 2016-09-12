using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Resume
{
    [Serializable]
    class WorkExperience
    {
        private string workdate;
        public string workDate
        {
            get {return workdate;}
            set {workdate = value;}
        }
        private string company;
        public string Company
        {
            get {return company;}
            set {company = value;}
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
