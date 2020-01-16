using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Deliverable : IDeliverable
    {
        public IncludeField IncludedFields { get; internal set; }
        public DateTime CompletedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCompletedAt) ?
                _completedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCompletedAt, nameof(CompletedAt));
            internal set => _completedAt = value;
        }
        public Status DeliveryStatus
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDeliveryStatus) ?
                _deliveryStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDeliveryStatus, nameof(DeliveryStatus));
            internal set => _deliveryStatus = value;
        }
        public DateTime DueAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDueAt) ?
                _dueAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDueAt, nameof(DueAt));
            internal set => _dueAt = value;
        }

        private DateTime _completedAt;
        private Status _deliveryStatus;
        private DateTime _dueAt;

        public enum Status : byte
        {
            Delivered,
            NotDelivered,
            WontDeliver
        }

        [Flags]
        public enum IncludeField : byte
        {
            None = 0,
            IncludesCompletedAt = 1 << 0,
            IncludesDeliveryStatus = 1 << 1,
            IncludesDueAt = 1 << 2
        }
    }
}
