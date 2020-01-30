using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IDeliverable<TStatus> : IPatreonResource
        where TStatus : struct, Enum
    {
        DateTime? CompletedAt { get; }
        TStatus DeliveryStatus { get; }
        DateTime DueAt { get; }

        Campaign Campaign { get; }
        Benefit Benefit { get; }
        Member Member { get; }
        User User { get; }
    }
}
