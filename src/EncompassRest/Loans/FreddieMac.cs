using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FreddieMac
    {
        public Value<string> AffordableProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffordableProduct() => !AffordableProduct.Clean;
        public Value<decimal?> AlimonyAsIncomeReduction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlimonyAsIncomeReduction() => !AlimonyAsIncomeReduction.Clean;
        public Value<decimal?> AllMonthlyPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllMonthlyPayments() => !AllMonthlyPayments.Clean;
        public Value<bool?> AllowsNegativeAmortizationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowsNegativeAmortizationIndicator() => !AllowsNegativeAmortizationIndicator.Clean;
        public Value<string> AmountOfFinancedMI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountOfFinancedMI() => !AmountOfFinancedMI.Clean;
        public Value<string> APNCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAPNCity() => !APNCity.Clean;
        public Value<bool?> ArmsLengthTransactionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmsLengthTransactionIndicator() => !ArmsLengthTransactionIndicator.Clean;
        public Value<bool?> BorrowerQualifiesAsVeteranIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerQualifiesAsVeteranIndicator() => !BorrowerQualifiesAsVeteranIndicator.Clean;
        public Value<string> BrokerOriginated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerOriginated() => !BrokerOriginated.Clean;
        public Value<string> BuydownContributor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownContributor() => !BuydownContributor.Clean;
        public Value<string> CondoClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondoClass() => !CondoClass.Clean;
        public Value<decimal?> ConvertibleFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleFeeAmount() => !ConvertibleFeeAmount.Clean;
        public Value<decimal?> ConvertibleFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleFeePercent() => !ConvertibleFeePercent.Clean;
        public Value<decimal?> ConvertibleMaxRateAdjPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleMaxRateAdjPercent() => !ConvertibleMaxRateAdjPercent.Clean;
        public Value<decimal?> ConvertibleMinRateAdjPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleMinRateAdjPercent() => !ConvertibleMinRateAdjPercent.Clean;
        public Value<string> County { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !County.Clean;
        public Value<string> CreditReportCompany { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportCompany() => !CreditReportCompany.Clean;
        public Value<decimal?> FinancingConcessions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancingConcessions() => !FinancingConcessions.Clean;
        public Value<string> FreddieFiel11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieFiel11() => !FreddieFiel11.Clean;
        public Value<string> FreddieFiel12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieFiel12() => !FreddieFiel12.Clean;
        public Value<string> FreddieFiel13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieFiel13() => !FreddieFiel13.Clean;
        public Value<string> FreddieFiel14 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieFiel14() => !FreddieFiel14.Clean;
        public Value<string> FreddieFiel15 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieFiel15() => !FreddieFiel15.Clean;
        public Value<string> FreddieField3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieField3() => !FreddieField3.Clean;
        public Value<string> FreddieField7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieField7() => !FreddieField7.Clean;
        public Value<string> HELOCActualBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHELOCActualBalance() => !HELOCActualBalance.Clean;
        public Value<string> HELOCCreditLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHELOCCreditLimit() => !HELOCCreditLimit.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LenderAltPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAltPhone() => !LenderAltPhone.Clean;
        public Value<string> LenderRegistration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderRegistration() => !LenderRegistration.Clean;
        public Value<string> LoanProspectorID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProspectorID() => !LoanProspectorID.Clean;
        public Value<string> LoanToConduitCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanToConduitCode() => !LoanToConduitCode.Clean;
        public Value<string> LongLegalDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLongLegalDescription() => !LongLegalDescription.Clean;
        public Value<string> LossCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLossCoverage() => !LossCoverage.Clean;
        public Value<string> LPKeyNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPKeyNumber() => !LPKeyNumber.Clean;
        public Value<string> MIRefundOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIRefundOption() => !MIRefundOption.Clean;
        public Value<string> MortgageInsuranceCompany { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceCompany() => !MortgageInsuranceCompany.Clean;
        public Value<decimal?> NetPurchasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetPurchasePrice() => !NetPurchasePrice.Clean;
        public Value<string> NewConstructionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewConstructionType() => !NewConstructionType.Clean;
        public Value<string> NoAppraisalMAF { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoAppraisalMAF() => !NoAppraisalMAF.Clean;
        public Value<decimal?> NonOccupantNonHousingDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonOccupantNonHousingDebt() => !NonOccupantNonHousingDebt.Clean;
        public Value<decimal?> NonOccupantPresentHE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonOccupantPresentHE() => !NonOccupantPresentHE.Clean;
        public Value<bool?> OrderCreditEvaluationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderCreditEvaluationIndicator() => !OrderCreditEvaluationIndicator.Clean;
        public Value<bool?> OrderMergedCreditReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderMergedCreditReportIndicator() => !OrderMergedCreditReportIndicator.Clean;
        public Value<string> OrderMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderMortgageInsurance() => !OrderMortgageInsurance.Clean;
        public Value<bool?> OrderRiskGradeEvaluationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderRiskGradeEvaluationIndicator() => !OrderRiskGradeEvaluationIndicator.Clean;
        public Value<decimal?> OriginalIntRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalIntRate() => !OriginalIntRate.Clean;
        public Value<string> OriginateID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginateID() => !OriginateID.Clean;
        public Value<string> PaymentFrequency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentFrequency() => !PaymentFrequency.Clean;
        public Value<string> PaymentOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentOption() => !PaymentOption.Clean;
        public Value<decimal?> PersonIncomeForSelfEmployment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonIncomeForSelfEmployment1() => !PersonIncomeForSelfEmployment1.Clean;
        public Value<decimal?> PersonIncomeForSelfEmployment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonIncomeForSelfEmployment2() => !PersonIncomeForSelfEmployment2.Clean;
        public Value<int?> PersonPercentOfBusinessOwned1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonPercentOfBusinessOwned1() => !PersonPercentOfBusinessOwned1.Clean;
        public Value<int?> PersonPercentOfBusinessOwned2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonPercentOfBusinessOwned2() => !PersonPercentOfBusinessOwned2.Clean;
        public Value<string> PremiumSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePremiumSource() => !PremiumSource.Clean;
        public Value<decimal?> PresentHousingExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentHousingExpense() => !PresentHousingExpense.Clean;
        public Value<string> ProcessingPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingPoint() => !ProcessingPoint.Clean;
        public Value<string> PropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyType() => !PropertyType.Clean;
        public Value<string> PurposeOfLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurposeOfLoan() => !PurposeOfLoan.Clean;
        public Value<string> RenewalOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRenewalOption() => !RenewalOption.Clean;
        public Value<string> RenewalType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRenewalType() => !RenewalType.Clean;
        public Value<string> RequiredDocumentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredDocumentType() => !RequiredDocumentType.Clean;
        public Value<decimal?> Reserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReserves() => !Reserves.Clean;
        public Value<bool?> RetailLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRetailLoanIndicator() => !RetailLoanIndicator.Clean;
        public Value<string> RiskClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskClass() => !RiskClass.Clean;
        public Value<string> RiskGradeEvaluationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskGradeEvaluationType() => !RiskGradeEvaluationType.Clean;
        public Value<decimal?> SalesConcessions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSalesConcessions() => !SalesConcessions.Clean;
        public Value<string> SecondaryFinancingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondaryFinancingType() => !SecondaryFinancingType.Clean;
        public Value<bool?> SecondTrustRefiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondTrustRefiIndicator() => !SecondTrustRefiIndicator.Clean;
        public Value<decimal?> SimulatedPITI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSimulatedPITI() => !SimulatedPITI.Clean;
        public Value<string> SizeOfHousehold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSizeOfHousehold() => !SizeOfHousehold.Clean;
        public Value<string> SpecialInstruction1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialInstruction1() => !SpecialInstruction1.Clean;
        public Value<string> SpecialInstruction2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialInstruction2() => !SpecialInstruction2.Clean;
        public Value<string> SpecialInstruction3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialInstruction3() => !SpecialInstruction3.Clean;
        public Value<string> SpecialInstruction4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialInstruction4() => !SpecialInstruction4.Clean;
        public Value<string> SpecialInstruction5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialInstruction5() => !SpecialInstruction5.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<bool?> TransferLoanToConduitIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransferLoanToConduitIndicator() => !TransferLoanToConduitIndicator.Clean;
        public Value<string> YearsOfCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearsOfCoverage() => !YearsOfCoverage.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AffordableProduct.Clean
                    && AlimonyAsIncomeReduction.Clean
                    && AllMonthlyPayments.Clean
                    && AllowsNegativeAmortizationIndicator.Clean
                    && AmountOfFinancedMI.Clean
                    && APNCity.Clean
                    && ArmsLengthTransactionIndicator.Clean
                    && BorrowerQualifiesAsVeteranIndicator.Clean
                    && BrokerOriginated.Clean
                    && BuydownContributor.Clean
                    && CondoClass.Clean
                    && ConvertibleFeeAmount.Clean
                    && ConvertibleFeePercent.Clean
                    && ConvertibleMaxRateAdjPercent.Clean
                    && ConvertibleMinRateAdjPercent.Clean
                    && County.Clean
                    && CreditReportCompany.Clean
                    && FinancingConcessions.Clean
                    && FreddieFiel11.Clean
                    && FreddieFiel12.Clean
                    && FreddieFiel13.Clean
                    && FreddieFiel14.Clean
                    && FreddieFiel15.Clean
                    && FreddieField3.Clean
                    && FreddieField7.Clean
                    && HELOCActualBalance.Clean
                    && HELOCCreditLimit.Clean
                    && Id.Clean
                    && LenderAltPhone.Clean
                    && LenderRegistration.Clean
                    && LoanProspectorID.Clean
                    && LoanToConduitCode.Clean
                    && LongLegalDescription.Clean
                    && LossCoverage.Clean
                    && LPKeyNumber.Clean
                    && MIRefundOption.Clean
                    && MortgageInsuranceCompany.Clean
                    && NetPurchasePrice.Clean
                    && NewConstructionType.Clean
                    && NoAppraisalMAF.Clean
                    && NonOccupantNonHousingDebt.Clean
                    && NonOccupantPresentHE.Clean
                    && OrderCreditEvaluationIndicator.Clean
                    && OrderMergedCreditReportIndicator.Clean
                    && OrderMortgageInsurance.Clean
                    && OrderRiskGradeEvaluationIndicator.Clean
                    && OriginalIntRate.Clean
                    && OriginateID.Clean
                    && PaymentFrequency.Clean
                    && PaymentOption.Clean
                    && PersonIncomeForSelfEmployment1.Clean
                    && PersonIncomeForSelfEmployment2.Clean
                    && PersonPercentOfBusinessOwned1.Clean
                    && PersonPercentOfBusinessOwned2.Clean
                    && PremiumSource.Clean
                    && PresentHousingExpense.Clean
                    && ProcessingPoint.Clean
                    && PropertyType.Clean
                    && PurposeOfLoan.Clean
                    && RenewalOption.Clean
                    && RenewalType.Clean
                    && RequiredDocumentType.Clean
                    && Reserves.Clean
                    && RetailLoanIndicator.Clean
                    && RiskClass.Clean
                    && RiskGradeEvaluationType.Clean
                    && SalesConcessions.Clean
                    && SecondaryFinancingType.Clean
                    && SecondTrustRefiIndicator.Clean
                    && SimulatedPITI.Clean
                    && SizeOfHousehold.Clean
                    && SpecialInstruction1.Clean
                    && SpecialInstruction2.Clean
                    && SpecialInstruction3.Clean
                    && SpecialInstruction4.Clean
                    && SpecialInstruction5.Clean
                    && State.Clean
                    && TransferLoanToConduitIndicator.Clean
                    && YearsOfCoverage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AffordableProduct; v0.Clean = value; AffordableProduct = v0;
                var v1 = AlimonyAsIncomeReduction; v1.Clean = value; AlimonyAsIncomeReduction = v1;
                var v2 = AllMonthlyPayments; v2.Clean = value; AllMonthlyPayments = v2;
                var v3 = AllowsNegativeAmortizationIndicator; v3.Clean = value; AllowsNegativeAmortizationIndicator = v3;
                var v4 = AmountOfFinancedMI; v4.Clean = value; AmountOfFinancedMI = v4;
                var v5 = APNCity; v5.Clean = value; APNCity = v5;
                var v6 = ArmsLengthTransactionIndicator; v6.Clean = value; ArmsLengthTransactionIndicator = v6;
                var v7 = BorrowerQualifiesAsVeteranIndicator; v7.Clean = value; BorrowerQualifiesAsVeteranIndicator = v7;
                var v8 = BrokerOriginated; v8.Clean = value; BrokerOriginated = v8;
                var v9 = BuydownContributor; v9.Clean = value; BuydownContributor = v9;
                var v10 = CondoClass; v10.Clean = value; CondoClass = v10;
                var v11 = ConvertibleFeeAmount; v11.Clean = value; ConvertibleFeeAmount = v11;
                var v12 = ConvertibleFeePercent; v12.Clean = value; ConvertibleFeePercent = v12;
                var v13 = ConvertibleMaxRateAdjPercent; v13.Clean = value; ConvertibleMaxRateAdjPercent = v13;
                var v14 = ConvertibleMinRateAdjPercent; v14.Clean = value; ConvertibleMinRateAdjPercent = v14;
                var v15 = County; v15.Clean = value; County = v15;
                var v16 = CreditReportCompany; v16.Clean = value; CreditReportCompany = v16;
                var v17 = FinancingConcessions; v17.Clean = value; FinancingConcessions = v17;
                var v18 = FreddieFiel11; v18.Clean = value; FreddieFiel11 = v18;
                var v19 = FreddieFiel12; v19.Clean = value; FreddieFiel12 = v19;
                var v20 = FreddieFiel13; v20.Clean = value; FreddieFiel13 = v20;
                var v21 = FreddieFiel14; v21.Clean = value; FreddieFiel14 = v21;
                var v22 = FreddieFiel15; v22.Clean = value; FreddieFiel15 = v22;
                var v23 = FreddieField3; v23.Clean = value; FreddieField3 = v23;
                var v24 = FreddieField7; v24.Clean = value; FreddieField7 = v24;
                var v25 = HELOCActualBalance; v25.Clean = value; HELOCActualBalance = v25;
                var v26 = HELOCCreditLimit; v26.Clean = value; HELOCCreditLimit = v26;
                var v27 = Id; v27.Clean = value; Id = v27;
                var v28 = LenderAltPhone; v28.Clean = value; LenderAltPhone = v28;
                var v29 = LenderRegistration; v29.Clean = value; LenderRegistration = v29;
                var v30 = LoanProspectorID; v30.Clean = value; LoanProspectorID = v30;
                var v31 = LoanToConduitCode; v31.Clean = value; LoanToConduitCode = v31;
                var v32 = LongLegalDescription; v32.Clean = value; LongLegalDescription = v32;
                var v33 = LossCoverage; v33.Clean = value; LossCoverage = v33;
                var v34 = LPKeyNumber; v34.Clean = value; LPKeyNumber = v34;
                var v35 = MIRefundOption; v35.Clean = value; MIRefundOption = v35;
                var v36 = MortgageInsuranceCompany; v36.Clean = value; MortgageInsuranceCompany = v36;
                var v37 = NetPurchasePrice; v37.Clean = value; NetPurchasePrice = v37;
                var v38 = NewConstructionType; v38.Clean = value; NewConstructionType = v38;
                var v39 = NoAppraisalMAF; v39.Clean = value; NoAppraisalMAF = v39;
                var v40 = NonOccupantNonHousingDebt; v40.Clean = value; NonOccupantNonHousingDebt = v40;
                var v41 = NonOccupantPresentHE; v41.Clean = value; NonOccupantPresentHE = v41;
                var v42 = OrderCreditEvaluationIndicator; v42.Clean = value; OrderCreditEvaluationIndicator = v42;
                var v43 = OrderMergedCreditReportIndicator; v43.Clean = value; OrderMergedCreditReportIndicator = v43;
                var v44 = OrderMortgageInsurance; v44.Clean = value; OrderMortgageInsurance = v44;
                var v45 = OrderRiskGradeEvaluationIndicator; v45.Clean = value; OrderRiskGradeEvaluationIndicator = v45;
                var v46 = OriginalIntRate; v46.Clean = value; OriginalIntRate = v46;
                var v47 = OriginateID; v47.Clean = value; OriginateID = v47;
                var v48 = PaymentFrequency; v48.Clean = value; PaymentFrequency = v48;
                var v49 = PaymentOption; v49.Clean = value; PaymentOption = v49;
                var v50 = PersonIncomeForSelfEmployment1; v50.Clean = value; PersonIncomeForSelfEmployment1 = v50;
                var v51 = PersonIncomeForSelfEmployment2; v51.Clean = value; PersonIncomeForSelfEmployment2 = v51;
                var v52 = PersonPercentOfBusinessOwned1; v52.Clean = value; PersonPercentOfBusinessOwned1 = v52;
                var v53 = PersonPercentOfBusinessOwned2; v53.Clean = value; PersonPercentOfBusinessOwned2 = v53;
                var v54 = PremiumSource; v54.Clean = value; PremiumSource = v54;
                var v55 = PresentHousingExpense; v55.Clean = value; PresentHousingExpense = v55;
                var v56 = ProcessingPoint; v56.Clean = value; ProcessingPoint = v56;
                var v57 = PropertyType; v57.Clean = value; PropertyType = v57;
                var v58 = PurposeOfLoan; v58.Clean = value; PurposeOfLoan = v58;
                var v59 = RenewalOption; v59.Clean = value; RenewalOption = v59;
                var v60 = RenewalType; v60.Clean = value; RenewalType = v60;
                var v61 = RequiredDocumentType; v61.Clean = value; RequiredDocumentType = v61;
                var v62 = Reserves; v62.Clean = value; Reserves = v62;
                var v63 = RetailLoanIndicator; v63.Clean = value; RetailLoanIndicator = v63;
                var v64 = RiskClass; v64.Clean = value; RiskClass = v64;
                var v65 = RiskGradeEvaluationType; v65.Clean = value; RiskGradeEvaluationType = v65;
                var v66 = SalesConcessions; v66.Clean = value; SalesConcessions = v66;
                var v67 = SecondaryFinancingType; v67.Clean = value; SecondaryFinancingType = v67;
                var v68 = SecondTrustRefiIndicator; v68.Clean = value; SecondTrustRefiIndicator = v68;
                var v69 = SimulatedPITI; v69.Clean = value; SimulatedPITI = v69;
                var v70 = SizeOfHousehold; v70.Clean = value; SizeOfHousehold = v70;
                var v71 = SpecialInstruction1; v71.Clean = value; SpecialInstruction1 = v71;
                var v72 = SpecialInstruction2; v72.Clean = value; SpecialInstruction2 = v72;
                var v73 = SpecialInstruction3; v73.Clean = value; SpecialInstruction3 = v73;
                var v74 = SpecialInstruction4; v74.Clean = value; SpecialInstruction4 = v74;
                var v75 = SpecialInstruction5; v75.Clean = value; SpecialInstruction5 = v75;
                var v76 = State; v76.Clean = value; State = v76;
                var v77 = TransferLoanToConduitIndicator; v77.Clean = value; TransferLoanToConduitIndicator = v77;
                var v78 = YearsOfCoverage; v78.Clean = value; YearsOfCoverage = v78;
                _settingClean = 0;
            }
        }
    }
}