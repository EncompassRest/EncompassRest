using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQL
    /// </summary>
    public sealed partial class TQL : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _citibank4506TBaselineReportRequired;
        /// <summary>
        /// Citibank 4506T Baseline Report Required [TQL.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank 4506T Baseline Report Required")]
        public string Citibank4506TBaselineReportRequired { get => _citibank4506TBaselineReportRequired; set => _citibank4506TBaselineReportRequired = value; }
        private DirtyValue<string> _citibankCCVPBaselineReportRequired;
        /// <summary>
        /// Citibank CCVP Baseline Report Required [TQL.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank CCVP Baseline Report Required")]
        public string CitibankCCVPBaselineReportRequired { get => _citibankCCVPBaselineReportRequired; set => _citibankCCVPBaselineReportRequired = value; }
        private DirtyValue<string> _citibankComplianceBaselineReportRequired;
        /// <summary>
        /// Citibank Compliance Baseline Report Required [TQL.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Compliance Baseline Report Required")]
        public string CitibankComplianceBaselineReportRequired { get => _citibankComplianceBaselineReportRequired; set => _citibankComplianceBaselineReportRequired = value; }
        private DirtyValue<string> _citibankFloodBaselineReportRequired;
        /// <summary>
        /// Citibank Flood Baseline Report Required [TQL.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Flood Baseline Report Required")]
        public string CitibankFloodBaselineReportRequired { get => _citibankFloodBaselineReportRequired; set => _citibankFloodBaselineReportRequired = value; }
        private DirtyValue<string> _citibankFraudBaselineReportRequired;
        /// <summary>
        /// Citibank Fraud Baseline Report Required [TQL.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Fraud Baseline Report Required")]
        public string CitibankFraudBaselineReportRequired { get => _citibankFraudBaselineReportRequired; set => _citibankFraudBaselineReportRequired = value; }
        private DirtyValue<string> _currentInvestorPublishingStatus;
        /// <summary>
        /// TQL - Investor Publishing - Current Publishing Status [TQL.X1]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Current Publishing Status")]
        public string CurrentInvestorPublishingStatus { get => _currentInvestorPublishingStatus; set => _currentInvestorPublishingStatus = value; }
        private DirtyValue<int?> _driveAppVerifyScore;
        /// <summary>
        /// DRIVE - AppVerify Score [TQL.X83]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - AppVerify Score")]
        public int? DriveAppVerifyScore { get => _driveAppVerifyScore; set => _driveAppVerifyScore = value; }
        private DirtyValue<int?> _driveIDVerifyScore;
        /// <summary>
        /// DRIVE - IDVerify Score [TQL.X82]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - IDVerify Score")]
        public int? DriveIDVerifyScore { get => _driveIDVerifyScore; set => _driveIDVerifyScore = value; }
        private DirtyValue<int?> _drivePropertyVerifyScore;
        /// <summary>
        /// DRIVE - Property Verify Score [TQL.X84]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Property Verify Score")]
        public int? DrivePropertyVerifyScore { get => _drivePropertyVerifyScore; set => _drivePropertyVerifyScore = value; }
        private DirtyValue<int?> _driveScore;
        /// <summary>
        /// DRIVE - Score [TQL.X80]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Score")]
        public int? DriveScore { get => _driveScore; set => _driveScore = value; }
        private DirtyValue<string> _driveStatus;
        /// <summary>
        /// DRIVE - Status [TQL.X81]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Status")]
        public string DriveStatus { get => _driveStatus; set => _driveStatus = value; }
        private DirtyValue<string> _homeward4506TBaselineReportRequired;
        /// <summary>
        /// Homeward 4506T Baseline Report Required [TQL.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward 4506T Baseline Report Required")]
        public string Homeward4506TBaselineReportRequired { get => _homeward4506TBaselineReportRequired; set => _homeward4506TBaselineReportRequired = value; }
        private DirtyValue<string> _homewardComplianceBaselineReportRequired;
        /// <summary>
        /// Homeward Compliance Baseline Report Required [TQL.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Compliance Baseline Report Required")]
        public string HomewardComplianceBaselineReportRequired { get => _homewardComplianceBaselineReportRequired; set => _homewardComplianceBaselineReportRequired = value; }
        private DirtyValue<string> _homewardFloodBaselineReportRequired;
        /// <summary>
        /// Homeward Flood Baseline Report Required [TQL.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Flood Baseline Report Required")]
        public string HomewardFloodBaselineReportRequired { get => _homewardFloodBaselineReportRequired; set => _homewardFloodBaselineReportRequired = value; }
        private DirtyValue<string> _homewardFraudBaselineReportRequired;
        /// <summary>
        /// Homeward Fraud Baseline Report Required [TQL.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Fraud Baseline Report Required")]
        public string HomewardFraudBaselineReportRequired { get => _homewardFraudBaselineReportRequired; set => _homewardFraudBaselineReportRequired = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// TQL Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _lastCCVPCompletedDate;
        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Completed Date [TQL.X31]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Valuation Service Completed Date")]
        public DateTime? LastCCVPCompletedDate { get => _lastCCVPCompletedDate; set => _lastCCVPCompletedDate = value; }
        private DirtyValue<string> _lastCCVPConfidenceScore;
        /// <summary>
        /// TQL - CCVP Orders - Last Confidence Score [TQL.X33]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Confidence Score")]
        public string LastCCVPConfidenceScore { get => _lastCCVPConfidenceScore; set => _lastCCVPConfidenceScore = value; }
        private DirtyValue<string> _lastCCVPEstimatedValue;
        /// <summary>
        /// TQL - CCVP Orders - Last Estimated Value [TQL.X35]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Estimated Value")]
        public string LastCCVPEstimatedValue { get => _lastCCVPEstimatedValue; set => _lastCCVPEstimatedValue = value; }
        private DirtyValue<string> _lastCCVPForecastDeviationScore;
        /// <summary>
        /// TQL - CCVP Orders - Last Forecast Deviation Score [TQL.X34]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Forecast Deviation Score")]
        public string LastCCVPForecastDeviationScore { get => _lastCCVPForecastDeviationScore; set => _lastCCVPForecastDeviationScore = value; }
        private DirtyValue<string> _lastCCVPReportHistoryProResult;
        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report History Pro Result [TQL.X48]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report History Pro Result")]
        public string LastCCVPReportHistoryProResult { get => _lastCCVPReportHistoryProResult; set => _lastCCVPReportHistoryProResult = value; }
        private DirtyValue<string> _lastCCVPReportID;
        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report ID [TQL.X49]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report ID")]
        public string LastCCVPReportID { get => _lastCCVPReportID; set => _lastCCVPReportID = value; }
        private DirtyValue<string> _lastCCVPReportOrdered;
        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Report(s) Ordered [TQL.X32]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Valuation Service Report(s) Ordered")]
        public string LastCCVPReportOrdered { get => _lastCCVPReportOrdered; set => _lastCCVPReportOrdered = value; }
        private DirtyValue<string> _lastCCVPReportPassResult;
        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report Pass Result [TQL.X47]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report Pass Result")]
        public string LastCCVPReportPassResult { get => _lastCCVPReportPassResult; set => _lastCCVPReportPassResult = value; }
        private DirtyValue<string> _lastCCVPResultsReportReturned;
        /// <summary>
        /// TQL - CCVP Orders - Last Results for Report Returned [TQL.X36]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Results for Report Returned")]
        public string LastCCVPResultsReportReturned { get => _lastCCVPResultsReportReturned; set => _lastCCVPResultsReportReturned = value; }
        private DirtyValue<DateTime?> _lastComplianceCompletedDate;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance Completed Date [TQL.X38]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance Completed Date")]
        public DateTime? LastComplianceCompletedDate { get => _lastComplianceCompletedDate; set => _lastComplianceCompletedDate = value; }
        private DirtyValue<int?> _lastComplianceNumberOfAlertMessages;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Alert Messages [TQL.X41]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Alert Messages")]
        public int? LastComplianceNumberOfAlertMessages { get => _lastComplianceNumberOfAlertMessages; set => _lastComplianceNumberOfAlertMessages = value; }
        private DirtyValue<int?> _lastComplianceNumberOfErrorMessages;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Error Messages [TQL.X45]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Error Messages")]
        public int? LastComplianceNumberOfErrorMessages { get => _lastComplianceNumberOfErrorMessages; set => _lastComplianceNumberOfErrorMessages = value; }
        private DirtyValue<int?> _lastComplianceNumberOfFailMessages;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Fail Messages [TQL.X42]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Fail Messages")]
        public int? LastComplianceNumberOfFailMessages { get => _lastComplianceNumberOfFailMessages; set => _lastComplianceNumberOfFailMessages = value; }
        private DirtyValue<int?> _lastComplianceNumberOfPassMessages;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Pass Messages [TQL.X43]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Pass Messages")]
        public int? LastComplianceNumberOfPassMessages { get => _lastComplianceNumberOfPassMessages; set => _lastComplianceNumberOfPassMessages = value; }
        private DirtyValue<int?> _lastComplianceNumberOfWarningMessages;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Warning Messages [TQL.X44]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Warning Messages")]
        public int? LastComplianceNumberOfWarningMessages { get => _lastComplianceNumberOfWarningMessages; set => _lastComplianceNumberOfWarningMessages = value; }
        private DirtyValue<string> _lastComplianceOrderType;
        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance Order Type [TQL.X40]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance Order Type")]
        public string LastComplianceOrderType { get => _lastComplianceOrderType; set => _lastComplianceOrderType = value; }
        private DirtyValue<string> _lastComplianceProductNameReportOrdered;
        /// <summary>
        /// TQL - Compliance Orders -  Last Product Name of Report Ordered [TQL.X39]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Product Name of Report Ordered")]
        public string LastComplianceProductNameReportOrdered { get => _lastComplianceProductNameReportOrdered; set => _lastComplianceProductNameReportOrdered = value; }
        private DirtyValue<string> _lastComplianceReportID;
        /// <summary>
        /// TQL - Compliance Orders - Last Compliance Report ID [TQL.X51]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Compliance Report ID")]
        public string LastComplianceReportID { get => _lastComplianceReportID; set => _lastComplianceReportID = value; }
        private DirtyValue<int?> _lastFraudOrderAlerts;
        /// <summary>
        /// TQL - Fraud Orders - Last # Fraud Alerts [TQL.X29]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last # Fraud Alerts")]
        public int? LastFraudOrderAlerts { get => _lastFraudOrderAlerts; set => _lastFraudOrderAlerts = value; }
        private DirtyValue<DateTime?> _lastFraudOrderCompletedDate;
        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Completed Date [TQL.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, Description = "TQL - Fraud Orders - Last Fraud Service Completed Date")]
        public DateTime? LastFraudOrderCompletedDate { get => _lastFraudOrderCompletedDate; set => _lastFraudOrderCompletedDate = value; }
        private DirtyValue<string> _lastFraudOrderProduct;
        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Product [TQL.X28]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Fraud Service Product")]
        public string LastFraudOrderProduct { get => _lastFraudOrderProduct; set => _lastFraudOrderProduct = value; }
        private DirtyValue<string> _lastFraudReportID;
        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Report ID [TQL.X50]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Fraud Report ID")]
        public string LastFraudReportID { get => _lastFraudReportID; set => _lastFraudReportID = value; }
        private DirtyValue<string> _lastInvestorPublishingInvestor;
        /// <summary>
        /// TQL - Investor Publishing - Last Publishing Investor [TQL.X3]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last Publishing Investor")]
        public string LastInvestorPublishingInvestor { get => _lastInvestorPublishingInvestor; set => _lastInvestorPublishingInvestor = value; }
        private DirtyValue<DateTime?> _lastInvestorPublishingStatusChangeDate;
        /// <summary>
        /// TQL - Investor Publishing - Last Publishing Status Change Date [TQL.X2]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last Publishing Status Change Date")]
        public DateTime? LastInvestorPublishingStatusChangeDate { get => _lastInvestorPublishingStatusChangeDate; set => _lastInvestorPublishingStatusChangeDate = value; }
        private DirtyValue<string> _lastInvestorPublishingUserWhoChangeStatus;
        /// <summary>
        /// TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing [TQL.X4]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing")]
        public string LastInvestorPublishingUserWhoChangeStatus { get => _lastInvestorPublishingUserWhoChangeStatus; set => _lastInvestorPublishingUserWhoChangeStatus = value; }
        private DirtyValue<string> _lastUserIDWhoOrderedCCVP;
        /// <summary>
        /// TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP [TQL.X37]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP")]
        public string LastUserIDWhoOrderedCCVP { get => _lastUserIDWhoOrderedCCVP; set => _lastUserIDWhoOrderedCCVP = value; }
        private DirtyValue<string> _lastUserIDWhoOrderedCompliance;
        /// <summary>
        /// TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance [TQL.X46]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance")]
        public string LastUserIDWhoOrderedCompliance { get => _lastUserIDWhoOrderedCompliance; set => _lastUserIDWhoOrderedCompliance = value; }
        private DirtyValue<string> _lastUserIDWhoOrderedFraudOrder;
        /// <summary>
        /// TQL - Fraud Orders - Last Userid of Person Who Ordered Report [TQL.X30]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Userid of Person Who Ordered Report")]
        public string LastUserIDWhoOrderedFraudOrder { get => _lastUserIDWhoOrderedFraudOrder; set => _lastUserIDWhoOrderedFraudOrder = value; }
        private DirtyValue<bool?> _mIVendorsArchAutoOrderIndicator;
        /// <summary>
        /// MIVendors Arch Report Auto Order Indicator [MISERVICE.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors Arch Report Auto Order Indicator")]
        public bool? MIVendorsArchAutoOrderIndicator { get => _mIVendorsArchAutoOrderIndicator; set => _mIVendorsArchAutoOrderIndicator = value; }
        private DirtyValue<bool?> _mIVendorsMgicAutoOrderIndicator;
        /// <summary>
        /// MIVendors MGIC Report Auto Order Indicator [MISERVICE.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors MGIC Report Auto Order Indicator")]
        public bool? MIVendorsMgicAutoOrderIndicator { get => _mIVendorsMgicAutoOrderIndicator; set => _mIVendorsMgicAutoOrderIndicator = value; }
        private DirtyValue<bool?> _mIVendorsRadianAutoOrderIndicator;
        /// <summary>
        /// MIVendors Radian Report Auto Order Indicator [MISERVICE.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors Radian Report Auto Order Indicator")]
        public bool? MIVendorsRadianAutoOrderIndicator { get => _mIVendorsRadianAutoOrderIndicator; set => _mIVendorsRadianAutoOrderIndicator = value; }
        private DirtyValue<string> _pHH4506TBaselineReportRequired;
        /// <summary>
        /// PHH 4506T Baseline Report Required [TQL.X69]
        /// </summary>
        [LoanFieldProperty(Description = "PHH 4506T Baseline Report Required")]
        public string PHH4506TBaselineReportRequired { get => _pHH4506TBaselineReportRequired; set => _pHH4506TBaselineReportRequired = value; }
        private DirtyValue<string> _pHHComplianceBaselineReportRequired;
        /// <summary>
        /// PHH Compliance Baseline Report Required [TQL.X71]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Compliance Baseline Report Required")]
        public string PHHComplianceBaselineReportRequired { get => _pHHComplianceBaselineReportRequired; set => _pHHComplianceBaselineReportRequired = value; }
        private DirtyValue<string> _pHHFloodBaselineReportRequired;
        /// <summary>
        /// PHH Flood Baseline Report Required [TQL.X72]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Flood Baseline Report Required")]
        public string PHHFloodBaselineReportRequired { get => _pHHFloodBaselineReportRequired; set => _pHHFloodBaselineReportRequired = value; }
        private DirtyValue<string> _pHHFraudBaselineReportRequired;
        /// <summary>
        /// PHH Fraud Baseline Report Required [TQL.X70]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Fraud Baseline Report Required")]
        public string PHHFraudBaselineReportRequired { get => _pHHFraudBaselineReportRequired; set => _pHHFraudBaselineReportRequired = value; }
        private DirtyValue<string> _stonegate4506TBaselineReport;
        /// <summary>
        /// Stonegate 4506T Baseline Report Required [TQL.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate 4506T Baseline Report Required")]
        public string Stonegate4506TBaselineReport { get => _stonegate4506TBaselineReport; set => _stonegate4506TBaselineReport = value; }
        private DirtyValue<string> _stonegateComplianceBaselineReportRequired;
        /// <summary>
        /// Stonegate Compliance Baseline Report Required [TQL.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Compliance Baseline Report Required")]
        public string StonegateComplianceBaselineReportRequired { get => _stonegateComplianceBaselineReportRequired; set => _stonegateComplianceBaselineReportRequired = value; }
        private DirtyValue<string> _stonegateFloodBaselineReportRequired;
        /// <summary>
        /// Stonegate Flood Baseline Report Required [TQL.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Flood Baseline Report Required")]
        public string StonegateFloodBaselineReportRequired { get => _stonegateFloodBaselineReportRequired; set => _stonegateFloodBaselineReportRequired = value; }
        private DirtyValue<string> _stonegateFraudBaselineReportRequired;
        /// <summary>
        /// Stonegate Fraud Baseline Report Required [TQL.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Fraud Baseline Report Required")]
        public string StonegateFraudBaselineReportRequired { get => _stonegateFraudBaselineReportRequired; set => _stonegateFraudBaselineReportRequired = value; }
        private DirtyList<TQLComplianceAlert> _tQLComplianceAlerts;
        /// <summary>
        /// TQL TQLComplianceAlerts
        /// </summary>
        public IList<TQLComplianceAlert> TQLComplianceAlerts { get => _tQLComplianceAlerts ?? (_tQLComplianceAlerts = new DirtyList<TQLComplianceAlert>()); set => _tQLComplianceAlerts = new DirtyList<TQLComplianceAlert>(value); }
        private DirtyList<TQLDocument> _tQLDocuments;
        /// <summary>
        /// TQL TQLDocuments
        /// </summary>
        public IList<TQLDocument> TQLDocuments { get => _tQLDocuments ?? (_tQLDocuments = new DirtyList<TQLDocument>()); set => _tQLDocuments = new DirtyList<TQLDocument>(value); }
        private DirtyList<TQLFraudAlert> _tQLFraudAlerts;
        /// <summary>
        /// TQL TQLFraudAlerts
        /// </summary>
        public IList<TQLFraudAlert> TQLFraudAlerts { get => _tQLFraudAlerts ?? (_tQLFraudAlerts = new DirtyList<TQLFraudAlert>()); set => _tQLFraudAlerts = new DirtyList<TQLFraudAlert>(value); }
        private DirtyValue<int?> _tQLFraudAlertsTotal;
        /// <summary>
        /// Fraud Alerts - Total # [TQL.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total #")]
        public int? TQLFraudAlertsTotal { get => _tQLFraudAlertsTotal; set => _tQLFraudAlertsTotal = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalHigh;
        /// <summary>
        /// Fraud Alerts - Total # High [TQL.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # High")]
        public int? TQLFraudAlertsTotalHigh { get => _tQLFraudAlertsTotalHigh; set => _tQLFraudAlertsTotalHigh = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalHighUnaddressed;
        /// <summary>
        /// Fraud Alerts - Total # High Unaddressed [TQL.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # High Unaddressed")]
        public int? TQLFraudAlertsTotalHighUnaddressed { get => _tQLFraudAlertsTotalHighUnaddressed; set => _tQLFraudAlertsTotalHighUnaddressed = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalLow;
        /// <summary>
        /// Fraud Alerts - Total # Low [TQL.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Low")]
        public int? TQLFraudAlertsTotalLow { get => _tQLFraudAlertsTotalLow; set => _tQLFraudAlertsTotalLow = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalLowUnaddressed;
        /// <summary>
        /// Fraud Alerts - Total # Low Unaddressed [TQL.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Low Unaddressed")]
        public int? TQLFraudAlertsTotalLowUnaddressed { get => _tQLFraudAlertsTotalLowUnaddressed; set => _tQLFraudAlertsTotalLowUnaddressed = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalMedium;
        /// <summary>
        /// Fraud Alerts - Total # Medium [TQL.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Medium")]
        public int? TQLFraudAlertsTotalMedium { get => _tQLFraudAlertsTotalMedium; set => _tQLFraudAlertsTotalMedium = value; }
        private DirtyValue<int?> _tQLFraudAlertsTotalMediumUnaddressed;
        /// <summary>
        /// Fraud Alerts - Total # Medium Unaddressed [TQL.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Medium Unaddressed")]
        public int? TQLFraudAlertsTotalMediumUnaddressed { get => _tQLFraudAlertsTotalMediumUnaddressed; set => _tQLFraudAlertsTotalMediumUnaddressed = value; }
        private DirtyValue<string> _wellsFargo4506TBaselineReportRequired;
        /// <summary>
        /// Wells Fargo 4506T Baseline Report Required [TQL.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo 4506T Baseline Report Required")]
        public string WellsFargo4506TBaselineReportRequired { get => _wellsFargo4506TBaselineReportRequired; set => _wellsFargo4506TBaselineReportRequired = value; }
        private DirtyValue<string> _wellsFargoComplianceBaselineReportRequired;
        /// <summary>
        /// Wells Fargo Compliance Baseline Report Required [TQL.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Compliance Baseline Report Required")]
        public string WellsFargoComplianceBaselineReportRequired { get => _wellsFargoComplianceBaselineReportRequired; set => _wellsFargoComplianceBaselineReportRequired = value; }
        private DirtyValue<string> _wellsFargoFloodBaselineReportRequired;
        /// <summary>
        /// Wells Fargo Flood Baseline Report Required [TQL.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Flood Baseline Report Required")]
        public string WellsFargoFloodBaselineReportRequired { get => _wellsFargoFloodBaselineReportRequired; set => _wellsFargoFloodBaselineReportRequired = value; }
        private DirtyValue<string> _wellsFargoFraudBaselineReportRequired;
        /// <summary>
        /// Wells Fargo Fraud Baseline Report Required [TQL.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Fraud Baseline Report Required")]
        public string WellsFargoFraudBaselineReportRequired { get => _wellsFargoFraudBaselineReportRequired; set => _wellsFargoFraudBaselineReportRequired = value; }
    }
}