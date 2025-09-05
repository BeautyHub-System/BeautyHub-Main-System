namespace BeautyHub
{
    partial class DashboardControl
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
            this.spaDataSet = new BeautyHub.SpaDataSet();
            this.appointmentNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.AppointmentNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SpaDataSetTableAdapters.TableAdapterManager();
            this.staffNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.StaffNEWTableAdapter();
            this.productNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.ProductNEWTableAdapter();
            this.saleNEWTableAdapter1 = new BeautyHub.SaleDataSetTableAdapters.SaleNEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spaDataSet
            // 
            this.spaDataSet.DataSetName = "SpaDataSet";
            this.spaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentNEWBindingSource
            // 
            this.appointmentNEWBindingSource.DataMember = "AppointmentNEW";
            this.appointmentNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // appointmentNEWTableAdapter
            // 
            this.appointmentNEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerNEWTableAdapter = null;
            this.tableAdapterManager.ProductNEWTableAdapter = null;
            this.tableAdapterManager.SaleItemNEWTableAdapter = null;
            this.tableAdapterManager.SaleNEWTableAdapter = null;
            this.tableAdapterManager.ServiceNEWTableAdapter = null;
            this.tableAdapterManager.StaffNEWTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BeautyHub.SpaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // productNEWBindingSource
            // 
            this.productNEWBindingSource.DataMember = "ProductNEW";
            this.productNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // productNEWTableAdapter
            // 
            this.productNEWTableAdapter.ClearBeforeFill = true;
            // 
            // saleNEWTableAdapter1
            // 
            this.saleNEWTableAdapter1.ClearBeforeFill = true;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(739, 484);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource appointmentNEWBindingSource;
        private SpaDataSetTableAdapters.AppointmentNEWTableAdapter appointmentNEWTableAdapter;
        private SpaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource staffNEWBindingSource;
        private SpaDataSetTableAdapters.StaffNEWTableAdapter staffNEWTableAdapter;
        private System.Windows.Forms.BindingSource productNEWBindingSource;
        private SpaDataSetTableAdapters.ProductNEWTableAdapter productNEWTableAdapter;
        private SaleDataSetTableAdapters.SaleNEWTableAdapter saleNEWTableAdapter1;
    }
}
