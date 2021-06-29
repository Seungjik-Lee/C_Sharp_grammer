using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhanced_Connect_DB
{
    interface ICRUD
    {
        void Query_Select();
        void Query_Insert(string CUST_ID, string BIRTH_DT);
        void Query_Update(string CUST_ID, string BIRTH_DT);
        void Query_Delete();

    }
}
