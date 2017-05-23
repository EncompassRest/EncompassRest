using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Shipping
    {
        public JsonNullable<DateTime?> ActualShipDate { get; set; }
        public string CarrierName { get; set; }
        public JsonNullable<decimal?> DownPaymentAmount { get; set; }
        public string Id { get; set; }
        public JsonNullable<DateTime?> InvestorDeliveryDate { get; set; }
        public string PackageTrackingNumber { get; set; }
        public string PhysicalFileStorageComments { get; set; }
        public string PhysicalFileStorageId { get; set; }
        public string PhysicalFileStorageLocation { get; set; }
        public string PoolID { get; set; }
        public string PoolNumber { get; set; }
        public string RecordingNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string ShipperName { get; set; }
        public JsonNullable<List<ShippingContact>> ShippingContacts { get; set; }
        public JsonNullable<DateTime?> TargetDeliveryDate { get; set; }
    }
}