using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement
    {
        public int? AffiliatedBusinessArrangementIndex { get; set; }
        public string AffiliateName { get; set; }
        public string ChargeRangeChargesDescription1 { get; set; }
        public string ChargeRangeChargesDescription2 { get; set; }
        public string ChargeRangeChargesDescription3 { get; set; }
        public string ChargeRangeChargesDescription4 { get; set; }
        public string ChargeRangeChargesDescription5 { get; set; }
        public string ChargeRangeChargesDescription6 { get; set; }
        public string Id { get; set; }
        public string LenderAddress { get; set; }
        public string LenderAddressCity { get; set; }
        public string LenderAddressState { get; set; }
        public string LenderAddressZipcode { get; set; }
        public string LenderName { get; set; }
        public string NatureOfRelationship { get; set; }
        public JsonNullable<decimal?> PercentOwnershipInterest { get; set; }
        public JsonNullable<bool?> PurchaseSaleRefinanceIndicator { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator1 { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator2 { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator3 { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator4 { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator5 { get; set; }
        public JsonNullable<bool?> RequiredUseIndicator6 { get; set; }
        public string ServiceDescription1 { get; set; }
        public string ServiceDescription2 { get; set; }
        public string ServiceDescription3 { get; set; }
        public string ServiceDescription4 { get; set; }
        public string ServiceDescription5 { get; set; }
        public string ServiceDescription6 { get; set; }
        public JsonNullable<bool?> SettlementIndicator { get; set; }
    }
}