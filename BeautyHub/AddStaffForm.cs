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
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            AddComboBoxItems();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.StaffNEW' table. You can move, or remove it, as needed.
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            btnSaveStaff.BackColor = Color.FromArgb(42, 157, 143);
            btnSaveStaff.ForeColor = Color.White;
            btnSaveStaff.FlatStyle = FlatStyle.Flat;
            btnSaveStaff.FlatAppearance.BorderSize = 0;


            label10.ForeColor = Color.DarkSlateGray;


        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            // Step-by-step validation with specific messages
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
                MessageBox.Show("Please enter a valid phone number (digits only).", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtEmail))
            {
                MessageBox.Show("Email is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtUserName))
            {
                MessageBox.Show("Username is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtPassword))
            {
                MessageBox.Show("Password is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtConfirmPassword))
            {
                MessageBox.Show("Please confirm your password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (!DashboardControl.isPasswordsSame(txtPassword, txtConfirmPassword))
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (!DashboardControl.IsComboBoxSelected(cbRole))
            {
                MessageBox.Show("Please select a role.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRole.Focus();
                return;
            }

            if (!DashboardControl.IsComboBoxSelected(cbStatus))
            {
                MessageBox.Show("Please select a status.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
                return;
            }

            
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
            string status = cbStatus.SelectedItem.ToString();
            bool isActive = checkBoxActive.Checked;
            string username = txtUserName.Text.Trim();
            string passwordHash = txtPassword.Text.Trim(); // Hash later

            
            string summaryMessage =
                $"Please confirm the New Staff Members details:\n\n" +
                $"👤 FIRST NAME: {firstName}\n" +
                $"👤 lAST NAME: {lastName}\n" +
                $"PHONE NUMBER: {phone}\n" +
                $"EMAIL ADDRESS: {email}\n" +
                $"ROLE: {role}\n" +
                $"📌 Status: {status}\n" +
                $"📌 USER NAME: {username}\n\n" +
                "Do you want to proceed with saving this New Staff members information?";

            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                summaryMessage,
                "Confirm Details",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("New Staff memeber was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            try
            {
                staffNEWTableAdapter.Insert(firstName, lastName, phone, email, role, status, isActive, username, passwordHash);
                MessageBox.Show("Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add staff: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }








        private void AddComboBoxItems()
        {
            cbRole.Items.AddRange(new string[] { "Manager", "Receptionist", "Beautician", "Therapist", "Cleaner" });
            cbStatus.Items.AddRange(new string[] { "Available", "Busy", "On Leave", "Inactive" });
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore key press
            }
        }
    }
}
