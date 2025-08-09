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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static string AccNum;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTbl WHERE AccNum = @acc AND Pin = @pin", con);
                sda.SelectCommand.Parameters.AddWithValue("@acc", AccNumtb.Text);
                sda.SelectCommand.Parameters.AddWithValue("@pin", pintb.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {   AccNum = AccNumtb.Text;
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    //con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Account Number or Pin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
