using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Webhook : IWebhook<Webhook.Trigger>
    {
        public int Id { get; internal set; }
        public IncludeField IncludesFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public Trigger Triggers
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTriggers) ?
                _triggers :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTriggers, nameof(Triggers));
            internal set => _triggers = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public Uri Uri
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUri) ?
                _uri :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUri, nameof(Uri));
            internal set => _uri = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool Paused
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPaused) ?
                _paused :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPaused, nameof(Paused));
            internal set => _paused = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime LastAttemptedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastAttemptedAt) ?
                _lastAttemptedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastAttemptedAt, nameof(LastAttemptedAt));
            internal set => _lastAttemptedAt = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int NumConsecutiveTimesFailed
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesNumConsecutiveTimesFailed) ?
                _numConsecutiveTimesFailed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNumConsecutiveTimesFailed, nameof(NumConsecutiveTimesFailed));
            internal set => _numConsecutiveTimesFailed = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Secret
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesSecret) ?
                _secret :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesSecret, nameof(Secret));
            internal set => _secret = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException"/>
        public OAuthClient Client
        {
            get => _client ?? throw new NotIncludedException();
            internal set => _client = value;
        }

        /// <inheritdoc/>>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }
        #endregion

        Trigger _triggers;
        Uri _uri;
        bool _paused;
        DateTime _lastAttemptedAt;
        int _numConsecutiveTimesFailed;
        string _secret;

        OAuthClient _client;
        Campaign _campaign;

        /// <summary> Library restricted constructor.</summary>
        internal Webhook() { }

        string IPatreonResource.IdString => Id.ToString();

        [Flags]
        public enum Trigger
        {
            MemberCreate = 1 << 0,
            MemberUpdate = 1 << 1,
            MemberDelete = 1 << 2,
            MemberPledgeCreate = 1 << 3,
            MemberPledgeUpdate = 1 << 4,
            MemberPledgeDelete = 1 << 5,
            PostPublish = 1 << 6,
            PostUpdate = 1 << 7,
            PostDelete = 1 << 8,
        }

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesTriggers = 1 << 0,
            IncludesUri = 1 << 1,
            IncludesPaused = 1 << 2,
            IncludesLastAttemptedAt = 1 << 3,
            IncludesNumConsecutiveTimesFailed = 1 << 4,
            IncludesSecret = 1 << 5,
        }
    }
}
