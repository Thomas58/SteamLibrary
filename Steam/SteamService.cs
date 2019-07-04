using Newtonsoft.Json;
using Steam.SteamObjects;
using Steam.SteamReponses;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Steam
{
    public class SteamService
    {
        private static string Key = "secret-key";
        private static ulong SteamUserId = 0;

        private static string OwnedGamesURL = @"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/";
        private static string PlayerSummariesURL = @"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/";
        private static string RecentlyPlayedGamesURL = @"http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/";

        public static OwnedGames GetOwnedGames(ulong steamuserid)
        {
            var url = OwnedGamesURL + "?key=" + Key + "&steamid=" + steamuserid + "&include_appinfo=1&format=json";
            var response = Request<OwnedGamesResponse>(url);
            return new OwnedGames(response.response);
        }

        public static PlayerSummaries GetPlayerSummary(ulong steamuserid)
        {
            var url = PlayerSummariesURL + "?key=" + Key + "&steamids=" + steamuserid + "&format=json";
            var response = Request<PlayerSummariesResponse>(url);
            return new PlayerSummaries(response.response);
        }

        public static RecentlyPlayedGames GetRecentlyPlayedGames(ulong steamuserid)
        {
            var url = OwnedGamesURL + "?key=" + Key + "&steamid=" + steamuserid + "&format=json";
            var response = Request<RecentlyPlayedGamesResponse>(url);
            return new RecentlyPlayedGames(response.response);
        }

        public async static Task<OwnedGames> GetOwnedGamesAsync(ulong steamuserid)
        {
            return await Task.Run(() => GetOwnedGames(steamuserid));
        }
        public async static Task<RecentlyPlayedGames> GetRecentlyPlayedGamesAsync(ulong steamuserid)
        {
            return await Task.Run(() => GetRecentlyPlayedGames(steamuserid));
        }
        public async static Task<PlayerSummaries> GetPlayerSummaryAsync(ulong steamuserid)
        {
            return await Task.Run(() => GetPlayerSummary(steamuserid));
        }

        private static Response<T> Request<T>(string url)
        {
            using (WebClient client = new WebClient())
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Response<T>>(json);
                }
            }
        }
    }
}
