using System;
using System.Collections.Generic;
using Patreon.Api.V2.Core.Resources;

namespace Patreon.Api.V2.Resources
{
    public class Tier : ITier
    {
        public IncludeField IncludesFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int AmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAmountCents) ?
                _amountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAmountCents, nameof(AmountCents));
            internal set => _amountCents = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int? UserLimit
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUserLimit) ?
                _userLimit :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUserLimit, nameof(UserLimit));
            internal set => _userLimit = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int? Remaining
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesRemaining) ?
                _remaining :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRemaining, nameof(Remaining));
            internal set => _remaining = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Description
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesDescription) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescription, nameof(Description));
            internal set => _description = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool RequiresShipping
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesRequiresShipping) ?
                _requiresShipping :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRequiresShipping, nameof(RequiresShipping));
            internal set => _requiresShipping = value;
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
        public string Url
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUrl) ?
                _url :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int PatronCount
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPatronCount) ?
                _patronCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronCount, nameof(PatronCount));
            internal set => _patronCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int PostCount
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPostCount) ?
                _postCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPostCount, nameof(PostCount));
            internal set => _postCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public IReadOnlyCollection<ulong> DiscordRoleIds =>
            IncludesFields.HasFlag(IncludeField.IncludesDiscordRoleIds) ?
                Array.AsReadOnly(_discordRoleIds) :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDiscordRoleIds,nameof(DiscordRoleIds));

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Title
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ImageUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesImageUrl) ?
                _imageUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesImageUrl, nameof(ImageUrl));
            internal set => _imageUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime EditedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEditedAt) ?
                _editedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEditedAt, nameof(EditedAt));
            internal set => _editedAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool Published
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPublished) ?
                _published :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublished, nameof(Published));
            internal set => _published = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? PublishedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPublishedAt) ?
                _publishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPublishedAt, nameof(PublishedAt));
            internal set => _publishedAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? UnpublishedAt
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesUnpublishedAt) ?
                _unpublishedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesUnpublishedAt, nameof(UnpublishedAt));
            internal set => _unpublishedAt = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Media Media
        {
            get => _tierImage ?? throw new NotIncludedException();
            internal set => _tierImage = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public IReadOnlyCollection<Benefit> Benefits =>
            _benefits != null ?
                Array.AsReadOnly(_benefits) :
                throw new NotIncludedException();
        #endregion

        private int _amountCents;
        private int? _userLimit;
        private int? _remaining;
        private string _description;
        private bool _requiresShipping;
        private DateTime _createdAt;
        private string _url;
        private int _patronCount;
        private int _postCount;
        private ulong[] _discordRoleIds;
        private string _title;
        private string _imageUrl;
        private DateTime _editedAt;
        private bool _published;
        private DateTime? _publishedAt;
        private DateTime? _unpublishedAt;

        private Campaign _campaign;
        private Media _tierImage;
        private Benefit[] _benefits;

        /// <summary> Library specific constructor.</summary>
        internal Tier() { }

        /// <summary> Sets the discord role ID's for this tier.</summary>
        internal void SetDiscordRoleIds(ulong[] roleIds) => _discordRoleIds = roleIds;

        /// <summary> Sets the benefits for this tier.</summary>
        internal void SetBenefits(Benefit[] benefits) => _benefits = benefits;

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
