#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _affiliatedWithLenderIndicator;
        public bool? AffiliatedWithLenderIndicator { get => _affiliatedWithLenderIndicator; set => _affiliatedWithLenderIndicator = value; }
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
        private DirtyValue<string> _agencyEmail;
        public string AgencyEmail { get => _agencyEmail; set => _agencyEmail = value; }
        private DirtyValue<string> _agencyFax;
        public string AgencyFax { get => _agencyFax; set => _agencyFax = value; }
        private DirtyValue<string> _agencyName;
        public string AgencyName { get => _agencyName; set => _agencyName = value; }
        private DirtyValue<string> _agencyPhoneDirect;
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => _agencyPhoneDirect = value; }
        private DirtyValue<string> _agencyPhoneTollFree;
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => _agencyPhoneTollFree = value; }
        private DirtyValue<string> _agencyWebAddress;
        public string AgencyWebAddress { get => _agencyWebAddress; set => _agencyWebAddress = value; }
        private DirtyValue<bool?> _brrowerSelectCounselorIndicator;
        public bool? BrrowerSelectCounselorIndicator { get => _brrowerSelectCounselorIndicator; set => _brrowerSelectCounselorIndicator = value; }
        private DirtyValue<bool?> _certificationIssuedIndicator;
        public bool? CertificationIssuedIndicator { get => _certificationIssuedIndicator; set => _certificationIssuedIndicator = value; }
        private DirtyValue<string> _counselingServicesProvided;
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => _counselingServicesProvided = value; }
        private DirtyValue<decimal?> _distanceMiles;
        public decimal? DistanceMiles { get => _distanceMiles; set => _distanceMiles = value; }
        private DirtyValue<string> _explanation;
        public string Explanation { get => _explanation; set => _explanation = value; }
        private DirtyValue<DateTime?> _homeCounselingCompletionDate;
        public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => _homeCounselingCompletionDate = value; }
        private DirtyValue<DateTime?> _homeCounselingDisclosureDate;
        public DateTime? HomeCounselingDisclosureDate { get => _homeCounselingDisclosureDate; set => _homeCounselingDisclosureDate = value; }
        private DirtyValue<DateTime?> _homeCounselingGeneratedDate;
        public DateTime? HomeCounselingGeneratedDate { get => _homeCounselingGeneratedDate; set => _homeCounselingGeneratedDate = value; }
        private DirtyValue<bool?> _homeCounselingRequiredIndicator;
        public bool? HomeCounselingRequiredIndicator { get => _homeCounselingRequiredIndicator; set => _homeCounselingRequiredIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _languagesSupported;
        public string LanguagesSupported { get => _languagesSupported; set => _languagesSupported = value; }
        private DirtyValue<string> _selectedGUID;
        public string SelectedGUID { get => _selectedGUID; set => _selectedGUID = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _affiliatedWithLenderIndicator.Dirty
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
            }
            set
            {
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
            }
        }
    }
}