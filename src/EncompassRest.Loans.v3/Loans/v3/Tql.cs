using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tql
/// </summary>
public sealed partial class Tql : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Citibank 4506T Baseline Report Required [TQL.X59]
    /// </summary>
    public string? Citibank4506TBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Citibank CCVP Baseline Report Required [TQL.X56]
    /// </summary>
    public string? CitibankCcvpBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Citibank Compliance Baseline Report Required [TQL.X58]
    /// </summary>
    public string? CitibankComplianceBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Citibank Flood Baseline Report Required [TQL.X60]
    /// </summary>
    public string? CitibankFloodBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Citibank Fraud Baseline Report Required [TQL.X57]
    /// </summary>
    public string? CitibankFraudBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coll Risk Score Date [TQL.X121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CollRiskScoreDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Cu Risk Score Date [TQL.X113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CuRiskScoreDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Investor Publishing - Current Publishing Status [TQL.X1]
    /// </summary>
    public string? CurrentInvestorPublishingStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Documentation Level Date [TQL.X119]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DocumentationLevelDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DRIVE - AppVerify Score [TQL.X83]
    /// </summary>
    public int? DriveAppVerifyScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DRIVE - IDVerify Score [TQL.X82]
    /// </summary>
    public int? DriveIdVerifyScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DRIVE - Property Verify Score [TQL.X84]
    /// </summary>
    public int? DrivePropertyVerifyScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DRIVE - Score [TQL.X80]
    /// </summary>
    public int? DriveScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DRIVE - Status [TQL.X81]
    /// </summary>
    public string? DriveStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Date Time stamp [TQL.X97]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DuFindingsMessageDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Inspection Property ID [TQL.X95]
    /// </summary>
    public string? DuPropertyDataId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Inspection Status Eligibility [TQL.X96]
    /// </summary>
    public string? DuPropertyDataMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Du Recommendation Date [TQL.X111]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DuRecommendationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Ec Status1003 Date [TQL.X114]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcStatus1003Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Ec Status Uldd Date [TQL.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcStatusUlddDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Appr Waiver Offered Date [TQL.X125]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieApprWaiverOfferedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Asset Rep And Warrant Date [TQL.X127]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieAssetRepAndWarrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Misc Date 1 [TQL.X128]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieMiscDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Misc Date 2 [TQL.X129]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieMiscDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Ucdp Status Date [TQL.X112]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieUcdpStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fannie Value Rep And Warrant Date [TQL.X126]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieValueRepAndWarrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood billing - Flood Order Date [TQL.X105]
    /// </summary>
    public DateTime? FloodOrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood billing - Flood Product Type [TQL.X103]
    /// </summary>
    public string? FloodProductType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood Program Code [TQL.X110]
    /// </summary>
    public StringEnumValue<FloodProgramCode> FloodProgramCode { get => GetValue<StringEnumValue<FloodProgramCode>>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood billing - Flood Received Date [TQL.X106]
    /// </summary>
    public DateTime? FloodReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood billing - Flood Status [TQL.X104]
    /// </summary>
    public string? FloodStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Flood billing - Flood Transaction Type [TQL.X102]
    /// </summary>
    public string? FloodTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Appr Waiver Offered Date [TQL.X130]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieApprWaiverOfferedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Asset Rep And Warrant Date [TQL.X132]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieAssetRepAndWarrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Col Rep And Warrant Date [TQL.X131]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieColRepAndWarrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Income Rep And Warrant Date [TQL.X133]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieIncomeRepAndWarrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Misc Date 1 [TQL.X134]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieMiscDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Misc Date 2 [TQL.X135]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieMiscDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Freddie Ucdp Status Date [TQL.X120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieUcdpStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tql GseTrackers
    /// </summary>
    [AllowNull]
    public IList<GseTracker> GseTrackers { get => GetList<GseTracker>(); set => SetList(value); }

    /// <summary>
    /// Homeward 4506T Baseline Report Required [TQL.X61]
    /// </summary>
    public string? Homeward4506TBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Homeward Compliance Baseline Report Required [TQL.X63]
    /// </summary>
    public string? HomewardComplianceBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Homeward Flood Baseline Report Required [TQL.X64]
    /// </summary>
    public string? HomewardFloodBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Homeward Fraud Baseline Report Required [TQL.X62]
    /// </summary>
    public string? HomewardFraudBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Valuation Service Completed Date [TQL.X31]
    /// </summary>
    public DateTime? LastCcvpCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Confidence Score [TQL.X33]
    /// </summary>
    public string? LastCcvpConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Estimated Value [TQL.X35]
    /// </summary>
    public string? LastCcvpEstimatedValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Forecast Deviation Score [TQL.X34]
    /// </summary>
    public string? LastCcvpForecastDeviationScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report History Pro Result [TQL.X48]
    /// </summary>
    public string? LastCcvpReportHistoryProResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report ID [TQL.X49]
    /// </summary>
    public string? LastCcvpReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Valuation Service Report(s) Ordered [TQL.X32]
    /// </summary>
    public string? LastCcvpReportOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report Pass Result [TQL.X47]
    /// </summary>
    public string? LastCcvpReportPassResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Results for Report Returned [TQL.X36]
    /// </summary>
    public string? LastCcvpResultsReportReturned { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance Completed Date [TQL.X38]
    /// </summary>
    public DateTime? LastComplianceCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Alert Messages [TQL.X41]
    /// </summary>
    public int? LastComplianceNumberOfAlertMessages { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Error Messages [TQL.X45]
    /// </summary>
    public int? LastComplianceNumberOfErrorMessages { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Fail Messages [TQL.X42]
    /// </summary>
    public int? LastComplianceNumberOfFailMessages { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Pass Messages [TQL.X43]
    /// </summary>
    public int? LastComplianceNumberOfPassMessages { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Warning Messages [TQL.X44]
    /// </summary>
    public int? LastComplianceNumberOfWarningMessages { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance Order Type [TQL.X40]
    /// </summary>
    public string? LastComplianceOrderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Product Name of Report Ordered [TQL.X39]
    /// </summary>
    public string? LastComplianceProductNameReportOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Compliance Report ID [TQL.X51]
    /// </summary>
    public string? LastComplianceReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last # Fraud Alerts [TQL.X29]
    /// </summary>
    public int? LastFraudOrderAlerts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Service Completed Date [TQL.X27]
    /// </summary>
    public DateTime? LastFraudOrderCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Service Product [TQL.X28]
    /// </summary>
    public string? LastFraudOrderProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Report ID [TQL.X50]
    /// </summary>
    public string? LastFraudReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Investor Publishing - Last Publishing Investor [TQL.X3]
    /// </summary>
    public string? LastInvestorPublishingInvestor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Investor Publishing - Last Publishing Status Change Date [TQL.X2]
    /// </summary>
    public DateTime? LastInvestorPublishingStatusChangeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing [TQL.X4]
    /// </summary>
    public string? LastInvestorPublishingUserWhoChangeStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP [TQL.X37]
    /// </summary>
    public string? LastUserIdWhoOrderedCcvp { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance [TQL.X46]
    /// </summary>
    public string? LastUserIdWhoOrderedCompliance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Userid of Person Who Ordered Report [TQL.X30]
    /// </summary>
    public string? LastUserIdWhoOrderedFraudOrder { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Lcla Ucd Req Date [TQL.X124]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LclaUcdReqDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - LOMA/LOMR Case Number [TQL.X109]
    /// </summary>
    public string? LomaOrLomrCaseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - LOMA/LOMR Date [TQL.X108]
    /// </summary>
    public DateTime? LomaOrLomrDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - LOMA/LOMR Indicator [TQL.X107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LomaOrLomrIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Message [TQL.X86]
    /// </summary>
    public string? LpAppraisalWaiverMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Offered [TQL.X85]
    /// </summary>
    public bool? LpAppraisalWaiverOffered { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - LPA Purchase Eligibility [TQL.X89]
    /// </summary>
    public string? LpaPurchaseEligibility { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Lpa Purch Elig Date [TQL.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LpaPurchEligDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Lpa Risk Class Date [TQL.X117]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LpaRiskClassDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty [TQL.X91]
    /// </summary>
    public bool? LpAssetRepWarrantyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty Message [TQL.X92]
    /// </summary>
    public string? LpAssetRepWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Collateral Rep and Warranty Message [TQL.X90]
    /// </summary>
    public string? LpCollateralRepWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level [TQL.X87]
    /// </summary>
    public string? LpDocumentationLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level Message [TQL.X88]
    /// </summary>
    public string? LpDocumentationLevelMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty [TQL.X93]
    /// </summary>
    public bool? LpIncomeRepWarrantyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty Message [TQL.X94]
    /// </summary>
    public string? LpIncomeRepWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Lqa Purch Elig Date [TQL.X122]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaPurchEligDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Lqa Risk Assessment Date [TQL.X123]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaRiskAssessmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MIVendors Arch Report Auto Order Indicator [MISERVICE.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsArchAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MIVendors MGIC Report Auto Order Indicator [MISERVICE.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsMgicAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MIVendors Radian Report Auto Order Indicator [MISERVICE.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsRadianAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PHH 4506T Baseline Report Required [TQL.X69]
    /// </summary>
    public string? Phh4506TBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PHH Compliance Baseline Report Required [TQL.X71]
    /// </summary>
    public string? PhhComplianceBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PHH Flood Baseline Report Required [TQL.X72]
    /// </summary>
    public string? PhhFloodBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PHH Fraud Baseline Report Required [TQL.X70]
    /// </summary>
    public string? PhhFraudBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc 1 [TQL.X136]
    /// </summary>
    public string? RwtMisc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc 2 [TQL.X137]
    /// </summary>
    public string? RwtMisc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc 3 [TQL.X138]
    /// </summary>
    public string? RwtMisc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc Date 1 [TQL.X139]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc Date 2 [TQL.X140]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Rwt Misc Date 3 [TQL.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Stonegate 4506T Baseline Report Required [TQL.X65]
    /// </summary>
    public string? Stonegate4506TBaselineReport { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Stonegate Compliance Baseline Report Required [TQL.X67]
    /// </summary>
    public string? StonegateComplianceBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Stonegate Flood Baseline Report Required [TQL.X68]
    /// </summary>
    public string? StonegateFloodBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Stonegate Fraud Baseline Report Required [TQL.X66]
    /// </summary>
    public string? StonegateFraudBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tql TqlComplianceAlerts
    /// </summary>
    [AllowNull]
    public IList<TqlComplianceAlert> TqlComplianceAlerts { get => GetList<TqlComplianceAlert>(); set => SetList(value); }

    /// <summary>
    /// Tql TqlDocuments
    /// </summary>
    [AllowNull]
    public IList<TqlDocument> TqlDocuments { get => GetList<TqlDocument>(); set => SetList(value); }

    /// <summary>
    /// Tql TqlFraudAlerts
    /// </summary>
    [AllowNull]
    public IList<TqlFraudAlert> TqlFraudAlerts { get => GetList<TqlFraudAlert>(); set => SetList(value); }

    /// <summary>
    /// Fraud Alerts - Total # [TQL.X73]
    /// </summary>
    public int? TqlFraudAlertsTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # High [TQL.X74]
    /// </summary>
    public int? TqlFraudAlertsTotalHigh { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # High Unaddressed [TQL.X77]
    /// </summary>
    public int? TqlFraudAlertsTotalHighUnaddressed { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # Low [TQL.X76]
    /// </summary>
    public int? TqlFraudAlertsTotalLow { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # Low Unaddressed [TQL.X79]
    /// </summary>
    public int? TqlFraudAlertsTotalLowUnaddressed { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # Medium [TQL.X75]
    /// </summary>
    public int? TqlFraudAlertsTotalMedium { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fraud Alerts - Total # Medium Unaddressed [TQL.X78]
    /// </summary>
    public int? TqlFraudAlertsTotalMediumUnaddressed { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Ucd Collection Date [TQL.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? UcdCollectionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Wells Fargo 4506T Baseline Report Required [TQL.X52]
    /// </summary>
    public string? WellsFargo4506TBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Wells Fargo Compliance Baseline Report Required [TQL.X54]
    /// </summary>
    public string? WellsFargoComplianceBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Wells Fargo Flood Baseline Report Required [TQL.X55]
    /// </summary>
    public string? WellsFargoFloodBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Wells Fargo Fraud Baseline Report Required [TQL.X53]
    /// </summary>
    public string? WellsFargoFraudBaselineReportRequired { get => GetValue<string?>(); set => SetValue(value); }
}