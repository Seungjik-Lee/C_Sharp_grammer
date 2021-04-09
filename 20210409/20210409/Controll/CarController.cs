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
        List<Car> list = new List<Car>();
        RandData rand;

        public CarController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Car(
                    rand.getName(),
                    rand.getcolor(),
                    rand.getcompany(),
                    rand.getprice()
                    ));
            }
        }
        public void carView()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ToString();
            }
        }

        public void carView2()
        {
            for (int i = 0; i < list.Count; i++)
            {
                
            }
        }
    }
}
