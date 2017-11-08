using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class EmDocumentInvestor : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _invAsgnCty;
        public string InvAsgnCty { get { return _invAsgnCty; } set { _invAsgnCty = value; } }
        private DirtyValue<string> _invAsgnJrsdctn;
        public string InvAsgnJrsdctn { get { return _invAsgnJrsdctn; } set { _invAsgnJrsdctn = value; } }
        private DirtyValue<string> _invAsgnNm;
        public string InvAsgnNm { get { return _invAsgnNm; } set { _invAsgnNm = value; } }
        private StringEnumValue<OrgTyp> _invAsgnOrgTyp;
        public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get { return _invAsgnOrgTyp; } set { _invAsgnOrgTyp = value; } }
        private DirtyValue<string> _invAsgnStCd;
        public string InvAsgnStCd { get { return _invAsgnStCd; } set { _invAsgnStCd = value; } }
        private DirtyValue<string> _invAsgnStreetAddr1;
        public string InvAsgnStreetAddr1 { get { return _invAsgnStreetAddr1; } set { _invAsgnStreetAddr1 = value; } }
        private DirtyValue<string> _invAsgnStreetAddr2;
        public string InvAsgnStreetAddr2 { get { return _invAsgnStreetAddr2; } set { _invAsgnStreetAddr2 = value; } }
        private DirtyValue<string> _invAsgnZip;
        public string InvAsgnZip { get { return _invAsgnZip; } set { _invAsgnZip = value; } }
        private DirtyValue<string> _invCty;
        public string InvCty { get { return _invCty; } set { _invCty = value; } }
        private DirtyValue<string> _invFaxNum;
        public string InvFaxNum { get { return _invFaxNum; } set { _invFaxNum = value; } }
        private DirtyValue<string> _invJrsdctn;
        public string InvJrsdctn { get { return _invJrsdctn; } set { _invJrsdctn = value; } }
        private DirtyValue<string> _invLossPayeeAdtlTxt;
        public string InvLossPayeeAdtlTxt { get { return _invLossPayeeAdtlTxt; } set { _invLossPayeeAdtlTxt = value; } }
        private DirtyValue<string> _invLossPayeeCntctEmail;
        public string InvLossPayeeCntctEmail { get { return _invLossPayeeCntctEmail; } set { _invLossPayeeCntctEmail = value; } }
        private DirtyValue<string> _invLossPayeeCntctFax;
        public string InvLossPayeeCntctFax { get { return _invLossPayeeCntctFax; } set { _invLossPayeeCntctFax = value; } }
        private DirtyValue<string> _invLossPayeeCntctNm;
        public string InvLossPayeeCntctNm { get { return _invLossPayeeCntctNm; } set { _invLossPayeeCntctNm = value; } }
        private DirtyValue<string> _invLossPayeeCntctPhone;
        public string InvLossPayeeCntctPhone { get { return _invLossPayeeCntctPhone; } set { _invLossPayeeCntctPhone = value; } }
        private DirtyValue<string> _invLossPayeeCty;
        public string InvLossPayeeCty { get { return _invLossPayeeCty; } set { _invLossPayeeCty = value; } }
        private DirtyValue<string> _invLossPayeeJrsdctn;
        public string InvLossPayeeJrsdctn { get { return _invLossPayeeJrsdctn; } set { _invLossPayeeJrsdctn = value; } }
        private DirtyValue<string> _invLossPayeeNm;
        public string InvLossPayeeNm { get { return _invLossPayeeNm; } set { _invLossPayeeNm = value; } }
        private StringEnumValue<OrgTyp> _invLossPayeeOrgTyp;
        public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get { return _invLossPayeeOrgTyp; } set { _invLossPayeeOrgTyp = value; } }
        private DirtyValue<string> _invLossPayeeScsrClausTxtDesc;
        public string InvLossPayeeScsrClausTxtDesc { get { return _invLossPayeeScsrClausTxtDesc; } set { _invLossPayeeScsrClausTxtDesc = value; } }
        private DirtyValue<string> _invLossPayeeStCd;
        public string InvLossPayeeStCd { get { return _invLossPayeeStCd; } set { _invLossPayeeStCd = value; } }
        private DirtyValue<string> _invLossPayeeStreetAddr1;
        public string InvLossPayeeStreetAddr1 { get { return _invLossPayeeStreetAddr1; } set { _invLossPayeeStreetAddr1 = value; } }
        private DirtyValue<string> _invLossPayeeStreetAddr2;
        public string InvLossPayeeStreetAddr2 { get { return _invLossPayeeStreetAddr2; } set { _invLossPayeeStreetAddr2 = value; } }
        private DirtyValue<string> _invLossPayeeZip;
        public string InvLossPayeeZip { get { return _invLossPayeeZip; } set { _invLossPayeeZip = value; } }
        private DirtyValue<string> _invNm;
        public string InvNm { get { return _invNm; } set { _invNm = value; } }
        private StringEnumValue<OrgTyp> _invOrgTyp;
        public StringEnumValue<OrgTyp> InvOrgTyp { get { return _invOrgTyp; } set { _invOrgTyp = value; } }
        private DirtyValue<string> _invPhoneNum;
        public string InvPhoneNum { get { return _invPhoneNum; } set { _invPhoneNum = value; } }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt;
        public string InvPmtCpn2PayToAdtlTxt { get { return _invPmtCpn2PayToAdtlTxt; } set { _invPmtCpn2PayToAdtlTxt = value; } }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt2;
        public string InvPmtCpn2PayToAdtlTxt2 { get { return _invPmtCpn2PayToAdtlTxt2; } set { _invPmtCpn2PayToAdtlTxt2 = value; } }
        private DirtyValue<string> _invPmtCpn2PayToCty;
        public string InvPmtCpn2PayToCty { get { return _invPmtCpn2PayToCty; } set { _invPmtCpn2PayToCty = value; } }
        private DirtyValue<string> _invPmtCpn2PayToNm;
        public string InvPmtCpn2PayToNm { get { return _invPmtCpn2PayToNm; } set { _invPmtCpn2PayToNm = value; } }
        private DirtyValue<string> _invPmtCpn2PayToStCd;
        public string InvPmtCpn2PayToStCd { get { return _invPmtCpn2PayToStCd; } set { _invPmtCpn2PayToStCd = value; } }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr1;
        public string InvPmtCpn2PayToStreetAddr1 { get { return _invPmtCpn2PayToStreetAddr1; } set { _invPmtCpn2PayToStreetAddr1 = value; } }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr2;
        public string InvPmtCpn2PayToStreetAddr2 { get { return _invPmtCpn2PayToStreetAddr2; } set { _invPmtCpn2PayToStreetAddr2 = value; } }
        private DirtyValue<string> _invPmtCpn2PayToZip;
        public string InvPmtCpn2PayToZip { get { return _invPmtCpn2PayToZip; } set { _invPmtCpn2PayToZip = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToAdtlTxt;
        public string InvPmtCpnLoanTrsfToAdtlTxt { get { return _invPmtCpnLoanTrsfToAdtlTxt; } set { _invPmtCpnLoanTrsfToAdtlTxt = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToCty;
        public string InvPmtCpnLoanTrsfToCty { get { return _invPmtCpnLoanTrsfToCty; } set { _invPmtCpnLoanTrsfToCty = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToNm;
        public string InvPmtCpnLoanTrsfToNm { get { return _invPmtCpnLoanTrsfToNm; } set { _invPmtCpnLoanTrsfToNm = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStCd;
        public string InvPmtCpnLoanTrsfToStCd { get { return _invPmtCpnLoanTrsfToStCd; } set { _invPmtCpnLoanTrsfToStCd = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr1;
        public string InvPmtCpnLoanTrsfToStreetAddr1 { get { return _invPmtCpnLoanTrsfToStreetAddr1; } set { _invPmtCpnLoanTrsfToStreetAddr1 = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr2;
        public string InvPmtCpnLoanTrsfToStreetAddr2 { get { return _invPmtCpnLoanTrsfToStreetAddr2; } set { _invPmtCpnLoanTrsfToStreetAddr2 = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcAdtlTxt;
        public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get { return _invPmtCpnLoanTrsfToSvcAdtlTxt; } set { _invPmtCpnLoanTrsfToSvcAdtlTxt = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcCty;
        public string InvPmtCpnLoanTrsfToSvcCty { get { return _invPmtCpnLoanTrsfToSvcCty; } set { _invPmtCpnLoanTrsfToSvcCty = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcNm;
        public string InvPmtCpnLoanTrsfToSvcNm { get { return _invPmtCpnLoanTrsfToSvcNm; } set { _invPmtCpnLoanTrsfToSvcNm = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStCd;
        public string InvPmtCpnLoanTrsfToSvcStCd { get { return _invPmtCpnLoanTrsfToSvcStCd; } set { _invPmtCpnLoanTrsfToSvcStCd = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr1;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get { return _invPmtCpnLoanTrsfToSvcStreetAddr1; } set { _invPmtCpnLoanTrsfToSvcStreetAddr1 = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr2;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get { return _invPmtCpnLoanTrsfToSvcStreetAddr2; } set { _invPmtCpnLoanTrsfToSvcStreetAddr2 = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcZip;
        public string InvPmtCpnLoanTrsfToSvcZip { get { return _invPmtCpnLoanTrsfToSvcZip; } set { _invPmtCpnLoanTrsfToSvcZip = value; } }
        private DirtyValue<string> _invPmtCpnLoanTrsfToZip;
        public string InvPmtCpnLoanTrsfToZip { get { return _invPmtCpnLoanTrsfToZip; } set { _invPmtCpnLoanTrsfToZip = value; } }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt;
        public string InvPmtCpnPayToAdtlTxt { get { return _invPmtCpnPayToAdtlTxt; } set { _invPmtCpnPayToAdtlTxt = value; } }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt2;
        public string InvPmtCpnPayToAdtlTxt2 { get { return _invPmtCpnPayToAdtlTxt2; } set { _invPmtCpnPayToAdtlTxt2 = value; } }
        private DirtyValue<string> _invPmtCpnPayToCty;
        public string InvPmtCpnPayToCty { get { return _invPmtCpnPayToCty; } set { _invPmtCpnPayToCty = value; } }
        private DirtyValue<string> _invPmtCpnPayToNm;
        public string InvPmtCpnPayToNm { get { return _invPmtCpnPayToNm; } set { _invPmtCpnPayToNm = value; } }
        private DirtyValue<string> _invPmtCpnPayToStCd;
        public string InvPmtCpnPayToStCd { get { return _invPmtCpnPayToStCd; } set { _invPmtCpnPayToStCd = value; } }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr1;
        public string InvPmtCpnPayToStreetAddr1 { get { return _invPmtCpnPayToStreetAddr1; } set { _invPmtCpnPayToStreetAddr1 = value; } }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr2;
        public string InvPmtCpnPayToStreetAddr2 { get { return _invPmtCpnPayToStreetAddr2; } set { _invPmtCpnPayToStreetAddr2 = value; } }
        private DirtyValue<string> _invPmtCpnPayToZip;
        public string InvPmtCpnPayToZip { get { return _invPmtCpnPayToZip; } set { _invPmtCpnPayToZip = value; } }
        private DirtyValue<string> _invStCd;
        public string InvStCd { get { return _invStCd; } set { _invStCd = value; } }
        private DirtyValue<string> _invStreetAddr1;
        public string InvStreetAddr1 { get { return _invStreetAddr1; } set { _invStreetAddr1 = value; } }
        private DirtyValue<string> _invStreetAddr2;
        public string InvStreetAddr2 { get { return _invStreetAddr2; } set { _invStreetAddr2 = value; } }
        private DirtyValue<string> _invSvcrAdtlTxt;
        public string InvSvcrAdtlTxt { get { return _invSvcrAdtlTxt; } set { _invSvcrAdtlTxt = value; } }
        private DirtyValue<string> _invSvcrCntctNm;
        public string InvSvcrCntctNm { get { return _invSvcrCntctNm; } set { _invSvcrCntctNm = value; } }
        private DirtyValue<string> _invSvcrCntctPhoneNum;
        public string InvSvcrCntctPhoneNum { get { return _invSvcrCntctPhoneNum; } set { _invSvcrCntctPhoneNum = value; } }
        private DirtyValue<string> _invSvcrCntctTollFreePhoneNum;
        public string InvSvcrCntctTollFreePhoneNum { get { return _invSvcrCntctTollFreePhoneNum; } set { _invSvcrCntctTollFreePhoneNum = value; } }
        private DirtyValue<string> _invSvcrCty;
        public string InvSvcrCty { get { return _invSvcrCty; } set { _invSvcrCty = value; } }
        private DirtyValue<string> _invSvcrDayOp;
        public string InvSvcrDayOp { get { return _invSvcrDayOp; } set { _invSvcrDayOp = value; } }
        private DirtyValue<string> _invSvcrDayOpAddl;
        public string InvSvcrDayOpAddl { get { return _invSvcrDayOpAddl; } set { _invSvcrDayOpAddl = value; } }
        private DirtyValue<string> _invSvcrHrsOp;
        public string InvSvcrHrsOp { get { return _invSvcrHrsOp; } set { _invSvcrHrsOp = value; } }
        private DirtyValue<string> _invSvcrHrsOpAddl;
        public string InvSvcrHrsOpAddl { get { return _invSvcrHrsOpAddl; } set { _invSvcrHrsOpAddl = value; } }
        private DirtyValue<string> _invSvcrJrsdctn;
        public string InvSvcrJrsdctn { get { return _invSvcrJrsdctn; } set { _invSvcrJrsdctn = value; } }
        private DirtyValue<string> _invSvcrNm;
        public string InvSvcrNm { get { return _invSvcrNm; } set { _invSvcrNm = value; } }
        private StringEnumValue<OrgTyp> _invSvcrOrgTyp;
        public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get { return _invSvcrOrgTyp; } set { _invSvcrOrgTyp = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get { return _invSvcrQlfdWrtnRqstMailToAdtlTxt; } set { _invSvcrQlfdWrtnRqstMailToAdtlTxt = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToCty;
        public string InvSvcrQlfdWrtnRqstMailToCty { get { return _invSvcrQlfdWrtnRqstMailToCty; } set { _invSvcrQlfdWrtnRqstMailToCty = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToNm;
        public string InvSvcrQlfdWrtnRqstMailToNm { get { return _invSvcrQlfdWrtnRqstMailToNm; } set { _invSvcrQlfdWrtnRqstMailToNm = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStCd;
        public string InvSvcrQlfdWrtnRqstMailToStCd { get { return _invSvcrQlfdWrtnRqstMailToStCd; } set { _invSvcrQlfdWrtnRqstMailToStCd = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get { return _invSvcrQlfdWrtnRqstMailToStreetAddr1; } set { _invSvcrQlfdWrtnRqstMailToStreetAddr1 = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get { return _invSvcrQlfdWrtnRqstMailToStreetAddr2; } set { _invSvcrQlfdWrtnRqstMailToStreetAddr2 = value; } }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToZip;
        public string InvSvcrQlfdWrtnRqstMailToZip { get { return _invSvcrQlfdWrtnRqstMailToZip; } set { _invSvcrQlfdWrtnRqstMailToZip = value; } }
        private DirtyValue<string> _invSvcrStCd;
        public string InvSvcrStCd { get { return _invSvcrStCd; } set { _invSvcrStCd = value; } }
        private DirtyValue<string> _invSvcrStreetAddr1;
        public string InvSvcrStreetAddr1 { get { return _invSvcrStreetAddr1; } set { _invSvcrStreetAddr1 = value; } }
        private DirtyValue<string> _invSvcrStreetAddr2;
        public string InvSvcrStreetAddr2 { get { return _invSvcrStreetAddr2; } set { _invSvcrStreetAddr2 = value; } }
        private DirtyValue<string> _invSvcrZip;
        public string InvSvcrZip { get { return _invSvcrZip; } set { _invSvcrZip = value; } }
        private DirtyValue<string> _invTaxIDNum;
        public string InvTaxIDNum { get { return _invTaxIDNum; } set { _invTaxIDNum = value; } }
        private DirtyValue<string> _invTollFreePhoneNum;
        public string InvTollFreePhoneNum { get { return _invTollFreePhoneNum; } set { _invTollFreePhoneNum = value; } }
        private DirtyValue<string> _invUrl;
        public string InvUrl { get { return _invUrl; } set { _invUrl = value; } }
        private DirtyValue<string> _invZip;
        public string InvZip { get { return _invZip; } set { _invZip = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _id.Dirty
                    || _invAsgnCty.Dirty
                    || _invAsgnJrsdctn.Dirty
                    || _invAsgnNm.Dirty
                    || _invAsgnOrgTyp.Dirty
                    || _invAsgnStCd.Dirty
                    || _invAsgnStreetAddr1.Dirty
                    || _invAsgnStreetAddr2.Dirty
                    || _invAsgnZip.Dirty
                    || _invCty.Dirty
                    || _invFaxNum.Dirty
                    || _invJrsdctn.Dirty
                    || _invLossPayeeAdtlTxt.Dirty
                    || _invLossPayeeCntctEmail.Dirty
                    || _invLossPayeeCntctFax.Dirty
                    || _invLossPayeeCntctNm.Dirty
                    || _invLossPayeeCntctPhone.Dirty
                    || _invLossPayeeCty.Dirty
                    || _invLossPayeeJrsdctn.Dirty
                    || _invLossPayeeNm.Dirty
                    || _invLossPayeeOrgTyp.Dirty
                    || _invLossPayeeScsrClausTxtDesc.Dirty
                    || _invLossPayeeStCd.Dirty
                    || _invLossPayeeStreetAddr1.Dirty
                    || _invLossPayeeStreetAddr2.Dirty
                    || _invLossPayeeZip.Dirty
                    || _invNm.Dirty
                    || _invOrgTyp.Dirty
                    || _invPhoneNum.Dirty
                    || _invPmtCpn2PayToAdtlTxt.Dirty
                    || _invPmtCpn2PayToAdtlTxt2.Dirty
                    || _invPmtCpn2PayToCty.Dirty
                    || _invPmtCpn2PayToNm.Dirty
                    || _invPmtCpn2PayToStCd.Dirty
                    || _invPmtCpn2PayToStreetAddr1.Dirty
                    || _invPmtCpn2PayToStreetAddr2.Dirty
                    || _invPmtCpn2PayToZip.Dirty
                    || _invPmtCpnLoanTrsfToAdtlTxt.Dirty
                    || _invPmtCpnLoanTrsfToCty.Dirty
                    || _invPmtCpnLoanTrsfToNm.Dirty
                    || _invPmtCpnLoanTrsfToStCd.Dirty
                    || _invPmtCpnLoanTrsfToStreetAddr1.Dirty
                    || _invPmtCpnLoanTrsfToStreetAddr2.Dirty
                    || _invPmtCpnLoanTrsfToSvcAdtlTxt.Dirty
                    || _invPmtCpnLoanTrsfToSvcCty.Dirty
                    || _invPmtCpnLoanTrsfToSvcNm.Dirty
                    || _invPmtCpnLoanTrsfToSvcStCd.Dirty
                    || _invPmtCpnLoanTrsfToSvcStreetAddr1.Dirty
                    || _invPmtCpnLoanTrsfToSvcStreetAddr2.Dirty
                    || _invPmtCpnLoanTrsfToSvcZip.Dirty
                    || _invPmtCpnLoanTrsfToZip.Dirty
                    || _invPmtCpnPayToAdtlTxt.Dirty
                    || _invPmtCpnPayToAdtlTxt2.Dirty
                    || _invPmtCpnPayToCty.Dirty
                    || _invPmtCpnPayToNm.Dirty
                    || _invPmtCpnPayToStCd.Dirty
                    || _invPmtCpnPayToStreetAddr1.Dirty
                    || _invPmtCpnPayToStreetAddr2.Dirty
                    || _invPmtCpnPayToZip.Dirty
                    || _invStCd.Dirty
                    || _invStreetAddr1.Dirty
                    || _invStreetAddr2.Dirty
                    || _invSvcrAdtlTxt.Dirty
                    || _invSvcrCntctNm.Dirty
                    || _invSvcrCntctPhoneNum.Dirty
                    || _invSvcrCntctTollFreePhoneNum.Dirty
                    || _invSvcrCty.Dirty
                    || _invSvcrDayOp.Dirty
                    || _invSvcrDayOpAddl.Dirty
                    || _invSvcrHrsOp.Dirty
                    || _invSvcrHrsOpAddl.Dirty
                    || _invSvcrJrsdctn.Dirty
                    || _invSvcrNm.Dirty
                    || _invSvcrOrgTyp.Dirty
                    || _invSvcrQlfdWrtnRqstMailToAdtlTxt.Dirty
                    || _invSvcrQlfdWrtnRqstMailToCty.Dirty
                    || _invSvcrQlfdWrtnRqstMailToNm.Dirty
                    || _invSvcrQlfdWrtnRqstMailToStCd.Dirty
                    || _invSvcrQlfdWrtnRqstMailToStreetAddr1.Dirty
                    || _invSvcrQlfdWrtnRqstMailToStreetAddr2.Dirty
                    || _invSvcrQlfdWrtnRqstMailToZip.Dirty
                    || _invSvcrStCd.Dirty
                    || _invSvcrStreetAddr1.Dirty
                    || _invSvcrStreetAddr2.Dirty
                    || _invSvcrZip.Dirty
                    || _invTaxIDNum.Dirty
                    || _invTollFreePhoneNum.Dirty
                    || _invUrl.Dirty
                    || _invZip.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _id.Dirty = value;
                _invAsgnCty.Dirty = value;
                _invAsgnJrsdctn.Dirty = value;
                _invAsgnNm.Dirty = value;
                _invAsgnOrgTyp.Dirty = value;
                _invAsgnStCd.Dirty = value;
                _invAsgnStreetAddr1.Dirty = value;
                _invAsgnStreetAddr2.Dirty = value;
                _invAsgnZip.Dirty = value;
                _invCty.Dirty = value;
                _invFaxNum.Dirty = value;
                _invJrsdctn.Dirty = value;
                _invLossPayeeAdtlTxt.Dirty = value;
                _invLossPayeeCntctEmail.Dirty = value;
                _invLossPayeeCntctFax.Dirty = value;
                _invLossPayeeCntctNm.Dirty = value;
                _invLossPayeeCntctPhone.Dirty = value;
                _invLossPayeeCty.Dirty = value;
                _invLossPayeeJrsdctn.Dirty = value;
                _invLossPayeeNm.Dirty = value;
                _invLossPayeeOrgTyp.Dirty = value;
                _invLossPayeeScsrClausTxtDesc.Dirty = value;
                _invLossPayeeStCd.Dirty = value;
                _invLossPayeeStreetAddr1.Dirty = value;
                _invLossPayeeStreetAddr2.Dirty = value;
                _invLossPayeeZip.Dirty = value;
                _invNm.Dirty = value;
                _invOrgTyp.Dirty = value;
                _invPhoneNum.Dirty = value;
                _invPmtCpn2PayToAdtlTxt.Dirty = value;
                _invPmtCpn2PayToAdtlTxt2.Dirty = value;
                _invPmtCpn2PayToCty.Dirty = value;
                _invPmtCpn2PayToNm.Dirty = value;
                _invPmtCpn2PayToStCd.Dirty = value;
                _invPmtCpn2PayToStreetAddr1.Dirty = value;
                _invPmtCpn2PayToStreetAddr2.Dirty = value;
                _invPmtCpn2PayToZip.Dirty = value;
                _invPmtCpnLoanTrsfToAdtlTxt.Dirty = value;
                _invPmtCpnLoanTrsfToCty.Dirty = value;
                _invPmtCpnLoanTrsfToNm.Dirty = value;
                _invPmtCpnLoanTrsfToStCd.Dirty = value;
                _invPmtCpnLoanTrsfToStreetAddr1.Dirty = value;
                _invPmtCpnLoanTrsfToStreetAddr2.Dirty = value;
                _invPmtCpnLoanTrsfToSvcAdtlTxt.Dirty = value;
                _invPmtCpnLoanTrsfToSvcCty.Dirty = value;
                _invPmtCpnLoanTrsfToSvcNm.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStCd.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStreetAddr1.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStreetAddr2.Dirty = value;
                _invPmtCpnLoanTrsfToSvcZip.Dirty = value;
                _invPmtCpnLoanTrsfToZip.Dirty = value;
                _invPmtCpnPayToAdtlTxt.Dirty = value;
                _invPmtCpnPayToAdtlTxt2.Dirty = value;
                _invPmtCpnPayToCty.Dirty = value;
                _invPmtCpnPayToNm.Dirty = value;
                _invPmtCpnPayToStCd.Dirty = value;
                _invPmtCpnPayToStreetAddr1.Dirty = value;
                _invPmtCpnPayToStreetAddr2.Dirty = value;
                _invPmtCpnPayToZip.Dirty = value;
                _invStCd.Dirty = value;
                _invStreetAddr1.Dirty = value;
                _invStreetAddr2.Dirty = value;
                _invSvcrAdtlTxt.Dirty = value;
                _invSvcrCntctNm.Dirty = value;
                _invSvcrCntctPhoneNum.Dirty = value;
                _invSvcrCntctTollFreePhoneNum.Dirty = value;
                _invSvcrCty.Dirty = value;
                _invSvcrDayOp.Dirty = value;
                _invSvcrDayOpAddl.Dirty = value;
                _invSvcrHrsOp.Dirty = value;
                _invSvcrHrsOpAddl.Dirty = value;
                _invSvcrJrsdctn.Dirty = value;
                _invSvcrNm.Dirty = value;
                _invSvcrOrgTyp.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToAdtlTxt.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToCty.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToNm.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStCd.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStreetAddr1.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStreetAddr2.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToZip.Dirty = value;
                _invSvcrStCd.Dirty = value;
                _invSvcrStreetAddr1.Dirty = value;
                _invSvcrStreetAddr2.Dirty = value;
                _invSvcrZip.Dirty = value;
                _invTaxIDNum.Dirty = value;
                _invTollFreePhoneNum.Dirty = value;
                _invUrl.Dirty = value;
                _invZip.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}