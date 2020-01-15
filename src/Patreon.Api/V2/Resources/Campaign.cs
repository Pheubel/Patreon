using System;

namespace Patreon.Api.V2.Resources
{
    public class Campaign
    {
        public IncludeField IncludeFields { get; internal set; }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? Summary
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesSummary) ?
                _summary :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesSummary, nameof(Summary));
            set => _summary = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? CreationName
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreationName) ?
                _creationName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreationName, nameof(CreationName));
            set => _creationName = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? PayPername
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPayPername) ?
                _payPername :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPayPername, nameof(PayPername));
            set => _payPername = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? OneLiner
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesOneLiner) ?
                _oneLiner :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesOneLiner, nameof(OneLiner));
            set => _oneLiner = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? MainVideoEmbed
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesMainVideoEmbed) ?
                _mainVideoEmbed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMainVideoEmbed, nameof(OneLiner));
            set => _mainVideoEmbed = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? MainVideoUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesMainVideoUrl) ?
                _mainVideoUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMainVideoUrl, nameof(MainVideoUrl));
            set => _mainVideoUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string ImageUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesImageUrl) ?
                _imageUrl! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageUrl, nameof(ImageUrl));
            set => _imageUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string ImageSmallUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesImageSmallUrl) ?
                _imageSmallUrl! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageSmallUrl, nameof(ImageSmallUrl));
            set => _imageSmallUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? ThanksVideoUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksVideoUrl) ?
                _thanksVideoUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksVideoUrl, nameof(ThanksVideoUrl));
            set => _thanksVideoUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? ThanksEmbed
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksEmbed) ?
                _thanksEmbed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksEmbed, nameof(ThanksEmbed));
            set => _thanksEmbed = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? ThanksMessage
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksMessage) ?
                _thanksMessage :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksMessage, nameof(ThanksEmbed));
            set => _thanksMessage = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsMonthly
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsMonthly) ?
                _isMonthly :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsMonthly, nameof(IsMonthly));
            set => _isMonthly = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool HasRss
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesHasRss) ?
                _hasRss :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesHasRss, nameof(HasRss));
            set => _hasRss = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool HasSentRssNotification
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesHasSentRssNotification) ?
                _hasSentRssNotification :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesHasSentRssNotification, nameof(HasSentRssNotification));
            set => _hasSentRssNotification = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string RssFeedTitle
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRssFeedTitle) ?
                _rssFeedTitle! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRssFeedTitle, nameof(RssFeedTitle));
            set => _rssFeedTitle = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? RssArtworkUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRssArtworkUrl) ?
                _rssArtworkUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRssArtworkUrl, nameof(RssArtworkUrl));
            set => _rssArtworkUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsNsfw
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsNsfw) ?
                _isNsfw :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsNsfw, nameof(IsNsfw));
            set => _isNsfw = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsChargedImmediately
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsChargedImmediately) ?
                _isChargedImmediately :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsChargedImmediately, nameof(IsChargedImmediately));
            set => _isChargedImmediately = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime CreatedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            set => _createdAt = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime? PublishedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPublishedAt) ?
                _publishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublishedAt, nameof(PublishedAt));
            set => _publishedAt = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string PledgeUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPledgeUrl) ?
                _pledgeUrl! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPledgeUrl, nameof(PledgeUrl));
            set => _pledgeUrl = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public int PatronCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPatronCount) ?
                _patronCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronCount, nameof(PatronCount));
            set => _patronCount = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public ulong? DiscordServerId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDiscordServerId) ?
                _discordServerId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDiscordServerId, nameof(DiscordServerId));
            set => _discordServerId = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? GoogleAnalyticsId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesGoogleAnalyticsId) ?
                _googleAnalyticsId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesGoogleAnalyticsId, nameof(GoogleAnalyticsId));
            set => _googleAnalyticsId = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool ShowEarnings
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesShowEarings) ?
                _showEarnings :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesShowEarings, nameof(ShowEarnings));
            set => _showEarnings = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? Vanity
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesVanity) ?
                  _vanity :
                  throw new NotIncludedException<IncludeField>(IncludeField.IncludesVanity, nameof(Vanity));
            set => _vanity = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Url
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesUrl) ?
                _url! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUrl, nameof(Url));
            set => _url = value;
        }

        string? _summary;
        string? _creationName;
        string? _payPername;
        string? _oneLiner;
        string? _mainVideoEmbed;
        string? _mainVideoUrl;
        string? _imageUrl;
        string? _imageSmallUrl;
        string? _thanksVideoUrl;
        string? _thanksEmbed;
        string? _thanksMessage;
        bool _isMonthly;
        bool _hasRss;
        bool _hasSentRssNotification;
        string? _rssFeedTitle;
        string? _rssArtworkUrl;
        bool _isNsfw;
        bool _isChargedImmediately;
        DateTime _createdAt;
        DateTime? _publishedAt;
        string? _pledgeUrl;
        int _patronCount;
        ulong? _discordServerId;
        string? _googleAnalyticsId;
        bool _showEarnings;
        string? _vanity;
        string? _url;

        /// <summary> Library restricted construcor.</summary>
        internal Campaign() { }

        [Flags]
        public enum IncludeField
        {
            IncludesSummary = 1 << 0,
            IncludesCreationName = 1 << 1,
            IncludesPayPername = 1 << 2,
            IncludesOneLiner = 1 << 3,
            IncludesMainVideoEmbed = 1 << 4,
            IncludesMainVideoUrl = 1 << 5,
            IncludesImageUrl = 1 << 6,
            IncludesImageSmallUrl = 1 << 7,
            IncludesThanksVideoUrl = 1 << 8,
            IncludesThanksEmbed = 1 << 9,
            IncludesThanksMessage = 1 << 10,
            IncludesIsMonthly = 1 << 11,
            IncludesHasRss = 1 << 12,
            IncludesHasSentRssNotification = 1 << 13,
            IncludesRssFeedTitle = 1 << 14,
            IncludesRssArtworkUrl = 1 << 15,
            IncludesIsNsfw = 1 << 16,
            IncludesIsChargedImmediately = 1 << 17,
            IncludesCreatedAt = 1 << 18,
            IncludesPublishedAt = 1 << 19,
            IncludesPledgeUrl = 1 << 20,
            IncludesPatronCount = 1 << 21,
            IncludesDiscordServerId = 1 << 22,
            IncludesGoogleAnalyticsId = 1 << 23,
            IncludesShowEarings = 1 << 24,
            IncludesVanity = 1 << 25,
            IncludesUrl = 1 << 26
        }
    }
}