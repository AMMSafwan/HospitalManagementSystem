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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
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
            String diagnosis_id = DiaID.Text;
            String patient_id = ptID.Text;
            String patient_name = ptName.Text;
            String symptoms = DiaSymp.Text;
            String diagnosis = diagno.Text;
            String medicines = Medicin.Text;

            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            Con.Open();
            cmd.CommandText = "insert into Diagnosis_HMSys (diagnosis_id, patient_id, patient_name, symptoms, diagnosis, medicines) values ('" + diagnosis_id + "', '" + patient_id + "', '" + patient_name + "', '" + symptoms + "', '" + diagnosis + "', '" + medicines + "')";
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DiaID.Clear();
            ptID.Clear();
            ptName.Clear();
            DiaSymp.Clear();
            diagno.Clear();
            Medicin.Clear();

        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "select * from Diagnosis_HMSys";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DiagnosdataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "select * from Diagnosis_HMSys where diagnosis_id LIKE '"+ txtSearch.Text +"%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DiagnosdataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void DiagnosdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DiagnosdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DiagnosdataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "select * from Diagnosis_HMSys where id LIKE '" + bid + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            DiaID.Text = ds.Tables[0].Rows[0][1].ToString();
            ptID.Text = ds.Tables[0].Rows[0][2].ToString();
            ptName.Text = ds.Tables[0].Rows[0][3].ToString();
            DiaSymp.Text = ds.Tables[0].Rows[0][4].ToString();
            diagno.Text = ds.Tables[0].Rows[0][5].ToString();
            Medicin.Text = ds.Tables[0].Rows[0][6].ToString();
            patientnametxt.Text = ds.Tables[0].Rows[0][3].ToString();
            diagnosistxt.Text = ds.Tables[0].Rows[0][5].ToString();
            symptomstxt.Text = ds.Tables[0].Rows[0][4].ToString();
            medicinestxt.Text = ds.Tables[0].Rows[0][6].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String diagnosis_id = DiaID.Text;
            String patient_id = ptID.Text;
            String patient_name = ptName.Text;
            String symptoms = DiaSymp.Text;
            String diagnosis = diagno.Text;
            String medicines = Medicin.Text;

            if (MessageBox.Show("Data will be updated. Confirm?", "Success.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection Con = new SqlConnection();
                Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "update Diagnosis_HMSys set diagnosis_id = '" + diagnosis_id + "', patient_id = '" + patient_id + "', patient_name = '" + patient_name + "', symptoms = '" + symptoms + "', diagnosis = '" + diagnosis + "', medicines = '" + medicines + "' where id = '"+rowid+"' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Diagnosis_Load(this, null);

                DiaID.Clear();
                ptID.Clear();
                ptName.Clear();
                DiaSymp.Clear();
                diagno.Clear();
                Medicin.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "deleted.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection Con = new SqlConnection();
                Con.ConnectionString = "data source = DESKTOP-DO1KHSV; database = HMSys; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "delete from Diagnosis_HMSys where id = '" + rowid + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Diagnosis_Load(this, null);

                DiaID.Clear();
                ptID.Clear();
                ptName.Clear();
                DiaSymp.Clear();
                diagno.Clear();
                Medicin.Clear();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label12.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(230));
            
            e.Graphics.DrawString(PatientNamelbl.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130, 150)); 
            e.Graphics.DrawString(patientnametxt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point (160,180));
            e.Graphics.DrawString(Diagnosislbl.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130, 210));
            e.Graphics.DrawString(diagnosistxt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(160, 240));
            e.Graphics.DrawString(Symptomslbl.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130, 270));
            e.Graphics.DrawString(symptomstxt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(160, 300));
            e.Graphics.DrawString(Medicineslbl.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130, 330));
            e.Graphics.DrawString(medicinestxt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(160, 360));
            e.Graphics.DrawString(label7.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130, 390));
            e.Graphics.DrawString(textBox5.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(160, 420));

            e.Graphics.DrawString(label8.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230,630));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
