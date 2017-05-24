using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<int?> NewYorkPrimaryLenderIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkPrimaryLenderIndex() => !NewYorkPrimaryLenderIndex.Clean;
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
                    && City.Clean
                    && Comments.Clean
                    && Id.Clean
                    && Name.Clean
                    && NewYorkPrimaryLenderIndex.Clean
                    && PostalCode.Clean
                    && State.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = City; v1.Clean = value; City = v1;
                var v2 = Comments; v2.Clean = value; Comments = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = Name; v4.Clean = value; Name = v4;
                var v5 = NewYorkPrimaryLenderIndex; v5.Clean = value; NewYorkPrimaryLenderIndex = v5;
                var v6 = PostalCode; v6.Clean = value; PostalCode = v6;
                var v7 = State; v7.Clean = value; State = v7;
                _settingClean = 0;
            }
        }
    }
}