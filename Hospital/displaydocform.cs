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
    public partial class displaydocform : Form
    {
        public displaydocform()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from doc2", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl_doc2 = new DataTable();
            tbl_doc2.Columns.Add("Doc_id");
            tbl_doc2.Columns.Add("Name");
            tbl_doc2.Columns.Add("Telphone");
            tbl_doc2.Columns.Add("Speciality");
            tbl_doc2.Columns.Add("Rate");
            DataRow row;

            while (reader.Read())

            {
                row = tbl_doc2.NewRow();
                row["Doc_id"] = reader["Doc_id"];
                row["Doc_id"] = reader["Doc_id"];
                row["Name"] = reader["Name"];
                row["Telphone"] = reader["Telphone"];
                row["Speciality"] = reader["Speciality"];
                row["Rate"] = reader["Rate"];
                tbl_doc2.Rows.Add(row);
               
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = tbl_doc2;

        }

        private void displayform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

             
        }

        private void displaydocform_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertform ins= new insertform();
            ins.Show();
        }
    }
}
