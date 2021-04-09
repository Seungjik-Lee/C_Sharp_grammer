using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.Model
{
    class Seller
    {
        public const string CENTER = "계머";
        private string name;
        private int age;
        private string position;

        public Seller(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Position { get => position; set => position = value; }

        public void sellerinfo()
        {
            Console.WriteLine("판매자 이름 : " + name);
            Console.WriteLine("판매자 나이 : " + age);
            Console.WriteLine("판매자 직급 : " + position);
        }

        public override string ToString()
        {
            string sellerdata = "이름 : " + name + "\n";
            sellerdata += "나이 : " + age + "\n";
            sellerdata += "직급 : " + position + "\n";
            return sellerdata;
        }
    }
}
