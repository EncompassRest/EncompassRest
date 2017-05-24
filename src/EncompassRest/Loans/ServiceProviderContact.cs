using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !_address.Clean;
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !_city.Clean;
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !_contactName.Clean;
        private Value<decimal?> _cost;
        public decimal? Cost { get { return _cost; } set { _cost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCost() => !_cost.Clean;
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !_email.Clean;
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !_fax.Clean;
        private Value<decimal?> _feeAmt1;
        public decimal? FeeAmt1 { get { return _feeAmt1; } set { _feeAmt1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt1() => !_feeAmt1.Clean;
        private Value<decimal?> _feeAmt10;
        public decimal? FeeAmt10 { get { return _feeAmt10; } set { _feeAmt10 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt10() => !_feeAmt10.Clean;
        private Value<decimal?> _feeAmt2;
        public decimal? FeeAmt2 { get { return _feeAmt2; } set { _feeAmt2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt2() => !_feeAmt2.Clean;
        private Value<decimal?> _feeAmt3;
        public decimal? FeeAmt3 { get { return _feeAmt3; } set { _feeAmt3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt3() => !_feeAmt3.Clean;
        private Value<decimal?> _feeAmt4;
        public decimal? FeeAmt4 { get { return _feeAmt4; } set { _feeAmt4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt4() => !_feeAmt4.Clean;
        private Value<decimal?> _feeAmt5;
        public decimal? FeeAmt5 { get { return _feeAmt5; } set { _feeAmt5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt5() => !_feeAmt5.Clean;
        private Value<decimal?> _feeAmt6;
        public decimal? FeeAmt6 { get { return _feeAmt6; } set { _feeAmt6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt6() => !_feeAmt6.Clean;
        private Value<decimal?> _feeAmt7;
        public decimal? FeeAmt7 { get { return _feeAmt7; } set { _feeAmt7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt7() => !_feeAmt7.Clean;
        private Value<decimal?> _feeAmt8;
        public decimal? FeeAmt8 { get { return _feeAmt8; } set { _feeAmt8 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt8() => !_feeAmt8.Clean;
        private Value<decimal?> _feeAmt9;
        public decimal? FeeAmt9 { get { return _feeAmt9; } set { _feeAmt9 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt9() => !_feeAmt9.Clean;
        private Value<string> _feeDesc1;
        public string FeeDesc1 { get { return _feeDesc1; } set { _feeDesc1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc1() => !_feeDesc1.Clean;
        private Value<string> _feeDesc10;
        public string FeeDesc10 { get { return _feeDesc10; } set { _feeDesc10 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc10() => !_feeDesc10.Clean;
        private Value<string> _feeDesc2;
        public string FeeDesc2 { get { return _feeDesc2; } set { _feeDesc2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc2() => !_feeDesc2.Clean;
        private Value<string> _feeDesc3;
        public string FeeDesc3 { get { return _feeDesc3; } set { _feeDesc3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc3() => !_feeDesc3.Clean;
        private Value<string> _feeDesc4;
        public string FeeDesc4 { get { return _feeDesc4; } set { _feeDesc4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc4() => !_feeDesc4.Clean;
        private Value<string> _feeDesc5;
        public string FeeDesc5 { get { return _feeDesc5; } set { _feeDesc5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc5() => !_feeDesc5.Clean;
        private Value<string> _feeDesc6;
        public string FeeDesc6 { get { return _feeDesc6; } set { _feeDesc6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc6() => !_feeDesc6.Clean;
        private Value<string> _feeDesc7;
        public string FeeDesc7 { get { return _feeDesc7; } set { _feeDesc7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc7() => !_feeDesc7.Clean;
        private Value<string> _feeDesc8;
        public string FeeDesc8 { get { return _feeDesc8; } set { _feeDesc8 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc8() => !_feeDesc8.Clean;
        private Value<string> _feeDesc9;
        public string FeeDesc9 { get { return _feeDesc9; } set { _feeDesc9 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc9() => !_feeDesc9.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _lineItemNumber;
        public string LineItemNumber { get { return _lineItemNumber; } set { _lineItemNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemNumber() => !_lineItemNumber.Clean;
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !_phone.Clean;
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !_postalCode.Clean;
        private Value<int?> _providerIndex;
        public int? ProviderIndex { get { return _providerIndex; } set { _providerIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderIndex() => !_providerIndex.Clean;
        private Value<string> _providerName;
        public string ProviderName { get { return _providerName; } set { _providerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderName() => !_providerName.Clean;
        private Value<string> _relationship;
        public string Relationship { get { return _relationship; } set { _relationship = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationship() => !_relationship.Clean;
        private Value<string> _serviceProvided;
        public string ServiceProvided { get { return _serviceProvided; } set { _serviceProvided = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProvided() => !_serviceProvided.Clean;
        private Value<string> _serviceProviderId;
        public string ServiceProviderId { get { return _serviceProviderId; } set { _serviceProviderId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProviderId() => !_serviceProviderId.Clean;
        private Value<string> _serviceType;
        public string ServiceType { get { return _serviceType; } set { _serviceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceType() => !_serviceType.Clean;
        private Value<bool?> _shopFor;
        public bool? ShopFor { get { return _shopFor; } set { _shopFor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShopFor() => !_shopFor.Clean;
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !_state.Clean;
        private Value<string> _webUrl;
        public string WebUrl { get { return _webUrl; } set { _webUrl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWebUrl() => !_webUrl.Clean;
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
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _city; v1.Clean = value; _city = v1;
                var v2 = _contactName; v2.Clean = value; _contactName = v2;
                var v3 = _cost; v3.Clean = value; _cost = v3;
                var v4 = _email; v4.Clean = value; _email = v4;
                var v5 = _fax; v5.Clean = value; _fax = v5;
                var v6 = _feeAmt1; v6.Clean = value; _feeAmt1 = v6;
                var v7 = _feeAmt10; v7.Clean = value; _feeAmt10 = v7;
                var v8 = _feeAmt2; v8.Clean = value; _feeAmt2 = v8;
                var v9 = _feeAmt3; v9.Clean = value; _feeAmt3 = v9;
                var v10 = _feeAmt4; v10.Clean = value; _feeAmt4 = v10;
                var v11 = _feeAmt5; v11.Clean = value; _feeAmt5 = v11;
                var v12 = _feeAmt6; v12.Clean = value; _feeAmt6 = v12;
                var v13 = _feeAmt7; v13.Clean = value; _feeAmt7 = v13;
                var v14 = _feeAmt8; v14.Clean = value; _feeAmt8 = v14;
                var v15 = _feeAmt9; v15.Clean = value; _feeAmt9 = v15;
                var v16 = _feeDesc1; v16.Clean = value; _feeDesc1 = v16;
                var v17 = _feeDesc10; v17.Clean = value; _feeDesc10 = v17;
                var v18 = _feeDesc2; v18.Clean = value; _feeDesc2 = v18;
                var v19 = _feeDesc3; v19.Clean = value; _feeDesc3 = v19;
                var v20 = _feeDesc4; v20.Clean = value; _feeDesc4 = v20;
                var v21 = _feeDesc5; v21.Clean = value; _feeDesc5 = v21;
                var v22 = _feeDesc6; v22.Clean = value; _feeDesc6 = v22;
                var v23 = _feeDesc7; v23.Clean = value; _feeDesc7 = v23;
                var v24 = _feeDesc8; v24.Clean = value; _feeDesc8 = v24;
                var v25 = _feeDesc9; v25.Clean = value; _feeDesc9 = v25;
                var v26 = _id; v26.Clean = value; _id = v26;
                var v27 = _lineItemNumber; v27.Clean = value; _lineItemNumber = v27;
                var v28 = _phone; v28.Clean = value; _phone = v28;
                var v29 = _postalCode; v29.Clean = value; _postalCode = v29;
                var v30 = _providerIndex; v30.Clean = value; _providerIndex = v30;
                var v31 = _providerName; v31.Clean = value; _providerName = v31;
                var v32 = _relationship; v32.Clean = value; _relationship = v32;
                var v33 = _serviceProvided; v33.Clean = value; _serviceProvided = v33;
                var v34 = _serviceProviderId; v34.Clean = value; _serviceProviderId = v34;
                var v35 = _serviceType; v35.Clean = value; _serviceType = v35;
                var v36 = _shopFor; v36.Clean = value; _shopFor = v36;
                var v37 = _state; v37.Clean = value; _state = v37;
                var v38 = _webUrl; v38.Clean = value; _webUrl = v38;
                _settingClean = 0;
            }
        }
    }
}