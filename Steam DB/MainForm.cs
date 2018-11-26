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
        /// <summary>
        /// Declare database var of ICollection(Game)
        /// </summary>
        private ICollection<Game> database;
        /// <summary>
        /// Declare csvParser var of type CSVParse.
        /// </summary>
        private CSVParser csvParser;
        /// <summary>
        /// Declare SearchFilter var of type SearchFilter
        /// </summary>
        private SearchFilter sF;
        /// <summary>
        /// filePath string.
        /// </summary>
        private string filePath;
        /// <summary>
        /// Declare a Func which receives an Object and return a Game.
        /// </summary>
        Func<Game, Object> OrderByFunc = game => game.ID;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        /// <param name="filepath">The filepath of the .csv file</param>
        public MainForm(string filepath) {
            InitializeComponent();
            filePath = filepath;
        }

        /// <summary>
        /// Shows the file in a table
        /// </summary>
        /// <param name="sender">Reference to the object that raised the 
        /// event</param>
        /// <param name="e">Passes an object specific to the event that is
        /// being handled</param>
        private void MainFormLoad(object sender, EventArgs e) {
            // initialize variable with a new HasSet of games.
            database = new HashSet<Game>();
            // initialize csvParse var.
            csvParser = new CSVParser();
            sF = new SearchFilter();
            // initialize the combo box to 0
            cboxType.SelectedIndex = 0;
            // initialize the combo box to 0
            cboxOrderBy.SelectedIndex = 0;
            // initialize the combo box to 0
            cboxOrder.SelectedIndex = 0;
            // Method: read the file and create a HasSet of Games.
            csvParser.ReadCSVFile(database, filePath);

            // var source contains the hashset data in order.
            var source = new BindingSource {
                DataSource = database.OrderBy(OrderByFunc)
            };
            // Format the Grid.
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // The user isnt allowed to insert new lines in the Grid.
            dataGrid.AllowUserToAddRows = false;
            // Insert the source in the Grid.
            dataGrid.DataSource = source;
        }

        /// <summary>
        /// ButtonFilterClick: Filtering and order the data in the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilterClick(object sender, EventArgs e) {
            // Method that converts to the right values the strings in the
            // combo box OrderBy. 
            TransformCombobox();

            // Linq: searches for values in the table, filters and orders.
            IEnumerable<Game> db2 = sF.Filter(database, txtID.Text,
                txtName.Text, dateTimePicker1.Value, txtIdade.Text,
                txtMetacritic.Text, txtRecomend.Text, checkSuppContrl.Checked,
                checkWindows.Checked, checkLinux.Checked, checkMac.Checked,
                checkSinglePlayer.Checked, checkMulti.Checked,
                checkMultiCoop.Checked, checkEditNiveis.Checked,
                checkVR.Checked);

            // Order by the value in OrderByFunc that have combobox Orderby values.
            if (cboxOrder.SelectedIndex == 0) {
                dataGrid.DataSource = db2.OrderBy(OrderByFunc).ToList();
            } else {
                dataGrid.DataSource = db2.OrderByDescending(OrderByFunc).ToList();
            }
        }

        /// <summary>
        /// Method Transformcombobox: Transforms the strings of the comboBox
        /// orderBy in the right Game Properties and save values in the Func
        /// OrderByFunc.
        /// </summary>
        private void TransformCombobox() {
            // Get the text in cboxOrderBy and save the rights value in OrderByFunc.
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

        /// <summary>
        /// Open detail form window and give the data of the selected game 
        /// to show in that window.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the 
        /// event</param>
        /// <param name="e">Passes an object specific to the event that is
        /// being handled</param>
        private void ButtonSearchClick(object sender, EventArgs e) {
            // instance of Game.
            Game gameFound = new Game();
            try {
                // Transform the combobox (Type) string in correct value and pass
                // to the database.
                if (cboxType.Text == "ID") {
                    gameFound = database.First(game => game.ID ==
                        Convert.ToInt32(textBoxValue.Text));
                } else if (cboxType.Text == "Name") {
                    gameFound = database.First(game => game.Name ==
                        textBoxValue.Text);
                }
            }
            catch {
                MessageBox.Show("The game you tried to search for doesn't" +
                    " exist.", "Error!");
                return;
            }
            // Instance of Details Form.
            Form detailsForm = new DetailsForm(gameFound);
            // Show and open detailForm.
            detailsForm.ShowDialog();
        }

        /// <summary>
        /// Reset the default values of the input fields in the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearClick(object sender, EventArgs e) {
            foreach (Control ctrl in this.Controls) {
                // Set to empty the input fields in the program.
                if (ctrl is TextBox) {
                    ((TextBox)ctrl).Text = String.Empty;
                } else if (ctrl is ComboBox) {
                    ((ComboBox)ctrl).SelectedIndex = 0;
                } else if (ctrl is CheckBox) {
                    ((CheckBox)ctrl).Checked = false;
                } else if (ctrl is DateTimePicker) {
                    ((DateTimePicker)ctrl).Value = new DateTime(1900, 01, 01);
                }
            }
        }
    }
}
