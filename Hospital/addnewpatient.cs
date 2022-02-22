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
    public partial class addnewpatient : Form
    {
        public addnewpatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert  into patient values(@id,@name,@phone,@bloodpressure,@diabetic,@payement)", con);

                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@bloodpressure", textBox4.Text);
                cmd.Parameters.AddWithValue("@diabetic", textBox5.Text);
                cmd.Parameters.AddWithValue("@payement", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted succesfully");
                con.Close();
            }catch(Exception eX)
            {
                MessageBox.Show("Check it Again");
            }
        }

        private void addnewpatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            displaypatform myform = new displaypatform();
            myform.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform2 fm2 = new adminform2();
            fm2.Show();
        }
    }
}
