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
    public partial class Working_hours : Form
    {
        public Working_hours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Working_hours set Start_time='" + textBox1.Text + "',End_time='" + textBox2.Text + "' where doc_id='" + textBox3.Text + "'and day='" + textBox4.Text + "'";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated succesfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check it Again");
            }
        }

        private void Working_hours_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform2 fm2 = new adminform2();
            fm2.Show();
        }
    }
}
