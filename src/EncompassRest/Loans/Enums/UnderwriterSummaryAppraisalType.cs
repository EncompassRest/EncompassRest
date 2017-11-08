using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UnderwriterSummaryAppraisalType
    {
        URAR = 0,
        [EnumMember(Value = "FHA URAR")]
        FHAURAR = 1,
        [EnumMember(Value = "2055 Drive-by")]
        n2055DriveBy = 2,
        [EnumMember(Value = "2075 Limited Desk Review")]
        n2075LimitedDeskReview = 3,
        [EnumMember(Value = "704 Limited Scope Appraisal Report")]
        n704LimitedScopeAppraisalReport = 4,
        [EnumMember(Value = "Condo Appraisal")]
        CondoAppraisal = 5,
        [EnumMember(Value = "2-4 Small Income Property Appraisal")]
        n24SmallIncomePropertyAppraisal = 6,
        [EnumMember(Value = "1092 Broker Price Opinion")]
        n1092BrokerPriceOpinion = 7,
        [EnumMember(Value = "No appraisal/inspection obtained")]
        NoAppraisalInspectionObtained = 8,
        [EnumMember(Value = "Form 2095 appraisal with exterior only")]
        Form2095AppraisalWithExteriorOnly = 9,
        [EnumMember(Value = "Form 1025 appraisal with interior/exterior")]
        Form1025AppraisalWithInteriorExterior = 10,
        [EnumMember(Value = "Form 1004 appraisal with interior/exterior")]
        Form1004AppraisalWithInteriorExterior = 11,
        [EnumMember(Value = "Prior appraisal used for the transaction")]
        PriorAppraisalUsedForTheTransaction = 12,
        Other = 13,
        [EnumMember(Value = "Form 26-1805, Certificate of Reasonable Value for VA")]
        Form261805CertificateOfReasonableValueForVA = 14,
        [EnumMember(Value = "Form 26-8712, Manufactured Home Appraisal Report for VA")]
        Form268712ManufacturedHomeAppraisalReportForVA = 15,
        [EnumMember(Value = "Form 1004C, Manufactured Home Appraisal Report with interior/exterior inspection")]
        Form1004CManufacturedHomeAppraisalReportWithInteriorExteriorInspection = 16,
        [EnumMember(Value = "Form 1073 condominium appraisal with interior/exterior inspection")]
        Form1073CondominiumAppraisalWithInteriorExteriorInspection = 17,
        [EnumMember(Value = "Form 1075 condominium appraisal with exterior inspection")]
        Form1075CondominiumAppraisalWithExteriorInspection = 18,
        [EnumMember(Value = "Form 2090 cooperative appraisal with interior/exterior inspection")]
        Form2090CooperativeAppraisalWithInteriorExteriorInspection = 19,
        [EnumMember(Value = "Form 1004D appraisal updated/completion report")]
        Form1004DAppraisalUpdatedCompletionReport = 20,
        [EnumMember(Value = "Form 2000 Field review one-unit")]
        Form2000FieldReviewOneUnit = 21,
        [EnumMember(Value = "Form 2000A Field review 2-4")]
        Form2000AFieldReview24 = 22
    }
}