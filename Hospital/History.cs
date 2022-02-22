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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into History values(@pat_id,@history )", con);
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@pat_id", SqlDbType.Int).Value =textBox1.Text ;
            cmd.Parameters.Add("@history", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("History Was saved!!");

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
