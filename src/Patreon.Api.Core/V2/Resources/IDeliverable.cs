using System;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A container representing data of a campaign's deliverable.</summary>
    public interface IDeliverable : IPatreonResource<int>
    {
        /// <summary> When the creator marked the diliverable as completed or fulfulled to the patron.</summary>
        DateTime? CompletedAt { get; }
        /// <summary> The current status of the deliverable.</summary>
        Enum DeliveryStatus { get; }
        /// <summary> When the deliverable is due to the patron.</summary>
        DateTime DueAt { get; }

        /// <summary> The campaign the deliverable belongs to.</summary>
        ICampaign Campaign { get; }
        /// <summary> The benefit the deliverable belongs to.</summary>
        IBenefit Benefit { get; }
        /// <summary> The member who has been granted the deliverable.</summary>
        IMember Member { get; }
        /// <summary> The user who has been granted the deliverable.</summary>
        IUser User { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TStatus"> The type to use for managing the delivery status.</typeparam>
    public interface IDeliverable<TStatus> : IDeliverable
        where TStatus : struct, Enum
    {
        /// <summary> The current status of the deliverable.</summary>
        new TStatus DeliveryStatus { get; }
    }
}
