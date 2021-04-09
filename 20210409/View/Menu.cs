using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.View
{
    class Menu
    {
        public int mainMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("호갱 차량 관리 앱 v1.0");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. 랜덤데이터 생성");
            Console.WriteLine("2. 데이터 보기");
            Console.WriteLine("3. 데이터 추가");
            Console.WriteLine("4. 데이터 삭제");
            Console.WriteLine("5. 데이터 수정");
            Console.WriteLine("6. 종료");
            Console.WriteLine("----------------------");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
