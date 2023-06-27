using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
    class Savings:Accounts
    {
        public Savings(string pin, string accountnum, double balance)
            : base(pin, accountnum, balance )
        {

        }

        public override string ToString()
        {
            return "S," + base.ToString();
        }

    }
}
