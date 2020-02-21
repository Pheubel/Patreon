using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Endponts;
using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Patreon.Api.V2
{
    public abstract class PatreonClient :
        ITokenClient<TokenResponse>,
        IIdentityClient<User, Campaign, TokenResponse>
    {
        protected HttpClient HttpClient { get; }

        public PatreonClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(PatreonUtility.BaseUrl);
            HttpClient = httpClient;
        }

        public async Task<TokenResponse> ValidateTokenAsync(string code, string clientId, string clientSecret, string redirectUrl) =>
            await ValidateTokenAsync(code, clientId, clientSecret, new Uri(redirectUrl));

        public async Task<TokenResponse> ValidateTokenAsync(string code, string clientId, string clientSecret, Uri redirectUri)
        {
            var parameters = new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("grant_type","authorization_code"),
                new KeyValuePair<string, string>("code",code),
                new KeyValuePair<string, string>("client_id",clientId),
                new KeyValuePair<string, string>("client_secret",clientSecret),
                new KeyValuePair<string, string>("redirect_uri",redirectUri.AbsoluteUri)
            };

            var formContent = new FormUrlEncodedContent(parameters);
            var request = new HttpRequestMessage(HttpMethod.Post, "api/oauth2/token")
            {
                Content = formContent
            };

            HttpResponseMessage responseMessage = default;

            try
            {
                responseMessage = await HttpClient.SendAsync(request);
                responseMessage.EnsureSuccessStatusCode();
            }
            catch
            {
                formContent.Dispose();
                request.Dispose();
                responseMessage?.Dispose();

                throw;
            }
            formContent.Dispose();
            request.Dispose();

            var token = JsonSerializer.Deserialize<TokenResponse>(await responseMessage.Content.ReadAsStringAsync());

            responseMessage.Dispose();

            return token;
        }

        public async Task<TokenResponse> RefreshTokenAsync(string refreshToken, string clientId, string clientSecret)
        {
            var parameters = new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("grant_type","refresh_token"),
                new KeyValuePair<string, string>("refresh_token",refreshToken),
                new KeyValuePair<string, string>("client_id",clientId),
                new KeyValuePair<string, string>("client_secret",clientSecret)
            };

            var formContent = new FormUrlEncodedContent(parameters);
            var request = new HttpRequestMessage(HttpMethod.Post, "api/oauth2/token")
            {
                Content = formContent
            };

            HttpResponseMessage responseMessage = default;

            try
            {
                responseMessage = await HttpClient.SendAsync(request);
                responseMessage.EnsureSuccessStatusCode();
            }
            catch
            {
                formContent.Dispose();
                request.Dispose();
                responseMessage?.Dispose();

                throw;
            }
            formContent.Dispose();
            request.Dispose();

            var token = JsonSerializer.Deserialize<TokenResponse>(await responseMessage.Content.ReadAsStringAsync());

            responseMessage.Dispose();

            return token;
        }

        public async Task<User> GetIdentityAsync(TokenResponse token, IIdentityBuilder<User> builder)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            HttpResponseMessage response = default;
            HttpRequestMessage request = default;
            try
            {
                request = new HttpRequestMessage(HttpMethod.Get, "api/oauth2/v2/identity");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);

                response = await HttpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                request.Dispose();
            }
            catch
            {
                request?.Dispose();
                response?.Dispose();

                throw;
            }

            var userStream = await response.Content.ReadAsStreamAsync();
            var user = await builder.BuildIdentityAsync(userStream);

            response.Dispose();
            userStream?.Dispose();

            return user;
        }

        public async Task<Campaign> GetIdentityCampaignAsync(TokenResponse token, ICampaignBuilder<Campaign> builder)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (!token.Scope.HasFlag(ScopeField.Campaigns))
                throw new Exception("Token does not allow access to the user's campaign.");

            HttpResponseMessage response = default;
            HttpRequestMessage request = default;
            try
            {
                request = new HttpRequestMessage(HttpMethod.Get, "api/oauth2/v2/campaigns");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);

                response = await HttpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                request.Dispose();
            }
            catch
            {
                request?.Dispose();
                response?.Dispose();

                throw;
            }

            var campaignStream = await response.Content.ReadAsStreamAsync();
            var campaign = await builder.BuildCampaignAsync(campaignStream);

            response.Dispose();
            campaignStream?.Dispose();

            return campaign;
        }


    }
}
