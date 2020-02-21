using System;

namespace Patreon.Api.Core.V2.Resources.Socials
{
    public class Youtube : IAuthorizedApp<Youtube.Scope>
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
