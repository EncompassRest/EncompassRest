using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EllieMaeNetworkServiceCategoriesClassRights
    /// </summary>
    public sealed class EllieMaeNetworkServiceCategoriesClassRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights AdditionalServices
        /// </summary>
        [JsonProperty("additional Services")]
        public bool? AdditionalServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Appraisal
        /// </summary>
        public bool? Appraisal { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights AVM
        /// </summary>
        public bool? AVM { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights CreditReport
        /// </summary>
        [JsonProperty("credit Report")]
        public bool? CreditReport { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights CustomLinks
        /// </summary>
        [JsonProperty("custom Links")]
        public bool? CustomLinks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights DocPreparation
        /// </summary>
        [JsonProperty("doc Preparation")]
        public bool? DocPreparation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights DueDiligence
        /// </summary>
        [JsonProperty("due Diligence")]
        public bool? DueDiligence { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights FloodCertification
        /// </summary>
        [JsonProperty("flood Certification")]
        public bool? FloodCertification { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights FraudAuditServices
        /// </summary>
        [JsonProperty("fraud/Audit Services")]
        public bool? FraudAuditServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights HMDAManagement
        /// </summary>
        [JsonProperty("hMDA Management")]
        public bool? HMDAManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Investors
        /// </summary>
        public bool? Investors { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Lenders
        /// </summary>
        public bool? Lenders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights MERS
        /// </summary>
        public bool? MERS { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights MortgageInsurance
        /// </summary>
        [JsonProperty("mortgage Insurance")]
        public bool? MortgageInsurance { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights ProductandPricing
        /// </summary>
        [JsonProperty("product and Pricing")]
        public bool? ProductandPricing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights TitleClosing
        /// </summary>
        [JsonProperty("title & Closing")]
        public bool? TitleClosing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Underwriting
        /// </summary>
        public bool? Underwriting { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights Verifications
        /// </summary>
        public bool? Verifications { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesClassRights WarehouseLenders
        /// </summary>
        [JsonProperty("warehouse Lenders")]
        public bool? WarehouseLenders { get => GetValue<bool?>(); set => SetValue(value); }
    }
}