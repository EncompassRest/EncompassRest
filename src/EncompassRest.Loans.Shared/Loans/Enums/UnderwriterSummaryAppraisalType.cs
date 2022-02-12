using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// UnderwriterSummaryAppraisalType
/// </summary>
public enum UnderwriterSummaryAppraisalType
{
    /// <summary>
    /// URAR
    /// </summary>
    URAR = 0,
    /// <summary>
    /// FHA URAR
    /// </summary>
    [EnumMember(Value = "FHA URAR")]
    FHAURAR = 1,
    /// <summary>
    /// 2055 Drive-by
    /// </summary>
    [EnumMember(Value = "2055 Drive-by")]
    n2055DriveBy = 2,
    /// <summary>
    /// 2075 Limited Desk Review
    /// </summary>
    [EnumMember(Value = "2075 Limited Desk Review")]
    n2075LimitedDeskReview = 3,
    /// <summary>
    /// 704 Limited Scope Appraisal Report
    /// </summary>
    [EnumMember(Value = "704 Limited Scope Appraisal Report")]
    n704LimitedScopeAppraisalReport = 4,
    /// <summary>
    /// Condo Appraisal
    /// </summary>
    [EnumMember(Value = "Condo Appraisal")]
    CondoAppraisal = 5,
    /// <summary>
    /// 2-4 Small Income Property Appraisal
    /// </summary>
    [EnumMember(Value = "2-4 Small Income Property Appraisal")]
    n24SmallIncomePropertyAppraisal = 6,
    /// <summary>
    /// 1092 Broker Price Opinion
    /// </summary>
    [EnumMember(Value = "1092 Broker Price Opinion")]
    n1092BrokerPriceOpinion = 7,
    /// <summary>
    /// No appraisal/inspection obtained
    /// </summary>
    [EnumMember(Value = "No appraisal/inspection obtained")]
    NoAppraisalInspectionObtained = 8,
    /// <summary>
    /// Form 2095 appraisal with exterior only
    /// </summary>
    [EnumMember(Value = "Form 2095 appraisal with exterior only")]
    Form2095AppraisalWithExteriorOnly = 9,
    /// <summary>
    /// Form 1025 appraisal with interior/exterior
    /// </summary>
    [EnumMember(Value = "Form 1025 appraisal with interior/exterior")]
    Form1025AppraisalWithInteriorExterior = 10,
    /// <summary>
    /// Form 1004 appraisal with interior/exterior
    /// </summary>
    [EnumMember(Value = "Form 1004 appraisal with interior/exterior")]
    Form1004AppraisalWithInteriorExterior = 11,
    /// <summary>
    /// Prior appraisal used for the transaction
    /// </summary>
    [EnumMember(Value = "Prior appraisal used for the transaction")]
    PriorAppraisalUsedForTheTransaction = 12,
    /// <summary>
    /// Other
    /// </summary>
    Other = 13,
    /// <summary>
    /// Form 26-1805, Certificate of Reasonable Value for VA
    /// </summary>
    [EnumMember(Value = "Form 26-1805, Certificate of Reasonable Value for VA")]
    Form261805CertificateOfReasonableValueForVA = 14,
    /// <summary>
    /// Form 26-8712, Manufactured Home Appraisal Report for VA
    /// </summary>
    [EnumMember(Value = "Form 26-8712, Manufactured Home Appraisal Report for VA")]
    Form268712ManufacturedHomeAppraisalReportForVA = 15,
    /// <summary>
    /// Form 1004C, Manufactured Home Appraisal Report with interior/exterior inspection
    /// </summary>
    [EnumMember(Value = "Form 1004C, Manufactured Home Appraisal Report with interior/exterior inspection")]
    Form1004CManufacturedHomeAppraisalReportWithInteriorExteriorInspection = 16,
    /// <summary>
    /// Form 1073 condominium appraisal with interior/exterior inspection
    /// </summary>
    [EnumMember(Value = "Form 1073 condominium appraisal with interior/exterior inspection")]
    Form1073CondominiumAppraisalWithInteriorExteriorInspection = 17,
    /// <summary>
    /// Form 1075 condominium appraisal with exterior inspection
    /// </summary>
    [EnumMember(Value = "Form 1075 condominium appraisal with exterior inspection")]
    Form1075CondominiumAppraisalWithExteriorInspection = 18,
    /// <summary>
    /// Form 2090 cooperative appraisal with interior/exterior inspection
    /// </summary>
    [EnumMember(Value = "Form 2090 cooperative appraisal with interior/exterior inspection")]
    Form2090CooperativeAppraisalWithInteriorExteriorInspection = 19,
    /// <summary>
    /// Form 1004D appraisal updated/completion report
    /// </summary>
    [EnumMember(Value = "Form 1004D appraisal updated/completion report")]
    Form1004DAppraisalUpdatedCompletionReport = 20,
    /// <summary>
    /// Form 2000 Field review one-unit
    /// </summary>
    [EnumMember(Value = "Form 2000 Field review one-unit")]
    Form2000FieldReviewOneUnit = 21,
    /// <summary>
    /// Form 2000A Field review 2-4
    /// </summary>
    [EnumMember(Value = "Form 2000A Field review 2-4")]
    Form2000AFieldReview24 = 22
}