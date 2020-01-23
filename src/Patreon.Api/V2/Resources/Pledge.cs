using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Pledge : IPledge<Pledge.PaymentType, Pledge.PaymentState>
    {
        public IncludeField IncludesFields { get; internal set; }
        public PaymentType Type 
        { 
            get => IncludesFields.HasFlag(IncludeField.IncludesType) ?
                _type :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesType, nameof(Type));
            internal set => _type = value; 
        }
        public DateTime Date 
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesDate) ?
                _date :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDate, nameof(Date));
            internal set => _date = value; 
        }
        public PaymentState PaymentStatus 
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPaymentStatus) ?
                _paymentStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPaymentStatus, nameof(PaymentStatus));
            internal set => _paymentStatus = value;
        }
        public string TierTitle 
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesTierTitle) ?
                _tierTitle :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTierTitle, nameof(TierTitle)); 
            internal set => _tierTitle = value;
        }
        public string TierId 
        {
            get =>IncludesFields.HasFlag(IncludeField.IncludesTierId) ?
                _tierId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTierId, nameof(TierId)); 
            internal set => _tierId = value;
        }
        public int AmountCents 
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesAmountCents) ?
                _amountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAmountCents, nameof(AmountCents));
            internal set => _amountCents = value; 
        }
        public string CurrencyCode 
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesCurrencyCode) ?
                _currencyCode :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCurrencyCode, nameof(CurrencyCode)); 
            internal set => _currencyCode = value;
        }

        PaymentType _type;
        DateTime _date;
        PaymentState _paymentStatus;
        string _tierTitle;
        string _tierId;
        int _amountCents;
        string _currencyCode;

        public enum PaymentType
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

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesType = 1 << 0,
            IncludesDate = 1 << 1,
            IncludesPaymentStatus = 1 << 2,
            IncludesTierTitle = 1 << 3,
            IncludesTierId = 1 << 4,
            IncludesAmountCents = 1 << 5,
            IncludesCurrencyCode = 1 << 6
        }
    }
}
