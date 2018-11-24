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
            OpenFileDialog file = new OpenFileDialog();

            if ((file.ShowDialog() == DialogResult.OK) &&
                (Path.GetExtension(file.FileName) == ".csv")) {

                string filePath = file.FileName;

                this.Hide();
                var mainForm = new MainForm(filePath);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();

            } else {
                MessageBox.Show("Please confirm it's the correct file" +
                    " and it's of type .csv", "Error!");
            }
        }
    }
}
