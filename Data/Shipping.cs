using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Shipping
    {
        public DateTime? investorDeliveryDate { get; set; }
        public DateTime? targetDeliveryDate { get; set; }
        public DateTime? actualShipDate { get; set; }
        public string recordingNumber { get; set; }
        public string shipmentMethod { get; set; }
        public string carrierName { get; set; }
        public string packageTrackingNumber { get; set; }
        public string shipperName { get; set; }
        public string physicalFileStorageLocation { get; set; }
        public string physicalFileStorageId { get; set; }
        public string physicalFileStorageComments { get; set; }
        public List<ShippingContact> shippingContacts { get; set; }
        public string poolID { get; set; }
        public string poolNumber { get; set; }
        public string id { get; set; }
        public decimal? downPaymentAmount { get; set; }

    }
}
