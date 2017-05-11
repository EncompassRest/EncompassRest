using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class SelectedHomeCounselingProvider
    {
        public string SelectedGUID { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyAddressCity { get; set; }
        public string AgencyAddressState { get; set; }
        public string AgencyAddressPostalCode { get; set; }
        public string AgencyPhoneDirect { get; set; }
        public string AgencyPhoneTollFree { get; set; }
        public string AgencyFax { get; set; }
        public string AgencyEmail { get; set; }
        public string AgencyWebAddress { get; set; }
        public string LanguagesSupported { get; set; }
        public string CounselingServicesProvided { get; set; }
        public string AgencyAffiliationDescription { get; set; }
        public bool? HomeCounselingRequiredIndicator { get; set; }
        public DateTime? HomeCounselingCompletionDate { get; set; }
        public bool? CertificationIssuedIndicator { get; set; }
        public DateTime? HomeCounselingDisclosureDate { get; set; }
        public decimal? DistanceMiles { get; set; }
        public string Id { get; set; }
    }
}