using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_management_system_GP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }
        public static string AccNum;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number: " + LogIn.AccNum;
            AccNum = LogIn.AccNum;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
            AccNumlbl.Text = "Account Number: " + LogIn.AccNum;
            AccNum=LogIn.AccNum;
            
        }

        private void FastCash_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();    
            this.Hide();
        }

        private void MiniStatement_Click(object sender, EventArgs e)
        {
            MiniStatement ms = new MiniStatement(); 
            ms.Show();
            this.Hide();
        }

        private void ChangePin_Click(object sender, EventArgs e)
        {
            ChangePin cp = new ChangePin();
            cp.Show();
            this.Hide();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Widthraw withdraw = new Widthraw();
            withdraw.Show();
            this.Hide();
        }
    }
}
