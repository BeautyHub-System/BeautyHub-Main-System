
namespace BeautyHub
{
    partial class SalesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSet = new BeautyHub.SaleDataSet();
            this.dgvSaleItem = new System.Windows.Forms.DataGridView();
            this.saleNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.SaleNEWTableAdapter();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            this.saleItemNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleItemNEWTableAdapter = new BeautyHub.SaleDataSetTableAdapters.SaleItemNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SaleDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemNEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.saleNEWBindingSource;
            this.dgvSales.Location = new System.Drawing.Point(14, 87);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(910, 429);
            this.dgvSales.TabIndex = 0;
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellClick);
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // saleNEWBindingSource
            // 
            this.saleNEWBindingSource.DataMember = "SaleNEW";
            this.saleNEWBindingSource.DataSource = this.saleDataSet;
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSaleItem
            // 
            this.dgvSaleItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItem.Location = new System.Drawing.Point(960, 87);
            this.dgvSaleItem.Name = "dgvSaleItem";
            this.dgvSaleItem.Size = new System.Drawing.Size(465, 429);
            this.dgvSaleItem.TabIndex = 1;
            this.dgvSaleItem.Visible = false;
            // 
            // saleNEWTableAdapter
            // 
            this.saleNEWTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSale.Location = new System.Drawing.Point(1101, 27);
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(324, 35);
            this.txtSearchSale.TabIndex = 2;
            this.txtSearchSale.TextChanged += new System.EventHandler(this.txtSearchSale_TextChanged);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentNEWTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerNEWTableAdapter = null;
            this.tableAdapterManager.ProductNEWTableAdapter = null;
            this.tableAdapterManager.SaleItemNEWTableAdapter = this.saleItemNEWTableAdapter;
            this.tableAdapterManager.SaleNEWTableAdapter = this.saleNEWTableAdapter;
            this.tableAdapterManager.ServiceNEWTableAdapter = null;
            this.tableAdapterManager.StaffNEWTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautyHub.SaleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1017, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "SALE MANAGEMENT";
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMakeSale.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeSale.Location = new System.Drawing.Point(264, 576);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(945, 66);
            this.btnMakeSale.TabIndex = 5;
            this.btnMakeSale.Text = "Make Sale Transaction";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSale);
            this.Controls.Add(this.dgvSaleItem);
            this.Controls.Add(this.dgvSales);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(1457, 677);
            this.Load += new System.EventHandler(this.SalesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemNEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saleNEWBindingSource;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.DataGridView dgvSaleItem;
        private SaleDataSetTableAdapters.SaleNEWTableAdapter saleNEWTableAdapter;
        private System.Windows.Forms.TextBox txtSearchSale;
        private System.Windows.Forms.BindingSource saleItemNEWBindingSource;
        private SaleDataSetTableAdapters.SaleItemNEWTableAdapter saleItemNEWTableAdapter;
        private SaleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeSale;
    }
}
