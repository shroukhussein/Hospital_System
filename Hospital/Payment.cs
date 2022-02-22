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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("pay ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@p_id", SqlDbType.Int).Value = var_text2.text2;
                cmd.Parameters.Add("@method", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
                cmd.ExecuteNonQuery();
                MessageBox.Show("your Payment Method successfully saved");
            }
            catch (Exception ex) {
                MessageBox.Show("Error");
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
    }

