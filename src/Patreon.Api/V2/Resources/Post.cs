using System;

namespace Patreon.Api.V2.Resources
{
    public class Post
    {
        public IncludeField IncludesFields { get; internal set; }

        public string Title
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }
        public string Content
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesContent) ?
                _content :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesContent, nameof(Content));
            internal set => _content = value;
        }
        public bool IsPaid
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesIsPaid) ?
                _isPaid :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsPaid, nameof(IsPaid));
            internal set => _isPaid = value;
        }
        public bool IsPublic
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesIsPublic) ?
                _isPublic :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsPublic, nameof(IsPublic));
            internal set => _isPublic = value;
        }
        public DateTime? PublishedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPublishedAt) ?
                _publishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublishedAt, nameof(PublishedAt));
            internal set => _publishedAt = value;
        }
        public string Url
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUrl) ?
                _url :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }
        public string EmbedData
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEmbedData) ?
                _embedData :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEmbedData, nameof(EmbedData));
            internal set => _embedData = value;
        }
        public string EmbedUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEmbedurl) ?
                _embedUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEmbedurl, nameof(EmbedUrl));
            internal set => _embedUrl = value;
        }
        public string AppId
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAppId) ?
                _appId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppId, nameof(AppId));
            internal set => _appId = value;
        }
        public string AppStatus
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAppStatus) ?
                _appStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppStatus, nameof(AppStatus));
            internal set => _appStatus = value;
        }
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        private string _title;
        private string _content;
        private bool _isPaid;
        private bool _isPublic;
        private DateTime? _publishedAt;
        private string _url;
        private string _embedData;
        private string _embedUrl;
        private string _appId;
        private string _appStatus;

        private User _user;
        private Campaign _campaign;

        internal Post() { }

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesTitle = 1 << 0,
            IncludesContent = 1 << 1,
            IncludesIsPaid = 1 << 2,
            IncludesIsPublic = 1 << 3,
            IncludesPublishedAt = 1 << 4,
            IncludesUrl = 1 << 5,
            IncludesEmbedData = 1 << 6,
            IncludesEmbedurl = 1 << 7,
            IncludesAppId = 1 << 8,
            IncludesAppStatus = 1 << 9
        }
    }
}
