using Steam.SteamReponses;

namespace Steam.SteamObjects
{
    public class OwnedGames
    {
        public int GameCount { get; set; }
        public Game[] Games { get; set; }

        public OwnedGames() { }
        public OwnedGames(OwnedGamesResponse response)
        {
            GameCount = response.game_count;
            Games = new Game[response.games.Length];
            for (int i = 0; i < response.games.Length; i++)
                Games[i] = new Game(response.games[i]);
        }
    }
}
