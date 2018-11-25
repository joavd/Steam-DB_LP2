using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
