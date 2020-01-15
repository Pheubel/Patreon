using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public sealed class User
    {
        public IncludeFlag IncludeFlags { get; internal set; }
        public string Email
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesEmail) ?
                _email! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesEmail, nameof(Email));
            internal set => _email = value;
        }
        public string? FirstName
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesFirstName) ?
                _firstname :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesFirstName, nameof(FirstName));
            internal set => _firstname = value;
        }
        public string? LastName
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLastName) ?
                _lastName :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLastName, nameof(LastName));
            internal set => _lastName = value;
        }
        public string? Vanity
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesVanity) ?
                _vanity :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesVanity, nameof(Vanity));
            internal set => _vanity = value;
        }
        public string? About
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAbout) ?
                _about :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAbout, nameof(About));
            internal set => _about = value;
        }
        public string Url
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesUrl) ?
                _url! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }
        public bool IsEmailVerified
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesIsEmailVerified) ?
                _isEmailVerified! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesIsEmailVerified, nameof(IsEmailVerified));
            internal set => _isEmailVerified = value;
        }
        public bool CanSeeNsfw
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCanSeeNsfw) ?
                _canSeeNsfw :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCanSeeNsfw,nameof(CanSeeNsfw));
            internal set => _canSeeNsfw = value;
        }
        public bool HidesPledges
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesHidePledges) ?
                _hidesPledges :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesHidePledges,nameof(HidesPledges));
            internal set => _hidesPledges = value;
        }
        public DateTime CreatedAt
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt:
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt,nameof(CreatedAt));
            internal set => _createdAt = value;
        }
        public string AvatarUrl
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAvatar) ?
                _avatarUrl! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatar,nameof(AvatarUrl));
            internal set => _avatarUrl = value;
        }
        public string AvatarThumbnailUrl
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAvatarThumbnail) ?
                _avatarThumbnailUrl! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatarThumbnail,nameof(AvatarThumbnailUrl));
            internal set => _avatarThumbnailUrl = value;
        }
        public int LikeCount
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLikeCount) ?
                _likeCount :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLikeCount, nameof(LikeCount));
            internal set => _likeCount = value;
        }
        public SocialConnections SocialConnections
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesSocialConnections) ?
                _socialConnections! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesSocialConnections,nameof(SocialConnections));
            internal set => _socialConnections = value;
        }

        private string? _email;
        private string? _firstname;
        private string? _lastName;
        private string? _vanity;
        private string? _about;
        private string? _url;
        private bool _isEmailVerified;
        private bool _canSeeNsfw;
        private bool _hidesPledges;
        private DateTime _createdAt;
        private string? _avatarUrl;
        private string? _avatarThumbnailUrl;
        private int _likeCount;
        private SocialConnections? _socialConnections;

        /// <summary> Library restricted construcor.</summary>
        internal User() { }


        [Flags]
        public enum IncludeFlag
        {
            IncludesEmail = 0b1,
            IncludesFirstName = 0b10,
            IncludesLastName = 0b100,
            IncludesFullName = 0b1000,
            IncludesIsEmailVerified = 0b1_0000,
            IncludesVanity = 0b10_0000,
            IncludesAbout = 0b100_0000,
            IncludesAvatar = 0b1000_0000,
            IncludesAvatarThumbnail = 0b1_0000_0000,
            IncludesCanSeeNsfw = 0b10_0000_0000,
            IncludesCreatedAt = 0b100_0000_0000,
            IncludesLikeCount = 0b1000_0000_0000,
            IncludesHidePledges = 0b1_0000_0000_0000,
            IncludesSocialConnections = 0b10_0000_0000,
            IncludesUrl = 0b100_0000_0000
        }
    }
}
