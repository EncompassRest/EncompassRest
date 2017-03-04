using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Liability
    {
        public string accountIdentifier { get; set; }
        public decimal? monthlyPaymentAmount { get; set; }
        public string description { get; set; }
        public int? remainingTermMonths { get; set; }
        public string holderName { get; set; }
        public string attention { get; set; }
        public string holderAddressStreetLine1 { get; set; }
        public string holderAddressCity { get; set; }
        public string holderAddressState { get; set; }
        public string holderAddressPostalCode { get; set; }
        public string liabilityType { get; set; }
        public string nameInAccount { get; set; }
        public decimal? unpaidBalanceAmount { get; set; }
        public int? monthsToExclude { get; set; }
        public string owner { get; set; }
        public decimal? toBePaidOffAmount { get; set; }
        public bool? exclusionIndicator { get; set; }
        public bool? payoffStatusIndicator { get; set; }
        public string holderPhone { get; set; }
        public string holderFax { get; set; }
        public string holderEmail { get; set; }
        public string holderComments { get; set; }
        public string reoId { get; set; }
        public bool? subjectLoanResubordinationIndicator { get; set; }
        public bool? printAttachmentIndicator { get; set; }
        public string title { get; set; }
        public bool? printUserNameIndicator { get; set; }
        public string descriptionOfPurpose { get; set; }
        public string titlePhone { get; set; }
        public string titleFax { get; set; }
        public decimal? prepaymentPenaltyAmount { get; set; }
        public int? lates12Month30Day { get; set; }
        public int? lates24Month30Day { get; set; }
        public int? lates25Month30Day { get; set; }
        public int? lates12Month60Day { get; set; }
        public int? lates24Month60Day { get; set; }
        public int? lates25Month60Day { get; set; }
        public int? lates12Month90Day { get; set; }
        public int? lates24Month90Day { get; set; }
        public int? lates25Month90Day { get; set; }
        public int? lates12Month120Day { get; set; }
        public int? lates24Month120Day { get; set; }
        public int? lates25Month120Day { get; set; }
        public int? lates12Month150Day { get; set; }
        public int? lates24Month150Day { get; set; }
        public int? lates25Month150Day { get; set; }
        public bool? isDebtNotSecuredToSubjectPropertyIndicator { get; set; }
        public string uCDPayoffType { get; set; }
        public bool? payoffIncludedIndicator { get; set; }
        public bool? noLinkToDocTrackIndicator { get; set; }
        public DateTime? date { get; set; }
        public string requestId { get; set; }
        public string id { get; set; }
        public bool? entityDeleted { get; set; }
        public int? liabilityIndex { get; set; }
        public int? volIndex { get; set; }
        public bool? accountIndicator { get; set; }

    }
}
