using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    public interface IPostCollectionBuilder<TPost>
        where TPost : IPost
    {
        FormUrlEncodedContent BuildRequestContent();
        Task<IReadOnlyCollection<TPost>> BuildPostCollectionAsync(Stream memberCollectionStream);
    }
}
