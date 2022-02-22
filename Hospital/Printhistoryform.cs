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
    public partial class Printhistoryform : Form
    {
        public Printhistoryform()
        {
            InitializeComponent();

        }

        private void Printpatientform_Load(object sender, EventArgs e)
        {

        }

        private void Printpatientform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from History where pat_id='" + textBox1.Text + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tbl_History = new DataTable();
                tbl_History.Columns.Add("PatientID");
                tbl_History.Columns.Add("History");

                DataRow row;

                while (reader.Read())

                {
                    row = tbl_History.NewRow();
                    row["PatientID"] = reader["pat_id"];
                    row["History"] = reader["History"];
                    tbl_History.Rows.Add(row);

                }
                reader.Close();
                con.Close();
                dataGridView1.DataSource = tbl_History;
            }catch(Exception ex)
            {
                MessageBox.Show("Check it Again");
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminform2 fm2 = new adminform2();
            fm2.Show();
        }
    }
}
