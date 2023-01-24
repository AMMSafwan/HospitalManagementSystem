using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSys
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D = new Dashboard();
            D.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String patient_id = ptID.Text;
            String patient_name = ptName.Text;
            String patient_address = ptAddress.Text;
            Int64 patient_phone = Int64.Parse(ptPhone.Text);
            String patient_age = ptAge.Text;
            String gender = Gender.Text;
            String blood_group = BloodGroup.Text;
            String major_disease = MajorDisease.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into Patient_HMSys (patient_id, patient_name, patient_address, patient_phone, patient_age, gender, blood_group, major_disease) values ('"+ patient_id +"', '"+ patient_name +"', '"+ patient_address +"', '"+ patient_phone +"', '"+ patient_age +"', '"+ gender +"', '"+ blood_group +"', '"+ major_disease +"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ptID.Clear();
            ptName.Clear();
            ptAddress.Clear();
            ptPhone.Clear();
            ptAge.Clear();
            Gender.Text = String.Empty;
            BloodGroup.Text = String.Empty;
            MajorDisease.Clear();


        }

        private void Patient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Patient_HMSys";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            PatientdataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from patient_HMSys where patient_id LIKE '"+ txtSearch.Text+"%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                PatientdataGridView1.DataSource = ds.Tables[0];
            }
        }

        int bid;
        Int64 rowid;
        private void PatientdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PatientdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(PatientdataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from patient_HMSys where id LIKE '" + bid + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            ptID.Text = ds.Tables[0].Rows[0][1].ToString();
            ptName.Text = ds.Tables[0].Rows[0][2].ToString();
            ptAddress.Text = ds.Tables[0].Rows[0][3].ToString();
            ptPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            ptAge.Text = ds.Tables[0].Rows[0][5].ToString();
            Gender.Text = ds.Tables[0].Rows[0][6].ToString();
            BloodGroup.Text = ds.Tables[0].Rows[0][7].ToString();
            MajorDisease.Text = ds.Tables[0].Rows[0][8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String patient_id = ptID.Text;
            String patient_name = ptName.Text;
            String patient_address = ptAddress.Text;
            Int64 patient_phone = Int64.Parse(ptPhone.Text);
            String patient_age = ptAge.Text;
            String gender = Gender.Text;
            String blood_group = BloodGroup.Text;
            String major_disease = MajorDisease.Text;

            if (MessageBox.Show("Data will be updated.Confirm?", "Success.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Patient_HMSys set patient_id = '" + patient_id + "', patient_name = '" + patient_name + "', patient_address = '" + patient_address + "', patient_phone = '" + patient_phone + "', patient_age = '" + patient_age + "', gender = '" + gender + "', blood_group = '" + blood_group + "', major_disease = '" + major_disease + "' where id = '"+rowid+"' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Patient_Load(this, null);

                ptID.Clear();
                ptName.Clear();
                ptAddress.Clear();
                ptPhone.Clear();
                ptAge.Clear();
                Gender.Text = String.Empty;
                BloodGroup.Text = String.Empty;
                MajorDisease.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted.Confirm?", "deleted.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Patient_HMSys where id = '" + rowid + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Patient_Load(this, null);

                ptID.Clear();
                ptName.Clear();
                ptAddress.Clear();
                ptPhone.Clear();
                ptAge.Clear();
                Gender.Text = String.Empty;
                BloodGroup.Text = String.Empty;
                MajorDisease.Clear();
            }
        }
    }
}
