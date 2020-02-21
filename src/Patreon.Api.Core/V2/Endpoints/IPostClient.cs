using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    public interface IPostClient<TPost, TToken>
        where TPost : IPost
    {
        Task<TPost> GetPostAsync(TToken token, int postId, IPostBuilder<TPost> builder);
    }
}
