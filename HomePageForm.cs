using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesAppPOE
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            // Professional design without any image
            this.BackColor = Color.FromArgb(0, 71, 125); // Nice municipal blue
            lblWelcomeTitle.ForeColor = Color.White;
            lblWelcomeSubtitle.ForeColor = Color.White;

            // Make panel semi-transparent with a nice effect
            panel1.BackColor = Color.FromArgb(180, 255, 255, 255); // Semi-transparent white
            panel1.BringToFront();
        }



        private void btnEnterMenu_Click(object sender, EventArgs e)
        {
            // Open the Main Menu and hide the homepage
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {

        }
    }
}