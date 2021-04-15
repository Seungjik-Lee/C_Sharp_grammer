using CustCar0415.Model;
using CustCar0415.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Controll
{
    class CarController
    {
        const int OLD_MODEL = 0;
        const int NEW_MODEL = 1;
        List<Car> listCar = new List<Car>();
        RandData rand;

        public CarController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
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

        public void carView()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("차량 데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listCar.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCar[i].ToString());
            }
        }

        public void carView2()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }

            for (int i = 0; i < listCar.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listCar[i].printInfoCar();
            }
        }

        public void removeAll()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listCar.Clear();
        }

        public void addCarItem(Car car)
        {
            listCar.Add(car);
        }

        public void delCarItem(string model)
        {

            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(model))
                {
                    listCar.RemoveAt(i--);

                }
            }
        }

        public void updateCarItem(string[] model)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(model[OLD_MODEL]))
                {
                    listCar[i].Model = model[NEW_MODEL];

                }
            }
        }
    }
}
