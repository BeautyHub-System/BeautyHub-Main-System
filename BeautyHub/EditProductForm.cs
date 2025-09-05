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
    public partial class EditProductForm : Form
    {
        private int productId;

        public EditProductForm(int productId, string name, string description, string category, decimal price, bool isPromo, decimal? promoPrice, int stock, bool isActive)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            this.productId = productId;

            // Fill fields
            txtProductName.Text = name;
            txtDescription.Text = description;
            cbCategory.SelectedItem = category;  // Ensure items are preloaded in Form_Load
            txtPrice.Text = price.ToString("0.00");
            txtStock.Text = stock.ToString();
            hasPromotion.Checked = isPromo;
            txtPromotionPrice.Enabled = isPromo;
            txtPromotionPrice.Text = promoPrice?.ToString("0.00") ?? "";
            IsActive.Checked = isActive;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.ProductNEW' table. You can move, or remove it, as needed.
            this.productNEWTableAdapter.Fill(this.spaDataSet.ProductNEW);
            // Manually add categories if not bound to DB
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(new string[] { "Skincare", "Haircare", "Body", "Fragrance", "Tools" , "Other" });

            if (string.IsNullOrEmpty(cbCategory.Text))
                cbCategory.SelectedItem = "Uncategorized";

            

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            btnSaveChanges.BackColor = Color.MidnightBlue;
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.FlatAppearance.BorderSize = 0;


            label1.ForeColor = Color.DarkSlateGray;

            lblProductID.Text = productId.ToString();



        }

        private void hasPromotion_CheckedChanged(object sender, EventArgs e)
        {
            txtPromotionPrice.Enabled = hasPromotion.Checked;
            if (!hasPromotion.Checked)
            {
                txtPromotionPrice.Text = ""; // Clear if promo is unchecked
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Validation
            if (!DashboardControl.IsNotEmpty(txtProductName) ||
                !DashboardControl.IsNotEmpty(txtPrice) ||
                !DashboardControl.IsNotEmpty(txtStock))
            {
                MessageBox.Show("Please enter valid Name, Price, and Stock values.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal? promoPrice = null;
            bool isPromo = hasPromotion.Checked;
            if (isPromo)
            {
                if (DashboardControl.IsNotEmpty(txtPromotionPrice))
                {
                    promoPrice =Convert.ToDecimal(txtPromotionPrice.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Enter a valid Promotion Price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string name = txtProductName.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string category = cbCategory.SelectedItem?.ToString() ?? "Uncategorized";
            bool isActive = IsActive.Checked;
            decimal price = Convert.ToDecimal( txtPrice.Text.Trim());
            int stock = Convert.ToInt32(txtStock.Text.Trim());

            // Confirmation
            var result = MessageBox.Show("Are you sure you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                // Your table adapter method may differ - this assumes you’ve added an UpdateProduct query
                productNEWTableAdapter.UpdateProduct(name, desc, category, price, isPromo, promoPrice, stock, isActive, productId);
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productNEWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productNEWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.spaDataSet);

        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys e.g.backspaces
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

            e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar)||!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            

          
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPromotionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys e.g.backspaces
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

            e.Handled = true;
        }
    }
}
