using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    public interface ICampaignBuilder<TCampaign>
        where TCampaign : ICampaign
    {
        FormUrlEncodedContent BuildRequestContent();

        Task<TCampaign> BuildCampaignAsync(Stream userStream);
    }
}
