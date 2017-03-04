
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class HomeCounselingProvider
{
public bool? selectedIndicator { get; set; }
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
public bool? agencyAffiliationIndicator { get; set; }
public string agencyAffiliationDescription { get; set; }
public string agencySource { get; set; }
public decimal? distanceMiles { get; set; }
public string agencyId { get; set; }
public string id { get; set; }
public int? homeCounselingProviderIndex { get; set; }
public string homeCounselingProviderId { get; set; }

    }
}