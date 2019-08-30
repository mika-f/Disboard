using System.Collections.Generic;
using System.Threading.Tasks;

using Disboard.Extensions;
using Disboard.Misskey.Models;

namespace Disboard.Misskey
{
    public partial class MisskeyClient
    {
        public async Task<Endpoint> EndpointAsync(string endpoint)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("endpoint", endpoint)
            };

            return await PostAsync<Endpoint>("/api/endpoint", parameters).Stay();
        }

        public async Task<IEnumerable<string>> EndpointsAsync()
        {
            return await PostAsync<IEnumerable<string>>("/api/endpoints").Stay();
        }

        public async Task<Metadata> MetaAsync(bool? detail = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("detail", detail);

            return await PostAsync<Metadata>("/api/meta", parameters).Stay();
        }

        public async Task<IEnumerable<User>> PinnedUsersAsync()
        {
            return await PostAsync<IEnumerable<User>>("/api/pinned-users").Stay();
        }

        public async Task<Drive> DriveAsync()
        {
            return await PostAsync<Drive>("/api/drive").Stay();
        }

        // ReSharper disable once InconsistentNaming
        public async Task<User> IAsync()
        {
            return await PostAsync<User>("/api/i").Stay();
        }

        public async Task<List<Note>> NotesAsync(bool? local = null, bool? reply = null, bool? renote = null, bool? withFiles = null, bool? poll = null, int? limit = null, string sinceId = null, string untilId = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("local", local);
            parameters.AddIfValidValue("reply", reply);
            parameters.AddIfValidValue("renote", renote);
            parameters.AddIfValidValue("withFiles", withFiles);
            parameters.AddIfValidValue("poll", poll);
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("sinceId", sinceId);
            parameters.AddIfValidValue("untilId", untilId);

            return await PostAsync<List<Note>>("/api/notes", parameters).Stay();
        }

        public async Task<Stats> StatsAsync()
        {
            return await PostAsync<Stats>("/api/stats").Stay();
        }

        public async Task<List<User>> UsersAsync(int? limit = null, int? offset = null, string sort = null, string state = null, string origin = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("offset", offset);
            parameters.AddIfValidValue("sort", sort);
            parameters.AddIfValidValue("state", state);
            parameters.AddIfValidValue("origin", origin);

            return await PostAsync<List<User>>("/api/users", parameters).Stay();
        }
    }
}