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
    public partial class CancelApp : Form
    {
        public CancelApp()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("canceled ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@d_id", SqlDbType.Int).Value = var_text.text1;
                cmd.Parameters.Add("@time", SqlDbType.Float).Value = textBox1.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("This Appointment was canceld");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void CancelApp_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
