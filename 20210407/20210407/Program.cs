using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407
{
    class Program
    {
        static void Main(string[] args)
        {
            //1차원 배열 초기화
            int[] arrlnt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrlnt.Length; i++)
            {
                Console.Write(arrlnt[i] + " ");
                string str = string.Format("배열[{0}]:{1}", i, arrlnt[i]);
                Console.WriteLine(str);
            }

            //1차원 배열 초기화2
            char[] arrCh = new char[4]
            {
                '김', '나', '박', '이'
            };
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
            }
        }
    }
}
