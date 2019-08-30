namespace Disboard.Misskey.Enums
{
    public enum Permission
    {
        AccountRead = 1 << 0,

        AccountWrite = 1 << 1,

        BlocksRead = 1 << 2,

        BlocksWrite = 1 << 3,

        DriveRead = 1 << 4,

        DriveWrite = 1 << 5,

        FavoritesRead = 1 << 6,

        FavoritesWrite = 1 << 7,

        FollowingRead = 1 << 8,

        FollowingWrite = 1 << 9,

        MessagingRead = 1 << 10,

        MessagingWrite = 1 << 11,

        MutesRead = 1 << 12,

        MutesWrite = 1 << 13,

        NotificationsRead = 1 << 14,

        NotificationsWrite = 1 << 15,

        ReactionsRead = 1 << 16,

        ReactionsWrite = 1 << 17,

        VotesWrite = 1 << 18,

        PagesRead = 1 << 19,

        PagesWrite = 1 << 20,

        PageLikesRead = 1 << 21,

        PageLikesWrite = 1 << 22,

        UserGroupsRead = 1 << 23,

        UserGroupsWrite = 1 << 24
    }
}