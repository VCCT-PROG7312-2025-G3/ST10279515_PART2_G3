namespace MunicipalServicesAppPOE
{
    partial class MainMenuForm
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
            btnReportIssue = new Button();
            btnLocalEvents = new Button();
            btnRequestStatus = new Button();
            btnExit = new Button();
            lblWelcome = new Label();
            panel1 = new Panel();
            lblSubtitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReportIssue
            // 
            btnReportIssue.BackColor = Color.FromArgb(30, 80, 160);
            btnReportIssue.FlatAppearance.BorderColor = Color.FromArgb(0, 40, 100);
            btnReportIssue.FlatAppearance.BorderSize = 2;
            btnReportIssue.FlatStyle = FlatStyle.Flat;
            btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportIssue.ForeColor = Color.White;
            btnReportIssue.Location = new Point(500, 288);
            btnReportIssue.Margin = new Padding(6, 6, 6, 6);
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.Size = new Size(600, 115);
            btnReportIssue.TabIndex = 0;
            btnReportIssue.Text = "Report Issues";
            btnReportIssue.UseVisualStyleBackColor = false;
            btnReportIssue.Click += btnReportIssue_Click;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.BackColor = Color.FromArgb(60, 120, 200);
            btnLocalEvents.FlatAppearance.BorderColor = Color.FromArgb(0, 60, 150);
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalEvents.ForeColor = Color.White;
            btnLocalEvents.Location = new Point(500, 442);
            btnLocalEvents.Margin = new Padding(6, 6, 6, 6);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(600, 115);
            btnLocalEvents.TabIndex = 1;
            btnLocalEvents.Text = "Events/Announcements";
            btnLocalEvents.UseVisualStyleBackColor = false;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // btnRequestStatus
            // 
            btnRequestStatus.BackColor = Color.FromArgb(100, 150, 220);
            btnRequestStatus.Enabled = false;
            btnRequestStatus.FlatAppearance.BorderColor = Color.FromArgb(80, 130, 200);
            btnRequestStatus.FlatStyle = FlatStyle.Flat;
            btnRequestStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRequestStatus.ForeColor = Color.White;
            btnRequestStatus.Location = new Point(500, 595);
            btnRequestStatus.Margin = new Padding(6, 6, 6, 6);
            btnRequestStatus.Name = "btnRequestStatus";
            btnRequestStatus.Size = new Size(600, 115);
            btnRequestStatus.TabIndex = 2;
            btnRequestStatus.Text = "Service Request Status";
            btnRequestStatus.UseVisualStyleBackColor = false;
            btnRequestStatus.Click += btnRequestStatus_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(220, 80, 80);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(700, 749);
            btnExit.Margin = new Padding(6, 6, 6, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 67);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(270, 27);
            lblWelcome.Margin = new Padding(6, 0, 6, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1000, 96);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Municipal Services Portal";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 80, 160);
            panel1.Controls.Add(lblSubtitle);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 230);
            panel1.TabIndex = 5;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightBlue;
            lblSubtitle.Location = new Point(256, 123);
            lblSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(1000, 58);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Your Gateway to Community Services";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(1597, 864);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnRequestStatus);
            Controls.Add(btnLocalEvents);
            Controls.Add(btnReportIssue);
            Margin = new Padding(6, 6, 6, 6);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipal Services";
            Load += MainMenuForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReportIssue;
        private Button btnLocalEvents;
        private Button btnRequestStatus;
        private Button btnExit;
        private Label lblWelcome;
        private Panel panel1;
        private Label lblSubtitle;
    }
}