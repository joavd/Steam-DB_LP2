using System;

namespace Steam_DB {
    /// <summary>
    /// define the struct who get all the data of the file.
    /// </summary>
    public struct Game {
        /// <summary>
        /// Property ID: get the int id of the file.
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// Property Name: get the string name of the file.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Property ReleaseDate: get the DateTime realeaseDate of the file.
        /// </summary>
        public DateTime ReleaseDate { get; }
        /// <summary>
        /// Property RequiredAge: get the int RequiredAge of the file.
        /// </summary>
        public int RequiredAge { get; }
        /// <summary>
        /// Property DLCCount: get the int DLCCount of the file.
        /// </summary>
        public int DLCCount { get; }
        /// <summary>
        /// Property Metacritic: get the int Metacritic of the file.
        /// </summary>
        public int Metacritic { get; }
        /// <summary>
        /// Property MovieCount: get the int MovieCount of the file.
        /// </summary>
        public int MovieCount { get; }
        /// <summary>
        /// Property RecommendationCount: get the int RecommendationCount of
        /// the file.
        /// </summary>
        public int RecommendationCount { get; }
        /// <summary>
        /// Property ScreenshotCount: get the int ScreenshotCount of the file.
        /// </summary>
        public int ScreenshotCount { get; }
        /// <summary>
        /// Property Owners: get the int Owners of the file.
        /// </summary>
        public int Owners { get; }
        /// <summary>
        /// Property NumberOfPlayers: get the int NumberOfPlayers of the file.
        /// </summary>
        public int NumberOfPlayers { get; }
        /// <summary>
        /// Property AchievementCount: get the int AchievementCount of the file.
        /// </summary>
        public int AchievementCount { get; }
        /// <summary>
        /// Property ControllerSupport: get the bool ControllerSupport of the file.
        /// </summary>
        public bool ControllerSupport { get; }
        /// <summary>
        /// Property PlatformWindows: get the bool PlatformWindows of the file.
        /// </summary>
        public bool PlatformWindows { get; }
        /// <summary>
        /// Property PlatformLinux: get the bool PlatformLinux of the file.
        /// </summary>
        public bool PlatformLinux { get; }
        /// <summary>
        /// Property PlatformMac: get the bool PlatformMac of the file.
        /// </summary>
        public bool PlatformMac { get; }
        /// <summary>
        /// Property CategorySinglePlayer: get the bool CategorySinglePlayer
        /// of the file.
        /// </summary>
        public bool CategorySinglePlayer { get; }
        /// <summary>
        /// Property CategorySinglePlayer: get the bool CategorySinglePlayer 
        /// of the file.
        /// </summary>
        public bool CategoryMultiplayer { get; }
        /// <summary>
        /// Property CategoryCoop: get the bool CategoryCoop of the file.
        /// </summary>
        public bool CategoryCoop { get; }
        /// <summary>
        /// Property CategoryIncludeLevelEditor: get the bool 
        /// CategoryIncludeLevelEditor of the file.
        /// </summary>
        public bool CategoryIncludeLevelEditor { get; }
        /// <summary>
        /// Property CategoryVRSupport: get the bool CategoryVRSupport of the file.
        /// </summary>
        public bool CategoryVRSupport { get; }
        /// <summary>
        /// Property SupportURL: get the Uri SupportURL of the file.
        /// </summary>
        public Uri SupportURL { get; }
        /// <summary>
        /// Property AboutText: get the string AboutText of the file.
        /// </summary>
        public string AboutText { get; }
        /// <summary>
        /// Property HeaderImage: get the Uri HeaderImage of the file.
        /// </summary>
        public Uri HeaderImage { get; }
        /// <summary>
        /// Property Website: get the Uri Website of the file.
        /// </summary>
        public Uri Website { get; }

        /// <summary>
        /// Constructor of the class Game. Initialize class variables.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="releaseDate"></param>
        /// <param name="requiredAge"></param>
        /// <param name="dlcCount"></param>
        /// <param name="metacritic"></param>
        /// <param name="movieCount"></param>
        /// <param name="recommendationCount"></param>
        /// <param name="screenshotCount"></param>
        /// <param name="owners"></param>
        /// <param name="numberOfPlayers"></param>
        /// <param name="achievementCount"></param>
        /// <param name="controller"></param>
        /// <param name="windows"></param>
        /// <param name="linux"></param>
        /// <param name="mac"></param>
        /// <param name="singlePlayer"></param>
        /// <param name="multiplayer"></param>
        /// <param name="coop"></param>
        /// <param name="levelEditor"></param>
        /// <param name="vrSupport"></param>
        /// <param name="supportURL"></param>
        /// <param name="about"></param>
        /// <param name="image"></param>
        /// <param name="website"></param>
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
