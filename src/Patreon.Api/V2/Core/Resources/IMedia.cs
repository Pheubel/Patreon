using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IMedia
    {
        string FileName { get; }
        int SizeBytes { get; }
        string MimeType { get; }
        string State { get; }
        string OwnerType { get; }
        string OwnerId { get; }
        string OwnerRelationship { get; }
        DateTime UploadExpiresAt { get; }
        string UploadUrl { get; }
        string UploadParameters { get; }
        string DownloadUrl { get; }
        string[] ImageUrls { get; }
        DateTime CreatedAt { get; }
        string MetaData { get; }
    }
}
