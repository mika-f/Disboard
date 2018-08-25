﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Disboard.Extensions;
using Disboard.Mastodon.Enums;
using Disboard.Mastodon.Models;

namespace Disboard.Mastodon.Clients
{
    public class InstanceClient : ApiClient<MastodonClient>
    {
        internal InstanceClient(MastodonClient client) : base(client, "/api/v1/instance") { }

        public async Task<Instance> FetchAsync()
        {
            return await GetAsync<Instance>("").Stay();
        }

        public async Task<List<string>> PeersAsync()
        {
            return await GetAsync<List<string>>("/peers").Stay();
        }

        public async Task<List<Activity>> ActivityAsync()
        {
            return await GetAsync<List<Activity>>("/activity").Stay();
        }
    }
}