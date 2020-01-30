using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPledgeEvent<TEventType, TPaymentState> : IPatreonResource
    {
        /// <summary> The ISO code of the currency.</summary>
        string CurrencyCode { get; }
        /// <summary> The amount of cents pledged.</summary>
        int AmountCents { get; }
        /// <summary> The tier id associated with the pledge.</summary>
        string TierId { get; }
        /// <summary> The tier title assoiated with the pledge.</summary>
        string TierTitle { get; }
        /// <summary> The status of the pledge's payment.</summary>
        TPaymentState PaymentStatus { get; }
        /// <summary> The date on which the pledge occured.</summary>
        DateTime Date { get; }
        /// <summary> The type of the event.</summary>
        TEventType Type { get; }

        /// <summary> The pledging user</summary>
        User User { get; }
        /// <summary> The capaign being pledged to.</summary>
        Campaign Campaign { get; }
    }
}
