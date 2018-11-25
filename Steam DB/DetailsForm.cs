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
            this.Text = "Details about " + game.Name;
            pictureBox1.ImageLocation = game.HeaderImage.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            lblID.Text = Convert.ToString(game.ID);
            lblName.Text = game.Name;
            lblRDate.Text = Convert.ToString(game.ReleaseDate.Date);
            lblAge.Text = Convert.ToString(game.RequiredAge);
            lblDLC.Text = Convert.ToString(game.DLCCount);
            lblMeta.Text = Convert.ToString(game.Metacritic);
            lblMovieCount.Text = Convert.ToString(game.MovieCount);
            lblRecomm.Text = Convert.ToString(game.RecommendationCount);
            lblScreenShotCount.Text = Convert.ToString(game.ScreenshotCount);
            lblOwners.Text = Convert.ToString(game.Owners);
            lblNumbOfPlayers.Text = Convert.ToString(game.NumberOfPlayers);
            lblAchievements.Text = Convert.ToString(game.AchievementCount);
            lblContrSuport.Text = Convert.ToString(game.ControllerSupport);
            lblPlatWindows.Text = Convert.ToString(game.PlatformWindows);
            lblPlatLinux.Text = Convert.ToString(game.PlatformLinux);
            lblPlatMac.Text = Convert.ToString(game.PlatformMac);
            lblSinglePlayer.Text = Convert.ToString(game.CategorySinglePlayer);
            lblMulti.Text = Convert.ToString(game.CategoryMultiplayer);
            lblCoop.Text = Convert.ToString(game.CategoryCoop);
            lblIncludeEditor.Text = Convert.ToString(game.CategoryIncludeLevelEditor);
            lblVR.Text = Convert.ToString(game.CategoryVRSupport);
            //lblAboutText.Text = Convert.ToString(game.AboutText);

            if (!game.SupportURL.IsAbsoluteUri) {
                buttonSURL.Enabled = false;
            }
            if (!game.Website.IsAbsoluteUri) {
                buttonWebsite.Enabled = false;
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
            Process.Start(sInfo);
        }
    }
}
