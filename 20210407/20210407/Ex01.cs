using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407
{
    class Ex01
    {
        static void Main(string[] args)
        {
            //10진수를 입력받아 2진수로 출력하는 프로그램
            /*
             *1. 입력 받는 값의 범위는 1~65535까지
             *2. int 배열크기를 16으로 사용하여 한개의 공간에 2진수 0,1 저장
             *3. 10진수 값을 2진수로 변경할 때 비트 범위에 맞게 출력
             *--> 8을 입력하면 00001000
             *--> 255를 입력하면 0000000100000000
             *--> 65535 입력하면 1111111111111111
             */
            /*
            Console.Write("정보 입력 : ");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            Console.Write("숫자 입력 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            */

            for (int i = 0; ; i++)
            {
                Console.Write("숫자 입력 : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
                Console.WriteLine("{0}", Convert.ToString(num, 2).PadLeft(16, '0'));
            }
        }
    }
}
