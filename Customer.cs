using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
    public class Customer
    {
        private string name;
        private string pin;

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Customer(string name, string pin)
        {
            this.name = name;
            this.pin = pin;
            
        }
    }
}
