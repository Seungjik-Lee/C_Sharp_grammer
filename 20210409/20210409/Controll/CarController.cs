using _20210409.Model;
using _20210409.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409.Controll
{
    class CarController
    {
        List<Car> listcar = new List<Car>();
        RandData rand;
        const int OLD_MODEL = 0;
        const int NEW_MODEL = 1;

        public CarController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listcar.Add(new Car(
                    rand.getName(),
                    rand.getcolor(),
                    rand.getcompany(),
                    rand.getprice()
                    ));
            }
        }
        public void carView()
        {
            for (int i = 0; i < listcar.Count; i++)
            {
                listcar[i].ToString();
            }
        }

        public void carView2()
        {
            for (int i = 0; i < listcar.Count; i++)
            {

            }
        }

        public void delCarItem(string model)
        {
            for (int i = 0; i < listcar.Count; i++)
            {
                if (listcar[i].Model.Equals(model))
                {
                    listcar.RemoveAt(i);
                }
            }
        }

        public void updateCarItem(string[] model)
        {
            for (int i = 0; i < listcar.Count; i++)
            {
                if (listcar[i].Model.Equals(model[OLD_MODEL]))
                {
                    listcar[i].Model = model[NEW_MODEL];
                }
            }
        }
    }
}
