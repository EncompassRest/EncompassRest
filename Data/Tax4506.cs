
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Tax4506
    {
        public bool? tax4506TIndicator { get; set; }
        public bool? historyIndicator { get; set; }
        public string person { get; set; }
        public string sendAddress { get; set; }
        public string sendCity { get; set; }
        public string sendState { get; set; }
        public string sendZip { get; set; }
        public bool? ifTaxRecordNotFound { get; set; }
        public bool? theseCopiesMustBeCertified { get; set; }
        public string first { get; set; }
        public string taxFormNumber { get; set; }
        public DateTime? requestYear1 { get; set; }
        public DateTime? requestYear2 { get; set; }
        public string requestorPhoneNumber { get; set; }
        public string requestorTitle { get; set; }
        public DateTime? requestYear3 { get; set; }
        public string last { get; set; }
        public DateTime? requestYear4 { get; set; }
        public int? numberOfPeriods { get; set; }
        public decimal? totalCost { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string currentFirst { get; set; }
        public string sSN { get; set; }
        public string currentLast { get; set; }
        public string returnAddress { get; set; }
        public string returnCity { get; set; }
        public string returnState { get; set; }
        public string returnZip { get; set; }
        public string sendPhone { get; set; }
        public bool? returnTranscript { get; set; }
        public bool? accountTranscript { get; set; }
        public bool? recordOfAccount { get; set; }
        public bool? verificationOfNonfiling { get; set; }
        public string spouseSSN { get; set; }
        public bool? formsSeriesTranscript { get; set; }
        public decimal? costForEachPeriod { get; set; }
        public DateTime? requestYear5 { get; set; }
        public DateTime? requestYear6 { get; set; }
        public DateTime? requestYear7 { get; set; }
        public DateTime? requestYear8 { get; set; }
        public bool? useEIN { get; set; }
        public bool? spouseUseEIN { get; set; }
        public bool? useWellsFargoRules { get; set; }
        public bool? notifiedIrsIdentityTheftIndicator { get; set; }
        public string spouseFirst { get; set; }
        public string spouseLast { get; set; }
        public string sendFirst { get; set; }
        public string sendLast { get; set; }
        public string selectedRecordNumber { get; set; }
        public bool? signatoryAttestation { get; set; }
        public bool? signatoryAttestationT { get; set; }
        public DateTime? lastUpdatedDate { get; set; }
        public string lastUpdatedTime { get; set; }
        public string historyId { get; set; }
        public int? lastUpdatedHistory { get; set; }
        public string id { get; set; }
        public int? tax4506Index { get; set; }

    }
}