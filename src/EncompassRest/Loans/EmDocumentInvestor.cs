using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class EmDocumentInvestor : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _invAsgnCty;
        public string InvAsgnCty { get => _invAsgnCty; set => _invAsgnCty = value; }
        private DirtyValue<string> _invAsgnJrsdctn;
        public string InvAsgnJrsdctn { get => _invAsgnJrsdctn; set => _invAsgnJrsdctn = value; }
        private DirtyValue<string> _invAsgnNm;
        public string InvAsgnNm { get => _invAsgnNm; set => _invAsgnNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invAsgnOrgTyp;
        public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get => _invAsgnOrgTyp; set => _invAsgnOrgTyp = value; }
        private DirtyValue<string> _invAsgnStCd;
        public string InvAsgnStCd { get => _invAsgnStCd; set => _invAsgnStCd = value; }
        private DirtyValue<string> _invAsgnStreetAddr1;
        public string InvAsgnStreetAddr1 { get => _invAsgnStreetAddr1; set => _invAsgnStreetAddr1 = value; }
        private DirtyValue<string> _invAsgnStreetAddr2;
        public string InvAsgnStreetAddr2 { get => _invAsgnStreetAddr2; set => _invAsgnStreetAddr2 = value; }
        private DirtyValue<string> _invAsgnZip;
        public string InvAsgnZip { get => _invAsgnZip; set => _invAsgnZip = value; }
        private DirtyValue<string> _invCty;
        public string InvCty { get => _invCty; set => _invCty = value; }
        private DirtyValue<string> _invFaxNum;
        public string InvFaxNum { get => _invFaxNum; set => _invFaxNum = value; }
        private DirtyValue<string> _invJrsdctn;
        public string InvJrsdctn { get => _invJrsdctn; set => _invJrsdctn = value; }
        private DirtyValue<string> _invLossPayeeAdtlTxt;
        public string InvLossPayeeAdtlTxt { get => _invLossPayeeAdtlTxt; set => _invLossPayeeAdtlTxt = value; }
        private DirtyValue<string> _invLossPayeeCntctEmail;
        public string InvLossPayeeCntctEmail { get => _invLossPayeeCntctEmail; set => _invLossPayeeCntctEmail = value; }
        private DirtyValue<string> _invLossPayeeCntctFax;
        public string InvLossPayeeCntctFax { get => _invLossPayeeCntctFax; set => _invLossPayeeCntctFax = value; }
        private DirtyValue<string> _invLossPayeeCntctNm;
        public string InvLossPayeeCntctNm { get => _invLossPayeeCntctNm; set => _invLossPayeeCntctNm = value; }
        private DirtyValue<string> _invLossPayeeCntctPhone;
        public string InvLossPayeeCntctPhone { get => _invLossPayeeCntctPhone; set => _invLossPayeeCntctPhone = value; }
        private DirtyValue<string> _invLossPayeeCty;
        public string InvLossPayeeCty { get => _invLossPayeeCty; set => _invLossPayeeCty = value; }
        private DirtyValue<string> _invLossPayeeJrsdctn;
        public string InvLossPayeeJrsdctn { get => _invLossPayeeJrsdctn; set => _invLossPayeeJrsdctn = value; }
        private DirtyValue<string> _invLossPayeeNm;
        public string InvLossPayeeNm { get => _invLossPayeeNm; set => _invLossPayeeNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invLossPayeeOrgTyp;
        public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get => _invLossPayeeOrgTyp; set => _invLossPayeeOrgTyp = value; }
        private DirtyValue<string> _invLossPayeeScsrClausTxtDesc;
        public string InvLossPayeeScsrClausTxtDesc { get => _invLossPayeeScsrClausTxtDesc; set => _invLossPayeeScsrClausTxtDesc = value; }
        private DirtyValue<string> _invLossPayeeStCd;
        public string InvLossPayeeStCd { get => _invLossPayeeStCd; set => _invLossPayeeStCd = value; }
        private DirtyValue<string> _invLossPayeeStreetAddr1;
        public string InvLossPayeeStreetAddr1 { get => _invLossPayeeStreetAddr1; set => _invLossPayeeStreetAddr1 = value; }
        private DirtyValue<string> _invLossPayeeStreetAddr2;
        public string InvLossPayeeStreetAddr2 { get => _invLossPayeeStreetAddr2; set => _invLossPayeeStreetAddr2 = value; }
        private DirtyValue<string> _invLossPayeeZip;
        public string InvLossPayeeZip { get => _invLossPayeeZip; set => _invLossPayeeZip = value; }
        private DirtyValue<string> _invNm;
        public string InvNm { get => _invNm; set => _invNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invOrgTyp;
        public StringEnumValue<OrgTyp> InvOrgTyp { get => _invOrgTyp; set => _invOrgTyp = value; }
        private DirtyValue<string> _invPhoneNum;
        public string InvPhoneNum { get => _invPhoneNum; set => _invPhoneNum = value; }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt;
        public string InvPmtCpn2PayToAdtlTxt { get => _invPmtCpn2PayToAdtlTxt; set => _invPmtCpn2PayToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt2;
        public string InvPmtCpn2PayToAdtlTxt2 { get => _invPmtCpn2PayToAdtlTxt2; set => _invPmtCpn2PayToAdtlTxt2 = value; }
        private DirtyValue<string> _invPmtCpn2PayToCty;
        public string InvPmtCpn2PayToCty { get => _invPmtCpn2PayToCty; set => _invPmtCpn2PayToCty = value; }
        private DirtyValue<string> _invPmtCpn2PayToNm;
        public string InvPmtCpn2PayToNm { get => _invPmtCpn2PayToNm; set => _invPmtCpn2PayToNm = value; }
        private DirtyValue<string> _invPmtCpn2PayToStCd;
        public string InvPmtCpn2PayToStCd { get => _invPmtCpn2PayToStCd; set => _invPmtCpn2PayToStCd = value; }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr1;
        public string InvPmtCpn2PayToStreetAddr1 { get => _invPmtCpn2PayToStreetAddr1; set => _invPmtCpn2PayToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr2;
        public string InvPmtCpn2PayToStreetAddr2 { get => _invPmtCpn2PayToStreetAddr2; set => _invPmtCpn2PayToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpn2PayToZip;
        public string InvPmtCpn2PayToZip { get => _invPmtCpn2PayToZip; set => _invPmtCpn2PayToZip = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToAdtlTxt;
        public string InvPmtCpnLoanTrsfToAdtlTxt { get => _invPmtCpnLoanTrsfToAdtlTxt; set => _invPmtCpnLoanTrsfToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToCty;
        public string InvPmtCpnLoanTrsfToCty { get => _invPmtCpnLoanTrsfToCty; set => _invPmtCpnLoanTrsfToCty = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToNm;
        public string InvPmtCpnLoanTrsfToNm { get => _invPmtCpnLoanTrsfToNm; set => _invPmtCpnLoanTrsfToNm = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStCd;
        public string InvPmtCpnLoanTrsfToStCd { get => _invPmtCpnLoanTrsfToStCd; set => _invPmtCpnLoanTrsfToStCd = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr1;
        public string InvPmtCpnLoanTrsfToStreetAddr1 { get => _invPmtCpnLoanTrsfToStreetAddr1; set => _invPmtCpnLoanTrsfToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr2;
        public string InvPmtCpnLoanTrsfToStreetAddr2 { get => _invPmtCpnLoanTrsfToStreetAddr2; set => _invPmtCpnLoanTrsfToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcAdtlTxt;
        public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get => _invPmtCpnLoanTrsfToSvcAdtlTxt; set => _invPmtCpnLoanTrsfToSvcAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcCty;
        public string InvPmtCpnLoanTrsfToSvcCty { get => _invPmtCpnLoanTrsfToSvcCty; set => _invPmtCpnLoanTrsfToSvcCty = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcNm;
        public string InvPmtCpnLoanTrsfToSvcNm { get => _invPmtCpnLoanTrsfToSvcNm; set => _invPmtCpnLoanTrsfToSvcNm = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStCd;
        public string InvPmtCpnLoanTrsfToSvcStCd { get => _invPmtCpnLoanTrsfToSvcStCd; set => _invPmtCpnLoanTrsfToSvcStCd = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr1;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get => _invPmtCpnLoanTrsfToSvcStreetAddr1; set => _invPmtCpnLoanTrsfToSvcStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr2;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get => _invPmtCpnLoanTrsfToSvcStreetAddr2; set => _invPmtCpnLoanTrsfToSvcStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcZip;
        public string InvPmtCpnLoanTrsfToSvcZip { get => _invPmtCpnLoanTrsfToSvcZip; set => _invPmtCpnLoanTrsfToSvcZip = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToZip;
        public string InvPmtCpnLoanTrsfToZip { get => _invPmtCpnLoanTrsfToZip; set => _invPmtCpnLoanTrsfToZip = value; }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt;
        public string InvPmtCpnPayToAdtlTxt { get => _invPmtCpnPayToAdtlTxt; set => _invPmtCpnPayToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt2;
        public string InvPmtCpnPayToAdtlTxt2 { get => _invPmtCpnPayToAdtlTxt2; set => _invPmtCpnPayToAdtlTxt2 = value; }
        private DirtyValue<string> _invPmtCpnPayToCty;
        public string InvPmtCpnPayToCty { get => _invPmtCpnPayToCty; set => _invPmtCpnPayToCty = value; }
        private DirtyValue<string> _invPmtCpnPayToNm;
        public string InvPmtCpnPayToNm { get => _invPmtCpnPayToNm; set => _invPmtCpnPayToNm = value; }
        private DirtyValue<string> _invPmtCpnPayToStCd;
        public string InvPmtCpnPayToStCd { get => _invPmtCpnPayToStCd; set => _invPmtCpnPayToStCd = value; }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr1;
        public string InvPmtCpnPayToStreetAddr1 { get => _invPmtCpnPayToStreetAddr1; set => _invPmtCpnPayToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr2;
        public string InvPmtCpnPayToStreetAddr2 { get => _invPmtCpnPayToStreetAddr2; set => _invPmtCpnPayToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnPayToZip;
        public string InvPmtCpnPayToZip { get => _invPmtCpnPayToZip; set => _invPmtCpnPayToZip = value; }
        private DirtyValue<string> _invStCd;
        public string InvStCd { get => _invStCd; set => _invStCd = value; }
        private DirtyValue<string> _invStreetAddr1;
        public string InvStreetAddr1 { get => _invStreetAddr1; set => _invStreetAddr1 = value; }
        private DirtyValue<string> _invStreetAddr2;
        public string InvStreetAddr2 { get => _invStreetAddr2; set => _invStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrAdtlTxt;
        public string InvSvcrAdtlTxt { get => _invSvcrAdtlTxt; set => _invSvcrAdtlTxt = value; }
        private DirtyValue<string> _invSvcrCntctNm;
        public string InvSvcrCntctNm { get => _invSvcrCntctNm; set => _invSvcrCntctNm = value; }
        private DirtyValue<string> _invSvcrCntctPhoneNum;
        public string InvSvcrCntctPhoneNum { get => _invSvcrCntctPhoneNum; set => _invSvcrCntctPhoneNum = value; }
        private DirtyValue<string> _invSvcrCntctTollFreePhoneNum;
        public string InvSvcrCntctTollFreePhoneNum { get => _invSvcrCntctTollFreePhoneNum; set => _invSvcrCntctTollFreePhoneNum = value; }
        private DirtyValue<string> _invSvcrCty;
        public string InvSvcrCty { get => _invSvcrCty; set => _invSvcrCty = value; }
        private DirtyValue<string> _invSvcrDayOp;
        public string InvSvcrDayOp { get => _invSvcrDayOp; set => _invSvcrDayOp = value; }
        private DirtyValue<string> _invSvcrDayOpAddl;
        public string InvSvcrDayOpAddl { get => _invSvcrDayOpAddl; set => _invSvcrDayOpAddl = value; }
        private DirtyValue<string> _invSvcrHrsOp;
        public string InvSvcrHrsOp { get => _invSvcrHrsOp; set => _invSvcrHrsOp = value; }
        private DirtyValue<string> _invSvcrHrsOpAddl;
        public string InvSvcrHrsOpAddl { get => _invSvcrHrsOpAddl; set => _invSvcrHrsOpAddl = value; }
        private DirtyValue<string> _invSvcrJrsdctn;
        public string InvSvcrJrsdctn { get => _invSvcrJrsdctn; set => _invSvcrJrsdctn = value; }
        private DirtyValue<string> _invSvcrNm;
        public string InvSvcrNm { get => _invSvcrNm; set => _invSvcrNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invSvcrOrgTyp;
        public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get => _invSvcrOrgTyp; set => _invSvcrOrgTyp = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get => _invSvcrQlfdWrtnRqstMailToAdtlTxt; set => _invSvcrQlfdWrtnRqstMailToAdtlTxt = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToCty;
        public string InvSvcrQlfdWrtnRqstMailToCty { get => _invSvcrQlfdWrtnRqstMailToCty; set => _invSvcrQlfdWrtnRqstMailToCty = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToNm;
        public string InvSvcrQlfdWrtnRqstMailToNm { get => _invSvcrQlfdWrtnRqstMailToNm; set => _invSvcrQlfdWrtnRqstMailToNm = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStCd;
        public string InvSvcrQlfdWrtnRqstMailToStCd { get => _invSvcrQlfdWrtnRqstMailToStCd; set => _invSvcrQlfdWrtnRqstMailToStCd = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr1; set => _invSvcrQlfdWrtnRqstMailToStreetAddr1 = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr2; set => _invSvcrQlfdWrtnRqstMailToStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToZip;
        public string InvSvcrQlfdWrtnRqstMailToZip { get => _invSvcrQlfdWrtnRqstMailToZip; set => _invSvcrQlfdWrtnRqstMailToZip = value; }
        private DirtyValue<string> _invSvcrStCd;
        public string InvSvcrStCd { get => _invSvcrStCd; set => _invSvcrStCd = value; }
        private DirtyValue<string> _invSvcrStreetAddr1;
        public string InvSvcrStreetAddr1 { get => _invSvcrStreetAddr1; set => _invSvcrStreetAddr1 = value; }
        private DirtyValue<string> _invSvcrStreetAddr2;
        public string InvSvcrStreetAddr2 { get => _invSvcrStreetAddr2; set => _invSvcrStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrZip;
        public string InvSvcrZip { get => _invSvcrZip; set => _invSvcrZip = value; }
        private DirtyValue<string> _invTaxIDNum;
        public string InvTaxIDNum { get => _invTaxIDNum; set => _invTaxIDNum = value; }
        private DirtyValue<string> _invTollFreePhoneNum;
        public string InvTollFreePhoneNum { get => _invTollFreePhoneNum; set => _invTollFreePhoneNum = value; }
        private DirtyValue<string> _invUrl;
        public string InvUrl { get => _invUrl; set => _invUrl = value; }
        private DirtyValue<string> _invZip;
        public string InvZip { get => _invZip; set => _invZip = value; }
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
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}