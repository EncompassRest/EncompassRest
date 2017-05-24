using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkFee
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<string> FeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeType() => !FeeType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<int?> NewYorkFeeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkFeeIndex() => !NewYorkFeeIndex.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Address.Clean
                    && Amount.Clean
                    && City.Clean
                    && Comments.Clean
                    && Date.Clean
                    && FeeType.Clean
                    && Id.Clean
                    && Name.Clean
                    && NewYorkFeeIndex.Clean
                    && PostalCode.Clean
                    && State.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = Amount; v1.Clean = value; Amount = v1;
                var v2 = City; v2.Clean = value; City = v2;
                var v3 = Comments; v3.Clean = value; Comments = v3;
                var v4 = Date; v4.Clean = value; Date = v4;
                var v5 = FeeType; v5.Clean = value; FeeType = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = Name; v7.Clean = value; Name = v7;
                var v8 = NewYorkFeeIndex; v8.Clean = value; NewYorkFeeIndex = v8;
                var v9 = PostalCode; v9.Clean = value; PostalCode = v9;
                var v10 = State; v10.Clean = value; State = v10;
                _settingClean = 0;
            }
        }
    }
}