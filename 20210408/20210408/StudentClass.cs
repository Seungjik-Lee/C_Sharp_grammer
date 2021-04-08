using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210408
{
    class StudentClass
    {
        private string name;
        private int age;
        private char gender;
        private string tel;
        private string addr;

        public StudentClass(string name, int age, char gender, string tel, string addr)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.tel = tel;
            this.addr = addr;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public void studentInfor()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("성별 : " + gender);
            Console.WriteLine("전화번호 : " + tel);
            Console.WriteLine("주소 : " + addr);
            Console.WriteLine("---------------------");
        }
    }
}
