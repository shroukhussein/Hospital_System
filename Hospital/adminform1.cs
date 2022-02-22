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
    public partial class adminform1 : Form
    {
        public adminform1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text=="Radwa" && textBox2.Text=="123456") || (textBox1.Text == "Shrouk" && textBox2.Text == "654321"))
            {
                this.Hide();

                adminform2 myfrom = new adminform2();

               
                myfrom.Show();

                    }
            else
            {
                MessageBox.Show("Username or Password is incorrect");

            }


        }

        private void adminform1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
    }

