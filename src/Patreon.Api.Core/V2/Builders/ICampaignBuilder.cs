using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a campaign from a GET request.</summary>
    /// <typeparam name="TCampaign"> The campaign type the builder will produce.</typeparam>
    public interface ICampaignBuilder<TCampaign>
        where TCampaign : ICampaign
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds a campaign instance from a stream of campaign data.</summary>
        /// <param name="userStream"> The stream containing the campaign data.</param>
        /// <returns> Campaign instance from a stream of campaign data.</returns>
        Task<TCampaign> BuildCampaignAsync(Stream userStream);
    }
}
