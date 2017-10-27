using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LoanEstimate3 : IDirty
    {
        private DirtyValue<string> _appraisal;
        public string Appraisal { get { return _appraisal; } set { _appraisal = value; } }
        private DirtyValue<string> _assumption;
        public string Assumption { get { return _assumption; } set { _assumption = value; } }
        private DirtyValue<bool?> _constructionLoan;
        public bool? ConstructionLoan { get { return _constructionLoan; } set { _constructionLoan = value; } }
        private DirtyValue<bool?> _homeownerInsurance;
        public bool? HomeownerInsurance { get { return _homeownerInsurance; } set { _homeownerInsurance = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<int?> _in5YearsPrincipalYouWillHavePaidOff;
        public int? In5YearsPrincipalYouWillHavePaidOff { get { return _in5YearsPrincipalYouWillHavePaidOff; } set { _in5YearsPrincipalYouWillHavePaidOff = value; } }
        private DirtyValue<int?> _in5YearsTotalYouWillHavePaid;
        public int? In5YearsTotalYouWillHavePaid { get { return _in5YearsTotalYouWillHavePaid; } set { _in5YearsTotalYouWillHavePaid = value; } }
        private DirtyValue<string> _lenderEmail;
        public string LenderEmail { get { return _lenderEmail; } set { _lenderEmail = value; } }
        private DirtyValue<string> _lenderLicenseID;
        public string LenderLicenseID { get { return _lenderLicenseID; } set { _lenderLicenseID = value; } }
        private DirtyValue<string> _lenderLicenseState;
        public string LenderLicenseState { get { return _lenderLicenseState; } set { _lenderLicenseState = value; } }
        private DirtyValue<string> _lenderLoanOfficer;
        public string LenderLoanOfficer { get { return _lenderLoanOfficer; } set { _lenderLoanOfficer = value; } }
        private DirtyValue<string> _lenderLoanOfficerLicenseState;
        public string LenderLoanOfficerLicenseState { get { return _lenderLoanOfficerLicenseState; } set { _lenderLoanOfficerLicenseState = value; } }
        private DirtyValue<string> _lenderLoanOfficerNMLSId;
        public string LenderLoanOfficerNMLSId { get { return _lenderLoanOfficerNMLSId; } set { _lenderLoanOfficerNMLSId = value; } }
        private DirtyValue<string> _lenderPhone;
        public string LenderPhone { get { return _lenderPhone; } set { _lenderPhone = value; } }
        private DirtyValue<string> _mortgageBrokerEmail;
        public string MortgageBrokerEmail { get { return _mortgageBrokerEmail; } set { _mortgageBrokerEmail = value; } }
        private DirtyValue<string> _mortgageBrokerLicenseID;
        public string MortgageBrokerLicenseID { get { return _mortgageBrokerLicenseID; } set { _mortgageBrokerLicenseID = value; } }
        private DirtyValue<string> _mortgageBrokerLicenseState;
        public string MortgageBrokerLicenseState { get { return _mortgageBrokerLicenseState; } set { _mortgageBrokerLicenseState = value; } }
        private DirtyValue<string> _mortgageBrokerLoanOfficer;
        public string MortgageBrokerLoanOfficer { get { return _mortgageBrokerLoanOfficer; } set { _mortgageBrokerLoanOfficer = value; } }
        private DirtyValue<string> _mortgageBrokerLoanOfficerLicenseID;
        public string MortgageBrokerLoanOfficerLicenseID { get { return _mortgageBrokerLoanOfficerLicenseID; } set { _mortgageBrokerLoanOfficerLicenseID = value; } }
        private DirtyValue<string> _mortgageBrokerLoanOfficerLicenseState;
        public string MortgageBrokerLoanOfficerLicenseState { get { return _mortgageBrokerLoanOfficerLicenseState; } set { _mortgageBrokerLoanOfficerLicenseState = value; } }
        private DirtyValue<string> _mortgageBrokerLoanOfficerNMLSId;
        public string MortgageBrokerLoanOfficerNMLSId { get { return _mortgageBrokerLoanOfficerNMLSId; } set { _mortgageBrokerLoanOfficerNMLSId = value; } }
        private DirtyValue<string> _mortgageBrokerPhone;
        public string MortgageBrokerPhone { get { return _mortgageBrokerPhone; } set { _mortgageBrokerPhone = value; } }
        private DirtyValue<string> _mortgageLenderLoanOfficerLicenseID;
        public string MortgageLenderLoanOfficerLicenseID { get { return _mortgageLenderLoanOfficerLicenseID; } set { _mortgageLenderLoanOfficerLicenseID = value; } }
        private DirtyValue<string> _servicing;
        public string Servicing { get { return _servicing; } set { _servicing = value; } }
        private DirtyValue<string> _signatureType;
        public string SignatureType { get { return _signatureType; } set { _signatureType = value; } }
        private DirtyValue<decimal?> _totalInterestPercentage;
        public decimal? TotalInterestPercentage { get { return _totalInterestPercentage; } set { _totalInterestPercentage = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
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
                    || _totalInterestPercentage.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}