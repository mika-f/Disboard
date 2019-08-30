using System.Collections.Generic;
using System.Threading.Tasks;

using Disboard.Extensions;
using Disboard.Misskey.Clients.Users;
using Disboard.Misskey.Models;

namespace Disboard.Misskey.Clients
{
    public partial class UsersClient : MisskeyApiClient
    {
        public ListsClient Lists { get; }

        protected internal UsersClient(MisskeyClient client) : base(client, "users")
        {
            Lists = new ListsClient(client);
        }

        public async Task<IEnumerable<FollowerRelation>> FollowersAsync(string userId = null, string username = null, int? limit = null, string sinceId = null, string untilId = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("userId", userId);
            parameters.AddIfValidValue("username", username);
            parameters.AddIfValidValue("sinceId", sinceId);
            parameters.AddIfValidValue("untilId", untilId);
            parameters.AddIfValidValue("limit", limit);

            return await PostAsync<IEnumerable<FollowerRelation>>("/followers", parameters).Stay();
        }

        public async Task<IEnumerable<FollowingRelation>> FollowingAsync(string userId = null, string username = null, int? limit = null, string sinceId = null, string untilId = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("userId", userId);
            parameters.AddIfValidValue("username", username);
            parameters.AddIfValidValue("sinceId", sinceId);
            parameters.AddIfValidValue("untilId", untilId);
            parameters.AddIfValidValue("limit", limit);

            return await PostAsync<IEnumerable<FollowingRelation>>("/following", parameters).Stay();
        }

        public async Task<List<FrequentlyRepliedUser>> GetFrequentlyRepliedUsersAsync(string userId, int? limit = null)
        {
            var parameters = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("userId", userId) };
            parameters.AddIfValidValue("limit", limit);

            return await PostAsync<List<FrequentlyRepliedUser>>("/get-frequently-replied-users", parameters).Stay();
        }

        public async Task<List<Note>> NotesAsync(string userId = null, bool? includeReplies = null, int? limit = null, string sinceId = null, string untilId = null, long? sinceDate = null, long? untilDate = null, bool? includeMyRenotes = null, bool? includeRenotedMyNotes = null,
                                                 bool? includeLocalRenotes = null, bool? withFiles = null, string fileType = null, bool? excludeNsfw = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("userId", userId);
            parameters.AddIfValidValue("includeReplies", includeReplies);
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("sinceId", sinceId);
            parameters.AddIfValidValue("untilId", untilId);
            parameters.AddIfValidValue("sinceDate", sinceDate);
            parameters.AddIfValidValue("untilDate", untilDate);
            parameters.AddIfValidValue("includeMyRenotes", includeMyRenotes);
            parameters.AddIfValidValue("includeRenotedMyNotes", includeRenotedMyNotes);
            parameters.AddIfValidValue("includeLocalRenotes", includeLocalRenotes);
            parameters.AddIfValidValue("withFiles", withFiles);
            parameters.AddIfValidValue("fileType", fileType);
            parameters.AddIfValidValue("excludeNsfw", excludeNsfw);

            return await PostAsync<List<Note>>("/notes", parameters).Stay();
        }

        public async Task<List<User>> RecommendationAsync(int? limit = null, int? offset = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("offset", offset);

            return await PostAsync<List<User>>("/recommendation", parameters).Stay();
        }

        public async Task<List<Relation>> RelationAsync(List<string> userIds)
        {
            var parameters = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("userId", userIds) };

            return await PostAsync<List<Relation>>("/relation", parameters).Stay();
        }

        public async Task ReportAbuseAsync(string userId, string comment)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("userId", userId),
                new KeyValuePair<string, object>("comment", comment)
            };

            await PostAsync("/report-abuse", parameters).Stay();
        }

        public async Task<List<User>> SearchAsync(string query, int? limit = null, int? offset = null, bool? localOnly = null, bool? detail = null)
        {
            var parameters = new List<KeyValuePair<string, object>> { new KeyValuePair<string, object>("query", query) };
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("offset", offset);
            parameters.AddIfValidValue("localOnly", localOnly);
            parameters.AddIfValidValue("detail", detail);

            return await PostAsync<List<User>>("/search", parameters).Stay();
        }

        public async Task<List<User>> ShowAsync(string userId = null, List<string> userIds = null, string username = null, string host = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("userId", userId);
            parameters.AddIfValidValue("userIds", userIds);
            parameters.AddIfValidValue("username", username);
            parameters.AddIfValidValue("host", host);

            if (userIds != null)
                return await PostAsync<List<User>>("/show", parameters).Stay();
            return new List<User> { await PostAsync<User>("/show", parameters).Stay() };
        }
    }
}