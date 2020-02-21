using System;

namespace Patreon.Api.Core.V2
{
    /// <summary> A container for an API token's data used for authentication.</summary>
    public interface ITokenResponse
    {
        /// <summary> The access token used to authenticate a request.</summary>
        string AccessToken { get; }
        /// <summary> The refresh token used to authenticate a refresh request.</summary>
        string RefreshToken { get; }
        /// <summary> The expiration date of the token.</summary>
        DateTime ExpiresAt { get; }
        /// <summary> The scopes the token grants access to.</summary>
        Enum Scope { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TScope"> The type to manage the token's scope type.</typeparam>
    public interface ITokenResponse<TScope> : ITokenResponse
        where TScope : struct, Enum
    {
        /// <summary> The scopes the token grants access to.</summary>
        new TScope Scope { get; }
    }
}
