using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HomeCounselingProvider : IClean
    {
        private Value<string> _agencyAddress;
        public string AgencyAddress { get { return _agencyAddress; } set { _agencyAddress = value; } }
        private Value<string> _agencyAddressCity;
        public string AgencyAddressCity { get { return _agencyAddressCity; } set { _agencyAddressCity = value; } }
        private Value<string> _agencyAddressPostalCode;
        public string AgencyAddressPostalCode { get { return _agencyAddressPostalCode; } set { _agencyAddressPostalCode = value; } }
        private Value<string> _agencyAddressState;
        public string AgencyAddressState { get { return _agencyAddressState; } set { _agencyAddressState = value; } }
        private Value<string> _agencyAffiliationDescription;
        public string AgencyAffiliationDescription { get { return _agencyAffiliationDescription; } set { _agencyAffiliationDescription = value; } }
        private Value<bool?> _agencyAffiliationIndicator;
        public bool? AgencyAffiliationIndicator { get { return _agencyAffiliationIndicator; } set { _agencyAffiliationIndicator = value; } }
        private Value<string> _agencyEmail;
        public string AgencyEmail { get { return _agencyEmail; } set { _agencyEmail = value; } }
        private Value<string> _agencyFax;
        public string AgencyFax { get { return _agencyFax; } set { _agencyFax = value; } }
        private Value<string> _agencyId;
        public string AgencyId { get { return _agencyId; } set { _agencyId = value; } }
        private Value<string> _agencyName;
        public string AgencyName { get { return _agencyName; } set { _agencyName = value; } }
        private Value<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get { return _agencyPhoneDirect; } set { _agencyPhoneDirect = value; } }
        private Value<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get { return _agencyPhoneTollFree; } set { _agencyPhoneTollFree = value; } }
        private Value<string> _agencySource;
        public string AgencySource { get { return _agencySource; } set { _agencySource = value; } }
        private Value<string> _agencyWebAddress;
        public string AgencyWebAddress { get { return _agencyWebAddress; } set { _agencyWebAddress = value; } }
        private Value<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        private Value<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        private Value<string> _homeCounselingProviderId;
        public string HomeCounselingProviderId { get { return _homeCounselingProviderId; } set { _homeCounselingProviderId = value; } }
        private Value<int?> _homeCounselingProviderIndex;
        public int? HomeCounselingProviderIndex { get { return _homeCounselingProviderIndex; } set { _homeCounselingProviderIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _languagesSupported;
        public string LanguagesSupported { get { return _languagesSupported; } set { _languagesSupported = value; } }
        private Value<bool?> _selectedIndicator;
        public bool? SelectedIndicator { get { return _selectedIndicator; } set { _selectedIndicator = value; } }
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
                var agencyAddress = _agencyAddress; agencyAddress.Clean = value; _agencyAddress = agencyAddress;
                var agencyAddressCity = _agencyAddressCity; agencyAddressCity.Clean = value; _agencyAddressCity = agencyAddressCity;
                var agencyAddressPostalCode = _agencyAddressPostalCode; agencyAddressPostalCode.Clean = value; _agencyAddressPostalCode = agencyAddressPostalCode;
                var agencyAddressState = _agencyAddressState; agencyAddressState.Clean = value; _agencyAddressState = agencyAddressState;
                var agencyAffiliationDescription = _agencyAffiliationDescription; agencyAffiliationDescription.Clean = value; _agencyAffiliationDescription = agencyAffiliationDescription;
                var agencyAffiliationIndicator = _agencyAffiliationIndicator; agencyAffiliationIndicator.Clean = value; _agencyAffiliationIndicator = agencyAffiliationIndicator;
                var agencyEmail = _agencyEmail; agencyEmail.Clean = value; _agencyEmail = agencyEmail;
                var agencyFax = _agencyFax; agencyFax.Clean = value; _agencyFax = agencyFax;
                var agencyId = _agencyId; agencyId.Clean = value; _agencyId = agencyId;
                var agencyName = _agencyName; agencyName.Clean = value; _agencyName = agencyName;
                var agencyPhoneDirect = _agencyPhoneDirect; agencyPhoneDirect.Clean = value; _agencyPhoneDirect = agencyPhoneDirect;
                var agencyPhoneTollFree = _agencyPhoneTollFree; agencyPhoneTollFree.Clean = value; _agencyPhoneTollFree = agencyPhoneTollFree;
                var agencySource = _agencySource; agencySource.Clean = value; _agencySource = agencySource;
                var agencyWebAddress = _agencyWebAddress; agencyWebAddress.Clean = value; _agencyWebAddress = agencyWebAddress;
                var counselingServicesProvided = _counselingServicesProvided; counselingServicesProvided.Clean = value; _counselingServicesProvided = counselingServicesProvided;
                var distanceMiles = _distanceMiles; distanceMiles.Clean = value; _distanceMiles = distanceMiles;
                var homeCounselingProviderId = _homeCounselingProviderId; homeCounselingProviderId.Clean = value; _homeCounselingProviderId = homeCounselingProviderId;
                var homeCounselingProviderIndex = _homeCounselingProviderIndex; homeCounselingProviderIndex.Clean = value; _homeCounselingProviderIndex = homeCounselingProviderIndex;
                var id = _id; id.Clean = value; _id = id;
                var languagesSupported = _languagesSupported; languagesSupported.Clean = value; _languagesSupported = languagesSupported;
                var selectedIndicator = _selectedIndicator; selectedIndicator.Clean = value; _selectedIndicator = selectedIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public HomeCounselingProvider()
        {
            Clean = true;
        }
    }
}