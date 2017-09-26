using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate3 : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _appraisal.Dirty
                    || _assumption.Dirty
                    || _constructionLoan.Dirty
                    || _homeownerInsurance.Dirty
                    || _id.Dirty
                    || _in5YearsPrincipalYouWillHavePaidOff.Dirty
                    || _in5YearsTotalYouWillHavePaid.Dirty
                    || _lenderEmail.Dirty
                    || _lenderLicenseID.Dirty
                    || _lenderLicenseState.Dirty
                    || _lenderLoanOfficer.Dirty
                    || _lenderLoanOfficerLicenseState.Dirty
                    || _lenderLoanOfficerNMLSId.Dirty
                    || _lenderPhone.Dirty
                    || _mortgageBrokerEmail.Dirty
                    || _mortgageBrokerLicenseID.Dirty
                    || _mortgageBrokerLicenseState.Dirty
                    || _mortgageBrokerLoanOfficer.Dirty
                    || _mortgageBrokerLoanOfficerLicenseID.Dirty
                    || _mortgageBrokerLoanOfficerLicenseState.Dirty
                    || _mortgageBrokerLoanOfficerNMLSId.Dirty
                    || _mortgageBrokerPhone.Dirty
                    || _mortgageLenderLoanOfficerLicenseID.Dirty
                    || _servicing.Dirty
                    || _signatureType.Dirty
                    || _totalInterestPercentage.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _appraisal.Dirty = value;
                _assumption.Dirty = value;
                _constructionLoan.Dirty = value;
                _homeownerInsurance.Dirty = value;
                _id.Dirty = value;
                _in5YearsPrincipalYouWillHavePaidOff.Dirty = value;
                _in5YearsTotalYouWillHavePaid.Dirty = value;
                _lenderEmail.Dirty = value;
                _lenderLicenseID.Dirty = value;
                _lenderLicenseState.Dirty = value;
                _lenderLoanOfficer.Dirty = value;
                _lenderLoanOfficerLicenseState.Dirty = value;
                _lenderLoanOfficerNMLSId.Dirty = value;
                _lenderPhone.Dirty = value;
                _mortgageBrokerEmail.Dirty = value;
                _mortgageBrokerLicenseID.Dirty = value;
                _mortgageBrokerLicenseState.Dirty = value;
                _mortgageBrokerLoanOfficer.Dirty = value;
                _mortgageBrokerLoanOfficerLicenseID.Dirty = value;
                _mortgageBrokerLoanOfficerLicenseState.Dirty = value;
                _mortgageBrokerLoanOfficerNMLSId.Dirty = value;
                _mortgageBrokerPhone.Dirty = value;
                _mortgageLenderLoanOfficerLicenseID.Dirty = value;
                _servicing.Dirty = value;
                _signatureType.Dirty = value;
                _totalInterestPercentage.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}