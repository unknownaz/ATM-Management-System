using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_management_system_GP
{
    public partial class Widthraw : Form
    {
        public Widthraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdulrehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string AccNum = LogIn.AccNum;
        int bal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum =" + AccNum + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Balance is Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void Widthraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addtransaction()
        {
            string trtype = "Widthraw";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" +withdrawtb.Text + "', '" + DateTime.Today.Date.ToString() + "')";

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

        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawtb.Text == "")
            {
                MessageBox.Show("Enter Amount :) Pleasse");
            }
            else if (Convert.ToInt32(withdrawtb.Text)<=0)
            {
                MessageBox.Show("Enter Valid Amount :) Pleasse");
            }
            else if (Convert.ToInt32(withdrawtb.Text) > bal)
            {
                MessageBox.Show("Insufficient Balance/ Balance can't be negative");
            }
            else
            {
                newbalance = bal - Convert.ToInt32(withdrawtb.Text);
                try
                {   
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Widthraw Successfully :) Pleasse");
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
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
