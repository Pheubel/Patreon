using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Endponts
{
    /// <summary> A patreon client which interacts with identity endpoints</summary>
    /// <typeparam name="TUser"> The user type the client will retrieve.</typeparam>
    /// <typeparam name="TCampaign"> The campaign type th client will retrieve.</typeparam>
    /// <typeparam name="TToken"> The token ype to be sent in the request for authorization.</typeparam>
    public interface IIdentityClient<TUser, TCampaign, TToken>
        where TUser : IUser
        where TCampaign : ICampaign
        where TToken : ITokenResponse
    {
        /// <summary> Retrieves the identity user from the pareon API.</summary>
        /// <param name="token"> The token used for autorization.</param>
        /// <param name="builder"> The builder used for forming the identity user.</param>
        /// <returns> The identity user.</returns>
        Task<TUser> GetIdentityAsync(TToken token, IIdentityBuilder<TUser> builder);

        /// <summary> Retrieves the identity user's campaign from the patreon API.</summary>
        /// <param name="token"> The token used for authentication.</param>
        /// <param name="builder"> The builder used for forming the campaign.</param>
        /// <returns> The identity user's campaign.</returns>
        Task<TCampaign> GetIdentityCampaignAsync(TToken token, ICampaignBuilder<TCampaign> builder);
    }
}
