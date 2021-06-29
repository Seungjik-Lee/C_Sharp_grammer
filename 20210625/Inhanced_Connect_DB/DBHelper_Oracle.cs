using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhanced_Connect_DB
{
    class DBHelper_Oracle : DBHelper
    {


        //NUGET에서 ORACLE 검색해서 추가함
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=AI;Password=1234;";

        public DataSet ds;
        public OracleCommand cmd = new OracleCommand();
        public OracleConnection OraConn;
        public OracleDataAdapter da;


        public override void ConnectDB()
        {
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
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
                da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand();
                da.SelectCommand.Connection = OraConn;
                da.SelectCommand.CommandText = sql;
                ds = new DataSet();
                da.Fill(ds, "tb_cust");

                OraConn.Close();
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
            cmd.Connection = OraConn;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            OraConn.Close();
        }

        public override void Query_Update(string cust_id, string birth_dt)
        {
            ConnectDB();
            cmd.Connection = OraConn;
            string sqlcommand = $"Update TB_CUST set CUST_ID={cust_id}, BIRTH_DT = {birth_dt} where CUST_ID = {cust_id}";
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            OraConn.Close();
        }

        public override void Query_Delete()
        {
            ConnectDB();

            string sqlcommand = "Delete from TB_CUST";
            cmd.Connection = OraConn;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            OraConn.Close();
        }

    }
}
