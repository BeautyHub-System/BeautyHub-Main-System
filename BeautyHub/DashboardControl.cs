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
    public partial class DashboardControl : UserControl
    {
        private int lowStockThreshold = 5;

        //============
        private Image imgAppointments, imgSales, imgStaff, imgStock;
        //=============



        public DashboardControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(248, 245, 243); // Light background

            String lblAppointmentsToday = "0";
            String lblAvailableStaff = "0";
            String lblLowStock = "0";
            String lblTotalSales = "error";
            //=================
            imgAppointments = Image.FromFile("Resources/massage.png");
            imgSales = Image.FromFile("Resources/salary.png");
            imgStaff = Image.FromFile("Resources/grouping.png");
            imgStock = Image.FromFile("Resources/out-of-stock.png");
            //===============

            try
            {
                int count = Convert.ToInt32(appointmentNEWTableAdapter.GetTodayAppointmentCount());
                lblAppointmentsToday = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading today's appointments: " + ex.Message);
                lblAppointmentsToday = "0";
            }

            try
            {
                // Fetch all staff data
                var staffTable = staffNEWTableAdapter.GetData();

                // Count how many are both active and available
                int availableStaffCount = staffTable
                    .Where(s => s.IsActive && s.Status == "Available")
                    .Count();

                // Update the dashboard label
                lblAvailableStaff = availableStaffCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message);
            }


            try
            {
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);

                int lowStockCount = spaDataSet.ProductNEW
                    .Where(p => p.IsActive && p.QuantityInStock <= lowStockThreshold)
                    .Count();

                lblLowStock = $"{lowStockCount} Low in Stock";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
            try
            {

                lblTotalSales = "R " + saleNEWTableAdapter1.GetTotalSales(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load total sales: " + ex.Message);
            }




            //======================
            Panel cardAppointments = CreateDashboardCard("Today's Appointments", lblAppointmentsToday, Color.FromArgb(215, 188, 221), new Point(50, 50), imgAppointments);
            Panel cardSales = CreateDashboardCard("Total Sales", lblTotalSales, Color.FromArgb(185, 213, 202), new Point(400, 50), imgSales);
            Panel cardStaff = CreateDashboardCard("Available Staff", lblAvailableStaff, Color.FromArgb(245, 224, 206), new Point(750, 50), imgStaff);
            Panel cardStock = CreateDashboardCard("Low Stock Products", lblLowStock, Color.FromArgb(250, 238, 221), new Point(50, 200), imgStock);


            //======================



            /*

            // CARD 1: Appointments
            Panel cardAppointments = CreateDashboardCard("Today's Appointments", lblAppointmentsToday, Color.FromArgb(215, 188, 221), new Point(50, 50));

            // CARD 2: Total Sales
            Panel cardSales = CreateDashboardCard("Total Sales", lblTotalSales, Color.FromArgb(185, 213, 202), new Point(400, 50));

            // CARD 3: Available Staff
            Panel cardStaff = CreateDashboardCard("Available Staff", lblAvailableStaff, Color.FromArgb(245, 224, 206), new Point(750, 50));

            // CARD 4: Low Stock
            Panel cardStock = CreateDashboardCard("Low Stock Products", lblLowStock, Color.FromArgb(250, 238, 221), new Point(50, 200));


            */

            // Add all cards to the dashboard
            this.Controls.Add(cardAppointments);
            this.Controls.Add(cardSales);
            this.Controls.Add(cardStaff);
            this.Controls.Add(cardStock);

            
        }
        private void DashboardControl_Load(object sender, EventArgs e)
        {
           
        }
        /*
        private Panel CreateDashboardCard(string title, string value, Color bgColor, Point location)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 100),
                BackColor = bgColor,
                Location = location,
                BorderStyle = BorderStyle.None
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(10, 40),
                AutoSize = true
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }
        */

        private Panel CreateDashboardCard(string title, string value, Color bgColor, Point location, Image icon = null)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 100),
                BackColor = bgColor,
                Location = location,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10) // breathing room
            };

            // Title (top-left)
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 8)
            };

            // Value (left, below title)
            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 38)
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            // Optional icon on the right side
            if (icon != null)
            {
                var pic = new PictureBox
                {
                    Image = new Bitmap(icon, new Size(56, 56)), // scale for consistency
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Size = new Size(56, 56),
                    Location = new Point(card.Width - 56 - 16, 22), // right padding 16
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };
                card.Controls.Add(pic);
                // Shift text a bit left so it never overlaps the icon
                // (Optional: only if your values get long)
                // lblValue.MaximumSize = new Size(card.Width - pic.Width - 32, 0);
            }

            return card;
        }



        // validation Functions  
        public static bool IsNotEmpty(System.Windows.Forms.TextBox box)
        {
            bool result = !string.IsNullOrWhiteSpace(box.Text);
            box.BackColor = result ? Color.White : Color.Red;
            box.Refresh();
            return result;

        }

        public static bool IsValidEmail(System.Windows.Forms.TextBox box)
        {
            string email = box.Text.Trim().ToLower();
            bool result = IsNotEmpty(box) && (email.EndsWith("@gmail.com") || email.EndsWith("@outlook.com") || email.EndsWith("@yahoo.com")) ;
            box.BackColor = result ? Color.White : Color.Red;
            box.Refresh();
            return result;
        }

        public static bool IsValidPhone(System.Windows.Forms.TextBox box)
        {
            string phone = box.Text.Trim();
            bool result = IsNotEmpty(box) && phone.Length == 10 && phone.StartsWith("0") && phone.All(char.IsDigit);
            box.BackColor = result ? Color.White : Color.Red;
            box.Refresh();
            return result;
        }

        public static bool IsComboBoxSelected(System.Windows.Forms.ComboBox combo)
        {
            bool result = combo.SelectedIndex >= 0;
            combo.BackColor = result ? Color.White : Color.Red;
            combo.Refresh();
            return result;
        }

        public static bool isPasswordsSame(System.Windows.Forms.TextBox box1, System.Windows.Forms.TextBox box2)
        {
            bool result = true;
            // Confirm password match
            if (box1.Text != box2.Text)
            {
                result = false;
                MessageBox.Show("Passwords do not match. Please re-enter.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            box1.BackColor = result ? Color.White : Color.Red;
            box2.BackColor = result ? Color.White : Color.Red;
            box1.Refresh();
            box2.Refresh();

            return result;
        }

        public static bool isValidAppointmentTime(TextBox txtTimeBox, out TimeSpan validTime)
        {
            validTime = TimeSpan.Zero;

            // Step 1: Try parsing the time
            bool isFormatValid = TimeSpan.TryParse(txtTimeBox.Text.Trim(), out validTime);

            // Step 2: Check time range only if format is valid
            bool isInRange = isFormatValid && validTime >= new TimeSpan(8, 0, 0) && validTime <= new TimeSpan(17, 0, 0);

            // Set back color based on final result
            txtTimeBox.BackColor = isInRange ? Color.White : Color.Red;
            txtTimeBox.Refresh();

            // Show appropriate message if not valid
            if (!isFormatValid)
            {
                MessageBox.Show("Please enter a valid time in HH:mm format (e.g., 14:30).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isInRange)
            {
                MessageBox.Show("Appointments must be between 08:00 and 17:00.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool isValidDate(DateTimePicker picker, TimeSpan appointmentTime)
        {
            DateTime selectedDate = picker.Value.Date;
            bool result = true;
            if (selectedDate < DateTime.Today ||
                (selectedDate == DateTime.Today && appointmentTime < DateTime.Now.TimeOfDay))
            {
                MessageBox.Show("Cannot book in the past.", "Invalid Date/Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            picker.ForeColor = result ? Color.White : Color.Red;
            picker.Refresh();
            return result;
        }

        public static int? GetRatingValue(NumericUpDown ratingControl, CheckBox noRatingCheckbox)
        {
            if (noRatingCheckbox.Checked)
            {
                ratingControl.BackColor = Color.White; // No rating needed
                return null;
            }

            if (ratingControl.Value < ratingControl.Minimum || ratingControl.Value > ratingControl.Maximum)
            {
                ratingControl.BackColor = Color.Red;
                ratingControl.Refresh();
                return null; // Out of valid range (shouldn't happen with UI, but safe guard)
            }

            ratingControl.BackColor = Color.White;
            ratingControl.Refresh();
            return (int)ratingControl.Value;
        }

        public static bool NumGreaterThenZero(NumericUpDown num)
        {
            if(Convert.ToInt32(num.Value) > 0)
            {
                num.BackColor = Color.White;
            }
            else
            {
                num.BackColor = Color.Red;
            }
            
            num.Refresh();

            return Convert.ToInt32(num.Value) > 0;
        }


        //End of Validation Functions




    }

}