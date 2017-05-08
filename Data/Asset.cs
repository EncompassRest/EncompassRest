using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Asset
    {
        public string accountIdentifier { get; set; }
        public decimal? cashOrMarketValueAmount { get; set; }
        public string description { get; set; }
        public decimal? lifeInsuranceFaceValueAmount { get; set; }
        public string holderName { get; set; }
        public string attention { get; set; }
        public string holderAddressStreetLine1 { get; set; }
        public string holderAddressCity { get; set; }
        public string holderAddressState { get; set; }
        public string holderAddressPostalCode { get; set; }
        public string assetType { get; set; }
        public string depositoryAccountName { get; set; }
        public string owner { get; set; }
        public string holderPhone { get; set; }
        public string holderFax { get; set; }
        public string holderEmail { get; set; }
        public string holderComments { get; set; }
        public decimal? total { get; set; }
        public string altId { get; set; }
        public bool? printAttachmentIndicator { get; set; }
        public string title { get; set; }
        public bool? printUserNameIndicator { get; set; }
        public string titlePhone { get; set; }
        public string titleFax { get; set; }
        public bool? noLinkToDocTrackIndicator { get; set; }
        public DateTime? depositoryRequestDate { get; set; }
        public string id { get; set; }
        public bool? entityDeleted { get; set; }
        public int? assetIndex { get; set; }
        public string borrowerId { get; set; }
        public bool? isEmpty { get; set; }
        public bool? isVod { get; set; }
        public string nameInAccount { get; set; }
        public int? vodIndex { get; set; }

    }
}
