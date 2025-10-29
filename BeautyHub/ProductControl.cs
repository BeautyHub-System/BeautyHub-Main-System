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
    public partial class ProductControl : UserControl
    {

        private int lowStockThreshold = 10; // You can later make this user-configurable

        public ProductControl()
        {
            InitializeComponent();
            
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

            dgvProducts.AutoGenerateColumns = true;
            productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
            HighlightArchivedProducts();
            HighlightLowStockProducts();
            foreach (DataGridViewColumn col in dgvProducts.Columns)
            {
                Console.WriteLine("Column Name: " + col.Name);
            }
            btnAddProduct.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F
        }





        private void HighlightArchivedProducts()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["isActiveDataGridViewCheckBoxColumn"].Value != null &&
                    !(bool)row.Cells["isActiveDataGridViewCheckBoxColumn"].Value)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchProduct.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
            }
            else
            {
                productNEWTableAdapter.FillByProductName(spaDataSet.ProductNEW, searchTerm);
            }

            HighlightArchivedProducts(); // Keep the rows greyed out
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm();
            addForm.FormClosed += (s, args) =>
            {
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
                HighlightArchivedProducts();
            };
            addForm.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

            // Extract data from the selected row
            int productId = Convert.ToInt32(selectedRow.Cells["productIDDataGridViewTextBoxColumn"].Value);
            string name = selectedRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
            string description = selectedRow.Cells["descriptionDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            string category = selectedRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["priceDataGridViewTextBoxColumn"].Value);
            bool isPromo = Convert.ToBoolean(selectedRow.Cells["promotionDataGridViewCheckBoxColumn"].Value);
            string ImagePath = selectedRow.Cells["Image"].Value?.ToString() ?? "";

            // Nullable promotion price
            object promoVal = selectedRow.Cells["promotionPriceDataGridViewTextBoxColumn"].Value;
            decimal? promoPrice = promoVal != DBNull.Value ? Convert.ToDecimal(promoVal) : (decimal?)null;

            int stock = Convert.ToInt32(selectedRow.Cells["quantityInStockDataGridViewTextBoxColumn"].Value);
            bool isActive = Convert.ToBoolean(selectedRow.Cells["isActiveDataGridViewCheckBoxColumn"].Value);
            string imagePath = selectedRow.Cells["Image"].Value?.ToString() ?? "";

            // Open the edit form with values
            EditProductForm editForm = new EditProductForm(productId, name, description, category, price, isPromo, promoPrice, stock, isActive, imagePath);
            //editForm.ShowDialog();

            // Refresh the data after editing
            //productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
           
            editForm.FormClosed += (s, args) =>
            {
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
                HighlightArchivedProducts();
            };
            editForm.ShowDialog();
        }

        private void btnArchiveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to archive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvProducts.SelectedRows[0];

            int productId = Convert.ToInt32(selectedRow.Cells["productIDDataGridViewTextBoxColumn"].Value);
            string productName = selectedRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();

            var result = MessageBox.Show(
                $"Are you sure you want to archive this product?\n\nID: {productId}\nName: {productName}",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    productNEWTableAdapter.UpdateIsActiveByID(false, productId);  // We'll define this method next
                    MessageBox.Show("Product archived successfully.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid and highlight archived
                    productNEWTableAdapter.Fill(spaDataSet.ProductNEW);
                    HighlightArchivedProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to archive product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HighlightLowStockProducts()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["quantityInStockDataGridViewTextBoxColumn"].Value != null &&
                    int.TryParse(row.Cells["quantityInStockDataGridViewTextBoxColumn"].Value.ToString(), out int stock))
                {
                    if (stock <= lowStockThreshold &&
                        (bool)row.Cells["isActiveDataGridViewCheckBoxColumn"].Value) // Only highlight active ones
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }
        



    }
}
