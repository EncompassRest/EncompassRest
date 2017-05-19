using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Residence
    {
        public string ApplicantType { get; set; }
        public bool? MailingAddressIndicator { get; set; }
        public string AddressStreetLine1 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string LandlordName { get; set; }
        public string LandlordAttention { get; set; }
        public string LandlordStreet { get; set; }
        public string LandlordCity { get; set; }
        public string LandlordState { get; set; }
        public string LandlordPostalCode { get; set; }
        public int? DurationTermYears { get; set; }
        public string AccountName { get; set; }
        public string ResidencyBasisType { get; set; }
        public int? Rent { get; set; }
        public string LandlordPhone { get; set; }
        public string LandlordFax { get; set; }
        public string LandlordEmail { get; set; }
        public string LandlordComments { get; set; }
        public string County { get; set; }
        public string ResidencyType { get; set; }
        public int? DurationTermMonths { get; set; }
        public bool? PrintAttachmentIndicator { get; set; }
        public string Title { get; set; }
        public bool? PrintUserNameIndicator { get; set; }
        public string TitlePhone { get; set; }
        public string TitleFax { get; set; }
        public bool? NoLinkToDocTrackIndicator { get; set; }
        public DateTime? RequestDate { get; set; }
        public string AltId { get; set; }
        public string Id { get; set; }
        public bool? EntityDeleted { get; set; }
    }
}