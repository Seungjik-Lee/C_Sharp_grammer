using CustCar0415.Common;
using CustCar0415.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Util
{
    class MyMenu
    {
        public int getRandSize()
        {
            int size = 0;
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("랜덤 데이터 갯수 설정");
                Console.WriteLine("--------------------");
                Console.Write("갯수 입력 : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("getRandSize", e.Message);
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
                Console.Write("1.차종 : ");
                data[0] = Console.ReadLine();
                Console.Write("2.색상 : ");
                data[1] = Console.ReadLine();
                Console.Write("3.제조사 : ");
                data[2] = Console.ReadLine();
                Console.Write("4.가격 : ");
                data[3] = Console.ReadLine();
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("addCarMenu", e.Message);
            }
                return data;
        }

        public Car addCarMenu2()
        {
            Car car = null;
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Car 데이터 추가");
                Console.WriteLine("--------------------");
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
            catch (FormatException e)
            {
                CommonMenu.errMsg("addCarMenu2", e.Message);
            }
                return car;
        }

        public string delCarMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Car 데이터 삭제");
                Console.WriteLine("--------------------");
                Console.Write("삭제할 차량 모델을 입력 : ");
                return Console.ReadLine();
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("delCarMenu", e.Message);
                return delCarMenu();
            }
        }

        public string[] updateCarMenu()
        {
            try
            {
                string[] model = new string[2];
                Console.WriteLine("--------------------");
                Console.WriteLine("Car 데이터 수정");
                Console.WriteLine("--------------------");
                Console.Write("검색할 차량 모델을 입력 : ");
                model[0] = Console.ReadLine();
                Console.Write("변경할 차량 모델을 입력 : ");
                model[1] = Console.ReadLine();
                return model;
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("updateCarMenu", e.Message);
                return updateCarMenu();
            }
        }


        public Customer addCustMenu2()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("고객 데이터 추가");
                Console.WriteLine("--------------------");
                Console.Write("1.이름 : ");
                string name = Console.ReadLine();
                Console.Write("2.나이 : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("3.전화번호 : ");
                string tel = Console.ReadLine();
                Console.Write("4.주소 : ");
                string address = Console.ReadLine();
                Console.Write("5.성별 : ");
                char gender = Convert.ToChar(Console.ReadLine());
                return new Customer(name, age, tel, address, gender);
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("addCustMenu2", e.Message);
                return addCustMenu2();
            }
        }

        public string delCustMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("고객 데이터 삭제");
                Console.WriteLine("--------------------");
                Console.Write("삭제할 고객 이름을 입력 : ");
                return Console.ReadLine();
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("delCustMenu", e.Message);
                return delCustMenu();
            }

        }

        public string[] updateCustMenu()
        {
            try
            {
                string[] name = new string[2];
                Console.WriteLine("--------------------");
                Console.WriteLine("고객 이름 수정");
                Console.WriteLine("--------------------");
                Console.Write("검색할 고객 이름을 입력 : ");
                name[0] = Console.ReadLine();
                Console.Write("변경할 고객 이름을 입력 : ");
                name[1] = Console.ReadLine();
                return name;
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("updateCustMenu", e.Message);
                return updateCustMenu();
            }
        }


        public Seller addSellMenu2()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("판매자 데이터 추가");
                Console.WriteLine("--------------------");
                Console.Write("1.이름 : ");
                string name = Console.ReadLine();
                Console.Write("2.전화번호 : ");
                string tel = Console.ReadLine();
                Console.Write("3.직급 : ");
                string jikwi = Console.ReadLine();
                Console.Write("4.사무실 : ");
                string office = Console.ReadLine();
                return new Seller(name, tel, jikwi, office);
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("addSellMenu2", e.Message);
                return addSellMenu2();
            }
        }

        public string delSellMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("판매자 데이터 삭제");
                Console.WriteLine("--------------------");
                Console.Write("삭제할 판매자 이름을 입력 : ");
                return Console.ReadLine();
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("delSellMenu", e.Message);
                return delSellMenu();
            }
        }

        public string[] updateSellMenu()
        {
            try
            {
                string[] sellname = new string[2];
                Console.WriteLine("--------------------");
                Console.WriteLine("판매자 이름 수정");
                Console.WriteLine("--------------------");
                Console.Write("검색할 판매자 이름을 입력 : ");
                sellname[0] = Console.ReadLine();
                Console.Write("변경할 판매자 이름을 입력 : ");
                sellname[1] = Console.ReadLine();
                return sellname;
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("updateSellMenu", e.Message);
                return updateSellMenu();
            }
        }

        public int subAddMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("데이터 추가 선택");
                Console.WriteLine("--------------------");
                Console.WriteLine("1.차량 정보 추가");
                Console.WriteLine("2.고객 정보 추가");
                Console.WriteLine("3.판매자 정보 추가");
                Console.WriteLine("4.종료");
                Console.WriteLine("--------------------");
                Console.Write("추가메뉴 선택 : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("subAddMenu", e.Message);
                return subAddMenu();
            }

        }
        public int subDelMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("데이터 추가 선택");
                Console.WriteLine("--------------------");
                Console.WriteLine("1.차량 정보 삭제");
                Console.WriteLine("2.고객 정보 삭제");
                Console.WriteLine("3.판매자 정보 삭제");
                Console.WriteLine("4.종료");
                Console.WriteLine("--------------------");
                Console.Write("삭제메뉴 선택 : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("subDelMenu", e.Message);
                return subDelMenu();
            }
        }
        public int subUpdateMenu()
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("데이터 추가 선택");
                Console.WriteLine("--------------------");
                Console.WriteLine("1.차량 정보 수정");
                Console.WriteLine("2.고객 정보 수정");
                Console.WriteLine("3.판매자 정보 수정");
                Console.WriteLine("4.종료");
                Console.WriteLine("--------------------");
                Console.Write("수정메뉴 선택 : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommonMenu.errMsg("subUpdateMenu", e.Message);
                return subUpdateMenu();
            }
        }
    }
}