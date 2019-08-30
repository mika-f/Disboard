using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Param : ApiResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        // NOTE: should I convert this value to .NET types?
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}