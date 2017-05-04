using System;
using System.Collections.Generic;
using EncompassRest.Reporting;

namespace EncompassRest
{
    public class Reports
    {
        private Dictionary<Guid, Report> _reportList;

        public EncompassRestClient Client { get; }

        public Reports(EncompassRestClient client)
        {
            Client = client;
            _reportList = new Dictionary<Guid, Reporting.Report>();
        }

        public Report NewReport(string title = "")
        {
            var report = new Report(Client, title);
            _reportList.Add(report.ReportId, report);
            return report;
        }
    }
}
