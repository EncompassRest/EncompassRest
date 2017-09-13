using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HomeCounselingProvider : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _agencyAddress.Dirty
                    || _agencyAddressCity.Dirty
                    || _agencyAddressPostalCode.Dirty
                    || _agencyAddressState.Dirty
                    || _agencyAffiliationDescription.Dirty
                    || _agencyAffiliationIndicator.Dirty
                    || _agencyEmail.Dirty
                    || _agencyFax.Dirty
                    || _agencyId.Dirty
                    || _agencyName.Dirty
                    || _agencyPhoneDirect.Dirty
                    || _agencyPhoneTollFree.Dirty
                    || _agencySource.Dirty
                    || _agencyWebAddress.Dirty
                    || _counselingServicesProvided.Dirty
                    || _distanceMiles.Dirty
                    || _homeCounselingProviderId.Dirty
                    || _homeCounselingProviderIndex.Dirty
                    || _id.Dirty
                    || _languagesSupported.Dirty
                    || _selectedIndicator.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _agencyAddress.Dirty = value;
                _agencyAddressCity.Dirty = value;
                _agencyAddressPostalCode.Dirty = value;
                _agencyAddressState.Dirty = value;
                _agencyAffiliationDescription.Dirty = value;
                _agencyAffiliationIndicator.Dirty = value;
                _agencyEmail.Dirty = value;
                _agencyFax.Dirty = value;
                _agencyId.Dirty = value;
                _agencyName.Dirty = value;
                _agencyPhoneDirect.Dirty = value;
                _agencyPhoneTollFree.Dirty = value;
                _agencySource.Dirty = value;
                _agencyWebAddress.Dirty = value;
                _counselingServicesProvided.Dirty = value;
                _distanceMiles.Dirty = value;
                _homeCounselingProviderId.Dirty = value;
                _homeCounselingProviderIndex.Dirty = value;
                _id.Dirty = value;
                _languagesSupported.Dirty = value;
                _selectedIndicator.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}