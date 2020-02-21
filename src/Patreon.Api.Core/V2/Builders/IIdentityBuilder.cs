using Patreon.Api.Core.V2.Resources;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Patreon.Api.Core.V2.Builders
{
    /// <summary> A mechanism to construct a identity user from a GET request.</summary>
    /// <typeparam name="TUser"> The user type the builder will produce.</typeparam>
    public interface IIdentityBuilder<TUser>
        where TUser : IUser
    {
        /// <summary> Builds a <see cref="FormUrlEncodedContent"/> for use in a GET request.</summary>
        /// <returns> A <see cref="FormUrlEncodedContent"/> containing info on what to include in the request.</returns>
        FormUrlEncodedContent BuildRequestContent();

        /// <summary> Builds an identity user instance from a stream of campaign data.</summary>
        /// <param name="userStream"> The stream containing the campaign data.</param>
        /// <returns> identity user instance from a stream of campaign data.</returns>
        Task<TUser> BuildIdentityAsync(Stream userStream);
    }
}
