using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Steam_DB {
    /// <summary>
    /// Class that searches in an ICollection(Game)
    /// </summary>
    public class SearchFilter {
        public IEnumerable<Game> Filter(ICollection<Game> database,
                string id, string name, DateTime date, string age,
                string metacritic, string recomend, bool control, bool windows,
                bool mac, bool linux, bool sp, bool mp, bool coop, bool levels,
                bool vr) {

            // Linq: searches for values in the table, filters and orders.
            IEnumerable<Game> newDB =
                (from game in database
                 where (string.IsNullOrEmpty(id) ||
                        game.ID.ToString().Contains(id))

                    && (string.IsNullOrEmpty(name) ||
                        game.Name.ToLower().Contains(name.ToLower()))

                    && (game.ReleaseDate >= date.Date)

                    && (string.IsNullOrEmpty(age) ||
                        game.RequiredAge >= Convert.ToInt32(age))

                    && (string.IsNullOrEmpty(metacritic) ||
                        game.Metacritic >= Convert.ToInt32(metacritic))

                    && (string.IsNullOrEmpty(recomend) ||
                        game.RecommendationCount >= Convert.ToInt32(recomend))

                    && ((control == false) || game.ControllerSupport == control)

                    && ((windows == false) || game.PlatformWindows == windows)

                    && ((linux == false) || game.PlatformLinux == linux)

                    && ((mac == false) || game.PlatformMac == mac)

                    && ((sp == false) || game.CategorySinglePlayer == sp)

                    && ((mp == false) || game.CategoryMultiplayer == mp)

                    && ((coop == false) || game.CategoryCoop == coop)

                    && ((levels == false) ||
                        game.CategoryIncludeLevelEditor == levels)

                    && ((vr == false) || game.CategoryVRSupport == vr)

                 select game);

            return newDB;
        }
    }
}
