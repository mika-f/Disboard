using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Stats : ApiResponse
    {
        [JsonProperty("driveUsageLocal")]
        public long DriveUsageLocal { get; set; }

        [JsonProperty("driveUsageRemote")]
        public long DriveUsageRemote { get; set; }

        [JsonProperty("instances")]
        public long Instances { get; set; }

        [JsonProperty("notesCount")]
        public long NotesCount { get; set; }

        [JsonProperty("originalNotesCount")]
        public long OriginalNotesCount { get; set; }

        [JsonProperty("originalUsersCount")]
        public long OriginalUsersCount { get; set; }

        [JsonProperty("usersCount")]
        public long UsersCount { get; set; }
    }
}