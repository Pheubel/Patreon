using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class OAuthClient : IOAuthClient<TokenResponse, ScopeField>
    {
        public IncludeField IncludesFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string ClientSecret
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesClientSecret) ?
                _clientSecret :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesClientSecret, nameof(ClientSecret));
            internal set => _clientSecret = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Name
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesName) ?
                _name :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesName, nameof(Name));
            internal set => _name = value;
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
        public string AuthorName
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAuthorName) ?
                _authorName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAuthorName, nameof(AuthorName));
            internal set => _authorName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Domain
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesDomain) ?
                _domain :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDomain, nameof(Domain));
            internal set => _domain = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int Version
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesVersion) ?
                _version :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesVersion, nameof(Version));
            internal set => _version = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string IconUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesIconUrl) ?
                _iconUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIconUrl, nameof(IconUrl));
            internal set => _iconUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string PrivacyPolicyUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPrivacyPolicyUrl) ?
                _privacyPolicyUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPrivacyPolicyUrl, nameof(PrivacyPolicyUrl));
            internal set => _privacyPolicyUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string TosUrl
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTosUrl) ?
                _tosUrl :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTosUrl, nameof(TosUrl));
            internal set => _tosUrl = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public IReadOnlyCollection<string> RedirectUris
        {
            get => _redirectUris;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public TokenResponse CreatorToken
        {
            get => _creatorToken ?? throw new NotIncludedException();
            internal set => _creatorToken = value;
        }
        #endregion

        private string _clientSecret;
        private string _name;
        private string _description;
        private string _authorName;
        private string _domain;
        private int _version;
        private string _iconUrl;
        private string _privacyPolicyUrl;
        private string _tosUrl;
        private string[] _redirectUris;

        private User _user;
        private Campaign _campaign;
        private TokenResponse _creatorToken;

        /// <summary> Library exclusive contructor.</summary>
        internal OAuthClient() { }

        /// <summary> Sets the redirect urls of the client.</summary>
        internal void SetRedirectUrls(string[] urls) => _redirectUris = urls;

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesClientSecret = 1 << 0,
            IncludesName = 1 << 1,
            IncludesDescription = 1 << 2,
            IncludesAuthorName = 1 << 3,
            IncludesDomain = 1 << 4,
            IncludesVersion = 1 << 5,
            IncludesIconUrl = 1 << 6,
            IncludesPrivacyPolicyUrl = 1 << 7,
            IncludesTosUrl = 1 << 8,
            IncludesRedirectUris = 1 << 9,
        }
    }
}
