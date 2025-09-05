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
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
        }

        private void SalesControl_Load(object sender, EventArgs e)
        {
            // Fill both tables
            this.saleNEWTableAdapter.Fill(this.saleDataSet.SaleNEW);
            this.saleItemNEWTableAdapter.Fill(this.saleDataSet.SaleItemNEW);

            // Bind sales list
            dgvSales.DataSource = saleDataSet.SaleNEW;
            foreach (DataGridViewColumn col in dgvSales.Columns)
            {
                Console.WriteLine(col.Name);
            }


            // Optional: Clear the sale item grid
            dgvSaleItem.DataSource = null;


            btnMakeSale.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F
            btnMakeSale.ForeColor = Color.White;
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected sale ID
                int saleId = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["saleIDDataGridViewTextBoxColumn"].Value);

                // Filter the SaleItemNEW DataTable using Select()
                DataRow[] matchedRows = saleDataSet.SaleItemNEW.Select($"SaleID = {saleId}");

                if (matchedRows.Length > 0)
                {
                    // Convert array to a new DataTable
                    DataTable filteredTable = matchedRows.CopyToDataTable();
                    dgvSaleItem.DataSource = filteredTable;
                }
                else
                {
                    dgvSaleItem.DataSource = null;
                }
            }
        }

        private void txtSearchSale_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = saleDataSet.SaleNEW;

            string search = txtSearchSale.Text.Trim();

            bs.Filter = $"Convert(SaleID, 'System.String') LIKE '%{search}%' " +
                        $"OR Convert(CustomerID, 'System.String') LIKE '%{search}%' " +
                        $"OR PaymentType LIKE '%{search}%' " +
                        $"OR Convert(SaleDate, 'System.String') LIKE '%{search}%'";

            dgvSales.DataSource = bs;
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSaleItem.Visible = true;
            
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get the selected SaleID
                    object value = dgvSales.Rows[e.RowIndex].Cells["saleIDDataGridViewTextBoxColumn"].Value;
                    if (value != null)
                    {
                        int saleId = Convert.ToInt32(value);

                        // Filter sale items using Select
                        DataRow[] filteredRows = saleDataSet.SaleItemNEW.Select($"SaleID = {saleId}");

                        if (filteredRows.Length > 0)
                        {
                            // Copy the filtered rows to a new DataTable
                            DataTable filteredTable = filteredRows.CopyToDataTable();
                            dgvSaleItem.DataSource = filteredTable;
                        }
                        else
                        {
                            dgvSaleItem.DataSource = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("SaleID is null for selected row.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Sale Items: " + ex.Message);
                }
            }
            
            
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            Form3 saleForm = new Form3();
            saleForm.ShowDialog();
            this.saleNEWTableAdapter.Fill(this.saleDataSet.SaleNEW);
            this.saleItemNEWTableAdapter.Fill(this.saleDataSet.SaleItemNEW);
        }
    }

}
