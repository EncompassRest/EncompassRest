using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class Options
    {
        public bool DigiCert { get; set; }
        public string RequestType { get; set; }
        public string ReportOn { get; set; }
        public string ReportType { get; set; }
        public string CreditReportIdentifier { get; set; }
        public string Note { get; set; }
        public bool ExcludeZeroforImportLiabilities { get; set; }
        public string CreditBureauExperian { get; set; }
        public string CreditBureauEquifax { get; set; }
        public string CreditBureauTransUnion { get; set; }
    }
}
