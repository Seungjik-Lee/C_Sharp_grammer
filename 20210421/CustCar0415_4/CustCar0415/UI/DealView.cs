using CustCar0415.Common;
using CustCar0415.Controll;
using CustCar0415.Model;
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

namespace CustCar0415.UI
{
    partial class DealView : MaterialForm
    {
        UnionController uHandler;
        public DealView()
        {
            InitializeComponent();
        }

        public DealView(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        private void initDealSmListView()
        {
            List<Deal<Car, Customer, Seller>> list = uHandler.ListUn;
            //string[] data = { "1", "그랜저", "4천만원", "홍길동", "전우치", "2001년4월16일", "4천만원" };
            //dealSmListView.Items.Add(new ListViewItem(data));
            for(int i=0; i<list.Count;i++)
            {
                dealSmListView.Items.Add(new ListViewItem(
                new string[]
                {
                    //(i).ToString(),"쏘나타","4천만원", "홍길동", "전우치", "2001년4월16일", "3천만원"
                    (i+1).ToString(),
                    list[i].Car.Model,
                    list[i].Car.Price,
                    list[i].Customer.Name,
                    list[i].Seller.Name,
                    list[i].Date, list[i].Price

                }
                )) ;
            }
            setRowColor(Color.White, Color.LightGray);
            int index = dealSmListView.Items.Count - 1;
            dealSmListView.Items[index].Selected = true;
            dealSmListView.Items[index].Focused = true;
            dealSmListView.EnsureVisible(index);
            CommMenu.colorListViewHeader(ref dealSmListView, Color.LightGray, Color.White);
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealSmListView();
        }

        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void setRowColor(Color color1, Color color2)
        {
            foreach(ListViewItem item in dealSmListView.Items)
            {
                if((item.Index %2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }
    }
}