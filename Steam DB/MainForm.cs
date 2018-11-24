using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;

namespace Steam_DB
{
    /// <summary>
    /// Class that shows the Data and manages searches and filters
    /// </summary>
    public partial class MainForm : Form
    {
        private ICollection<Game> database;
        private DataTable dataTable;
        private CSVParser csvParser;
        private string filePath;
        Func<Game, Object> OrderByFunc = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        /// <param name="filepath"></param>
        public MainForm(string filepath)
        {
            InitializeComponent();
            filePath = filepath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database = new HashSet<Game>();
            csvParser = new CSVParser();

            csvParser.ReadCSVFile(database, filePath);

            var source = new BindingSource();
            dataTable = new DataTable();

            using (var reader = ObjectReader.Create(database, "ID", "Name",
                "ReleaseDate", "RequiredAge", "DLCCount", "Metacritic",
                "MovieCount", "RecommendationCount", "ScreenshotCount",
                "Owners", "NumberOfPlayers", "AchievementCount",
                "ControllerSupport", "PlatformWindows", "PlatformLinux",
                "PlatformMac", "CategorySinglePlayer",
                "CategoryMultiplayer", "CategoryCoop",
                "CategoryIncludeLevelEditor", "CategoryVRSupport",
                "SupportURL", "AboutText", "HeaderImage", "Website"))
            {
                dataTable.Load(reader);
            }
            source.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

                    && ((checkWindows.Checked != false) ||
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

                    //orderby OrderByFunc descending
                 select game).ToList();
           
            dataGridView1.DataSource = db2;
        }

        private void TransformCombobox()
        {
            if (cboxOrderBy.Text == "ID") { OrderByFunc = game => game.ID; }
            else if (cboxOrderBy.Text == "Name") { OrderByFunc = game => game.Name; }
            else if (cboxOrderBy.Text == "Release Date") { OrderByFunc = game => game.ReleaseDate; }
            else if (cboxOrderBy.Text == "Number of DLC´s") { OrderByFunc = game => game.DLCCount; }
            else if (cboxOrderBy.Text == "Metacritic") { OrderByFunc = game => game.Metacritic; }
            else if (cboxOrderBy.Text == "Recomendations") { OrderByFunc = game => game.RecommendationCount; }
            else if (cboxOrderBy.Text == "People who have") { OrderByFunc = game => game.Owners; }
            else if (cboxOrderBy.Text == "People who play") { OrderByFunc = game => game.NumberOfPlayers; }
            else if (cboxOrderBy.Text == "Achievements") { OrderByFunc = game => game.AchievementCount; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int comboType = 0;

            if (comboBox1.Text == "Name") { comboType = 0; }
            else if (comboBox1.Text == "ID") { comboType = 1; }

            switch (comboType)
            {
                case 0:
                    dataTable.DefaultView.RowFilter =
                       string.Format("" + comboBox1.Text + " LIKE '*" +
                       textBox1.Text + "*' ");
                    break;
                case 1:
                    dataTable.DefaultView.RowFilter =
                        string.Format("Convert([" + comboBox1.Text + "]," +
                        " System.String) LIKE '" + textBox1.Text + "'");
                    break;
                default:
                    MessageBox.Show("Error! Please confirm it's the correct file" +
    " and it's of type .csv", "Error");
                    break;

            }
        }
    }
}
