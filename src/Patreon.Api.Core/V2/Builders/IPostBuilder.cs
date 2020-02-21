using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    public interface IPostBuilder<TPost>
        where TPost : IPost
    {
        FormUrlEncodedContent BuildRequestContent();
        Task<TPost> BuildPostAsync(Stream memberStream);
    }
}
