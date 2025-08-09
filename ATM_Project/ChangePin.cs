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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string AccNum = LogIn.AccNum;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1tb.Text == "" || Pin2tb.Text=="")
            {
                MessageBox.Show("Enter and Confirm the new Pin");
            }
            else if (Pin1tb.Text != Pin2tb.Text)
            {
                MessageBox.Show("Pins do not match");
            }
            else
            {
                //newbalance = oldbalance + Convert.ToInt32(DepositAmttb.Text);
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Pin= " + Pin1tb.Text + " WHERE AccNum = " + AccNum + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Changed Successfully");
                    con.Close();
                    LogIn log = new LogIn();
                    log.Show();
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

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
    }
}
