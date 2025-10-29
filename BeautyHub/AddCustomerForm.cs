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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.CustomerNEW' table. You can move, or remove it, as needed.
            this.customerNEWTableAdapter.Fill(this.spaDataSet.CustomerNEW);

           
            cbGender.Items.Clear();
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Non-binary");

            cbGender.SelectedIndex = 0; 


            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            lblHeaderCustomer.ForeColor = Color.FromArgb(42, 157, 143); 



            btnSaveCustomer.BackColor = Color.FromArgb(42, 157, 143); 
            btnSaveCustomer.ForeColor = Color.White;
            btnSaveCustomer.FlatStyle = FlatStyle.Flat;
            btnSaveCustomer.FlatAppearance.BorderSize = 0;
            btnSaveCustomer.Cursor = Cursors.Hand;





        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
       

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            // Field-by-field validation
            if (!DashboardControl.IsNotEmpty(txtFirstName))
            {
                MessageBox.Show("First Name is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtLastName))
            {
                MessageBox.Show("Last Name is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (!DashboardControl.IsValidPhone(txtPhone))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (!DashboardControl.IsValidEmail(txtEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Confirm with user
            string summaryMessage =
                $"Please confirm the appointment details:\n\n" +
                $"👤 First Name: {txtFirstName.Text}\n" +
                $"👨‍⚕️ Last Name: {txtLastName.Text}\n" +
                $"👤 Phone Number: {txtPhone.Text}\n" +
                $"👤 Email Address: {txtEmail.Text}\n" +
                $"👤 Gender: {cbGender.SelectedItem.ToString()}\n\n" +
                 
                "Do you want to proceed with saving this Customers information?";


            // Confirmation dialog
            DialogResult result = MessageBox.Show(
                summaryMessage,
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return; 
            }

            
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = cbGender.SelectedItem?.ToString() ?? "Unspecified";
            bool isActive = true;
            string username = txtUserName.Text.Trim();
            string password = txtpassword.Text.Trim();

            string notes = txtNotes.Text.Trim();
            if (string.IsNullOrWhiteSpace(notes))
                notes = "No special requirements or allergies stated";

            notes = $"Gender: {gender} | {notes}";

            
            try
            {
                customerNEWTableAdapter.Insert(firstName, lastName, phone, email, notes, isActive,username,password);
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
