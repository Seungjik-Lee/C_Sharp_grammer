using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1.Common
{
    class CommMenu
    {
        public static void errMsg(string path, string msg) //위치 , 에러타입
        {
            string str = string.Format("[{0}]:{1}", path, msg);
            Console.WriteLine(str);
        }
    }
}
