using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate3
    {
        public string Appraisal { get; set; }
        public string Assumption { get; set; }
        public JsonNullable<bool?> ConstructionLoan { get; set; }
        public JsonNullable<bool?> HomeownerInsurance { get; set; }
        public string Id { get; set; }
        public JsonNullable<int?> In5YearsPrincipalYouWillHavePaidOff { get; set; }
        public JsonNullable<int?> In5YearsTotalYouWillHavePaid { get; set; }
        public string LenderEmail { get; set; }
        public string LenderLicenseID { get; set; }
        public string LenderLicenseState { get; set; }
        public string LenderLoanOfficer { get; set; }
        public string LenderLoanOfficerLicenseState { get; set; }
        public string LenderLoanOfficerNMLSId { get; set; }
        public string LenderPhone { get; set; }
        public string MortgageBrokerEmail { get; set; }
        public string MortgageBrokerLicenseID { get; set; }
        public string MortgageBrokerLicenseState { get; set; }
        public string MortgageBrokerLoanOfficer { get; set; }
        public string MortgageBrokerLoanOfficerLicenseID { get; set; }
        public string MortgageBrokerLoanOfficerLicenseState { get; set; }
        public string MortgageBrokerLoanOfficerNMLSId { get; set; }
        public string MortgageBrokerPhone { get; set; }
        public string MortgageLenderLoanOfficerLicenseID { get; set; }
        public string Servicing { get; set; }
        public string SignatureType { get; set; }
        public JsonNullable<decimal?> TotalInterestPercentage { get; set; }
    }
}