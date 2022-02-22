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

namespace hospital
{
    public partial class adminform3 : Form
    {
        public adminform3()
        {
            InitializeComponent();
        }

        private void adminform3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            insertform myform = new insertform();

            myform.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            updateform myform = new updateform();

            myform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            deleteform myform = new deleteform();

            myform.Show();

        }

        private void adminform3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform2 fm2 = new adminform2();
            fm2.Show();
        }
    }
}
