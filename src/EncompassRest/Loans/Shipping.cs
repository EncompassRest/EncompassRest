using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Shipping : IClean
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
        private Value<List<ShippingContact>> _shippingContacts;
        public List<ShippingContact> ShippingContacts { get { return _shippingContacts; } set { _shippingContacts = value; } }
        private Value<DateTime?> _targetDeliveryDate;
        public DateTime? TargetDeliveryDate { get { return _targetDeliveryDate; } set { _targetDeliveryDate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualShipDate.Clean
                    && _carrierName.Clean
                    && _downPaymentAmount.Clean
                    && _id.Clean
                    && _investorDeliveryDate.Clean
                    && _packageTrackingNumber.Clean
                    && _physicalFileStorageComments.Clean
                    && _physicalFileStorageId.Clean
                    && _physicalFileStorageLocation.Clean
                    && _poolID.Clean
                    && _poolNumber.Clean
                    && _recordingNumber.Clean
                    && _shipmentMethod.Clean
                    && _shipperName.Clean
                    && _shippingContacts.Clean
                    && _targetDeliveryDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var actualShipDate = _actualShipDate; actualShipDate.Clean = value; _actualShipDate = actualShipDate;
                var carrierName = _carrierName; carrierName.Clean = value; _carrierName = carrierName;
                var downPaymentAmount = _downPaymentAmount; downPaymentAmount.Clean = value; _downPaymentAmount = downPaymentAmount;
                var id = _id; id.Clean = value; _id = id;
                var investorDeliveryDate = _investorDeliveryDate; investorDeliveryDate.Clean = value; _investorDeliveryDate = investorDeliveryDate;
                var packageTrackingNumber = _packageTrackingNumber; packageTrackingNumber.Clean = value; _packageTrackingNumber = packageTrackingNumber;
                var physicalFileStorageComments = _physicalFileStorageComments; physicalFileStorageComments.Clean = value; _physicalFileStorageComments = physicalFileStorageComments;
                var physicalFileStorageId = _physicalFileStorageId; physicalFileStorageId.Clean = value; _physicalFileStorageId = physicalFileStorageId;
                var physicalFileStorageLocation = _physicalFileStorageLocation; physicalFileStorageLocation.Clean = value; _physicalFileStorageLocation = physicalFileStorageLocation;
                var poolID = _poolID; poolID.Clean = value; _poolID = poolID;
                var poolNumber = _poolNumber; poolNumber.Clean = value; _poolNumber = poolNumber;
                var recordingNumber = _recordingNumber; recordingNumber.Clean = value; _recordingNumber = recordingNumber;
                var shipmentMethod = _shipmentMethod; shipmentMethod.Clean = value; _shipmentMethod = shipmentMethod;
                var shipperName = _shipperName; shipperName.Clean = value; _shipperName = shipperName;
                var shippingContacts = _shippingContacts; shippingContacts.Clean = value; _shippingContacts = shippingContacts;
                var targetDeliveryDate = _targetDeliveryDate; targetDeliveryDate.Clean = value; _targetDeliveryDate = targetDeliveryDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Shipping()
        {
            Clean = true;
        }
    }
}