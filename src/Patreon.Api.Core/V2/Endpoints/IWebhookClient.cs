using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    /// <summary> A patreon client which interacts with webhook endpoints.</summary>
    /// <typeparam name="TWebhook"> The webhook type the client will retrieve.</typeparam>
    /// <typeparam name="TToken"> The token type to be sent in the request for authorization.</typeparam>
    public interface IWebhookClient<TWebhook, TToken>
        where TWebhook : IWebhook
        where TToken : ITokenResponse
    {
        /// <summary> Retrieves a collection of webhooks from the patreon API.</summary>
        /// <param name="token"> The token used for autorization.</param>
        /// <param name="builder"> The builder used for forming the webhook collection.</param>
        /// <returns> Colletion of webhooks.</returns>
        Task<IReadOnlyCollection<TWebhook>> GetWebhooks(TToken token, IWebhookCollectionBuilder<TWebhook> builder);

        /// <summary> Adds webhook through the patreon API.</summary>
        /// <typeparam name="TWebhookData"> The webhook data type</typeparam>
        /// <param name="token"> The token used for autorization.</param>
        /// <param name="webhook"> The webhook data to add.</param>
        /// <returns> Newly created webhook.</returns>        
        Task<TWebhook> PostWebhook<TWebhookData>(TToken token, TWebhookData webhook) where TWebhookData : IWebhook;

        /// <summary> Changes the webhook through the patreon API.</summary>
        /// <typeparam name="TWebhookData"> The webhook data type</typeparam>
        /// <param name="token"> The token used for autorization.</param>
        /// <param name="webhook"> The webhook data to patch with.</param>
        /// <returns> Patched webhook.</returns>
        Task<TWebhook> PatchWebhook<TWebhookData>(TToken token, TWebhookData webhook) where TWebhookData : IWebhook;
    }
}
