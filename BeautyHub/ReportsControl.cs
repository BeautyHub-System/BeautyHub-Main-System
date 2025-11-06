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
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

        private async void ReportsControl_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            string powerBilink = "https://app.powerbi.com/view?r=eyJrIjoiNDFkYjJmZjQtOWVlNC00NTE0LThjMTYtODQyMWIwNmQyZDExIiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9";
            webView21.Source = new Uri(powerBilink);
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
