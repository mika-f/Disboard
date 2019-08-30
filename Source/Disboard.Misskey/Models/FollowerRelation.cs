using System;

using Disboard.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Disboard.Misskey.Models
{
    public class FollowerRelation : ApiResponse
    {
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("followeeId")]
        public string FolloweeId { get; set; }

        [JsonProperty("follower")]
        public User Follower { get; set; }

        [JsonProperty("followerId")]
        public string FollowerId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}