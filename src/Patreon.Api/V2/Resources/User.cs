using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public sealed class User : IUser
    {
        public IncludeFlag IncludesField { get; internal set; }
        public int Id { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Email
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesEmail) ?
                _email :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesEmail, nameof(Email));
            internal set => _email = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string FirstName
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesFirstName) ?
                _firstname :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesFirstName, nameof(FirstName));
            internal set => _firstname = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string LastName
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesLastName) ?
                _lastName :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLastName, nameof(LastName));
            internal set => _lastName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string FullName
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesFullName) ?
                _fullName :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesFullName, nameof(FullName));
            internal set => _fullName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Vanity
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesVanity) ?
                _vanity :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesVanity, nameof(Vanity));
            internal set => _vanity = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string About
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesAbout) ?
                _about :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAbout, nameof(About));
            internal set => _about = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Url
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesUrl) ?
                _url :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool IsEmailVerified
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesIsEmailVerified) ?
                _isEmailVerified :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesIsEmailVerified, nameof(IsEmailVerified));
            internal set => _isEmailVerified = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool CanSeeNsfw
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesCanSeeNsfw) ?
                _canSeeNsfw :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCanSeeNsfw, nameof(CanSeeNsfw));
            internal set => _canSeeNsfw = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool HidesPledges
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesHidePledges) ?
                _hidesPledges :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesHidePledges, nameof(HidesPledges));
            internal set => _hidesPledges = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime CreatedAt
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string AvatarUrl
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesAvatar) ?
                _avatarUrl :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatar, nameof(AvatarUrl));
            internal set => _avatarUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string AvatarThumbnailUrl
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesAvatarThumbnail) ?
                _avatarThumbnailUrl :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatarThumbnail, nameof(AvatarThumbnailUrl));
            internal set => _avatarThumbnailUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int LikeCount
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesLikeCount) ?
                _likeCount :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLikeCount, nameof(LikeCount));
            internal set => _likeCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public SocialConnections SocialConnections
        {
            get => IncludesField.HasFlag(IncludeFlag.IncludesSocialConnections) ?
                _socialConnections :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesSocialConnections, nameof(SocialConnections));
            internal set => _socialConnections = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        public IReadOnlyCollection<Member> Members =>
            _members != null ?
                Array.AsReadOnly(_members) :
                Array.AsReadOnly(Array.Empty<Member>());

        /// <inheritdoc/>
        public Campaign Campaign { get; internal set; }
        #endregion

        private string _email;
        private string _firstname;
        private string _lastName;
        private string _fullName;
        private string _vanity;
        private string _about;
        private string _url;
        private bool _isEmailVerified;
        private bool _canSeeNsfw;
        private bool _hidesPledges;
        private DateTime _createdAt;
        private string _avatarUrl;
        private string _avatarThumbnailUrl;
        private int _likeCount;
        private SocialConnections _socialConnections;

        private Member[] _members;
        private Campaign _campaign;

        /// <summary> Library restricted construcor.</summary>
        internal User() { }

        /// <summary> Sets the memberships for the user.</summary>
        internal void SetMemberships(Member[] members) => _members = members;

        string IPatreonResource.IdString => Id.ToString();

        [Flags]
        public enum IncludeFlag
        {
            None = 0,
            IncludesEmail = 1 << 0,
            IncludesFirstName = 1 << 1,
            IncludesLastName = 1 << 2,
            IncludesFullName = 1 << 3,
            IncludesIsEmailVerified = 1 << 4,
            IncludesVanity = 1 << 5,
            IncludesAbout = 1 << 6,
            IncludesAvatar = 1 << 7,
            IncludesAvatarThumbnail = 1 << 8,
            IncludesCanSeeNsfw = 1 << 9,
            IncludesCreatedAt = 1 << 10,
            IncludesLikeCount = 1 << 11,
            IncludesHidePledges = 1 << 12,
            IncludesSocialConnections = 1 << 13,
            IncludesUrl = 1 << 14
        }
    }
}
