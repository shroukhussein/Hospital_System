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

namespace Hospital
{
    public partial class patFunction : Form
    {
        public patFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserve fm7 = new Reserve();
            fm7.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rate fm8 = new Rate();
            fm8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment fm9 = new Payment();
            fm9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void patFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
