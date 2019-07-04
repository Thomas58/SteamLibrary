namespace Steam.SteamReponses
{
    public class PlayerSummariesResponse
    {
        public PlayerResponse[] players;
    }

    public class PlayerResponse
    {
        public ulong steamid;
        public string personaname;
        public string profileurl;
        public string avatar;
        public string avatarmedium;
        public string avatarfull;
        public int personastate;
        public int communityvisibilitystate;
        public int profilestate;
        public int lastlogoff;
        public bool commentpermission;

        public string realname;
        public string primaryclanid;
        public int timecreated;
        public int gameid;
        public string gameserverip;
        public string gameextrainfo;
        public int cityid;
        public string loccountrycode;
        public string locstatecode;
        public string loccityid;
    }
}
