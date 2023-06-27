using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PP1E
{
  public  class ATMManager
    {
        // intialising the collections/arrays
        Bank bank = new Bank();
        Customers customers = new Customers();
        ChequingAccounts chequingaccounts = new ChequingAccounts();
        SavingsAccounts savingaccounts = new SavingsAccounts();
        // inintialising the new variables of daily and current balances
        private double currentAccountBalance = 0;// set at zero as it resets.
        private double currentDailyBalance = 0;
        //bool has to be false. if its out of order.
       
      
      
      
      // private bool HorsService = false;
        
      
      
      // new defined variables.
        private DailyBalances dailyBalances = new DailyBalances();
        private const double BillFee = 1.25;
         // get set of recent account balance. Read and Write only accessors
        public double CurrentAccountBalance
        {
            get { return currentAccountBalance; }
            set { currentAccountBalance = value; }
        }

        //readcustomers,readaccounts dones,redailybalances.
        public ATMManager()
        {
            ReadCustomers();
            ReadAccounts();
            ReadDailyBalances();
        }

        public void ReadAccounts()
        {
            chequingaccounts.Clear();
            savingaccounts.Clear();

            FileStream FS = new FileStream("Accounts.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(FS);

            while (!reader.EndOfStream)
            {
                string formatline = reader.ReadLine();
                string[] section = formatline.Split(',');

                if (section[0] == "C")
                {

                    chequingaccounts.Add(new Chequing(section[1], section[2], Convert.ToDouble(section[3])));
                }
                else
                {
                    if (section[0] == "S")
                    {
                        savingaccounts.Add(new Savings(section[1], section[2], Convert.ToDouble(section[3])));
                        
                    }
                }
            }
            reader.Close();
        }

        public void ReadCustomers()
        {
            customers.Clear();
            FileStream FS = new FileStream("Customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(FS);

            while (!reader.EndOfStream)
            {
                string formatline = reader.ReadLine();
                string[] section = formatline.Split(',');

                customers.Add(new Customer(section[0], section[1]));
              
            }
            reader.Close();
        }

        public void ReadDailyBalances()
        {
            CurrentAccountBalance = 0;
            dailyBalances.Clear();
            FileStream FS = new FileStream("DailyBalances.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(FS);

            while (!reader.EndOfStream)
            {
                DateTime current;
                string formatline = reader.ReadLine();
                string[] section = formatline.Split(',');

                dailyBalances.Add(new DailyBalance(section[0], Convert.ToDouble(section[1])));

                current = Convert.ToDateTime(section[0]);
                if (current == DateTime.Today)
                {
                    CurrentAccountBalance = Convert.ToDouble(section[1]);
                }
                

            }
            reader.Close();
        }

        public bool WriteAccounts()
        {
            FileStream FS = new FileStream("Accounts.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(FS);

            foreach (Chequing c in chequingaccounts)
            {
                string line = "C," + c.GetPin + "," + c.GetAccountNumber + "," + c.GetBalance;
                writer.WriteLine(line);
            }
            foreach (Savings s in savingaccounts)
            {
                string line = "S," + s.GetPin + "," + s.GetAccountNumber + "," + s.GetBalance;
                writer.WriteLine(line);
            }
            writer.Close();
            return true;
        }

        public void WriteDailyBalances()
        {
            FileStream FS = new FileStream("DailyBalances.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(FS);

            foreach (DailyBalance db in dailyBalances)
            {
                string line = db.atmDate + "," + db.atmBalance;
                writer.WriteLine(line);
            }
            writer.Close();
        }

        public bool CheckUser(string name, string pin)
        {

            foreach (Customer c in customers)
            {
                if (c.Name == name && c.Pin == pin)
                {
                    return true;
                }

            }
            return false;
        }

        public double CheckDailyBalance()
        {
            foreach (DailyBalance dailyBalance in dailyBalances)
            {
                if (Convert.ToDateTime(dailyBalance.atmDate) == DateTime.Today)
                {
                    return dailyBalance.atmBalance;
                }

            }
            return 0;
        }

        public double DisplayAccountBalance()
        {
            return currentAccountBalance;
        }

        public void AddDailyBalance()
        {
            currentDailyBalance += 5000;
            foreach (DailyBalance dailyBalance in dailyBalances)
            {
                if (Convert.ToDateTime(dailyBalance.atmDate) == DateTime.Today)
                {
                    dailyBalance.atmBalance = currentDailyBalance;
                    return;
                }
            }
            DailyBalance DB = new DailyBalance(DateTime.Today.ToString("MM-DD-YYYY"), 5000);
            dailyBalances.Add(DB);
            WriteDailyBalances();
        }

        public string AccountsReport()
        {
            string accountsReport;
            accountsReport = string.Empty;
            foreach (Chequing chequing in chequingaccounts)
            {
                accountsReport += chequing.ToString();
            }

            foreach (Savings saving in savingaccounts)
            {
                accountsReport += saving.ToString(); 
            }

            return accountsReport;
        }

        public void PayIntrest()
        {
            foreach (Savings s in savingaccounts)
            {
                s.accountBalance += s.accountBalance * 0.01;
            }
            WriteAccounts();
        }

       

        public bool WithdrawChequing(string pin, double amount)
        {
            if ((amount % 20== 0))
            {
                foreach (Chequing c in chequingaccounts)
                {
                    if( pin== c.GetPin && amount<= c.GetBalance)
                    {
                        c.Withdraw(amount);
                        //bank.accountBalance -= amount;
                        return true;
                    }
                }

            }

            return false;
        }

        public bool WithdrawSavings(string pin, double amount)
        {
            if ((amount % 20== 0))
            {
                foreach (Savings s in savingaccounts)
                {
                    if (pin == s.GetPin && amount <= s.GetBalance)
                    {
                        s.Withdraw(amount);
                       // bank.accountBalance -= amount;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DepositChequing(string pin, double amount)
        {
            if (amount > 0)
            {
                foreach (Chequing c in chequingaccounts)
                {
                    if (pin == c.GetPin)
                    {
                        c.Deposit(amount);
                        bank.accountBalance += amount;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DepositSavings(string pin, double amount)
        {
            if (amount > 0)
            {
                foreach (Savings s in savingaccounts)
                {
                    if (pin == s.GetPin)
                    {
                        s.Deposit(amount);
                        bank.accountBalance += amount;
                        return true;
                    }
                }
            }
            return false;
        }


        public bool PayBillPayments(string pin, double amount)
        {
            if (amount > 0)
            {
                foreach (Chequing c in chequingaccounts)
                {
                    if (pin == c.GetPin && (amount + 1.25 <= c.GetBalance))
                    {
                        c.PayBill(amount);
                        return true;
                    }
                }

            }
            return false;
        }

        public bool TransferFunds(string pin, double amount, char accountType)
        {
            Savings save = null;
            Chequing cheque = null;
           double valide = 0;

            foreach (Savings s in savingaccounts)
            {
                if (s.GetPin == pin)
                {
                    save = s;
                }
            }

            foreach (Chequing c in chequingaccounts)
            {
                if (c.GetPin == pin)
                {
                    cheque = c;
                }
            }
            if (accountType == 'S')
            {
                valide = save.TransferOut(amount);
                if (valide > 0)
                {
                    cheque.TransferIn(amount);
                    return true;
                }
                else return false;
            }
            else
            {
                valide = cheque.TransferOut(amount);
                if (valide > 0)
                {
                    save.TransferIn(amount);
                    return true;
                }
                else return false;
            }

        }
        public string GetAccounts(string pin)
        {
            string result="";
            foreach (Chequing c in chequingaccounts)
            {
                if (c.GetPin == pin)
                {
                    
                    result = Environment.NewLine + "Chequing Balance: $" +c.GetBalance.ToString() + Environment.NewLine;
                }
            }
            foreach (Savings s in savingaccounts)
            {
                if (s.GetPin == pin)
                {
                    result += "Savings Balance: $" + s.GetBalance.ToString() + Environment.NewLine;
                }
            }
            return result;
        }
       
    }//class
}//namespace

