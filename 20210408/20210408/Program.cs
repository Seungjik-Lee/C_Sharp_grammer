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
            //CarClass
            /*
            Console.WriteLine("영업소 : " + CarClass.CENTER);
            CarClass car = new CarClass("K8","Silver","KIA","5000만원");
            car.Model = "그랜저2020";
            Console.WriteLine("모델 : " + car.Model);
            car.printInforCar();

            Console.WriteLine("영업소 : " + CarClass.CENTER);
            CarClass car2 = new CarClass();
            car2.Model = "그랜저2021";
            car2.printInforCar();

            Console.WriteLine("영업소 : " + CarClass.CENTER);
            Console.WriteLine(new CarClass("G80", "Black", "Hyundai", "7000만원").ToString());
            */

            //StudentClass
            string[] name = { "고길동", "둘리", "또치", "도우너", "마이콜" };
            int[] age = { 50, 900, 900, 900, 25 };
            char[] gender = { '남', '여' };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] addr = { "서울", "대전", "대구", "부산", "울산" };

            //0~2
            /*
            Random r = new Random();
            Console.WriteLine(r.Next(3));
            */

            Random r = new Random();
            StudentClass[] st = new StudentClass[10];
            List<StudentClass> list = new List<StudentClass>();
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new StudentClass(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]);
                st[i].studentInfor();
                list.Add(new StudentClass(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]));
                list[i].studentInfor();
            }

            menu();

        }

        public static void menu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. 학생정보 생성");
            Console.WriteLine("2. 학생정보 출력");
            Console.WriteLine("3. 종료");
            Console.WriteLine("-------------------------------------");
        }
    }
}
