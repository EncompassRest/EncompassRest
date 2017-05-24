using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure5
    {
        public Value<string> CDLiabilityAfterForeclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDLiabilityAfterForeclosure() => !CDLiabilityAfterForeclosure.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LenderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddress() => !LenderAddress.Clean;
        public Value<string> LenderCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCity() => !LenderCity.Clean;
        public Value<string> LenderContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderContact() => !LenderContact.Clean;
        public Value<string> LenderContactATLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderContactATLicenseID() => !LenderContactATLicenseID.Clean;
        public Value<string> LenderContactNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderContactNMLSID() => !LenderContactNMLSID.Clean;
        public Value<string> LenderEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderEmail() => !LenderEmail.Clean;
        public Value<string> LenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderName() => !LenderName.Clean;
        public Value<string> LenderNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNMLSID() => !LenderNMLSID.Clean;
        public Value<string> LenderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPhone() => !LenderPhone.Clean;
        public Value<string> LenderState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderState() => !LenderState.Clean;
        public Value<string> LenderSTLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderSTLicenseID() => !LenderSTLicenseID.Clean;
        public Value<string> LenderZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderZip() => !LenderZip.Clean;
        public Value<string> MortgageBrokerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerAddress() => !MortgageBrokerAddress.Clean;
        public Value<string> MortgageBrokerCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerCity() => !MortgageBrokerCity.Clean;
        public Value<string> MortgageBrokerContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerContact() => !MortgageBrokerContact.Clean;
        public Value<string> MortgageBrokerContactATLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerContactATLicenseID() => !MortgageBrokerContactATLicenseID.Clean;
        public Value<string> MortgageBrokerContactNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerContactNMLSID() => !MortgageBrokerContactNMLSID.Clean;
        public Value<string> MortgageBrokerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerEmail() => !MortgageBrokerEmail.Clean;
        public Value<string> MortgageBrokerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerName() => !MortgageBrokerName.Clean;
        public Value<string> MortgageBrokerNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerNMLSID() => !MortgageBrokerNMLSID.Clean;
        public Value<string> MortgageBrokerPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerPhone() => !MortgageBrokerPhone.Clean;
        public Value<string> MortgageBrokerState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerState() => !MortgageBrokerState.Clean;
        public Value<string> MortgageBrokerSTLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerSTLicenseID() => !MortgageBrokerSTLicenseID.Clean;
        public Value<string> MortgageBrokerZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerZip() => !MortgageBrokerZip.Clean;
        public Value<string> RealEstateBrokerBAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBAddress() => !RealEstateBrokerBAddress.Clean;
        public Value<string> RealEstateBrokerBCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBCity() => !RealEstateBrokerBCity.Clean;
        public Value<string> RealEstateBrokerBContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBContact() => !RealEstateBrokerBContact.Clean;
        public Value<string> RealEstateBrokerBContactATLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBContactATLicenseID() => !RealEstateBrokerBContactATLicenseID.Clean;
        public Value<string> RealEstateBrokerBContactNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBContactNMLSID() => !RealEstateBrokerBContactNMLSID.Clean;
        public Value<string> RealEstateBrokerBEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBEmail() => !RealEstateBrokerBEmail.Clean;
        public Value<string> RealEstateBrokerBName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBName() => !RealEstateBrokerBName.Clean;
        public Value<string> RealEstateBrokerBNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBNMLSID() => !RealEstateBrokerBNMLSID.Clean;
        public Value<string> RealEstateBrokerBPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBPhone() => !RealEstateBrokerBPhone.Clean;
        public Value<string> RealEstateBrokerBState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBState() => !RealEstateBrokerBState.Clean;
        public Value<string> RealEstateBrokerBSTLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBSTLicenseID() => !RealEstateBrokerBSTLicenseID.Clean;
        public Value<string> RealEstateBrokerBZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerBZip() => !RealEstateBrokerBZip.Clean;
        public Value<string> RealEstateBrokerSAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSAddress() => !RealEstateBrokerSAddress.Clean;
        public Value<string> RealEstateBrokerSCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSCity() => !RealEstateBrokerSCity.Clean;
        public Value<string> RealEstateBrokerSContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSContact() => !RealEstateBrokerSContact.Clean;
        public Value<string> RealEstateBrokerSContactATLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSContactATLicenseID() => !RealEstateBrokerSContactATLicenseID.Clean;
        public Value<string> RealEstateBrokerSContactNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSContactNMLSID() => !RealEstateBrokerSContactNMLSID.Clean;
        public Value<string> RealEstateBrokerSEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSEmail() => !RealEstateBrokerSEmail.Clean;
        public Value<string> RealEstateBrokerSName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSName() => !RealEstateBrokerSName.Clean;
        public Value<string> RealEstateBrokerSNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSNMLSID() => !RealEstateBrokerSNMLSID.Clean;
        public Value<string> RealEstateBrokerSPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSPhone() => !RealEstateBrokerSPhone.Clean;
        public Value<string> RealEstateBrokerSState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSState() => !RealEstateBrokerSState.Clean;
        public Value<string> RealEstateBrokerSSTLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSSTLicenseID() => !RealEstateBrokerSSTLicenseID.Clean;
        public Value<string> RealEstateBrokerSZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateBrokerSZip() => !RealEstateBrokerSZip.Clean;
        public Value<string> SettlementAgentAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentAddress() => !SettlementAgentAddress.Clean;
        public Value<string> SettlementAgentCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentCity() => !SettlementAgentCity.Clean;
        public Value<string> SettlementAgentContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentContact() => !SettlementAgentContact.Clean;
        public Value<string> SettlementAgentContactATLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentContactATLicenseID() => !SettlementAgentContactATLicenseID.Clean;
        public Value<string> SettlementAgentContactNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentContactNMLSID() => !SettlementAgentContactNMLSID.Clean;
        public Value<string> SettlementAgentEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentEmail() => !SettlementAgentEmail.Clean;
        public Value<string> SettlementAgentName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentName() => !SettlementAgentName.Clean;
        public Value<string> SettlementAgentNMLSID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentNMLSID() => !SettlementAgentNMLSID.Clean;
        public Value<string> SettlementAgentPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentPhone() => !SettlementAgentPhone.Clean;
        public Value<string> SettlementAgentState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentState() => !SettlementAgentState.Clean;
        public Value<string> SettlementAgentSTLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentSTLicenseID() => !SettlementAgentSTLicenseID.Clean;
        public Value<string> SettlementAgentZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgentZip() => !SettlementAgentZip.Clean;
        public Value<string> SignatureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureType() => !SignatureType.Clean;
        public Value<decimal?> TotalPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPayments() => !TotalPayments.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CDLiabilityAfterForeclosure.Clean
                    && Id.Clean
                    && LenderAddress.Clean
                    && LenderCity.Clean
                    && LenderContact.Clean
                    && LenderContactATLicenseID.Clean
                    && LenderContactNMLSID.Clean
                    && LenderEmail.Clean
                    && LenderName.Clean
                    && LenderNMLSID.Clean
                    && LenderPhone.Clean
                    && LenderState.Clean
                    && LenderSTLicenseID.Clean
                    && LenderZip.Clean
                    && MortgageBrokerAddress.Clean
                    && MortgageBrokerCity.Clean
                    && MortgageBrokerContact.Clean
                    && MortgageBrokerContactATLicenseID.Clean
                    && MortgageBrokerContactNMLSID.Clean
                    && MortgageBrokerEmail.Clean
                    && MortgageBrokerName.Clean
                    && MortgageBrokerNMLSID.Clean
                    && MortgageBrokerPhone.Clean
                    && MortgageBrokerState.Clean
                    && MortgageBrokerSTLicenseID.Clean
                    && MortgageBrokerZip.Clean
                    && RealEstateBrokerBAddress.Clean
                    && RealEstateBrokerBCity.Clean
                    && RealEstateBrokerBContact.Clean
                    && RealEstateBrokerBContactATLicenseID.Clean
                    && RealEstateBrokerBContactNMLSID.Clean
                    && RealEstateBrokerBEmail.Clean
                    && RealEstateBrokerBName.Clean
                    && RealEstateBrokerBNMLSID.Clean
                    && RealEstateBrokerBPhone.Clean
                    && RealEstateBrokerBState.Clean
                    && RealEstateBrokerBSTLicenseID.Clean
                    && RealEstateBrokerBZip.Clean
                    && RealEstateBrokerSAddress.Clean
                    && RealEstateBrokerSCity.Clean
                    && RealEstateBrokerSContact.Clean
                    && RealEstateBrokerSContactATLicenseID.Clean
                    && RealEstateBrokerSContactNMLSID.Clean
                    && RealEstateBrokerSEmail.Clean
                    && RealEstateBrokerSName.Clean
                    && RealEstateBrokerSNMLSID.Clean
                    && RealEstateBrokerSPhone.Clean
                    && RealEstateBrokerSState.Clean
                    && RealEstateBrokerSSTLicenseID.Clean
                    && RealEstateBrokerSZip.Clean
                    && SettlementAgentAddress.Clean
                    && SettlementAgentCity.Clean
                    && SettlementAgentContact.Clean
                    && SettlementAgentContactATLicenseID.Clean
                    && SettlementAgentContactNMLSID.Clean
                    && SettlementAgentEmail.Clean
                    && SettlementAgentName.Clean
                    && SettlementAgentNMLSID.Clean
                    && SettlementAgentPhone.Clean
                    && SettlementAgentState.Clean
                    && SettlementAgentSTLicenseID.Clean
                    && SettlementAgentZip.Clean
                    && SignatureType.Clean
                    && TotalPayments.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CDLiabilityAfterForeclosure; v0.Clean = value; CDLiabilityAfterForeclosure = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = LenderAddress; v2.Clean = value; LenderAddress = v2;
                var v3 = LenderCity; v3.Clean = value; LenderCity = v3;
                var v4 = LenderContact; v4.Clean = value; LenderContact = v4;
                var v5 = LenderContactATLicenseID; v5.Clean = value; LenderContactATLicenseID = v5;
                var v6 = LenderContactNMLSID; v6.Clean = value; LenderContactNMLSID = v6;
                var v7 = LenderEmail; v7.Clean = value; LenderEmail = v7;
                var v8 = LenderName; v8.Clean = value; LenderName = v8;
                var v9 = LenderNMLSID; v9.Clean = value; LenderNMLSID = v9;
                var v10 = LenderPhone; v10.Clean = value; LenderPhone = v10;
                var v11 = LenderState; v11.Clean = value; LenderState = v11;
                var v12 = LenderSTLicenseID; v12.Clean = value; LenderSTLicenseID = v12;
                var v13 = LenderZip; v13.Clean = value; LenderZip = v13;
                var v14 = MortgageBrokerAddress; v14.Clean = value; MortgageBrokerAddress = v14;
                var v15 = MortgageBrokerCity; v15.Clean = value; MortgageBrokerCity = v15;
                var v16 = MortgageBrokerContact; v16.Clean = value; MortgageBrokerContact = v16;
                var v17 = MortgageBrokerContactATLicenseID; v17.Clean = value; MortgageBrokerContactATLicenseID = v17;
                var v18 = MortgageBrokerContactNMLSID; v18.Clean = value; MortgageBrokerContactNMLSID = v18;
                var v19 = MortgageBrokerEmail; v19.Clean = value; MortgageBrokerEmail = v19;
                var v20 = MortgageBrokerName; v20.Clean = value; MortgageBrokerName = v20;
                var v21 = MortgageBrokerNMLSID; v21.Clean = value; MortgageBrokerNMLSID = v21;
                var v22 = MortgageBrokerPhone; v22.Clean = value; MortgageBrokerPhone = v22;
                var v23 = MortgageBrokerState; v23.Clean = value; MortgageBrokerState = v23;
                var v24 = MortgageBrokerSTLicenseID; v24.Clean = value; MortgageBrokerSTLicenseID = v24;
                var v25 = MortgageBrokerZip; v25.Clean = value; MortgageBrokerZip = v25;
                var v26 = RealEstateBrokerBAddress; v26.Clean = value; RealEstateBrokerBAddress = v26;
                var v27 = RealEstateBrokerBCity; v27.Clean = value; RealEstateBrokerBCity = v27;
                var v28 = RealEstateBrokerBContact; v28.Clean = value; RealEstateBrokerBContact = v28;
                var v29 = RealEstateBrokerBContactATLicenseID; v29.Clean = value; RealEstateBrokerBContactATLicenseID = v29;
                var v30 = RealEstateBrokerBContactNMLSID; v30.Clean = value; RealEstateBrokerBContactNMLSID = v30;
                var v31 = RealEstateBrokerBEmail; v31.Clean = value; RealEstateBrokerBEmail = v31;
                var v32 = RealEstateBrokerBName; v32.Clean = value; RealEstateBrokerBName = v32;
                var v33 = RealEstateBrokerBNMLSID; v33.Clean = value; RealEstateBrokerBNMLSID = v33;
                var v34 = RealEstateBrokerBPhone; v34.Clean = value; RealEstateBrokerBPhone = v34;
                var v35 = RealEstateBrokerBState; v35.Clean = value; RealEstateBrokerBState = v35;
                var v36 = RealEstateBrokerBSTLicenseID; v36.Clean = value; RealEstateBrokerBSTLicenseID = v36;
                var v37 = RealEstateBrokerBZip; v37.Clean = value; RealEstateBrokerBZip = v37;
                var v38 = RealEstateBrokerSAddress; v38.Clean = value; RealEstateBrokerSAddress = v38;
                var v39 = RealEstateBrokerSCity; v39.Clean = value; RealEstateBrokerSCity = v39;
                var v40 = RealEstateBrokerSContact; v40.Clean = value; RealEstateBrokerSContact = v40;
                var v41 = RealEstateBrokerSContactATLicenseID; v41.Clean = value; RealEstateBrokerSContactATLicenseID = v41;
                var v42 = RealEstateBrokerSContactNMLSID; v42.Clean = value; RealEstateBrokerSContactNMLSID = v42;
                var v43 = RealEstateBrokerSEmail; v43.Clean = value; RealEstateBrokerSEmail = v43;
                var v44 = RealEstateBrokerSName; v44.Clean = value; RealEstateBrokerSName = v44;
                var v45 = RealEstateBrokerSNMLSID; v45.Clean = value; RealEstateBrokerSNMLSID = v45;
                var v46 = RealEstateBrokerSPhone; v46.Clean = value; RealEstateBrokerSPhone = v46;
                var v47 = RealEstateBrokerSState; v47.Clean = value; RealEstateBrokerSState = v47;
                var v48 = RealEstateBrokerSSTLicenseID; v48.Clean = value; RealEstateBrokerSSTLicenseID = v48;
                var v49 = RealEstateBrokerSZip; v49.Clean = value; RealEstateBrokerSZip = v49;
                var v50 = SettlementAgentAddress; v50.Clean = value; SettlementAgentAddress = v50;
                var v51 = SettlementAgentCity; v51.Clean = value; SettlementAgentCity = v51;
                var v52 = SettlementAgentContact; v52.Clean = value; SettlementAgentContact = v52;
                var v53 = SettlementAgentContactATLicenseID; v53.Clean = value; SettlementAgentContactATLicenseID = v53;
                var v54 = SettlementAgentContactNMLSID; v54.Clean = value; SettlementAgentContactNMLSID = v54;
                var v55 = SettlementAgentEmail; v55.Clean = value; SettlementAgentEmail = v55;
                var v56 = SettlementAgentName; v56.Clean = value; SettlementAgentName = v56;
                var v57 = SettlementAgentNMLSID; v57.Clean = value; SettlementAgentNMLSID = v57;
                var v58 = SettlementAgentPhone; v58.Clean = value; SettlementAgentPhone = v58;
                var v59 = SettlementAgentState; v59.Clean = value; SettlementAgentState = v59;
                var v60 = SettlementAgentSTLicenseID; v60.Clean = value; SettlementAgentSTLicenseID = v60;
                var v61 = SettlementAgentZip; v61.Clean = value; SettlementAgentZip = v61;
                var v62 = SignatureType; v62.Clean = value; SignatureType = v62;
                var v63 = TotalPayments; v63.Clean = value; TotalPayments = v63;
                _settingClean = 0;
            }
        }
    }
}