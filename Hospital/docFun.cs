using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class docFun : Form
    {
        public docFun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayAPP fm10 = new DisplayAPP();
            fm10.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            History fm13 = new History();
            fm13.Show();
        }

        private void docFun_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
