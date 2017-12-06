#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Shipping : ExtensibleObject
    {
        private DirtyValue<DateTime?> _actualShipDate;
        public DateTime? ActualShipDate { get => _actualShipDate; set => _actualShipDate = value; }
        private DirtyValue<string> _carrierName;
        public string CarrierName { get => _carrierName; set => _carrierName = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _investorDeliveryDate;
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => _investorDeliveryDate = value; }
        private DirtyValue<string> _packageTrackingNumber;
        public string PackageTrackingNumber { get => _packageTrackingNumber; set => _packageTrackingNumber = value; }
        private DirtyValue<string> _physicalFileStorageComments;
        public string PhysicalFileStorageComments { get => _physicalFileStorageComments; set => _physicalFileStorageComments = value; }
        private DirtyValue<string> _physicalFileStorageId;
        public string PhysicalFileStorageId { get => _physicalFileStorageId; set => _physicalFileStorageId = value; }
        private DirtyValue<string> _physicalFileStorageLocation;
        public string PhysicalFileStorageLocation { get => _physicalFileStorageLocation; set => _physicalFileStorageLocation = value; }
        private DirtyValue<string> _poolID;
        public string PoolID { get => _poolID; set => _poolID = value; }
        private DirtyValue<string> _poolNumber;
        public string PoolNumber { get => _poolNumber; set => _poolNumber = value; }
        private DirtyValue<string> _recordingNumber;
        public string RecordingNumber { get => _recordingNumber; set => _recordingNumber = value; }
        private DirtyValue<string> _shipmentMethod;
        public string ShipmentMethod { get => _shipmentMethod; set => _shipmentMethod = value; }
        private DirtyValue<string> _shipperName;
        public string ShipperName { get => _shipperName; set => _shipperName = value; }
        private DirtyList<ShippingContact> _shippingContacts;
        public IList<ShippingContact> ShippingContacts { get => _shippingContacts ?? (_shippingContacts = new DirtyList<ShippingContact>()); set => _shippingContacts = new DirtyList<ShippingContact>(value); }
        private DirtyValue<DateTime?> _targetDeliveryDate;
        public DateTime? TargetDeliveryDate { get => _targetDeliveryDate; set => _targetDeliveryDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _actualShipDate.Dirty
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
            }
            set
            {
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
            }
        }
    }
}