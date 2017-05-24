using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010
    {
        public Value<decimal?> AdjustedOriginationCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedOriginationCharges() => !AdjustedOriginationCharges.Clean;
        public Value<decimal?> AllOtherServiceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllOtherServiceAmount() => !AllOtherServiceAmount.Clean;
        public Value<decimal?> ApplicationFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationFees() => !ApplicationFees.Clean;
        public Value<bool?> BorrowerSelectIndicator10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator10() => !BorrowerSelectIndicator10.Clean;
        public Value<bool?> BorrowerSelectIndicator11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator11() => !BorrowerSelectIndicator11.Clean;
        public Value<bool?> BorrowerSelectIndicator12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator12() => !BorrowerSelectIndicator12.Clean;
        public Value<bool?> BorrowerSelectIndicator13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator13() => !BorrowerSelectIndicator13.Clean;
        public Value<bool?> BorrowerSelectIndicator14 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator14() => !BorrowerSelectIndicator14.Clean;
        public Value<bool?> BorrowerSelectIndicator15 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator15() => !BorrowerSelectIndicator15.Clean;
        public Value<bool?> BorrowerSelectIndicator16 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator16() => !BorrowerSelectIndicator16.Clean;
        public Value<bool?> BorrowerSelectIndicator17 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator17() => !BorrowerSelectIndicator17.Clean;
        public Value<bool?> BorrowerSelectIndicator18 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator18() => !BorrowerSelectIndicator18.Clean;
        public Value<bool?> BorrowerSelectIndicator19 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator19() => !BorrowerSelectIndicator19.Clean;
        public Value<bool?> BorrowerSelectIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator2() => !BorrowerSelectIndicator2.Clean;
        public Value<bool?> BorrowerSelectIndicator20 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator20() => !BorrowerSelectIndicator20.Clean;
        public Value<bool?> BorrowerSelectIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator3() => !BorrowerSelectIndicator3.Clean;
        public Value<bool?> BorrowerSelectIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator4() => !BorrowerSelectIndicator4.Clean;
        public Value<bool?> BorrowerSelectIndicator5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator5() => !BorrowerSelectIndicator5.Clean;
        public Value<bool?> BorrowerSelectIndicator6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator6() => !BorrowerSelectIndicator6.Clean;
        public Value<bool?> BorrowerSelectIndicator7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator7() => !BorrowerSelectIndicator7.Clean;
        public Value<bool?> BorrowerSelectIndicator8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator8() => !BorrowerSelectIndicator8.Clean;
        public Value<bool?> BorrowerSelectIndicator9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator9() => !BorrowerSelectIndicator9.Clean;
        public Value<decimal?> BrokerAdditionalFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAdditionalFees() => !BrokerAdditionalFees.Clean;
        public Value<decimal?> BrokerFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFees() => !BrokerFees.Clean;
        public Value<decimal?> BrokerFeesPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeesPercentage() => !BrokerFeesPercentage.Clean;
        public Value<decimal?> ChargeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeAmount() => !ChargeAmount.Clean;
        public Value<decimal?> ChargeAmountForPrint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeAmountForPrint() => !ChargeAmountForPrint.Clean;
        public Value<bool?> CopyFromGfeIndicator1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator1() => !CopyFromGfeIndicator1.Clean;
        public Value<bool?> CopyFromGfeIndicator10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator10() => !CopyFromGfeIndicator10.Clean;
        public Value<bool?> CopyFromGfeIndicator11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator11() => !CopyFromGfeIndicator11.Clean;
        public Value<bool?> CopyFromGfeIndicator12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator12() => !CopyFromGfeIndicator12.Clean;
        public Value<bool?> CopyFromGfeIndicator13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator13() => !CopyFromGfeIndicator13.Clean;
        public Value<bool?> CopyFromGfeIndicator14 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator14() => !CopyFromGfeIndicator14.Clean;
        public Value<bool?> CopyFromGfeIndicator15 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator15() => !CopyFromGfeIndicator15.Clean;
        public Value<bool?> CopyFromGfeIndicator16 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator16() => !CopyFromGfeIndicator16.Clean;
        public Value<bool?> CopyFromGfeIndicator17 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator17() => !CopyFromGfeIndicator17.Clean;
        public Value<bool?> CopyFromGfeIndicator18 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator18() => !CopyFromGfeIndicator18.Clean;
        public Value<bool?> CopyFromGfeIndicator19 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator19() => !CopyFromGfeIndicator19.Clean;
        public Value<bool?> CopyFromGfeIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator2() => !CopyFromGfeIndicator2.Clean;
        public Value<bool?> CopyFromGfeIndicator20 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator20() => !CopyFromGfeIndicator20.Clean;
        public Value<bool?> CopyFromGfeIndicator21 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator21() => !CopyFromGfeIndicator21.Clean;
        public Value<bool?> CopyFromGfeIndicator22 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator22() => !CopyFromGfeIndicator22.Clean;
        public Value<bool?> CopyFromGfeIndicator23 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator23() => !CopyFromGfeIndicator23.Clean;
        public Value<bool?> CopyFromGfeIndicator24 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator24() => !CopyFromGfeIndicator24.Clean;
        public Value<bool?> CopyFromGfeIndicator25 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator25() => !CopyFromGfeIndicator25.Clean;
        public Value<bool?> CopyFromGfeIndicator26 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator26() => !CopyFromGfeIndicator26.Clean;
        public Value<bool?> CopyFromGfeIndicator27 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator27() => !CopyFromGfeIndicator27.Clean;
        public Value<bool?> CopyFromGfeIndicator28 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator28() => !CopyFromGfeIndicator28.Clean;
        public Value<bool?> CopyFromGfeIndicator29 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator29() => !CopyFromGfeIndicator29.Clean;
        public Value<bool?> CopyFromGfeIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator3() => !CopyFromGfeIndicator3.Clean;
        public Value<bool?> CopyFromGfeIndicator30 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator30() => !CopyFromGfeIndicator30.Clean;
        public Value<bool?> CopyFromGfeIndicator31 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator31() => !CopyFromGfeIndicator31.Clean;
        public Value<bool?> CopyFromGfeIndicator32 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator32() => !CopyFromGfeIndicator32.Clean;
        public Value<bool?> CopyFromGfeIndicator33 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator33() => !CopyFromGfeIndicator33.Clean;
        public Value<bool?> CopyFromGfeIndicator34 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator34() => !CopyFromGfeIndicator34.Clean;
        public Value<bool?> CopyFromGfeIndicator35 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator35() => !CopyFromGfeIndicator35.Clean;
        public Value<bool?> CopyFromGfeIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator4() => !CopyFromGfeIndicator4.Clean;
        public Value<bool?> CopyFromGfeIndicator5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator5() => !CopyFromGfeIndicator5.Clean;
        public Value<bool?> CopyFromGfeIndicator6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator6() => !CopyFromGfeIndicator6.Clean;
        public Value<bool?> CopyFromGfeIndicator7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator7() => !CopyFromGfeIndicator7.Clean;
        public Value<bool?> CopyFromGfeIndicator8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator8() => !CopyFromGfeIndicator8.Clean;
        public Value<bool?> CopyFromGfeIndicator9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromGfeIndicator9() => !CopyFromGfeIndicator9.Clean;
        public Value<decimal?> CreditAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditAmount() => !CreditAmount.Clean;
        public Value<decimal?> CreditAmountForPrint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditAmountForPrint() => !CreditAmountForPrint.Clean;
        public Value<string> CreditChargeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditChargeType() => !CreditChargeType.Clean;
        public Value<decimal?> CreditOrChange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditOrChange() => !CreditOrChange.Clean;
        public Value<decimal?> CuredAdjustedOriginationCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredAdjustedOriginationCharges() => !CuredAdjustedOriginationCharges.Clean;
        public Value<decimal?> CuredCreditOrChange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredCreditOrChange() => !CuredCreditOrChange.Clean;
        public Value<decimal?> CuredOriginationCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredOriginationCharges() => !CuredOriginationCharges.Clean;
        public Value<decimal?> CuredTotalTransferTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredTotalTransferTaxes() => !CuredTotalTransferTaxes.Clean;
        public Value<decimal?> DailyInterestCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDailyInterestCharges() => !DailyInterestCharges.Clean;
        public Value<DateTime?> DateForCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateForCharges() => !DateForCharges.Clean;
        public Value<string> DateForRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateForRate() => !DateForRate.Clean;
        public Value<string> DaysToSettlement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToSettlement() => !DaysToSettlement.Clean;
        public Value<int?> DurationMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationMonths() => !DurationMonths.Clean;
        public Value<bool?> EscrowChargeAllInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowChargeAllInsuranceIndicator() => !EscrowChargeAllInsuranceIndicator.Clean;
        public Value<bool?> EscrowChargeAllPropertyTaxesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowChargeAllPropertyTaxesIndicator() => !EscrowChargeAllPropertyTaxesIndicator.Clean;
        public Value<bool?> EscrowChargeOtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowChargeOtherIndicator() => !EscrowChargeOtherIndicator.Clean;
        public Value<string> EscrowOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOtherDescription() => !EscrowOtherDescription.Clean;
        public Value<decimal?> FinancedFeesFromPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedFeesFromPrepaid() => !FinancedFeesFromPrepaid.Clean;
        public Value<List<Gfe2010Fee>> Gfe2010Fees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010Fees() => !Gfe2010Fees.Clean;
        public Value<List<Gfe2010WholePoc>> Gfe2010WholePocs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010WholePocs() => !Gfe2010WholePocs.Clean;
        public Value<decimal?> GfeGovernmentRecordingCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeGovernmentRecordingCharges() => !GfeGovernmentRecordingCharges.Clean;
        public Value<decimal?> HazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardInsurance() => !HazardInsurance.Clean;
        public Value<decimal?> HomeownerInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeownerInsurance() => !HomeownerInsurance.Clean;
        public Value<decimal?> HudGuaranteeFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudGuaranteeFee() => !HudGuaranteeFee.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IncludeOriginationPointsCreditType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeOriginationPointsCreditType() => !IncludeOriginationPointsCreditType.Clean;
        public Value<decimal?> InitialLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialLoanAmount() => !InitialLoanAmount.Clean;
        public Value<decimal?> InitialMonthlyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialMonthlyAmount() => !InitialMonthlyAmount.Clean;
        public Value<bool?> InterestRateRiseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateRiseIndicator() => !InterestRateRiseIndicator.Clean;
        public Value<bool?> IsCDValidForEarliestClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsCDValidForEarliestClosingDate() => !IsCDValidForEarliestClosingDate.Clean;
        public Value<decimal?> Line1001Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1001Fee() => !Line1001Fee.Clean;
        public Value<decimal?> Line1002Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1002Fee() => !Line1002Fee.Clean;
        public Value<decimal?> Line1003Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1003Fee() => !Line1003Fee.Clean;
        public Value<decimal?> Line1004Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1004Fee() => !Line1004Fee.Clean;
        public Value<decimal?> Line1005Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1005Fee() => !Line1005Fee.Clean;
        public Value<decimal?> Line1006Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1006Fee() => !Line1006Fee.Clean;
        public Value<decimal?> Line1007Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1007Fee() => !Line1007Fee.Clean;
        public Value<decimal?> Line1008Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1008Fee() => !Line1008Fee.Clean;
        public Value<decimal?> Line1009Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1009Fee() => !Line1009Fee.Clean;
        public Value<decimal?> Line801BrokerCompensationAdditionalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801BrokerCompensationAdditionalAmount() => !Line801BrokerCompensationAdditionalAmount.Clean;
        public Value<decimal?> Line801BrokerCompensationFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801BrokerCompensationFees() => !Line801BrokerCompensationFees.Clean;
        public Value<decimal?> Line801BrokerCompensationRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801BrokerCompensationRate() => !Line801BrokerCompensationRate.Clean;
        public Value<decimal?> Line808Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine808Fee() => !Line808Fee.Clean;
        public Value<decimal?> Line809Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine809Fee() => !Line809Fee.Clean;
        public Value<decimal?> Line810Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine810Fee() => !Line810Fee.Clean;
        public Value<decimal?> Line811Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine811Fee() => !Line811Fee.Clean;
        public Value<decimal?> Line812Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine812Fee() => !Line812Fee.Clean;
        public Value<decimal?> Line813Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine813Fee() => !Line813Fee.Clean;
        public Value<decimal?> Line814Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine814Fee() => !Line814Fee.Clean;
        public Value<decimal?> Line815Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine815Fee() => !Line815Fee.Clean;
        public Value<decimal?> Line816Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine816Fee() => !Line816Fee.Clean;
        public Value<decimal?> Line817Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine817Fee() => !Line817Fee.Clean;
        public Value<decimal?> Line818Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine818Fee() => !Line818Fee.Clean;
        public Value<decimal?> Line819Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine819Fee() => !Line819Fee.Clean;
        public Value<decimal?> Line820Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine820Fee() => !Line820Fee.Clean;
        public Value<decimal?> Line821Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine821Fee() => !Line821Fee.Clean;
        public Value<decimal?> Line822Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine822Fee() => !Line822Fee.Clean;
        public Value<decimal?> Line823Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine823Fee() => !Line823Fee.Clean;
        public Value<decimal?> Line824Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine824Fee() => !Line824Fee.Clean;
        public Value<decimal?> Line825Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine825Fee() => !Line825Fee.Clean;
        public Value<decimal?> Line826Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine826Fee() => !Line826Fee.Clean;
        public Value<decimal?> Line827Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine827Fee() => !Line827Fee.Clean;
        public Value<decimal?> Line828Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine828Fee() => !Line828Fee.Clean;
        public Value<decimal?> Line829Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine829Fee() => !Line829Fee.Clean;
        public Value<decimal?> Line830Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine830Fee() => !Line830Fee.Clean;
        public Value<decimal?> Line831Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine831Fee() => !Line831Fee.Clean;
        public Value<decimal?> Line832Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine832Fee() => !Line832Fee.Clean;
        public Value<decimal?> Line833Fee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine833Fee() => !Line833Fee.Clean;
        public Value<bool?> LoanBalanceRiseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanBalanceRiseIndicator() => !LoanBalanceRiseIndicator.Clean;
        public Value<decimal?> LoanOriginationFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginationFees() => !LoanOriginationFees.Clean;
        public Value<decimal?> LoanOriginationPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginationPercentage() => !LoanOriginationPercentage.Clean;
        public Value<string> LoanOriginatorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorName() => !LoanOriginatorName.Clean;
        public Value<decimal?> LowerInterestInitialInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerInterestInitialInterestRate() => !LowerInterestInitialInterestRate.Clean;
        public Value<decimal?> LowerInterestInitialMonthlyAmountOwed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerInterestInitialMonthlyAmountOwed() => !LowerInterestInitialMonthlyAmountOwed.Clean;
        public Value<decimal?> LowerInterestMonthlyPaymentReduced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerInterestMonthlyPaymentReduced() => !LowerInterestMonthlyPaymentReduced.Clean;
        public Value<decimal?> LowerInterestServiceChargeIncreasedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerInterestServiceChargeIncreasedAmount() => !LowerInterestServiceChargeIncreasedAmount.Clean;
        public Value<decimal?> LowerInterestTotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerInterestTotalSettlementCharges() => !LowerInterestTotalSettlementCharges.Clean;
        public Value<decimal?> LowerSettlementInitialInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerSettlementInitialInterestRate() => !LowerSettlementInitialInterestRate.Clean;
        public Value<decimal?> LowerSettlementInitialMonthlyAmountOwed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerSettlementInitialMonthlyAmountOwed() => !LowerSettlementInitialMonthlyAmountOwed.Clean;
        public Value<decimal?> LowerSettlementMonthlyPaymentIncreased { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerSettlementMonthlyPaymentIncreased() => !LowerSettlementMonthlyPaymentIncreased.Clean;
        public Value<decimal?> LowerSettlementServiceChargeReducedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerSettlementServiceChargeReducedAmount() => !LowerSettlementServiceChargeReducedAmount.Clean;
        public Value<decimal?> LowerSettlementTotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowerSettlementTotalSettlementCharges() => !LowerSettlementTotalSettlementCharges.Clean;
        public Value<decimal?> MaximumLoanBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumLoanBalance() => !MaximumLoanBalance.Clean;
        public Value<decimal?> MaximumOwedMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumOwedMonthlyPayment() => !MaximumOwedMonthlyPayment.Clean;
        public Value<decimal?> MaxLifeInterestCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLifeInterestCapPercent() => !MaxLifeInterestCapPercent.Clean;
        public Value<int?> MonthlyPaymentFirstIncreaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentFirstIncreaseDate() => !MonthlyPaymentFirstIncreaseDate.Clean;
        public Value<bool?> MonthlyPaymentRiseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentRiseIndicator() => !MonthlyPaymentRiseIndicator.Clean;
        public Value<decimal?> MortgageInsurancePremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePremium() => !MortgageInsurancePremium.Clean;
        public Value<string> MustLockRateDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMustLockRateDays() => !MustLockRateDays.Clean;
        public Value<decimal?> NewHudSection1100Line1104BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewHudSection1100Line1104BorPaidAmount() => !NewHudSection1100Line1104BorPaidAmount.Clean;
        public Value<decimal?> NewHudSection1100Line1104SelPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewHudSection1100Line1104SelPaidAmount() => !NewHudSection1100Line1104SelPaidAmount.Clean;
        public Value<decimal?> NewHudSection1100Line1107BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewHudSection1100Line1107BorPaidAmount() => !NewHudSection1100Line1107BorPaidAmount.Clean;
        public Value<decimal?> NewHudSection1100Line1108BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewHudSection1100Line1108BorPaidAmount() => !NewHudSection1100Line1108BorPaidAmount.Clean;
        public Value<decimal?> OriginationCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationCharges() => !OriginationCharges.Clean;
        public Value<decimal?> OriginationCreditYsp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationCreditYsp() => !OriginationCreditYsp.Clean;
        public Value<decimal?> OriginationCreditYspAdditional { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationCreditYspAdditional() => !OriginationCreditYspAdditional.Clean;
        public Value<decimal?> OriginationPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPoints() => !OriginationPoints.Clean;
        public Value<decimal?> OriginationPointsAdditional { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsAdditional() => !OriginationPointsAdditional.Clean;
        public Value<decimal?> OriginationPointsPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsPercentage() => !OriginationPointsPercentage.Clean;
        public Value<decimal?> OwnerTitleInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnerTitleInsuranceAmount() => !OwnerTitleInsuranceAmount.Clean;
        public Value<bool?> PrintNAInLockRateDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintNAInLockRateDays() => !PrintNAInLockRateDays.Clean;
        public Value<bool?> PrintShoppingChartIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintShoppingChartIndicator() => !PrintShoppingChartIndicator.Clean;
        public Value<decimal?> ProcessingFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFees() => !ProcessingFees.Clean;
        public Value<decimal?> RequiredAppraisalFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredAppraisalFee() => !RequiredAppraisalFee.Clean;
        public Value<decimal?> RequiredCreditReportFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredCreditReportFee() => !RequiredCreditReportFee.Clean;
        public Value<decimal?> RequiredFloodCertificationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredFloodCertificationFee() => !RequiredFloodCertificationFee.Clean;
        public Value<decimal?> RequiredServicesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredServicesAmount() => !RequiredServicesAmount.Clean;
        public Value<decimal?> RequiredTaxServiceFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredTaxServiceFee() => !RequiredTaxServiceFee.Clean;
        public Value<decimal?> Section1000TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000TotalBorrowerPaidAmount() => !Section1000TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section1000TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000TotalOtherPaidAmount() => !Section1000TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section1000TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000TotalPaidAmount() => !Section1000TotalPaidAmount.Clean;
        public Value<decimal?> Section1000TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000TotalSellerPaidAmount() => !Section1000TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section1100TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1100TotalBorrowerPaidAmount() => !Section1100TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section1100TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1100TotalOtherPaidAmount() => !Section1100TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section1100TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1100TotalPaidAmount() => !Section1100TotalPaidAmount.Clean;
        public Value<decimal?> Section1100TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1100TotalSellerPaidAmount() => !Section1100TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section1200TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1200TotalBorrowerPaidAmount() => !Section1200TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section1200TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1200TotalOtherPaidAmount() => !Section1200TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section1200TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1200TotalPaidAmount() => !Section1200TotalPaidAmount.Clean;
        public Value<decimal?> Section1200TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1200TotalSellerPaidAmount() => !Section1200TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section1300TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1300TotalBorrowerPaidAmount() => !Section1300TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section1300TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1300TotalOtherPaidAmount() => !Section1300TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section1300TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1300TotalPaidAmount() => !Section1300TotalPaidAmount.Clean;
        public Value<decimal?> Section1300TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1300TotalSellerPaidAmount() => !Section1300TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section1400TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1400TotalBorrowerPaidAmount() => !Section1400TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section1400TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1400TotalOtherPaidAmount() => !Section1400TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section1400TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1400TotalPaidAmount() => !Section1400TotalPaidAmount.Clean;
        public Value<decimal?> Section1400TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1400TotalSellerPaidAmount() => !Section1400TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section700TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection700TotalBorrowerPaidAmount() => !Section700TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section700TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection700TotalOtherPaidAmount() => !Section700TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section700TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection700TotalPaidAmount() => !Section700TotalPaidAmount.Clean;
        public Value<decimal?> Section700TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection700TotalSellerPaidAmount() => !Section700TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section800TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection800TotalBorrowerPaidAmount() => !Section800TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section800TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection800TotalOtherPaidAmount() => !Section800TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section800TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection800TotalPaidAmount() => !Section800TotalPaidAmount.Clean;
        public Value<decimal?> Section800TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection800TotalSellerPaidAmount() => !Section800TotalSellerPaidAmount.Clean;
        public Value<decimal?> Section900TotalBorrowerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection900TotalBorrowerPaidAmount() => !Section900TotalBorrowerPaidAmount.Clean;
        public Value<decimal?> Section900TotalOtherPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection900TotalOtherPaidAmount() => !Section900TotalOtherPaidAmount.Clean;
        public Value<decimal?> Section900TotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection900TotalPaidAmount() => !Section900TotalPaidAmount.Clean;
        public Value<decimal?> Section900TotalSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection900TotalSellerPaidAmount() => !Section900TotalSellerPaidAmount.Clean;
        public Value<decimal?> ShopRequiredServicesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShopRequiredServicesAmount() => !ShopRequiredServicesAmount.Clean;
        public Value<decimal?> SubsequentCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentCapPercent() => !SubsequentCapPercent.Clean;
        public Value<int?> SubsequentRateAdjustmentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentRateAdjustmentMonths() => !SubsequentRateAdjustmentMonths.Clean;
        public Value<bool?> TableFundedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTableFundedIndicator() => !TableFundedIndicator.Clean;
        public Value<string> TimeForRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeForRate() => !TimeForRate.Clean;
        public Value<decimal?> TitleServiceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleServiceAmount() => !TitleServiceAmount.Clean;
        public Value<decimal?> TotalBelow10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBelow10() => !TotalBelow10.Clean;
        public Value<decimal?> TotalOfFinancedFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOfFinancedFees() => !TotalOfFinancedFees.Clean;
        public Value<decimal?> TotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSettlementCharges() => !TotalSettlementCharges.Clean;
        public Value<decimal?> TotalTransferTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalTransferTaxes() => !TotalTransferTaxes.Clean;
        public Value<decimal?> TransferTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransferTaxes() => !TransferTaxes.Clean;
        public Value<decimal?> UnderwritingFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFees() => !UnderwritingFees.Clean;
        public Value<bool?> UseLOCompTool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseLOCompTool() => !UseLOCompTool.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustedOriginationCharges.Clean
                    && AllOtherServiceAmount.Clean
                    && ApplicationFees.Clean
                    && BorrowerSelectIndicator10.Clean
                    && BorrowerSelectIndicator11.Clean
                    && BorrowerSelectIndicator12.Clean
                    && BorrowerSelectIndicator13.Clean
                    && BorrowerSelectIndicator14.Clean
                    && BorrowerSelectIndicator15.Clean
                    && BorrowerSelectIndicator16.Clean
                    && BorrowerSelectIndicator17.Clean
                    && BorrowerSelectIndicator18.Clean
                    && BorrowerSelectIndicator19.Clean
                    && BorrowerSelectIndicator2.Clean
                    && BorrowerSelectIndicator20.Clean
                    && BorrowerSelectIndicator3.Clean
                    && BorrowerSelectIndicator4.Clean
                    && BorrowerSelectIndicator5.Clean
                    && BorrowerSelectIndicator6.Clean
                    && BorrowerSelectIndicator7.Clean
                    && BorrowerSelectIndicator8.Clean
                    && BorrowerSelectIndicator9.Clean
                    && BrokerAdditionalFees.Clean
                    && BrokerFees.Clean
                    && BrokerFeesPercentage.Clean
                    && ChargeAmount.Clean
                    && ChargeAmountForPrint.Clean
                    && CopyFromGfeIndicator1.Clean
                    && CopyFromGfeIndicator10.Clean
                    && CopyFromGfeIndicator11.Clean
                    && CopyFromGfeIndicator12.Clean
                    && CopyFromGfeIndicator13.Clean
                    && CopyFromGfeIndicator14.Clean
                    && CopyFromGfeIndicator15.Clean
                    && CopyFromGfeIndicator16.Clean
                    && CopyFromGfeIndicator17.Clean
                    && CopyFromGfeIndicator18.Clean
                    && CopyFromGfeIndicator19.Clean
                    && CopyFromGfeIndicator2.Clean
                    && CopyFromGfeIndicator20.Clean
                    && CopyFromGfeIndicator21.Clean
                    && CopyFromGfeIndicator22.Clean
                    && CopyFromGfeIndicator23.Clean
                    && CopyFromGfeIndicator24.Clean
                    && CopyFromGfeIndicator25.Clean
                    && CopyFromGfeIndicator26.Clean
                    && CopyFromGfeIndicator27.Clean
                    && CopyFromGfeIndicator28.Clean
                    && CopyFromGfeIndicator29.Clean
                    && CopyFromGfeIndicator3.Clean
                    && CopyFromGfeIndicator30.Clean
                    && CopyFromGfeIndicator31.Clean
                    && CopyFromGfeIndicator32.Clean
                    && CopyFromGfeIndicator33.Clean
                    && CopyFromGfeIndicator34.Clean
                    && CopyFromGfeIndicator35.Clean
                    && CopyFromGfeIndicator4.Clean
                    && CopyFromGfeIndicator5.Clean
                    && CopyFromGfeIndicator6.Clean
                    && CopyFromGfeIndicator7.Clean
                    && CopyFromGfeIndicator8.Clean
                    && CopyFromGfeIndicator9.Clean
                    && CreditAmount.Clean
                    && CreditAmountForPrint.Clean
                    && CreditChargeType.Clean
                    && CreditOrChange.Clean
                    && CuredAdjustedOriginationCharges.Clean
                    && CuredCreditOrChange.Clean
                    && CuredOriginationCharges.Clean
                    && CuredTotalTransferTaxes.Clean
                    && DailyInterestCharges.Clean
                    && DateForCharges.Clean
                    && DateForRate.Clean
                    && DaysToSettlement.Clean
                    && DurationMonths.Clean
                    && EscrowChargeAllInsuranceIndicator.Clean
                    && EscrowChargeAllPropertyTaxesIndicator.Clean
                    && EscrowChargeOtherIndicator.Clean
                    && EscrowOtherDescription.Clean
                    && FinancedFeesFromPrepaid.Clean
                    && Gfe2010Fees.Clean
                    && Gfe2010WholePocs.Clean
                    && GfeGovernmentRecordingCharges.Clean
                    && HazardInsurance.Clean
                    && HomeownerInsurance.Clean
                    && HudGuaranteeFee.Clean
                    && Id.Clean
                    && IncludeOriginationPointsCreditType.Clean
                    && InitialLoanAmount.Clean
                    && InitialMonthlyAmount.Clean
                    && InterestRateRiseIndicator.Clean
                    && IsCDValidForEarliestClosingDate.Clean
                    && Line1001Fee.Clean
                    && Line1002Fee.Clean
                    && Line1003Fee.Clean
                    && Line1004Fee.Clean
                    && Line1005Fee.Clean
                    && Line1006Fee.Clean
                    && Line1007Fee.Clean
                    && Line1008Fee.Clean
                    && Line1009Fee.Clean
                    && Line801BrokerCompensationAdditionalAmount.Clean
                    && Line801BrokerCompensationFees.Clean
                    && Line801BrokerCompensationRate.Clean
                    && Line808Fee.Clean
                    && Line809Fee.Clean
                    && Line810Fee.Clean
                    && Line811Fee.Clean
                    && Line812Fee.Clean
                    && Line813Fee.Clean
                    && Line814Fee.Clean
                    && Line815Fee.Clean
                    && Line816Fee.Clean
                    && Line817Fee.Clean
                    && Line818Fee.Clean
                    && Line819Fee.Clean
                    && Line820Fee.Clean
                    && Line821Fee.Clean
                    && Line822Fee.Clean
                    && Line823Fee.Clean
                    && Line824Fee.Clean
                    && Line825Fee.Clean
                    && Line826Fee.Clean
                    && Line827Fee.Clean
                    && Line828Fee.Clean
                    && Line829Fee.Clean
                    && Line830Fee.Clean
                    && Line831Fee.Clean
                    && Line832Fee.Clean
                    && Line833Fee.Clean
                    && LoanBalanceRiseIndicator.Clean
                    && LoanOriginationFees.Clean
                    && LoanOriginationPercentage.Clean
                    && LoanOriginatorName.Clean
                    && LowerInterestInitialInterestRate.Clean
                    && LowerInterestInitialMonthlyAmountOwed.Clean
                    && LowerInterestMonthlyPaymentReduced.Clean
                    && LowerInterestServiceChargeIncreasedAmount.Clean
                    && LowerInterestTotalSettlementCharges.Clean
                    && LowerSettlementInitialInterestRate.Clean
                    && LowerSettlementInitialMonthlyAmountOwed.Clean
                    && LowerSettlementMonthlyPaymentIncreased.Clean
                    && LowerSettlementServiceChargeReducedAmount.Clean
                    && LowerSettlementTotalSettlementCharges.Clean
                    && MaximumLoanBalance.Clean
                    && MaximumOwedMonthlyPayment.Clean
                    && MaxLifeInterestCapPercent.Clean
                    && MonthlyPaymentFirstIncreaseDate.Clean
                    && MonthlyPaymentRiseIndicator.Clean
                    && MortgageInsurancePremium.Clean
                    && MustLockRateDays.Clean
                    && NewHudSection1100Line1104BorPaidAmount.Clean
                    && NewHudSection1100Line1104SelPaidAmount.Clean
                    && NewHudSection1100Line1107BorPaidAmount.Clean
                    && NewHudSection1100Line1108BorPaidAmount.Clean
                    && OriginationCharges.Clean
                    && OriginationCreditYsp.Clean
                    && OriginationCreditYspAdditional.Clean
                    && OriginationPoints.Clean
                    && OriginationPointsAdditional.Clean
                    && OriginationPointsPercentage.Clean
                    && OwnerTitleInsuranceAmount.Clean
                    && PrintNAInLockRateDays.Clean
                    && PrintShoppingChartIndicator.Clean
                    && ProcessingFees.Clean
                    && RequiredAppraisalFee.Clean
                    && RequiredCreditReportFee.Clean
                    && RequiredFloodCertificationFee.Clean
                    && RequiredServicesAmount.Clean
                    && RequiredTaxServiceFee.Clean
                    && Section1000TotalBorrowerPaidAmount.Clean
                    && Section1000TotalOtherPaidAmount.Clean
                    && Section1000TotalPaidAmount.Clean
                    && Section1000TotalSellerPaidAmount.Clean
                    && Section1100TotalBorrowerPaidAmount.Clean
                    && Section1100TotalOtherPaidAmount.Clean
                    && Section1100TotalPaidAmount.Clean
                    && Section1100TotalSellerPaidAmount.Clean
                    && Section1200TotalBorrowerPaidAmount.Clean
                    && Section1200TotalOtherPaidAmount.Clean
                    && Section1200TotalPaidAmount.Clean
                    && Section1200TotalSellerPaidAmount.Clean
                    && Section1300TotalBorrowerPaidAmount.Clean
                    && Section1300TotalOtherPaidAmount.Clean
                    && Section1300TotalPaidAmount.Clean
                    && Section1300TotalSellerPaidAmount.Clean
                    && Section1400TotalBorrowerPaidAmount.Clean
                    && Section1400TotalOtherPaidAmount.Clean
                    && Section1400TotalPaidAmount.Clean
                    && Section1400TotalSellerPaidAmount.Clean
                    && Section700TotalBorrowerPaidAmount.Clean
                    && Section700TotalOtherPaidAmount.Clean
                    && Section700TotalPaidAmount.Clean
                    && Section700TotalSellerPaidAmount.Clean
                    && Section800TotalBorrowerPaidAmount.Clean
                    && Section800TotalOtherPaidAmount.Clean
                    && Section800TotalPaidAmount.Clean
                    && Section800TotalSellerPaidAmount.Clean
                    && Section900TotalBorrowerPaidAmount.Clean
                    && Section900TotalOtherPaidAmount.Clean
                    && Section900TotalPaidAmount.Clean
                    && Section900TotalSellerPaidAmount.Clean
                    && ShopRequiredServicesAmount.Clean
                    && SubsequentCapPercent.Clean
                    && SubsequentRateAdjustmentMonths.Clean
                    && TableFundedIndicator.Clean
                    && TimeForRate.Clean
                    && TitleServiceAmount.Clean
                    && TotalBelow10.Clean
                    && TotalOfFinancedFees.Clean
                    && TotalSettlementCharges.Clean
                    && TotalTransferTaxes.Clean
                    && TransferTaxes.Clean
                    && UnderwritingFees.Clean
                    && UseLOCompTool.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdjustedOriginationCharges; v0.Clean = value; AdjustedOriginationCharges = v0;
                var v1 = AllOtherServiceAmount; v1.Clean = value; AllOtherServiceAmount = v1;
                var v2 = ApplicationFees; v2.Clean = value; ApplicationFees = v2;
                var v3 = BorrowerSelectIndicator10; v3.Clean = value; BorrowerSelectIndicator10 = v3;
                var v4 = BorrowerSelectIndicator11; v4.Clean = value; BorrowerSelectIndicator11 = v4;
                var v5 = BorrowerSelectIndicator12; v5.Clean = value; BorrowerSelectIndicator12 = v5;
                var v6 = BorrowerSelectIndicator13; v6.Clean = value; BorrowerSelectIndicator13 = v6;
                var v7 = BorrowerSelectIndicator14; v7.Clean = value; BorrowerSelectIndicator14 = v7;
                var v8 = BorrowerSelectIndicator15; v8.Clean = value; BorrowerSelectIndicator15 = v8;
                var v9 = BorrowerSelectIndicator16; v9.Clean = value; BorrowerSelectIndicator16 = v9;
                var v10 = BorrowerSelectIndicator17; v10.Clean = value; BorrowerSelectIndicator17 = v10;
                var v11 = BorrowerSelectIndicator18; v11.Clean = value; BorrowerSelectIndicator18 = v11;
                var v12 = BorrowerSelectIndicator19; v12.Clean = value; BorrowerSelectIndicator19 = v12;
                var v13 = BorrowerSelectIndicator2; v13.Clean = value; BorrowerSelectIndicator2 = v13;
                var v14 = BorrowerSelectIndicator20; v14.Clean = value; BorrowerSelectIndicator20 = v14;
                var v15 = BorrowerSelectIndicator3; v15.Clean = value; BorrowerSelectIndicator3 = v15;
                var v16 = BorrowerSelectIndicator4; v16.Clean = value; BorrowerSelectIndicator4 = v16;
                var v17 = BorrowerSelectIndicator5; v17.Clean = value; BorrowerSelectIndicator5 = v17;
                var v18 = BorrowerSelectIndicator6; v18.Clean = value; BorrowerSelectIndicator6 = v18;
                var v19 = BorrowerSelectIndicator7; v19.Clean = value; BorrowerSelectIndicator7 = v19;
                var v20 = BorrowerSelectIndicator8; v20.Clean = value; BorrowerSelectIndicator8 = v20;
                var v21 = BorrowerSelectIndicator9; v21.Clean = value; BorrowerSelectIndicator9 = v21;
                var v22 = BrokerAdditionalFees; v22.Clean = value; BrokerAdditionalFees = v22;
                var v23 = BrokerFees; v23.Clean = value; BrokerFees = v23;
                var v24 = BrokerFeesPercentage; v24.Clean = value; BrokerFeesPercentage = v24;
                var v25 = ChargeAmount; v25.Clean = value; ChargeAmount = v25;
                var v26 = ChargeAmountForPrint; v26.Clean = value; ChargeAmountForPrint = v26;
                var v27 = CopyFromGfeIndicator1; v27.Clean = value; CopyFromGfeIndicator1 = v27;
                var v28 = CopyFromGfeIndicator10; v28.Clean = value; CopyFromGfeIndicator10 = v28;
                var v29 = CopyFromGfeIndicator11; v29.Clean = value; CopyFromGfeIndicator11 = v29;
                var v30 = CopyFromGfeIndicator12; v30.Clean = value; CopyFromGfeIndicator12 = v30;
                var v31 = CopyFromGfeIndicator13; v31.Clean = value; CopyFromGfeIndicator13 = v31;
                var v32 = CopyFromGfeIndicator14; v32.Clean = value; CopyFromGfeIndicator14 = v32;
                var v33 = CopyFromGfeIndicator15; v33.Clean = value; CopyFromGfeIndicator15 = v33;
                var v34 = CopyFromGfeIndicator16; v34.Clean = value; CopyFromGfeIndicator16 = v34;
                var v35 = CopyFromGfeIndicator17; v35.Clean = value; CopyFromGfeIndicator17 = v35;
                var v36 = CopyFromGfeIndicator18; v36.Clean = value; CopyFromGfeIndicator18 = v36;
                var v37 = CopyFromGfeIndicator19; v37.Clean = value; CopyFromGfeIndicator19 = v37;
                var v38 = CopyFromGfeIndicator2; v38.Clean = value; CopyFromGfeIndicator2 = v38;
                var v39 = CopyFromGfeIndicator20; v39.Clean = value; CopyFromGfeIndicator20 = v39;
                var v40 = CopyFromGfeIndicator21; v40.Clean = value; CopyFromGfeIndicator21 = v40;
                var v41 = CopyFromGfeIndicator22; v41.Clean = value; CopyFromGfeIndicator22 = v41;
                var v42 = CopyFromGfeIndicator23; v42.Clean = value; CopyFromGfeIndicator23 = v42;
                var v43 = CopyFromGfeIndicator24; v43.Clean = value; CopyFromGfeIndicator24 = v43;
                var v44 = CopyFromGfeIndicator25; v44.Clean = value; CopyFromGfeIndicator25 = v44;
                var v45 = CopyFromGfeIndicator26; v45.Clean = value; CopyFromGfeIndicator26 = v45;
                var v46 = CopyFromGfeIndicator27; v46.Clean = value; CopyFromGfeIndicator27 = v46;
                var v47 = CopyFromGfeIndicator28; v47.Clean = value; CopyFromGfeIndicator28 = v47;
                var v48 = CopyFromGfeIndicator29; v48.Clean = value; CopyFromGfeIndicator29 = v48;
                var v49 = CopyFromGfeIndicator3; v49.Clean = value; CopyFromGfeIndicator3 = v49;
                var v50 = CopyFromGfeIndicator30; v50.Clean = value; CopyFromGfeIndicator30 = v50;
                var v51 = CopyFromGfeIndicator31; v51.Clean = value; CopyFromGfeIndicator31 = v51;
                var v52 = CopyFromGfeIndicator32; v52.Clean = value; CopyFromGfeIndicator32 = v52;
                var v53 = CopyFromGfeIndicator33; v53.Clean = value; CopyFromGfeIndicator33 = v53;
                var v54 = CopyFromGfeIndicator34; v54.Clean = value; CopyFromGfeIndicator34 = v54;
                var v55 = CopyFromGfeIndicator35; v55.Clean = value; CopyFromGfeIndicator35 = v55;
                var v56 = CopyFromGfeIndicator4; v56.Clean = value; CopyFromGfeIndicator4 = v56;
                var v57 = CopyFromGfeIndicator5; v57.Clean = value; CopyFromGfeIndicator5 = v57;
                var v58 = CopyFromGfeIndicator6; v58.Clean = value; CopyFromGfeIndicator6 = v58;
                var v59 = CopyFromGfeIndicator7; v59.Clean = value; CopyFromGfeIndicator7 = v59;
                var v60 = CopyFromGfeIndicator8; v60.Clean = value; CopyFromGfeIndicator8 = v60;
                var v61 = CopyFromGfeIndicator9; v61.Clean = value; CopyFromGfeIndicator9 = v61;
                var v62 = CreditAmount; v62.Clean = value; CreditAmount = v62;
                var v63 = CreditAmountForPrint; v63.Clean = value; CreditAmountForPrint = v63;
                var v64 = CreditChargeType; v64.Clean = value; CreditChargeType = v64;
                var v65 = CreditOrChange; v65.Clean = value; CreditOrChange = v65;
                var v66 = CuredAdjustedOriginationCharges; v66.Clean = value; CuredAdjustedOriginationCharges = v66;
                var v67 = CuredCreditOrChange; v67.Clean = value; CuredCreditOrChange = v67;
                var v68 = CuredOriginationCharges; v68.Clean = value; CuredOriginationCharges = v68;
                var v69 = CuredTotalTransferTaxes; v69.Clean = value; CuredTotalTransferTaxes = v69;
                var v70 = DailyInterestCharges; v70.Clean = value; DailyInterestCharges = v70;
                var v71 = DateForCharges; v71.Clean = value; DateForCharges = v71;
                var v72 = DateForRate; v72.Clean = value; DateForRate = v72;
                var v73 = DaysToSettlement; v73.Clean = value; DaysToSettlement = v73;
                var v74 = DurationMonths; v74.Clean = value; DurationMonths = v74;
                var v75 = EscrowChargeAllInsuranceIndicator; v75.Clean = value; EscrowChargeAllInsuranceIndicator = v75;
                var v76 = EscrowChargeAllPropertyTaxesIndicator; v76.Clean = value; EscrowChargeAllPropertyTaxesIndicator = v76;
                var v77 = EscrowChargeOtherIndicator; v77.Clean = value; EscrowChargeOtherIndicator = v77;
                var v78 = EscrowOtherDescription; v78.Clean = value; EscrowOtherDescription = v78;
                var v79 = FinancedFeesFromPrepaid; v79.Clean = value; FinancedFeesFromPrepaid = v79;
                var v80 = Gfe2010Fees; v80.Clean = value; Gfe2010Fees = v80;
                var v81 = Gfe2010WholePocs; v81.Clean = value; Gfe2010WholePocs = v81;
                var v82 = GfeGovernmentRecordingCharges; v82.Clean = value; GfeGovernmentRecordingCharges = v82;
                var v83 = HazardInsurance; v83.Clean = value; HazardInsurance = v83;
                var v84 = HomeownerInsurance; v84.Clean = value; HomeownerInsurance = v84;
                var v85 = HudGuaranteeFee; v85.Clean = value; HudGuaranteeFee = v85;
                var v86 = Id; v86.Clean = value; Id = v86;
                var v87 = IncludeOriginationPointsCreditType; v87.Clean = value; IncludeOriginationPointsCreditType = v87;
                var v88 = InitialLoanAmount; v88.Clean = value; InitialLoanAmount = v88;
                var v89 = InitialMonthlyAmount; v89.Clean = value; InitialMonthlyAmount = v89;
                var v90 = InterestRateRiseIndicator; v90.Clean = value; InterestRateRiseIndicator = v90;
                var v91 = IsCDValidForEarliestClosingDate; v91.Clean = value; IsCDValidForEarliestClosingDate = v91;
                var v92 = Line1001Fee; v92.Clean = value; Line1001Fee = v92;
                var v93 = Line1002Fee; v93.Clean = value; Line1002Fee = v93;
                var v94 = Line1003Fee; v94.Clean = value; Line1003Fee = v94;
                var v95 = Line1004Fee; v95.Clean = value; Line1004Fee = v95;
                var v96 = Line1005Fee; v96.Clean = value; Line1005Fee = v96;
                var v97 = Line1006Fee; v97.Clean = value; Line1006Fee = v97;
                var v98 = Line1007Fee; v98.Clean = value; Line1007Fee = v98;
                var v99 = Line1008Fee; v99.Clean = value; Line1008Fee = v99;
                var v100 = Line1009Fee; v100.Clean = value; Line1009Fee = v100;
                var v101 = Line801BrokerCompensationAdditionalAmount; v101.Clean = value; Line801BrokerCompensationAdditionalAmount = v101;
                var v102 = Line801BrokerCompensationFees; v102.Clean = value; Line801BrokerCompensationFees = v102;
                var v103 = Line801BrokerCompensationRate; v103.Clean = value; Line801BrokerCompensationRate = v103;
                var v104 = Line808Fee; v104.Clean = value; Line808Fee = v104;
                var v105 = Line809Fee; v105.Clean = value; Line809Fee = v105;
                var v106 = Line810Fee; v106.Clean = value; Line810Fee = v106;
                var v107 = Line811Fee; v107.Clean = value; Line811Fee = v107;
                var v108 = Line812Fee; v108.Clean = value; Line812Fee = v108;
                var v109 = Line813Fee; v109.Clean = value; Line813Fee = v109;
                var v110 = Line814Fee; v110.Clean = value; Line814Fee = v110;
                var v111 = Line815Fee; v111.Clean = value; Line815Fee = v111;
                var v112 = Line816Fee; v112.Clean = value; Line816Fee = v112;
                var v113 = Line817Fee; v113.Clean = value; Line817Fee = v113;
                var v114 = Line818Fee; v114.Clean = value; Line818Fee = v114;
                var v115 = Line819Fee; v115.Clean = value; Line819Fee = v115;
                var v116 = Line820Fee; v116.Clean = value; Line820Fee = v116;
                var v117 = Line821Fee; v117.Clean = value; Line821Fee = v117;
                var v118 = Line822Fee; v118.Clean = value; Line822Fee = v118;
                var v119 = Line823Fee; v119.Clean = value; Line823Fee = v119;
                var v120 = Line824Fee; v120.Clean = value; Line824Fee = v120;
                var v121 = Line825Fee; v121.Clean = value; Line825Fee = v121;
                var v122 = Line826Fee; v122.Clean = value; Line826Fee = v122;
                var v123 = Line827Fee; v123.Clean = value; Line827Fee = v123;
                var v124 = Line828Fee; v124.Clean = value; Line828Fee = v124;
                var v125 = Line829Fee; v125.Clean = value; Line829Fee = v125;
                var v126 = Line830Fee; v126.Clean = value; Line830Fee = v126;
                var v127 = Line831Fee; v127.Clean = value; Line831Fee = v127;
                var v128 = Line832Fee; v128.Clean = value; Line832Fee = v128;
                var v129 = Line833Fee; v129.Clean = value; Line833Fee = v129;
                var v130 = LoanBalanceRiseIndicator; v130.Clean = value; LoanBalanceRiseIndicator = v130;
                var v131 = LoanOriginationFees; v131.Clean = value; LoanOriginationFees = v131;
                var v132 = LoanOriginationPercentage; v132.Clean = value; LoanOriginationPercentage = v132;
                var v133 = LoanOriginatorName; v133.Clean = value; LoanOriginatorName = v133;
                var v134 = LowerInterestInitialInterestRate; v134.Clean = value; LowerInterestInitialInterestRate = v134;
                var v135 = LowerInterestInitialMonthlyAmountOwed; v135.Clean = value; LowerInterestInitialMonthlyAmountOwed = v135;
                var v136 = LowerInterestMonthlyPaymentReduced; v136.Clean = value; LowerInterestMonthlyPaymentReduced = v136;
                var v137 = LowerInterestServiceChargeIncreasedAmount; v137.Clean = value; LowerInterestServiceChargeIncreasedAmount = v137;
                var v138 = LowerInterestTotalSettlementCharges; v138.Clean = value; LowerInterestTotalSettlementCharges = v138;
                var v139 = LowerSettlementInitialInterestRate; v139.Clean = value; LowerSettlementInitialInterestRate = v139;
                var v140 = LowerSettlementInitialMonthlyAmountOwed; v140.Clean = value; LowerSettlementInitialMonthlyAmountOwed = v140;
                var v141 = LowerSettlementMonthlyPaymentIncreased; v141.Clean = value; LowerSettlementMonthlyPaymentIncreased = v141;
                var v142 = LowerSettlementServiceChargeReducedAmount; v142.Clean = value; LowerSettlementServiceChargeReducedAmount = v142;
                var v143 = LowerSettlementTotalSettlementCharges; v143.Clean = value; LowerSettlementTotalSettlementCharges = v143;
                var v144 = MaximumLoanBalance; v144.Clean = value; MaximumLoanBalance = v144;
                var v145 = MaximumOwedMonthlyPayment; v145.Clean = value; MaximumOwedMonthlyPayment = v145;
                var v146 = MaxLifeInterestCapPercent; v146.Clean = value; MaxLifeInterestCapPercent = v146;
                var v147 = MonthlyPaymentFirstIncreaseDate; v147.Clean = value; MonthlyPaymentFirstIncreaseDate = v147;
                var v148 = MonthlyPaymentRiseIndicator; v148.Clean = value; MonthlyPaymentRiseIndicator = v148;
                var v149 = MortgageInsurancePremium; v149.Clean = value; MortgageInsurancePremium = v149;
                var v150 = MustLockRateDays; v150.Clean = value; MustLockRateDays = v150;
                var v151 = NewHudSection1100Line1104BorPaidAmount; v151.Clean = value; NewHudSection1100Line1104BorPaidAmount = v151;
                var v152 = NewHudSection1100Line1104SelPaidAmount; v152.Clean = value; NewHudSection1100Line1104SelPaidAmount = v152;
                var v153 = NewHudSection1100Line1107BorPaidAmount; v153.Clean = value; NewHudSection1100Line1107BorPaidAmount = v153;
                var v154 = NewHudSection1100Line1108BorPaidAmount; v154.Clean = value; NewHudSection1100Line1108BorPaidAmount = v154;
                var v155 = OriginationCharges; v155.Clean = value; OriginationCharges = v155;
                var v156 = OriginationCreditYsp; v156.Clean = value; OriginationCreditYsp = v156;
                var v157 = OriginationCreditYspAdditional; v157.Clean = value; OriginationCreditYspAdditional = v157;
                var v158 = OriginationPoints; v158.Clean = value; OriginationPoints = v158;
                var v159 = OriginationPointsAdditional; v159.Clean = value; OriginationPointsAdditional = v159;
                var v160 = OriginationPointsPercentage; v160.Clean = value; OriginationPointsPercentage = v160;
                var v161 = OwnerTitleInsuranceAmount; v161.Clean = value; OwnerTitleInsuranceAmount = v161;
                var v162 = PrintNAInLockRateDays; v162.Clean = value; PrintNAInLockRateDays = v162;
                var v163 = PrintShoppingChartIndicator; v163.Clean = value; PrintShoppingChartIndicator = v163;
                var v164 = ProcessingFees; v164.Clean = value; ProcessingFees = v164;
                var v165 = RequiredAppraisalFee; v165.Clean = value; RequiredAppraisalFee = v165;
                var v166 = RequiredCreditReportFee; v166.Clean = value; RequiredCreditReportFee = v166;
                var v167 = RequiredFloodCertificationFee; v167.Clean = value; RequiredFloodCertificationFee = v167;
                var v168 = RequiredServicesAmount; v168.Clean = value; RequiredServicesAmount = v168;
                var v169 = RequiredTaxServiceFee; v169.Clean = value; RequiredTaxServiceFee = v169;
                var v170 = Section1000TotalBorrowerPaidAmount; v170.Clean = value; Section1000TotalBorrowerPaidAmount = v170;
                var v171 = Section1000TotalOtherPaidAmount; v171.Clean = value; Section1000TotalOtherPaidAmount = v171;
                var v172 = Section1000TotalPaidAmount; v172.Clean = value; Section1000TotalPaidAmount = v172;
                var v173 = Section1000TotalSellerPaidAmount; v173.Clean = value; Section1000TotalSellerPaidAmount = v173;
                var v174 = Section1100TotalBorrowerPaidAmount; v174.Clean = value; Section1100TotalBorrowerPaidAmount = v174;
                var v175 = Section1100TotalOtherPaidAmount; v175.Clean = value; Section1100TotalOtherPaidAmount = v175;
                var v176 = Section1100TotalPaidAmount; v176.Clean = value; Section1100TotalPaidAmount = v176;
                var v177 = Section1100TotalSellerPaidAmount; v177.Clean = value; Section1100TotalSellerPaidAmount = v177;
                var v178 = Section1200TotalBorrowerPaidAmount; v178.Clean = value; Section1200TotalBorrowerPaidAmount = v178;
                var v179 = Section1200TotalOtherPaidAmount; v179.Clean = value; Section1200TotalOtherPaidAmount = v179;
                var v180 = Section1200TotalPaidAmount; v180.Clean = value; Section1200TotalPaidAmount = v180;
                var v181 = Section1200TotalSellerPaidAmount; v181.Clean = value; Section1200TotalSellerPaidAmount = v181;
                var v182 = Section1300TotalBorrowerPaidAmount; v182.Clean = value; Section1300TotalBorrowerPaidAmount = v182;
                var v183 = Section1300TotalOtherPaidAmount; v183.Clean = value; Section1300TotalOtherPaidAmount = v183;
                var v184 = Section1300TotalPaidAmount; v184.Clean = value; Section1300TotalPaidAmount = v184;
                var v185 = Section1300TotalSellerPaidAmount; v185.Clean = value; Section1300TotalSellerPaidAmount = v185;
                var v186 = Section1400TotalBorrowerPaidAmount; v186.Clean = value; Section1400TotalBorrowerPaidAmount = v186;
                var v187 = Section1400TotalOtherPaidAmount; v187.Clean = value; Section1400TotalOtherPaidAmount = v187;
                var v188 = Section1400TotalPaidAmount; v188.Clean = value; Section1400TotalPaidAmount = v188;
                var v189 = Section1400TotalSellerPaidAmount; v189.Clean = value; Section1400TotalSellerPaidAmount = v189;
                var v190 = Section700TotalBorrowerPaidAmount; v190.Clean = value; Section700TotalBorrowerPaidAmount = v190;
                var v191 = Section700TotalOtherPaidAmount; v191.Clean = value; Section700TotalOtherPaidAmount = v191;
                var v192 = Section700TotalPaidAmount; v192.Clean = value; Section700TotalPaidAmount = v192;
                var v193 = Section700TotalSellerPaidAmount; v193.Clean = value; Section700TotalSellerPaidAmount = v193;
                var v194 = Section800TotalBorrowerPaidAmount; v194.Clean = value; Section800TotalBorrowerPaidAmount = v194;
                var v195 = Section800TotalOtherPaidAmount; v195.Clean = value; Section800TotalOtherPaidAmount = v195;
                var v196 = Section800TotalPaidAmount; v196.Clean = value; Section800TotalPaidAmount = v196;
                var v197 = Section800TotalSellerPaidAmount; v197.Clean = value; Section800TotalSellerPaidAmount = v197;
                var v198 = Section900TotalBorrowerPaidAmount; v198.Clean = value; Section900TotalBorrowerPaidAmount = v198;
                var v199 = Section900TotalOtherPaidAmount; v199.Clean = value; Section900TotalOtherPaidAmount = v199;
                var v200 = Section900TotalPaidAmount; v200.Clean = value; Section900TotalPaidAmount = v200;
                var v201 = Section900TotalSellerPaidAmount; v201.Clean = value; Section900TotalSellerPaidAmount = v201;
                var v202 = ShopRequiredServicesAmount; v202.Clean = value; ShopRequiredServicesAmount = v202;
                var v203 = SubsequentCapPercent; v203.Clean = value; SubsequentCapPercent = v203;
                var v204 = SubsequentRateAdjustmentMonths; v204.Clean = value; SubsequentRateAdjustmentMonths = v204;
                var v205 = TableFundedIndicator; v205.Clean = value; TableFundedIndicator = v205;
                var v206 = TimeForRate; v206.Clean = value; TimeForRate = v206;
                var v207 = TitleServiceAmount; v207.Clean = value; TitleServiceAmount = v207;
                var v208 = TotalBelow10; v208.Clean = value; TotalBelow10 = v208;
                var v209 = TotalOfFinancedFees; v209.Clean = value; TotalOfFinancedFees = v209;
                var v210 = TotalSettlementCharges; v210.Clean = value; TotalSettlementCharges = v210;
                var v211 = TotalTransferTaxes; v211.Clean = value; TotalTransferTaxes = v211;
                var v212 = TransferTaxes; v212.Clean = value; TransferTaxes = v212;
                var v213 = UnderwritingFees; v213.Clean = value; UnderwritingFees = v213;
                var v214 = UseLOCompTool; v214.Clean = value; UseLOCompTool = v214;
                _settingClean = 0;
            }
        }
    }
}