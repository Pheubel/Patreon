using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPledgeEvent<TEventType, TPaymentState> : IPatreonResource
    {
        string CurrencyCode { get; }
        int AmountCents { get; }
        string TierId { get; }
        string TierTitle { get; }
        TPaymentState PaymentStatus { get; }
        DateTime Date { get; }
        TEventType Type { get; }

        User User { get; }
        Campaign Campaign { get; }
    }
}
