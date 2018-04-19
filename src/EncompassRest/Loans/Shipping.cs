using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Shipping
    /// </summary>
    public sealed partial class Shipping : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actualShipDate;
        /// <summary>
        /// Shipping Actual Shipping Date [2014]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Actual Shipping Date")]
        public DateTime? ActualShipDate { get => _actualShipDate; set => _actualShipDate = value; }
        private DirtyValue<string> _carrierName;
        /// <summary>
        /// Shipping Carrier Name [2017]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Carrier Name")]
        public string CarrierName { get => _carrierName; set => _carrierName = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        /// <summary>
        /// Shipping DownPaymentAmount
        /// </summary>
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Shipping Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _investorDeliveryDate;
        /// <summary>
        /// Shipping Investor Delivery Date [2012]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Investor Delivery Date")]
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => _investorDeliveryDate = value; }
        private DirtyValue<string> _packageTrackingNumber;
        /// <summary>
        /// Shipping Pkg Tracking Number [2018]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Pkg Tracking Number")]
        public string PackageTrackingNumber { get => _packageTrackingNumber; set => _packageTrackingNumber = value; }
        private DirtyValue<string> _physicalFileStorageComments;
        /// <summary>
        /// Shipping File Storage Comments [2022]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping File Storage Comments")]
        public string PhysicalFileStorageComments { get => _physicalFileStorageComments; set => _physicalFileStorageComments = value; }
        private DirtyValue<string> _physicalFileStorageId;
        /// <summary>
        /// Shipping File Storage ID [2021]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping File Storage ID")]
        public string PhysicalFileStorageId { get => _physicalFileStorageId; set => _physicalFileStorageId = value; }
        private DirtyValue<string> _physicalFileStorageLocation;
        /// <summary>
        /// Shipping File Storage Location [2020]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping File Storage Location")]
        public string PhysicalFileStorageLocation { get => _physicalFileStorageLocation; set => _physicalFileStorageLocation = value; }
        private DirtyValue<string> _poolID;
        /// <summary>
        /// Shipping Pool ID [4020]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Pool ID")]
        public string PoolID { get => _poolID; set => _poolID = value; }
        private DirtyValue<string> _poolNumber;
        /// <summary>
        /// Shipping Pool Number [4021]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Pool Number")]
        public string PoolNumber { get => _poolNumber; set => _poolNumber = value; }
        private DirtyValue<string> _recordingNumber;
        /// <summary>
        /// Shipping Recording Number [2015]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Recording Number")]
        public string RecordingNumber { get => _recordingNumber; set => _recordingNumber = value; }
        private DirtyValue<string> _shipmentMethod;
        /// <summary>
        /// Shipping Shipment Method [2016]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Shipment Method")]
        public string ShipmentMethod { get => _shipmentMethod; set => _shipmentMethod = value; }
        private DirtyValue<string> _shipperName;
        /// <summary>
        /// Shipping Shipper Name [2019]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Shipper Name")]
        public string ShipperName { get => _shipperName; set => _shipperName = value; }
        private DirtyList<ShippingContact> _shippingContacts;
        /// <summary>
        /// Shipping ShippingContacts
        /// </summary>
        public IList<ShippingContact> ShippingContacts { get => _shippingContacts ?? (_shippingContacts = new DirtyList<ShippingContact>()); set => _shippingContacts = new DirtyList<ShippingContact>(value); }
        private DirtyValue<DateTime?> _targetDeliveryDate;
        /// <summary>
        /// Shipping Target Delivery Date [2013]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping Target Delivery Date")]
        public DateTime? TargetDeliveryDate { get => _targetDeliveryDate; set => _targetDeliveryDate = value; }
        internal override bool DirtyInternal
        {
            get => _actualShipDate.Dirty
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