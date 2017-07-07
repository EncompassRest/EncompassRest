using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
        private Value<NA<decimal>?> _ownerTitleInsuranceAmount;
        public NA<decimal>? OwnerTitleInsuranceAmount { get { return _ownerTitleInsuranceAmount; } set { _ownerTitleInsuranceAmount = value; } }
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
                var adjustedOriginationCharges = _adjustedOriginationCharges; adjustedOriginationCharges.Clean = value; _adjustedOriginationCharges = adjustedOriginationCharges;
                var allOtherServiceAmount = _allOtherServiceAmount; allOtherServiceAmount.Clean = value; _allOtherServiceAmount = allOtherServiceAmount;
                var applicationFees = _applicationFees; applicationFees.Clean = value; _applicationFees = applicationFees;
                var borrowerSelectIndicator10 = _borrowerSelectIndicator10; borrowerSelectIndicator10.Clean = value; _borrowerSelectIndicator10 = borrowerSelectIndicator10;
                var borrowerSelectIndicator11 = _borrowerSelectIndicator11; borrowerSelectIndicator11.Clean = value; _borrowerSelectIndicator11 = borrowerSelectIndicator11;
                var borrowerSelectIndicator12 = _borrowerSelectIndicator12; borrowerSelectIndicator12.Clean = value; _borrowerSelectIndicator12 = borrowerSelectIndicator12;
                var borrowerSelectIndicator13 = _borrowerSelectIndicator13; borrowerSelectIndicator13.Clean = value; _borrowerSelectIndicator13 = borrowerSelectIndicator13;
                var borrowerSelectIndicator14 = _borrowerSelectIndicator14; borrowerSelectIndicator14.Clean = value; _borrowerSelectIndicator14 = borrowerSelectIndicator14;
                var borrowerSelectIndicator15 = _borrowerSelectIndicator15; borrowerSelectIndicator15.Clean = value; _borrowerSelectIndicator15 = borrowerSelectIndicator15;
                var borrowerSelectIndicator16 = _borrowerSelectIndicator16; borrowerSelectIndicator16.Clean = value; _borrowerSelectIndicator16 = borrowerSelectIndicator16;
                var borrowerSelectIndicator17 = _borrowerSelectIndicator17; borrowerSelectIndicator17.Clean = value; _borrowerSelectIndicator17 = borrowerSelectIndicator17;
                var borrowerSelectIndicator18 = _borrowerSelectIndicator18; borrowerSelectIndicator18.Clean = value; _borrowerSelectIndicator18 = borrowerSelectIndicator18;
                var borrowerSelectIndicator19 = _borrowerSelectIndicator19; borrowerSelectIndicator19.Clean = value; _borrowerSelectIndicator19 = borrowerSelectIndicator19;
                var borrowerSelectIndicator2 = _borrowerSelectIndicator2; borrowerSelectIndicator2.Clean = value; _borrowerSelectIndicator2 = borrowerSelectIndicator2;
                var borrowerSelectIndicator20 = _borrowerSelectIndicator20; borrowerSelectIndicator20.Clean = value; _borrowerSelectIndicator20 = borrowerSelectIndicator20;
                var borrowerSelectIndicator3 = _borrowerSelectIndicator3; borrowerSelectIndicator3.Clean = value; _borrowerSelectIndicator3 = borrowerSelectIndicator3;
                var borrowerSelectIndicator4 = _borrowerSelectIndicator4; borrowerSelectIndicator4.Clean = value; _borrowerSelectIndicator4 = borrowerSelectIndicator4;
                var borrowerSelectIndicator5 = _borrowerSelectIndicator5; borrowerSelectIndicator5.Clean = value; _borrowerSelectIndicator5 = borrowerSelectIndicator5;
                var borrowerSelectIndicator6 = _borrowerSelectIndicator6; borrowerSelectIndicator6.Clean = value; _borrowerSelectIndicator6 = borrowerSelectIndicator6;
                var borrowerSelectIndicator7 = _borrowerSelectIndicator7; borrowerSelectIndicator7.Clean = value; _borrowerSelectIndicator7 = borrowerSelectIndicator7;
                var borrowerSelectIndicator8 = _borrowerSelectIndicator8; borrowerSelectIndicator8.Clean = value; _borrowerSelectIndicator8 = borrowerSelectIndicator8;
                var borrowerSelectIndicator9 = _borrowerSelectIndicator9; borrowerSelectIndicator9.Clean = value; _borrowerSelectIndicator9 = borrowerSelectIndicator9;
                var brokerAdditionalFees = _brokerAdditionalFees; brokerAdditionalFees.Clean = value; _brokerAdditionalFees = brokerAdditionalFees;
                var brokerFees = _brokerFees; brokerFees.Clean = value; _brokerFees = brokerFees;
                var brokerFeesPercentage = _brokerFeesPercentage; brokerFeesPercentage.Clean = value; _brokerFeesPercentage = brokerFeesPercentage;
                var chargeAmount = _chargeAmount; chargeAmount.Clean = value; _chargeAmount = chargeAmount;
                var chargeAmountForPrint = _chargeAmountForPrint; chargeAmountForPrint.Clean = value; _chargeAmountForPrint = chargeAmountForPrint;
                var copyFromGfeIndicator1 = _copyFromGfeIndicator1; copyFromGfeIndicator1.Clean = value; _copyFromGfeIndicator1 = copyFromGfeIndicator1;
                var copyFromGfeIndicator10 = _copyFromGfeIndicator10; copyFromGfeIndicator10.Clean = value; _copyFromGfeIndicator10 = copyFromGfeIndicator10;
                var copyFromGfeIndicator11 = _copyFromGfeIndicator11; copyFromGfeIndicator11.Clean = value; _copyFromGfeIndicator11 = copyFromGfeIndicator11;
                var copyFromGfeIndicator12 = _copyFromGfeIndicator12; copyFromGfeIndicator12.Clean = value; _copyFromGfeIndicator12 = copyFromGfeIndicator12;
                var copyFromGfeIndicator13 = _copyFromGfeIndicator13; copyFromGfeIndicator13.Clean = value; _copyFromGfeIndicator13 = copyFromGfeIndicator13;
                var copyFromGfeIndicator14 = _copyFromGfeIndicator14; copyFromGfeIndicator14.Clean = value; _copyFromGfeIndicator14 = copyFromGfeIndicator14;
                var copyFromGfeIndicator15 = _copyFromGfeIndicator15; copyFromGfeIndicator15.Clean = value; _copyFromGfeIndicator15 = copyFromGfeIndicator15;
                var copyFromGfeIndicator16 = _copyFromGfeIndicator16; copyFromGfeIndicator16.Clean = value; _copyFromGfeIndicator16 = copyFromGfeIndicator16;
                var copyFromGfeIndicator17 = _copyFromGfeIndicator17; copyFromGfeIndicator17.Clean = value; _copyFromGfeIndicator17 = copyFromGfeIndicator17;
                var copyFromGfeIndicator18 = _copyFromGfeIndicator18; copyFromGfeIndicator18.Clean = value; _copyFromGfeIndicator18 = copyFromGfeIndicator18;
                var copyFromGfeIndicator19 = _copyFromGfeIndicator19; copyFromGfeIndicator19.Clean = value; _copyFromGfeIndicator19 = copyFromGfeIndicator19;
                var copyFromGfeIndicator2 = _copyFromGfeIndicator2; copyFromGfeIndicator2.Clean = value; _copyFromGfeIndicator2 = copyFromGfeIndicator2;
                var copyFromGfeIndicator20 = _copyFromGfeIndicator20; copyFromGfeIndicator20.Clean = value; _copyFromGfeIndicator20 = copyFromGfeIndicator20;
                var copyFromGfeIndicator21 = _copyFromGfeIndicator21; copyFromGfeIndicator21.Clean = value; _copyFromGfeIndicator21 = copyFromGfeIndicator21;
                var copyFromGfeIndicator22 = _copyFromGfeIndicator22; copyFromGfeIndicator22.Clean = value; _copyFromGfeIndicator22 = copyFromGfeIndicator22;
                var copyFromGfeIndicator23 = _copyFromGfeIndicator23; copyFromGfeIndicator23.Clean = value; _copyFromGfeIndicator23 = copyFromGfeIndicator23;
                var copyFromGfeIndicator24 = _copyFromGfeIndicator24; copyFromGfeIndicator24.Clean = value; _copyFromGfeIndicator24 = copyFromGfeIndicator24;
                var copyFromGfeIndicator25 = _copyFromGfeIndicator25; copyFromGfeIndicator25.Clean = value; _copyFromGfeIndicator25 = copyFromGfeIndicator25;
                var copyFromGfeIndicator26 = _copyFromGfeIndicator26; copyFromGfeIndicator26.Clean = value; _copyFromGfeIndicator26 = copyFromGfeIndicator26;
                var copyFromGfeIndicator27 = _copyFromGfeIndicator27; copyFromGfeIndicator27.Clean = value; _copyFromGfeIndicator27 = copyFromGfeIndicator27;
                var copyFromGfeIndicator28 = _copyFromGfeIndicator28; copyFromGfeIndicator28.Clean = value; _copyFromGfeIndicator28 = copyFromGfeIndicator28;
                var copyFromGfeIndicator29 = _copyFromGfeIndicator29; copyFromGfeIndicator29.Clean = value; _copyFromGfeIndicator29 = copyFromGfeIndicator29;
                var copyFromGfeIndicator3 = _copyFromGfeIndicator3; copyFromGfeIndicator3.Clean = value; _copyFromGfeIndicator3 = copyFromGfeIndicator3;
                var copyFromGfeIndicator30 = _copyFromGfeIndicator30; copyFromGfeIndicator30.Clean = value; _copyFromGfeIndicator30 = copyFromGfeIndicator30;
                var copyFromGfeIndicator31 = _copyFromGfeIndicator31; copyFromGfeIndicator31.Clean = value; _copyFromGfeIndicator31 = copyFromGfeIndicator31;
                var copyFromGfeIndicator32 = _copyFromGfeIndicator32; copyFromGfeIndicator32.Clean = value; _copyFromGfeIndicator32 = copyFromGfeIndicator32;
                var copyFromGfeIndicator33 = _copyFromGfeIndicator33; copyFromGfeIndicator33.Clean = value; _copyFromGfeIndicator33 = copyFromGfeIndicator33;
                var copyFromGfeIndicator34 = _copyFromGfeIndicator34; copyFromGfeIndicator34.Clean = value; _copyFromGfeIndicator34 = copyFromGfeIndicator34;
                var copyFromGfeIndicator35 = _copyFromGfeIndicator35; copyFromGfeIndicator35.Clean = value; _copyFromGfeIndicator35 = copyFromGfeIndicator35;
                var copyFromGfeIndicator4 = _copyFromGfeIndicator4; copyFromGfeIndicator4.Clean = value; _copyFromGfeIndicator4 = copyFromGfeIndicator4;
                var copyFromGfeIndicator5 = _copyFromGfeIndicator5; copyFromGfeIndicator5.Clean = value; _copyFromGfeIndicator5 = copyFromGfeIndicator5;
                var copyFromGfeIndicator6 = _copyFromGfeIndicator6; copyFromGfeIndicator6.Clean = value; _copyFromGfeIndicator6 = copyFromGfeIndicator6;
                var copyFromGfeIndicator7 = _copyFromGfeIndicator7; copyFromGfeIndicator7.Clean = value; _copyFromGfeIndicator7 = copyFromGfeIndicator7;
                var copyFromGfeIndicator8 = _copyFromGfeIndicator8; copyFromGfeIndicator8.Clean = value; _copyFromGfeIndicator8 = copyFromGfeIndicator8;
                var copyFromGfeIndicator9 = _copyFromGfeIndicator9; copyFromGfeIndicator9.Clean = value; _copyFromGfeIndicator9 = copyFromGfeIndicator9;
                var creditAmount = _creditAmount; creditAmount.Clean = value; _creditAmount = creditAmount;
                var creditAmountForPrint = _creditAmountForPrint; creditAmountForPrint.Clean = value; _creditAmountForPrint = creditAmountForPrint;
                var creditChargeType = _creditChargeType; creditChargeType.Clean = value; _creditChargeType = creditChargeType;
                var creditOrChange = _creditOrChange; creditOrChange.Clean = value; _creditOrChange = creditOrChange;
                var curedAdjustedOriginationCharges = _curedAdjustedOriginationCharges; curedAdjustedOriginationCharges.Clean = value; _curedAdjustedOriginationCharges = curedAdjustedOriginationCharges;
                var curedCreditOrChange = _curedCreditOrChange; curedCreditOrChange.Clean = value; _curedCreditOrChange = curedCreditOrChange;
                var curedOriginationCharges = _curedOriginationCharges; curedOriginationCharges.Clean = value; _curedOriginationCharges = curedOriginationCharges;
                var curedTotalTransferTaxes = _curedTotalTransferTaxes; curedTotalTransferTaxes.Clean = value; _curedTotalTransferTaxes = curedTotalTransferTaxes;
                var dailyInterestCharges = _dailyInterestCharges; dailyInterestCharges.Clean = value; _dailyInterestCharges = dailyInterestCharges;
                var dateForCharges = _dateForCharges; dateForCharges.Clean = value; _dateForCharges = dateForCharges;
                var dateForRate = _dateForRate; dateForRate.Clean = value; _dateForRate = dateForRate;
                var daysToSettlement = _daysToSettlement; daysToSettlement.Clean = value; _daysToSettlement = daysToSettlement;
                var durationMonths = _durationMonths; durationMonths.Clean = value; _durationMonths = durationMonths;
                var escrowChargeAllInsuranceIndicator = _escrowChargeAllInsuranceIndicator; escrowChargeAllInsuranceIndicator.Clean = value; _escrowChargeAllInsuranceIndicator = escrowChargeAllInsuranceIndicator;
                var escrowChargeAllPropertyTaxesIndicator = _escrowChargeAllPropertyTaxesIndicator; escrowChargeAllPropertyTaxesIndicator.Clean = value; _escrowChargeAllPropertyTaxesIndicator = escrowChargeAllPropertyTaxesIndicator;
                var escrowChargeOtherIndicator = _escrowChargeOtherIndicator; escrowChargeOtherIndicator.Clean = value; _escrowChargeOtherIndicator = escrowChargeOtherIndicator;
                var escrowOtherDescription = _escrowOtherDescription; escrowOtherDescription.Clean = value; _escrowOtherDescription = escrowOtherDescription;
                var financedFeesFromPrepaid = _financedFeesFromPrepaid; financedFeesFromPrepaid.Clean = value; _financedFeesFromPrepaid = financedFeesFromPrepaid;
                var gfe2010Fees = _gfe2010Fees; gfe2010Fees.Clean = value; _gfe2010Fees = gfe2010Fees;
                var gfe2010WholePocs = _gfe2010WholePocs; gfe2010WholePocs.Clean = value; _gfe2010WholePocs = gfe2010WholePocs;
                var gfeGovernmentRecordingCharges = _gfeGovernmentRecordingCharges; gfeGovernmentRecordingCharges.Clean = value; _gfeGovernmentRecordingCharges = gfeGovernmentRecordingCharges;
                var hazardInsurance = _hazardInsurance; hazardInsurance.Clean = value; _hazardInsurance = hazardInsurance;
                var homeownerInsurance = _homeownerInsurance; homeownerInsurance.Clean = value; _homeownerInsurance = homeownerInsurance;
                var hudGuaranteeFee = _hudGuaranteeFee; hudGuaranteeFee.Clean = value; _hudGuaranteeFee = hudGuaranteeFee;
                var id = _id; id.Clean = value; _id = id;
                var includeOriginationPointsCreditType = _includeOriginationPointsCreditType; includeOriginationPointsCreditType.Clean = value; _includeOriginationPointsCreditType = includeOriginationPointsCreditType;
                var initialLoanAmount = _initialLoanAmount; initialLoanAmount.Clean = value; _initialLoanAmount = initialLoanAmount;
                var initialMonthlyAmount = _initialMonthlyAmount; initialMonthlyAmount.Clean = value; _initialMonthlyAmount = initialMonthlyAmount;
                var interestRateRiseIndicator = _interestRateRiseIndicator; interestRateRiseIndicator.Clean = value; _interestRateRiseIndicator = interestRateRiseIndicator;
                var isCDValidForEarliestClosingDate = _isCDValidForEarliestClosingDate; isCDValidForEarliestClosingDate.Clean = value; _isCDValidForEarliestClosingDate = isCDValidForEarliestClosingDate;
                var line1001Fee = _line1001Fee; line1001Fee.Clean = value; _line1001Fee = line1001Fee;
                var line1002Fee = _line1002Fee; line1002Fee.Clean = value; _line1002Fee = line1002Fee;
                var line1003Fee = _line1003Fee; line1003Fee.Clean = value; _line1003Fee = line1003Fee;
                var line1004Fee = _line1004Fee; line1004Fee.Clean = value; _line1004Fee = line1004Fee;
                var line1005Fee = _line1005Fee; line1005Fee.Clean = value; _line1005Fee = line1005Fee;
                var line1006Fee = _line1006Fee; line1006Fee.Clean = value; _line1006Fee = line1006Fee;
                var line1007Fee = _line1007Fee; line1007Fee.Clean = value; _line1007Fee = line1007Fee;
                var line1008Fee = _line1008Fee; line1008Fee.Clean = value; _line1008Fee = line1008Fee;
                var line1009Fee = _line1009Fee; line1009Fee.Clean = value; _line1009Fee = line1009Fee;
                var line801BrokerCompensationAdditionalAmount = _line801BrokerCompensationAdditionalAmount; line801BrokerCompensationAdditionalAmount.Clean = value; _line801BrokerCompensationAdditionalAmount = line801BrokerCompensationAdditionalAmount;
                var line801BrokerCompensationFees = _line801BrokerCompensationFees; line801BrokerCompensationFees.Clean = value; _line801BrokerCompensationFees = line801BrokerCompensationFees;
                var line801BrokerCompensationRate = _line801BrokerCompensationRate; line801BrokerCompensationRate.Clean = value; _line801BrokerCompensationRate = line801BrokerCompensationRate;
                var line808Fee = _line808Fee; line808Fee.Clean = value; _line808Fee = line808Fee;
                var line809Fee = _line809Fee; line809Fee.Clean = value; _line809Fee = line809Fee;
                var line810Fee = _line810Fee; line810Fee.Clean = value; _line810Fee = line810Fee;
                var line811Fee = _line811Fee; line811Fee.Clean = value; _line811Fee = line811Fee;
                var line812Fee = _line812Fee; line812Fee.Clean = value; _line812Fee = line812Fee;
                var line813Fee = _line813Fee; line813Fee.Clean = value; _line813Fee = line813Fee;
                var line814Fee = _line814Fee; line814Fee.Clean = value; _line814Fee = line814Fee;
                var line815Fee = _line815Fee; line815Fee.Clean = value; _line815Fee = line815Fee;
                var line816Fee = _line816Fee; line816Fee.Clean = value; _line816Fee = line816Fee;
                var line817Fee = _line817Fee; line817Fee.Clean = value; _line817Fee = line817Fee;
                var line818Fee = _line818Fee; line818Fee.Clean = value; _line818Fee = line818Fee;
                var line819Fee = _line819Fee; line819Fee.Clean = value; _line819Fee = line819Fee;
                var line820Fee = _line820Fee; line820Fee.Clean = value; _line820Fee = line820Fee;
                var line821Fee = _line821Fee; line821Fee.Clean = value; _line821Fee = line821Fee;
                var line822Fee = _line822Fee; line822Fee.Clean = value; _line822Fee = line822Fee;
                var line823Fee = _line823Fee; line823Fee.Clean = value; _line823Fee = line823Fee;
                var line824Fee = _line824Fee; line824Fee.Clean = value; _line824Fee = line824Fee;
                var line825Fee = _line825Fee; line825Fee.Clean = value; _line825Fee = line825Fee;
                var line826Fee = _line826Fee; line826Fee.Clean = value; _line826Fee = line826Fee;
                var line827Fee = _line827Fee; line827Fee.Clean = value; _line827Fee = line827Fee;
                var line828Fee = _line828Fee; line828Fee.Clean = value; _line828Fee = line828Fee;
                var line829Fee = _line829Fee; line829Fee.Clean = value; _line829Fee = line829Fee;
                var line830Fee = _line830Fee; line830Fee.Clean = value; _line830Fee = line830Fee;
                var line831Fee = _line831Fee; line831Fee.Clean = value; _line831Fee = line831Fee;
                var line832Fee = _line832Fee; line832Fee.Clean = value; _line832Fee = line832Fee;
                var line833Fee = _line833Fee; line833Fee.Clean = value; _line833Fee = line833Fee;
                var loanBalanceRiseIndicator = _loanBalanceRiseIndicator; loanBalanceRiseIndicator.Clean = value; _loanBalanceRiseIndicator = loanBalanceRiseIndicator;
                var loanOriginationFees = _loanOriginationFees; loanOriginationFees.Clean = value; _loanOriginationFees = loanOriginationFees;
                var loanOriginationPercentage = _loanOriginationPercentage; loanOriginationPercentage.Clean = value; _loanOriginationPercentage = loanOriginationPercentage;
                var loanOriginatorName = _loanOriginatorName; loanOriginatorName.Clean = value; _loanOriginatorName = loanOriginatorName;
                var lowerInterestInitialInterestRate = _lowerInterestInitialInterestRate; lowerInterestInitialInterestRate.Clean = value; _lowerInterestInitialInterestRate = lowerInterestInitialInterestRate;
                var lowerInterestInitialMonthlyAmountOwed = _lowerInterestInitialMonthlyAmountOwed; lowerInterestInitialMonthlyAmountOwed.Clean = value; _lowerInterestInitialMonthlyAmountOwed = lowerInterestInitialMonthlyAmountOwed;
                var lowerInterestMonthlyPaymentReduced = _lowerInterestMonthlyPaymentReduced; lowerInterestMonthlyPaymentReduced.Clean = value; _lowerInterestMonthlyPaymentReduced = lowerInterestMonthlyPaymentReduced;
                var lowerInterestServiceChargeIncreasedAmount = _lowerInterestServiceChargeIncreasedAmount; lowerInterestServiceChargeIncreasedAmount.Clean = value; _lowerInterestServiceChargeIncreasedAmount = lowerInterestServiceChargeIncreasedAmount;
                var lowerInterestTotalSettlementCharges = _lowerInterestTotalSettlementCharges; lowerInterestTotalSettlementCharges.Clean = value; _lowerInterestTotalSettlementCharges = lowerInterestTotalSettlementCharges;
                var lowerSettlementInitialInterestRate = _lowerSettlementInitialInterestRate; lowerSettlementInitialInterestRate.Clean = value; _lowerSettlementInitialInterestRate = lowerSettlementInitialInterestRate;
                var lowerSettlementInitialMonthlyAmountOwed = _lowerSettlementInitialMonthlyAmountOwed; lowerSettlementInitialMonthlyAmountOwed.Clean = value; _lowerSettlementInitialMonthlyAmountOwed = lowerSettlementInitialMonthlyAmountOwed;
                var lowerSettlementMonthlyPaymentIncreased = _lowerSettlementMonthlyPaymentIncreased; lowerSettlementMonthlyPaymentIncreased.Clean = value; _lowerSettlementMonthlyPaymentIncreased = lowerSettlementMonthlyPaymentIncreased;
                var lowerSettlementServiceChargeReducedAmount = _lowerSettlementServiceChargeReducedAmount; lowerSettlementServiceChargeReducedAmount.Clean = value; _lowerSettlementServiceChargeReducedAmount = lowerSettlementServiceChargeReducedAmount;
                var lowerSettlementTotalSettlementCharges = _lowerSettlementTotalSettlementCharges; lowerSettlementTotalSettlementCharges.Clean = value; _lowerSettlementTotalSettlementCharges = lowerSettlementTotalSettlementCharges;
                var maximumLoanBalance = _maximumLoanBalance; maximumLoanBalance.Clean = value; _maximumLoanBalance = maximumLoanBalance;
                var maximumOwedMonthlyPayment = _maximumOwedMonthlyPayment; maximumOwedMonthlyPayment.Clean = value; _maximumOwedMonthlyPayment = maximumOwedMonthlyPayment;
                var maxLifeInterestCapPercent = _maxLifeInterestCapPercent; maxLifeInterestCapPercent.Clean = value; _maxLifeInterestCapPercent = maxLifeInterestCapPercent;
                var monthlyPaymentFirstIncreaseDate = _monthlyPaymentFirstIncreaseDate; monthlyPaymentFirstIncreaseDate.Clean = value; _monthlyPaymentFirstIncreaseDate = monthlyPaymentFirstIncreaseDate;
                var monthlyPaymentRiseIndicator = _monthlyPaymentRiseIndicator; monthlyPaymentRiseIndicator.Clean = value; _monthlyPaymentRiseIndicator = monthlyPaymentRiseIndicator;
                var mortgageInsurancePremium = _mortgageInsurancePremium; mortgageInsurancePremium.Clean = value; _mortgageInsurancePremium = mortgageInsurancePremium;
                var mustLockRateDays = _mustLockRateDays; mustLockRateDays.Clean = value; _mustLockRateDays = mustLockRateDays;
                var newHudSection1100Line1104BorPaidAmount = _newHudSection1100Line1104BorPaidAmount; newHudSection1100Line1104BorPaidAmount.Clean = value; _newHudSection1100Line1104BorPaidAmount = newHudSection1100Line1104BorPaidAmount;
                var newHudSection1100Line1104SelPaidAmount = _newHudSection1100Line1104SelPaidAmount; newHudSection1100Line1104SelPaidAmount.Clean = value; _newHudSection1100Line1104SelPaidAmount = newHudSection1100Line1104SelPaidAmount;
                var newHudSection1100Line1107BorPaidAmount = _newHudSection1100Line1107BorPaidAmount; newHudSection1100Line1107BorPaidAmount.Clean = value; _newHudSection1100Line1107BorPaidAmount = newHudSection1100Line1107BorPaidAmount;
                var newHudSection1100Line1108BorPaidAmount = _newHudSection1100Line1108BorPaidAmount; newHudSection1100Line1108BorPaidAmount.Clean = value; _newHudSection1100Line1108BorPaidAmount = newHudSection1100Line1108BorPaidAmount;
                var originationCharges = _originationCharges; originationCharges.Clean = value; _originationCharges = originationCharges;
                var originationCreditYsp = _originationCreditYsp; originationCreditYsp.Clean = value; _originationCreditYsp = originationCreditYsp;
                var originationCreditYspAdditional = _originationCreditYspAdditional; originationCreditYspAdditional.Clean = value; _originationCreditYspAdditional = originationCreditYspAdditional;
                var originationPoints = _originationPoints; originationPoints.Clean = value; _originationPoints = originationPoints;
                var originationPointsAdditional = _originationPointsAdditional; originationPointsAdditional.Clean = value; _originationPointsAdditional = originationPointsAdditional;
                var originationPointsPercentage = _originationPointsPercentage; originationPointsPercentage.Clean = value; _originationPointsPercentage = originationPointsPercentage;
                var ownerTitleInsuranceAmount = _ownerTitleInsuranceAmount; ownerTitleInsuranceAmount.Clean = value; _ownerTitleInsuranceAmount = ownerTitleInsuranceAmount;
                var printNAInLockRateDays = _printNAInLockRateDays; printNAInLockRateDays.Clean = value; _printNAInLockRateDays = printNAInLockRateDays;
                var printShoppingChartIndicator = _printShoppingChartIndicator; printShoppingChartIndicator.Clean = value; _printShoppingChartIndicator = printShoppingChartIndicator;
                var processingFees = _processingFees; processingFees.Clean = value; _processingFees = processingFees;
                var requiredAppraisalFee = _requiredAppraisalFee; requiredAppraisalFee.Clean = value; _requiredAppraisalFee = requiredAppraisalFee;
                var requiredCreditReportFee = _requiredCreditReportFee; requiredCreditReportFee.Clean = value; _requiredCreditReportFee = requiredCreditReportFee;
                var requiredFloodCertificationFee = _requiredFloodCertificationFee; requiredFloodCertificationFee.Clean = value; _requiredFloodCertificationFee = requiredFloodCertificationFee;
                var requiredServicesAmount = _requiredServicesAmount; requiredServicesAmount.Clean = value; _requiredServicesAmount = requiredServicesAmount;
                var requiredTaxServiceFee = _requiredTaxServiceFee; requiredTaxServiceFee.Clean = value; _requiredTaxServiceFee = requiredTaxServiceFee;
                var section1000TotalBorrowerPaidAmount = _section1000TotalBorrowerPaidAmount; section1000TotalBorrowerPaidAmount.Clean = value; _section1000TotalBorrowerPaidAmount = section1000TotalBorrowerPaidAmount;
                var section1000TotalOtherPaidAmount = _section1000TotalOtherPaidAmount; section1000TotalOtherPaidAmount.Clean = value; _section1000TotalOtherPaidAmount = section1000TotalOtherPaidAmount;
                var section1000TotalPaidAmount = _section1000TotalPaidAmount; section1000TotalPaidAmount.Clean = value; _section1000TotalPaidAmount = section1000TotalPaidAmount;
                var section1000TotalSellerPaidAmount = _section1000TotalSellerPaidAmount; section1000TotalSellerPaidAmount.Clean = value; _section1000TotalSellerPaidAmount = section1000TotalSellerPaidAmount;
                var section1100TotalBorrowerPaidAmount = _section1100TotalBorrowerPaidAmount; section1100TotalBorrowerPaidAmount.Clean = value; _section1100TotalBorrowerPaidAmount = section1100TotalBorrowerPaidAmount;
                var section1100TotalOtherPaidAmount = _section1100TotalOtherPaidAmount; section1100TotalOtherPaidAmount.Clean = value; _section1100TotalOtherPaidAmount = section1100TotalOtherPaidAmount;
                var section1100TotalPaidAmount = _section1100TotalPaidAmount; section1100TotalPaidAmount.Clean = value; _section1100TotalPaidAmount = section1100TotalPaidAmount;
                var section1100TotalSellerPaidAmount = _section1100TotalSellerPaidAmount; section1100TotalSellerPaidAmount.Clean = value; _section1100TotalSellerPaidAmount = section1100TotalSellerPaidAmount;
                var section1200TotalBorrowerPaidAmount = _section1200TotalBorrowerPaidAmount; section1200TotalBorrowerPaidAmount.Clean = value; _section1200TotalBorrowerPaidAmount = section1200TotalBorrowerPaidAmount;
                var section1200TotalOtherPaidAmount = _section1200TotalOtherPaidAmount; section1200TotalOtherPaidAmount.Clean = value; _section1200TotalOtherPaidAmount = section1200TotalOtherPaidAmount;
                var section1200TotalPaidAmount = _section1200TotalPaidAmount; section1200TotalPaidAmount.Clean = value; _section1200TotalPaidAmount = section1200TotalPaidAmount;
                var section1200TotalSellerPaidAmount = _section1200TotalSellerPaidAmount; section1200TotalSellerPaidAmount.Clean = value; _section1200TotalSellerPaidAmount = section1200TotalSellerPaidAmount;
                var section1300TotalBorrowerPaidAmount = _section1300TotalBorrowerPaidAmount; section1300TotalBorrowerPaidAmount.Clean = value; _section1300TotalBorrowerPaidAmount = section1300TotalBorrowerPaidAmount;
                var section1300TotalOtherPaidAmount = _section1300TotalOtherPaidAmount; section1300TotalOtherPaidAmount.Clean = value; _section1300TotalOtherPaidAmount = section1300TotalOtherPaidAmount;
                var section1300TotalPaidAmount = _section1300TotalPaidAmount; section1300TotalPaidAmount.Clean = value; _section1300TotalPaidAmount = section1300TotalPaidAmount;
                var section1300TotalSellerPaidAmount = _section1300TotalSellerPaidAmount; section1300TotalSellerPaidAmount.Clean = value; _section1300TotalSellerPaidAmount = section1300TotalSellerPaidAmount;
                var section1400TotalBorrowerPaidAmount = _section1400TotalBorrowerPaidAmount; section1400TotalBorrowerPaidAmount.Clean = value; _section1400TotalBorrowerPaidAmount = section1400TotalBorrowerPaidAmount;
                var section1400TotalOtherPaidAmount = _section1400TotalOtherPaidAmount; section1400TotalOtherPaidAmount.Clean = value; _section1400TotalOtherPaidAmount = section1400TotalOtherPaidAmount;
                var section1400TotalPaidAmount = _section1400TotalPaidAmount; section1400TotalPaidAmount.Clean = value; _section1400TotalPaidAmount = section1400TotalPaidAmount;
                var section1400TotalSellerPaidAmount = _section1400TotalSellerPaidAmount; section1400TotalSellerPaidAmount.Clean = value; _section1400TotalSellerPaidAmount = section1400TotalSellerPaidAmount;
                var section700TotalBorrowerPaidAmount = _section700TotalBorrowerPaidAmount; section700TotalBorrowerPaidAmount.Clean = value; _section700TotalBorrowerPaidAmount = section700TotalBorrowerPaidAmount;
                var section700TotalOtherPaidAmount = _section700TotalOtherPaidAmount; section700TotalOtherPaidAmount.Clean = value; _section700TotalOtherPaidAmount = section700TotalOtherPaidAmount;
                var section700TotalPaidAmount = _section700TotalPaidAmount; section700TotalPaidAmount.Clean = value; _section700TotalPaidAmount = section700TotalPaidAmount;
                var section700TotalSellerPaidAmount = _section700TotalSellerPaidAmount; section700TotalSellerPaidAmount.Clean = value; _section700TotalSellerPaidAmount = section700TotalSellerPaidAmount;
                var section800TotalBorrowerPaidAmount = _section800TotalBorrowerPaidAmount; section800TotalBorrowerPaidAmount.Clean = value; _section800TotalBorrowerPaidAmount = section800TotalBorrowerPaidAmount;
                var section800TotalOtherPaidAmount = _section800TotalOtherPaidAmount; section800TotalOtherPaidAmount.Clean = value; _section800TotalOtherPaidAmount = section800TotalOtherPaidAmount;
                var section800TotalPaidAmount = _section800TotalPaidAmount; section800TotalPaidAmount.Clean = value; _section800TotalPaidAmount = section800TotalPaidAmount;
                var section800TotalSellerPaidAmount = _section800TotalSellerPaidAmount; section800TotalSellerPaidAmount.Clean = value; _section800TotalSellerPaidAmount = section800TotalSellerPaidAmount;
                var section900TotalBorrowerPaidAmount = _section900TotalBorrowerPaidAmount; section900TotalBorrowerPaidAmount.Clean = value; _section900TotalBorrowerPaidAmount = section900TotalBorrowerPaidAmount;
                var section900TotalOtherPaidAmount = _section900TotalOtherPaidAmount; section900TotalOtherPaidAmount.Clean = value; _section900TotalOtherPaidAmount = section900TotalOtherPaidAmount;
                var section900TotalPaidAmount = _section900TotalPaidAmount; section900TotalPaidAmount.Clean = value; _section900TotalPaidAmount = section900TotalPaidAmount;
                var section900TotalSellerPaidAmount = _section900TotalSellerPaidAmount; section900TotalSellerPaidAmount.Clean = value; _section900TotalSellerPaidAmount = section900TotalSellerPaidAmount;
                var shopRequiredServicesAmount = _shopRequiredServicesAmount; shopRequiredServicesAmount.Clean = value; _shopRequiredServicesAmount = shopRequiredServicesAmount;
                var subsequentCapPercent = _subsequentCapPercent; subsequentCapPercent.Clean = value; _subsequentCapPercent = subsequentCapPercent;
                var subsequentRateAdjustmentMonths = _subsequentRateAdjustmentMonths; subsequentRateAdjustmentMonths.Clean = value; _subsequentRateAdjustmentMonths = subsequentRateAdjustmentMonths;
                var tableFundedIndicator = _tableFundedIndicator; tableFundedIndicator.Clean = value; _tableFundedIndicator = tableFundedIndicator;
                var timeForRate = _timeForRate; timeForRate.Clean = value; _timeForRate = timeForRate;
                var titleServiceAmount = _titleServiceAmount; titleServiceAmount.Clean = value; _titleServiceAmount = titleServiceAmount;
                var totalBelow10 = _totalBelow10; totalBelow10.Clean = value; _totalBelow10 = totalBelow10;
                var totalOfFinancedFees = _totalOfFinancedFees; totalOfFinancedFees.Clean = value; _totalOfFinancedFees = totalOfFinancedFees;
                var totalSettlementCharges = _totalSettlementCharges; totalSettlementCharges.Clean = value; _totalSettlementCharges = totalSettlementCharges;
                var totalTransferTaxes = _totalTransferTaxes; totalTransferTaxes.Clean = value; _totalTransferTaxes = totalTransferTaxes;
                var transferTaxes = _transferTaxes; transferTaxes.Clean = value; _transferTaxes = transferTaxes;
                var underwritingFees = _underwritingFees; underwritingFees.Clean = value; _underwritingFees = underwritingFees;
                var useLOCompTool = _useLOCompTool; useLOCompTool.Clean = value; _useLOCompTool = useLOCompTool;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010()
        {
            Clean = true;
        }
    }
}