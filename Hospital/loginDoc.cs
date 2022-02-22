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
    public partial class loginDoc : Form
    {
        public loginDoc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select * from doc2  where Doc_id=@id and Name=@name", con);
            com.Parameters.AddWithValue("@id", var_text.text1 = docid.Text);
            com.Parameters.AddWithValue("@name",textBox2.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                this.Hide();
                docFun fm12 = new docFun();
                fm12.Show();
                
            }
        
        
            else
            {
                MessageBox.Show("check your id and name again");

            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loginDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
