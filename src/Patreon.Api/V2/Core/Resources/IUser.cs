using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IUser
    {
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
        string Vanity { get; }
        string About { get; }
        string Url { get; }
        bool IsEmailVerified { get; }
        bool CanSeeNsfw { get; }
        bool HidesPledges { get; }
        DateTime CreatedAt { get; }
        string AvatarUrl { get; }
        string AvatarThumbnailUrl { get; }
        int LikeCount { get; }
        SocialConnections SocialConnections { get; }
    }
}
