using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FanniePropertyFormType
    {
        [EnumMember(Value = "FNM 1004 / FRE 70 = Uniform Residential Appraisal Report")]
        FNM1004FRE70UniformResidentialAppraisalReport = 0,
        [EnumMember(Value = "FNM 1004C / FRE 70B = Manufactured Home Appraisal Report")]
        FNM1004CFRE70BManufacturedHomeAppraisalReport = 1,
        [EnumMember(Value = "FNM 1004D / FRE 442 = Appraisal Update And Or Completion Report")]
        FNM1004DFRE442AppraisalUpdateAndOrCompletionReport = 2,
        [EnumMember(Value = "FNM 1025 / FRE 72 = Small Residential Income Property Appraisal Report")]
        FNM1025FRE72SmallResidentialIncomePropertyAppraisalReport = 3,
        [EnumMember(Value = "FNM 1073 / FRE 465 = Individual Condominium Unit Appraisal Report")]
        FNM1073FRE465IndividualCondominiumUnitAppraisalReport = 4,
        [EnumMember(Value = "FNM 1075 / FRE 466 = Exterior Only Inspection Individual Condominium Unit Appraisal Report")]
        FNM1075FRE466ExteriorOnlyInspectionIndividualCondominiumUnitAppraisalReport = 5,
        [EnumMember(Value = "FNM 2000 / FRE1032 = One Unit Residential Appraisal Field Review Report")]
        FNM2000FRE1032OneUnitResidentialAppraisalFieldReviewReport = 6,
        [EnumMember(Value = "FNM 2000A / FRE 1072 = Two To Four Unit Residential Appraisal")]
        FNM2000AFRE1072TwoToFourUnitResidentialAppraisal = 7,
        [EnumMember(Value = "FNM 2055 / FRE 2055 = Exterior Only Inspection Residential Appraisal Report")]
        FNM2055FRE2055ExteriorOnlyInspectionResidentialAppraisalReport = 8,
        [EnumMember(Value = "FNM 2090 = Individual Cooperative Interest Appraisal Report")]
        FNM2090IndividualCooperativeInterestAppraisalReport = 9,
        [EnumMember(Value = "FNM 2095 = Exterior Only Inspection Individual Cooperative Interest Appraisal Report")]
        FNM2095ExteriorOnlyInspectionIndividualCooperativeInterestAppraisalReport = 10,
        [EnumMember(Value = "DU Form 2075 = Desktop Underwriter Property Inspection Report")]
        DUForm2075DesktopUnderwriterPropertyInspectionReport = 11
    }
}