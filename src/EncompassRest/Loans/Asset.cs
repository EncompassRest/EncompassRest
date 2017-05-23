using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Asset
    {
        public string AccountIdentifier { get; set; }
        public string AltId { get; set; }
        public int? AssetIndex { get; set; }
        public string AssetType { get; set; }
        public string Attention { get; set; }
        public string BorrowerId { get; set; }
        public JsonNullable<decimal?> CashOrMarketValueAmount { get; set; }
        public string DepositoryAccountName { get; set; }
        public JsonNullable<DateTime?> DepositoryRequestDate { get; set; }
        public string Description { get; set; }
        public JsonNullable<bool?> EntityDeleted { get; set; }
        public string HolderAddressCity { get; set; }
        public string HolderAddressPostalCode { get; set; }
        public string HolderAddressState { get; set; }
        public string HolderAddressStreetLine1 { get; set; }
        public string HolderComments { get; set; }
        public string HolderEmail { get; set; }
        public string HolderFax { get; set; }
        public string HolderName { get; set; }
        public string HolderPhone { get; set; }
        public string Id { get; set; }
        public bool? IsEmpty { get; set; }
        public bool? IsVod { get; set; }
        public JsonNullable<decimal?> LifeInsuranceFaceValueAmount { get; set; }
        public string NameInAccount { get; set; }
        public JsonNullable<bool?> NoLinkToDocTrackIndicator { get; set; }
        public string Owner { get; set; }
        public JsonNullable<bool?> PrintAttachmentIndicator { get; set; }
        public JsonNullable<bool?> PrintUserNameIndicator { get; set; }
        public string Title { get; set; }
        public string TitleFax { get; set; }
        public string TitlePhone { get; set; }
        public JsonNullable<decimal?> Total { get; set; }
        public int? VodIndex { get; set; }
    }
}