using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQL : IClean
    {
        private Value<string> _citibank4506TBaselineReportRequired;
        public string Citibank4506TBaselineReportRequired { get { return _citibank4506TBaselineReportRequired; } set { _citibank4506TBaselineReportRequired = value; } }
        private Value<string> _citibankCCVPBaselineReportRequired;
        public string CitibankCCVPBaselineReportRequired { get { return _citibankCCVPBaselineReportRequired; } set { _citibankCCVPBaselineReportRequired = value; } }
        private Value<string> _citibankComplianceBaselineReportRequired;
        public string CitibankComplianceBaselineReportRequired { get { return _citibankComplianceBaselineReportRequired; } set { _citibankComplianceBaselineReportRequired = value; } }
        private Value<string> _citibankFloodBaselineReportRequired;
        public string CitibankFloodBaselineReportRequired { get { return _citibankFloodBaselineReportRequired; } set { _citibankFloodBaselineReportRequired = value; } }
        private Value<string> _citibankFraudBaselineReportRequired;
        public string CitibankFraudBaselineReportRequired { get { return _citibankFraudBaselineReportRequired; } set { _citibankFraudBaselineReportRequired = value; } }
        private Value<string> _currentInvestorPublishingStatus;
        public string CurrentInvestorPublishingStatus { get { return _currentInvestorPublishingStatus; } set { _currentInvestorPublishingStatus = value; } }
        private Value<int?> _driveAppVerifyScore;
        public int? DriveAppVerifyScore { get { return _driveAppVerifyScore; } set { _driveAppVerifyScore = value; } }
        private Value<int?> _driveIDVerifyScore;
        public int? DriveIDVerifyScore { get { return _driveIDVerifyScore; } set { _driveIDVerifyScore = value; } }
        private Value<int?> _drivePropertyVerifyScore;
        public int? DrivePropertyVerifyScore { get { return _drivePropertyVerifyScore; } set { _drivePropertyVerifyScore = value; } }
        private Value<int?> _driveScore;
        public int? DriveScore { get { return _driveScore; } set { _driveScore = value; } }
        private Value<string> _driveStatus;
        public string DriveStatus { get { return _driveStatus; } set { _driveStatus = value; } }
        private Value<string> _homeward4506TBaselineReportRequired;
        public string Homeward4506TBaselineReportRequired { get { return _homeward4506TBaselineReportRequired; } set { _homeward4506TBaselineReportRequired = value; } }
        private Value<string> _homewardComplianceBaselineReportRequired;
        public string HomewardComplianceBaselineReportRequired { get { return _homewardComplianceBaselineReportRequired; } set { _homewardComplianceBaselineReportRequired = value; } }
        private Value<string> _homewardFloodBaselineReportRequired;
        public string HomewardFloodBaselineReportRequired { get { return _homewardFloodBaselineReportRequired; } set { _homewardFloodBaselineReportRequired = value; } }
        private Value<string> _homewardFraudBaselineReportRequired;
        public string HomewardFraudBaselineReportRequired { get { return _homewardFraudBaselineReportRequired; } set { _homewardFraudBaselineReportRequired = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _lastCCVPCompletedDate;
        public DateTime? LastCCVPCompletedDate { get { return _lastCCVPCompletedDate; } set { _lastCCVPCompletedDate = value; } }
        private Value<string> _lastCCVPConfidenceScore;
        public string LastCCVPConfidenceScore { get { return _lastCCVPConfidenceScore; } set { _lastCCVPConfidenceScore = value; } }
        private Value<string> _lastCCVPEstimatedValue;
        public string LastCCVPEstimatedValue { get { return _lastCCVPEstimatedValue; } set { _lastCCVPEstimatedValue = value; } }
        private Value<string> _lastCCVPForecastDeviationScore;
        public string LastCCVPForecastDeviationScore { get { return _lastCCVPForecastDeviationScore; } set { _lastCCVPForecastDeviationScore = value; } }
        private Value<string> _lastCCVPReportHistoryProResult;
        public string LastCCVPReportHistoryProResult { get { return _lastCCVPReportHistoryProResult; } set { _lastCCVPReportHistoryProResult = value; } }
        private Value<string> _lastCCVPReportID;
        public string LastCCVPReportID { get { return _lastCCVPReportID; } set { _lastCCVPReportID = value; } }
        private Value<string> _lastCCVPReportOrdered;
        public string LastCCVPReportOrdered { get { return _lastCCVPReportOrdered; } set { _lastCCVPReportOrdered = value; } }
        private Value<string> _lastCCVPReportPassResult;
        public string LastCCVPReportPassResult { get { return _lastCCVPReportPassResult; } set { _lastCCVPReportPassResult = value; } }
        private Value<string> _lastCCVPResultsReportReturned;
        public string LastCCVPResultsReportReturned { get { return _lastCCVPResultsReportReturned; } set { _lastCCVPResultsReportReturned = value; } }
        private Value<DateTime?> _lastComplianceCompletedDate;
        public DateTime? LastComplianceCompletedDate { get { return _lastComplianceCompletedDate; } set { _lastComplianceCompletedDate = value; } }
        private Value<int?> _lastComplianceNumberOfAlertMessages;
        public int? LastComplianceNumberOfAlertMessages { get { return _lastComplianceNumberOfAlertMessages; } set { _lastComplianceNumberOfAlertMessages = value; } }
        private Value<int?> _lastComplianceNumberOfErrorMessages;
        public int? LastComplianceNumberOfErrorMessages { get { return _lastComplianceNumberOfErrorMessages; } set { _lastComplianceNumberOfErrorMessages = value; } }
        private Value<int?> _lastComplianceNumberOfFailMessages;
        public int? LastComplianceNumberOfFailMessages { get { return _lastComplianceNumberOfFailMessages; } set { _lastComplianceNumberOfFailMessages = value; } }
        private Value<int?> _lastComplianceNumberOfPassMessages;
        public int? LastComplianceNumberOfPassMessages { get { return _lastComplianceNumberOfPassMessages; } set { _lastComplianceNumberOfPassMessages = value; } }
        private Value<int?> _lastComplianceNumberOfWarningMessages;
        public int? LastComplianceNumberOfWarningMessages { get { return _lastComplianceNumberOfWarningMessages; } set { _lastComplianceNumberOfWarningMessages = value; } }
        private Value<string> _lastComplianceOrderType;
        public string LastComplianceOrderType { get { return _lastComplianceOrderType; } set { _lastComplianceOrderType = value; } }
        private Value<string> _lastComplianceProductNameReportOrdered;
        public string LastComplianceProductNameReportOrdered { get { return _lastComplianceProductNameReportOrdered; } set { _lastComplianceProductNameReportOrdered = value; } }
        private Value<string> _lastComplianceReportID;
        public string LastComplianceReportID { get { return _lastComplianceReportID; } set { _lastComplianceReportID = value; } }
        private Value<int?> _lastFraudOrderAlerts;
        public int? LastFraudOrderAlerts { get { return _lastFraudOrderAlerts; } set { _lastFraudOrderAlerts = value; } }
        private Value<DateTime?> _lastFraudOrderCompletedDate;
        public DateTime? LastFraudOrderCompletedDate { get { return _lastFraudOrderCompletedDate; } set { _lastFraudOrderCompletedDate = value; } }
        private Value<string> _lastFraudOrderProduct;
        public string LastFraudOrderProduct { get { return _lastFraudOrderProduct; } set { _lastFraudOrderProduct = value; } }
        private Value<string> _lastFraudReportID;
        public string LastFraudReportID { get { return _lastFraudReportID; } set { _lastFraudReportID = value; } }
        private Value<string> _lastInvestorPublishingInvestor;
        public string LastInvestorPublishingInvestor { get { return _lastInvestorPublishingInvestor; } set { _lastInvestorPublishingInvestor = value; } }
        private Value<DateTime?> _lastInvestorPublishingStatusChangeDate;
        public DateTime? LastInvestorPublishingStatusChangeDate { get { return _lastInvestorPublishingStatusChangeDate; } set { _lastInvestorPublishingStatusChangeDate = value; } }
        private Value<string> _lastInvestorPublishingUserWhoChangeStatus;
        public string LastInvestorPublishingUserWhoChangeStatus { get { return _lastInvestorPublishingUserWhoChangeStatus; } set { _lastInvestorPublishingUserWhoChangeStatus = value; } }
        private Value<string> _lastUserIDWhoOrderedCCVP;
        public string LastUserIDWhoOrderedCCVP { get { return _lastUserIDWhoOrderedCCVP; } set { _lastUserIDWhoOrderedCCVP = value; } }
        private Value<string> _lastUserIDWhoOrderedCompliance;
        public string LastUserIDWhoOrderedCompliance { get { return _lastUserIDWhoOrderedCompliance; } set { _lastUserIDWhoOrderedCompliance = value; } }
        private Value<string> _lastUserIDWhoOrderedFraudOrder;
        public string LastUserIDWhoOrderedFraudOrder { get { return _lastUserIDWhoOrderedFraudOrder; } set { _lastUserIDWhoOrderedFraudOrder = value; } }
        private Value<bool?> _mIVendorsArchAutoOrderIndicator;
        public bool? MIVendorsArchAutoOrderIndicator { get { return _mIVendorsArchAutoOrderIndicator; } set { _mIVendorsArchAutoOrderIndicator = value; } }
        private Value<bool?> _mIVendorsMgicAutoOrderIndicator;
        public bool? MIVendorsMgicAutoOrderIndicator { get { return _mIVendorsMgicAutoOrderIndicator; } set { _mIVendorsMgicAutoOrderIndicator = value; } }
        private Value<bool?> _mIVendorsRadianAutoOrderIndicator;
        public bool? MIVendorsRadianAutoOrderIndicator { get { return _mIVendorsRadianAutoOrderIndicator; } set { _mIVendorsRadianAutoOrderIndicator = value; } }
        private Value<string> _pHH4506TBaselineReportRequired;
        public string PHH4506TBaselineReportRequired { get { return _pHH4506TBaselineReportRequired; } set { _pHH4506TBaselineReportRequired = value; } }
        private Value<string> _pHHComplianceBaselineReportRequired;
        public string PHHComplianceBaselineReportRequired { get { return _pHHComplianceBaselineReportRequired; } set { _pHHComplianceBaselineReportRequired = value; } }
        private Value<string> _pHHFloodBaselineReportRequired;
        public string PHHFloodBaselineReportRequired { get { return _pHHFloodBaselineReportRequired; } set { _pHHFloodBaselineReportRequired = value; } }
        private Value<string> _pHHFraudBaselineReportRequired;
        public string PHHFraudBaselineReportRequired { get { return _pHHFraudBaselineReportRequired; } set { _pHHFraudBaselineReportRequired = value; } }
        private Value<string> _stonegate4506TBaselineReport;
        public string Stonegate4506TBaselineReport { get { return _stonegate4506TBaselineReport; } set { _stonegate4506TBaselineReport = value; } }
        private Value<string> _stonegateComplianceBaselineReportRequired;
        public string StonegateComplianceBaselineReportRequired { get { return _stonegateComplianceBaselineReportRequired; } set { _stonegateComplianceBaselineReportRequired = value; } }
        private Value<string> _stonegateFloodBaselineReportRequired;
        public string StonegateFloodBaselineReportRequired { get { return _stonegateFloodBaselineReportRequired; } set { _stonegateFloodBaselineReportRequired = value; } }
        private Value<string> _stonegateFraudBaselineReportRequired;
        public string StonegateFraudBaselineReportRequired { get { return _stonegateFraudBaselineReportRequired; } set { _stonegateFraudBaselineReportRequired = value; } }
        private Value<List<TQLComplianceAlert>> _tQLComplianceAlerts;
        public List<TQLComplianceAlert> TQLComplianceAlerts { get { return _tQLComplianceAlerts; } set { _tQLComplianceAlerts = value; } }
        private Value<List<TQLDocument>> _tQLDocuments;
        public List<TQLDocument> TQLDocuments { get { return _tQLDocuments; } set { _tQLDocuments = value; } }
        private Value<List<TQLFraudAlert>> _tQLFraudAlerts;
        public List<TQLFraudAlert> TQLFraudAlerts { get { return _tQLFraudAlerts; } set { _tQLFraudAlerts = value; } }
        private Value<int?> _tQLFraudAlertsTotal;
        public int? TQLFraudAlertsTotal { get { return _tQLFraudAlertsTotal; } set { _tQLFraudAlertsTotal = value; } }
        private Value<int?> _tQLFraudAlertsTotalHigh;
        public int? TQLFraudAlertsTotalHigh { get { return _tQLFraudAlertsTotalHigh; } set { _tQLFraudAlertsTotalHigh = value; } }
        private Value<int?> _tQLFraudAlertsTotalHighUnaddressed;
        public int? TQLFraudAlertsTotalHighUnaddressed { get { return _tQLFraudAlertsTotalHighUnaddressed; } set { _tQLFraudAlertsTotalHighUnaddressed = value; } }
        private Value<int?> _tQLFraudAlertsTotalLow;
        public int? TQLFraudAlertsTotalLow { get { return _tQLFraudAlertsTotalLow; } set { _tQLFraudAlertsTotalLow = value; } }
        private Value<int?> _tQLFraudAlertsTotalLowUnaddressed;
        public int? TQLFraudAlertsTotalLowUnaddressed { get { return _tQLFraudAlertsTotalLowUnaddressed; } set { _tQLFraudAlertsTotalLowUnaddressed = value; } }
        private Value<int?> _tQLFraudAlertsTotalMedium;
        public int? TQLFraudAlertsTotalMedium { get { return _tQLFraudAlertsTotalMedium; } set { _tQLFraudAlertsTotalMedium = value; } }
        private Value<int?> _tQLFraudAlertsTotalMediumUnaddressed;
        public int? TQLFraudAlertsTotalMediumUnaddressed { get { return _tQLFraudAlertsTotalMediumUnaddressed; } set { _tQLFraudAlertsTotalMediumUnaddressed = value; } }
        private Value<string> _wellsFargo4506TBaselineReportRequired;
        public string WellsFargo4506TBaselineReportRequired { get { return _wellsFargo4506TBaselineReportRequired; } set { _wellsFargo4506TBaselineReportRequired = value; } }
        private Value<string> _wellsFargoComplianceBaselineReportRequired;
        public string WellsFargoComplianceBaselineReportRequired { get { return _wellsFargoComplianceBaselineReportRequired; } set { _wellsFargoComplianceBaselineReportRequired = value; } }
        private Value<string> _wellsFargoFloodBaselineReportRequired;
        public string WellsFargoFloodBaselineReportRequired { get { return _wellsFargoFloodBaselineReportRequired; } set { _wellsFargoFloodBaselineReportRequired = value; } }
        private Value<string> _wellsFargoFraudBaselineReportRequired;
        public string WellsFargoFraudBaselineReportRequired { get { return _wellsFargoFraudBaselineReportRequired; } set { _wellsFargoFraudBaselineReportRequired = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _citibank4506TBaselineReportRequired.Clean
                    && _citibankCCVPBaselineReportRequired.Clean
                    && _citibankComplianceBaselineReportRequired.Clean
                    && _citibankFloodBaselineReportRequired.Clean
                    && _citibankFraudBaselineReportRequired.Clean
                    && _currentInvestorPublishingStatus.Clean
                    && _driveAppVerifyScore.Clean
                    && _driveIDVerifyScore.Clean
                    && _drivePropertyVerifyScore.Clean
                    && _driveScore.Clean
                    && _driveStatus.Clean
                    && _homeward4506TBaselineReportRequired.Clean
                    && _homewardComplianceBaselineReportRequired.Clean
                    && _homewardFloodBaselineReportRequired.Clean
                    && _homewardFraudBaselineReportRequired.Clean
                    && _id.Clean
                    && _lastCCVPCompletedDate.Clean
                    && _lastCCVPConfidenceScore.Clean
                    && _lastCCVPEstimatedValue.Clean
                    && _lastCCVPForecastDeviationScore.Clean
                    && _lastCCVPReportHistoryProResult.Clean
                    && _lastCCVPReportID.Clean
                    && _lastCCVPReportOrdered.Clean
                    && _lastCCVPReportPassResult.Clean
                    && _lastCCVPResultsReportReturned.Clean
                    && _lastComplianceCompletedDate.Clean
                    && _lastComplianceNumberOfAlertMessages.Clean
                    && _lastComplianceNumberOfErrorMessages.Clean
                    && _lastComplianceNumberOfFailMessages.Clean
                    && _lastComplianceNumberOfPassMessages.Clean
                    && _lastComplianceNumberOfWarningMessages.Clean
                    && _lastComplianceOrderType.Clean
                    && _lastComplianceProductNameReportOrdered.Clean
                    && _lastComplianceReportID.Clean
                    && _lastFraudOrderAlerts.Clean
                    && _lastFraudOrderCompletedDate.Clean
                    && _lastFraudOrderProduct.Clean
                    && _lastFraudReportID.Clean
                    && _lastInvestorPublishingInvestor.Clean
                    && _lastInvestorPublishingStatusChangeDate.Clean
                    && _lastInvestorPublishingUserWhoChangeStatus.Clean
                    && _lastUserIDWhoOrderedCCVP.Clean
                    && _lastUserIDWhoOrderedCompliance.Clean
                    && _lastUserIDWhoOrderedFraudOrder.Clean
                    && _mIVendorsArchAutoOrderIndicator.Clean
                    && _mIVendorsMgicAutoOrderIndicator.Clean
                    && _mIVendorsRadianAutoOrderIndicator.Clean
                    && _pHH4506TBaselineReportRequired.Clean
                    && _pHHComplianceBaselineReportRequired.Clean
                    && _pHHFloodBaselineReportRequired.Clean
                    && _pHHFraudBaselineReportRequired.Clean
                    && _stonegate4506TBaselineReport.Clean
                    && _stonegateComplianceBaselineReportRequired.Clean
                    && _stonegateFloodBaselineReportRequired.Clean
                    && _stonegateFraudBaselineReportRequired.Clean
                    && _tQLComplianceAlerts.Clean
                    && _tQLDocuments.Clean
                    && _tQLFraudAlerts.Clean
                    && _tQLFraudAlertsTotal.Clean
                    && _tQLFraudAlertsTotalHigh.Clean
                    && _tQLFraudAlertsTotalHighUnaddressed.Clean
                    && _tQLFraudAlertsTotalLow.Clean
                    && _tQLFraudAlertsTotalLowUnaddressed.Clean
                    && _tQLFraudAlertsTotalMedium.Clean
                    && _tQLFraudAlertsTotalMediumUnaddressed.Clean
                    && _wellsFargo4506TBaselineReportRequired.Clean
                    && _wellsFargoComplianceBaselineReportRequired.Clean
                    && _wellsFargoFloodBaselineReportRequired.Clean
                    && _wellsFargoFraudBaselineReportRequired.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var citibank4506TBaselineReportRequired = _citibank4506TBaselineReportRequired; citibank4506TBaselineReportRequired.Clean = value; _citibank4506TBaselineReportRequired = citibank4506TBaselineReportRequired;
                var citibankCCVPBaselineReportRequired = _citibankCCVPBaselineReportRequired; citibankCCVPBaselineReportRequired.Clean = value; _citibankCCVPBaselineReportRequired = citibankCCVPBaselineReportRequired;
                var citibankComplianceBaselineReportRequired = _citibankComplianceBaselineReportRequired; citibankComplianceBaselineReportRequired.Clean = value; _citibankComplianceBaselineReportRequired = citibankComplianceBaselineReportRequired;
                var citibankFloodBaselineReportRequired = _citibankFloodBaselineReportRequired; citibankFloodBaselineReportRequired.Clean = value; _citibankFloodBaselineReportRequired = citibankFloodBaselineReportRequired;
                var citibankFraudBaselineReportRequired = _citibankFraudBaselineReportRequired; citibankFraudBaselineReportRequired.Clean = value; _citibankFraudBaselineReportRequired = citibankFraudBaselineReportRequired;
                var currentInvestorPublishingStatus = _currentInvestorPublishingStatus; currentInvestorPublishingStatus.Clean = value; _currentInvestorPublishingStatus = currentInvestorPublishingStatus;
                var driveAppVerifyScore = _driveAppVerifyScore; driveAppVerifyScore.Clean = value; _driveAppVerifyScore = driveAppVerifyScore;
                var driveIDVerifyScore = _driveIDVerifyScore; driveIDVerifyScore.Clean = value; _driveIDVerifyScore = driveIDVerifyScore;
                var drivePropertyVerifyScore = _drivePropertyVerifyScore; drivePropertyVerifyScore.Clean = value; _drivePropertyVerifyScore = drivePropertyVerifyScore;
                var driveScore = _driveScore; driveScore.Clean = value; _driveScore = driveScore;
                var driveStatus = _driveStatus; driveStatus.Clean = value; _driveStatus = driveStatus;
                var homeward4506TBaselineReportRequired = _homeward4506TBaselineReportRequired; homeward4506TBaselineReportRequired.Clean = value; _homeward4506TBaselineReportRequired = homeward4506TBaselineReportRequired;
                var homewardComplianceBaselineReportRequired = _homewardComplianceBaselineReportRequired; homewardComplianceBaselineReportRequired.Clean = value; _homewardComplianceBaselineReportRequired = homewardComplianceBaselineReportRequired;
                var homewardFloodBaselineReportRequired = _homewardFloodBaselineReportRequired; homewardFloodBaselineReportRequired.Clean = value; _homewardFloodBaselineReportRequired = homewardFloodBaselineReportRequired;
                var homewardFraudBaselineReportRequired = _homewardFraudBaselineReportRequired; homewardFraudBaselineReportRequired.Clean = value; _homewardFraudBaselineReportRequired = homewardFraudBaselineReportRequired;
                var id = _id; id.Clean = value; _id = id;
                var lastCCVPCompletedDate = _lastCCVPCompletedDate; lastCCVPCompletedDate.Clean = value; _lastCCVPCompletedDate = lastCCVPCompletedDate;
                var lastCCVPConfidenceScore = _lastCCVPConfidenceScore; lastCCVPConfidenceScore.Clean = value; _lastCCVPConfidenceScore = lastCCVPConfidenceScore;
                var lastCCVPEstimatedValue = _lastCCVPEstimatedValue; lastCCVPEstimatedValue.Clean = value; _lastCCVPEstimatedValue = lastCCVPEstimatedValue;
                var lastCCVPForecastDeviationScore = _lastCCVPForecastDeviationScore; lastCCVPForecastDeviationScore.Clean = value; _lastCCVPForecastDeviationScore = lastCCVPForecastDeviationScore;
                var lastCCVPReportHistoryProResult = _lastCCVPReportHistoryProResult; lastCCVPReportHistoryProResult.Clean = value; _lastCCVPReportHistoryProResult = lastCCVPReportHistoryProResult;
                var lastCCVPReportID = _lastCCVPReportID; lastCCVPReportID.Clean = value; _lastCCVPReportID = lastCCVPReportID;
                var lastCCVPReportOrdered = _lastCCVPReportOrdered; lastCCVPReportOrdered.Clean = value; _lastCCVPReportOrdered = lastCCVPReportOrdered;
                var lastCCVPReportPassResult = _lastCCVPReportPassResult; lastCCVPReportPassResult.Clean = value; _lastCCVPReportPassResult = lastCCVPReportPassResult;
                var lastCCVPResultsReportReturned = _lastCCVPResultsReportReturned; lastCCVPResultsReportReturned.Clean = value; _lastCCVPResultsReportReturned = lastCCVPResultsReportReturned;
                var lastComplianceCompletedDate = _lastComplianceCompletedDate; lastComplianceCompletedDate.Clean = value; _lastComplianceCompletedDate = lastComplianceCompletedDate;
                var lastComplianceNumberOfAlertMessages = _lastComplianceNumberOfAlertMessages; lastComplianceNumberOfAlertMessages.Clean = value; _lastComplianceNumberOfAlertMessages = lastComplianceNumberOfAlertMessages;
                var lastComplianceNumberOfErrorMessages = _lastComplianceNumberOfErrorMessages; lastComplianceNumberOfErrorMessages.Clean = value; _lastComplianceNumberOfErrorMessages = lastComplianceNumberOfErrorMessages;
                var lastComplianceNumberOfFailMessages = _lastComplianceNumberOfFailMessages; lastComplianceNumberOfFailMessages.Clean = value; _lastComplianceNumberOfFailMessages = lastComplianceNumberOfFailMessages;
                var lastComplianceNumberOfPassMessages = _lastComplianceNumberOfPassMessages; lastComplianceNumberOfPassMessages.Clean = value; _lastComplianceNumberOfPassMessages = lastComplianceNumberOfPassMessages;
                var lastComplianceNumberOfWarningMessages = _lastComplianceNumberOfWarningMessages; lastComplianceNumberOfWarningMessages.Clean = value; _lastComplianceNumberOfWarningMessages = lastComplianceNumberOfWarningMessages;
                var lastComplianceOrderType = _lastComplianceOrderType; lastComplianceOrderType.Clean = value; _lastComplianceOrderType = lastComplianceOrderType;
                var lastComplianceProductNameReportOrdered = _lastComplianceProductNameReportOrdered; lastComplianceProductNameReportOrdered.Clean = value; _lastComplianceProductNameReportOrdered = lastComplianceProductNameReportOrdered;
                var lastComplianceReportID = _lastComplianceReportID; lastComplianceReportID.Clean = value; _lastComplianceReportID = lastComplianceReportID;
                var lastFraudOrderAlerts = _lastFraudOrderAlerts; lastFraudOrderAlerts.Clean = value; _lastFraudOrderAlerts = lastFraudOrderAlerts;
                var lastFraudOrderCompletedDate = _lastFraudOrderCompletedDate; lastFraudOrderCompletedDate.Clean = value; _lastFraudOrderCompletedDate = lastFraudOrderCompletedDate;
                var lastFraudOrderProduct = _lastFraudOrderProduct; lastFraudOrderProduct.Clean = value; _lastFraudOrderProduct = lastFraudOrderProduct;
                var lastFraudReportID = _lastFraudReportID; lastFraudReportID.Clean = value; _lastFraudReportID = lastFraudReportID;
                var lastInvestorPublishingInvestor = _lastInvestorPublishingInvestor; lastInvestorPublishingInvestor.Clean = value; _lastInvestorPublishingInvestor = lastInvestorPublishingInvestor;
                var lastInvestorPublishingStatusChangeDate = _lastInvestorPublishingStatusChangeDate; lastInvestorPublishingStatusChangeDate.Clean = value; _lastInvestorPublishingStatusChangeDate = lastInvestorPublishingStatusChangeDate;
                var lastInvestorPublishingUserWhoChangeStatus = _lastInvestorPublishingUserWhoChangeStatus; lastInvestorPublishingUserWhoChangeStatus.Clean = value; _lastInvestorPublishingUserWhoChangeStatus = lastInvestorPublishingUserWhoChangeStatus;
                var lastUserIDWhoOrderedCCVP = _lastUserIDWhoOrderedCCVP; lastUserIDWhoOrderedCCVP.Clean = value; _lastUserIDWhoOrderedCCVP = lastUserIDWhoOrderedCCVP;
                var lastUserIDWhoOrderedCompliance = _lastUserIDWhoOrderedCompliance; lastUserIDWhoOrderedCompliance.Clean = value; _lastUserIDWhoOrderedCompliance = lastUserIDWhoOrderedCompliance;
                var lastUserIDWhoOrderedFraudOrder = _lastUserIDWhoOrderedFraudOrder; lastUserIDWhoOrderedFraudOrder.Clean = value; _lastUserIDWhoOrderedFraudOrder = lastUserIDWhoOrderedFraudOrder;
                var mIVendorsArchAutoOrderIndicator = _mIVendorsArchAutoOrderIndicator; mIVendorsArchAutoOrderIndicator.Clean = value; _mIVendorsArchAutoOrderIndicator = mIVendorsArchAutoOrderIndicator;
                var mIVendorsMgicAutoOrderIndicator = _mIVendorsMgicAutoOrderIndicator; mIVendorsMgicAutoOrderIndicator.Clean = value; _mIVendorsMgicAutoOrderIndicator = mIVendorsMgicAutoOrderIndicator;
                var mIVendorsRadianAutoOrderIndicator = _mIVendorsRadianAutoOrderIndicator; mIVendorsRadianAutoOrderIndicator.Clean = value; _mIVendorsRadianAutoOrderIndicator = mIVendorsRadianAutoOrderIndicator;
                var pHH4506TBaselineReportRequired = _pHH4506TBaselineReportRequired; pHH4506TBaselineReportRequired.Clean = value; _pHH4506TBaselineReportRequired = pHH4506TBaselineReportRequired;
                var pHHComplianceBaselineReportRequired = _pHHComplianceBaselineReportRequired; pHHComplianceBaselineReportRequired.Clean = value; _pHHComplianceBaselineReportRequired = pHHComplianceBaselineReportRequired;
                var pHHFloodBaselineReportRequired = _pHHFloodBaselineReportRequired; pHHFloodBaselineReportRequired.Clean = value; _pHHFloodBaselineReportRequired = pHHFloodBaselineReportRequired;
                var pHHFraudBaselineReportRequired = _pHHFraudBaselineReportRequired; pHHFraudBaselineReportRequired.Clean = value; _pHHFraudBaselineReportRequired = pHHFraudBaselineReportRequired;
                var stonegate4506TBaselineReport = _stonegate4506TBaselineReport; stonegate4506TBaselineReport.Clean = value; _stonegate4506TBaselineReport = stonegate4506TBaselineReport;
                var stonegateComplianceBaselineReportRequired = _stonegateComplianceBaselineReportRequired; stonegateComplianceBaselineReportRequired.Clean = value; _stonegateComplianceBaselineReportRequired = stonegateComplianceBaselineReportRequired;
                var stonegateFloodBaselineReportRequired = _stonegateFloodBaselineReportRequired; stonegateFloodBaselineReportRequired.Clean = value; _stonegateFloodBaselineReportRequired = stonegateFloodBaselineReportRequired;
                var stonegateFraudBaselineReportRequired = _stonegateFraudBaselineReportRequired; stonegateFraudBaselineReportRequired.Clean = value; _stonegateFraudBaselineReportRequired = stonegateFraudBaselineReportRequired;
                var tQLComplianceAlerts = _tQLComplianceAlerts; tQLComplianceAlerts.Clean = value; _tQLComplianceAlerts = tQLComplianceAlerts;
                var tQLDocuments = _tQLDocuments; tQLDocuments.Clean = value; _tQLDocuments = tQLDocuments;
                var tQLFraudAlerts = _tQLFraudAlerts; tQLFraudAlerts.Clean = value; _tQLFraudAlerts = tQLFraudAlerts;
                var tQLFraudAlertsTotal = _tQLFraudAlertsTotal; tQLFraudAlertsTotal.Clean = value; _tQLFraudAlertsTotal = tQLFraudAlertsTotal;
                var tQLFraudAlertsTotalHigh = _tQLFraudAlertsTotalHigh; tQLFraudAlertsTotalHigh.Clean = value; _tQLFraudAlertsTotalHigh = tQLFraudAlertsTotalHigh;
                var tQLFraudAlertsTotalHighUnaddressed = _tQLFraudAlertsTotalHighUnaddressed; tQLFraudAlertsTotalHighUnaddressed.Clean = value; _tQLFraudAlertsTotalHighUnaddressed = tQLFraudAlertsTotalHighUnaddressed;
                var tQLFraudAlertsTotalLow = _tQLFraudAlertsTotalLow; tQLFraudAlertsTotalLow.Clean = value; _tQLFraudAlertsTotalLow = tQLFraudAlertsTotalLow;
                var tQLFraudAlertsTotalLowUnaddressed = _tQLFraudAlertsTotalLowUnaddressed; tQLFraudAlertsTotalLowUnaddressed.Clean = value; _tQLFraudAlertsTotalLowUnaddressed = tQLFraudAlertsTotalLowUnaddressed;
                var tQLFraudAlertsTotalMedium = _tQLFraudAlertsTotalMedium; tQLFraudAlertsTotalMedium.Clean = value; _tQLFraudAlertsTotalMedium = tQLFraudAlertsTotalMedium;
                var tQLFraudAlertsTotalMediumUnaddressed = _tQLFraudAlertsTotalMediumUnaddressed; tQLFraudAlertsTotalMediumUnaddressed.Clean = value; _tQLFraudAlertsTotalMediumUnaddressed = tQLFraudAlertsTotalMediumUnaddressed;
                var wellsFargo4506TBaselineReportRequired = _wellsFargo4506TBaselineReportRequired; wellsFargo4506TBaselineReportRequired.Clean = value; _wellsFargo4506TBaselineReportRequired = wellsFargo4506TBaselineReportRequired;
                var wellsFargoComplianceBaselineReportRequired = _wellsFargoComplianceBaselineReportRequired; wellsFargoComplianceBaselineReportRequired.Clean = value; _wellsFargoComplianceBaselineReportRequired = wellsFargoComplianceBaselineReportRequired;
                var wellsFargoFloodBaselineReportRequired = _wellsFargoFloodBaselineReportRequired; wellsFargoFloodBaselineReportRequired.Clean = value; _wellsFargoFloodBaselineReportRequired = wellsFargoFloodBaselineReportRequired;
                var wellsFargoFraudBaselineReportRequired = _wellsFargoFraudBaselineReportRequired; wellsFargoFraudBaselineReportRequired.Clean = value; _wellsFargoFraudBaselineReportRequired = wellsFargoFraudBaselineReportRequired;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public TQL()
        {
            Clean = true;
        }
    }
}