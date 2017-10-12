using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private DirtyValue<decimal?> _cost;
        public decimal? Cost { get { return _cost; } set { _cost = value; } }
        private DirtyValue<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private DirtyValue<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private DirtyValue<decimal?> _feeAmt1;
        public decimal? FeeAmt1 { get { return _feeAmt1; } set { _feeAmt1 = value; } }
        private DirtyValue<decimal?> _feeAmt10;
        public decimal? FeeAmt10 { get { return _feeAmt10; } set { _feeAmt10 = value; } }
        private DirtyValue<decimal?> _feeAmt2;
        public decimal? FeeAmt2 { get { return _feeAmt2; } set { _feeAmt2 = value; } }
        private DirtyValue<decimal?> _feeAmt3;
        public decimal? FeeAmt3 { get { return _feeAmt3; } set { _feeAmt3 = value; } }
        private DirtyValue<decimal?> _feeAmt4;
        public decimal? FeeAmt4 { get { return _feeAmt4; } set { _feeAmt4 = value; } }
        private DirtyValue<decimal?> _feeAmt5;
        public decimal? FeeAmt5 { get { return _feeAmt5; } set { _feeAmt5 = value; } }
        private DirtyValue<decimal?> _feeAmt6;
        public decimal? FeeAmt6 { get { return _feeAmt6; } set { _feeAmt6 = value; } }
        private DirtyValue<decimal?> _feeAmt7;
        public decimal? FeeAmt7 { get { return _feeAmt7; } set { _feeAmt7 = value; } }
        private DirtyValue<decimal?> _feeAmt8;
        public decimal? FeeAmt8 { get { return _feeAmt8; } set { _feeAmt8 = value; } }
        private DirtyValue<decimal?> _feeAmt9;
        public decimal? FeeAmt9 { get { return _feeAmt9; } set { _feeAmt9 = value; } }
        private DirtyValue<string> _feeDesc1;
        public string FeeDesc1 { get { return _feeDesc1; } set { _feeDesc1 = value; } }
        private DirtyValue<string> _feeDesc10;
        public string FeeDesc10 { get { return _feeDesc10; } set { _feeDesc10 = value; } }
        private DirtyValue<string> _feeDesc2;
        public string FeeDesc2 { get { return _feeDesc2; } set { _feeDesc2 = value; } }
        private DirtyValue<string> _feeDesc3;
        public string FeeDesc3 { get { return _feeDesc3; } set { _feeDesc3 = value; } }
        private DirtyValue<string> _feeDesc4;
        public string FeeDesc4 { get { return _feeDesc4; } set { _feeDesc4 = value; } }
        private DirtyValue<string> _feeDesc5;
        public string FeeDesc5 { get { return _feeDesc5; } set { _feeDesc5 = value; } }
        private DirtyValue<string> _feeDesc6;
        public string FeeDesc6 { get { return _feeDesc6; } set { _feeDesc6 = value; } }
        private DirtyValue<string> _feeDesc7;
        public string FeeDesc7 { get { return _feeDesc7; } set { _feeDesc7 = value; } }
        private DirtyValue<string> _feeDesc8;
        public string FeeDesc8 { get { return _feeDesc8; } set { _feeDesc8 = value; } }
        private DirtyValue<string> _feeDesc9;
        public string FeeDesc9 { get { return _feeDesc9; } set { _feeDesc9 = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lineItemNumber;
        public string LineItemNumber { get { return _lineItemNumber; } set { _lineItemNumber = value; } }
        private DirtyValue<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private DirtyValue<int?> _providerIndex;
        public int? ProviderIndex { get { return _providerIndex; } set { _providerIndex = value; } }
        private DirtyValue<string> _providerName;
        public string ProviderName { get { return _providerName; } set { _providerName = value; } }
        private DirtyValue<string> _relationship;
        public string Relationship { get { return _relationship; } set { _relationship = value; } }
        private DirtyValue<string> _serviceProvided;
        public string ServiceProvided { get { return _serviceProvided; } set { _serviceProvided = value; } }
        private DirtyValue<string> _serviceProviderId;
        public string ServiceProviderId { get { return _serviceProviderId; } set { _serviceProviderId = value; } }
        private DirtyValue<string> _serviceType;
        public string ServiceType { get { return _serviceType; } set { _serviceType = value; } }
        private DirtyValue<bool?> _shopFor;
        public bool? ShopFor { get { return _shopFor; } set { _shopFor = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private DirtyValue<string> _webUrl;
        public string WebUrl { get { return _webUrl; } set { _webUrl = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _address.Dirty
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
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}