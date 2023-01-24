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
    public partial class Doctor : Form
    {
        public Doctor()
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
            String doctor_id = textBox1.Text;
            String doctor_name = textBox2.Text;
            String experience = textBox3.Text;
            String password = textBox4.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString =  "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into doctor_HMSys (doctor_id, doctor_name, experience, password) values ('" + doctor_id + "', '" + doctor_name + "', '" + experience + "', '" + password + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String doctor_id = textBox1.Text;
            String doctor_name = textBox2.Text;
            String experience = textBox3.Text;
            String password = textBox4.Text;

            if (MessageBox.Show("Data will be updated.Confirm?", "Success.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update doctor_HMSys set doctor_id = '" + doctor_id + "', doctor_name = '" + doctor_name + "', experience = '" + experience + "', password = '" + password + "' where id = '" + rowid + "'  ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Doctor_Load(this, null);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Dleted.Confirm?", "Deleted.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from doctor_HMSys where id = '" + rowid + "'  ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Doctor_Load(this, null);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
        }

        private void DoctordataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from doctor_HMSys";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DoctordataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from doctor_HMSys where doctor_id LIKE '"+txtSearch.Text+"%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DoctordataGridView1.DataSource = ds.Tables[0];
            }
        }

        int bid;
        Int64 rowid;
        private void DoctordataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DoctordataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DoctordataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from doctor_HMSys where id LIKE '" + bid + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][4].ToString();

        }
    }
}
