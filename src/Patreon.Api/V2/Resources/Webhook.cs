using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public class Webhook : IWebhook<Webhook.Trigger>
    {
        public IncludeField IncludesFields { get; internal set; }
        public Trigger Triggers
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTriggers) ?
                _triggers :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTriggers, nameof(Triggers));
            internal set => _triggers = value;
        }
        public Uri Uri
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUri) ?
                _uri :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUri, nameof(Uri));
            internal set => _uri = value;
        }
        public bool Paused
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPaused) ?
                _paused :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPaused, nameof(Paused));
            internal set => _paused = value;
        }
        public DateTime LastAttemptedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastAttemptedAt) ?
                _lastAttemptedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastAttemptedAt, nameof(LastAttemptedAt));
            internal set => _lastAttemptedAt = value;
        }
        public int NumConsecutiveTimesFailed
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesNumConsecutiveTimesFailed) ?
                _numConsecutiveTimesFailed :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNumConsecutiveTimesFailed, nameof(NumConsecutiveTimesFailed));
            internal set => _numConsecutiveTimesFailed = value;
        }
        public string Secret
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesSecret) ?
                _secret :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesSecret, nameof(Secret));
            internal set => _secret = value;
        }

        Trigger _triggers;
        Uri _uri;
        bool _paused;
        DateTime _lastAttemptedAt;
        int _numConsecutiveTimesFailed;
        string _secret;

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
