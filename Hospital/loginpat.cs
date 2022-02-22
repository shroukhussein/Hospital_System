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
    public partial class loginpat : Form
    {
        public loginpat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select * from patient where pat_id=@id and name=@Name", con);
                com.Parameters.AddWithValue("@id", var_text2.text2 = patid.Text);
                com.Parameters.AddWithValue("@Name", textBox2.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows == true)
                {
                    this.Hide();
                    patFunction fm6 = new patFunction();
                    fm6.Show();
                }
                else
                {
                    MessageBox.Show("check your id and name again");

                }
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Check it Again");
            }
            }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginpat_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
