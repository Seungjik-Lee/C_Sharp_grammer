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

            //0~2
            /*
            Random r = new Random();
            Console.WriteLine(r.Next(3));
            */

            //StudentClass
            /*
            string[] name = { "고길동", "둘리", "또치", "도우너", "마이콜" };
            int[] age = { 50, 900, 900, 900, 25 };
            char[] gender = { '남', '여' };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] addr = { "서울", "대전", "대구", "부산", "울산" };

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
            */

            //학생관리 프로그램
            const int MAIN_MENU_INSERT = 1;
            const int MAIN_MENU_VIEW = 2;
            const int MAIN_MENU_ADD = 3;
            const int MAIN_MENU_UPDATE = 4;
            const int MAIN_MENU_DELETE = 5;
            const int MAIN_MENU_EXIT = 6;

            Random r = new Random();
            string[] name = { "고길동", "둘리", "또치", "도우너", "마이콜" };
            int[] age = { 50, 900, 900, 900, 25 };
            char[] gender = { '남', '여' };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] addr = { "서울", "대전", "대구", "부산", "울산" };

            StudentClass[] st = new StudentClass[10];
            List<StudentClass> list = new List<StudentClass>();

            while (true)
            {
                switch (menu())
                {
                    case MAIN_MENU_INSERT:
                        int size = getRandSize();
                        st = new StudentClass[size];
                        createRandomdata(st, name, age, gender, tel, addr, r); //랜덤 데이터 생성
                        break;
                    case MAIN_MENU_VIEW:
                        if (st != null)
                        {
                            dataView2(st); //데이터 출력
                        }
                        break;
                    case MAIN_MENU_ADD:
                        break;
                    case MAIN_MENU_UPDATE:
                        break;
                    case MAIN_MENU_DELETE:
                        break;
                    case MAIN_MENU_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        //콘솔 프로그램 종료
        /* 
         * Environment.Exit(0);
         */
        public static int menu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. 학생정보 생성");
            Console.WriteLine("2. 학생정보 출력");
            Console.WriteLine("3. 학생정보 추가");
            Console.WriteLine("4. 학생정보 수정");
            Console.WriteLine("5. 학생정보 삭제");
            Console.WriteLine("6. 종료");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.Write("메뉴 선택: ");
            int menunum = Convert.ToInt32(Console.ReadLine());
            return menunum;
        }

        public static int getRandSize()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("랜덤 데이터 생성 크기");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("크기 입력 : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static void createRandomdata(StudentClass[] st, string[] name, int[] age, char[] gender, string[] tel, string[] addr, Random r)
        {
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new StudentClass(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]);
            }
                Console.WriteLine("정상적으로 데이터가 처리 되었습니다.");
        }

        public static void dataView(StudentClass[] s)
        {
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s[i].studentInfor();
                } //데이터 출력
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("생성된 데이터가 없습니다.");
                Console.WriteLine(e.Message);
            }
        }

        public static void dataView2(StudentClass[] s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                s[i].studentInfor();
            } //데이터 출력

        }
    }
}
