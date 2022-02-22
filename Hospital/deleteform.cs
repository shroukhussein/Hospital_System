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
    public partial class deleteform : Form
    {
        public deleteform()
        {
            InitializeComponent();
        }

        private void deleteform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from doc2  where doc_id='" + textBox1.Text + "'";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted succesfully");
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Check it Again");
            }
        }

        private void deleteform_FormClosing(object sender, FormClosingEventArgs e)
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
