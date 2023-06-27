using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
   public class Bank: Accounts
    {
        const double refill = 5000;
        const double maxTop = 20000;
        public double refillATM()
        {
            return refill;
        }
        public Bank()
        {

        }
    }
}
