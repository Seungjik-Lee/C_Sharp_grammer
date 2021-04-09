using _20210409.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Car().ToString());
            new Customer("고길동", 100, "010-1111-1111", "서울 턱별시", '남').CustomerInfo();
            Console.WriteLine();

            Console.WriteLine("영업소 : " + Seller.CENTER);
            new Seller("김준석", 28, "사장").sellerinfo();
        }
    }
}
