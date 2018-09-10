using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SelectedHomeCounselingProvider
    /// </summary>
    public sealed partial class SelectedHomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _affiliatedWithLenderIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Affiliated With Lender Indicator [HOC.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Affiliated With Lender Indicator")]
        public bool? AffiliatedWithLenderIndicator { get => _affiliatedWithLenderIndicator; set => SetField(ref _affiliatedWithLenderIndicator, value); }
        private DirtyValue<string> _agencyAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Address [HOC.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address")]
        public string AgencyAddress { get => _agencyAddress; set => SetField(ref _agencyAddress, value); }
        private DirtyValue<string> _agencyAddressCity;
        /// <summary>
        /// Home Counseling Provider - Agency Address City [HOC.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address City")]
        public string AgencyAddressCity { get => _agencyAddressCity; set => SetField(ref _agencyAddressCity, value); }
        private DirtyValue<string> _agencyAddressPostalCode;
        /// <summary>
        /// Home Counseling Provider - Agency Address Postal Code [HOC.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Home Counseling Provider - Agency Address Postal Code")]
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => SetField(ref _agencyAddressPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _agencyAddressState;
        /// <summary>
        /// Home Counseling Provider - Agency Address State [HOC.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address State")]
        public StringEnumValue<State> AgencyAddressState { get => _agencyAddressState; set => SetField(ref _agencyAddressState, value); }
        private DirtyValue<string> _agencyAffiliationDescription;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Description [HOC.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Description")]
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => SetField(ref _agencyAffiliationDescription, value); }
        private DirtyValue<string> _agencyEmail;
        /// <summary>
        /// Home Counseling Provider - Agency Email [HOC.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Email")]
        public string AgencyEmail { get => _agencyEmail; set => SetField(ref _agencyEmail, value); }
        private DirtyValue<string> _agencyFax;
        /// <summary>
        /// Home Counseling Provider - Agency Fax [HOC.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Fax")]
        public string AgencyFax { get => _agencyFax; set => SetField(ref _agencyFax, value); }
        private DirtyValue<string> _agencyName;
        /// <summary>
        /// Home Counseling Provider - Agency Name [HOC.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Name")]
        public string AgencyName { get => _agencyName; set => SetField(ref _agencyName, value); }
        private DirtyValue<string> _agencyPhoneDirect;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Direct [HOC.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Direct")]
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => SetField(ref _agencyPhoneDirect, value); }
        private DirtyValue<string> _agencyPhoneTollFree;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Toll Free Number [HOC.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Toll Free Number")]
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => SetField(ref _agencyPhoneTollFree, value); }
        private DirtyValue<string> _agencyWebAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Web Address [HOC.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Web Address")]
        public string AgencyWebAddress { get => _agencyWebAddress; set => SetField(ref _agencyWebAddress, value); }
        private DirtyValue<bool?> _brrowerSelectCounselorIndicator;
        /// <summary>
        /// Home Counseling Provider -  Borrower Select Counselor Indicator [HOC.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider -  Borrower Select Counselor Indicator")]
        public bool? BrrowerSelectCounselorIndicator { get => _brrowerSelectCounselorIndicator; set => SetField(ref _brrowerSelectCounselorIndicator, value); }
        private DirtyValue<bool?> _certificationIssuedIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Certification Issued Indicator [HOC.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Certification Issued Indicator")]
        public bool? CertificationIssuedIndicator { get => _certificationIssuedIndicator; set => SetField(ref _certificationIssuedIndicator, value); }
        private DirtyValue<string> _counselingServicesProvided;
        /// <summary>
        /// Home Counseling Provider - Counseling Services Provided [HOC.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Counseling Services Provided")]
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => SetField(ref _counselingServicesProvided, value); }
        private DirtyValue<decimal?> _distanceMiles;
        /// <summary>
        /// Home Counseling Provider - Distance Number of Miles [HOC.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Home Counseling Provider - Distance Number of Miles")]
        public decimal? DistanceMiles { get => _distanceMiles; set => SetField(ref _distanceMiles, value); }
        private DirtyValue<string> _explanation;
        /// <summary>
        /// Home Counseling Provider - Explanation [HOC.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Explanation")]
        public string Explanation { get => _explanation; set => SetField(ref _explanation, value); }
        private DirtyValue<DateTime?> _homeCounselingCompletionDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Completion Date [HOC.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Completion Date")]
        public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => SetField(ref _homeCounselingCompletionDate, value); }
        private DirtyValue<DateTime?> _homeCounselingDisclosureDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Disclosure Date [HOC.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Disclosure Date")]
        public DateTime? HomeCounselingDisclosureDate { get => _homeCounselingDisclosureDate; set => SetField(ref _homeCounselingDisclosureDate, value); }
        private DirtyValue<DateTime?> _homeCounselingGeneratedDate;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Generated Date [HOC.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Generated Date")]
        public DateTime? HomeCounselingGeneratedDate { get => _homeCounselingGeneratedDate; set => SetField(ref _homeCounselingGeneratedDate, value); }
        private DirtyValue<bool?> _homeCounselingRequiredIndicator;
        /// <summary>
        /// Home Counseling Provider - Home Counseling Required [HOC.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Home Counseling Required")]
        public bool? HomeCounselingRequiredIndicator { get => _homeCounselingRequiredIndicator; set => SetField(ref _homeCounselingRequiredIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// SelectedHomeCounselingProvider Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _languagesSupported;
        /// <summary>
        /// Home Counseling Provider - Languages Supported [HOC.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Languages Supported")]
        public string LanguagesSupported { get => _languagesSupported; set => SetField(ref _languagesSupported, value); }
        private DirtyValue<string> _selectedGUID;
        /// <summary>
        /// Home Counseling Provider - Selected Record ID [HOC.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Selected Record ID")]
        public string SelectedGUID { get => _selectedGUID; set => SetField(ref _selectedGUID, value); }
    }
}