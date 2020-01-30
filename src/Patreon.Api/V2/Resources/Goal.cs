using Patreon.Api.V2.Core.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Goal : IGoal
    {
        public IncludeField IncludedFields { get; private set; }
        public int AmountCents
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesAmountCents) ?
                _amountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAmountCents, nameof(AmountCents));
            internal set => _amountCents = value;
        }
        public string Title
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }
        public string Description
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDescription) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescription, nameof(Description));
            internal set => _description = value;
        }
        public DateTime CreatedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }
        public DateTime? ReachedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesReachedAt) ?
                _reachedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesReachedAt, nameof(ReachedAt));
            internal set => _reachedAt = value;
        }
        public byte CompletedPercentage
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCompletedPercentage) ?
                _completedPercentage :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCompletedPercentage, nameof(CompletedPercentage));
            internal set => _completedPercentage = value;
        }

        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        private int _amountCents;
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private DateTime? _reachedAt;
        private byte _completedPercentage;

        private Campaign _campaign;

        internal Goal() { }

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesAmountCents = 1 << 0,
            IncludesTitle = 1 << 1,
            IncludesDescription = 1 << 2,
            IncludesCreatedAt = 1 << 3,
            IncludesReachedAt = 1 << 4,
            IncludesCompletedPercentage = 1 << 5
        }
    }
}
