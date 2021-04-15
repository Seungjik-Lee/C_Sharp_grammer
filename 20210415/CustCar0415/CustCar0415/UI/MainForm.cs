using CustCar0415.Controll;
using CustCar0415.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415
{
    public partial class MainWin : MaterialForm
    {
        MyMenu mymenu = new MyMenu();
        UnionController uHandler = new UnionController(new RandData());

        public MainWin()
        {
            InitializeComponent();
        }

        private void RandDataAdd_Click(object sender, EventArgs e)
        {

        }

        private void DataDelete_Click(object sender, EventArgs e)
        {

        }

        private void DataView_Click(object sender, EventArgs e)
        {

        }

        private void DataAdd_Click(object sender, EventArgs e)
        {

        }

        private void DataUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리프로그램 V1.0 \n" + "2021년 4월 15일 By 이승직");
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
