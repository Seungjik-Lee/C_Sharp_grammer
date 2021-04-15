using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1.Model
{
    class Seller
    {
        private string name;
        private string tel;
        private string jikwi;
        private string office;

        public Seller(string name, string tel, 
            string jikwi, string office)
        {
            this.name = name;
            this.tel = tel;
            this.jikwi = jikwi;
            this.office = office;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Jikwi { get => jikwi; set => jikwi = value; }
        public string Office { get => office; set => office = value; }

        public void SellerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("직급: " + jikwi);
            Console.WriteLine("사무실: " + office);
        }

        public override string ToString()
        {
            string data = "이름: " + name + "\n";
            data += "전화: " + tel + "\n";
            data += "직급: " + jikwi + "\n";
            data += "사무실: " + office + "\n";
            return data;
        }
    }
}
