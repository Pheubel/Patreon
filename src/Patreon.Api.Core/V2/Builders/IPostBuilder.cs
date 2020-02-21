using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a post from a GET request.</summary>
    /// <typeparam name="TPost"> The post type the builder will produce.</typeparam>
    public interface IPostBuilder<TPost>
        where TPost : IPost
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds a post instance from a stream of post data.</summary>
        /// <param name="postStream"> The stream containing the post data.</param>
        /// <returns> Post instance from a stream of post data.</returns>
        Task<TPost> BuildPostAsync(Stream postStream);
    }
}
