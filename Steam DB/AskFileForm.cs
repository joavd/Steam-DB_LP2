using System;
using System.Windows.Forms;
using System.IO;

namespace Steam_DB {
    /// <summary>
    /// Class that asks the FilePath to read from
    /// </summary>
    public partial class AskFileForm : Form {
        /// <summary>
        /// Initializes a new instance of the <see cref="AskFileForm"/> class.
        /// </summary>
        public AskFileForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Shows a Dialog to get the filepath to read from
        /// </summary>
        /// <param name="sender">Reference to the object that raised the 
        /// event</param>
        /// <param name="e">Passes an object specific to the event that is
        /// being handled</param>
        private void ReadFileButtonClick(object sender, EventArgs e) {
            // Opens a dialog to navigate into the file
            OpenFileDialog file = new OpenFileDialog();

            // If it validates and if it's of type .csv
            if ((file.ShowDialog() == DialogResult.OK) &&
                (Path.GetExtension(file.FileName) == ".csv")) {
                // Sets the filepath
                string filePath = file.FileName;

                // Opens the Mainform, passes it the file path and closes this 
                // one
                this.Hide();
                var mainForm = new MainForm(filePath);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
                
                // If it doesn't validate or it's not a csv file shows an 
                // error message
            } else {
                MessageBox.Show("Please confirm it's the correct file" +
                    " and it's of type .csv", "Error!");
            }
        }
    }
}
