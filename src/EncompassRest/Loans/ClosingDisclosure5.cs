using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure5 : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _cDLiabilityAfterForeclosure.Clean
                    && _id.Clean
                    && _lenderAddress.Clean
                    && _lenderCity.Clean
                    && _lenderContact.Clean
                    && _lenderContactATLicenseID.Clean
                    && _lenderContactNMLSID.Clean
                    && _lenderEmail.Clean
                    && _lenderName.Clean
                    && _lenderNMLSID.Clean
                    && _lenderPhone.Clean
                    && _lenderState.Clean
                    && _lenderSTLicenseID.Clean
                    && _lenderZip.Clean
                    && _mortgageBrokerAddress.Clean
                    && _mortgageBrokerCity.Clean
                    && _mortgageBrokerContact.Clean
                    && _mortgageBrokerContactATLicenseID.Clean
                    && _mortgageBrokerContactNMLSID.Clean
                    && _mortgageBrokerEmail.Clean
                    && _mortgageBrokerName.Clean
                    && _mortgageBrokerNMLSID.Clean
                    && _mortgageBrokerPhone.Clean
                    && _mortgageBrokerState.Clean
                    && _mortgageBrokerSTLicenseID.Clean
                    && _mortgageBrokerZip.Clean
                    && _realEstateBrokerBAddress.Clean
                    && _realEstateBrokerBCity.Clean
                    && _realEstateBrokerBContact.Clean
                    && _realEstateBrokerBContactATLicenseID.Clean
                    && _realEstateBrokerBContactNMLSID.Clean
                    && _realEstateBrokerBEmail.Clean
                    && _realEstateBrokerBName.Clean
                    && _realEstateBrokerBNMLSID.Clean
                    && _realEstateBrokerBPhone.Clean
                    && _realEstateBrokerBState.Clean
                    && _realEstateBrokerBSTLicenseID.Clean
                    && _realEstateBrokerBZip.Clean
                    && _realEstateBrokerSAddress.Clean
                    && _realEstateBrokerSCity.Clean
                    && _realEstateBrokerSContact.Clean
                    && _realEstateBrokerSContactATLicenseID.Clean
                    && _realEstateBrokerSContactNMLSID.Clean
                    && _realEstateBrokerSEmail.Clean
                    && _realEstateBrokerSName.Clean
                    && _realEstateBrokerSNMLSID.Clean
                    && _realEstateBrokerSPhone.Clean
                    && _realEstateBrokerSState.Clean
                    && _realEstateBrokerSSTLicenseID.Clean
                    && _realEstateBrokerSZip.Clean
                    && _settlementAgentAddress.Clean
                    && _settlementAgentCity.Clean
                    && _settlementAgentContact.Clean
                    && _settlementAgentContactATLicenseID.Clean
                    && _settlementAgentContactNMLSID.Clean
                    && _settlementAgentEmail.Clean
                    && _settlementAgentName.Clean
                    && _settlementAgentNMLSID.Clean
                    && _settlementAgentPhone.Clean
                    && _settlementAgentState.Clean
                    && _settlementAgentSTLicenseID.Clean
                    && _settlementAgentZip.Clean
                    && _signatureType.Clean
                    && _totalPayments.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var cDLiabilityAfterForeclosure = _cDLiabilityAfterForeclosure; cDLiabilityAfterForeclosure.Clean = value; _cDLiabilityAfterForeclosure = cDLiabilityAfterForeclosure;
                var id = _id; id.Clean = value; _id = id;
                var lenderAddress = _lenderAddress; lenderAddress.Clean = value; _lenderAddress = lenderAddress;
                var lenderCity = _lenderCity; lenderCity.Clean = value; _lenderCity = lenderCity;
                var lenderContact = _lenderContact; lenderContact.Clean = value; _lenderContact = lenderContact;
                var lenderContactATLicenseID = _lenderContactATLicenseID; lenderContactATLicenseID.Clean = value; _lenderContactATLicenseID = lenderContactATLicenseID;
                var lenderContactNMLSID = _lenderContactNMLSID; lenderContactNMLSID.Clean = value; _lenderContactNMLSID = lenderContactNMLSID;
                var lenderEmail = _lenderEmail; lenderEmail.Clean = value; _lenderEmail = lenderEmail;
                var lenderName = _lenderName; lenderName.Clean = value; _lenderName = lenderName;
                var lenderNMLSID = _lenderNMLSID; lenderNMLSID.Clean = value; _lenderNMLSID = lenderNMLSID;
                var lenderPhone = _lenderPhone; lenderPhone.Clean = value; _lenderPhone = lenderPhone;
                var lenderState = _lenderState; lenderState.Clean = value; _lenderState = lenderState;
                var lenderSTLicenseID = _lenderSTLicenseID; lenderSTLicenseID.Clean = value; _lenderSTLicenseID = lenderSTLicenseID;
                var lenderZip = _lenderZip; lenderZip.Clean = value; _lenderZip = lenderZip;
                var mortgageBrokerAddress = _mortgageBrokerAddress; mortgageBrokerAddress.Clean = value; _mortgageBrokerAddress = mortgageBrokerAddress;
                var mortgageBrokerCity = _mortgageBrokerCity; mortgageBrokerCity.Clean = value; _mortgageBrokerCity = mortgageBrokerCity;
                var mortgageBrokerContact = _mortgageBrokerContact; mortgageBrokerContact.Clean = value; _mortgageBrokerContact = mortgageBrokerContact;
                var mortgageBrokerContactATLicenseID = _mortgageBrokerContactATLicenseID; mortgageBrokerContactATLicenseID.Clean = value; _mortgageBrokerContactATLicenseID = mortgageBrokerContactATLicenseID;
                var mortgageBrokerContactNMLSID = _mortgageBrokerContactNMLSID; mortgageBrokerContactNMLSID.Clean = value; _mortgageBrokerContactNMLSID = mortgageBrokerContactNMLSID;
                var mortgageBrokerEmail = _mortgageBrokerEmail; mortgageBrokerEmail.Clean = value; _mortgageBrokerEmail = mortgageBrokerEmail;
                var mortgageBrokerName = _mortgageBrokerName; mortgageBrokerName.Clean = value; _mortgageBrokerName = mortgageBrokerName;
                var mortgageBrokerNMLSID = _mortgageBrokerNMLSID; mortgageBrokerNMLSID.Clean = value; _mortgageBrokerNMLSID = mortgageBrokerNMLSID;
                var mortgageBrokerPhone = _mortgageBrokerPhone; mortgageBrokerPhone.Clean = value; _mortgageBrokerPhone = mortgageBrokerPhone;
                var mortgageBrokerState = _mortgageBrokerState; mortgageBrokerState.Clean = value; _mortgageBrokerState = mortgageBrokerState;
                var mortgageBrokerSTLicenseID = _mortgageBrokerSTLicenseID; mortgageBrokerSTLicenseID.Clean = value; _mortgageBrokerSTLicenseID = mortgageBrokerSTLicenseID;
                var mortgageBrokerZip = _mortgageBrokerZip; mortgageBrokerZip.Clean = value; _mortgageBrokerZip = mortgageBrokerZip;
                var realEstateBrokerBAddress = _realEstateBrokerBAddress; realEstateBrokerBAddress.Clean = value; _realEstateBrokerBAddress = realEstateBrokerBAddress;
                var realEstateBrokerBCity = _realEstateBrokerBCity; realEstateBrokerBCity.Clean = value; _realEstateBrokerBCity = realEstateBrokerBCity;
                var realEstateBrokerBContact = _realEstateBrokerBContact; realEstateBrokerBContact.Clean = value; _realEstateBrokerBContact = realEstateBrokerBContact;
                var realEstateBrokerBContactATLicenseID = _realEstateBrokerBContactATLicenseID; realEstateBrokerBContactATLicenseID.Clean = value; _realEstateBrokerBContactATLicenseID = realEstateBrokerBContactATLicenseID;
                var realEstateBrokerBContactNMLSID = _realEstateBrokerBContactNMLSID; realEstateBrokerBContactNMLSID.Clean = value; _realEstateBrokerBContactNMLSID = realEstateBrokerBContactNMLSID;
                var realEstateBrokerBEmail = _realEstateBrokerBEmail; realEstateBrokerBEmail.Clean = value; _realEstateBrokerBEmail = realEstateBrokerBEmail;
                var realEstateBrokerBName = _realEstateBrokerBName; realEstateBrokerBName.Clean = value; _realEstateBrokerBName = realEstateBrokerBName;
                var realEstateBrokerBNMLSID = _realEstateBrokerBNMLSID; realEstateBrokerBNMLSID.Clean = value; _realEstateBrokerBNMLSID = realEstateBrokerBNMLSID;
                var realEstateBrokerBPhone = _realEstateBrokerBPhone; realEstateBrokerBPhone.Clean = value; _realEstateBrokerBPhone = realEstateBrokerBPhone;
                var realEstateBrokerBState = _realEstateBrokerBState; realEstateBrokerBState.Clean = value; _realEstateBrokerBState = realEstateBrokerBState;
                var realEstateBrokerBSTLicenseID = _realEstateBrokerBSTLicenseID; realEstateBrokerBSTLicenseID.Clean = value; _realEstateBrokerBSTLicenseID = realEstateBrokerBSTLicenseID;
                var realEstateBrokerBZip = _realEstateBrokerBZip; realEstateBrokerBZip.Clean = value; _realEstateBrokerBZip = realEstateBrokerBZip;
                var realEstateBrokerSAddress = _realEstateBrokerSAddress; realEstateBrokerSAddress.Clean = value; _realEstateBrokerSAddress = realEstateBrokerSAddress;
                var realEstateBrokerSCity = _realEstateBrokerSCity; realEstateBrokerSCity.Clean = value; _realEstateBrokerSCity = realEstateBrokerSCity;
                var realEstateBrokerSContact = _realEstateBrokerSContact; realEstateBrokerSContact.Clean = value; _realEstateBrokerSContact = realEstateBrokerSContact;
                var realEstateBrokerSContactATLicenseID = _realEstateBrokerSContactATLicenseID; realEstateBrokerSContactATLicenseID.Clean = value; _realEstateBrokerSContactATLicenseID = realEstateBrokerSContactATLicenseID;
                var realEstateBrokerSContactNMLSID = _realEstateBrokerSContactNMLSID; realEstateBrokerSContactNMLSID.Clean = value; _realEstateBrokerSContactNMLSID = realEstateBrokerSContactNMLSID;
                var realEstateBrokerSEmail = _realEstateBrokerSEmail; realEstateBrokerSEmail.Clean = value; _realEstateBrokerSEmail = realEstateBrokerSEmail;
                var realEstateBrokerSName = _realEstateBrokerSName; realEstateBrokerSName.Clean = value; _realEstateBrokerSName = realEstateBrokerSName;
                var realEstateBrokerSNMLSID = _realEstateBrokerSNMLSID; realEstateBrokerSNMLSID.Clean = value; _realEstateBrokerSNMLSID = realEstateBrokerSNMLSID;
                var realEstateBrokerSPhone = _realEstateBrokerSPhone; realEstateBrokerSPhone.Clean = value; _realEstateBrokerSPhone = realEstateBrokerSPhone;
                var realEstateBrokerSState = _realEstateBrokerSState; realEstateBrokerSState.Clean = value; _realEstateBrokerSState = realEstateBrokerSState;
                var realEstateBrokerSSTLicenseID = _realEstateBrokerSSTLicenseID; realEstateBrokerSSTLicenseID.Clean = value; _realEstateBrokerSSTLicenseID = realEstateBrokerSSTLicenseID;
                var realEstateBrokerSZip = _realEstateBrokerSZip; realEstateBrokerSZip.Clean = value; _realEstateBrokerSZip = realEstateBrokerSZip;
                var settlementAgentAddress = _settlementAgentAddress; settlementAgentAddress.Clean = value; _settlementAgentAddress = settlementAgentAddress;
                var settlementAgentCity = _settlementAgentCity; settlementAgentCity.Clean = value; _settlementAgentCity = settlementAgentCity;
                var settlementAgentContact = _settlementAgentContact; settlementAgentContact.Clean = value; _settlementAgentContact = settlementAgentContact;
                var settlementAgentContactATLicenseID = _settlementAgentContactATLicenseID; settlementAgentContactATLicenseID.Clean = value; _settlementAgentContactATLicenseID = settlementAgentContactATLicenseID;
                var settlementAgentContactNMLSID = _settlementAgentContactNMLSID; settlementAgentContactNMLSID.Clean = value; _settlementAgentContactNMLSID = settlementAgentContactNMLSID;
                var settlementAgentEmail = _settlementAgentEmail; settlementAgentEmail.Clean = value; _settlementAgentEmail = settlementAgentEmail;
                var settlementAgentName = _settlementAgentName; settlementAgentName.Clean = value; _settlementAgentName = settlementAgentName;
                var settlementAgentNMLSID = _settlementAgentNMLSID; settlementAgentNMLSID.Clean = value; _settlementAgentNMLSID = settlementAgentNMLSID;
                var settlementAgentPhone = _settlementAgentPhone; settlementAgentPhone.Clean = value; _settlementAgentPhone = settlementAgentPhone;
                var settlementAgentState = _settlementAgentState; settlementAgentState.Clean = value; _settlementAgentState = settlementAgentState;
                var settlementAgentSTLicenseID = _settlementAgentSTLicenseID; settlementAgentSTLicenseID.Clean = value; _settlementAgentSTLicenseID = settlementAgentSTLicenseID;
                var settlementAgentZip = _settlementAgentZip; settlementAgentZip.Clean = value; _settlementAgentZip = settlementAgentZip;
                var signatureType = _signatureType; signatureType.Clean = value; _signatureType = signatureType;
                var totalPayments = _totalPayments; totalPayments.Clean = value; _totalPayments = totalPayments;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDisclosure5()
        {
            Clean = true;
        }
    }
}