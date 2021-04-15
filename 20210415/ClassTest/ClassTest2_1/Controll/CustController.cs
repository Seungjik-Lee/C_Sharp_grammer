using ClassTest2_1.Model;
using ClassTest2_1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1.Controll
{

    class CustController
    {
        const int OLD_NAME = 0;
        const int NEW_NAME = 1;
        List<Customer> listCust = new List<Customer>();
        RandData rand;

        
        public CustController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i=0; i<count; i++)
            {
                listCust.Add(new Customer(
                    rand.getName(),
                    rand.getAge(),
                    rand.getTel(),
                    rand.getAddr(),
                    rand.getGender()));
            }
        }

        public void custView()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i=0; i< listCust.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCust[i].ToString());
            }
        }

        public void custView2()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listCust.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listCust[i].CustomerInfo();
            }
        }

        public void removeAll()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }
            listCust.Clear();
        }

        public void addCustItem(Customer cust)
        {
            listCust.Add(cust);
        }

        public void delCustItem(string name)
        {
            
            for (int i=0; i< listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(name))
                {
                    listCust.RemoveAt(i--);
                    
                }                
            }
            
            

        }
        
        public void updateCustItem(string[] name)
        {
            for (int i=0; i<listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(name[OLD_NAME]))
                {
                    listCust[i].Name = name[NEW_NAME];
                   
                }
            }
        }
    }
    
}
