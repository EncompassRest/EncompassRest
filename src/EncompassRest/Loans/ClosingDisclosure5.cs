using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure5 : IDirty
    {
        private Value<string> _cDLiabilityAfterForeclosure;
        public string CDLiabilityAfterForeclosure { get { return _cDLiabilityAfterForeclosure; } set { _cDLiabilityAfterForeclosure = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lenderAddress;
        public string LenderAddress { get { return _lenderAddress; } set { _lenderAddress = value; } }
        private Value<string> _lenderCity;
        public string LenderCity { get { return _lenderCity; } set { _lenderCity = value; } }
        private Value<string> _lenderContact;
        public string LenderContact { get { return _lenderContact; } set { _lenderContact = value; } }
        private Value<string> _lenderContactATLicenseID;
        public string LenderContactATLicenseID { get { return _lenderContactATLicenseID; } set { _lenderContactATLicenseID = value; } }
        private Value<string> _lenderContactNMLSID;
        public string LenderContactNMLSID { get { return _lenderContactNMLSID; } set { _lenderContactNMLSID = value; } }
        private Value<string> _lenderEmail;
        public string LenderEmail { get { return _lenderEmail; } set { _lenderEmail = value; } }
        private Value<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private Value<string> _lenderNMLSID;
        public string LenderNMLSID { get { return _lenderNMLSID; } set { _lenderNMLSID = value; } }
        private Value<string> _lenderPhone;
        public string LenderPhone { get { return _lenderPhone; } set { _lenderPhone = value; } }
        private Value<string> _lenderState;
        public string LenderState { get { return _lenderState; } set { _lenderState = value; } }
        private Value<string> _lenderSTLicenseID;
        public string LenderSTLicenseID { get { return _lenderSTLicenseID; } set { _lenderSTLicenseID = value; } }
        private Value<string> _lenderZip;
        public string LenderZip { get { return _lenderZip; } set { _lenderZip = value; } }
        private Value<string> _mortgageBrokerAddress;
        public string MortgageBrokerAddress { get { return _mortgageBrokerAddress; } set { _mortgageBrokerAddress = value; } }
        private Value<string> _mortgageBrokerCity;
        public string MortgageBrokerCity { get { return _mortgageBrokerCity; } set { _mortgageBrokerCity = value; } }
        private Value<string> _mortgageBrokerContact;
        public string MortgageBrokerContact { get { return _mortgageBrokerContact; } set { _mortgageBrokerContact = value; } }
        private Value<string> _mortgageBrokerContactATLicenseID;
        public string MortgageBrokerContactATLicenseID { get { return _mortgageBrokerContactATLicenseID; } set { _mortgageBrokerContactATLicenseID = value; } }
        private Value<string> _mortgageBrokerContactNMLSID;
        public string MortgageBrokerContactNMLSID { get { return _mortgageBrokerContactNMLSID; } set { _mortgageBrokerContactNMLSID = value; } }
        private Value<string> _mortgageBrokerEmail;
        public string MortgageBrokerEmail { get { return _mortgageBrokerEmail; } set { _mortgageBrokerEmail = value; } }
        private Value<string> _mortgageBrokerName;
        public string MortgageBrokerName { get { return _mortgageBrokerName; } set { _mortgageBrokerName = value; } }
        private Value<string> _mortgageBrokerNMLSID;
        public string MortgageBrokerNMLSID { get { return _mortgageBrokerNMLSID; } set { _mortgageBrokerNMLSID = value; } }
        private Value<string> _mortgageBrokerPhone;
        public string MortgageBrokerPhone { get { return _mortgageBrokerPhone; } set { _mortgageBrokerPhone = value; } }
        private Value<string> _mortgageBrokerState;
        public string MortgageBrokerState { get { return _mortgageBrokerState; } set { _mortgageBrokerState = value; } }
        private Value<string> _mortgageBrokerSTLicenseID;
        public string MortgageBrokerSTLicenseID { get { return _mortgageBrokerSTLicenseID; } set { _mortgageBrokerSTLicenseID = value; } }
        private Value<string> _mortgageBrokerZip;
        public string MortgageBrokerZip { get { return _mortgageBrokerZip; } set { _mortgageBrokerZip = value; } }
        private Value<string> _realEstateBrokerBAddress;
        public string RealEstateBrokerBAddress { get { return _realEstateBrokerBAddress; } set { _realEstateBrokerBAddress = value; } }
        private Value<string> _realEstateBrokerBCity;
        public string RealEstateBrokerBCity { get { return _realEstateBrokerBCity; } set { _realEstateBrokerBCity = value; } }
        private Value<string> _realEstateBrokerBContact;
        public string RealEstateBrokerBContact { get { return _realEstateBrokerBContact; } set { _realEstateBrokerBContact = value; } }
        private Value<string> _realEstateBrokerBContactATLicenseID;
        public string RealEstateBrokerBContactATLicenseID { get { return _realEstateBrokerBContactATLicenseID; } set { _realEstateBrokerBContactATLicenseID = value; } }
        private Value<string> _realEstateBrokerBContactNMLSID;
        public string RealEstateBrokerBContactNMLSID { get { return _realEstateBrokerBContactNMLSID; } set { _realEstateBrokerBContactNMLSID = value; } }
        private Value<string> _realEstateBrokerBEmail;
        public string RealEstateBrokerBEmail { get { return _realEstateBrokerBEmail; } set { _realEstateBrokerBEmail = value; } }
        private Value<string> _realEstateBrokerBName;
        public string RealEstateBrokerBName { get { return _realEstateBrokerBName; } set { _realEstateBrokerBName = value; } }
        private Value<string> _realEstateBrokerBNMLSID;
        public string RealEstateBrokerBNMLSID { get { return _realEstateBrokerBNMLSID; } set { _realEstateBrokerBNMLSID = value; } }
        private Value<string> _realEstateBrokerBPhone;
        public string RealEstateBrokerBPhone { get { return _realEstateBrokerBPhone; } set { _realEstateBrokerBPhone = value; } }
        private Value<string> _realEstateBrokerBState;
        public string RealEstateBrokerBState { get { return _realEstateBrokerBState; } set { _realEstateBrokerBState = value; } }
        private Value<string> _realEstateBrokerBSTLicenseID;
        public string RealEstateBrokerBSTLicenseID { get { return _realEstateBrokerBSTLicenseID; } set { _realEstateBrokerBSTLicenseID = value; } }
        private Value<string> _realEstateBrokerBZip;
        public string RealEstateBrokerBZip { get { return _realEstateBrokerBZip; } set { _realEstateBrokerBZip = value; } }
        private Value<string> _realEstateBrokerSAddress;
        public string RealEstateBrokerSAddress { get { return _realEstateBrokerSAddress; } set { _realEstateBrokerSAddress = value; } }
        private Value<string> _realEstateBrokerSCity;
        public string RealEstateBrokerSCity { get { return _realEstateBrokerSCity; } set { _realEstateBrokerSCity = value; } }
        private Value<string> _realEstateBrokerSContact;
        public string RealEstateBrokerSContact { get { return _realEstateBrokerSContact; } set { _realEstateBrokerSContact = value; } }
        private Value<string> _realEstateBrokerSContactATLicenseID;
        public string RealEstateBrokerSContactATLicenseID { get { return _realEstateBrokerSContactATLicenseID; } set { _realEstateBrokerSContactATLicenseID = value; } }
        private Value<string> _realEstateBrokerSContactNMLSID;
        public string RealEstateBrokerSContactNMLSID { get { return _realEstateBrokerSContactNMLSID; } set { _realEstateBrokerSContactNMLSID = value; } }
        private Value<string> _realEstateBrokerSEmail;
        public string RealEstateBrokerSEmail { get { return _realEstateBrokerSEmail; } set { _realEstateBrokerSEmail = value; } }
        private Value<string> _realEstateBrokerSName;
        public string RealEstateBrokerSName { get { return _realEstateBrokerSName; } set { _realEstateBrokerSName = value; } }
        private Value<string> _realEstateBrokerSNMLSID;
        public string RealEstateBrokerSNMLSID { get { return _realEstateBrokerSNMLSID; } set { _realEstateBrokerSNMLSID = value; } }
        private Value<string> _realEstateBrokerSPhone;
        public string RealEstateBrokerSPhone { get { return _realEstateBrokerSPhone; } set { _realEstateBrokerSPhone = value; } }
        private Value<string> _realEstateBrokerSState;
        public string RealEstateBrokerSState { get { return _realEstateBrokerSState; } set { _realEstateBrokerSState = value; } }
        private Value<string> _realEstateBrokerSSTLicenseID;
        public string RealEstateBrokerSSTLicenseID { get { return _realEstateBrokerSSTLicenseID; } set { _realEstateBrokerSSTLicenseID = value; } }
        private Value<string> _realEstateBrokerSZip;
        public string RealEstateBrokerSZip { get { return _realEstateBrokerSZip; } set { _realEstateBrokerSZip = value; } }
        private Value<string> _settlementAgentAddress;
        public string SettlementAgentAddress { get { return _settlementAgentAddress; } set { _settlementAgentAddress = value; } }
        private Value<string> _settlementAgentCity;
        public string SettlementAgentCity { get { return _settlementAgentCity; } set { _settlementAgentCity = value; } }
        private Value<string> _settlementAgentContact;
        public string SettlementAgentContact { get { return _settlementAgentContact; } set { _settlementAgentContact = value; } }
        private Value<string> _settlementAgentContactATLicenseID;
        public string SettlementAgentContactATLicenseID { get { return _settlementAgentContactATLicenseID; } set { _settlementAgentContactATLicenseID = value; } }
        private Value<string> _settlementAgentContactNMLSID;
        public string SettlementAgentContactNMLSID { get { return _settlementAgentContactNMLSID; } set { _settlementAgentContactNMLSID = value; } }
        private Value<string> _settlementAgentEmail;
        public string SettlementAgentEmail { get { return _settlementAgentEmail; } set { _settlementAgentEmail = value; } }
        private Value<string> _settlementAgentName;
        public string SettlementAgentName { get { return _settlementAgentName; } set { _settlementAgentName = value; } }
        private Value<string> _settlementAgentNMLSID;
        public string SettlementAgentNMLSID { get { return _settlementAgentNMLSID; } set { _settlementAgentNMLSID = value; } }
        private Value<string> _settlementAgentPhone;
        public string SettlementAgentPhone { get { return _settlementAgentPhone; } set { _settlementAgentPhone = value; } }
        private Value<string> _settlementAgentState;
        public string SettlementAgentState { get { return _settlementAgentState; } set { _settlementAgentState = value; } }
        private Value<string> _settlementAgentSTLicenseID;
        public string SettlementAgentSTLicenseID { get { return _settlementAgentSTLicenseID; } set { _settlementAgentSTLicenseID = value; } }
        private Value<string> _settlementAgentZip;
        public string SettlementAgentZip { get { return _settlementAgentZip; } set { _settlementAgentZip = value; } }
        private Value<string> _signatureType;
        public string SignatureType { get { return _signatureType; } set { _signatureType = value; } }
        private Value<decimal?> _totalPayments;
        public decimal? TotalPayments { get { return _totalPayments; } set { _totalPayments = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _cDLiabilityAfterForeclosure.Dirty
                    || _id.Dirty
                    || _lenderAddress.Dirty
                    || _lenderCity.Dirty
                    || _lenderContact.Dirty
                    || _lenderContactATLicenseID.Dirty
                    || _lenderContactNMLSID.Dirty
                    || _lenderEmail.Dirty
                    || _lenderName.Dirty
                    || _lenderNMLSID.Dirty
                    || _lenderPhone.Dirty
                    || _lenderState.Dirty
                    || _lenderSTLicenseID.Dirty
                    || _lenderZip.Dirty
                    || _mortgageBrokerAddress.Dirty
                    || _mortgageBrokerCity.Dirty
                    || _mortgageBrokerContact.Dirty
                    || _mortgageBrokerContactATLicenseID.Dirty
                    || _mortgageBrokerContactNMLSID.Dirty
                    || _mortgageBrokerEmail.Dirty
                    || _mortgageBrokerName.Dirty
                    || _mortgageBrokerNMLSID.Dirty
                    || _mortgageBrokerPhone.Dirty
                    || _mortgageBrokerState.Dirty
                    || _mortgageBrokerSTLicenseID.Dirty
                    || _mortgageBrokerZip.Dirty
                    || _realEstateBrokerBAddress.Dirty
                    || _realEstateBrokerBCity.Dirty
                    || _realEstateBrokerBContact.Dirty
                    || _realEstateBrokerBContactATLicenseID.Dirty
                    || _realEstateBrokerBContactNMLSID.Dirty
                    || _realEstateBrokerBEmail.Dirty
                    || _realEstateBrokerBName.Dirty
                    || _realEstateBrokerBNMLSID.Dirty
                    || _realEstateBrokerBPhone.Dirty
                    || _realEstateBrokerBState.Dirty
                    || _realEstateBrokerBSTLicenseID.Dirty
                    || _realEstateBrokerBZip.Dirty
                    || _realEstateBrokerSAddress.Dirty
                    || _realEstateBrokerSCity.Dirty
                    || _realEstateBrokerSContact.Dirty
                    || _realEstateBrokerSContactATLicenseID.Dirty
                    || _realEstateBrokerSContactNMLSID.Dirty
                    || _realEstateBrokerSEmail.Dirty
                    || _realEstateBrokerSName.Dirty
                    || _realEstateBrokerSNMLSID.Dirty
                    || _realEstateBrokerSPhone.Dirty
                    || _realEstateBrokerSState.Dirty
                    || _realEstateBrokerSSTLicenseID.Dirty
                    || _realEstateBrokerSZip.Dirty
                    || _settlementAgentAddress.Dirty
                    || _settlementAgentCity.Dirty
                    || _settlementAgentContact.Dirty
                    || _settlementAgentContactATLicenseID.Dirty
                    || _settlementAgentContactNMLSID.Dirty
                    || _settlementAgentEmail.Dirty
                    || _settlementAgentName.Dirty
                    || _settlementAgentNMLSID.Dirty
                    || _settlementAgentPhone.Dirty
                    || _settlementAgentState.Dirty
                    || _settlementAgentSTLicenseID.Dirty
                    || _settlementAgentZip.Dirty
                    || _signatureType.Dirty
                    || _totalPayments.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _cDLiabilityAfterForeclosure.Dirty = value;
                _id.Dirty = value;
                _lenderAddress.Dirty = value;
                _lenderCity.Dirty = value;
                _lenderContact.Dirty = value;
                _lenderContactATLicenseID.Dirty = value;
                _lenderContactNMLSID.Dirty = value;
                _lenderEmail.Dirty = value;
                _lenderName.Dirty = value;
                _lenderNMLSID.Dirty = value;
                _lenderPhone.Dirty = value;
                _lenderState.Dirty = value;
                _lenderSTLicenseID.Dirty = value;
                _lenderZip.Dirty = value;
                _mortgageBrokerAddress.Dirty = value;
                _mortgageBrokerCity.Dirty = value;
                _mortgageBrokerContact.Dirty = value;
                _mortgageBrokerContactATLicenseID.Dirty = value;
                _mortgageBrokerContactNMLSID.Dirty = value;
                _mortgageBrokerEmail.Dirty = value;
                _mortgageBrokerName.Dirty = value;
                _mortgageBrokerNMLSID.Dirty = value;
                _mortgageBrokerPhone.Dirty = value;
                _mortgageBrokerState.Dirty = value;
                _mortgageBrokerSTLicenseID.Dirty = value;
                _mortgageBrokerZip.Dirty = value;
                _realEstateBrokerBAddress.Dirty = value;
                _realEstateBrokerBCity.Dirty = value;
                _realEstateBrokerBContact.Dirty = value;
                _realEstateBrokerBContactATLicenseID.Dirty = value;
                _realEstateBrokerBContactNMLSID.Dirty = value;
                _realEstateBrokerBEmail.Dirty = value;
                _realEstateBrokerBName.Dirty = value;
                _realEstateBrokerBNMLSID.Dirty = value;
                _realEstateBrokerBPhone.Dirty = value;
                _realEstateBrokerBState.Dirty = value;
                _realEstateBrokerBSTLicenseID.Dirty = value;
                _realEstateBrokerBZip.Dirty = value;
                _realEstateBrokerSAddress.Dirty = value;
                _realEstateBrokerSCity.Dirty = value;
                _realEstateBrokerSContact.Dirty = value;
                _realEstateBrokerSContactATLicenseID.Dirty = value;
                _realEstateBrokerSContactNMLSID.Dirty = value;
                _realEstateBrokerSEmail.Dirty = value;
                _realEstateBrokerSName.Dirty = value;
                _realEstateBrokerSNMLSID.Dirty = value;
                _realEstateBrokerSPhone.Dirty = value;
                _realEstateBrokerSState.Dirty = value;
                _realEstateBrokerSSTLicenseID.Dirty = value;
                _realEstateBrokerSZip.Dirty = value;
                _settlementAgentAddress.Dirty = value;
                _settlementAgentCity.Dirty = value;
                _settlementAgentContact.Dirty = value;
                _settlementAgentContactATLicenseID.Dirty = value;
                _settlementAgentContactNMLSID.Dirty = value;
                _settlementAgentEmail.Dirty = value;
                _settlementAgentName.Dirty = value;
                _settlementAgentNMLSID.Dirty = value;
                _settlementAgentPhone.Dirty = value;
                _settlementAgentState.Dirty = value;
                _settlementAgentSTLicenseID.Dirty = value;
                _settlementAgentZip.Dirty = value;
                _signatureType.Dirty = value;
                _totalPayments.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}