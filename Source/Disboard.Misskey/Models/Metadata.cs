using System;
using System.Collections.Generic;

using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class Metadata : ApiResponse
    {
        [JsonProperty("announcements")]
        public IEnumerable<Announcement> Announcements { get; set; }

        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        [JsonProperty("cacheRemoteFiles")]
        public bool IsCacheRemoteFiles { get; set; }

        [JsonProperty("cpu")]
        public Cpu Cpu { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("disableGlobalTimeline")]
        public bool IsDisableGlobalTimeline { get; set; }

        [JsonProperty("disableLocalTimeline")]
        public bool IsDisableLocalTimeline { get; set; }

        [JsonProperty("disableRegistration")]
        public bool IsDisableRegistration { get; set; }

        [JsonProperty("driveCapacityPerLocalUserMb")]
        public long DriveCapacityPerLocalUserMb { get; set; }

        [JsonProperty("driveCapacityPerRemoteUserMb")]
        public long DriveCapacityPerRemoteUserMb { get; set; }

        [JsonProperty("emojis")]
        public IEnumerable<Emoji> Emojis { get; set; }

        [JsonProperty("enableDiscordIntegration")]
        public bool IsEnableDiscordIntegration { get; set; }

        [JsonProperty("enableEmail")]
        public bool IsEnableEmail { get; set; }

        [JsonProperty("enableEmojiReaction")]
        public bool IsEnableEmojiReaction { get; set; }

        [JsonProperty("enableGithubIntegration")]
        public bool IsEnableGithubIntegration { get; set; }

        [JsonProperty("enableRecaptcha")]
        public bool IsEnableRecaptcha { get; set; }

        [JsonProperty("enableServiceWorker")]
        public bool IsEnableServiceWorker { get; set; }

        [JsonProperty("enableTwitterIntegration")]
        public bool IsEnableTwitterIntegration { get; set; }

        [JsonProperty("errorImageUrl")]
        public string ErrorImageUrl { get; set; }

        [JsonProperty("feedbackUrl")]
        public string FeedbackUrl { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("langs")]
        public IEnumerable<string> Langs { get; set; }

        [JsonProperty("machine")]
        public string Machine { get; set; }

        [JsonProperty("maintainerEmail")]
        public string MaintainerEmail { get; set; }

        [JsonProperty("maintainerName")]
        public string MaintainerName { get; set; }

        [JsonProperty("mascotImageUrl")]
        public string MascotImageUrl { get; set; }

        [JsonProperty("maxNoteTextLength")]
        public long MaxNoteTextLength { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("psql")]
        public string Psql { get; set; }

        [JsonProperty("recaptchaSiteKey")]
        public string RecaptchaSiteKey { get; set; }

        [JsonProperty("redis")]
        public string Redis { get; set; }

        [JsonProperty("repositoryUrl")]
        public string RepositoryUrl { get; set; }

        [JsonProperty("secure")]
        public bool IsSecure { get; set; }

        [JsonProperty("swPublickey")]
        public string SwPublickey { get; set; }

        [JsonProperty("ToSUrl")]
        public string ToSUrl { get; set; }

        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        // if details set to true, includes below properties

        [JsonProperty("features")]
        public Features Features { get; set; }

        // if user is administrator or moderator, includes below properties

        // NOT SUPPORTED CURRENTLY BECAUSE RESPONSE TYPE IS UNKNOWN
    }
}