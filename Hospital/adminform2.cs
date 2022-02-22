using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class adminform2 : Form
    {
        public adminform2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            adminform3 myform = new adminform3();

            myform.Show();




        }

        private void adminform2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void adminform2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            addnewpatient myform = new addnewpatient();
            myform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            Working_hours myform = new Working_hours();
            myform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Printhistoryform myform = new Printhistoryform();
            myform.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform1 fm1 = new adminform1();
            fm1.Show();
           
        }
    }
}
