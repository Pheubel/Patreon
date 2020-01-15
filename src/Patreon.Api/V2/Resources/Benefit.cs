using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public class Benefit
    {
        public IncludeField IncludeFields { get; internal set; }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Title
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesTitle) ?
                _title! :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTitle, nameof(Title));
            internal set => _title = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? Description
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDescripion) ?
                _description :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDescripion, nameof(Description));
            internal set => _description = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? BenefitType
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesBenefitType) ?
                _benefitType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesBenefitType, nameof(BenefitType));
            internal set => _benefitType = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? RuleType
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesRuleType) ?
                _ruleType :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesRuleType, nameof(RuleType));
            internal set => _ruleType = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime CreatedAt
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public int DeliveredDeliverablesCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesDeliveredDeliverableCount) ?
                _deliveredDeliverablesCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesDeliveredDeliverableCount, nameof(DeliveredDeliverablesCount));
            internal set => _deliveredDeliverablesCount = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public int NotDeliveredDeliverablesCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesNotDeliveredDeliverablesCount) ?
                _notDeliveredDeliverablesCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNotDeliveredDeliverablesCount, nameof(NotDeliveredDeliverablesCount));
            internal set => _notDeliveredDeliverablesCount = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime? NextDeliverableDueDate
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesNextDeliverableDueDate) ?
                _nextDeliverableDueDate :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNextDeliverableDueDate, nameof(NextDeliverableDueDate));
            internal set => _nextDeliverableDueDate = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public int TiersCount
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesTiersCount) ?
                _tiersCount :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesTiersCount, nameof(TiersCount));
            internal set => _tiersCount = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsDeleted
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsDeleted) ?
                _isDeleted :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsDeleted, nameof(IsDeleted));
            internal set => _isDeleted = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsPublished
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsPublished) ?
                _isPublished :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsPublished, nameof(IsPublished));
            internal set => _isPublished = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public bool IsEnded
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesIsEnded) ?
                _isEnded :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsEnded, nameof(IsEnded));
            internal set => _isEnded = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string? AppExternalId
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesAppExternalId) ?
                _appExternalId :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppExternalId, nameof(AppExternalId));
            internal set => _appExternalId = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public object? AppMeta
        {
            get => IncludeFields.HasFlag(IncludeField.IncludesAppMeta) ?
                _appMeta :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesAppMeta, nameof(AppMeta));
            internal set => _appMeta = value;
        }

        string? _title;
        string? _description;
        string? _benefitType;
        string? _ruleType;
        DateTime _createdAt;
        int _deliveredDeliverablesCount;
        int _notDeliveredDeliverablesCount;
        DateTime? _nextDeliverableDueDate;
        int _tiersCount;
        bool _isDeleted;
        bool _isPublished;
        bool _isEnded;
        string? _appExternalId;
        object? _appMeta;

        /// <summary> Library restricted construcor.</summary>
        internal Benefit() { }

        public enum IncludeField
        {
            IncludesTitle = 1 << 1,
            IncludesDescripion = 1 << 2,
            IncludesBenefitType = 1 << 3,
            IncludesRuleType = 1 << 4,
            IncludesCreatedAt = 1 << 5,
            IncludesDeliveredDeliverableCount = 1 << 6,
            IncludesNotDeliveredDeliverablesCount = 1 << 7,
            IncludesNextDeliverableDueDate = 1 << 8,
            IncludesTiersCount = 1 << 9,
            IncludesIsDeleted = 1 << 10,
            IncludesIsPublished = 1 << 11,
            IncludesIsEnded = 1 << 12,
            IncludesAppExternalId = 1 << 13,
            IncludesAppMeta = 1 << 14
        }
    }
}
