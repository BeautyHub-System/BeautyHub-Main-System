using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BeautyHub
{
    public partial class EditAppointmentForm : Form
    {

       

        private int appointmentId;
        
        public EditAppointmentForm(int appointmentId, int customerId, int staffId, int serviceId, DateTime date, TimeSpan time, string status, string comment, int? rating)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;



            this.appointmentId = appointmentId;

            // 🧠 Make sure dataset is initialized
            spaDataSet = new SpaDataSet();

            // ✅ Fill tables first
            this.customerNEWTableAdapter.Fill(this.spaDataSet.CustomerNEW);
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);
            this.serviceNEWTableAdapter.Fill(this.spaDataSet.ServiceNEW);

            // ✅ Set data sources
            cbCustomerEDIT.DataSource = spaDataSet.CustomerNEW;
            cbCustomerEDIT.DisplayMember = "CustomerName";
            cbCustomerEDIT.ValueMember = "CustomerID";

            cbStaffEDIT.DataSource = spaDataSet.StaffNEW;
            cbStaffEDIT.DisplayMember = "StaffName";
            cbStaffEDIT.ValueMember = "StaffID";

            cbServiceEDIT.DataSource = spaDataSet.ServiceNEW;
            cbServiceEDIT.DisplayMember = "ServiceName";
            cbServiceEDIT.ValueMember = "ServiceID";

            // ✅ Set values AFTER data source is assigned
            cbCustomerEDIT.SelectedValue = customerId;
            cbStaffEDIT.SelectedValue = staffId;
            cbServiceEDIT.SelectedValue = serviceId;


            

            // ✅ Other fields
            dtpDateEDIT.Value = date;
            txtTimeEDIT.Text = time.ToString(@"hh\:mm");
            cbStatusEdit.SelectedItem = status;
            txtCommentEDIT.Text = comment;

            // ✅ Set Rating if exists
            if (rating.HasValue && rating.Value > 0)
            {
                numRatingEDIT.Value = rating.Value;
            }

        }




        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spaDataSet.StaffNEW' table. You can move, or remove it, as needed.
            this.staffNEWTableAdapter.Fill(this.spaDataSet.StaffNEW);
            // TODO: This line of code loads data into the 'spaDataSet.CustomerNEW' table. You can move, or remove it, as needed.
            this.customerNEWTableAdapter.Fill(this.spaDataSet.CustomerNEW);
            // TODO: This line of code loads data into the 'spaDataSet.ServiceNEW' table. You can move, or remove it, as needed.
            this.serviceNEWTableAdapter.Fill(this.spaDataSet.ServiceNEW);
            // Fill dropdowns

            customerNEWTableAdapter.Fill(spaDataSet.CustomerNEW);
            staffNEWTableAdapter.Fill(spaDataSet.StaffNEW);
            serviceNEWTableAdapter.Fill(spaDataSet.ServiceNEW);


            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone

            btnSave.BackColor = Color.MidnightBlue;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;

            
            lblTitleEDIT.ForeColor = Color.DarkSlateGray;




        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate dropdowns
                if (!DashboardControl.IsComboBoxSelected(cbCustomerEDIT) ||
                    !DashboardControl.IsComboBoxSelected(cbStaffEDIT) ||
                    !DashboardControl.IsComboBoxSelected(cbServiceEDIT))
                {
                    MessageBox.Show("Please select Customer, Staff, and Service.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 2: Validate time
                if (!DashboardControl.isValidAppointmentTime(txtTimeEDIT, out TimeSpan appointmentTime))
                {
                    return;
                }

                // Step 3: Validate date
                if (!DashboardControl.isValidDate(dtpDateEDIT, appointmentTime))
                {
                    return;
                }

                // Step 4: Handle Rating using DashboardControl helper
                int? rating = DashboardControl.GetRatingValue(numRatingEDIT, chkNoRating);
                // Optional: You could check if rating is null when checkbox is NOT checked (invalid state)
                if (!chkNoRating.Checked && rating == null)
                {
                    MessageBox.Show("Invalid rating value.", "Rating Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 5: Collect input values
                int customerId = Convert.ToInt32(cbCustomerEDIT.SelectedValue);
                int staffId = Convert.ToInt32(cbStaffEDIT.SelectedValue);
                int serviceId = Convert.ToInt32(cbServiceEDIT.SelectedValue);
                string status = cbStatusEdit.SelectedItem?.ToString() ?? "Pending";
                string comment = txtCommentEDIT.Text.Trim();
                DateTime selectedDate = dtpDateEDIT.Value.Date;
                DateTime combinedDateTime = selectedDate + appointmentTime;

                // Step 6: Get service duration
                int? serviceDuration = serviceNEWTableAdapter.GetDurationByServiceID(serviceId);
                if (serviceDuration == null)
                {
                    MessageBox.Show("Failed to retrieve service duration.", "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 7: Check staff conflict
                TimeSpan newStart = appointmentTime;
                TimeSpan newEnd = newStart.Add(TimeSpan.FromMinutes((double)serviceDuration));
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

                // Step 8: Check customer conflict
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

                // Step 9: Confirm update
                var confirm = MessageBox.Show(
                    $"Please confirm the updated details:\n\n" +
                    $"Customer ID: {customerId}\n" +
                    $"Staff ID: {staffId}\n" +
                    $"Service ID: {serviceId}\n" +
                    $"Date: {selectedDate:yyyy/MM/dd}\n" +
                    $"Time: {appointmentTime:hh\\:mm}\n" +
                    $"Status: {status}\n" +
                    $"Rating: {(rating.HasValue ? rating.ToString() : "No Rating")}\n" +
                    $"Comment: {comment}",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Step 10: Update in database
                    appointmentNEWTableAdapter.UpdateAppointment(
                        customerId, staffId, serviceId, combinedDateTime, appointmentTime, status, comment, rating, appointmentId);

                    MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating appointment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void chkNoRating_CheckedChanged(object sender, EventArgs e)
        {
            numRatingEDIT.Enabled = !chkNoRating.Checked;
        }

        private void txtTimeEDIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
