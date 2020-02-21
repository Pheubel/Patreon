using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.Core.V2.Resources
{
    public interface IAuhorizedApp
    {
        string Id { get; }
        Enum Scopes { get; }
        string Url { get; }
    }

    public interface IAuthorizedApp<TScope> : IAuhorizedApp
        where TScope : struct, Enum
    {
        new TScope Scopes { get; }
    }
}
