using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    public interface ICampaignClient<TCampaign, TMember, TPost, TToken>
        where TCampaign : ICampaign
        where TMember : IMember
        where TPost : IPost
        where TToken : ITokenResponse
    {
        Task<TCampaign> GetCampaignAsync(TToken token, int campaignId, ICampaignBuilder<TCampaign> builder);
        Task<IReadOnlyCollection<TMember>> GetCampaignMembersAsync(TToken token, int campaignId, IMemberCollectionBuilder<TMember> builder);
        Task<IReadOnlyCollection<TPost>> GetCampaignPostsAsync(TToken token, int campaignId, IPostCollectionBuilder<TPost> builder);
    }
}
