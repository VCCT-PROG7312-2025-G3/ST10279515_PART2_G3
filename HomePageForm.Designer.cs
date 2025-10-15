namespace MunicipalServicesAppPOE
{
    partial class HomePageForm
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
            lblWelcomeTitle = new Label();
            lblWelcomeSubtitle = new Label();
            btnEnterMenu = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.BackColor = Color.Transparent;
            lblWelcomeTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.White;
            lblWelcomeTitle.Location = new Point(6, -40);
            lblWelcomeTitle.Margin = new Padding(6, 0, 6, 0);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(1183, 174);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "Welcome to SA's Municipality";
            lblWelcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeTitle.Click += lblWelcomeTitle_Click;
            // 
            // lblWelcomeSubtitle
            // 
            lblWelcomeSubtitle.BackColor = Color.Transparent;
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeSubtitle.ForeColor = Color.White;
            lblWelcomeSubtitle.Location = new Point(60, 134);
            lblWelcomeSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            lblWelcomeSubtitle.Size = new Size(1080, 154);
            lblWelcomeSubtitle.TabIndex = 1;
            lblWelcomeSubtitle.Text = "Your one-stop platform for reporting issues, viewing events, and tracking service requests.";
            lblWelcomeSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEnterMenu
            // 
            btnEnterMenu.BackColor = Color.FromArgb(0, 102, 204);
            btnEnterMenu.FlatStyle = FlatStyle.Flat;
            btnEnterMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnterMenu.ForeColor = Color.White;
            btnEnterMenu.Location = new Point(400, 326);
            btnEnterMenu.Margin = new Padding(6);
            btnEnterMenu.Name = "btnEnterMenu";
            btnEnterMenu.Size = new Size(400, 96);
            btnEnterMenu.TabIndex = 2;
            btnEnterMenu.Text = "Enter Main Menu";
            btnEnterMenu.UseVisualStyleBackColor = false;
            btnEnterMenu.Click += btnEnterMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(220, 80, 80);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(500, 461);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 67);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(lblWelcomeTitle);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblWelcomeSubtitle);
            panel1.Controls.Add(btnEnterMenu);
            panel1.Location = new Point(200, 115);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 576);
            panel1.TabIndex = 4;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 864);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SA Municipality - Home";
            Load += HomePageForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcomeTitle;
        private Label lblWelcomeSubtitle;
        private Button btnEnterMenu;
        private Button btnExit;
        private Panel panel1;
    }
}