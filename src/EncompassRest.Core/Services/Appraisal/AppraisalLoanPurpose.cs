using System.Runtime.Serialization;

namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// AppraisalLoanPurpose
    /// </summary>
    public enum AppraisalLoanPurpose
    {
        /// <summary>
        /// Construction
        /// </summary>
        Construction = 0,
        /// <summary>
        /// Construction Permanent
        /// </summary>
        [EnumMember(Value = "Construction Permanent")]
        ConstructionPermanent = 1,
        /// <summary>
        /// HELOC
        /// </summary>
        HELOC = 2,
        /// <summary>
        /// OREO/SAD
        /// </summary>
        [EnumMember(Value = "OREO/SAD")]
        OREO_SAD = 3,
        /// <summary>
        /// Purchase
        /// </summary>
        Purchase = 4,
        /// <summary>
        /// Refinance
        /// </summary>
        Refinance = 5,
        /// <summary>
        /// Renewal
        /// </summary>
        Renewal = 6,
        /// <summary>
        /// Second Mortgage
        /// </summary>
        [EnumMember(Value = "Second Mortgage")]
        SecondMortgage = 7,
        /// <summary>
        /// Other
        /// </summary>
        Other = 8
    }
}