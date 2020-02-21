using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a webhook collection from an API get request.</summary>
    /// <typeparam name="TWebhook"> The webhook type the builder will produce.</typeparam>
    public interface IWebhookCollectionBuilder<TWebhook>
        where TWebhook : IWebhook
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds a webhook collection from a stream of campaign data.</summary>
        /// <param name="webhookCollectionStream"> The stream containing the webhook collection data.</param>
        /// <returns> Webhook collection from a stream of campaign data.</returns>
        Task<IReadOnlyCollection<TWebhook>> BuildWebhookCollectionAsync(Stream webhookCollectionStream);
    }
}
