using System;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> Resembles an application that can give authorization to patreon through scopes.</summary>
    public interface IAuhorizedApp
    {
        /// <summary> The string representation of the identifier of the application user.</summary>
        string Id { get; }
        /// <summary> The scopes that the app has granted to patreon.</summary>
        Enum Scopes { get; }
        /// <summary> The URL leading to the application granting autorization to patreon.</summary>
        string Url { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TScope"> The scope type to use to maintain app scopes.</typeparam>
    public interface IAuthorizedApp<TScope> : IAuhorizedApp
        where TScope : struct, Enum
    {
        /// <summary> The scopes that the app has granted to patreon.</summary>
        new TScope Scopes { get; }
    }
}
