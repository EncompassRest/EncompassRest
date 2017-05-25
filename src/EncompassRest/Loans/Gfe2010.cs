using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010 : IClean
    {
        private Value<decimal?> _adjustedOriginationCharges;
        public decimal? AdjustedOriginationCharges { get { return _adjustedOriginationCharges; } set { _adjustedOriginationCharges = value; } }
        private Value<decimal?> _allOtherServiceAmount;
        public decimal? AllOtherServiceAmount { get { return _allOtherServiceAmount; } set { _allOtherServiceAmount = value; } }
        private Value<decimal?> _applicationFees;
        public decimal? ApplicationFees { get { return _applicationFees; } set { _applicationFees = value; } }
        private Value<bool?> _borrowerSelectIndicator10;
        public bool? BorrowerSelectIndicator10 { get { return _borrowerSelectIndicator10; } set { _borrowerSelectIndicator10 = value; } }
        private Value<bool?> _borrowerSelectIndicator11;
        public bool? BorrowerSelectIndicator11 { get { return _borrowerSelectIndicator11; } set { _borrowerSelectIndicator11 = value; } }
        private Value<bool?> _borrowerSelectIndicator12;
        public bool? BorrowerSelectIndicator12 { get { return _borrowerSelectIndicator12; } set { _borrowerSelectIndicator12 = value; } }
        private Value<bool?> _borrowerSelectIndicator13;
        public bool? BorrowerSelectIndicator13 { get { return _borrowerSelectIndicator13; } set { _borrowerSelectIndicator13 = value; } }
        private Value<bool?> _borrowerSelectIndicator14;
        public bool? BorrowerSelectIndicator14 { get { return _borrowerSelectIndicator14; } set { _borrowerSelectIndicator14 = value; } }
        private Value<bool?> _borrowerSelectIndicator15;
        public bool? BorrowerSelectIndicator15 { get { return _borrowerSelectIndicator15; } set { _borrowerSelectIndicator15 = value; } }
        private Value<bool?> _borrowerSelectIndicator16;
        public bool? BorrowerSelectIndicator16 { get { return _borrowerSelectIndicator16; } set { _borrowerSelectIndicator16 = value; } }
        private Value<bool?> _borrowerSelectIndicator17;
        public bool? BorrowerSelectIndicator17 { get { return _borrowerSelectIndicator17; } set { _borrowerSelectIndicator17 = value; } }
        private Value<bool?> _borrowerSelectIndicator18;
        public bool? BorrowerSelectIndicator18 { get { return _borrowerSelectIndicator18; } set { _borrowerSelectIndicator18 = value; } }
        private Value<bool?> _borrowerSelectIndicator19;
        public bool? BorrowerSelectIndicator19 { get { return _borrowerSelectIndicator19; } set { _borrowerSelectIndicator19 = value; } }
        private Value<bool?> _borrowerSelectIndicator2;
        public bool? BorrowerSelectIndicator2 { get { return _borrowerSelectIndicator2; } set { _borrowerSelectIndicator2 = value; } }
        private Value<bool?> _borrowerSelectIndicator20;
        public bool? BorrowerSelectIndicator20 { get { return _borrowerSelectIndicator20; } set { _borrowerSelectIndicator20 = value; } }
        private Value<bool?> _borrowerSelectIndicator3;
        public bool? BorrowerSelectIndicator3 { get { return _borrowerSelectIndicator3; } set { _borrowerSelectIndicator3 = value; } }
        private Value<bool?> _borrowerSelectIndicator4;
        public bool? BorrowerSelectIndicator4 { get { return _borrowerSelectIndicator4; } set { _borrowerSelectIndicator4 = value; } }
        private Value<bool?> _borrowerSelectIndicator5;
        public bool? BorrowerSelectIndicator5 { get { return _borrowerSelectIndicator5; } set { _borrowerSelectIndicator5 = value; } }
        private Value<bool?> _borrowerSelectIndicator6;
        public bool? BorrowerSelectIndicator6 { get { return _borrowerSelectIndicator6; } set { _borrowerSelectIndicator6 = value; } }
        private Value<bool?> _borrowerSelectIndicator7;
        public bool? BorrowerSelectIndicator7 { get { return _borrowerSelectIndicator7; } set { _borrowerSelectIndicator7 = value; } }
        private Value<bool?> _borrowerSelectIndicator8;
        public bool? BorrowerSelectIndicator8 { get { return _borrowerSelectIndicator8; } set { _borrowerSelectIndicator8 = value; } }
        private Value<bool?> _borrowerSelectIndicator9;
        public bool? BorrowerSelectIndicator9 { get { return _borrowerSelectIndicator9; } set { _borrowerSelectIndicator9 = value; } }
        private Value<decimal?> _brokerAdditionalFees;
        public decimal? BrokerAdditionalFees { get { return _brokerAdditionalFees; } set { _brokerAdditionalFees = value; } }
        private Value<decimal?> _brokerFees;
        public decimal? BrokerFees { get { return _brokerFees; } set { _brokerFees = value; } }
        private Value<decimal?> _brokerFeesPercentage;
        public decimal? BrokerFeesPercentage { get { return _brokerFeesPercentage; } set { _brokerFeesPercentage = value; } }
        private Value<decimal?> _chargeAmount;
        public decimal? ChargeAmount { get { return _chargeAmount; } set { _chargeAmount = value; } }
        private Value<decimal?> _chargeAmountForPrint;
        public decimal? ChargeAmountForPrint { get { return _chargeAmountForPrint; } set { _chargeAmountForPrint = value; } }
        private Value<bool?> _copyFromGfeIndicator1;
        public bool? CopyFromGfeIndicator1 { get { return _copyFromGfeIndicator1; } set { _copyFromGfeIndicator1 = value; } }
        private Value<bool?> _copyFromGfeIndicator10;
        public bool? CopyFromGfeIndicator10 { get { return _copyFromGfeIndicator10; } set { _copyFromGfeIndicator10 = value; } }
        private Value<bool?> _copyFromGfeIndicator11;
        public bool? CopyFromGfeIndicator11 { get { return _copyFromGfeIndicator11; } set { _copyFromGfeIndicator11 = value; } }
        private Value<bool?> _copyFromGfeIndicator12;
        public bool? CopyFromGfeIndicator12 { get { return _copyFromGfeIndicator12; } set { _copyFromGfeIndicator12 = value; } }
        private Value<bool?> _copyFromGfeIndicator13;
        public bool? CopyFromGfeIndicator13 { get { return _copyFromGfeIndicator13; } set { _copyFromGfeIndicator13 = value; } }
        private Value<bool?> _copyFromGfeIndicator14;
        public bool? CopyFromGfeIndicator14 { get { return _copyFromGfeIndicator14; } set { _copyFromGfeIndicator14 = value; } }
        private Value<bool?> _copyFromGfeIndicator15;
        public bool? CopyFromGfeIndicator15 { get { return _copyFromGfeIndicator15; } set { _copyFromGfeIndicator15 = value; } }
        private Value<bool?> _copyFromGfeIndicator16;
        public bool? CopyFromGfeIndicator16 { get { return _copyFromGfeIndicator16; } set { _copyFromGfeIndicator16 = value; } }
        private Value<bool?> _copyFromGfeIndicator17;
        public bool? CopyFromGfeIndicator17 { get { return _copyFromGfeIndicator17; } set { _copyFromGfeIndicator17 = value; } }
        private Value<bool?> _copyFromGfeIndicator18;
        public bool? CopyFromGfeIndicator18 { get { return _copyFromGfeIndicator18; } set { _copyFromGfeIndicator18 = value; } }
        private Value<bool?> _copyFromGfeIndicator19;
        public bool? CopyFromGfeIndicator19 { get { return _copyFromGfeIndicator19; } set { _copyFromGfeIndicator19 = value; } }
        private Value<bool?> _copyFromGfeIndicator2;
        public bool? CopyFromGfeIndicator2 { get { return _copyFromGfeIndicator2; } set { _copyFromGfeIndicator2 = value; } }
        private Value<bool?> _copyFromGfeIndicator20;
        public bool? CopyFromGfeIndicator20 { get { return _copyFromGfeIndicator20; } set { _copyFromGfeIndicator20 = value; } }
        private Value<bool?> _copyFromGfeIndicator21;
        public bool? CopyFromGfeIndicator21 { get { return _copyFromGfeIndicator21; } set { _copyFromGfeIndicator21 = value; } }
        private Value<bool?> _copyFromGfeIndicator22;
        public bool? CopyFromGfeIndicator22 { get { return _copyFromGfeIndicator22; } set { _copyFromGfeIndicator22 = value; } }
        private Value<bool?> _copyFromGfeIndicator23;
        public bool? CopyFromGfeIndicator23 { get { return _copyFromGfeIndicator23; } set { _copyFromGfeIndicator23 = value; } }
        private Value<bool?> _copyFromGfeIndicator24;
        public bool? CopyFromGfeIndicator24 { get { return _copyFromGfeIndicator24; } set { _copyFromGfeIndicator24 = value; } }
        private Value<bool?> _copyFromGfeIndicator25;
        public bool? CopyFromGfeIndicator25 { get { return _copyFromGfeIndicator25; } set { _copyFromGfeIndicator25 = value; } }
        private Value<bool?> _copyFromGfeIndicator26;
        public bool? CopyFromGfeIndicator26 { get { return _copyFromGfeIndicator26; } set { _copyFromGfeIndicator26 = value; } }
        private Value<bool?> _copyFromGfeIndicator27;
        public bool? CopyFromGfeIndicator27 { get { return _copyFromGfeIndicator27; } set { _copyFromGfeIndicator27 = value; } }
        private Value<bool?> _copyFromGfeIndicator28;
        public bool? CopyFromGfeIndicator28 { get { return _copyFromGfeIndicator28; } set { _copyFromGfeIndicator28 = value; } }
        private Value<bool?> _copyFromGfeIndicator29;
        public bool? CopyFromGfeIndicator29 { get { return _copyFromGfeIndicator29; } set { _copyFromGfeIndicator29 = value; } }
        private Value<bool?> _copyFromGfeIndicator3;
        public bool? CopyFromGfeIndicator3 { get { return _copyFromGfeIndicator3; } set { _copyFromGfeIndicator3 = value; } }
        private Value<bool?> _copyFromGfeIndicator30;
        public bool? CopyFromGfeIndicator30 { get { return _copyFromGfeIndicator30; } set { _copyFromGfeIndicator30 = value; } }
        private Value<bool?> _copyFromGfeIndicator31;
        public bool? CopyFromGfeIndicator31 { get { return _copyFromGfeIndicator31; } set { _copyFromGfeIndicator31 = value; } }
        private Value<bool?> _copyFromGfeIndicator32;
        public bool? CopyFromGfeIndicator32 { get { return _copyFromGfeIndicator32; } set { _copyFromGfeIndicator32 = value; } }
        private Value<bool?> _copyFromGfeIndicator33;
        public bool? CopyFromGfeIndicator33 { get { return _copyFromGfeIndicator33; } set { _copyFromGfeIndicator33 = value; } }
        private Value<bool?> _copyFromGfeIndicator34;
        public bool? CopyFromGfeIndicator34 { get { return _copyFromGfeIndicator34; } set { _copyFromGfeIndicator34 = value; } }
        private Value<bool?> _copyFromGfeIndicator35;
        public bool? CopyFromGfeIndicator35 { get { return _copyFromGfeIndicator35; } set { _copyFromGfeIndicator35 = value; } }
        private Value<bool?> _copyFromGfeIndicator4;
        public bool? CopyFromGfeIndicator4 { get { return _copyFromGfeIndicator4; } set { _copyFromGfeIndicator4 = value; } }
        private Value<bool?> _copyFromGfeIndicator5;
        public bool? CopyFromGfeIndicator5 { get { return _copyFromGfeIndicator5; } set { _copyFromGfeIndicator5 = value; } }
        private Value<bool?> _copyFromGfeIndicator6;
        public bool? CopyFromGfeIndicator6 { get { return _copyFromGfeIndicator6; } set { _copyFromGfeIndicator6 = value; } }
        private Value<bool?> _copyFromGfeIndicator7;
        public bool? CopyFromGfeIndicator7 { get { return _copyFromGfeIndicator7; } set { _copyFromGfeIndicator7 = value; } }
        private Value<bool?> _copyFromGfeIndicator8;
        public bool? CopyFromGfeIndicator8 { get { return _copyFromGfeIndicator8; } set { _copyFromGfeIndicator8 = value; } }
        private Value<bool?> _copyFromGfeIndicator9;
        public bool? CopyFromGfeIndicator9 { get { return _copyFromGfeIndicator9; } set { _copyFromGfeIndicator9 = value; } }
        private Value<decimal?> _creditAmount;
        public decimal? CreditAmount { get { return _creditAmount; } set { _creditAmount = value; } }
        private Value<decimal?> _creditAmountForPrint;
        public decimal? CreditAmountForPrint { get { return _creditAmountForPrint; } set { _creditAmountForPrint = value; } }
        private Value<string> _creditChargeType;
        public string CreditChargeType { get { return _creditChargeType; } set { _creditChargeType = value; } }
        private Value<decimal?> _creditOrChange;
        public decimal? CreditOrChange { get { return _creditOrChange; } set { _creditOrChange = value; } }
        private Value<decimal?> _curedAdjustedOriginationCharges;
        public decimal? CuredAdjustedOriginationCharges { get { return _curedAdjustedOriginationCharges; } set { _curedAdjustedOriginationCharges = value; } }
        private Value<decimal?> _curedCreditOrChange;
        public decimal? CuredCreditOrChange { get { return _curedCreditOrChange; } set { _curedCreditOrChange = value; } }
        private Value<decimal?> _curedOriginationCharges;
        public decimal? CuredOriginationCharges { get { return _curedOriginationCharges; } set { _curedOriginationCharges = value; } }
        private Value<decimal?> _curedTotalTransferTaxes;
        public decimal? CuredTotalTransferTaxes { get { return _curedTotalTransferTaxes; } set { _curedTotalTransferTaxes = value; } }
        private Value<decimal?> _dailyInterestCharges;
        public decimal? DailyInterestCharges { get { return _dailyInterestCharges; } set { _dailyInterestCharges = value; } }
        private Value<DateTime?> _dateForCharges;
        public DateTime? DateForCharges { get { return _dateForCharges; } set { _dateForCharges = value; } }
        private Value<string> _dateForRate;
        public string DateForRate { get { return _dateForRate; } set { _dateForRate = value; } }
        private Value<string> _daysToSettlement;
        public string DaysToSettlement { get { return _daysToSettlement; } set { _daysToSettlement = value; } }
        private Value<int?> _durationMonths;
        public int? DurationMonths { get { return _durationMonths; } set { _durationMonths = value; } }
        private Value<bool?> _escrowChargeAllInsuranceIndicator;
        public bool? EscrowChargeAllInsuranceIndicator { get { return _escrowChargeAllInsuranceIndicator; } set { _escrowChargeAllInsuranceIndicator = value; } }
        private Value<bool?> _escrowChargeAllPropertyTaxesIndicator;
        public bool? EscrowChargeAllPropertyTaxesIndicator { get { return _escrowChargeAllPropertyTaxesIndicator; } set { _escrowChargeAllPropertyTaxesIndicator = value; } }
        private Value<bool?> _escrowChargeOtherIndicator;
        public bool? EscrowChargeOtherIndicator { get { return _escrowChargeOtherIndicator; } set { _escrowChargeOtherIndicator = value; } }
        private Value<string> _escrowOtherDescription;
        public string EscrowOtherDescription { get { return _escrowOtherDescription; } set { _escrowOtherDescription = value; } }
        private Value<decimal?> _financedFeesFromPrepaid;
        public decimal? FinancedFeesFromPrepaid { get { return _financedFeesFromPrepaid; } set { _financedFeesFromPrepaid = value; } }
        private Value<List<Gfe2010Fee>> _gfe2010Fees;
        public List<Gfe2010Fee> Gfe2010Fees { get { return _gfe2010Fees; } set { _gfe2010Fees = value; } }
        private Value<List<Gfe2010WholePoc>> _gfe2010WholePocs;
        public List<Gfe2010WholePoc> Gfe2010WholePocs { get { return _gfe2010WholePocs; } set { _gfe2010WholePocs = value; } }
        private Value<decimal?> _gfeGovernmentRecordingCharges;
        public decimal? GfeGovernmentRecordingCharges { get { return _gfeGovernmentRecordingCharges; } set { _gfeGovernmentRecordingCharges = value; } }
        private Value<decimal?> _hazardInsurance;
        public decimal? HazardInsurance { get { return _hazardInsurance; } set { _hazardInsurance = value; } }
        private Value<decimal?> _homeownerInsurance;
        public decimal? HomeownerInsurance { get { return _homeownerInsurance; } set { _homeownerInsurance = value; } }
        private Value<decimal?> _hudGuaranteeFee;
        public decimal? HudGuaranteeFee { get { return _hudGuaranteeFee; } set { _hudGuaranteeFee = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _includeOriginationPointsCreditType;
        public string IncludeOriginationPointsCreditType { get { return _includeOriginationPointsCreditType; } set { _includeOriginationPointsCreditType = value; } }
        private Value<decimal?> _initialLoanAmount;
        public decimal? InitialLoanAmount { get { return _initialLoanAmount; } set { _initialLoanAmount = value; } }
        private Value<decimal?> _initialMonthlyAmount;
        public decimal? InitialMonthlyAmount { get { return _initialMonthlyAmount; } set { _initialMonthlyAmount = value; } }
        private Value<bool?> _interestRateRiseIndicator;
        public bool? InterestRateRiseIndicator { get { return _interestRateRiseIndicator; } set { _interestRateRiseIndicator = value; } }
        private Value<bool?> _isCDValidForEarliestClosingDate;
        public bool? IsCDValidForEarliestClosingDate { get { return _isCDValidForEarliestClosingDate; } set { _isCDValidForEarliestClosingDate = value; } }
        private Value<decimal?> _line1001Fee;
        public decimal? Line1001Fee { get { return _line1001Fee; } set { _line1001Fee = value; } }
        private Value<decimal?> _line1002Fee;
        public decimal? Line1002Fee { get { return _line1002Fee; } set { _line1002Fee = value; } }
        private Value<decimal?> _line1003Fee;
        public decimal? Line1003Fee { get { return _line1003Fee; } set { _line1003Fee = value; } }
        private Value<decimal?> _line1004Fee;
        public decimal? Line1004Fee { get { return _line1004Fee; } set { _line1004Fee = value; } }
        private Value<decimal?> _line1005Fee;
        public decimal? Line1005Fee { get { return _line1005Fee; } set { _line1005Fee = value; } }
        private Value<decimal?> _line1006Fee;
        public decimal? Line1006Fee { get { return _line1006Fee; } set { _line1006Fee = value; } }
        private Value<decimal?> _line1007Fee;
        public decimal? Line1007Fee { get { return _line1007Fee; } set { _line1007Fee = value; } }
        private Value<decimal?> _line1008Fee;
        public decimal? Line1008Fee { get { return _line1008Fee; } set { _line1008Fee = value; } }
        private Value<decimal?> _line1009Fee;
        public decimal? Line1009Fee { get { return _line1009Fee; } set { _line1009Fee = value; } }
        private Value<decimal?> _line801BrokerCompensationAdditionalAmount;
        public decimal? Line801BrokerCompensationAdditionalAmount { get { return _line801BrokerCompensationAdditionalAmount; } set { _line801BrokerCompensationAdditionalAmount = value; } }
        private Value<decimal?> _line801BrokerCompensationFees;
        public decimal? Line801BrokerCompensationFees { get { return _line801BrokerCompensationFees; } set { _line801BrokerCompensationFees = value; } }
        private Value<decimal?> _line801BrokerCompensationRate;
        public decimal? Line801BrokerCompensationRate { get { return _line801BrokerCompensationRate; } set { _line801BrokerCompensationRate = value; } }
        private Value<decimal?> _line808Fee;
        public decimal? Line808Fee { get { return _line808Fee; } set { _line808Fee = value; } }
        private Value<decimal?> _line809Fee;
        public decimal? Line809Fee { get { return _line809Fee; } set { _line809Fee = value; } }
        private Value<decimal?> _line810Fee;
        public decimal? Line810Fee { get { return _line810Fee; } set { _line810Fee = value; } }
        private Value<decimal?> _line811Fee;
        public decimal? Line811Fee { get { return _line811Fee; } set { _line811Fee = value; } }
        private Value<decimal?> _line812Fee;
        public decimal? Line812Fee { get { return _line812Fee; } set { _line812Fee = value; } }
        private Value<decimal?> _line813Fee;
        public decimal? Line813Fee { get { return _line813Fee; } set { _line813Fee = value; } }
        private Value<decimal?> _line814Fee;
        public decimal? Line814Fee { get { return _line814Fee; } set { _line814Fee = value; } }
        private Value<decimal?> _line815Fee;
        public decimal? Line815Fee { get { return _line815Fee; } set { _line815Fee = value; } }
        private Value<decimal?> _line816Fee;
        public decimal? Line816Fee { get { return _line816Fee; } set { _line816Fee = value; } }
        private Value<decimal?> _line817Fee;
        public decimal? Line817Fee { get { return _line817Fee; } set { _line817Fee = value; } }
        private Value<decimal?> _line818Fee;
        public decimal? Line818Fee { get { return _line818Fee; } set { _line818Fee = value; } }
        private Value<decimal?> _line819Fee;
        public decimal? Line819Fee { get { return _line819Fee; } set { _line819Fee = value; } }
        private Value<decimal?> _line820Fee;
        public decimal? Line820Fee { get { return _line820Fee; } set { _line820Fee = value; } }
        private Value<decimal?> _line821Fee;
        public decimal? Line821Fee { get { return _line821Fee; } set { _line821Fee = value; } }
        private Value<decimal?> _line822Fee;
        public decimal? Line822Fee { get { return _line822Fee; } set { _line822Fee = value; } }
        private Value<decimal?> _line823Fee;
        public decimal? Line823Fee { get { return _line823Fee; } set { _line823Fee = value; } }
        private Value<decimal?> _line824Fee;
        public decimal? Line824Fee { get { return _line824Fee; } set { _line824Fee = value; } }
        private Value<decimal?> _line825Fee;
        public decimal? Line825Fee { get { return _line825Fee; } set { _line825Fee = value; } }
        private Value<decimal?> _line826Fee;
        public decimal? Line826Fee { get { return _line826Fee; } set { _line826Fee = value; } }
        private Value<decimal?> _line827Fee;
        public decimal? Line827Fee { get { return _line827Fee; } set { _line827Fee = value; } }
        private Value<decimal?> _line828Fee;
        public decimal? Line828Fee { get { return _line828Fee; } set { _line828Fee = value; } }
        private Value<decimal?> _line829Fee;
        public decimal? Line829Fee { get { return _line829Fee; } set { _line829Fee = value; } }
        private Value<decimal?> _line830Fee;
        public decimal? Line830Fee { get { return _line830Fee; } set { _line830Fee = value; } }
        private Value<decimal?> _line831Fee;
        public decimal? Line831Fee { get { return _line831Fee; } set { _line831Fee = value; } }
        private Value<decimal?> _line832Fee;
        public decimal? Line832Fee { get { return _line832Fee; } set { _line832Fee = value; } }
        private Value<decimal?> _line833Fee;
        public decimal? Line833Fee { get { return _line833Fee; } set { _line833Fee = value; } }
        private Value<bool?> _loanBalanceRiseIndicator;
        public bool? LoanBalanceRiseIndicator { get { return _loanBalanceRiseIndicator; } set { _loanBalanceRiseIndicator = value; } }
        private Value<decimal?> _loanOriginationFees;
        public decimal? LoanOriginationFees { get { return _loanOriginationFees; } set { _loanOriginationFees = value; } }
        private Value<decimal?> _loanOriginationPercentage;
        public decimal? LoanOriginationPercentage { get { return _loanOriginationPercentage; } set { _loanOriginationPercentage = value; } }
        private Value<string> _loanOriginatorName;
        public string LoanOriginatorName { get { return _loanOriginatorName; } set { _loanOriginatorName = value; } }
        private Value<decimal?> _lowerInterestInitialInterestRate;
        public decimal? LowerInterestInitialInterestRate { get { return _lowerInterestInitialInterestRate; } set { _lowerInterestInitialInterestRate = value; } }
        private Value<decimal?> _lowerInterestInitialMonthlyAmountOwed;
        public decimal? LowerInterestInitialMonthlyAmountOwed { get { return _lowerInterestInitialMonthlyAmountOwed; } set { _lowerInterestInitialMonthlyAmountOwed = value; } }
        private Value<decimal?> _lowerInterestMonthlyPaymentReduced;
        public decimal? LowerInterestMonthlyPaymentReduced { get { return _lowerInterestMonthlyPaymentReduced; } set { _lowerInterestMonthlyPaymentReduced = value; } }
        private Value<decimal?> _lowerInterestServiceChargeIncreasedAmount;
        public decimal? LowerInterestServiceChargeIncreasedAmount { get { return _lowerInterestServiceChargeIncreasedAmount; } set { _lowerInterestServiceChargeIncreasedAmount = value; } }
        private Value<decimal?> _lowerInterestTotalSettlementCharges;
        public decimal? LowerInterestTotalSettlementCharges { get { return _lowerInterestTotalSettlementCharges; } set { _lowerInterestTotalSettlementCharges = value; } }
        private Value<decimal?> _lowerSettlementInitialInterestRate;
        public decimal? LowerSettlementInitialInterestRate { get { return _lowerSettlementInitialInterestRate; } set { _lowerSettlementInitialInterestRate = value; } }
        private Value<decimal?> _lowerSettlementInitialMonthlyAmountOwed;
        public decimal? LowerSettlementInitialMonthlyAmountOwed { get { return _lowerSettlementInitialMonthlyAmountOwed; } set { _lowerSettlementInitialMonthlyAmountOwed = value; } }
        private Value<decimal?> _lowerSettlementMonthlyPaymentIncreased;
        public decimal? LowerSettlementMonthlyPaymentIncreased { get { return _lowerSettlementMonthlyPaymentIncreased; } set { _lowerSettlementMonthlyPaymentIncreased = value; } }
        private Value<decimal?> _lowerSettlementServiceChargeReducedAmount;
        public decimal? LowerSettlementServiceChargeReducedAmount { get { return _lowerSettlementServiceChargeReducedAmount; } set { _lowerSettlementServiceChargeReducedAmount = value; } }
        private Value<decimal?> _lowerSettlementTotalSettlementCharges;
        public decimal? LowerSettlementTotalSettlementCharges { get { return _lowerSettlementTotalSettlementCharges; } set { _lowerSettlementTotalSettlementCharges = value; } }
        private Value<decimal?> _maximumLoanBalance;
        public decimal? MaximumLoanBalance { get { return _maximumLoanBalance; } set { _maximumLoanBalance = value; } }
        private Value<decimal?> _maximumOwedMonthlyPayment;
        public decimal? MaximumOwedMonthlyPayment { get { return _maximumOwedMonthlyPayment; } set { _maximumOwedMonthlyPayment = value; } }
        private Value<decimal?> _maxLifeInterestCapPercent;
        public decimal? MaxLifeInterestCapPercent { get { return _maxLifeInterestCapPercent; } set { _maxLifeInterestCapPercent = value; } }
        private Value<int?> _monthlyPaymentFirstIncreaseDate;
        public int? MonthlyPaymentFirstIncreaseDate { get { return _monthlyPaymentFirstIncreaseDate; } set { _monthlyPaymentFirstIncreaseDate = value; } }
        private Value<bool?> _monthlyPaymentRiseIndicator;
        public bool? MonthlyPaymentRiseIndicator { get { return _monthlyPaymentRiseIndicator; } set { _monthlyPaymentRiseIndicator = value; } }
        private Value<decimal?> _mortgageInsurancePremium;
        public decimal? MortgageInsurancePremium { get { return _mortgageInsurancePremium; } set { _mortgageInsurancePremium = value; } }
        private Value<string> _mustLockRateDays;
        public string MustLockRateDays { get { return _mustLockRateDays; } set { _mustLockRateDays = value; } }
        private Value<decimal?> _newHudSection1100Line1104BorPaidAmount;
        public decimal? NewHudSection1100Line1104BorPaidAmount { get { return _newHudSection1100Line1104BorPaidAmount; } set { _newHudSection1100Line1104BorPaidAmount = value; } }
        private Value<decimal?> _newHudSection1100Line1104SelPaidAmount;
        public decimal? NewHudSection1100Line1104SelPaidAmount { get { return _newHudSection1100Line1104SelPaidAmount; } set { _newHudSection1100Line1104SelPaidAmount = value; } }
        private Value<decimal?> _newHudSection1100Line1107BorPaidAmount;
        public decimal? NewHudSection1100Line1107BorPaidAmount { get { return _newHudSection1100Line1107BorPaidAmount; } set { _newHudSection1100Line1107BorPaidAmount = value; } }
        private Value<decimal?> _newHudSection1100Line1108BorPaidAmount;
        public decimal? NewHudSection1100Line1108BorPaidAmount { get { return _newHudSection1100Line1108BorPaidAmount; } set { _newHudSection1100Line1108BorPaidAmount = value; } }
        private Value<decimal?> _originationCharges;
        public decimal? OriginationCharges { get { return _originationCharges; } set { _originationCharges = value; } }
        private Value<decimal?> _originationCreditYsp;
        public decimal? OriginationCreditYsp { get { return _originationCreditYsp; } set { _originationCreditYsp = value; } }
        private Value<decimal?> _originationCreditYspAdditional;
        public decimal? OriginationCreditYspAdditional { get { return _originationCreditYspAdditional; } set { _originationCreditYspAdditional = value; } }
        private Value<decimal?> _originationPoints;
        public decimal? OriginationPoints { get { return _originationPoints; } set { _originationPoints = value; } }
        private Value<decimal?> _originationPointsAdditional;
        public decimal? OriginationPointsAdditional { get { return _originationPointsAdditional; } set { _originationPointsAdditional = value; } }
        private Value<decimal?> _originationPointsPercentage;
        public decimal? OriginationPointsPercentage { get { return _originationPointsPercentage; } set { _originationPointsPercentage = value; } }
        private Value<decimal?> _ownerTitleInsuranceAmount;
        public decimal? OwnerTitleInsuranceAmount { get { return _ownerTitleInsuranceAmount; } set { _ownerTitleInsuranceAmount = value; } }
        private Value<bool?> _printNAInLockRateDays;
        public bool? PrintNAInLockRateDays { get { return _printNAInLockRateDays; } set { _printNAInLockRateDays = value; } }
        private Value<bool?> _printShoppingChartIndicator;
        public bool? PrintShoppingChartIndicator { get { return _printShoppingChartIndicator; } set { _printShoppingChartIndicator = value; } }
        private Value<decimal?> _processingFees;
        public decimal? ProcessingFees { get { return _processingFees; } set { _processingFees = value; } }
        private Value<decimal?> _requiredAppraisalFee;
        public decimal? RequiredAppraisalFee { get { return _requiredAppraisalFee; } set { _requiredAppraisalFee = value; } }
        private Value<decimal?> _requiredCreditReportFee;
        public decimal? RequiredCreditReportFee { get { return _requiredCreditReportFee; } set { _requiredCreditReportFee = value; } }
        private Value<decimal?> _requiredFloodCertificationFee;
        public decimal? RequiredFloodCertificationFee { get { return _requiredFloodCertificationFee; } set { _requiredFloodCertificationFee = value; } }
        private Value<decimal?> _requiredServicesAmount;
        public decimal? RequiredServicesAmount { get { return _requiredServicesAmount; } set { _requiredServicesAmount = value; } }
        private Value<decimal?> _requiredTaxServiceFee;
        public decimal? RequiredTaxServiceFee { get { return _requiredTaxServiceFee; } set { _requiredTaxServiceFee = value; } }
        private Value<decimal?> _section1000TotalBorrowerPaidAmount;
        public decimal? Section1000TotalBorrowerPaidAmount { get { return _section1000TotalBorrowerPaidAmount; } set { _section1000TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section1000TotalOtherPaidAmount;
        public decimal? Section1000TotalOtherPaidAmount { get { return _section1000TotalOtherPaidAmount; } set { _section1000TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section1000TotalPaidAmount;
        public decimal? Section1000TotalPaidAmount { get { return _section1000TotalPaidAmount; } set { _section1000TotalPaidAmount = value; } }
        private Value<decimal?> _section1000TotalSellerPaidAmount;
        public decimal? Section1000TotalSellerPaidAmount { get { return _section1000TotalSellerPaidAmount; } set { _section1000TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section1100TotalBorrowerPaidAmount;
        public decimal? Section1100TotalBorrowerPaidAmount { get { return _section1100TotalBorrowerPaidAmount; } set { _section1100TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section1100TotalOtherPaidAmount;
        public decimal? Section1100TotalOtherPaidAmount { get { return _section1100TotalOtherPaidAmount; } set { _section1100TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section1100TotalPaidAmount;
        public decimal? Section1100TotalPaidAmount { get { return _section1100TotalPaidAmount; } set { _section1100TotalPaidAmount = value; } }
        private Value<decimal?> _section1100TotalSellerPaidAmount;
        public decimal? Section1100TotalSellerPaidAmount { get { return _section1100TotalSellerPaidAmount; } set { _section1100TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section1200TotalBorrowerPaidAmount;
        public decimal? Section1200TotalBorrowerPaidAmount { get { return _section1200TotalBorrowerPaidAmount; } set { _section1200TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section1200TotalOtherPaidAmount;
        public decimal? Section1200TotalOtherPaidAmount { get { return _section1200TotalOtherPaidAmount; } set { _section1200TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section1200TotalPaidAmount;
        public decimal? Section1200TotalPaidAmount { get { return _section1200TotalPaidAmount; } set { _section1200TotalPaidAmount = value; } }
        private Value<decimal?> _section1200TotalSellerPaidAmount;
        public decimal? Section1200TotalSellerPaidAmount { get { return _section1200TotalSellerPaidAmount; } set { _section1200TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section1300TotalBorrowerPaidAmount;
        public decimal? Section1300TotalBorrowerPaidAmount { get { return _section1300TotalBorrowerPaidAmount; } set { _section1300TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section1300TotalOtherPaidAmount;
        public decimal? Section1300TotalOtherPaidAmount { get { return _section1300TotalOtherPaidAmount; } set { _section1300TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section1300TotalPaidAmount;
        public decimal? Section1300TotalPaidAmount { get { return _section1300TotalPaidAmount; } set { _section1300TotalPaidAmount = value; } }
        private Value<decimal?> _section1300TotalSellerPaidAmount;
        public decimal? Section1300TotalSellerPaidAmount { get { return _section1300TotalSellerPaidAmount; } set { _section1300TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section1400TotalBorrowerPaidAmount;
        public decimal? Section1400TotalBorrowerPaidAmount { get { return _section1400TotalBorrowerPaidAmount; } set { _section1400TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section1400TotalOtherPaidAmount;
        public decimal? Section1400TotalOtherPaidAmount { get { return _section1400TotalOtherPaidAmount; } set { _section1400TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section1400TotalPaidAmount;
        public decimal? Section1400TotalPaidAmount { get { return _section1400TotalPaidAmount; } set { _section1400TotalPaidAmount = value; } }
        private Value<decimal?> _section1400TotalSellerPaidAmount;
        public decimal? Section1400TotalSellerPaidAmount { get { return _section1400TotalSellerPaidAmount; } set { _section1400TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section700TotalBorrowerPaidAmount;
        public decimal? Section700TotalBorrowerPaidAmount { get { return _section700TotalBorrowerPaidAmount; } set { _section700TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section700TotalOtherPaidAmount;
        public decimal? Section700TotalOtherPaidAmount { get { return _section700TotalOtherPaidAmount; } set { _section700TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section700TotalPaidAmount;
        public decimal? Section700TotalPaidAmount { get { return _section700TotalPaidAmount; } set { _section700TotalPaidAmount = value; } }
        private Value<decimal?> _section700TotalSellerPaidAmount;
        public decimal? Section700TotalSellerPaidAmount { get { return _section700TotalSellerPaidAmount; } set { _section700TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section800TotalBorrowerPaidAmount;
        public decimal? Section800TotalBorrowerPaidAmount { get { return _section800TotalBorrowerPaidAmount; } set { _section800TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section800TotalOtherPaidAmount;
        public decimal? Section800TotalOtherPaidAmount { get { return _section800TotalOtherPaidAmount; } set { _section800TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section800TotalPaidAmount;
        public decimal? Section800TotalPaidAmount { get { return _section800TotalPaidAmount; } set { _section800TotalPaidAmount = value; } }
        private Value<decimal?> _section800TotalSellerPaidAmount;
        public decimal? Section800TotalSellerPaidAmount { get { return _section800TotalSellerPaidAmount; } set { _section800TotalSellerPaidAmount = value; } }
        private Value<decimal?> _section900TotalBorrowerPaidAmount;
        public decimal? Section900TotalBorrowerPaidAmount { get { return _section900TotalBorrowerPaidAmount; } set { _section900TotalBorrowerPaidAmount = value; } }
        private Value<decimal?> _section900TotalOtherPaidAmount;
        public decimal? Section900TotalOtherPaidAmount { get { return _section900TotalOtherPaidAmount; } set { _section900TotalOtherPaidAmount = value; } }
        private Value<decimal?> _section900TotalPaidAmount;
        public decimal? Section900TotalPaidAmount { get { return _section900TotalPaidAmount; } set { _section900TotalPaidAmount = value; } }
        private Value<decimal?> _section900TotalSellerPaidAmount;
        public decimal? Section900TotalSellerPaidAmount { get { return _section900TotalSellerPaidAmount; } set { _section900TotalSellerPaidAmount = value; } }
        private Value<decimal?> _shopRequiredServicesAmount;
        public decimal? ShopRequiredServicesAmount { get { return _shopRequiredServicesAmount; } set { _shopRequiredServicesAmount = value; } }
        private Value<decimal?> _subsequentCapPercent;
        public decimal? SubsequentCapPercent { get { return _subsequentCapPercent; } set { _subsequentCapPercent = value; } }
        private Value<int?> _subsequentRateAdjustmentMonths;
        public int? SubsequentRateAdjustmentMonths { get { return _subsequentRateAdjustmentMonths; } set { _subsequentRateAdjustmentMonths = value; } }
        private Value<bool?> _tableFundedIndicator;
        public bool? TableFundedIndicator { get { return _tableFundedIndicator; } set { _tableFundedIndicator = value; } }
        private Value<string> _timeForRate;
        public string TimeForRate { get { return _timeForRate; } set { _timeForRate = value; } }
        private Value<decimal?> _titleServiceAmount;
        public decimal? TitleServiceAmount { get { return _titleServiceAmount; } set { _titleServiceAmount = value; } }
        private Value<decimal?> _totalBelow10;
        public decimal? TotalBelow10 { get { return _totalBelow10; } set { _totalBelow10 = value; } }
        private Value<decimal?> _totalOfFinancedFees;
        public decimal? TotalOfFinancedFees { get { return _totalOfFinancedFees; } set { _totalOfFinancedFees = value; } }
        private Value<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get { return _totalSettlementCharges; } set { _totalSettlementCharges = value; } }
        private Value<decimal?> _totalTransferTaxes;
        public decimal? TotalTransferTaxes { get { return _totalTransferTaxes; } set { _totalTransferTaxes = value; } }
        private Value<decimal?> _transferTaxes;
        public decimal? TransferTaxes { get { return _transferTaxes; } set { _transferTaxes = value; } }
        private Value<decimal?> _underwritingFees;
        public decimal? UnderwritingFees { get { return _underwritingFees; } set { _underwritingFees = value; } }
        private Value<bool?> _useLOCompTool;
        public bool? UseLOCompTool { get { return _useLOCompTool; } set { _useLOCompTool = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustedOriginationCharges.Clean
                    && _allOtherServiceAmount.Clean
                    && _applicationFees.Clean
                    && _borrowerSelectIndicator10.Clean
                    && _borrowerSelectIndicator11.Clean
                    && _borrowerSelectIndicator12.Clean
                    && _borrowerSelectIndicator13.Clean
                    && _borrowerSelectIndicator14.Clean
                    && _borrowerSelectIndicator15.Clean
                    && _borrowerSelectIndicator16.Clean
                    && _borrowerSelectIndicator17.Clean
                    && _borrowerSelectIndicator18.Clean
                    && _borrowerSelectIndicator19.Clean
                    && _borrowerSelectIndicator2.Clean
                    && _borrowerSelectIndicator20.Clean
                    && _borrowerSelectIndicator3.Clean
                    && _borrowerSelectIndicator4.Clean
                    && _borrowerSelectIndicator5.Clean
                    && _borrowerSelectIndicator6.Clean
                    && _borrowerSelectIndicator7.Clean
                    && _borrowerSelectIndicator8.Clean
                    && _borrowerSelectIndicator9.Clean
                    && _brokerAdditionalFees.Clean
                    && _brokerFees.Clean
                    && _brokerFeesPercentage.Clean
                    && _chargeAmount.Clean
                    && _chargeAmountForPrint.Clean
                    && _copyFromGfeIndicator1.Clean
                    && _copyFromGfeIndicator10.Clean
                    && _copyFromGfeIndicator11.Clean
                    && _copyFromGfeIndicator12.Clean
                    && _copyFromGfeIndicator13.Clean
                    && _copyFromGfeIndicator14.Clean
                    && _copyFromGfeIndicator15.Clean
                    && _copyFromGfeIndicator16.Clean
                    && _copyFromGfeIndicator17.Clean
                    && _copyFromGfeIndicator18.Clean
                    && _copyFromGfeIndicator19.Clean
                    && _copyFromGfeIndicator2.Clean
                    && _copyFromGfeIndicator20.Clean
                    && _copyFromGfeIndicator21.Clean
                    && _copyFromGfeIndicator22.Clean
                    && _copyFromGfeIndicator23.Clean
                    && _copyFromGfeIndicator24.Clean
                    && _copyFromGfeIndicator25.Clean
                    && _copyFromGfeIndicator26.Clean
                    && _copyFromGfeIndicator27.Clean
                    && _copyFromGfeIndicator28.Clean
                    && _copyFromGfeIndicator29.Clean
                    && _copyFromGfeIndicator3.Clean
                    && _copyFromGfeIndicator30.Clean
                    && _copyFromGfeIndicator31.Clean
                    && _copyFromGfeIndicator32.Clean
                    && _copyFromGfeIndicator33.Clean
                    && _copyFromGfeIndicator34.Clean
                    && _copyFromGfeIndicator35.Clean
                    && _copyFromGfeIndicator4.Clean
                    && _copyFromGfeIndicator5.Clean
                    && _copyFromGfeIndicator6.Clean
                    && _copyFromGfeIndicator7.Clean
                    && _copyFromGfeIndicator8.Clean
                    && _copyFromGfeIndicator9.Clean
                    && _creditAmount.Clean
                    && _creditAmountForPrint.Clean
                    && _creditChargeType.Clean
                    && _creditOrChange.Clean
                    && _curedAdjustedOriginationCharges.Clean
                    && _curedCreditOrChange.Clean
                    && _curedOriginationCharges.Clean
                    && _curedTotalTransferTaxes.Clean
                    && _dailyInterestCharges.Clean
                    && _dateForCharges.Clean
                    && _dateForRate.Clean
                    && _daysToSettlement.Clean
                    && _durationMonths.Clean
                    && _escrowChargeAllInsuranceIndicator.Clean
                    && _escrowChargeAllPropertyTaxesIndicator.Clean
                    && _escrowChargeOtherIndicator.Clean
                    && _escrowOtherDescription.Clean
                    && _financedFeesFromPrepaid.Clean
                    && _gfe2010Fees.Clean
                    && _gfe2010WholePocs.Clean
                    && _gfeGovernmentRecordingCharges.Clean
                    && _hazardInsurance.Clean
                    && _homeownerInsurance.Clean
                    && _hudGuaranteeFee.Clean
                    && _id.Clean
                    && _includeOriginationPointsCreditType.Clean
                    && _initialLoanAmount.Clean
                    && _initialMonthlyAmount.Clean
                    && _interestRateRiseIndicator.Clean
                    && _isCDValidForEarliestClosingDate.Clean
                    && _line1001Fee.Clean
                    && _line1002Fee.Clean
                    && _line1003Fee.Clean
                    && _line1004Fee.Clean
                    && _line1005Fee.Clean
                    && _line1006Fee.Clean
                    && _line1007Fee.Clean
                    && _line1008Fee.Clean
                    && _line1009Fee.Clean
                    && _line801BrokerCompensationAdditionalAmount.Clean
                    && _line801BrokerCompensationFees.Clean
                    && _line801BrokerCompensationRate.Clean
                    && _line808Fee.Clean
                    && _line809Fee.Clean
                    && _line810Fee.Clean
                    && _line811Fee.Clean
                    && _line812Fee.Clean
                    && _line813Fee.Clean
                    && _line814Fee.Clean
                    && _line815Fee.Clean
                    && _line816Fee.Clean
                    && _line817Fee.Clean
                    && _line818Fee.Clean
                    && _line819Fee.Clean
                    && _line820Fee.Clean
                    && _line821Fee.Clean
                    && _line822Fee.Clean
                    && _line823Fee.Clean
                    && _line824Fee.Clean
                    && _line825Fee.Clean
                    && _line826Fee.Clean
                    && _line827Fee.Clean
                    && _line828Fee.Clean
                    && _line829Fee.Clean
                    && _line830Fee.Clean
                    && _line831Fee.Clean
                    && _line832Fee.Clean
                    && _line833Fee.Clean
                    && _loanBalanceRiseIndicator.Clean
                    && _loanOriginationFees.Clean
                    && _loanOriginationPercentage.Clean
                    && _loanOriginatorName.Clean
                    && _lowerInterestInitialInterestRate.Clean
                    && _lowerInterestInitialMonthlyAmountOwed.Clean
                    && _lowerInterestMonthlyPaymentReduced.Clean
                    && _lowerInterestServiceChargeIncreasedAmount.Clean
                    && _lowerInterestTotalSettlementCharges.Clean
                    && _lowerSettlementInitialInterestRate.Clean
                    && _lowerSettlementInitialMonthlyAmountOwed.Clean
                    && _lowerSettlementMonthlyPaymentIncreased.Clean
                    && _lowerSettlementServiceChargeReducedAmount.Clean
                    && _lowerSettlementTotalSettlementCharges.Clean
                    && _maximumLoanBalance.Clean
                    && _maximumOwedMonthlyPayment.Clean
                    && _maxLifeInterestCapPercent.Clean
                    && _monthlyPaymentFirstIncreaseDate.Clean
                    && _monthlyPaymentRiseIndicator.Clean
                    && _mortgageInsurancePremium.Clean
                    && _mustLockRateDays.Clean
                    && _newHudSection1100Line1104BorPaidAmount.Clean
                    && _newHudSection1100Line1104SelPaidAmount.Clean
                    && _newHudSection1100Line1107BorPaidAmount.Clean
                    && _newHudSection1100Line1108BorPaidAmount.Clean
                    && _originationCharges.Clean
                    && _originationCreditYsp.Clean
                    && _originationCreditYspAdditional.Clean
                    && _originationPoints.Clean
                    && _originationPointsAdditional.Clean
                    && _originationPointsPercentage.Clean
                    && _ownerTitleInsuranceAmount.Clean
                    && _printNAInLockRateDays.Clean
                    && _printShoppingChartIndicator.Clean
                    && _processingFees.Clean
                    && _requiredAppraisalFee.Clean
                    && _requiredCreditReportFee.Clean
                    && _requiredFloodCertificationFee.Clean
                    && _requiredServicesAmount.Clean
                    && _requiredTaxServiceFee.Clean
                    && _section1000TotalBorrowerPaidAmount.Clean
                    && _section1000TotalOtherPaidAmount.Clean
                    && _section1000TotalPaidAmount.Clean
                    && _section1000TotalSellerPaidAmount.Clean
                    && _section1100TotalBorrowerPaidAmount.Clean
                    && _section1100TotalOtherPaidAmount.Clean
                    && _section1100TotalPaidAmount.Clean
                    && _section1100TotalSellerPaidAmount.Clean
                    && _section1200TotalBorrowerPaidAmount.Clean
                    && _section1200TotalOtherPaidAmount.Clean
                    && _section1200TotalPaidAmount.Clean
                    && _section1200TotalSellerPaidAmount.Clean
                    && _section1300TotalBorrowerPaidAmount.Clean
                    && _section1300TotalOtherPaidAmount.Clean
                    && _section1300TotalPaidAmount.Clean
                    && _section1300TotalSellerPaidAmount.Clean
                    && _section1400TotalBorrowerPaidAmount.Clean
                    && _section1400TotalOtherPaidAmount.Clean
                    && _section1400TotalPaidAmount.Clean
                    && _section1400TotalSellerPaidAmount.Clean
                    && _section700TotalBorrowerPaidAmount.Clean
                    && _section700TotalOtherPaidAmount.Clean
                    && _section700TotalPaidAmount.Clean
                    && _section700TotalSellerPaidAmount.Clean
                    && _section800TotalBorrowerPaidAmount.Clean
                    && _section800TotalOtherPaidAmount.Clean
                    && _section800TotalPaidAmount.Clean
                    && _section800TotalSellerPaidAmount.Clean
                    && _section900TotalBorrowerPaidAmount.Clean
                    && _section900TotalOtherPaidAmount.Clean
                    && _section900TotalPaidAmount.Clean
                    && _section900TotalSellerPaidAmount.Clean
                    && _shopRequiredServicesAmount.Clean
                    && _subsequentCapPercent.Clean
                    && _subsequentRateAdjustmentMonths.Clean
                    && _tableFundedIndicator.Clean
                    && _timeForRate.Clean
                    && _titleServiceAmount.Clean
                    && _totalBelow10.Clean
                    && _totalOfFinancedFees.Clean
                    && _totalSettlementCharges.Clean
                    && _totalTransferTaxes.Clean
                    && _transferTaxes.Clean
                    && _underwritingFees.Clean
                    && _useLOCompTool.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _adjustedOriginationCharges; v0.Clean = value; _adjustedOriginationCharges = v0;
                var v1 = _allOtherServiceAmount; v1.Clean = value; _allOtherServiceAmount = v1;
                var v2 = _applicationFees; v2.Clean = value; _applicationFees = v2;
                var v3 = _borrowerSelectIndicator10; v3.Clean = value; _borrowerSelectIndicator10 = v3;
                var v4 = _borrowerSelectIndicator11; v4.Clean = value; _borrowerSelectIndicator11 = v4;
                var v5 = _borrowerSelectIndicator12; v5.Clean = value; _borrowerSelectIndicator12 = v5;
                var v6 = _borrowerSelectIndicator13; v6.Clean = value; _borrowerSelectIndicator13 = v6;
                var v7 = _borrowerSelectIndicator14; v7.Clean = value; _borrowerSelectIndicator14 = v7;
                var v8 = _borrowerSelectIndicator15; v8.Clean = value; _borrowerSelectIndicator15 = v8;
                var v9 = _borrowerSelectIndicator16; v9.Clean = value; _borrowerSelectIndicator16 = v9;
                var v10 = _borrowerSelectIndicator17; v10.Clean = value; _borrowerSelectIndicator17 = v10;
                var v11 = _borrowerSelectIndicator18; v11.Clean = value; _borrowerSelectIndicator18 = v11;
                var v12 = _borrowerSelectIndicator19; v12.Clean = value; _borrowerSelectIndicator19 = v12;
                var v13 = _borrowerSelectIndicator2; v13.Clean = value; _borrowerSelectIndicator2 = v13;
                var v14 = _borrowerSelectIndicator20; v14.Clean = value; _borrowerSelectIndicator20 = v14;
                var v15 = _borrowerSelectIndicator3; v15.Clean = value; _borrowerSelectIndicator3 = v15;
                var v16 = _borrowerSelectIndicator4; v16.Clean = value; _borrowerSelectIndicator4 = v16;
                var v17 = _borrowerSelectIndicator5; v17.Clean = value; _borrowerSelectIndicator5 = v17;
                var v18 = _borrowerSelectIndicator6; v18.Clean = value; _borrowerSelectIndicator6 = v18;
                var v19 = _borrowerSelectIndicator7; v19.Clean = value; _borrowerSelectIndicator7 = v19;
                var v20 = _borrowerSelectIndicator8; v20.Clean = value; _borrowerSelectIndicator8 = v20;
                var v21 = _borrowerSelectIndicator9; v21.Clean = value; _borrowerSelectIndicator9 = v21;
                var v22 = _brokerAdditionalFees; v22.Clean = value; _brokerAdditionalFees = v22;
                var v23 = _brokerFees; v23.Clean = value; _brokerFees = v23;
                var v24 = _brokerFeesPercentage; v24.Clean = value; _brokerFeesPercentage = v24;
                var v25 = _chargeAmount; v25.Clean = value; _chargeAmount = v25;
                var v26 = _chargeAmountForPrint; v26.Clean = value; _chargeAmountForPrint = v26;
                var v27 = _copyFromGfeIndicator1; v27.Clean = value; _copyFromGfeIndicator1 = v27;
                var v28 = _copyFromGfeIndicator10; v28.Clean = value; _copyFromGfeIndicator10 = v28;
                var v29 = _copyFromGfeIndicator11; v29.Clean = value; _copyFromGfeIndicator11 = v29;
                var v30 = _copyFromGfeIndicator12; v30.Clean = value; _copyFromGfeIndicator12 = v30;
                var v31 = _copyFromGfeIndicator13; v31.Clean = value; _copyFromGfeIndicator13 = v31;
                var v32 = _copyFromGfeIndicator14; v32.Clean = value; _copyFromGfeIndicator14 = v32;
                var v33 = _copyFromGfeIndicator15; v33.Clean = value; _copyFromGfeIndicator15 = v33;
                var v34 = _copyFromGfeIndicator16; v34.Clean = value; _copyFromGfeIndicator16 = v34;
                var v35 = _copyFromGfeIndicator17; v35.Clean = value; _copyFromGfeIndicator17 = v35;
                var v36 = _copyFromGfeIndicator18; v36.Clean = value; _copyFromGfeIndicator18 = v36;
                var v37 = _copyFromGfeIndicator19; v37.Clean = value; _copyFromGfeIndicator19 = v37;
                var v38 = _copyFromGfeIndicator2; v38.Clean = value; _copyFromGfeIndicator2 = v38;
                var v39 = _copyFromGfeIndicator20; v39.Clean = value; _copyFromGfeIndicator20 = v39;
                var v40 = _copyFromGfeIndicator21; v40.Clean = value; _copyFromGfeIndicator21 = v40;
                var v41 = _copyFromGfeIndicator22; v41.Clean = value; _copyFromGfeIndicator22 = v41;
                var v42 = _copyFromGfeIndicator23; v42.Clean = value; _copyFromGfeIndicator23 = v42;
                var v43 = _copyFromGfeIndicator24; v43.Clean = value; _copyFromGfeIndicator24 = v43;
                var v44 = _copyFromGfeIndicator25; v44.Clean = value; _copyFromGfeIndicator25 = v44;
                var v45 = _copyFromGfeIndicator26; v45.Clean = value; _copyFromGfeIndicator26 = v45;
                var v46 = _copyFromGfeIndicator27; v46.Clean = value; _copyFromGfeIndicator27 = v46;
                var v47 = _copyFromGfeIndicator28; v47.Clean = value; _copyFromGfeIndicator28 = v47;
                var v48 = _copyFromGfeIndicator29; v48.Clean = value; _copyFromGfeIndicator29 = v48;
                var v49 = _copyFromGfeIndicator3; v49.Clean = value; _copyFromGfeIndicator3 = v49;
                var v50 = _copyFromGfeIndicator30; v50.Clean = value; _copyFromGfeIndicator30 = v50;
                var v51 = _copyFromGfeIndicator31; v51.Clean = value; _copyFromGfeIndicator31 = v51;
                var v52 = _copyFromGfeIndicator32; v52.Clean = value; _copyFromGfeIndicator32 = v52;
                var v53 = _copyFromGfeIndicator33; v53.Clean = value; _copyFromGfeIndicator33 = v53;
                var v54 = _copyFromGfeIndicator34; v54.Clean = value; _copyFromGfeIndicator34 = v54;
                var v55 = _copyFromGfeIndicator35; v55.Clean = value; _copyFromGfeIndicator35 = v55;
                var v56 = _copyFromGfeIndicator4; v56.Clean = value; _copyFromGfeIndicator4 = v56;
                var v57 = _copyFromGfeIndicator5; v57.Clean = value; _copyFromGfeIndicator5 = v57;
                var v58 = _copyFromGfeIndicator6; v58.Clean = value; _copyFromGfeIndicator6 = v58;
                var v59 = _copyFromGfeIndicator7; v59.Clean = value; _copyFromGfeIndicator7 = v59;
                var v60 = _copyFromGfeIndicator8; v60.Clean = value; _copyFromGfeIndicator8 = v60;
                var v61 = _copyFromGfeIndicator9; v61.Clean = value; _copyFromGfeIndicator9 = v61;
                var v62 = _creditAmount; v62.Clean = value; _creditAmount = v62;
                var v63 = _creditAmountForPrint; v63.Clean = value; _creditAmountForPrint = v63;
                var v64 = _creditChargeType; v64.Clean = value; _creditChargeType = v64;
                var v65 = _creditOrChange; v65.Clean = value; _creditOrChange = v65;
                var v66 = _curedAdjustedOriginationCharges; v66.Clean = value; _curedAdjustedOriginationCharges = v66;
                var v67 = _curedCreditOrChange; v67.Clean = value; _curedCreditOrChange = v67;
                var v68 = _curedOriginationCharges; v68.Clean = value; _curedOriginationCharges = v68;
                var v69 = _curedTotalTransferTaxes; v69.Clean = value; _curedTotalTransferTaxes = v69;
                var v70 = _dailyInterestCharges; v70.Clean = value; _dailyInterestCharges = v70;
                var v71 = _dateForCharges; v71.Clean = value; _dateForCharges = v71;
                var v72 = _dateForRate; v72.Clean = value; _dateForRate = v72;
                var v73 = _daysToSettlement; v73.Clean = value; _daysToSettlement = v73;
                var v74 = _durationMonths; v74.Clean = value; _durationMonths = v74;
                var v75 = _escrowChargeAllInsuranceIndicator; v75.Clean = value; _escrowChargeAllInsuranceIndicator = v75;
                var v76 = _escrowChargeAllPropertyTaxesIndicator; v76.Clean = value; _escrowChargeAllPropertyTaxesIndicator = v76;
                var v77 = _escrowChargeOtherIndicator; v77.Clean = value; _escrowChargeOtherIndicator = v77;
                var v78 = _escrowOtherDescription; v78.Clean = value; _escrowOtherDescription = v78;
                var v79 = _financedFeesFromPrepaid; v79.Clean = value; _financedFeesFromPrepaid = v79;
                var v80 = _gfe2010Fees; v80.Clean = value; _gfe2010Fees = v80;
                var v81 = _gfe2010WholePocs; v81.Clean = value; _gfe2010WholePocs = v81;
                var v82 = _gfeGovernmentRecordingCharges; v82.Clean = value; _gfeGovernmentRecordingCharges = v82;
                var v83 = _hazardInsurance; v83.Clean = value; _hazardInsurance = v83;
                var v84 = _homeownerInsurance; v84.Clean = value; _homeownerInsurance = v84;
                var v85 = _hudGuaranteeFee; v85.Clean = value; _hudGuaranteeFee = v85;
                var v86 = _id; v86.Clean = value; _id = v86;
                var v87 = _includeOriginationPointsCreditType; v87.Clean = value; _includeOriginationPointsCreditType = v87;
                var v88 = _initialLoanAmount; v88.Clean = value; _initialLoanAmount = v88;
                var v89 = _initialMonthlyAmount; v89.Clean = value; _initialMonthlyAmount = v89;
                var v90 = _interestRateRiseIndicator; v90.Clean = value; _interestRateRiseIndicator = v90;
                var v91 = _isCDValidForEarliestClosingDate; v91.Clean = value; _isCDValidForEarliestClosingDate = v91;
                var v92 = _line1001Fee; v92.Clean = value; _line1001Fee = v92;
                var v93 = _line1002Fee; v93.Clean = value; _line1002Fee = v93;
                var v94 = _line1003Fee; v94.Clean = value; _line1003Fee = v94;
                var v95 = _line1004Fee; v95.Clean = value; _line1004Fee = v95;
                var v96 = _line1005Fee; v96.Clean = value; _line1005Fee = v96;
                var v97 = _line1006Fee; v97.Clean = value; _line1006Fee = v97;
                var v98 = _line1007Fee; v98.Clean = value; _line1007Fee = v98;
                var v99 = _line1008Fee; v99.Clean = value; _line1008Fee = v99;
                var v100 = _line1009Fee; v100.Clean = value; _line1009Fee = v100;
                var v101 = _line801BrokerCompensationAdditionalAmount; v101.Clean = value; _line801BrokerCompensationAdditionalAmount = v101;
                var v102 = _line801BrokerCompensationFees; v102.Clean = value; _line801BrokerCompensationFees = v102;
                var v103 = _line801BrokerCompensationRate; v103.Clean = value; _line801BrokerCompensationRate = v103;
                var v104 = _line808Fee; v104.Clean = value; _line808Fee = v104;
                var v105 = _line809Fee; v105.Clean = value; _line809Fee = v105;
                var v106 = _line810Fee; v106.Clean = value; _line810Fee = v106;
                var v107 = _line811Fee; v107.Clean = value; _line811Fee = v107;
                var v108 = _line812Fee; v108.Clean = value; _line812Fee = v108;
                var v109 = _line813Fee; v109.Clean = value; _line813Fee = v109;
                var v110 = _line814Fee; v110.Clean = value; _line814Fee = v110;
                var v111 = _line815Fee; v111.Clean = value; _line815Fee = v111;
                var v112 = _line816Fee; v112.Clean = value; _line816Fee = v112;
                var v113 = _line817Fee; v113.Clean = value; _line817Fee = v113;
                var v114 = _line818Fee; v114.Clean = value; _line818Fee = v114;
                var v115 = _line819Fee; v115.Clean = value; _line819Fee = v115;
                var v116 = _line820Fee; v116.Clean = value; _line820Fee = v116;
                var v117 = _line821Fee; v117.Clean = value; _line821Fee = v117;
                var v118 = _line822Fee; v118.Clean = value; _line822Fee = v118;
                var v119 = _line823Fee; v119.Clean = value; _line823Fee = v119;
                var v120 = _line824Fee; v120.Clean = value; _line824Fee = v120;
                var v121 = _line825Fee; v121.Clean = value; _line825Fee = v121;
                var v122 = _line826Fee; v122.Clean = value; _line826Fee = v122;
                var v123 = _line827Fee; v123.Clean = value; _line827Fee = v123;
                var v124 = _line828Fee; v124.Clean = value; _line828Fee = v124;
                var v125 = _line829Fee; v125.Clean = value; _line829Fee = v125;
                var v126 = _line830Fee; v126.Clean = value; _line830Fee = v126;
                var v127 = _line831Fee; v127.Clean = value; _line831Fee = v127;
                var v128 = _line832Fee; v128.Clean = value; _line832Fee = v128;
                var v129 = _line833Fee; v129.Clean = value; _line833Fee = v129;
                var v130 = _loanBalanceRiseIndicator; v130.Clean = value; _loanBalanceRiseIndicator = v130;
                var v131 = _loanOriginationFees; v131.Clean = value; _loanOriginationFees = v131;
                var v132 = _loanOriginationPercentage; v132.Clean = value; _loanOriginationPercentage = v132;
                var v133 = _loanOriginatorName; v133.Clean = value; _loanOriginatorName = v133;
                var v134 = _lowerInterestInitialInterestRate; v134.Clean = value; _lowerInterestInitialInterestRate = v134;
                var v135 = _lowerInterestInitialMonthlyAmountOwed; v135.Clean = value; _lowerInterestInitialMonthlyAmountOwed = v135;
                var v136 = _lowerInterestMonthlyPaymentReduced; v136.Clean = value; _lowerInterestMonthlyPaymentReduced = v136;
                var v137 = _lowerInterestServiceChargeIncreasedAmount; v137.Clean = value; _lowerInterestServiceChargeIncreasedAmount = v137;
                var v138 = _lowerInterestTotalSettlementCharges; v138.Clean = value; _lowerInterestTotalSettlementCharges = v138;
                var v139 = _lowerSettlementInitialInterestRate; v139.Clean = value; _lowerSettlementInitialInterestRate = v139;
                var v140 = _lowerSettlementInitialMonthlyAmountOwed; v140.Clean = value; _lowerSettlementInitialMonthlyAmountOwed = v140;
                var v141 = _lowerSettlementMonthlyPaymentIncreased; v141.Clean = value; _lowerSettlementMonthlyPaymentIncreased = v141;
                var v142 = _lowerSettlementServiceChargeReducedAmount; v142.Clean = value; _lowerSettlementServiceChargeReducedAmount = v142;
                var v143 = _lowerSettlementTotalSettlementCharges; v143.Clean = value; _lowerSettlementTotalSettlementCharges = v143;
                var v144 = _maximumLoanBalance; v144.Clean = value; _maximumLoanBalance = v144;
                var v145 = _maximumOwedMonthlyPayment; v145.Clean = value; _maximumOwedMonthlyPayment = v145;
                var v146 = _maxLifeInterestCapPercent; v146.Clean = value; _maxLifeInterestCapPercent = v146;
                var v147 = _monthlyPaymentFirstIncreaseDate; v147.Clean = value; _monthlyPaymentFirstIncreaseDate = v147;
                var v148 = _monthlyPaymentRiseIndicator; v148.Clean = value; _monthlyPaymentRiseIndicator = v148;
                var v149 = _mortgageInsurancePremium; v149.Clean = value; _mortgageInsurancePremium = v149;
                var v150 = _mustLockRateDays; v150.Clean = value; _mustLockRateDays = v150;
                var v151 = _newHudSection1100Line1104BorPaidAmount; v151.Clean = value; _newHudSection1100Line1104BorPaidAmount = v151;
                var v152 = _newHudSection1100Line1104SelPaidAmount; v152.Clean = value; _newHudSection1100Line1104SelPaidAmount = v152;
                var v153 = _newHudSection1100Line1107BorPaidAmount; v153.Clean = value; _newHudSection1100Line1107BorPaidAmount = v153;
                var v154 = _newHudSection1100Line1108BorPaidAmount; v154.Clean = value; _newHudSection1100Line1108BorPaidAmount = v154;
                var v155 = _originationCharges; v155.Clean = value; _originationCharges = v155;
                var v156 = _originationCreditYsp; v156.Clean = value; _originationCreditYsp = v156;
                var v157 = _originationCreditYspAdditional; v157.Clean = value; _originationCreditYspAdditional = v157;
                var v158 = _originationPoints; v158.Clean = value; _originationPoints = v158;
                var v159 = _originationPointsAdditional; v159.Clean = value; _originationPointsAdditional = v159;
                var v160 = _originationPointsPercentage; v160.Clean = value; _originationPointsPercentage = v160;
                var v161 = _ownerTitleInsuranceAmount; v161.Clean = value; _ownerTitleInsuranceAmount = v161;
                var v162 = _printNAInLockRateDays; v162.Clean = value; _printNAInLockRateDays = v162;
                var v163 = _printShoppingChartIndicator; v163.Clean = value; _printShoppingChartIndicator = v163;
                var v164 = _processingFees; v164.Clean = value; _processingFees = v164;
                var v165 = _requiredAppraisalFee; v165.Clean = value; _requiredAppraisalFee = v165;
                var v166 = _requiredCreditReportFee; v166.Clean = value; _requiredCreditReportFee = v166;
                var v167 = _requiredFloodCertificationFee; v167.Clean = value; _requiredFloodCertificationFee = v167;
                var v168 = _requiredServicesAmount; v168.Clean = value; _requiredServicesAmount = v168;
                var v169 = _requiredTaxServiceFee; v169.Clean = value; _requiredTaxServiceFee = v169;
                var v170 = _section1000TotalBorrowerPaidAmount; v170.Clean = value; _section1000TotalBorrowerPaidAmount = v170;
                var v171 = _section1000TotalOtherPaidAmount; v171.Clean = value; _section1000TotalOtherPaidAmount = v171;
                var v172 = _section1000TotalPaidAmount; v172.Clean = value; _section1000TotalPaidAmount = v172;
                var v173 = _section1000TotalSellerPaidAmount; v173.Clean = value; _section1000TotalSellerPaidAmount = v173;
                var v174 = _section1100TotalBorrowerPaidAmount; v174.Clean = value; _section1100TotalBorrowerPaidAmount = v174;
                var v175 = _section1100TotalOtherPaidAmount; v175.Clean = value; _section1100TotalOtherPaidAmount = v175;
                var v176 = _section1100TotalPaidAmount; v176.Clean = value; _section1100TotalPaidAmount = v176;
                var v177 = _section1100TotalSellerPaidAmount; v177.Clean = value; _section1100TotalSellerPaidAmount = v177;
                var v178 = _section1200TotalBorrowerPaidAmount; v178.Clean = value; _section1200TotalBorrowerPaidAmount = v178;
                var v179 = _section1200TotalOtherPaidAmount; v179.Clean = value; _section1200TotalOtherPaidAmount = v179;
                var v180 = _section1200TotalPaidAmount; v180.Clean = value; _section1200TotalPaidAmount = v180;
                var v181 = _section1200TotalSellerPaidAmount; v181.Clean = value; _section1200TotalSellerPaidAmount = v181;
                var v182 = _section1300TotalBorrowerPaidAmount; v182.Clean = value; _section1300TotalBorrowerPaidAmount = v182;
                var v183 = _section1300TotalOtherPaidAmount; v183.Clean = value; _section1300TotalOtherPaidAmount = v183;
                var v184 = _section1300TotalPaidAmount; v184.Clean = value; _section1300TotalPaidAmount = v184;
                var v185 = _section1300TotalSellerPaidAmount; v185.Clean = value; _section1300TotalSellerPaidAmount = v185;
                var v186 = _section1400TotalBorrowerPaidAmount; v186.Clean = value; _section1400TotalBorrowerPaidAmount = v186;
                var v187 = _section1400TotalOtherPaidAmount; v187.Clean = value; _section1400TotalOtherPaidAmount = v187;
                var v188 = _section1400TotalPaidAmount; v188.Clean = value; _section1400TotalPaidAmount = v188;
                var v189 = _section1400TotalSellerPaidAmount; v189.Clean = value; _section1400TotalSellerPaidAmount = v189;
                var v190 = _section700TotalBorrowerPaidAmount; v190.Clean = value; _section700TotalBorrowerPaidAmount = v190;
                var v191 = _section700TotalOtherPaidAmount; v191.Clean = value; _section700TotalOtherPaidAmount = v191;
                var v192 = _section700TotalPaidAmount; v192.Clean = value; _section700TotalPaidAmount = v192;
                var v193 = _section700TotalSellerPaidAmount; v193.Clean = value; _section700TotalSellerPaidAmount = v193;
                var v194 = _section800TotalBorrowerPaidAmount; v194.Clean = value; _section800TotalBorrowerPaidAmount = v194;
                var v195 = _section800TotalOtherPaidAmount; v195.Clean = value; _section800TotalOtherPaidAmount = v195;
                var v196 = _section800TotalPaidAmount; v196.Clean = value; _section800TotalPaidAmount = v196;
                var v197 = _section800TotalSellerPaidAmount; v197.Clean = value; _section800TotalSellerPaidAmount = v197;
                var v198 = _section900TotalBorrowerPaidAmount; v198.Clean = value; _section900TotalBorrowerPaidAmount = v198;
                var v199 = _section900TotalOtherPaidAmount; v199.Clean = value; _section900TotalOtherPaidAmount = v199;
                var v200 = _section900TotalPaidAmount; v200.Clean = value; _section900TotalPaidAmount = v200;
                var v201 = _section900TotalSellerPaidAmount; v201.Clean = value; _section900TotalSellerPaidAmount = v201;
                var v202 = _shopRequiredServicesAmount; v202.Clean = value; _shopRequiredServicesAmount = v202;
                var v203 = _subsequentCapPercent; v203.Clean = value; _subsequentCapPercent = v203;
                var v204 = _subsequentRateAdjustmentMonths; v204.Clean = value; _subsequentRateAdjustmentMonths = v204;
                var v205 = _tableFundedIndicator; v205.Clean = value; _tableFundedIndicator = v205;
                var v206 = _timeForRate; v206.Clean = value; _timeForRate = v206;
                var v207 = _titleServiceAmount; v207.Clean = value; _titleServiceAmount = v207;
                var v208 = _totalBelow10; v208.Clean = value; _totalBelow10 = v208;
                var v209 = _totalOfFinancedFees; v209.Clean = value; _totalOfFinancedFees = v209;
                var v210 = _totalSettlementCharges; v210.Clean = value; _totalSettlementCharges = v210;
                var v211 = _totalTransferTaxes; v211.Clean = value; _totalTransferTaxes = v211;
                var v212 = _transferTaxes; v212.Clean = value; _transferTaxes = v212;
                var v213 = _underwritingFees; v213.Clean = value; _underwritingFees = v213;
                var v214 = _useLOCompTool; v214.Clean = value; _useLOCompTool = v214;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}