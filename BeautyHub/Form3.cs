using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;   


namespace BeautyHub
{
    

    public partial class Form3 : Form
    {

        DataTable cartTable = new DataTable();

        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleDataSet.SaleNEW' table. You can move, or remove it, as needed.
            this.saleNEWTableAdapter.Fill(this.saleDataSet.SaleNEW);
            // TODO: This line of code loads data into the 'saleDataSet.SaleItemNEW' table. You can move, or remove it, as needed.
            this.saleItemNEWTableAdapter.Fill(this.saleDataSet.SaleItemNEW);
            // TODO: This line of code loads data into the 'paymentProcessDataSet.CustomerNEW' table. You can move, or remove it, as needed.
            this.customerNEWTableAdapter.Fill(this.saleDataSet.CustomerNEW);
            // TODO: This line of code loads data into the 'paymentProcessDataSet.ProductNEW' table. You can move, or remove it, as needed.
            this.productNEWTableAdapter.Fill(this.saleDataSet.ProductNEW);

            // Add FullName column to dataset (only if it doesn't exist already)
            if (!saleDataSet.CustomerNEW.Columns.Contains("FullName"))
            {
                saleDataSet.CustomerNEW.Columns.Add("FullName", typeof(string));
                foreach (DataRow row in saleDataSet.CustomerNEW)
                {
                    row["FullName"] = row["FirstName"] + " " + row["LastName"];
                }
            }

            cbProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProduct.AutoCompleteSource = AutoCompleteSource.ListItems;


            // Bind the ComboBox
            cbCustomer.DataSource = saleDataSet.CustomerNEW;
            cbCustomer.DisplayMember = "FullName";   
            cbCustomer.ValueMember = "CustomerID";

            DataRow walkInRow = saleDataSet.CustomerNEW.NewCustomerNEWRow();
            walkInRow["CustomerID"] = 0;  
            walkInRow["FirstName"] = "";  
            walkInRow["LastName"] = "";
            walkInRow["FullName"] = "Walk-in / No Name";
            saleDataSet.CustomerNEW.Rows.InsertAt(walkInRow, 0);


            // Set up cartTable columns
            cartTable.Columns.Add("ProductID", typeof(int));
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("UnitPrice", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Subtotal", typeof(decimal));

            // Bind to the DataGridView
            dgvCart.DataSource = cartTable;

            // hide ProductID from view
            dgvCart.Columns["ProductID"].Visible = false;


           
            productNEWTableAdapter.Fill(saleDataSet.ProductNEW);

            // Create a FullDisplayName column 
            if (!saleDataSet.ProductNEW.Columns.Contains("DisplayName"))
            {
                saleDataSet.ProductNEW.Columns.Add("DisplayName", typeof(string));
                foreach (DataRow row in saleDataSet.ProductNEW)
                {
                    row["DisplayName"] = row["ProductName"] + " (R" + string.Format("{0:0.00}", row["Price"]) + ")";
                }
            }

            // Bind to ComboBox
            cbProduct.DataSource = saleDataSet.ProductNEW;
            cbProduct.DisplayMember = "DisplayName";  // What the user sees
            cbProduct.ValueMember = "ProductID";      // What is used internally


            // Add Remove button column if not already added
            if (!dgvCart.Columns.Contains("Remove"))
            {
                DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
                btnRemove.Name = "Remove";
                //btnRemove.HeaderText = "";
                btnRemove.HeaderText = "🗑";

                btnRemove.Text = "Remove";
                btnRemove.UseColumnTextForButtonValue = true;
                dgvCart.Columns.Add(btnRemove);
            }
            dgvCart.CellContentClick += dgvCart_CellContentClick;


            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            label6.ForeColor = Color.FromArgb(42, 157, 143); // #2A9D8F



            btnCheckOut.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.Cursor = Cursors.Hand;

            btnAddToCart.BackColor = Color.DarkTurquoise;
            btnAddToCart.ForeColor = Color.White;

        }

       
        private decimal GetCartTotal()
        {
            decimal total = 0m;
            foreach (DataRow row in cartTable.Rows)
                total += (decimal)row["Subtotal"];
            return total;
        }

        private bool TryParseMoney(string input, out decimal value)
        {
            input = (input ?? "").Trim().Replace("R", "").Replace(" ", "");
            // Try current culture first (e.g., en-ZA), then invariant
            if (decimal.TryParse(input, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                 CultureInfo.CurrentCulture, out value))
                return true;

            return decimal.TryParse(input, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                    CultureInfo.InvariantCulture, out value);
        }

        private string BuildPaymentNotes(string paymentType, decimal total, decimal amountReceived, decimal change)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Payment Type: {paymentType}");
            sb.AppendLine($"Total: R{total:0.00}");
            sb.AppendLine($"Amount Received: R{amountReceived:0.00}");
            sb.AppendLine($"Change Given: R{change:0.00}");
            return sb.ToString();
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (cbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!DashboardControl.NumGreaterThenZero(nudQuantity))
            {
                MessageBox.Show("Please enter a quantity.");
                return;
            }

          

            int productId = (int)cbProduct.SelectedValue;
            int quantity = (int)nudQuantity.Value;

            var productRow = saleDataSet.ProductNEW.FindByProductID(productId);

            if (productRow == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            string productName = productRow.ProductName;
            decimal unitPrice = productRow.Promotion ? productRow.PromotionPrice : productRow.Price;
            decimal subtotal = unitPrice * quantity;

            // Check if already in cart
            foreach (DataRow row in cartTable.Rows)
            {
                if ((int)row["ProductID"] == productId)
                {
                    row["Quantity"] = (int)row["Quantity"] + quantity;
                    row["Subtotal"] = (int)row["Quantity"] * unitPrice;
                    CalculateTotal();
                    return;
                }
            }

            // Add new row
            cartTable.Rows.Add(productId, productName, unitPrice, quantity, subtotal);
            CalculateTotal();
        }


        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += (decimal)row["Subtotal"];
            }

            lblTotal.Text = $"Total: R{total:0.00}";
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure we clicked the "Remove" button
            if (dgvCart.Columns[e.ColumnIndex].Name == "Remove" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Remove this item from cart?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Safely get the row from the DataGridView and delete it from the DataTable
                    DataGridViewRow gridRow = dgvCart.Rows[e.RowIndex];
                    DataRowView rowView = gridRow.DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        rowView.Row.Delete();
                        cartTable.AcceptChanges(); 
                        CalculateTotal();
                    }
                }
            }
        }



        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // 1) Validation
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add products first.");
                return;
            }

            if (!DashboardControl.IsComboBoxSelected(cbPaymentType))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // 2) Collect
            int? customerId = cbCustomer.SelectedIndex > 0 ? (int?)cbCustomer.SelectedValue : null;
            string paymentType = cbPaymentType.SelectedItem.ToString();
            decimal totalAmount = GetCartTotal();

            // 3) Amount received & change (Cash requires amount; others default to exact)
            decimal amountReceived = totalAmount;
            decimal changeGiven = 0m;

            if (paymentType.Equals("Cash", StringComparison.OrdinalIgnoreCase))
            {
                if (!TryParseMoney(txtAmountReceived.Text, out amountReceived))
                {
                    MessageBox.Show("Enter a valid amount received before checkout.");
                    txtAmountReceived.Focus();
                    return;
                }

                changeGiven = amountReceived - totalAmount;
                if (changeGiven < 0)
                {
                    MessageBox.Show($"Amount received is short by R{Math.Abs(changeGiven):0.00}.");
                    return;
                }
            }
            else
            {
                // Non-cash: assume exact amount, no change
                amountReceived = totalAmount;
                changeGiven = 0m;
            }

            if (!DashboardControl.IsNotEmpty(txtChange))
            {
                MessageBox.Show("Please Click Calculate Change");
                return;
            }

            // 4) Build a clear note and insert sale
            string notes = BuildPaymentNotes(paymentType, totalAmount, amountReceived, changeGiven);

            int saleId = (int)saleNEWTableAdapter.InsertSaleAndReturnID(
                customerId,
                DateTime.Now,
                totalAmount,
                paymentType,
                notes               // <— was null, now saving your payment summary
            );

            // 5) Insert items
            foreach (DataRow row in cartTable.Rows)
            {
                int productId = (int)row["ProductID"];
                int quantity = (int)row["Quantity"];
                decimal unitPrice = (decimal)row["UnitPrice"];
                decimal subtotal = (decimal)row["Subtotal"];

                saleItemNEWTableAdapter.Insert(saleId, productId, quantity, unitPrice, subtotal);
            }

            // 6) Update UI
            txtChange.Text = $"R {changeGiven:0.00}";
            if (!paymentType.Equals("Cash", StringComparison.OrdinalIgnoreCase))
                txtAmountReceived.Text = $"R {amountReceived:0.00}";


            cartTable.Clear();
            cbCustomer.SelectedIndex = 0;
            cbPaymentType.SelectedIndex = -1;
            txtAmountReceived.Clear();
            // keep txtChange if you want to show the last change; otherwise:
            // txtChange.Clear();
            CalculateTotal();

            

            var again = MessageBox.Show(
                "Sale saved successfully!\n\nWould you like to make another transaction?",
                "Success",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

            if (again == DialogResult.Yes)
            {
                // Keep the form open and reset for the next sale
                ResetForNewTransaction();
            }
            else
            {
                // Close this form
                // If this form was shown with ShowDialog(), set DialogResult so the parent knows we’re done
                if (this.Modal)
                    this.DialogResult = DialogResult.OK;
                else
                    this.Close();
            }



        }


        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if (!TryParseMoney(txtAmountReceived.Text, out decimal amountReceived))
            {
                MessageBox.Show("Enter a valid amount received (e.g., 100 or 100.00).");
                txtAmountReceived.Focus();
                return;
            }

            decimal total = GetCartTotal();
            decimal change = amountReceived - total;

            if (change < 0)
            {
                MessageBox.Show($"Amount received is short by R{Math.Abs(change):0.00}.");
                txtChange.Text = "R 0.00";
                return;
            }

            txtChange.Text = $"R {change:0.00}";
        }

        private void ResetForNewTransaction()
        {
            cartTable.Clear();
            cbCustomer.SelectedIndex = 0;
            cbPaymentType.SelectedIndex = -1;

            cbProduct.SelectedIndex = -1;   
            nudQuantity.Value = 1;          

            txtAmountReceived.Clear();
            txtChange.Clear();

            CalculateTotal();
            cbProduct.Focus();
        }


    }
}
