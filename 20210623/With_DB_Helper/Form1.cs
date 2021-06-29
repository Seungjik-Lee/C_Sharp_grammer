using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace With_DB_Helper
{
    public partial class Form1 : Form
    {
        DB_Helper dh; 

        public Form1()
        {
            InitializeComponent();
            dh = new DB_Helper().getInstance();
        }

        private void DB_Select()
        {
            DB_Helper.Query_Select();
            dataGridView1.DataSource = DB_Helper.ds;
            dataGridView1.DataMember = "TB_CUST";
        }

        private void DB_Select_Instance()
        {

        }

        private void DB_Insert()
        {
            DB_Helper.Query_Insert(textBox1.Text, textBox2.Text);
        }

        private void DB_Update()
        {
            DB_Helper.Query_Update(textBox1.Text, textBox2.Text);
        }

        private void DB_Delete()
        {
            DB_Helper.Query_Delete(textBox1.Text);
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            //DB_Select();
            DB_Select_Instance();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            DB_Delete();
            DB_Select();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DB_Delete();
            DB_Select();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DB_Delete();
            DB_Select();
        }
    }
}
