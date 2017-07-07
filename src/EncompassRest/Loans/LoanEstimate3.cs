using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate3 : IClean
    {
        private Value<string> _appraisal;
        public string Appraisal { get { return _appraisal; } set { _appraisal = value; } }
        private Value<string> _assumption;
        public string Assumption { get { return _assumption; } set { _assumption = value; } }
        private Value<bool?> _constructionLoan;
        public bool? ConstructionLoan { get { return _constructionLoan; } set { _constructionLoan = value; } }
        private Value<bool?> _homeownerInsurance;
        public bool? HomeownerInsurance { get { return _homeownerInsurance; } set { _homeownerInsurance = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _in5YearsPrincipalYouWillHavePaidOff;
        public int? In5YearsPrincipalYouWillHavePaidOff { get { return _in5YearsPrincipalYouWillHavePaidOff; } set { _in5YearsPrincipalYouWillHavePaidOff = value; } }
        private Value<int?> _in5YearsTotalYouWillHavePaid;
        public int? In5YearsTotalYouWillHavePaid { get { return _in5YearsTotalYouWillHavePaid; } set { _in5YearsTotalYouWillHavePaid = value; } }
        private Value<string> _lenderEmail;
        public string LenderEmail { get { return _lenderEmail; } set { _lenderEmail = value; } }
        private Value<string> _lenderLicenseID;
        public string LenderLicenseID { get { return _lenderLicenseID; } set { _lenderLicenseID = value; } }
        private Value<string> _lenderLicenseState;
        public string LenderLicenseState { get { return _lenderLicenseState; } set { _lenderLicenseState = value; } }
        private Value<string> _lenderLoanOfficer;
        public string LenderLoanOfficer { get { return _lenderLoanOfficer; } set { _lenderLoanOfficer = value; } }
        private Value<string> _lenderLoanOfficerLicenseState;
        public string LenderLoanOfficerLicenseState { get { return _lenderLoanOfficerLicenseState; } set { _lenderLoanOfficerLicenseState = value; } }
        private Value<string> _lenderLoanOfficerNMLSId;
        public string LenderLoanOfficerNMLSId { get { return _lenderLoanOfficerNMLSId; } set { _lenderLoanOfficerNMLSId = value; } }
        private Value<string> _lenderPhone;
        public string LenderPhone { get { return _lenderPhone; } set { _lenderPhone = value; } }
        private Value<string> _mortgageBrokerEmail;
        public string MortgageBrokerEmail { get { return _mortgageBrokerEmail; } set { _mortgageBrokerEmail = value; } }
        private Value<string> _mortgageBrokerLicenseID;
        public string MortgageBrokerLicenseID { get { return _mortgageBrokerLicenseID; } set { _mortgageBrokerLicenseID = value; } }
        private Value<string> _mortgageBrokerLicenseState;
        public string MortgageBrokerLicenseState { get { return _mortgageBrokerLicenseState; } set { _mortgageBrokerLicenseState = value; } }
        private Value<string> _mortgageBrokerLoanOfficer;
        public string MortgageBrokerLoanOfficer { get { return _mortgageBrokerLoanOfficer; } set { _mortgageBrokerLoanOfficer = value; } }
        private Value<string> _mortgageBrokerLoanOfficerLicenseID;
        public string MortgageBrokerLoanOfficerLicenseID { get { return _mortgageBrokerLoanOfficerLicenseID; } set { _mortgageBrokerLoanOfficerLicenseID = value; } }
        private Value<string> _mortgageBrokerLoanOfficerLicenseState;
        public string MortgageBrokerLoanOfficerLicenseState { get { return _mortgageBrokerLoanOfficerLicenseState; } set { _mortgageBrokerLoanOfficerLicenseState = value; } }
        private Value<string> _mortgageBrokerLoanOfficerNMLSId;
        public string MortgageBrokerLoanOfficerNMLSId { get { return _mortgageBrokerLoanOfficerNMLSId; } set { _mortgageBrokerLoanOfficerNMLSId = value; } }
        private Value<string> _mortgageBrokerPhone;
        public string MortgageBrokerPhone { get { return _mortgageBrokerPhone; } set { _mortgageBrokerPhone = value; } }
        private Value<string> _mortgageLenderLoanOfficerLicenseID;
        public string MortgageLenderLoanOfficerLicenseID { get { return _mortgageLenderLoanOfficerLicenseID; } set { _mortgageLenderLoanOfficerLicenseID = value; } }
        private Value<string> _servicing;
        public string Servicing { get { return _servicing; } set { _servicing = value; } }
        private Value<string> _signatureType;
        public string SignatureType { get { return _signatureType; } set { _signatureType = value; } }
        private Value<decimal?> _totalInterestPercentage;
        public decimal? TotalInterestPercentage { get { return _totalInterestPercentage; } set { _totalInterestPercentage = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisal.Clean
                    && _assumption.Clean
                    && _constructionLoan.Clean
                    && _homeownerInsurance.Clean
                    && _id.Clean
                    && _in5YearsPrincipalYouWillHavePaidOff.Clean
                    && _in5YearsTotalYouWillHavePaid.Clean
                    && _lenderEmail.Clean
                    && _lenderLicenseID.Clean
                    && _lenderLicenseState.Clean
                    && _lenderLoanOfficer.Clean
                    && _lenderLoanOfficerLicenseState.Clean
                    && _lenderLoanOfficerNMLSId.Clean
                    && _lenderPhone.Clean
                    && _mortgageBrokerEmail.Clean
                    && _mortgageBrokerLicenseID.Clean
                    && _mortgageBrokerLicenseState.Clean
                    && _mortgageBrokerLoanOfficer.Clean
                    && _mortgageBrokerLoanOfficerLicenseID.Clean
                    && _mortgageBrokerLoanOfficerLicenseState.Clean
                    && _mortgageBrokerLoanOfficerNMLSId.Clean
                    && _mortgageBrokerPhone.Clean
                    && _mortgageLenderLoanOfficerLicenseID.Clean
                    && _servicing.Clean
                    && _signatureType.Clean
                    && _totalInterestPercentage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var appraisal = _appraisal; appraisal.Clean = value; _appraisal = appraisal;
                var assumption = _assumption; assumption.Clean = value; _assumption = assumption;
                var constructionLoan = _constructionLoan; constructionLoan.Clean = value; _constructionLoan = constructionLoan;
                var homeownerInsurance = _homeownerInsurance; homeownerInsurance.Clean = value; _homeownerInsurance = homeownerInsurance;
                var id = _id; id.Clean = value; _id = id;
                var in5YearsPrincipalYouWillHavePaidOff = _in5YearsPrincipalYouWillHavePaidOff; in5YearsPrincipalYouWillHavePaidOff.Clean = value; _in5YearsPrincipalYouWillHavePaidOff = in5YearsPrincipalYouWillHavePaidOff;
                var in5YearsTotalYouWillHavePaid = _in5YearsTotalYouWillHavePaid; in5YearsTotalYouWillHavePaid.Clean = value; _in5YearsTotalYouWillHavePaid = in5YearsTotalYouWillHavePaid;
                var lenderEmail = _lenderEmail; lenderEmail.Clean = value; _lenderEmail = lenderEmail;
                var lenderLicenseID = _lenderLicenseID; lenderLicenseID.Clean = value; _lenderLicenseID = lenderLicenseID;
                var lenderLicenseState = _lenderLicenseState; lenderLicenseState.Clean = value; _lenderLicenseState = lenderLicenseState;
                var lenderLoanOfficer = _lenderLoanOfficer; lenderLoanOfficer.Clean = value; _lenderLoanOfficer = lenderLoanOfficer;
                var lenderLoanOfficerLicenseState = _lenderLoanOfficerLicenseState; lenderLoanOfficerLicenseState.Clean = value; _lenderLoanOfficerLicenseState = lenderLoanOfficerLicenseState;
                var lenderLoanOfficerNMLSId = _lenderLoanOfficerNMLSId; lenderLoanOfficerNMLSId.Clean = value; _lenderLoanOfficerNMLSId = lenderLoanOfficerNMLSId;
                var lenderPhone = _lenderPhone; lenderPhone.Clean = value; _lenderPhone = lenderPhone;
                var mortgageBrokerEmail = _mortgageBrokerEmail; mortgageBrokerEmail.Clean = value; _mortgageBrokerEmail = mortgageBrokerEmail;
                var mortgageBrokerLicenseID = _mortgageBrokerLicenseID; mortgageBrokerLicenseID.Clean = value; _mortgageBrokerLicenseID = mortgageBrokerLicenseID;
                var mortgageBrokerLicenseState = _mortgageBrokerLicenseState; mortgageBrokerLicenseState.Clean = value; _mortgageBrokerLicenseState = mortgageBrokerLicenseState;
                var mortgageBrokerLoanOfficer = _mortgageBrokerLoanOfficer; mortgageBrokerLoanOfficer.Clean = value; _mortgageBrokerLoanOfficer = mortgageBrokerLoanOfficer;
                var mortgageBrokerLoanOfficerLicenseID = _mortgageBrokerLoanOfficerLicenseID; mortgageBrokerLoanOfficerLicenseID.Clean = value; _mortgageBrokerLoanOfficerLicenseID = mortgageBrokerLoanOfficerLicenseID;
                var mortgageBrokerLoanOfficerLicenseState = _mortgageBrokerLoanOfficerLicenseState; mortgageBrokerLoanOfficerLicenseState.Clean = value; _mortgageBrokerLoanOfficerLicenseState = mortgageBrokerLoanOfficerLicenseState;
                var mortgageBrokerLoanOfficerNMLSId = _mortgageBrokerLoanOfficerNMLSId; mortgageBrokerLoanOfficerNMLSId.Clean = value; _mortgageBrokerLoanOfficerNMLSId = mortgageBrokerLoanOfficerNMLSId;
                var mortgageBrokerPhone = _mortgageBrokerPhone; mortgageBrokerPhone.Clean = value; _mortgageBrokerPhone = mortgageBrokerPhone;
                var mortgageLenderLoanOfficerLicenseID = _mortgageLenderLoanOfficerLicenseID; mortgageLenderLoanOfficerLicenseID.Clean = value; _mortgageLenderLoanOfficerLicenseID = mortgageLenderLoanOfficerLicenseID;
                var servicing = _servicing; servicing.Clean = value; _servicing = servicing;
                var signatureType = _signatureType; signatureType.Clean = value; _signatureType = signatureType;
                var totalInterestPercentage = _totalInterestPercentage; totalInterestPercentage.Clean = value; _totalInterestPercentage = totalInterestPercentage;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanEstimate3()
        {
            Clean = true;
        }
    }
}