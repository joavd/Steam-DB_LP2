using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Steam_DB {
    public class CSVParser {
        private StreamReader file;
        private string line;

        public void ReadCSVFile(IDictionary<int, Game> database, 
            string filePath) {
            file = File.OpenText(filePath);

            while ((line = file.ReadLine()) != null) {
                string[] fields = new string[24];
                fields = line.Split(',');

                //for a meter dentro da DB
            }
        }
    }
}
