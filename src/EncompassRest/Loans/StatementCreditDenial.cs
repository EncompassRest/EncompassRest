using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class StatementCreditDenial
    {
        public DateTime? DenialMailedOn { get; set; }
        public bool? InformationObtainedInReportFromCra { get; set; }
        public bool? InformationObtainedFromOutsideSource { get; set; }
        public bool? AdditionalStatement { get; set; }
        public string DenialDescription { get; set; }
        public bool? NoCreditFile { get; set; }
        public bool? InsufficientCreditReference { get; set; }
        public bool? InsufficientCreditFile { get; set; }
        public bool? UnableToVerifyCreditReferences { get; set; }
        public bool? Garnishment { get; set; }
        public bool? ExcessiveObligations { get; set; }
        public bool? InsufficientIncomeForTotalObligations { get; set; }
        public bool? UnacceptablePaymentRecordOnPreviousMtg { get; set; }
        public bool? LackOfCashReserves { get; set; }
        public bool? DelinquentCreditObligations { get; set; }
        public bool? Bankruptcy { get; set; }
        public bool? InformationFromAConsumerReportingAgency { get; set; }
        public bool? UnableToVerifyEmployment { get; set; }
        public bool? LengthOfEmployment { get; set; }
        public bool? TemporaryOrIrregularEmployment { get; set; }
        public bool? InsufficientStabilityOfIncome { get; set; }
        public bool? UnableToVerifyIncome { get; set; }
        public bool? TemporaryResidence { get; set; }
        public bool? ToShortPeriodOfResidence { get; set; }
        public bool? UnableToVerifyResidence { get; set; }
        public bool? DeniedByHud { get; set; }
        public bool? DeniedByVa { get; set; }
        public bool? DeniedByFnma { get; set; }
        public bool? DeniedByFhlmc { get; set; }
        public bool? DeniedByOther { get; set; }
        public string OtherDescription { get; set; }
        public bool? InsufficientFundsToCloseLoan { get; set; }
        public bool? CreditApplicationIncomplete { get; set; }
        public bool? InadequateCollateral { get; set; }
        public bool? UnacceptableProperty { get; set; }
        public bool? InsufficientData { get; set; }
        public bool? UnacceptableAppraisal { get; set; }
        public bool? UnacceptableLeaseholdEstate { get; set; }
        public bool? WeDoNotGrantCredit { get; set; }
        public bool? WithdrawnByApplicant { get; set; }
        public bool? DenialOther1 { get; set; }
        public string DenialOtherDesc1 { get; set; }
        public bool? DenialOther2 { get; set; }
        public string DenialOtherDesc2 { get; set; }
        public DateTime? DenialDate { get; set; }
        public string DeniedBy { get; set; }
        public string DescriptionofAccount1 { get; set; }
        public string DescriptionofAccount2 { get; set; }
        public string DescriptionofAccount3 { get; set; }
        public string DescriptionofActionTaken1 { get; set; }
        public string DescriptionofActionTaken2 { get; set; }
        public bool? CreditReportObtainedFromConsumerReportingAgency { get; set; }
        public bool? UnacceptableCreditReferencesProvided { get; set; }
        public bool? PoorCreditPerformance { get; set; }
        public bool? NumberRecentInquiriesCredit { get; set; }
        public bool? CollateralNotSufficient { get; set; }
        public string LenderInvestorName { get; set; }
        public string LenderInvestorAddress { get; set; }
        public string LenderInvestorCity { get; set; }
        public string LenderInvestorState { get; set; }
        public string LenderInvestorPostalCode { get; set; }
        public string LenderInvestorPhone { get; set; }
        public string EcoaAddress { get; set; }
        public string EcoaAddress2 { get; set; }
        public string EcoaCity { get; set; }
        public string EcoaName { get; set; }
        public string EcoaPhone { get; set; }
        public string EcoaState { get; set; }
        public string EcoaPostalCode { get; set; }
        public string Id { get; set; }
    }
}