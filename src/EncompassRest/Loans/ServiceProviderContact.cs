using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<decimal?> _cost;
        public decimal? Cost { get { return _cost; } set { _cost = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<decimal?> _feeAmt1;
        public decimal? FeeAmt1 { get { return _feeAmt1; } set { _feeAmt1 = value; } }
        private Value<decimal?> _feeAmt10;
        public decimal? FeeAmt10 { get { return _feeAmt10; } set { _feeAmt10 = value; } }
        private Value<decimal?> _feeAmt2;
        public decimal? FeeAmt2 { get { return _feeAmt2; } set { _feeAmt2 = value; } }
        private Value<decimal?> _feeAmt3;
        public decimal? FeeAmt3 { get { return _feeAmt3; } set { _feeAmt3 = value; } }
        private Value<decimal?> _feeAmt4;
        public decimal? FeeAmt4 { get { return _feeAmt4; } set { _feeAmt4 = value; } }
        private Value<decimal?> _feeAmt5;
        public decimal? FeeAmt5 { get { return _feeAmt5; } set { _feeAmt5 = value; } }
        private Value<decimal?> _feeAmt6;
        public decimal? FeeAmt6 { get { return _feeAmt6; } set { _feeAmt6 = value; } }
        private Value<decimal?> _feeAmt7;
        public decimal? FeeAmt7 { get { return _feeAmt7; } set { _feeAmt7 = value; } }
        private Value<decimal?> _feeAmt8;
        public decimal? FeeAmt8 { get { return _feeAmt8; } set { _feeAmt8 = value; } }
        private Value<decimal?> _feeAmt9;
        public decimal? FeeAmt9 { get { return _feeAmt9; } set { _feeAmt9 = value; } }
        private Value<string> _feeDesc1;
        public string FeeDesc1 { get { return _feeDesc1; } set { _feeDesc1 = value; } }
        private Value<string> _feeDesc10;
        public string FeeDesc10 { get { return _feeDesc10; } set { _feeDesc10 = value; } }
        private Value<string> _feeDesc2;
        public string FeeDesc2 { get { return _feeDesc2; } set { _feeDesc2 = value; } }
        private Value<string> _feeDesc3;
        public string FeeDesc3 { get { return _feeDesc3; } set { _feeDesc3 = value; } }
        private Value<string> _feeDesc4;
        public string FeeDesc4 { get { return _feeDesc4; } set { _feeDesc4 = value; } }
        private Value<string> _feeDesc5;
        public string FeeDesc5 { get { return _feeDesc5; } set { _feeDesc5 = value; } }
        private Value<string> _feeDesc6;
        public string FeeDesc6 { get { return _feeDesc6; } set { _feeDesc6 = value; } }
        private Value<string> _feeDesc7;
        public string FeeDesc7 { get { return _feeDesc7; } set { _feeDesc7 = value; } }
        private Value<string> _feeDesc8;
        public string FeeDesc8 { get { return _feeDesc8; } set { _feeDesc8 = value; } }
        private Value<string> _feeDesc9;
        public string FeeDesc9 { get { return _feeDesc9; } set { _feeDesc9 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lineItemNumber;
        public string LineItemNumber { get { return _lineItemNumber; } set { _lineItemNumber = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<int?> _providerIndex;
        public int? ProviderIndex { get { return _providerIndex; } set { _providerIndex = value; } }
        private Value<string> _providerName;
        public string ProviderName { get { return _providerName; } set { _providerName = value; } }
        private Value<string> _relationship;
        public string Relationship { get { return _relationship; } set { _relationship = value; } }
        private Value<string> _serviceProvided;
        public string ServiceProvided { get { return _serviceProvided; } set { _serviceProvided = value; } }
        private Value<string> _serviceProviderId;
        public string ServiceProviderId { get { return _serviceProviderId; } set { _serviceProviderId = value; } }
        private Value<string> _serviceType;
        public string ServiceType { get { return _serviceType; } set { _serviceType = value; } }
        private Value<bool?> _shopFor;
        public bool? ShopFor { get { return _shopFor; } set { _shopFor = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _webUrl;
        public string WebUrl { get { return _webUrl; } set { _webUrl = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _city.Clean
                    && _contactName.Clean
                    && _cost.Clean
                    && _email.Clean
                    && _fax.Clean
                    && _feeAmt1.Clean
                    && _feeAmt10.Clean
                    && _feeAmt2.Clean
                    && _feeAmt3.Clean
                    && _feeAmt4.Clean
                    && _feeAmt5.Clean
                    && _feeAmt6.Clean
                    && _feeAmt7.Clean
                    && _feeAmt8.Clean
                    && _feeAmt9.Clean
                    && _feeDesc1.Clean
                    && _feeDesc10.Clean
                    && _feeDesc2.Clean
                    && _feeDesc3.Clean
                    && _feeDesc4.Clean
                    && _feeDesc5.Clean
                    && _feeDesc6.Clean
                    && _feeDesc7.Clean
                    && _feeDesc8.Clean
                    && _feeDesc9.Clean
                    && _id.Clean
                    && _lineItemNumber.Clean
                    && _phone.Clean
                    && _postalCode.Clean
                    && _providerIndex.Clean
                    && _providerName.Clean
                    && _relationship.Clean
                    && _serviceProvided.Clean
                    && _serviceProviderId.Clean
                    && _serviceType.Clean
                    && _shopFor.Clean
                    && _state.Clean
                    && _webUrl.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var address = _address; address.Clean = value; _address = address;
                var city = _city; city.Clean = value; _city = city;
                var contactName = _contactName; contactName.Clean = value; _contactName = contactName;
                var cost = _cost; cost.Clean = value; _cost = cost;
                var email = _email; email.Clean = value; _email = email;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var feeAmt1 = _feeAmt1; feeAmt1.Clean = value; _feeAmt1 = feeAmt1;
                var feeAmt10 = _feeAmt10; feeAmt10.Clean = value; _feeAmt10 = feeAmt10;
                var feeAmt2 = _feeAmt2; feeAmt2.Clean = value; _feeAmt2 = feeAmt2;
                var feeAmt3 = _feeAmt3; feeAmt3.Clean = value; _feeAmt3 = feeAmt3;
                var feeAmt4 = _feeAmt4; feeAmt4.Clean = value; _feeAmt4 = feeAmt4;
                var feeAmt5 = _feeAmt5; feeAmt5.Clean = value; _feeAmt5 = feeAmt5;
                var feeAmt6 = _feeAmt6; feeAmt6.Clean = value; _feeAmt6 = feeAmt6;
                var feeAmt7 = _feeAmt7; feeAmt7.Clean = value; _feeAmt7 = feeAmt7;
                var feeAmt8 = _feeAmt8; feeAmt8.Clean = value; _feeAmt8 = feeAmt8;
                var feeAmt9 = _feeAmt9; feeAmt9.Clean = value; _feeAmt9 = feeAmt9;
                var feeDesc1 = _feeDesc1; feeDesc1.Clean = value; _feeDesc1 = feeDesc1;
                var feeDesc10 = _feeDesc10; feeDesc10.Clean = value; _feeDesc10 = feeDesc10;
                var feeDesc2 = _feeDesc2; feeDesc2.Clean = value; _feeDesc2 = feeDesc2;
                var feeDesc3 = _feeDesc3; feeDesc3.Clean = value; _feeDesc3 = feeDesc3;
                var feeDesc4 = _feeDesc4; feeDesc4.Clean = value; _feeDesc4 = feeDesc4;
                var feeDesc5 = _feeDesc5; feeDesc5.Clean = value; _feeDesc5 = feeDesc5;
                var feeDesc6 = _feeDesc6; feeDesc6.Clean = value; _feeDesc6 = feeDesc6;
                var feeDesc7 = _feeDesc7; feeDesc7.Clean = value; _feeDesc7 = feeDesc7;
                var feeDesc8 = _feeDesc8; feeDesc8.Clean = value; _feeDesc8 = feeDesc8;
                var feeDesc9 = _feeDesc9; feeDesc9.Clean = value; _feeDesc9 = feeDesc9;
                var id = _id; id.Clean = value; _id = id;
                var lineItemNumber = _lineItemNumber; lineItemNumber.Clean = value; _lineItemNumber = lineItemNumber;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var providerIndex = _providerIndex; providerIndex.Clean = value; _providerIndex = providerIndex;
                var providerName = _providerName; providerName.Clean = value; _providerName = providerName;
                var relationship = _relationship; relationship.Clean = value; _relationship = relationship;
                var serviceProvided = _serviceProvided; serviceProvided.Clean = value; _serviceProvided = serviceProvided;
                var serviceProviderId = _serviceProviderId; serviceProviderId.Clean = value; _serviceProviderId = serviceProviderId;
                var serviceType = _serviceType; serviceType.Clean = value; _serviceType = serviceType;
                var shopFor = _shopFor; shopFor.Clean = value; _shopFor = shopFor;
                var state = _state; state.Clean = value; _state = state;
                var webUrl = _webUrl; webUrl.Clean = value; _webUrl = webUrl;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ServiceProviderContact()
        {
            Clean = true;
        }
    }
}