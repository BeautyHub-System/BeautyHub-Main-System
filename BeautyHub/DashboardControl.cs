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

        // ===== Overlay detail panel stuff =====
        private Panel pnlDetails;
        private Label lblDetailsHeader;
        private DataGridView dgvDetails;
        private Button btnCloseDetails;



        public DashboardControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(248, 245, 243);

            // images
            imgAppointments = Image.FromFile("Resources/massage.png");
            imgSales = Image.FromFile("Resources/salary.png");
            imgStaff = Image.FromFile("Resources/grouping.png");
            imgStock = Image.FromFile("Resources/out-of-stock.png");

            // ===== dashboard numbers =====
            string lblAppointmentsToday = "0";
            string lblAvailableStaff = "0";
            string lblLowStock = "0";
            string lblTotalSales = "error";

            try
            {
                int count = Convert.ToInt32(appointmentNEWTableAdapter.GetTodayAppointmentCount());
                lblAppointmentsToday = count.ToString();
            }
            catch { lblAppointmentsToday = "0"; }

            try
            {
                var staffTable = staffNEWTableAdapter.GetData();
                int availableStaffCount = staffTable
                    .Where(s => s.IsActive && s.Status == "Available")
                    .Count();
                lblAvailableStaff = availableStaffCount.ToString();
            }
            catch { lblAvailableStaff = "0"; }

            try
            {
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);

                int lowStockCount = spaDataSet.ProductNEW
                    .Where(p => p.IsActive && p.QuantityInStock <= lowStockThreshold)
                    .Count();
                lblLowStock = $"{lowStockCount} Low in Stock";
            }
            catch { lblLowStock = "0 Low in Stock"; }

            try
            {
                lblTotalSales = "R " + saleNEWTableAdapter1.GetTotalSales();
            }
            catch { lblTotalSales = "R 0"; }

            // ===== create cards =====
            Panel cardAppointments = CreateDashboardCard(
                "Today's Appointments",
                lblAppointmentsToday,
                Color.FromArgb(215, 188, 221),
                new Point(50, 50),
                imgAppointments
            );

            Panel cardSales = CreateDashboardCard(
                "Total Sales",
                lblTotalSales,
                Color.FromArgb(185, 213, 202),
                new Point(400, 50),
                imgSales
            );

            Panel cardStaff = CreateDashboardCard(
                "Available Staff",
                lblAvailableStaff,
                Color.FromArgb(245, 224, 206),
                new Point(750, 50),
                imgStaff
            );

            Panel cardStock = CreateDashboardCard(
                "Low Stock Products",
                lblLowStock,
                Color.FromArgb(250, 238, 221),
                new Point(50, 200),
                imgStock
            );

            // ===== build the overlay panel BEFORE wiring clicks =====
            BuildDetailsOverlayPanel();

            // ===== hook click handlers =====
            cardAppointments.Click += ShowTodayAppointments;
            cardSales.Click += ShowSalesBreakdown;
            cardStaff.Click += ShowAvailableStaff;
            cardStock.Click += ShowLowStockProducts;

            HookChildClicksToParent(cardAppointments, ShowTodayAppointments);
            HookChildClicksToParent(cardSales, ShowSalesBreakdown);
            HookChildClicksToParent(cardStaff, ShowAvailableStaff);
            HookChildClicksToParent(cardStock, ShowLowStockProducts);

            // ===== add controls to dashboard =====
            this.Controls.Add(cardAppointments);
            this.Controls.Add(cardSales);
            this.Controls.Add(cardStaff);
            this.Controls.Add(cardStock);

            this.Controls.Add(pnlDetails); // overlay last so it's "on top"
        }


        private void DashboardControl_Load(object sender, EventArgs e)
        {
           
        }


        private Panel CreateDashboardCard(string title, string value, Color bgColor, Point location, Image icon = null)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 100),
                BackColor = bgColor,
                Location = location,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10),
                Cursor = Cursors.Hand
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 8),
                Cursor = Cursors.Hand
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 38),
                Cursor = Cursors.Hand
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            if (icon != null)
            {
                var pic = new PictureBox
                {
                    Image = new Bitmap(icon, new Size(56, 56)),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Size = new Size(56, 56),
                    Location = new Point(card.Width - 56 - 16, 22),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Cursor = Cursors.Hand
                };
                card.Controls.Add(pic);
            }

            return card;
        }


        private void BuildDetailsOverlayPanel()
        {
            pnlDetails = new Panel
            {
                Size = new Size(800, 400),
                Location = new Point(100, 120),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            // header label at top-left ("Today's Appointments", etc.)
            lblDetailsHeader = new Label
            {
                Text = "Details",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(15, 15),
                ForeColor = Color.Black
            };

            // close button at top-right
            btnCloseDetails = new Button
            {
                Text = "X",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(30, 30),
                Location = new Point(800 - 45, 10), // panel width - 45
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnCloseDetails.FlatAppearance.BorderSize = 0;
            btnCloseDetails.Click += (s, e) =>
            {
                pnlDetails.Visible = false;
            };

            // the grid for the data
            dgvDetails = new DataGridView
            {
                Location = new Point(15, 55),
                Size = new Size(770, 330),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            pnlDetails.Controls.Add(lblDetailsHeader);
            pnlDetails.Controls.Add(btnCloseDetails);
            pnlDetails.Controls.Add(dgvDetails);
        }

        private void EnsureOverlay()
        {
            if (pnlDetails == null || dgvDetails == null || lblDetailsHeader == null)
            {
                BuildDetailsOverlayPanel();
                if (!this.Controls.Contains(pnlDetails))
                {
                    this.Controls.Add(pnlDetails);
                }
            }
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

        
        private void HookChildClicksToParent(Control parent, EventHandler handler)
        {
            foreach (Control c in parent.Controls)
            {
                c.Cursor = Cursors.Hand;
                c.Click += handler;
            }
            parent.Cursor = Cursors.Hand;
        }

        private void ShowTodayAppointments(object sender, EventArgs e)
        {
            try
            {
                EnsureOverlay();

                DateTime today = DateTime.Today;

                var allAppts = appointmentNEWTableAdapter.GetData();
                if (allAppts == null)
                {
                    MessageBox.Show("No appointment data returned.");
                    return;
                }

                var todays = allAppts
                    .Where(a =>
                        a != null &&
                        a.Date != null &&
                        a.Date.Date == today
                    )
                    .Select(a => new
                    {
                        a.AppointmentID,
                        a.Date,
                        a.Time,
                        a.CustomerID,
                        a.StaffID,
                        a.Status,
                        // Some rows might have NULL in Comment or Rating
                        Comment = a.IsCommentNull() ? "" : a.Comment,
                        Rating = a.IsRatingNull() ? (int?)null : a.Rating
                    })
                    .ToList();

                lblDetailsHeader.Text = "Today's Appointments";
                dgvDetails.DataSource = todays;
                pnlDetails.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading today's appointments:\n" + ex.Message);
            }
        }



        private void ShowAvailableStaff(object sender, EventArgs e)
        {
            try
            {
                EnsureOverlay();

                var staffTable = staffNEWTableAdapter.GetData();
                if (staffTable == null)
                {
                    MessageBox.Show("No staff data returned.");
                    return;
                }

                var available = staffTable
                    .Where(s =>
                        s != null &&
                        s.IsActive == true &&
                        s.Status == "Available"
                    )
                    .Select(s => new
                    {
                        s.StaffID,
                        s.FirstName,
                        s.LastName,
                        s.Role,
                        s.Status
                    })
                    .ToList();

                lblDetailsHeader.Text = "Available Staff";
                dgvDetails.DataSource = available;
                pnlDetails.Visible = true;
                pnlDetails.Location = new Point(50, 200);
                pnlDetails.Size = new Size(900, 300);
                pnlDetails.Visible = true;
                pnlDetails.BringToFront();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff:\n" + ex.Message);
            }
        }


        private void ShowLowStockProducts(object sender, EventArgs e)
        {
            try
            {
                EnsureOverlay();

                // Refresh from DB
                productNEWTableAdapter.Fill(spaDataSet.ProductNEW);

                var low = spaDataSet.ProductNEW
                    .Where(p =>
                        p != null &&
                        p.IsActive == true &&
                        p.QuantityInStock <= lowStockThreshold
                    )
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.QuantityInStock,
                        p.Price,

                        // Force Promotion into a string no matter what its real type is
                        Promotion = p.IsPromotionNull()
                            ? ""
                            : p.Promotion.ToString(),

                        // Force PromotionPrice into a nullable decimal display value
                        PromotionPrice = p.IsPromotionPriceNull()
                            ? (decimal?)null
                            : p.PromotionPrice
                    })
                    .ToList();

                lblDetailsHeader.Text = "Low Stock Products";
                dgvDetails.DataSource = low;
                pnlDetails.Visible = true;
                pnlDetails.Location = new Point(50, 200);
                pnlDetails.Size = new Size(900, 300);
                pnlDetails.Visible = true;
                pnlDetails.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stock:\n" + ex.Message);
            }
        }



        private void ShowSalesBreakdown(object sender, EventArgs e)
        {
            try
            {
                EnsureOverlay();

                string totalSalesText;
                try
                {
                    totalSalesText = "R " + saleNEWTableAdapter1.GetTotalSales();
                }
                catch
                {
                    totalSalesText = "R 0";
                }

                var list = new[]
                {
            new { Metric = "Total Sales", Value = totalSalesText }
        }.ToList();

                lblDetailsHeader.Text = "Sales Summary";
                dgvDetails.DataSource = list;
                pnlDetails.Visible = true;
                pnlDetails.Location = new Point(50, 200);
                pnlDetails.Size = new Size(900, 300);
                pnlDetails.Visible = true;
                pnlDetails.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales:\n" + ex.Message);
            }
        }











    }

}