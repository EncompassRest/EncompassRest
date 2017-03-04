
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class DisclosureNotices
    {
        public bool? occupancyStatementIndicator { get; set; }
        public bool? informationDisclosureAuthorizationIndicator { get; set; }
        public bool? releaseEmploymentInformationIndicator { get; set; }
        public bool? releaseBankingInformationIndicator { get; set; }
        public bool? releaseMortgageInformationIndicator { get; set; }
        public bool? releaseInformationInConnectionWithCreditReportIndicator { get; set; }
        public bool? antiCoercionStatementIndicator { get; set; }
        public bool? floodInsuranceNotificationIndicator { get; set; }
        public string lossPayeeClause { get; set; }
        public string consumerHandbookOnAdjustableRateMortgages { get; set; }
        public string ecoaName { get; set; }
        public string fairLendingNoticeDescription1 { get; set; }
        public string fairLendingNoticeDescription2 { get; set; }
        public string fairLendingNoticeDescription3 { get; set; }
        public string fairLendingNoticeDescription4 { get; set; }
        public string fairLendingNoticeDescription5 { get; set; }
        public string fairLendingNoticeDescription6 { get; set; }
        public string fairLendingNoticeDescription7 { get; set; }
        public string fairLendingNoticeDescription8 { get; set; }
        public string daysToReceiveWrittenRequest { get; set; }
        public string licensedMortgageBrokerUnder { get; set; }
        public string ecoaAddress { get; set; }
        public string commitmentIssuedByContactName { get; set; }
        public string commitmentIssuedByName { get; set; }
        public string commitmentIssuedByAddress { get; set; }
        public string commitmentIssuedByCity { get; set; }
        public string commitmentIssuedByState { get; set; }
        public string commitmentIssuedByPostalCode { get; set; }
        public string commitmentIssuedByPhone { get; set; }
        public string discloseNonPublicPersonalInformation { get; set; }
        public string ecoaAddress2 { get; set; }
        public string nonFinancialCompaniesDescription1 { get; set; }
        public string nonFinancialCompaniesDescription2 { get; set; }
        public string nonFinancialCompaniesDescription3 { get; set; }
        public string nonFinancialCompaniesDescription4 { get; set; }
        public string optOutPhone { get; set; }
        public string optOut { get; set; }
        public int? daysToReturnToLender { get; set; }
        public bool? locatedInNfipIndicator { get; set; }
        public bool? notLocatedInNfipIndicator { get; set; }
        public string femaCommunityName { get; set; }
        public string nFIPCommunityNumber { get; set; }
        public DateTime? nFIPMapEffectiveRevisedDate { get; set; }
        public string mapPanelNumber { get; set; }
        public string ecoaCity { get; set; }
        public string ecoaState { get; set; }
        public string ecoaPostalCode { get; set; }
        public string ecoaPhone { get; set; }
        public bool? rightToFinancialPrivacyActIndicator { get; set; }
        public string id { get; set; }

    }
}