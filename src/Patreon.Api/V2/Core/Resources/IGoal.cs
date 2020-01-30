using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IGoal : IPatreonResource
    {
        int AmountCents { get; }
        string Title { get; }
        string Description { get; }
        DateTime CreatedAt { get; }
        DateTime? ReachedAt { get; }
        int CompletedPercentage { get; }

        Campaign Campaign { get; }
    }
}
