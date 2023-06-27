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
    public partial class splash_screen : Form
    {
       
        public splash_screen()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            timer1.Enabled = false;
            this.Hide();
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {

        }

       
    }
}
