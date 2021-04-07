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
            //1차원 배열 초기화1
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i] + " ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
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
            Console.WriteLine();

            //2차원 배열 초기화1
            int[,] arrInt2 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화2
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt3 = new int[SIZE_ROW, SIZE_COL]
            {
                {10, 20, 30},
                {40, 50, 60}
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_ROW; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화3
            string[][] arrStr1 = new string[2][];
            arrStr1[0] = new string[] { "홍길동", "김길동", "박길동" };
            arrStr1[1] = new string[] { "전우치" };
            for (int i = 0; i < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1[i].Length; j++)
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
