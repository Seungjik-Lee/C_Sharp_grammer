using CustCar0415_2.Controll;
using CustCar0415_2.Util;
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

namespace CustCar0415_2
{
    public partial class MainWin : MaterialForm
    {
        MyMenu menu = new MyMenu();
        UnionController uHandler =
            new UnionController(new RandData());

        public MainWin()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" +
                "2011년4월15일 by PARK.SS");
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
