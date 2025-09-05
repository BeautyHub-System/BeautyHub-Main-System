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
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
            //this.Load += StaffControl_Load;
        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);
            dgvStaff.DataSource = spaDataSet.StaffNEW;
            dgvStaff.CellFormatting += dgvStaff_CellFormatting;

            dgvStaff.AutoGenerateColumns = true;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStaff.DefaultCellStyle.Font = new Font("Segoe UI", 13);
            dgvStaff.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.MultiSelect = false;


            foreach (DataGridViewColumn col in dgvStaff.Columns)
            {
                Console.WriteLine("Column Name: " + col.Name);
            }

            cbFilter.Items.Clear();
            cbFilter.Items.Add("All");         // default option
            cbFilter.Items.Add("Available");
            cbFilter.Items.Add("On Leave");
            cbFilter.SelectedIndex = 0;        // set to "All"

            btnAddStaff.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F



        }

        private void dgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Available")
                {
                    dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Honeydew; // light green
                }
                else if (status == "On Leave")
                {
                    dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose; // light red
                }
            }
            
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm addForm = new AddStaffForm ();
            addForm.ShowDialog();
            RefreshStaffData();
        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStaff.Text.Trim().ToLower();

            if (staffNEWTableAdapter == null) return;

            var dt = staffNEWTableAdapter.GetData();

            var filtered = dt.Where(row =>
                row.FirstName.ToLower().Contains(searchText) ||
                row.LastName.ToLower().Contains(searchText)
            ).ToList();

            if (filtered.Count > 0)
                dgvStaff.DataSource = filtered.CopyToDataTable();
            else
                dgvStaff.DataSource = null;

        }

        public void RefreshStaffData()
        {
            
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
                if (!isActive)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW); // Update with your dataset/table names
            dgvStaff.DataSource = spaDataSet.StaffNEW;
            dgvStaff.CellFormatting += dgvStaff_CellFormatting;

            dgvStaff.AutoGenerateColumns = true;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStaff.DefaultCellStyle.Font = new Font("Segoe UI", 13);
            dgvStaff.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.MultiSelect = false;

        }


        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                var row = dgvStaff.CurrentRow;

                int staffId = Convert.ToInt32(row.Cells["StaffID"].Value);
                string firstName = row.Cells["FirstName"].Value.ToString();
                string lastName = row.Cells["LastName"].Value.ToString();
                string phone = row.Cells["Phone"].Value?.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();
                bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
                string username = row.Cells["Username"].Value.ToString();
                string password = row.Cells["PasswordHash"].Value.ToString();

                EditStaffForm editForm = new EditStaffForm(
                    staffId, firstName, lastName, phone, email, role, status, isActive, username, password);
                editForm.ShowDialog();

                
            }
            RefreshStaffData(); // Refresh the grid after editing

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member to archive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];
            int staffId = Convert.ToInt32(selectedRow.Cells["StaffID"].Value);
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to archive staff member:\n\n{firstName} {lastName} (ID: {staffId})?",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Set isActive to false
                    staffNEWTableAdapter.UpdateIsActiveByStaffID(false, staffId);
                    MessageBox.Show("Staff member archived successfully.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshStaffData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to archive staff: " + ex.Message);
                }
            }
            RefreshStaffData();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cbFilter.SelectedItem.ToString();

            var dt = staffNEWTableAdapter.GetData();

            if (selectedStatus == "All")
            {
                dgvStaff.DataSource = dt;
            }
            else
            {
                var filtered = dt.Where(row => row.Status == selectedStatus).ToList();

                dgvStaff.DataSource = filtered.Count > 0 ? filtered.CopyToDataTable() : null;
            }
        }
    }
}
