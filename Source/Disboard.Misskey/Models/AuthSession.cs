using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class AuthSession : ApiResponse
    {
        [JsonProperty("app")]
        public App App { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}