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
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            this.Load += CustomerControl_Load;
            

        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = true;
            customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
            // dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;
            
            foreach (DataGridViewColumn col in dgvCustomers.Columns)
            {
                Console.WriteLine("Column Name: " + col.Name);
            }
            
            btnAddCustomer.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F


            HighlightArchivedCustomers();
        }

        



        private void HighlightArchivedCustomers()
        {
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (row.Cells["isActiveDataGridViewCheckBoxColumn"].Value != null &&
                    !(bool)row.Cells["isActiveDataGridViewCheckBoxColumn"].Value)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }
        

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchCustomer.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
            }
            else
            {
                customerNEWTableAdapter.FillByCustomerName(spaDataSet.CustomerNEW, searchTerm);
            }
            HighlightArchivedCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
                HighlightArchivedCustomers(); 
            }
            customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
            HighlightArchivedCustomers();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];

            EditCustomerForm editForm = new EditCustomerForm
            {
                CustomerID = Convert.ToInt32(row.Cells["customerIDDataGridViewTextBoxColumn"].Value),
                FirstName = row.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString(),
                LastName = row.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString(),
                Phone = row.Cells["phoneDataGridViewTextBoxColumn"].Value.ToString(),
                Email = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString(),
                Notes = row.Cells["notesDataGridViewTextBoxColumn"].Value.ToString(),
                Username = row.Cells["Username"].Value.ToString(),
                Password = row.Cells["Password"].Value.ToString()
            };

            editForm.ShowDialog();

            customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW); // Refresh
            HighlightArchivedCustomers(); // Optional: reapply styling
        }

        private void btnArchiveCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to archive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];

            int customerId = Convert.ToInt32(selectedRow.Cells["customerIDDataGridViewTextBoxColumn"].Value);
            string firstName = selectedRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            string lastName = selectedRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to archive this customer?\n\nCustomerID: {customerId}\nName: {firstName} {lastName}",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    customerNEWTableAdapter.ArchiveCustomer(false, customerId);
                    MessageBox.Show("Customer archived successfully.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
                    HighlightArchivedCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to archive customer: " + ex.Message);
                }
            }
        }

        
    }
}
