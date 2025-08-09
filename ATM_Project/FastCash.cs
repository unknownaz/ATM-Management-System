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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string AccNum = LogIn.AccNum;
        int bal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum =" + AccNum + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Rs " + dt.Rows[0][0].ToString();
            bal =Convert.ToInt32(dt.Rows[0][0].ToString()); 
            con.Close();
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            getbalance();   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bal<100){
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 100;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction1();  
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }   
            }
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction4();  
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction5();  
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        //int amt1=100,amt2=500,amt3=1000,amt4=2000,amt5=5000,amt6=10000;
        private void addtransaction1()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 100 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction2()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 500 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction3()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 1000 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction4()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 2000 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction5()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 5000 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction6()
        {
            string trtype = "FastCash";
            try
            {
                con.Open();
                String query = "INSERT INTO Transactiontbl VALUES ('" + AccNum + "', '" + trtype + "', '" + 10000 + "', '" + DateTime.Today.Date.ToString() + "')";

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
        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("balance can't be negative or insufficient balance");

            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance= " + newbalance + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                    con.Close();
                    addtransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
