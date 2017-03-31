using EncompassREST.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Reporting
{
    public class Report
    {
        private List<Loan> _Loans = new List<Loan>();
        private Dictionary<string, string> _Fields = new Dictionary<string, string>();
        private string _Title;
        private Session _Session;
        private Guid _ReportID;

        public Session Session
        {
            get { return _Session; }
        }

        public Guid ReportID
        {
            get { return _ReportID; }
        }

        public List<string> GuidList
        {
            get { return _Loans.Select(x => x.encompassId).ToList(); }
        }

        public Report(Session Session,string Title)
        {
            _Title = Title;
            _Session = Session;
            _ReportID = Guid.NewGuid();
        }
        public void addLoan(string GUID)
        {
            var tLoan = _Session.Loans.GetLoanAsync(GUID).Result;
            this.addLoan(tLoan);
        }

        public void addLoan(Loan newLoan)
        {
            if (_Loans.Where(x => x.encompassId == newLoan.encompassId).Count() == 0) //ensure no duplicate loans
                _Loans.Add(newLoan);
        }

        public void addFieldOutput(string Headder, string Field)
        {
            _Fields.Add(Headder, Field);
        }

        public string generateJSONReport()
        {
            ExpandoObject report = new ExpandoObject();
            var rep = report as IDictionary<string, object>;
            foreach (var loan in _Loans)
            {
                ExpandoObject ja = new ExpandoObject();
                var jaAdd = ja as IDictionary<string, object>;
                foreach (var kp in _Fields)
                {
                    jaAdd.Add(kp.Key, loan.GetLoanValueJSONRecursive(kp.Value));
                }
                rep.Add(loan.encompassId, ja);
            }
            return JsonConvert.SerializeObject(report);
        }

        [Obsolete()]
        public string generateCSVReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Join(",", _Fields.Select(x => x.Key)));


            foreach (var loan in _Loans)
            {
                sb.AppendLine(GenerateLoanRow(loan));
            }

            return sb.ToString();
        }
        [Obsolete()]
        private string GenerateLoanRow(Loan loan)
        {
            List<string> data = new List<string>();
            foreach (var kp in _Fields)
            {
                data.Add(GetFieldData(loan, kp.Value).ToString());
            }
            return string.Join(",", data);
        }
        [Obsolete()]
        private object GetFieldData(Loan loan, string Field)
        {
            //The magic happens here
            return loan.GetLoanValueRecursive(Field);
        }
    }
}
