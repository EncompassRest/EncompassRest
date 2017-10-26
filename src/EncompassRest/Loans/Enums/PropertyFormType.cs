using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PropertyFormType
    {
        [EnumMember(Value = "Uniform Residential Appraisal Report")]
        UniformResidentialAppraisalReport = 0,
        [EnumMember(Value = "Manufactured Home Appraisal Report")]
        ManufacturedHomeAppraisalReport = 1,
        [EnumMember(Value = "Small Residential Income Property Appraisal Report")]
        SmallResidentialIncomePropertyAppraisalReport = 2,
        [EnumMember(Value = "Individual Condominium Unit Appraisal Report")]
        IndividualCondominiumUnitAppraisalReport = 3,
        [EnumMember(Value = "Exterior Only Inspection Individual Condominium Unit Appraisal Report")]
        ExteriorOnlyInspectionIndividualCondominiumUnitAppraisalReport = 4,
        [EnumMember(Value = "One Unit Residential Appraisal Field Review Report")]
        OneUnitResidentialAppraisalFieldReviewReport = 5,
        [EnumMember(Value = "Two To Four Unit Residential Appraisal")]
        TwoToFourUnitResidentialAppraisal = 6,
        [EnumMember(Value = "Exterior Only Inspection Residential Appraisal Report")]
        ExteriorOnlyInspectionResidentialAppraisalReport = 7,
        [EnumMember(Value = "Individual Cooperative Interest Appraisal Report")]
        IndividualCooperativeInterestAppraisalReport = 8,
        [EnumMember(Value = "Exterior Only Inspection Individual Cooperative Interest Appraisal Report")]
        ExteriorOnlyInspectionIndividualCooperativeInterestAppraisalReport = 9,
        [EnumMember(Value = "Appraisal Update And Or Completion Report")]
        AppraisalUpdateAndOrCompletionReport = 10,
        [EnumMember(Value = "Desktop Underwriter Property Inspection Report")]
        DesktopUnderwriterPropertyInspectionReport = 11,
        [EnumMember(Value = "Loan Prospector Condition And Marketability")]
        LoanProspectorConditionAndMarketability = 12
    }
}