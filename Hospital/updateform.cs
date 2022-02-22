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
    public partial class updateform : Form
    {
        public updateform()
        {
            InitializeComponent();
        }

        private void updateform_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update doc2 set name='" + textBox2.Text + "',Telphone='" + textBox4.Text + "',Speciality='" + textBox5.Text + "' ,Rate='" + textBox6.Text + "'  where doc_id='" + textBox1.Text + "'";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated succesfully");
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Check it Again");
            }
        }

        private void updateform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            displaydocform myform = new displaydocform();

            myform.Show();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform3 fm3 = new adminform3();
            fm3.Show();
        }
    }
}
