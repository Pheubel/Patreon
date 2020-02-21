using Patreon.Api.Core.V2.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Deliverable : IDeliverable<Deliverable.Status>
    {
        public int Id { get; internal set; }
        public IncludeField IncludedFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? CompletedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCompletedAt) ?
                _completedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCompletedAt, nameof(CompletedAt));
            internal set => _completedAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public Status DeliveryStatus
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDeliveryStatus) ?
                _deliveryStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDeliveryStatus, nameof(DeliveryStatus));
            internal set => _deliveryStatus = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime DueAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDueAt) ?
                _dueAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDueAt, nameof(DueAt));
            internal set => _dueAt = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Benefit Benefit
        {
            get => _benefit ?? throw new NotIncludedException();
            internal set => _benefit = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Member Member
        {
            get => _member ?? throw new NotIncludedException();
            internal set => _member = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }
        #endregion

        private DateTime? _completedAt;
        private Status _deliveryStatus;
        private DateTime _dueAt;

        private Campaign _campaign;
        private Benefit _benefit;
        private Member _member;
        private User _user;

        /// <summary> Library restricted construcor.</summary>
        internal Deliverable() { }

        string IPatreonResource.IdString => Id.ToString();

        Enum IDeliverable.DeliveryStatusValue => DeliveryStatus;
        ICampaign IDeliverable.Campaign => Campaign;
        IBenefit IDeliverable.Benefit => Benefit;
        IMember IDeliverable.Member => Member;
        IUser IDeliverable.User => User;

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
