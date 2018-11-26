using System;

namespace Steam_DB {
    /// <summary>
    /// Define the struct who saves all the data about a game.
    /// </summary>
    public struct Game {
        /// <summary>
        /// Property ID: get the int id of the game.
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// Property Name: get the string name of the game.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Property ReleaseDate: get the DateTime realeaseDate of the game.
        /// </summary>
        public DateTime ReleaseDate { get; }
        /// <summary>
        /// Property RequiredAge: get the int RequiredAge of the game.
        /// </summary>
        public int RequiredAge { get; }
        /// <summary>
        /// Property DLCCount: get the int DLCCount of the game.
        /// </summary>
        public int DLCCount { get; }
        /// <summary>
        /// Property Metacritic: get the int Metacritic of the game.
        /// </summary>
        public int Metacritic { get; }
        /// <summary>
        /// Property MovieCount: get the int MovieCount of the game.
        /// </summary>
        public int MovieCount { get; }
        /// <summary>
        /// Property RecommendationCount: get the int RecommendationCount of
        /// the game.
        /// </summary>
        public int RecommendationCount { get; }
        /// <summary>
        /// Property ScreenshotCount: get the int ScreenshotCount of the game.
        /// </summary>
        public int ScreenshotCount { get; }
        /// <summary>
        /// Property Owners: get the int Owners of the game.
        /// </summary>
        public int Owners { get; }
        /// <summary>
        /// Property NumberOfPlayers: get the int NumberOfPlayers of the game.
        /// </summary>
        public int NumberOfPlayers { get; }
        /// <summary>
        /// Property AchievementCount: get the int AchievementCount of the 
        /// game.
        /// </summary>
        public int AchievementCount { get; }
        /// <summary>
        /// Property ControllerSupport: get the bool ControllerSupport of the 
        /// game.
        /// </summary>
        public bool ControllerSupport { get; }
        /// <summary>
        /// Property PlatformWindows: get the bool PlatformWindows of the game.
        /// </summary>
        public bool PlatformWindows { get; }
        /// <summary>
        /// Property PlatformLinux: get the bool PlatformLinux of the game.
        /// </summary>
        public bool PlatformLinux { get; }
        /// <summary>
        /// Property PlatformMac: get the bool PlatformMac of the game.
        /// </summary>
        public bool PlatformMac { get; }
        /// <summary>
        /// Property CategorySinglePlayer: get the bool CategorySinglePlayer
        /// of the game.
        /// </summary>
        public bool CategorySinglePlayer { get; }
        /// <summary>
        /// Property CategorySinglePlayer: get the bool CategorySinglePlayer 
        /// of the game.
        /// </summary>
        public bool CategoryMultiplayer { get; }
        /// <summary>
        /// Property CategoryCoop: get the bool CategoryCoop of the game.
        /// </summary>
        public bool CategoryCoop { get; }
        /// <summary>
        /// Property CategoryIncludeLevelEditor: get the bool 
        /// CategoryIncludeLevelEditor of the game.
        /// </summary>
        public bool CategoryIncludeLevelEditor { get; }
        /// <summary>
        /// Property CategoryVRSupport: get the bool CategoryVRSupport of the 
        /// game.
        /// </summary>
        public bool CategoryVRSupport { get; }
        /// <summary>
        /// Property SupportURL: get the Uri SupportURL of the game.
        /// </summary>
        public Uri SupportURL { get; }
        /// <summary>
        /// Property AboutText: get the string AboutText of the game.
        /// </summary>
        public string AboutText { get; }
        /// <summary>
        /// Property HeaderImage: get the Uri HeaderImage of the game.
        /// </summary>
        public Uri HeaderImage { get; }
        /// <summary>
        /// Property Website: get the Uri Website of the game.
        /// </summary>
        public Uri Website { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="id">ID of the game</param>
        /// <param name="name">Name of the game</param>
        /// <param name="releaseDate">Rel Date of the game</param>
        /// <param name="requiredAge">Req Age of the game</param>
        /// <param name="dlcCount">#DLCs of the game</param>
        /// <param name="metacritic">Score of the game</param>
        /// <param name="movieCount">#Trailers of the game</param>
        /// <param name="recommendationCount">#Recommendations of the game</param>
        /// <param name="screenshotCount">#Screenshots of the game</param>
        /// <param name="owners">#Owners of the game</param>
        /// <param name="numberOfPlayers">#Players of the game</param>
        /// <param name="achievementCount">#Achievements of the game</param>
        /// <param name="controller">If allows a controller</param>
        /// <param name="windows">If allows to be played in Windows</param>
        /// <param name="linux">If allows to be played in Linux</param>
        /// <param name="mac">If allows to be played in Mac</param>
        /// <param name="singlePlayer">If it's a single layer game</param>
        /// <param name="multiplayer">If it's a multi layer game</param>
        /// <param name="coop">If it's a coop game</param>
        /// <param name="levelEditor">If it allows to edit levels</param>
        /// <param name="vrSupport">If it has VR support</param>
        /// <param name="supportURL">URL of the support page of the game</param>
        /// <param name="about">Description of the game</param>
        /// <param name="image">URL of the header image</param>
        /// <param name="website">URL of the game's website</param>
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
