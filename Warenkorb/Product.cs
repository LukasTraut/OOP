using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class Product
    {
        public int Id;
        public string Name;
        public double Price;

        override public string ToString()
        {
            return Name;
        }
    }
}
