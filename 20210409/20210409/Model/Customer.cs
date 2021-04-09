﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.Model
{
    class Customer
    {
        private string name;
        private int age;
        private string tel;
        private string address;
        private char gender;

        public Customer(string name, int age, string tel, string address, char gender)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.address = address;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public char Gender { get => gender; set => gender = value; }

        public void CustomerInfo()
        {
            Console.WriteLine("호갱 이름 : " + name);
            Console.WriteLine("호갱 나이 : " + age);
            Console.WriteLine("호갱 번호 : " + tel);
            Console.WriteLine("호갱 주소 : " + address);
            Console.WriteLine("호갱 성별 : " + gender);
        }

        public override string ToString()
        {
            string data = "이름" + name + "\n";
            data += "나이" + age + "\n";
            data += "성별" + gender + "\n";
            data += "번호" + tel + "\n";
            data += "주소" + address + "\n";
            return data;
        }
    }
}
