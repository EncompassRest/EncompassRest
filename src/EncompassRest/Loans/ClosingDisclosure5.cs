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
                var v0 = _cDLiabilityAfterForeclosure; v0.Clean = value; _cDLiabilityAfterForeclosure = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _lenderAddress; v2.Clean = value; _lenderAddress = v2;
                var v3 = _lenderCity; v3.Clean = value; _lenderCity = v3;
                var v4 = _lenderContact; v4.Clean = value; _lenderContact = v4;
                var v5 = _lenderContactATLicenseID; v5.Clean = value; _lenderContactATLicenseID = v5;
                var v6 = _lenderContactNMLSID; v6.Clean = value; _lenderContactNMLSID = v6;
                var v7 = _lenderEmail; v7.Clean = value; _lenderEmail = v7;
                var v8 = _lenderName; v8.Clean = value; _lenderName = v8;
                var v9 = _lenderNMLSID; v9.Clean = value; _lenderNMLSID = v9;
                var v10 = _lenderPhone; v10.Clean = value; _lenderPhone = v10;
                var v11 = _lenderState; v11.Clean = value; _lenderState = v11;
                var v12 = _lenderSTLicenseID; v12.Clean = value; _lenderSTLicenseID = v12;
                var v13 = _lenderZip; v13.Clean = value; _lenderZip = v13;
                var v14 = _mortgageBrokerAddress; v14.Clean = value; _mortgageBrokerAddress = v14;
                var v15 = _mortgageBrokerCity; v15.Clean = value; _mortgageBrokerCity = v15;
                var v16 = _mortgageBrokerContact; v16.Clean = value; _mortgageBrokerContact = v16;
                var v17 = _mortgageBrokerContactATLicenseID; v17.Clean = value; _mortgageBrokerContactATLicenseID = v17;
                var v18 = _mortgageBrokerContactNMLSID; v18.Clean = value; _mortgageBrokerContactNMLSID = v18;
                var v19 = _mortgageBrokerEmail; v19.Clean = value; _mortgageBrokerEmail = v19;
                var v20 = _mortgageBrokerName; v20.Clean = value; _mortgageBrokerName = v20;
                var v21 = _mortgageBrokerNMLSID; v21.Clean = value; _mortgageBrokerNMLSID = v21;
                var v22 = _mortgageBrokerPhone; v22.Clean = value; _mortgageBrokerPhone = v22;
                var v23 = _mortgageBrokerState; v23.Clean = value; _mortgageBrokerState = v23;
                var v24 = _mortgageBrokerSTLicenseID; v24.Clean = value; _mortgageBrokerSTLicenseID = v24;
                var v25 = _mortgageBrokerZip; v25.Clean = value; _mortgageBrokerZip = v25;
                var v26 = _realEstateBrokerBAddress; v26.Clean = value; _realEstateBrokerBAddress = v26;
                var v27 = _realEstateBrokerBCity; v27.Clean = value; _realEstateBrokerBCity = v27;
                var v28 = _realEstateBrokerBContact; v28.Clean = value; _realEstateBrokerBContact = v28;
                var v29 = _realEstateBrokerBContactATLicenseID; v29.Clean = value; _realEstateBrokerBContactATLicenseID = v29;
                var v30 = _realEstateBrokerBContactNMLSID; v30.Clean = value; _realEstateBrokerBContactNMLSID = v30;
                var v31 = _realEstateBrokerBEmail; v31.Clean = value; _realEstateBrokerBEmail = v31;
                var v32 = _realEstateBrokerBName; v32.Clean = value; _realEstateBrokerBName = v32;
                var v33 = _realEstateBrokerBNMLSID; v33.Clean = value; _realEstateBrokerBNMLSID = v33;
                var v34 = _realEstateBrokerBPhone; v34.Clean = value; _realEstateBrokerBPhone = v34;
                var v35 = _realEstateBrokerBState; v35.Clean = value; _realEstateBrokerBState = v35;
                var v36 = _realEstateBrokerBSTLicenseID; v36.Clean = value; _realEstateBrokerBSTLicenseID = v36;
                var v37 = _realEstateBrokerBZip; v37.Clean = value; _realEstateBrokerBZip = v37;
                var v38 = _realEstateBrokerSAddress; v38.Clean = value; _realEstateBrokerSAddress = v38;
                var v39 = _realEstateBrokerSCity; v39.Clean = value; _realEstateBrokerSCity = v39;
                var v40 = _realEstateBrokerSContact; v40.Clean = value; _realEstateBrokerSContact = v40;
                var v41 = _realEstateBrokerSContactATLicenseID; v41.Clean = value; _realEstateBrokerSContactATLicenseID = v41;
                var v42 = _realEstateBrokerSContactNMLSID; v42.Clean = value; _realEstateBrokerSContactNMLSID = v42;
                var v43 = _realEstateBrokerSEmail; v43.Clean = value; _realEstateBrokerSEmail = v43;
                var v44 = _realEstateBrokerSName; v44.Clean = value; _realEstateBrokerSName = v44;
                var v45 = _realEstateBrokerSNMLSID; v45.Clean = value; _realEstateBrokerSNMLSID = v45;
                var v46 = _realEstateBrokerSPhone; v46.Clean = value; _realEstateBrokerSPhone = v46;
                var v47 = _realEstateBrokerSState; v47.Clean = value; _realEstateBrokerSState = v47;
                var v48 = _realEstateBrokerSSTLicenseID; v48.Clean = value; _realEstateBrokerSSTLicenseID = v48;
                var v49 = _realEstateBrokerSZip; v49.Clean = value; _realEstateBrokerSZip = v49;
                var v50 = _settlementAgentAddress; v50.Clean = value; _settlementAgentAddress = v50;
                var v51 = _settlementAgentCity; v51.Clean = value; _settlementAgentCity = v51;
                var v52 = _settlementAgentContact; v52.Clean = value; _settlementAgentContact = v52;
                var v53 = _settlementAgentContactATLicenseID; v53.Clean = value; _settlementAgentContactATLicenseID = v53;
                var v54 = _settlementAgentContactNMLSID; v54.Clean = value; _settlementAgentContactNMLSID = v54;
                var v55 = _settlementAgentEmail; v55.Clean = value; _settlementAgentEmail = v55;
                var v56 = _settlementAgentName; v56.Clean = value; _settlementAgentName = v56;
                var v57 = _settlementAgentNMLSID; v57.Clean = value; _settlementAgentNMLSID = v57;
                var v58 = _settlementAgentPhone; v58.Clean = value; _settlementAgentPhone = v58;
                var v59 = _settlementAgentState; v59.Clean = value; _settlementAgentState = v59;
                var v60 = _settlementAgentSTLicenseID; v60.Clean = value; _settlementAgentSTLicenseID = v60;
                var v61 = _settlementAgentZip; v61.Clean = value; _settlementAgentZip = v61;
                var v62 = _signatureType; v62.Clean = value; _signatureType = v62;
                var v63 = _totalPayments; v63.Clean = value; _totalPayments = v63;
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