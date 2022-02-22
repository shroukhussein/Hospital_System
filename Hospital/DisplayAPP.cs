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
    public partial class DisplayAPP : Form
    {
        public DisplayAPP()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("displaytbl", con);

            SqlParameter paramsearch = new SqlParameter("@id", var_text.text1);
            cmd.Parameters.Add(paramsearch);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader r = cmd.ExecuteReader();
            DataTable disp_pat = new DataTable();
            disp_pat.Columns.Add("patient_id");
            disp_pat.Columns.Add("daay");
            disp_pat.Columns.Add("Time");

            DataRow row;
            while (r.Read())
            {
                row = disp_pat.NewRow();
                row["patient_id"] = r["patient_id"];
                row["daay"] = r["daay"];
                row["Time"] = r["Time"];

                disp_pat.Rows.Add(row);

            }
            r.Close();
            con.Close();
            dataGridView2.DataSource = disp_pat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelApp fm11 = new CancelApp();
            fm11.Show();
            
        }

        private void DisplayAPP_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
