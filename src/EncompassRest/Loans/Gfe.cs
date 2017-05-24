using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<decimal?> AgregateAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgregateAdjustment() => !AgregateAdjustment.Clean;
        public Value<decimal?> BrokerCommission { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCommission() => !BrokerCommission.Clean;
        public Value<string> BrokerLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicense() => !BrokerLicense.Clean;
        public Value<string> BrokerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerName() => !BrokerName.Clean;
        public Value<string> BrokerRepresentative { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerRepresentative() => !BrokerRepresentative.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<decimal?> CompensationFromLenderAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderAmount() => !CompensationFromLenderAmount.Clean;
        public Value<decimal?> CompensationFromLenderPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderPercentage() => !CompensationFromLenderPercentage.Clean;
        public Value<decimal?> CompensationFromLenderTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderTotalAmount() => !CompensationFromLenderTotalAmount.Clean;
        public Value<decimal?> CreditLifeOrDisabilityPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLifeOrDisabilityPremium() => !CreditLifeOrDisabilityPremium.Clean;
        public Value<decimal?> CreditToBorrowerAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditToBorrowerAmount() => !CreditToBorrowerAmount.Clean;
        public Value<decimal?> EstimatedCashAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashAtClosing() => !EstimatedCashAtClosing.Clean;
        public Value<decimal?> EstimatedCashToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashToBorrower() => !EstimatedCashToBorrower.Clean;
        public Value<DateTime?> EstimatedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedDueDate() => !EstimatedDueDate.Clean;
        public Value<decimal?> FinalBalloonPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalBalloonPayment() => !FinalBalloonPayment.Clean;
        public Value<decimal?> FirstChangePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePayment() => !FirstChangePayment.Clean;
        public Value<decimal?> FirstChangePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePercent() => !FirstChangePercent.Clean;
        public Value<decimal?> FundingAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingAmount() => !FundingAmount.Clean;
        public Value<List<GfeFee>> GfeFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeFees() => !GfeFees.Clean;
        public Value<List<GfeLien>> GfeLiens { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLiens() => !GfeLiens.Clean;
        public Value<List<GfePayment>> GfePayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePayments() => !GfePayments.Clean;
        public Value<List<GfePayoff>> GfePayoffs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePayoffs() => !GfePayoffs.Clean;
        public Value<bool?> GfeProvidedByBrokerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeProvidedByBrokerIndicator() => !GfeProvidedByBrokerIndicator.Clean;
        public Value<bool?> HasAdditionalCompensationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasAdditionalCompensationIndicator() => !HasAdditionalCompensationIndicator.Clean;
        public Value<bool?> HasLateChargesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasLateChargesIndicator() => !HasLateChargesIndicator.Clean;
        public Value<bool?> HasPrepaymentPenaltyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasPrepaymentPenaltyIndicator() => !HasPrepaymentPenaltyIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InitialFixedOrArmType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialFixedOrArmType() => !InitialFixedOrArmType.Clean;
        public Value<decimal?> LenderOriginationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderOriginationFee() => !LenderOriginationFee.Clean;
        public Value<string> LoanFromBrokerControledFundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFromBrokerControledFundsType() => !LoanFromBrokerControledFundsType.Clean;
        public Value<bool?> LockField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockField() => !LockField.Clean;
        public Value<decimal?> MaxLifePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLifePayment() => !MaxLifePayment.Clean;
        public Value<int?> MaxPaymentAfterMonth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPaymentAfterMonth() => !MaxPaymentAfterMonth.Clean;
        public Value<decimal?> MonthlyPaymentAndEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentAndEscrow() => !MonthlyPaymentAndEscrow.Clean;
        public Value<decimal?> MortgageBrokerComissionFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerComissionFee() => !MortgageBrokerComissionFee.Clean;
        public Value<string> MortgageBrokerComissionFeePaidToName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerComissionFeePaidToName() => !MortgageBrokerComissionFeePaidToName.Clean;
        public Value<string> NatureLien1Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien1Description() => !NatureLien1Description.Clean;
        public Value<string> NatureLien1PayoffDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien1PayoffDescription() => !NatureLien1PayoffDescription.Clean;
        public Value<string> NatureLien2Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien2Description() => !NatureLien2Description.Clean;
        public Value<string> NatureLien2PayoffDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien2PayoffDescription() => !NatureLien2PayoffDescription.Clean;
        public Value<string> NatureLien3Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien3Description() => !NatureLien3Description.Clean;
        public Value<string> NatureLien3PayoffDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien3PayoffDescription() => !NatureLien3PayoffDescription.Clean;
        public Value<bool?> PaymentOfPrincipleIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentOfPrincipleIndicator() => !PaymentOfPrincipleIndicator.Clean;
        public Value<string> PaymentOfPrincipleType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentOfPrincipleType() => !PaymentOfPrincipleType.Clean;
        public Value<int?> PenaltyNotToExceedMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePenaltyNotToExceedMonths() => !PenaltyNotToExceedMonths.Clean;
        public Value<string> PocPaid1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid1() => !PocPaid1.Clean;
        public Value<string> PocPaid2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid2() => !PocPaid2.Clean;
        public Value<string> PocPaid3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid3() => !PocPaid3.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> PrepaymentOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentOtherDescription() => !PrepaymentOtherDescription.Clean;
        public Value<bool?> PrepaymentOtherTypeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentOtherTypeIndicator() => !PrepaymentOtherTypeIndicator.Clean;
        public Value<decimal?> PrepaymentPenaltyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyAmount() => !PrepaymentPenaltyAmount.Clean;
        public Value<bool?> PrepaymentPenaltyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !PrepaymentPenaltyIndicator.Clean;
        public Value<int?> PrepaymentPenaltyPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPeriod() => !PrepaymentPenaltyPeriod.Clean;
        public Value<decimal?> PrincipalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalAmount() => !PrincipalAmount.Clean;
        public Value<decimal?> PurchasePayOff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePayOff() => !PurchasePayOff.Clean;
        public Value<decimal?> Re882AdditionalCompensation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRe882AdditionalCompensation() => !Re882AdditionalCompensation.Clean;
        public Value<decimal?> ReceivedFromLenderAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedFromLenderAmount() => !ReceivedFromLenderAmount.Clean;
        public Value<string> RepresentativeLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepresentativeLicense() => !RepresentativeLicense.Clean;
        public Value<bool?> SourcesDeemedReliableIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourcesDeemedReliableIndicator() => !SourcesDeemedReliableIndicator.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<decimal?> SubtotalOfAllDeductions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubtotalOfAllDeductions() => !SubtotalOfAllDeductions.Clean;
        public Value<decimal?> TotalBrokerCompensationAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBrokerCompensationAmount() => !TotalBrokerCompensationAmount.Clean;
        public Value<decimal?> TotalClosingCostWithDiscount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCostWithDiscount() => !TotalClosingCostWithDiscount.Clean;
        public Value<decimal?> TotalCostsExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCostsExpenses() => !TotalCostsExpenses.Clean;
        public Value<decimal?> TotalMaximumCostsExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMaximumCostsExpenses() => !TotalMaximumCostsExpenses.Clean;
        public Value<decimal?> TotalOfInitialFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOfInitialFees() => !TotalOfInitialFees.Clean;
        public Value<decimal?> TotalPrepaidClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrepaidClosingCost() => !TotalPrepaidClosingCost.Clean;
        public Value<decimal?> TotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSettlementCharges() => !TotalSettlementCharges.Clean;
        public Value<decimal?> TotalTaxAndInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalTaxAndInsurance() => !TotalTaxAndInsurance.Clean;
        public Value<decimal?> YearlyFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyFloodInsurance() => !YearlyFloodInsurance.Clean;
        public Value<decimal?> YearlyInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyInsurance() => !YearlyInsurance.Clean;
        public Value<decimal?> YearlyMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyMortgageInsurance() => !YearlyMortgageInsurance.Clean;
        public Value<decimal?> YearlyOtherInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyOtherInsurance() => !YearlyOtherInsurance.Clean;
        public Value<string> YearlyOtherInsuranceDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyOtherInsuranceDescription() => !YearlyOtherInsuranceDescription.Clean;
        public Value<decimal?> YearlyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyTax() => !YearlyTax.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Address.Clean
                    && AgregateAdjustment.Clean
                    && BrokerCommission.Clean
                    && BrokerLicense.Clean
                    && BrokerName.Clean
                    && BrokerRepresentative.Clean
                    && City.Clean
                    && CompensationFromLenderAmount.Clean
                    && CompensationFromLenderPercentage.Clean
                    && CompensationFromLenderTotalAmount.Clean
                    && CreditLifeOrDisabilityPremium.Clean
                    && CreditToBorrowerAmount.Clean
                    && EstimatedCashAtClosing.Clean
                    && EstimatedCashToBorrower.Clean
                    && EstimatedDueDate.Clean
                    && FinalBalloonPayment.Clean
                    && FirstChangePayment.Clean
                    && FirstChangePercent.Clean
                    && FundingAmount.Clean
                    && GfeFees.Clean
                    && GfeLiens.Clean
                    && GfePayments.Clean
                    && GfePayoffs.Clean
                    && GfeProvidedByBrokerIndicator.Clean
                    && HasAdditionalCompensationIndicator.Clean
                    && HasLateChargesIndicator.Clean
                    && HasPrepaymentPenaltyIndicator.Clean
                    && Id.Clean
                    && InitialFixedOrArmType.Clean
                    && LenderOriginationFee.Clean
                    && LoanFromBrokerControledFundsType.Clean
                    && LockField.Clean
                    && MaxLifePayment.Clean
                    && MaxPaymentAfterMonth.Clean
                    && MonthlyPaymentAndEscrow.Clean
                    && MortgageBrokerComissionFee.Clean
                    && MortgageBrokerComissionFeePaidToName.Clean
                    && NatureLien1Description.Clean
                    && NatureLien1PayoffDescription.Clean
                    && NatureLien2Description.Clean
                    && NatureLien2PayoffDescription.Clean
                    && NatureLien3Description.Clean
                    && NatureLien3PayoffDescription.Clean
                    && PaymentOfPrincipleIndicator.Clean
                    && PaymentOfPrincipleType.Clean
                    && PenaltyNotToExceedMonths.Clean
                    && PocPaid1.Clean
                    && PocPaid2.Clean
                    && PocPaid3.Clean
                    && PostalCode.Clean
                    && PrepaymentOtherDescription.Clean
                    && PrepaymentOtherTypeIndicator.Clean
                    && PrepaymentPenaltyAmount.Clean
                    && PrepaymentPenaltyIndicator.Clean
                    && PrepaymentPenaltyPeriod.Clean
                    && PrincipalAmount.Clean
                    && PurchasePayOff.Clean
                    && Re882AdditionalCompensation.Clean
                    && ReceivedFromLenderAmount.Clean
                    && RepresentativeLicense.Clean
                    && SourcesDeemedReliableIndicator.Clean
                    && State.Clean
                    && SubtotalOfAllDeductions.Clean
                    && TotalBrokerCompensationAmount.Clean
                    && TotalClosingCostWithDiscount.Clean
                    && TotalCostsExpenses.Clean
                    && TotalMaximumCostsExpenses.Clean
                    && TotalOfInitialFees.Clean
                    && TotalPrepaidClosingCost.Clean
                    && TotalSettlementCharges.Clean
                    && TotalTaxAndInsurance.Clean
                    && YearlyFloodInsurance.Clean
                    && YearlyInsurance.Clean
                    && YearlyMortgageInsurance.Clean
                    && YearlyOtherInsurance.Clean
                    && YearlyOtherInsuranceDescription.Clean
                    && YearlyTax.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = AgregateAdjustment; v1.Clean = value; AgregateAdjustment = v1;
                var v2 = BrokerCommission; v2.Clean = value; BrokerCommission = v2;
                var v3 = BrokerLicense; v3.Clean = value; BrokerLicense = v3;
                var v4 = BrokerName; v4.Clean = value; BrokerName = v4;
                var v5 = BrokerRepresentative; v5.Clean = value; BrokerRepresentative = v5;
                var v6 = City; v6.Clean = value; City = v6;
                var v7 = CompensationFromLenderAmount; v7.Clean = value; CompensationFromLenderAmount = v7;
                var v8 = CompensationFromLenderPercentage; v8.Clean = value; CompensationFromLenderPercentage = v8;
                var v9 = CompensationFromLenderTotalAmount; v9.Clean = value; CompensationFromLenderTotalAmount = v9;
                var v10 = CreditLifeOrDisabilityPremium; v10.Clean = value; CreditLifeOrDisabilityPremium = v10;
                var v11 = CreditToBorrowerAmount; v11.Clean = value; CreditToBorrowerAmount = v11;
                var v12 = EstimatedCashAtClosing; v12.Clean = value; EstimatedCashAtClosing = v12;
                var v13 = EstimatedCashToBorrower; v13.Clean = value; EstimatedCashToBorrower = v13;
                var v14 = EstimatedDueDate; v14.Clean = value; EstimatedDueDate = v14;
                var v15 = FinalBalloonPayment; v15.Clean = value; FinalBalloonPayment = v15;
                var v16 = FirstChangePayment; v16.Clean = value; FirstChangePayment = v16;
                var v17 = FirstChangePercent; v17.Clean = value; FirstChangePercent = v17;
                var v18 = FundingAmount; v18.Clean = value; FundingAmount = v18;
                var v19 = GfeFees; v19.Clean = value; GfeFees = v19;
                var v20 = GfeLiens; v20.Clean = value; GfeLiens = v20;
                var v21 = GfePayments; v21.Clean = value; GfePayments = v21;
                var v22 = GfePayoffs; v22.Clean = value; GfePayoffs = v22;
                var v23 = GfeProvidedByBrokerIndicator; v23.Clean = value; GfeProvidedByBrokerIndicator = v23;
                var v24 = HasAdditionalCompensationIndicator; v24.Clean = value; HasAdditionalCompensationIndicator = v24;
                var v25 = HasLateChargesIndicator; v25.Clean = value; HasLateChargesIndicator = v25;
                var v26 = HasPrepaymentPenaltyIndicator; v26.Clean = value; HasPrepaymentPenaltyIndicator = v26;
                var v27 = Id; v27.Clean = value; Id = v27;
                var v28 = InitialFixedOrArmType; v28.Clean = value; InitialFixedOrArmType = v28;
                var v29 = LenderOriginationFee; v29.Clean = value; LenderOriginationFee = v29;
                var v30 = LoanFromBrokerControledFundsType; v30.Clean = value; LoanFromBrokerControledFundsType = v30;
                var v31 = LockField; v31.Clean = value; LockField = v31;
                var v32 = MaxLifePayment; v32.Clean = value; MaxLifePayment = v32;
                var v33 = MaxPaymentAfterMonth; v33.Clean = value; MaxPaymentAfterMonth = v33;
                var v34 = MonthlyPaymentAndEscrow; v34.Clean = value; MonthlyPaymentAndEscrow = v34;
                var v35 = MortgageBrokerComissionFee; v35.Clean = value; MortgageBrokerComissionFee = v35;
                var v36 = MortgageBrokerComissionFeePaidToName; v36.Clean = value; MortgageBrokerComissionFeePaidToName = v36;
                var v37 = NatureLien1Description; v37.Clean = value; NatureLien1Description = v37;
                var v38 = NatureLien1PayoffDescription; v38.Clean = value; NatureLien1PayoffDescription = v38;
                var v39 = NatureLien2Description; v39.Clean = value; NatureLien2Description = v39;
                var v40 = NatureLien2PayoffDescription; v40.Clean = value; NatureLien2PayoffDescription = v40;
                var v41 = NatureLien3Description; v41.Clean = value; NatureLien3Description = v41;
                var v42 = NatureLien3PayoffDescription; v42.Clean = value; NatureLien3PayoffDescription = v42;
                var v43 = PaymentOfPrincipleIndicator; v43.Clean = value; PaymentOfPrincipleIndicator = v43;
                var v44 = PaymentOfPrincipleType; v44.Clean = value; PaymentOfPrincipleType = v44;
                var v45 = PenaltyNotToExceedMonths; v45.Clean = value; PenaltyNotToExceedMonths = v45;
                var v46 = PocPaid1; v46.Clean = value; PocPaid1 = v46;
                var v47 = PocPaid2; v47.Clean = value; PocPaid2 = v47;
                var v48 = PocPaid3; v48.Clean = value; PocPaid3 = v48;
                var v49 = PostalCode; v49.Clean = value; PostalCode = v49;
                var v50 = PrepaymentOtherDescription; v50.Clean = value; PrepaymentOtherDescription = v50;
                var v51 = PrepaymentOtherTypeIndicator; v51.Clean = value; PrepaymentOtherTypeIndicator = v51;
                var v52 = PrepaymentPenaltyAmount; v52.Clean = value; PrepaymentPenaltyAmount = v52;
                var v53 = PrepaymentPenaltyIndicator; v53.Clean = value; PrepaymentPenaltyIndicator = v53;
                var v54 = PrepaymentPenaltyPeriod; v54.Clean = value; PrepaymentPenaltyPeriod = v54;
                var v55 = PrincipalAmount; v55.Clean = value; PrincipalAmount = v55;
                var v56 = PurchasePayOff; v56.Clean = value; PurchasePayOff = v56;
                var v57 = Re882AdditionalCompensation; v57.Clean = value; Re882AdditionalCompensation = v57;
                var v58 = ReceivedFromLenderAmount; v58.Clean = value; ReceivedFromLenderAmount = v58;
                var v59 = RepresentativeLicense; v59.Clean = value; RepresentativeLicense = v59;
                var v60 = SourcesDeemedReliableIndicator; v60.Clean = value; SourcesDeemedReliableIndicator = v60;
                var v61 = State; v61.Clean = value; State = v61;
                var v62 = SubtotalOfAllDeductions; v62.Clean = value; SubtotalOfAllDeductions = v62;
                var v63 = TotalBrokerCompensationAmount; v63.Clean = value; TotalBrokerCompensationAmount = v63;
                var v64 = TotalClosingCostWithDiscount; v64.Clean = value; TotalClosingCostWithDiscount = v64;
                var v65 = TotalCostsExpenses; v65.Clean = value; TotalCostsExpenses = v65;
                var v66 = TotalMaximumCostsExpenses; v66.Clean = value; TotalMaximumCostsExpenses = v66;
                var v67 = TotalOfInitialFees; v67.Clean = value; TotalOfInitialFees = v67;
                var v68 = TotalPrepaidClosingCost; v68.Clean = value; TotalPrepaidClosingCost = v68;
                var v69 = TotalSettlementCharges; v69.Clean = value; TotalSettlementCharges = v69;
                var v70 = TotalTaxAndInsurance; v70.Clean = value; TotalTaxAndInsurance = v70;
                var v71 = YearlyFloodInsurance; v71.Clean = value; YearlyFloodInsurance = v71;
                var v72 = YearlyInsurance; v72.Clean = value; YearlyInsurance = v72;
                var v73 = YearlyMortgageInsurance; v73.Clean = value; YearlyMortgageInsurance = v73;
                var v74 = YearlyOtherInsurance; v74.Clean = value; YearlyOtherInsurance = v74;
                var v75 = YearlyOtherInsuranceDescription; v75.Clean = value; YearlyOtherInsuranceDescription = v75;
                var v76 = YearlyTax; v76.Clean = value; YearlyTax = v76;
                _settingClean = 0;
            }
        }
    }
}