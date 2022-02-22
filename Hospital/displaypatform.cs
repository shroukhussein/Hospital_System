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
    public partial class displaypatform : Form
    {
        public displaypatform()
        {

            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from patient", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl_patient = new DataTable();
            tbl_patient.Columns.Add("PatientID");
            tbl_patient.Columns.Add("PatientName");
            tbl_patient.Columns.Add("Phone");
            tbl_patient.Columns.Add("Blood_Pressure");
            tbl_patient.Columns.Add("Diabetic");
            tbl_patient.Columns.Add("payment");
            DataRow row;

            while (reader.Read())

            {
                row = tbl_patient.NewRow();
                row["PatientID"] = reader["pat_id"];
                row["PatientName"] = reader["name"];
                row["Phone"] = reader["phone"];
                row["Blood_Pressure"] = reader["Blood_pressure"];
                row["Diabetic"] = reader["Diabetic"];
                row["payment"] = reader["payment"];
                tbl_patient.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = tbl_patient;
        }

        private void displaypatform_Load(object sender, EventArgs e)
        {

        }

        private void displaypatform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            addnewpatient ap = new addnewpatient();
            ap.Show();
        }
    }
}
