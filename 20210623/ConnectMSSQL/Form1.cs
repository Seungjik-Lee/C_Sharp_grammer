using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectMSSQL
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection();

        private void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" + "Initial Catalog = {1};" + "Integrated Security = {2};" + "Timeout = 3", "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        private void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; //DB 접속 정보 추가
            //테이블에 날릴 쿼리 추가
            cmd.CommandText = "SELECT * FROM TB_CUST";

            //DB 접속해서 쿼리 날려서 결과값으로 받은 테이블 관련 정보
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TB_CUST"); //da를 통해서 ds에 테이블 데이터를 넣는다.

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }

        private void Query_Insert()
        {
            ConnectDB();
            string sqlcommand = "INSERT INTO TB_CUST (CUST_ID, BIRTH_DT) VALUES (@parameter1, @parameter2)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", textBox1.Text);
            cmd.Parameters.AddWithValue("@parameter2", textBox2.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }

        private void Query_Update()
        {
            ConnectDB();
            string sqlcommand = "UPDATE TB_CUST SET CUST_ID=@parameter1, BIRTH_DT=@parameter2 WHERE CUST_ID=@parameter3";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", textBox1.Text);
            cmd.Parameters.AddWithValue("@parameter2", textBox2.Text);
            cmd.Parameters.AddWithValue("@parameter3", textBox1.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }

        private void Query_Delete()
        {
            ConnectDB();
            string sqlcommand = "DELETE TB_CUST WHERE CUST_ID=@parameter1";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //Colum 명은 별도의 파라메터 형태로 선언
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예) + 나 ' 기호를 이용한 공격

            cmd.Parameters.AddWithValue("@parameter1", textBox1.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행

            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            Query_Select();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Query_Insert();
            Query_Select();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Query_Update();
            Query_Select();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Query_Delete();
            Query_Select();
        }
    }
}
