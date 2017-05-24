using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PaymentTransaction
    {
        public Value<string> AccountHolder { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountHolder() => !AccountHolder.Clean;
        public Value<string> AccountNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountNumber() => !AccountNumber.Clean;
        public Value<decimal?> AdditionalEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalEscrow() => !AdditionalEscrow.Clean;
        public Value<decimal?> AdditionalPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalPrincipal() => !AdditionalPrincipal.Clean;
        public Value<decimal?> BuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownSubsidyAmount() => !BuydownSubsidyAmount.Clean;
        public Value<string> CheckNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCheckNumber() => !CheckNumber.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<decimal?> CommonAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommonAmount() => !CommonAmount.Clean;
        public Value<DateTime?> CommonDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommonDate() => !CommonDate.Clean;
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
        public Value<decimal?> EscrowCityPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowCityPropertyTax() => !EscrowCityPropertyTax.Clean;
        public Value<decimal?> EscrowFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFloodInsurance() => !EscrowFloodInsurance.Clean;
        public Value<decimal?> EscrowHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowHazardInsurance() => !EscrowHazardInsurance.Clean;
        public Value<decimal?> EscrowMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowMortgageInsurance() => !EscrowMortgageInsurance.Clean;
        public Value<decimal?> EscrowOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther1() => !EscrowOther1.Clean;
        public Value<decimal?> EscrowOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther2() => !EscrowOther2.Clean;
        public Value<decimal?> EscrowOther3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowOther3() => !EscrowOther3.Clean;
        public Value<decimal?> EscrowTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTax() => !EscrowTax.Clean;
        public Value<decimal?> EscrowUSDAMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowUSDAMonthlyPremium() => !EscrowUSDAMonthlyPremium.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndexRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRate() => !IndexRate.Clean;
        public Value<string> InstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionName() => !InstitutionName.Clean;
        public Value<string> InstitutionRouting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionRouting() => !InstitutionRouting.Clean;
        public Value<decimal?> Interest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterest() => !Interest.Clean;
        public Value<decimal?> InterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRate() => !InterestRate.Clean;
        public Value<decimal?> LateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFee() => !LateFee.Clean;
        public Value<decimal?> LateFeeIfLate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeeIfLate() => !LateFeeIfLate.Clean;
        public Value<DateTime?> LatePaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLatePaymentDate() => !LatePaymentDate.Clean;
        public Value<decimal?> MiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiscFee() => !MiscFee.Clean;
        public Value<string> ModifiedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedById() => !ModifiedById.Clean;
        public Value<string> ModifiedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedByName() => !ModifiedByName.Clean;
        public Value<DateTime?> ModifiedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedDateTimeUtc() => !ModifiedDateTimeUtc.Clean;
        public Value<DateTime?> PaymentDepositedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDepositedDate() => !PaymentDepositedDate.Clean;
        public Value<DateTime?> PaymentDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDueDate() => !PaymentDueDate.Clean;
        public Value<DateTime?> PaymentIndexDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentIndexDate() => !PaymentIndexDate.Clean;
        public Value<int?> PaymentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentNumber() => !PaymentNumber.Clean;
        public Value<DateTime?> PaymentReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentReceivedDate() => !PaymentReceivedDate.Clean;
        public Value<decimal?> Principal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipal() => !Principal.Clean;
        public Value<string> Reference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReference() => !Reference.Clean;
        public Value<decimal?> SchedulePayLogMiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchedulePayLogMiscFee() => !SchedulePayLogMiscFee.Clean;
        public Value<string> ServicingPaymentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingPaymentMethod() => !ServicingPaymentMethod.Clean;
        public Value<string> ServicingTransactionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransactionType() => !ServicingTransactionType.Clean;
        public Value<DateTime?> StatementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatementDate() => !StatementDate.Clean;
        public Value<decimal?> TotalAmountDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAmountDue() => !TotalAmountDue.Clean;
        public Value<decimal?> TotalAmountReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAmountReceived() => !TotalAmountReceived.Clean;
        public Value<decimal?> TransactionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionAmount() => !TransactionAmount.Clean;
        public Value<DateTime?> TransactionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionDate() => !TransactionDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccountHolder.Clean
                    && AccountNumber.Clean
                    && AdditionalEscrow.Clean
                    && AdditionalPrincipal.Clean
                    && BuydownSubsidyAmount.Clean
                    && CheckNumber.Clean
                    && Comments.Clean
                    && CommonAmount.Clean
                    && CommonDate.Clean
                    && CreatedById.Clean
                    && CreatedByName.Clean
                    && CreatedDateTimeUtc.Clean
                    && Escrow.Clean
                    && EscrowCityPropertyTax.Clean
                    && EscrowFloodInsurance.Clean
                    && EscrowHazardInsurance.Clean
                    && EscrowMortgageInsurance.Clean
                    && EscrowOther1.Clean
                    && EscrowOther2.Clean
                    && EscrowOther3.Clean
                    && EscrowTax.Clean
                    && EscrowUSDAMonthlyPremium.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IndexRate.Clean
                    && InstitutionName.Clean
                    && InstitutionRouting.Clean
                    && Interest.Clean
                    && InterestRate.Clean
                    && LateFee.Clean
                    && LateFeeIfLate.Clean
                    && LatePaymentDate.Clean
                    && MiscFee.Clean
                    && ModifiedById.Clean
                    && ModifiedByName.Clean
                    && ModifiedDateTimeUtc.Clean
                    && PaymentDepositedDate.Clean
                    && PaymentDueDate.Clean
                    && PaymentIndexDate.Clean
                    && PaymentNumber.Clean
                    && PaymentReceivedDate.Clean
                    && Principal.Clean
                    && Reference.Clean
                    && SchedulePayLogMiscFee.Clean
                    && ServicingPaymentMethod.Clean
                    && ServicingTransactionType.Clean
                    && StatementDate.Clean
                    && TotalAmountDue.Clean
                    && TotalAmountReceived.Clean
                    && TransactionAmount.Clean
                    && TransactionDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountHolder; v0.Clean = value; AccountHolder = v0;
                var v1 = AccountNumber; v1.Clean = value; AccountNumber = v1;
                var v2 = AdditionalEscrow; v2.Clean = value; AdditionalEscrow = v2;
                var v3 = AdditionalPrincipal; v3.Clean = value; AdditionalPrincipal = v3;
                var v4 = BuydownSubsidyAmount; v4.Clean = value; BuydownSubsidyAmount = v4;
                var v5 = CheckNumber; v5.Clean = value; CheckNumber = v5;
                var v6 = Comments; v6.Clean = value; Comments = v6;
                var v7 = CommonAmount; v7.Clean = value; CommonAmount = v7;
                var v8 = CommonDate; v8.Clean = value; CommonDate = v8;
                var v9 = CreatedById; v9.Clean = value; CreatedById = v9;
                var v10 = CreatedByName; v10.Clean = value; CreatedByName = v10;
                var v11 = CreatedDateTimeUtc; v11.Clean = value; CreatedDateTimeUtc = v11;
                var v12 = Escrow; v12.Clean = value; Escrow = v12;
                var v13 = EscrowCityPropertyTax; v13.Clean = value; EscrowCityPropertyTax = v13;
                var v14 = EscrowFloodInsurance; v14.Clean = value; EscrowFloodInsurance = v14;
                var v15 = EscrowHazardInsurance; v15.Clean = value; EscrowHazardInsurance = v15;
                var v16 = EscrowMortgageInsurance; v16.Clean = value; EscrowMortgageInsurance = v16;
                var v17 = EscrowOther1; v17.Clean = value; EscrowOther1 = v17;
                var v18 = EscrowOther2; v18.Clean = value; EscrowOther2 = v18;
                var v19 = EscrowOther3; v19.Clean = value; EscrowOther3 = v19;
                var v20 = EscrowTax; v20.Clean = value; EscrowTax = v20;
                var v21 = EscrowUSDAMonthlyPremium; v21.Clean = value; EscrowUSDAMonthlyPremium = v21;
                var v22 = Guid; v22.Clean = value; Guid = v22;
                var v23 = Id; v23.Clean = value; Id = v23;
                var v24 = IndexRate; v24.Clean = value; IndexRate = v24;
                var v25 = InstitutionName; v25.Clean = value; InstitutionName = v25;
                var v26 = InstitutionRouting; v26.Clean = value; InstitutionRouting = v26;
                var v27 = Interest; v27.Clean = value; Interest = v27;
                var v28 = InterestRate; v28.Clean = value; InterestRate = v28;
                var v29 = LateFee; v29.Clean = value; LateFee = v29;
                var v30 = LateFeeIfLate; v30.Clean = value; LateFeeIfLate = v30;
                var v31 = LatePaymentDate; v31.Clean = value; LatePaymentDate = v31;
                var v32 = MiscFee; v32.Clean = value; MiscFee = v32;
                var v33 = ModifiedById; v33.Clean = value; ModifiedById = v33;
                var v34 = ModifiedByName; v34.Clean = value; ModifiedByName = v34;
                var v35 = ModifiedDateTimeUtc; v35.Clean = value; ModifiedDateTimeUtc = v35;
                var v36 = PaymentDepositedDate; v36.Clean = value; PaymentDepositedDate = v36;
                var v37 = PaymentDueDate; v37.Clean = value; PaymentDueDate = v37;
                var v38 = PaymentIndexDate; v38.Clean = value; PaymentIndexDate = v38;
                var v39 = PaymentNumber; v39.Clean = value; PaymentNumber = v39;
                var v40 = PaymentReceivedDate; v40.Clean = value; PaymentReceivedDate = v40;
                var v41 = Principal; v41.Clean = value; Principal = v41;
                var v42 = Reference; v42.Clean = value; Reference = v42;
                var v43 = SchedulePayLogMiscFee; v43.Clean = value; SchedulePayLogMiscFee = v43;
                var v44 = ServicingPaymentMethod; v44.Clean = value; ServicingPaymentMethod = v44;
                var v45 = ServicingTransactionType; v45.Clean = value; ServicingTransactionType = v45;
                var v46 = StatementDate; v46.Clean = value; StatementDate = v46;
                var v47 = TotalAmountDue; v47.Clean = value; TotalAmountDue = v47;
                var v48 = TotalAmountReceived; v48.Clean = value; TotalAmountReceived = v48;
                var v49 = TransactionAmount; v49.Clean = value; TransactionAmount = v49;
                var v50 = TransactionDate; v50.Clean = value; TransactionDate = v50;
                _settingClean = 0;
            }
        }
    }
}