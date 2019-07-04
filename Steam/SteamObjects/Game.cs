using Steam.SteamReponses;
using System;

namespace Steam.SteamObjects
{
    public class Game
    {
        public int AppId { get; set; }
        public string Name { get; set; }
        public int PlaytimeForever { get; set; }
        public bool HasCommunityVisibleStats { get; set; }
        public string IconUrl;
        public string LogoUrl;
        public Uri LogoUri => new Uri(@"http://media.steampowered.com/steamcommunity/public/images/apps/" + AppId + "/" + LogoUrl + ".jpg");
        public Uri IconUri => new Uri(@"http://media.steampowered.com/steamcommunity/public/images/apps/" + AppId + "/" + IconUrl + ".jpg");

        public Game() { }
        public Game(GameResponse response)
        {
            AppId = response.appid;
            Name = response.name;
            PlaytimeForever = response.playtime_forever;
            HasCommunityVisibleStats = response.has_community_visible_stats;
            IconUrl = response.img_icon_url;
            LogoUrl = response.img_logo_url;
        }

        public string ToString()
        {
            return
                "" + AppId + ", " + Name + ", " + PlaytimeForever 
                + ", " + HasCommunityVisibleStats + ", " + IconUri + ", " + LogoUri;
        }
    }
}