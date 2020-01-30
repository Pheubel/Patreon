using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IOAuthClient<TAuthToken, TTokenScopes> : IPatreonResource
        where TAuthToken : ITokenResponse<TTokenScopes>
        where TTokenScopes : struct, Enum
    {
        string ClientSecret { get; }
        string Name { get; }
        string Description { get; }
        string AuthorName { get; }
        string Domain { get; }
        int Version { get; }
        string IconUrl { get; }
        string PrivacyPolicyUrl { get; }
        string TosUrl { get; }
        IReadOnlyCollection<string> RedirectUris { get; }
        
        User User { get; }
        Campaign Campaign { get; }
        TAuthToken CreatorToken { get; }
    }
}
