using _20210409.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.View
{
    class Menu
    {
        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_DEL_ALL = 2;
        public const int MENU_MAIN_VIEW = 3;
        public const int MENU_MAIN_ADD = 4;
        public const int MENU_MAIN_DEL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public int mainMenu()
        {
            Console.WriteLine("====================");
            Console.WriteLine("고객차량관리 앱 v1.0");
            Console.WriteLine("====================");
            Console.WriteLine("1.랜덤데이터 생성");
            Console.WriteLine("2.모든 데이터 삭제");
            Console.WriteLine("3.데이터 보기");
            Console.WriteLine("4.데이터 추가");
            Console.WriteLine("5.데이터 삭제");
            Console.WriteLine("6.데이터 수정");
            Console.WriteLine("7.앱 종료");
            Console.WriteLine("====================");
            Console.Write("Main 메뉴 선택: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int getRandSize()
        {
            Console.WriteLine("====================");
            Console.WriteLine("랜덤 데이터 개수 설정");
            Console.WriteLine("====================");
            Console.WriteLine("개수 입력: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string[] addCarMenu()
        {

            string[] data = new string[4];
            Console.WriteLine("====================");
            Console.WriteLine("Car 데이터 추가");
            Console.WriteLine("====================");
            Console.Write("1.차종 : ");
            data[0] = Console.ReadLine();
            Console.Write("2.색상 : ");
            data[1] = Console.ReadLine();
            Console.Write("3.제조사 : ");
            data[2] = Console.ReadLine();
            Console.Write("4.가격 : ");
            data[3] = Console.ReadLine();
            return data;
        }

        public Car addCarMenu2()
        {

            Console.WriteLine("====================");
            Console.WriteLine("Car 데이터 추가");
            Console.WriteLine("====================");
            Console.Write("1.차종 : ");
            string model = Console.ReadLine();
            Console.Write("2.색상 : ");
            string color = Console.ReadLine();
            Console.Write("3.제조사 : ");
            string company = Console.ReadLine();
            Console.Write("4.가격 : ");
            string price = Console.ReadLine();
            return new Car(model, color, company, price);
        }
    }
}