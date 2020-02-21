using System;
using System.Collections.Generic;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A container representing a campaign member data.</summary>
    public interface IMember : IPatreonResource<Guid>
    {
        /// <summary> The status of the patron.</summary>
        Enum PatronStatus { get; }
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
        Enum LastChargeStatus { get; }
        /// <summary> The creator's not on the member.</summary>
        string Note { get; }
        /// <summary> The amount in cents hte user will pay at the next pay cycle.</summary>
        int WillPayAmountCents { get; }

        /// <summary> The member's shipping address that they entered fo rthe campaign.</summary>
        IAddress Address { get; }
        /// <summary> The campaign that the membership is for.</summary>
        ICampaign Campaign { get; }
        /// <summary> The tiers that the member is entitled to.</summary>
        IReadOnlyCollection<ITier> EntitledTiers { get; }
        /// <summary> The use who is pledging to the campaign.</summary>
        IUser User { get; }
        /// <summary> The pledge history of the member.</summary>
        IReadOnlyCollection<IPledgeEvent> PledgeHistory { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TPatronState"> The type to use for managing the patron's state.</typeparam>
    /// <typeparam name="TChargeState"> The type to use for managing the charge state.</typeparam>
    public interface IMember<TPatronState, TChargeState> : IMember
        where TPatronState : struct, Enum
        where TChargeState : struct, Enum
    {
        /// <summary> The status of the patron.</summary>
        new TPatronState PatronStatus { get; }
        /// <summary> The result of the last attempted charge.</summary>
        new TChargeState LastChargeStatus { get; }
    }
}
