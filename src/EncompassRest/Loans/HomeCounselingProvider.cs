using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HomeCounselingProvider
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class HomeCounselingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _agencyAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Address [HCNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address")]
        public string AgencyAddress { get => _agencyAddress; set => SetField(ref _agencyAddress, value); }
        private DirtyValue<string> _agencyAddressCity;
        /// <summary>
        /// Home Counseling Provider - Agency Address City [HCNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address City")]
        public string AgencyAddressCity { get => _agencyAddressCity; set => SetField(ref _agencyAddressCity, value); }
        private DirtyValue<string> _agencyAddressPostalCode;
        /// <summary>
        /// Home Counseling Provider - Agency Address Postal Code [HCNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Home Counseling Provider - Agency Address Postal Code")]
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => SetField(ref _agencyAddressPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _agencyAddressState;
        /// <summary>
        /// Home Counseling Provider - Agency Address State [HCNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address State")]
        public StringEnumValue<State> AgencyAddressState { get => _agencyAddressState; set => SetField(ref _agencyAddressState, value); }
        private DirtyValue<string> _agencyAffiliationDescription;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Description [HCNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Description")]
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => SetField(ref _agencyAffiliationDescription, value); }
        private DirtyValue<bool?> _agencyAffiliationIndicator;
        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Indicator [HCNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Indicator")]
        public bool? AgencyAffiliationIndicator { get => _agencyAffiliationIndicator; set => SetField(ref _agencyAffiliationIndicator, value); }
        private DirtyValue<string> _agencyEmail;
        /// <summary>
        /// Home Counseling Provider - Agency Email [HCNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Email")]
        public string AgencyEmail { get => _agencyEmail; set => SetField(ref _agencyEmail, value); }
        private DirtyValue<string> _agencyFax;
        /// <summary>
        /// Home Counseling Provider - Agency Fax [HCNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Fax")]
        public string AgencyFax { get => _agencyFax; set => SetField(ref _agencyFax, value); }
        private DirtyValue<string> _agencyId;
        /// <summary>
        /// Home Counseling Provider - Agency ID [HCNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency ID")]
        public string AgencyId { get => _agencyId; set => SetField(ref _agencyId, value); }
        private DirtyValue<string> _agencyName;
        /// <summary>
        /// Home Counseling Provider - Agency Name [HCNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Name")]
        public string AgencyName { get => _agencyName; set => SetField(ref _agencyName, value); }
        private DirtyValue<string> _agencyPhoneDirect;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Direct [HCNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Direct")]
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => SetField(ref _agencyPhoneDirect, value); }
        private DirtyValue<string> _agencyPhoneTollFree;
        /// <summary>
        /// Home Counseling Provider - Agency Phone Toll Free Number [HCNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Toll Free Number")]
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => SetField(ref _agencyPhoneTollFree, value); }
        private DirtyValue<string> _agencySource;
        /// <summary>
        /// Home Counseling Provider - Agency Source [HCNN16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency Source")]
        public string AgencySource { get => _agencySource; set => SetField(ref _agencySource, value); }
        private DirtyValue<string> _agencyWebAddress;
        /// <summary>
        /// Home Counseling Provider - Agency Web Address [HCNN11]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Web Address")]
        public string AgencyWebAddress { get => _agencyWebAddress; set => SetField(ref _agencyWebAddress, value); }
        private DirtyValue<string> _counselingServicesProvided;
        /// <summary>
        /// Home Counseling Provider - Counseling Services Provided [HCNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Counseling Services Provided")]
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => SetField(ref _counselingServicesProvided, value); }
        private DirtyValue<decimal?> _distanceMiles;
        /// <summary>
        /// Home Counseling Provider - Distance Number of Miles [HCNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Home Counseling Provider - Distance Number of Miles")]
        public decimal? DistanceMiles { get => _distanceMiles; set => SetField(ref _distanceMiles, value); }
        private DirtyValue<string> _homeCounselingProviderId;
        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderId
        /// </summary>
        public string HomeCounselingProviderId { get => _homeCounselingProviderId; set => SetField(ref _homeCounselingProviderId, value); }
        private DirtyValue<int?> _homeCounselingProviderIndex;
        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderIndex
        /// </summary>
        public int? HomeCounselingProviderIndex { get => _homeCounselingProviderIndex; set => SetField(ref _homeCounselingProviderIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// HomeCounselingProvider Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _languagesSupported;
        /// <summary>
        /// Home Counseling Provider - Languages Supported [HCNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Languages Supported")]
        public string LanguagesSupported { get => _languagesSupported; set => SetField(ref _languagesSupported, value); }
        private DirtyValue<bool?> _selectedIndicator;
        /// <summary>
        /// Home Counseling Provider - Selected Indicator [HCNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Selected Indicator")]
        public bool? SelectedIndicator { get => _selectedIndicator; set => SetField(ref _selectedIndicator, value); }
    }
}