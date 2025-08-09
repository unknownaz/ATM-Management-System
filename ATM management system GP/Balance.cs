using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_management_system_GP
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        public static string AccNum;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum ="+ AccNumlbl.Text+"" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text= "Rs "+dt.Rows[0][0].ToString();
            con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        //public static string AccNum;
        private void AccNumlbl_Click(object sender, EventArgs e)
        {
            //AccNumlbl.Text = Home.AccNum;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = LogIn.AccNum;
            AccNum = LogIn.AccNum;
            getbalance();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
            
        }
    }
}
