using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IAddress : IPatreonResource<int>
    {
        /// <summary> The full recipient name.</summary>
        string Addressee { get; }
        /// <summary> The first line of the user's street address.</summary>
        string LineOne { get; }
        /// <summary> The second line of the user's street address.</summary>
        string LineTwo { get; }
        /// <summary> The postal or zip code of the user.</summary>
        string PostalCode { get; }
        /// <summary> The city the user resides in.</summary>
        string City { get; }
        /// <summary> The name of the state or province the user resides in.</summary>
        string State { get; }
        /// <summary> The country the user resides in.</summary>
        string Country { get; }
        /// <summary> The non US telephone address.</summary>
        string PhoneNumber { get; }
        /// <summary> The moment the address record was created.</summary>
        DateTime CreatedAt { get; }

        /// <summary> The user the address record belongs to.</summary>
        User User { get; }
        /// <summary> The campaigns that have access to this record.</summary>
        IReadOnlyCollection<Campaign> Campaigns { get; }
    }
}
