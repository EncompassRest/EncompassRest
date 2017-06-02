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
                var v0 = _actualShipDate; v0.Clean = value; _actualShipDate = v0;
                var v1 = _carrierName; v1.Clean = value; _carrierName = v1;
                var v2 = _downPaymentAmount; v2.Clean = value; _downPaymentAmount = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _investorDeliveryDate; v4.Clean = value; _investorDeliveryDate = v4;
                var v5 = _packageTrackingNumber; v5.Clean = value; _packageTrackingNumber = v5;
                var v6 = _physicalFileStorageComments; v6.Clean = value; _physicalFileStorageComments = v6;
                var v7 = _physicalFileStorageId; v7.Clean = value; _physicalFileStorageId = v7;
                var v8 = _physicalFileStorageLocation; v8.Clean = value; _physicalFileStorageLocation = v8;
                var v9 = _poolID; v9.Clean = value; _poolID = v9;
                var v10 = _poolNumber; v10.Clean = value; _poolNumber = v10;
                var v11 = _recordingNumber; v11.Clean = value; _recordingNumber = v11;
                var v12 = _shipmentMethod; v12.Clean = value; _shipmentMethod = v12;
                var v13 = _shipperName; v13.Clean = value; _shipperName = v13;
                var v14 = _shippingContacts; v14.Clean = value; _shippingContacts = v14;
                var v15 = _targetDeliveryDate; v15.Clean = value; _targetDeliveryDate = v15;
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