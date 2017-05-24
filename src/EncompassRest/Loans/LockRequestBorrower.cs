using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestBorrower
    {
        public Value<string> EquifaxScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxScore() => !EquifaxScore.Clean;
        public Value<string> ExperianScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianScore() => !ExperianScore.Clean;
        public Value<string> FirstName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstName() => !FirstName.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEmpty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !IsEmpty.Clean;
        public Value<string> LastName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastName() => !LastName.Clean;
        public Value<int?> LrbIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLrbIndex() => !LrbIndex.Clean;
        public Value<string> SSN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSN() => !SSN.Clean;
        public Value<string> TransUnionScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionScore() => !TransUnionScore.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = EquifaxScore.Clean
                    && ExperianScore.Clean
                    && FirstName.Clean
                    && Id.Clean
                    && IsEmpty.Clean
                    && LastName.Clean
                    && LrbIndex.Clean
                    && SSN.Clean
                    && TransUnionScore.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = EquifaxScore; v0.Clean = value; EquifaxScore = v0;
                var v1 = ExperianScore; v1.Clean = value; ExperianScore = v1;
                var v2 = FirstName; v2.Clean = value; FirstName = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = IsEmpty; v4.Clean = value; IsEmpty = v4;
                var v5 = LastName; v5.Clean = value; LastName = v5;
                var v6 = LrbIndex; v6.Clean = value; LrbIndex = v6;
                var v7 = SSN; v7.Clean = value; SSN = v7;
                var v8 = TransUnionScore; v8.Clean = value; TransUnionScore = v8;
                _settingClean = 0;
            }
        }
    }
}