using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HomeCounselingProvider
    /// </summary>
    public sealed partial class HomeCounselingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _agencyAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Address [HCNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address")]
        public string AgencyAddress { get => _agencyAddress; set => _agencyAddress = value; }
        private DirtyValue<string> _agencyAddressCity;
        /// <summary>
        /// Home Counseling Provider - Agency Address City [HCNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address City")]
        public string AgencyAddressCity { get => _agencyAddressCity; set => _agencyAddressCity = value; }
        private DirtyValue<string> _agencyAddressPostalCode;
        /// <summary>
        /// Home Counseling Provider - Agency Address Postal Code [HCNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Home Counseling Provider - Agency Address Postal Code")]
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => _agencyAddressPostalCode = value; }
        private DirtyValue<string> _agencyAddressState;
        /// <summary>
        /// Home Counseling Provider - Agency Address State [HCNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Home Counseling Provider - Agency Address State")]
        public string AgencyAddressState { get => _agencyAddressState; set => _agencyAddressState = value; }
        private DirtyValue<string> _agencyAffiliationDescription;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Description [HCNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Description")]
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => _agencyAffiliationDescription = value; }
        private DirtyValue<bool?> _agencyAffiliationIndicator;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Indicator [HCNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Indicator")]
        public bool? AgencyAffiliationIndicator { get => _agencyAffiliationIndicator; set => _agencyAffiliationIndicator = value; }
        private DirtyValue<string> _agencyEmail;
        /// <summary>
        /// Home Counseling Provider - Agency Email [HCNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Email")]
        public string AgencyEmail { get => _agencyEmail; set => _agencyEmail = value; }
        private DirtyValue<string> _agencyFax;
        /// <summary>
        /// Home Counseling Provider - Agency Fax [HCNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Fax")]
        public string AgencyFax { get => _agencyFax; set => _agencyFax = value; }
        private DirtyValue<string> _agencyId;
        /// <summary>
        /// Home Counseling Provider - Agency ID [HCNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency ID")]
        public string AgencyId { get => _agencyId; set => _agencyId = value; }
        private DirtyValue<string> _agencyName;
        /// <summary>
        /// Home Counseling Provider - Agency Name [HCNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Name")]
        public string AgencyName { get => _agencyName; set => _agencyName = value; }
        private DirtyValue<string> _agencyPhoneDirect;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Direct [HCNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Direct")]
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => _agencyPhoneDirect = value; }
        private DirtyValue<string> _agencyPhoneTollFree;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Toll Free Number [HCNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Toll Free Number")]
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => _agencyPhoneTollFree = value; }
        private DirtyValue<string> _agencySource;
        /// <summary>
        /// Home Counseling Provider - Agency Source [HCNN16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency Source")]
        public string AgencySource { get => _agencySource; set => _agencySource = value; }
        private DirtyValue<string> _agencyWebAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Web Address [HCNN11]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Web Address")]
        public string AgencyWebAddress { get => _agencyWebAddress; set => _agencyWebAddress = value; }
        private DirtyValue<string> _counselingServicesProvided;
        /// <summary>
        /// Home Counseling Provider - Counseling Services Provided [HCNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Counseling Services Provided")]
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => _counselingServicesProvided = value; }
        private DirtyValue<decimal?> _distanceMiles;
        /// <summary>
        /// Home Counseling Provider - Distance Number of Miles [HCNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Home Counseling Provider - Distance Number of Miles")]
        public decimal? DistanceMiles { get => _distanceMiles; set => _distanceMiles = value; }
        private DirtyValue<string> _homeCounselingProviderId;
        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderId
        /// </summary>
        public string HomeCounselingProviderId { get => _homeCounselingProviderId; set => _homeCounselingProviderId = value; }
        private DirtyValue<int?> _homeCounselingProviderIndex;
        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderIndex
        /// </summary>
        public int? HomeCounselingProviderIndex { get => _homeCounselingProviderIndex; set => _homeCounselingProviderIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// HomeCounselingProvider Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _languagesSupported;
        /// <summary>
        /// Home Counseling Provider - Languages Supported [HCNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Languages Supported")]
        public string LanguagesSupported { get => _languagesSupported; set => _languagesSupported = value; }
        private DirtyValue<bool?> _selectedIndicator;
        /// <summary>
        /// Home Counseling Provider - Selected Indicator [HCNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Selected Indicator")]
        public bool? SelectedIndicator { get => _selectedIndicator; set => _selectedIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _agencyAddress.Dirty
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