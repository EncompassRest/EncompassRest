
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class TQL
{
public string currentInvestorPublishingStatus { get; set; }
public DateTime? lastInvestorPublishingStatusChangeDate { get; set; }
public string lastInvestorPublishingInvestor { get; set; }
public string lastInvestorPublishingUserWhoChangeStatus { get; set; }
public DateTime? lastFraudOrderCompletedDate { get; set; }
public string lastFraudOrderProduct { get; set; }
public int? lastFraudOrderAlerts { get; set; }
public List<TQLFraudAlert> tQLFraudAlerts { get; set; }
public string lastUserIDWhoOrderedFraudOrder { get; set; }
public DateTime? lastCCVPCompletedDate { get; set; }
public string lastCCVPReportOrdered { get; set; }
public string lastCCVPConfidenceScore { get; set; }
public string lastCCVPForecastDeviationScore { get; set; }
public string lastCCVPEstimatedValue { get; set; }
public string lastCCVPResultsReportReturned { get; set; }
public string lastUserIDWhoOrderedCCVP { get; set; }
public DateTime? lastComplianceCompletedDate { get; set; }
public string lastComplianceProductNameReportOrdered { get; set; }
public string lastComplianceOrderType { get; set; }
public int? lastComplianceNumberOfAlertMessages { get; set; }
public int? lastComplianceNumberOfFailMessages { get; set; }
public int? lastComplianceNumberOfPassMessages { get; set; }
public int? lastComplianceNumberOfWarningMessages { get; set; }
public int? lastComplianceNumberOfErrorMessages { get; set; }
public List<TQLComplianceAlert> tQLComplianceAlerts { get; set; }
public string lastUserIDWhoOrderedCompliance { get; set; }
public string lastCCVPReportPassResult { get; set; }
public string lastCCVPReportHistoryProResult { get; set; }
public string lastCCVPReportID { get; set; }
public string lastFraudReportID { get; set; }
public string lastComplianceReportID { get; set; }
public string wellsFargo4506TBaselineReportRequired { get; set; }
public string wellsFargoFraudBaselineReportRequired { get; set; }
public string wellsFargoComplianceBaselineReportRequired { get; set; }
public string wellsFargoFloodBaselineReportRequired { get; set; }
public string citibankCCVPBaselineReportRequired { get; set; }
public string citibankFraudBaselineReportRequired { get; set; }
public string citibankComplianceBaselineReportRequired { get; set; }
public string citibank4506TBaselineReportRequired { get; set; }
public string citibankFloodBaselineReportRequired { get; set; }
public string homeward4506TBaselineReportRequired { get; set; }
public string homewardFraudBaselineReportRequired { get; set; }
public string homewardComplianceBaselineReportRequired { get; set; }
public string homewardFloodBaselineReportRequired { get; set; }
public string stonegate4506TBaselineReport { get; set; }
public string stonegateFraudBaselineReportRequired { get; set; }
public string stonegateComplianceBaselineReportRequired { get; set; }
public string stonegateFloodBaselineReportRequired { get; set; }
public string pHH4506TBaselineReportRequired { get; set; }
public string pHHFraudBaselineReportRequired { get; set; }
public string pHHComplianceBaselineReportRequired { get; set; }
public string pHHFloodBaselineReportRequired { get; set; }
public int? tQLFraudAlertsTotal { get; set; }
public int? tQLFraudAlertsTotalHigh { get; set; }
public int? tQLFraudAlertsTotalMedium { get; set; }
public int? tQLFraudAlertsTotalLow { get; set; }
public int? tQLFraudAlertsTotalHighUnaddressed { get; set; }
public int? tQLFraudAlertsTotalMediumUnaddressed { get; set; }
public int? tQLFraudAlertsTotalLowUnaddressed { get; set; }
public int? driveScore { get; set; }
public string driveStatus { get; set; }
public int? driveIDVerifyScore { get; set; }
public int? driveAppVerifyScore { get; set; }
public int? drivePropertyVerifyScore { get; set; }
public List<TQLDocument> tQLDocuments { get; set; }
public string id { get; set; }

    }
}