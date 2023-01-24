using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSys
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void txtEnterName_Enter(object sender, EventArgs e)
        {
            if (txtEnterName.Text == "Enter Name")
            {
                txtEnterName.Text = "";
                txtEnterName.ForeColor = Color.Black;
            }
        }

        private void txtEnterName_Leave(object sender, EventArgs e)
        {
            if (txtEnterName.Text == "")
            {
                txtEnterName.Text = "Enter Name";
                txtEnterName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEnterName.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D = new Dashboard();
            D.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
