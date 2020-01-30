﻿using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Member : IMember<Member.PatronState, Member.ChargeState>
    {
        public IncludeField IncludesFields { get; internal set; }

        public PatronState PatronStatus
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPatronStatus) ?
                _patronStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPatronStatus, nameof(PatronStatus));
            internal set => _patronStatus = value;
        }
        public bool IsFollower
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesIsFollower) ?
                _isFollower :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesIsFollower, nameof(IsFollower));
            internal set => _isFollower = value;
        }
        public string FullName
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesFullName) ?
                _fullName :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesFullName, nameof(FullName));
            internal set => _fullName = value;
        }
        public string Email
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesEmail) ?
                _email :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesEmail, nameof(Email));
            internal set => _email = value;
        }
        public DateTime? PledgeRelationshipStart
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesPledgeRelationshipStart) ?
                _pledgeRelationshipStart :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesPledgeRelationshipStart, nameof(PledgeRelationshipStart));
            internal set => _pledgeRelationshipStart = value;
        }
        public int LifetimeSupportCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLifetimeSupportCents) ?
                _lifetimeSupportCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLifetimeSupportCents, nameof(LifetimeSupportCents));
            internal set => _lifetimeSupportCents = value;
        }
        public int CurrentlyEntitledAmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesCurrentlyEntitledAmountCents) ?
                _currentlyEntitledAmountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesCurrentlyEntitledAmountCents, nameof(CurrentlyEntitledAmountCents));
            internal set => _currentlyEntitledAmountCents = value;
        }
        public DateTime? LastChargeDate
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastChargeDate) ?
                _lastchargeDate :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastChargeDate, nameof(LastChargeDate));
            internal set => _lastchargeDate = value;
        }
        public ChargeState LastChargeStatus
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesLastChargeStatus) ?
                _lastChargeStatus :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesLastChargeStatus, nameof(LastChargeStatus));
            internal set => _lastChargeStatus = value;
        }
        public string Note
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesNote) ?
                _note :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesNote, nameof(Note));
            internal set => _note = value;
        }
        public int WillPayAmountCents
        {
            get => IncludesFields.HasFlag(IncludeField.IncludesWillPayAmountCents) ?
                _willPayAmountCents :
                throw new NotIncludedException<IncludeField>(IncludeField.IncludesWillPayAmountCents, nameof(WillPayAmountCents));
            internal set => _willPayAmountCents = value;
        }

        public Address Address
        {
            get => _address ?? throw new NotIncludedException();
            internal set => _address = value;
        }
        public Campaign Campaign
        {
            get => _campaign ?? throw new NotIncludedException();
            internal set => _campaign = value;
        }
        public IReadOnlyCollection<Tier> EntitledTiers =>
            _entitledTiers != null ?
                Array.AsReadOnly(_entitledTiers) :
                throw new NotIncludedException();
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }
        public IReadOnlyCollection<Pledge> PledgeHistory =>
            _pledgeHistory != null ?
                Array.AsReadOnly(_pledgeHistory) :
                throw new NotIncludedException();

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
        private Tier[] _entitledTiers;
        private User _user;
        private Pledge[] _pledgeHistory;

        internal void SetEntitledTiers(Tier[] tiers) => _entitledTiers = tiers;
        internal void SetPledgeHistory(Pledge[] pledges) => _pledgeHistory = pledges;


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
