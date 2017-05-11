using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ReoProperty
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public decimal? ParticipationPercentage { get; set; }
        public decimal? LienInstallmentAmount { get; set; }
        public decimal? LienUpbAmount { get; set; }
        public string GsePropertyType { get; set; }
        public decimal? MarketValueAmount { get; set; }
        public decimal? RentalIncomeGrossAmount { get; set; }
        public string MaintenanceExpenseAmount { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public int? PurchasePrice { get; set; }
        public string DispositionStatusType { get; set; }
        public string ReoComments { get; set; }
        public decimal? PercentageofRental { get; set; }
        public bool? SubjectIndicator { get; set; }
        public decimal? RentalIncomeNetAmount { get; set; }
        public bool? PrintAttachIndicator { get; set; }
        public string Title { get; set; }
        public bool? PrintUserNameIndicator { get; set; }
        public string PropertyUsageType { get; set; }
        public string ReoId { get; set; }
        public string TitlePhone { get; set; }
        public string TitleFax { get; set; }
        public bool? NoLinkToDocTrackIndicator { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Id { get; set; }
        public bool? EntityDeleted { get; set; }
        public bool? IsEmpty { get; set; }
        public int? ReoPropertyIndex { get; set; }
    }
}