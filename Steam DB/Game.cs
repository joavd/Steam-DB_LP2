using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_DB {
    public struct Game {
        public int ID { get; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; }
        public int RequiredAge { get; }
        public int DLCCount { get; }
        public int Metacritic { get; }
        public int MovieCount { get; }
        public int RecommendationCount { get; }
        public int ScreenshotCount { get; }
        public int Owners { get; }
        public int NumberOfPlayers { get; }
        public int AchievementCount { get; }
        public bool ControllerSupport { get; }
        public bool PlatformWindows { get; }
        public bool PlatformLinux { get; }
        public bool PlatformMac { get; }
        public bool CategorySinglePlayer { get; }
        public bool CategoryMultiplayer { get; }
        public bool CategoryCoop { get; }
        public bool CategoryIncludeLevelEditor { get; }
        public bool CategoryVRSupport { get; }
        public Uri SupportURL { get; }
        public string AboutText { get; }
        public Uri HeaderImage { get; }
        public Uri Website { get; }

        public Game(int id, string name, DateTime releaseDate, int requiredAge,
            int dlcCount, int metacritic, int movieCount,
            int recommendationCount, int screenshotCount, int owners,
            int numberOfPlayers, int achievementCount, bool controller,
            bool windows, bool linux, bool mac, bool singlePlayer,
            bool multiplayer, bool coop, bool levelEditor, bool vrSupport,
            Uri supportURL, string about, Uri image, Uri website) {
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
    }
}
