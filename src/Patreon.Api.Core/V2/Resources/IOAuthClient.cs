using System;
using System.Collections.Generic;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A container representing OAuth client data.</summary>
    public interface IOAuthClient : IPatreonResource<int>
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
        IUser User { get; }
        /// <summary> The campaign of the user who created the OAuth client/</summary>
        ICampaign Campaign { get; }
        /// <summary> The token of the user who created the client.</summary>
        ITokenResponse CreatorToken { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TAuthToken"> The token type to use to represent the authorization token.</typeparam>
    /// <typeparam name="TTokenScopes"> The type responsible for managing the token's scope.</typeparam>
    public interface IOAuthClient<TAuthToken, TTokenScopes> : IOAuthClient
        where TAuthToken : ITokenResponse<TTokenScopes>
        where TTokenScopes : struct, Enum
    {
        /// <summary> The token of the user who created the client.</summary>
        new TAuthToken CreatorToken { get; }
    }
}
