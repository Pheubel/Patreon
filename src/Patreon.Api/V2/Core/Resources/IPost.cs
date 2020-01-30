using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPost : IPatreonResource
    {
        string Title { get; }
        string Content { get; }
        bool IsPaid { get; }
        bool IsPublic { get; }
        DateTime? PublishedAt { get; }
        string EmbedData { get; }
        string EmbedUrl { get; }
        string AppId { get; }
        string AppStatus { get; }

        User User { get; }
        Campaign Campaign { get; }
    }
}
