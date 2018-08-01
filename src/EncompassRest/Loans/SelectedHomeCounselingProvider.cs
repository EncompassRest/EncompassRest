using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SelectedHomeCounselingProvider
    /// </summary>
    public sealed partial class SelectedHomeCounselingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _affiliatedWithLenderIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Affiliated With Lender Indicator [HOC.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Affiliated With Lender Indicator")]
        public bool? AffiliatedWithLenderIndicator { get => _affiliatedWithLenderIndicator; set => _affiliatedWithLenderIndicator = value; }
        private DirtyValue<string> _agencyAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Address [HOC.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address")]
        public string AgencyAddress { get => _agencyAddress; set => _agencyAddress = value; }
        private DirtyValue<string> _agencyAddressCity;
        /// <summary>
        /// Home Counseling Provider - Agency Address City [HOC.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address City")]
        public string AgencyAddressCity { get => _agencyAddressCity; set => _agencyAddressCity = value; }
        private DirtyValue<string> _agencyAddressPostalCode;
        /// <summary>
        /// Home Counseling Provider - Agency Address Postal Code [HOC.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Home Counseling Provider - Agency Address Postal Code")]
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => _agencyAddressPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _agencyAddressState;
        /// <summary>
        /// Home Counseling Provider - Agency Address State [HOC.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address State")]
        public StringEnumValue<State> AgencyAddressState { get => _agencyAddressState; set => _agencyAddressState = value; }
        private DirtyValue<string> _agencyAffiliationDescription;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Description [HOC.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Description")]
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => _agencyAffiliationDescription = value; }
        private DirtyValue<string> _agencyEmail;
        /// <summary>
        /// Home Counseling Provider - Agency Email [HOC.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Email")]
        public string AgencyEmail { get => _agencyEmail; set => _agencyEmail = value; }
        private DirtyValue<string> _agencyFax;
        /// <summary>
        /// Home Counseling Provider - Agency Fax [HOC.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Fax")]
        public string AgencyFax { get => _agencyFax; set => _agencyFax = value; }
        private DirtyValue<string> _agencyName;
        /// <summary>
        /// Home Counseling Provider - Agency Name [HOC.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Name")]
        public string AgencyName { get => _agencyName; set => _agencyName = value; }
        private DirtyValue<string> _agencyPhoneDirect;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Direct [HOC.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Direct")]
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => _agencyPhoneDirect = value; }
        private DirtyValue<string> _agencyPhoneTollFree;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Toll Free Number [HOC.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Toll Free Number")]
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => _agencyPhoneTollFree = value; }
        private DirtyValue<string> _agencyWebAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Web Address [HOC.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Web Address")]
        public string AgencyWebAddress { get => _agencyWebAddress; set => _agencyWebAddress = value; }
        private DirtyValue<bool?> _brrowerSelectCounselorIndicator;
        /// <summary>
        /// Home Counseling Provider -  Borrower Select Counselor Indicator [HOC.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider -  Borrower Select Counselor Indicator")]
        public bool? BrrowerSelectCounselorIndicator { get => _brrowerSelectCounselorIndicator; set => _brrowerSelectCounselorIndicator = value; }
        private DirtyValue<bool?> _certificationIssuedIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Certification Issued Indicator [HOC.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Certification Issued Indicator")]
        public bool? CertificationIssuedIndicator { get => _certificationIssuedIndicator; set => _certificationIssuedIndicator = value; }
        private DirtyValue<string> _counselingServicesProvided;
        /// <summary>
        /// Home Counseling Provider - Counseling Services Provided [HOC.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Counseling Services Provided")]
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => _counselingServicesProvided = value; }
        private DirtyValue<decimal?> _distanceMiles;
        /// <summary>
        /// Home Counseling Provider - Distance Number of Miles [HOC.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Home Counseling Provider - Distance Number of Miles")]
        public decimal? DistanceMiles { get => _distanceMiles; set => _distanceMiles = value; }
        private DirtyValue<string> _explanation;
        /// <summary>
        /// Home Counseling Provider - Explanation [HOC.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Explanation")]
        public string Explanation { get => _explanation; set => _explanation = value; }
        private DirtyValue<DateTime?> _homeCounselingCompletionDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Completion Date [HOC.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Completion Date")]
        public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => _homeCounselingCompletionDate = value; }
        private DirtyValue<DateTime?> _homeCounselingDisclosureDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Disclosure Date [HOC.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Disclosure Date")]
        public DateTime? HomeCounselingDisclosureDate { get => _homeCounselingDisclosureDate; set => _homeCounselingDisclosureDate = value; }
        private DirtyValue<DateTime?> _homeCounselingGeneratedDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Generated Date [HOC.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Generated Date")]
        public DateTime? HomeCounselingGeneratedDate { get => _homeCounselingGeneratedDate; set => _homeCounselingGeneratedDate = value; }
        private DirtyValue<bool?> _homeCounselingRequiredIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Required [HOC.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Required")]
        public bool? HomeCounselingRequiredIndicator { get => _homeCounselingRequiredIndicator; set => _homeCounselingRequiredIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// SelectedHomeCounselingProvider Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _languagesSupported;
        /// <summary>
        /// Home Counseling Provider - Languages Supported [HOC.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Languages Supported")]
        public string LanguagesSupported { get => _languagesSupported; set => _languagesSupported = value; }
        private DirtyValue<string> _selectedGUID;
        /// <summary>
        /// Home Counseling Provider - Selected Record ID [HOC.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Selected Record ID")]
        public string SelectedGUID { get => _selectedGUID; set => _selectedGUID = value; }
        internal override bool DirtyInternal
        {
            get => _affiliatedWithLenderIndicator.Dirty
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