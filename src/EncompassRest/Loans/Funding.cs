using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Funding
    {
        public Value<DateTime?> CollateralSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralSentDate() => !CollateralSentDate.Clean;
        public Value<string> FunderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFunderName() => !FunderName.Clean;
        public Value<string> FunderUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFunderUrl() => !FunderUrl.Clean;
        public Value<string> FundingClearedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingClearedBy() => !FundingClearedBy.Clean;
        public Value<DateTime?> FundingCloseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingCloseDate() => !FundingCloseDate.Clean;
        public Value<string> FundingFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFees() => !FundingFees.Clean;
        public Value<DateTime?> FundingOrderDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingOrderDate() => !FundingOrderDate.Clean;
        public Value<string> FundingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingType() => !FundingType.Clean;
        public Value<DateTime?> FundsReleasedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsReleasedDate() => !FundsReleasedDate.Clean;
        public Value<string> FundsReleaseNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsReleaseNumber() => !FundsReleaseNumber.Clean;
        public Value<DateTime?> FundsSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsSentDate() => !FundsSentDate.Clean;
        public Value<string> FundsWireTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsWireTo() => !FundsWireTo.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> SentToFunderDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSentToFunderDate() => !SentToFunderDate.Clean;
        public Value<string> WiredToAbaNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToAbaNumber() => !WiredToAbaNumber.Clean;
        public Value<string> WiredToAccountNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToAccountNumber() => !WiredToAccountNumber.Clean;
        public Value<string> WiredToForCreditTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo() => !WiredToForCreditTo.Clean;
        public Value<string> WiredToForCreditTo1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo1() => !WiredToForCreditTo1.Clean;
        public Value<string> WiredToForCreditTo2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo2() => !WiredToForCreditTo2.Clean;
        public Value<string> WiredToForFurtherCreditTo1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForFurtherCreditTo1() => !WiredToForFurtherCreditTo1.Clean;
        public Value<string> WiredToForFurtherCreditTo2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForFurtherCreditTo2() => !WiredToForFurtherCreditTo2.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CollateralSentDate.Clean
                    && FunderName.Clean
                    && FunderUrl.Clean
                    && FundingClearedBy.Clean
                    && FundingCloseDate.Clean
                    && FundingFees.Clean
                    && FundingOrderDate.Clean
                    && FundingType.Clean
                    && FundsReleasedDate.Clean
                    && FundsReleaseNumber.Clean
                    && FundsSentDate.Clean
                    && FundsWireTo.Clean
                    && Id.Clean
                    && SentToFunderDate.Clean
                    && WiredToAbaNumber.Clean
                    && WiredToAccountNumber.Clean
                    && WiredToForCreditTo.Clean
                    && WiredToForCreditTo1.Clean
                    && WiredToForCreditTo2.Clean
                    && WiredToForFurtherCreditTo1.Clean
                    && WiredToForFurtherCreditTo2.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CollateralSentDate; v0.Clean = value; CollateralSentDate = v0;
                var v1 = FunderName; v1.Clean = value; FunderName = v1;
                var v2 = FunderUrl; v2.Clean = value; FunderUrl = v2;
                var v3 = FundingClearedBy; v3.Clean = value; FundingClearedBy = v3;
                var v4 = FundingCloseDate; v4.Clean = value; FundingCloseDate = v4;
                var v5 = FundingFees; v5.Clean = value; FundingFees = v5;
                var v6 = FundingOrderDate; v6.Clean = value; FundingOrderDate = v6;
                var v7 = FundingType; v7.Clean = value; FundingType = v7;
                var v8 = FundsReleasedDate; v8.Clean = value; FundsReleasedDate = v8;
                var v9 = FundsReleaseNumber; v9.Clean = value; FundsReleaseNumber = v9;
                var v10 = FundsSentDate; v10.Clean = value; FundsSentDate = v10;
                var v11 = FundsWireTo; v11.Clean = value; FundsWireTo = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = SentToFunderDate; v13.Clean = value; SentToFunderDate = v13;
                var v14 = WiredToAbaNumber; v14.Clean = value; WiredToAbaNumber = v14;
                var v15 = WiredToAccountNumber; v15.Clean = value; WiredToAccountNumber = v15;
                var v16 = WiredToForCreditTo; v16.Clean = value; WiredToForCreditTo = v16;
                var v17 = WiredToForCreditTo1; v17.Clean = value; WiredToForCreditTo1 = v17;
                var v18 = WiredToForCreditTo2; v18.Clean = value; WiredToForCreditTo2 = v18;
                var v19 = WiredToForFurtherCreditTo1; v19.Clean = value; WiredToForFurtherCreditTo1 = v19;
                var v20 = WiredToForFurtherCreditTo2; v20.Clean = value; WiredToForFurtherCreditTo2 = v20;
                _settingClean = 0;
            }
        }
    }
}