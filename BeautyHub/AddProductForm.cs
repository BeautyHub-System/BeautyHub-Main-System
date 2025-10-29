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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.ProductNEW' table. You can move, or remove it, as needed.
            this.productNEWTableAdapter.Fill(this.spaDataSet.ProductNEW);

            cbCategory.Items.Clear();
            cbCategory.Items.Add("Skincare");
            cbCategory.Items.Add("Haircare");
            cbCategory.Items.Add("Body");
            cbCategory.Items.Add("Fragrance");
            cbCategory.Items.Add("Tools");
            cbCategory.Items.Add("Other");

            cbCategory.SelectedIndex = 0; // Optional: selects the first item
            txtPromotionPrice.Enabled = false;

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            label1.ForeColor = Color.FromArgb(42, 157, 143); // #2A9D8F



            btnSaveProduct.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.Cursor = Cursors.Hand;

        }

        
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            // Check individual fields with specific messages
            if (!DashboardControl.IsNotEmpty(txtProductName))
            {
                MessageBox.Show("Product Name is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            if (!DashboardControl.IsComboBoxSelected(cbCategory))
            {
                MessageBox.Show("Please select a product category.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategory.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtPrice))
            {
                MessageBox.Show("Product Price is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Product Price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!DashboardControl.IsNotEmpty(txtStock))
            {
                MessageBox.Show("Stock Quantity is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Please enter a valid number for Stock Quantity.", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            // Handle promotion price if checked
            decimal? promoPrice = null;
            bool isPromo = hasPromotion.Checked;

            if (isPromo)
            {
                if (!DashboardControl.IsNotEmpty(txtPromotionPrice))
                {
                    MessageBox.Show("Promotion Price is required when promotion is active.", "Missing Promo Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPromotionPrice.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPromotionPrice.Text.Trim(), out decimal parsedPromo))
                {
                    MessageBox.Show("Please enter a valid number for Promotion Price.", "Invalid Promo Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPromotionPrice.Focus();
                    return;
                }

                promoPrice = parsedPromo;
            }

            // Capture values
            string name = txtProductName.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string category = cbCategory.SelectedItem?.ToString() ?? "Uncategorized";
            bool isActive = IsActive.Checked;
            string imagePath = txtImageURL.Text.Trim();

            // Save to DB
            try
            {
                // Make sure your Insert accepts nullable decimal for promoPrice
                productNEWTableAdapter.Insert(name, desc, category, price, isPromo, promoPrice, stock, isActive, imagePath);

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void productNEWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productNEWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.spaDataSet);

        }

        private void hasPromotion_CheckedChanged(object sender, EventArgs e)
        {
            txtPromotionPrice.Enabled = hasPromotion.Checked;
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }




        /*
        private void txtPromotionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g. backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow one decimal point
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt != null && !txt.Text.Contains("."))
            {
                return;
            }

            // Disallow anything else
            e.Handled = true;
        }
        */
        private void txtPromotionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore key press
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore key press
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore key press
            }
        }

        
    }
}
