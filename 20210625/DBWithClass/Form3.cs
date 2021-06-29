﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            DataManager_Oracle.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager_Oracle.tb_custs;
        }
        private void button_select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

            TB_CUST temp = new TB_CUST();
            temp.cust_id = textBox1.Text;
            temp.birth_dt = textBox2.Text;
            DataManager_Oracle.tb_custs.Add(temp);
            DataManager_Oracle.Save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            try
            {
                TB_CUST temp = DataManager_Oracle.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                temp.birth_dt = textBox2.Text;
                DataManager_Oracle.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            try
            {
                //싱글은 pk 대상으로 해야 함
                //값이 두 개 들어 있으면 catch에서 걸림
                TB_CUST temp = DataManager_Oracle.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                DataManager_Oracle.tb_custs.Remove(temp);

                DataManager_Oracle.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
