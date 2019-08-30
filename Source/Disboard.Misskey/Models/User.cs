using System;
using System.Collections.Generic;
using System.Drawing;

using Disboard.Converters;
using Disboard.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Disboard.Misskey.Models
{
    public class User : ApiResponse
    {
        [JsonProperty("alwaysMarkNsfw")]
        public bool? IsAlwaysMarkNsfw { get; set; }

        [JsonProperty("autoAcceptFollowed")]
        public bool? IsAutoAcceptFollowed { get; set; }

        [JsonProperty("autoWatch")]
        public bool? IsAutoWatch { get; set; }

        [JsonProperty("avatarColor")]
        [JsonConverter(typeof(RgbToColorConverter))]
        public Color? AvatarColor { get; set; }

        [JsonProperty("avatarId")]
        public string AvatarId { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("bannerColor")]
        [JsonConverter(typeof(RgbToColorConverter))]
        public Color? BannerColor { get; set; }

        [JsonProperty("bannerId")]
        public string BannerId { get; set; }

        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        [JsonProperty("birthday")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? Birthday { get; set; }

        [JsonProperty("carefulBot")]
        public bool? IsCarefulBot { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discord")]
        public Discord Discord { get; set; }

        [JsonProperty("emojis")]
        public IEnumerable<Emoji> Emojis { get; set; }

        [JsonProperty("followingCount")]
        public long? FollowingCount { get; set; }

        [JsonProperty("followersCount")]
        public long? FollowersCount { get; set; }

        [JsonProperty("github")]
        public Github Github { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isAdmin")]
        public bool? IsAdmin { get; set; }

        [JsonProperty("isBlocked")]
        public bool? IsBlocked { get; set; }

        [JsonProperty("isBlocking")]
        public bool? IsBlocking { get; set; }

        [JsonProperty("isBot")]
        public bool? IsBot { get; set; }

        [JsonProperty("isCat")]
        public bool? IsCat { get; set; }

        [JsonProperty("isFollowed")]
        public bool? IsFollowed { get; set; }

        [JsonProperty("isFollowing")]
        public bool? IsFollowing { get; set; }

        [JsonProperty("isLocked")]
        public bool? IsLocked { get; set; }

        [JsonProperty("isModerator")]
        public bool? IsModerator { get; set; }

        [JsonProperty("isMuted")]
        public bool? IsMuted { get; set; }

        [JsonProperty("hasPendingFollowRequestFromYou")]
        public bool? HasPendingFollowRequestFromYou { get; set; }

        [JsonProperty("hasPendingFollowRequestToYou")]
        public bool? HasPendingFollowRequestToYou { get; set; }

        [JsonProperty("hasUnreadMentions")]
        public bool? HasUnreadMentions { get; set; }

        [JsonProperty("hasUnreadMessagingMessage")]
        public bool? HasUnreadMessagingMessage { get; set; }

        [JsonProperty("hasUnreadNotification")]
        public bool? HasUnreadNotification { get; set; }

        [JsonProperty("hasUnreadSpecifiedNotes")]
        public bool? HasUnreadSpecifiedNotes { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notesCount")]
        public long? NotesCount { get; set; }

        [JsonProperty("pendingReceivedFollowRequestsCount")]
        public long? PendingReceivedFollowRequestsCount { get; set; }

        [JsonProperty("pinnedNotes")]
        public IEnumerable<Note> PinnedNotes { get; set; }

        [JsonProperty("pinnedNoteIds")]
        public IEnumerable<string> PinnedNoteIds { get; set; }

        [JsonProperty("twitter")]
        public Twitter Twitter { get; set; }

        [JsonProperty("twoFactorEnabled")]
        public bool? IsTwoFactorEnabled { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        // INCLUDE_SECRETS OPTS IS CURRENTLY NOT SUPPORTED IN DISBOARD
    }
}