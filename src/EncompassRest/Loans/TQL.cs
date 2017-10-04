using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQL : IDirty
    {
        private DirtyValue<string> _citibank4506TBaselineReportRequired;
        public string Citibank4506TBaselineReportRequired { get { return _citibank4506TBaselineReportRequired; } set { _citibank4506TBaselineReportRequired = value; } }
        private DirtyValue<string> _citibankCCVPBaselineReportRequired;
        public string CitibankCCVPBaselineReportRequired { get { return _citibankCCVPBaselineReportRequired; } set { _citibankCCVPBaselineReportRequired = value; } }
        private DirtyValue<string> _citibankComplianceBaselineReportRequired;
        public string CitibankComplianceBaselineReportRequired { get { return _citibankComplianceBaselineReportRequired; } set { _citibankComplianceBaselineReportRequired = value; } }
        private DirtyValue<string> _citibankFloodBaselineReportRequired;
        public string CitibankFloodBaselineReportRequired { get { return _citibankFloodBaselineReportRequired; } set { _citibankFloodBaselineReportRequired = value; } }
        private DirtyValue<string> _citibankFraudBaselineReportRequired;
        public string CitibankFraudBaselineReportRequired { get { return _citibankFraudBaselineReportRequired; } set { _citibankFraudBaselineReportRequired = value; } }
        private DirtyValue<string> _currentInvestorPublishingStatus;
        public string CurrentInvestorPublishingStatus { get { return _currentInvestorPublishingStatus; } set { _currentInvestorPublishingStatus = value; } }
        private DirtyValue<int?> _driveAppVerifyScore;
        public int? DriveAppVerifyScore { get { return _driveAppVerifyScore; } set { _driveAppVerifyScore = value; } }
        private DirtyValue<int?> _driveIDVerifyScore;
        public int? DriveIDVerifyScore { get { return _driveIDVerifyScore; } set { _driveIDVerifyScore = value; } }
        private DirtyValue<int?> _drivePropertyVerifyScore;
        public int? DrivePropertyVerifyScore { get { return _drivePropertyVerifyScore; } set { _drivePropertyVerifyScore = value; } }
        private DirtyValue<int?> _driveScore;
        public int? DriveScore { get { return _driveScore; } set { _driveScore = value; } }
        private DirtyValue<string> _driveStatus;
        public string DriveStatus { get { return _driveStatus; } set { _driveStatus = value; } }
        private DirtyValue<string> _homeward4506TBaselineReportRequired;
        public string Homeward4506TBaselineReportRequired { get { return _homeward4506TBaselineReportRequired; } set { _homeward4506TBaselineReportRequired = value; } }
        private DirtyValue<string> _homewardComplianceBaselineReportRequired;
        public string HomewardComplianceBaselineReportRequired { get { return _homewardComplianceBaselineReportRequired; } set { _homewardComplianceBaselineReportRequired = value; } }
        private DirtyValue<string> _homewardFloodBaselineReportRequired;
        public string HomewardFloodBaselineReportRequired { get { return _homewardFloodBaselineReportRequired; } set { _homewardFloodBaselineReportRequired = value; } }
        private DirtyValue<string> _homewardFraudBaselineReportRequired;
        public string HomewardFraudBaselineReportRequired { get { return _homewardFraudBaselineReportRequired; } set { _homewardFraudBaselineReportRequired = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<DateTime?> _lastCCVPCompletedDate;
        public DateTime? LastCCVPCompletedDate { get { return _lastCCVPCompletedDate; } set { _lastCCVPCompletedDate = value; } }
        private DirtyValue<string> _lastCCVPConfidenceScore;
        public string LastCCVPConfidenceScore { get { return _lastCCVPConfidenceScore; } set { _lastCCVPConfidenceScore = value; } }
        private DirtyValue<string> _lastCCVPEstimatedValue;
        public string LastCCVPEstimatedValue { get { return _lastCCVPEstimatedValue; } set { _lastCCVPEstimatedValue = value; } }
        private DirtyValue<string> _lastCCVPForecastDeviationScore;
        public string LastCCVPForecastDeviationScore { get { return _lastCCVPForecastDeviationScore; } set { _lastCCVPForecastDeviationScore = value; } }
        private DirtyValue<string> _lastCCVPReportHistoryProResult;
        public string LastCCVPReportHistoryProResult { get { return _lastCCVPReportHistoryProResult; } set { _lastCCVPReportHistoryProResult = value; } }
        private DirtyValue<string> _lastCCVPReportID;
        public string LastCCVPReportID { get { return _lastCCVPReportID; } set { _lastCCVPReportID = value; } }
        private DirtyValue<string> _lastCCVPReportOrdered;
        public string LastCCVPReportOrdered { get { return _lastCCVPReportOrdered; } set { _lastCCVPReportOrdered = value; } }
        private DirtyValue<string> _lastCCVPReportPassResult;
        public string LastCCVPReportPassResult { get { return _lastCCVPReportPassResult; } set { _lastCCVPReportPassResult = value; } }
        private DirtyValue<string> _lastCCVPResultsReportReturned;
        public string LastCCVPResultsReportReturned { get { return _lastCCVPResultsReportReturned; } set { _lastCCVPResultsReportReturned = value; } }
        private DirtyValue<DateTime?> _lastComplianceCompletedDate;
        public DateTime? LastComplianceCompletedDate { get { return _lastComplianceCompletedDate; } set { _lastComplianceCompletedDate = value; } }
        private DirtyValue<int?> _lastComplianceNumberOfAlertMessages;
        public int? LastComplianceNumberOfAlertMessages { get { return _lastComplianceNumberOfAlertMessages; } set { _lastComplianceNumberOfAlertMessages = value; } }
        private DirtyValue<int?> _lastComplianceNumberOfErrorMessages;
        public int? LastComplianceNumberOfErrorMessages { get { return _lastComplianceNumberOfErrorMessages; } set { _lastComplianceNumberOfErrorMessages = value; } }
        private DirtyValue<int?> _lastComplianceNumberOfFailMessages;
        public int? LastComplianceNumberOfFailMessages { get { return _lastComplianceNumberOfFailMessages; } set { _lastComplianceNumberOfFailMessages = value; } }
        private DirtyValue<int?> _lastComplianceNumberOfPassMessages;
        public int? LastComplianceNumberOfPassMessages { get { return _lastComplianceNumberOfPassMessages; } set { _lastComplianceNumberOfPassMessages = value; } }
        private DirtyValue<int?> _lastComplianceNumberOfWarningMessages;
        public int? LastComplianceNumberOfWarningMessages { get { return _lastComplianceNumberOfWarningMessages; } set { _lastComplianceNumberOfWarningMessages = value; } }
        private DirtyValue<string> _lastComplianceOrderType;
        public string LastComplianceOrderType { get { return _lastComplianceOrderType; } set { _lastComplianceOrderType = value; } }
        private DirtyValue<string> _lastComplianceProductNameReportOrdered;
        public string LastComplianceProductNameReportOrdered { get { return _lastComplianceProductNameReportOrdered; } set { _lastComplianceProductNameReportOrdered = value; } }
        private DirtyValue<string> _lastComplianceReportID;
        public string LastComplianceReportID { get { return _lastComplianceReportID; } set { _lastComplianceReportID = value; } }
        private DirtyValue<int?> _lastFraudOrderAlerts;
        public int? LastFraudOrderAlerts { get { return _lastFraudOrderAlerts; } set { _lastFraudOrderAlerts = value; } }
        private DirtyValue<DateTime?> _lastFraudOrderCompletedDate;
        public DateTime? LastFraudOrderCompletedDate { get { return _lastFraudOrderCompletedDate; } set { _lastFraudOrderCompletedDate = value; } }
        private DirtyValue<string> _lastFraudOrderProduct;
        public string LastFraudOrderProduct { get { return _lastFraudOrderProduct; } set { _lastFraudOrderProduct = value; } }
        private DirtyValue<string> _lastFraudReportID;
        public string LastFraudReportID { get { return _lastFraudReportID; } set { _lastFraudReportID = value; } }
        private DirtyValue<string> _lastInvestorPublishingInvestor;
        public string LastInvestorPublishingInvestor { get { return _lastInvestorPublishingInvestor; } set { _lastInvestorPublishingInvestor = value; } }
        private DirtyValue<DateTime?> _lastInvestorPublishingStatusChangeDate;
        public DateTime? LastInvestorPublishingStatusChangeDate { get { return _lastInvestorPublishingStatusChangeDate; } set { _lastInvestorPublishingStatusChangeDate = value; } }
        private DirtyValue<string> _lastInvestorPublishingUserWhoChangeStatus;
        public string LastInvestorPublishingUserWhoChangeStatus { get { return _lastInvestorPublishingUserWhoChangeStatus; } set { _lastInvestorPublishingUserWhoChangeStatus = value; } }
        private DirtyValue<string> _lastUserIDWhoOrderedCCVP;
        public string LastUserIDWhoOrderedCCVP { get { return _lastUserIDWhoOrderedCCVP; } set { _lastUserIDWhoOrderedCCVP = value; } }
        private DirtyValue<string> _lastUserIDWhoOrderedCompliance;
        public string LastUserIDWhoOrderedCompliance { get { return _lastUserIDWhoOrderedCompliance; } set { _lastUserIDWhoOrderedCompliance = value; } }
        private DirtyValue<string> _lastUserIDWhoOrderedFraudOrder;
        public string LastUserIDWhoOrderedFraudOrder { get { return _lastUserIDWhoOrderedFraudOrder; } set { _lastUserIDWhoOrderedFraudOrder = value; } }
        private DirtyValue<bool?> _mIVendorsArchAutoOrderIndicator;
        public bool? MIVendorsArchAutoOrderIndicator { get { return _mIVendorsArchAutoOrderIndicator; } set { _mIVendorsArchAutoOrderIndicator = value; } }
        private DirtyValue<bool?> _mIVendorsMgicAutoOrderIndicator;
        public bool? MIVendorsMgicAutoOrderIndicator { get { return _mIVendorsMgicAutoOrderIndicator; } set { _mIVendorsMgicAutoOrderIndicator = value; } }
        private DirtyValue<bool?> _mIVendorsRadianAutoOrderIndicator;
        public bool? MIVendorsRadianAutoOrderIndicator { get { return _mIVendorsRadianAutoOrderIndicator; } set { _mIVendorsRadianAutoOrderIndicator = value; } }
        private DirtyValue<string> _pHH4506TBaselineReportRequired;
        public string PHH4506TBaselineReportRequired { get { return _pHH4506TBaselineReportRequired; } set { _pHH4506TBaselineReportRequired = value; } }
        private DirtyValue<string> _pHHComplianceBaselineReportRequired;
        public string PHHComplianceBaselineReportRequired { get { return _pHHComplianceBaselineReportRequired; } set { _pHHComplianceBaselineReportRequired = value; } }
        private DirtyValue<string> _pHHFloodBaselineReportRequired;
        public string PHHFloodBaselineReportRequired { get { return _pHHFloodBaselineReportRequired; } set { _pHHFloodBaselineReportRequired = value; } }
        private DirtyValue<string> _pHHFraudBaselineReportRequired;
        public string PHHFraudBaselineReportRequired { get { return _pHHFraudBaselineReportRequired; } set { _pHHFraudBaselineReportRequired = value; } }
        private DirtyValue<string> _stonegate4506TBaselineReport;
        public string Stonegate4506TBaselineReport { get { return _stonegate4506TBaselineReport; } set { _stonegate4506TBaselineReport = value; } }
        private DirtyValue<string> _stonegateComplianceBaselineReportRequired;
        public string StonegateComplianceBaselineReportRequired { get { return _stonegateComplianceBaselineReportRequired; } set { _stonegateComplianceBaselineReportRequired = value; } }
        private DirtyValue<string> _stonegateFloodBaselineReportRequired;
        public string StonegateFloodBaselineReportRequired { get { return _stonegateFloodBaselineReportRequired; } set { _stonegateFloodBaselineReportRequired = value; } }
        private DirtyValue<string> _stonegateFraudBaselineReportRequired;
        public string StonegateFraudBaselineReportRequired { get { return _stonegateFraudBaselineReportRequired; } set { _stonegateFraudBaselineReportRequired = value; } }
        private DirtyList<TQLComplianceAlert> _tQLComplianceAlerts;
        public IList<TQLComplianceAlert> TQLComplianceAlerts { get { var v = _tQLComplianceAlerts; return v ?? Interlocked.CompareExchange(ref _tQLComplianceAlerts, (v = new DirtyList<TQLComplianceAlert>()), null) ?? v; } set { _tQLComplianceAlerts = new DirtyList<TQLComplianceAlert>(value); } }
        private DirtyList<TQLDocument> _tQLDocuments;
        public IList<TQLDocument> TQLDocuments { get { var v = _tQLDocuments; return v ?? Interlocked.CompareExchange(ref _tQLDocuments, (v = new DirtyList<TQLDocument>()), null) ?? v; } set { _tQLDocuments = new DirtyList<TQLDocument>(value); } }
        private DirtyList<TQLFraudAlert> _tQLFraudAlerts;
        public IList<TQLFraudAlert> TQLFraudAlerts { get { var v = _tQLFraudAlerts; return v ?? Interlocked.CompareExchange(ref _tQLFraudAlerts, (v = new DirtyList<TQLFraudAlert>()), null) ?? v; } set { _tQLFraudAlerts = new DirtyList<TQLFraudAlert>(value); } }
        private DirtyValue<int?> _tQLFraudAlertsTotal;
        public int? TQLFraudAlertsTotal { get { return _tQLFraudAlertsTotal; } set { _tQLFraudAlertsTotal = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalHigh;
        public int? TQLFraudAlertsTotalHigh { get { return _tQLFraudAlertsTotalHigh; } set { _tQLFraudAlertsTotalHigh = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalHighUnaddressed;
        public int? TQLFraudAlertsTotalHighUnaddressed { get { return _tQLFraudAlertsTotalHighUnaddressed; } set { _tQLFraudAlertsTotalHighUnaddressed = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalLow;
        public int? TQLFraudAlertsTotalLow { get { return _tQLFraudAlertsTotalLow; } set { _tQLFraudAlertsTotalLow = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalLowUnaddressed;
        public int? TQLFraudAlertsTotalLowUnaddressed { get { return _tQLFraudAlertsTotalLowUnaddressed; } set { _tQLFraudAlertsTotalLowUnaddressed = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalMedium;
        public int? TQLFraudAlertsTotalMedium { get { return _tQLFraudAlertsTotalMedium; } set { _tQLFraudAlertsTotalMedium = value; } }
        private DirtyValue<int?> _tQLFraudAlertsTotalMediumUnaddressed;
        public int? TQLFraudAlertsTotalMediumUnaddressed { get { return _tQLFraudAlertsTotalMediumUnaddressed; } set { _tQLFraudAlertsTotalMediumUnaddressed = value; } }
        private DirtyValue<string> _wellsFargo4506TBaselineReportRequired;
        public string WellsFargo4506TBaselineReportRequired { get { return _wellsFargo4506TBaselineReportRequired; } set { _wellsFargo4506TBaselineReportRequired = value; } }
        private DirtyValue<string> _wellsFargoComplianceBaselineReportRequired;
        public string WellsFargoComplianceBaselineReportRequired { get { return _wellsFargoComplianceBaselineReportRequired; } set { _wellsFargoComplianceBaselineReportRequired = value; } }
        private DirtyValue<string> _wellsFargoFloodBaselineReportRequired;
        public string WellsFargoFloodBaselineReportRequired { get { return _wellsFargoFloodBaselineReportRequired; } set { _wellsFargoFloodBaselineReportRequired = value; } }
        private DirtyValue<string> _wellsFargoFraudBaselineReportRequired;
        public string WellsFargoFraudBaselineReportRequired { get { return _wellsFargoFraudBaselineReportRequired; } set { _wellsFargoFraudBaselineReportRequired = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _citibank4506TBaselineReportRequired.Dirty
                    || _citibankCCVPBaselineReportRequired.Dirty
                    || _citibankComplianceBaselineReportRequired.Dirty
                    || _citibankFloodBaselineReportRequired.Dirty
                    || _citibankFraudBaselineReportRequired.Dirty
                    || _currentInvestorPublishingStatus.Dirty
                    || _driveAppVerifyScore.Dirty
                    || _driveIDVerifyScore.Dirty
                    || _drivePropertyVerifyScore.Dirty
                    || _driveScore.Dirty
                    || _driveStatus.Dirty
                    || _homeward4506TBaselineReportRequired.Dirty
                    || _homewardComplianceBaselineReportRequired.Dirty
                    || _homewardFloodBaselineReportRequired.Dirty
                    || _homewardFraudBaselineReportRequired.Dirty
                    || _id.Dirty
                    || _lastCCVPCompletedDate.Dirty
                    || _lastCCVPConfidenceScore.Dirty
                    || _lastCCVPEstimatedValue.Dirty
                    || _lastCCVPForecastDeviationScore.Dirty
                    || _lastCCVPReportHistoryProResult.Dirty
                    || _lastCCVPReportID.Dirty
                    || _lastCCVPReportOrdered.Dirty
                    || _lastCCVPReportPassResult.Dirty
                    || _lastCCVPResultsReportReturned.Dirty
                    || _lastComplianceCompletedDate.Dirty
                    || _lastComplianceNumberOfAlertMessages.Dirty
                    || _lastComplianceNumberOfErrorMessages.Dirty
                    || _lastComplianceNumberOfFailMessages.Dirty
                    || _lastComplianceNumberOfPassMessages.Dirty
                    || _lastComplianceNumberOfWarningMessages.Dirty
                    || _lastComplianceOrderType.Dirty
                    || _lastComplianceProductNameReportOrdered.Dirty
                    || _lastComplianceReportID.Dirty
                    || _lastFraudOrderAlerts.Dirty
                    || _lastFraudOrderCompletedDate.Dirty
                    || _lastFraudOrderProduct.Dirty
                    || _lastFraudReportID.Dirty
                    || _lastInvestorPublishingInvestor.Dirty
                    || _lastInvestorPublishingStatusChangeDate.Dirty
                    || _lastInvestorPublishingUserWhoChangeStatus.Dirty
                    || _lastUserIDWhoOrderedCCVP.Dirty
                    || _lastUserIDWhoOrderedCompliance.Dirty
                    || _lastUserIDWhoOrderedFraudOrder.Dirty
                    || _mIVendorsArchAutoOrderIndicator.Dirty
                    || _mIVendorsMgicAutoOrderIndicator.Dirty
                    || _mIVendorsRadianAutoOrderIndicator.Dirty
                    || _pHH4506TBaselineReportRequired.Dirty
                    || _pHHComplianceBaselineReportRequired.Dirty
                    || _pHHFloodBaselineReportRequired.Dirty
                    || _pHHFraudBaselineReportRequired.Dirty
                    || _stonegate4506TBaselineReport.Dirty
                    || _stonegateComplianceBaselineReportRequired.Dirty
                    || _stonegateFloodBaselineReportRequired.Dirty
                    || _stonegateFraudBaselineReportRequired.Dirty
                    || _tQLFraudAlertsTotal.Dirty
                    || _tQLFraudAlertsTotalHigh.Dirty
                    || _tQLFraudAlertsTotalHighUnaddressed.Dirty
                    || _tQLFraudAlertsTotalLow.Dirty
                    || _tQLFraudAlertsTotalLowUnaddressed.Dirty
                    || _tQLFraudAlertsTotalMedium.Dirty
                    || _tQLFraudAlertsTotalMediumUnaddressed.Dirty
                    || _wellsFargo4506TBaselineReportRequired.Dirty
                    || _wellsFargoComplianceBaselineReportRequired.Dirty
                    || _wellsFargoFloodBaselineReportRequired.Dirty
                    || _wellsFargoFraudBaselineReportRequired.Dirty
                    || _tQLComplianceAlerts?.Dirty == true
                    || _tQLDocuments?.Dirty == true
                    || _tQLFraudAlerts?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _citibank4506TBaselineReportRequired.Dirty = value;
                _citibankCCVPBaselineReportRequired.Dirty = value;
                _citibankComplianceBaselineReportRequired.Dirty = value;
                _citibankFloodBaselineReportRequired.Dirty = value;
                _citibankFraudBaselineReportRequired.Dirty = value;
                _currentInvestorPublishingStatus.Dirty = value;
                _driveAppVerifyScore.Dirty = value;
                _driveIDVerifyScore.Dirty = value;
                _drivePropertyVerifyScore.Dirty = value;
                _driveScore.Dirty = value;
                _driveStatus.Dirty = value;
                _homeward4506TBaselineReportRequired.Dirty = value;
                _homewardComplianceBaselineReportRequired.Dirty = value;
                _homewardFloodBaselineReportRequired.Dirty = value;
                _homewardFraudBaselineReportRequired.Dirty = value;
                _id.Dirty = value;
                _lastCCVPCompletedDate.Dirty = value;
                _lastCCVPConfidenceScore.Dirty = value;
                _lastCCVPEstimatedValue.Dirty = value;
                _lastCCVPForecastDeviationScore.Dirty = value;
                _lastCCVPReportHistoryProResult.Dirty = value;
                _lastCCVPReportID.Dirty = value;
                _lastCCVPReportOrdered.Dirty = value;
                _lastCCVPReportPassResult.Dirty = value;
                _lastCCVPResultsReportReturned.Dirty = value;
                _lastComplianceCompletedDate.Dirty = value;
                _lastComplianceNumberOfAlertMessages.Dirty = value;
                _lastComplianceNumberOfErrorMessages.Dirty = value;
                _lastComplianceNumberOfFailMessages.Dirty = value;
                _lastComplianceNumberOfPassMessages.Dirty = value;
                _lastComplianceNumberOfWarningMessages.Dirty = value;
                _lastComplianceOrderType.Dirty = value;
                _lastComplianceProductNameReportOrdered.Dirty = value;
                _lastComplianceReportID.Dirty = value;
                _lastFraudOrderAlerts.Dirty = value;
                _lastFraudOrderCompletedDate.Dirty = value;
                _lastFraudOrderProduct.Dirty = value;
                _lastFraudReportID.Dirty = value;
                _lastInvestorPublishingInvestor.Dirty = value;
                _lastInvestorPublishingStatusChangeDate.Dirty = value;
                _lastInvestorPublishingUserWhoChangeStatus.Dirty = value;
                _lastUserIDWhoOrderedCCVP.Dirty = value;
                _lastUserIDWhoOrderedCompliance.Dirty = value;
                _lastUserIDWhoOrderedFraudOrder.Dirty = value;
                _mIVendorsArchAutoOrderIndicator.Dirty = value;
                _mIVendorsMgicAutoOrderIndicator.Dirty = value;
                _mIVendorsRadianAutoOrderIndicator.Dirty = value;
                _pHH4506TBaselineReportRequired.Dirty = value;
                _pHHComplianceBaselineReportRequired.Dirty = value;
                _pHHFloodBaselineReportRequired.Dirty = value;
                _pHHFraudBaselineReportRequired.Dirty = value;
                _stonegate4506TBaselineReport.Dirty = value;
                _stonegateComplianceBaselineReportRequired.Dirty = value;
                _stonegateFloodBaselineReportRequired.Dirty = value;
                _stonegateFraudBaselineReportRequired.Dirty = value;
                _tQLFraudAlertsTotal.Dirty = value;
                _tQLFraudAlertsTotalHigh.Dirty = value;
                _tQLFraudAlertsTotalHighUnaddressed.Dirty = value;
                _tQLFraudAlertsTotalLow.Dirty = value;
                _tQLFraudAlertsTotalLowUnaddressed.Dirty = value;
                _tQLFraudAlertsTotalMedium.Dirty = value;
                _tQLFraudAlertsTotalMediumUnaddressed.Dirty = value;
                _wellsFargo4506TBaselineReportRequired.Dirty = value;
                _wellsFargoComplianceBaselineReportRequired.Dirty = value;
                _wellsFargoFloodBaselineReportRequired.Dirty = value;
                _wellsFargoFraudBaselineReportRequired.Dirty = value;
                if (_tQLComplianceAlerts != null) _tQLComplianceAlerts.Dirty = value;
                if (_tQLDocuments != null) _tQLDocuments.Dirty = value;
                if (_tQLFraudAlerts != null) _tQLFraudAlerts.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}