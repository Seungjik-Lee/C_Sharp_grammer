using CustCar0415.Controll;
using CustCar0415.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            string size = myInputBox("랜덤데이터 추가", "랜덤하게 생성할 데이터 개수를 입력하세요", "0");
            uHandler.insRandData(Convert.ToInt32(size));
        }

        private void DataDelete_Click(object sender, EventArgs e)
        {

        }

        private void DataView_Click(object sender, EventArgs e)
        {
            uHandler.dealView();
        }

        private void DataAdd_Click(object sender, EventArgs e)
        {

        }

        private void DataUpdate_Click(object sender, EventArgs e)
        {

        }

        private void RandDataDelete_Click(object sender, EventArgs e)
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

        public string myInputBox(string title, string body, string prompt)
        {
            Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return null;
        }

        public void InitFont()
        {
            CxFlatUI.CxFlatRoundButton[] btnArr = { RandDataAdd, DataDelete, DataView, DataAdd, DataUpdate, RandDataDelete };
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("tvN_Enjoystories_Medium.ttf");
            Font font = new Font(pFont.Families[0], 18f);
            foreach (var n in btnArr)
            {
                n.Font = font;
            }
            MainTitle.Font = font;
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            InitFont();
        }
    }
}
