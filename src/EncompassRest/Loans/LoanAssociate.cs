using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate
    {
        public Value<string> CellPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCellPhone() => !CellPhone.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IdString { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIdString() => !IdString.Clean;
        public Value<string> LoanAssociateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAssociateType() => !LoanAssociateType.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<int?> RoleId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleId() => !RoleId.Clean;
        public Value<string> RoleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleName() => !RoleName.Clean;
        public Value<string> WriteAccess { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWriteAccess() => !WriteAccess.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CellPhone.Clean
                    && Email.Clean
                    && Fax.Clean
                    && Id.Clean
                    && IdString.Clean
                    && LoanAssociateType.Clean
                    && Name.Clean
                    && Phone.Clean
                    && RoleId.Clean
                    && RoleName.Clean
                    && WriteAccess.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CellPhone; v0.Clean = value; CellPhone = v0;
                var v1 = Email; v1.Clean = value; Email = v1;
                var v2 = Fax; v2.Clean = value; Fax = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = IdString; v4.Clean = value; IdString = v4;
                var v5 = LoanAssociateType; v5.Clean = value; LoanAssociateType = v5;
                var v6 = Name; v6.Clean = value; Name = v6;
                var v7 = Phone; v7.Clean = value; Phone = v7;
                var v8 = RoleId; v8.Clean = value; RoleId = v8;
                var v9 = RoleName; v9.Clean = value; RoleName = v9;
                var v10 = WriteAccess; v10.Clean = value; WriteAccess = v10;
                _settingClean = 0;
            }
        }
    }
}