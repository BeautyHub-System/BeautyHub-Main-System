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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Set form properties
            this.Text = "Spa Management System";
            this.WindowState = FormWindowState.Maximized; // Fullscreen
            this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resizing
            this.BackColor = Color.FromArgb(248, 245, 243); // Light beige spa tone


            // Create sidebar panel
            Panel sidebar = new Panel
            {
                Name = "sidebar",
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(240, 235, 230) // soft beige-gray
            };
            this.Controls.Add(sidebar);

            // Create main content panel
            Panel mainContentPanel = new Panel
            {
                Name = "mainContent",
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 245, 243) // matches form background
            };
            this.Controls.Add(mainContentPanel);
            this.Controls.SetChildIndex(mainContentPanel, 0); // Ensure it's behind sidebar

            

            LoadPage(new DashboardControl());

            




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Icon images
            Image dashboardIcon = Image.FromFile("Resources/DashboardIcon.png");
            Image appointmentIcon = Image.FromFile("Resources/AppointmentsIcon.png");
            Image salesIcon = Image.FromFile("Resources/SalesIcon.png");
            Image staffIcon = Image.FromFile("Resources/StaffIcon.png");
            Image logoutIcon = Image.FromFile("Resources/check-out.png");
            Image productsIcon = Image.FromFile("Resources/ProductsIcon.png");
            Image customersIcon = Image.FromFile("Resources/CustomerIcon.png");
            Image reportIcon = Image.FromFile("Resources/report.png");



            // Reference to sidebar panel
            Panel sidebar = this.Controls.Find("sidebar", true).FirstOrDefault() as Panel;

            if (sidebar != null)
            {
                
                Button btnDashboard = CreateSidebarButton("Dashboard", 20, dashboardIcon);
                btnDashboard.Click += (s, evt) => LoadPage(new DashboardControl());// ⬅️ Attach the event

                // Now add to sidebar
                sidebar.Controls.Add(btnDashboard);

                // The rest of your buttons

                Button btnAppointments = CreateSidebarButton("Appointments", 170, appointmentIcon);
                btnAppointments.Click += (s, evt) => LoadPage(new AppointmentsControl());
                sidebar.Controls.Add(btnAppointments);




                //sidebar.Controls.Add(CreateSidebarButton("Staff", 320, staffIcon));

                Button btnStaff = CreateSidebarButton("Staff", 320, staffIcon);
                btnStaff.Click += (s, evt) => LoadPage(new StaffControl());
                sidebar.Controls.Add(btnStaff);



                //sidebar.Controls.Add(CreateSidebarButton("Customers", 270, customersIcon));

                Button btnCustomer = CreateSidebarButton("Customers", 120, customersIcon);
                btnCustomer.Click += (s, evt) => LoadPage(new CustomerControl());
                sidebar.Controls.Add(btnCustomer);


                //sidebar.Controls.Add(CreateSidebarButton("Products", 220, productsIcon));

                Button btnProducts = CreateSidebarButton("Products", 270, productsIcon);
                btnProducts.Click += (s, evt) => LoadPage(new ProductControl());
                sidebar.Controls.Add(btnProducts);



                //sidebar.Controls.Add(CreateSidebarButton("Sales", 170, salesIcon));
                Button btnSales = CreateSidebarButton("Sales", 220, salesIcon);
                btnSales.Click += (s, evt) => LoadPage(new SalesControl());
                sidebar.Controls.Add(btnSales);


                Button btnReports = CreateSidebarButton("Reports", 370, reportIcon);
                btnReports.Click += (s, evt) => LoadPage(new ReportsControl());
                sidebar.Controls.Add(btnReports);

                Button btnLogout = CreateSidebarButton("LogOut", 550, logoutIcon);
                //Form1 loginPage = new Form1();

                //btnLogout.Click += (s, evt) => loginPage.ShowDialog();
                btnLogout.Click += (s, evt) =>
                {
                    Form1 loginPage = new Form1();
                    loginPage.Show();  // Show Form1
                    this.Hide();      // Close Form2
                };


                sidebar.Controls.Add(btnLogout);
                //sidebar.Controls.Add(CreateSidebarButton("Settings", 370, settingsIcon));
            }




        }

        //helper function to make clean, flat, modern buttons.
        private Button CreateSidebarButton(string text, int top, Image icon)
        {
            Button btn = new Button();
            btn.Text = "   " + text;
            btn.Image = new Bitmap(icon, new Size(30, 30)); // Resize image
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText; // Prevent overlap
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(240, 235, 230);
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            btn.Width = 220;
            btn.Height = 45;
            btn.Top = top;
            btn.Left = 0;
            btn.Cursor = Cursors.Hand;
            return btn;
        }


        private void LoadPage(UserControl page)
        {
            Panel mainContent = this.Controls.Find("mainContent", true).FirstOrDefault() as Panel;

            if (mainContent != null)
            {
                mainContent.Controls.Clear();
                page.Dock = DockStyle.Fill;
                mainContent.Controls.Add(page);
            }
        }








    }

}
