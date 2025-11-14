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
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.AppointmentNEW' table. You can move, or remove it, as needed.
            this.appointmentNEWTableAdapter.Fill(this.spaDataSet.AppointmentNEW);
            // TODO: This line of code loads data into the 'spaDataSet.ServiceNEW' table. You can move, or remove it, as needed.
            this.serviceNEWTableAdapter.Fill(this.spaDataSet.ServiceNEW);
            // TODO: This line of code loads data into the 'spaDataSet.CustomerNEW' table. You can move, or remove it, as needed.
            this.customerNEWTableAdapter.Fill(this.spaDataSet.CustomerNEW);
            // TODO: This line of code loads data into the 'spaDataSet.StaffNEW' table. You can move, or remove it, as needed.
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);
            // Load customers
            cbCustomer.DataSource = customerNEWTableAdapter.GetData();
            cbCustomer.DisplayMember = "FullName"; 
            cbCustomer.ValueMember = "CustomerID";

            // Load staff
            cbStaff.DataSource = staffNEWTableAdapter.GetData();
            cbStaff.DisplayMember = "FirstName"; 
            cbStaff.ValueMember = "StaffID";

            // Load services
            cbService.DataSource = serviceNEWTableAdapter.GetData();
            cbService.DisplayMember = "ServiceName";
            cbService.ValueMember = "ServiceID";

            cbStatus.Items.AddRange(new string[] { "Scheduled", "Confirmed", "Cancelled" });
            cbStatus.SelectedIndex = 0;

            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            label1.ForeColor = Color.FromArgb(42, 157, 143); 
            


            btnSaveAppointment.BackColor = Color.FromArgb(42, 157, 143); 
            btnSaveAppointment.ForeColor = Color.White;
            btnSaveAppointment.FlatStyle = FlatStyle.Flat;
            btnSaveAppointment.FlatAppearance.BorderSize = 0;
            btnSaveAppointment.Cursor = Cursors.Hand;

        }





        


        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            try
            { 

                if (!DashboardControl.IsComboBoxSelected(cbCustomer))
                {
                    MessageBox.Show("Please select a customer.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbCustomer.Focus();
                    return;
                }

                if (!DashboardControl.IsComboBoxSelected(cbStaff))
                {
                    MessageBox.Show("Please select a staff member.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbStaff.Focus();
                    return;
                }

                if (!DashboardControl.IsComboBoxSelected(cbService))
                {
                    MessageBox.Show("Please select a service.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbService.Focus();
                    return;
                }

                // Validate appointment time format and logic
                if (!DashboardControl.isValidAppointmentTime(txtTime, out TimeSpan appointmentTime))
                {
                    txtTime.Focus();
                    return;
                }

                // Validate that the date isn't in the past
                if (!DashboardControl.isValidDate(dtpDate, appointmentTime))
                {
                    dtpDate.Focus();
                    return;
                }

                
                int customerId = Convert.ToInt32(cbCustomer.SelectedValue);
                int staffId = Convert.ToInt32(cbStaff.SelectedValue);
                int serviceId = Convert.ToInt32(cbService.SelectedValue);
                string status = cbStatus.SelectedItem?.ToString() ?? "Pending";
                string comment = txtComment.Text.Trim();
                DateTime selectedDate = dtpDate.Value.Date;

                
                int? serviceDuration = serviceNEWTableAdapter.GetDurationByServiceID(serviceId);
                if (serviceDuration == null)
                {
                    MessageBox.Show("Failed to retrieve service duration.", "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                TimeSpan newStart = appointmentTime;
                TimeSpan newEnd = newStart.Add(TimeSpan.FromMinutes((double)serviceDuration));

                //Staff conflict check
                var staffAppointments = appointmentNEWTableAdapter.GetDataByStaffAndDate(staffId, selectedDate.ToString());

                foreach (var row in staffAppointments)
                {
                    TimeSpan existingStart = (TimeSpan)row["Time"];
                    int existingServiceID = (int)row["ServiceID"];
                    int existingDuration = (int)serviceNEWTableAdapter.GetDurationByServiceID(existingServiceID);
                    TimeSpan existingEnd = existingStart.Add(TimeSpan.FromMinutes(existingDuration));

                    if (newStart < existingEnd && existingStart < newEnd)
                    {
                        string serviceName = serviceNEWTableAdapter.GetServiceNameByID(existingServiceID)?.ToString() ?? "Unknown Service";
                        string conflictDetails = $"This staff member is already booked during the selected time slot:\n\n" +
                                                 $"• {serviceName} from {existingStart:hh\\:mm} to {existingEnd:hh\\:mm}";

                        MessageBox.Show(conflictDetails, "Double Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Customer conflict check
                var customerAppointments = appointmentNEWTableAdapter.GetDataByCustomerAndDate(customerId, selectedDate.ToString());

                string customerConflictDetails = $"Conflicting appointment(s) for Customer ID {customerId}:\n\n";
                bool customerConflictFound = false;

                foreach (var row in customerAppointments)
                {
                    TimeSpan existingStart = (TimeSpan)row["Time"];
                    int existingServiceID = (int)row["ServiceID"];
                    int existingDuration = (int)serviceNEWTableAdapter.GetDurationByServiceID(existingServiceID);
                    TimeSpan existingEnd = existingStart.Add(TimeSpan.FromMinutes(existingDuration));

                    if (newStart < existingEnd && existingStart < newEnd)
                    {
                        string serviceName = serviceNEWTableAdapter.GetServiceNameByID(existingServiceID)?.ToString() ?? "Unknown Service";
                        customerConflictDetails += $"• {serviceName} from {existingStart:hh\\:mm} to {existingEnd:hh\\:mm}\n";
                        customerConflictFound = true;
                    }
                }

                if (customerConflictFound)
                {
                    MessageBox.Show(customerConflictDetails, "Customer Already Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm with user
                string summaryMessage =
                    $"Please confirm the appointment details:\n\n" +
                    $"👤 Customer ID: {customerId}\n" +
                    $"👨‍⚕️ Staff ID: {staffId}\n" +
                    $"🛎️ Service ID: {serviceId}\n" +
                    $"📅 Date: {selectedDate:yyyy-MM-dd}\n" +
                    $"⏰ Time: {appointmentTime:hh\\:mm}\n" +
                    $"📌 Status: {status}\n\n" +
                    "Do you want to proceed with saving this appointment?";

                DialogResult result = MessageBox.Show(
                    summaryMessage,
                    "Confirm Appointment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Appointment was not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                appointmentNEWTableAdapter.InsertAppointment(
                    customerId,
                    staffId,
                    serviceId,
                    selectedDate,
                    appointmentTime,
                    status,
                    comment,
                    null 
                );

                MessageBox.Show("Appointment successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void staffNEWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffNEWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.spaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows digits (0-9), colon (:), and control keys like backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
