using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQL
    /// </summary>
    public sealed partial class TQL : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _citibank4506TBaselineReportRequired;
        private DirtyValue<string?>? _citibankCCVPBaselineReportRequired;
        private DirtyValue<string?>? _citibankComplianceBaselineReportRequired;
        private DirtyValue<string?>? _citibankFloodBaselineReportRequired;
        private DirtyValue<string?>? _citibankFraudBaselineReportRequired;
        private DirtyValue<string?>? _currentInvestorPublishingStatus;
        private DirtyValue<int?>? _driveAppVerifyScore;
        private DirtyValue<int?>? _driveIDVerifyScore;
        private DirtyValue<int?>? _drivePropertyVerifyScore;
        private DirtyValue<int?>? _driveScore;
        private DirtyValue<string?>? _driveStatus;
        private DirtyValue<DateTime?>? _dUFindingsMessageDateTime;
        private DirtyValue<string?>? _dUPropertyDataID;
        private DirtyValue<string?>? _dUPropertyDataMessage;
        private DirtyList<GSETracker>? _gSETrackers;
        private DirtyValue<string?>? _homeward4506TBaselineReportRequired;
        private DirtyValue<string?>? _homewardComplianceBaselineReportRequired;
        private DirtyValue<string?>? _homewardFloodBaselineReportRequired;
        private DirtyValue<string?>? _homewardFraudBaselineReportRequired;
        private DirtyValue<string?>? _id;
        private DirtyValue<DateTime?>? _lastCCVPCompletedDate;
        private DirtyValue<string?>? _lastCCVPConfidenceScore;
        private DirtyValue<string?>? _lastCCVPEstimatedValue;
        private DirtyValue<string?>? _lastCCVPForecastDeviationScore;
        private DirtyValue<string?>? _lastCCVPReportHistoryProResult;
        private DirtyValue<string?>? _lastCCVPReportID;
        private DirtyValue<string?>? _lastCCVPReportOrdered;
        private DirtyValue<string?>? _lastCCVPReportPassResult;
        private DirtyValue<string?>? _lastCCVPResultsReportReturned;
        private DirtyValue<DateTime?>? _lastComplianceCompletedDate;
        private DirtyValue<int?>? _lastComplianceNumberOfAlertMessages;
        private DirtyValue<int?>? _lastComplianceNumberOfErrorMessages;
        private DirtyValue<int?>? _lastComplianceNumberOfFailMessages;
        private DirtyValue<int?>? _lastComplianceNumberOfPassMessages;
        private DirtyValue<int?>? _lastComplianceNumberOfWarningMessages;
        private DirtyValue<string?>? _lastComplianceOrderType;
        private DirtyValue<string?>? _lastComplianceProductNameReportOrdered;
        private DirtyValue<string?>? _lastComplianceReportID;
        private DirtyValue<int?>? _lastFraudOrderAlerts;
        private DirtyValue<DateTime?>? _lastFraudOrderCompletedDate;
        private DirtyValue<string?>? _lastFraudOrderProduct;
        private DirtyValue<string?>? _lastFraudReportID;
        private DirtyValue<string?>? _lastInvestorPublishingInvestor;
        private DirtyValue<DateTime?>? _lastInvestorPublishingStatusChangeDate;
        private DirtyValue<string?>? _lastInvestorPublishingUserWhoChangeStatus;
        private DirtyValue<string?>? _lastUserIDWhoOrderedCCVP;
        private DirtyValue<string?>? _lastUserIDWhoOrderedCompliance;
        private DirtyValue<string?>? _lastUserIDWhoOrderedFraudOrder;
        private DirtyValue<string?>? _lPAppraisalWaiverMessage;
        private DirtyValue<bool?>? _lPAppraisalWaiverOffered;
        private DirtyValue<string?>? _lPAPurchaseEligibility;
        private DirtyValue<bool?>? _lPAssetRepWarrantyIndicator;
        private DirtyValue<string?>? _lPAssetRepWarrantyMessage;
        private DirtyValue<string?>? _lPCollateralRepWarrantyMessage;
        private DirtyValue<string?>? _lPDocumentationLevel;
        private DirtyValue<string?>? _lPDocumentationLevelMessage;
        private DirtyValue<bool?>? _lPIncomeRepWarrantyIndicator;
        private DirtyValue<string?>? _lPIncomeRepWarrantyMessage;
        private DirtyValue<bool?>? _mIVendorsArchAutoOrderIndicator;
        private DirtyValue<bool?>? _mIVendorsMgicAutoOrderIndicator;
        private DirtyValue<bool?>? _mIVendorsRadianAutoOrderIndicator;
        private DirtyValue<string?>? _pHH4506TBaselineReportRequired;
        private DirtyValue<string?>? _pHHComplianceBaselineReportRequired;
        private DirtyValue<string?>? _pHHFloodBaselineReportRequired;
        private DirtyValue<string?>? _pHHFraudBaselineReportRequired;
        private DirtyValue<string?>? _stonegate4506TBaselineReport;
        private DirtyValue<string?>? _stonegateComplianceBaselineReportRequired;
        private DirtyValue<string?>? _stonegateFloodBaselineReportRequired;
        private DirtyValue<string?>? _stonegateFraudBaselineReportRequired;
        private DirtyList<TQLComplianceAlert>? _tQLComplianceAlerts;
        private DirtyList<TQLDocument>? _tQLDocuments;
        private DirtyList<TQLFraudAlert>? _tQLFraudAlerts;
        private DirtyValue<int?>? _tQLFraudAlertsTotal;
        private DirtyValue<int?>? _tQLFraudAlertsTotalHigh;
        private DirtyValue<int?>? _tQLFraudAlertsTotalHighUnaddressed;
        private DirtyValue<int?>? _tQLFraudAlertsTotalLow;
        private DirtyValue<int?>? _tQLFraudAlertsTotalLowUnaddressed;
        private DirtyValue<int?>? _tQLFraudAlertsTotalMedium;
        private DirtyValue<int?>? _tQLFraudAlertsTotalMediumUnaddressed;
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
        public string? CitibankCCVPBaselineReportRequired { get => _citibankCCVPBaselineReportRequired; set => SetField(ref _citibankCCVPBaselineReportRequired, value); }

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
        /// TQL - Investor Publishing - Current Publishing Status [TQL.X1]
        /// </summary>
        public string? CurrentInvestorPublishingStatus { get => _currentInvestorPublishingStatus; set => SetField(ref _currentInvestorPublishingStatus, value); }

        /// <summary>
        /// DRIVE - AppVerify Score [TQL.X83]
        /// </summary>
        public int? DriveAppVerifyScore { get => _driveAppVerifyScore; set => SetField(ref _driveAppVerifyScore, value); }

        /// <summary>
        /// DRIVE - IDVerify Score [TQL.X82]
        /// </summary>
        public int? DriveIDVerifyScore { get => _driveIDVerifyScore; set => SetField(ref _driveIDVerifyScore, value); }

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
        public DateTime? DUFindingsMessageDateTime { get => _dUFindingsMessageDateTime; set => SetField(ref _dUFindingsMessageDateTime, value); }

        /// <summary>
        /// Inspection Property ID [TQL.X95]
        /// </summary>
        public string? DUPropertyDataID { get => _dUPropertyDataID; set => SetField(ref _dUPropertyDataID, value); }

        /// <summary>
        /// Inspection Status Eligibility [TQL.X96]
        /// </summary>
        public string? DUPropertyDataMessage { get => _dUPropertyDataMessage; set => SetField(ref _dUPropertyDataMessage, value); }

        /// <summary>
        /// TQL GSETrackers
        /// </summary>
        [AllowNull]
        public IList<GSETracker> GSETrackers { get => GetField(ref _gSETrackers); set => SetField(ref _gSETrackers, value); }

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
        /// TQL Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Completed Date [TQL.X31]
        /// </summary>
        public DateTime? LastCCVPCompletedDate { get => _lastCCVPCompletedDate; set => SetField(ref _lastCCVPCompletedDate, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Confidence Score [TQL.X33]
        /// </summary>
        public string? LastCCVPConfidenceScore { get => _lastCCVPConfidenceScore; set => SetField(ref _lastCCVPConfidenceScore, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Estimated Value [TQL.X35]
        /// </summary>
        public string? LastCCVPEstimatedValue { get => _lastCCVPEstimatedValue; set => SetField(ref _lastCCVPEstimatedValue, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Forecast Deviation Score [TQL.X34]
        /// </summary>
        public string? LastCCVPForecastDeviationScore { get => _lastCCVPForecastDeviationScore; set => SetField(ref _lastCCVPForecastDeviationScore, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report History Pro Result [TQL.X48]
        /// </summary>
        public string? LastCCVPReportHistoryProResult { get => _lastCCVPReportHistoryProResult; set => SetField(ref _lastCCVPReportHistoryProResult, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report ID [TQL.X49]
        /// </summary>
        public string? LastCCVPReportID { get => _lastCCVPReportID; set => SetField(ref _lastCCVPReportID, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Report(s) Ordered [TQL.X32]
        /// </summary>
        public string? LastCCVPReportOrdered { get => _lastCCVPReportOrdered; set => SetField(ref _lastCCVPReportOrdered, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report Pass Result [TQL.X47]
        /// </summary>
        public string? LastCCVPReportPassResult { get => _lastCCVPReportPassResult; set => SetField(ref _lastCCVPReportPassResult, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Results for Report Returned [TQL.X36]
        /// </summary>
        public string? LastCCVPResultsReportReturned { get => _lastCCVPResultsReportReturned; set => SetField(ref _lastCCVPResultsReportReturned, value); }

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
        public string? LastComplianceReportID { get => _lastComplianceReportID; set => SetField(ref _lastComplianceReportID, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last # Fraud Alerts [TQL.X29]
        /// </summary>
        public int? LastFraudOrderAlerts { get => _lastFraudOrderAlerts; set => SetField(ref _lastFraudOrderAlerts, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Completed Date [TQL.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LastFraudOrderCompletedDate { get => _lastFraudOrderCompletedDate; set => SetField(ref _lastFraudOrderCompletedDate, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Product [TQL.X28]
        /// </summary>
        public string? LastFraudOrderProduct { get => _lastFraudOrderProduct; set => SetField(ref _lastFraudOrderProduct, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Report ID [TQL.X50]
        /// </summary>
        public string? LastFraudReportID { get => _lastFraudReportID; set => SetField(ref _lastFraudReportID, value); }

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
        public string? LastUserIDWhoOrderedCCVP { get => _lastUserIDWhoOrderedCCVP; set => SetField(ref _lastUserIDWhoOrderedCCVP, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance [TQL.X46]
        /// </summary>
        public string? LastUserIDWhoOrderedCompliance { get => _lastUserIDWhoOrderedCompliance; set => SetField(ref _lastUserIDWhoOrderedCompliance, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Userid of Person Who Ordered Report [TQL.X30]
        /// </summary>
        public string? LastUserIDWhoOrderedFraudOrder { get => _lastUserIDWhoOrderedFraudOrder; set => SetField(ref _lastUserIDWhoOrderedFraudOrder, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Message [TQL.X86]
        /// </summary>
        public string? LPAppraisalWaiverMessage { get => _lPAppraisalWaiverMessage; set => SetField(ref _lPAppraisalWaiverMessage, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Appraisal Waiver Offered [TQL.X85]
        /// </summary>
        public bool? LPAppraisalWaiverOffered { get => _lPAppraisalWaiverOffered; set => SetField(ref _lPAppraisalWaiverOffered, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - LPA Purchase Eligibility [TQL.X89]
        /// </summary>
        public string? LPAPurchaseEligibility { get => _lPAPurchaseEligibility; set => SetField(ref _lPAPurchaseEligibility, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty [TQL.X91]
        /// </summary>
        public bool? LPAssetRepWarrantyIndicator { get => _lPAssetRepWarrantyIndicator; set => SetField(ref _lPAssetRepWarrantyIndicator, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Asset Rep and Warranty Message [TQL.X92]
        /// </summary>
        public string? LPAssetRepWarrantyMessage { get => _lPAssetRepWarrantyMessage; set => SetField(ref _lPAssetRepWarrantyMessage, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Collateral Rep and Warranty Message [TQL.X90]
        /// </summary>
        public string? LPCollateralRepWarrantyMessage { get => _lPCollateralRepWarrantyMessage; set => SetField(ref _lPCollateralRepWarrantyMessage, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level [TQL.X87]
        /// </summary>
        public string? LPDocumentationLevel { get => _lPDocumentationLevel; set => SetField(ref _lPDocumentationLevel, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Documentation Level Message [TQL.X88]
        /// </summary>
        public string? LPDocumentationLevelMessage { get => _lPDocumentationLevelMessage; set => SetField(ref _lPDocumentationLevelMessage, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty [TQL.X93]
        /// </summary>
        public bool? LPIncomeRepWarrantyIndicator { get => _lPIncomeRepWarrantyIndicator; set => SetField(ref _lPIncomeRepWarrantyIndicator, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Freddie Mac Income Rep and Warranty Message [TQL.X94]
        /// </summary>
        public string? LPIncomeRepWarrantyMessage { get => _lPIncomeRepWarrantyMessage; set => SetField(ref _lPIncomeRepWarrantyMessage, value); }

        /// <summary>
        /// MIVendors Arch Report Auto Order Indicator [MISERVICE.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? MIVendorsArchAutoOrderIndicator { get => _mIVendorsArchAutoOrderIndicator; set => SetField(ref _mIVendorsArchAutoOrderIndicator, value); }

        /// <summary>
        /// MIVendors MGIC Report Auto Order Indicator [MISERVICE.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? MIVendorsMgicAutoOrderIndicator { get => _mIVendorsMgicAutoOrderIndicator; set => SetField(ref _mIVendorsMgicAutoOrderIndicator, value); }

        /// <summary>
        /// MIVendors Radian Report Auto Order Indicator [MISERVICE.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? MIVendorsRadianAutoOrderIndicator { get => _mIVendorsRadianAutoOrderIndicator; set => SetField(ref _mIVendorsRadianAutoOrderIndicator, value); }

        /// <summary>
        /// PHH 4506T Baseline Report Required [TQL.X69]
        /// </summary>
        public string? PHH4506TBaselineReportRequired { get => _pHH4506TBaselineReportRequired; set => SetField(ref _pHH4506TBaselineReportRequired, value); }

        /// <summary>
        /// PHH Compliance Baseline Report Required [TQL.X71]
        /// </summary>
        public string? PHHComplianceBaselineReportRequired { get => _pHHComplianceBaselineReportRequired; set => SetField(ref _pHHComplianceBaselineReportRequired, value); }

        /// <summary>
        /// PHH Flood Baseline Report Required [TQL.X72]
        /// </summary>
        public string? PHHFloodBaselineReportRequired { get => _pHHFloodBaselineReportRequired; set => SetField(ref _pHHFloodBaselineReportRequired, value); }

        /// <summary>
        /// PHH Fraud Baseline Report Required [TQL.X70]
        /// </summary>
        public string? PHHFraudBaselineReportRequired { get => _pHHFraudBaselineReportRequired; set => SetField(ref _pHHFraudBaselineReportRequired, value); }

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
        /// TQL TQLComplianceAlerts
        /// </summary>
        [AllowNull]
        public IList<TQLComplianceAlert> TQLComplianceAlerts { get => GetField(ref _tQLComplianceAlerts); set => SetField(ref _tQLComplianceAlerts, value); }

        /// <summary>
        /// TQL TQLDocuments
        /// </summary>
        [AllowNull]
        public IList<TQLDocument> TQLDocuments { get => GetField(ref _tQLDocuments); set => SetField(ref _tQLDocuments, value); }

        /// <summary>
        /// TQL TQLFraudAlerts
        /// </summary>
        [AllowNull]
        public IList<TQLFraudAlert> TQLFraudAlerts { get => GetField(ref _tQLFraudAlerts); set => SetField(ref _tQLFraudAlerts, value); }

        /// <summary>
        /// Fraud Alerts - Total # [TQL.X73]
        /// </summary>
        public int? TQLFraudAlertsTotal { get => _tQLFraudAlertsTotal; set => SetField(ref _tQLFraudAlertsTotal, value); }

        /// <summary>
        /// Fraud Alerts - Total # High [TQL.X74]
        /// </summary>
        public int? TQLFraudAlertsTotalHigh { get => _tQLFraudAlertsTotalHigh; set => SetField(ref _tQLFraudAlertsTotalHigh, value); }

        /// <summary>
        /// Fraud Alerts - Total # High Unaddressed [TQL.X77]
        /// </summary>
        public int? TQLFraudAlertsTotalHighUnaddressed { get => _tQLFraudAlertsTotalHighUnaddressed; set => SetField(ref _tQLFraudAlertsTotalHighUnaddressed, value); }

        /// <summary>
        /// Fraud Alerts - Total # Low [TQL.X76]
        /// </summary>
        public int? TQLFraudAlertsTotalLow { get => _tQLFraudAlertsTotalLow; set => SetField(ref _tQLFraudAlertsTotalLow, value); }

        /// <summary>
        /// Fraud Alerts - Total # Low Unaddressed [TQL.X79]
        /// </summary>
        public int? TQLFraudAlertsTotalLowUnaddressed { get => _tQLFraudAlertsTotalLowUnaddressed; set => SetField(ref _tQLFraudAlertsTotalLowUnaddressed, value); }

        /// <summary>
        /// Fraud Alerts - Total # Medium [TQL.X75]
        /// </summary>
        public int? TQLFraudAlertsTotalMedium { get => _tQLFraudAlertsTotalMedium; set => SetField(ref _tQLFraudAlertsTotalMedium, value); }

        /// <summary>
        /// Fraud Alerts - Total # Medium Unaddressed [TQL.X78]
        /// </summary>
        public int? TQLFraudAlertsTotalMediumUnaddressed { get => _tQLFraudAlertsTotalMediumUnaddressed; set => SetField(ref _tQLFraudAlertsTotalMediumUnaddressed, value); }

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
}