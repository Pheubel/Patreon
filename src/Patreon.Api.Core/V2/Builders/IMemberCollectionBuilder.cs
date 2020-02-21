using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a member collection from an API get request.</summary>
    /// <typeparam name="TMember"> The member type the builder will produce.</typeparam>
    public interface IMemberCollectionBuilder<TMember>
        where TMember : IMember
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds a member collection from a stream of campaign data.</summary>
        /// <param name="memberCollectionStream"> The stream containing the member collection data.</param>
        /// <returns> Member collection from a stream of campaign data.</returns>
        Task<IReadOnlyCollection<TMember>> BuildMemberCollectionAsync(Stream memberCollectionStream);
    }
}
