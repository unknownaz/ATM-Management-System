using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_management_system_GP
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string AccNum = LogIn.AccNum;
        //string trtype = "Deposit";
            private void addtransaction()
            {
                string trtype = "Deposit";
            try
                {
                    con.Open();
                    String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + DepositAmttb.Text + "', '" + DateTime.Today.Date.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Account Created Successfully");
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmttb.Text == "" || Convert.ToInt32(DepositAmttb.Text) <= 0)
            {
                MessageBox.Show("Please Enter Amount to Deposit");
            }
            else
            {   
                newbalance= oldbalance + Convert.ToInt32(DepositAmttb.Text);
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = " +newbalance+" WHERE AccNum = "+AccNum+ "" ;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Deposited Successfully");
                    con.Close();

                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home home=new Home();
            home.Show();
            this.Hide(); 
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum =" + AccNum + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32( dt.Rows[0][0].ToString());
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void DepositAmttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
