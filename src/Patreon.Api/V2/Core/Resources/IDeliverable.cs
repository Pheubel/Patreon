using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IDeliverable : IPatreonResource
    {
        DateTime CompletedAt { get; }
        Deliverable.Status DeliveryStatus { get; }
        DateTime DueAt { get; }
    }
}
