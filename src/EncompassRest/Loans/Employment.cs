using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Employment
    {
        public string AddressCity { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressState { get; set; }
        public string AddressStreetLine1 { get; set; }
        public string AltId { get; set; }
        public string Attention { get; set; }
        public string BadgeOrEmployeeID { get; set; }
        public JsonNullable<decimal?> BasePayAmount { get; set; }
        public JsonNullable<decimal?> BonusAmount { get; set; }
        public string BusinessName { get; set; }
        public JsonNullable<decimal?> BusinessOwnedPercent { get; set; }
        public string BusinessPhone { get; set; }
        public JsonNullable<decimal?> CommissionsAmount { get; set; }
        public JsonNullable<bool?> CurrentEmploymentIndicator { get; set; }
        public string Email { get; set; }
        public string EmployerComments { get; set; }
        public string EmployerName { get; set; }
        public JsonNullable<DateTime?> EndDate { get; set; }
        public JsonNullable<bool?> EntityDeleted { get; set; }
        public string Fax { get; set; }
        public string Id { get; set; }
        public JsonNullable<int?> MonthlyIncomeAmount { get; set; }
        public JsonNullable<bool?> NoLinkToDocTrackIndicator { get; set; }
        public JsonNullable<decimal?> OtherAmount { get; set; }
        public JsonNullable<decimal?> OvertimeAmount { get; set; }
        public string Owner { get; set; }
        public string PhoneNumber { get; set; }
        public string PositionDescription { get; set; }
        public JsonNullable<bool?> PrintAttachmentIndicator { get; set; }
        public JsonNullable<bool?> PrintUserNameIndicator { get; set; }
        public JsonNullable<bool?> SelfEmployedIndicator { get; set; }
        public JsonNullable<DateTime?> StartDate { get; set; }
        public JsonNullable<int?> TimeInLineOfWorkMonths { get; set; }
        public JsonNullable<int?> TimeInLineOfWorkYears { get; set; }
        public JsonNullable<int?> TimeOnJobTermMonths { get; set; }
        public JsonNullable<int?> TimeOnJobTermYears { get; set; }
        public string Title { get; set; }
        public string TitleFax { get; set; }
        public string TitlePhone { get; set; }
        public JsonNullable<DateTime?> VerificationRequestDate { get; set; }
    }
}