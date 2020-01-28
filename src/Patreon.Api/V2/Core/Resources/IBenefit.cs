using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IBenefit : IPatreonResource
    {
        string Title { get; }
        string Description { get; }
        string BenefitType {get;}
        string RuleType { get; }
        DateTime CreatedAt { get; }
        int DeliveredDeliverablesCount { get; }
        int NotDeliveredDeliverablesCount { get; }
        DateTime? NextDeliverableDueDate { get; }
        int TiersCount { get; }
        bool IsDeleted { get; }
        bool IsPublished { get; }
        bool IsEnded { get; }
        string AppExternalId { get; }
        string AppMeta { get; }
        IReadOnlyCollection<Tier> Tiers { get; }
        IReadOnlyCollection<Deliverable> Deliverables { get; }
        Campaign Campaign { get; }
    }
}
