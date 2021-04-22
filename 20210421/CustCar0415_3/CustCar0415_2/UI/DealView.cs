using CustCar0415_2.Controll;
using CustCar0415_2.Model;
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

namespace CustCar0415_2.UI
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
            List<Deal<Car, Customer, Seller>> list =
                uHandler.ListUn;
            for (int i=0; i<list.Count; i++)
            {
                dealSmListview.Items.Add(
                    new ListViewItem(
                        new string[]
                        {
                            (i+1).ToString(), 
                            list[i].Car.Model,
                            list[i].Car.Price,
                            list[i].Customer.Name, 
                            list[i].Seller.Name,
                            list[i].Date, list[i].Price
                        }
                ));
            }
            setRowColor(Color.White, Color.LightGray);
            int index = dealSmListview.Items.Count - 1;
            dealSmListview.Items[index].Selected = true;
            dealSmListview.Items[index].Focused = true;
            dealSmListview.EnsureVisible(index);
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealSmListView();
        }

        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setRowColor(Color color1, 
            Color color2)
        {
            foreach (ListViewItem item in 
                dealSmListview.Items)
            {
                if ((item.Index % 2) == 0)
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
