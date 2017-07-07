using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider : IClean
    {
        private Value<bool?> _affiliatedWithLenderIndicator;
        public bool? AffiliatedWithLenderIndicator { get { return _affiliatedWithLenderIndicator; } set { _affiliatedWithLenderIndicator = value; } }
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
        private Value<string> _agencyEmail;
        public string AgencyEmail { get { return _agencyEmail; } set { _agencyEmail = value; } }
        private Value<string> _agencyFax;
        public string AgencyFax { get { return _agencyFax; } set { _agencyFax = value; } }
        private Value<string> _agencyName;
        public string AgencyName { get { return _agencyName; } set { _agencyName = value; } }
        private Value<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get { return _agencyPhoneDirect; } set { _agencyPhoneDirect = value; } }
        private Value<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get { return _agencyPhoneTollFree; } set { _agencyPhoneTollFree = value; } }
        private Value<string> _agencyWebAddress;
        public string AgencyWebAddress { get { return _agencyWebAddress; } set { _agencyWebAddress = value; } }
        private Value<bool?> _brrowerSelectCounselorIndicator;
        public bool? BrrowerSelectCounselorIndicator { get { return _brrowerSelectCounselorIndicator; } set { _brrowerSelectCounselorIndicator = value; } }
        private Value<bool?> _certificationIssuedIndicator;
        public bool? CertificationIssuedIndicator { get { return _certificationIssuedIndicator; } set { _certificationIssuedIndicator = value; } }
        private Value<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        private Value<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        private Value<string> _explanation;
        public string Explanation { get { return _explanation; } set { _explanation = value; } }
        private Value<DateTime?> _homeCounselingCompletionDate;
        public DateTime? HomeCounselingCompletionDate { get { return _homeCounselingCompletionDate; } set { _homeCounselingCompletionDate = value; } }
        private Value<DateTime?> _homeCounselingDisclosureDate;
        public DateTime? HomeCounselingDisclosureDate { get { return _homeCounselingDisclosureDate; } set { _homeCounselingDisclosureDate = value; } }
        private Value<DateTime?> _homeCounselingGeneratedDate;
        public DateTime? HomeCounselingGeneratedDate { get { return _homeCounselingGeneratedDate; } set { _homeCounselingGeneratedDate = value; } }
        private Value<bool?> _homeCounselingRequiredIndicator;
        public bool? HomeCounselingRequiredIndicator { get { return _homeCounselingRequiredIndicator; } set { _homeCounselingRequiredIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _languagesSupported;
        public string LanguagesSupported { get { return _languagesSupported; } set { _languagesSupported = value; } }
        private Value<string> _selectedGUID;
        public string SelectedGUID { get { return _selectedGUID; } set { _selectedGUID = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _affiliatedWithLenderIndicator.Clean
                    && _agencyAddress.Clean
                    && _agencyAddressCity.Clean
                    && _agencyAddressPostalCode.Clean
                    && _agencyAddressState.Clean
                    && _agencyAffiliationDescription.Clean
                    && _agencyEmail.Clean
                    && _agencyFax.Clean
                    && _agencyName.Clean
                    && _agencyPhoneDirect.Clean
                    && _agencyPhoneTollFree.Clean
                    && _agencyWebAddress.Clean
                    && _brrowerSelectCounselorIndicator.Clean
                    && _certificationIssuedIndicator.Clean
                    && _counselingServicesProvided.Clean
                    && _distanceMiles.Clean
                    && _explanation.Clean
                    && _homeCounselingCompletionDate.Clean
                    && _homeCounselingDisclosureDate.Clean
                    && _homeCounselingGeneratedDate.Clean
                    && _homeCounselingRequiredIndicator.Clean
                    && _id.Clean
                    && _languagesSupported.Clean
                    && _selectedGUID.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var affiliatedWithLenderIndicator = _affiliatedWithLenderIndicator; affiliatedWithLenderIndicator.Clean = value; _affiliatedWithLenderIndicator = affiliatedWithLenderIndicator;
                var agencyAddress = _agencyAddress; agencyAddress.Clean = value; _agencyAddress = agencyAddress;
                var agencyAddressCity = _agencyAddressCity; agencyAddressCity.Clean = value; _agencyAddressCity = agencyAddressCity;
                var agencyAddressPostalCode = _agencyAddressPostalCode; agencyAddressPostalCode.Clean = value; _agencyAddressPostalCode = agencyAddressPostalCode;
                var agencyAddressState = _agencyAddressState; agencyAddressState.Clean = value; _agencyAddressState = agencyAddressState;
                var agencyAffiliationDescription = _agencyAffiliationDescription; agencyAffiliationDescription.Clean = value; _agencyAffiliationDescription = agencyAffiliationDescription;
                var agencyEmail = _agencyEmail; agencyEmail.Clean = value; _agencyEmail = agencyEmail;
                var agencyFax = _agencyFax; agencyFax.Clean = value; _agencyFax = agencyFax;
                var agencyName = _agencyName; agencyName.Clean = value; _agencyName = agencyName;
                var agencyPhoneDirect = _agencyPhoneDirect; agencyPhoneDirect.Clean = value; _agencyPhoneDirect = agencyPhoneDirect;
                var agencyPhoneTollFree = _agencyPhoneTollFree; agencyPhoneTollFree.Clean = value; _agencyPhoneTollFree = agencyPhoneTollFree;
                var agencyWebAddress = _agencyWebAddress; agencyWebAddress.Clean = value; _agencyWebAddress = agencyWebAddress;
                var brrowerSelectCounselorIndicator = _brrowerSelectCounselorIndicator; brrowerSelectCounselorIndicator.Clean = value; _brrowerSelectCounselorIndicator = brrowerSelectCounselorIndicator;
                var certificationIssuedIndicator = _certificationIssuedIndicator; certificationIssuedIndicator.Clean = value; _certificationIssuedIndicator = certificationIssuedIndicator;
                var counselingServicesProvided = _counselingServicesProvided; counselingServicesProvided.Clean = value; _counselingServicesProvided = counselingServicesProvided;
                var distanceMiles = _distanceMiles; distanceMiles.Clean = value; _distanceMiles = distanceMiles;
                var explanation = _explanation; explanation.Clean = value; _explanation = explanation;
                var homeCounselingCompletionDate = _homeCounselingCompletionDate; homeCounselingCompletionDate.Clean = value; _homeCounselingCompletionDate = homeCounselingCompletionDate;
                var homeCounselingDisclosureDate = _homeCounselingDisclosureDate; homeCounselingDisclosureDate.Clean = value; _homeCounselingDisclosureDate = homeCounselingDisclosureDate;
                var homeCounselingGeneratedDate = _homeCounselingGeneratedDate; homeCounselingGeneratedDate.Clean = value; _homeCounselingGeneratedDate = homeCounselingGeneratedDate;
                var homeCounselingRequiredIndicator = _homeCounselingRequiredIndicator; homeCounselingRequiredIndicator.Clean = value; _homeCounselingRequiredIndicator = homeCounselingRequiredIndicator;
                var id = _id; id.Clean = value; _id = id;
                var languagesSupported = _languagesSupported; languagesSupported.Clean = value; _languagesSupported = languagesSupported;
                var selectedGUID = _selectedGUID; selectedGUID.Clean = value; _selectedGUID = selectedGUID;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public SelectedHomeCounselingProvider()
        {
            Clean = true;
        }
    }
}