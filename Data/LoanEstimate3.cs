
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class LoanEstimate3
{
public string lenderLicenseID { get; set; }
public string lenderEmail { get; set; }
public string lenderPhone { get; set; }
public string lenderLoanOfficer { get; set; }
public string lenderLoanOfficerNMLSId { get; set; }
public string mortgageBrokerLicenseID { get; set; }
public string mortgageBrokerEmail { get; set; }
public string mortgageBrokerPhone { get; set; }
public string mortgageBrokerLoanOfficer { get; set; }
public string mortgageBrokerLoanOfficerNMLSId { get; set; }
public string appraisal { get; set; }
public string assumption { get; set; }
public bool? homeownerInsurance { get; set; }
public string servicing { get; set; }
public bool? constructionLoan { get; set; }
public decimal? totalInterestPercentage { get; set; }
public int? in5YearsTotalYouWillHavePaid { get; set; }
public int? in5YearsPrincipalYouWillHavePaidOff { get; set; }
public string signatureType { get; set; }
public string lenderLicenseState { get; set; }
public string lenderLoanOfficerLicenseState { get; set; }
public string mortgageBrokerLicenseState { get; set; }
public string mortgageBrokerLoanOfficerLicenseState { get; set; }
public string mortgageLenderLoanOfficerLicenseID { get; set; }
public string mortgageBrokerLoanOfficerLicenseID { get; set; }
public string id { get; set; }

    }
}