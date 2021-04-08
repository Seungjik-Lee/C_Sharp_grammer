using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210408
{
    class CarClass
    {
        public const string CENTER = "동대구 영업소";
        private string model;
        private string color;
        private string company;
        private string price;

        public CarClass()
        {
        }

        public CarClass(string model, string color, string company, string price)
        {
            this.model = model;
            this.color = color;
            this.company = company;
            this.price = price;
        }

        //필드 캡슐화(여전히 필드를 사용함)
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Price { get => price; set => price = value; }

        public void printInforCar()
        {
            Console.WriteLine("모델 : " + model);
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("가격 : " + price);
            Console.WriteLine("---------------------");
        }

        public override string ToString()
        {
            string str = "모델 : " + model + "\n";
            str += "제조사 : " + company + "\n";
            str += "색상 : " + color + "\n";
            str += "가격 : " + price + "\n";
            return str;
        }
    }
}
