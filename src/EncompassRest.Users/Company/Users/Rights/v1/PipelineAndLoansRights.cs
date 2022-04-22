using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PipelineAndLoansRights
    /// </summary>
    public sealed class PipelineAndLoansRights : ParentAccessRights
    {
        /// <summary>
        /// PipelineAndLoansRights AccessToFees
        /// </summary>
        [AllowNull]
        public AccessToFeesRights AccessToFees { get => GetEntity<AccessToFeesRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineAndLoansRights AccessToProductPricing
        /// </summary>
        [JsonProperty("accessToProduct&Pricing")]
        [AllowNull]
        public AccessToProductPricingRights AccessToProductPricing { get => GetEntity<AccessToProductPricingRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineAndLoansRights GenerateDisclosures
        /// </summary>
        public bool? GenerateDisclosures { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineAndLoansRights SubmitForPurchase
        /// </summary>
        public bool? SubmitForPurchase { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineAndLoansRights ViewPurchaseAdvice
        /// </summary>
        [JsonProperty("view Purchase Advice")]
        public bool? ViewPurchaseAdvice { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineAndLoansRights ViewMessages
        /// </summary>
        public bool? ViewMessages { get => GetValue<bool?>(); set => SetValue(value); }
    }
}