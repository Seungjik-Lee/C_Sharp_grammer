using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extends_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Animal_Click(object sender, EventArgs e)
        {

        }

        private void button_Cat_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = "냥냥이";
            c.age = 1;
            c.eyeColor = "오드아이";
            c.Sleep();
            c.DailyLootin();
        }

        private void button_Dog_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.name = "댕댕이";
            d.age = 1;
            d.hairColor = "갈색";
            d.Sleep();
        }

        private void button_Animals_Click(object sender, EventArgs e)
        {
            //다형성
            Animal a = new Cat();
            Animal b = new Dog();

            a.age = 1;
            a.name = "파트라슈";

            if (a is Cat)
            {
                (a as Cat).eyeColor = "갈색";
                (a as Cat).DailyLootin();
                (a as Cat).Sleep();
                a.Sleep();
            }

            var temp a as Cat;
            if(temp != null)
            {
                temp.DailyLootin();
            }

            b.age = 1;
            b.name = "도그";

            Animal c = new Cat();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(b);
            animals.Add(c);

            foreach(var item in animals)
            {
                if (item is Cat)
                {
                    (item as Cat).DailyLootin();
                }
                else
                {
                    item.Sleep();
                }
            }    
        }
    }
}
