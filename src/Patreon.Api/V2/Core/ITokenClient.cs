using System;
using System.Threading.Tasks;

namespace Patreon.Api.V2.Core
{
    public interface ITokenClient<TToken,TScope>
        where TToken : ITokenResponse<TScope>
        where TScope : struct, Enum
    {
        Task<TToken> ValidateTokenAsync(string code, string clientId, string clientSecret, string redirectUrl);
        Task<TToken> RefreshTokenAsync(string refreshToken, string clientId, string clientSecret);
    }
}
