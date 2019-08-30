using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Twitter : ApiResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("screenName")]
        public string ScreenName { get; set; }
    }
}