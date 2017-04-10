using System;
using System.Collections.Generic;
using EncompassREST.Reporting;

namespace EncompassREST
{
    public class Reports
    {
        private Dictionary<Guid, Report> _reportList;

        public Session Session { get; }

        public Reports(Session session)
        {
            Session = session;
            _reportList = new Dictionary<Guid, Reporting.Report>();
        }

        public Report NewReport(string title = "")
        {
            var report = new Report(Session, title);
            _reportList.Add(report.ReportId, report);
            return report;
        }
    }
}
