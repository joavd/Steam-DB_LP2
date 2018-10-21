using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Steam_DB
{
    public class CSVParser
    {
        private StreamReader file;
        private string line;

        public void ReadCSVFile(HashSet<Game> database,
            string filePath)
        {
            file = File.OpenText(filePath);

            while ((line = file.ReadLine()) != null)
            {
                string[] fields = new string[24];
                fields = line.Split(',');
                if (fields[0] == "ID")
                {

                }
                else
                {
                    Uri uri1, uri2,uri3;
                    uri1 = new System.Uri(fields[21]);
                    uri2 = new System.Uri(fields[23]);
                    uri3 = new System.Uri(fields[24]);

                    database.Add
                    (
                      new Game()
                      {
                          ID = Convert.ToInt32(fields[0]),
                          Name = fields[1],
                          ReleaseDate = Convert.ToDateTime(fields[2]),
                          RequiredAge = Convert.ToInt32(fields[3]),
                          DLCCount = Convert.ToInt32(fields[4]),
                          Metacritic = Convert.ToInt32(fields[5]),
                          MovieCount = Convert.ToInt32(fields[6]),
                          RecommendationCount = Convert.ToInt32(fields[7]),
                          ScreenshotCount = Convert.ToInt32(fields[8]),
                          Owners = Convert.ToInt32(fields[9]),
                          NumberOfPlayers = Convert.ToInt32(fields[10]),
                          AchievementCount = Convert.ToInt32(fields[11]),
                          ControllerSupport = Convert.ToBoolean(fields[12]),
                          PlatformWindows = Convert.ToBoolean(fields[13]),
                          PlatformLinux = Convert.ToBoolean(fields[14]),
                          PlatformMac = Convert.ToBoolean(fields[15]),
                          CategorySinglePlayer = Convert.ToBoolean(fields[16]),
                          CategoryMultiplayer = Convert.ToBoolean(fields[17]),
                          CategoryCoop = Convert.ToBoolean(fields[18]),
                          CategoryIncludeLevelEditor = Convert.ToBoolean(fields[19]),
                          CategoryVRSupport = Convert.ToBoolean(fields[20]),
                          SupportURL = uri1,
                          AboutText = fields[22],
                          HeaderImage = uri2,
                          Website = uri3
                      }
                    );
                }
            }
        }
    }
}
