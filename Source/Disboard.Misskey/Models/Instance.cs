using System;

using Disboard.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Disboard.Misskey.Models
{
    public class Instance : ApiResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("caughtAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CaughtAt { get; set; }

        [JsonProperty("driveFiles")]
        public long DriveFiles { get; set; }

        [JsonProperty("driveUsage")]
        public long DriveUsage { get; set; }

        [JsonProperty("followersCount")]
        public long FollowersCount { get; set; }

        [JsonProperty("followingCount")]
        public long FollowingCount { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("isMarkedAsClosed")]
        public bool IsMarkedAtClosed { get; set; }

        [JsonProperty("isNotResponding")]
        public bool IsNotResponding { get; set; }

        [JsonProperty("lastCommunicatedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime LastCommunicatedAt { get; set; }

        [JsonProperty("latestRequestReceivedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? LatestRequestReceivedAt { get; set; }

        [JsonProperty("latestRequestSentAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? LatestRequestSentAt { get; set; }

        [JsonProperty("latestStatus")]
        public int? LatestStatus { get; set; }

        [JsonProperty("notesCount")]
        public long NotesCount { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("usersCount")]
        public long UsersCount { get; set; }
    }
}