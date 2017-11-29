using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class HomeCounselingProvider : ExtensibleObject
    {
        private DirtyValue<string> _agencyAddress;
        public string AgencyAddress { get => _agencyAddress; set => _agencyAddress = value; }
        private DirtyValue<string> _agencyAddressCity;
        public string AgencyAddressCity { get => _agencyAddressCity; set => _agencyAddressCity = value; }
        private DirtyValue<string> _agencyAddressPostalCode;
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => _agencyAddressPostalCode = value; }
        private DirtyValue<string> _agencyAddressState;
        public string AgencyAddressState { get => _agencyAddressState; set => _agencyAddressState = value; }
        private DirtyValue<string> _agencyAffiliationDescription;
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => _agencyAffiliationDescription = value; }
        private DirtyValue<bool?> _agencyAffiliationIndicator;
        public bool? AgencyAffiliationIndicator { get => _agencyAffiliationIndicator; set => _agencyAffiliationIndicator = value; }
        private DirtyValue<string> _agencyEmail;
        public string AgencyEmail { get => _agencyEmail; set => _agencyEmail = value; }
        private DirtyValue<string> _agencyFax;
        public string AgencyFax { get => _agencyFax; set => _agencyFax = value; }
        private DirtyValue<string> _agencyId;
        public string AgencyId { get => _agencyId; set => _agencyId = value; }
        private DirtyValue<string> _agencyName;
        public string AgencyName { get => _agencyName; set => _agencyName = value; }
        private DirtyValue<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => _agencyPhoneDirect = value; }
        private DirtyValue<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => _agencyPhoneTollFree = value; }
        private DirtyValue<string> _agencySource;
        public string AgencySource { get => _agencySource; set => _agencySource = value; }
        private DirtyValue<string> _agencyWebAddress;
        public string AgencyWebAddress { get => _agencyWebAddress; set => _agencyWebAddress = value; }
        private DirtyValue<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => _counselingServicesProvided = value; }
        private DirtyValue<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get => _distanceMiles; set => _distanceMiles = value; }
        private DirtyValue<string> _homeCounselingProviderId;
        public string HomeCounselingProviderId { get => _homeCounselingProviderId; set => _homeCounselingProviderId = value; }
        private DirtyValue<int?> _homeCounselingProviderIndex;
        public int? HomeCounselingProviderIndex { get => _homeCounselingProviderIndex; set => _homeCounselingProviderIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _languagesSupported;
        public string LanguagesSupported { get => _languagesSupported; set => _languagesSupported = value; }
        private DirtyValue<bool?> _selectedIndicator;
        public bool? SelectedIndicator { get => _selectedIndicator; set => _selectedIndicator = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _agencyAddress.Dirty
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
            }
            set
            {
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
            }
        }
    }
}