using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IMember<TPatronState,TChargeState> : IPatreonResource
        where TPatronState : struct, Enum
        where TChargeState : struct, Enum
    {
        TPatronState PatronStatus { get; }
        bool IsFollower { get; }
        string FullName { get; }
        string Email { get; }
        DateTime? PledgeRelationshipStart { get; }
        int LifetimeSupportCents { get; }
        int CurrentlyEntitledAmountCents { get; }
        DateTime? LastChargeDate { get; }
        TChargeState LastChargeStatus { get; }
        string Note { get; }
        int WillPayAmountCents { get; }

        Address Address { get; }
        Campaign Campaign { get; }
        IReadOnlyCollection<Tier> EntitledTiers { get; }
        User User { get; }
        IReadOnlyCollection<Pledge> PledgeHistory { get; }
    }
}
