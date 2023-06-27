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
    public partial class Account : Form
    {
        string pin;
        ATMManager atmanager;
        Login login;
        double amount;
        public Account(string pin, ATMManager atmanager, Login login)
        {
            InitializeComponent();
            TXTaccinfo.Text = "";
            this.pin = pin;
            this.atmanager = atmanager;
            this.login = login;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }


        private void deposit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNcloseacc_Click(object sender, EventArgs e)
        {

            atmanager.WriteAccounts();
            login.Show();
            this.Close();
        }

        private void BTN1acc_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (TXTaccEnterDisplay.Text == "0.00")
            {
                TXTaccEnterDisplay.Text = b.Text;
            }
            else
            {
                TXTaccEnterDisplay.Text += b.Text;
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            TXTaccinfo.Text = atmanager.GetAccounts(pin);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 100)
            {
                timer1.Enabled = true;
            }
        }

        private void BTNClearacc_Click(object sender, EventArgs e)
        {
            TXTaccEnterDisplay.Clear();
        }

        private void BTNCorrectacc_Click(object sender, EventArgs e)
        {
            TXTaccEnterDisplay.Text = TXTaccEnterDisplay.Text.Substring(0, TXTaccEnterDisplay.Text.Length - 1);
        }

        private void BTNEnteracc_Click(object sender, EventArgs e)
        {
            char accountType;
            amount = Convert.ToDouble(TXTaccEnterDisplay.Text);
            if (CHKsavings.Checked)
            {
                if (CHKPayBill.Checked)
                {
                    System.Windows.Forms.MessageBox.Show("Please Select *Chequing Account For this Transaction");
                }
                if (CHKtransfer.Checked)
                {
                    atmanager.TransferFunds(pin, amount, accountType = 'S');
                    TXTaccinfo.Text += " " + Environment.NewLine;
                    TXTaccinfo.Text += "Completed: Transfered From *Savings to *Chequing";
                    TXTaccinfo.Text += " " + Environment.NewLine;
                    TXTaccinfo.Text += atmanager.GetAccounts(pin);
                    

                
                }

                if (CHKdeposit.Checked)//if saving and deposit checked do this
                {
                    atmanager.DepositSavings(pin, amount);
                    TXTaccinfo.Text += "***UPDATED***";
                    TXTaccinfo.Text += atmanager.GetAccounts(pin);//(works good)
                    
                }
                else
                {
                    if (CHKwithdraw.Checked)//else savings and withdraw do this
                    {
                        if (amount % 20 != 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Please Enter Withdraw Amount Divisble by 20");
                        }
                        else
                        {
                            atmanager.WithdrawSavings(pin, amount);
                            TXTaccinfo.Text += "***UPDATED***";
                            TXTaccinfo.Text += atmanager.GetAccounts(pin);//(good)
                        }
                    }
                }
            }
            else// if niether then its chequing checked
            {
                if (CHKchequing.Checked)
                {
                    if (CHKPayBill.Checked)
                    {
                        atmanager.PayBillPayments(pin, amount);
                        TXTaccinfo.Text += " " + Environment.NewLine;
                        TXTaccinfo.Text += "Bill Payment Completed. " + Environment.NewLine;
                        TXTaccinfo.Text += "Thank you!" + Environment.NewLine;
                        TXTaccinfo.Text += atmanager.GetAccounts(pin);
                    }
                    if (CHKtransfer.Checked)
                    {
                        atmanager.TransferFunds(pin, amount, accountType = 'C');
                        TXTaccinfo.Text += " " + Environment.NewLine;
                        TXTaccinfo.Text += "Completed: Transfered From *Chequing to *Savings";
                        TXTaccinfo.Text += " " + Environment.NewLine;
                        TXTaccinfo.Text += atmanager.GetAccounts(pin);

                    }
                    if (CHKdeposit.Checked)// if chequing selected and deposit selected do this
                    {
                        atmanager.DepositChequing(pin,amount);
                        TXTaccinfo.Text += "***UPDATED***";
                        TXTaccinfo.Text += atmanager.GetAccounts(pin);//(good)
                    }
                    else
                    {
                        if (CHKwithdraw.Checked)// else if not deposit then withdraw
                        {
                            if (amount % 20 != 0)
                            {
                                System.Windows.Forms.MessageBox.Show("Please Enter Withdraw Amount Divisble by 20");
                            }
                            else
                            {
                                atmanager.WithdrawChequing(pin, amount);
                                TXTaccinfo.Text += "***UPDATED***";
                                TXTaccinfo.Text += atmanager.GetAccounts(pin);
                            }
                            
                        }
                    }
                }//if (CHKchequing.Checked)
            }//else (CHKsavings.Checked)

        }//enter button
    }
}
