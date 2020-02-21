using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endpoints
{
    /// <summary> A patreon client which interacts with campaign endpoints.</summary>
    /// <typeparam name="TCampaign"> The campaign type the client will retrieve.</typeparam>
    /// <typeparam name="TMember"> The member type the client will retrieve.</typeparam>
    /// <typeparam name="TPost"> The post type the client will retrieve.</typeparam>
    /// <typeparam name="TToken"> The token type to be sent in the request for authorization.</typeparam>
    public interface ICampaignClient<TCampaign, TMember, TPost, TToken>
        where TCampaign : ICampaign
        where TMember : IMember
        where TPost : IPost
        where TToken : ITokenResponse
    {
        /// <summary> Retrieves a campaign from the patreon API.</summary>
        /// <param name="token"></param>
        /// <param name="campaignId"> The campaign to retrieve.</param>
        /// <param name="builder"> The builder used for forming the campaign.</param>
        /// <returns> A campaign from the patreon API.</returns>
        Task<TCampaign> GetCampaignAsync(TToken token, int campaignId, ICampaignBuilder<TCampaign> builder);

        /// <summary> Retrieves a collection of members of a campaign from the patreon API.</summary>
        /// <param name="token"></param>
        /// <param name="campaignId"> The campaign to retrieve members from.</param>
        /// <param name="builder"> The builder used for forming the campaign members.</param>
        /// <returns> A collection of members of a campaign.</returns>
        Task<IReadOnlyCollection<TMember>> GetCampaignMembersAsync(TToken token, int campaignId, IMemberCollectionBuilder<TMember> builder);

        /// <summary> Retrieves a collection of posts of a campaign from the patreon API.</summary>
        /// <param name="token"> The token used for authentication.</param>
        /// <param name="campaignId"> The campaign to retrieve members from.</param>
        /// <param name="builder"> The builder used for forming the campaign posts.</param>
        /// <returns> A collection of posts of a campaign.</returns>
        Task<IReadOnlyCollection<TPost>> GetCampaignPostsAsync(TToken token, int campaignId, IPostCollectionBuilder<TPost> builder);
    }
}
