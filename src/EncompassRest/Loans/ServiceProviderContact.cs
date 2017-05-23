using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public JsonNullable<decimal?> Cost { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public JsonNullable<decimal?> FeeAmt1 { get; set; }
        public JsonNullable<decimal?> FeeAmt10 { get; set; }
        public JsonNullable<decimal?> FeeAmt2 { get; set; }
        public JsonNullable<decimal?> FeeAmt3 { get; set; }
        public JsonNullable<decimal?> FeeAmt4 { get; set; }
        public JsonNullable<decimal?> FeeAmt5 { get; set; }
        public JsonNullable<decimal?> FeeAmt6 { get; set; }
        public JsonNullable<decimal?> FeeAmt7 { get; set; }
        public JsonNullable<decimal?> FeeAmt8 { get; set; }
        public JsonNullable<decimal?> FeeAmt9 { get; set; }
        public string FeeDesc1 { get; set; }
        public string FeeDesc10 { get; set; }
        public string FeeDesc2 { get; set; }
        public string FeeDesc3 { get; set; }
        public string FeeDesc4 { get; set; }
        public string FeeDesc5 { get; set; }
        public string FeeDesc6 { get; set; }
        public string FeeDesc7 { get; set; }
        public string FeeDesc8 { get; set; }
        public string FeeDesc9 { get; set; }
        public string Id { get; set; }
        public string LineItemNumber { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public int? ProviderIndex { get; set; }
        public string ProviderName { get; set; }
        public string Relationship { get; set; }
        public string ServiceProvided { get; set; }
        public string ServiceProviderId { get; set; }
        public string ServiceType { get; set; }
        public JsonNullable<bool?> ShopFor { get; set; }
        public string State { get; set; }
        public string WebUrl { get; set; }
    }
}