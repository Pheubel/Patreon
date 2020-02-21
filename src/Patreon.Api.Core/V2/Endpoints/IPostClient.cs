using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    /// <summary> A patreon client which interacts with post endpoints.</summary>
    /// <typeparam name="TPost"> The post type the client will retrieve.</typeparam>
    /// <typeparam name="TToken"> The token type to be sent in the request for authorization.</typeparam>
    public interface IPostClient<TPost, TToken>
        where TPost : IPost
    {
        /// <summary> Retrieves a post from the patreon API.</summary>
        /// <param name="token"> The token used for autorization.</param>
        /// <param name="postId"> The post to retrieve.</param>
        /// <param name="builder"> The builder used for forming the identity user.</param>
        /// <returns> A post.</returns>
        Task<TPost> GetPostAsync(TToken token, int postId, IPostBuilder<TPost> builder);
    }
}
