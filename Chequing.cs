using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
    public class Chequing : Accounts
    {
        private double maximumBillAmount = 10000;
        private const double BillFee=1.25;

        public override string ToString()
        {
            return "C," + base.ToString();
        }
        public bool PayBill(double amount)
        {
            if (amount <= maximumBillAmount && amount <= accountBalance)
            {
                accountBalance -= (amount * BillFee);
                return true;
            }

            else
            { 
                return false;
            }
            
        }

        public Chequing(string pin, string accountnum, double Balance):base( pin,  accountnum,  Balance)
        {

        }
    }
}
