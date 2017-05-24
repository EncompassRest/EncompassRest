using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQL
    {
        public Value<string> Citibank4506TBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitibank4506TBaselineReportRequired() => !Citibank4506TBaselineReportRequired.Clean;
        public Value<string> CitibankCCVPBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitibankCCVPBaselineReportRequired() => !CitibankCCVPBaselineReportRequired.Clean;
        public Value<string> CitibankComplianceBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitibankComplianceBaselineReportRequired() => !CitibankComplianceBaselineReportRequired.Clean;
        public Value<string> CitibankFloodBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitibankFloodBaselineReportRequired() => !CitibankFloodBaselineReportRequired.Clean;
        public Value<string> CitibankFraudBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitibankFraudBaselineReportRequired() => !CitibankFraudBaselineReportRequired.Clean;
        public Value<string> CurrentInvestorPublishingStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentInvestorPublishingStatus() => !CurrentInvestorPublishingStatus.Clean;
        public Value<int?> DriveAppVerifyScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDriveAppVerifyScore() => !DriveAppVerifyScore.Clean;
        public Value<int?> DriveIDVerifyScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDriveIDVerifyScore() => !DriveIDVerifyScore.Clean;
        public Value<int?> DrivePropertyVerifyScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrivePropertyVerifyScore() => !DrivePropertyVerifyScore.Clean;
        public Value<int?> DriveScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDriveScore() => !DriveScore.Clean;
        public Value<string> DriveStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDriveStatus() => !DriveStatus.Clean;
        public Value<string> Homeward4506TBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeward4506TBaselineReportRequired() => !Homeward4506TBaselineReportRequired.Clean;
        public Value<string> HomewardComplianceBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomewardComplianceBaselineReportRequired() => !HomewardComplianceBaselineReportRequired.Clean;
        public Value<string> HomewardFloodBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomewardFloodBaselineReportRequired() => !HomewardFloodBaselineReportRequired.Clean;
        public Value<string> HomewardFraudBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomewardFraudBaselineReportRequired() => !HomewardFraudBaselineReportRequired.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> LastCCVPCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPCompletedDate() => !LastCCVPCompletedDate.Clean;
        public Value<string> LastCCVPConfidenceScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPConfidenceScore() => !LastCCVPConfidenceScore.Clean;
        public Value<string> LastCCVPEstimatedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPEstimatedValue() => !LastCCVPEstimatedValue.Clean;
        public Value<string> LastCCVPForecastDeviationScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPForecastDeviationScore() => !LastCCVPForecastDeviationScore.Clean;
        public Value<string> LastCCVPReportHistoryProResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPReportHistoryProResult() => !LastCCVPReportHistoryProResult.Clean;
        public Value<string> LastCCVPReportID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPReportID() => !LastCCVPReportID.Clean;
        public Value<string> LastCCVPReportOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPReportOrdered() => !LastCCVPReportOrdered.Clean;
        public Value<string> LastCCVPReportPassResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPReportPassResult() => !LastCCVPReportPassResult.Clean;
        public Value<string> LastCCVPResultsReportReturned { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastCCVPResultsReportReturned() => !LastCCVPResultsReportReturned.Clean;
        public Value<DateTime?> LastComplianceCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceCompletedDate() => !LastComplianceCompletedDate.Clean;
        public Value<int?> LastComplianceNumberOfAlertMessages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceNumberOfAlertMessages() => !LastComplianceNumberOfAlertMessages.Clean;
        public Value<int?> LastComplianceNumberOfErrorMessages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceNumberOfErrorMessages() => !LastComplianceNumberOfErrorMessages.Clean;
        public Value<int?> LastComplianceNumberOfFailMessages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceNumberOfFailMessages() => !LastComplianceNumberOfFailMessages.Clean;
        public Value<int?> LastComplianceNumberOfPassMessages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceNumberOfPassMessages() => !LastComplianceNumberOfPassMessages.Clean;
        public Value<int?> LastComplianceNumberOfWarningMessages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceNumberOfWarningMessages() => !LastComplianceNumberOfWarningMessages.Clean;
        public Value<string> LastComplianceOrderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderType() => !LastComplianceOrderType.Clean;
        public Value<string> LastComplianceProductNameReportOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceProductNameReportOrdered() => !LastComplianceProductNameReportOrdered.Clean;
        public Value<string> LastComplianceReportID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceReportID() => !LastComplianceReportID.Clean;
        public Value<int?> LastFraudOrderAlerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlerts() => !LastFraudOrderAlerts.Clean;
        public Value<DateTime?> LastFraudOrderCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderCompletedDate() => !LastFraudOrderCompletedDate.Clean;
        public Value<string> LastFraudOrderProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderProduct() => !LastFraudOrderProduct.Clean;
        public Value<string> LastFraudReportID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudReportID() => !LastFraudReportID.Clean;
        public Value<string> LastInvestorPublishingInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastInvestorPublishingInvestor() => !LastInvestorPublishingInvestor.Clean;
        public Value<DateTime?> LastInvestorPublishingStatusChangeDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastInvestorPublishingStatusChangeDate() => !LastInvestorPublishingStatusChangeDate.Clean;
        public Value<string> LastInvestorPublishingUserWhoChangeStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastInvestorPublishingUserWhoChangeStatus() => !LastInvestorPublishingUserWhoChangeStatus.Clean;
        public Value<string> LastUserIDWhoOrderedCCVP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUserIDWhoOrderedCCVP() => !LastUserIDWhoOrderedCCVP.Clean;
        public Value<string> LastUserIDWhoOrderedCompliance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUserIDWhoOrderedCompliance() => !LastUserIDWhoOrderedCompliance.Clean;
        public Value<string> LastUserIDWhoOrderedFraudOrder { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUserIDWhoOrderedFraudOrder() => !LastUserIDWhoOrderedFraudOrder.Clean;
        public Value<string> PHH4506TBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePHH4506TBaselineReportRequired() => !PHH4506TBaselineReportRequired.Clean;
        public Value<string> PHHComplianceBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePHHComplianceBaselineReportRequired() => !PHHComplianceBaselineReportRequired.Clean;
        public Value<string> PHHFloodBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePHHFloodBaselineReportRequired() => !PHHFloodBaselineReportRequired.Clean;
        public Value<string> PHHFraudBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePHHFraudBaselineReportRequired() => !PHHFraudBaselineReportRequired.Clean;
        public Value<string> Stonegate4506TBaselineReport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStonegate4506TBaselineReport() => !Stonegate4506TBaselineReport.Clean;
        public Value<string> StonegateComplianceBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStonegateComplianceBaselineReportRequired() => !StonegateComplianceBaselineReportRequired.Clean;
        public Value<string> StonegateFloodBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStonegateFloodBaselineReportRequired() => !StonegateFloodBaselineReportRequired.Clean;
        public Value<string> StonegateFraudBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStonegateFraudBaselineReportRequired() => !StonegateFraudBaselineReportRequired.Clean;
        public Value<List<TQLComplianceAlert>> TQLComplianceAlerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLComplianceAlerts() => !TQLComplianceAlerts.Clean;
        public Value<List<TQLDocument>> TQLDocuments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLDocuments() => !TQLDocuments.Clean;
        public Value<List<TQLFraudAlert>> TQLFraudAlerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlerts() => !TQLFraudAlerts.Clean;
        public Value<int?> TQLFraudAlertsTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotal() => !TQLFraudAlertsTotal.Clean;
        public Value<int?> TQLFraudAlertsTotalHigh { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalHigh() => !TQLFraudAlertsTotalHigh.Clean;
        public Value<int?> TQLFraudAlertsTotalHighUnaddressed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalHighUnaddressed() => !TQLFraudAlertsTotalHighUnaddressed.Clean;
        public Value<int?> TQLFraudAlertsTotalLow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalLow() => !TQLFraudAlertsTotalLow.Clean;
        public Value<int?> TQLFraudAlertsTotalLowUnaddressed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalLowUnaddressed() => !TQLFraudAlertsTotalLowUnaddressed.Clean;
        public Value<int?> TQLFraudAlertsTotalMedium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalMedium() => !TQLFraudAlertsTotalMedium.Clean;
        public Value<int?> TQLFraudAlertsTotalMediumUnaddressed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertsTotalMediumUnaddressed() => !TQLFraudAlertsTotalMediumUnaddressed.Clean;
        public Value<string> WellsFargo4506TBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWellsFargo4506TBaselineReportRequired() => !WellsFargo4506TBaselineReportRequired.Clean;
        public Value<string> WellsFargoComplianceBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWellsFargoComplianceBaselineReportRequired() => !WellsFargoComplianceBaselineReportRequired.Clean;
        public Value<string> WellsFargoFloodBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWellsFargoFloodBaselineReportRequired() => !WellsFargoFloodBaselineReportRequired.Clean;
        public Value<string> WellsFargoFraudBaselineReportRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWellsFargoFraudBaselineReportRequired() => !WellsFargoFraudBaselineReportRequired.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Citibank4506TBaselineReportRequired.Clean
                    && CitibankCCVPBaselineReportRequired.Clean
                    && CitibankComplianceBaselineReportRequired.Clean
                    && CitibankFloodBaselineReportRequired.Clean
                    && CitibankFraudBaselineReportRequired.Clean
                    && CurrentInvestorPublishingStatus.Clean
                    && DriveAppVerifyScore.Clean
                    && DriveIDVerifyScore.Clean
                    && DrivePropertyVerifyScore.Clean
                    && DriveScore.Clean
                    && DriveStatus.Clean
                    && Homeward4506TBaselineReportRequired.Clean
                    && HomewardComplianceBaselineReportRequired.Clean
                    && HomewardFloodBaselineReportRequired.Clean
                    && HomewardFraudBaselineReportRequired.Clean
                    && Id.Clean
                    && LastCCVPCompletedDate.Clean
                    && LastCCVPConfidenceScore.Clean
                    && LastCCVPEstimatedValue.Clean
                    && LastCCVPForecastDeviationScore.Clean
                    && LastCCVPReportHistoryProResult.Clean
                    && LastCCVPReportID.Clean
                    && LastCCVPReportOrdered.Clean
                    && LastCCVPReportPassResult.Clean
                    && LastCCVPResultsReportReturned.Clean
                    && LastComplianceCompletedDate.Clean
                    && LastComplianceNumberOfAlertMessages.Clean
                    && LastComplianceNumberOfErrorMessages.Clean
                    && LastComplianceNumberOfFailMessages.Clean
                    && LastComplianceNumberOfPassMessages.Clean
                    && LastComplianceNumberOfWarningMessages.Clean
                    && LastComplianceOrderType.Clean
                    && LastComplianceProductNameReportOrdered.Clean
                    && LastComplianceReportID.Clean
                    && LastFraudOrderAlerts.Clean
                    && LastFraudOrderCompletedDate.Clean
                    && LastFraudOrderProduct.Clean
                    && LastFraudReportID.Clean
                    && LastInvestorPublishingInvestor.Clean
                    && LastInvestorPublishingStatusChangeDate.Clean
                    && LastInvestorPublishingUserWhoChangeStatus.Clean
                    && LastUserIDWhoOrderedCCVP.Clean
                    && LastUserIDWhoOrderedCompliance.Clean
                    && LastUserIDWhoOrderedFraudOrder.Clean
                    && PHH4506TBaselineReportRequired.Clean
                    && PHHComplianceBaselineReportRequired.Clean
                    && PHHFloodBaselineReportRequired.Clean
                    && PHHFraudBaselineReportRequired.Clean
                    && Stonegate4506TBaselineReport.Clean
                    && StonegateComplianceBaselineReportRequired.Clean
                    && StonegateFloodBaselineReportRequired.Clean
                    && StonegateFraudBaselineReportRequired.Clean
                    && TQLComplianceAlerts.Clean
                    && TQLDocuments.Clean
                    && TQLFraudAlerts.Clean
                    && TQLFraudAlertsTotal.Clean
                    && TQLFraudAlertsTotalHigh.Clean
                    && TQLFraudAlertsTotalHighUnaddressed.Clean
                    && TQLFraudAlertsTotalLow.Clean
                    && TQLFraudAlertsTotalLowUnaddressed.Clean
                    && TQLFraudAlertsTotalMedium.Clean
                    && TQLFraudAlertsTotalMediumUnaddressed.Clean
                    && WellsFargo4506TBaselineReportRequired.Clean
                    && WellsFargoComplianceBaselineReportRequired.Clean
                    && WellsFargoFloodBaselineReportRequired.Clean
                    && WellsFargoFraudBaselineReportRequired.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Citibank4506TBaselineReportRequired; v0.Clean = value; Citibank4506TBaselineReportRequired = v0;
                var v1 = CitibankCCVPBaselineReportRequired; v1.Clean = value; CitibankCCVPBaselineReportRequired = v1;
                var v2 = CitibankComplianceBaselineReportRequired; v2.Clean = value; CitibankComplianceBaselineReportRequired = v2;
                var v3 = CitibankFloodBaselineReportRequired; v3.Clean = value; CitibankFloodBaselineReportRequired = v3;
                var v4 = CitibankFraudBaselineReportRequired; v4.Clean = value; CitibankFraudBaselineReportRequired = v4;
                var v5 = CurrentInvestorPublishingStatus; v5.Clean = value; CurrentInvestorPublishingStatus = v5;
                var v6 = DriveAppVerifyScore; v6.Clean = value; DriveAppVerifyScore = v6;
                var v7 = DriveIDVerifyScore; v7.Clean = value; DriveIDVerifyScore = v7;
                var v8 = DrivePropertyVerifyScore; v8.Clean = value; DrivePropertyVerifyScore = v8;
                var v9 = DriveScore; v9.Clean = value; DriveScore = v9;
                var v10 = DriveStatus; v10.Clean = value; DriveStatus = v10;
                var v11 = Homeward4506TBaselineReportRequired; v11.Clean = value; Homeward4506TBaselineReportRequired = v11;
                var v12 = HomewardComplianceBaselineReportRequired; v12.Clean = value; HomewardComplianceBaselineReportRequired = v12;
                var v13 = HomewardFloodBaselineReportRequired; v13.Clean = value; HomewardFloodBaselineReportRequired = v13;
                var v14 = HomewardFraudBaselineReportRequired; v14.Clean = value; HomewardFraudBaselineReportRequired = v14;
                var v15 = Id; v15.Clean = value; Id = v15;
                var v16 = LastCCVPCompletedDate; v16.Clean = value; LastCCVPCompletedDate = v16;
                var v17 = LastCCVPConfidenceScore; v17.Clean = value; LastCCVPConfidenceScore = v17;
                var v18 = LastCCVPEstimatedValue; v18.Clean = value; LastCCVPEstimatedValue = v18;
                var v19 = LastCCVPForecastDeviationScore; v19.Clean = value; LastCCVPForecastDeviationScore = v19;
                var v20 = LastCCVPReportHistoryProResult; v20.Clean = value; LastCCVPReportHistoryProResult = v20;
                var v21 = LastCCVPReportID; v21.Clean = value; LastCCVPReportID = v21;
                var v22 = LastCCVPReportOrdered; v22.Clean = value; LastCCVPReportOrdered = v22;
                var v23 = LastCCVPReportPassResult; v23.Clean = value; LastCCVPReportPassResult = v23;
                var v24 = LastCCVPResultsReportReturned; v24.Clean = value; LastCCVPResultsReportReturned = v24;
                var v25 = LastComplianceCompletedDate; v25.Clean = value; LastComplianceCompletedDate = v25;
                var v26 = LastComplianceNumberOfAlertMessages; v26.Clean = value; LastComplianceNumberOfAlertMessages = v26;
                var v27 = LastComplianceNumberOfErrorMessages; v27.Clean = value; LastComplianceNumberOfErrorMessages = v27;
                var v28 = LastComplianceNumberOfFailMessages; v28.Clean = value; LastComplianceNumberOfFailMessages = v28;
                var v29 = LastComplianceNumberOfPassMessages; v29.Clean = value; LastComplianceNumberOfPassMessages = v29;
                var v30 = LastComplianceNumberOfWarningMessages; v30.Clean = value; LastComplianceNumberOfWarningMessages = v30;
                var v31 = LastComplianceOrderType; v31.Clean = value; LastComplianceOrderType = v31;
                var v32 = LastComplianceProductNameReportOrdered; v32.Clean = value; LastComplianceProductNameReportOrdered = v32;
                var v33 = LastComplianceReportID; v33.Clean = value; LastComplianceReportID = v33;
                var v34 = LastFraudOrderAlerts; v34.Clean = value; LastFraudOrderAlerts = v34;
                var v35 = LastFraudOrderCompletedDate; v35.Clean = value; LastFraudOrderCompletedDate = v35;
                var v36 = LastFraudOrderProduct; v36.Clean = value; LastFraudOrderProduct = v36;
                var v37 = LastFraudReportID; v37.Clean = value; LastFraudReportID = v37;
                var v38 = LastInvestorPublishingInvestor; v38.Clean = value; LastInvestorPublishingInvestor = v38;
                var v39 = LastInvestorPublishingStatusChangeDate; v39.Clean = value; LastInvestorPublishingStatusChangeDate = v39;
                var v40 = LastInvestorPublishingUserWhoChangeStatus; v40.Clean = value; LastInvestorPublishingUserWhoChangeStatus = v40;
                var v41 = LastUserIDWhoOrderedCCVP; v41.Clean = value; LastUserIDWhoOrderedCCVP = v41;
                var v42 = LastUserIDWhoOrderedCompliance; v42.Clean = value; LastUserIDWhoOrderedCompliance = v42;
                var v43 = LastUserIDWhoOrderedFraudOrder; v43.Clean = value; LastUserIDWhoOrderedFraudOrder = v43;
                var v44 = PHH4506TBaselineReportRequired; v44.Clean = value; PHH4506TBaselineReportRequired = v44;
                var v45 = PHHComplianceBaselineReportRequired; v45.Clean = value; PHHComplianceBaselineReportRequired = v45;
                var v46 = PHHFloodBaselineReportRequired; v46.Clean = value; PHHFloodBaselineReportRequired = v46;
                var v47 = PHHFraudBaselineReportRequired; v47.Clean = value; PHHFraudBaselineReportRequired = v47;
                var v48 = Stonegate4506TBaselineReport; v48.Clean = value; Stonegate4506TBaselineReport = v48;
                var v49 = StonegateComplianceBaselineReportRequired; v49.Clean = value; StonegateComplianceBaselineReportRequired = v49;
                var v50 = StonegateFloodBaselineReportRequired; v50.Clean = value; StonegateFloodBaselineReportRequired = v50;
                var v51 = StonegateFraudBaselineReportRequired; v51.Clean = value; StonegateFraudBaselineReportRequired = v51;
                var v52 = TQLComplianceAlerts; v52.Clean = value; TQLComplianceAlerts = v52;
                var v53 = TQLDocuments; v53.Clean = value; TQLDocuments = v53;
                var v54 = TQLFraudAlerts; v54.Clean = value; TQLFraudAlerts = v54;
                var v55 = TQLFraudAlertsTotal; v55.Clean = value; TQLFraudAlertsTotal = v55;
                var v56 = TQLFraudAlertsTotalHigh; v56.Clean = value; TQLFraudAlertsTotalHigh = v56;
                var v57 = TQLFraudAlertsTotalHighUnaddressed; v57.Clean = value; TQLFraudAlertsTotalHighUnaddressed = v57;
                var v58 = TQLFraudAlertsTotalLow; v58.Clean = value; TQLFraudAlertsTotalLow = v58;
                var v59 = TQLFraudAlertsTotalLowUnaddressed; v59.Clean = value; TQLFraudAlertsTotalLowUnaddressed = v59;
                var v60 = TQLFraudAlertsTotalMedium; v60.Clean = value; TQLFraudAlertsTotalMedium = v60;
                var v61 = TQLFraudAlertsTotalMediumUnaddressed; v61.Clean = value; TQLFraudAlertsTotalMediumUnaddressed = v61;
                var v62 = WellsFargo4506TBaselineReportRequired; v62.Clean = value; WellsFargo4506TBaselineReportRequired = v62;
                var v63 = WellsFargoComplianceBaselineReportRequired; v63.Clean = value; WellsFargoComplianceBaselineReportRequired = v63;
                var v64 = WellsFargoFloodBaselineReportRequired; v64.Clean = value; WellsFargoFloodBaselineReportRequired = v64;
                var v65 = WellsFargoFraudBaselineReportRequired; v65.Clean = value; WellsFargoFraudBaselineReportRequired = v65;
                _settingClean = 0;
            }
        }
    }
}