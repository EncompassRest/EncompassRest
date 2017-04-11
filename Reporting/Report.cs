using EncompassREST.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace EncompassREST.Reporting
{
    public class Report
    {
        private readonly List<Loan> _loans = new List<Loan>();
        private readonly Dictionary<string, string> _fields = new Dictionary<string, string>();
        private readonly string _title;

        public Session Session { get; }

        public Guid ReportId { get; }

        public List<string> GuidList
        {
            get { return _loans.Select(x => x.encompassId).ToList(); }
        }

        public Report(Session session, string title)
        {
            _title = title;
            Session = session;
            ReportId = Guid.NewGuid();
        }

        public void AddLoan(string guid)
        {
            var tLoan = Session.Loans.GetLoanAsync(guid).Result;
            AddLoan(tLoan);
        }

        public void AddLoan(Loan newLoan)
        {
            if (_loans.Where(x => x.encompassId == newLoan.encompassId).Count() == 0) //ensure no duplicate loans
                _loans.Add(newLoan);
        }

        public void AddFieldOutput(string header, string field)
        {
            _fields.Add(header, field);
        }

        public string GenerateJsonReport()
        {
            var report = new ExpandoObject();
            var rep = report as IDictionary<string, object>;
            foreach (var loan in _loans)
            {
                var ja = new ExpandoObject();
                var jaAdd = ja as IDictionary<string, object>;
                foreach (var kp in _fields)
                {
                    jaAdd.Add(kp.Key, loan.GetLoanValueJSONRecursive(kp.Value));
                }
                rep.Add(loan.encompassId, ja);
            }
            return JsonConvert.SerializeObject(report);
        }

        [Obsolete]
        public string GenerateCsvReport()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(",", _fields.Select(x => x.Key)));

            foreach (var loan in _loans)
            {
                sb.AppendLine(GenerateLoanRow(loan));
            }

            return sb.ToString();
        }

        [Obsolete]
        private string GenerateLoanRow(Loan loan)
        {
            var data = new List<string>();
            foreach (var kp in _fields)
            {
                data.Add(GetFieldData(loan, kp.Value).ToString());
            }
            return string.Join(",", data);
        }

        [Obsolete]
        private object GetFieldData(Loan loan, string Field)
        {
            //The magic happens here
            return loan.GetLoanValueRecursive(Field);
        }
    }
}
