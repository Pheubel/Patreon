using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPost : IPatreonResource<int>
    {
        /// <summary> The title of the post.</summary>
        string Title { get; }
        /// <summary> The content of the post.</summary>
        string Content { get; }
        /// <summary> Determines if the post incurs a bill as part of a pay-per-pos campaign.</summary>
        bool IsPaid { get; }
        /// <summary> Determines if the post is viewable by non-patrons.</summary>
        bool IsPublic { get; }
        /// <summary> When the post was pubished by the creator.</summary>
        DateTime? PublishedAt { get; }
        /// <summary> The embed data if the media is embedded in the post.</summary>
        string EmbedData { get; }
        /// <summary> The embedded media URL.</summary>
        string EmbedUrl { get; }
        /// <summary> The platform app ID.</summary>
        string AppId { get; }
        /// <summary> The status of the app.</summary>
        string AppStatus { get; }

        /// <summary> The author of the post.</summary>
        User User { get; }
        /// <summary> The campaign that the post belongs to</summary>
        Campaign Campaign { get; }
    }
}
