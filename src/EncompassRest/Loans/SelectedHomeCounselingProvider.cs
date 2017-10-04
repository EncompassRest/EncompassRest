using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider : IDirty
    {
        private DirtyValue<bool?> _affiliatedWithLenderIndicator;
        public bool? AffiliatedWithLenderIndicator { get { return _affiliatedWithLenderIndicator; } set { _affiliatedWithLenderIndicator = value; } }
        private DirtyValue<string> _agencyAddress;
        public string AgencyAddress { get { return _agencyAddress; } set { _agencyAddress = value; } }
        private DirtyValue<string> _agencyAddressCity;
        public string AgencyAddressCity { get { return _agencyAddressCity; } set { _agencyAddressCity = value; } }
        private DirtyValue<string> _agencyAddressPostalCode;
        public string AgencyAddressPostalCode { get { return _agencyAddressPostalCode; } set { _agencyAddressPostalCode = value; } }
        private DirtyValue<string> _agencyAddressState;
        public string AgencyAddressState { get { return _agencyAddressState; } set { _agencyAddressState = value; } }
        private DirtyValue<string> _agencyAffiliationDescription;
        public string AgencyAffiliationDescription { get { return _agencyAffiliationDescription; } set { _agencyAffiliationDescription = value; } }
        private DirtyValue<string> _agencyEmail;
        public string AgencyEmail { get { return _agencyEmail; } set { _agencyEmail = value; } }
        private DirtyValue<string> _agencyFax;
        public string AgencyFax { get { return _agencyFax; } set { _agencyFax = value; } }
        private DirtyValue<string> _agencyName;
        public string AgencyName { get { return _agencyName; } set { _agencyName = value; } }
        private DirtyValue<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get { return _agencyPhoneDirect; } set { _agencyPhoneDirect = value; } }
        private DirtyValue<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get { return _agencyPhoneTollFree; } set { _agencyPhoneTollFree = value; } }
        private DirtyValue<string> _agencyWebAddress;
        public string AgencyWebAddress { get { return _agencyWebAddress; } set { _agencyWebAddress = value; } }
        private DirtyValue<bool?> _brrowerSelectCounselorIndicator;
        public bool? BrrowerSelectCounselorIndicator { get { return _brrowerSelectCounselorIndicator; } set { _brrowerSelectCounselorIndicator = value; } }
        private DirtyValue<bool?> _certificationIssuedIndicator;
        public bool? CertificationIssuedIndicator { get { return _certificationIssuedIndicator; } set { _certificationIssuedIndicator = value; } }
        private DirtyValue<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        private DirtyValue<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        private DirtyValue<string> _explanation;
        public string Explanation { get { return _explanation; } set { _explanation = value; } }
        private DirtyValue<DateTime?> _homeCounselingCompletionDate;
        public DateTime? HomeCounselingCompletionDate { get { return _homeCounselingCompletionDate; } set { _homeCounselingCompletionDate = value; } }
        private DirtyValue<DateTime?> _homeCounselingDisclosureDate;
        public DateTime? HomeCounselingDisclosureDate { get { return _homeCounselingDisclosureDate; } set { _homeCounselingDisclosureDate = value; } }
        private DirtyValue<DateTime?> _homeCounselingGeneratedDate;
        public DateTime? HomeCounselingGeneratedDate { get { return _homeCounselingGeneratedDate; } set { _homeCounselingGeneratedDate = value; } }
        private DirtyValue<bool?> _homeCounselingRequiredIndicator;
        public bool? HomeCounselingRequiredIndicator { get { return _homeCounselingRequiredIndicator; } set { _homeCounselingRequiredIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _languagesSupported;
        public string LanguagesSupported { get { return _languagesSupported; } set { _languagesSupported = value; } }
        private DirtyValue<string> _selectedGUID;
        public string SelectedGUID { get { return _selectedGUID; } set { _selectedGUID = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _affiliatedWithLenderIndicator.Dirty
                    || _agencyAddress.Dirty
                    || _agencyAddressCity.Dirty
                    || _agencyAddressPostalCode.Dirty
                    || _agencyAddressState.Dirty
                    || _agencyAffiliationDescription.Dirty
                    || _agencyEmail.Dirty
                    || _agencyFax.Dirty
                    || _agencyName.Dirty
                    || _agencyPhoneDirect.Dirty
                    || _agencyPhoneTollFree.Dirty
                    || _agencyWebAddress.Dirty
                    || _brrowerSelectCounselorIndicator.Dirty
                    || _certificationIssuedIndicator.Dirty
                    || _counselingServicesProvided.Dirty
                    || _distanceMiles.Dirty
                    || _explanation.Dirty
                    || _homeCounselingCompletionDate.Dirty
                    || _homeCounselingDisclosureDate.Dirty
                    || _homeCounselingGeneratedDate.Dirty
                    || _homeCounselingRequiredIndicator.Dirty
                    || _id.Dirty
                    || _languagesSupported.Dirty
                    || _selectedGUID.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _affiliatedWithLenderIndicator.Dirty = value;
                _agencyAddress.Dirty = value;
                _agencyAddressCity.Dirty = value;
                _agencyAddressPostalCode.Dirty = value;
                _agencyAddressState.Dirty = value;
                _agencyAffiliationDescription.Dirty = value;
                _agencyEmail.Dirty = value;
                _agencyFax.Dirty = value;
                _agencyName.Dirty = value;
                _agencyPhoneDirect.Dirty = value;
                _agencyPhoneTollFree.Dirty = value;
                _agencyWebAddress.Dirty = value;
                _brrowerSelectCounselorIndicator.Dirty = value;
                _certificationIssuedIndicator.Dirty = value;
                _counselingServicesProvided.Dirty = value;
                _distanceMiles.Dirty = value;
                _explanation.Dirty = value;
                _homeCounselingCompletionDate.Dirty = value;
                _homeCounselingDisclosureDate.Dirty = value;
                _homeCounselingGeneratedDate.Dirty = value;
                _homeCounselingRequiredIndicator.Dirty = value;
                _id.Dirty = value;
                _languagesSupported.Dirty = value;
                _selectedGUID.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}