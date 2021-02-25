using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PropertyFormType
    /// </summary>
    public enum PropertyFormType
    {
        /// <summary>
        /// Uniform Residential Appraisal Report
        /// </summary>
        [EnumMember(Value = "Uniform Residential Appraisal Report")]
        UniformResidentialAppraisalReport = 0,
        /// <summary>
        /// Manufactured Home Appraisal Report
        /// </summary>
        [EnumMember(Value = "Manufactured Home Appraisal Report")]
        ManufacturedHomeAppraisalReport = 1,
        /// <summary>
        /// Small Residential Income Property Appraisal Report
        /// </summary>
        [EnumMember(Value = "Small Residential Income Property Appraisal Report")]
        SmallResidentialIncomePropertyAppraisalReport = 2,
        /// <summary>
        /// Individual Condominium Unit Appraisal Report
        /// </summary>
        [EnumMember(Value = "Individual Condominium Unit Appraisal Report")]
        IndividualCondominiumUnitAppraisalReport = 3,
        /// <summary>
        /// Exterior Only Inspection Individual Condominium Unit Appraisal Report
        /// </summary>
        [EnumMember(Value = "Exterior Only Inspection Individual Condominium Unit Appraisal Report")]
        ExteriorOnlyInspectionIndividualCondominiumUnitAppraisalReport = 4,
        /// <summary>
        /// One Unit Residential Appraisal Field Review Report
        /// </summary>
        [EnumMember(Value = "One Unit Residential Appraisal Field Review Report")]
        OneUnitResidentialAppraisalFieldReviewReport = 5,
        /// <summary>
        /// Two To Four Unit Residential Appraisal
        /// </summary>
        [EnumMember(Value = "Two To Four Unit Residential Appraisal")]
        TwoToFourUnitResidentialAppraisal = 6,
        /// <summary>
        /// Exterior Only Inspection Residential Appraisal Report
        /// </summary>
        [EnumMember(Value = "Exterior Only Inspection Residential Appraisal Report")]
        ExteriorOnlyInspectionResidentialAppraisalReport = 7,
        /// <summary>
        /// Individual Cooperative Interest Appraisal Report
        /// </summary>
        [EnumMember(Value = "Individual Cooperative Interest Appraisal Report")]
        IndividualCooperativeInterestAppraisalReport = 8,
        /// <summary>
        /// Exterior Only Inspection Individual Cooperative Interest Appraisal Report
        /// </summary>
        [EnumMember(Value = "Exterior Only Inspection Individual Cooperative Interest Appraisal Report")]
        ExteriorOnlyInspectionIndividualCooperativeInterestAppraisalReport = 9,
        /// <summary>
        /// Appraisal Update And Or Completion Report
        /// </summary>
        [EnumMember(Value = "Appraisal Update And Or Completion Report")]
        AppraisalUpdateAndOrCompletionReport = 10,
        /// <summary>
        /// Desktop Underwriter Property Inspection Report
        /// </summary>
        [EnumMember(Value = "Desktop Underwriter Property Inspection Report")]
        DesktopUnderwriterPropertyInspectionReport = 11,
        /// <summary>
        /// Loan Prospector Condition And Marketability
        /// </summary>
        [EnumMember(Value = "Loan Prospector Condition And Marketability")]
        LoanProspectorConditionAndMarketability = 12,
        /// <summary>
        /// One Unit Residential Appraisal Desk Review Report
        /// </summary>
        [EnumMember(Value = "One Unit Residential Appraisal Desk Review Report")]
        OneUnitResidentialAppraisalDeskReviewReport = 13
    }
}