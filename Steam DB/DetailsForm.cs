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
