using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    public interface IIdentityBuilder<TUser>
        where TUser : IUser
    {
        FormUrlEncodedContent BuildRequestContent();

        Task<TUser> BuildIdentityAsync(Stream userStream);
    }
}
