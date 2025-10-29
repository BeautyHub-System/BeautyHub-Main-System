
namespace BeautyHub
{
    partial class StaffControl
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spaDataSet = new BeautyHub.SpaDataSet();
            this.staffNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.StaffNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SpaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(90, 157);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1042, 150);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStaff_CellFormatting);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStaff.Location = new System.Drawing.Point(102, 525);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(300, 70);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "ADD NEW STAFF ";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditStaff.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditStaff.Location = new System.Drawing.Point(466, 525);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(300, 70);
            this.btnEditStaff.TabIndex = 2;
            this.btnEditStaff.Text = "EDIT STAFF DETAILS";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchive.BackColor = System.Drawing.Color.Red;
            this.btnArchive.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArchive.Location = new System.Drawing.Point(823, 525);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(300, 70);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "DELETE STAFF ";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By STATUS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By NAME";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(204, 79);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(184, 21);
            this.cbFilter.TabIndex = 6;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchStaff.Location = new System.Drawing.Point(901, 85);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(231, 20);
            this.txtSearchStaff.TabIndex = 7;
            this.txtSearchStaff.TextChanged += new System.EventHandler(this.txtSearchStaff_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(981, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "GREEN = AVAILABLE";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(991, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "RED = ON LEAVE";
            // 
            // spaDataSet
            // 
            this.spaDataSet.DataSetName = "SpaDataSet";
            this.spaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffNEWBindingSource
            // 
            this.staffNEWBindingSource.DataMember = "StaffNEW";
            this.staffNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // staffNEWTableAdapter
            // 
            this.staffNEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerNEWTableAdapter = null;
            this.tableAdapterManager.ProductNEWTableAdapter = null;
            this.tableAdapterManager.SaleItemNEWTableAdapter = null;
            this.tableAdapterManager.SaleNEWTableAdapter = null;
            this.tableAdapterManager.ServiceNEWTableAdapter = null;
            this.tableAdapterManager.StaffNEWTableAdapter = this.staffNEWTableAdapter;
            this.tableAdapterManager.UpdateOrder = BeautyHub.SpaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.dgvStaff);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(1210, 658);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource staffNEWBindingSource;
        private SpaDataSetTableAdapters.StaffNEWTableAdapter staffNEWTableAdapter;
        private SpaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
