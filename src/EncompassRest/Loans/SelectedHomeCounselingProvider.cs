using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider
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
        private Value<string> _agencyEmail;
        public string AgencyEmail { get { return _agencyEmail; } set { _agencyEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyEmail() => !_agencyEmail.Clean;
        private Value<string> _agencyFax;
        public string AgencyFax { get { return _agencyFax; } set { _agencyFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyFax() => !_agencyFax.Clean;
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
        private Value<string> _agencyWebAddress;
        public string AgencyWebAddress { get { return _agencyWebAddress; } set { _agencyWebAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyWebAddress() => !_agencyWebAddress.Clean;
        private Value<bool?> _certificationIssuedIndicator;
        public bool? CertificationIssuedIndicator { get { return _certificationIssuedIndicator; } set { _certificationIssuedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationIssuedIndicator() => !_certificationIssuedIndicator.Clean;
        private Value<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get { return _counselingServicesProvided; } set { _counselingServicesProvided = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingServicesProvided() => !_counselingServicesProvided.Clean;
        private Value<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get { return _distanceMiles; } set { _distanceMiles = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDistanceMiles() => !_distanceMiles.Clean;
        private Value<DateTime?> _homeCounselingCompletionDate;
        public DateTime? HomeCounselingCompletionDate { get { return _homeCounselingCompletionDate; } set { _homeCounselingCompletionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingCompletionDate() => !_homeCounselingCompletionDate.Clean;
        private Value<DateTime?> _homeCounselingDisclosureDate;
        public DateTime? HomeCounselingDisclosureDate { get { return _homeCounselingDisclosureDate; } set { _homeCounselingDisclosureDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingDisclosureDate() => !_homeCounselingDisclosureDate.Clean;
        private Value<bool?> _homeCounselingRequiredIndicator;
        public bool? HomeCounselingRequiredIndicator { get { return _homeCounselingRequiredIndicator; } set { _homeCounselingRequiredIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingRequiredIndicator() => !_homeCounselingRequiredIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _languagesSupported;
        public string LanguagesSupported { get { return _languagesSupported; } set { _languagesSupported = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLanguagesSupported() => !_languagesSupported.Clean;
        private Value<string> _selectedGUID;
        public string SelectedGUID { get { return _selectedGUID; } set { _selectedGUID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedGUID() => !_selectedGUID.Clean;
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
    }
}