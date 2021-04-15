using ClassTest2_1.Model;
using ClassTest2_1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1.Controll
{
    class SellController
    {
        const int OLD_NAME_SEll = 0;
        const int NEW_NAME_SEll = 1;
        List<Seller> listSell = new List<Seller>();
        RandData rand;

        
        public SellController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i=0; i<count; i++)
            {
                listSell.Add(new Seller(
                    rand.getName(),
                    rand.getTel(),
                    rand.getJikwi(),
                    rand.getOffice()));
            }
        }

        public void sellView()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("판매자 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i=0; i< listSell.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listSell[i].ToString());
            }
        }

        public void sellView2()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("판매자 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listSell.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listSell[i].SellerInfo();
            }
        }

        public void removeAll()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("판매자 데이터가 존재하지 않습니다.");
                return;
            }
            listSell.Clear();
        }

        public void addSellItem(Seller sell)
        {
            listSell.Add(sell);
        }

        public void delSellItem(string name)
        {
            
            for (int i=0; i< listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(name))
                {
                    listSell.RemoveAt(i--);
                    
                }                
            }
            
            

        }
        
        public void updateSellItem(string[] name)
        {
            for (int i=0; i<listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(name[OLD_NAME_SEll]))
                {
                    listSell[i].Name = name[NEW_NAME_SEll];
                   
                }
            }
        }
    }
}
