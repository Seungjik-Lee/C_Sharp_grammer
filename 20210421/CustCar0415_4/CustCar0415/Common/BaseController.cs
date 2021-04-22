using CustCar0415.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Common
{
    abstract class BaseController
    {
        protected RandData rand;
        protected List<object> listItem;

        public abstract void insRandData(int count);
        public abstract void itemView();
        public abstract void removeAll();
        public abstract void addItem(object item);
        public abstract void delItem(object item);
        public abstract void updateItem(string[] item);
    }
}
