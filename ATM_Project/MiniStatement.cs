using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_management_system_GP
{
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AbdulRehman\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        String AccNum = LogIn.AccNum;
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM TransactionTbl WHERE AccNum = '" + AccNum + "' ORDER BY TDate DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Ministatementdgv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
