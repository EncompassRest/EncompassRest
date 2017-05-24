using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ShippingContact
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> Address2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress2() => !Address2.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !ContactName.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> ShippingContactType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingContactType() => !ShippingContactType.Clean;
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
                    && Address2.Clean
                    && City.Clean
                    && ContactName.Clean
                    && Email.Clean
                    && Fax.Clean
                    && Id.Clean
                    && Name.Clean
                    && Phone.Clean
                    && PostalCode.Clean
                    && ShippingContactType.Clean
                    && State.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = Address2; v1.Clean = value; Address2 = v1;
                var v2 = City; v2.Clean = value; City = v2;
                var v3 = ContactName; v3.Clean = value; ContactName = v3;
                var v4 = Email; v4.Clean = value; Email = v4;
                var v5 = Fax; v5.Clean = value; Fax = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = Name; v7.Clean = value; Name = v7;
                var v8 = Phone; v8.Clean = value; Phone = v8;
                var v9 = PostalCode; v9.Clean = value; PostalCode = v9;
                var v10 = ShippingContactType; v10.Clean = value; ShippingContactType = v10;
                var v11 = State; v11.Clean = value; State = v11;
                _settingClean = 0;
            }
        }
    }
}