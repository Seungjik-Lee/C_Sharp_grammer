using CustCar0415.Controll;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    public partial class AddData : MaterialForm
    {
#pragma warning disable CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.

        const string UC_NAME_ADD_CAR = "UcAddCar";
        const string UC_NAME_ADD_CUST = "UcAddCust";
        const string UC_NAME_ADD_SELL = "UcAddSell";
        UcAddCar ucAddCar;
        UcAddCust ucAddCust;
        UcAddSell ucAddSell;


        public AddData()
        {
            InitializeComponent();
            ucAddCar = new UcAddCar();
            ucAddCust = new UcAddCust();
            ucAddSell = new UcAddSell();
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
        }

        public AddData(UnionController uHandler)
        {
            InitializeComponent();
            ucAddCar = new UcAddCar(uHandler, this);
            ucAddCust = new UcAddCust();
            ucAddSell = new UcAddSell();
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
        }

        private void addDataExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addDataCar_Click(object sender, EventArgs e)
        {
            controllView(ucAddCar, UC_NAME_ADD_CAR);
        }

        private void addDataCust_Click(object sender, EventArgs e)
        {
            controllView(ucAddCust, UC_NAME_ADD_CUST);
        }

        private void addDataSell_Click(object sender, EventArgs e)
        {
            controllView(ucAddSell, UC_NAME_ADD_SELL);
        }

        private void controllView(UserControl uc, string view)
        {
            if(!centerLayout.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[view].BringToFront();
        }
    }
}
