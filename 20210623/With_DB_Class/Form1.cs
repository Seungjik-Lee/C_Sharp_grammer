using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace With_DB_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            Data_Manger.Load();
            dataGridView1.DataSource = Data_Manger.tB_CUSTs;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            TB_CUST temp = new TB_CUST();
            temp.CUST_ID = textBox1.Text;
            temp.BIRTH_DT = textBox2.Text;
            Data_Manger.tB_CUSTs.Add(temp);
            Data_Manger.Save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
