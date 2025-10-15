namespace MunicipalServicesAppPOE
{
    partial class ReportIssueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtxtDescription = new RichTextBox();
            lblAttach = new Label();
            btnAttach = new Button();
            lblFileName = new Label();
            lblEngagementMessage = new Label();
            btnSubmit = new Button();
            btnBackToMenu = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(30, 80, 160);
            lblLocation.Location = new Point(50, 80);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(100, 25);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.White;
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(200, 77);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(300, 34);
            txtLocation.TabIndex = 1;
            txtLocation.TextChanged += FormFields_Changed;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(30, 80, 160);
            lblCategory.Location = new Point(50, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 25);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads & Potholes", "Water & Utilities", "Electricity", "Other" });
            cmbCategory.Location = new Point(200, 127);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 36);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += FormFields_Changed;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(30, 80, 160);
            lblDescription.Location = new Point(50, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 25);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // rtxtDescription
            // 
            rtxtDescription.BackColor = Color.White;
            rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDescription.Font = new Font("Segoe UI", 10F);
            rtxtDescription.Location = new Point(200, 180);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(300, 100);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            rtxtDescription.TextChanged += FormFields_Changed;
            // 
            // lblAttach
            // 
            lblAttach.AutoSize = true;
            lblAttach.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAttach.ForeColor = Color.FromArgb(30, 80, 160);
            lblAttach.Location = new Point(50, 300);
            lblAttach.Name = "lblAttach";
            lblAttach.Size = new Size(110, 25);
            lblAttach.TabIndex = 6;
            lblAttach.Text = "Attach File:";
            // 
            // btnAttach
            // 
            btnAttach.BackColor = Color.FromArgb(60, 120, 200);
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAttach.ForeColor = Color.White;
            btnAttach.Location = new Point(200, 300);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(200, 35);
            btnAttach.TabIndex = 7;
            btnAttach.Text = "Attach Image/Document...";
            btnAttach.UseVisualStyleBackColor = false;
            btnAttach.Click += btnAttach_Click;
            btnAttach.FlatAppearance.BorderColor = Color.FromArgb(30, 80, 160);
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 9F);
            lblFileName.ForeColor = Color.FromArgb(30, 80, 160);
            lblFileName.Location = new Point(200, 345);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(150, 25);
            lblFileName.TabIndex = 8;
            lblFileName.Text = "No file attached";
            // 
            // lblEngagementMessage
            // 
            lblEngagementMessage.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEngagementMessage.ForeColor = Color.FromArgb(30, 80, 160);
            lblEngagementMessage.Location = new Point(50, 390);
            lblEngagementMessage.Name = "lblEngagementMessage";
            lblEngagementMessage.Size = new Size(450, 40);
            lblEngagementMessage.TabIndex = 9;
            lblEngagementMessage.Text = "Welcome! Your report makes a difference.";
            lblEngagementMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(30, 80, 160);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(300, 450);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 40);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit Report";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(0, 40, 100);
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(100, 150, 220);
            btnBackToMenu.FlatStyle = FlatStyle.Flat;
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackToMenu.ForeColor = Color.White;
            btnBackToMenu.Location = new Point(120, 450);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(120, 40);
            btnBackToMenu.TabIndex = 11;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            btnBackToMenu.FlatAppearance.BorderColor = Color.FromArgb(80, 130, 200);
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 80, 160);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(578, 60);
            panelHeader.TabIndex = 12;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(201, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Report an Issue";
            // 
            // ReportIssueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(578, 520);
            Controls.Add(panelHeader);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnSubmit);
            Controls.Add(lblEngagementMessage);
            Controls.Add(lblFileName);
            Controls.Add(btnAttach);
            Controls.Add(lblAttach);
            Controls.Add(rtxtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Name = "ReportIssueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an Issue";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private RichTextBox rtxtDescription;
        private Label lblAttach;
        private Button btnAttach;
        private Label lblFileName;
        private Label lblEngagementMessage;
        private Button btnSubmit;
        private Button btnBackToMenu;
        private Panel panelHeader;
        private Label lblHeader;
    }
}