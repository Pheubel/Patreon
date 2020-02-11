using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IUser : IPatreonResource<int>
    {
        /// <summary> The user's email address.</summary>
        string Email { get; }
        /// <summary> The user's first name.</summary>
        string FirstName { get; }
        /// <summary> The user's last name.</summary>
        string LastName { get; }
        /// <summary> The user's full name.</summary>
        string FullName { get; }
        /// <summary> The public username of the user.</summary>
        string Vanity { get; }
        /// <summary> The user's about text displayed on their profile.</summary>
        string About { get; }
        /// <summary> The URL of the user's creator or patron profile.</summary>
        string Url { get; }
        /// <summary> Determines if the user has confirmed their email.</summary>
        bool IsEmailVerified { get; }
        /// <summary> Determines if this user can see NSFW content.</summary>
        bool CanSeeNsfw { get; }
        /// <summary> Determines if this users hides their pledges.</summary>
        bool HidesPledges { get; }
        /// <summary> When the user's account was created.</summary>
        DateTime CreatedAt { get; }
        /// <summary> The URL of the user's profile picture.</summary>
        string AvatarUrl { get; }
        /// <summary> The urL of the user's profile picture thumbnail.</summary>
        string AvatarThumbnailUrl { get; }
        /// <summary> The number of posts this user has liked.</summary>
        int LikeCount { get; }
        /// <summary> The mapping of the user's connected apps.</summary>
        SocialConnections SocialConnections { get; }

        /// <summary> The memberships of the user.</summary>
        /// <remarks> 
        /// Requires "identity.memberships" scope to get all campaigns the identity user
        /// is a member of.
        /// </remarks>
        IReadOnlyCollection<Member> Members { get; }
        /// <summary> The user's campaign.</summary>
        Campaign Campaign { get; }
       
    }
}
