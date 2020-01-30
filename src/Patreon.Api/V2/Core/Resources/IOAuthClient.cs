using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IOAuthClient<TAuthToken, TTokenScopes> : IPatreonResource
        where TAuthToken : ITokenResponse<TTokenScopes>
        where TTokenScopes : struct, Enum
    {
        /// <summary> The client's secret.</summary>
        string ClientSecret { get; }
        /// <summary> The name provided during client setup.</summary>
        string Name { get; }
        /// <summary> The description provided during client setup.</summary>
        string Description { get; }
        /// <summary> The author name provided during client setup.</summary>
        string AuthorName { get; }
        /// <summary> The domain provided during client setup.</summary>
        string Domain { get; }
        /// <summary> The patreon API version the client is using.</summary>
        int Version { get; }
        /// <summary> The URL of the icon used in the OAuth authorization flow.</summary>
        string IconUrl { get; }
        /// <summary> The URL of the privacy policy provided during client setup.</summary>
        string PrivacyPolicyUrl { get; }
        /// <summary> The uRl of the terms of service provided during client setup.</summary>
        string TosUrl { get; }
        /// <summary> The allowable redirect URIs for the OAuth authorization flow.</summary>
        IReadOnlyCollection<string> RedirectUris { get; }

        /// <summary> The user who created the OAuth client.</summary>
        User User { get; }
        /// <summary> The campaign of the user who created the OAuth client/</summary>
        Campaign Campaign { get; }
        /// <summary> The token of the user who created the client.</summary>
        TAuthToken CreatorToken { get; }
    }
}
