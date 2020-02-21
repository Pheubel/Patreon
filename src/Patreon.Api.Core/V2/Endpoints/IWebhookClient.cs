using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    public interface IWebhookClient<TWebhook, TToken>
        where TWebhook : IWebhook
        where TToken : ITokenResponse
    {
        Task<IReadOnlyCollection<TWebhook>> GetWebhooks(TToken token, IWebhookCollectionBuilder<TWebhook> builder);
        Task<TWebhook> PostWebhook(TToken token, TWebhook webhook);
        Task<TWebhook> PatchWebhook(TToken token, TWebhook webhook);
    }
}
