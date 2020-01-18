using System;

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
    }
}
