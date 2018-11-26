using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Steam_DB {
    /// <summary>
    /// Class CSVPArser read from the file and save the values in a HasSet.
    /// </summary>
    public class CSVParser {
        /// <summary>
        /// Var StreamReader file, it serves to use the file methods.
        /// </summary>
        private StreamReader file;
        /// <summary>
        /// Var string line, it serves to get the lines of the file.
        /// </summary>
        private string line;

        /// <summary>
        /// Method ReadCSVFile read and save the file values in a HasSet.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="filePath"></param>
        public void ReadCSVFile(ICollection<Game> database, string filePath) {

            /// Open the file.
            file = File.OpenText(filePath);

            /// Perwalk the file while the lines of the file have data.
            while ((line = file.ReadLine()) != null) {
                /// Array fields, has capacity for 24 fields.
                string[] fields = new string[24];
                /// Get one by one the data of the fields in each line.
                fields = line.Split(',');
                /// We don´t want to get the header data of the file.
                if (fields[0] == "ID") {

                } else {
                    /// Variables to know the fields of the URIs in the HasSet.
                    int numSup = 21, numImg = 23, numWeb = 24;
                    /// Inicialize Uri´s variables.
                    Uri supportURL, image, website;
                    /// Array of int which have capacity for 8 fields.
                    int[] intSupport = new int[8];
                    /// Convert to int if it can.
                    for (int i = 0; i < 9; i++) {
                        Int32.TryParse(fields[i + 3], out int newInt);
                        fields[i + 3] = newInt.ToString();
                    }
                    /// Parse the strings of the file to Uri, to save in the hasset.
                    DateTime.TryParse(fields[2], out DateTime time);
                    supportURL = 
                        (Uri.TryCreate(fields[numSup], 0, out Uri sup)) ? 
                        sup : null;
                    image = (Uri.TryCreate(fields[numImg], 0, out Uri img)) ?
                        img : null;
                    website = (Uri.TryCreate(fields[numWeb], 0, out Uri web)) ?
                        web : null;

                    /// Add file data to the HasSet, with the correct values.
                    database.Add(new Game(
                      Convert.ToInt32(fields[0]),
                      fields[1],
                      time,
                      Convert.ToInt32(fields[3]),
                      Convert.ToInt32(fields[4]),
                      Convert.ToInt32(fields[5]),
                      Convert.ToInt32(fields[6]),
                      Convert.ToInt32(fields[7]),
                      Convert.ToInt32(fields[8]),
                      Convert.ToInt32(fields[9]),
                      Convert.ToInt32(fields[10]),
                      Convert.ToInt32(fields[11]),
                      Convert.ToBoolean(fields[12]),
                      Convert.ToBoolean(fields[13]),
                      Convert.ToBoolean(fields[14]),
                      Convert.ToBoolean(fields[15]),
                      Convert.ToBoolean(fields[16]),
                      Convert.ToBoolean(fields[17]),
                      Convert.ToBoolean(fields[18]),
                      Convert.ToBoolean(fields[19]),
                      Convert.ToBoolean(fields[20]),
                      supportURL,
                      fields[22],
                      image,
                      website
                      ));
                }
            }
        }
    }
}
