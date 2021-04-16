using CustCar0415_2.Common;
using CustCar0415_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415_2.Util
{
    class MyMenu
    {
        #region 1. 메뉴 상수 정의
        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_DEL_ALL = 2;
        public const int MENU_MAIN_VIEW = 3;
        public const int MENU_MAIN_ADD = 4;
        public const int MENU_MAIN_DEL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public const int MENU_SUB_ADD_CAR = 1;
        public const int MENU_SUB_ADD_CUST = 2;
        public const int MENU_SUB_ADD_SELL = 3;
        public const int MENU_SUB_ADD_EXIT = 4;

        public const int MENU_SUB_DEL_CAR = 1;
        public const int MENU_SUB_DEL_CUST = 2;
        public const int MENU_SUB_DEL_SELL = 3;
        public const int MENU_SUB_DEL_EXIT = 4;

        public const int MENU_SUB_UP_CAR = 1;
        public const int MENU_SUB_UP_CUST = 2;
        public const int MENU_SUB_UP_SELL = 3;
        public const int MENU_SUB_UP_EXIT = 4;
        #endregion

        #region 2. 메인 메뉴
        public int mainMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("고객차량관리 앱 v1.0");
                Console.WriteLine("--------------------");
                Console.WriteLine("1.랜덤데이터 생성");
                Console.WriteLine("2.모든 데이터 삭제");
                Console.WriteLine("3.데이터 보기");
                Console.WriteLine("4.데이터 추가");
                Console.WriteLine("5.데이터 삭제");
                Console.WriteLine("6.데이터 수정");
                Console.WriteLine("7.앱 종료");
                Console.WriteLine("--------------------");
                Console.Write("Main메뉴 선택: ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.errMsg("mainMenu", e.Message);
            }
            return menu;
        }
        #endregion

        public int getRandSize()
        {
            int size = 0;
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("랜덤 데이터 갯수 설정");
                Console.WriteLine("--------------------");
                Console.Write("갯수 입력: ");
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.errMsg("getRandSize", e.Message);
            }
            return size;
        }

        public string[] addCarMenu()
        {
            string[] data = new string[4];
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Car 데이터 추가");
                Console.WriteLine("--------------------");
                Console.Write("1.차종: ");
                data[0] = Console.ReadLine();
                Console.Write("2.색상: ");
                data[1] = Console.ReadLine();
                Console.Write("3.제조사: ");
                data[2] = Console.ReadLine();
                Console.Write("4.가격: ");
                data[3] = Console.ReadLine();
            }
            catch (FormatException e)
            {
                CommMenu.errMsg("addCarMenu", e.Message);
            }
            return data;
        }

        public Car addCarMenu2()
        {
            Car car = null;
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("차량 데이터 추가");
                Console.WriteLine("--------------------");
                Console.Write("1.차종: ");
                string model = Console.ReadLine();
                Console.Write("2.색상: ");
                string color = Console.ReadLine();
                Console.Write("3.제조사: ");
                string company = Console.ReadLine();
                Console.Write("4.가격: ");
                string price = Console.ReadLine();
                car = new Car(model, color, company, price);
            }
            catch (FormatException e)
            {
                CommMenu.errMsg("addCarMenu2", e.Message);
            }
            return car;
        }

        public string delCarMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("차량 데이터 삭제");
            Console.WriteLine("--------------------");
            Console.Write("삭제할 차량 모델을 입력: ");
            return Console.ReadLine();
        }

        public string[] updateCarMenu()
        {
            string[] model = new string[2];
            Console.WriteLine("--------------------");
            Console.WriteLine("차량 데이터 수정");
            Console.WriteLine("--------------------");
            Console.Write("검색할 차량 모델을 입력: ");
            model[0] = Console.ReadLine();
            Console.Write("변경할 차량 모델을 입력: ");
            model[1] = Console.ReadLine();
            return model;
        }

        public Customer addCustMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("고객 데이터 추가");
            Console.WriteLine("--------------------");
            Console.Write("1.이름: ");
            string name = Console.ReadLine();
            Console.Write("2.나이: ");
            int age =
                Convert.ToInt32(Console.ReadLine());
            Console.Write("3.전화: ");
            string tel = Console.ReadLine();
            Console.Write("4.주소: ");
            string addr = Console.ReadLine();
            Console.Write("5.성별: ");
            char gender =
                Convert.ToChar(Console.ReadLine());
            return new Customer(name, age,
                tel, addr, gender);
        }

        public string delCustMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("고객 데이터 삭제");
            Console.WriteLine("--------------------");
            Console.Write("삭제할 고객 이름을 입력하세요: ");
            return Console.ReadLine();
        }

        public string[] updateCustMenu()
        {
            string[] name = new string[2];
            Console.WriteLine("--------------------");
            Console.WriteLine("고객 데이터 수정");
            Console.WriteLine("--------------------");
            Console.Write("검색할 고객 이름을 입력: ");
            name[0] = Console.ReadLine();
            Console.Write("변경할 고객 이름을 입력: ");
            name[1] = Console.ReadLine();
            return name;
        }

        public Seller addSellMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("판매자 데이터 추가");
            Console.WriteLine("--------------------");
            Console.Write("1.이름: ");
            string name = Console.ReadLine();
            Console.Write("2.전화: ");
            string tel = Console.ReadLine();
            Console.Write("3.직급: ");
            string jikwi = Console.ReadLine();
            Console.Write("4.사무실: ");
            string office = Console.ReadLine();
            return new Seller(name, tel, jikwi, office);
        }

        public string delSellMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("판매자 데이터 삭제");
            Console.WriteLine("--------------------");
            Console.Write("삭제할 판매자 이름을 입력하세요: ");
            return Console.ReadLine();
        }

        public string[] updateSellMenu()
        {
            string[] name = new string[2];
            Console.WriteLine("--------------------");
            Console.WriteLine("판매자 데이터 수정");
            Console.WriteLine("--------------------");
            Console.Write("검색할 판매자 이름을 입력: ");
            name[0] = Console.ReadLine();
            Console.Write("변경할 판매자 이름을 입력: ");
            name[1] = Console.ReadLine();
            return name;
        }

        public int subAddMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("데이터 추가 선택");
            Console.WriteLine("--------------------");
            Console.WriteLine("1.차량 정보 추가");
            Console.WriteLine("2.고객 정보 추가");
            Console.WriteLine("3.판매자 정보 추가");
            Console.WriteLine("4.종료");
            Console.WriteLine("--------------------");
            Console.Write("추가 메뉴 선택: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int subDelMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("데이터 삭제 선택");
            Console.WriteLine("--------------------");
            Console.WriteLine("1.차량 정보 삭제");
            Console.WriteLine("2.고객 정보 삭제");
            Console.WriteLine("3.판매자 정보 삭제");
            Console.WriteLine("4.종료");
            Console.WriteLine("--------------------");
            Console.Write("삭제 메뉴 선택: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int subUpdateMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("데이터 수정 선택");
            Console.WriteLine("--------------------");
            Console.WriteLine("1.차량 정보 수정");
            Console.WriteLine("2.고객 정보 수정");
            Console.WriteLine("3.판매자 정보 수정");
            Console.WriteLine("4.종료");
            Console.WriteLine("--------------------");
            Console.Write("수정 메뉴 선택: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
