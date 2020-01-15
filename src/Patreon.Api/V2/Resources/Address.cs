using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Resources
{
    public class Address
    {
        public IncludeFlag IncludeFlags { get; internal set; }
        public string? Addressee
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAddressee) ?
                _addressee :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAddressee, nameof(Addressee));
            internal set => _addressee = value;
        }
        public string? LineOne
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineOne) ?
                _lineOne :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineOne, nameof(LineOne));
            internal set => _lineOne = value;
        }
        public string? LineTwo
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineTwo) ?
                _lineTwo :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineTwo, nameof(LineTwo));
            internal set => _lineTwo = value;
        }
        public string? PostalCode
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPostalCode) ?
                _postalCode :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPostalCode, nameof(PostalCode));
            internal set => _postalCode = value;
        }
        public string City
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCity) ?
                _city! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCity, nameof(City));
            internal set => _city = value;
        }
        public string? State
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesState) ?
                _state :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesState, nameof(State));
            internal set => _state = value;
        }
        public string? Country
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCountry) ?
                _country! :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCountry, nameof(Country));
            internal set => _country = value;
        }
        public string? PhoneNumber
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPhoneNumber) ?
                _phoneNumber :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPhoneNumber, nameof(PhoneNumber));
            internal set => _phoneNumber = value;
        }
        public DateTime CreatedAt
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        private string? _addressee;
        private string? _lineOne;
        private string? _lineTwo;
        private string? _postalCode;
        private string? _city;
        private string? _state;
        private string? _country;
        private string? _phoneNumber;
        private DateTime _createdAt;

        [Flags]
        public enum IncludeFlag
        {
            IncludesAddressee = 0b1,
            IncludesLineOne = 0b10,
            IncludesLineTwo = 0b100,
            IncludesPostalCode = 0b1000,
            IncludesCity = 0b1_0000,
            IncludesState = 0b10_0000,
            IncludesCountry = 0b100_0000,
            IncludesPhoneNumber = 0b1000_0000,
            IncludesCreatedAt = 0b1_0000_0000
        }
    }
}
