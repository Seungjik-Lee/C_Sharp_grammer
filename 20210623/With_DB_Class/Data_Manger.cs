using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DB_Class
{
    class Data_Manger
    {
        public static List<TB_CUST> tB_CUSTs = new List<TB_CUST>();

        public static void Load()
        {
            DB_Helper.Query_Select();
            tB_CUSTs.Clear();

            foreach(DataRow item in DB_Helper.ds.Tables[0].Rows)
            {
                TB_CUST temp = new TB_CUST();
                temp.CUST_ID = item["CUST_ID"].ToString();
                temp.BIRTH_DT = item["BIRTH_DT"].ToString();
                tB_CUSTs.Add(temp);
            }
        }
        public static void Save()
        {
            //DB 값 날리기
            DB_Helper.Query_Delete();

            foreach (TB_CUST item in )
            {
                DB_Helper.Query_Insert(item.CUST_ID, item.BIRTH_DT);
            }
        }
    }
}
