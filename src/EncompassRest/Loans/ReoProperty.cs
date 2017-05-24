using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ReoProperty
    {
        public Value<DateTime?> AcquiredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcquiredDate() => !AcquiredDate.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> DispositionStatusType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDispositionStatusType() => !DispositionStatusType.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<string> GsePropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGsePropertyType() => !GsePropertyType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEmpty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !IsEmpty.Clean;
        public Value<decimal?> LienInstallmentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienInstallmentAmount() => !LienInstallmentAmount.Clean;
        public Value<decimal?> LienUpbAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienUpbAmount() => !LienUpbAmount.Clean;
        public Value<string> MaintenanceExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaintenanceExpenseAmount() => !MaintenanceExpenseAmount.Clean;
        public Value<decimal?> MarketValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarketValueAmount() => !MarketValueAmount.Clean;
        public Value<bool?> NoLinkToDocTrackIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !NoLinkToDocTrackIndicator.Clean;
        public Value<decimal?> ParticipationPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParticipationPercentage() => !ParticipationPercentage.Clean;
        public Value<decimal?> PercentageofRental { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentageofRental() => !PercentageofRental.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<bool?> PrintAttachIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachIndicator() => !PrintAttachIndicator.Clean;
        public Value<bool?> PrintUserNameIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !PrintUserNameIndicator.Clean;
        public Value<string> PropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !PropertyUsageType.Clean;
        public Value<int?> PurchasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePrice() => !PurchasePrice.Clean;
        public Value<decimal?> RentalIncomeGrossAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentalIncomeGrossAmount() => !RentalIncomeGrossAmount.Clean;
        public Value<decimal?> RentalIncomeNetAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentalIncomeNetAmount() => !RentalIncomeNetAmount.Clean;
        public Value<string> ReoComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoComments() => !ReoComments.Clean;
        public Value<string> ReoId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoId() => !ReoId.Clean;
        public Value<int?> ReoPropertyIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoPropertyIndex() => !ReoPropertyIndex.Clean;
        public Value<DateTime?> RequestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestDate() => !RequestDate.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> StreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress() => !StreetAddress.Clean;
        public Value<bool?> SubjectIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectIndicator() => !SubjectIndicator.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !TitleFax.Clean;
        public Value<string> TitlePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !TitlePhone.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AcquiredDate.Clean
                    && City.Clean
                    && DispositionStatusType.Clean
                    && EntityDeleted.Clean
                    && GsePropertyType.Clean
                    && Id.Clean
                    && IsEmpty.Clean
                    && LienInstallmentAmount.Clean
                    && LienUpbAmount.Clean
                    && MaintenanceExpenseAmount.Clean
                    && MarketValueAmount.Clean
                    && NoLinkToDocTrackIndicator.Clean
                    && ParticipationPercentage.Clean
                    && PercentageofRental.Clean
                    && PostalCode.Clean
                    && PrintAttachIndicator.Clean
                    && PrintUserNameIndicator.Clean
                    && PropertyUsageType.Clean
                    && PurchasePrice.Clean
                    && RentalIncomeGrossAmount.Clean
                    && RentalIncomeNetAmount.Clean
                    && ReoComments.Clean
                    && ReoId.Clean
                    && ReoPropertyIndex.Clean
                    && RequestDate.Clean
                    && State.Clean
                    && StreetAddress.Clean
                    && SubjectIndicator.Clean
                    && Title.Clean
                    && TitleFax.Clean
                    && TitlePhone.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AcquiredDate; v0.Clean = value; AcquiredDate = v0;
                var v1 = City; v1.Clean = value; City = v1;
                var v2 = DispositionStatusType; v2.Clean = value; DispositionStatusType = v2;
                var v3 = EntityDeleted; v3.Clean = value; EntityDeleted = v3;
                var v4 = GsePropertyType; v4.Clean = value; GsePropertyType = v4;
                var v5 = Id; v5.Clean = value; Id = v5;
                var v6 = IsEmpty; v6.Clean = value; IsEmpty = v6;
                var v7 = LienInstallmentAmount; v7.Clean = value; LienInstallmentAmount = v7;
                var v8 = LienUpbAmount; v8.Clean = value; LienUpbAmount = v8;
                var v9 = MaintenanceExpenseAmount; v9.Clean = value; MaintenanceExpenseAmount = v9;
                var v10 = MarketValueAmount; v10.Clean = value; MarketValueAmount = v10;
                var v11 = NoLinkToDocTrackIndicator; v11.Clean = value; NoLinkToDocTrackIndicator = v11;
                var v12 = ParticipationPercentage; v12.Clean = value; ParticipationPercentage = v12;
                var v13 = PercentageofRental; v13.Clean = value; PercentageofRental = v13;
                var v14 = PostalCode; v14.Clean = value; PostalCode = v14;
                var v15 = PrintAttachIndicator; v15.Clean = value; PrintAttachIndicator = v15;
                var v16 = PrintUserNameIndicator; v16.Clean = value; PrintUserNameIndicator = v16;
                var v17 = PropertyUsageType; v17.Clean = value; PropertyUsageType = v17;
                var v18 = PurchasePrice; v18.Clean = value; PurchasePrice = v18;
                var v19 = RentalIncomeGrossAmount; v19.Clean = value; RentalIncomeGrossAmount = v19;
                var v20 = RentalIncomeNetAmount; v20.Clean = value; RentalIncomeNetAmount = v20;
                var v21 = ReoComments; v21.Clean = value; ReoComments = v21;
                var v22 = ReoId; v22.Clean = value; ReoId = v22;
                var v23 = ReoPropertyIndex; v23.Clean = value; ReoPropertyIndex = v23;
                var v24 = RequestDate; v24.Clean = value; RequestDate = v24;
                var v25 = State; v25.Clean = value; State = v25;
                var v26 = StreetAddress; v26.Clean = value; StreetAddress = v26;
                var v27 = SubjectIndicator; v27.Clean = value; SubjectIndicator = v27;
                var v28 = Title; v28.Clean = value; Title = v28;
                var v29 = TitleFax; v29.Clean = value; TitleFax = v29;
                var v30 = TitlePhone; v30.Clean = value; TitlePhone = v30;
                _settingClean = 0;
            }
        }
    }
}