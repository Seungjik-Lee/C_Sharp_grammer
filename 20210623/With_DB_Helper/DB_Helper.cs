using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DB_Helper
{
    class DB_Helper
    {
        public static SqlConnection conn = new SqlConnection();
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static DataTable dt;

        private DB_Helper instance;

        public DB_Helper getInstance()
        {
            if (instance == null)
                instance = new DB_Helper();

            return instance;
        }

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" + "Initial Catalog = {1};" + "Integrated Security = {2};" + "Timeout = 3", "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; //DB 접속 정보 추가
            //테이블에 날릴 쿼리 추가
            cmd.CommandText = "SELECT * FROM TB_CUST";

            //DB 접속해서 쿼리 날려서 결과값으로 받은 테이블 관련 정보
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "TB_CUST"); //da를 통해서 ds에 테이블 데이터를 넣는다.

            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }

        public static void Query_Insert(string CUST_ID, string BIRTH_DT)
        {
            ConnectDB();
            string sqlcommand = "INSERT INTO TB_CUST (CUST_ID, BIRTH_DT) VALUES (@parameter1, @parameter2)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", CUST_ID);
            cmd.Parameters.AddWithValue("@parameter2", BIRTH_DT);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }

        public static void Query_Update(string CUST_ID, string BIRTH_DT)
        {
            ConnectDB();
            string sqlcommand = "UPDATE TB_CUST SET CUST_ID=@parameter1, BIRTH_DT=@parameter2 WHERE CUST_ID=@parameter3";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", CUST_ID);
            cmd.Parameters.AddWithValue("@parameter2", BIRTH_DT);
            cmd.Parameters.AddWithValue("@parameter3", CUST_ID);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }

        public static void Query_Delete(string CUST_ID)
        {
            ConnectDB();
            string sqlcommand = "DELETE TB_CUST WHERE CUST_ID=@parameter1";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", CUST_ID);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }
    }
}
