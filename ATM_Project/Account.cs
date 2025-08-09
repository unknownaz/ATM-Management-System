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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNotb.Text == "" || fnametb.Text == "" || phonetb.Text == "" || addrtb.Text == "" || occtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "insert into AccountTbl values(" + AccNotb.Text + ",'" +nametb.Text+"','"+fnametb.Text + "','" + dobtb.Value.Date  + "','" + addrtb.Text + "','" + phonetb.Text + "','" + edutb.SelectedItem.ToString() + "','" + occtb.Text + "','" + pintb.Text + "','" + bal + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    con.Close();
                    LogIn log = new LogIn();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}