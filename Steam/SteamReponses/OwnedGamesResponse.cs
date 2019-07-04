namespace Steam.SteamReponses
{
    public class OwnedGamesResponse
    {
        public int game_count;
        public GameResponse[] games;
    }

    public class GameResponse
    {
        public int appid;
        public string name;
        public int playtime_forever;
        public string img_icon_url;
        public string img_logo_url;
        public bool has_community_visible_stats;
    }
}
