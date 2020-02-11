using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class PledgeEvent : IPledgeEvent<PledgeEvent.PledgeType, PledgeEvent.PaymentState>
    {
        public long Id { get; internal set; }

        #region FIELDS 
        /// <inheritdoc/>
        public string CurrencyCode { get; internal set; }

        /// <inheritdoc/>
        public int AmountCents {get; internal set;}

        /// <inheritdoc/>
        public string TierId {get; internal set;}

        /// <inheritdoc/>
        public string TierTitle {get; internal set;}

        /// <inheritdoc/>
        public PaymentState PaymentStatus {get; internal set;}

        /// <inheritdoc/>
        public DateTime Date {get; internal set;}

        /// <inheritdoc/>
        public PledgeType Type {get; internal set;}
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        public User User { get; internal set; }

        /// <inheritdoc/>
        public Campaign Campaign { get; internal set; }
        #endregion

        internal PledgeEvent() { }

        string IPatreonResource.IdString => Id.ToString();

        public enum PledgeType
        {
            PledgeStart,
            PledgeUpgrade,
            PledgeDowngrade,
            PledgeDelete,
            Subscription
        }
        public enum PaymentState
        {
            Paid,
            Declined,
            Deleted,
            Pending,
            Refunded,
            Fraud,
            Other
        }
    }
}
