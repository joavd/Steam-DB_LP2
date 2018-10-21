using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_DB
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RequiredAge { get; set; }
        public int DLCCount { get; set; }
        public int Metacritic { get; set; }
        public int MovieCount { get; set; }
        public int RecommendationCount { get; set; }
        public int ScreenshotCount { get; set; }
        public int Owners { get; set; }
        public int NumberOfPlayers { get; set; }
        public int AchievementCount { get; set; }
        public bool ControllerSupport { get; set; }
        public bool PlatformWindows { get; set; }
        public bool PlatformLinux { get; set; }
        public bool PlatformMac { get; set; }
        public bool CategorySinglePlayer { get; set; }
        public bool CategoryMultiplayer { get; set; }
        public bool CategoryCoop { get; set; }
        public bool CategoryIncludeLevelEditor { get; set; }
        public bool CategoryVRSupport { get; set; }
        public Uri SupportURL { get; set; }
        public string AboutText { get; set; }
        public Uri HeaderImage { get; set; }
        public Uri Website { get; set; }

        public Game(int id, string name, DateTime releaseDate, int requiredAge,
            int dlcCount, int metacritic, int movieCount,
            int recommendationCount, int screenshotCount, int owners,
            int numberOfPlayers, int achievementCount, bool controller,
            bool windows, bool linux, bool mac, bool singlePlayer,
            bool multiplayer, bool coop, bool levelEditor, bool vrSupport,
            Uri supportURL, string about, Uri image, Uri website)
        {
            ID = id;
            Name = name;
            ReleaseDate = releaseDate;
            DLCCount = dlcCount;
            RequiredAge = requiredAge;
            Metacritic = metacritic;
            MovieCount = movieCount;
            RecommendationCount = recommendationCount;
            ScreenshotCount = screenshotCount;
            Owners = owners;
            NumberOfPlayers = numberOfPlayers;
            AchievementCount = achievementCount;
            ControllerSupport = controller;
            PlatformWindows = windows;
            PlatformLinux = linux;
            PlatformMac = mac;
            CategorySinglePlayer = singlePlayer;
            CategoryMultiplayer = multiplayer;
            CategoryCoop = coop;
            CategoryIncludeLevelEditor = levelEditor;
            CategoryVRSupport = vrSupport;
            SupportURL = supportURL;
            AboutText = about;
            HeaderImage = image;
            Website = website;
        }

        public Game()
        {
        }
    }
}
