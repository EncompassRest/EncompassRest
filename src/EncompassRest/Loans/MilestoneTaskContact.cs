using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskContact
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ContactId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactId() => !ContactId.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> Role { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRole() => !Role.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> Zip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeZip() => !Zip.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Address.Clean
                    && City.Clean
                    && ContactId.Clean
                    && Email.Clean
                    && Guid.Clean
                    && Id.Clean
                    && Name.Clean
                    && Phone.Clean
                    && Role.Clean
                    && State.Clean
                    && Zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = City; v1.Clean = value; City = v1;
                var v2 = ContactId; v2.Clean = value; ContactId = v2;
                var v3 = Email; v3.Clean = value; Email = v3;
                var v4 = Guid; v4.Clean = value; Guid = v4;
                var v5 = Id; v5.Clean = value; Id = v5;
                var v6 = Name; v6.Clean = value; Name = v6;
                var v7 = Phone; v7.Clean = value; Phone = v7;
                var v8 = Role; v8.Clean = value; Role = v8;
                var v9 = State; v9.Clean = value; State = v9;
                var v10 = Zip; v10.Clean = value; Zip = v10;
                _settingClean = 0;
            }
        }
    }
}