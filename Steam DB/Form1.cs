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
    public partial class Form1 : Form {
        private IDictionary<int, Game> database;
        CSVParser csvParser;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            database = new Dictionary<int, Game>();
            csvParser = new CSVParser();
        }

        private void btnReadFile_Click(object sender, EventArgs e) {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string filePath = file.FileName;
                
                csvParser.ReadCSVFile(database, filePath);
            } else {
                MessageBox.Show("Error! Please confirm it's the correct file" +
                    " and it's of type .csv");
            }
        }
    }
}
