using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210408
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass car = new CarClass("K8","Silver","KIA","5000만원");
            car.Model = "그랜저2020";
            Console.WriteLine("모델 : " + car.Model);
            car.printInforCar();

            CarClass car2 = new CarClass();
            car2.Model = "그랜저2021";
            car2.printInforCar();

            Console.WriteLine(new CarClass("G80", "Black", "Hyundai", "7000만원").ToString());
        }
    }
}
