using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider
    {
        public string AgencyAddress { get; set; }
        public string AgencyAddressCity { get; set; }
        public string AgencyAddressPostalCode { get; set; }
        public string AgencyAddressState { get; set; }
        public string AgencyAffiliationDescription { get; set; }
        public string AgencyEmail { get; set; }
        public string AgencyFax { get; set; }
        public string AgencyName { get; set; }
        public string AgencyPhoneDirect { get; set; }
        public string AgencyPhoneTollFree { get; set; }
        public string AgencyWebAddress { get; set; }
        public JsonNullable<bool?> CertificationIssuedIndicator { get; set; }
        public string CounselingServicesProvided { get; set; }
        public JsonNullable<decimal?> DistanceMiles { get; set; }
        public JsonNullable<DateTime?> HomeCounselingCompletionDate { get; set; }
        public JsonNullable<DateTime?> HomeCounselingDisclosureDate { get; set; }
        public JsonNullable<bool?> HomeCounselingRequiredIndicator { get; set; }
        public string Id { get; set; }
        public string LanguagesSupported { get; set; }
        public string SelectedGUID { get; set; }
    }
}