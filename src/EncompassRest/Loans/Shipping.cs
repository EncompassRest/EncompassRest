using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Shipping
    {
        public Value<DateTime?> ActualShipDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualShipDate() => !ActualShipDate.Clean;
        public Value<string> CarrierName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCarrierName() => !CarrierName.Clean;
        public Value<decimal?> DownPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentAmount() => !DownPaymentAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> InvestorDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorDeliveryDate() => !InvestorDeliveryDate.Clean;
        public Value<string> PackageTrackingNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePackageTrackingNumber() => !PackageTrackingNumber.Clean;
        public Value<string> PhysicalFileStorageComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhysicalFileStorageComments() => !PhysicalFileStorageComments.Clean;
        public Value<string> PhysicalFileStorageId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhysicalFileStorageId() => !PhysicalFileStorageId.Clean;
        public Value<string> PhysicalFileStorageLocation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhysicalFileStorageLocation() => !PhysicalFileStorageLocation.Clean;
        public Value<string> PoolID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolID() => !PoolID.Clean;
        public Value<string> PoolNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolNumber() => !PoolNumber.Clean;
        public Value<string> RecordingNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordingNumber() => !RecordingNumber.Clean;
        public Value<string> ShipmentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShipmentMethod() => !ShipmentMethod.Clean;
        public Value<string> ShipperName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShipperName() => !ShipperName.Clean;
        public Value<List<ShippingContact>> ShippingContacts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingContacts() => !ShippingContacts.Clean;
        public Value<DateTime?> TargetDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTargetDeliveryDate() => !TargetDeliveryDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualShipDate.Clean
                    && CarrierName.Clean
                    && DownPaymentAmount.Clean
                    && Id.Clean
                    && InvestorDeliveryDate.Clean
                    && PackageTrackingNumber.Clean
                    && PhysicalFileStorageComments.Clean
                    && PhysicalFileStorageId.Clean
                    && PhysicalFileStorageLocation.Clean
                    && PoolID.Clean
                    && PoolNumber.Clean
                    && RecordingNumber.Clean
                    && ShipmentMethod.Clean
                    && ShipperName.Clean
                    && ShippingContacts.Clean
                    && TargetDeliveryDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualShipDate; v0.Clean = value; ActualShipDate = v0;
                var v1 = CarrierName; v1.Clean = value; CarrierName = v1;
                var v2 = DownPaymentAmount; v2.Clean = value; DownPaymentAmount = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = InvestorDeliveryDate; v4.Clean = value; InvestorDeliveryDate = v4;
                var v5 = PackageTrackingNumber; v5.Clean = value; PackageTrackingNumber = v5;
                var v6 = PhysicalFileStorageComments; v6.Clean = value; PhysicalFileStorageComments = v6;
                var v7 = PhysicalFileStorageId; v7.Clean = value; PhysicalFileStorageId = v7;
                var v8 = PhysicalFileStorageLocation; v8.Clean = value; PhysicalFileStorageLocation = v8;
                var v9 = PoolID; v9.Clean = value; PoolID = v9;
                var v10 = PoolNumber; v10.Clean = value; PoolNumber = v10;
                var v11 = RecordingNumber; v11.Clean = value; RecordingNumber = v11;
                var v12 = ShipmentMethod; v12.Clean = value; ShipmentMethod = v12;
                var v13 = ShipperName; v13.Clean = value; ShipperName = v13;
                var v14 = ShippingContacts; v14.Clean = value; ShippingContacts = v14;
                var v15 = TargetDeliveryDate; v15.Clean = value; TargetDeliveryDate = v15;
                _settingClean = 0;
            }
        }
    }
}