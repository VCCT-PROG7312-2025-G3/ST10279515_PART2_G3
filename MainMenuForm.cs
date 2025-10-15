using System;
using System.Windows.Forms;

namespace MunicipalServicesAppPOE
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            // Only disable Service Request Status now
            btnRequestStatus.Enabled = false;
            // Events & Announcements should be ENABLED
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Any initialization code
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            // Open the Report Issues form
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.Show();
            this.Hide();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            // Open the Events System
            EventsSystemForm eventsForm = new EventsSystemForm();
            eventsForm.Show();
            this.Hide();
        }

        private void btnRequestStatus_Click(object sender, EventArgs e)
        {
            // This will be implemented later
            MessageBox.Show("Service Request Status feature is coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}