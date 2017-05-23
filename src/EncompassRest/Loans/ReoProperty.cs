using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ReoProperty
    {
        public JsonNullable<DateTime?> AcquiredDate { get; set; }
        public string City { get; set; }
        public string DispositionStatusType { get; set; }
        public JsonNullable<bool?> EntityDeleted { get; set; }
        public string GsePropertyType { get; set; }
        public string Id { get; set; }
        public bool? IsEmpty { get; set; }
        public JsonNullable<decimal?> LienInstallmentAmount { get; set; }
        public JsonNullable<decimal?> LienUpbAmount { get; set; }
        public string MaintenanceExpenseAmount { get; set; }
        public JsonNullable<decimal?> MarketValueAmount { get; set; }
        public JsonNullable<bool?> NoLinkToDocTrackIndicator { get; set; }
        public JsonNullable<decimal?> ParticipationPercentage { get; set; }
        public JsonNullable<decimal?> PercentageofRental { get; set; }
        public string PostalCode { get; set; }
        public JsonNullable<bool?> PrintAttachIndicator { get; set; }
        public JsonNullable<bool?> PrintUserNameIndicator { get; set; }
        public string PropertyUsageType { get; set; }
        public JsonNullable<int?> PurchasePrice { get; set; }
        public JsonNullable<decimal?> RentalIncomeGrossAmount { get; set; }
        public JsonNullable<decimal?> RentalIncomeNetAmount { get; set; }
        public string ReoComments { get; set; }
        public string ReoId { get; set; }
        public int? ReoPropertyIndex { get; set; }
        public JsonNullable<DateTime?> RequestDate { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public JsonNullable<bool?> SubjectIndicator { get; set; }
        public string Title { get; set; }
        public string TitleFax { get; set; }
        public string TitlePhone { get; set; }
    }
}