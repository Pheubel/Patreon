using System;
using System.Collections.Generic;
using Patreon.Api.V2.Core.Resources;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public class Tier : ITier
    {
        public IncludeField IncludesFields { get; internal set; }
        public int AmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAmountCents) ?
                _amountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAmountCents, nameof(AmountCents));
            internal set => _amountCents = value;
        }

        public int UserLimit
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUserLimit) ?
                _userLimit :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUserLimit, nameof(UserLimit));
            internal set => _userLimit = value;
        }

        public int? Remaining
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesRemaining) ?
                _remaining :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRemaining, nameof(Remaining));
            internal set => _remaining = value;
        }

        public string Description
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesDescription) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescription, nameof(Description));
            internal set => _description = value;
        }

        public bool RequiresShipping
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesRequiresShipping) ?
                _requiresShipping :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRequiresShipping, nameof(RequiresShipping));
            internal set => _requiresShipping = value;
        }

        public DateTime CreatedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        public string Url
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUrl) ?
                _url :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }

        public int PatronCount
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPatronCount) ?
                _patronCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronCount, nameof(PatronCount));
            internal set => _patronCount = value;
        }

        public int PostCount
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPostCount) ?
                _postCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPostCount, nameof(PostCount));
            internal set => _postCount = value;
        }
        public IReadOnlyCollection<ulong> DiscordRoleIds => _discordRoleIds == null ? null : Array.AsReadOnly(_discordRoleIds);

        public string Title
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }

        public string ImageUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesImageUrl) ?
                _imageUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageUrl, nameof(ImageUrl));
            internal set => _imageUrl = value;
        }

        public DateTime EditedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEditedAt) ?
                _editedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEditedAt, nameof(EditedAt));
            internal set => _editedAt = value;
        }

        public bool Published
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPublished) ?
                _published :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublished, nameof(Published));
            internal set => _published = value;
        }

        public DateTime? PublishedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPublishedAt) ?
                _publishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublishedAt, nameof(PublishedAt));
            internal set => _publishedAt = value;
        }

        public DateTime? UnpublishedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUnpublishedAt) ?
                _unpublishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUnpublishedAt, nameof(UnpublishedAt));
            internal set => _unpublishedAt = value;
        }

        int _amountCents;
        int _userLimit;
        int? _remaining;
        string _description;
        bool _requiresShipping;
        DateTime _createdAt;
        string _url;
        int _patronCount;
        int _postCount;
        ulong[] _discordRoleIds;
        string _title;
        string _imageUrl;
        DateTime _editedAt;
        bool _published;
        DateTime? _publishedAt;
        DateTime? _unpublishedAt;

        internal void SetDiscordRoleIds(ulong[] roleIds) => _discordRoleIds = roleIds;

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesAmountCents = 1 << 0,
            IncludesUserLimit = 1 << 1,
            IncludesRemaining = 1 << 2,
            IncludesDescription = 1 << 3,
            IncludesRequiresShipping = 1 << 4,
            IncludesCreatedAt = 1 << 5,
            IncludesUrl = 1 << 6,
            IncludesPatronCount = 1 << 7,
            IncludesPostCount = 1 << 8,
            IncludesDiscordRoleIds = 1 << 9,
            IncludesTitle = 1 << 10,
            IncludesImageUrl = 1 << 11,
            IncludesEditedAt = 1 << 12,
            IncludesPublished = 1 << 13,
            IncludesPublishedAt = 1 << 14,
            IncludesUnpublishedAt = 1 << 15,
        }
    }
}
