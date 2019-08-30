Disboard.Misskey
----

[![License](https://img.shields.io/github/license/mika-f/Disboard.svg?style=flat-square)](../../LICENSE)
[![Disboard.Misskey](https://img.shields.io/nuget/v/Disboard.Misskey.svg?style=flat-square)](https://nuget.org/packages/Disboard.Misskey)


Misskey API wrapper for .NET Standard 2.0.  
Based on Misskey 10.90.x.


## Note

[Misskey's documentation](https://misskey.xyz/docs/ja-JP/about) is not trustworthy.  
If you want to contribute to this library, you SHOULD read [Misskey's source code implementation](https://github.com/syuilo/misskey).

**This is a generic Misskey API wrapper**, we do not implement features unique to the instance.  

Some Misskey endpoints require privilege permission (`requireAdmin`, `requireModerator` or `secure` set to `true`).  
Disboard does not support these APIs.


## Usage

```csharp
var misskey = new MisskeyClient("misskey.xyz");

// register app
var permissions = new List<Permission> {
    Permission.AccountRead, Permission.AccountWrite,
    Permission.BlocksRead, Permission.BlocksWrite,
    Permission.DriveRead, Permission.DriveWrite,
    Permission.FavoritesRead, Permission.FavoritesWrite,
    Permission.FollowingRead, Permission.FollowingWrite,
    Permission.MessagingRead, Permission.MessagingWrite,
    Permission.MutesRead, Permission.MutesWrite,
    Permission.NotificationsRead, Permission.NotificationsWrite,
    Permission.PagesRead, Permission.PagesWrite,
    Permission.PageLikesRead, Permission.PageLikesWrite,
    Permission.ReactionsRead, Permission.ReactionsWrite,
    Permission.UserGroupsRead, Permission.UserGroupsWrite,
    Permission.VotesWrite,
};

// permission is "string[]", because Misskey's permission is very flexible and possibility that it will increase in the future.
await misskey.App.CreateAsync("Orion", "Orion is generic microblogging client", permissions.Select(w => w.ToStr()).ToArray(), "https://static.mochizuki.moe/callback.html");

// auth
var session = await misskey.Auth.Session.Generate();
Process.Start(session.Url);

// Wait for user accepts client that access to your info
var token = Console.ReadLine();
await misskey.Auth.Session.UserKeyAsync(token);

// If you want to call REST API, please use method that has "Async()" suffix.
await misskey.IAsync();

try
{
    // Streaming API
    await misskey.Streaming.ConnectAsync();
    var disposable = misskey.Streaming.LocalTimelineAsObservable().Subscribe(w => {
        w.Dump();
    });

    await Task.Delay(1000 * 60);
    disposable.Dispose();

    // If you want to call REST API using WebSocket connection, please use method that has "WsAsync()" suffix.
    await misskey.IWsAsync();
}
catch (Exception e)
{
    Debug.WriteLine(e);
}
finally
{
    misskey.Streaming.Disconnect();
}
```

