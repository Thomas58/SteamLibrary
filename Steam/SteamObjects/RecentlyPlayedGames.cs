using Steam.SteamReponses;

namespace Steam.SteamObjects
{
    public class RecentlyPlayedGames
    {
        public int TotalCount { get; set; }
        public Game[] Games { get; set; }

        public RecentlyPlayedGames() { }
        public RecentlyPlayedGames(RecentlyPlayedGamesResponse response)
        {
            TotalCount = response.total_count;
            Games = new Game[response.games.Length];
            for (int i = 0; i < response.games.Length; i++)
                Games[i] = new Game(response.games[i]);
        }
    }
}
