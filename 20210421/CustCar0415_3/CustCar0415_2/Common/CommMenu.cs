using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415_2.Common
{
    class CommMenu
    {
        public const int OLD_MODEL = 0;
        public const int NEW_MODEL = 1;

        public static void errMsg(string path,
            string msg)
        {
            string str =
                string.Format("[{0}]:{1}", path, msg);
            Console.WriteLine(str);
        }
    }
}
