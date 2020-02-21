using System;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endponts
{
    /// <summary> A patreon client that interacts with the authorization endpoints.</summary>
    /// <typeparam name="TToken"> The token type to use for authorization.</typeparam>
    public interface ITokenClient<TToken>
        where TToken : ITokenResponse
    {
        /// <summary> Sends a validation request to retrieve an authorization token from the patreon API.</summary>
        /// <param name="code"> The validation code to verify the token request.</param>
        /// <param name="clientId"> The API client id.</param>
        /// <param name="clientSecret"> The API client secret used for verifying the client's identity.</param>
        /// <param name="redirectUri"> The URI to redirect the client to.</param>
        /// <returns> A token used for autorization.</returns>
        Task<TToken> ValidateTokenAsync(string code, string clientId, string clientSecret, string redirectUri);

        /// <summary> Sends a validation request to retrieve an authorization token from the patreon API.</summary>
        /// <param name="code"> The validation code to verify the token request.</param>
        /// <param name="clientId"> The API client id.</param>
        /// <param name="clientSecret"> The API client secret for verifying the client's identity.</param>
        /// <param name="redirectUri"> The URI to redirect the client to.</param>
        /// <returns> A token used for autorization.</returns>
        Task<TToken> ValidateTokenAsync(string code, string clientId, string clientSecret, Uri redirectUri);

        /// <summary> Sends a refresh token request to the patreon authorization API.</summary>
        /// <param name="refreshToken"> The refresh token used to authenticate the refresh request.</param>
        /// <param name="clientId"> The API client id.</param>
        /// <param name="clientSecret"> The API client secret used for verifying the client's identity.</param>
        /// <returns> A token used for autorization.</returns>
        Task<TToken> RefreshTokenAsync(string refreshToken, string clientId, string clientSecret);
    }
}
