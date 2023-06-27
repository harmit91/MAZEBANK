using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP1E
{
    public partial class Supervisor : Form
    {
        string pin;
        ATMManager atmanager;
        Login login;
        public Supervisor(string pin, ATMManager atmanager, Login login)
        {
            InitializeComponent();
            this.pin = pin;
            this.atmanager = atmanager;
            this.login = login;
           
        }
        

        private void chkSupClose_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity >= 100)
            {
                timer1.Enabled = false;
            }

        }

        private void Supervisor_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void BTNSupSubmit_Click(object sender, EventArgs e)
        {
            if (chkSupOutServ.Checked)
            {
                atmanager.WriteAccounts();
                atmanager.WriteDailyBalances();
                TXTSupInfo.Text += "ATM Is Now Out of Order" + Environment.NewLine;

            }

            if (chkSupPayIntrest.Checked)
            {
                atmanager.PayIntrest();
                TXTSupInfo.Text += " Intrest Paid" + Environment.NewLine;
            }

            if (chkSupRefill.Checked)
            {
                atmanager.DisplayAccountBalance();
                // atmanager.AccountsReport();
                TXTSupInfo.Text += "ATM has been refilled" + Environment.NewLine;
            }

            if (chkSupPrintRep.Checked)
            {
                atmanager.AccountsReport();
                TXTSupInfo.Text += " Print Action Complete" + Environment.NewLine;
            }
        }

       
        

       
    }
}
