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

namespace Steam_DB {
    public partial class Form1 : Form {
        private ICollection<Game> database;
        private DataTable dataTable;
        CSVParser csvParser;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            database = new HashSet<Game>();
            csvParser = new CSVParser();
        }

        private void btnReadFile_Click(object sender, EventArgs e) {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK) {
                string filePath = file.FileName;

                csvParser.ReadCSVFile(database, filePath);

                var source = new BindingSource();
                //source.DataSource = database;
                dataTable = new DataTable();

                using (var reader = ObjectReader.Create(database, "ID", "Name",
                    "ReleaseDate", "RequiredAge", "DLCCount", "Metacritic",
                    "MovieCount", "RecommendationCount", "ScreenshotCount",
                    "Owners", "NumberOfPlayers", "AchievementCount",
                    "ControllerSupport", "PlatformWindows", "PlatformLinux",
                    "PlatformMac", "CategorySinglePlayer",
                    "CategoryMultiplayer", "CategoryCoop",
                    "CategoryIncludeLevelEditor", "CategoryVRSupport",
                    "SupportURL", "AboutText", "HeaderImage", "Website")) {
                    dataTable.Load(reader);
                }
                source.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = source;

            } else {
                MessageBox.Show("Error! Please confirm it's the correct file" +
                    " and it's of type .csv", "Error");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {
            //http://www.csharp-examples.net/dataview-rowfilter/

            // Para strings
            //dataTable.DefaultView.RowFilter =
            //    string.Format("ID LIKE '*{0}*'", textBox1.Text);

            //Para numeros
            dataTable.DefaultView.RowFilter =
                string.Format("Convert([ID], System.String) LIKE '%{0}%'", textBox1.Text);
        }
    }
}
