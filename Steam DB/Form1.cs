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
    public partial class Form1 : Form
    {
        private ICollection<Game> database;
        private DataTable dataTable;
        CSVParser csvParser;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database = new HashSet<Game>();
            csvParser = new CSVParser();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
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
                    "SupportURL", "AboutText", "HeaderImage", "Website"))
                {
                    dataTable.Load(reader);
                }
                source.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = source;

            }
            else
            {
                MessageBox.Show("Error! Please confirm it's the correct file" +
                    " and it's of type .csv", "Error");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataTable.DefaultView.RowFilter =
            //    string.Format("Convert([ID], System.String) LIKE '*{0}*'" +
            //    " AND Name LIKE '%{1}%'" +
            //    " AND Convert([ControllerSupport], System.String) LIKE '*{2}*'" +
            //    " AND Convert([PlatformWindows], System.String) LIKE '*{3}*'" +
            //    " AND Convert([PlatformLinux], System.String) LIKE '*{4}*'" +
            //    " AND Convert([PlatformMac], System.String) LIKE '*{5}*'" +
            //    " AND Convert([CategorySinglePlayer], System.String) LIKE '*{6}*'" +
            //    " AND Convert([CategoryMultiplayer], System.String) LIKE '*{7}*'" +
            //    " AND Convert([CategoryCoop], System.String) LIKE '*{8}*'" +
            //    " AND Convert([CategoryIncludeLevelEditor], System.String) LIKE '*{9}*'" +
            //    " AND Convert([CategoryVRSupport], System.String) LIKE '*{10}*'" +
            //    "", txtID.Text, txtName.Text, checkSuppContrl.Checked,
            //    checkWindows.Checked, checkLinux.Checked, checkMac.Checked,
            //    checkSinglePlayer.Checked, checkMulti.Checked,
            //    checkMultiCoop.Checked, checkEditNiveis.Checked, checkVR.Checked);

            IEnumerable<Game> db2 = (from game in database
                                    where game.ID == Convert.ToInt32(txtID.Text)
                                    select game).ToList();
            dataGridView1.DataSource = db2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //http://www.csharp-examples.net/dataview-rowfilter/

            // Para strings
            //dataTable.DefaultView.RowFilter =
            //    string.Format("Name LIKE '*{0}*'", textBox1.Text);

            int comboType = 0;

            if (comboBox1.Text == "Name") { comboType = 0; }
            else if (comboBox1.Text == "ID") { comboType = 1; }

            switch (comboType)
            {
                case 0:
                    dataTable.DefaultView.RowFilter =
                       string.Format("" + comboBox1.Text + " LIKE '*" +
                       textBox1.Text+"*' ");
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
            ////Para numeros
            //dataTable.DefaultView.RowFilter =
            //    string.Format("Convert([ID], System.String) LIKE '" + textBox1.Text + "'");



            
        }
    }
}
