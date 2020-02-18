using Patreon.Api.V2.Builders;
using Patreon.Api.V2.Core;
using Patreon.Api.V2.Core.Builders;
using Patreon.Api.V2.Core.Resources;
using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Patreon.Api.V2
{
    public abstract class PatreonClient :
        ITokenClient<TokenResponse,ScopeField>,
        IIdentityClient<User,TokenResponse,ScopeField>
    {
        protected HttpClient HttpClient { get; }

        public PatreonClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(PatreonUtility.BaseUrl);
            HttpClient = httpClient;
        }

        public async Task<TokenResponse> ValidateTokenAsync(string code, string clientId, string clientSecret, string redirectUrl)
        {
            var parameters = new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("grant_type","authorization_code"),
                new KeyValuePair<string, string>("code",code),
                new KeyValuePair<string, string>("client_id",clientId),
                new KeyValuePair<string, string>("client_secret",clientSecret),
                new KeyValuePair<string, string>("redirect_url",redirectUrl)
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
    }
}
