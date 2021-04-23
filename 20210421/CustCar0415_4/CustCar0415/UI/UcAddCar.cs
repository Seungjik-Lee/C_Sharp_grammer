using CustCar0415.Controll;
using CustCar0415.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    partial class UcAddCar : UserControl
    {
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;
        AddData ad;
        public delegate void AddCarConfirmEventHandler(object sender, EventArgs e);
        public event AddCarConfirmEventHandler addCarConfirmEvent;

        public UcAddCar()
        {
            InitializeComponent();
        }

        public UcAddCar(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        public UcAddCar(UnionController uHandler, AddData ad)
        {
            InitializeComponent();
            this.uHandler = uHandler;
            this.ad = ad;
        }

       

        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
            Console.WriteLine("index : " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if (cb.SelectedIndex > -1)
            {
                Console.WriteLine("선택 : " + cb.SelectedItem.ToString());
            }
            return item;
        }

        private void ucAddCarOK_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            if (company == null)
            {
                MessageBox.Show("제조사를 선택하세요.");
                ucComboCompany.Select();
                return;
            }

            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                ucComboColor.Select();
                return;
            }

            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                ucComboPrice.Select();
                return;
            }

            uHandler.CarHandle.addItem(new Car(model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            ucAddCarOK.Enabled = false;
            //ad.setStatusInfo("차량 정보가 등록되었습니다.");
            if (addCarConfirmEvent != null)
            {
                addCarConfirmEvent(this, new EventArgs());
            }
        }

        private void ucAddCarInit_Click(object sender, EventArgs e)
        {

        }

        private void ucComboModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            ucInfoModel.Text = model;
            ucInfoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "그랜저":
                    pictureBox1.Image = Properties.Resources.그랜저;
                    pictureBox2.Image = Properties.Resources.그랜저2;
                    pictureBox3.Image = Properties.Resources.그랜저내부;
                    pictureBox4.Image = Properties.Resources.그랜저후방;
                    break;
                case "제네시스":
                    pictureBox1.Image = Properties.Resources.제네시스1;
                    pictureBox2.Image = Properties.Resources.제네시스2;
                    pictureBox3.Image = Properties.Resources.제네시스내부;
                    pictureBox4.Image = Properties.Resources.제네시스후방;
                    break;
                case "K8":
                    pictureBox1.Image = Properties.Resources.K8;
                    pictureBox2.Image = Properties.Resources.K8_1;
                    pictureBox3.Image = Properties.Resources.K8_2;
                    pictureBox4.Image = Properties.Resources.K8내부;
                    break;
                case "K7":
                    pictureBox1.Image = Properties.Resources.K7;
                    pictureBox2.Image = Properties.Resources.K7_1;
                    pictureBox3.Image = Properties.Resources.K7내부;
                    pictureBox4.Image = Properties.Resources.K7후방;
                    break;
                case "SM6":
                    pictureBox1.Image = Properties.Resources.SM6;
                    pictureBox2.Image = Properties.Resources.SM6_1;
                    pictureBox3.Image = Properties.Resources.SM6내부;
                    pictureBox4.Image = Properties.Resources.SM6후방;
                    break;
            }
        }

        private void ucComboCompany_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            ucInfoCompany.Text = company;
            ucInfoCompany.ForeColor = Color.Red;
        }

        private void ucComboColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            ucInfoColor.Text = color;
            ucInfoColor.ForeColor = Color.Red;
        }

        private void ucComboPrice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            ucInfoPrice.Text = price;
            ucInfoPrice.ForeColor = Color.Red;
        }        
    }
}
