using Patreon.Api.Core.V2.Resources;
using System;

namespace Patreon.Api.V2.Resources.Socials
{
    public class DeviantArt : IAuthorizedApp<DeviantArt.Scope>
    {
        public string Id => throw new NotImplementedException();
        public string Url => throw new NotImplementedException();
        public Scope Scopes => throw new NotImplementedException();

        Enum IAuhorizedApp.Scopes => Scopes;

        [Flags]
        public enum Scope
        {

        }
    }
}
