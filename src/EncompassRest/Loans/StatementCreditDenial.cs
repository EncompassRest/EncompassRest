using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class StatementCreditDenial
    {
        public JsonNullable<bool?> AdditionalStatement { get; set; }
        public JsonNullable<bool?> Bankruptcy { get; set; }
        public JsonNullable<bool?> CollateralNotSufficient { get; set; }
        public JsonNullable<bool?> CreditApplicationIncomplete { get; set; }
        public JsonNullable<bool?> CreditReportObtainedFromConsumerReportingAgency { get; set; }
        public JsonNullable<bool?> DelinquentCreditObligations { get; set; }
        public JsonNullable<DateTime?> DenialDate { get; set; }
        public string DenialDescription { get; set; }
        public JsonNullable<DateTime?> DenialMailedOn { get; set; }
        public JsonNullable<bool?> DenialOther1 { get; set; }
        public JsonNullable<bool?> DenialOther2 { get; set; }
        public string DenialOtherDesc1 { get; set; }
        public string DenialOtherDesc2 { get; set; }
        public string DeniedBy { get; set; }
        public JsonNullable<bool?> DeniedByFhlmc { get; set; }
        public JsonNullable<bool?> DeniedByFnma { get; set; }
        public JsonNullable<bool?> DeniedByHud { get; set; }
        public JsonNullable<bool?> DeniedByOther { get; set; }
        public JsonNullable<bool?> DeniedByVa { get; set; }
        public string DescriptionofAccount1 { get; set; }
        public string DescriptionofAccount2 { get; set; }
        public string DescriptionofAccount3 { get; set; }
        public string DescriptionofActionTaken1 { get; set; }
        public string DescriptionofActionTaken2 { get; set; }
        public string EcoaAddress { get; set; }
        public string EcoaAddress2 { get; set; }
        public string EcoaCity { get; set; }
        public string EcoaName { get; set; }
        public string EcoaPhone { get; set; }
        public string EcoaPostalCode { get; set; }
        public string EcoaState { get; set; }
        public JsonNullable<bool?> ExcessiveObligations { get; set; }
        public JsonNullable<bool?> Garnishment { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> InadequateCollateral { get; set; }
        public JsonNullable<bool?> InformationFromAConsumerReportingAgency { get; set; }
        public JsonNullable<bool?> InformationObtainedFromOutsideSource { get; set; }
        public JsonNullable<bool?> InformationObtainedInReportFromCra { get; set; }
        public JsonNullable<bool?> InsufficientCreditFile { get; set; }
        public JsonNullable<bool?> InsufficientCreditReference { get; set; }
        public JsonNullable<bool?> InsufficientData { get; set; }
        public JsonNullable<bool?> InsufficientFundsToCloseLoan { get; set; }
        public JsonNullable<bool?> InsufficientIncomeForTotalObligations { get; set; }
        public JsonNullable<bool?> InsufficientStabilityOfIncome { get; set; }
        public JsonNullable<bool?> LackOfCashReserves { get; set; }
        public string LenderInvestorAddress { get; set; }
        public string LenderInvestorCity { get; set; }
        public string LenderInvestorName { get; set; }
        public string LenderInvestorPhone { get; set; }
        public string LenderInvestorPostalCode { get; set; }
        public string LenderInvestorState { get; set; }
        public JsonNullable<bool?> LengthOfEmployment { get; set; }
        public JsonNullable<bool?> NoCreditFile { get; set; }
        public JsonNullable<bool?> NumberRecentInquiriesCredit { get; set; }
        public string OtherDescription { get; set; }
        public JsonNullable<bool?> PoorCreditPerformance { get; set; }
        public JsonNullable<bool?> TemporaryOrIrregularEmployment { get; set; }
        public JsonNullable<bool?> TemporaryResidence { get; set; }
        public JsonNullable<bool?> ToShortPeriodOfResidence { get; set; }
        public JsonNullable<bool?> UnableToVerifyCreditReferences { get; set; }
        public JsonNullable<bool?> UnableToVerifyEmployment { get; set; }
        public JsonNullable<bool?> UnableToVerifyIncome { get; set; }
        public JsonNullable<bool?> UnableToVerifyResidence { get; set; }
        public JsonNullable<bool?> UnacceptableAppraisal { get; set; }
        public JsonNullable<bool?> UnacceptableCreditReferencesProvided { get; set; }
        public JsonNullable<bool?> UnacceptableLeaseholdEstate { get; set; }
        public JsonNullable<bool?> UnacceptablePaymentRecordOnPreviousMtg { get; set; }
        public JsonNullable<bool?> UnacceptableProperty { get; set; }
        public JsonNullable<bool?> WeDoNotGrantCredit { get; set; }
        public JsonNullable<bool?> WithdrawnByApplicant { get; set; }
    }
}