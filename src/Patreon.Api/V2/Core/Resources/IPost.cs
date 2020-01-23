using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
