using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz222
{
    class Purchase
    {
        public int Id;
        public Product Product;
        public Human Human;
        public double Quantity; //количество
        public double Amount; //сумма
        public Purchase(double Quantity)
        {
            if (Quantity>0)
            {
                this.Quantity = Quantity;
            }
            else
            {
                this.Quantity = 0;
            }
        }
    }
}