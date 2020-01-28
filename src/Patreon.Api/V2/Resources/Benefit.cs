using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Benefit : IBenefit
    {
        public IncludeField IncludeFields { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string Title
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesTitle) ?
                _title :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string Description
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDescripion) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescripion, nameof(Description));
            internal set => _description = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string BenefitType
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesBenefitType) ?
                _benefitType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesBenefitType, nameof(BenefitType));
            internal set => _benefitType = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string RuleType
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRuleType) ?
                _ruleType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRuleType, nameof(RuleType));
            internal set => _ruleType = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public DateTime CreatedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public int DeliveredDeliverablesCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDeliveredDeliverableCount) ?
                _deliveredDeliverablesCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDeliveredDeliverableCount, nameof(DeliveredDeliverablesCount));
            internal set => _deliveredDeliverablesCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public int NotDeliveredDeliverablesCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesNotDeliveredDeliverablesCount) ?
                _notDeliveredDeliverablesCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNotDeliveredDeliverablesCount, nameof(NotDeliveredDeliverablesCount));
            internal set => _notDeliveredDeliverablesCount = value;
        }

        ///  <inheritdoc/>
        ///  <exception cref="NotIncludedException{IncludeField}" />
        public int DeliverablesDueTodayCount 
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDeliverablesdueTodayCount) ?
                _deliverablesDueTodayCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDeliverablesdueTodayCount, nameof(DeliverablesDueTodayCount));
            internal set => _deliverablesDueTodayCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public DateTime? NextDeliverableDueDate
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesNextDeliverableDueDate) ?
                _nextDeliverableDueDate :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNextDeliverableDueDate, nameof(NextDeliverableDueDate));
            internal set => _nextDeliverableDueDate = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public int TiersCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesTiersCount) ?
                _tiersCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTiersCount, nameof(TiersCount));
            internal set => _tiersCount = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public bool IsDeleted
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsDeleted) ?
                _isDeleted :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsDeleted, nameof(IsDeleted));
            internal set => _isDeleted = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public bool IsPublished
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsPublished) ?
                _isPublished :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsPublished, nameof(IsPublished));
            internal set => _isPublished = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}" />
        public bool IsEnded
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsEnded) ?
                _isEnded :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsEnded, nameof(IsEnded));
            internal set => _isEnded = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string AppExternalId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesAppExternalId) ?
                _appExternalId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppExternalId, nameof(AppExternalId));
            internal set => _appExternalId = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string AppMeta
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesAppMeta) ?
                _appMeta :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppMeta, nameof(AppMeta));
            internal set => _appMeta = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public IReadOnlyCollection<Tier> Tiers => _tiers != null ? Array.AsReadOnly(_tiers) : throw new NotIncludedException();

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public IReadOnlyCollection<Deliverable> Deliverables => _deliverables != null ? Array.AsReadOnly(_deliverables) : throw new NotIncludedException();

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }
        #endregion

        string _title;
        string _description;
        string _benefitType;
        string _ruleType;
        DateTime _createdAt;
        int _deliveredDeliverablesCount;
        int _notDeliveredDeliverablesCount;
        int _deliverablesDueTodayCount;
        DateTime? _nextDeliverableDueDate;
        int _tiersCount;
        bool _isDeleted;
        bool _isPublished;
        bool _isEnded;
        string _appExternalId;
        string _appMeta;

        Tier[] _tiers;
        Deliverable[] _deliverables;
        Campaign _campaign;

        /// <summary> Library restricted construcor.</summary>
        internal Benefit() { }

        /// <summary> Sets the tiers of the benefit record.</summary>
        internal void SetTiers(Tier[] tiers) => _tiers = tiers;

        /// <summary> Sets the deliverables of the benefit record.</summary>
        internal void SetDeliverables(Deliverable[] deliverables) => _deliverables = deliverables;

        public enum IncludeField
        {
            None = 0,
            IncludesTitle = 1 << 1,
            IncludesDescripion = 1 << 2,
            IncludesBenefitType = 1 << 3,
            IncludesRuleType = 1 << 4,
            IncludesCreatedAt = 1 << 5,
            IncludesDeliveredDeliverableCount = 1 << 6,
            IncludesNotDeliveredDeliverablesCount = 1 << 7,
            IncludesDeliverablesdueTodayCount = 1 << 8,
            IncludesNextDeliverableDueDate = 1 << 9,
            IncludesTiersCount = 1 << 10,
            IncludesIsDeleted = 1 << 11,
            IncludesIsPublished = 1 << 12,
            IncludesIsEnded = 1 << 13,
            IncludesAppExternalId = 1 << 14,
            IncludesAppMeta = 1 << 15
        }
    }
}
