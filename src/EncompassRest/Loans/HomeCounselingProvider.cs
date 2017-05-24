using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HomeCounselingProvider
    {
        private Value<string> _agencyAddress;
        public string AgencyAddress { get { return _agencyAddress; } set { _agencyAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddress() => !_agencyAddress.Clean;
        private Value<string> _agencyAddressCity;
        public string AgencyAddressCity { get { return _agencyAddressCity; } set { _agencyAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressCity() => !_agencyAddressCity.Clean;
        private Value<string> _agencyAddressPostalCode;
        public string AgencyAddressPostalCode { get { return _agencyAddressPostalCode; } set { _agencyAddressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressPostalCode() => !_agencyAddressPostalCode.Clean;
        private Value<string> _agencyAddressState;
        public string AgencyAddressState { get { return _agencyAddressState; } set { _agencyAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressState() => !_agencyAddressState.Clean;
        private Value<string> _agencyAffiliationDescription;
        public string AgencyAffiliationDescription { get { return _agencyAffiliationDescription; } set { _agencyAffiliationDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAffiliationDescription() => !_agencyAffiliationDescription.Clean;
        private Value<bool?> _agencyAffiliationIndicator;
        public bool? AgencyAffiliationIndicator { get { return _agencyAffiliationIndicator; } set { _agencyAffiliationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAffiliationIndicator() => !_agencyAffiliationIndicator.Clean;
        private Value<string> _agencyEmail;
        public string AgencyEmail { get { return _agencyEmail; } set { _agencyEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyEmail() => !_agencyEmail.Clean;
        private Value<string> _agencyFax;
        public string AgencyFax { get { return _agencyFax; } set { _agencyFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyFax() => !_agencyFax.Clean;
        private Value<string> _agencyId;
        public string AgencyId { get { return _agencyId; } set { _agencyId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyId() => !_agencyId.Clean;
        private Value<string> _agencyName;
        public string AgencyName { get { return _agencyName; } set { _agencyName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyName() => !_agencyName.Clean;
        private Value<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get { return _agencyPhoneDirect; } set { _agencyPhoneDirect = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneDirect() => !_agencyPhoneDirect.Clean;
        private Value<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get { return _agencyPhoneTollFree; } set { _agencyPhoneTollFree = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneTollFree() => !_agencyPhoneTollFree.Clean;
        private Value<string> _agencySource;
        public string AgencySource { get { return _agencySource; } set { _agencySource = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencySource() => !_agencySource.Clean;
        private Value<string> _agencyWebAddress;
        public string AgencyWebAddress { get { return _agencyWebAddress; } set { _agencyWebAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyWebAddress() => !_agencyWebAddress.Clean;
        private Value<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingServicesProvided() => !_counselingServicesProvided.Clean;
        private Value<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDistanceMiles() => !_distanceMiles.Clean;
        private Value<string> _homeCounselingProviderId;
        public string HomeCounselingProviderId { get { return _homeCounselingProviderId; } set { _homeCounselingProviderId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProviderId() => !_homeCounselingProviderId.Clean;
        private Value<int?> _homeCounselingProviderIndex;
        public int? HomeCounselingProviderIndex { get { return _homeCounselingProviderIndex; } set { _homeCounselingProviderIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProviderIndex() => !_homeCounselingProviderIndex.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _languagesSupported;
        public string LanguagesSupported { get { return _languagesSupported; } set { _languagesSupported = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLanguagesSupported() => !_languagesSupported.Clean;
        private Value<bool?> _selectedIndicator;
        public bool? SelectedIndicator { get { return _selectedIndicator; } set { _selectedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedIndicator() => !_selectedIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _agencyAddress.Clean
                    && _agencyAddressCity.Clean
                    && _agencyAddressPostalCode.Clean
                    && _agencyAddressState.Clean
                    && _agencyAffiliationDescription.Clean
                    && _agencyAffiliationIndicator.Clean
                    && _agencyEmail.Clean
                    && _agencyFax.Clean
                    && _agencyId.Clean
                    && _agencyName.Clean
                    && _agencyPhoneDirect.Clean
                    && _agencyPhoneTollFree.Clean
                    && _agencySource.Clean
                    && _agencyWebAddress.Clean
                    && _counselingServicesProvided.Clean
                    && _distanceMiles.Clean
                    && _homeCounselingProviderId.Clean
                    && _homeCounselingProviderIndex.Clean
                    && _id.Clean
                    && _languagesSupported.Clean
                    && _selectedIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _agencyAddress; v0.Clean = value; _agencyAddress = v0;
                var v1 = _agencyAddressCity; v1.Clean = value; _agencyAddressCity = v1;
                var v2 = _agencyAddressPostalCode; v2.Clean = value; _agencyAddressPostalCode = v2;
                var v3 = _agencyAddressState; v3.Clean = value; _agencyAddressState = v3;
                var v4 = _agencyAffiliationDescription; v4.Clean = value; _agencyAffiliationDescription = v4;
                var v5 = _agencyAffiliationIndicator; v5.Clean = value; _agencyAffiliationIndicator = v5;
                var v6 = _agencyEmail; v6.Clean = value; _agencyEmail = v6;
                var v7 = _agencyFax; v7.Clean = value; _agencyFax = v7;
                var v8 = _agencyId; v8.Clean = value; _agencyId = v8;
                var v9 = _agencyName; v9.Clean = value; _agencyName = v9;
                var v10 = _agencyPhoneDirect; v10.Clean = value; _agencyPhoneDirect = v10;
                var v11 = _agencyPhoneTollFree; v11.Clean = value; _agencyPhoneTollFree = v11;
                var v12 = _agencySource; v12.Clean = value; _agencySource = v12;
                var v13 = _agencyWebAddress; v13.Clean = value; _agencyWebAddress = v13;
                var v14 = _counselingServicesProvided; v14.Clean = value; _counselingServicesProvided = v14;
                var v15 = _distanceMiles; v15.Clean = value; _distanceMiles = v15;
                var v16 = _homeCounselingProviderId; v16.Clean = value; _homeCounselingProviderId = v16;
                var v17 = _homeCounselingProviderIndex; v17.Clean = value; _homeCounselingProviderIndex = v17;
                var v18 = _id; v18.Clean = value; _id = v18;
                var v19 = _languagesSupported; v19.Clean = value; _languagesSupported = v19;
                var v20 = _selectedIndicator; v20.Clean = value; _selectedIndicator = v20;
                _settingClean = 0;
            }
        }
    }
}