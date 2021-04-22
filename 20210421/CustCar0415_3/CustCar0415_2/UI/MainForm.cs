using CustCar0415_2.Controll;
using CustCar0415_2.UI;
using CustCar0415_2.Util;
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

        private void randInsert_Click(object sender, EventArgs e)
        {
            string size = myInputBox("랜덤 데이터 추가",
                "랜덤하게 생성할 데이터 개수를 입력하세요", "0");
            uHandler.insRandData(Convert.ToInt32(size));
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            uHandler.dealView();
            new DealView(uHandler).ShowDialog();
        }

        public string myInputBox(string title, 
            string body,
            string prompt)
        {
            string input = 
                Microsoft.VisualBasic.Interaction.
                InputBox(body, title, prompt, -1, -1);
            return input;
        }
        
        public void initFont()
        {
            CxFlatUI.CxFlatRoundButton[] btnArr =
                {randInsert, randDel, dataView,
                 dataInsert, dataDel, dataUpdate};
            PrivateFontCollection pFont =
                new PrivateFontCollection();
            pFont.AddFontFile("crayonm.ttf");
            Font font =
                new Font(pFont.Families[0], 13f);
            foreach (var n in btnArr)
            {
                n.Font = font;
            }
            mainTitle.Font = font;
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            initFont();
        }

        private void randDel_Click(object sender, EventArgs e)
        {
            uHandler.removeAll();
        }
    }
}
