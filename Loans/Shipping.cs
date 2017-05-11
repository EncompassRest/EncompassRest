using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Shipping
    {
        public DateTime? InvestorDeliveryDate { get; set; }
        public DateTime? TargetDeliveryDate { get; set; }
        public DateTime? ActualShipDate { get; set; }
        public string RecordingNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string CarrierName { get; set; }
        public string PackageTrackingNumber { get; set; }
        public string ShipperName { get; set; }
        public string PhysicalFileStorageLocation { get; set; }
        public string PhysicalFileStorageId { get; set; }
        public string PhysicalFileStorageComments { get; set; }
        public List<ShippingContact> ShippingContacts { get; set; }
        public string PoolID { get; set; }
        public string PoolNumber { get; set; }
        public string Id { get; set; }
        public decimal? DownPaymentAmount { get; set; }
    }
}