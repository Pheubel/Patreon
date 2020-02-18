using Patreon.Api.V2.Core.Resources;
using System.Net.Http;

namespace Patreon.Api.V2.Core.Builders
{
    public interface IIdentityBuilder<TUser>
        where TUser : IUser
    {
        string ApiEndpoint { get; }
        FormUrlEncodedContent BuildRequestContent();
        TUser BuildIdentity(string userString);
    }
}
