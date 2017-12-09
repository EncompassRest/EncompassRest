#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<decimal?> _cost;
        public decimal? Cost { get => _cost; set => _cost = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<decimal?> _feeAmt1;
        public decimal? FeeAmt1 { get => _feeAmt1; set => _feeAmt1 = value; }
        private DirtyValue<decimal?> _feeAmt10;
        public decimal? FeeAmt10 { get => _feeAmt10; set => _feeAmt10 = value; }
        private DirtyValue<decimal?> _feeAmt2;
        public decimal? FeeAmt2 { get => _feeAmt2; set => _feeAmt2 = value; }
        private DirtyValue<decimal?> _feeAmt3;
        public decimal? FeeAmt3 { get => _feeAmt3; set => _feeAmt3 = value; }
        private DirtyValue<decimal?> _feeAmt4;
        public decimal? FeeAmt4 { get => _feeAmt4; set => _feeAmt4 = value; }
        private DirtyValue<decimal?> _feeAmt5;
        public decimal? FeeAmt5 { get => _feeAmt5; set => _feeAmt5 = value; }
        private DirtyValue<decimal?> _feeAmt6;
        public decimal? FeeAmt6 { get => _feeAmt6; set => _feeAmt6 = value; }
        private DirtyValue<decimal?> _feeAmt7;
        public decimal? FeeAmt7 { get => _feeAmt7; set => _feeAmt7 = value; }
        private DirtyValue<decimal?> _feeAmt8;
        public decimal? FeeAmt8 { get => _feeAmt8; set => _feeAmt8 = value; }
        private DirtyValue<decimal?> _feeAmt9;
        public decimal? FeeAmt9 { get => _feeAmt9; set => _feeAmt9 = value; }
        private DirtyValue<string> _feeDesc1;
        public string FeeDesc1 { get => _feeDesc1; set => _feeDesc1 = value; }
        private DirtyValue<string> _feeDesc10;
        public string FeeDesc10 { get => _feeDesc10; set => _feeDesc10 = value; }
        private DirtyValue<string> _feeDesc2;
        public string FeeDesc2 { get => _feeDesc2; set => _feeDesc2 = value; }
        private DirtyValue<string> _feeDesc3;
        public string FeeDesc3 { get => _feeDesc3; set => _feeDesc3 = value; }
        private DirtyValue<string> _feeDesc4;
        public string FeeDesc4 { get => _feeDesc4; set => _feeDesc4 = value; }
        private DirtyValue<string> _feeDesc5;
        public string FeeDesc5 { get => _feeDesc5; set => _feeDesc5 = value; }
        private DirtyValue<string> _feeDesc6;
        public string FeeDesc6 { get => _feeDesc6; set => _feeDesc6 = value; }
        private DirtyValue<string> _feeDesc7;
        public string FeeDesc7 { get => _feeDesc7; set => _feeDesc7 = value; }
        private DirtyValue<string> _feeDesc8;
        public string FeeDesc8 { get => _feeDesc8; set => _feeDesc8 = value; }
        private DirtyValue<string> _feeDesc9;
        public string FeeDesc9 { get => _feeDesc9; set => _feeDesc9 = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lineItemNumber;
        public string LineItemNumber { get => _lineItemNumber; set => _lineItemNumber = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<int?> _providerIndex;
        public int? ProviderIndex { get => _providerIndex; set => _providerIndex = value; }
        private DirtyValue<string> _providerName;
        public string ProviderName { get => _providerName; set => _providerName = value; }
        private DirtyValue<string> _relationship;
        public string Relationship { get => _relationship; set => _relationship = value; }
        private DirtyValue<string> _serviceProvided;
        public string ServiceProvided { get => _serviceProvided; set => _serviceProvided = value; }
        private DirtyValue<string> _serviceProviderId;
        public string ServiceProviderId { get => _serviceProviderId; set => _serviceProviderId = value; }
        private DirtyValue<StringEnumValue<ServiceType>> _serviceType;
        public StringEnumValue<ServiceType> ServiceType { get => _serviceType; set => _serviceType = value; }
        private DirtyValue<bool?> _shopFor;
        public bool? ShopFor { get => _shopFor; set => _shopFor = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _webUrl;
        public string WebUrl { get => _webUrl; set => _webUrl = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
                    || _city.Dirty
                    || _contactName.Dirty
                    || _cost.Dirty
                    || _email.Dirty
                    || _fax.Dirty
                    || _feeAmt1.Dirty
                    || _feeAmt10.Dirty
                    || _feeAmt2.Dirty
                    || _feeAmt3.Dirty
                    || _feeAmt4.Dirty
                    || _feeAmt5.Dirty
                    || _feeAmt6.Dirty
                    || _feeAmt7.Dirty
                    || _feeAmt8.Dirty
                    || _feeAmt9.Dirty
                    || _feeDesc1.Dirty
                    || _feeDesc10.Dirty
                    || _feeDesc2.Dirty
                    || _feeDesc3.Dirty
                    || _feeDesc4.Dirty
                    || _feeDesc5.Dirty
                    || _feeDesc6.Dirty
                    || _feeDesc7.Dirty
                    || _feeDesc8.Dirty
                    || _feeDesc9.Dirty
                    || _id.Dirty
                    || _lineItemNumber.Dirty
                    || _phone.Dirty
                    || _postalCode.Dirty
                    || _providerIndex.Dirty
                    || _providerName.Dirty
                    || _relationship.Dirty
                    || _serviceProvided.Dirty
                    || _serviceProviderId.Dirty
                    || _serviceType.Dirty
                    || _shopFor.Dirty
                    || _state.Dirty
                    || _webUrl.Dirty;
            }
            set
            {
                _address.Dirty = value;
                _city.Dirty = value;
                _contactName.Dirty = value;
                _cost.Dirty = value;
                _email.Dirty = value;
                _fax.Dirty = value;
                _feeAmt1.Dirty = value;
                _feeAmt10.Dirty = value;
                _feeAmt2.Dirty = value;
                _feeAmt3.Dirty = value;
                _feeAmt4.Dirty = value;
                _feeAmt5.Dirty = value;
                _feeAmt6.Dirty = value;
                _feeAmt7.Dirty = value;
                _feeAmt8.Dirty = value;
                _feeAmt9.Dirty = value;
                _feeDesc1.Dirty = value;
                _feeDesc10.Dirty = value;
                _feeDesc2.Dirty = value;
                _feeDesc3.Dirty = value;
                _feeDesc4.Dirty = value;
                _feeDesc5.Dirty = value;
                _feeDesc6.Dirty = value;
                _feeDesc7.Dirty = value;
                _feeDesc8.Dirty = value;
                _feeDesc9.Dirty = value;
                _id.Dirty = value;
                _lineItemNumber.Dirty = value;
                _phone.Dirty = value;
                _postalCode.Dirty = value;
                _providerIndex.Dirty = value;
                _providerName.Dirty = value;
                _relationship.Dirty = value;
                _serviceProvided.Dirty = value;
                _serviceProviderId.Dirty = value;
                _serviceType.Dirty = value;
                _shopFor.Dirty = value;
                _state.Dirty = value;
                _webUrl.Dirty = value;
            }
        }
    }
}