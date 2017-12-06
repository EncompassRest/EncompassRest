#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FreddieMac : ExtensibleObject
    {
        private DirtyValue<StringEnumValue<AffordableProduct>> _affordableProduct;
        public StringEnumValue<AffordableProduct> AffordableProduct { get => _affordableProduct; set => _affordableProduct = value; }
        private DirtyValue<decimal?> _alimonyAsIncomeReduction;
        public decimal? AlimonyAsIncomeReduction { get => _alimonyAsIncomeReduction; set => _alimonyAsIncomeReduction = value; }
        private DirtyValue<decimal?> _allMonthlyPayments;
        public decimal? AllMonthlyPayments { get => _allMonthlyPayments; set => _allMonthlyPayments = value; }
        private DirtyValue<bool?> _allowsNegativeAmortizationIndicator;
        public bool? AllowsNegativeAmortizationIndicator { get => _allowsNegativeAmortizationIndicator; set => _allowsNegativeAmortizationIndicator = value; }
        private DirtyValue<string> _amountOfFinancedMI;
        public string AmountOfFinancedMI { get => _amountOfFinancedMI; set => _amountOfFinancedMI = value; }
        private DirtyValue<string> _aPNCity;
        public string APNCity { get => _aPNCity; set => _aPNCity = value; }
        private DirtyValue<bool?> _armsLengthTransactionIndicator;
        public bool? ArmsLengthTransactionIndicator { get => _armsLengthTransactionIndicator; set => _armsLengthTransactionIndicator = value; }
        private DirtyValue<bool?> _borrowerQualifiesAsVeteranIndicator;
        public bool? BorrowerQualifiesAsVeteranIndicator { get => _borrowerQualifiesAsVeteranIndicator; set => _borrowerQualifiesAsVeteranIndicator = value; }
        private DirtyValue<string> _brokerOriginated;
        public string BrokerOriginated { get => _brokerOriginated; set => _brokerOriginated = value; }
        private DirtyValue<StringEnumValue<BuydownContributor>> _buydownContributor;
        public StringEnumValue<BuydownContributor> BuydownContributor { get => _buydownContributor; set => _buydownContributor = value; }
        private DirtyValue<StringEnumValue<CondoClass>> _condoClass;
        public StringEnumValue<CondoClass> CondoClass { get => _condoClass; set => _condoClass = value; }
        private DirtyValue<decimal?> _convertibleFeeAmount;
        public decimal? ConvertibleFeeAmount { get => _convertibleFeeAmount; set => _convertibleFeeAmount = value; }
        private DirtyValue<decimal?> _convertibleFeePercent;
        public decimal? ConvertibleFeePercent { get => _convertibleFeePercent; set => _convertibleFeePercent = value; }
        private DirtyValue<decimal?> _convertibleMaxRateAdjPercent;
        public decimal? ConvertibleMaxRateAdjPercent { get => _convertibleMaxRateAdjPercent; set => _convertibleMaxRateAdjPercent = value; }
        private DirtyValue<decimal?> _convertibleMinRateAdjPercent;
        public decimal? ConvertibleMinRateAdjPercent { get => _convertibleMinRateAdjPercent; set => _convertibleMinRateAdjPercent = value; }
        private DirtyValue<string> _county;
        public string County { get => _county; set => _county = value; }
        private DirtyValue<StringEnumValue<CreditReportCompany>> _creditReportCompany;
        public StringEnumValue<CreditReportCompany> CreditReportCompany { get => _creditReportCompany; set => _creditReportCompany = value; }
        private DirtyValue<decimal?> _financingConcessions;
        public decimal? FinancingConcessions { get => _financingConcessions; set => _financingConcessions = value; }
        private DirtyValue<string> _freddieFiel11;
        public string FreddieFiel11 { get => _freddieFiel11; set => _freddieFiel11 = value; }
        private DirtyValue<string> _freddieFiel12;
        public string FreddieFiel12 { get => _freddieFiel12; set => _freddieFiel12 = value; }
        private DirtyValue<string> _freddieFiel13;
        public string FreddieFiel13 { get => _freddieFiel13; set => _freddieFiel13 = value; }
        private DirtyValue<string> _freddieFiel14;
        public string FreddieFiel14 { get => _freddieFiel14; set => _freddieFiel14 = value; }
        private DirtyValue<string> _freddieFiel15;
        public string FreddieFiel15 { get => _freddieFiel15; set => _freddieFiel15 = value; }
        private DirtyValue<string> _freddieField3;
        public string FreddieField3 { get => _freddieField3; set => _freddieField3 = value; }
        private DirtyValue<string> _freddieField7;
        public string FreddieField7 { get => _freddieField7; set => _freddieField7 = value; }
        private DirtyValue<string> _hELOCActualBalance;
        public string HELOCActualBalance { get => _hELOCActualBalance; set => _hELOCActualBalance = value; }
        private DirtyValue<string> _hELOCCreditLimit;
        public string HELOCCreditLimit { get => _hELOCCreditLimit; set => _hELOCCreditLimit = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lenderAltPhone;
        public string LenderAltPhone { get => _lenderAltPhone; set => _lenderAltPhone = value; }
        private DirtyValue<string> _lenderRegistration;
        public string LenderRegistration { get => _lenderRegistration; set => _lenderRegistration = value; }
        private DirtyValue<string> _loanProspectorID;
        public string LoanProspectorID { get => _loanProspectorID; set => _loanProspectorID = value; }
        private DirtyValue<StringEnumValue<LoanToConduitCode>> _loanToConduitCode;
        public StringEnumValue<LoanToConduitCode> LoanToConduitCode { get => _loanToConduitCode; set => _loanToConduitCode = value; }
        private DirtyValue<string> _longLegalDescription;
        public string LongLegalDescription { get => _longLegalDescription; set => _longLegalDescription = value; }
        private DirtyValue<StringEnumValue<LossCoverage>> _lossCoverage;
        public StringEnumValue<LossCoverage> LossCoverage { get => _lossCoverage; set => _lossCoverage = value; }
        private DirtyValue<string> _lPKeyNumber;
        public string LPKeyNumber { get => _lPKeyNumber; set => _lPKeyNumber = value; }
        private DirtyValue<StringEnumValue<MIRefundOption>> _mIRefundOption;
        public StringEnumValue<MIRefundOption> MIRefundOption { get => _mIRefundOption; set => _mIRefundOption = value; }
        private DirtyValue<StringEnumValue<MortgageInsuranceCompany>> _mortgageInsuranceCompany;
        public StringEnumValue<MortgageInsuranceCompany> MortgageInsuranceCompany { get => _mortgageInsuranceCompany; set => _mortgageInsuranceCompany = value; }
        private DirtyValue<decimal?> _netPurchasePrice;
        public decimal? NetPurchasePrice { get => _netPurchasePrice; set => _netPurchasePrice = value; }
        private DirtyValue<StringEnumValue<NewConstructionType>> _newConstructionType;
        public StringEnumValue<NewConstructionType> NewConstructionType { get => _newConstructionType; set => _newConstructionType = value; }
        private DirtyValue<StringEnumValue<NoAppraisalMAF>> _noAppraisalMAF;
        public StringEnumValue<NoAppraisalMAF> NoAppraisalMAF { get => _noAppraisalMAF; set => _noAppraisalMAF = value; }
        private DirtyValue<decimal?> _nonOccupantNonHousingDebt;
        public decimal? NonOccupantNonHousingDebt { get => _nonOccupantNonHousingDebt; set => _nonOccupantNonHousingDebt = value; }
        private DirtyValue<decimal?> _nonOccupantPresentHE;
        public decimal? NonOccupantPresentHE { get => _nonOccupantPresentHE; set => _nonOccupantPresentHE = value; }
        private DirtyValue<bool?> _orderCreditEvaluationIndicator;
        public bool? OrderCreditEvaluationIndicator { get => _orderCreditEvaluationIndicator; set => _orderCreditEvaluationIndicator = value; }
        private DirtyValue<bool?> _orderMergedCreditReportIndicator;
        public bool? OrderMergedCreditReportIndicator { get => _orderMergedCreditReportIndicator; set => _orderMergedCreditReportIndicator = value; }
        private DirtyValue<StringEnumValue<OrderMortgageInsurance>> _orderMortgageInsurance;
        public StringEnumValue<OrderMortgageInsurance> OrderMortgageInsurance { get => _orderMortgageInsurance; set => _orderMortgageInsurance = value; }
        private DirtyValue<bool?> _orderRiskGradeEvaluationIndicator;
        public bool? OrderRiskGradeEvaluationIndicator { get => _orderRiskGradeEvaluationIndicator; set => _orderRiskGradeEvaluationIndicator = value; }
        private DirtyValue<decimal?> _originalIntRate;
        public decimal? OriginalIntRate { get => _originalIntRate; set => _originalIntRate = value; }
        private DirtyValue<string> _originateID;
        public string OriginateID { get => _originateID; set => _originateID = value; }
        private DirtyValue<StringEnumValue<PaymentFrequency>> _paymentFrequency;
        public StringEnumValue<PaymentFrequency> PaymentFrequency { get => _paymentFrequency; set => _paymentFrequency = value; }
        private DirtyValue<StringEnumValue<PaymentOption>> _paymentOption;
        public StringEnumValue<PaymentOption> PaymentOption { get => _paymentOption; set => _paymentOption = value; }
        private DirtyValue<decimal?> _personIncomeForSelfEmployment1;
        public decimal? PersonIncomeForSelfEmployment1 { get => _personIncomeForSelfEmployment1; set => _personIncomeForSelfEmployment1 = value; }
        private DirtyValue<decimal?> _personIncomeForSelfEmployment2;
        public decimal? PersonIncomeForSelfEmployment2 { get => _personIncomeForSelfEmployment2; set => _personIncomeForSelfEmployment2 = value; }
        private DirtyValue<int?> _personPercentOfBusinessOwned1;
        public int? PersonPercentOfBusinessOwned1 { get => _personPercentOfBusinessOwned1; set => _personPercentOfBusinessOwned1 = value; }
        private DirtyValue<int?> _personPercentOfBusinessOwned2;
        public int? PersonPercentOfBusinessOwned2 { get => _personPercentOfBusinessOwned2; set => _personPercentOfBusinessOwned2 = value; }
        private DirtyValue<StringEnumValue<PremiumSource>> _premiumSource;
        public StringEnumValue<PremiumSource> PremiumSource { get => _premiumSource; set => _premiumSource = value; }
        private DirtyValue<decimal?> _presentHousingExpense;
        public decimal? PresentHousingExpense { get => _presentHousingExpense; set => _presentHousingExpense = value; }
        private DirtyValue<StringEnumValue<ProcessingPoint>> _processingPoint;
        public StringEnumValue<ProcessingPoint> ProcessingPoint { get => _processingPoint; set => _processingPoint = value; }
        private DirtyValue<StringEnumValue<FreddieMacPropertyType>> _propertyType;
        public StringEnumValue<FreddieMacPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<StringEnumValue<FreddieMacPurposeOfLoan>> _purposeOfLoan;
        public StringEnumValue<FreddieMacPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => _purposeOfLoan = value; }
        private DirtyValue<StringEnumValue<RenewalOption>> _renewalOption;
        public StringEnumValue<RenewalOption> RenewalOption { get => _renewalOption; set => _renewalOption = value; }
        private DirtyValue<StringEnumValue<RenewalType>> _renewalType;
        public StringEnumValue<RenewalType> RenewalType { get => _renewalType; set => _renewalType = value; }
        private DirtyValue<StringEnumValue<RequiredDocumentType>> _requiredDocumentType;
        public StringEnumValue<RequiredDocumentType> RequiredDocumentType { get => _requiredDocumentType; set => _requiredDocumentType = value; }
        private DirtyValue<decimal?> _reserves;
        public decimal? Reserves { get => _reserves; set => _reserves = value; }
        private DirtyValue<bool?> _retailLoanIndicator;
        public bool? RetailLoanIndicator { get => _retailLoanIndicator; set => _retailLoanIndicator = value; }
        private DirtyValue<StringEnumValue<FreddieMacRiskClass>> _riskClass;
        public StringEnumValue<FreddieMacRiskClass> RiskClass { get => _riskClass; set => _riskClass = value; }
        private DirtyValue<StringEnumValue<RiskGradeEvaluationType>> _riskGradeEvaluationType;
        public StringEnumValue<RiskGradeEvaluationType> RiskGradeEvaluationType { get => _riskGradeEvaluationType; set => _riskGradeEvaluationType = value; }
        private DirtyValue<decimal?> _salesConcessions;
        public decimal? SalesConcessions { get => _salesConcessions; set => _salesConcessions = value; }
        private DirtyValue<StringEnumValue<SecondaryFinancingType>> _secondaryFinancingType;
        public StringEnumValue<SecondaryFinancingType> SecondaryFinancingType { get => _secondaryFinancingType; set => _secondaryFinancingType = value; }
        private DirtyValue<bool?> _secondTrustRefiIndicator;
        public bool? SecondTrustRefiIndicator { get => _secondTrustRefiIndicator; set => _secondTrustRefiIndicator = value; }
        private DirtyValue<decimal?> _simulatedPITI;
        public decimal? SimulatedPITI { get => _simulatedPITI; set => _simulatedPITI = value; }
        private DirtyValue<string> _sizeOfHousehold;
        public string SizeOfHousehold { get => _sizeOfHousehold; set => _sizeOfHousehold = value; }
        private DirtyValue<string> _specialInstruction1;
        public string SpecialInstruction1 { get => _specialInstruction1; set => _specialInstruction1 = value; }
        private DirtyValue<string> _specialInstruction2;
        public string SpecialInstruction2 { get => _specialInstruction2; set => _specialInstruction2 = value; }
        private DirtyValue<string> _specialInstruction3;
        public string SpecialInstruction3 { get => _specialInstruction3; set => _specialInstruction3 = value; }
        private DirtyValue<string> _specialInstruction4;
        public string SpecialInstruction4 { get => _specialInstruction4; set => _specialInstruction4 = value; }
        private DirtyValue<string> _specialInstruction5;
        public string SpecialInstruction5 { get => _specialInstruction5; set => _specialInstruction5 = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<bool?> _transferLoanToConduitIndicator;
        public bool? TransferLoanToConduitIndicator { get => _transferLoanToConduitIndicator; set => _transferLoanToConduitIndicator = value; }
        private DirtyValue<StringEnumValue<YearsOfCoverage>> _yearsOfCoverage;
        public StringEnumValue<YearsOfCoverage> YearsOfCoverage { get => _yearsOfCoverage; set => _yearsOfCoverage = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _affordableProduct.Dirty
                    || _alimonyAsIncomeReduction.Dirty
                    || _allMonthlyPayments.Dirty
                    || _allowsNegativeAmortizationIndicator.Dirty
                    || _amountOfFinancedMI.Dirty
                    || _aPNCity.Dirty
                    || _armsLengthTransactionIndicator.Dirty
                    || _borrowerQualifiesAsVeteranIndicator.Dirty
                    || _brokerOriginated.Dirty
                    || _buydownContributor.Dirty
                    || _condoClass.Dirty
                    || _convertibleFeeAmount.Dirty
                    || _convertibleFeePercent.Dirty
                    || _convertibleMaxRateAdjPercent.Dirty
                    || _convertibleMinRateAdjPercent.Dirty
                    || _county.Dirty
                    || _creditReportCompany.Dirty
                    || _financingConcessions.Dirty
                    || _freddieFiel11.Dirty
                    || _freddieFiel12.Dirty
                    || _freddieFiel13.Dirty
                    || _freddieFiel14.Dirty
                    || _freddieFiel15.Dirty
                    || _freddieField3.Dirty
                    || _freddieField7.Dirty
                    || _hELOCActualBalance.Dirty
                    || _hELOCCreditLimit.Dirty
                    || _id.Dirty
                    || _lenderAltPhone.Dirty
                    || _lenderRegistration.Dirty
                    || _loanProspectorID.Dirty
                    || _loanToConduitCode.Dirty
                    || _longLegalDescription.Dirty
                    || _lossCoverage.Dirty
                    || _lPKeyNumber.Dirty
                    || _mIRefundOption.Dirty
                    || _mortgageInsuranceCompany.Dirty
                    || _netPurchasePrice.Dirty
                    || _newConstructionType.Dirty
                    || _noAppraisalMAF.Dirty
                    || _nonOccupantNonHousingDebt.Dirty
                    || _nonOccupantPresentHE.Dirty
                    || _orderCreditEvaluationIndicator.Dirty
                    || _orderMergedCreditReportIndicator.Dirty
                    || _orderMortgageInsurance.Dirty
                    || _orderRiskGradeEvaluationIndicator.Dirty
                    || _originalIntRate.Dirty
                    || _originateID.Dirty
                    || _paymentFrequency.Dirty
                    || _paymentOption.Dirty
                    || _personIncomeForSelfEmployment1.Dirty
                    || _personIncomeForSelfEmployment2.Dirty
                    || _personPercentOfBusinessOwned1.Dirty
                    || _personPercentOfBusinessOwned2.Dirty
                    || _premiumSource.Dirty
                    || _presentHousingExpense.Dirty
                    || _processingPoint.Dirty
                    || _propertyType.Dirty
                    || _purposeOfLoan.Dirty
                    || _renewalOption.Dirty
                    || _renewalType.Dirty
                    || _requiredDocumentType.Dirty
                    || _reserves.Dirty
                    || _retailLoanIndicator.Dirty
                    || _riskClass.Dirty
                    || _riskGradeEvaluationType.Dirty
                    || _salesConcessions.Dirty
                    || _secondaryFinancingType.Dirty
                    || _secondTrustRefiIndicator.Dirty
                    || _simulatedPITI.Dirty
                    || _sizeOfHousehold.Dirty
                    || _specialInstruction1.Dirty
                    || _specialInstruction2.Dirty
                    || _specialInstruction3.Dirty
                    || _specialInstruction4.Dirty
                    || _specialInstruction5.Dirty
                    || _state.Dirty
                    || _transferLoanToConduitIndicator.Dirty
                    || _yearsOfCoverage.Dirty;
            }
            set
            {
                _affordableProduct.Dirty = value;
                _alimonyAsIncomeReduction.Dirty = value;
                _allMonthlyPayments.Dirty = value;
                _allowsNegativeAmortizationIndicator.Dirty = value;
                _amountOfFinancedMI.Dirty = value;
                _aPNCity.Dirty = value;
                _armsLengthTransactionIndicator.Dirty = value;
                _borrowerQualifiesAsVeteranIndicator.Dirty = value;
                _brokerOriginated.Dirty = value;
                _buydownContributor.Dirty = value;
                _condoClass.Dirty = value;
                _convertibleFeeAmount.Dirty = value;
                _convertibleFeePercent.Dirty = value;
                _convertibleMaxRateAdjPercent.Dirty = value;
                _convertibleMinRateAdjPercent.Dirty = value;
                _county.Dirty = value;
                _creditReportCompany.Dirty = value;
                _financingConcessions.Dirty = value;
                _freddieFiel11.Dirty = value;
                _freddieFiel12.Dirty = value;
                _freddieFiel13.Dirty = value;
                _freddieFiel14.Dirty = value;
                _freddieFiel15.Dirty = value;
                _freddieField3.Dirty = value;
                _freddieField7.Dirty = value;
                _hELOCActualBalance.Dirty = value;
                _hELOCCreditLimit.Dirty = value;
                _id.Dirty = value;
                _lenderAltPhone.Dirty = value;
                _lenderRegistration.Dirty = value;
                _loanProspectorID.Dirty = value;
                _loanToConduitCode.Dirty = value;
                _longLegalDescription.Dirty = value;
                _lossCoverage.Dirty = value;
                _lPKeyNumber.Dirty = value;
                _mIRefundOption.Dirty = value;
                _mortgageInsuranceCompany.Dirty = value;
                _netPurchasePrice.Dirty = value;
                _newConstructionType.Dirty = value;
                _noAppraisalMAF.Dirty = value;
                _nonOccupantNonHousingDebt.Dirty = value;
                _nonOccupantPresentHE.Dirty = value;
                _orderCreditEvaluationIndicator.Dirty = value;
                _orderMergedCreditReportIndicator.Dirty = value;
                _orderMortgageInsurance.Dirty = value;
                _orderRiskGradeEvaluationIndicator.Dirty = value;
                _originalIntRate.Dirty = value;
                _originateID.Dirty = value;
                _paymentFrequency.Dirty = value;
                _paymentOption.Dirty = value;
                _personIncomeForSelfEmployment1.Dirty = value;
                _personIncomeForSelfEmployment2.Dirty = value;
                _personPercentOfBusinessOwned1.Dirty = value;
                _personPercentOfBusinessOwned2.Dirty = value;
                _premiumSource.Dirty = value;
                _presentHousingExpense.Dirty = value;
                _processingPoint.Dirty = value;
                _propertyType.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _renewalOption.Dirty = value;
                _renewalType.Dirty = value;
                _requiredDocumentType.Dirty = value;
                _reserves.Dirty = value;
                _retailLoanIndicator.Dirty = value;
                _riskClass.Dirty = value;
                _riskGradeEvaluationType.Dirty = value;
                _salesConcessions.Dirty = value;
                _secondaryFinancingType.Dirty = value;
                _secondTrustRefiIndicator.Dirty = value;
                _simulatedPITI.Dirty = value;
                _sizeOfHousehold.Dirty = value;
                _specialInstruction1.Dirty = value;
                _specialInstruction2.Dirty = value;
                _specialInstruction3.Dirty = value;
                _specialInstruction4.Dirty = value;
                _specialInstruction5.Dirty = value;
                _state.Dirty = value;
                _transferLoanToConduitIndicator.Dirty = value;
                _yearsOfCoverage.Dirty = value;
            }
        }
    }
}