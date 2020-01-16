using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public sealed class User : IUser
    {
        public IncludeFlag IncludeFlags { get; internal set; }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Email
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesEmail) ?
                _email! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesEmail, nameof(Email));
            internal set => _email = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? FirstName
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesFirstName) ?
                _firstname :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesFirstName, nameof(FirstName));
            internal set => _firstname = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? LastName
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLastName) ?
                _lastName :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLastName, nameof(LastName));
            internal set => _lastName = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? Vanity
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesVanity) ?
                _vanity :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesVanity, nameof(Vanity));
            internal set => _vanity = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? About
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAbout) ?
                _about :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAbout, nameof(About));
            internal set => _about = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Url
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesUrl) ?
                _url! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesUrl, nameof(Url));
            internal set => _url = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsEmailVerified
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesIsEmailVerified) ?
                _isEmailVerified! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesIsEmailVerified, nameof(IsEmailVerified));
            internal set => _isEmailVerified = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool CanSeeNsfw
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCanSeeNsfw) ?
                _canSeeNsfw :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCanSeeNsfw, nameof(CanSeeNsfw));
            internal set => _canSeeNsfw = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool HidesPledges
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesHidePledges) ?
                _hidesPledges :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesHidePledges, nameof(HidesPledges));
            internal set => _hidesPledges = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime CreatedAt
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }
       
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string AvatarUrl
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAvatar) ?
                _avatarUrl! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatar, nameof(AvatarUrl));
            internal set => _avatarUrl = value;
        }
        
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string AvatarThumbnailUrl
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAvatarThumbnail) ?
                _avatarThumbnailUrl! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAvatarThumbnail, nameof(AvatarThumbnailUrl));
            internal set => _avatarThumbnailUrl = value;
        }
      
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public int LikeCount
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLikeCount) ?
                _likeCount :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLikeCount, nameof(LikeCount));
            internal set => _likeCount = value;
        }
       
        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public SocialConnections SocialConnections
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesSocialConnections) ?
                _socialConnections! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesSocialConnections, nameof(SocialConnections));
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
