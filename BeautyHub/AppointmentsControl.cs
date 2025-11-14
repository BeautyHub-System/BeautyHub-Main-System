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
    public partial class AppointmentsControl : UserControl
    {
        public AppointmentsControl()
        {
            InitializeComponent();
            dgvAppointments.EnableHeadersVisualStyles = false;
            
        }


        private void AppointmentsControl_Load(object sender, EventArgs e)
        {
            
            dgvAppointments.AutoGenerateColumns = true;
            appointmentNEWTableAdapter.FillWithCustomerName(spaDataSet.AppointmentNEW);
            foreach (DataGridViewColumn col in dgvAppointments.Columns)
            {
                Console.WriteLine("Column: " + col.Name);
            }
            btnAddAppointment.BackColor = Color.FromArgb(42, 157, 143); // #2A9D8F


            Console.WriteLine("ROWS: " + dgvAppointments.Rows.Count);

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.appointmentNEWTableAdapter.FillWithCustomerName(this.spaDataSet.AppointmentNEW);
                    

                }
                else
                {
                    // Search based on CustomerName
                    this.appointmentNEWTableAdapter.FillByCustomerName(this.spaDataSet.AppointmentNEW, txtSearch.Text.Trim());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpFilter.Value.Date;
                appointmentNEWTableAdapter.FillByDate(spaDataSet.AppointmentNEW, selectedDate);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date search failed: " + ex.Message);
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addForm = new AddAppointmentForm();
            addForm.ShowDialog();





            // Refresh the table after adding
            appointmentNEWTableAdapter.FillWithCustomerName(spaDataSet.AppointmentNEW);
            
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
           
            if (dgvAppointments.CurrentRow != null)
            {
                var row = dgvAppointments.CurrentRow;

                int appointmentId = Convert.ToInt32(row.Cells["appointmentIDDataGridViewTextBoxColumn"].Value);
                int customerId = Convert.ToInt32(row.Cells["customerIDDataGridViewTextBoxColumn"].Value);
                int staffId = Convert.ToInt32(row.Cells["staffIDDataGridViewTextBoxColumn"].Value);
                int serviceId = Convert.ToInt32(row.Cells["serviceIDDataGridViewTextBoxColumn"].Value);
                DateTime date = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
                TimeSpan time = (TimeSpan)row.Cells["timeDataGridViewTextBoxColumn"].Value;
                string status = row.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                string comment = row.Cells["commentDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                int? rating = row.Cells["ratingDataGridViewTextBoxColumn"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["ratingDataGridViewTextBoxColumn"].Value) : (int?)null;

                // Open edit form with pre-filled values
                EditAppointmentForm editForm = new EditAppointmentForm(appointmentId, customerId, staffId, serviceId, date, time, status, comment, rating);
                editForm.ShowDialog();

                // Refresh table after editing
                appointmentNEWTableAdapter.FillWithCustomerName(spaDataSet.AppointmentNEW);
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.");
            }
        }

        //private void btnCancelAppointment_Click(object sender, EventArgs e)
        //{
        //    if (dgvAppointments.CurrentRow != null)
        //    {
        //        var row = dgvAppointments.CurrentRow;

        //        int appointmentId = Convert.ToInt32(row.Cells["appointmentIDDataGridViewTextBoxColumn"].Value);
        //        string customerName = row.Cells["CustomerName"].Value?.ToString() ?? "Unknown";
        //        DateTime date = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
        //        string time = row.Cells["timeDataGridViewTextBoxColumn"].Value?.ToString();

        //        // Confirm cancellation
        //        DialogResult confirm = MessageBox.Show(
        //            $"Are you sure you want to cancel this appointment?\n\n" +
        //            $"• Customer: {customerName}\n" +
        //            $"• Date: {date:yyyy-MM-dd}\n" +
        //            $"• Time: {time}",
        //            "Confirm Cancellation",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning
        //        );

        //        if (confirm == DialogResult.Yes)
        //        {
        //            // Call your UPDATE method to change status
        //            appointmentNEWTableAdapter.UpdateAppointmentStatus("Cancelled", appointmentId);

        //            MessageBox.Show("Appointment cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            appointmentNEWTableAdapter.FillWithCustomerName(spaDataSet.AppointmentNEW);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select an appointment to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}
        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null)
            {
                var row = dgvAppointments.CurrentRow;

                int appointmentId = Convert.ToInt32(row.Cells["appointmentIDDataGridViewTextBoxColumn"].Value);
                string customerName = row.Cells["CustomerName"].Value?.ToString() ?? "Unknown";
                DateTime date = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);

               
                object timeCellValue = row.Cells["timeDataGridViewTextBoxColumn"].Value;
                string timeString = timeCellValue?.ToString();

                
                DateTime appointmentDateTime;

                if (!string.IsNullOrWhiteSpace(timeString) && TimeSpan.TryParse(timeString, out TimeSpan appointmentTime))
                {
                    appointmentDateTime = date.Date + appointmentTime;
                }
                else
                {
                    appointmentDateTime = date;
                }

                if (appointmentDateTime < DateTime.Now)
                {
                    MessageBox.Show(
                        "You cannot cancel past appointments.\n\n" +
                        "",
                        "Cannot Cancel",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }


                // Confirm cancellation
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to cancel this appointment?\n\n" +
                    $"• Customer: {customerName}\n" +
                    $"• Date: {date:yyyy-MM-dd}\n" +
                    $"• Time: {timeString}",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    // Call your UPDATE method to change status
                    appointmentNEWTableAdapter.UpdateAppointmentStatus("Cancelled", appointmentId);

                    MessageBox.Show("Appointment cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appointmentNEWTableAdapter.FillWithCustomerName(spaDataSet.AppointmentNEW);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
