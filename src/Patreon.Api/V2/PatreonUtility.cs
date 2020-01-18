using System;

namespace Patreon.Api.V2
{
    public class PatreonUtility
    {
        public const string BaseUrl = "https://www.patreon.com/";

        public static Uri BuildAuthorizeUri(string clientId, string redirectUri, ScopeField scope = ScopeField.Identity, string stateToken = null) =>
            new Uri($"{BaseUrl}oauth2/authorize?response_type=code&client_id={clientId}&redirect_uri={redirectUri}&scope={ScopeUtility.ToScopeString(scope)}{(string.IsNullOrWhiteSpace(stateToken) ? string.Empty : $"&{stateToken}")}", UriKind.Absolute);

        public static Uri BuildAuthorizeUri(string clientId, Uri redirectUri, ScopeField scope = ScopeField.Identity, string stateToken = null) =>
            new Uri($"{BaseUrl}oauth2/authorize?response_type=code&client_id={clientId}&redirect_uri={redirectUri}&scope={ScopeUtility.ToScopeString(scope)}{(string.IsNullOrWhiteSpace(stateToken) ? string.Empty : $"&{stateToken}")}", UriKind.Absolute);
    }
}
