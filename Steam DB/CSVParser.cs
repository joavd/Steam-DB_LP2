using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Steam_DB {
    public class CSVParser {
        private StreamReader file;
        private string line;

        public void ReadCSVFile(ICollection<Game> database, string filePath) {
            file = File.OpenText(filePath);


            while ((line = file.ReadLine()) != null) {
                string[] fields = new string[24];
                fields = line.Split(',');
                if (fields[0] == "ID") {

                } else {
                    int numSup = 21, numImg = 23, numWeb = 24;
                    Uri supportURL, image, website;
                    int[] intSupport = new int[8];

                    for (int i = 0; i < 9; i++) {
                        Int32.TryParse(fields[i+3], out int newInt);
                        fields[i + 3] = newInt.ToString();
                    }

                    DateTime.TryParse(fields[2], out DateTime time);
                    supportURL = (Uri.TryCreate(fields[numSup], 0, out Uri sup)) ?
                        sup : null;
                    image = (Uri.TryCreate(fields[numImg], 0, out Uri img)) ?
                        img : null;
                    website = (Uri.TryCreate(fields[numWeb], 0, out Uri web)) ?
                        web : null;

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
