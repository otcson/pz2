using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pz222
{
    class Human
    {
        private int Id;
        public string Secondname;
        public string Name;
        public string PhoneNumber;

        public Human(string PhoneNumber)
        {
            if(PhoneNumber.Length == 9)
            {
                PhoneNumber = "+7" + PhoneNumber;
                this.PhoneNumber = PhoneNumber;
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
        }

    }
}
