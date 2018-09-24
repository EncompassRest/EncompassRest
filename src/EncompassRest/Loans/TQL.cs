using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQL
    /// </summary>
    public sealed partial class TQL : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _citibank4506TBaselineReportRequired;
        private DirtyValue<string> _citibankCCVPBaselineReportRequired;
        private DirtyValue<string> _citibankComplianceBaselineReportRequired;
        private DirtyValue<string> _citibankFloodBaselineReportRequired;
        private DirtyValue<string> _citibankFraudBaselineReportRequired;
        private DirtyValue<string> _currentInvestorPublishingStatus;
        private DirtyValue<int?> _driveAppVerifyScore;
        private DirtyValue<int?> _driveIDVerifyScore;
        private DirtyValue<int?> _drivePropertyVerifyScore;
        private DirtyValue<int?> _driveScore;
        private DirtyValue<string> _driveStatus;
        private DirtyValue<string> _homeward4506TBaselineReportRequired;
        private DirtyValue<string> _homewardComplianceBaselineReportRequired;
        private DirtyValue<string> _homewardFloodBaselineReportRequired;
        private DirtyValue<string> _homewardFraudBaselineReportRequired;
        private DirtyValue<string> _id;
        private DirtyValue<DateTime?> _lastCCVPCompletedDate;
        private DirtyValue<string> _lastCCVPConfidenceScore;
        private DirtyValue<string> _lastCCVPEstimatedValue;
        private DirtyValue<string> _lastCCVPForecastDeviationScore;
        private DirtyValue<string> _lastCCVPReportHistoryProResult;
        private DirtyValue<string> _lastCCVPReportID;
        private DirtyValue<string> _lastCCVPReportOrdered;
        private DirtyValue<string> _lastCCVPReportPassResult;
        private DirtyValue<string> _lastCCVPResultsReportReturned;
        private DirtyValue<DateTime?> _lastComplianceCompletedDate;
        private DirtyValue<int?> _lastComplianceNumberOfAlertMessages;
        private DirtyValue<int?> _lastComplianceNumberOfErrorMessages;
        private DirtyValue<int?> _lastComplianceNumberOfFailMessages;
        private DirtyValue<int?> _lastComplianceNumberOfPassMessages;
        private DirtyValue<int?> _lastComplianceNumberOfWarningMessages;
        private DirtyValue<string> _lastComplianceOrderType;
        private DirtyValue<string> _lastComplianceProductNameReportOrdered;
        private DirtyValue<string> _lastComplianceReportID;
        private DirtyValue<int?> _lastFraudOrderAlerts;
        private DirtyValue<DateTime?> _lastFraudOrderCompletedDate;
        private DirtyValue<string> _lastFraudOrderProduct;
        private DirtyValue<string> _lastFraudReportID;
        private DirtyValue<string> _lastInvestorPublishingInvestor;
        private DirtyValue<DateTime?> _lastInvestorPublishingStatusChangeDate;
        private DirtyValue<string> _lastInvestorPublishingUserWhoChangeStatus;
        private DirtyValue<string> _lastUserIDWhoOrderedCCVP;
        private DirtyValue<string> _lastUserIDWhoOrderedCompliance;
        private DirtyValue<string> _lastUserIDWhoOrderedFraudOrder;
        private DirtyValue<bool?> _mIVendorsArchAutoOrderIndicator;
        private DirtyValue<bool?> _mIVendorsMgicAutoOrderIndicator;
        private DirtyValue<bool?> _mIVendorsRadianAutoOrderIndicator;
        private DirtyValue<string> _pHH4506TBaselineReportRequired;
        private DirtyValue<string> _pHHComplianceBaselineReportRequired;
        private DirtyValue<string> _pHHFloodBaselineReportRequired;
        private DirtyValue<string> _pHHFraudBaselineReportRequired;
        private DirtyValue<string> _stonegate4506TBaselineReport;
        private DirtyValue<string> _stonegateComplianceBaselineReportRequired;
        private DirtyValue<string> _stonegateFloodBaselineReportRequired;
        private DirtyValue<string> _stonegateFraudBaselineReportRequired;
        private DirtyList<TQLComplianceAlert> _tQLComplianceAlerts;
        private DirtyList<TQLDocument> _tQLDocuments;
        private DirtyList<TQLFraudAlert> _tQLFraudAlerts;
        private DirtyValue<int?> _tQLFraudAlertsTotal;
        private DirtyValue<int?> _tQLFraudAlertsTotalHigh;
        private DirtyValue<int?> _tQLFraudAlertsTotalHighUnaddressed;
        private DirtyValue<int?> _tQLFraudAlertsTotalLow;
        private DirtyValue<int?> _tQLFraudAlertsTotalLowUnaddressed;
        private DirtyValue<int?> _tQLFraudAlertsTotalMedium;
        private DirtyValue<int?> _tQLFraudAlertsTotalMediumUnaddressed;
        private DirtyValue<string> _wellsFargo4506TBaselineReportRequired;
        private DirtyValue<string> _wellsFargoComplianceBaselineReportRequired;
        private DirtyValue<string> _wellsFargoFloodBaselineReportRequired;
        private DirtyValue<string> _wellsFargoFraudBaselineReportRequired;

        /// <summary>
        /// Citibank 4506T Baseline Report Required [TQL.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank 4506T Baseline Report Required")]
        public string Citibank4506TBaselineReportRequired { get => _citibank4506TBaselineReportRequired; set => SetField(ref _citibank4506TBaselineReportRequired, value); }

        /// <summary>
        /// Citibank CCVP Baseline Report Required [TQL.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank CCVP Baseline Report Required")]
        public string CitibankCCVPBaselineReportRequired { get => _citibankCCVPBaselineReportRequired; set => SetField(ref _citibankCCVPBaselineReportRequired, value); }

        /// <summary>
        /// Citibank Compliance Baseline Report Required [TQL.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Compliance Baseline Report Required")]
        public string CitibankComplianceBaselineReportRequired { get => _citibankComplianceBaselineReportRequired; set => SetField(ref _citibankComplianceBaselineReportRequired, value); }

        /// <summary>
        /// Citibank Flood Baseline Report Required [TQL.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Flood Baseline Report Required")]
        public string CitibankFloodBaselineReportRequired { get => _citibankFloodBaselineReportRequired; set => SetField(ref _citibankFloodBaselineReportRequired, value); }

        /// <summary>
        /// Citibank Fraud Baseline Report Required [TQL.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Citibank Fraud Baseline Report Required")]
        public string CitibankFraudBaselineReportRequired { get => _citibankFraudBaselineReportRequired; set => SetField(ref _citibankFraudBaselineReportRequired, value); }

        /// <summary>
        /// TQL - Investor Publishing - Current Publishing Status [TQL.X1]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Current Publishing Status")]
        public string CurrentInvestorPublishingStatus { get => _currentInvestorPublishingStatus; set => SetField(ref _currentInvestorPublishingStatus, value); }

        /// <summary>
        /// DRIVE - AppVerify Score [TQL.X83]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - AppVerify Score")]
        public int? DriveAppVerifyScore { get => _driveAppVerifyScore; set => SetField(ref _driveAppVerifyScore, value); }

        /// <summary>
        /// DRIVE - IDVerify Score [TQL.X82]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - IDVerify Score")]
        public int? DriveIDVerifyScore { get => _driveIDVerifyScore; set => SetField(ref _driveIDVerifyScore, value); }

        /// <summary>
        /// DRIVE - Property Verify Score [TQL.X84]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Property Verify Score")]
        public int? DrivePropertyVerifyScore { get => _drivePropertyVerifyScore; set => SetField(ref _drivePropertyVerifyScore, value); }

        /// <summary>
        /// DRIVE - Score [TQL.X80]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Score")]
        public int? DriveScore { get => _driveScore; set => SetField(ref _driveScore, value); }

        /// <summary>
        /// DRIVE - Status [TQL.X81]
        /// </summary>
        [LoanFieldProperty(Description = "DRIVE - Status")]
        public string DriveStatus { get => _driveStatus; set => SetField(ref _driveStatus, value); }

        /// <summary>
        /// Homeward 4506T Baseline Report Required [TQL.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward 4506T Baseline Report Required")]
        public string Homeward4506TBaselineReportRequired { get => _homeward4506TBaselineReportRequired; set => SetField(ref _homeward4506TBaselineReportRequired, value); }

        /// <summary>
        /// Homeward Compliance Baseline Report Required [TQL.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Compliance Baseline Report Required")]
        public string HomewardComplianceBaselineReportRequired { get => _homewardComplianceBaselineReportRequired; set => SetField(ref _homewardComplianceBaselineReportRequired, value); }

        /// <summary>
        /// Homeward Flood Baseline Report Required [TQL.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Flood Baseline Report Required")]
        public string HomewardFloodBaselineReportRequired { get => _homewardFloodBaselineReportRequired; set => SetField(ref _homewardFloodBaselineReportRequired, value); }

        /// <summary>
        /// Homeward Fraud Baseline Report Required [TQL.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Homeward Fraud Baseline Report Required")]
        public string HomewardFraudBaselineReportRequired { get => _homewardFraudBaselineReportRequired; set => SetField(ref _homewardFraudBaselineReportRequired, value); }

        /// <summary>
        /// TQL Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Completed Date [TQL.X31]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Valuation Service Completed Date")]
        public DateTime? LastCCVPCompletedDate { get => _lastCCVPCompletedDate; set => SetField(ref _lastCCVPCompletedDate, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Confidence Score [TQL.X33]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Confidence Score")]
        public string LastCCVPConfidenceScore { get => _lastCCVPConfidenceScore; set => SetField(ref _lastCCVPConfidenceScore, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Estimated Value [TQL.X35]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Estimated Value")]
        public string LastCCVPEstimatedValue { get => _lastCCVPEstimatedValue; set => SetField(ref _lastCCVPEstimatedValue, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Forecast Deviation Score [TQL.X34]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Forecast Deviation Score")]
        public string LastCCVPForecastDeviationScore { get => _lastCCVPForecastDeviationScore; set => SetField(ref _lastCCVPForecastDeviationScore, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report History Pro Result [TQL.X48]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report History Pro Result")]
        public string LastCCVPReportHistoryProResult { get => _lastCCVPReportHistoryProResult; set => SetField(ref _lastCCVPReportHistoryProResult, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report ID [TQL.X49]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report ID")]
        public string LastCCVPReportID { get => _lastCCVPReportID; set => SetField(ref _lastCCVPReportID, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Valuation Service Report(s) Ordered [TQL.X32]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Valuation Service Report(s) Ordered")]
        public string LastCCVPReportOrdered { get => _lastCCVPReportOrdered; set => SetField(ref _lastCCVPReportOrdered, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last CCVP Report Pass Result [TQL.X47]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last CCVP Report Pass Result")]
        public string LastCCVPReportPassResult { get => _lastCCVPReportPassResult; set => SetField(ref _lastCCVPReportPassResult, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Results for Report Returned [TQL.X36]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Results for Report Returned")]
        public string LastCCVPResultsReportReturned { get => _lastCCVPResultsReportReturned; set => SetField(ref _lastCCVPResultsReportReturned, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance Completed Date [TQL.X38]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance Completed Date")]
        public DateTime? LastComplianceCompletedDate { get => _lastComplianceCompletedDate; set => SetField(ref _lastComplianceCompletedDate, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Alert Messages [TQL.X41]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Alert Messages")]
        public int? LastComplianceNumberOfAlertMessages { get => _lastComplianceNumberOfAlertMessages; set => SetField(ref _lastComplianceNumberOfAlertMessages, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Error Messages [TQL.X45]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Error Messages")]
        public int? LastComplianceNumberOfErrorMessages { get => _lastComplianceNumberOfErrorMessages; set => SetField(ref _lastComplianceNumberOfErrorMessages, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Fail Messages [TQL.X42]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Fail Messages")]
        public int? LastComplianceNumberOfFailMessages { get => _lastComplianceNumberOfFailMessages; set => SetField(ref _lastComplianceNumberOfFailMessages, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Pass Messages [TQL.X43]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Pass Messages")]
        public int? LastComplianceNumberOfPassMessages { get => _lastComplianceNumberOfPassMessages; set => SetField(ref _lastComplianceNumberOfPassMessages, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance # Warning Messages [TQL.X44]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance # Warning Messages")]
        public int? LastComplianceNumberOfWarningMessages { get => _lastComplianceNumberOfWarningMessages; set => SetField(ref _lastComplianceNumberOfWarningMessages, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Compliance Order Type [TQL.X40]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Compliance Order Type")]
        public string LastComplianceOrderType { get => _lastComplianceOrderType; set => SetField(ref _lastComplianceOrderType, value); }

        /// <summary>
        /// TQL - Compliance Orders -  Last Product Name of Report Ordered [TQL.X39]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders -  Last Product Name of Report Ordered")]
        public string LastComplianceProductNameReportOrdered { get => _lastComplianceProductNameReportOrdered; set => SetField(ref _lastComplianceProductNameReportOrdered, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Compliance Report ID [TQL.X51]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Compliance Report ID")]
        public string LastComplianceReportID { get => _lastComplianceReportID; set => SetField(ref _lastComplianceReportID, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last # Fraud Alerts [TQL.X29]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last # Fraud Alerts")]
        public int? LastFraudOrderAlerts { get => _lastFraudOrderAlerts; set => SetField(ref _lastFraudOrderAlerts, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Completed Date [TQL.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, Description = "TQL - Fraud Orders - Last Fraud Service Completed Date")]
        public DateTime? LastFraudOrderCompletedDate { get => _lastFraudOrderCompletedDate; set => SetField(ref _lastFraudOrderCompletedDate, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Service Product [TQL.X28]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Fraud Service Product")]
        public string LastFraudOrderProduct { get => _lastFraudOrderProduct; set => SetField(ref _lastFraudOrderProduct, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Fraud Report ID [TQL.X50]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Fraud Report ID")]
        public string LastFraudReportID { get => _lastFraudReportID; set => SetField(ref _lastFraudReportID, value); }

        /// <summary>
        /// TQL - Investor Publishing - Last Publishing Investor [TQL.X3]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last Publishing Investor")]
        public string LastInvestorPublishingInvestor { get => _lastInvestorPublishingInvestor; set => SetField(ref _lastInvestorPublishingInvestor, value); }

        /// <summary>
        /// TQL - Investor Publishing - Last Publishing Status Change Date [TQL.X2]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last Publishing Status Change Date")]
        public DateTime? LastInvestorPublishingStatusChangeDate { get => _lastInvestorPublishingStatusChangeDate; set => SetField(ref _lastInvestorPublishingStatusChangeDate, value); }

        /// <summary>
        /// TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing [TQL.X4]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Investor Publishing - Last User Name of the Person Who Started or Stopped Publishing")]
        public string LastInvestorPublishingUserWhoChangeStatus { get => _lastInvestorPublishingUserWhoChangeStatus; set => SetField(ref _lastInvestorPublishingUserWhoChangeStatus, value); }

        /// <summary>
        /// TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP [TQL.X37]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - CCVP Orders - Last Userid of Person Who Ordered CCVP")]
        public string LastUserIDWhoOrderedCCVP { get => _lastUserIDWhoOrderedCCVP; set => SetField(ref _lastUserIDWhoOrderedCCVP, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance [TQL.X46]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Compliance Orders - Last Userid of Person Who Ordered Compliance")]
        public string LastUserIDWhoOrderedCompliance { get => _lastUserIDWhoOrderedCompliance; set => SetField(ref _lastUserIDWhoOrderedCompliance, value); }

        /// <summary>
        /// TQL - Fraud Orders - Last Userid of Person Who Ordered Report [TQL.X30]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Fraud Orders - Last Userid of Person Who Ordered Report")]
        public string LastUserIDWhoOrderedFraudOrder { get => _lastUserIDWhoOrderedFraudOrder; set => SetField(ref _lastUserIDWhoOrderedFraudOrder, value); }

        /// <summary>
        /// MIVendors Arch Report Auto Order Indicator [MISERVICE.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors Arch Report Auto Order Indicator")]
        public bool? MIVendorsArchAutoOrderIndicator { get => _mIVendorsArchAutoOrderIndicator; set => SetField(ref _mIVendorsArchAutoOrderIndicator, value); }

        /// <summary>
        /// MIVendors MGIC Report Auto Order Indicator [MISERVICE.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors MGIC Report Auto Order Indicator")]
        public bool? MIVendorsMgicAutoOrderIndicator { get => _mIVendorsMgicAutoOrderIndicator; set => SetField(ref _mIVendorsMgicAutoOrderIndicator, value); }

        /// <summary>
        /// MIVendors Radian Report Auto Order Indicator [MISERVICE.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "MIVendors Radian Report Auto Order Indicator")]
        public bool? MIVendorsRadianAutoOrderIndicator { get => _mIVendorsRadianAutoOrderIndicator; set => SetField(ref _mIVendorsRadianAutoOrderIndicator, value); }

        /// <summary>
        /// PHH 4506T Baseline Report Required [TQL.X69]
        /// </summary>
        [LoanFieldProperty(Description = "PHH 4506T Baseline Report Required")]
        public string PHH4506TBaselineReportRequired { get => _pHH4506TBaselineReportRequired; set => SetField(ref _pHH4506TBaselineReportRequired, value); }

        /// <summary>
        /// PHH Compliance Baseline Report Required [TQL.X71]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Compliance Baseline Report Required")]
        public string PHHComplianceBaselineReportRequired { get => _pHHComplianceBaselineReportRequired; set => SetField(ref _pHHComplianceBaselineReportRequired, value); }

        /// <summary>
        /// PHH Flood Baseline Report Required [TQL.X72]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Flood Baseline Report Required")]
        public string PHHFloodBaselineReportRequired { get => _pHHFloodBaselineReportRequired; set => SetField(ref _pHHFloodBaselineReportRequired, value); }

        /// <summary>
        /// PHH Fraud Baseline Report Required [TQL.X70]
        /// </summary>
        [LoanFieldProperty(Description = "PHH Fraud Baseline Report Required")]
        public string PHHFraudBaselineReportRequired { get => _pHHFraudBaselineReportRequired; set => SetField(ref _pHHFraudBaselineReportRequired, value); }

        /// <summary>
        /// Stonegate 4506T Baseline Report Required [TQL.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate 4506T Baseline Report Required")]
        public string Stonegate4506TBaselineReport { get => _stonegate4506TBaselineReport; set => SetField(ref _stonegate4506TBaselineReport, value); }

        /// <summary>
        /// Stonegate Compliance Baseline Report Required [TQL.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Compliance Baseline Report Required")]
        public string StonegateComplianceBaselineReportRequired { get => _stonegateComplianceBaselineReportRequired; set => SetField(ref _stonegateComplianceBaselineReportRequired, value); }

        /// <summary>
        /// Stonegate Flood Baseline Report Required [TQL.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Flood Baseline Report Required")]
        public string StonegateFloodBaselineReportRequired { get => _stonegateFloodBaselineReportRequired; set => SetField(ref _stonegateFloodBaselineReportRequired, value); }

        /// <summary>
        /// Stonegate Fraud Baseline Report Required [TQL.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Stonegate Fraud Baseline Report Required")]
        public string StonegateFraudBaselineReportRequired { get => _stonegateFraudBaselineReportRequired; set => SetField(ref _stonegateFraudBaselineReportRequired, value); }

        /// <summary>
        /// TQL TQLComplianceAlerts
        /// </summary>
        public IList<TQLComplianceAlert> TQLComplianceAlerts { get => GetField(ref _tQLComplianceAlerts); set => SetField(ref _tQLComplianceAlerts, value); }

        /// <summary>
        /// TQL TQLDocuments
        /// </summary>
        public IList<TQLDocument> TQLDocuments { get => GetField(ref _tQLDocuments); set => SetField(ref _tQLDocuments, value); }

        /// <summary>
        /// TQL TQLFraudAlerts
        /// </summary>
        public IList<TQLFraudAlert> TQLFraudAlerts { get => GetField(ref _tQLFraudAlerts); set => SetField(ref _tQLFraudAlerts, value); }

        /// <summary>
        /// Fraud Alerts - Total # [TQL.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total #")]
        public int? TQLFraudAlertsTotal { get => _tQLFraudAlertsTotal; set => SetField(ref _tQLFraudAlertsTotal, value); }

        /// <summary>
        /// Fraud Alerts - Total # High [TQL.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # High")]
        public int? TQLFraudAlertsTotalHigh { get => _tQLFraudAlertsTotalHigh; set => SetField(ref _tQLFraudAlertsTotalHigh, value); }

        /// <summary>
        /// Fraud Alerts - Total # High Unaddressed [TQL.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # High Unaddressed")]
        public int? TQLFraudAlertsTotalHighUnaddressed { get => _tQLFraudAlertsTotalHighUnaddressed; set => SetField(ref _tQLFraudAlertsTotalHighUnaddressed, value); }

        /// <summary>
        /// Fraud Alerts - Total # Low [TQL.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Low")]
        public int? TQLFraudAlertsTotalLow { get => _tQLFraudAlertsTotalLow; set => SetField(ref _tQLFraudAlertsTotalLow, value); }

        /// <summary>
        /// Fraud Alerts - Total # Low Unaddressed [TQL.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Low Unaddressed")]
        public int? TQLFraudAlertsTotalLowUnaddressed { get => _tQLFraudAlertsTotalLowUnaddressed; set => SetField(ref _tQLFraudAlertsTotalLowUnaddressed, value); }

        /// <summary>
        /// Fraud Alerts - Total # Medium [TQL.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Medium")]
        public int? TQLFraudAlertsTotalMedium { get => _tQLFraudAlertsTotalMedium; set => SetField(ref _tQLFraudAlertsTotalMedium, value); }

        /// <summary>
        /// Fraud Alerts - Total # Medium Unaddressed [TQL.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Alerts - Total # Medium Unaddressed")]
        public int? TQLFraudAlertsTotalMediumUnaddressed { get => _tQLFraudAlertsTotalMediumUnaddressed; set => SetField(ref _tQLFraudAlertsTotalMediumUnaddressed, value); }

        /// <summary>
        /// Wells Fargo 4506T Baseline Report Required [TQL.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo 4506T Baseline Report Required")]
        public string WellsFargo4506TBaselineReportRequired { get => _wellsFargo4506TBaselineReportRequired; set => SetField(ref _wellsFargo4506TBaselineReportRequired, value); }

        /// <summary>
        /// Wells Fargo Compliance Baseline Report Required [TQL.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Compliance Baseline Report Required")]
        public string WellsFargoComplianceBaselineReportRequired { get => _wellsFargoComplianceBaselineReportRequired; set => SetField(ref _wellsFargoComplianceBaselineReportRequired, value); }

        /// <summary>
        /// Wells Fargo Flood Baseline Report Required [TQL.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Flood Baseline Report Required")]
        public string WellsFargoFloodBaselineReportRequired { get => _wellsFargoFloodBaselineReportRequired; set => SetField(ref _wellsFargoFloodBaselineReportRequired, value); }

        /// <summary>
        /// Wells Fargo Fraud Baseline Report Required [TQL.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Wells Fargo Fraud Baseline Report Required")]
        public string WellsFargoFraudBaselineReportRequired { get => _wellsFargoFraudBaselineReportRequired; set => SetField(ref _wellsFargoFraudBaselineReportRequired, value); }
    }
}