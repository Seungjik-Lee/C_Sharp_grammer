using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Student
    {
        public Student(string name, int age, string hakbeon, string hakgwa, string gender)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
            this.gender = gender;
        }

        //이름, 나이, 학번, 학과, 성별
        public string name { get; set; }
        public int age { get; set; }
        public string hakbeon { get; set; }
        public string hakgwa { get; set; }
        public string gender { get; set; }

        //c# 스타일 get, set
        /*private string hakgwa;
        public string _hakgwa
        {
            get { return hakgwa; }
            set { hakgwa = value; }
        }*/
    }
}
