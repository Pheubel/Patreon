using Patreon.Api.Core.V2.Builders;
using Patreon.Api.Core.V2.Resources;
using System;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Api
{
    public interface IIdentityClient<TUser, TCampaign, TToken,TTokenScope>
        where TUser : IUser
        where TCampaign : ICampaign
        where TToken : ITokenResponse<TTokenScope>
        where TTokenScope : struct, Enum
    {
        Task<TUser> GetIdentityAsync(TToken token, IIdentityBuilder<TUser> builder);
        Task<TCampaign> GetIdentityCampaignAsync(TToken token, ICampaignBuilder<TCampaign> builder);
    }
}
