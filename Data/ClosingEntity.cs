using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class ClosingEntity
    {
        public string closingEntityType { get; set; }
        public string unparsedName { get; set; }
        public string organizedUnderTheLawsOfJurisdictionName { get; set; }
        public string organizationType { get; set; }
        public string taxIdentificationNumberIdentifier { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string county { get; set; }
        public string phone { get; set; }
        public DateTime? recordableDocumentTrustDate { get; set; }
        public string comments { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string fax { get; set; }
        public string recordCity { get; set; }
        public string assignee { get; set; }
        public string trustOfficerName1 { get; set; }
        public string trustOfficerTitle1 { get; set; }
        public string trustOfficerName2 { get; set; }
        public string trustOfficerTitle2 { get; set; }
        public string alias { get; set; }
        public string ssn { get; set; }
        public string vestingType { get; set; }
        public string borrowerPair { get; set; }
        public string vestingTrusteeOfType { get; set; }
        public string powerOfAttorney { get; set; }
        public string vesting { get; set; }
        public bool? authorizedToSignIndicator { get; set; }
        public string vestingGuid { get; set; }
        public string poaSignatureText { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string occupancyStatus { get; set; }
        public string occupancyIntent { get; set; }
        public string id { get; set; }

    }
}
