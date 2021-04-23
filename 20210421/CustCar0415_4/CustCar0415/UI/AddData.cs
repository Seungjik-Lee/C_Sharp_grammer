using CustCar0415.Controll;
using CustCar0415.Model;
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
    partial class AddData : MaterialForm
    {
#pragma warning disable CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        UnionController uHandler;

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
            ucAddCust = new UcAddCust(uHandler);
            ucAddSell = new UcAddSell(uHandler);
            //centerLayout.Controls.Add(ucAddCar);
            //centerLayout.Dock = DockStyle.Fill;
            ucAddCar.addCarConfirmEvent += addCarConfirmHandler;
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
            if (!centerLayout.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[view].BringToFront();
        }

        public void setStatusInfo(string status)
        {
            addDataStatus.Text = status;
        }

        private void addCarConfirmHandler(object sender, EventArgs e)
        {
            addDataStatus.Text = "차량 정보를 등록하였습니다.";
        }

        private void addCustConfirmHandler(object sender, EventArgs e)
        {
            addDataStatus.Text = "고객정보를 등록하였습니다.";
        }
        private void addSellConfirmHandler(object sender, EventArgs e)
        {
            addDataStatus.Text = "판매자정보를 등록하였습니다.";
        }

        private void addDataOk_Click_1(object sender, EventArgs e)
        {
            uHandler.ListUn.Add(new Deal<Car, Customer, Seller>(
   uHandler.CarHandle.ListCar[0],
   uHandler.CustHandle.ListCust[0],
   uHandler.SellHandle.ListSell[0],
   DateTime.Now.ToString("yyyy년MM월dd일"),
   uHandler.CarHandle.ListCar[0].Price + "5백만원"));
            Close();
        }
    }
}
