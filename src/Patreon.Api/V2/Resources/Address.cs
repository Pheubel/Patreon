using Patreon.Api.V2.Core.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Address : IAddress
    {
        public IncludeFlag IncludeFlags { get; internal set; }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Addressee
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAddressee) ?
                _addressee :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAddressee, nameof(Addressee));
            internal set => _addressee = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string LineOne
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineOne) ?
                _lineOne :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineOne, nameof(LineOne));
            internal set => _lineOne = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string LineTwo
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineTwo) ?
                _lineTwo :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineTwo, nameof(LineTwo));
            internal set => _lineTwo = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string PostalCode
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPostalCode) ?
                _postalCode :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPostalCode, nameof(PostalCode));
            internal set => _postalCode = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string City
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCity) ?
                _city :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCity, nameof(City));
            internal set => _city = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string State
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesState) ?
                _state :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesState, nameof(State));
            internal set => _state = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string Country
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCountry) ?
                _country :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCountry, nameof(Country));
            internal set => _country = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public string PhoneNumber
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPhoneNumber) ?
                _phoneNumber :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPhoneNumber, nameof(PhoneNumber));
            internal set => _phoneNumber = value;
        }

        /// <exception cref="NotIncludedException{IncludeField}"></exception>
        public DateTime CreatedAt
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }
        public IReadOnlyCollection<Campaign> Campaigns
        {
            get => _campaigns != null ? Array.AsReadOnly(_campaigns) : throw new NotIncludedException();
        }
        private string _addressee;
        private string _lineOne;
        private string _lineTwo;
        private string _postalCode;
        private string _city;
        private string _state;
        private string _country;
        private string _phoneNumber;
        private DateTime _createdAt;

        private User _user;
        private Campaign[] _campaigns;
        /// <summary> Library restricted construcor.</summary>
        internal Address() { }

        internal void SetCampaigns(Campaign[] campains) => _campaigns = _campaigns = campains;

        [Flags]
        public enum IncludeFlag
        {
            None = 0,
            IncludesAddressee = 1 << 1,
            IncludesLineOne = 1 << 2,
            IncludesLineTwo = 1 << 3,
            IncludesPostalCode = 1 << 4,
            IncludesCity = 1 << 5,
            IncludesState = 1 << 6,
            IncludesCountry = 1 << 7,
            IncludesPhoneNumber = 1 << 8,
            IncludesCreatedAt = 1 << 9
        }
    }
}
