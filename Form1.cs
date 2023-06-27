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
    public partial class Login : Form
    {
        int numenteries = 0;
        private ATMManager atmManager = new ATMManager();
        
        private string pin;
       // private bool customerread;
       // private bool accountread;

        
        public Login()
        {
            InitializeComponent();

        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

        }

        private void TXTname_KeyDown(object sender, KeyEventArgs e)
        {
            if (TXTname.Text.Equals("ENTER NAME") == true)
            {
                TXTname.Text = "";
                TXTname.ForeColor = Color.Black;
            }
        }

        private void TXTname_KeyUp(object sender, KeyEventArgs e)
        {
            if (TXTname.Text.Equals(null) == true || TXTname.Text.Equals("") == true)
            {
                TXTname.Text = "ENTER NAME";
                TXTname.ForeColor = Color.Gray;
            }
        }

        private void TXTname_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.IBeam;
        }

        private void TXTpin_KeyDown(object sender, KeyEventArgs e)
        {
            if (TXTpin.Text.Equals("PIN") == true)
            {
                TXTpin.Text = "";
                TXTpin.PasswordChar = '*';
                TXTpin.ForeColor = Color.Black;
            }
        }

        private void TXTpin_KeyUp(object sender, KeyEventArgs e)
        {
            if (TXTpin.Text.Equals(null) == true || TXTpin.Text.Equals("") == true)
            {
                TXTpin.PasswordChar = '\0';
                TXTpin.Text = "PIN";
                TXTpin.ForeColor = Color.Gray;
            }
        }

        private void TXTpin_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.IBeam;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Login_Activated(object sender, EventArgs e)
        {
            TXTname.SelectionStart = 0;
            TXTname.SelectionLength = 0;
            TXTname.ForeColor = Color.Gray;
            TXTpin.SelectionStart = 0;
            TXTpin.SelectionLength = 0;
            TXTpin.ForeColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if(this.Opacity== 100)
            {
                timer1.Enabled = true;
            }
        }

        private void TXTclear()
        {
            TXTname.Clear();
            TXTname.Text = "ENTER NAME";
            TXTname.ForeColor = Color.Gray;

            TXTpin.Clear();
            TXTpin.PasswordChar = '\0';
            TXTpin.Text = "PIN";
            TXTpin.ForeColor = Color.Gray;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            TXTclear();
        
        }

        private void btncorrect_Click(object sender, EventArgs e)
        {
            TXTpin.Text = TXTpin.Text.Substring(0, TXTpin.Text.Length - 1);

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((TXTname.ForeColor == Color.Gray) || (TXTpin.ForeColor == Color.Gray))
            {
                MessageBox.Show("Username and Pin Required.Try Again");
                numenteries++;
                
            }
            else
            {
                atmManager.ReadCustomers();
                atmManager.ReadAccounts();
                pin = TXTpin.Text.ToUpper();
                string name = TXTname.Text;

                bool good = atmManager.CheckUser(name, pin);

                    if (good == true)
                    {
                        TXTclear();
                        if (name == "Korben Dallas")
                        {
                            
                            this.Hide();
                            Supervisor supervisor = new Supervisor(pin, atmManager, this);
                            supervisor.Visible = true;
                            supervisor.Activate();
                        }

                        else
                        {
                            this.Hide();
                            Account account = new Account(pin,atmManager,this);
                            account.Visible = true;
                            account.Activate();
                        }
                    }
            }

            if (numenteries >= 3)
            {
                MessageBox.Show("Too Many Incorrect Enteries.Program will now Exit");
                Application.Exit();
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;// use 1 event for the pin
            TXTpin.ForeColor = Color.Black;//et black
            TXTpin.PasswordChar = '*';//set pass key
            if (TXTpin.Text == "PIN")// if its PIN then put button click to text and it takes its number name.
            {
                TXTpin.Text = b.Text;
            }
            else
            {
                TXTpin.Text += b.Text;// this adds the button numbers clicked one after another.
            }

        }

        

        

        

        
        

    }
}
