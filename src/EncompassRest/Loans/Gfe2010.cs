#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustedOriginationCharges;
        public decimal? AdjustedOriginationCharges { get => _adjustedOriginationCharges; set => _adjustedOriginationCharges = value; }
        private DirtyValue<decimal?> _allOtherServiceAmount;
        public decimal? AllOtherServiceAmount { get => _allOtherServiceAmount; set => _allOtherServiceAmount = value; }
        private DirtyValue<decimal?> _applicationFees;
        public decimal? ApplicationFees { get => _applicationFees; set => _applicationFees = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator10;
        public bool? BorrowerSelectIndicator10 { get => _borrowerSelectIndicator10; set => _borrowerSelectIndicator10 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator11;
        public bool? BorrowerSelectIndicator11 { get => _borrowerSelectIndicator11; set => _borrowerSelectIndicator11 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator12;
        public bool? BorrowerSelectIndicator12 { get => _borrowerSelectIndicator12; set => _borrowerSelectIndicator12 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator13;
        public bool? BorrowerSelectIndicator13 { get => _borrowerSelectIndicator13; set => _borrowerSelectIndicator13 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator14;
        public bool? BorrowerSelectIndicator14 { get => _borrowerSelectIndicator14; set => _borrowerSelectIndicator14 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator15;
        public bool? BorrowerSelectIndicator15 { get => _borrowerSelectIndicator15; set => _borrowerSelectIndicator15 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator16;
        public bool? BorrowerSelectIndicator16 { get => _borrowerSelectIndicator16; set => _borrowerSelectIndicator16 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator17;
        public bool? BorrowerSelectIndicator17 { get => _borrowerSelectIndicator17; set => _borrowerSelectIndicator17 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator18;
        public bool? BorrowerSelectIndicator18 { get => _borrowerSelectIndicator18; set => _borrowerSelectIndicator18 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator19;
        public bool? BorrowerSelectIndicator19 { get => _borrowerSelectIndicator19; set => _borrowerSelectIndicator19 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator2;
        public bool? BorrowerSelectIndicator2 { get => _borrowerSelectIndicator2; set => _borrowerSelectIndicator2 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator20;
        public bool? BorrowerSelectIndicator20 { get => _borrowerSelectIndicator20; set => _borrowerSelectIndicator20 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator3;
        public bool? BorrowerSelectIndicator3 { get => _borrowerSelectIndicator3; set => _borrowerSelectIndicator3 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator4;
        public bool? BorrowerSelectIndicator4 { get => _borrowerSelectIndicator4; set => _borrowerSelectIndicator4 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator5;
        public bool? BorrowerSelectIndicator5 { get => _borrowerSelectIndicator5; set => _borrowerSelectIndicator5 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator6;
        public bool? BorrowerSelectIndicator6 { get => _borrowerSelectIndicator6; set => _borrowerSelectIndicator6 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator7;
        public bool? BorrowerSelectIndicator7 { get => _borrowerSelectIndicator7; set => _borrowerSelectIndicator7 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator8;
        public bool? BorrowerSelectIndicator8 { get => _borrowerSelectIndicator8; set => _borrowerSelectIndicator8 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator9;
        public bool? BorrowerSelectIndicator9 { get => _borrowerSelectIndicator9; set => _borrowerSelectIndicator9 = value; }
        private DirtyValue<decimal?> _brokerAdditionalFees;
        public decimal? BrokerAdditionalFees { get => _brokerAdditionalFees; set => _brokerAdditionalFees = value; }
        private DirtyValue<decimal?> _brokerFees;
        public decimal? BrokerFees { get => _brokerFees; set => _brokerFees = value; }
        private DirtyValue<decimal?> _brokerFeesPercentage;
        public decimal? BrokerFeesPercentage { get => _brokerFeesPercentage; set => _brokerFeesPercentage = value; }
        private DirtyValue<decimal?> _chargeAmount;
        public decimal? ChargeAmount { get => _chargeAmount; set => _chargeAmount = value; }
        private DirtyValue<decimal?> _chargeAmountForPrint;
        public decimal? ChargeAmountForPrint { get => _chargeAmountForPrint; set => _chargeAmountForPrint = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator1;
        public bool? CopyFromGfeIndicator1 { get => _copyFromGfeIndicator1; set => _copyFromGfeIndicator1 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator10;
        public bool? CopyFromGfeIndicator10 { get => _copyFromGfeIndicator10; set => _copyFromGfeIndicator10 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator11;
        public bool? CopyFromGfeIndicator11 { get => _copyFromGfeIndicator11; set => _copyFromGfeIndicator11 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator12;
        public bool? CopyFromGfeIndicator12 { get => _copyFromGfeIndicator12; set => _copyFromGfeIndicator12 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator13;
        public bool? CopyFromGfeIndicator13 { get => _copyFromGfeIndicator13; set => _copyFromGfeIndicator13 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator14;
        public bool? CopyFromGfeIndicator14 { get => _copyFromGfeIndicator14; set => _copyFromGfeIndicator14 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator15;
        public bool? CopyFromGfeIndicator15 { get => _copyFromGfeIndicator15; set => _copyFromGfeIndicator15 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator16;
        public bool? CopyFromGfeIndicator16 { get => _copyFromGfeIndicator16; set => _copyFromGfeIndicator16 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator17;
        public bool? CopyFromGfeIndicator17 { get => _copyFromGfeIndicator17; set => _copyFromGfeIndicator17 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator18;
        public bool? CopyFromGfeIndicator18 { get => _copyFromGfeIndicator18; set => _copyFromGfeIndicator18 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator19;
        public bool? CopyFromGfeIndicator19 { get => _copyFromGfeIndicator19; set => _copyFromGfeIndicator19 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator2;
        public bool? CopyFromGfeIndicator2 { get => _copyFromGfeIndicator2; set => _copyFromGfeIndicator2 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator20;
        public bool? CopyFromGfeIndicator20 { get => _copyFromGfeIndicator20; set => _copyFromGfeIndicator20 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator21;
        public bool? CopyFromGfeIndicator21 { get => _copyFromGfeIndicator21; set => _copyFromGfeIndicator21 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator22;
        public bool? CopyFromGfeIndicator22 { get => _copyFromGfeIndicator22; set => _copyFromGfeIndicator22 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator23;
        public bool? CopyFromGfeIndicator23 { get => _copyFromGfeIndicator23; set => _copyFromGfeIndicator23 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator24;
        public bool? CopyFromGfeIndicator24 { get => _copyFromGfeIndicator24; set => _copyFromGfeIndicator24 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator25;
        public bool? CopyFromGfeIndicator25 { get => _copyFromGfeIndicator25; set => _copyFromGfeIndicator25 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator26;
        public bool? CopyFromGfeIndicator26 { get => _copyFromGfeIndicator26; set => _copyFromGfeIndicator26 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator27;
        public bool? CopyFromGfeIndicator27 { get => _copyFromGfeIndicator27; set => _copyFromGfeIndicator27 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator28;
        public bool? CopyFromGfeIndicator28 { get => _copyFromGfeIndicator28; set => _copyFromGfeIndicator28 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator29;
        public bool? CopyFromGfeIndicator29 { get => _copyFromGfeIndicator29; set => _copyFromGfeIndicator29 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator3;
        public bool? CopyFromGfeIndicator3 { get => _copyFromGfeIndicator3; set => _copyFromGfeIndicator3 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator30;
        public bool? CopyFromGfeIndicator30 { get => _copyFromGfeIndicator30; set => _copyFromGfeIndicator30 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator31;
        public bool? CopyFromGfeIndicator31 { get => _copyFromGfeIndicator31; set => _copyFromGfeIndicator31 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator32;
        public bool? CopyFromGfeIndicator32 { get => _copyFromGfeIndicator32; set => _copyFromGfeIndicator32 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator33;
        public bool? CopyFromGfeIndicator33 { get => _copyFromGfeIndicator33; set => _copyFromGfeIndicator33 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator34;
        public bool? CopyFromGfeIndicator34 { get => _copyFromGfeIndicator34; set => _copyFromGfeIndicator34 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator35;
        public bool? CopyFromGfeIndicator35 { get => _copyFromGfeIndicator35; set => _copyFromGfeIndicator35 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator4;
        public bool? CopyFromGfeIndicator4 { get => _copyFromGfeIndicator4; set => _copyFromGfeIndicator4 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator5;
        public bool? CopyFromGfeIndicator5 { get => _copyFromGfeIndicator5; set => _copyFromGfeIndicator5 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator6;
        public bool? CopyFromGfeIndicator6 { get => _copyFromGfeIndicator6; set => _copyFromGfeIndicator6 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator7;
        public bool? CopyFromGfeIndicator7 { get => _copyFromGfeIndicator7; set => _copyFromGfeIndicator7 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator8;
        public bool? CopyFromGfeIndicator8 { get => _copyFromGfeIndicator8; set => _copyFromGfeIndicator8 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator9;
        public bool? CopyFromGfeIndicator9 { get => _copyFromGfeIndicator9; set => _copyFromGfeIndicator9 = value; }
        private DirtyValue<decimal?> _creditAmount;
        public decimal? CreditAmount { get => _creditAmount; set => _creditAmount = value; }
        private DirtyValue<decimal?> _creditAmountForPrint;
        public decimal? CreditAmountForPrint { get => _creditAmountForPrint; set => _creditAmountForPrint = value; }
        private DirtyValue<StringEnumValue<CreditChargeType>> _creditChargeType;
        public StringEnumValue<CreditChargeType> CreditChargeType { get => _creditChargeType; set => _creditChargeType = value; }
        private DirtyValue<decimal?> _creditOrChange;
        public decimal? CreditOrChange { get => _creditOrChange; set => _creditOrChange = value; }
        private DirtyValue<decimal?> _curedAdjustedOriginationCharges;
        public decimal? CuredAdjustedOriginationCharges { get => _curedAdjustedOriginationCharges; set => _curedAdjustedOriginationCharges = value; }
        private DirtyValue<decimal?> _curedCreditOrChange;
        public decimal? CuredCreditOrChange { get => _curedCreditOrChange; set => _curedCreditOrChange = value; }
        private DirtyValue<decimal?> _curedOriginationCharges;
        public decimal? CuredOriginationCharges { get => _curedOriginationCharges; set => _curedOriginationCharges = value; }
        private DirtyValue<decimal?> _curedTotalTransferTaxes;
        public decimal? CuredTotalTransferTaxes { get => _curedTotalTransferTaxes; set => _curedTotalTransferTaxes = value; }
        private DirtyValue<decimal?> _dailyInterestCharges;
        public decimal? DailyInterestCharges { get => _dailyInterestCharges; set => _dailyInterestCharges = value; }
        private DirtyValue<DateTime?> _dateForCharges;
        public DateTime? DateForCharges { get => _dateForCharges; set => _dateForCharges = value; }
        private DirtyValue<string> _dateForRate;
        public string DateForRate { get => _dateForRate; set => _dateForRate = value; }
        private DirtyValue<string> _daysToSettlement;
        public string DaysToSettlement { get => _daysToSettlement; set => _daysToSettlement = value; }
        private DirtyValue<int?> _durationMonths;
        public int? DurationMonths { get => _durationMonths; set => _durationMonths = value; }
        private DirtyValue<bool?> _escrowChargeAllInsuranceIndicator;
        public bool? EscrowChargeAllInsuranceIndicator { get => _escrowChargeAllInsuranceIndicator; set => _escrowChargeAllInsuranceIndicator = value; }
        private DirtyValue<bool?> _escrowChargeAllPropertyTaxesIndicator;
        public bool? EscrowChargeAllPropertyTaxesIndicator { get => _escrowChargeAllPropertyTaxesIndicator; set => _escrowChargeAllPropertyTaxesIndicator = value; }
        private DirtyValue<bool?> _escrowChargeOtherIndicator;
        public bool? EscrowChargeOtherIndicator { get => _escrowChargeOtherIndicator; set => _escrowChargeOtherIndicator = value; }
        private DirtyValue<string> _escrowOtherDescription;
        public string EscrowOtherDescription { get => _escrowOtherDescription; set => _escrowOtherDescription = value; }
        private DirtyValue<decimal?> _financedFeesFromPrepaid;
        public decimal? FinancedFeesFromPrepaid { get => _financedFeesFromPrepaid; set => _financedFeesFromPrepaid = value; }
        private DirtyList<Gfe2010Fee> _gfe2010Fees;
        public IList<Gfe2010Fee> Gfe2010Fees { get => _gfe2010Fees ?? (_gfe2010Fees = new DirtyList<Gfe2010Fee>()); set => _gfe2010Fees = new DirtyList<Gfe2010Fee>(value); }
        private DirtyList<Gfe2010WholePoc> _gfe2010WholePocs;
        public IList<Gfe2010WholePoc> Gfe2010WholePocs { get => _gfe2010WholePocs ?? (_gfe2010WholePocs = new DirtyList<Gfe2010WholePoc>()); set => _gfe2010WholePocs = new DirtyList<Gfe2010WholePoc>(value); }
        private DirtyValue<decimal?> _gfeGovernmentRecordingCharges;
        public decimal? GfeGovernmentRecordingCharges { get => _gfeGovernmentRecordingCharges; set => _gfeGovernmentRecordingCharges = value; }
        private DirtyValue<decimal?> _hazardInsurance;
        public decimal? HazardInsurance { get => _hazardInsurance; set => _hazardInsurance = value; }
        private DirtyValue<decimal?> _homeownerInsurance;
        public decimal? HomeownerInsurance { get => _homeownerInsurance; set => _homeownerInsurance = value; }
        private DirtyValue<decimal?> _hudGuaranteeFee;
        public decimal? HudGuaranteeFee { get => _hudGuaranteeFee; set => _hudGuaranteeFee = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IncludeOriginationPointsCreditType>> _includeOriginationPointsCreditType;
        public StringEnumValue<IncludeOriginationPointsCreditType> IncludeOriginationPointsCreditType { get => _includeOriginationPointsCreditType; set => _includeOriginationPointsCreditType = value; }
        private DirtyValue<decimal?> _initialLoanAmount;
        public decimal? InitialLoanAmount { get => _initialLoanAmount; set => _initialLoanAmount = value; }
        private DirtyValue<decimal?> _initialMonthlyAmount;
        public decimal? InitialMonthlyAmount { get => _initialMonthlyAmount; set => _initialMonthlyAmount = value; }
        private DirtyValue<bool?> _interestRateRiseIndicator;
        public bool? InterestRateRiseIndicator { get => _interestRateRiseIndicator; set => _interestRateRiseIndicator = value; }
        private DirtyValue<bool?> _isCDValidForEarliestClosingDate;
        public bool? IsCDValidForEarliestClosingDate { get => _isCDValidForEarliestClosingDate; set => _isCDValidForEarliestClosingDate = value; }
        private DirtyValue<decimal?> _line1001Fee;
        public decimal? Line1001Fee { get => _line1001Fee; set => _line1001Fee = value; }
        private DirtyValue<decimal?> _line1002Fee;
        public decimal? Line1002Fee { get => _line1002Fee; set => _line1002Fee = value; }
        private DirtyValue<decimal?> _line1003Fee;
        public decimal? Line1003Fee { get => _line1003Fee; set => _line1003Fee = value; }
        private DirtyValue<decimal?> _line1004Fee;
        public decimal? Line1004Fee { get => _line1004Fee; set => _line1004Fee = value; }
        private DirtyValue<decimal?> _line1005Fee;
        public decimal? Line1005Fee { get => _line1005Fee; set => _line1005Fee = value; }
        private DirtyValue<decimal?> _line1006Fee;
        public decimal? Line1006Fee { get => _line1006Fee; set => _line1006Fee = value; }
        private DirtyValue<decimal?> _line1007Fee;
        public decimal? Line1007Fee { get => _line1007Fee; set => _line1007Fee = value; }
        private DirtyValue<decimal?> _line1008Fee;
        public decimal? Line1008Fee { get => _line1008Fee; set => _line1008Fee = value; }
        private DirtyValue<decimal?> _line1009Fee;
        public decimal? Line1009Fee { get => _line1009Fee; set => _line1009Fee = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationAdditionalAmount;
        public decimal? Line801BrokerCompensationAdditionalAmount { get => _line801BrokerCompensationAdditionalAmount; set => _line801BrokerCompensationAdditionalAmount = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationFees;
        public decimal? Line801BrokerCompensationFees { get => _line801BrokerCompensationFees; set => _line801BrokerCompensationFees = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationRate;
        public decimal? Line801BrokerCompensationRate { get => _line801BrokerCompensationRate; set => _line801BrokerCompensationRate = value; }
        private DirtyValue<decimal?> _line808Fee;
        public decimal? Line808Fee { get => _line808Fee; set => _line808Fee = value; }
        private DirtyValue<decimal?> _line809Fee;
        public decimal? Line809Fee { get => _line809Fee; set => _line809Fee = value; }
        private DirtyValue<decimal?> _line810Fee;
        public decimal? Line810Fee { get => _line810Fee; set => _line810Fee = value; }
        private DirtyValue<decimal?> _line811Fee;
        public decimal? Line811Fee { get => _line811Fee; set => _line811Fee = value; }
        private DirtyValue<decimal?> _line812Fee;
        public decimal? Line812Fee { get => _line812Fee; set => _line812Fee = value; }
        private DirtyValue<decimal?> _line813Fee;
        public decimal? Line813Fee { get => _line813Fee; set => _line813Fee = value; }
        private DirtyValue<decimal?> _line814Fee;
        public decimal? Line814Fee { get => _line814Fee; set => _line814Fee = value; }
        private DirtyValue<decimal?> _line815Fee;
        public decimal? Line815Fee { get => _line815Fee; set => _line815Fee = value; }
        private DirtyValue<decimal?> _line816Fee;
        public decimal? Line816Fee { get => _line816Fee; set => _line816Fee = value; }
        private DirtyValue<decimal?> _line817Fee;
        public decimal? Line817Fee { get => _line817Fee; set => _line817Fee = value; }
        private DirtyValue<decimal?> _line818Fee;
        public decimal? Line818Fee { get => _line818Fee; set => _line818Fee = value; }
        private DirtyValue<decimal?> _line819Fee;
        public decimal? Line819Fee { get => _line819Fee; set => _line819Fee = value; }
        private DirtyValue<decimal?> _line820Fee;
        public decimal? Line820Fee { get => _line820Fee; set => _line820Fee = value; }
        private DirtyValue<decimal?> _line821Fee;
        public decimal? Line821Fee { get => _line821Fee; set => _line821Fee = value; }
        private DirtyValue<decimal?> _line822Fee;
        public decimal? Line822Fee { get => _line822Fee; set => _line822Fee = value; }
        private DirtyValue<decimal?> _line823Fee;
        public decimal? Line823Fee { get => _line823Fee; set => _line823Fee = value; }
        private DirtyValue<decimal?> _line824Fee;
        public decimal? Line824Fee { get => _line824Fee; set => _line824Fee = value; }
        private DirtyValue<decimal?> _line825Fee;
        public decimal? Line825Fee { get => _line825Fee; set => _line825Fee = value; }
        private DirtyValue<decimal?> _line826Fee;
        public decimal? Line826Fee { get => _line826Fee; set => _line826Fee = value; }
        private DirtyValue<decimal?> _line827Fee;
        public decimal? Line827Fee { get => _line827Fee; set => _line827Fee = value; }
        private DirtyValue<decimal?> _line828Fee;
        public decimal? Line828Fee { get => _line828Fee; set => _line828Fee = value; }
        private DirtyValue<decimal?> _line829Fee;
        public decimal? Line829Fee { get => _line829Fee; set => _line829Fee = value; }
        private DirtyValue<decimal?> _line830Fee;
        public decimal? Line830Fee { get => _line830Fee; set => _line830Fee = value; }
        private DirtyValue<decimal?> _line831Fee;
        public decimal? Line831Fee { get => _line831Fee; set => _line831Fee = value; }
        private DirtyValue<decimal?> _line832Fee;
        public decimal? Line832Fee { get => _line832Fee; set => _line832Fee = value; }
        private DirtyValue<decimal?> _line833Fee;
        public decimal? Line833Fee { get => _line833Fee; set => _line833Fee = value; }
        private DirtyValue<bool?> _loanBalanceRiseIndicator;
        public bool? LoanBalanceRiseIndicator { get => _loanBalanceRiseIndicator; set => _loanBalanceRiseIndicator = value; }
        private DirtyValue<decimal?> _loanOriginationFees;
        public decimal? LoanOriginationFees { get => _loanOriginationFees; set => _loanOriginationFees = value; }
        private DirtyValue<decimal?> _loanOriginationPercentage;
        public decimal? LoanOriginationPercentage { get => _loanOriginationPercentage; set => _loanOriginationPercentage = value; }
        private DirtyValue<string> _loanOriginatorName;
        public string LoanOriginatorName { get => _loanOriginatorName; set => _loanOriginatorName = value; }
        private DirtyValue<decimal?> _lowerInterestInitialInterestRate;
        public decimal? LowerInterestInitialInterestRate { get => _lowerInterestInitialInterestRate; set => _lowerInterestInitialInterestRate = value; }
        private DirtyValue<decimal?> _lowerInterestInitialMonthlyAmountOwed;
        public decimal? LowerInterestInitialMonthlyAmountOwed { get => _lowerInterestInitialMonthlyAmountOwed; set => _lowerInterestInitialMonthlyAmountOwed = value; }
        private DirtyValue<decimal?> _lowerInterestMonthlyPaymentReduced;
        public decimal? LowerInterestMonthlyPaymentReduced { get => _lowerInterestMonthlyPaymentReduced; set => _lowerInterestMonthlyPaymentReduced = value; }
        private DirtyValue<decimal?> _lowerInterestServiceChargeIncreasedAmount;
        public decimal? LowerInterestServiceChargeIncreasedAmount { get => _lowerInterestServiceChargeIncreasedAmount; set => _lowerInterestServiceChargeIncreasedAmount = value; }
        private DirtyValue<decimal?> _lowerInterestTotalSettlementCharges;
        public decimal? LowerInterestTotalSettlementCharges { get => _lowerInterestTotalSettlementCharges; set => _lowerInterestTotalSettlementCharges = value; }
        private DirtyValue<decimal?> _lowerSettlementInitialInterestRate;
        public decimal? LowerSettlementInitialInterestRate { get => _lowerSettlementInitialInterestRate; set => _lowerSettlementInitialInterestRate = value; }
        private DirtyValue<decimal?> _lowerSettlementInitialMonthlyAmountOwed;
        public decimal? LowerSettlementInitialMonthlyAmountOwed { get => _lowerSettlementInitialMonthlyAmountOwed; set => _lowerSettlementInitialMonthlyAmountOwed = value; }
        private DirtyValue<decimal?> _lowerSettlementMonthlyPaymentIncreased;
        public decimal? LowerSettlementMonthlyPaymentIncreased { get => _lowerSettlementMonthlyPaymentIncreased; set => _lowerSettlementMonthlyPaymentIncreased = value; }
        private DirtyValue<decimal?> _lowerSettlementServiceChargeReducedAmount;
        public decimal? LowerSettlementServiceChargeReducedAmount { get => _lowerSettlementServiceChargeReducedAmount; set => _lowerSettlementServiceChargeReducedAmount = value; }
        private DirtyValue<decimal?> _lowerSettlementTotalSettlementCharges;
        public decimal? LowerSettlementTotalSettlementCharges { get => _lowerSettlementTotalSettlementCharges; set => _lowerSettlementTotalSettlementCharges = value; }
        private DirtyValue<decimal?> _maximumLoanBalance;
        public decimal? MaximumLoanBalance { get => _maximumLoanBalance; set => _maximumLoanBalance = value; }
        private DirtyValue<decimal?> _maximumOwedMonthlyPayment;
        public decimal? MaximumOwedMonthlyPayment { get => _maximumOwedMonthlyPayment; set => _maximumOwedMonthlyPayment = value; }
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => _maxLifeInterestCapPercent = value; }
        private DirtyValue<int?> _monthlyPaymentFirstIncreaseDate;
        public int? MonthlyPaymentFirstIncreaseDate { get => _monthlyPaymentFirstIncreaseDate; set => _monthlyPaymentFirstIncreaseDate = value; }
        private DirtyValue<bool?> _monthlyPaymentRiseIndicator;
        public bool? MonthlyPaymentRiseIndicator { get => _monthlyPaymentRiseIndicator; set => _monthlyPaymentRiseIndicator = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremium;
        public decimal? MortgageInsurancePremium { get => _mortgageInsurancePremium; set => _mortgageInsurancePremium = value; }
        private DirtyValue<string> _mustLockRateDays;
        public string MustLockRateDays { get => _mustLockRateDays; set => _mustLockRateDays = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1104BorPaidAmount;
        public decimal? NewHudSection1100Line1104BorPaidAmount { get => _newHudSection1100Line1104BorPaidAmount; set => _newHudSection1100Line1104BorPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1104SelPaidAmount;
        public decimal? NewHudSection1100Line1104SelPaidAmount { get => _newHudSection1100Line1104SelPaidAmount; set => _newHudSection1100Line1104SelPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1107BorPaidAmount;
        public decimal? NewHudSection1100Line1107BorPaidAmount { get => _newHudSection1100Line1107BorPaidAmount; set => _newHudSection1100Line1107BorPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1108BorPaidAmount;
        public decimal? NewHudSection1100Line1108BorPaidAmount { get => _newHudSection1100Line1108BorPaidAmount; set => _newHudSection1100Line1108BorPaidAmount = value; }
        private DirtyValue<decimal?> _originationCharges;
        public decimal? OriginationCharges { get => _originationCharges; set => _originationCharges = value; }
        private DirtyValue<decimal?> _originationCreditYsp;
        public decimal? OriginationCreditYsp { get => _originationCreditYsp; set => _originationCreditYsp = value; }
        private DirtyValue<decimal?> _originationCreditYspAdditional;
        public decimal? OriginationCreditYspAdditional { get => _originationCreditYspAdditional; set => _originationCreditYspAdditional = value; }
        private DirtyValue<decimal?> _originationPoints;
        public decimal? OriginationPoints { get => _originationPoints; set => _originationPoints = value; }
        private DirtyValue<decimal?> _originationPointsAdditional;
        public decimal? OriginationPointsAdditional { get => _originationPointsAdditional; set => _originationPointsAdditional = value; }
        private DirtyValue<decimal?> _originationPointsPercentage;
        public decimal? OriginationPointsPercentage { get => _originationPointsPercentage; set => _originationPointsPercentage = value; }
        private DirtyValue<NA<decimal>?> _ownerTitleInsuranceAmount;
        public NA<decimal>? OwnerTitleInsuranceAmount { get => _ownerTitleInsuranceAmount; set => _ownerTitleInsuranceAmount = value; }
        private DirtyValue<bool?> _printNAInLockRateDays;
        public bool? PrintNAInLockRateDays { get => _printNAInLockRateDays; set => _printNAInLockRateDays = value; }
        private DirtyValue<bool?> _printShoppingChartIndicator;
        public bool? PrintShoppingChartIndicator { get => _printShoppingChartIndicator; set => _printShoppingChartIndicator = value; }
        private DirtyValue<decimal?> _processingFees;
        public decimal? ProcessingFees { get => _processingFees; set => _processingFees = value; }
        private DirtyValue<decimal?> _requiredAppraisalFee;
        public decimal? RequiredAppraisalFee { get => _requiredAppraisalFee; set => _requiredAppraisalFee = value; }
        private DirtyValue<decimal?> _requiredCreditReportFee;
        public decimal? RequiredCreditReportFee { get => _requiredCreditReportFee; set => _requiredCreditReportFee = value; }
        private DirtyValue<decimal?> _requiredFloodCertificationFee;
        public decimal? RequiredFloodCertificationFee { get => _requiredFloodCertificationFee; set => _requiredFloodCertificationFee = value; }
        private DirtyValue<decimal?> _requiredServicesAmount;
        public decimal? RequiredServicesAmount { get => _requiredServicesAmount; set => _requiredServicesAmount = value; }
        private DirtyValue<decimal?> _requiredTaxServiceFee;
        public decimal? RequiredTaxServiceFee { get => _requiredTaxServiceFee; set => _requiredTaxServiceFee = value; }
        private DirtyValue<decimal?> _section1000TotalBorrowerPaidAmount;
        public decimal? Section1000TotalBorrowerPaidAmount { get => _section1000TotalBorrowerPaidAmount; set => _section1000TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalOtherPaidAmount;
        public decimal? Section1000TotalOtherPaidAmount { get => _section1000TotalOtherPaidAmount; set => _section1000TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalPaidAmount;
        public decimal? Section1000TotalPaidAmount { get => _section1000TotalPaidAmount; set => _section1000TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalSellerPaidAmount;
        public decimal? Section1000TotalSellerPaidAmount { get => _section1000TotalSellerPaidAmount; set => _section1000TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalBorrowerPaidAmount;
        public decimal? Section1100TotalBorrowerPaidAmount { get => _section1100TotalBorrowerPaidAmount; set => _section1100TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalOtherPaidAmount;
        public decimal? Section1100TotalOtherPaidAmount { get => _section1100TotalOtherPaidAmount; set => _section1100TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalPaidAmount;
        public decimal? Section1100TotalPaidAmount { get => _section1100TotalPaidAmount; set => _section1100TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalSellerPaidAmount;
        public decimal? Section1100TotalSellerPaidAmount { get => _section1100TotalSellerPaidAmount; set => _section1100TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalBorrowerPaidAmount;
        public decimal? Section1200TotalBorrowerPaidAmount { get => _section1200TotalBorrowerPaidAmount; set => _section1200TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalOtherPaidAmount;
        public decimal? Section1200TotalOtherPaidAmount { get => _section1200TotalOtherPaidAmount; set => _section1200TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalPaidAmount;
        public decimal? Section1200TotalPaidAmount { get => _section1200TotalPaidAmount; set => _section1200TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalSellerPaidAmount;
        public decimal? Section1200TotalSellerPaidAmount { get => _section1200TotalSellerPaidAmount; set => _section1200TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalBorrowerPaidAmount;
        public decimal? Section1300TotalBorrowerPaidAmount { get => _section1300TotalBorrowerPaidAmount; set => _section1300TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalOtherPaidAmount;
        public decimal? Section1300TotalOtherPaidAmount { get => _section1300TotalOtherPaidAmount; set => _section1300TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalPaidAmount;
        public decimal? Section1300TotalPaidAmount { get => _section1300TotalPaidAmount; set => _section1300TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalSellerPaidAmount;
        public decimal? Section1300TotalSellerPaidAmount { get => _section1300TotalSellerPaidAmount; set => _section1300TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalBorrowerPaidAmount;
        public decimal? Section1400TotalBorrowerPaidAmount { get => _section1400TotalBorrowerPaidAmount; set => _section1400TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalOtherPaidAmount;
        public decimal? Section1400TotalOtherPaidAmount { get => _section1400TotalOtherPaidAmount; set => _section1400TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalPaidAmount;
        public decimal? Section1400TotalPaidAmount { get => _section1400TotalPaidAmount; set => _section1400TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalSellerPaidAmount;
        public decimal? Section1400TotalSellerPaidAmount { get => _section1400TotalSellerPaidAmount; set => _section1400TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalBorrowerPaidAmount;
        public decimal? Section700TotalBorrowerPaidAmount { get => _section700TotalBorrowerPaidAmount; set => _section700TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalOtherPaidAmount;
        public decimal? Section700TotalOtherPaidAmount { get => _section700TotalOtherPaidAmount; set => _section700TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalPaidAmount;
        public decimal? Section700TotalPaidAmount { get => _section700TotalPaidAmount; set => _section700TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalSellerPaidAmount;
        public decimal? Section700TotalSellerPaidAmount { get => _section700TotalSellerPaidAmount; set => _section700TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalBorrowerPaidAmount;
        public decimal? Section800TotalBorrowerPaidAmount { get => _section800TotalBorrowerPaidAmount; set => _section800TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalOtherPaidAmount;
        public decimal? Section800TotalOtherPaidAmount { get => _section800TotalOtherPaidAmount; set => _section800TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalPaidAmount;
        public decimal? Section800TotalPaidAmount { get => _section800TotalPaidAmount; set => _section800TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalSellerPaidAmount;
        public decimal? Section800TotalSellerPaidAmount { get => _section800TotalSellerPaidAmount; set => _section800TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalBorrowerPaidAmount;
        public decimal? Section900TotalBorrowerPaidAmount { get => _section900TotalBorrowerPaidAmount; set => _section900TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalOtherPaidAmount;
        public decimal? Section900TotalOtherPaidAmount { get => _section900TotalOtherPaidAmount; set => _section900TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalPaidAmount;
        public decimal? Section900TotalPaidAmount { get => _section900TotalPaidAmount; set => _section900TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalSellerPaidAmount;
        public decimal? Section900TotalSellerPaidAmount { get => _section900TotalSellerPaidAmount; set => _section900TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _shopRequiredServicesAmount;
        public decimal? ShopRequiredServicesAmount { get => _shopRequiredServicesAmount; set => _shopRequiredServicesAmount = value; }
        private DirtyValue<decimal?> _subsequentCapPercent;
        public decimal? SubsequentCapPercent { get => _subsequentCapPercent; set => _subsequentCapPercent = value; }
        private DirtyValue<int?> _subsequentRateAdjustmentMonths;
        public int? SubsequentRateAdjustmentMonths { get => _subsequentRateAdjustmentMonths; set => _subsequentRateAdjustmentMonths = value; }
        private DirtyValue<bool?> _tableFundedIndicator;
        public bool? TableFundedIndicator { get => _tableFundedIndicator; set => _tableFundedIndicator = value; }
        private DirtyValue<string> _timeForRate;
        public string TimeForRate { get => _timeForRate; set => _timeForRate = value; }
        private DirtyValue<decimal?> _titleServiceAmount;
        public decimal? TitleServiceAmount { get => _titleServiceAmount; set => _titleServiceAmount = value; }
        private DirtyValue<decimal?> _totalBelow10;
        public decimal? TotalBelow10 { get => _totalBelow10; set => _totalBelow10 = value; }
        private DirtyValue<decimal?> _totalOfFinancedFees;
        public decimal? TotalOfFinancedFees { get => _totalOfFinancedFees; set => _totalOfFinancedFees = value; }
        private DirtyValue<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => _totalSettlementCharges = value; }
        private DirtyValue<decimal?> _totalTransferTaxes;
        public decimal? TotalTransferTaxes { get => _totalTransferTaxes; set => _totalTransferTaxes = value; }
        private DirtyValue<decimal?> _transferTaxes;
        public decimal? TransferTaxes { get => _transferTaxes; set => _transferTaxes = value; }
        private DirtyValue<decimal?> _underwritingFees;
        public decimal? UnderwritingFees { get => _underwritingFees; set => _underwritingFees = value; }
        private DirtyValue<bool?> _useLOCompTool;
        public bool? UseLOCompTool { get => _useLOCompTool; set => _useLOCompTool = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustedOriginationCharges.Dirty
                    || _allOtherServiceAmount.Dirty
                    || _applicationFees.Dirty
                    || _borrowerSelectIndicator10.Dirty
                    || _borrowerSelectIndicator11.Dirty
                    || _borrowerSelectIndicator12.Dirty
                    || _borrowerSelectIndicator13.Dirty
                    || _borrowerSelectIndicator14.Dirty
                    || _borrowerSelectIndicator15.Dirty
                    || _borrowerSelectIndicator16.Dirty
                    || _borrowerSelectIndicator17.Dirty
                    || _borrowerSelectIndicator18.Dirty
                    || _borrowerSelectIndicator19.Dirty
                    || _borrowerSelectIndicator2.Dirty
                    || _borrowerSelectIndicator20.Dirty
                    || _borrowerSelectIndicator3.Dirty
                    || _borrowerSelectIndicator4.Dirty
                    || _borrowerSelectIndicator5.Dirty
                    || _borrowerSelectIndicator6.Dirty
                    || _borrowerSelectIndicator7.Dirty
                    || _borrowerSelectIndicator8.Dirty
                    || _borrowerSelectIndicator9.Dirty
                    || _brokerAdditionalFees.Dirty
                    || _brokerFees.Dirty
                    || _brokerFeesPercentage.Dirty
                    || _chargeAmount.Dirty
                    || _chargeAmountForPrint.Dirty
                    || _copyFromGfeIndicator1.Dirty
                    || _copyFromGfeIndicator10.Dirty
                    || _copyFromGfeIndicator11.Dirty
                    || _copyFromGfeIndicator12.Dirty
                    || _copyFromGfeIndicator13.Dirty
                    || _copyFromGfeIndicator14.Dirty
                    || _copyFromGfeIndicator15.Dirty
                    || _copyFromGfeIndicator16.Dirty
                    || _copyFromGfeIndicator17.Dirty
                    || _copyFromGfeIndicator18.Dirty
                    || _copyFromGfeIndicator19.Dirty
                    || _copyFromGfeIndicator2.Dirty
                    || _copyFromGfeIndicator20.Dirty
                    || _copyFromGfeIndicator21.Dirty
                    || _copyFromGfeIndicator22.Dirty
                    || _copyFromGfeIndicator23.Dirty
                    || _copyFromGfeIndicator24.Dirty
                    || _copyFromGfeIndicator25.Dirty
                    || _copyFromGfeIndicator26.Dirty
                    || _copyFromGfeIndicator27.Dirty
                    || _copyFromGfeIndicator28.Dirty
                    || _copyFromGfeIndicator29.Dirty
                    || _copyFromGfeIndicator3.Dirty
                    || _copyFromGfeIndicator30.Dirty
                    || _copyFromGfeIndicator31.Dirty
                    || _copyFromGfeIndicator32.Dirty
                    || _copyFromGfeIndicator33.Dirty
                    || _copyFromGfeIndicator34.Dirty
                    || _copyFromGfeIndicator35.Dirty
                    || _copyFromGfeIndicator4.Dirty
                    || _copyFromGfeIndicator5.Dirty
                    || _copyFromGfeIndicator6.Dirty
                    || _copyFromGfeIndicator7.Dirty
                    || _copyFromGfeIndicator8.Dirty
                    || _copyFromGfeIndicator9.Dirty
                    || _creditAmount.Dirty
                    || _creditAmountForPrint.Dirty
                    || _creditChargeType.Dirty
                    || _creditOrChange.Dirty
                    || _curedAdjustedOriginationCharges.Dirty
                    || _curedCreditOrChange.Dirty
                    || _curedOriginationCharges.Dirty
                    || _curedTotalTransferTaxes.Dirty
                    || _dailyInterestCharges.Dirty
                    || _dateForCharges.Dirty
                    || _dateForRate.Dirty
                    || _daysToSettlement.Dirty
                    || _durationMonths.Dirty
                    || _escrowChargeAllInsuranceIndicator.Dirty
                    || _escrowChargeAllPropertyTaxesIndicator.Dirty
                    || _escrowChargeOtherIndicator.Dirty
                    || _escrowOtherDescription.Dirty
                    || _financedFeesFromPrepaid.Dirty
                    || _gfeGovernmentRecordingCharges.Dirty
                    || _hazardInsurance.Dirty
                    || _homeownerInsurance.Dirty
                    || _hudGuaranteeFee.Dirty
                    || _id.Dirty
                    || _includeOriginationPointsCreditType.Dirty
                    || _initialLoanAmount.Dirty
                    || _initialMonthlyAmount.Dirty
                    || _interestRateRiseIndicator.Dirty
                    || _isCDValidForEarliestClosingDate.Dirty
                    || _line1001Fee.Dirty
                    || _line1002Fee.Dirty
                    || _line1003Fee.Dirty
                    || _line1004Fee.Dirty
                    || _line1005Fee.Dirty
                    || _line1006Fee.Dirty
                    || _line1007Fee.Dirty
                    || _line1008Fee.Dirty
                    || _line1009Fee.Dirty
                    || _line801BrokerCompensationAdditionalAmount.Dirty
                    || _line801BrokerCompensationFees.Dirty
                    || _line801BrokerCompensationRate.Dirty
                    || _line808Fee.Dirty
                    || _line809Fee.Dirty
                    || _line810Fee.Dirty
                    || _line811Fee.Dirty
                    || _line812Fee.Dirty
                    || _line813Fee.Dirty
                    || _line814Fee.Dirty
                    || _line815Fee.Dirty
                    || _line816Fee.Dirty
                    || _line817Fee.Dirty
                    || _line818Fee.Dirty
                    || _line819Fee.Dirty
                    || _line820Fee.Dirty
                    || _line821Fee.Dirty
                    || _line822Fee.Dirty
                    || _line823Fee.Dirty
                    || _line824Fee.Dirty
                    || _line825Fee.Dirty
                    || _line826Fee.Dirty
                    || _line827Fee.Dirty
                    || _line828Fee.Dirty
                    || _line829Fee.Dirty
                    || _line830Fee.Dirty
                    || _line831Fee.Dirty
                    || _line832Fee.Dirty
                    || _line833Fee.Dirty
                    || _loanBalanceRiseIndicator.Dirty
                    || _loanOriginationFees.Dirty
                    || _loanOriginationPercentage.Dirty
                    || _loanOriginatorName.Dirty
                    || _lowerInterestInitialInterestRate.Dirty
                    || _lowerInterestInitialMonthlyAmountOwed.Dirty
                    || _lowerInterestMonthlyPaymentReduced.Dirty
                    || _lowerInterestServiceChargeIncreasedAmount.Dirty
                    || _lowerInterestTotalSettlementCharges.Dirty
                    || _lowerSettlementInitialInterestRate.Dirty
                    || _lowerSettlementInitialMonthlyAmountOwed.Dirty
                    || _lowerSettlementMonthlyPaymentIncreased.Dirty
                    || _lowerSettlementServiceChargeReducedAmount.Dirty
                    || _lowerSettlementTotalSettlementCharges.Dirty
                    || _maximumLoanBalance.Dirty
                    || _maximumOwedMonthlyPayment.Dirty
                    || _maxLifeInterestCapPercent.Dirty
                    || _monthlyPaymentFirstIncreaseDate.Dirty
                    || _monthlyPaymentRiseIndicator.Dirty
                    || _mortgageInsurancePremium.Dirty
                    || _mustLockRateDays.Dirty
                    || _newHudSection1100Line1104BorPaidAmount.Dirty
                    || _newHudSection1100Line1104SelPaidAmount.Dirty
                    || _newHudSection1100Line1107BorPaidAmount.Dirty
                    || _newHudSection1100Line1108BorPaidAmount.Dirty
                    || _originationCharges.Dirty
                    || _originationCreditYsp.Dirty
                    || _originationCreditYspAdditional.Dirty
                    || _originationPoints.Dirty
                    || _originationPointsAdditional.Dirty
                    || _originationPointsPercentage.Dirty
                    || _ownerTitleInsuranceAmount.Dirty
                    || _printNAInLockRateDays.Dirty
                    || _printShoppingChartIndicator.Dirty
                    || _processingFees.Dirty
                    || _requiredAppraisalFee.Dirty
                    || _requiredCreditReportFee.Dirty
                    || _requiredFloodCertificationFee.Dirty
                    || _requiredServicesAmount.Dirty
                    || _requiredTaxServiceFee.Dirty
                    || _section1000TotalBorrowerPaidAmount.Dirty
                    || _section1000TotalOtherPaidAmount.Dirty
                    || _section1000TotalPaidAmount.Dirty
                    || _section1000TotalSellerPaidAmount.Dirty
                    || _section1100TotalBorrowerPaidAmount.Dirty
                    || _section1100TotalOtherPaidAmount.Dirty
                    || _section1100TotalPaidAmount.Dirty
                    || _section1100TotalSellerPaidAmount.Dirty
                    || _section1200TotalBorrowerPaidAmount.Dirty
                    || _section1200TotalOtherPaidAmount.Dirty
                    || _section1200TotalPaidAmount.Dirty
                    || _section1200TotalSellerPaidAmount.Dirty
                    || _section1300TotalBorrowerPaidAmount.Dirty
                    || _section1300TotalOtherPaidAmount.Dirty
                    || _section1300TotalPaidAmount.Dirty
                    || _section1300TotalSellerPaidAmount.Dirty
                    || _section1400TotalBorrowerPaidAmount.Dirty
                    || _section1400TotalOtherPaidAmount.Dirty
                    || _section1400TotalPaidAmount.Dirty
                    || _section1400TotalSellerPaidAmount.Dirty
                    || _section700TotalBorrowerPaidAmount.Dirty
                    || _section700TotalOtherPaidAmount.Dirty
                    || _section700TotalPaidAmount.Dirty
                    || _section700TotalSellerPaidAmount.Dirty
                    || _section800TotalBorrowerPaidAmount.Dirty
                    || _section800TotalOtherPaidAmount.Dirty
                    || _section800TotalPaidAmount.Dirty
                    || _section800TotalSellerPaidAmount.Dirty
                    || _section900TotalBorrowerPaidAmount.Dirty
                    || _section900TotalOtherPaidAmount.Dirty
                    || _section900TotalPaidAmount.Dirty
                    || _section900TotalSellerPaidAmount.Dirty
                    || _shopRequiredServicesAmount.Dirty
                    || _subsequentCapPercent.Dirty
                    || _subsequentRateAdjustmentMonths.Dirty
                    || _tableFundedIndicator.Dirty
                    || _timeForRate.Dirty
                    || _titleServiceAmount.Dirty
                    || _totalBelow10.Dirty
                    || _totalOfFinancedFees.Dirty
                    || _totalSettlementCharges.Dirty
                    || _totalTransferTaxes.Dirty
                    || _transferTaxes.Dirty
                    || _underwritingFees.Dirty
                    || _useLOCompTool.Dirty
                    || _gfe2010Fees?.Dirty == true
                    || _gfe2010WholePocs?.Dirty == true;
            }
            set
            {
                _adjustedOriginationCharges.Dirty = value;
                _allOtherServiceAmount.Dirty = value;
                _applicationFees.Dirty = value;
                _borrowerSelectIndicator10.Dirty = value;
                _borrowerSelectIndicator11.Dirty = value;
                _borrowerSelectIndicator12.Dirty = value;
                _borrowerSelectIndicator13.Dirty = value;
                _borrowerSelectIndicator14.Dirty = value;
                _borrowerSelectIndicator15.Dirty = value;
                _borrowerSelectIndicator16.Dirty = value;
                _borrowerSelectIndicator17.Dirty = value;
                _borrowerSelectIndicator18.Dirty = value;
                _borrowerSelectIndicator19.Dirty = value;
                _borrowerSelectIndicator2.Dirty = value;
                _borrowerSelectIndicator20.Dirty = value;
                _borrowerSelectIndicator3.Dirty = value;
                _borrowerSelectIndicator4.Dirty = value;
                _borrowerSelectIndicator5.Dirty = value;
                _borrowerSelectIndicator6.Dirty = value;
                _borrowerSelectIndicator7.Dirty = value;
                _borrowerSelectIndicator8.Dirty = value;
                _borrowerSelectIndicator9.Dirty = value;
                _brokerAdditionalFees.Dirty = value;
                _brokerFees.Dirty = value;
                _brokerFeesPercentage.Dirty = value;
                _chargeAmount.Dirty = value;
                _chargeAmountForPrint.Dirty = value;
                _copyFromGfeIndicator1.Dirty = value;
                _copyFromGfeIndicator10.Dirty = value;
                _copyFromGfeIndicator11.Dirty = value;
                _copyFromGfeIndicator12.Dirty = value;
                _copyFromGfeIndicator13.Dirty = value;
                _copyFromGfeIndicator14.Dirty = value;
                _copyFromGfeIndicator15.Dirty = value;
                _copyFromGfeIndicator16.Dirty = value;
                _copyFromGfeIndicator17.Dirty = value;
                _copyFromGfeIndicator18.Dirty = value;
                _copyFromGfeIndicator19.Dirty = value;
                _copyFromGfeIndicator2.Dirty = value;
                _copyFromGfeIndicator20.Dirty = value;
                _copyFromGfeIndicator21.Dirty = value;
                _copyFromGfeIndicator22.Dirty = value;
                _copyFromGfeIndicator23.Dirty = value;
                _copyFromGfeIndicator24.Dirty = value;
                _copyFromGfeIndicator25.Dirty = value;
                _copyFromGfeIndicator26.Dirty = value;
                _copyFromGfeIndicator27.Dirty = value;
                _copyFromGfeIndicator28.Dirty = value;
                _copyFromGfeIndicator29.Dirty = value;
                _copyFromGfeIndicator3.Dirty = value;
                _copyFromGfeIndicator30.Dirty = value;
                _copyFromGfeIndicator31.Dirty = value;
                _copyFromGfeIndicator32.Dirty = value;
                _copyFromGfeIndicator33.Dirty = value;
                _copyFromGfeIndicator34.Dirty = value;
                _copyFromGfeIndicator35.Dirty = value;
                _copyFromGfeIndicator4.Dirty = value;
                _copyFromGfeIndicator5.Dirty = value;
                _copyFromGfeIndicator6.Dirty = value;
                _copyFromGfeIndicator7.Dirty = value;
                _copyFromGfeIndicator8.Dirty = value;
                _copyFromGfeIndicator9.Dirty = value;
                _creditAmount.Dirty = value;
                _creditAmountForPrint.Dirty = value;
                _creditChargeType.Dirty = value;
                _creditOrChange.Dirty = value;
                _curedAdjustedOriginationCharges.Dirty = value;
                _curedCreditOrChange.Dirty = value;
                _curedOriginationCharges.Dirty = value;
                _curedTotalTransferTaxes.Dirty = value;
                _dailyInterestCharges.Dirty = value;
                _dateForCharges.Dirty = value;
                _dateForRate.Dirty = value;
                _daysToSettlement.Dirty = value;
                _durationMonths.Dirty = value;
                _escrowChargeAllInsuranceIndicator.Dirty = value;
                _escrowChargeAllPropertyTaxesIndicator.Dirty = value;
                _escrowChargeOtherIndicator.Dirty = value;
                _escrowOtherDescription.Dirty = value;
                _financedFeesFromPrepaid.Dirty = value;
                _gfeGovernmentRecordingCharges.Dirty = value;
                _hazardInsurance.Dirty = value;
                _homeownerInsurance.Dirty = value;
                _hudGuaranteeFee.Dirty = value;
                _id.Dirty = value;
                _includeOriginationPointsCreditType.Dirty = value;
                _initialLoanAmount.Dirty = value;
                _initialMonthlyAmount.Dirty = value;
                _interestRateRiseIndicator.Dirty = value;
                _isCDValidForEarliestClosingDate.Dirty = value;
                _line1001Fee.Dirty = value;
                _line1002Fee.Dirty = value;
                _line1003Fee.Dirty = value;
                _line1004Fee.Dirty = value;
                _line1005Fee.Dirty = value;
                _line1006Fee.Dirty = value;
                _line1007Fee.Dirty = value;
                _line1008Fee.Dirty = value;
                _line1009Fee.Dirty = value;
                _line801BrokerCompensationAdditionalAmount.Dirty = value;
                _line801BrokerCompensationFees.Dirty = value;
                _line801BrokerCompensationRate.Dirty = value;
                _line808Fee.Dirty = value;
                _line809Fee.Dirty = value;
                _line810Fee.Dirty = value;
                _line811Fee.Dirty = value;
                _line812Fee.Dirty = value;
                _line813Fee.Dirty = value;
                _line814Fee.Dirty = value;
                _line815Fee.Dirty = value;
                _line816Fee.Dirty = value;
                _line817Fee.Dirty = value;
                _line818Fee.Dirty = value;
                _line819Fee.Dirty = value;
                _line820Fee.Dirty = value;
                _line821Fee.Dirty = value;
                _line822Fee.Dirty = value;
                _line823Fee.Dirty = value;
                _line824Fee.Dirty = value;
                _line825Fee.Dirty = value;
                _line826Fee.Dirty = value;
                _line827Fee.Dirty = value;
                _line828Fee.Dirty = value;
                _line829Fee.Dirty = value;
                _line830Fee.Dirty = value;
                _line831Fee.Dirty = value;
                _line832Fee.Dirty = value;
                _line833Fee.Dirty = value;
                _loanBalanceRiseIndicator.Dirty = value;
                _loanOriginationFees.Dirty = value;
                _loanOriginationPercentage.Dirty = value;
                _loanOriginatorName.Dirty = value;
                _lowerInterestInitialInterestRate.Dirty = value;
                _lowerInterestInitialMonthlyAmountOwed.Dirty = value;
                _lowerInterestMonthlyPaymentReduced.Dirty = value;
                _lowerInterestServiceChargeIncreasedAmount.Dirty = value;
                _lowerInterestTotalSettlementCharges.Dirty = value;
                _lowerSettlementInitialInterestRate.Dirty = value;
                _lowerSettlementInitialMonthlyAmountOwed.Dirty = value;
                _lowerSettlementMonthlyPaymentIncreased.Dirty = value;
                _lowerSettlementServiceChargeReducedAmount.Dirty = value;
                _lowerSettlementTotalSettlementCharges.Dirty = value;
                _maximumLoanBalance.Dirty = value;
                _maximumOwedMonthlyPayment.Dirty = value;
                _maxLifeInterestCapPercent.Dirty = value;
                _monthlyPaymentFirstIncreaseDate.Dirty = value;
                _monthlyPaymentRiseIndicator.Dirty = value;
                _mortgageInsurancePremium.Dirty = value;
                _mustLockRateDays.Dirty = value;
                _newHudSection1100Line1104BorPaidAmount.Dirty = value;
                _newHudSection1100Line1104SelPaidAmount.Dirty = value;
                _newHudSection1100Line1107BorPaidAmount.Dirty = value;
                _newHudSection1100Line1108BorPaidAmount.Dirty = value;
                _originationCharges.Dirty = value;
                _originationCreditYsp.Dirty = value;
                _originationCreditYspAdditional.Dirty = value;
                _originationPoints.Dirty = value;
                _originationPointsAdditional.Dirty = value;
                _originationPointsPercentage.Dirty = value;
                _ownerTitleInsuranceAmount.Dirty = value;
                _printNAInLockRateDays.Dirty = value;
                _printShoppingChartIndicator.Dirty = value;
                _processingFees.Dirty = value;
                _requiredAppraisalFee.Dirty = value;
                _requiredCreditReportFee.Dirty = value;
                _requiredFloodCertificationFee.Dirty = value;
                _requiredServicesAmount.Dirty = value;
                _requiredTaxServiceFee.Dirty = value;
                _section1000TotalBorrowerPaidAmount.Dirty = value;
                _section1000TotalOtherPaidAmount.Dirty = value;
                _section1000TotalPaidAmount.Dirty = value;
                _section1000TotalSellerPaidAmount.Dirty = value;
                _section1100TotalBorrowerPaidAmount.Dirty = value;
                _section1100TotalOtherPaidAmount.Dirty = value;
                _section1100TotalPaidAmount.Dirty = value;
                _section1100TotalSellerPaidAmount.Dirty = value;
                _section1200TotalBorrowerPaidAmount.Dirty = value;
                _section1200TotalOtherPaidAmount.Dirty = value;
                _section1200TotalPaidAmount.Dirty = value;
                _section1200TotalSellerPaidAmount.Dirty = value;
                _section1300TotalBorrowerPaidAmount.Dirty = value;
                _section1300TotalOtherPaidAmount.Dirty = value;
                _section1300TotalPaidAmount.Dirty = value;
                _section1300TotalSellerPaidAmount.Dirty = value;
                _section1400TotalBorrowerPaidAmount.Dirty = value;
                _section1400TotalOtherPaidAmount.Dirty = value;
                _section1400TotalPaidAmount.Dirty = value;
                _section1400TotalSellerPaidAmount.Dirty = value;
                _section700TotalBorrowerPaidAmount.Dirty = value;
                _section700TotalOtherPaidAmount.Dirty = value;
                _section700TotalPaidAmount.Dirty = value;
                _section700TotalSellerPaidAmount.Dirty = value;
                _section800TotalBorrowerPaidAmount.Dirty = value;
                _section800TotalOtherPaidAmount.Dirty = value;
                _section800TotalPaidAmount.Dirty = value;
                _section800TotalSellerPaidAmount.Dirty = value;
                _section900TotalBorrowerPaidAmount.Dirty = value;
                _section900TotalOtherPaidAmount.Dirty = value;
                _section900TotalPaidAmount.Dirty = value;
                _section900TotalSellerPaidAmount.Dirty = value;
                _shopRequiredServicesAmount.Dirty = value;
                _subsequentCapPercent.Dirty = value;
                _subsequentRateAdjustmentMonths.Dirty = value;
                _tableFundedIndicator.Dirty = value;
                _timeForRate.Dirty = value;
                _titleServiceAmount.Dirty = value;
                _totalBelow10.Dirty = value;
                _totalOfFinancedFees.Dirty = value;
                _totalSettlementCharges.Dirty = value;
                _totalTransferTaxes.Dirty = value;
                _transferTaxes.Dirty = value;
                _underwritingFees.Dirty = value;
                _useLOCompTool.Dirty = value;
                if (_gfe2010Fees != null) _gfe2010Fees.Dirty = value;
                if (_gfe2010WholePocs != null) _gfe2010WholePocs.Dirty = value;
            }
        }
    }
}