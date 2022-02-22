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
    public partial class insertform : Form
    {
        public insertform()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert  into doc2  values(@id,@name,@tel,@spec,@rate,@affiliation)", con);

                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@tel", textBox4.Text);
                cmd.Parameters.AddWithValue("@spec", textBox5.Text);
                cmd.Parameters.AddWithValue("@rate", textBox6.Text);
                cmd.Parameters.AddWithValue("@affiliation", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted succesfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check it Again");
            }


        }

        private void insertform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            displaydocform myform = new displaydocform();

            myform.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform3 fm3 = new adminform3();
            fm3.Show();
        }
    }
}
