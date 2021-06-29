using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Animal : Creature
    {
        public string name { get; set; }
        public int age { get; set; }

        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("응애");
        }

        public virtual void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("");
        }
    }
}
