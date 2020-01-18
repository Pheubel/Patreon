using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public class Memeber : IMember
    {
        PatronState _patronStatus;
        bool _isFollower;
        string _fullName;
        string _email;
        DateTime? _pledgeRelationshipStart;
        int _lifetimeSupportCents;
        

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
