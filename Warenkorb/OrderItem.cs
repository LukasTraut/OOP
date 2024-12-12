using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class OrderItem
    {
        public Product Product;
        public int Quantity;

        public double GetAmount()
        {
            return Product.Price;

        }
    }
}
