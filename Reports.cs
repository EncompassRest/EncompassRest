using EncompassREST.Data;
using EncompassREST.Reporting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Reports
    {
        private Session eSession;
        private Dictionary<Guid, Report> _ReportList;

        public Session Session
        {
            get { return eSession; }
        }

        public Reports(Session Session)
        {
            eSession = Session;
            _ReportList = new Dictionary<Guid, Reporting.Report>();
        }

        public Report newReport(string Title = "")
        {
            var report = new Report(eSession, Title);
            _ReportList.Add(report.ReportID, report);
            return report;
        }


        



    }
}
