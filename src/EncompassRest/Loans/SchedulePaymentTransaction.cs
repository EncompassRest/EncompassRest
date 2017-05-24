using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SchedulePaymentTransaction
    {
        public Value<decimal?> AdditionalEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalEscrow() => !AdditionalEscrow.Clean;
        public Value<decimal?> AdditionalPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalPrincipal() => !AdditionalPrincipal.Clean;
        public Value<decimal?> BuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownSubsidyAmount() => !BuydownSubsidyAmount.Clean;
        public Value<decimal?> BuydownSubsidyAmountDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownSubsidyAmountDue() => !BuydownSubsidyAmountDue.Clean;
        public Value<decimal?> CityPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTax() => !CityPropertyTax.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> CreatedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedById() => !CreatedById.Clean;
        public Value<string> CreatedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedByName() => !CreatedByName.Clean;
        public Value<DateTime?> CreatedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedDateTimeUtc() => !CreatedDateTimeUtc.Clean;
        public Value<decimal?> Escrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrow() => !Escrow.Clean;
        public Value<decimal?> EscrowCityPropertyTaxDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowCityPropertyTaxDue() => !EscrowCityPropertyTaxDue.Clean;
        public Value<decimal?> EscrowDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowDue() => !EscrowDue.Clean;
        public Value<decimal?> EscrowFloodInsuranceDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFloodInsuranceDue() => !EscrowFloodInsuranceDue.Clean;
        public Value<decimal?> EscrowHazardInsuranceDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowHazardInsuranceDue() => !EscrowHazardInsuranceDue.Clean;
        public Value<decimal?> EscrowMortgageInsuranceDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowMortgageInsuranceDue() => !EscrowMortgageInsuranceDue.Clean;
        public Value<decimal?> EscrowOther1Due { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther1Due() => !EscrowOther1Due.Clean;
        public Value<decimal?> EscrowOther2Due { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther2Due() => !EscrowOther2Due.Clean;
        public Value<decimal?> EscrowOther3Due { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther3Due() => !EscrowOther3Due.Clean;
        public Value<decimal?> EscrowTaxDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTaxDue() => !EscrowTaxDue.Clean;
        public Value<decimal?> EscrowUSDAMonthlyPremiumDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowUSDAMonthlyPremiumDue() => !EscrowUSDAMonthlyPremiumDue.Clean;
        public Value<decimal?> FloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsurance() => !FloodInsurance.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<decimal?> HazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardInsurance() => !HazardInsurance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndexRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRate() => !IndexRate.Clean;
        public Value<decimal?> Interest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterest() => !Interest.Clean;
        public Value<decimal?> InterestDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestDue() => !InterestDue.Clean;
        public Value<decimal?> InterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRate() => !InterestRate.Clean;
        public Value<decimal?> LateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFee() => !LateFee.Clean;
        public Value<DateTime?> LatePaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLatePaymentDate() => !LatePaymentDate.Clean;
        public Value<decimal?> MiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiscFee() => !MiscFee.Clean;
        public Value<decimal?> MiscFeeDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiscFeeDue() => !MiscFeeDue.Clean;
        public Value<string> ModifiedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedById() => !ModifiedById.Clean;
        public Value<string> ModifiedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedByName() => !ModifiedByName.Clean;
        public Value<DateTime?> ModifiedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedDateTimeUtc() => !ModifiedDateTimeUtc.Clean;
        public Value<decimal?> MortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurance() => !MortgageInsurance.Clean;
        public Value<decimal?> Other1Escrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther1Escrow() => !Other1Escrow.Clean;
        public Value<decimal?> Other2Escrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther2Escrow() => !Other2Escrow.Clean;
        public Value<decimal?> Other3Escrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther3Escrow() => !Other3Escrow.Clean;
        public Value<int?> PaymentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentNumber() => !PaymentNumber.Clean;
        public Value<DateTime?> PaymentReceiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentReceiveDate() => !PaymentReceiveDate.Clean;
        public Value<decimal?> Principal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipal() => !Principal.Clean;
        public Value<decimal?> PrincipalDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalDue() => !PrincipalDue.Clean;
        public Value<string> ServicingPaymentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingPaymentMethod() => !ServicingPaymentMethod.Clean;
        public Value<string> ServicingTransactionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransactionType() => !ServicingTransactionType.Clean;
        public Value<decimal?> Taxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxes() => !Taxes.Clean;
        public Value<decimal?> TotalPastDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPastDue() => !TotalPastDue.Clean;
        public Value<decimal?> TransactionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionAmount() => !TransactionAmount.Clean;
        public Value<DateTime?> TransactionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionDate() => !TransactionDate.Clean;
        public Value<decimal?> UnpaidLateFeeDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidLateFeeDue() => !UnpaidLateFeeDue.Clean;
        public Value<decimal?> USDAMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUSDAMonthlyPremium() => !USDAMonthlyPremium.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalEscrow.Clean
                    && AdditionalPrincipal.Clean
                    && BuydownSubsidyAmount.Clean
                    && BuydownSubsidyAmountDue.Clean
                    && CityPropertyTax.Clean
                    && Comments.Clean
                    && CreatedById.Clean
                    && CreatedByName.Clean
                    && CreatedDateTimeUtc.Clean
                    && Escrow.Clean
                    && EscrowCityPropertyTaxDue.Clean
                    && EscrowDue.Clean
                    && EscrowFloodInsuranceDue.Clean
                    && EscrowHazardInsuranceDue.Clean
                    && EscrowMortgageInsuranceDue.Clean
                    && EscrowOther1Due.Clean
                    && EscrowOther2Due.Clean
                    && EscrowOther3Due.Clean
                    && EscrowTaxDue.Clean
                    && EscrowUSDAMonthlyPremiumDue.Clean
                    && FloodInsurance.Clean
                    && Guid.Clean
                    && HazardInsurance.Clean
                    && Id.Clean
                    && IndexRate.Clean
                    && Interest.Clean
                    && InterestDue.Clean
                    && InterestRate.Clean
                    && LateFee.Clean
                    && LatePaymentDate.Clean
                    && MiscFee.Clean
                    && MiscFeeDue.Clean
                    && ModifiedById.Clean
                    && ModifiedByName.Clean
                    && ModifiedDateTimeUtc.Clean
                    && MortgageInsurance.Clean
                    && Other1Escrow.Clean
                    && Other2Escrow.Clean
                    && Other3Escrow.Clean
                    && PaymentNumber.Clean
                    && PaymentReceiveDate.Clean
                    && Principal.Clean
                    && PrincipalDue.Clean
                    && ServicingPaymentMethod.Clean
                    && ServicingTransactionType.Clean
                    && Taxes.Clean
                    && TotalPastDue.Clean
                    && TransactionAmount.Clean
                    && TransactionDate.Clean
                    && UnpaidLateFeeDue.Clean
                    && USDAMonthlyPremium.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalEscrow; v0.Clean = value; AdditionalEscrow = v0;
                var v1 = AdditionalPrincipal; v1.Clean = value; AdditionalPrincipal = v1;
                var v2 = BuydownSubsidyAmount; v2.Clean = value; BuydownSubsidyAmount = v2;
                var v3 = BuydownSubsidyAmountDue; v3.Clean = value; BuydownSubsidyAmountDue = v3;
                var v4 = CityPropertyTax; v4.Clean = value; CityPropertyTax = v4;
                var v5 = Comments; v5.Clean = value; Comments = v5;
                var v6 = CreatedById; v6.Clean = value; CreatedById = v6;
                var v7 = CreatedByName; v7.Clean = value; CreatedByName = v7;
                var v8 = CreatedDateTimeUtc; v8.Clean = value; CreatedDateTimeUtc = v8;
                var v9 = Escrow; v9.Clean = value; Escrow = v9;
                var v10 = EscrowCityPropertyTaxDue; v10.Clean = value; EscrowCityPropertyTaxDue = v10;
                var v11 = EscrowDue; v11.Clean = value; EscrowDue = v11;
                var v12 = EscrowFloodInsuranceDue; v12.Clean = value; EscrowFloodInsuranceDue = v12;
                var v13 = EscrowHazardInsuranceDue; v13.Clean = value; EscrowHazardInsuranceDue = v13;
                var v14 = EscrowMortgageInsuranceDue; v14.Clean = value; EscrowMortgageInsuranceDue = v14;
                var v15 = EscrowOther1Due; v15.Clean = value; EscrowOther1Due = v15;
                var v16 = EscrowOther2Due; v16.Clean = value; EscrowOther2Due = v16;
                var v17 = EscrowOther3Due; v17.Clean = value; EscrowOther3Due = v17;
                var v18 = EscrowTaxDue; v18.Clean = value; EscrowTaxDue = v18;
                var v19 = EscrowUSDAMonthlyPremiumDue; v19.Clean = value; EscrowUSDAMonthlyPremiumDue = v19;
                var v20 = FloodInsurance; v20.Clean = value; FloodInsurance = v20;
                var v21 = Guid; v21.Clean = value; Guid = v21;
                var v22 = HazardInsurance; v22.Clean = value; HazardInsurance = v22;
                var v23 = Id; v23.Clean = value; Id = v23;
                var v24 = IndexRate; v24.Clean = value; IndexRate = v24;
                var v25 = Interest; v25.Clean = value; Interest = v25;
                var v26 = InterestDue; v26.Clean = value; InterestDue = v26;
                var v27 = InterestRate; v27.Clean = value; InterestRate = v27;
                var v28 = LateFee; v28.Clean = value; LateFee = v28;
                var v29 = LatePaymentDate; v29.Clean = value; LatePaymentDate = v29;
                var v30 = MiscFee; v30.Clean = value; MiscFee = v30;
                var v31 = MiscFeeDue; v31.Clean = value; MiscFeeDue = v31;
                var v32 = ModifiedById; v32.Clean = value; ModifiedById = v32;
                var v33 = ModifiedByName; v33.Clean = value; ModifiedByName = v33;
                var v34 = ModifiedDateTimeUtc; v34.Clean = value; ModifiedDateTimeUtc = v34;
                var v35 = MortgageInsurance; v35.Clean = value; MortgageInsurance = v35;
                var v36 = Other1Escrow; v36.Clean = value; Other1Escrow = v36;
                var v37 = Other2Escrow; v37.Clean = value; Other2Escrow = v37;
                var v38 = Other3Escrow; v38.Clean = value; Other3Escrow = v38;
                var v39 = PaymentNumber; v39.Clean = value; PaymentNumber = v39;
                var v40 = PaymentReceiveDate; v40.Clean = value; PaymentReceiveDate = v40;
                var v41 = Principal; v41.Clean = value; Principal = v41;
                var v42 = PrincipalDue; v42.Clean = value; PrincipalDue = v42;
                var v43 = ServicingPaymentMethod; v43.Clean = value; ServicingPaymentMethod = v43;
                var v44 = ServicingTransactionType; v44.Clean = value; ServicingTransactionType = v44;
                var v45 = Taxes; v45.Clean = value; Taxes = v45;
                var v46 = TotalPastDue; v46.Clean = value; TotalPastDue = v46;
                var v47 = TransactionAmount; v47.Clean = value; TransactionAmount = v47;
                var v48 = TransactionDate; v48.Clean = value; TransactionDate = v48;
                var v49 = UnpaidLateFeeDue; v49.Clean = value; UnpaidLateFeeDue = v49;
                var v50 = USDAMonthlyPremium; v50.Clean = value; USDAMonthlyPremium = v50;
                _settingClean = 0;
            }
        }
    }
}