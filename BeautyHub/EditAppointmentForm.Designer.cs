
namespace BeautyHub
{
    partial class EditAppointmentForm
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
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.cbCustomerEDIT = new System.Windows.Forms.ComboBox();
            this.cbServiceEDIT = new System.Windows.Forms.ComboBox();
            this.cbStaffEDIT = new System.Windows.Forms.ComboBox();
            this.cbStatusEdit = new System.Windows.Forms.ComboBox();
            this.txtTimeEDIT = new System.Windows.Forms.TextBox();
            this.dtpDateEDIT = new System.Windows.Forms.DateTimePicker();
            this.txtCommentEDIT = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.numRatingEDIT = new System.Windows.Forms.NumericUpDown();
            this.spaDataSet = new BeautyHub.SpaDataSet();
            this.appointmentNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.AppointmentNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SpaDataSetTableAdapters.TableAdapterManager();
            this.serviceNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.ServiceNEWTableAdapter();
            this.customerNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.CustomerNEWTableAdapter();
            this.staffNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.StaffNEWTableAdapter();
            this.chkNoRating = new System.Windows.Forms.CheckBox();
            this.lblTitleEDIT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingEDIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomer.Location = new System.Drawing.Point(146, 75);
            this.lblEditCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(140, 37);
            this.lblEditCustomer.TabIndex = 6;
            this.lblEditCustomer.Text = "Customer ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Service ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Staff ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Time ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Status ";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(143, 435);
            this.Comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(143, 37);
            this.Comment.TabIndex = 21;
            this.Comment.Text = "Comment ";
            // 
            // cbCustomerEDIT
            // 
            this.cbCustomerEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerEDIT.FormattingEnabled = true;
            this.cbCustomerEDIT.Location = new System.Drawing.Point(306, 91);
            this.cbCustomerEDIT.Name = "cbCustomerEDIT";
            this.cbCustomerEDIT.Size = new System.Drawing.Size(206, 25);
            this.cbCustomerEDIT.TabIndex = 22;
            this.cbCustomerEDIT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbServiceEDIT
            // 
            this.cbServiceEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceEDIT.FormattingEnabled = true;
            this.cbServiceEDIT.Location = new System.Drawing.Point(306, 143);
            this.cbServiceEDIT.Name = "cbServiceEDIT";
            this.cbServiceEDIT.Size = new System.Drawing.Size(206, 25);
            this.cbServiceEDIT.TabIndex = 23;
            // 
            // cbStaffEDIT
            // 
            this.cbStaffEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffEDIT.FormattingEnabled = true;
            this.cbStaffEDIT.Location = new System.Drawing.Point(306, 207);
            this.cbStaffEDIT.Name = "cbStaffEDIT";
            this.cbStaffEDIT.Size = new System.Drawing.Size(206, 25);
            this.cbStaffEDIT.TabIndex = 24;
            // 
            // cbStatusEdit
            // 
            this.cbStatusEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusEdit.FormattingEnabled = true;
            this.cbStatusEdit.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled",
            "Completed"});
            this.cbStatusEdit.Location = new System.Drawing.Point(306, 384);
            this.cbStatusEdit.Name = "cbStatusEdit";
            this.cbStatusEdit.Size = new System.Drawing.Size(200, 25);
            this.cbStatusEdit.TabIndex = 25;
            // 
            // txtTimeEDIT
            // 
            this.txtTimeEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEDIT.Location = new System.Drawing.Point(306, 311);
            this.txtTimeEDIT.Name = "txtTimeEDIT";
            this.txtTimeEDIT.Size = new System.Drawing.Size(200, 25);
            this.txtTimeEDIT.TabIndex = 26;
            this.txtTimeEDIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeEDIT_KeyPress);
            // 
            // dtpDateEDIT
            // 
            this.dtpDateEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEDIT.Location = new System.Drawing.Point(306, 269);
            this.dtpDateEDIT.Name = "dtpDateEDIT";
            this.dtpDateEDIT.Size = new System.Drawing.Size(200, 25);
            this.dtpDateEDIT.TabIndex = 27;
            // 
            // txtCommentEDIT
            // 
            this.txtCommentEDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentEDIT.Location = new System.Drawing.Point(306, 435);
            this.txtCommentEDIT.Name = "txtCommentEDIT";
            this.txtCommentEDIT.Size = new System.Drawing.Size(294, 100);
            this.txtCommentEDIT.TabIndex = 28;
            this.txtCommentEDIT.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "RATING";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(141, 666);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(479, 86);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE CHANGES";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numRatingEDIT
            // 
            this.numRatingEDIT.Location = new System.Drawing.Point(306, 579);
            this.numRatingEDIT.Name = "numRatingEDIT";
            this.numRatingEDIT.Size = new System.Drawing.Size(217, 20);
            this.numRatingEDIT.TabIndex = 31;
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
            // serviceNEWBindingSource
            // 
            this.serviceNEWBindingSource.DataMember = "ServiceNEW";
            this.serviceNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // serviceNEWTableAdapter
            // 
            this.serviceNEWTableAdapter.ClearBeforeFill = true;
            // 
            // customerNEWBindingSource
            // 
            this.customerNEWBindingSource.DataMember = "CustomerNEW";
            this.customerNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // customerNEWTableAdapter
            // 
            this.customerNEWTableAdapter.ClearBeforeFill = true;
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
            // chkNoRating
            // 
            this.chkNoRating.AutoSize = true;
            this.chkNoRating.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoRating.Location = new System.Drawing.Point(306, 614);
            this.chkNoRating.Name = "chkNoRating";
            this.chkNoRating.Size = new System.Drawing.Size(95, 21);
            this.chkNoRating.TabIndex = 32;
            this.chkNoRating.Text = "Skip Rating";
            this.chkNoRating.UseVisualStyleBackColor = true;
            this.chkNoRating.CheckedChanged += new System.EventHandler(this.chkNoRating_CheckedChanged);
            // 
            // lblTitleEDIT
            // 
            this.lblTitleEDIT.AutoSize = true;
            this.lblTitleEDIT.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEDIT.Location = new System.Drawing.Point(12, 9);
            this.lblTitleEDIT.Name = "lblTitleEDIT";
            this.lblTitleEDIT.Size = new System.Drawing.Size(332, 45);
            this.lblTitleEDIT.TabIndex = 33;
            this.lblTitleEDIT.Text = "EDIT APPOINTMENT";
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(727, 811);
            this.Controls.Add(this.lblTitleEDIT);
            this.Controls.Add(this.chkNoRating);
            this.Controls.Add(this.numRatingEDIT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommentEDIT);
            this.Controls.Add(this.dtpDateEDIT);
            this.Controls.Add(this.txtTimeEDIT);
            this.Controls.Add(this.cbStatusEdit);
            this.Controls.Add(this.cbStaffEDIT);
            this.Controls.Add(this.cbServiceEDIT);
            this.Controls.Add(this.cbCustomerEDIT);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEditCustomer);
            this.Name = "EditAppointmentForm";
            this.Text = "EditAppointmentForm";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRatingEDIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource appointmentNEWBindingSource;
        private SpaDataSetTableAdapters.AppointmentNEWTableAdapter appointmentNEWTableAdapter;
        private SpaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.ComboBox cbCustomerEDIT;
        private System.Windows.Forms.ComboBox cbServiceEDIT;
        private System.Windows.Forms.ComboBox cbStaffEDIT;
        private System.Windows.Forms.ComboBox cbStatusEdit;
        private System.Windows.Forms.TextBox txtTimeEDIT;
        private System.Windows.Forms.DateTimePicker dtpDateEDIT;
        private System.Windows.Forms.RichTextBox txtCommentEDIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource serviceNEWBindingSource;
        private SpaDataSetTableAdapters.ServiceNEWTableAdapter serviceNEWTableAdapter;
        private System.Windows.Forms.BindingSource customerNEWBindingSource;
        private SpaDataSetTableAdapters.CustomerNEWTableAdapter customerNEWTableAdapter;
        private System.Windows.Forms.BindingSource staffNEWBindingSource;
        private SpaDataSetTableAdapters.StaffNEWTableAdapter staffNEWTableAdapter;
        private System.Windows.Forms.NumericUpDown numRatingEDIT;
        private System.Windows.Forms.CheckBox chkNoRating;
        private System.Windows.Forms.Label lblTitleEDIT;
    }
}