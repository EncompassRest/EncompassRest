
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class StatementCreditDenial
    {
        public DateTime? denialMailedOn { get; set; }
        public bool? informationObtainedInReportFromCra { get; set; }
        public bool? informationObtainedFromOutsideSource { get; set; }
        public bool? additionalStatement { get; set; }
        public string denialDescription { get; set; }
        public bool? noCreditFile { get; set; }
        public bool? insufficientCreditReference { get; set; }
        public bool? insufficientCreditFile { get; set; }
        public bool? unableToVerifyCreditReferences { get; set; }
        public bool? garnishment { get; set; }
        public bool? excessiveObligations { get; set; }
        public bool? insufficientIncomeForTotalObligations { get; set; }
        public bool? unacceptablePaymentRecordOnPreviousMtg { get; set; }
        public bool? lackOfCashReserves { get; set; }
        public bool? delinquentCreditObligations { get; set; }
        public bool? bankruptcy { get; set; }
        public bool? informationFromAConsumerReportingAgency { get; set; }
        public bool? unableToVerifyEmployment { get; set; }
        public bool? lengthOfEmployment { get; set; }
        public bool? temporaryOrIrregularEmployment { get; set; }
        public bool? insufficientStabilityOfIncome { get; set; }
        public bool? unableToVerifyIncome { get; set; }
        public bool? temporaryResidence { get; set; }
        public bool? toShortPeriodOfResidence { get; set; }
        public bool? unableToVerifyResidence { get; set; }
        public bool? deniedByHud { get; set; }
        public bool? deniedByVa { get; set; }
        public bool? deniedByFnma { get; set; }
        public bool? deniedByFhlmc { get; set; }
        public bool? deniedByOther { get; set; }
        public string otherDescription { get; set; }
        public bool? insufficientFundsToCloseLoan { get; set; }
        public bool? creditApplicationIncomplete { get; set; }
        public bool? inadequateCollateral { get; set; }
        public bool? unacceptableProperty { get; set; }
        public bool? insufficientData { get; set; }
        public bool? unacceptableAppraisal { get; set; }
        public bool? unacceptableLeaseholdEstate { get; set; }
        public bool? weDoNotGrantCredit { get; set; }
        public bool? withdrawnByApplicant { get; set; }
        public bool? denialOther1 { get; set; }
        public string denialOtherDesc1 { get; set; }
        public bool? denialOther2 { get; set; }
        public string denialOtherDesc2 { get; set; }
        public DateTime? denialDate { get; set; }
        public string deniedBy { get; set; }
        public string descriptionofAccount1 { get; set; }
        public string descriptionofAccount2 { get; set; }
        public string descriptionofAccount3 { get; set; }
        public string descriptionofActionTaken1 { get; set; }
        public string descriptionofActionTaken2 { get; set; }
        public bool? creditReportObtainedFromConsumerReportingAgency { get; set; }
        public bool? unacceptableCreditReferencesProvided { get; set; }
        public bool? poorCreditPerformance { get; set; }
        public bool? numberRecentInquiriesCredit { get; set; }
        public bool? collateralNotSufficient { get; set; }
        public string lenderInvestorName { get; set; }
        public string lenderInvestorAddress { get; set; }
        public string lenderInvestorCity { get; set; }
        public string lenderInvestorState { get; set; }
        public string lenderInvestorPostalCode { get; set; }
        public string lenderInvestorPhone { get; set; }
        public string ecoaAddress { get; set; }
        public string ecoaAddress2 { get; set; }
        public string ecoaCity { get; set; }
        public string ecoaName { get; set; }
        public string ecoaPhone { get; set; }
        public string ecoaState { get; set; }
        public string ecoaPostalCode { get; set; }
        public string id { get; set; }

    }
}