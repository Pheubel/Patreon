using Patreon.Api.Core.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Resources
{
    public class Address : IAddress
    {
        public int Id { get; internal set; }
        public IncludeFlag IncludeFlags { get; internal set; }

        #region FIELDS

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string Addressee
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesAddressee) ?
                _addressee :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesAddressee, nameof(Addressee));
            internal set => _addressee = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string LineOne
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineOne) ?
                _lineOne :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineOne, nameof(LineOne));
            internal set => _lineOne = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string LineTwo
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesLineTwo) ?
                _lineTwo :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesLineTwo, nameof(LineTwo));
            internal set => _lineTwo = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string PostalCode
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPostalCode) ?
                _postalCode :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPostalCode, nameof(PostalCode));
            internal set => _postalCode = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string City
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCity) ?
                _city :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCity, nameof(City));
            internal set => _city = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string State
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesState) ?
                _state :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesState, nameof(State));
            internal set => _state = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string Country
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCountry) ?
                _country :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCountry, nameof(Country));
            internal set => _country = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public string PhoneNumber
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesPhoneNumber) ?
                _phoneNumber :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesPhoneNumber, nameof(PhoneNumber));
            internal set => _phoneNumber = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException{IncludeField}" />
        public DateTime CreatedAt
        {
            get => IncludeFlags.HasFlag(IncludeFlag.IncludesCreatedAt) ?
                _createdAt :
                throw new NotIncludedException<IncludeFlag>(IncludeFlag.IncludesCreatedAt, nameof(CreatedAt));
            internal set => _createdAt = value;
        }

        #endregion

        #region RELATIONS

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException" />
        public User User
        {
            get => _user ?? throw new NotIncludedException();
            internal set => _user = value;
        }

        /// <inheritdoc/>
        /// <exception cref="NotIncludedException" />
        public IReadOnlyCollection<Campaign> Campaigns
        {
            get => _campaigns ?? throw new NotIncludedException();
            internal set => _campaigns = value;
        }

        #endregion

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
        private IReadOnlyCollection<Campaign> _campaigns;

        /// <summary> Library restricted construcor.</summary>
        internal Address() { }

        string IPatreonResource.Id => Id.ToString();

        IUser IAddress.User => User;
        IReadOnlyCollection<ICampaign> IAddress.Campaigns => Campaigns;

        [Flags]
        public enum IncludeFlag
        {
            None = 0,
            IncludesAddressee = 1 << 0,
            IncludesLineOne = 1 << 1,
            IncludesLineTwo = 1 << 2,
            IncludesPostalCode = 1 << 3,
            IncludesCity = 1 << 4,
            IncludesState = 1 << 5,
            IncludesCountry = 1 << 6,
            IncludesPhoneNumber = 1 << 7,
            IncludesCreatedAt = 1 << 8,

            IncludesAllFields = 0b1_1111_1111
        }
    }
}
