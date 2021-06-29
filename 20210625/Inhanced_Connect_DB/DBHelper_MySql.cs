using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhanced_Connect_DB
{
    class DBHelper_MySql : DBHelper
    {

        public MySqlConnection Myconn = new MySqlConnection();
        public MySqlDataAdapter da;
        public DataSet ds;

        public override void ConnectDB()
        {
            try
            {
                string pwd = "1234";
                string strConn = "Server=localhost;Database=test;Uid=root;Pwd=" + pwd + ";Charset=utf8";
                Myconn = new MySqlConnection(strConn);
                Myconn.Open();
            }
            catch (Exception e)
            {
            }
        }

        public override void Query_Select()
        {
            try
            {
                ConnectDB();

                string sql = "SELECT * FROM tb_cust";
                da = new MySqlDataAdapter();
                MySqlCommand cmd = Myconn.CreateCommand();
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "tb_cust");

                Myconn.Close();
            }
            catch (Exception e)
            {
            }
        }


        public override void Query_Insert(string cust_id, string birth_dt)
        {
            ConnectDB();
            //홑따옴표 들어가야 함
            string sqlcommand = $"Insert Into TB_CUST(CUST_ID, BIRTH_DT) values ('{cust_id}', '{birth_dt}')";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, Myconn);
            cmd.ExecuteNonQuery();

            Myconn.Close();
        }

        public override void Query_Update(string cust_id, string birth_dt)
        {
            ConnectDB();
            MySqlCommand cmd = new MySqlCommand("", Myconn);
            string sqlcommand = $"Update TB_CUST set CUST_ID={cust_id}, BIRTH_DT = {birth_dt} where CUST_ID = {cust_id}";
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            Myconn.Close();
        }

        public override void Query_Delete()
        {
            ConnectDB();

            string sqlcommand = "Delete from TB_CUST";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, Myconn);

            cmd.ExecuteNonQuery();

            Myconn.Close();
        }

    }
}
