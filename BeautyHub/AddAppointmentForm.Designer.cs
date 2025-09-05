
namespace BeautyHub
{
    partial class AddAppointmentForm
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
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.Comment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.staffNEWBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.staffNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSet = new BeautyHub.SpaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staffNEWBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.appointmentNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.AppointmentNEWTableAdapter();
            this.customerNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.StaffNEWTableAdapter();
            this.tableAdapterManager = new BeautyHub.SpaDataSetTableAdapters.TableAdapterManager();
            this.customerNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.CustomerNEWTableAdapter();
            this.serviceNEWTableAdapter = new BeautyHub.SpaDataSetTableAdapters.ServiceNEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingNavigator)).BeginInit();
            this.staffNEWBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(328, 95);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(261, 36);
            this.cbCustomer.TabIndex = 0;
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(328, 208);
            this.cbStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(261, 36);
            this.cbStaff.TabIndex = 1;
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(328, 153);
            this.cbService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(261, 36);
            this.cbService.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(328, 270);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(261, 34);
            this.dtpDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADD APPOINTMENT FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Staff ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status ";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(328, 334);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(263, 34);
            this.txtTime.TabIndex = 10;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(328, 399);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(261, 36);
            this.cbStatus.TabIndex = 12;
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(150, 464);
            this.Comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(179, 46);
            this.Comment.TabIndex = 13;
            this.Comment.Text = "Comment ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(328, 464);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(261, 125);
            this.txtComment.TabIndex = 14;
            this.txtComment.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Service ";
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.Location = new System.Drawing.Point(125, 636);
            this.btnSaveAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(513, 60);
            this.btnSaveAppointment.TabIndex = 16;
            this.btnSaveAppointment.Text = "Save appointment";
            this.btnSaveAppointment.UseVisualStyleBackColor = true;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
            // 
            // staffNEWBindingNavigator
            // 
            this.staffNEWBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staffNEWBindingNavigator.BindingSource = this.staffNEWBindingSource;
            this.staffNEWBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffNEWBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staffNEWBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staffNEWBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.staffNEWBindingNavigatorSaveItem});
            this.staffNEWBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staffNEWBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffNEWBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffNEWBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffNEWBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffNEWBindingNavigator.Name = "staffNEWBindingNavigator";
            this.staffNEWBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffNEWBindingNavigator.ShowItemToolTips = false;
            this.staffNEWBindingNavigator.Size = new System.Drawing.Size(1073, 25);
            this.staffNEWBindingNavigator.TabIndex = 17;
            this.staffNEWBindingNavigator.Text = "bindingNavigator1";
            this.staffNEWBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // staffNEWBindingSource
            // 
            this.staffNEWBindingSource.DataMember = "StaffNEW";
            this.staffNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // spaDataSet
            // 
            this.spaDataSet.DataSetName = "SpaDataSet";
            this.spaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // staffNEWBindingNavigatorSaveItem
            // 
            this.staffNEWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffNEWBindingNavigatorSaveItem.Name = "staffNEWBindingNavigatorSaveItem";
            this.staffNEWBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 22);
            this.staffNEWBindingNavigatorSaveItem.Text = "Save Data";
            this.staffNEWBindingNavigatorSaveItem.Click += new System.EventHandler(this.staffNEWBindingNavigatorSaveItem_Click);
            // 
            // appointmentNEWTableAdapter
            // 
            this.appointmentNEWTableAdapter.ClearBeforeFill = true;
            // 
            // customerNEWBindingSource
            // 
            this.customerNEWBindingSource.DataMember = "CustomerNEW";
            this.customerNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // serviceNEWBindingSource
            // 
            this.serviceNEWBindingSource.DataMember = "ServiceNEW";
            this.serviceNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // appointmentNEWBindingSource
            // 
            this.appointmentNEWBindingSource.DataMember = "AppointmentNEW";
            this.appointmentNEWBindingSource.DataSource = this.spaDataSet;
            // 
            // staffNEWTableAdapter
            // 
            this.staffNEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerNEWTableAdapter = this.customerNEWTableAdapter;
            this.tableAdapterManager.ProductNEWTableAdapter = null;
            this.tableAdapterManager.SaleItemNEWTableAdapter = null;
            this.tableAdapterManager.SaleNEWTableAdapter = null;
            this.tableAdapterManager.ServiceNEWTableAdapter = this.serviceNEWTableAdapter;
            this.tableAdapterManager.StaffNEWTableAdapter = this.staffNEWTableAdapter;
            this.tableAdapterManager.UpdateOrder = BeautyHub.SpaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerNEWTableAdapter
            // 
            this.customerNEWTableAdapter.ClearBeforeFill = true;
            // 
            // serviceNEWTableAdapter
            // 
            this.serviceNEWTableAdapter.ClearBeforeFill = true;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(796, 716);
            this.Controls.Add(this.btnSaveAppointment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.cbStaff);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.staffNEWBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAppointmentForm";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingNavigator)).EndInit();
            this.staffNEWBindingNavigator.ResumeLayout(false);
            this.staffNEWBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentNEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveAppointment;
        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource staffNEWBindingSource;
        private SpaDataSetTableAdapters.StaffNEWTableAdapter staffNEWTableAdapter;
        private SpaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffNEWBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton staffNEWBindingNavigatorSaveItem;
        private SpaDataSetTableAdapters.CustomerNEWTableAdapter customerNEWTableAdapter;
        private System.Windows.Forms.BindingSource customerNEWBindingSource;
        private SpaDataSetTableAdapters.ServiceNEWTableAdapter serviceNEWTableAdapter;
        private System.Windows.Forms.BindingSource serviceNEWBindingSource;
        private System.Windows.Forms.BindingSource appointmentNEWBindingSource;
        private SpaDataSetTableAdapters.AppointmentNEWTableAdapter appointmentNEWTableAdapter;
    }
}