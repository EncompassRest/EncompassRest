using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EllieMaeNetworkServiceCategoriesClassRights
    /// </summary>
    public sealed class EllieMaeNetworkServiceCategoriesClassRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _additionalServices;
        private DirtyValue<bool?>? _appraisal;
        private DirtyValue<bool?>? _aVM;
        private DirtyValue<bool?>? _creditReport;
        private DirtyValue<bool?>? _customLinks;
        private DirtyValue<bool?>? _docPreparation;
        private DirtyValue<bool?>? _dueDiligence;
        private DirtyValue<bool?>? _floodCertification;
        private DirtyValue<bool?>? _fraudAuditServices;
        private DirtyValue<bool?>? _hMDAManagement;
        private DirtyValue<bool?>? _investors;
        private DirtyValue<bool?>? _lenders;
        private DirtyValue<bool?>? _mERS;
        private DirtyValue<bool?>? _mortgageInsurance;
        private DirtyValue<bool?>? _productandPricing;
        private DirtyValue<bool?>? _titleClosing;
        private DirtyValue<bool?>? _underwriting;
        private DirtyValue<bool?>? _verifications;
        private DirtyValue<bool?>? _warehouseLenders;

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights AdditionalServices
        /// </summary>
        [JsonProperty("additional Services")]
        public bool? AdditionalServices { get => _additionalServices; set => SetField(ref _additionalServices, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Appraisal
        /// </summary>
        public bool? Appraisal { get => _appraisal; set => SetField(ref _appraisal, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights AVM
        /// </summary>
        public bool? AVM { get => _aVM; set => SetField(ref _aVM, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights CreditReport
        /// </summary>
        [JsonProperty("credit Report")]
        public bool? CreditReport { get => _creditReport; set => SetField(ref _creditReport, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights CustomLinks
        /// </summary>
        [JsonProperty("custom Links")]
        public bool? CustomLinks { get => _customLinks; set => SetField(ref _customLinks, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights DocPreparation
        /// </summary>
        [JsonProperty("doc Preparation")]
        public bool? DocPreparation { get => _docPreparation; set => SetField(ref _docPreparation, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights DueDiligence
        /// </summary>
        [JsonProperty("due Diligence")]
        public bool? DueDiligence { get => _dueDiligence; set => SetField(ref _dueDiligence, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights FloodCertification
        /// </summary>
        [JsonProperty("flood Certification")]
        public bool? FloodCertification { get => _floodCertification; set => SetField(ref _floodCertification, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights FraudAuditServices
        /// </summary>
        [JsonProperty("fraud/Audit Services")]
        public bool? FraudAuditServices { get => _fraudAuditServices; set => SetField(ref _fraudAuditServices, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights HMDAManagement
        /// </summary>
        [JsonProperty("hMDA Management")]
        public bool? HMDAManagement { get => _hMDAManagement; set => SetField(ref _hMDAManagement, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Investors
        /// </summary>
        public bool? Investors { get => _investors; set => SetField(ref _investors, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Lenders
        /// </summary>
        public bool? Lenders { get => _lenders; set => SetField(ref _lenders, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights MERS
        /// </summary>
        public bool? MERS { get => _mERS; set => SetField(ref _mERS, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights MortgageInsurance
        /// </summary>
        [JsonProperty("mortgage Insurance")]
        public bool? MortgageInsurance { get => _mortgageInsurance; set => SetField(ref _mortgageInsurance, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights ProductandPricing
        /// </summary>
        [JsonProperty("product and Pricing")]
        public bool? ProductandPricing { get => _productandPricing; set => SetField(ref _productandPricing, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights TitleClosing
        /// </summary>
        [JsonProperty("title & Closing")]
        public bool? TitleClosing { get => _titleClosing; set => SetField(ref _titleClosing, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Underwriting
        /// </summary>
        public bool? Underwriting { get => _underwriting; set => SetField(ref _underwriting, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Verifications
        /// </summary>
        public bool? Verifications { get => _verifications; set => SetField(ref _verifications, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights WarehouseLenders
        /// </summary>
        [JsonProperty("warehouse Lenders")]
        public bool? WarehouseLenders { get => _warehouseLenders; set => SetField(ref _warehouseLenders, value); }
    }
}