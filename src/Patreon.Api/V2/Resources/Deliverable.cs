using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Deliverable : IDeliverable<Deliverable.Status>
    {
        public IncludeField IncludedFields { get; internal set; }
        public DateTime? CompletedAt
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
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }
        public Benefit Benefit
        {
            get => _benefit ?? throw new NotIncludedException();
            internal set => _benefit = value;
        }
        public Member Member
        {
            get => _member ?? throw new NotIncludedException();
            internal set => _member = value;
        }
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }

        private DateTime? _completedAt;
        private Status _deliveryStatus;
        private DateTime _dueAt;

        private Campaign _campaign;
        private Benefit _benefit;
        private Member _member;
        private User _user;

        internal Deliverable() { }

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
