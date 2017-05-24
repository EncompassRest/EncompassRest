using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome
    {
        public Value<bool?> BoolFieldValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBoolFieldValue() => !BoolFieldValue.Clean;
        public Value<string> BusinessName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessName() => !BusinessName.Clean;
        public Value<string> FieldName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFieldName() => !FieldName.Clean;
        public Value<decimal?> FieldValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFieldValue() => !FieldValue.Clean;
        public Value<decimal?> FirstYearAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstYearAmount() => !FirstYearAmount.Clean;
        public Value<string> FormType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormType() => !FormType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> SecondYearAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondYearAmount() => !SecondYearAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BoolFieldValue.Clean
                    && BusinessName.Clean
                    && FieldName.Clean
                    && FieldValue.Clean
                    && FirstYearAmount.Clean
                    && FormType.Clean
                    && Id.Clean
                    && SecondYearAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BoolFieldValue; v0.Clean = value; BoolFieldValue = v0;
                var v1 = BusinessName; v1.Clean = value; BusinessName = v1;
                var v2 = FieldName; v2.Clean = value; FieldName = v2;
                var v3 = FieldValue; v3.Clean = value; FieldValue = v3;
                var v4 = FirstYearAmount; v4.Clean = value; FirstYearAmount = v4;
                var v5 = FormType; v5.Clean = value; FormType = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = SecondYearAmount; v7.Clean = value; SecondYearAmount = v7;
                _settingClean = 0;
            }
        }
    }
}