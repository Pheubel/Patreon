using Patreon.Api.Core.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Member : IMember<Member.PatronState, Member.ChargeState>
    {
        public IncludeField IncludesFields { get; internal set; }
        public Guid Id { get; internal set; }

        #region FIELDS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public PatronState PatronStatus
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPatronStatus) ?
                _patronStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronStatus, nameof(PatronStatus));
            internal set => _patronStatus = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public bool IsFollower
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesIsFollower) ?
                _isFollower :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsFollower, nameof(IsFollower));
            internal set => _isFollower = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string FullName
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesFullName) ?
                _fullName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesFullName, nameof(FullName));
            internal set => _fullName = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Email
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEmail) ?
                _email :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEmail, nameof(Email));
            internal set => _email = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? PledgeRelationshipStart
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPledgeRelationshipStart) ?
                _pledgeRelationshipStart :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPledgeRelationshipStart, nameof(PledgeRelationshipStart));
            internal set => _pledgeRelationshipStart = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int LifetimeSupportCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLifetimeSupportCents) ?
                _lifetimeSupportCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLifetimeSupportCents, nameof(LifetimeSupportCents));
            internal set => _lifetimeSupportCents = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int CurrentlyEntitledAmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesCurrentlyEntitledAmountCents) ?
                _currentlyEntitledAmountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCurrentlyEntitledAmountCents, nameof(CurrentlyEntitledAmountCents));
            internal set => _currentlyEntitledAmountCents = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public DateTime? LastChargeDate
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastChargeDate) ?
                _lastchargeDate :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastChargeDate, nameof(LastChargeDate));
            internal set => _lastchargeDate = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public ChargeState LastChargeStatus
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastChargeStatus) ?
                _lastChargeStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastChargeStatus, nameof(LastChargeStatus));
            internal set => _lastChargeStatus = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public string Note
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesNote) ?
                _note :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNote, nameof(Note));
            internal set => _note = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}"/>
        public int WillPayAmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesWillPayAmountCents) ?
                _willPayAmountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesWillPayAmountCents, nameof(WillPayAmountCents));
            internal set => _willPayAmountCents = value;
        }
        #endregion

        #region RELATIONS
        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Address Address
        {
            get => _address ?? throw new NotIncludedException();
            internal set => _address = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public IReadOnlyCollection<Tier> EntitledTiers
        {
            get => _entitledTiers ?? throw new NotIncludedException();
            internal set => _entitledTiers = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException"/>
        public IReadOnlyCollection<PledgeEvent> PledgeHistory
        {
            get => _pledgeHistory ?? throw new NotIncludedException();
            internal set => _pledgeHistory = value;
        }
        #endregion

        private PatronState _patronStatus;
        private bool _isFollower;
        private string _fullName;
        private string _email;
        private DateTime? _pledgeRelationshipStart;
        private int _lifetimeSupportCents;
        private int _currentlyEntitledAmountCents;
        private DateTime? _lastchargeDate;
        private ChargeState _lastChargeStatus;
        private string _note;
        private int _willPayAmountCents;

        private Address _address;
        private Campaign _campaign;
        private IReadOnlyCollection<Tier> _entitledTiers;
        private User _user;
        private IReadOnlyCollection<PledgeEvent> _pledgeHistory;

        /// <summary> Library restricted constructor.</summary>
        internal Member() { }

        string IPatreonResource.IdString => Id.ToString();

        Enum IMember.PatronStatusValue => PatronStatus;
        Enum IMember.LastChargeStatusValue => LastChargeStatus;
        IAddress IMember.Address => Address;
        ICampaign IMember.Campaign => Campaign;
        IReadOnlyCollection<ITier> IMember.EntitledTiers => EntitledTiers;
        IUser IMember.User => User;
        IReadOnlyCollection<IPledgeEvent> IMember.PledgeHistory => PledgeHistory;

        [Flags]
        public enum IncludeField
        {
            None = 0,
            IncludesPatronStatus = 1 << 0,
            IncludesIsFollower = 1 << 1,
            IncludesFullName = 1 << 2,
            IncludesEmail = 1 << 3,
            IncludesPledgeRelationshipStart = 1 << 4,
            IncludesLifetimeSupportCents = 1 << 5,
            IncludesCurrentlyEntitledAmountCents = 1 << 6,
            IncludesLastChargeDate = 1 << 7,
            IncludesLastChargeStatus = 1 << 8,
            IncludesNote = 1 << 9,
            IncludesWillPayAmountCents = 1 << 10
        }

        public enum PatronState
        {
            NeverPledged,
            ActivePatron,
            DeclinedPatron,
            FormerPatron
        }

        public enum ChargeState
        {
            NeverCharged,
            Paid,
            Declined,
            Deleted,
            Pending,
            Refunded,
            Fraud,
            Other
        }
    }
}
