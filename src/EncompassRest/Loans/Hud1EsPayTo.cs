using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsPayTo
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<decimal?> AmountLastPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountLastPay() => !AmountLastPay.Clean;
        public Value<decimal?> AmountNextDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountNextDue() => !AmountNextDue.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !ContactName.Clean;
        public Value<decimal?> CoverageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoverageAmount() => !CoverageAmount.Clean;
        public Value<DateTime?> DatePaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDatePaid() => !DatePaid.Clean;
        public Value<DateTime?> DelinquentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDelinquentDate() => !DelinquentDate.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> FeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeType() => !FeeType.Clean;
        public Value<int?> Hud1EsPayToIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsPayToIndex() => !Hud1EsPayToIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> MaxDeductibleAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxDeductibleAmount() => !MaxDeductibleAmount.Clean;
        public Value<decimal?> MaxDeductiblePercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxDeductiblePercentage() => !MaxDeductiblePercentage.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<DateTime?> NextDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextDueDate() => !NextDueDate.Clean;
        public Value<string> PaymentSchedule { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentSchedule() => !PaymentSchedule.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> PolicyNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePolicyNumber() => !PolicyNumber.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<decimal?> Premium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePremium() => !Premium.Clean;
        public Value<DateTime?> RenewalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRenewalDate() => !RenewalDate.Clean;
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
                    && AmountLastPay.Clean
                    && AmountNextDue.Clean
                    && City.Clean
                    && ContactName.Clean
                    && CoverageAmount.Clean
                    && DatePaid.Clean
                    && DelinquentDate.Clean
                    && Email.Clean
                    && Fax.Clean
                    && FeeType.Clean
                    && Hud1EsPayToIndex.Clean
                    && Id.Clean
                    && MaxDeductibleAmount.Clean
                    && MaxDeductiblePercentage.Clean
                    && Name.Clean
                    && NextDueDate.Clean
                    && PaymentSchedule.Clean
                    && Phone.Clean
                    && PolicyNumber.Clean
                    && PostalCode.Clean
                    && Premium.Clean
                    && RenewalDate.Clean
                    && State.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = AmountLastPay; v1.Clean = value; AmountLastPay = v1;
                var v2 = AmountNextDue; v2.Clean = value; AmountNextDue = v2;
                var v3 = City; v3.Clean = value; City = v3;
                var v4 = ContactName; v4.Clean = value; ContactName = v4;
                var v5 = CoverageAmount; v5.Clean = value; CoverageAmount = v5;
                var v6 = DatePaid; v6.Clean = value; DatePaid = v6;
                var v7 = DelinquentDate; v7.Clean = value; DelinquentDate = v7;
                var v8 = Email; v8.Clean = value; Email = v8;
                var v9 = Fax; v9.Clean = value; Fax = v9;
                var v10 = FeeType; v10.Clean = value; FeeType = v10;
                var v11 = Hud1EsPayToIndex; v11.Clean = value; Hud1EsPayToIndex = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = MaxDeductibleAmount; v13.Clean = value; MaxDeductibleAmount = v13;
                var v14 = MaxDeductiblePercentage; v14.Clean = value; MaxDeductiblePercentage = v14;
                var v15 = Name; v15.Clean = value; Name = v15;
                var v16 = NextDueDate; v16.Clean = value; NextDueDate = v16;
                var v17 = PaymentSchedule; v17.Clean = value; PaymentSchedule = v17;
                var v18 = Phone; v18.Clean = value; Phone = v18;
                var v19 = PolicyNumber; v19.Clean = value; PolicyNumber = v19;
                var v20 = PostalCode; v20.Clean = value; PostalCode = v20;
                var v21 = Premium; v21.Clean = value; Premium = v21;
                var v22 = RenewalDate; v22.Clean = value; RenewalDate = v22;
                var v23 = State; v23.Clean = value; State = v23;
                _settingClean = 0;
            }
        }
    }
}