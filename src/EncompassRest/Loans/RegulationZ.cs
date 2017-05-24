using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZ
    {
        public Value<string> AcknowledgedDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcknowledgedDay() => !AcknowledgedDay.Clean;
        public Value<string> AcknowledgedMonth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcknowledgedMonth() => !AcknowledgedMonth.Clean;
        public Value<string> AcknowledgedYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcknowledgedYear() => !AcknowledgedYear.Clean;
        public Value<bool?> Acquisition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcquisition() => !Acquisition.Clean;
        public Value<string> AdditionalArmInformation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalArmInformation() => !AdditionalArmInformation.Clean;
        public Value<bool?> AllDateAndNumericalDisclosuresIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllDateAndNumericalDisclosuresIndicator() => !AllDateAndNumericalDisclosuresIndicator.Clean;
        public Value<decimal?> AmountFinanced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountFinanced() => !AmountFinanced.Clean;
        public Value<decimal?> AprPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprPercent() => !AprPercent.Clean;
        public Value<string> ArmDisclosureDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmDisclosureDescription() => !ArmDisclosureDescription.Clean;
        public Value<string> AssumptionOnYourProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumptionOnYourProperty() => !AssumptionOnYourProperty.Clean;
        public Value<DateTime?> BorrowerIntendToContinueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerIntendToContinueDate() => !BorrowerIntendToContinueDate.Clean;
        public Value<bool?> BorrowerIntendToContinueIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerIntendToContinueIndicator() => !BorrowerIntendToContinueIndicator.Clean;
        public Value<string> BorrowerMiTerminationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerMiTerminationDate() => !BorrowerMiTerminationDate.Clean;
        public Value<string> CalculateBasedOnRemainingBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCalculateBasedOnRemainingBalance() => !CalculateBasedOnRemainingBalance.Clean;
        public Value<bool?> ChargesAddedToPaymentsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesAddedToPaymentsIndicator() => !ChargesAddedToPaymentsIndicator.Clean;
        public Value<bool?> ChargesAtLoanClosingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesAtLoanClosingIndicator() => !ChargesAtLoanClosingIndicator.Clean;
        public Value<string> CircumstanceChangeReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCircumstanceChangeReason() => !CircumstanceChangeReason.Clean;
        public Value<DateTime?> CircumstanceChangeReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCircumstanceChangeReceivedDate() => !CircumstanceChangeReceivedDate.Clean;
        public Value<DateTime?> ClosingDisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosureReceivedDate() => !ClosingDisclosureReceivedDate.Clean;
        public Value<DateTime?> ClosingDisclosureSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosureSentDate() => !ClosingDisclosureSentDate.Clean;
        public Value<string> ConstructionFirstIntChangeAdjType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionFirstIntChangeAdjType() => !ConstructionFirstIntChangeAdjType.Clean;
        public Value<string> ConstructionLoanDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionLoanDescription() => !ConstructionLoanDescription.Clean;
        public Value<string> ConstructionLoanMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionLoanMethod() => !ConstructionLoanMethod.Clean;
        public Value<int?> ConstructionPeriodMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionPeriodMonths() => !ConstructionPeriodMonths.Clean;
        public Value<decimal?> ConstructionRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionRatePercent() => !ConstructionRatePercent.Clean;
        public Value<bool?> ConstructionRefinanceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionRefinanceIndicator() => !ConstructionRefinanceIndicator.Clean;
        public Value<decimal?> CreditDisability { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditDisability() => !CreditDisability.Clean;
        public Value<bool?> CreditDisabilityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditDisabilityIndicator() => !CreditDisabilityIndicator.Clean;
        public Value<decimal?> CreditLife { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLife() => !CreditLife.Clean;
        public Value<decimal?> CreditLifeAndCreditDisability { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLifeAndCreditDisability() => !CreditLifeAndCreditDisability.Clean;
        public Value<bool?> CreditLifeInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLifeInsuranceIndicator() => !CreditLifeInsuranceIndicator.Clean;
        public Value<bool?> CustomizePaymentScheduleIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCustomizePaymentScheduleIndicator() => !CustomizePaymentScheduleIndicator.Clean;
        public Value<bool?> DemandFeatureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDemandFeatureIndicator() => !DemandFeatureIndicator.Clean;
        public Value<decimal?> DisclosedAprPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedAprPercent() => !DisclosedAprPercent.Clean;
        public Value<bool?> DisclosedByBrokerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedByBrokerIndicator() => !DisclosedByBrokerIndicator.Clean;
        public Value<string> DisclosedComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedComments() => !DisclosedComments.Clean;
        public Value<decimal?> DisclosedDailyInterestCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedDailyInterestCharge() => !DisclosedDailyInterestCharge.Clean;
        public Value<decimal?> DisclosedFinanceCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedFinanceCharge() => !DisclosedFinanceCharge.Clean;
        public Value<bool?> DisclosedPrepayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedPrepayment() => !DisclosedPrepayment.Clean;
        public Value<string> DisclosedProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedProduct() => !DisclosedProduct.Clean;
        public Value<string> DisclosureMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureMethod() => !DisclosureMethod.Clean;
        public Value<string> DisclosureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureType() => !DisclosureType.Clean;
        public Value<int?> DiscountPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPeriod() => !DiscountPeriod.Clean;
        public Value<decimal?> DiscountRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountRatePercent() => !DiscountRatePercent.Clean;
        public Value<string> DiscountType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountType() => !DiscountType.Clean;
        public Value<DateTime?> DueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueDate() => !DueDate.Clean;
        public Value<DateTime?> EarliestClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEarliestClosingDate() => !EarliestClosingDate.Clean;
        public Value<DateTime?> EarliestFeeCollectionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEarliestFeeCollectionDate() => !EarliestFeeCollectionDate.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted1() => !eSignConsentBorrowerDateAccepted1.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted2() => !eSignConsentBorrowerDateAccepted2.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted3() => !eSignConsentBorrowerDateAccepted3.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted4() => !eSignConsentBorrowerDateAccepted4.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted5() => !eSignConsentBorrowerDateAccepted5.Clean;
        public Value<DateTime?> eSignConsentBorrowerDateAccepted6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerDateAccepted6() => !eSignConsentBorrowerDateAccepted6.Clean;
        public Value<string> eSignConsentBorrowerIPAddress1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress1() => !eSignConsentBorrowerIPAddress1.Clean;
        public Value<string> eSignConsentBorrowerIPAddress2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress2() => !eSignConsentBorrowerIPAddress2.Clean;
        public Value<string> eSignConsentBorrowerIPAddress3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress3() => !eSignConsentBorrowerIPAddress3.Clean;
        public Value<string> eSignConsentBorrowerIPAddress4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress4() => !eSignConsentBorrowerIPAddress4.Clean;
        public Value<string> eSignConsentBorrowerIPAddress5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress5() => !eSignConsentBorrowerIPAddress5.Clean;
        public Value<string> eSignConsentBorrowerIPAddress6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerIPAddress6() => !eSignConsentBorrowerIPAddress6.Clean;
        public Value<string> eSignConsentBorrowerSource1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource1() => !eSignConsentBorrowerSource1.Clean;
        public Value<string> eSignConsentBorrowerSource2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource2() => !eSignConsentBorrowerSource2.Clean;
        public Value<string> eSignConsentBorrowerSource3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource3() => !eSignConsentBorrowerSource3.Clean;
        public Value<string> eSignConsentBorrowerSource4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource4() => !eSignConsentBorrowerSource4.Clean;
        public Value<string> eSignConsentBorrowerSource5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource5() => !eSignConsentBorrowerSource5.Clean;
        public Value<string> eSignConsentBorrowerSource6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerSource6() => !eSignConsentBorrowerSource6.Clean;
        public Value<string> eSignConsentBorrowerStatus1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus1() => !eSignConsentBorrowerStatus1.Clean;
        public Value<string> eSignConsentBorrowerStatus2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus2() => !eSignConsentBorrowerStatus2.Clean;
        public Value<string> eSignConsentBorrowerStatus3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus3() => !eSignConsentBorrowerStatus3.Clean;
        public Value<string> eSignConsentBorrowerStatus4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus4() => !eSignConsentBorrowerStatus4.Clean;
        public Value<string> eSignConsentBorrowerStatus5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus5() => !eSignConsentBorrowerStatus5.Clean;
        public Value<string> eSignConsentBorrowerStatus6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentBorrowerStatus6() => !eSignConsentBorrowerStatus6.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted1() => !eSignConsentCoBorrowerDateAccepted1.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted2() => !eSignConsentCoBorrowerDateAccepted2.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted3() => !eSignConsentCoBorrowerDateAccepted3.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted4() => !eSignConsentCoBorrowerDateAccepted4.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted5() => !eSignConsentCoBorrowerDateAccepted5.Clean;
        public Value<DateTime?> eSignConsentCoBorrowerDateAccepted6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerDateAccepted6() => !eSignConsentCoBorrowerDateAccepted6.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress1() => !eSignConsentCoBorrowerIPAddress1.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress2() => !eSignConsentCoBorrowerIPAddress2.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress3() => !eSignConsentCoBorrowerIPAddress3.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress4() => !eSignConsentCoBorrowerIPAddress4.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress5() => !eSignConsentCoBorrowerIPAddress5.Clean;
        public Value<string> eSignConsentCoBorrowerIPAddress6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerIPAddress6() => !eSignConsentCoBorrowerIPAddress6.Clean;
        public Value<string> eSignConsentCoBorrowerSource1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource1() => !eSignConsentCoBorrowerSource1.Clean;
        public Value<string> eSignConsentCoBorrowerSource2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource2() => !eSignConsentCoBorrowerSource2.Clean;
        public Value<string> eSignConsentCoBorrowerSource3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource3() => !eSignConsentCoBorrowerSource3.Clean;
        public Value<string> eSignConsentCoBorrowerSource4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource4() => !eSignConsentCoBorrowerSource4.Clean;
        public Value<string> eSignConsentCoBorrowerSource5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource5() => !eSignConsentCoBorrowerSource5.Clean;
        public Value<string> eSignConsentCoBorrowerSource6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerSource6() => !eSignConsentCoBorrowerSource6.Clean;
        public Value<string> eSignConsentCoBorrowerStatus1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus1() => !eSignConsentCoBorrowerStatus1.Clean;
        public Value<string> eSignConsentCoBorrowerStatus2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus2() => !eSignConsentCoBorrowerStatus2.Clean;
        public Value<string> eSignConsentCoBorrowerStatus3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus3() => !eSignConsentCoBorrowerStatus3.Clean;
        public Value<string> eSignConsentCoBorrowerStatus4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus4() => !eSignConsentCoBorrowerStatus4.Clean;
        public Value<string> eSignConsentCoBorrowerStatus5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus5() => !eSignConsentCoBorrowerStatus5.Clean;
        public Value<string> eSignConsentCoBorrowerStatus6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentCoBorrowerStatus6() => !eSignConsentCoBorrowerStatus6.Clean;
        public Value<DateTime?> eSignConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeeSignConsentDate() => !eSignConsentDate.Clean;
        public Value<decimal?> ExtraPaymentForEarlyPayOff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExtraPaymentForEarlyPayOff() => !ExtraPaymentForEarlyPayOff.Clean;
        public Value<DateTime?> FeeCollectedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeCollectedDate() => !FeeCollectedDate.Clean;
        public Value<decimal?> FilingFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFilingFees() => !FilingFees.Clean;
        public Value<DateTime?> FinalPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalPaymentDate() => !FinalPaymentDate.Clean;
        public Value<decimal?> FinanceCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceCharge() => !FinanceCharge.Clean;
        public Value<decimal?> FinancedAllGuaranteeFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedAllGuaranteeFeeAmount() => !FinancedAllGuaranteeFeeAmount.Clean;
        public Value<decimal?> FinancedAllGuaranteeFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedAllGuaranteeFeePercent() => !FinancedAllGuaranteeFeePercent.Clean;
        public Value<decimal?> FinancedAllTotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedAllTotalLoanAmount() => !FinancedAllTotalLoanAmount.Clean;
        public Value<decimal?> FinancedPortionGuaranteeFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedPortionGuaranteeFeeAmount() => !FinancedPortionGuaranteeFeeAmount.Clean;
        public Value<decimal?> FinancedPortionGuaranteeFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedPortionGuaranteeFeePercent() => !FinancedPortionGuaranteeFeePercent.Clean;
        public Value<decimal?> FinancedPortionTotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedPortionTotalLoanAmount() => !FinancedPortionTotalLoanAmount.Clean;
        public Value<string> FinancingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancingType() => !FinancingType.Clean;
        public Value<DateTime?> FirstAmortizationPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstAmortizationPaymentDate() => !FirstAmortizationPaymentDate.Clean;
        public Value<bool?> FloodInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsuranceIndicator() => !FloodInsuranceIndicator.Clean;
        public Value<DateTime?> GfeApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeApplicationDate() => !GfeApplicationDate.Clean;
        public Value<bool?> GfeChangedCircumstanceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeChangedCircumstanceIndicator() => !GfeChangedCircumstanceIndicator.Clean;
        public Value<string> GfeChangedCircumstanceItem { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeChangedCircumstanceItem() => !GfeChangedCircumstanceItem.Clean;
        public Value<string> GFEChangedCirsumstanceItemCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGFEChangedCirsumstanceItemCode() => !GFEChangedCirsumstanceItemCode.Clean;
        public Value<DateTime?> GfeDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeDate() => !GfeDate.Clean;
        public Value<DateTime?> GfeExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeExpirationDate() => !GfeExpirationDate.Clean;
        public Value<string> GfeExpirationPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeExpirationPeriod() => !GfeExpirationPeriod.Clean;
        public Value<bool?> GfeRateLockRedisclosureRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeRateLockRedisclosureRequiredIndicator() => !GfeRateLockRedisclosureRequiredIndicator.Clean;
        public Value<DateTime?> GfeRedisclosureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeRedisclosureProvidedDate() => !GfeRedisclosureProvidedDate.Clean;
        public Value<DateTime?> GfeRedisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeRedisclosureReceivedDate() => !GfeRedisclosureReceivedDate.Clean;
        public Value<DateTime?> HighCostDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighCostDisclosure() => !HighCostDisclosure.Clean;
        public Value<DateTime?> HomeCounselingProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProvidedDate() => !HomeCounselingProvidedDate.Clean;
        public Value<bool?> Hud1ToleranceViolatedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1ToleranceViolatedIndicator() => !Hud1ToleranceViolatedIndicator.Clean;
        public Value<string> HudToleranceResolutionComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudToleranceResolutionComments() => !HudToleranceResolutionComments.Clean;
        public Value<DateTime?> HudToleranceResolutionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudToleranceResolutionDate() => !HudToleranceResolutionDate.Clean;
        public Value<string> HudToleranceResolvedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudToleranceResolvedBy() => !HudToleranceResolvedBy.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IfYouPurchaseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIfYouPurchaseIndicator() => !IfYouPurchaseIndicator.Clean;
        public Value<string> IfYouPurchaseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIfYouPurchaseType() => !IfYouPurchaseType.Clean;
        public Value<bool?> IncludeMiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeMiIndicator() => !IncludeMiIndicator.Clean;
        public Value<bool?> IncludePmiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludePmiIndicator() => !IncludePmiIndicator.Clean;
        public Value<bool?> IncludeTaxesInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeTaxesInsuranceIndicator() => !IncludeTaxesInsuranceIndicator.Clean;
        public Value<DateTime?> InitialAVMProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialAVMProvidedDate() => !InitialAVMProvidedDate.Clean;
        public Value<DateTime?> InitialDisclosureDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialDisclosureDueDate() => !InitialDisclosureDueDate.Clean;
        public Value<DateTime?> InitialDisclosureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialDisclosureProvidedDate() => !InitialDisclosureProvidedDate.Clean;
        public Value<DateTime?> InitialGfeAffiliatedBusinessProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeAffiliatedBusinessProvidedDate() => !InitialGfeAffiliatedBusinessProvidedDate.Clean;
        public Value<DateTime?> InitialGFEAppraisalProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGFEAppraisalProvidedDate() => !InitialGFEAppraisalProvidedDate.Clean;
        public Value<DateTime?> InitialGfeCharmBookletProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeCharmBookletProvidedDate() => !InitialGfeCharmBookletProvidedDate.Clean;
        public Value<DateTime?> InitialGfeDisclosureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeDisclosureProvidedDate() => !InitialGfeDisclosureProvidedDate.Clean;
        public Value<DateTime?> InitialGfeDisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeDisclosureReceivedDate() => !InitialGfeDisclosureReceivedDate.Clean;
        public Value<DateTime?> InitialGfeHelocBrochureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeHelocBrochureProvidedDate() => !InitialGfeHelocBrochureProvidedDate.Clean;
        public Value<DateTime?> InitialGfeHudSpecialBookletProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialGfeHudSpecialBookletProvidedDate() => !InitialGfeHudSpecialBookletProvidedDate.Clean;
        public Value<DateTime?> InitialSubsequentAppraisalProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialSubsequentAppraisalProvidedDate() => !InitialSubsequentAppraisalProvidedDate.Clean;
        public Value<DateTime?> InitialTilDisclosureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialTilDisclosureProvidedDate() => !InitialTilDisclosureProvidedDate.Clean;
        public Value<DateTime?> InitialTilDisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialTilDisclosureReceivedDate() => !InitialTilDisclosureReceivedDate.Clean;
        public Value<string> InsuranceRequiredDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceRequiredDescription() => !InsuranceRequiredDescription.Clean;
        public Value<string> InterestInNameOf { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestInNameOf() => !InterestInNameOf.Clean;
        public Value<bool?> InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnly() => !InterestOnly.Clean;
        public Value<bool?> InterestOnlyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyIndicator() => !InterestOnlyIndicator.Clean;
        public Value<int?> InterestOnlyMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyMonths() => !InterestOnlyMonths.Clean;
        public Value<string> InterestRateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateType() => !InterestRateType.Clean;
        public Value<decimal?> InterestReserveAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestReserveAmount() => !InterestReserveAmount.Clean;
        public Value<string> LastDisclosedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedBy() => !LastDisclosedBy.Clean;
        public Value<DateTime?> LastDisclosedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedDate() => !LastDisclosedDate.Clean;
        public Value<DateTime?> LastDisclosedGfeReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedGfeReceivedDate() => !LastDisclosedGfeReceivedDate.Clean;
        public Value<string> LateChargeComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargeComments() => !LateChargeComments.Clean;
        public Value<int?> LateChargeDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargeDays() => !LateChargeDays.Clean;
        public Value<decimal?> LateChargePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargePercent() => !LateChargePercent.Clean;
        public Value<string> LateChargeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargeType() => !LateChargeType.Clean;
        public Value<decimal?> LateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFee() => !LateFee.Clean;
        public Value<string> LEIntentToProceedComment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEIntentToProceedComment() => !LEIntentToProceedComment.Clean;
        public Value<bool?> LenderPaidMortgageInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidMortgageInsuranceIndicator() => !LenderPaidMortgageInsuranceIndicator.Clean;
        public Value<decimal?> LendersInspectionFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLendersInspectionFee() => !LendersInspectionFee.Clean;
        public Value<string> LEReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReceivedBy() => !LEReceivedBy.Clean;
        public Value<string> LEReceivedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReceivedMethod() => !LEReceivedMethod.Clean;
        public Value<string> LEReceivedMethodOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReceivedMethodOther() => !LEReceivedMethodOther.Clean;
        public Value<DateTime?> LESentOnDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLESentOnDate() => !LESentOnDate.Clean;
        public Value<decimal?> MarginPlusIndexPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarginPlusIndexPercent() => !MarginPlusIndexPercent.Clean;
        public Value<decimal?> MaximumLateCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumLateCharge() => !MaximumLateCharge.Clean;
        public Value<decimal?> MaximumPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumPayment() => !MaximumPayment.Clean;
        public Value<bool?> MeansAnEstimateIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMeansAnEstimateIndicator() => !MeansAnEstimateIndicator.Clean;
        public Value<decimal?> MiAdjustmentFactorLevel2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiAdjustmentFactorLevel2() => !MiAdjustmentFactorLevel2.Clean;
        public Value<bool?> MiDecliningRenewalsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiDecliningRenewalsIndicator() => !MiDecliningRenewalsIndicator.Clean;
        public Value<string> MidpointCancellation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMidpointCancellation() => !MidpointCancellation.Clean;
        public Value<decimal?> MiMonthlyPaymentLevel1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiMonthlyPaymentLevel1() => !MiMonthlyPaymentLevel1.Clean;
        public Value<decimal?> MiMonthlyPaymentLevel2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiMonthlyPaymentLevel2() => !MiMonthlyPaymentLevel2.Clean;
        public Value<int?> MiMonthsOfAdjustmentLevel1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiMonthsOfAdjustmentLevel1() => !MiMonthsOfAdjustmentLevel1.Clean;
        public Value<int?> MiMonthsOfAdjustmentLevel2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiMonthsOfAdjustmentLevel2() => !MiMonthsOfAdjustmentLevel2.Clean;
        public Value<decimal?> MinimumLateCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumLateCharge() => !MinimumLateCharge.Clean;
        public Value<decimal?> MinimumPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPayment() => !MinimumPayment.Clean;
        public Value<bool?> MIPFactorLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPFactorLocked() => !MIPFactorLocked.Clean;
        public Value<decimal?> MIPrepaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPrepaidAmount() => !MIPrepaidAmount.Clean;
        public Value<bool?> MiPrepaidIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiPrepaidIndicator() => !MiPrepaidIndicator.Clean;
        public Value<string> MiScheduledTerminationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiScheduledTerminationDate() => !MiScheduledTerminationDate.Clean;
        public Value<bool?> MmiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMmiIndicator() => !MmiIndicator.Clean;
        public Value<decimal?> MonthlyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyTerm() => !MonthlyTerm.Clean;
        public Value<int?> MonthsOfMiPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthsOfMiPrepaid() => !MonthsOfMiPrepaid.Clean;
        public Value<decimal?> MortgageInsuranceCancelPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceCancelPercent() => !MortgageInsuranceCancelPercent.Clean;
        public Value<string> NamePreparedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNamePreparedBy() => !NamePreparedBy.Clean;
        public Value<string> NewConstructionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewConstructionIndicator() => !NewConstructionIndicator.Clean;
        public Value<int?> NumberOfPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfPayments() => !NumberOfPayments.Clean;
        public Value<DateTime?> OccupancyCertDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancyCertDate() => !OccupancyCertDate.Clean;
        public Value<DateTime?> OriginalContractDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalContractDate() => !OriginalContractDate.Clean;
        public Value<decimal?> OutstandingBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOutstandingBalance() => !OutstandingBalance.Clean;
        public Value<string> PaymentFrequencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentFrequencyType() => !PaymentFrequencyType.Clean;
        public Value<decimal?> PaymentIncreasePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentIncreasePercent() => !PaymentIncreasePercent.Clean;
        public Value<string> PhonePreparedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhonePreparedBy() => !PhonePreparedBy.Clean;
        public Value<bool?> PmiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmiIndicator() => !PmiIndicator.Clean;
        public Value<DateTime?> PmiMidpointCancelationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmiMidpointCancelationDate() => !PmiMidpointCancelationDate.Clean;
        public Value<DateTime?> PostConsummationDisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostConsummationDisclosureReceivedDate() => !PostConsummationDisclosureReceivedDate.Clean;
        public Value<DateTime?> PostConsummationDisclosureSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostConsummationDisclosureSentDate() => !PostConsummationDisclosureSentDate.Clean;
        public Value<decimal?> PrepaidFinanceCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidFinanceCharge() => !PrepaidFinanceCharge.Clean;
        public Value<bool?> PropertyInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyInsuranceIndicator() => !PropertyInsuranceIndicator.Clean;
        public Value<DateTime?> RateLockGfeDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockGfeDueDate() => !RateLockGfeDueDate.Clean;
        public Value<decimal?> RatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRatePercent() => !RatePercent.Clean;
        public Value<int?> RecastPaidMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecastPaidMonths() => !RecastPaidMonths.Clean;
        public Value<int?> RecastStopMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecastStopMonths() => !RecastStopMonths.Clean;
        public Value<bool?> RefundPaymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundPaymentIndicator() => !RefundPaymentIndicator.Clean;
        public Value<bool?> RefundUnearnedMipIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundUnearnedMipIndicator() => !RefundUnearnedMipIndicator.Clean;
        public Value<List<RegulationZInterestRatePeriod>> RegulationZInterestRatePeriods { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZInterestRatePeriods() => !RegulationZInterestRatePeriods.Clean;
        public Value<List<RegulationZPayment>> RegulationZPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZPayments() => !RegulationZPayments.Clean;
        public Value<string> RegzTableType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegzTableType() => !RegzTableType.Clean;
        public Value<bool?> RequiredDepositIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredDepositIndicator() => !RequiredDepositIndicator.Clean;
        public Value<DateTime?> RevisedClosingDisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRevisedClosingDisclosureReceivedDate() => !RevisedClosingDisclosureReceivedDate.Clean;
        public Value<DateTime?> RevisedClosingDisclosureSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRevisedClosingDisclosureSentDate() => !RevisedClosingDisclosureSentDate.Clean;
        public Value<DateTime?> RevisedGfeDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRevisedGfeDueDate() => !RevisedGfeDueDate.Clean;
        public Value<decimal?> RoundedMarginPlusIndexPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundedMarginPlusIndexPercent() => !RoundedMarginPlusIndexPercent.Clean;
        public Value<DateTime?> SafeHarborSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSafeHarborSentDate() => !SafeHarborSentDate.Clean;
        public Value<decimal?> SamplePayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSamplePayments() => !SamplePayments.Clean;
        public Value<string> SecurityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityType() => !SecurityType.Clean;
        public Value<DateTime?> SSPLSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSPLSentDate() => !SSPLSentDate.Clean;
        public Value<DateTime?> TilDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilDate() => !TilDate.Clean;
        public Value<string> TilDisclosedComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilDisclosedComments() => !TilDisclosedComments.Clean;
        public Value<string> TilDisclosureMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilDisclosureMethod() => !TilDisclosureMethod.Clean;
        public Value<DateTime?> TilLastDisclosedBorrowerReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilLastDisclosedBorrowerReceivedDate() => !TilLastDisclosedBorrowerReceivedDate.Clean;
        public Value<string> TilLastDisclosedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilLastDisclosedBy() => !TilLastDisclosedBy.Clean;
        public Value<DateTime?> TilLastDisclosedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilLastDisclosedDate() => !TilLastDisclosedDate.Clean;
        public Value<DateTime?> TilRedisclosureProvidedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilRedisclosureProvidedDate() => !TilRedisclosureProvidedDate.Clean;
        public Value<DateTime?> TilRedisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilRedisclosureReceivedDate() => !TilRedisclosureReceivedDate.Clean;
        public Value<decimal?> TotalBrokerFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBrokerFees() => !TotalBrokerFees.Clean;
        public Value<decimal?> TotalLatePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLatePayment() => !TotalLatePayment.Clean;
        public Value<decimal?> TotalLenderFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLenderFees() => !TotalLenderFees.Clean;
        public Value<decimal?> TotalOfPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOfPayments() => !TotalOfPayments.Clean;
        public Value<decimal?> TotalOfPrincipalAndInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOfPrincipalAndInterest() => !TotalOfPrincipalAndInterest.Clean;
        public Value<bool?> UseCustomLenderProfile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseCustomLenderProfile() => !UseCustomLenderProfile.Clean;
        public Value<string> UseDaysInYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseDaysInYears() => !UseDaysInYears.Clean;
        public Value<bool?> UsePitiForRatioIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsePitiForRatioIndicator() => !UsePitiForRatioIndicator.Clean;
        public Value<bool?> VariableRateFeatureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVariableRateFeatureIndicator() => !VariableRateFeatureIndicator.Clean;
        public Value<decimal?> YearlyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyTerm() => !YearlyTerm.Clean;
        public Value<string> YearOfMaximumPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearOfMaximumPayment() => !YearOfMaximumPayment.Clean;
        public Value<int?> Years { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYears() => !Years.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AcknowledgedDay.Clean
                    && AcknowledgedMonth.Clean
                    && AcknowledgedYear.Clean
                    && Acquisition.Clean
                    && AdditionalArmInformation.Clean
                    && AllDateAndNumericalDisclosuresIndicator.Clean
                    && AmountFinanced.Clean
                    && AprPercent.Clean
                    && ArmDisclosureDescription.Clean
                    && AssumptionOnYourProperty.Clean
                    && BorrowerIntendToContinueDate.Clean
                    && BorrowerIntendToContinueIndicator.Clean
                    && BorrowerMiTerminationDate.Clean
                    && CalculateBasedOnRemainingBalance.Clean
                    && ChargesAddedToPaymentsIndicator.Clean
                    && ChargesAtLoanClosingIndicator.Clean
                    && CircumstanceChangeReason.Clean
                    && CircumstanceChangeReceivedDate.Clean
                    && ClosingDisclosureReceivedDate.Clean
                    && ClosingDisclosureSentDate.Clean
                    && ConstructionFirstIntChangeAdjType.Clean
                    && ConstructionLoanDescription.Clean
                    && ConstructionLoanMethod.Clean
                    && ConstructionPeriodMonths.Clean
                    && ConstructionRatePercent.Clean
                    && ConstructionRefinanceIndicator.Clean
                    && CreditDisability.Clean
                    && CreditDisabilityIndicator.Clean
                    && CreditLife.Clean
                    && CreditLifeAndCreditDisability.Clean
                    && CreditLifeInsuranceIndicator.Clean
                    && CustomizePaymentScheduleIndicator.Clean
                    && DemandFeatureIndicator.Clean
                    && DisclosedAprPercent.Clean
                    && DisclosedByBrokerIndicator.Clean
                    && DisclosedComments.Clean
                    && DisclosedDailyInterestCharge.Clean
                    && DisclosedFinanceCharge.Clean
                    && DisclosedPrepayment.Clean
                    && DisclosedProduct.Clean
                    && DisclosureMethod.Clean
                    && DisclosureType.Clean
                    && DiscountPeriod.Clean
                    && DiscountRatePercent.Clean
                    && DiscountType.Clean
                    && DueDate.Clean
                    && EarliestClosingDate.Clean
                    && EarliestFeeCollectionDate.Clean
                    && eSignConsentBorrowerDateAccepted1.Clean
                    && eSignConsentBorrowerDateAccepted2.Clean
                    && eSignConsentBorrowerDateAccepted3.Clean
                    && eSignConsentBorrowerDateAccepted4.Clean
                    && eSignConsentBorrowerDateAccepted5.Clean
                    && eSignConsentBorrowerDateAccepted6.Clean
                    && eSignConsentBorrowerIPAddress1.Clean
                    && eSignConsentBorrowerIPAddress2.Clean
                    && eSignConsentBorrowerIPAddress3.Clean
                    && eSignConsentBorrowerIPAddress4.Clean
                    && eSignConsentBorrowerIPAddress5.Clean
                    && eSignConsentBorrowerIPAddress6.Clean
                    && eSignConsentBorrowerSource1.Clean
                    && eSignConsentBorrowerSource2.Clean
                    && eSignConsentBorrowerSource3.Clean
                    && eSignConsentBorrowerSource4.Clean
                    && eSignConsentBorrowerSource5.Clean
                    && eSignConsentBorrowerSource6.Clean
                    && eSignConsentBorrowerStatus1.Clean
                    && eSignConsentBorrowerStatus2.Clean
                    && eSignConsentBorrowerStatus3.Clean
                    && eSignConsentBorrowerStatus4.Clean
                    && eSignConsentBorrowerStatus5.Clean
                    && eSignConsentBorrowerStatus6.Clean
                    && eSignConsentCoBorrowerDateAccepted1.Clean
                    && eSignConsentCoBorrowerDateAccepted2.Clean
                    && eSignConsentCoBorrowerDateAccepted3.Clean
                    && eSignConsentCoBorrowerDateAccepted4.Clean
                    && eSignConsentCoBorrowerDateAccepted5.Clean
                    && eSignConsentCoBorrowerDateAccepted6.Clean
                    && eSignConsentCoBorrowerIPAddress1.Clean
                    && eSignConsentCoBorrowerIPAddress2.Clean
                    && eSignConsentCoBorrowerIPAddress3.Clean
                    && eSignConsentCoBorrowerIPAddress4.Clean
                    && eSignConsentCoBorrowerIPAddress5.Clean
                    && eSignConsentCoBorrowerIPAddress6.Clean
                    && eSignConsentCoBorrowerSource1.Clean
                    && eSignConsentCoBorrowerSource2.Clean
                    && eSignConsentCoBorrowerSource3.Clean
                    && eSignConsentCoBorrowerSource4.Clean
                    && eSignConsentCoBorrowerSource5.Clean
                    && eSignConsentCoBorrowerSource6.Clean
                    && eSignConsentCoBorrowerStatus1.Clean
                    && eSignConsentCoBorrowerStatus2.Clean
                    && eSignConsentCoBorrowerStatus3.Clean
                    && eSignConsentCoBorrowerStatus4.Clean
                    && eSignConsentCoBorrowerStatus5.Clean
                    && eSignConsentCoBorrowerStatus6.Clean
                    && eSignConsentDate.Clean
                    && ExtraPaymentForEarlyPayOff.Clean
                    && FeeCollectedDate.Clean
                    && FilingFees.Clean
                    && FinalPaymentDate.Clean
                    && FinanceCharge.Clean
                    && FinancedAllGuaranteeFeeAmount.Clean
                    && FinancedAllGuaranteeFeePercent.Clean
                    && FinancedAllTotalLoanAmount.Clean
                    && FinancedPortionGuaranteeFeeAmount.Clean
                    && FinancedPortionGuaranteeFeePercent.Clean
                    && FinancedPortionTotalLoanAmount.Clean
                    && FinancingType.Clean
                    && FirstAmortizationPaymentDate.Clean
                    && FloodInsuranceIndicator.Clean
                    && GfeApplicationDate.Clean
                    && GfeChangedCircumstanceIndicator.Clean
                    && GfeChangedCircumstanceItem.Clean
                    && GFEChangedCirsumstanceItemCode.Clean
                    && GfeDate.Clean
                    && GfeExpirationDate.Clean
                    && GfeExpirationPeriod.Clean
                    && GfeRateLockRedisclosureRequiredIndicator.Clean
                    && GfeRedisclosureProvidedDate.Clean
                    && GfeRedisclosureReceivedDate.Clean
                    && HighCostDisclosure.Clean
                    && HomeCounselingProvidedDate.Clean
                    && Hud1ToleranceViolatedIndicator.Clean
                    && HudToleranceResolutionComments.Clean
                    && HudToleranceResolutionDate.Clean
                    && HudToleranceResolvedBy.Clean
                    && Id.Clean
                    && IfYouPurchaseIndicator.Clean
                    && IfYouPurchaseType.Clean
                    && IncludeMiIndicator.Clean
                    && IncludePmiIndicator.Clean
                    && IncludeTaxesInsuranceIndicator.Clean
                    && InitialAVMProvidedDate.Clean
                    && InitialDisclosureDueDate.Clean
                    && InitialDisclosureProvidedDate.Clean
                    && InitialGfeAffiliatedBusinessProvidedDate.Clean
                    && InitialGFEAppraisalProvidedDate.Clean
                    && InitialGfeCharmBookletProvidedDate.Clean
                    && InitialGfeDisclosureProvidedDate.Clean
                    && InitialGfeDisclosureReceivedDate.Clean
                    && InitialGfeHelocBrochureProvidedDate.Clean
                    && InitialGfeHudSpecialBookletProvidedDate.Clean
                    && InitialSubsequentAppraisalProvidedDate.Clean
                    && InitialTilDisclosureProvidedDate.Clean
                    && InitialTilDisclosureReceivedDate.Clean
                    && InsuranceRequiredDescription.Clean
                    && InterestInNameOf.Clean
                    && InterestOnly.Clean
                    && InterestOnlyIndicator.Clean
                    && InterestOnlyMonths.Clean
                    && InterestRateType.Clean
                    && InterestReserveAmount.Clean
                    && LastDisclosedBy.Clean
                    && LastDisclosedDate.Clean
                    && LastDisclosedGfeReceivedDate.Clean
                    && LateChargeComments.Clean
                    && LateChargeDays.Clean
                    && LateChargePercent.Clean
                    && LateChargeType.Clean
                    && LateFee.Clean
                    && LEIntentToProceedComment.Clean
                    && LenderPaidMortgageInsuranceIndicator.Clean
                    && LendersInspectionFee.Clean
                    && LEReceivedBy.Clean
                    && LEReceivedMethod.Clean
                    && LEReceivedMethodOther.Clean
                    && LESentOnDate.Clean
                    && MarginPlusIndexPercent.Clean
                    && MaximumLateCharge.Clean
                    && MaximumPayment.Clean
                    && MeansAnEstimateIndicator.Clean
                    && MiAdjustmentFactorLevel2.Clean
                    && MiDecliningRenewalsIndicator.Clean
                    && MidpointCancellation.Clean
                    && MiMonthlyPaymentLevel1.Clean
                    && MiMonthlyPaymentLevel2.Clean
                    && MiMonthsOfAdjustmentLevel1.Clean
                    && MiMonthsOfAdjustmentLevel2.Clean
                    && MinimumLateCharge.Clean
                    && MinimumPayment.Clean
                    && MIPFactorLocked.Clean
                    && MIPrepaidAmount.Clean
                    && MiPrepaidIndicator.Clean
                    && MiScheduledTerminationDate.Clean
                    && MmiIndicator.Clean
                    && MonthlyTerm.Clean
                    && MonthsOfMiPrepaid.Clean
                    && MortgageInsuranceCancelPercent.Clean
                    && NamePreparedBy.Clean
                    && NewConstructionIndicator.Clean
                    && NumberOfPayments.Clean
                    && OccupancyCertDate.Clean
                    && OriginalContractDate.Clean
                    && OutstandingBalance.Clean
                    && PaymentFrequencyType.Clean
                    && PaymentIncreasePercent.Clean
                    && PhonePreparedBy.Clean
                    && PmiIndicator.Clean
                    && PmiMidpointCancelationDate.Clean
                    && PostConsummationDisclosureReceivedDate.Clean
                    && PostConsummationDisclosureSentDate.Clean
                    && PrepaidFinanceCharge.Clean
                    && PropertyInsuranceIndicator.Clean
                    && RateLockGfeDueDate.Clean
                    && RatePercent.Clean
                    && RecastPaidMonths.Clean
                    && RecastStopMonths.Clean
                    && RefundPaymentIndicator.Clean
                    && RefundUnearnedMipIndicator.Clean
                    && RegulationZInterestRatePeriods.Clean
                    && RegulationZPayments.Clean
                    && RegzTableType.Clean
                    && RequiredDepositIndicator.Clean
                    && RevisedClosingDisclosureReceivedDate.Clean
                    && RevisedClosingDisclosureSentDate.Clean
                    && RevisedGfeDueDate.Clean
                    && RoundedMarginPlusIndexPercent.Clean
                    && SafeHarborSentDate.Clean
                    && SamplePayments.Clean
                    && SecurityType.Clean
                    && SSPLSentDate.Clean
                    && TilDate.Clean
                    && TilDisclosedComments.Clean
                    && TilDisclosureMethod.Clean
                    && TilLastDisclosedBorrowerReceivedDate.Clean
                    && TilLastDisclosedBy.Clean
                    && TilLastDisclosedDate.Clean
                    && TilRedisclosureProvidedDate.Clean
                    && TilRedisclosureReceivedDate.Clean
                    && TotalBrokerFees.Clean
                    && TotalLatePayment.Clean
                    && TotalLenderFees.Clean
                    && TotalOfPayments.Clean
                    && TotalOfPrincipalAndInterest.Clean
                    && UseCustomLenderProfile.Clean
                    && UseDaysInYears.Clean
                    && UsePitiForRatioIndicator.Clean
                    && VariableRateFeatureIndicator.Clean
                    && YearlyTerm.Clean
                    && YearOfMaximumPayment.Clean
                    && Years.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AcknowledgedDay; v0.Clean = value; AcknowledgedDay = v0;
                var v1 = AcknowledgedMonth; v1.Clean = value; AcknowledgedMonth = v1;
                var v2 = AcknowledgedYear; v2.Clean = value; AcknowledgedYear = v2;
                var v3 = Acquisition; v3.Clean = value; Acquisition = v3;
                var v4 = AdditionalArmInformation; v4.Clean = value; AdditionalArmInformation = v4;
                var v5 = AllDateAndNumericalDisclosuresIndicator; v5.Clean = value; AllDateAndNumericalDisclosuresIndicator = v5;
                var v6 = AmountFinanced; v6.Clean = value; AmountFinanced = v6;
                var v7 = AprPercent; v7.Clean = value; AprPercent = v7;
                var v8 = ArmDisclosureDescription; v8.Clean = value; ArmDisclosureDescription = v8;
                var v9 = AssumptionOnYourProperty; v9.Clean = value; AssumptionOnYourProperty = v9;
                var v10 = BorrowerIntendToContinueDate; v10.Clean = value; BorrowerIntendToContinueDate = v10;
                var v11 = BorrowerIntendToContinueIndicator; v11.Clean = value; BorrowerIntendToContinueIndicator = v11;
                var v12 = BorrowerMiTerminationDate; v12.Clean = value; BorrowerMiTerminationDate = v12;
                var v13 = CalculateBasedOnRemainingBalance; v13.Clean = value; CalculateBasedOnRemainingBalance = v13;
                var v14 = ChargesAddedToPaymentsIndicator; v14.Clean = value; ChargesAddedToPaymentsIndicator = v14;
                var v15 = ChargesAtLoanClosingIndicator; v15.Clean = value; ChargesAtLoanClosingIndicator = v15;
                var v16 = CircumstanceChangeReason; v16.Clean = value; CircumstanceChangeReason = v16;
                var v17 = CircumstanceChangeReceivedDate; v17.Clean = value; CircumstanceChangeReceivedDate = v17;
                var v18 = ClosingDisclosureReceivedDate; v18.Clean = value; ClosingDisclosureReceivedDate = v18;
                var v19 = ClosingDisclosureSentDate; v19.Clean = value; ClosingDisclosureSentDate = v19;
                var v20 = ConstructionFirstIntChangeAdjType; v20.Clean = value; ConstructionFirstIntChangeAdjType = v20;
                var v21 = ConstructionLoanDescription; v21.Clean = value; ConstructionLoanDescription = v21;
                var v22 = ConstructionLoanMethod; v22.Clean = value; ConstructionLoanMethod = v22;
                var v23 = ConstructionPeriodMonths; v23.Clean = value; ConstructionPeriodMonths = v23;
                var v24 = ConstructionRatePercent; v24.Clean = value; ConstructionRatePercent = v24;
                var v25 = ConstructionRefinanceIndicator; v25.Clean = value; ConstructionRefinanceIndicator = v25;
                var v26 = CreditDisability; v26.Clean = value; CreditDisability = v26;
                var v27 = CreditDisabilityIndicator; v27.Clean = value; CreditDisabilityIndicator = v27;
                var v28 = CreditLife; v28.Clean = value; CreditLife = v28;
                var v29 = CreditLifeAndCreditDisability; v29.Clean = value; CreditLifeAndCreditDisability = v29;
                var v30 = CreditLifeInsuranceIndicator; v30.Clean = value; CreditLifeInsuranceIndicator = v30;
                var v31 = CustomizePaymentScheduleIndicator; v31.Clean = value; CustomizePaymentScheduleIndicator = v31;
                var v32 = DemandFeatureIndicator; v32.Clean = value; DemandFeatureIndicator = v32;
                var v33 = DisclosedAprPercent; v33.Clean = value; DisclosedAprPercent = v33;
                var v34 = DisclosedByBrokerIndicator; v34.Clean = value; DisclosedByBrokerIndicator = v34;
                var v35 = DisclosedComments; v35.Clean = value; DisclosedComments = v35;
                var v36 = DisclosedDailyInterestCharge; v36.Clean = value; DisclosedDailyInterestCharge = v36;
                var v37 = DisclosedFinanceCharge; v37.Clean = value; DisclosedFinanceCharge = v37;
                var v38 = DisclosedPrepayment; v38.Clean = value; DisclosedPrepayment = v38;
                var v39 = DisclosedProduct; v39.Clean = value; DisclosedProduct = v39;
                var v40 = DisclosureMethod; v40.Clean = value; DisclosureMethod = v40;
                var v41 = DisclosureType; v41.Clean = value; DisclosureType = v41;
                var v42 = DiscountPeriod; v42.Clean = value; DiscountPeriod = v42;
                var v43 = DiscountRatePercent; v43.Clean = value; DiscountRatePercent = v43;
                var v44 = DiscountType; v44.Clean = value; DiscountType = v44;
                var v45 = DueDate; v45.Clean = value; DueDate = v45;
                var v46 = EarliestClosingDate; v46.Clean = value; EarliestClosingDate = v46;
                var v47 = EarliestFeeCollectionDate; v47.Clean = value; EarliestFeeCollectionDate = v47;
                var v48 = eSignConsentBorrowerDateAccepted1; v48.Clean = value; eSignConsentBorrowerDateAccepted1 = v48;
                var v49 = eSignConsentBorrowerDateAccepted2; v49.Clean = value; eSignConsentBorrowerDateAccepted2 = v49;
                var v50 = eSignConsentBorrowerDateAccepted3; v50.Clean = value; eSignConsentBorrowerDateAccepted3 = v50;
                var v51 = eSignConsentBorrowerDateAccepted4; v51.Clean = value; eSignConsentBorrowerDateAccepted4 = v51;
                var v52 = eSignConsentBorrowerDateAccepted5; v52.Clean = value; eSignConsentBorrowerDateAccepted5 = v52;
                var v53 = eSignConsentBorrowerDateAccepted6; v53.Clean = value; eSignConsentBorrowerDateAccepted6 = v53;
                var v54 = eSignConsentBorrowerIPAddress1; v54.Clean = value; eSignConsentBorrowerIPAddress1 = v54;
                var v55 = eSignConsentBorrowerIPAddress2; v55.Clean = value; eSignConsentBorrowerIPAddress2 = v55;
                var v56 = eSignConsentBorrowerIPAddress3; v56.Clean = value; eSignConsentBorrowerIPAddress3 = v56;
                var v57 = eSignConsentBorrowerIPAddress4; v57.Clean = value; eSignConsentBorrowerIPAddress4 = v57;
                var v58 = eSignConsentBorrowerIPAddress5; v58.Clean = value; eSignConsentBorrowerIPAddress5 = v58;
                var v59 = eSignConsentBorrowerIPAddress6; v59.Clean = value; eSignConsentBorrowerIPAddress6 = v59;
                var v60 = eSignConsentBorrowerSource1; v60.Clean = value; eSignConsentBorrowerSource1 = v60;
                var v61 = eSignConsentBorrowerSource2; v61.Clean = value; eSignConsentBorrowerSource2 = v61;
                var v62 = eSignConsentBorrowerSource3; v62.Clean = value; eSignConsentBorrowerSource3 = v62;
                var v63 = eSignConsentBorrowerSource4; v63.Clean = value; eSignConsentBorrowerSource4 = v63;
                var v64 = eSignConsentBorrowerSource5; v64.Clean = value; eSignConsentBorrowerSource5 = v64;
                var v65 = eSignConsentBorrowerSource6; v65.Clean = value; eSignConsentBorrowerSource6 = v65;
                var v66 = eSignConsentBorrowerStatus1; v66.Clean = value; eSignConsentBorrowerStatus1 = v66;
                var v67 = eSignConsentBorrowerStatus2; v67.Clean = value; eSignConsentBorrowerStatus2 = v67;
                var v68 = eSignConsentBorrowerStatus3; v68.Clean = value; eSignConsentBorrowerStatus3 = v68;
                var v69 = eSignConsentBorrowerStatus4; v69.Clean = value; eSignConsentBorrowerStatus4 = v69;
                var v70 = eSignConsentBorrowerStatus5; v70.Clean = value; eSignConsentBorrowerStatus5 = v70;
                var v71 = eSignConsentBorrowerStatus6; v71.Clean = value; eSignConsentBorrowerStatus6 = v71;
                var v72 = eSignConsentCoBorrowerDateAccepted1; v72.Clean = value; eSignConsentCoBorrowerDateAccepted1 = v72;
                var v73 = eSignConsentCoBorrowerDateAccepted2; v73.Clean = value; eSignConsentCoBorrowerDateAccepted2 = v73;
                var v74 = eSignConsentCoBorrowerDateAccepted3; v74.Clean = value; eSignConsentCoBorrowerDateAccepted3 = v74;
                var v75 = eSignConsentCoBorrowerDateAccepted4; v75.Clean = value; eSignConsentCoBorrowerDateAccepted4 = v75;
                var v76 = eSignConsentCoBorrowerDateAccepted5; v76.Clean = value; eSignConsentCoBorrowerDateAccepted5 = v76;
                var v77 = eSignConsentCoBorrowerDateAccepted6; v77.Clean = value; eSignConsentCoBorrowerDateAccepted6 = v77;
                var v78 = eSignConsentCoBorrowerIPAddress1; v78.Clean = value; eSignConsentCoBorrowerIPAddress1 = v78;
                var v79 = eSignConsentCoBorrowerIPAddress2; v79.Clean = value; eSignConsentCoBorrowerIPAddress2 = v79;
                var v80 = eSignConsentCoBorrowerIPAddress3; v80.Clean = value; eSignConsentCoBorrowerIPAddress3 = v80;
                var v81 = eSignConsentCoBorrowerIPAddress4; v81.Clean = value; eSignConsentCoBorrowerIPAddress4 = v81;
                var v82 = eSignConsentCoBorrowerIPAddress5; v82.Clean = value; eSignConsentCoBorrowerIPAddress5 = v82;
                var v83 = eSignConsentCoBorrowerIPAddress6; v83.Clean = value; eSignConsentCoBorrowerIPAddress6 = v83;
                var v84 = eSignConsentCoBorrowerSource1; v84.Clean = value; eSignConsentCoBorrowerSource1 = v84;
                var v85 = eSignConsentCoBorrowerSource2; v85.Clean = value; eSignConsentCoBorrowerSource2 = v85;
                var v86 = eSignConsentCoBorrowerSource3; v86.Clean = value; eSignConsentCoBorrowerSource3 = v86;
                var v87 = eSignConsentCoBorrowerSource4; v87.Clean = value; eSignConsentCoBorrowerSource4 = v87;
                var v88 = eSignConsentCoBorrowerSource5; v88.Clean = value; eSignConsentCoBorrowerSource5 = v88;
                var v89 = eSignConsentCoBorrowerSource6; v89.Clean = value; eSignConsentCoBorrowerSource6 = v89;
                var v90 = eSignConsentCoBorrowerStatus1; v90.Clean = value; eSignConsentCoBorrowerStatus1 = v90;
                var v91 = eSignConsentCoBorrowerStatus2; v91.Clean = value; eSignConsentCoBorrowerStatus2 = v91;
                var v92 = eSignConsentCoBorrowerStatus3; v92.Clean = value; eSignConsentCoBorrowerStatus3 = v92;
                var v93 = eSignConsentCoBorrowerStatus4; v93.Clean = value; eSignConsentCoBorrowerStatus4 = v93;
                var v94 = eSignConsentCoBorrowerStatus5; v94.Clean = value; eSignConsentCoBorrowerStatus5 = v94;
                var v95 = eSignConsentCoBorrowerStatus6; v95.Clean = value; eSignConsentCoBorrowerStatus6 = v95;
                var v96 = eSignConsentDate; v96.Clean = value; eSignConsentDate = v96;
                var v97 = ExtraPaymentForEarlyPayOff; v97.Clean = value; ExtraPaymentForEarlyPayOff = v97;
                var v98 = FeeCollectedDate; v98.Clean = value; FeeCollectedDate = v98;
                var v99 = FilingFees; v99.Clean = value; FilingFees = v99;
                var v100 = FinalPaymentDate; v100.Clean = value; FinalPaymentDate = v100;
                var v101 = FinanceCharge; v101.Clean = value; FinanceCharge = v101;
                var v102 = FinancedAllGuaranteeFeeAmount; v102.Clean = value; FinancedAllGuaranteeFeeAmount = v102;
                var v103 = FinancedAllGuaranteeFeePercent; v103.Clean = value; FinancedAllGuaranteeFeePercent = v103;
                var v104 = FinancedAllTotalLoanAmount; v104.Clean = value; FinancedAllTotalLoanAmount = v104;
                var v105 = FinancedPortionGuaranteeFeeAmount; v105.Clean = value; FinancedPortionGuaranteeFeeAmount = v105;
                var v106 = FinancedPortionGuaranteeFeePercent; v106.Clean = value; FinancedPortionGuaranteeFeePercent = v106;
                var v107 = FinancedPortionTotalLoanAmount; v107.Clean = value; FinancedPortionTotalLoanAmount = v107;
                var v108 = FinancingType; v108.Clean = value; FinancingType = v108;
                var v109 = FirstAmortizationPaymentDate; v109.Clean = value; FirstAmortizationPaymentDate = v109;
                var v110 = FloodInsuranceIndicator; v110.Clean = value; FloodInsuranceIndicator = v110;
                var v111 = GfeApplicationDate; v111.Clean = value; GfeApplicationDate = v111;
                var v112 = GfeChangedCircumstanceIndicator; v112.Clean = value; GfeChangedCircumstanceIndicator = v112;
                var v113 = GfeChangedCircumstanceItem; v113.Clean = value; GfeChangedCircumstanceItem = v113;
                var v114 = GFEChangedCirsumstanceItemCode; v114.Clean = value; GFEChangedCirsumstanceItemCode = v114;
                var v115 = GfeDate; v115.Clean = value; GfeDate = v115;
                var v116 = GfeExpirationDate; v116.Clean = value; GfeExpirationDate = v116;
                var v117 = GfeExpirationPeriod; v117.Clean = value; GfeExpirationPeriod = v117;
                var v118 = GfeRateLockRedisclosureRequiredIndicator; v118.Clean = value; GfeRateLockRedisclosureRequiredIndicator = v118;
                var v119 = GfeRedisclosureProvidedDate; v119.Clean = value; GfeRedisclosureProvidedDate = v119;
                var v120 = GfeRedisclosureReceivedDate; v120.Clean = value; GfeRedisclosureReceivedDate = v120;
                var v121 = HighCostDisclosure; v121.Clean = value; HighCostDisclosure = v121;
                var v122 = HomeCounselingProvidedDate; v122.Clean = value; HomeCounselingProvidedDate = v122;
                var v123 = Hud1ToleranceViolatedIndicator; v123.Clean = value; Hud1ToleranceViolatedIndicator = v123;
                var v124 = HudToleranceResolutionComments; v124.Clean = value; HudToleranceResolutionComments = v124;
                var v125 = HudToleranceResolutionDate; v125.Clean = value; HudToleranceResolutionDate = v125;
                var v126 = HudToleranceResolvedBy; v126.Clean = value; HudToleranceResolvedBy = v126;
                var v127 = Id; v127.Clean = value; Id = v127;
                var v128 = IfYouPurchaseIndicator; v128.Clean = value; IfYouPurchaseIndicator = v128;
                var v129 = IfYouPurchaseType; v129.Clean = value; IfYouPurchaseType = v129;
                var v130 = IncludeMiIndicator; v130.Clean = value; IncludeMiIndicator = v130;
                var v131 = IncludePmiIndicator; v131.Clean = value; IncludePmiIndicator = v131;
                var v132 = IncludeTaxesInsuranceIndicator; v132.Clean = value; IncludeTaxesInsuranceIndicator = v132;
                var v133 = InitialAVMProvidedDate; v133.Clean = value; InitialAVMProvidedDate = v133;
                var v134 = InitialDisclosureDueDate; v134.Clean = value; InitialDisclosureDueDate = v134;
                var v135 = InitialDisclosureProvidedDate; v135.Clean = value; InitialDisclosureProvidedDate = v135;
                var v136 = InitialGfeAffiliatedBusinessProvidedDate; v136.Clean = value; InitialGfeAffiliatedBusinessProvidedDate = v136;
                var v137 = InitialGFEAppraisalProvidedDate; v137.Clean = value; InitialGFEAppraisalProvidedDate = v137;
                var v138 = InitialGfeCharmBookletProvidedDate; v138.Clean = value; InitialGfeCharmBookletProvidedDate = v138;
                var v139 = InitialGfeDisclosureProvidedDate; v139.Clean = value; InitialGfeDisclosureProvidedDate = v139;
                var v140 = InitialGfeDisclosureReceivedDate; v140.Clean = value; InitialGfeDisclosureReceivedDate = v140;
                var v141 = InitialGfeHelocBrochureProvidedDate; v141.Clean = value; InitialGfeHelocBrochureProvidedDate = v141;
                var v142 = InitialGfeHudSpecialBookletProvidedDate; v142.Clean = value; InitialGfeHudSpecialBookletProvidedDate = v142;
                var v143 = InitialSubsequentAppraisalProvidedDate; v143.Clean = value; InitialSubsequentAppraisalProvidedDate = v143;
                var v144 = InitialTilDisclosureProvidedDate; v144.Clean = value; InitialTilDisclosureProvidedDate = v144;
                var v145 = InitialTilDisclosureReceivedDate; v145.Clean = value; InitialTilDisclosureReceivedDate = v145;
                var v146 = InsuranceRequiredDescription; v146.Clean = value; InsuranceRequiredDescription = v146;
                var v147 = InterestInNameOf; v147.Clean = value; InterestInNameOf = v147;
                var v148 = InterestOnly; v148.Clean = value; InterestOnly = v148;
                var v149 = InterestOnlyIndicator; v149.Clean = value; InterestOnlyIndicator = v149;
                var v150 = InterestOnlyMonths; v150.Clean = value; InterestOnlyMonths = v150;
                var v151 = InterestRateType; v151.Clean = value; InterestRateType = v151;
                var v152 = InterestReserveAmount; v152.Clean = value; InterestReserveAmount = v152;
                var v153 = LastDisclosedBy; v153.Clean = value; LastDisclosedBy = v153;
                var v154 = LastDisclosedDate; v154.Clean = value; LastDisclosedDate = v154;
                var v155 = LastDisclosedGfeReceivedDate; v155.Clean = value; LastDisclosedGfeReceivedDate = v155;
                var v156 = LateChargeComments; v156.Clean = value; LateChargeComments = v156;
                var v157 = LateChargeDays; v157.Clean = value; LateChargeDays = v157;
                var v158 = LateChargePercent; v158.Clean = value; LateChargePercent = v158;
                var v159 = LateChargeType; v159.Clean = value; LateChargeType = v159;
                var v160 = LateFee; v160.Clean = value; LateFee = v160;
                var v161 = LEIntentToProceedComment; v161.Clean = value; LEIntentToProceedComment = v161;
                var v162 = LenderPaidMortgageInsuranceIndicator; v162.Clean = value; LenderPaidMortgageInsuranceIndicator = v162;
                var v163 = LendersInspectionFee; v163.Clean = value; LendersInspectionFee = v163;
                var v164 = LEReceivedBy; v164.Clean = value; LEReceivedBy = v164;
                var v165 = LEReceivedMethod; v165.Clean = value; LEReceivedMethod = v165;
                var v166 = LEReceivedMethodOther; v166.Clean = value; LEReceivedMethodOther = v166;
                var v167 = LESentOnDate; v167.Clean = value; LESentOnDate = v167;
                var v168 = MarginPlusIndexPercent; v168.Clean = value; MarginPlusIndexPercent = v168;
                var v169 = MaximumLateCharge; v169.Clean = value; MaximumLateCharge = v169;
                var v170 = MaximumPayment; v170.Clean = value; MaximumPayment = v170;
                var v171 = MeansAnEstimateIndicator; v171.Clean = value; MeansAnEstimateIndicator = v171;
                var v172 = MiAdjustmentFactorLevel2; v172.Clean = value; MiAdjustmentFactorLevel2 = v172;
                var v173 = MiDecliningRenewalsIndicator; v173.Clean = value; MiDecliningRenewalsIndicator = v173;
                var v174 = MidpointCancellation; v174.Clean = value; MidpointCancellation = v174;
                var v175 = MiMonthlyPaymentLevel1; v175.Clean = value; MiMonthlyPaymentLevel1 = v175;
                var v176 = MiMonthlyPaymentLevel2; v176.Clean = value; MiMonthlyPaymentLevel2 = v176;
                var v177 = MiMonthsOfAdjustmentLevel1; v177.Clean = value; MiMonthsOfAdjustmentLevel1 = v177;
                var v178 = MiMonthsOfAdjustmentLevel2; v178.Clean = value; MiMonthsOfAdjustmentLevel2 = v178;
                var v179 = MinimumLateCharge; v179.Clean = value; MinimumLateCharge = v179;
                var v180 = MinimumPayment; v180.Clean = value; MinimumPayment = v180;
                var v181 = MIPFactorLocked; v181.Clean = value; MIPFactorLocked = v181;
                var v182 = MIPrepaidAmount; v182.Clean = value; MIPrepaidAmount = v182;
                var v183 = MiPrepaidIndicator; v183.Clean = value; MiPrepaidIndicator = v183;
                var v184 = MiScheduledTerminationDate; v184.Clean = value; MiScheduledTerminationDate = v184;
                var v185 = MmiIndicator; v185.Clean = value; MmiIndicator = v185;
                var v186 = MonthlyTerm; v186.Clean = value; MonthlyTerm = v186;
                var v187 = MonthsOfMiPrepaid; v187.Clean = value; MonthsOfMiPrepaid = v187;
                var v188 = MortgageInsuranceCancelPercent; v188.Clean = value; MortgageInsuranceCancelPercent = v188;
                var v189 = NamePreparedBy; v189.Clean = value; NamePreparedBy = v189;
                var v190 = NewConstructionIndicator; v190.Clean = value; NewConstructionIndicator = v190;
                var v191 = NumberOfPayments; v191.Clean = value; NumberOfPayments = v191;
                var v192 = OccupancyCertDate; v192.Clean = value; OccupancyCertDate = v192;
                var v193 = OriginalContractDate; v193.Clean = value; OriginalContractDate = v193;
                var v194 = OutstandingBalance; v194.Clean = value; OutstandingBalance = v194;
                var v195 = PaymentFrequencyType; v195.Clean = value; PaymentFrequencyType = v195;
                var v196 = PaymentIncreasePercent; v196.Clean = value; PaymentIncreasePercent = v196;
                var v197 = PhonePreparedBy; v197.Clean = value; PhonePreparedBy = v197;
                var v198 = PmiIndicator; v198.Clean = value; PmiIndicator = v198;
                var v199 = PmiMidpointCancelationDate; v199.Clean = value; PmiMidpointCancelationDate = v199;
                var v200 = PostConsummationDisclosureReceivedDate; v200.Clean = value; PostConsummationDisclosureReceivedDate = v200;
                var v201 = PostConsummationDisclosureSentDate; v201.Clean = value; PostConsummationDisclosureSentDate = v201;
                var v202 = PrepaidFinanceCharge; v202.Clean = value; PrepaidFinanceCharge = v202;
                var v203 = PropertyInsuranceIndicator; v203.Clean = value; PropertyInsuranceIndicator = v203;
                var v204 = RateLockGfeDueDate; v204.Clean = value; RateLockGfeDueDate = v204;
                var v205 = RatePercent; v205.Clean = value; RatePercent = v205;
                var v206 = RecastPaidMonths; v206.Clean = value; RecastPaidMonths = v206;
                var v207 = RecastStopMonths; v207.Clean = value; RecastStopMonths = v207;
                var v208 = RefundPaymentIndicator; v208.Clean = value; RefundPaymentIndicator = v208;
                var v209 = RefundUnearnedMipIndicator; v209.Clean = value; RefundUnearnedMipIndicator = v209;
                var v210 = RegulationZInterestRatePeriods; v210.Clean = value; RegulationZInterestRatePeriods = v210;
                var v211 = RegulationZPayments; v211.Clean = value; RegulationZPayments = v211;
                var v212 = RegzTableType; v212.Clean = value; RegzTableType = v212;
                var v213 = RequiredDepositIndicator; v213.Clean = value; RequiredDepositIndicator = v213;
                var v214 = RevisedClosingDisclosureReceivedDate; v214.Clean = value; RevisedClosingDisclosureReceivedDate = v214;
                var v215 = RevisedClosingDisclosureSentDate; v215.Clean = value; RevisedClosingDisclosureSentDate = v215;
                var v216 = RevisedGfeDueDate; v216.Clean = value; RevisedGfeDueDate = v216;
                var v217 = RoundedMarginPlusIndexPercent; v217.Clean = value; RoundedMarginPlusIndexPercent = v217;
                var v218 = SafeHarborSentDate; v218.Clean = value; SafeHarborSentDate = v218;
                var v219 = SamplePayments; v219.Clean = value; SamplePayments = v219;
                var v220 = SecurityType; v220.Clean = value; SecurityType = v220;
                var v221 = SSPLSentDate; v221.Clean = value; SSPLSentDate = v221;
                var v222 = TilDate; v222.Clean = value; TilDate = v222;
                var v223 = TilDisclosedComments; v223.Clean = value; TilDisclosedComments = v223;
                var v224 = TilDisclosureMethod; v224.Clean = value; TilDisclosureMethod = v224;
                var v225 = TilLastDisclosedBorrowerReceivedDate; v225.Clean = value; TilLastDisclosedBorrowerReceivedDate = v225;
                var v226 = TilLastDisclosedBy; v226.Clean = value; TilLastDisclosedBy = v226;
                var v227 = TilLastDisclosedDate; v227.Clean = value; TilLastDisclosedDate = v227;
                var v228 = TilRedisclosureProvidedDate; v228.Clean = value; TilRedisclosureProvidedDate = v228;
                var v229 = TilRedisclosureReceivedDate; v229.Clean = value; TilRedisclosureReceivedDate = v229;
                var v230 = TotalBrokerFees; v230.Clean = value; TotalBrokerFees = v230;
                var v231 = TotalLatePayment; v231.Clean = value; TotalLatePayment = v231;
                var v232 = TotalLenderFees; v232.Clean = value; TotalLenderFees = v232;
                var v233 = TotalOfPayments; v233.Clean = value; TotalOfPayments = v233;
                var v234 = TotalOfPrincipalAndInterest; v234.Clean = value; TotalOfPrincipalAndInterest = v234;
                var v235 = UseCustomLenderProfile; v235.Clean = value; UseCustomLenderProfile = v235;
                var v236 = UseDaysInYears; v236.Clean = value; UseDaysInYears = v236;
                var v237 = UsePitiForRatioIndicator; v237.Clean = value; UsePitiForRatioIndicator = v237;
                var v238 = VariableRateFeatureIndicator; v238.Clean = value; VariableRateFeatureIndicator = v238;
                var v239 = YearlyTerm; v239.Clean = value; YearlyTerm = v239;
                var v240 = YearOfMaximumPayment; v240.Clean = value; YearOfMaximumPayment = v240;
                var v241 = Years; v241.Clean = value; Years = v241;
                _settingClean = 0;
            }
        }
    }
}