using CustCar0415_2.Model;
using CustCar0415_2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415_2.Controll
{
    class UnionController
    {
        CarController carHandle;
        CustController custHandle;
        SellController sellHandle;
        List<Deal<Car, Customer, Seller>> listUn =
            new List<Deal<Car, Customer, Seller>>();
        RandData rand;

        public UnionController(RandData rand)
        {
            this.rand = rand;
            carHandle = new CarController(rand);
            custHandle = new CustController(rand);
            sellHandle = new SellController(rand);
        }

        public UnionController(
            CarController carHandle,
            CustController custHandle,
            SellController sellHandle)
        {
            this.carHandle = carHandle;
            this.custHandle = custHandle;
            this.sellHandle = sellHandle;
        }

        internal CarController CarHandle { get => carHandle; set => carHandle = value; }
        internal CustController CustHandle { get => custHandle; set => custHandle = value; }
        internal SellController SellHandle { get => sellHandle; set => sellHandle = value; }

        public void addItem(
            Deal<Car, Customer, Seller> deal)
        {
            listUn.Add(deal);
        }

        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listUn.Add(
                    new Deal<Car, Customer, Seller>(
                        new Car(rand.getModel(),
                            rand.getColor(),
                            rand.getCompany(),
                            rand.getPrice()),
                        new Customer(rand.getName(),
                            rand.getAge(),
                            rand.getTel(),
                            rand.getAddr(),
                            rand.getGender()),
                        new Seller(rand.getName(),
                            rand.getTel(),
                            rand.getJikwi(),
                            rand.getOffice()),
                        DateTime.Now.ToString("yyyy년MM월dd일-") +
                        DateTime.Now.ToString("HH:mm분:ss초"),
                        rand.getPrice() + "+500만원"));
            }
        }

        public void dealViewAll()
        {
            if (listUn.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listUn.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listUn[i].ToString());
                Console.WriteLine("-----------------");
            }
        }

        public void dealView()
        {
            if (listUn.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listUn.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listUn[i].dealInfo();
                Console.WriteLine("-----------------");
            }
        }
    }
}
