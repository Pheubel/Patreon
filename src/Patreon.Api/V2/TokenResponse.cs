using Patreon.Api.Converters;
using Patreon.Api.V2.Core;
using System;
using System.Text.Json.Serialization;

namespace Patreon.Api.V2
{
    [JsonConverter(typeof(TokenResponseConverter))]
    public class TokenResponse : ITokenResponse<ScopeField>
    {
        public string AccessToken { get; internal set; }
        public string RefreshToken { get; internal set; }
        public DateTime ExpiresAt { get; internal set; }
        public ScopeField Scope { get; internal set; }
        public const string TokenType = "Bearer";
    }
}
