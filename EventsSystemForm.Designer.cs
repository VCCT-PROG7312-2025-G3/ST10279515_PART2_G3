namespace MunicipalServicesAppPOE
{
    partial class EventsSystemForm
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
            listBoxEvents = new ListBox();
            listBoxRecentViews = new ListBox();
            listBoxRecommendations = new ListBox();
            textBoxSearch = new TextBox();
            comboBoxCategory = new ComboBox();
            btnBack = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelSearch = new Panel();
            lblCategory = new Label();
            groupBoxEvents = new GroupBox();
            btnViewDetails = new Button();
            groupBoxRecent = new GroupBox();
            groupBoxRecommend = new GroupBox();
            lblDataStructures = new Label();
            btnBackToMain = new Button();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            groupBoxEvents.SuspendLayout();
            groupBoxRecent.SuspendLayout();
            groupBoxRecommend.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxEvents
            // 
            listBoxEvents.BackColor = Color.White;
            listBoxEvents.Font = new Font("Segoe UI", 10F);
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 54;
            listBoxEvents.Location = new Point(40, 77);
            listBoxEvents.Margin = new Padding(6, 6, 6, 6);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(1496, 598);
            listBoxEvents.TabIndex = 0;
            listBoxEvents.DoubleClick += listBoxEvents_DoubleClick;
            // 
            // listBoxRecentViews
            // 
            listBoxRecentViews.BackColor = Color.White;
            listBoxRecentViews.Font = new Font("Segoe UI", 9F);
            listBoxRecentViews.FormattingEnabled = true;
            listBoxRecentViews.Location = new Point(40, 77);
            listBoxRecentViews.Margin = new Padding(6, 6, 6, 6);
            listBoxRecentViews.Name = "listBoxRecentViews";
            listBoxRecentViews.Size = new Size(1496, 244);
            listBoxRecentViews.TabIndex = 1;
            // 
            // listBoxRecommendations
            // 
            listBoxRecommendations.BackColor = Color.White;
            listBoxRecommendations.Font = new Font("Segoe UI", 9F);
            listBoxRecommendations.FormattingEnabled = true;
            listBoxRecommendations.Location = new Point(12, 128);
            listBoxRecommendations.Margin = new Padding(6, 6, 6, 6);
            listBoxRecommendations.Name = "listBoxRecommendations";
            listBoxRecommendations.Size = new Size(716, 724);
            listBoxRecommendations.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.ForeColor = Color.Gray;
            textBoxSearch.Location = new Point(40, 38);
            textBoxSearch.Margin = new Padding(6, 6, 6, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(796, 61);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.Text = "Search events...";
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.White;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(1100, 38);
            comboBoxCategory.Margin = new Padding(6, 6, 6, 6);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(496, 62);
            comboBoxCategory.TabIndex = 4;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(30, 80, 160);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(60, 1440);
            btnBack.Margin = new Padding(6, 6, 6, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(400, 77);
            btnBack.TabIndex = 5;
            btnBack.Text = "← Back to Main Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 80, 160);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 6, 6, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2400, 192);
            panelHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(60, 58);
            lblHeader.Margin = new Padding(6, 0, 6, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1070, 106);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "📅 Events and Announcements";
            lblHeader.Click += lblHeader_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblCategory);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(comboBoxCategory);
            panelSearch.Location = new Point(40, 230);
            panelSearch.Margin = new Padding(6, 6, 6, 6);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(2318, 152);
            panelSearch.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(900, 44);
            lblCategory.Margin = new Padding(6, 0, 6, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(208, 54);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category:";
            // 
            // groupBoxEvents
            // 
            groupBoxEvents.BackColor = Color.White;
            groupBoxEvents.Controls.Add(btnViewDetails);
            groupBoxEvents.Controls.Add(listBoxEvents);
            groupBoxEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxEvents.Location = new Point(40, 422);
            groupBoxEvents.Margin = new Padding(6, 6, 6, 6);
            groupBoxEvents.Name = "groupBoxEvents";
            groupBoxEvents.Padding = new Padding(6, 6, 6, 6);
            groupBoxEvents.Size = new Size(1600, 864);
            groupBoxEvents.TabIndex = 8;
            groupBoxEvents.TabStop = false;
            groupBoxEvents.Text = "All Community Events & Announcements";
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(30, 80, 160);
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(40, 749);
            btnViewDetails.Margin = new Padding(6, 6, 6, 6);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(400, 77);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Event Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // groupBoxRecent
            // 
            groupBoxRecent.BackColor = Color.White;
            groupBoxRecent.Controls.Add(listBoxRecentViews);
            groupBoxRecent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxRecent.Location = new Point(40, 1325);
            groupBoxRecent.Margin = new Padding(6, 6, 6, 6);
            groupBoxRecent.Name = "groupBoxRecent";
            groupBoxRecent.Padding = new Padding(6, 6, 6, 6);
            groupBoxRecent.Size = new Size(1600, 365);
            groupBoxRecent.TabIndex = 9;
            groupBoxRecent.TabStop = false;
            groupBoxRecent.Text = "Recently Viewed Events (Stack Data Structure)";
            // 
            // groupBoxRecommend
            // 
            groupBoxRecommend.BackColor = Color.White;
            groupBoxRecommend.Controls.Add(listBoxRecommendations);
            groupBoxRecommend.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxRecommend.Location = new Point(1680, 422);
            groupBoxRecommend.Margin = new Padding(6, 6, 6, 6);
            groupBoxRecommend.Name = "groupBoxRecommend";
            groupBoxRecommend.Padding = new Padding(6, 6, 6, 6);
            groupBoxRecommend.Size = new Size(680, 864);
            groupBoxRecommend.TabIndex = 10;
            groupBoxRecommend.TabStop = false;
            groupBoxRecommend.Text = "Personalized Recommendations";
            // 
            // lblDataStructures
            // 
            lblDataStructures.AutoSize = true;
            lblDataStructures.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDataStructures.ForeColor = Color.FromArgb(30, 80, 160);
            lblDataStructures.Location = new Point(1680, 1306);
            lblDataStructures.Margin = new Padding(6, 0, 6, 0);
            lblDataStructures.Name = "lblDataStructures";
            lblDataStructures.Size = new Size(655, 48);
            lblDataStructures.TabIndex = 11;
            lblDataStructures.Text = "Using: Stack, Queue, Dictionary, HashSet";
            lblDataStructures.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.FromArgb(100, 150, 220);
            btnBackToMain.FlatStyle = FlatStyle.Flat;
            btnBackToMain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBackToMain.ForeColor = Color.White;
            btnBackToMain.Location = new Point(1680, 1382);
            btnBackToMain.Margin = new Padding(6, 6, 6, 6);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(400, 77);
            btnBackToMain.TabIndex = 12;
            btnBackToMain.Text = "Back to Main Menu";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // EventsSystemForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(2400, 1536);
            Controls.Add(btnBackToMain);
            Controls.Add(lblDataStructures);
            Controls.Add(groupBoxRecommend);
            Controls.Add(groupBoxRecent);
            Controls.Add(groupBoxEvents);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Controls.Add(btnBack);
            Margin = new Padding(6, 6, 6, 6);
            Name = "EventsSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Events & Announcements - Municipal Services";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            groupBoxEvents.ResumeLayout(false);
            groupBoxRecent.ResumeLayout(false);
            groupBoxRecommend.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEvents;
        private ListBox listBoxRecentViews;
        private ListBox listBoxRecommendations;
        private TextBox textBoxSearch;
        private ComboBox comboBoxCategory;
        private Button btnBack;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSearch;
        private Label lblCategory;
        private GroupBox groupBoxEvents;
        private Button btnViewDetails;
        private GroupBox groupBoxRecent;
        private GroupBox groupBoxRecommend;
        private Label lblDataStructures;
        private Button btnBackToMain;
    }
}