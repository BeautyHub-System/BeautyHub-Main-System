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
    public partial class EditStaffForm : Form
    {
        

        int staffId = 0;
        public EditStaffForm(int id, string fname, string lname, string phone, string email,
                     string role, string status, bool isActive, string username, string password)
        {
            InitializeComponent();
            AddComboBoxItems();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            lblStaffID.Text = id.ToString();
            staffId = id;

            txtFirstName.Text = fname;
            txtLastName.Text = lname;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            cbRole.Text = role;
            cbStatus.Text = status;
            checkBoxActive.Checked = isActive;
            txtUsername.Text = username;
            txtPassword.Text = password; // or leave blank if not editable
            txtConfirmPassword.Text = password;
        }


        private void EditStaffForm_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'spaDataSet.StaffNEW' table. You can move, or remove it, as needed.
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            btnSave.BackColor = Color.MidnightBlue;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;


            label1.ForeColor = Color.DarkSlateGray;


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                staffNEWTableAdapter.UpdateStaff(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    cbRole.Text.Trim(),
                    cbStatus.Text.Trim(),
                    checkBoxActive.Checked,
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim(),  // Or use hashed password if enabled
                    staffId // 👈 The staff ID you're editing
                );

                MessageBox.Show("Staff information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update staff: " + ex.Message);
            }
        }


        private void AddComboBoxItems()
        {
            cbRole.Items.AddRange(new string[] { "Manager", "Receptionist", "Beautician", "Therapist", "Cleaner" });
            cbStatus.Items.AddRange(new string[] { "Available", "Busy", "On Leave", "Inactive" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DashboardControl.IsNotEmpty(txtFirstName) ||
                !DashboardControl.IsNotEmpty(txtLastName) ||
                !DashboardControl.IsValidPhone(txtPhone) ||
                !DashboardControl.IsNotEmpty(txtEmail) ||
                !DashboardControl.IsNotEmpty(txtUsername) ||
                !DashboardControl.IsNotEmpty(txtPassword) ||
                !DashboardControl.IsNotEmpty(txtConfirmPassword) ||
                !DashboardControl.IsComboBoxSelected(cbRole) ||
                !DashboardControl.IsComboBoxSelected(cbStatus))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check password match
            if (!DashboardControl.isPasswordsSame(txtPassword, txtConfirmPassword))
            {
                MessageBox.Show("Passwords do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
            string status = cbStatus.Text.Trim();
            bool isActive = checkBoxActive.Checked;
            string username = txtUsername.Text.Trim();
            string passwordHash = txtPassword.Text.Trim(); // Consider hashing

            try
            {
                staffNEWTableAdapter.UpdateStaff(firstName,lastName,phone,email,role,status,isActive,username,passwordHash,staffId);
                MessageBox.Show("Staff member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update staff: " + ex.Message);
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || ((sender as TextBox).TextLength >= 10)))
                e.Handled = true;

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
