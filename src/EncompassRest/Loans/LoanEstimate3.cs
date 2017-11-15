using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LoanEstimate3 : IDirty
    {
        private DirtyValue<StringEnumValue<Appraisal>> _appraisal;
        public StringEnumValue<Appraisal> Appraisal { get => _appraisal; set => _appraisal = value; }
        private DirtyValue<StringEnumValue<Assumption>> _assumption;
        public StringEnumValue<Assumption> Assumption { get => _assumption; set => _assumption = value; }
        private DirtyValue<bool?> _constructionLoan;
        public bool? ConstructionLoan { get => _constructionLoan; set => _constructionLoan = value; }
        private DirtyValue<bool?> _homeownerInsurance;
        public bool? HomeownerInsurance { get => _homeownerInsurance; set => _homeownerInsurance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _in5YearsPrincipalYouWillHavePaidOff;
        public int? In5YearsPrincipalYouWillHavePaidOff { get => _in5YearsPrincipalYouWillHavePaidOff; set => _in5YearsPrincipalYouWillHavePaidOff = value; }
        private DirtyValue<int?> _in5YearsTotalYouWillHavePaid;
        public int? In5YearsTotalYouWillHavePaid { get => _in5YearsTotalYouWillHavePaid; set => _in5YearsTotalYouWillHavePaid = value; }
        private DirtyValue<string> _lenderEmail;
        public string LenderEmail { get => _lenderEmail; set => _lenderEmail = value; }
        private DirtyValue<string> _lenderLicenseID;
        public string LenderLicenseID { get => _lenderLicenseID; set => _lenderLicenseID = value; }
        private DirtyValue<string> _lenderLicenseState;
        public string LenderLicenseState { get => _lenderLicenseState; set => _lenderLicenseState = value; }
        private DirtyValue<string> _lenderLoanOfficer;
        public string LenderLoanOfficer { get => _lenderLoanOfficer; set => _lenderLoanOfficer = value; }
        private DirtyValue<string> _lenderLoanOfficerLicenseState;
        public string LenderLoanOfficerLicenseState { get => _lenderLoanOfficerLicenseState; set => _lenderLoanOfficerLicenseState = value; }
        private DirtyValue<string> _lenderLoanOfficerNMLSId;
        public string LenderLoanOfficerNMLSId { get => _lenderLoanOfficerNMLSId; set => _lenderLoanOfficerNMLSId = value; }
        private DirtyValue<string> _lenderPhone;
        public string LenderPhone { get => _lenderPhone; set => _lenderPhone = value; }
        private DirtyValue<string> _mortgageBrokerEmail;
        public string MortgageBrokerEmail { get => _mortgageBrokerEmail; set => _mortgageBrokerEmail = value; }
        private DirtyValue<string> _mortgageBrokerLicenseID;
        public string MortgageBrokerLicenseID { get => _mortgageBrokerLicenseID; set => _mortgageBrokerLicenseID = value; }
        private DirtyValue<string> _mortgageBrokerLicenseState;
        public string MortgageBrokerLicenseState { get => _mortgageBrokerLicenseState; set => _mortgageBrokerLicenseState = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficer;
        public string MortgageBrokerLoanOfficer { get => _mortgageBrokerLoanOfficer; set => _mortgageBrokerLoanOfficer = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficerLicenseID;
        public string MortgageBrokerLoanOfficerLicenseID { get => _mortgageBrokerLoanOfficerLicenseID; set => _mortgageBrokerLoanOfficerLicenseID = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficerLicenseState;
        public string MortgageBrokerLoanOfficerLicenseState { get => _mortgageBrokerLoanOfficerLicenseState; set => _mortgageBrokerLoanOfficerLicenseState = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficerNMLSId;
        public string MortgageBrokerLoanOfficerNMLSId { get => _mortgageBrokerLoanOfficerNMLSId; set => _mortgageBrokerLoanOfficerNMLSId = value; }
        private DirtyValue<string> _mortgageBrokerPhone;
        public string MortgageBrokerPhone { get => _mortgageBrokerPhone; set => _mortgageBrokerPhone = value; }
        private DirtyValue<string> _mortgageLenderLoanOfficerLicenseID;
        public string MortgageLenderLoanOfficerLicenseID { get => _mortgageLenderLoanOfficerLicenseID; set => _mortgageLenderLoanOfficerLicenseID = value; }
        private DirtyValue<StringEnumValue<Servicing>> _servicing;
        public StringEnumValue<Servicing> Servicing { get => _servicing; set => _servicing = value; }
        private DirtyValue<StringEnumValue<SignatureType>> _signatureType;
        public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => _signatureType = value; }
        private DirtyValue<decimal?> _totalInterestPercentage;
        public decimal? TotalInterestPercentage { get => _totalInterestPercentage; set => _totalInterestPercentage = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
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
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}