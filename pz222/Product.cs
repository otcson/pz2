using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz222
{
    class Product
    {
        private int Id;
        public string Name;
        public double Price;
        public DateTime Deliverydate;
        public Product(string Name)
        {
            if(Name.Length < 4)
            {
                this.Name = Name;
            }
            else
            {
                Name = Name.Remove(4);
                this.Name = Name;
            }
             
        }
    }
}
