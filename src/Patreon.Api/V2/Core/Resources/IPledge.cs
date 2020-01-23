﻿using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IPledge<TPaymentType, TPaymentState>
    {
        string CurrencyCode { get; }
        int AmountCents { get; }
        string TierId { get; }
        string TierTitle { get; }
        Pledge.PaymentState PaymentStatus { get; }
        DateTime Date { get; }
        Pledge.PaymentType Type { get; }
    }
}