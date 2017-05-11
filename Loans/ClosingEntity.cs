using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ClosingEntity
    {
        public string ClosingEntityType { get; set; }
        public string UnparsedName { get; set; }
        public string OrganizedUnderTheLawsOfJurisdictionName { get; set; }
        public string OrganizationType { get; set; }
        public string TaxIdentificationNumberIdentifier { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string Phone { get; set; }
        public DateTime? RecordableDocumentTrustDate { get; set; }
        public string Comments { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string RecordCity { get; set; }
        public string Assignee { get; set; }
        public string TrustOfficerName1 { get; set; }
        public string TrustOfficerTitle1 { get; set; }
        public string TrustOfficerName2 { get; set; }
        public string TrustOfficerTitle2 { get; set; }
        public string Alias { get; set; }
        public string Ssn { get; set; }
        public string VestingType { get; set; }
        public string BorrowerPair { get; set; }
        public string VestingTrusteeOfType { get; set; }
        public string PowerOfAttorney { get; set; }
        public string Vesting { get; set; }
        public bool? AuthorizedToSignIndicator { get; set; }
        public string VestingGuid { get; set; }
        public string PoaSignatureText { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string OccupancyStatus { get; set; }
        public string OccupancyIntent { get; set; }
        public string Id { get; set; }
    }
}