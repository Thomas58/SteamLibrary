using Steam.SteamReponses;

namespace Steam.SteamObjects
{
    public class PlayerSummaries
    {
        public Player[] Players;

        public PlayerSummaries() { }
        public PlayerSummaries(PlayerSummariesResponse response)
        {
            Players = new Player[response.players.Length];
            for (int i = 0; i < response.players.Length; i++)
                Players[i] = new Player(response.players[i]);
        }
    }
}
