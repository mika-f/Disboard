using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Discord : ApiResponse
    {
        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}