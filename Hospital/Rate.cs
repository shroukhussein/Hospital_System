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
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Raatee ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                cmd.Parameters.Add("@rate", SqlDbType.Int).Value = textBox2.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thank You for Ratting");

            } catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void Rate_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
