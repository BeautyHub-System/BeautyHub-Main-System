namespace BeautyHub
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.saleDataSet = new BeautyHub.SaleDataSet();
            this.customerNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.CustomerNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SaleDataSetTableAdapters.TableAdapterManager();
            this.productNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.ProductNEWTableAdapter();
            this.productNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.saleItemNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleItemNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.SaleItemNEWTableAdapter();
            this.saleNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.SaleNEWTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNEWBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(257, 108);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(712, 36);
            this.cbCustomer.TabIndex = 0;
            // 
            // cbProduct
            // 
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(257, 185);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(420, 36);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(811, 191);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(160, 34);
            this.nudQuantity.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(811, 254);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(160, 44);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(117, 305);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(853, 185);
            this.dgvCart.TabIndex = 4;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(805, 538);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 28);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "----------";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(117, 784);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(853, 89);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "SAVE SALE TRANSACTION";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerNEWBindingSource
            // 
            this.customerNEWBindingSource.DataMember = "CustomerNEW";
            this.customerNEWBindingSource.DataSource = this.saleDataSet;
            // 
            // customerNEWTableAdapter
            // 
            this.customerNEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentNEWTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerNEWTableAdapter = this.customerNEWTableAdapter;
            this.tableAdapterManager.ProductNEWTableAdapter = this.productNEWTableAdapter;
            this.tableAdapterManager.SaleItemNEWTableAdapter = null;
            this.tableAdapterManager.SaleNEWTableAdapter = null;
            this.tableAdapterManager.ServiceNEWTableAdapter = null;
            this.tableAdapterManager.StaffNEWTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautyHub.SaleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productNEWTableAdapter
            // 
            this.productNEWTableAdapter.ClearBeforeFill = true;
            // 
            // productNEWBindingSource
            // 
            this.productNEWBindingSource.DataMember = "ProductNEW";
            this.productNEWBindingSource.DataSource = this.saleDataSet;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "cash",
            "Card",
            "eft"});
            this.cbPaymentType.Location = new System.Drawing.Point(320, 527);
            this.cbPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(317, 36);
            this.cbPaymentType.TabIndex = 7;
            // 
            // saleItemNEWBindingSource
            // 
            this.saleItemNEWBindingSource.DataMember = "SaleItemNEW";
            this.saleItemNEWBindingSource.DataSource = this.saleDataSet;
            // 
            // saleItemNEWTableAdapter
            // 
            this.saleItemNEWTableAdapter.ClearBeforeFill = true;
            // 
            // saleNEWBindingSource
            // 
            this.saleNEWBindingSource.DataMember = "SaleNEW";
            this.saleNEWBindingSource.DataSource = this.saleDataSet;
            // 
            // saleNEWTableAdapter
            // 
            this.saleNEWTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 527);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total : R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "QTY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 62);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sales Transaction Form";
            // 
            // btnCalculateChange
            // 
            this.btnCalculateChange.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateChange.Location = new System.Drawing.Point(603, 31);
            this.btnCalculateChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(241, 98);
            this.btnCalculateChange.TabIndex = 14;
            this.btnCalculateChange.Text = "Calculate Change";
            this.btnCalculateChange.UseVisualStyleBackColor = true;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txtChange);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAmountReceived);
            this.groupBox1.Controls.Add(this.btnCalculateChange);
            this.groupBox1.Location = new System.Drawing.Point(117, 597);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(852, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CALCULATE CHANGE";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(252, 92);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(272, 34);
            this.txtChange.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Change";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Amount received";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.Location = new System.Drawing.Point(252, 31);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(272, 34);
            this.txtAmountReceived.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 887);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNEWBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.BindingSource customerNEWBindingSource;
        private SaleDataSetTableAdapters.CustomerNEWTableAdapter customerNEWTableAdapter;
        private SaleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SaleDataSetTableAdapters.ProductNEWTableAdapter productNEWTableAdapter;
        private System.Windows.Forms.BindingSource productNEWBindingSource;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.BindingSource saleItemNEWBindingSource;
        private SaleDataSetTableAdapters.SaleItemNEWTableAdapter saleItemNEWTableAdapter;
        private System.Windows.Forms.BindingSource saleNEWBindingSource;
        private SaleDataSetTableAdapters.SaleNEWTableAdapter saleNEWTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountReceived;
    }
}