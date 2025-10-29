using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautyHub
{
    public partial class EditCustomerForm : Form
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public EditCustomerForm()
        {

            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.CustomerNEW' table. You can move, or remove it, as needed.
            this.customerNEWTableAdapter.Fill(this.spaDataSet.CustomerNEW);
            lblCustomerID.Text = CustomerID.ToString();
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtPhone.Text = Phone;
            txtEmail.Text = Email;
            txtNotes.Text = Notes;
            txtUsername.Text = Username;
            txtpassword.Text = Password;

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            btnSave.BackColor = Color.MidnightBlue;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;


            label1.ForeColor = Color.DarkSlateGray;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
             if (!DashboardControl.IsNotEmpty(txtFirstName)||!DashboardControl.IsNotEmpty(txtLastName)||!DashboardControl.IsValidPhone(txtPhone)||!DashboardControl.IsValidEmail(txtEmail) )
            {
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string notes = txtNotes.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtpassword.Text.Trim();


            try
            {
                customerNEWTableAdapter.UpdateCustomer(firstName, lastName, phone, email, notes,username,password, CustomerID);
                MessageBox.Show("Customer updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update customer: " + ex.Message);
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || ((sender as System.Windows.Forms.TextBox).TextLength >= 10)))
                e.Handled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
