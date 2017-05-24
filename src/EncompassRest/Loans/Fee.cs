using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Fee
    {
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<decimal?> AmountPerDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountPerDay() => !AmountPerDay.Clean;
        public Value<decimal?> BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorPaidAmount() => !BorPaidAmount.Clean;
        public Value<DateTime?> DateFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateFrom() => !DateFrom.Clean;
        public Value<DateTime?> DateTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateTo() => !DateTo.Clean;
        public Value<int?> Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDays() => !Days.Clean;
        public Value<decimal?> DeedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeedAmount() => !DeedAmount.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> FeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeType() => !FeeType.Clean;
        public Value<bool?> FHA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHA() => !FHA.Clean;
        public Value<string> FWBC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFWBC() => !FWBC.Clean;
        public Value<string> FWSC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFWSC() => !FWSC.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IncludeAboveNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeAboveNumber() => !IncludeAboveNumber.Clean;
        public Value<decimal?> LenderCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCoverage() => !LenderCoverage.Clean;
        public Value<decimal?> MonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !MonthlyPayment.Clean;
        public Value<decimal?> MortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAmount() => !MortgageAmount.Clean;
        public Value<decimal?> NewHUDBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewHUDBorPaidAmount() => !NewHUDBorPaidAmount.Clean;
        public Value<int?> NumberOfMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMonths() => !NumberOfMonths.Clean;
        public Value<decimal?> OwnerCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnerCoverage() => !OwnerCoverage.Clean;
        public Value<string> PaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidBy() => !PaidBy.Clean;
        public Value<decimal?> PaidInAdvance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidInAdvance() => !PaidInAdvance.Clean;
        public Value<decimal?> PaidToBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidToBroker() => !PaidToBroker.Clean;
        public Value<string> PaidToName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidToName() => !PaidToName.Clean;
        public Value<decimal?> PaidToOthers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidToOthers() => !PaidToOthers.Clean;
        public Value<decimal?> Percentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentage() => !Percentage.Clean;
        public Value<bool?> PFC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePFC() => !PFC.Clean;
        public Value<bool?> POC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOC() => !POC.Clean;
        public Value<string> PTB { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePTB() => !PTB.Clean;
        public Value<decimal?> ReleasesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleasesAmount() => !ReleasesAmount.Clean;
        public Value<decimal?> SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPaidAmount() => !SellerPaidAmount.Clean;
        public Value<decimal?> TruncatedAmountPerDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTruncatedAmountPerDay() => !TruncatedAmountPerDay.Clean;
        public Value<bool?> Use4Decimals { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUse4Decimals() => !Use4Decimals.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Amount.Clean
                    && AmountPerDay.Clean
                    && BorPaidAmount.Clean
                    && DateFrom.Clean
                    && DateTo.Clean
                    && Days.Clean
                    && DeedAmount.Clean
                    && Description.Clean
                    && FeeType.Clean
                    && FHA.Clean
                    && FWBC.Clean
                    && FWSC.Clean
                    && Id.Clean
                    && IncludeAboveNumber.Clean
                    && LenderCoverage.Clean
                    && MonthlyPayment.Clean
                    && MortgageAmount.Clean
                    && NewHUDBorPaidAmount.Clean
                    && NumberOfMonths.Clean
                    && OwnerCoverage.Clean
                    && PaidBy.Clean
                    && PaidInAdvance.Clean
                    && PaidToBroker.Clean
                    && PaidToName.Clean
                    && PaidToOthers.Clean
                    && Percentage.Clean
                    && PFC.Clean
                    && POC.Clean
                    && PTB.Clean
                    && ReleasesAmount.Clean
                    && SellerPaidAmount.Clean
                    && TruncatedAmountPerDay.Clean
                    && Use4Decimals.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Amount; v0.Clean = value; Amount = v0;
                var v1 = AmountPerDay; v1.Clean = value; AmountPerDay = v1;
                var v2 = BorPaidAmount; v2.Clean = value; BorPaidAmount = v2;
                var v3 = DateFrom; v3.Clean = value; DateFrom = v3;
                var v4 = DateTo; v4.Clean = value; DateTo = v4;
                var v5 = Days; v5.Clean = value; Days = v5;
                var v6 = DeedAmount; v6.Clean = value; DeedAmount = v6;
                var v7 = Description; v7.Clean = value; Description = v7;
                var v8 = FeeType; v8.Clean = value; FeeType = v8;
                var v9 = FHA; v9.Clean = value; FHA = v9;
                var v10 = FWBC; v10.Clean = value; FWBC = v10;
                var v11 = FWSC; v11.Clean = value; FWSC = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = IncludeAboveNumber; v13.Clean = value; IncludeAboveNumber = v13;
                var v14 = LenderCoverage; v14.Clean = value; LenderCoverage = v14;
                var v15 = MonthlyPayment; v15.Clean = value; MonthlyPayment = v15;
                var v16 = MortgageAmount; v16.Clean = value; MortgageAmount = v16;
                var v17 = NewHUDBorPaidAmount; v17.Clean = value; NewHUDBorPaidAmount = v17;
                var v18 = NumberOfMonths; v18.Clean = value; NumberOfMonths = v18;
                var v19 = OwnerCoverage; v19.Clean = value; OwnerCoverage = v19;
                var v20 = PaidBy; v20.Clean = value; PaidBy = v20;
                var v21 = PaidInAdvance; v21.Clean = value; PaidInAdvance = v21;
                var v22 = PaidToBroker; v22.Clean = value; PaidToBroker = v22;
                var v23 = PaidToName; v23.Clean = value; PaidToName = v23;
                var v24 = PaidToOthers; v24.Clean = value; PaidToOthers = v24;
                var v25 = Percentage; v25.Clean = value; Percentage = v25;
                var v26 = PFC; v26.Clean = value; PFC = v26;
                var v27 = POC; v27.Clean = value; POC = v27;
                var v28 = PTB; v28.Clean = value; PTB = v28;
                var v29 = ReleasesAmount; v29.Clean = value; ReleasesAmount = v29;
                var v30 = SellerPaidAmount; v30.Clean = value; SellerPaidAmount = v30;
                var v31 = TruncatedAmountPerDay; v31.Clean = value; TruncatedAmountPerDay = v31;
                var v32 = Use4Decimals; v32.Clean = value; Use4Decimals = v32;
                _settingClean = 0;
            }
        }
    }
}