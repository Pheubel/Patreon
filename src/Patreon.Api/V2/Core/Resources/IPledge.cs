using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPledge<TPaymentType, TPaymentState> : IPatreonResource
    {
        string CurrencyCode { get; }
        int AmountCents { get; }
        string TierId { get; }
        string TierTitle { get; }
        TPaymentState PaymentStatus { get; }
        DateTime Date { get; }
        TPaymentType Type { get; }

        User User { get; }
        Campaign Campaign { get; }
    }
}
