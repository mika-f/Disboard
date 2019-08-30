using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Features : ApiResponse
    {
        [JsonProperty("discord")]
        public bool Discord { get; set; }

        [JsonProperty("elasticsearch")]
        public bool Elasticsearch { get; set; }

        [JsonProperty("localTimeLine")]
        public bool LocalTimeline { get; set; }

        [JsonProperty("github")]
        public bool Github { get; set; }

        [JsonProperty("globalTimeLine")]
        public bool GlobalTimeline { get; set; }

        [JsonProperty("objectStorage")]
        public bool ObjectStorage { get; set; }

        [JsonProperty("recaptcha")]
        public bool Recaptcha { get; set; }

        [JsonProperty("registration")]
        public bool Registration { get; set; }

        [JsonProperty("serviceWorker")]
        public bool ServiceWorker { get; set; }

        [JsonProperty("twitter")]
        public bool Twitter { get; set; }
    }
}