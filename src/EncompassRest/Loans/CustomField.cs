using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CustomField
    {
        public Value<DateTime?> DateValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateValue() => !DateValue.Clean;
        public Value<string> FieldName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFieldName() => !FieldName.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> NumericValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumericValue() => !NumericValue.Clean;
        public Value<string> StringValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStringValue() => !StringValue.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DateValue.Clean
                    && FieldName.Clean
                    && Id.Clean
                    && NumericValue.Clean
                    && StringValue.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DateValue; v0.Clean = value; DateValue = v0;
                var v1 = FieldName; v1.Clean = value; FieldName = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = NumericValue; v3.Clean = value; NumericValue = v3;
                var v4 = StringValue; v4.Clean = value; StringValue = v4;
                _settingClean = 0;
            }
        }
    }
}