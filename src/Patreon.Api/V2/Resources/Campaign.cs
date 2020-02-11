using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Campaign : ICampaign
    {
        public int Id { get; internal set; }
        public IncludeField IncludeFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Summary
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesSummary) ?
                _summary :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesSummary, nameof(Summary));
            internal set => _summary = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string CreationName
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreationName) ?
                _creationName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreationName, nameof(CreationName));
            internal set => _creationName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string PayPername
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPayPername) ?
                _payPername :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPayPername, nameof(PayPername));
            internal set => _payPername = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string OneLiner
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesOneLiner) ?
                _oneLiner :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesOneLiner, nameof(OneLiner));
            internal set => _oneLiner = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string MainVideoEmbed
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesMainVideoEmbed) ?
                _mainVideoEmbed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMainVideoEmbed, nameof(OneLiner));
            internal set => _mainVideoEmbed = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string MainVideoUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesMainVideoUrl) ?
                _mainVideoUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesMainVideoUrl, nameof(MainVideoUrl));
            internal set => _mainVideoUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ImageUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesImageUrl) ?
                _imageUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageUrl, nameof(ImageUrl));
            internal set => _imageUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ImageSmallUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesImageSmallUrl) ?
                _imageSmallUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageSmallUrl, nameof(ImageSmallUrl));
            internal set => _imageSmallUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ThanksVideoUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksVideoUrl) ?
                _thanksVideoUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksVideoUrl, nameof(ThanksVideoUrl));
            internal set => _thanksVideoUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ThanksEmbed
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksEmbed) ?
                _thanksEmbed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksEmbed, nameof(ThanksEmbed));
            internal set => _thanksEmbed = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ThanksMessage
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesThanksMessage) ?
                _thanksMessage :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesThanksMessage, nameof(ThanksEmbed));
            internal set => _thanksMessage = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool IsMonthly
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsMonthly) ?
                _isMonthly :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsMonthly, nameof(IsMonthly));
            internal set => _isMonthly = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool HasRss
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesHasRss) ?
                _hasRss :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesHasRss, nameof(HasRss));
            internal set => _hasRss = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool HasSentRssNotification
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesHasSentRssNotification) ?
                _hasSentRssNotification :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesHasSentRssNotification, nameof(HasSentRssNotification));
            internal set => _hasSentRssNotification = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string RssFeedTitle
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRssFeedTitle) ?
                _rssFeedTitle :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRssFeedTitle, nameof(RssFeedTitle));
            internal set => _rssFeedTitle = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string RssArtworkUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRssArtworkUrl) ?
                _rssArtworkUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRssArtworkUrl, nameof(RssArtworkUrl));
            internal set => _rssArtworkUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool IsNsfw
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsNsfw) ?
                _isNsfw :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsNsfw, nameof(IsNsfw));
            internal set => _isNsfw = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool IsChargedImmediately
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsChargedImmediately) ?
                _isChargedImmediately :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsChargedImmediately, nameof(IsChargedImmediately));
            internal set => _isChargedImmediately = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime CreatedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? PublishedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPublishedAt) ?
                _publishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublishedAt, nameof(PublishedAt));
            internal set => _publishedAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string PledgeUrl
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPledgeUrl) ?
                _pledgeUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPledgeUrl, nameof(PledgeUrl));
            internal set => _pledgeUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int PatronCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesPatronCount) ?
                _patronCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronCount, nameof(PatronCount));
            internal set => _patronCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public ulong? DiscordServerId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDiscordServerId) ?
                _discordServerId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDiscordServerId, nameof(DiscordServerId));
            internal set => _discordServerId = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string GoogleAnalyticsId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesGoogleAnalyticsId) ?
                _googleAnalyticsId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesGoogleAnalyticsId, nameof(GoogleAnalyticsId));
            internal set => _googleAnalyticsId = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool ShowEarnings
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesShowEarings) ?
                _showEarnings :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesShowEarings, nameof(ShowEarnings));
            internal set => _showEarnings = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Vanity
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesVanity) ?
                  _vanity :
                  throw new NotIncludedException<IncludeField>(IncludeField.IncludesVanity, nameof(Vanity));
            internal set => _vanity = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Url
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesUrl) ?
                _url :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        public IReadOnlyCollection<Tier> Tiers => _tiers != null ? Array.AsReadOnly(_tiers) : Array.AsReadOnly(Array.Empty<Tier>());

        /// <inheritdoc/>
        public User Creator { get; internal set; }

        /// <inheritdoc/>
        public IReadOnlyCollection<Benefit> Benefits => _benefits != null ? Array.AsReadOnly(_benefits) : Array.AsReadOnly(Array.Empty<Benefit>());

        /// <inheritdoc/>
        public IReadOnlyCollection<Goal> Goals => _goals != null ? Array.AsReadOnly(_goals) : Array.AsReadOnly(Array.Empty<Goal>());
        #endregion

        private string _summary;
        private string _creationName;
        private string _payPername;
        private string _oneLiner;
        private string _mainVideoEmbed;
        private string _mainVideoUrl;
        private string _imageUrl;
        private string _imageSmallUrl;
        private string _thanksVideoUrl;
        private string _thanksEmbed;
        private string _thanksMessage;
        private bool _isMonthly;
        private bool _hasRss;
        private bool _hasSentRssNotification;
        private string _rssFeedTitle;
        private string _rssArtworkUrl;
        private bool _isNsfw;
        private bool _isChargedImmediately;
        private DateTime _createdAt;
        private DateTime? _publishedAt;
        private string _pledgeUrl;
        private int _patronCount;
        private ulong? _discordServerId;
        private string _googleAnalyticsId;
        private bool _showEarnings;
        private string _vanity;
        private string _url;

        private Tier[] _tiers;
        private Benefit[] _benefits;
        private Goal[] _goals;


        /// <summary> Library restricted construcor.</summary>
        internal Campaign() { }

        /// <summary> Sets the tiers for this campaign.</summary>
        internal void SetTiers(Tier[] tiers) => _tiers = tiers;

        /// <summary> Sets the benefits for this campaign.</summary>
        internal void SetBenefits(Benefit[] benefits) => _benefits = benefits;

        /// <summary> Sets the goals for this campaign.</summary>
        internal void SetGoals(Goal[] goals) => _goals = goals;

        string IPatreonResource.IdString => Id.ToString();

        [Flags]
        public enum IncludeField
        {
            None = 0,
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