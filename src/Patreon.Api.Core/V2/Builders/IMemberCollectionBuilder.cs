using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    public interface IMemberCollectionBuilder<TMember>
        where TMember : IMember
    {
        FormUrlEncodedContent BuildRequestContent();
        Task<IReadOnlyCollection<TMember>> BuildMemberCollectionAsync(Stream memberCollectionStream);
    }
}
