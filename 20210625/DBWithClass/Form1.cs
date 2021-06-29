using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWithClass
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
            DataManager.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.tb_custs;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                TB_CUST temp = DataManager.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                //DataManager.tb_custs.Remove(temp);
                temp.birth_dt = textBox2.Text;
                DataManager.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            int a = 100;
            int b = a;
            b = 1;

            TB_CUST t = new TB_CUST();
            t.cust_id = "a";
            t.birth_dt = "b";
            TB_CUST t2 = t;
            t2.cust_id = "c";
           // MessageBox.Show(t.cust_id);

            //Single 사용 방법(람다 써야 함)

            try
            {
                //싱글은 pk 대상으로 해야 함
                //값이 두 개 들어 있으면 catch에서 걸림
                TB_CUST temp = DataManager.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                DataManager.tb_custs.Remove(temp);

                //이런거 안 됨

                //TB_CUST test = new TB_CUST();
                //test.cust_id = "aaa";
                //test.birth_dt = "bbb";
               //DataManager.tb_custs.Remove(test);



                DataManager.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            TB_CUST temp = new TB_CUST();
            temp.cust_id = textBox1.Text;
            temp.birth_dt = textBox2.Text;
            DataManager.tb_custs.Add(temp);
            DataManager.Save();
            DataLoad();
        }

        private void button_mysql_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button_oracle_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
