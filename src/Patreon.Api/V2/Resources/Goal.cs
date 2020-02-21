using Patreon.Api.Core.V2.Resources;
using System;

namespace Patreon.Api.V2.Resources
{
    public class Goal : IGoal
    {
        public int Id { get; internal set; }
        public IncludeField IncludedFields { get; private set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int AmountCents
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesAmountCents) ?
                _amountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAmountCents, nameof(AmountCents));
            internal set => _amountCents = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Title
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Description
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesDescription) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescription, nameof(Description));
            internal set => _description = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime CreatedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? ReachedAt
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesReachedAt) ?
                _reachedAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesReachedAt, nameof(ReachedAt));
            internal set => _reachedAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int CompletedPercentage
        {
            get => IncludedFields.HasFlag(IncludeField.IncludesCompletedPercentage) ?
                _completedPercentage :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCompletedPercentage, nameof(CompletedPercentage));
            internal set => _completedPercentage = value;
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
        #endregion

        private int _amountCents;
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private DateTime? _reachedAt;
        private int _completedPercentage;

        private Campaign _campaign;

        /// <summary> Library restricted constructor.</summary>
        internal Goal() { }

        string IPatreonResource.Id => Id.ToString();

        ICampaign IGoal.Campaign => Campaign;

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
