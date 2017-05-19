using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Employment
    {
        public string EmployerName { get; set; }
        public string Attention { get; set; }
        public string AddressStreetLine1 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string Owner { get; set; }
        public bool? CurrentEmploymentIndicator { get; set; }
        public string PositionDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public int? MonthlyIncomeAmount { get; set; }
        public int? TimeOnJobTermYears { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? SelfEmployedIndicator { get; set; }
        public int? TimeInLineOfWorkYears { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? BasePayAmount { get; set; }
        public decimal? OvertimeAmount { get; set; }
        public decimal? BonusAmount { get; set; }
        public decimal? CommissionsAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public decimal? BusinessOwnedPercent { get; set; }
        public string BusinessPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string EmployerComments { get; set; }
        public string BusinessName { get; set; }
        public int? TimeOnJobTermMonths { get; set; }
        public bool? PrintAttachmentIndicator { get; set; }
        public string Title { get; set; }
        public bool? PrintUserNameIndicator { get; set; }
        public string BadgeOrEmployeeID { get; set; }
        public string TitlePhone { get; set; }
        public string TitleFax { get; set; }
        public bool? NoLinkToDocTrackIndicator { get; set; }
        public DateTime? VerificationRequestDate { get; set; }
        public string AltId { get; set; }
        public string Id { get; set; }
        public bool? EntityDeleted { get; set; }
        public int? TimeInLineOfWorkMonths { get; set; }
    }
}