using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.Util
{
    class RandData
    {
        string[] name = { "김길동", "고길동", "박길동", "이길동", "최길동"};
        int[] age = { 10, 20, 30, 40, 50};
        string[] tel = { "010-0000-0000", "010 - 1111 - 1111", "010 - 2222 - 2222", "010 - 3333 - 3333", "010 - 4444 - 4444" };
        string[] addr = { "서울", "대구", "부산", "인천", "대전" };
        char[] gender = { '남', '여' };


        string[] position = { "사원", "대리", "과장", "차장", "부장" };
        string[] office = { "동대구 영업소", "서대구 영업소", "남대구 영업소", "북대구 영업소", "중대구 영업소" };


        string[] model = { "티코", "모닝", "마티즈", "포터", "스파크" };
        string[] color = { "노랑", "빨강", "하양", "검정", "회색" };
        string[] price = { "1억", "2억", "3억", "4억", "5억" };
        string[] company = { "람보르기니", "벤틀리", "부가티", "롤스로이스", "포르쉐" };

        Random random = new Random();

        public string getName()
        {
            return name[random.Next(5)];
        }

        public int getage()
        {
            return age[random.Next(5)];
        }

        public string gettel()
        {
            return tel[random.Next(5)];
        }

        public string getaddr()
        {
            return addr[random.Next(5)];
        }

        public char getgender()
        {
            return gender[random.Next(5)];
        }

        public string getposition()
        {
            return position[random.Next(5)];
        }

        public string getoffice()
        {
            return office[random.Next(5)];
        }

        public string getmodel()
        {
            return model[random.Next(5)];
        }

        public string getcolor()
        {
            return color[random.Next(5)];
        }

        public string getprice()
        {
            return price[random.Next(5)];
        }

        public string getcompany()
        {
            return company[random.Next(5)];
        }
    }
}
