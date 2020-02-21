using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.Core.V2.Resources
{
    public interface IAuthorizedApp<TScope>
        where TScope : struct, Enum
    {
        string Id { get; }
        TScope Scopes { get; }
        string Url { get; }
    }
}
