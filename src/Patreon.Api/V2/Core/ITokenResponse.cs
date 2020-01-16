#nullable disable

using System;

namespace Patreon.Api.V2.Core
{
    public interface ITokenResponse<TScope>
        where TScope: struct, Enum
    {
        string AccessToken { get; }
        string RefreshToken { get; }
        DateTime ExpiresAt { get; }
        TScope Scope { get; }
    }
}
