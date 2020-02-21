using System;

namespace Patreon.Api.Core.V2
{
    public interface ITokenResponse
    {
        string AccessToken { get; }
        string RefreshToken { get; }
        DateTime ExpiresAt { get; }
        Enum Scopevalue { get; }
    }

    public interface ITokenResponse<TScope> : ITokenResponse
        where TScope: struct, Enum
    {
        TScope Scope { get; }
    }
}
