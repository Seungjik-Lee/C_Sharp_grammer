using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWithClass
{
    class DataManager_Oracle
    {
        public static List<TB_CUST> tb_custs = new List<TB_CUST>();

        public static void Load()
        {
            DBHelper_Oracle.Query_Select();
            tb_custs.Clear();

            foreach (DataRow item in DBHelper_Oracle.ds.Tables[0].Rows)
            {
                TB_CUST temp = new TB_CUST();
                temp.cust_id = item["CUST_ID"].ToString();
                temp.birth_dt = item["BIRTH_DT"].ToString();
                tb_custs.Add(temp);
            }
        }

        public static void Save()
        {
            //DB 값을 싹 날린다.
            DBHelper_Oracle.Query_Delete();

            foreach (TB_CUST item in tb_custs)
            {
                DBHelper_Oracle.Query_Insert(item.cust_id, item.birth_dt);
            }
        }

    }
}
