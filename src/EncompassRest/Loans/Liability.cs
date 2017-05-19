using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Liability
    {
        public string AccountIdentifier { get; set; }
        public decimal? MonthlyPaymentAmount { get; set; }
        public string Description { get; set; }
        public int? RemainingTermMonths { get; set; }
        public string HolderName { get; set; }
        public string Attention { get; set; }
        public string HolderAddressStreetLine1 { get; set; }
        public string HolderAddressCity { get; set; }
        public string HolderAddressState { get; set; }
        public string HolderAddressPostalCode { get; set; }
        public string LiabilityType { get; set; }
        public string NameInAccount { get; set; }
        public decimal? UnpaidBalanceAmount { get; set; }
        public int? MonthsToExclude { get; set; }
        public string Owner { get; set; }
        public decimal? ToBePaidOffAmount { get; set; }
        public bool? ExclusionIndicator { get; set; }
        public bool? PayoffStatusIndicator { get; set; }
        public string HolderPhone { get; set; }
        public string HolderFax { get; set; }
        public string HolderEmail { get; set; }
        public string HolderComments { get; set; }
        public string ReoId { get; set; }
        public bool? SubjectLoanResubordinationIndicator { get; set; }
        public bool? PrintAttachmentIndicator { get; set; }
        public string Title { get; set; }
        public bool? PrintUserNameIndicator { get; set; }
        public string DescriptionOfPurpose { get; set; }
        public string TitlePhone { get; set; }
        public string TitleFax { get; set; }
        public decimal? PrepaymentPenaltyAmount { get; set; }
        public int? Lates12Month30Day { get; set; }
        public int? Lates24Month30Day { get; set; }
        public int? Lates25Month30Day { get; set; }
        public int? Lates12Month60Day { get; set; }
        public int? Lates24Month60Day { get; set; }
        public int? Lates25Month60Day { get; set; }
        public int? Lates12Month90Day { get; set; }
        public int? Lates24Month90Day { get; set; }
        public int? Lates25Month90Day { get; set; }
        public int? Lates12Month120Day { get; set; }
        public int? Lates24Month120Day { get; set; }
        public int? Lates25Month120Day { get; set; }
        public int? Lates12Month150Day { get; set; }
        public int? Lates24Month150Day { get; set; }
        public int? Lates25Month150Day { get; set; }
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get; set; }
        public string UCDPayoffType { get; set; }
        public bool? PayoffIncludedIndicator { get; set; }
        public bool? NoLinkToDocTrackIndicator { get; set; }
        public DateTime? Date { get; set; }
        public string RequestId { get; set; }
        public string Id { get; set; }
        public bool? EntityDeleted { get; set; }
        public int? LiabilityIndex { get; set; }
        public int? VolIndex { get; set; }
        public bool? AccountIndicator { get; set; }
    }
}