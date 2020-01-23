using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources.Socials
{
    public class Discord : IAuthorizedApp<Discord.Scope>
    {
        public string Id => throw new NotImplementedException();

        public string Url => throw new NotImplementedException();

        public Scope Scopes => throw new NotImplementedException();

        [Flags]
        public enum Scope
        {

        }
    }
}
