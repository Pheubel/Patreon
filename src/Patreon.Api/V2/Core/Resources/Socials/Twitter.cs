﻿using System;

namespace Patreon.Api.V2.Core.Resources.Socials
{
    public class Twitter : IAuthorizedApp<Twitter.Scope>
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