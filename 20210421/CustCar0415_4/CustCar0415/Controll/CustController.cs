using CustCar0415.Common;
using CustCar0415.Model;
using CustCar0415.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Controll
{
    class CustController : BaseController
    {
        List<Customer> listCust;

        internal List<Customer> ListCust { get => listCust; set => listCust = value; }

        public CustController(RandData rand)
        {
            listItem = new List<object>();
            listCust = listItem.Cast<Customer>().ToList();
            this.rand = rand;
        }

        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listCust.Add(new Customer(
                    rand.getName(),
                    rand.getAge(),
                    rand.getTel(),
                    rand.getAddr(),
                    rand.getGender()));
            }
        }

        public override void itemView()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listCust.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCust[i].ToString());
            }
        }

        public override void removeAll()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }
            listCust.Clear();
        }

        public override void addItem(object item)
        {
            listCust.Add(item as Customer);
        }

        public override void delItem(object item)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(item))
                {
                    listCust.RemoveAt(i--);
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(item[CommMenu.OLD_MODEL]))
                {
                    listCust[i].Name = item[CommMenu.NEW_MODEL];
                }
            }
        }
    }
}
