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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBar1.Value = starting;
            persentage.Text = "" + starting;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                LogIn log = new LogIn();
                log.Show();
                this.Hide();    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void persentage_Click(object sender, EventArgs e)
        {

        }
    }
}
