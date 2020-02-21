using System;
using System.Collections.Generic;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> a container for media data.</summary>
    public interface IMedia : IPatreonResource<int>
    {
        /// <summary> the name of the file.</summary>
        string FileName { get; }
        /// <summary> The size of the file in bytes.</summary>
        int SizeBytes { get; }
        /// <summary> The mimetype of te uploaded file.</summary>
        string MimeType { get; }
        /// <summary> The state of the file.</summary>
        string State { get; }
        /// <summary> The type of resource that owns the file.</summary>
        string OwnerType { get; }
        /// <summary> The id of the owner resource.</summary>
        string OwnerId { get; }
        /// <summary> The relationship type for multi-relationship media.</summary>
        string OwnerRelationship { get; }
        /// <summary> When the upload URL expires.</summary>
        DateTime UploadExpiresAt { get; }
        /// <summary> The URL to perform a POST request to in order to upload the media file.</summary>
        string UploadUrl { get; }
        /// <summary> All the parameters that have to be added to the upload form request.</summary>
        string UploadParameters { get; }
        /// <summary> The URL to download this media.</summary>
        string DownloadUrl { get; }
        /// <summary> The resized image URL's for this media.</summary>
        IReadOnlyCollection<string> ImageUrls { get; }
        /// <summary> When the file was created.</summary>
        DateTime CreatedAt { get; }
        /// <summary> The metadate related to the file.</summary>
        string MetaData { get; }
    }
}
