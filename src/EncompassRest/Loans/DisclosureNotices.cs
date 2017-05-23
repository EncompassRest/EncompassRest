using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureNotices
    {
        public JsonNullable<bool?> AntiCoercionStatementIndicator { get; set; }
        public string CommitmentIssuedByAddress { get; set; }
        public string CommitmentIssuedByCity { get; set; }
        public string CommitmentIssuedByContactName { get; set; }
        public string CommitmentIssuedByName { get; set; }
        public string CommitmentIssuedByPhone { get; set; }
        public string CommitmentIssuedByPostalCode { get; set; }
        public string CommitmentIssuedByState { get; set; }
        public string ConsumerHandbookOnAdjustableRateMortgages { get; set; }
        public string DaysToReceiveWrittenRequest { get; set; }
        public JsonNullable<int?> DaysToReturnToLender { get; set; }
        public string DiscloseNonPublicPersonalInformation { get; set; }
        public string EcoaAddress { get; set; }
        public string EcoaAddress2 { get; set; }
        public string EcoaCity { get; set; }
        public string EcoaName { get; set; }
        public string EcoaPhone { get; set; }
        public string EcoaPostalCode { get; set; }
        public string EcoaState { get; set; }
        public string FairLendingNoticeDescription1 { get; set; }
        public string FairLendingNoticeDescription2 { get; set; }
        public string FairLendingNoticeDescription3 { get; set; }
        public string FairLendingNoticeDescription4 { get; set; }
        public string FairLendingNoticeDescription5 { get; set; }
        public string FairLendingNoticeDescription6 { get; set; }
        public string FairLendingNoticeDescription7 { get; set; }
        public string FairLendingNoticeDescription8 { get; set; }
        public string FemaCommunityName { get; set; }
        public JsonNullable<bool?> FloodInsuranceNotificationIndicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> InformationDisclosureAuthorizationIndicator { get; set; }
        public string LicensedMortgageBrokerUnder { get; set; }
        public JsonNullable<bool?> LocatedInNfipIndicator { get; set; }
        public string LossPayeeClause { get; set; }
        public string MapPanelNumber { get; set; }
        public string NFIPCommunityNumber { get; set; }
        public JsonNullable<DateTime?> NFIPMapEffectiveRevisedDate { get; set; }
        public string NonFinancialCompaniesDescription1 { get; set; }
        public string NonFinancialCompaniesDescription2 { get; set; }
        public string NonFinancialCompaniesDescription3 { get; set; }
        public string NonFinancialCompaniesDescription4 { get; set; }
        public JsonNullable<bool?> NotLocatedInNfipIndicator { get; set; }
        public JsonNullable<bool?> OccupancyStatementIndicator { get; set; }
        public string OptOut { get; set; }
        public string OptOutPhone { get; set; }
        public JsonNullable<bool?> ReleaseBankingInformationIndicator { get; set; }
        public JsonNullable<bool?> ReleaseEmploymentInformationIndicator { get; set; }
        public JsonNullable<bool?> ReleaseInformationInConnectionWithCreditReportIndicator { get; set; }
        public JsonNullable<bool?> ReleaseMortgageInformationIndicator { get; set; }
        public JsonNullable<bool?> RightToFinancialPrivacyActIndicator { get; set; }
    }
}