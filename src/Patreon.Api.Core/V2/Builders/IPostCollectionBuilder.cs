using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a post collection from an API get request.</summary>
    /// <typeparam name="TPost"> The post type the builder will produce.</typeparam>
    public interface IPostCollectionBuilder<TPost>
        where TPost : IPost
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds a post collection from a stream of campaign data.</summary>
        /// <param name="postCollectionStream"> The stream containing the post collection data.</param>
        /// <returns> Post collection from a stream of campaign data.</returns>
        Task<IReadOnlyCollection<TPost>> BuildPostCollectionAsync(Stream postCollectionStream);
    }
}
