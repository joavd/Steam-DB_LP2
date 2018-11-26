using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Steam_DB {
    /// <summary>
    /// Class that shows details about the selected Game
    /// </summary>
    public partial class DetailsForm : Form {
        /// <summary>
        /// Instance of Game.
        /// </summary>
        private Game game;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsForm"/> class.
        /// </summary>
        public DetailsForm(Game game) {
            InitializeComponent();
            this.game = game;
        }

        /// <summary>
        /// Show the selected game in Detailsform, show the foto and the data 
        /// of that game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsFormLoad(object sender, EventArgs e) {
            // Set the game name header. 
            this.Text = game.Name;
            // Insert the foto to the picturebox.
            pictureBox1.ImageLocation = game.HeaderImage.ToString();
            // format the foto.
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            // Insert the data in the elements of the window.
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

            // Enable button if the game have SupportURL
            if (game.SupportURL.IsAbsoluteUri || 
                game.SupportURL.ToString().Contains("www.")) {
                buttonSURL.Enabled = true;
            }
            // Enable button if the game have Website
            if (game.Website.IsAbsoluteUri ||
                game.Website.ToString().Contains("www.")) {
                buttonWebsite.Enabled = true;
            }

        }

        /// <summary>
        /// ButtonsURLClick: Open the SupportURL of the game selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSURLClick(object sender, EventArgs e) {
            OpenWebsite(game.SupportURL.ToString());
        }

        /// <summary>
        /// ButtonWebsiteClick: Open the Website of the game selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWebsiteClick(object sender, EventArgs e) {
            OpenWebsite(game.Website.ToString());
        }

        /// <summary>
        /// OpenWebsite: Do the action to Open the navigator.
        /// </summary>
        /// <param name="url"></param>
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
