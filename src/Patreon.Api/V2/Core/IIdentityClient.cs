using Patreon.Api.V2.Core.Builders;
using Patreon.Api.V2.Core.Resources;
using System;
using System.Threading.Tasks;

namespace Patreon.Api.V2.Core
{
    public interface IIdentityClient<TUser,TToken,TTokenScope>
        where TUser : IUser
        where TToken : ITokenResponse<TTokenScope>
        where TTokenScope : struct, Enum
    {
        Task<TUser> GetIdentityAsync(TToken token, IIdentityBuilder<TUser> builder);
    }
}
