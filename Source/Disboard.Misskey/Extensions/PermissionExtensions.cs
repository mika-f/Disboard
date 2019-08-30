using System;

using Disboard.Misskey.Enums;

namespace Disboard.Misskey.Extensions
{
    public static class PermissionExtensions
    {
        public static string ToStr(this Permission permission)
        {
            switch (permission)
            {
                case Permission.AccountRead:
                    return "read:account";

                case Permission.AccountWrite:
                    return "write:account";

                case Permission.BlocksRead:
                    return "read:blocks";

                case Permission.BlocksWrite:
                    return "write:blocks";

                case Permission.DriveRead:
                    return "read:drive";

                case Permission.DriveWrite:
                    return "write:drive";

                case Permission.FavoritesRead:
                    return "read:favorites";

                case Permission.FavoritesWrite:
                    return "write:favorites";

                case Permission.FollowingRead:
                    return "read:following";

                case Permission.FollowingWrite:
                    return "write:following";

                case Permission.MessagingRead:
                    return "read:messaging";

                case Permission.MessagingWrite:
                    return "write:messaging";

                case Permission.MutesRead:
                    return "read:mutes";

                case Permission.MutesWrite:
                    return "write:mutes";

                case Permission.NotificationsRead:
                    return "read:notifications";

                case Permission.NotificationsWrite:
                    return "write:notification";

                case Permission.ReactionsRead:
                    return "read:reactions";

                case Permission.ReactionsWrite:
                    return "write:reactions";

                case Permission.VotesWrite:
                    return "write:votes";

                case Permission.PagesRead:
                    return "read:pages";

                case Permission.PagesWrite:
                    return "write:pages";

                case Permission.PageLikesRead:
                    return "read:page-likes";

                case Permission.PageLikesWrite:
                    return "write:page-likes";

                case Permission.UserGroupsRead:
                    return "read:user-groups";

                case Permission.UserGroupsWrite:
                    return "write:user-groups";

                default:
                    throw new ArgumentOutOfRangeException(nameof(permission), permission, null);
            }
        }
    }
}