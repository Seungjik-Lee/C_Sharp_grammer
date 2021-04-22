using CustCar0415_2.Common;
using CustCar0415_2.Model;
using CustCar0415_2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415_2.Controll
{
    class CarController : BaseController
    {
        List<Car> listCar = new List<Car>();

        public CarController(RandData rand)
        {
            listItem = new List<object>();
            listCar = listItem.Cast<Car>().ToList();
            this.rand = rand;
        }

        public void updateCarItem(string[] model)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(model[CommMenu.OLD_MODEL]))
                {
                    listCar[i].Model = model[CommMenu.NEW_MODEL];
                }
            }
        }

        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listCar.Add(new Car(
                    rand.getModel(),
                    rand.getColor(),
                    rand.getCompany(),
                    rand.getPrice()));
            }
        }
        public override void itemView()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("차량 데이터가  존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listCar.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCar[i].ToString());
            }
        }

        public override void removeAll()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("차량 데이터가 존재하지 않습니다.");
                return;
            }
            listCar.Clear();
        }

        public override void addItem(object item)
        {
            listCar.Add(item as Car);
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(item))
                {
                    listCar.RemoveAt(i--);
                }
            }
        }

    }
}
