public partial class DashboardControl : UserControl
{
    public DashboardControl()
    {
        InitializeComponent();
        this.BackColor = Color.FromArgb(248, 245, 243); // Match main theme

        // Example: Total Appointments label
        Label lblAppointments = new Label
        {
            Text = "Today's Appointments: 8",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            ForeColor = Color.Black,
            Location = new Point(40, 40),
            AutoSize = true
        };

        // Example: Total Sales label
        Label lblSales = new Label
        {
            Text = "Total Sales: R 1,200",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            ForeColor = Color.Black,
            Location = new Point(40, 90),
            AutoSize = true
        };

        this.Controls.Add(lblAppointments);
        this.Controls.Add(lblSales);
    }
}
