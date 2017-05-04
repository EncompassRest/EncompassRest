
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class SelectedHomeCounselingProvider
{
public string selectedGUID { get; set; }
public string agencyName { get; set; }
public string agencyAddress { get; set; }
public string agencyAddressCity { get; set; }
public string agencyAddressState { get; set; }
public string agencyAddressPostalCode { get; set; }
public string agencyPhoneDirect { get; set; }
public string agencyPhoneTollFree { get; set; }
public string agencyFax { get; set; }
public string agencyEmail { get; set; }
public string agencyWebAddress { get; set; }
public string languagesSupported { get; set; }
public string counselingServicesProvided { get; set; }
public string agencyAffiliationDescription { get; set; }
public bool? homeCounselingRequiredIndicator { get; set; }
public DateTime? homeCounselingCompletionDate { get; set; }
public bool? certificationIssuedIndicator { get; set; }
public DateTime? homeCounselingDisclosureDate { get; set; }
public decimal? distanceMiles { get; set; }
public string id { get; set; }

    }
}