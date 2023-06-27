using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1E
{
   public class Accounts
    {
        private string pinNumber;
        private string accountNumber;
        public double accountBalance;
        private const double maxWithdraw = 1000;
        private const double maxTransferAmount = 100000;

        public Accounts()
        {

        }
        public  Accounts(string pin, string accountnum, double Balance)
        {
            pinNumber=pin;
            accountNumber=accountnum;
            accountBalance=Balance;
        }

         public override string ToString()
        {
            return pinNumber + "," + accountNumber + "," + accountBalance.ToString("F");
        }

        public double Withdraw(double amount)
        {
            if (amount <= maxWithdraw && amount <= accountBalance)
            {
                accountBalance -= amount;
                return accountBalance;
            }

            else
            {
                return 0;
            }
        }

        public double Deposit(double amount)
        {
            accountBalance += amount;
            return accountBalance;

        }

        public double TransferOut(double amount)
        {
            if (amount <= maxTransferAmount && amount <= accountBalance)// if transfer amount is less than max transfer and less than account balance then run the script.
            {
                accountBalance -= amount;
                return accountBalance;

            }

            else
            {
                return 0;
            }

        }

        public double TransferIn(double Amount)
        {
            accountBalance += Amount;
            return accountBalance;

        }

        public string GetPin
        { 
            get{return pinNumber;}
            set{ pinNumber= value;}

        }

        public string GetAccountNumber
        {
            get{return accountNumber;}
        }

        public double GetBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        
    }
}
