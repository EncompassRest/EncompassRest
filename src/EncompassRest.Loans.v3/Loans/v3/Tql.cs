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
    private DirtyValue<string?>? _citibank4506TBaselineReportRequired;
    private DirtyValue<string?>? _citibankCcvpBaselineReportRequired;
    private DirtyValue<string?>? _citibankComplianceBaselineReportRequired;
    private DirtyValue<string?>? _citibankFloodBaselineReportRequired;
    private DirtyValue<string?>? _citibankFraudBaselineReportRequired;
    private DirtyValue<DateTime?>? _collRiskScoreDate;
    private DirtyValue<DateTime?>? _cuRiskScoreDate;
    private DirtyValue<string?>? _currentInvestorPublishingStatus;
    private DirtyValue<DateTime?>? _documentationLevelDate;
    private DirtyValue<int?>? _driveAppVerifyScore;
    private DirtyValue<int?>? _driveIdVerifyScore;
    private DirtyValue<int?>? _drivePropertyVerifyScore;
    private DirtyValue<int?>? _driveScore;
    private DirtyValue<string?>? _driveStatus;
    private DirtyValue<DateTime?>? _duFindingsMessageDateTime;
    private DirtyValue<string?>? _duPropertyDataId;
    private DirtyValue<string?>? _duPropertyDataMessage;
    private DirtyValue<DateTime?>? _duRecommendationDate;
    private DirtyValue<DateTime?>? _ecStatus1003Date;
    private DirtyValue<DateTime?>? _ecStatusUlddDate;
    private DirtyValue<DateTime?>? _fannieApprWaiverOfferedDate;
    private DirtyValue<DateTime?>? _fannieAssetRepAndWarrantDate;
    private DirtyValue<DateTime?>? _fannieMiscDate1;
    private DirtyValue<DateTime?>? _fannieMiscDate2;
    private DirtyValue<DateTime?>? _fannieUcdpStatusDate;
    private DirtyValue<DateTime?>? _fannieValueRepAndWarrantDate;
    private DirtyValue<DateTime?>? _floodOrderDate;
    private DirtyValue<string?>? _floodProductType;
    private DirtyValue<StringEnumValue<FloodProgramCode>>? _floodProgramCode;
    private DirtyValue<DateTime?>? _floodReceivedDate;
    private DirtyValue<string?>? _floodStatus;
    private DirtyValue<string?>? _floodTransactionType;
    private DirtyValue<DateTime?>? _freddieApprWaiverOfferedDate;
    private DirtyValue<DateTime?>? _freddieAssetRepAndWarrantDate;
    private DirtyValue<DateTime?>? _freddieColRepAndWarrantDate;
    private DirtyValue<DateTime?>? _freddieIncomeRepAndWarrantDate;
    private DirtyValue<DateTime?>? _freddieMiscDate1;
    private DirtyValue<DateTime?>? _freddieMiscDate2;
    private DirtyValue<DateTime?>? _freddieUcdpStatusDate;
    private DirtyList<GseTracker>? _gseTrackers;
    private DirtyValue<string?>? _homeward4506TBaselineReportRequired;
    private DirtyValue<string?>? _homewardComplianceBaselineReportRequired;
    private DirtyValue<string?>? _homewardFloodBaselineReportRequired;
    private DirtyValue<string?>? _homewardFraudBaselineReportRequired;
    private DirtyValue<DateTime?>? _lastCcvpCompletedDate;
    private DirtyValue<string?>? _lastCcvpConfidenceScore;
    private DirtyValue<string?>? _lastCcvpEstimatedValue;
    private DirtyValue<string?>? _lastCcvpForecastDeviationScore;
    private DirtyValue<string?>? _lastCcvpReportHistoryProResult;
    private DirtyValue<string?>? _lastCcvpReportId;
    private DirtyValue<string?>? _lastCcvpReportOrdered;
    private DirtyValue<string?>? _lastCcvpReportPassResult;
    private DirtyValue<string?>? _lastCcvpResultsReportReturned;
    private DirtyValue<DateTime?>? _lastComplianceCompletedDate;
    private DirtyValue<int?>? _lastComplianceNumberOfAlertMessages;
    private DirtyValue<int?>? _lastComplianceNumberOfErrorMessages;
    private DirtyValue<int?>? _lastComplianceNumberOfFailMessages;
    private DirtyValue<int?>? _lastComplianceNumberOfPassMessages;
    private DirtyValue<int?>? _lastComplianceNumberOfWarningMessages;
    private DirtyValue<string?>? _lastComplianceOrderType;
    private DirtyValue<string?>? _lastComplianceProductNameReportOrdered;
    private DirtyValue<string?>? _lastComplianceReportId;
    private DirtyValue<int?>? _lastFraudOrderAlerts;
    private DirtyValue<DateTime?>? _lastFraudOrderCompletedDate;
    private DirtyValue<string?>? _lastFraudOrderProduct;
    private DirtyValue<string?>? _lastFraudReportId;
    private DirtyValue<string?>? _lastInvestorPublishingInvestor;
    private DirtyValue<DateTime?>? _lastInvestorPublishingStatusChangeDate;
    private DirtyValue<string?>? _lastInvestorPublishingUserWhoChangeStatus;
    private DirtyValue<string?>? _lastUserIdWhoOrderedCcvp;
    private DirtyValue<string?>? _lastUserIdWhoOrderedCompliance;
    private DirtyValue<string?>? _lastUserIdWhoOrderedFraudOrder;
    private DirtyValue<DateTime?>? _lclaUcdReqDate;
    private DirtyValue<string?>? _lomaOrLomrCaseNumber;
    private DirtyValue<DateTime?>? _lomaOrLomrDate;
    private DirtyValue<bool?>? _lomaOrLomrIndicator;
    private DirtyValue<string?>? _lpAppraisalWaiverMessage;
    private DirtyValue<bool?>? _lpAppraisalWaiverOffered;
    private DirtyValue<string?>? _lpaPurchaseEligibility;
    private DirtyValue<DateTime?>? _lpaPurchEligDate;
    private DirtyValue<DateTime?>? _lpaRiskClassDate;
    private DirtyValue<bool?>? _lpAssetRepWarrantyIndicator;
    private DirtyValue<string?>? _lpAssetRepWarrantyMessage;
    private DirtyValue<string?>? _lpCollateralRepWarrantyMessage;
    private DirtyValue<string?>? _lpDocumentationLevel;
    private DirtyValue<string?>? _lpDocumentationLevelMessage;
    private DirtyValue<bool?>? _lpIncomeRepWarrantyIndicator;
    private DirtyValue<string?>? _lpIncomeRepWarrantyMessage;
    private DirtyValue<DateTime?>? _lqaPurchEligDate;
    private DirtyValue<DateTime?>? _lqaRiskAssessmentDate;
    private DirtyValue<bool?>? _miVendorsArchAutoOrderIndicator;
    private DirtyValue<bool?>? _miVendorsMgicAutoOrderIndicator;
    private DirtyValue<bool?>? _miVendorsRadianAutoOrderIndicator;
    private DirtyValue<string?>? _phh4506TBaselineReportRequired;
    private DirtyValue<string?>? _phhComplianceBaselineReportRequired;
    private DirtyValue<string?>? _phhFloodBaselineReportRequired;
    private DirtyValue<string?>? _phhFraudBaselineReportRequired;
    private DirtyValue<string?>? _rwtMisc1;
    private DirtyValue<string?>? _rwtMisc2;
    private DirtyValue<string?>? _rwtMisc3;
    private DirtyValue<DateTime?>? _rwtMiscDate1;
    private DirtyValue<DateTime?>? _rwtMiscDate2;
    private DirtyValue<DateTime?>? _rwtMiscDate3;
    private DirtyValue<string?>? _stonegate4506TBaselineReport;
    private DirtyValue<string?>? _stonegateComplianceBaselineReportRequired;
    private DirtyValue<string?>? _stonegateFloodBaselineReportRequired;
    private DirtyValue<string?>? _stonegateFraudBaselineReportRequired;
    private DirtyList<TqlComplianceAlert>? _tqlComplianceAlerts;
    private DirtyList<TqlDocument>? _tqlDocuments;
    private DirtyList<TqlFraudAlert>? _tqlFraudAlerts;
    private DirtyValue<int?>? _tqlFraudAlertsTotal;
    private DirtyValue<int?>? _tqlFraudAlertsTotalHigh;
    private DirtyValue<int?>? _tqlFraudAlertsTotalHighUnaddressed;
    private DirtyValue<int?>? _tqlFraudAlertsTotalLow;
    private DirtyValue<int?>? _tqlFraudAlertsTotalLowUnaddressed;
    private DirtyValue<int?>? _tqlFraudAlertsTotalMedium;
    private DirtyValue<int?>? _tqlFraudAlertsTotalMediumUnaddressed;
    private DirtyValue<DateTime?>? _ucdCollectionDate;
    private DirtyValue<string?>? _wellsFargo4506TBaselineReportRequired;
    private DirtyValue<string?>? _wellsFargoComplianceBaselineReportRequired;
    private DirtyValue<string?>? _wellsFargoFloodBaselineReportRequired;
    private DirtyValue<string?>? _wellsFargoFraudBaselineReportRequired;

    /// <summary>
    /// Citibank 4506T Baseline Report Required [TQL.X59]
    /// </summary>
    public string? Citibank4506TBaselineReportRequired { get => _citibank4506TBaselineReportRequired; set => SetField(ref _citibank4506TBaselineReportRequired, value); }

    /// <summary>
    /// Citibank CCVP Baseline Report Required [TQL.X56]
    /// </summary>
    public string? CitibankCcvpBaselineReportRequired { get => _citibankCcvpBaselineReportRequired; set => SetField(ref _citibankCcvpBaselineReportRequired, value); }

    /// <summary>
    /// Citibank Compliance Baseline Report Required [TQL.X58]
    /// </summary>
    public string? CitibankComplianceBaselineReportRequired { get => _citibankComplianceBaselineReportRequired; set => SetField(ref _citibankComplianceBaselineReportRequired, value); }

    /// <summary>
    /// Citibank Flood Baseline Report Required [TQL.X60]
    /// </summary>
    public string? CitibankFloodBaselineReportRequired { get => _citibankFloodBaselineReportRequired; set => SetField(ref _citibankFloodBaselineReportRequired, value); }

    /// <summary>
    /// Citibank Fraud Baseline Report Required [TQL.X57]
    /// </summary>
    public string? CitibankFraudBaselineReportRequired { get => _citibankFraudBaselineReportRequired; set => SetField(ref _citibankFraudBaselineReportRequired, value); }

    /// <summary>
    /// TQL - Coll Risk Score Date [TQL.X121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CollRiskScoreDate { get => _collRiskScoreDate; set => SetField(ref _collRiskScoreDate, value); }

    /// <summary>
    /// TQL - Cu Risk Score Date [TQL.X113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CuRiskScoreDate { get => _cuRiskScoreDate; set => SetField(ref _cuRiskScoreDate, value); }

    /// <summary>
    /// TQL - Investor Publishing - Current Publishing Status [TQL.X1]
    /// </summary>
    public string? CurrentInvestorPublishingStatus { get => _currentInvestorPublishingStatus; set => SetField(ref _currentInvestorPublishingStatus, value); }

    /// <summary>
    /// TQL - Documentation Level Date [TQL.X119]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DocumentationLevelDate { get => _documentationLevelDate; set => SetField(ref _documentationLevelDate, value); }

    /// <summary>
    /// DRIVE - AppVerify Score [TQL.X83]
    /// </summary>
    public int? DriveAppVerifyScore { get => _driveAppVerifyScore; set => SetField(ref _driveAppVerifyScore, value); }

    /// <summary>
    /// DRIVE - IDVerify Score [TQL.X82]
    /// </summary>
    public int? DriveIdVerifyScore { get => _driveIdVerifyScore; set => SetField(ref _driveIdVerifyScore, value); }

    /// <summary>
    /// DRIVE - Property Verify Score [TQL.X84]
    /// </summary>
    public int? DrivePropertyVerifyScore { get => _drivePropertyVerifyScore; set => SetField(ref _drivePropertyVerifyScore, value); }

    /// <summary>
    /// DRIVE - Score [TQL.X80]
    /// </summary>
    public int? DriveScore { get => _driveScore; set => SetField(ref _driveScore, value); }

    /// <summary>
    /// DRIVE - Status [TQL.X81]
    /// </summary>
    public string? DriveStatus { get => _driveStatus; set => SetField(ref _driveStatus, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Date Time stamp [TQL.X97]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DuFindingsMessageDateTime { get => _duFindingsMessageDateTime; set => SetField(ref _duFindingsMessageDateTime, value); }

    /// <summary>
    /// Inspection Property ID [TQL.X95]
    /// </summary>
    public string? DuPropertyDataId { get => _duPropertyDataId; set => SetField(ref _duPropertyDataId, value); }

    /// <summary>
    /// Inspection Status Eligibility [TQL.X96]
    /// </summary>
    public string? DuPropertyDataMessage { get => _duPropertyDataMessage; set => SetField(ref _duPropertyDataMessage, value); }

    /// <summary>
    /// TQL - Du Recommendation Date [TQL.X111]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DuRecommendationDate { get => _duRecommendationDate; set => SetField(ref _duRecommendationDate, value); }

    /// <summary>
    /// TQL - Ec Status1003 Date [TQL.X114]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcStatus1003Date { get => _ecStatus1003Date; set => SetField(ref _ecStatus1003Date, value); }

    /// <summary>
    /// TQL - Ec Status Uldd Date [TQL.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcStatusUlddDate { get => _ecStatusUlddDate; set => SetField(ref _ecStatusUlddDate, value); }

    /// <summary>
    /// TQL - Fannie Appr Waiver Offered Date [TQL.X125]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieApprWaiverOfferedDate { get => _fannieApprWaiverOfferedDate; set => SetField(ref _fannieApprWaiverOfferedDate, value); }

    /// <summary>
    /// TQL - Fannie Asset Rep And Warrant Date [TQL.X127]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieAssetRepAndWarrantDate { get => _fannieAssetRepAndWarrantDate; set => SetField(ref _fannieAssetRepAndWarrantDate, value); }

    /// <summary>
    /// TQL - Fannie Misc Date 1 [TQL.X128]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieMiscDate1 { get => _fannieMiscDate1; set => SetField(ref _fannieMiscDate1, value); }

    /// <summary>
    /// TQL - Fannie Misc Date 2 [TQL.X129]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieMiscDate2 { get => _fannieMiscDate2; set => SetField(ref _fannieMiscDate2, value); }

    /// <summary>
    /// TQL - Fannie Ucdp Status Date [TQL.X112]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieUcdpStatusDate { get => _fannieUcdpStatusDate; set => SetField(ref _fannieUcdpStatusDate, value); }

    /// <summary>
    /// TQL - Fannie Value Rep And Warrant Date [TQL.X126]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieValueRepAndWarrantDate { get => _fannieValueRepAndWarrantDate; set => SetField(ref _fannieValueRepAndWarrantDate, value); }

    /// <summary>
    /// TQL - Flood billing - Flood Order Date [TQL.X105]
    /// </summary>
    public DateTime? FloodOrderDate { get => _floodOrderDate; set => SetField(ref _floodOrderDate, value); }

    /// <summary>
    /// TQL - Flood billing - Flood Product Type [TQL.X103]
    /// </summary>
    public string? FloodProductType { get => _floodProductType; set => SetField(ref _floodProductType, value); }

    /// <summary>
    /// TQL - Flood Program Code [TQL.X110]
    /// </summary>
    public StringEnumValue<FloodProgramCode> FloodProgramCode { get => _floodProgramCode; set => SetField(ref _floodProgramCode, value); }

    /// <summary>
    /// TQL - Flood billing - Flood Received Date [TQL.X106]
    /// </summary>
    public DateTime? FloodReceivedDate { get => _floodReceivedDate; set => SetField(ref _floodReceivedDate, value); }

    /// <summary>
    /// TQL - Flood billing - Flood Status [TQL.X104]
    /// </summary>
    public string? FloodStatus { get => _floodStatus; set => SetField(ref _floodStatus, value); }

    /// <summary>
    /// TQL - Flood billing - Flood Transaction Type [TQL.X102]
    /// </summary>
    public string? FloodTransactionType { get => _floodTransactionType; set => SetField(ref _floodTransactionType, value); }

    /// <summary>
    /// TQL - Freddie Appr Waiver Offered Date [TQL.X130]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieApprWaiverOfferedDate { get => _freddieApprWaiverOfferedDate; set => SetField(ref _freddieApprWaiverOfferedDate, value); }

    /// <summary>
    /// TQL - Freddie Asset Rep And Warrant Date [TQL.X132]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieAssetRepAndWarrantDate { get => _freddieAssetRepAndWarrantDate; set => SetField(ref _freddieAssetRepAndWarrantDate, value); }

    /// <summary>
    /// TQL - Freddie Col Rep And Warrant Date [TQL.X131]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieColRepAndWarrantDate { get => _freddieColRepAndWarrantDate; set => SetField(ref _freddieColRepAndWarrantDate, value); }

    /// <summary>
    /// TQL - Freddie Income Rep And Warrant Date [TQL.X133]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieIncomeRepAndWarrantDate { get => _freddieIncomeRepAndWarrantDate; set => SetField(ref _freddieIncomeRepAndWarrantDate, value); }

    /// <summary>
    /// TQL - Freddie Misc Date 1 [TQL.X134]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieMiscDate1 { get => _freddieMiscDate1; set => SetField(ref _freddieMiscDate1, value); }

    /// <summary>
    /// TQL - Freddie Misc Date 2 [TQL.X135]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieMiscDate2 { get => _freddieMiscDate2; set => SetField(ref _freddieMiscDate2, value); }

    /// <summary>
    /// TQL - Freddie Ucdp Status Date [TQL.X120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FreddieUcdpStatusDate { get => _freddieUcdpStatusDate; set => SetField(ref _freddieUcdpStatusDate, value); }

    /// <summary>
    /// TqlContract GseTrackers
    /// </summary>
    [AllowNull]
    public IList<GseTracker> GseTrackers { get => GetField(ref _gseTrackers); set => SetField(ref _gseTrackers, value); }

    /// <summary>
    /// Homeward 4506T Baseline Report Required [TQL.X61]
    /// </summary>
    public string? Homeward4506TBaselineReportRequired { get => _homeward4506TBaselineReportRequired; set => SetField(ref _homeward4506TBaselineReportRequired, value); }

    /// <summary>
    /// Homeward Compliance Baseline Report Required [TQL.X63]
    /// </summary>
    public string? HomewardComplianceBaselineReportRequired { get => _homewardComplianceBaselineReportRequired; set => SetField(ref _homewardComplianceBaselineReportRequired, value); }

    /// <summary>
    /// Homeward Flood Baseline Report Required [TQL.X64]
    /// </summary>
    public string? HomewardFloodBaselineReportRequired { get => _homewardFloodBaselineReportRequired; set => SetField(ref _homewardFloodBaselineReportRequired, value); }

    /// <summary>
    /// Homeward Fraud Baseline Report Required [TQL.X62]
    /// </summary>
    public string? HomewardFraudBaselineReportRequired { get => _homewardFraudBaselineReportRequired; set => SetField(ref _homewardFraudBaselineReportRequired, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Valuation Service Completed Date [TQL.X31]
    /// </summary>
    public DateTime? LastCcvpCompletedDate { get => _lastCcvpCompletedDate; set => SetField(ref _lastCcvpCompletedDate, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Confidence Score [TQL.X33]
    /// </summary>
    public string? LastCcvpConfidenceScore { get => _lastCcvpConfidenceScore; set => SetField(ref _lastCcvpConfidenceScore, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Estimated Value [TQL.X35]
    /// </summary>
    public string? LastCcvpEstimatedValue { get => _lastCcvpEstimatedValue; set => SetField(ref _lastCcvpEstimatedValue, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Forecast Deviation Score [TQL.X34]
    /// </summary>
    public string? LastCcvpForecastDeviationScore { get => _lastCcvpForecastDeviationScore; set => SetField(ref _lastCcvpForecastDeviationScore, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report History Pro Result [TQL.X48]
    /// </summary>
    public string? LastCcvpReportHistoryProResult { get => _lastCcvpReportHistoryProResult; set => SetField(ref _lastCcvpReportHistoryProResult, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report ID [TQL.X49]
    /// </summary>
    public string? LastCcvpReportId { get => _lastCcvpReportId; set => SetField(ref _lastCcvpReportId, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Valuation Service Report(s) Ordered [TQL.X32]
    /// </summary>
    public string? LastCcvpReportOrdered { get => _lastCcvpReportOrdered; set => SetField(ref _lastCcvpReportOrdered, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last CCVP Report Pass Result [TQL.X47]
    /// </summary>
    public string? LastCcvpReportPassResult { get => _lastCcvpReportPassResult; set => SetField(ref _lastCcvpReportPassResult, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Results for Report Returned [TQL.X36]
    /// </summary>
    public string? LastCcvpResultsReportReturned { get => _lastCcvpResultsReportReturned; set => SetField(ref _lastCcvpResultsReportReturned, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance Completed Date [TQL.X38]
    /// </summary>
    public DateTime? LastComplianceCompletedDate { get => _lastComplianceCompletedDate; set => SetField(ref _lastComplianceCompletedDate, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Alert Messages [TQL.X41]
    /// </summary>
    public int? LastComplianceNumberOfAlertMessages { get => _lastComplianceNumberOfAlertMessages; set => SetField(ref _lastComplianceNumberOfAlertMessages, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Error Messages [TQL.X45]
    /// </summary>
    public int? LastComplianceNumberOfErrorMessages { get => _lastComplianceNumberOfErrorMessages; set => SetField(ref _lastComplianceNumberOfErrorMessages, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Fail Messages [TQL.X42]
    /// </summary>
    public int? LastComplianceNumberOfFailMessages { get => _lastComplianceNumberOfFailMessages; set => SetField(ref _lastComplianceNumberOfFailMessages, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Pass Messages [TQL.X43]
    /// </summary>
    public int? LastComplianceNumberOfPassMessages { get => _lastComplianceNumberOfPassMessages; set => SetField(ref _lastComplianceNumberOfPassMessages, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance # Warning Messages [TQL.X44]
    /// </summary>
    public int? LastComplianceNumberOfWarningMessages { get => _lastComplianceNumberOfWarningMessages; set => SetField(ref _lastComplianceNumberOfWarningMessages, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Compliance Order Type [TQL.X40]
    /// </summary>
    public string? LastComplianceOrderType { get => _lastComplianceOrderType; set => SetField(ref _lastComplianceOrderType, value); }

    /// <summary>
    /// TQL - Compliance Orders -  Last Product Name of Report Ordered [TQL.X39]
    /// </summary>
    public string? LastComplianceProductNameReportOrdered { get => _lastComplianceProductNameReportOrdered; set => SetField(ref _lastComplianceProductNameReportOrdered, value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Compliance Report ID [TQL.X51]
    /// </summary>
    public string? LastComplianceReportId { get => _lastComplianceReportId; set => SetField(ref _lastComplianceReportId, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last # Fraud Alerts [TQL.X29]
    /// </summary>
    public int? LastFraudOrderAlerts { get => _lastFraudOrderAlerts; set => SetField(ref _lastFraudOrderAlerts, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Service Completed Date [TQL.X27]
    /// </summary>
    public DateTime? LastFraudOrderCompletedDate { get => _lastFraudOrderCompletedDate; set => SetField(ref _lastFraudOrderCompletedDate, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Service Product [TQL.X28]
    /// </summary>
    public string? LastFraudOrderProduct { get => _lastFraudOrderProduct; set => SetField(ref _lastFraudOrderProduct, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Report ID [TQL.X50]
    /// </summary>
    public string? LastFraudReportId { get => _lastFraudReportId; set => SetField(ref _lastFraudReportId, value); }

    /// <summary>
    /// TQL - Investor Publishing - Last Publishing Investor [TQL.X3]
    /// </summary>
    public string? LastInvestorPublishingInvestor { get => _lastInvestorPublishingInvestor; set => SetField(ref _lastInvestorPublishingInvestor, value); }

    /// <summary>
    /// TQL - Investor Publishing - Last Publishing Status Change Date [TQL.X2]
    /// </summary>
    public DateTime? LastInvestorPublishingStatusChangeDate { get => _lastInvestorPublishingStatusChangeDate; set => SetField(ref _lastInvestorPublishingStatusChangeDate, value); }

    /// <summary>
    /// TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing [TQL.X4]
    /// </summary>
    public string? LastInvestorPublishingUserWhoChangeStatus { get => _lastInvestorPublishingUserWhoChangeStatus; set => SetField(ref _lastInvestorPublishingUserWhoChangeStatus, value); }

    /// <summary>
    /// TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP [TQL.X37]
    /// </summary>
    public string? LastUserIdWhoOrderedCcvp { get => _lastUserIdWhoOrderedCcvp; set => SetField(ref _lastUserIdWhoOrderedCcvp, value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance [TQL.X46]
    /// </summary>
    public string? LastUserIdWhoOrderedCompliance { get => _lastUserIdWhoOrderedCompliance; set => SetField(ref _lastUserIdWhoOrderedCompliance, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Userid of Person Who Ordered Report [TQL.X30]
    /// </summary>
    public string? LastUserIdWhoOrderedFraudOrder { get => _lastUserIdWhoOrderedFraudOrder; set => SetField(ref _lastUserIdWhoOrderedFraudOrder, value); }

    /// <summary>
    /// TQL - Lcla Ucd Req Date [TQL.X124]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LclaUcdReqDate { get => _lclaUcdReqDate; set => SetField(ref _lclaUcdReqDate, value); }

    /// <summary>
    /// TQL - LOMA/LOMR Case Number [TQL.X109]
    /// </summary>
    public string? LomaOrLomrCaseNumber { get => _lomaOrLomrCaseNumber; set => SetField(ref _lomaOrLomrCaseNumber, value); }

    /// <summary>
    /// TQL - LOMA/LOMR Date [TQL.X108]
    /// </summary>
    public DateTime? LomaOrLomrDate { get => _lomaOrLomrDate; set => SetField(ref _lomaOrLomrDate, value); }

    /// <summary>
    /// TQL - LOMA/LOMR Indicator [TQL.X107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LomaOrLomrIndicator { get => _lomaOrLomrIndicator; set => SetField(ref _lomaOrLomrIndicator, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Message [TQL.X86]
    /// </summary>
    public string? LpAppraisalWaiverMessage { get => _lpAppraisalWaiverMessage; set => SetField(ref _lpAppraisalWaiverMessage, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Offered [TQL.X85]
    /// </summary>
    public bool? LpAppraisalWaiverOffered { get => _lpAppraisalWaiverOffered; set => SetField(ref _lpAppraisalWaiverOffered, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - LPA Purchase Eligibility [TQL.X89]
    /// </summary>
    public string? LpaPurchaseEligibility { get => _lpaPurchaseEligibility; set => SetField(ref _lpaPurchaseEligibility, value); }

    /// <summary>
    /// TQL - Lpa Purch Elig Date [TQL.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LpaPurchEligDate { get => _lpaPurchEligDate; set => SetField(ref _lpaPurchEligDate, value); }

    /// <summary>
    /// TQL - Lpa Risk Class Date [TQL.X117]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LpaRiskClassDate { get => _lpaRiskClassDate; set => SetField(ref _lpaRiskClassDate, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty [TQL.X91]
    /// </summary>
    public bool? LpAssetRepWarrantyIndicator { get => _lpAssetRepWarrantyIndicator; set => SetField(ref _lpAssetRepWarrantyIndicator, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty Message [TQL.X92]
    /// </summary>
    public string? LpAssetRepWarrantyMessage { get => _lpAssetRepWarrantyMessage; set => SetField(ref _lpAssetRepWarrantyMessage, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Collateral Rep and Warranty Message [TQL.X90]
    /// </summary>
    public string? LpCollateralRepWarrantyMessage { get => _lpCollateralRepWarrantyMessage; set => SetField(ref _lpCollateralRepWarrantyMessage, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level [TQL.X87]
    /// </summary>
    public string? LpDocumentationLevel { get => _lpDocumentationLevel; set => SetField(ref _lpDocumentationLevel, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level Message [TQL.X88]
    /// </summary>
    public string? LpDocumentationLevelMessage { get => _lpDocumentationLevelMessage; set => SetField(ref _lpDocumentationLevelMessage, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty [TQL.X93]
    /// </summary>
    public bool? LpIncomeRepWarrantyIndicator { get => _lpIncomeRepWarrantyIndicator; set => SetField(ref _lpIncomeRepWarrantyIndicator, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty Message [TQL.X94]
    /// </summary>
    public string? LpIncomeRepWarrantyMessage { get => _lpIncomeRepWarrantyMessage; set => SetField(ref _lpIncomeRepWarrantyMessage, value); }

    /// <summary>
    /// TQL - Lqa Purch Elig Date [TQL.X122]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaPurchEligDate { get => _lqaPurchEligDate; set => SetField(ref _lqaPurchEligDate, value); }

    /// <summary>
    /// TQL - Lqa Risk Assessment Date [TQL.X123]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaRiskAssessmentDate { get => _lqaRiskAssessmentDate; set => SetField(ref _lqaRiskAssessmentDate, value); }

    /// <summary>
    /// MIVendors Arch Report Auto Order Indicator [MISERVICE.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsArchAutoOrderIndicator { get => _miVendorsArchAutoOrderIndicator; set => SetField(ref _miVendorsArchAutoOrderIndicator, value); }

    /// <summary>
    /// MIVendors MGIC Report Auto Order Indicator [MISERVICE.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsMgicAutoOrderIndicator { get => _miVendorsMgicAutoOrderIndicator; set => SetField(ref _miVendorsMgicAutoOrderIndicator, value); }

    /// <summary>
    /// MIVendors Radian Report Auto Order Indicator [MISERVICE.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MiVendorsRadianAutoOrderIndicator { get => _miVendorsRadianAutoOrderIndicator; set => SetField(ref _miVendorsRadianAutoOrderIndicator, value); }

    /// <summary>
    /// PHH 4506T Baseline Report Required [TQL.X69]
    /// </summary>
    public string? Phh4506TBaselineReportRequired { get => _phh4506TBaselineReportRequired; set => SetField(ref _phh4506TBaselineReportRequired, value); }

    /// <summary>
    /// PHH Compliance Baseline Report Required [TQL.X71]
    /// </summary>
    public string? PhhComplianceBaselineReportRequired { get => _phhComplianceBaselineReportRequired; set => SetField(ref _phhComplianceBaselineReportRequired, value); }

    /// <summary>
    /// PHH Flood Baseline Report Required [TQL.X72]
    /// </summary>
    public string? PhhFloodBaselineReportRequired { get => _phhFloodBaselineReportRequired; set => SetField(ref _phhFloodBaselineReportRequired, value); }

    /// <summary>
    /// PHH Fraud Baseline Report Required [TQL.X70]
    /// </summary>
    public string? PhhFraudBaselineReportRequired { get => _phhFraudBaselineReportRequired; set => SetField(ref _phhFraudBaselineReportRequired, value); }

    /// <summary>
    /// TQL - Rwt Misc 1 [TQL.X136]
    /// </summary>
    public string? RwtMisc1 { get => _rwtMisc1; set => SetField(ref _rwtMisc1, value); }

    /// <summary>
    /// TQL - Rwt Misc 2 [TQL.X137]
    /// </summary>
    public string? RwtMisc2 { get => _rwtMisc2; set => SetField(ref _rwtMisc2, value); }

    /// <summary>
    /// TQL - Rwt Misc 3 [TQL.X138]
    /// </summary>
    public string? RwtMisc3 { get => _rwtMisc3; set => SetField(ref _rwtMisc3, value); }

    /// <summary>
    /// TQL - Rwt Misc Date 1 [TQL.X139]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate1 { get => _rwtMiscDate1; set => SetField(ref _rwtMiscDate1, value); }

    /// <summary>
    /// TQL - Rwt Misc Date 2 [TQL.X140]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate2 { get => _rwtMiscDate2; set => SetField(ref _rwtMiscDate2, value); }

    /// <summary>
    /// TQL - Rwt Misc Date 3 [TQL.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtMiscDate3 { get => _rwtMiscDate3; set => SetField(ref _rwtMiscDate3, value); }

    /// <summary>
    /// Stonegate 4506T Baseline Report Required [TQL.X65]
    /// </summary>
    public string? Stonegate4506TBaselineReport { get => _stonegate4506TBaselineReport; set => SetField(ref _stonegate4506TBaselineReport, value); }

    /// <summary>
    /// Stonegate Compliance Baseline Report Required [TQL.X67]
    /// </summary>
    public string? StonegateComplianceBaselineReportRequired { get => _stonegateComplianceBaselineReportRequired; set => SetField(ref _stonegateComplianceBaselineReportRequired, value); }

    /// <summary>
    /// Stonegate Flood Baseline Report Required [TQL.X68]
    /// </summary>
    public string? StonegateFloodBaselineReportRequired { get => _stonegateFloodBaselineReportRequired; set => SetField(ref _stonegateFloodBaselineReportRequired, value); }

    /// <summary>
    /// Stonegate Fraud Baseline Report Required [TQL.X66]
    /// </summary>
    public string? StonegateFraudBaselineReportRequired { get => _stonegateFraudBaselineReportRequired; set => SetField(ref _stonegateFraudBaselineReportRequired, value); }

    /// <summary>
    /// TqlContract TqlComplianceAlerts
    /// </summary>
    [AllowNull]
    public IList<TqlComplianceAlert> TqlComplianceAlerts { get => GetField(ref _tqlComplianceAlerts); set => SetField(ref _tqlComplianceAlerts, value); }

    /// <summary>
    /// TqlContract TqlDocuments
    /// </summary>
    [AllowNull]
    public IList<TqlDocument> TqlDocuments { get => GetField(ref _tqlDocuments); set => SetField(ref _tqlDocuments, value); }

    /// <summary>
    /// TqlContract TqlFraudAlerts
    /// </summary>
    [AllowNull]
    public IList<TqlFraudAlert> TqlFraudAlerts { get => GetField(ref _tqlFraudAlerts); set => SetField(ref _tqlFraudAlerts, value); }

    /// <summary>
    /// Fraud Alerts - Total # [TQL.X73]
    /// </summary>
    public int? TqlFraudAlertsTotal { get => _tqlFraudAlertsTotal; set => SetField(ref _tqlFraudAlertsTotal, value); }

    /// <summary>
    /// Fraud Alerts - Total # High [TQL.X74]
    /// </summary>
    public int? TqlFraudAlertsTotalHigh { get => _tqlFraudAlertsTotalHigh; set => SetField(ref _tqlFraudAlertsTotalHigh, value); }

    /// <summary>
    /// Fraud Alerts - Total # High Unaddressed [TQL.X77]
    /// </summary>
    public int? TqlFraudAlertsTotalHighUnaddressed { get => _tqlFraudAlertsTotalHighUnaddressed; set => SetField(ref _tqlFraudAlertsTotalHighUnaddressed, value); }

    /// <summary>
    /// Fraud Alerts - Total # Low [TQL.X76]
    /// </summary>
    public int? TqlFraudAlertsTotalLow { get => _tqlFraudAlertsTotalLow; set => SetField(ref _tqlFraudAlertsTotalLow, value); }

    /// <summary>
    /// Fraud Alerts - Total # Low Unaddressed [TQL.X79]
    /// </summary>
    public int? TqlFraudAlertsTotalLowUnaddressed { get => _tqlFraudAlertsTotalLowUnaddressed; set => SetField(ref _tqlFraudAlertsTotalLowUnaddressed, value); }

    /// <summary>
    /// Fraud Alerts - Total # Medium [TQL.X75]
    /// </summary>
    public int? TqlFraudAlertsTotalMedium { get => _tqlFraudAlertsTotalMedium; set => SetField(ref _tqlFraudAlertsTotalMedium, value); }

    /// <summary>
    /// Fraud Alerts - Total # Medium Unaddressed [TQL.X78]
    /// </summary>
    public int? TqlFraudAlertsTotalMediumUnaddressed { get => _tqlFraudAlertsTotalMediumUnaddressed; set => SetField(ref _tqlFraudAlertsTotalMediumUnaddressed, value); }

    /// <summary>
    /// TQL - Ucd Collection Date [TQL.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? UcdCollectionDate { get => _ucdCollectionDate; set => SetField(ref _ucdCollectionDate, value); }

    /// <summary>
    /// Wells Fargo 4506T Baseline Report Required [TQL.X52]
    /// </summary>
    public string? WellsFargo4506TBaselineReportRequired { get => _wellsFargo4506TBaselineReportRequired; set => SetField(ref _wellsFargo4506TBaselineReportRequired, value); }

    /// <summary>
    /// Wells Fargo Compliance Baseline Report Required [TQL.X54]
    /// </summary>
    public string? WellsFargoComplianceBaselineReportRequired { get => _wellsFargoComplianceBaselineReportRequired; set => SetField(ref _wellsFargoComplianceBaselineReportRequired, value); }

    /// <summary>
    /// Wells Fargo Flood Baseline Report Required [TQL.X55]
    /// </summary>
    public string? WellsFargoFloodBaselineReportRequired { get => _wellsFargoFloodBaselineReportRequired; set => SetField(ref _wellsFargoFloodBaselineReportRequired, value); }

    /// <summary>
    /// Wells Fargo Fraud Baseline Report Required [TQL.X53]
    /// </summary>
    public string? WellsFargoFraudBaselineReportRequired { get => _wellsFargoFraudBaselineReportRequired; set => SetField(ref _wellsFargoFraudBaselineReportRequired, value); }
}