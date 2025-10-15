using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesAppPOE
{
    public partial class ReportIssueForm : Form
    {
        // Data structure to store reported issues
        public static List<ReportedIssue> IssuesList = new List<ReportedIssue>();

        public ReportIssueForm()
        {
            InitializeComponent();
            UpdateEngagementMessage(); // Initialize the engagement message
        }

        // User engagement strategy: Feedback & Transparency
        private void UpdateEngagementMessage()
        {
            string[] messages = {
                "Welcome! Your report makes a difference.",
                "Thank you for helping us improve your community.",
                "Providing details helps us resolve the issue faster.",
                "Your report is important to us. Almost done!",
                "Thank you for your civic engagement!"
            };

            int progressIndex = 0;
            if (!string.IsNullOrEmpty(txtLocation.Text)) progressIndex++;
            if (cmbCategory.SelectedIndex != -1) progressIndex++;
            if (!string.IsNullOrEmpty(rtxtDescription.Text)) progressIndex++;
            if (!string.IsNullOrEmpty(lblFileName.Text) && lblFileName.Text != "No file attached") progressIndex++;

            progressIndex = Math.Min(progressIndex, messages.Length - 1);
            lblEngagementMessage.Text = messages[progressIndex];
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Attach a File";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = openFileDialog.SafeFileName;
            }
            UpdateEngagementMessage();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrEmpty(txtLocation.Text) || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a location and select a category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new issue object and add it to the list
            ReportedIssue newIssue = new ReportedIssue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtxtDescription.Text,
                FilePath = lblFileName.Text,
                Status = "Received",
                ReportID = IssuesList.Count + 1
            };
            IssuesList.Add(newIssue);

            // User Feedback
            MessageBox.Show($"Thank you! Your report has been submitted.\n\nYour reference number is: MS{newIssue.ReportID:D4}\n\nYou will receive updates on the status of your request. Thank you for helping us improve your community!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Reset form
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtxtDescription.Clear();
            lblFileName.Text = "No file attached";
            UpdateEngagementMessage();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }

        // Update the engagement message as the user types/selects
        private void FormFields_Changed(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportIssueForm_Load_1(object sender, EventArgs e)
        {

        }
    }

    // Class to represent a reported issue
    public class ReportedIssue
    {
        public int ReportID { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
    }
}