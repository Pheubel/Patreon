﻿using Patreon.Api.Core.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Media : IMedia
    {
        public int Id { get; internal set; }
        public IncludeField IncludesFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string FileName
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesFileName) ?
                _fileName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesFileName, nameof(FileName));
            internal set => _fileName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int SizeBytes
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesSizeBytes) ?
                _sizeBytes :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesSizeBytes, nameof(SizeBytes));
            internal set => _sizeBytes = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string MimeType
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesMimeType) ?
                _mimeType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMimeType, nameof(MimeType));
            internal set => _mimeType = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string State
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesState) ?
                _state :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesState, nameof(State));
            internal set => _state = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string OwnerType
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesOwnerType) ?
                _ownerType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesOwnerType, nameof(OwnerType));
            internal set => _ownerType = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string OwnerId
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesOwnerId) ?
                _ownerId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesOwnerId, nameof(OwnerId));
            internal set => _ownerId = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string OwnerRelationship
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesOwnerRelationship) ?
                _ownerRelationship :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesOwnerRelationship, nameof(OwnerRelationship));
            internal set => _ownerRelationship = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime UploadExpiresAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUploadExpiresAt) ?
                _uploadExpiresAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUploadExpiresAt, nameof(UploadExpiresAt));
            internal set => _uploadExpiresAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string UploadUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUploadUrl) ?
                _uploadUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUploadUrl, nameof(UploadUrl));
            internal set => _uploadUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string UploadParameters
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUploadParameters) ?
                _uploadParameters :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUploadParameters, nameof(UploadParameters));
            internal set => _uploadParameters = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string DownloadUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesDownloadurl) ?
                _downloadUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDownloadurl, nameof(DownloadUrl));
            internal set => _downloadUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public IReadOnlyCollection<string> ImageUrls
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesImageUrls) ?
                _imageUrls :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageUrls, nameof(ImageUrls));
            internal set => _imageUrls = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime CreatedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string MetaData
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesMetaData) ?
                _metaData :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMetaData, nameof(MetaData));
            internal set => _metaData = value;
        }
        #endregion

        private string _fileName;
        private int _sizeBytes;
        private string _mimeType;
        private string _state;
        private string _ownerType;
        private string _ownerId;
        private string _ownerRelationship;
        private DateTime _uploadExpiresAt;
        private string _uploadUrl;
        private string _uploadParameters;
        private string _downloadUrl;
        private IReadOnlyCollection<string> _imageUrls;
        private DateTime _createdAt;
        private string _metaData;

        /// <summary> Library specific constructor.</summary>
        internal Media() { }

        string IPatreonResource.Id => Id.ToString();

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesFileName = 1 << 0,
            IncludesSizeBytes = 1 << 1,
            IncludesMimeType = 1 << 2,
            IncludesState = 1 << 3,
            IncludesOwnerType = 1 << 4,
            IncludesOwnerId = 1 << 5,
            IncludesOwnerRelationship = 1 << 6,
            IncludesUploadExpiresAt = 1 << 7,
            IncludesUploadUrl = 1 << 8,
            IncludesUploadParameters = 1 << 9,
            IncludesDownloadurl = 1 << 10,
            IncludesImageUrls = 1 << 11,
            IncludesCreatedAt = 1 << 12,
            IncludesMetaData = 1 << 13
        }
    }
}
