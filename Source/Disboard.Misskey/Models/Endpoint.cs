using System.Collections.Generic;

using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Endpoint : ApiResponse
    {
        [JsonProperty("params")]
        public IEnumerable<Param> Params { get; set; }
    }
}