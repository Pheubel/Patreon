using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IAddress : IPatreonResource
    {
        string Addressee { get; }
        string LineOne { get; }
        string LineTwo { get; }
        string PostalCode { get; }
        string City { get; }
        string State { get; }
        string Country { get; }
        string PhoneNumber { get; }
        DateTime CreatedAt { get; }

        User User { get; }
        IReadOnlyCollection<Campaign> Campaigns { get; }
    }
}
