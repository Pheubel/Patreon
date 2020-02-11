using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IMember<TPatronState,TChargeState> : IPatreonResource<Guid>
        where TPatronState : struct, Enum
        where TChargeState : struct, Enum
    {
        /// <summary> The status of the patron.</summary>
        TPatronState PatronStatus { get; }
        /// <summary> Determines if the user has subscribed to updates about public posts.</summary>
        bool IsFollower { get; }
        /// <summary> The full name of the member.</summary>
        string FullName { get; }
        /// <summary> The email address of the member.</summary>
        string Email { get; }
        /// <summary> When the member started to pledge to the campaign.</summary>
        DateTime? PledgeRelationshipStart { get; }
        /// <summary> The total amount that the member has ever paid to the campaign.</summary>
        int LifetimeSupportCents { get; }
        /// <summary> The amount in cents that the member is entitled to.</summary>
        int CurrentlyEntitledAmountCents { get; }
        /// <summary> When the last attempted charge was.</summary>
        DateTime? LastChargeDate { get; }
        /// <summary> The result of the last attempted charge.</summary>
        TChargeState LastChargeStatus { get; }
        /// <summary> The creator's not on the member.</summary>
        string Note { get; }
        /// <summary> The amount in cents hte user will pay at the next pay cycle.</summary>
        int WillPayAmountCents { get; }

        /// <summary> The member's shipping address that they entered fo rthe campaign.</summary>
        Address Address { get; }
        /// <summary> The campaign that the membership is for.</summary>
        Campaign Campaign { get; }
        /// <summary> The tiers that the member is entitled to.</summary>
        IReadOnlyCollection<Tier> EntitledTiers { get; }
        /// <summary> The use who is pledging to the campaign.</summary>
        User User { get; }
        /// <summary> The pledge history of the member.</summary>
        IReadOnlyCollection<PledgeEvent> PledgeHistory { get; }
    }
}
