using Steam.SteamReponses;

namespace Steam.SteamObjects
{
    public class Player
    {
        public ulong SteamId { get; set; }
        public string PersonaName { get; set; }
        public string ProfileUrl { get; set; }
        public string Avatar { get; set; }
        public string AvatarMedium { get; set; }
        public string AvatarFull { get; set; }
        public int PersonaState { get; set; }
        public int CommunityVisibilityState { get; set; }
        public int ProfileState { get; set; }
        public int LastLogoff { get; set; }
        public bool CommentPermission { get; set; }

        public string RealName { get; set; }
        public string PrimaryClanId { get; set; }
        public int TimeCreated { get; set; }
        public int GameId { get; set; }
        public string GameServerIp { get; set; }
        public string GameExtraInfo { get; set; }
        public int CityId { get; set; }
        public string LocCountryCode { get; set; }
        public string LocStateCode { get; set; }
        public string LocCityId { get; set; }

        public Player() { }
        public Player(PlayerResponse response)
        {
            SteamId = response.steamid;
            PersonaName = response.personaname;
            ProfileUrl = response.profileurl;
            Avatar = response.avatar;
            AvatarMedium = response.avatarmedium;
            AvatarFull = response.avatarfull;
            PersonaState = response.personastate;
            CommunityVisibilityState = response.communityvisibilitystate;
            ProfileState = response.profilestate;
            LastLogoff = response.lastlogoff;
            CommentPermission = response.commentpermission;

            RealName = response.realname;
            PrimaryClanId = response.primaryclanid;
            TimeCreated = response.timecreated;
            GameId = response.gameid;
            GameServerIp = response.gameserverip;
            GameExtraInfo = response.gameextrainfo;
            CityId = response.cityid;
            LocCountryCode = response.loccountrycode;
            LocStateCode = response.locstatecode;
            LocCityId = response.loccityid;
        }

        override
        public string ToString()
        {
            return
                "" + SteamId + ", " + PersonaName + ", " + ProfileUrl
                + ", " + Avatar + ", " + AvatarMedium + ", " + AvatarFull
                + ", " + PersonaState + ", " + CommunityVisibilityState + ", " + ProfileState
                + ", " + LastLogoff + ", " + CommentPermission + ", " + RealName
                + ", " + PrimaryClanId + ", " + TimeCreated + ", " + GameId
                + ", " + GameServerIp + ", " + GameExtraInfo + ", " + CityId
                + ", " + LocCountryCode + ", " + LocStateCode + ", " + LocCityId;
        }
    }
}
