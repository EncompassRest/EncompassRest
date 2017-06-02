using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider : IClean
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
        private Value<bool?> _certificationIssuedIndicator;
        public bool? CertificationIssuedIndicator { get { return _certificationIssuedIndicator; } set { _certificationIssuedIndicator = value; } }
        private Value<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        private Value<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        private Value<DateTime?> _homeCounselingCompletionDate;
        public DateTime? HomeCounselingCompletionDate { get { return _homeCounselingCompletionDate; } set { _homeCounselingCompletionDate = value; } }
        private Value<DateTime?> _homeCounselingDisclosureDate;
        public DateTime? HomeCounselingDisclosureDate { get { return _homeCounselingDisclosureDate; } set { _homeCounselingDisclosureDate = value; } }
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
                var clean = _agencyAddress.Clean
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
                    && _certificationIssuedIndicator.Clean
                    && _counselingServicesProvided.Clean
                    && _distanceMiles.Clean
                    && _homeCounselingCompletionDate.Clean
                    && _homeCounselingDisclosureDate.Clean
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
                var v0 = _agencyAddress; v0.Clean = value; _agencyAddress = v0;
                var v1 = _agencyAddressCity; v1.Clean = value; _agencyAddressCity = v1;
                var v2 = _agencyAddressPostalCode; v2.Clean = value; _agencyAddressPostalCode = v2;
                var v3 = _agencyAddressState; v3.Clean = value; _agencyAddressState = v3;
                var v4 = _agencyAffiliationDescription; v4.Clean = value; _agencyAffiliationDescription = v4;
                var v5 = _agencyEmail; v5.Clean = value; _agencyEmail = v5;
                var v6 = _agencyFax; v6.Clean = value; _agencyFax = v6;
                var v7 = _agencyName; v7.Clean = value; _agencyName = v7;
                var v8 = _agencyPhoneDirect; v8.Clean = value; _agencyPhoneDirect = v8;
                var v9 = _agencyPhoneTollFree; v9.Clean = value; _agencyPhoneTollFree = v9;
                var v10 = _agencyWebAddress; v10.Clean = value; _agencyWebAddress = v10;
                var v11 = _certificationIssuedIndicator; v11.Clean = value; _certificationIssuedIndicator = v11;
                var v12 = _counselingServicesProvided; v12.Clean = value; _counselingServicesProvided = v12;
                var v13 = _distanceMiles; v13.Clean = value; _distanceMiles = v13;
                var v14 = _homeCounselingCompletionDate; v14.Clean = value; _homeCounselingCompletionDate = v14;
                var v15 = _homeCounselingDisclosureDate; v15.Clean = value; _homeCounselingDisclosureDate = v15;
                var v16 = _homeCounselingRequiredIndicator; v16.Clean = value; _homeCounselingRequiredIndicator = v16;
                var v17 = _id; v17.Clean = value; _id = v17;
                var v18 = _languagesSupported; v18.Clean = value; _languagesSupported = v18;
                var v19 = _selectedGUID; v19.Clean = value; _selectedGUID = v19;
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