using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Steam_DB {
    /// <summary>
    /// Class that shows the Data and manages searches and filters
    /// </summary>
    public partial class MainForm : Form {
        private ICollection<Game> database;
        private CSVParser csvParser;
        private string filePath;
        Func<Game, Object> OrderByFunc = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        /// <param name="filepath">The filepath of the .csv file</param>
        public MainForm(string filepath) {
            InitializeComponent();
            filePath = filepath;
        }

        private void MainFormLoad(object sender, EventArgs e) {
            database = new HashSet<Game>();
            csvParser = new CSVParser();
            comboBoxType.SelectedIndex = 0;
            cboxOrderBy.SelectedIndex = 0;

            csvParser.ReadCSVFile(database, filePath);

            var source = new BindingSource {
                DataSource = database
            };
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = source;
        }

        private void ButtonFilterClick(object sender, EventArgs e) {
            TransformCombobox();

            IEnumerable<Game> db2 =
                (from game in database
                 where (string.IsNullOrEmpty(txtID.Text) ||
                        game.ID.ToString().Contains(txtID.Text))

                    && (string.IsNullOrEmpty(txtName.Text) ||
                        game.Name.ToLower().Contains(txtName.Text.ToLower()))

                    && (string.IsNullOrEmpty(dateTimePicker1.Text) ||
                        game.ReleaseDate >= dateTimePicker1.Value.Date)

                    && (string.IsNullOrEmpty(txtIdade.Text) ||
                        game.RequiredAge >= Convert.ToInt32(txtIdade.Text))

                    && (string.IsNullOrEmpty(txtMetacritic.Text) ||
                        game.Metacritic >= Convert.ToInt32(txtMetacritic.Text))

                    && (string.IsNullOrEmpty(txtRecomend.Text) ||
                        game.RecommendationCount >= Convert.ToInt32(txtRecomend.Text))

                    && ((checkSuppContrl.Checked == false) ||
                        game.ControllerSupport == checkSuppContrl.Checked)

                    && ((checkWindows.Checked == false) ||
                        game.PlatformWindows == checkWindows.Checked)

                    && ((checkLinux.Checked == false) ||
                        game.PlatformLinux == checkLinux.Checked)

                    && ((checkMac.Checked == false) ||
                        game.PlatformMac == checkMac.Checked)

                    && ((checkSinglePlayer.Checked == false) ||
                        game.CategorySinglePlayer == checkSinglePlayer.Checked)

                    && ((checkMulti.Checked == false) ||
                        game.CategoryMultiplayer == checkMulti.Checked)

                    && ((checkMultiCoop.Checked == false) ||
                        game.CategoryCoop == checkMultiCoop.Checked)

                    && ((checkEditNiveis.Checked == false) ||
                        game.CategoryIncludeLevelEditor == checkEditNiveis.Checked)

                    && ((checkVR.Checked == false) ||
                        game.CategoryVRSupport == checkVR.Checked)

                 select game).OrderBy(OrderByFunc).ToList();

            dataGridView1.DataSource = db2;
        }

        private void TransformCombobox() {
            if (cboxOrderBy.Text == "ID") {
                OrderByFunc = game => game.ID;
            } else if (cboxOrderBy.Text == "Name") {
                OrderByFunc = game => game.Name;
            } else if (cboxOrderBy.Text == "Release Date") {
                OrderByFunc = game => game.ReleaseDate;
            } else if (cboxOrderBy.Text == "Number of DLC´s") {
                OrderByFunc = game => game.DLCCount;
            } else if (cboxOrderBy.Text == "Metacritic") {
                OrderByFunc = game => game.Metacritic;
            } else if (cboxOrderBy.Text == "Recomendations") {
                OrderByFunc = game => game.RecommendationCount;
            } else if (cboxOrderBy.Text == "People who have") {
                OrderByFunc = game => game.Owners;
            } else if (cboxOrderBy.Text == "People who play") {
                OrderByFunc = game => game.NumberOfPlayers;
            } else if (cboxOrderBy.Text == "Achievements") {
                OrderByFunc = game => game.AchievementCount;
            }
        }

        private void ButtonSearchClick(object sender, EventArgs e) {
            Game gameFound = new Game();
            try {
                if (comboBoxType.Text == "ID") {
                    gameFound = database.First(game => game.ID ==
                        Convert.ToInt32(textBoxValue.Text));
                } else if (comboBoxType.Text == "Name") {
                    gameFound = database.First(game => game.Name ==
                        textBoxValue.Text);
                }
            } catch {
                MessageBox.Show("The game you tried to search for doesn't" +
                    " exist.", "Error!");
                return;
            }

            Form detailsForm = new DetailsForm(gameFound);
            detailsForm.ShowDialog();
        }
    }
}
