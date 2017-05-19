using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class TQL
    {
        public string CurrentInvestorPublishingStatus { get; set; }
        public DateTime? LastInvestorPublishingStatusChangeDate { get; set; }
        public string LastInvestorPublishingInvestor { get; set; }
        public string LastInvestorPublishingUserWhoChangeStatus { get; set; }
        public DateTime? LastFraudOrderCompletedDate { get; set; }
        public string LastFraudOrderProduct { get; set; }
        public int? LastFraudOrderAlerts { get; set; }
        public List<TQLFraudAlert> TQLFraudAlerts { get; set; }
        public string LastUserIDWhoOrderedFraudOrder { get; set; }
        public DateTime? LastCCVPCompletedDate { get; set; }
        public string LastCCVPReportOrdered { get; set; }
        public string LastCCVPConfidenceScore { get; set; }
        public string LastCCVPForecastDeviationScore { get; set; }
        public string LastCCVPEstimatedValue { get; set; }
        public string LastCCVPResultsReportReturned { get; set; }
        public string LastUserIDWhoOrderedCCVP { get; set; }
        public DateTime? LastComplianceCompletedDate { get; set; }
        public string LastComplianceProductNameReportOrdered { get; set; }
        public string LastComplianceOrderType { get; set; }
        public int? LastComplianceNumberOfAlertMessages { get; set; }
        public int? LastComplianceNumberOfFailMessages { get; set; }
        public int? LastComplianceNumberOfPassMessages { get; set; }
        public int? LastComplianceNumberOfWarningMessages { get; set; }
        public int? LastComplianceNumberOfErrorMessages { get; set; }
        public List<TQLComplianceAlert> TQLComplianceAlerts { get; set; }
        public string LastUserIDWhoOrderedCompliance { get; set; }
        public string LastCCVPReportPassResult { get; set; }
        public string LastCCVPReportHistoryProResult { get; set; }
        public string LastCCVPReportID { get; set; }
        public string LastFraudReportID { get; set; }
        public string LastComplianceReportID { get; set; }
        public string WellsFargo4506TBaselineReportRequired { get; set; }
        public string WellsFargoFraudBaselineReportRequired { get; set; }
        public string WellsFargoComplianceBaselineReportRequired { get; set; }
        public string WellsFargoFloodBaselineReportRequired { get; set; }
        public string CitibankCCVPBaselineReportRequired { get; set; }
        public string CitibankFraudBaselineReportRequired { get; set; }
        public string CitibankComplianceBaselineReportRequired { get; set; }
        public string Citibank4506TBaselineReportRequired { get; set; }
        public string CitibankFloodBaselineReportRequired { get; set; }
        public string Homeward4506TBaselineReportRequired { get; set; }
        public string HomewardFraudBaselineReportRequired { get; set; }
        public string HomewardComplianceBaselineReportRequired { get; set; }
        public string HomewardFloodBaselineReportRequired { get; set; }
        public string Stonegate4506TBaselineReport { get; set; }
        public string StonegateFraudBaselineReportRequired { get; set; }
        public string StonegateComplianceBaselineReportRequired { get; set; }
        public string StonegateFloodBaselineReportRequired { get; set; }
        public string PHH4506TBaselineReportRequired { get; set; }
        public string PHHFraudBaselineReportRequired { get; set; }
        public string PHHComplianceBaselineReportRequired { get; set; }
        public string PHHFloodBaselineReportRequired { get; set; }
        public int? TQLFraudAlertsTotal { get; set; }
        public int? TQLFraudAlertsTotalHigh { get; set; }
        public int? TQLFraudAlertsTotalMedium { get; set; }
        public int? TQLFraudAlertsTotalLow { get; set; }
        public int? TQLFraudAlertsTotalHighUnaddressed { get; set; }
        public int? TQLFraudAlertsTotalMediumUnaddressed { get; set; }
        public int? TQLFraudAlertsTotalLowUnaddressed { get; set; }
        public int? DriveScore { get; set; }
        public string DriveStatus { get; set; }
        public int? DriveIDVerifyScore { get; set; }
        public int? DriveAppVerifyScore { get; set; }
        public int? DrivePropertyVerifyScore { get; set; }
        public List<TQLDocument> TQLDocuments { get; set; }
        public string Id { get; set; }
    }
}