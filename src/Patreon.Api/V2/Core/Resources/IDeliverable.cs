using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IDeliverable<TStatus> : IPatreonResource<int>
        where TStatus : struct, Enum
    {
        /// <summary> When the creator marked the diliverable as completed or fulfulled to the patron.</summary>
        DateTime? CompletedAt { get; }
        /// <summary> The current status of the deliverable.</summary>
        TStatus DeliveryStatus { get; }
        /// <summary> When the deliverable is due to the patron.</summary>
        DateTime DueAt { get; }

        /// <summary> The campaign the deliverable belongs to.</summary>
        Campaign Campaign { get; }
        /// <summary> The benefit the deliverable belongs to.</summary>
        Benefit Benefit { get; }
        /// <summary> The member who has been granted the deliverable.</summary>
        Member Member { get; }
        /// <summary> The user who has been granted the deliverable.</summary>
        User User { get; }
    }
}
