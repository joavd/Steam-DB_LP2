using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Steam_DB {
    /// <summary>
    /// Class that shows details about the selected Game
    /// </summary>
    public partial class DetailsForm : Form {
        private Game game;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsForm"/> class.
        /// </summary>
        public DetailsForm(Game game) {
            InitializeComponent();
            this.game = game;
        }

        private void DetailsFormLoad(object sender, EventArgs e) {
            this.Text = game.Name;
            pictureBox1.ImageLocation = game.HeaderImage.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            lblID.Text = Convert.ToString(game.ID);
            lblRDate.Text = game.ReleaseDate.ToShortDateString();
            lblAge.Text = Convert.ToString(game.RequiredAge);
            lblDLC.Text = Convert.ToString(game.DLCCount);
            lblMeta.Text = Convert.ToString(game.Metacritic);
            lblMovieCount.Text = Convert.ToString(game.MovieCount);
            lblRecomm.Text = Convert.ToString(game.RecommendationCount);
            lblScreenShotCount.Text = Convert.ToString(game.ScreenshotCount);
            lblOwners.Text = Convert.ToString(game.Owners);
            lblNumbOfPlayers.Text = Convert.ToString(game.NumberOfPlayers);
            lblAchievements.Text = Convert.ToString(game.AchievementCount);
            cbController.Checked = game.ControllerSupport;
            cbWindows.Checked = game.PlatformWindows;
            cbLinux.Checked = game.PlatformLinux;
            cbMac.Checked = game.PlatformMac;
            cbSP.Checked = game.CategorySinglePlayer;
            cbMP.Checked = game.CategoryMultiplayer;
            cbCoop.Checked = game.CategoryCoop;
            cbLevel.Checked = game.CategoryIncludeLevelEditor;
            cbVR.Checked = game.CategoryVRSupport;
            richTextBox1.Text = game.AboutText;

            if (game.SupportURL.IsAbsoluteUri || 
                game.SupportURL.ToString().Contains("www.")) {
                buttonSURL.Enabled = true;
            }
            if (game.Website.IsAbsoluteUri ||
                game.Website.ToString().Contains("www.")) {
                buttonWebsite.Enabled = true;
            }

        }

        private void ButtonSURLClick(object sender, EventArgs e) {
            OpenWebsite(game.SupportURL.ToString());
        }

        private void ButtonWebsiteClick(object sender, EventArgs e) {
            OpenWebsite(game.Website.ToString());
        }

        private void OpenWebsite(string url) {
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            try {
                Process.Start(sInfo);
            } catch {
                MessageBox.Show("There was an error displaying the webpage" +
                    ".", "Error!");
            }
        }
    }
}
