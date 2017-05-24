using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LogComment
    {
        public Value<string> AddedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !AddedBy.Clean;
        public Value<string> AddedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedByName() => !AddedByName.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<int?> ForRoleId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForRoleId() => !ForRoleId.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsInternal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsInternal() => !IsInternal.Clean;
        public Value<string> ReviewedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedBy() => !ReviewedBy.Clean;
        public Value<DateTime?> ReviewedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedDate() => !ReviewedDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AddedBy.Clean
                    && AddedByName.Clean
                    && Comments.Clean
                    && Date.Clean
                    && ForRoleId.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsInternal.Clean
                    && ReviewedBy.Clean
                    && ReviewedDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddedBy; v0.Clean = value; AddedBy = v0;
                var v1 = AddedByName; v1.Clean = value; AddedByName = v1;
                var v2 = Comments; v2.Clean = value; Comments = v2;
                var v3 = Date; v3.Clean = value; Date = v3;
                var v4 = ForRoleId; v4.Clean = value; ForRoleId = v4;
                var v5 = Guid; v5.Clean = value; Guid = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = IsInternal; v7.Clean = value; IsInternal = v7;
                var v8 = ReviewedBy; v8.Clean = value; ReviewedBy = v8;
                var v9 = ReviewedDate; v9.Clean = value; ReviewedDate = v9;
                _settingClean = 0;
            }
        }
    }
}