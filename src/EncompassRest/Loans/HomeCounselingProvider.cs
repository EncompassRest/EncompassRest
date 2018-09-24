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
    public sealed partial class HomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _agencyAddress;
        private DirtyValue<string> _agencyAddressCity;
        private DirtyValue<string> _agencyAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _agencyAddressState;
        private DirtyValue<string> _agencyAffiliationDescription;
        private DirtyValue<bool?> _agencyAffiliationIndicator;
        private DirtyValue<string> _agencyEmail;
        private DirtyValue<string> _agencyFax;
        private DirtyValue<string> _agencyId;
        private DirtyValue<string> _agencyName;
        private DirtyValue<string> _agencyPhoneDirect;
        private DirtyValue<string> _agencyPhoneTollFree;
        private DirtyValue<string> _agencySource;
        private DirtyValue<string> _agencyWebAddress;
        private DirtyValue<string> _counselingServicesProvided;
        private DirtyValue<decimal?> _distanceMiles;
        private DirtyValue<string> _homeCounselingProviderId;
        private DirtyValue<int?> _homeCounselingProviderIndex;
        private DirtyValue<string> _id;
        private DirtyValue<string> _languagesSupported;
        private DirtyValue<bool?> _selectedIndicator;

        /// <summary>
        /// Home Counseling Provider - Agency Address [HCNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address")]
        public string AgencyAddress { get => _agencyAddress; set => SetField(ref _agencyAddress, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Address City [HCNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address City")]
        public string AgencyAddressCity { get => _agencyAddressCity; set => SetField(ref _agencyAddressCity, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Address Postal Code [HCNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Home Counseling Provider - Agency Address Postal Code")]
        public string AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => SetField(ref _agencyAddressPostalCode, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Address State [HCNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Address State")]
        public StringEnumValue<State> AgencyAddressState { get => _agencyAddressState; set => SetField(ref _agencyAddressState, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Description [HCNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Description")]
        public string AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => SetField(ref _agencyAffiliationDescription, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Affiliation Indicator [HCNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Affiliation Indicator")]
        public bool? AgencyAffiliationIndicator { get => _agencyAffiliationIndicator; set => SetField(ref _agencyAffiliationIndicator, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Email [HCNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Email")]
        public string AgencyEmail { get => _agencyEmail; set => SetField(ref _agencyEmail, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Fax [HCNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Fax")]
        public string AgencyFax { get => _agencyFax; set => SetField(ref _agencyFax, value); }

        /// <summary>
        /// Home Counseling Provider - Agency ID [HCNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency ID")]
        public string AgencyId { get => _agencyId; set => SetField(ref _agencyId, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Name [HCNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Name")]
        public string AgencyName { get => _agencyName; set => SetField(ref _agencyName, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Phone Direct [HCNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Direct")]
        public string AgencyPhoneDirect { get => _agencyPhoneDirect; set => SetField(ref _agencyPhoneDirect, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Phone Toll Free Number [HCNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Home Counseling Provider - Agency Phone Toll Free Number")]
        public string AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => SetField(ref _agencyPhoneTollFree, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Source [HCNN16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Counseling Provider - Agency Source")]
        public string AgencySource { get => _agencySource; set => SetField(ref _agencySource, value); }

        /// <summary>
        /// Home Counseling Provider - Agency Web Address [HCNN11]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Agency Web Address")]
        public string AgencyWebAddress { get => _agencyWebAddress; set => SetField(ref _agencyWebAddress, value); }

        /// <summary>
        /// Home Counseling Provider - Counseling Services Provided [HCNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Counseling Services Provided")]
        public string CounselingServicesProvided { get => _counselingServicesProvided; set => SetField(ref _counselingServicesProvided, value); }

        /// <summary>
        /// Home Counseling Provider - Distance Number of Miles [HCNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Home Counseling Provider - Distance Number of Miles")]
        public decimal? DistanceMiles { get => _distanceMiles; set => SetField(ref _distanceMiles, value); }

        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderId
        /// </summary>
        public string HomeCounselingProviderId { get => _homeCounselingProviderId; set => SetField(ref _homeCounselingProviderId, value); }

        /// <summary>
        /// HomeCounselingProvider HomeCounselingProviderIndex
        /// </summary>
        public int? HomeCounselingProviderIndex { get => _homeCounselingProviderIndex; set => SetField(ref _homeCounselingProviderIndex, value); }

        /// <summary>
        /// HomeCounselingProvider Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Home Counseling Provider - Languages Supported [HCNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Languages Supported")]
        public string LanguagesSupported { get => _languagesSupported; set => SetField(ref _languagesSupported, value); }

        /// <summary>
        /// Home Counseling Provider - Selected Indicator [HCNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Selected Indicator")]
        public bool? SelectedIndicator { get => _selectedIndicator; set => SetField(ref _selectedIndicator, value); }
    }
}