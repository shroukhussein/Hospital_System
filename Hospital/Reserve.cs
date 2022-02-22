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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"Select doc2. Doc_id, Name, Rate, Day, start_Time, End_time from doc2 inner join working_hours on " +
                                                "doc2.Doc_id = working_hours.Doc_id " +
                                                "where Speciality = @spec", con);
                SqlParameter paramsearch = new SqlParameter("@spec", comboBox2.SelectedItem);
                cmd.Parameters.Add(paramsearch);
                cmd.CommandType = CommandType.Text;
                SqlDataReader r = cmd.ExecuteReader();
                DataTable tbl_doc = new DataTable();
                tbl_doc.Columns.Add("Doc_id");
                tbl_doc.Columns.Add("Name");
                tbl_doc.Columns.Add("Rate");
                tbl_doc.Columns.Add("Day");
                tbl_doc.Columns.Add("start_Time");
                tbl_doc.Columns.Add("End_Time");
                DataRow row;
                while (r.Read())
                {
                    row = tbl_doc.NewRow();
                    row["Doc_id"] = r["Doc_id"];
                    row["Name"] = r["Name"];
                    row["Rate"] = r["Rate"];
                    row["Day"] = r["Day"];
                    row["start_Time"] = r["start_Time"];
                    row["End_Time"] = r["End_Time"];
                    tbl_doc.Rows.Add(row);

                }
                r.Close();
                con.Close();
                dataGridView1.DataSource = tbl_doc;
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("reserved", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pat_id", SqlDbType.Int).Value = var_text2.text2;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBox2.Text;
            cmd.Parameters.Add("@Daay", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@Time", SqlDbType.Float).Value = textBox4.Text;
            SqlParameter RuturnValue = new SqlParameter("@@result", SqlDbType.NVarChar,200);
            RuturnValue.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(RuturnValue);
            cmd.ExecuteNonQuery();
            MessageBox.Show((string)cmd.Parameters["@@result"].Value.ToString());
            
            con.Close();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Reserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
