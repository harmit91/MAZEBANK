using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
    public class DailyBalance
    {
        private string ATMDate;
        private double ATMBalance;
        private const int minimumAmount = 5000;

        public string atmDate
        {
            get { return ATMDate; }
            set { ATMDate = value; }
        }

        public double atmBalance
        {
            get { return ATMBalance; }
            set { ATMBalance = value; }
        }

        public DailyBalance(string ATMDate, double ATMBalance)
        {
            this.ATMDate= ATMDate;
            this.ATMBalance=ATMBalance;
         }

        public void UpdateDailyBalance(double amount)
        {
            ATMBalance -= amount;
        }
    }
}
