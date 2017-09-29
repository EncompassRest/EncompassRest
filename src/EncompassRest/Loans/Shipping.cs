using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Shipping : IDirty
    {
        private Value<DateTime?> _actualShipDate;
        public DateTime? ActualShipDate { get { return _actualShipDate; } set { _actualShipDate = value; } }
        private Value<string> _carrierName;
        public string CarrierName { get { return _carrierName; } set { _carrierName = value; } }
        private Value<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get { return _downPaymentAmount; } set { _downPaymentAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _investorDeliveryDate;
        public DateTime? InvestorDeliveryDate { get { return _investorDeliveryDate; } set { _investorDeliveryDate = value; } }
        private Value<string> _packageTrackingNumber;
        public string PackageTrackingNumber { get { return _packageTrackingNumber; } set { _packageTrackingNumber = value; } }
        private Value<string> _physicalFileStorageComments;
        public string PhysicalFileStorageComments { get { return _physicalFileStorageComments; } set { _physicalFileStorageComments = value; } }
        private Value<string> _physicalFileStorageId;
        public string PhysicalFileStorageId { get { return _physicalFileStorageId; } set { _physicalFileStorageId = value; } }
        private Value<string> _physicalFileStorageLocation;
        public string PhysicalFileStorageLocation { get { return _physicalFileStorageLocation; } set { _physicalFileStorageLocation = value; } }
        private Value<string> _poolID;
        public string PoolID { get { return _poolID; } set { _poolID = value; } }
        private Value<string> _poolNumber;
        public string PoolNumber { get { return _poolNumber; } set { _poolNumber = value; } }
        private Value<string> _recordingNumber;
        public string RecordingNumber { get { return _recordingNumber; } set { _recordingNumber = value; } }
        private Value<string> _shipmentMethod;
        public string ShipmentMethod { get { return _shipmentMethod; } set { _shipmentMethod = value; } }
        private Value<string> _shipperName;
        public string ShipperName { get { return _shipperName; } set { _shipperName = value; } }
        private DirtyList<ShippingContact> _shippingContacts;
        public IList<ShippingContact> ShippingContacts { get { var v = _shippingContacts; return v ?? Interlocked.CompareExchange(ref _shippingContacts, (v = new DirtyList<ShippingContact>()), null) ?? v; } set { _shippingContacts = new DirtyList<ShippingContact>(value); } }
        private Value<DateTime?> _targetDeliveryDate;
        public DateTime? TargetDeliveryDate { get { return _targetDeliveryDate; } set { _targetDeliveryDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _actualShipDate.Dirty
                    || _carrierName.Dirty
                    || _downPaymentAmount.Dirty
                    || _id.Dirty
                    || _investorDeliveryDate.Dirty
                    || _packageTrackingNumber.Dirty
                    || _physicalFileStorageComments.Dirty
                    || _physicalFileStorageId.Dirty
                    || _physicalFileStorageLocation.Dirty
                    || _poolID.Dirty
                    || _poolNumber.Dirty
                    || _recordingNumber.Dirty
                    || _shipmentMethod.Dirty
                    || _shipperName.Dirty
                    || _targetDeliveryDate.Dirty
                    || _shippingContacts?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _actualShipDate.Dirty = value;
                _carrierName.Dirty = value;
                _downPaymentAmount.Dirty = value;
                _id.Dirty = value;
                _investorDeliveryDate.Dirty = value;
                _packageTrackingNumber.Dirty = value;
                _physicalFileStorageComments.Dirty = value;
                _physicalFileStorageId.Dirty = value;
                _physicalFileStorageLocation.Dirty = value;
                _poolID.Dirty = value;
                _poolNumber.Dirty = value;
                _recordingNumber.Dirty = value;
                _shipmentMethod.Dirty = value;
                _shipperName.Dirty = value;
                _targetDeliveryDate.Dirty = value;
                if (_shippingContacts != null) _shippingContacts.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}