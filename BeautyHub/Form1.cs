using BeautyHub.SpaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.staffNEWTableAdapter1.Fill(this.spaDataSet1.StaffNEW);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.WhiteSmoke;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            staffNEWTableAdapter1.CheckLogin(spaDataSet1.StaffNEW, txtLogin.Text, txtPassword.Text);
            
            if (spaDataSet1.StaffNEW.Rows.Count > 0)
            {
                Form2 main = new Form2();
                MessageBox.Show("Welcome User "+ txtLogin.Text);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login Failed");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
