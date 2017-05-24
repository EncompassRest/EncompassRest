using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission
    {
        public Value<decimal?> AmountAvailable { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountAvailable() => !AmountAvailable.Clean;
        public Value<decimal?> AmountRequiredToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountRequiredToClose() => !AmountRequiredToClose.Clean;
        public Value<string> BuydownDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownDescription() => !BuydownDescription.Clean;
        public Value<string> BuydownMonthsPerAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownMonthsPerAdjustment() => !BuydownMonthsPerAdjustment.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> CurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateSetDate() => !CurrentRateSetDate.Clean;
        public Value<DateTime?> DateLastPaymentReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLastPaymentReceived() => !DateLastPaymentReceived.Clean;
        public Value<bool?> FloodIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodIndicator() => !FloodIndicator.Clean;
        public Value<bool?> HazardIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardIndicator() => !HazardIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsSecondaryRegistration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSecondaryRegistration() => !IsSecondaryRegistration.Clean;
        public Value<List<LoanSubmissionFee>> LoanSubmissionFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSubmissionFees() => !LoanSubmissionFees.Clean;
        public Value<DateTime?> LockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockDate() => !LockDate.Clean;
        public Value<DateTime?> LockDateTimestampUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockDateTimestampUtc() => !LockDateTimestampUtc.Clean;
        public Value<DateTime?> LockExpiresDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockExpiresDate() => !LockExpiresDate.Clean;
        public Value<bool?> MmmPmiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMmmPmiIndicator() => !MmmPmiIndicator.Clean;
        public Value<int?> NumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfDays() => !NumberOfDays.Clean;
        public Value<string> OtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !OtherDescription.Clean;
        public Value<bool?> OtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIndicator() => !OtherIndicator.Clean;
        public Value<string> ProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramCode() => !ProgramCode.Clean;
        public Value<string> RateLock { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLock() => !RateLock.Clean;
        public Value<DateTime?> RateLockDisclosureDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockDisclosureDate() => !RateLockDisclosureDate.Clean;
        public Value<bool?> ReducedDocsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedDocsIndicator() => !ReducedDocsIndicator.Clean;
        public Value<bool?> TaxesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesIndicator() => !TaxesIndicator.Clean;
        public Value<decimal?> Total { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !Total.Clean;
        public Value<decimal?> TotalDiscountPointCharged { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointCharged() => !TotalDiscountPointCharged.Clean;
        public Value<decimal?> TotalForDueBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForDueBroker() => !TotalForDueBroker.Clean;
        public Value<decimal?> TotalForDueLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForDueLender() => !TotalForDueLender.Clean;
        public Value<decimal?> TotalForPrimaryResidence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForPrimaryResidence() => !TotalForPrimaryResidence.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AmountAvailable.Clean
                    && AmountRequiredToClose.Clean
                    && BuydownDescription.Clean
                    && BuydownMonthsPerAdjustment.Clean
                    && Comments.Clean
                    && CurrentRateSetDate.Clean
                    && DateLastPaymentReceived.Clean
                    && FloodIndicator.Clean
                    && HazardIndicator.Clean
                    && Id.Clean
                    && IsSecondaryRegistration.Clean
                    && LoanSubmissionFees.Clean
                    && LockDate.Clean
                    && LockDateTimestampUtc.Clean
                    && LockExpiresDate.Clean
                    && MmmPmiIndicator.Clean
                    && NumberOfDays.Clean
                    && OtherDescription.Clean
                    && OtherIndicator.Clean
                    && ProgramCode.Clean
                    && RateLock.Clean
                    && RateLockDisclosureDate.Clean
                    && ReducedDocsIndicator.Clean
                    && TaxesIndicator.Clean
                    && Total.Clean
                    && TotalDiscountPointCharged.Clean
                    && TotalForDueBroker.Clean
                    && TotalForDueLender.Clean
                    && TotalForPrimaryResidence.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AmountAvailable; v0.Clean = value; AmountAvailable = v0;
                var v1 = AmountRequiredToClose; v1.Clean = value; AmountRequiredToClose = v1;
                var v2 = BuydownDescription; v2.Clean = value; BuydownDescription = v2;
                var v3 = BuydownMonthsPerAdjustment; v3.Clean = value; BuydownMonthsPerAdjustment = v3;
                var v4 = Comments; v4.Clean = value; Comments = v4;
                var v5 = CurrentRateSetDate; v5.Clean = value; CurrentRateSetDate = v5;
                var v6 = DateLastPaymentReceived; v6.Clean = value; DateLastPaymentReceived = v6;
                var v7 = FloodIndicator; v7.Clean = value; FloodIndicator = v7;
                var v8 = HazardIndicator; v8.Clean = value; HazardIndicator = v8;
                var v9 = Id; v9.Clean = value; Id = v9;
                var v10 = IsSecondaryRegistration; v10.Clean = value; IsSecondaryRegistration = v10;
                var v11 = LoanSubmissionFees; v11.Clean = value; LoanSubmissionFees = v11;
                var v12 = LockDate; v12.Clean = value; LockDate = v12;
                var v13 = LockDateTimestampUtc; v13.Clean = value; LockDateTimestampUtc = v13;
                var v14 = LockExpiresDate; v14.Clean = value; LockExpiresDate = v14;
                var v15 = MmmPmiIndicator; v15.Clean = value; MmmPmiIndicator = v15;
                var v16 = NumberOfDays; v16.Clean = value; NumberOfDays = v16;
                var v17 = OtherDescription; v17.Clean = value; OtherDescription = v17;
                var v18 = OtherIndicator; v18.Clean = value; OtherIndicator = v18;
                var v19 = ProgramCode; v19.Clean = value; ProgramCode = v19;
                var v20 = RateLock; v20.Clean = value; RateLock = v20;
                var v21 = RateLockDisclosureDate; v21.Clean = value; RateLockDisclosureDate = v21;
                var v22 = ReducedDocsIndicator; v22.Clean = value; ReducedDocsIndicator = v22;
                var v23 = TaxesIndicator; v23.Clean = value; TaxesIndicator = v23;
                var v24 = Total; v24.Clean = value; Total = v24;
                var v25 = TotalDiscountPointCharged; v25.Clean = value; TotalDiscountPointCharged = v25;
                var v26 = TotalForDueBroker; v26.Clean = value; TotalForDueBroker = v26;
                var v27 = TotalForDueLender; v27.Clean = value; TotalForDueLender = v27;
                var v28 = TotalForPrimaryResidence; v28.Clean = value; TotalForPrimaryResidence = v28;
                _settingClean = 0;
            }
        }
    }
}