using CustCar0415_2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415_2.Common
{
    abstract class BaseController
    {
        protected RandData rand;
        protected List<object> listItem;

        public abstract void itemView();
        public abstract void removeAll();
        public abstract void addItem(object item);
        public abstract void delItem(string item);
        public abstract void up
    }
}
