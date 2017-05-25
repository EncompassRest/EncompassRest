using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _citibank4506TBaselineReportRequired; v0.Clean = value; _citibank4506TBaselineReportRequired = v0;
                var v1 = _citibankCCVPBaselineReportRequired; v1.Clean = value; _citibankCCVPBaselineReportRequired = v1;
                var v2 = _citibankComplianceBaselineReportRequired; v2.Clean = value; _citibankComplianceBaselineReportRequired = v2;
                var v3 = _citibankFloodBaselineReportRequired; v3.Clean = value; _citibankFloodBaselineReportRequired = v3;
                var v4 = _citibankFraudBaselineReportRequired; v4.Clean = value; _citibankFraudBaselineReportRequired = v4;
                var v5 = _currentInvestorPublishingStatus; v5.Clean = value; _currentInvestorPublishingStatus = v5;
                var v6 = _driveAppVerifyScore; v6.Clean = value; _driveAppVerifyScore = v6;
                var v7 = _driveIDVerifyScore; v7.Clean = value; _driveIDVerifyScore = v7;
                var v8 = _drivePropertyVerifyScore; v8.Clean = value; _drivePropertyVerifyScore = v8;
                var v9 = _driveScore; v9.Clean = value; _driveScore = v9;
                var v10 = _driveStatus; v10.Clean = value; _driveStatus = v10;
                var v11 = _homeward4506TBaselineReportRequired; v11.Clean = value; _homeward4506TBaselineReportRequired = v11;
                var v12 = _homewardComplianceBaselineReportRequired; v12.Clean = value; _homewardComplianceBaselineReportRequired = v12;
                var v13 = _homewardFloodBaselineReportRequired; v13.Clean = value; _homewardFloodBaselineReportRequired = v13;
                var v14 = _homewardFraudBaselineReportRequired; v14.Clean = value; _homewardFraudBaselineReportRequired = v14;
                var v15 = _id; v15.Clean = value; _id = v15;
                var v16 = _lastCCVPCompletedDate; v16.Clean = value; _lastCCVPCompletedDate = v16;
                var v17 = _lastCCVPConfidenceScore; v17.Clean = value; _lastCCVPConfidenceScore = v17;
                var v18 = _lastCCVPEstimatedValue; v18.Clean = value; _lastCCVPEstimatedValue = v18;
                var v19 = _lastCCVPForecastDeviationScore; v19.Clean = value; _lastCCVPForecastDeviationScore = v19;
                var v20 = _lastCCVPReportHistoryProResult; v20.Clean = value; _lastCCVPReportHistoryProResult = v20;
                var v21 = _lastCCVPReportID; v21.Clean = value; _lastCCVPReportID = v21;
                var v22 = _lastCCVPReportOrdered; v22.Clean = value; _lastCCVPReportOrdered = v22;
                var v23 = _lastCCVPReportPassResult; v23.Clean = value; _lastCCVPReportPassResult = v23;
                var v24 = _lastCCVPResultsReportReturned; v24.Clean = value; _lastCCVPResultsReportReturned = v24;
                var v25 = _lastComplianceCompletedDate; v25.Clean = value; _lastComplianceCompletedDate = v25;
                var v26 = _lastComplianceNumberOfAlertMessages; v26.Clean = value; _lastComplianceNumberOfAlertMessages = v26;
                var v27 = _lastComplianceNumberOfErrorMessages; v27.Clean = value; _lastComplianceNumberOfErrorMessages = v27;
                var v28 = _lastComplianceNumberOfFailMessages; v28.Clean = value; _lastComplianceNumberOfFailMessages = v28;
                var v29 = _lastComplianceNumberOfPassMessages; v29.Clean = value; _lastComplianceNumberOfPassMessages = v29;
                var v30 = _lastComplianceNumberOfWarningMessages; v30.Clean = value; _lastComplianceNumberOfWarningMessages = v30;
                var v31 = _lastComplianceOrderType; v31.Clean = value; _lastComplianceOrderType = v31;
                var v32 = _lastComplianceProductNameReportOrdered; v32.Clean = value; _lastComplianceProductNameReportOrdered = v32;
                var v33 = _lastComplianceReportID; v33.Clean = value; _lastComplianceReportID = v33;
                var v34 = _lastFraudOrderAlerts; v34.Clean = value; _lastFraudOrderAlerts = v34;
                var v35 = _lastFraudOrderCompletedDate; v35.Clean = value; _lastFraudOrderCompletedDate = v35;
                var v36 = _lastFraudOrderProduct; v36.Clean = value; _lastFraudOrderProduct = v36;
                var v37 = _lastFraudReportID; v37.Clean = value; _lastFraudReportID = v37;
                var v38 = _lastInvestorPublishingInvestor; v38.Clean = value; _lastInvestorPublishingInvestor = v38;
                var v39 = _lastInvestorPublishingStatusChangeDate; v39.Clean = value; _lastInvestorPublishingStatusChangeDate = v39;
                var v40 = _lastInvestorPublishingUserWhoChangeStatus; v40.Clean = value; _lastInvestorPublishingUserWhoChangeStatus = v40;
                var v41 = _lastUserIDWhoOrderedCCVP; v41.Clean = value; _lastUserIDWhoOrderedCCVP = v41;
                var v42 = _lastUserIDWhoOrderedCompliance; v42.Clean = value; _lastUserIDWhoOrderedCompliance = v42;
                var v43 = _lastUserIDWhoOrderedFraudOrder; v43.Clean = value; _lastUserIDWhoOrderedFraudOrder = v43;
                var v44 = _pHH4506TBaselineReportRequired; v44.Clean = value; _pHH4506TBaselineReportRequired = v44;
                var v45 = _pHHComplianceBaselineReportRequired; v45.Clean = value; _pHHComplianceBaselineReportRequired = v45;
                var v46 = _pHHFloodBaselineReportRequired; v46.Clean = value; _pHHFloodBaselineReportRequired = v46;
                var v47 = _pHHFraudBaselineReportRequired; v47.Clean = value; _pHHFraudBaselineReportRequired = v47;
                var v48 = _stonegate4506TBaselineReport; v48.Clean = value; _stonegate4506TBaselineReport = v48;
                var v49 = _stonegateComplianceBaselineReportRequired; v49.Clean = value; _stonegateComplianceBaselineReportRequired = v49;
                var v50 = _stonegateFloodBaselineReportRequired; v50.Clean = value; _stonegateFloodBaselineReportRequired = v50;
                var v51 = _stonegateFraudBaselineReportRequired; v51.Clean = value; _stonegateFraudBaselineReportRequired = v51;
                var v52 = _tQLComplianceAlerts; v52.Clean = value; _tQLComplianceAlerts = v52;
                var v53 = _tQLDocuments; v53.Clean = value; _tQLDocuments = v53;
                var v54 = _tQLFraudAlerts; v54.Clean = value; _tQLFraudAlerts = v54;
                var v55 = _tQLFraudAlertsTotal; v55.Clean = value; _tQLFraudAlertsTotal = v55;
                var v56 = _tQLFraudAlertsTotalHigh; v56.Clean = value; _tQLFraudAlertsTotalHigh = v56;
                var v57 = _tQLFraudAlertsTotalHighUnaddressed; v57.Clean = value; _tQLFraudAlertsTotalHighUnaddressed = v57;
                var v58 = _tQLFraudAlertsTotalLow; v58.Clean = value; _tQLFraudAlertsTotalLow = v58;
                var v59 = _tQLFraudAlertsTotalLowUnaddressed; v59.Clean = value; _tQLFraudAlertsTotalLowUnaddressed = v59;
                var v60 = _tQLFraudAlertsTotalMedium; v60.Clean = value; _tQLFraudAlertsTotalMedium = v60;
                var v61 = _tQLFraudAlertsTotalMediumUnaddressed; v61.Clean = value; _tQLFraudAlertsTotalMediumUnaddressed = v61;
                var v62 = _wellsFargo4506TBaselineReportRequired; v62.Clean = value; _wellsFargo4506TBaselineReportRequired = v62;
                var v63 = _wellsFargoComplianceBaselineReportRequired; v63.Clean = value; _wellsFargoComplianceBaselineReportRequired = v63;
                var v64 = _wellsFargoFloodBaselineReportRequired; v64.Clean = value; _wellsFargoFloodBaselineReportRequired = v64;
                var v65 = _wellsFargoFraudBaselineReportRequired; v65.Clean = value; _wellsFargoFraudBaselineReportRequired = v65;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}