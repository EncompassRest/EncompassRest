using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FanniePropertyFormType
    /// </summary>
    public enum FanniePropertyFormType
    {
        /// <summary>
        /// FNM 1004 / FRE 70 = Uniform Residential Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 1004 / FRE 70 = Uniform Residential Appraisal Report")]
        FNM1004FRE70UniformResidentialAppraisalReport = 0,
        /// <summary>
        /// FNM 1004C / FRE 70B = Manufactured Home Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 1004C / FRE 70B = Manufactured Home Appraisal Report")]
        FNM1004CFRE70BManufacturedHomeAppraisalReport = 1,
        /// <summary>
        /// FNM 1025 / FRE 72 = Small Residential Income Property Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 1025 / FRE 72 = Small Residential Income Property Appraisal Report")]
        FNM1025FRE72SmallResidentialIncomePropertyAppraisalReport = 3,
        /// <summary>
        /// FNM 1073 / FRE 465 = Individual Condominium Unit Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 1073 / FRE 465 = Individual Condominium Unit Appraisal Report")]
        FNM1073FRE465IndividualCondominiumUnitAppraisalReport = 4,
        /// <summary>
        /// FNM 1075 / FRE 466 = Exterior Only Inspection Individual Condominium Unit Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 1075 / FRE 466 = Exterior Only Inspection Individual Condominium Unit Appraisal Report")]
        FNM1075FRE466ExteriorOnlyInspectionIndividualCondominiumUnitAppraisalReport = 5,
        /// <summary>
        /// FNM 2000 / FRE1032 = One Unit Residential Appraisal Field Review Report
        /// </summary>
        [EnumMember(Value = "FNM 2000 / FRE1032 = One Unit Residential Appraisal Field Review Report")]
        FNM2000FRE1032OneUnitResidentialAppraisalFieldReviewReport = 6,
        /// <summary>
        /// FNM 2000A / FRE 1072 = Two To Four Unit Residential Appraisal
        /// </summary>
        [EnumMember(Value = "FNM 2000A / FRE 1072 = Two To Four Unit Residential Appraisal")]
        FNM2000AFRE1072TwoToFourUnitResidentialAppraisal = 7,
        /// <summary>
        /// FNM 2055 / FRE 2055 = Exterior Only Inspection Residential Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 2055 / FRE 2055 = Exterior Only Inspection Residential Appraisal Report")]
        FNM2055FRE2055ExteriorOnlyInspectionResidentialAppraisalReport = 8,
        /// <summary>
        /// FNM 2090 = Individual Cooperative Interest Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 2090 = Individual Cooperative Interest Appraisal Report")]
        FNM2090IndividualCooperativeInterestAppraisalReport = 9,
        /// <summary>
        /// FNM 2095 = Exterior Only Inspection Individual Cooperative Interest Appraisal Report
        /// </summary>
        [EnumMember(Value = "FNM 2095 = Exterior Only Inspection Individual Cooperative Interest Appraisal Report")]
        FNM2095ExteriorOnlyInspectionIndividualCooperativeInterestAppraisalReport = 10,
        /// <summary>
        /// DU Form 2075 = Desktop Underwriter Property Inspection Report
        /// </summary>
        [EnumMember(Value = "DU Form 2075 = Desktop Underwriter Property Inspection Report")]
        DUForm2075DesktopUnderwriterPropertyInspectionReport = 11,
        /// <summary>
        /// FNM 1004D / FRE 442 = Appraisal Update And Or Completion Report (FRE Removed 5/2017)
        /// </summary>
        [EnumMember(Value = "FNM 1004D / FRE 442 = Appraisal Update And Or Completion Report (FRE Removed 5/2017)")]
        FNM1004DFRE442AppraisalUpdateAndOrCompletionReportFRERemoved52017 = 12
    }
}