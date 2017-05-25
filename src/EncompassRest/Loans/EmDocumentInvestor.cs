using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentInvestor : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _invAsgnCty;
        public string InvAsgnCty { get { return _invAsgnCty; } set { _invAsgnCty = value; } }
        private Value<string> _invAsgnJrsdctn;
        public string InvAsgnJrsdctn { get { return _invAsgnJrsdctn; } set { _invAsgnJrsdctn = value; } }
        private Value<string> _invAsgnNm;
        public string InvAsgnNm { get { return _invAsgnNm; } set { _invAsgnNm = value; } }
        private Value<string> _invAsgnOrgTyp;
        public string InvAsgnOrgTyp { get { return _invAsgnOrgTyp; } set { _invAsgnOrgTyp = value; } }
        private Value<string> _invAsgnStCd;
        public string InvAsgnStCd { get { return _invAsgnStCd; } set { _invAsgnStCd = value; } }
        private Value<string> _invAsgnStreetAddr1;
        public string InvAsgnStreetAddr1 { get { return _invAsgnStreetAddr1; } set { _invAsgnStreetAddr1 = value; } }
        private Value<string> _invAsgnStreetAddr2;
        public string InvAsgnStreetAddr2 { get { return _invAsgnStreetAddr2; } set { _invAsgnStreetAddr2 = value; } }
        private Value<string> _invAsgnZip;
        public string InvAsgnZip { get { return _invAsgnZip; } set { _invAsgnZip = value; } }
        private Value<string> _invCty;
        public string InvCty { get { return _invCty; } set { _invCty = value; } }
        private Value<string> _invFaxNum;
        public string InvFaxNum { get { return _invFaxNum; } set { _invFaxNum = value; } }
        private Value<string> _invJrsdctn;
        public string InvJrsdctn { get { return _invJrsdctn; } set { _invJrsdctn = value; } }
        private Value<string> _invLossPayeeAdtlTxt;
        public string InvLossPayeeAdtlTxt { get { return _invLossPayeeAdtlTxt; } set { _invLossPayeeAdtlTxt = value; } }
        private Value<string> _invLossPayeeCntctEmail;
        public string InvLossPayeeCntctEmail { get { return _invLossPayeeCntctEmail; } set { _invLossPayeeCntctEmail = value; } }
        private Value<string> _invLossPayeeCntctFax;
        public string InvLossPayeeCntctFax { get { return _invLossPayeeCntctFax; } set { _invLossPayeeCntctFax = value; } }
        private Value<string> _invLossPayeeCntctNm;
        public string InvLossPayeeCntctNm { get { return _invLossPayeeCntctNm; } set { _invLossPayeeCntctNm = value; } }
        private Value<string> _invLossPayeeCntctPhone;
        public string InvLossPayeeCntctPhone { get { return _invLossPayeeCntctPhone; } set { _invLossPayeeCntctPhone = value; } }
        private Value<string> _invLossPayeeCty;
        public string InvLossPayeeCty { get { return _invLossPayeeCty; } set { _invLossPayeeCty = value; } }
        private Value<string> _invLossPayeeJrsdctn;
        public string InvLossPayeeJrsdctn { get { return _invLossPayeeJrsdctn; } set { _invLossPayeeJrsdctn = value; } }
        private Value<string> _invLossPayeeNm;
        public string InvLossPayeeNm { get { return _invLossPayeeNm; } set { _invLossPayeeNm = value; } }
        private Value<string> _invLossPayeeOrgTyp;
        public string InvLossPayeeOrgTyp { get { return _invLossPayeeOrgTyp; } set { _invLossPayeeOrgTyp = value; } }
        private Value<string> _invLossPayeeScsrClausTxtDesc;
        public string InvLossPayeeScsrClausTxtDesc { get { return _invLossPayeeScsrClausTxtDesc; } set { _invLossPayeeScsrClausTxtDesc = value; } }
        private Value<string> _invLossPayeeStCd;
        public string InvLossPayeeStCd { get { return _invLossPayeeStCd; } set { _invLossPayeeStCd = value; } }
        private Value<string> _invLossPayeeStreetAddr1;
        public string InvLossPayeeStreetAddr1 { get { return _invLossPayeeStreetAddr1; } set { _invLossPayeeStreetAddr1 = value; } }
        private Value<string> _invLossPayeeStreetAddr2;
        public string InvLossPayeeStreetAddr2 { get { return _invLossPayeeStreetAddr2; } set { _invLossPayeeStreetAddr2 = value; } }
        private Value<string> _invLossPayeeZip;
        public string InvLossPayeeZip { get { return _invLossPayeeZip; } set { _invLossPayeeZip = value; } }
        private Value<string> _invNm;
        public string InvNm { get { return _invNm; } set { _invNm = value; } }
        private Value<string> _invOrgTyp;
        public string InvOrgTyp { get { return _invOrgTyp; } set { _invOrgTyp = value; } }
        private Value<string> _invPhoneNum;
        public string InvPhoneNum { get { return _invPhoneNum; } set { _invPhoneNum = value; } }
        private Value<string> _invPmtCpn2PayToAdtlTxt;
        public string InvPmtCpn2PayToAdtlTxt { get { return _invPmtCpn2PayToAdtlTxt; } set { _invPmtCpn2PayToAdtlTxt = value; } }
        private Value<string> _invPmtCpn2PayToAdtlTxt2;
        public string InvPmtCpn2PayToAdtlTxt2 { get { return _invPmtCpn2PayToAdtlTxt2; } set { _invPmtCpn2PayToAdtlTxt2 = value; } }
        private Value<string> _invPmtCpn2PayToCty;
        public string InvPmtCpn2PayToCty { get { return _invPmtCpn2PayToCty; } set { _invPmtCpn2PayToCty = value; } }
        private Value<string> _invPmtCpn2PayToNm;
        public string InvPmtCpn2PayToNm { get { return _invPmtCpn2PayToNm; } set { _invPmtCpn2PayToNm = value; } }
        private Value<string> _invPmtCpn2PayToStCd;
        public string InvPmtCpn2PayToStCd { get { return _invPmtCpn2PayToStCd; } set { _invPmtCpn2PayToStCd = value; } }
        private Value<string> _invPmtCpn2PayToStreetAddr1;
        public string InvPmtCpn2PayToStreetAddr1 { get { return _invPmtCpn2PayToStreetAddr1; } set { _invPmtCpn2PayToStreetAddr1 = value; } }
        private Value<string> _invPmtCpn2PayToStreetAddr2;
        public string InvPmtCpn2PayToStreetAddr2 { get { return _invPmtCpn2PayToStreetAddr2; } set { _invPmtCpn2PayToStreetAddr2 = value; } }
        private Value<string> _invPmtCpn2PayToZip;
        public string InvPmtCpn2PayToZip { get { return _invPmtCpn2PayToZip; } set { _invPmtCpn2PayToZip = value; } }
        private Value<string> _invPmtCpnLoanTrsfToAdtlTxt;
        public string InvPmtCpnLoanTrsfToAdtlTxt { get { return _invPmtCpnLoanTrsfToAdtlTxt; } set { _invPmtCpnLoanTrsfToAdtlTxt = value; } }
        private Value<string> _invPmtCpnLoanTrsfToCty;
        public string InvPmtCpnLoanTrsfToCty { get { return _invPmtCpnLoanTrsfToCty; } set { _invPmtCpnLoanTrsfToCty = value; } }
        private Value<string> _invPmtCpnLoanTrsfToNm;
        public string InvPmtCpnLoanTrsfToNm { get { return _invPmtCpnLoanTrsfToNm; } set { _invPmtCpnLoanTrsfToNm = value; } }
        private Value<string> _invPmtCpnLoanTrsfToStCd;
        public string InvPmtCpnLoanTrsfToStCd { get { return _invPmtCpnLoanTrsfToStCd; } set { _invPmtCpnLoanTrsfToStCd = value; } }
        private Value<string> _invPmtCpnLoanTrsfToStreetAddr1;
        public string InvPmtCpnLoanTrsfToStreetAddr1 { get { return _invPmtCpnLoanTrsfToStreetAddr1; } set { _invPmtCpnLoanTrsfToStreetAddr1 = value; } }
        private Value<string> _invPmtCpnLoanTrsfToStreetAddr2;
        public string InvPmtCpnLoanTrsfToStreetAddr2 { get { return _invPmtCpnLoanTrsfToStreetAddr2; } set { _invPmtCpnLoanTrsfToStreetAddr2 = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcAdtlTxt;
        public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get { return _invPmtCpnLoanTrsfToSvcAdtlTxt; } set { _invPmtCpnLoanTrsfToSvcAdtlTxt = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcCty;
        public string InvPmtCpnLoanTrsfToSvcCty { get { return _invPmtCpnLoanTrsfToSvcCty; } set { _invPmtCpnLoanTrsfToSvcCty = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcNm;
        public string InvPmtCpnLoanTrsfToSvcNm { get { return _invPmtCpnLoanTrsfToSvcNm; } set { _invPmtCpnLoanTrsfToSvcNm = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcStCd;
        public string InvPmtCpnLoanTrsfToSvcStCd { get { return _invPmtCpnLoanTrsfToSvcStCd; } set { _invPmtCpnLoanTrsfToSvcStCd = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcStreetAddr1;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get { return _invPmtCpnLoanTrsfToSvcStreetAddr1; } set { _invPmtCpnLoanTrsfToSvcStreetAddr1 = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcStreetAddr2;
        public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get { return _invPmtCpnLoanTrsfToSvcStreetAddr2; } set { _invPmtCpnLoanTrsfToSvcStreetAddr2 = value; } }
        private Value<string> _invPmtCpnLoanTrsfToSvcZip;
        public string InvPmtCpnLoanTrsfToSvcZip { get { return _invPmtCpnLoanTrsfToSvcZip; } set { _invPmtCpnLoanTrsfToSvcZip = value; } }
        private Value<string> _invPmtCpnLoanTrsfToZip;
        public string InvPmtCpnLoanTrsfToZip { get { return _invPmtCpnLoanTrsfToZip; } set { _invPmtCpnLoanTrsfToZip = value; } }
        private Value<string> _invPmtCpnPayToAdtlTxt;
        public string InvPmtCpnPayToAdtlTxt { get { return _invPmtCpnPayToAdtlTxt; } set { _invPmtCpnPayToAdtlTxt = value; } }
        private Value<string> _invPmtCpnPayToAdtlTxt2;
        public string InvPmtCpnPayToAdtlTxt2 { get { return _invPmtCpnPayToAdtlTxt2; } set { _invPmtCpnPayToAdtlTxt2 = value; } }
        private Value<string> _invPmtCpnPayToCty;
        public string InvPmtCpnPayToCty { get { return _invPmtCpnPayToCty; } set { _invPmtCpnPayToCty = value; } }
        private Value<string> _invPmtCpnPayToNm;
        public string InvPmtCpnPayToNm { get { return _invPmtCpnPayToNm; } set { _invPmtCpnPayToNm = value; } }
        private Value<string> _invPmtCpnPayToStCd;
        public string InvPmtCpnPayToStCd { get { return _invPmtCpnPayToStCd; } set { _invPmtCpnPayToStCd = value; } }
        private Value<string> _invPmtCpnPayToStreetAddr1;
        public string InvPmtCpnPayToStreetAddr1 { get { return _invPmtCpnPayToStreetAddr1; } set { _invPmtCpnPayToStreetAddr1 = value; } }
        private Value<string> _invPmtCpnPayToStreetAddr2;
        public string InvPmtCpnPayToStreetAddr2 { get { return _invPmtCpnPayToStreetAddr2; } set { _invPmtCpnPayToStreetAddr2 = value; } }
        private Value<string> _invPmtCpnPayToZip;
        public string InvPmtCpnPayToZip { get { return _invPmtCpnPayToZip; } set { _invPmtCpnPayToZip = value; } }
        private Value<string> _invStCd;
        public string InvStCd { get { return _invStCd; } set { _invStCd = value; } }
        private Value<string> _invStreetAddr1;
        public string InvStreetAddr1 { get { return _invStreetAddr1; } set { _invStreetAddr1 = value; } }
        private Value<string> _invStreetAddr2;
        public string InvStreetAddr2 { get { return _invStreetAddr2; } set { _invStreetAddr2 = value; } }
        private Value<string> _invSvcrAdtlTxt;
        public string InvSvcrAdtlTxt { get { return _invSvcrAdtlTxt; } set { _invSvcrAdtlTxt = value; } }
        private Value<string> _invSvcrCntctNm;
        public string InvSvcrCntctNm { get { return _invSvcrCntctNm; } set { _invSvcrCntctNm = value; } }
        private Value<string> _invSvcrCntctPhoneNum;
        public string InvSvcrCntctPhoneNum { get { return _invSvcrCntctPhoneNum; } set { _invSvcrCntctPhoneNum = value; } }
        private Value<string> _invSvcrCntctTollFreePhoneNum;
        public string InvSvcrCntctTollFreePhoneNum { get { return _invSvcrCntctTollFreePhoneNum; } set { _invSvcrCntctTollFreePhoneNum = value; } }
        private Value<string> _invSvcrCty;
        public string InvSvcrCty { get { return _invSvcrCty; } set { _invSvcrCty = value; } }
        private Value<string> _invSvcrDayOp;
        public string InvSvcrDayOp { get { return _invSvcrDayOp; } set { _invSvcrDayOp = value; } }
        private Value<string> _invSvcrDayOpAddl;
        public string InvSvcrDayOpAddl { get { return _invSvcrDayOpAddl; } set { _invSvcrDayOpAddl = value; } }
        private Value<string> _invSvcrHrsOp;
        public string InvSvcrHrsOp { get { return _invSvcrHrsOp; } set { _invSvcrHrsOp = value; } }
        private Value<string> _invSvcrHrsOpAddl;
        public string InvSvcrHrsOpAddl { get { return _invSvcrHrsOpAddl; } set { _invSvcrHrsOpAddl = value; } }
        private Value<string> _invSvcrJrsdctn;
        public string InvSvcrJrsdctn { get { return _invSvcrJrsdctn; } set { _invSvcrJrsdctn = value; } }
        private Value<string> _invSvcrNm;
        public string InvSvcrNm { get { return _invSvcrNm; } set { _invSvcrNm = value; } }
        private Value<string> _invSvcrOrgTyp;
        public string InvSvcrOrgTyp { get { return _invSvcrOrgTyp; } set { _invSvcrOrgTyp = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get { return _invSvcrQlfdWrtnRqstMailToAdtlTxt; } set { _invSvcrQlfdWrtnRqstMailToAdtlTxt = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToCty;
        public string InvSvcrQlfdWrtnRqstMailToCty { get { return _invSvcrQlfdWrtnRqstMailToCty; } set { _invSvcrQlfdWrtnRqstMailToCty = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToNm;
        public string InvSvcrQlfdWrtnRqstMailToNm { get { return _invSvcrQlfdWrtnRqstMailToNm; } set { _invSvcrQlfdWrtnRqstMailToNm = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToStCd;
        public string InvSvcrQlfdWrtnRqstMailToStCd { get { return _invSvcrQlfdWrtnRqstMailToStCd; } set { _invSvcrQlfdWrtnRqstMailToStCd = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get { return _invSvcrQlfdWrtnRqstMailToStreetAddr1; } set { _invSvcrQlfdWrtnRqstMailToStreetAddr1 = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get { return _invSvcrQlfdWrtnRqstMailToStreetAddr2; } set { _invSvcrQlfdWrtnRqstMailToStreetAddr2 = value; } }
        private Value<string> _invSvcrQlfdWrtnRqstMailToZip;
        public string InvSvcrQlfdWrtnRqstMailToZip { get { return _invSvcrQlfdWrtnRqstMailToZip; } set { _invSvcrQlfdWrtnRqstMailToZip = value; } }
        private Value<string> _invSvcrStCd;
        public string InvSvcrStCd { get { return _invSvcrStCd; } set { _invSvcrStCd = value; } }
        private Value<string> _invSvcrStreetAddr1;
        public string InvSvcrStreetAddr1 { get { return _invSvcrStreetAddr1; } set { _invSvcrStreetAddr1 = value; } }
        private Value<string> _invSvcrStreetAddr2;
        public string InvSvcrStreetAddr2 { get { return _invSvcrStreetAddr2; } set { _invSvcrStreetAddr2 = value; } }
        private Value<string> _invSvcrZip;
        public string InvSvcrZip { get { return _invSvcrZip; } set { _invSvcrZip = value; } }
        private Value<string> _invTaxIDNum;
        public string InvTaxIDNum { get { return _invTaxIDNum; } set { _invTaxIDNum = value; } }
        private Value<string> _invTollFreePhoneNum;
        public string InvTollFreePhoneNum { get { return _invTollFreePhoneNum; } set { _invTollFreePhoneNum = value; } }
        private Value<string> _invUrl;
        public string InvUrl { get { return _invUrl; } set { _invUrl = value; } }
        private Value<string> _invZip;
        public string InvZip { get { return _invZip; } set { _invZip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _invAsgnCty.Clean
                    && _invAsgnJrsdctn.Clean
                    && _invAsgnNm.Clean
                    && _invAsgnOrgTyp.Clean
                    && _invAsgnStCd.Clean
                    && _invAsgnStreetAddr1.Clean
                    && _invAsgnStreetAddr2.Clean
                    && _invAsgnZip.Clean
                    && _invCty.Clean
                    && _invFaxNum.Clean
                    && _invJrsdctn.Clean
                    && _invLossPayeeAdtlTxt.Clean
                    && _invLossPayeeCntctEmail.Clean
                    && _invLossPayeeCntctFax.Clean
                    && _invLossPayeeCntctNm.Clean
                    && _invLossPayeeCntctPhone.Clean
                    && _invLossPayeeCty.Clean
                    && _invLossPayeeJrsdctn.Clean
                    && _invLossPayeeNm.Clean
                    && _invLossPayeeOrgTyp.Clean
                    && _invLossPayeeScsrClausTxtDesc.Clean
                    && _invLossPayeeStCd.Clean
                    && _invLossPayeeStreetAddr1.Clean
                    && _invLossPayeeStreetAddr2.Clean
                    && _invLossPayeeZip.Clean
                    && _invNm.Clean
                    && _invOrgTyp.Clean
                    && _invPhoneNum.Clean
                    && _invPmtCpn2PayToAdtlTxt.Clean
                    && _invPmtCpn2PayToAdtlTxt2.Clean
                    && _invPmtCpn2PayToCty.Clean
                    && _invPmtCpn2PayToNm.Clean
                    && _invPmtCpn2PayToStCd.Clean
                    && _invPmtCpn2PayToStreetAddr1.Clean
                    && _invPmtCpn2PayToStreetAddr2.Clean
                    && _invPmtCpn2PayToZip.Clean
                    && _invPmtCpnLoanTrsfToAdtlTxt.Clean
                    && _invPmtCpnLoanTrsfToCty.Clean
                    && _invPmtCpnLoanTrsfToNm.Clean
                    && _invPmtCpnLoanTrsfToStCd.Clean
                    && _invPmtCpnLoanTrsfToStreetAddr1.Clean
                    && _invPmtCpnLoanTrsfToStreetAddr2.Clean
                    && _invPmtCpnLoanTrsfToSvcAdtlTxt.Clean
                    && _invPmtCpnLoanTrsfToSvcCty.Clean
                    && _invPmtCpnLoanTrsfToSvcNm.Clean
                    && _invPmtCpnLoanTrsfToSvcStCd.Clean
                    && _invPmtCpnLoanTrsfToSvcStreetAddr1.Clean
                    && _invPmtCpnLoanTrsfToSvcStreetAddr2.Clean
                    && _invPmtCpnLoanTrsfToSvcZip.Clean
                    && _invPmtCpnLoanTrsfToZip.Clean
                    && _invPmtCpnPayToAdtlTxt.Clean
                    && _invPmtCpnPayToAdtlTxt2.Clean
                    && _invPmtCpnPayToCty.Clean
                    && _invPmtCpnPayToNm.Clean
                    && _invPmtCpnPayToStCd.Clean
                    && _invPmtCpnPayToStreetAddr1.Clean
                    && _invPmtCpnPayToStreetAddr2.Clean
                    && _invPmtCpnPayToZip.Clean
                    && _invStCd.Clean
                    && _invStreetAddr1.Clean
                    && _invStreetAddr2.Clean
                    && _invSvcrAdtlTxt.Clean
                    && _invSvcrCntctNm.Clean
                    && _invSvcrCntctPhoneNum.Clean
                    && _invSvcrCntctTollFreePhoneNum.Clean
                    && _invSvcrCty.Clean
                    && _invSvcrDayOp.Clean
                    && _invSvcrDayOpAddl.Clean
                    && _invSvcrHrsOp.Clean
                    && _invSvcrHrsOpAddl.Clean
                    && _invSvcrJrsdctn.Clean
                    && _invSvcrNm.Clean
                    && _invSvcrOrgTyp.Clean
                    && _invSvcrQlfdWrtnRqstMailToAdtlTxt.Clean
                    && _invSvcrQlfdWrtnRqstMailToCty.Clean
                    && _invSvcrQlfdWrtnRqstMailToNm.Clean
                    && _invSvcrQlfdWrtnRqstMailToStCd.Clean
                    && _invSvcrQlfdWrtnRqstMailToStreetAddr1.Clean
                    && _invSvcrQlfdWrtnRqstMailToStreetAddr2.Clean
                    && _invSvcrQlfdWrtnRqstMailToZip.Clean
                    && _invSvcrStCd.Clean
                    && _invSvcrStreetAddr1.Clean
                    && _invSvcrStreetAddr2.Clean
                    && _invSvcrZip.Clean
                    && _invTaxIDNum.Clean
                    && _invTollFreePhoneNum.Clean
                    && _invUrl.Clean
                    && _invZip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _invAsgnCty; v1.Clean = value; _invAsgnCty = v1;
                var v2 = _invAsgnJrsdctn; v2.Clean = value; _invAsgnJrsdctn = v2;
                var v3 = _invAsgnNm; v3.Clean = value; _invAsgnNm = v3;
                var v4 = _invAsgnOrgTyp; v4.Clean = value; _invAsgnOrgTyp = v4;
                var v5 = _invAsgnStCd; v5.Clean = value; _invAsgnStCd = v5;
                var v6 = _invAsgnStreetAddr1; v6.Clean = value; _invAsgnStreetAddr1 = v6;
                var v7 = _invAsgnStreetAddr2; v7.Clean = value; _invAsgnStreetAddr2 = v7;
                var v8 = _invAsgnZip; v8.Clean = value; _invAsgnZip = v8;
                var v9 = _invCty; v9.Clean = value; _invCty = v9;
                var v10 = _invFaxNum; v10.Clean = value; _invFaxNum = v10;
                var v11 = _invJrsdctn; v11.Clean = value; _invJrsdctn = v11;
                var v12 = _invLossPayeeAdtlTxt; v12.Clean = value; _invLossPayeeAdtlTxt = v12;
                var v13 = _invLossPayeeCntctEmail; v13.Clean = value; _invLossPayeeCntctEmail = v13;
                var v14 = _invLossPayeeCntctFax; v14.Clean = value; _invLossPayeeCntctFax = v14;
                var v15 = _invLossPayeeCntctNm; v15.Clean = value; _invLossPayeeCntctNm = v15;
                var v16 = _invLossPayeeCntctPhone; v16.Clean = value; _invLossPayeeCntctPhone = v16;
                var v17 = _invLossPayeeCty; v17.Clean = value; _invLossPayeeCty = v17;
                var v18 = _invLossPayeeJrsdctn; v18.Clean = value; _invLossPayeeJrsdctn = v18;
                var v19 = _invLossPayeeNm; v19.Clean = value; _invLossPayeeNm = v19;
                var v20 = _invLossPayeeOrgTyp; v20.Clean = value; _invLossPayeeOrgTyp = v20;
                var v21 = _invLossPayeeScsrClausTxtDesc; v21.Clean = value; _invLossPayeeScsrClausTxtDesc = v21;
                var v22 = _invLossPayeeStCd; v22.Clean = value; _invLossPayeeStCd = v22;
                var v23 = _invLossPayeeStreetAddr1; v23.Clean = value; _invLossPayeeStreetAddr1 = v23;
                var v24 = _invLossPayeeStreetAddr2; v24.Clean = value; _invLossPayeeStreetAddr2 = v24;
                var v25 = _invLossPayeeZip; v25.Clean = value; _invLossPayeeZip = v25;
                var v26 = _invNm; v26.Clean = value; _invNm = v26;
                var v27 = _invOrgTyp; v27.Clean = value; _invOrgTyp = v27;
                var v28 = _invPhoneNum; v28.Clean = value; _invPhoneNum = v28;
                var v29 = _invPmtCpn2PayToAdtlTxt; v29.Clean = value; _invPmtCpn2PayToAdtlTxt = v29;
                var v30 = _invPmtCpn2PayToAdtlTxt2; v30.Clean = value; _invPmtCpn2PayToAdtlTxt2 = v30;
                var v31 = _invPmtCpn2PayToCty; v31.Clean = value; _invPmtCpn2PayToCty = v31;
                var v32 = _invPmtCpn2PayToNm; v32.Clean = value; _invPmtCpn2PayToNm = v32;
                var v33 = _invPmtCpn2PayToStCd; v33.Clean = value; _invPmtCpn2PayToStCd = v33;
                var v34 = _invPmtCpn2PayToStreetAddr1; v34.Clean = value; _invPmtCpn2PayToStreetAddr1 = v34;
                var v35 = _invPmtCpn2PayToStreetAddr2; v35.Clean = value; _invPmtCpn2PayToStreetAddr2 = v35;
                var v36 = _invPmtCpn2PayToZip; v36.Clean = value; _invPmtCpn2PayToZip = v36;
                var v37 = _invPmtCpnLoanTrsfToAdtlTxt; v37.Clean = value; _invPmtCpnLoanTrsfToAdtlTxt = v37;
                var v38 = _invPmtCpnLoanTrsfToCty; v38.Clean = value; _invPmtCpnLoanTrsfToCty = v38;
                var v39 = _invPmtCpnLoanTrsfToNm; v39.Clean = value; _invPmtCpnLoanTrsfToNm = v39;
                var v40 = _invPmtCpnLoanTrsfToStCd; v40.Clean = value; _invPmtCpnLoanTrsfToStCd = v40;
                var v41 = _invPmtCpnLoanTrsfToStreetAddr1; v41.Clean = value; _invPmtCpnLoanTrsfToStreetAddr1 = v41;
                var v42 = _invPmtCpnLoanTrsfToStreetAddr2; v42.Clean = value; _invPmtCpnLoanTrsfToStreetAddr2 = v42;
                var v43 = _invPmtCpnLoanTrsfToSvcAdtlTxt; v43.Clean = value; _invPmtCpnLoanTrsfToSvcAdtlTxt = v43;
                var v44 = _invPmtCpnLoanTrsfToSvcCty; v44.Clean = value; _invPmtCpnLoanTrsfToSvcCty = v44;
                var v45 = _invPmtCpnLoanTrsfToSvcNm; v45.Clean = value; _invPmtCpnLoanTrsfToSvcNm = v45;
                var v46 = _invPmtCpnLoanTrsfToSvcStCd; v46.Clean = value; _invPmtCpnLoanTrsfToSvcStCd = v46;
                var v47 = _invPmtCpnLoanTrsfToSvcStreetAddr1; v47.Clean = value; _invPmtCpnLoanTrsfToSvcStreetAddr1 = v47;
                var v48 = _invPmtCpnLoanTrsfToSvcStreetAddr2; v48.Clean = value; _invPmtCpnLoanTrsfToSvcStreetAddr2 = v48;
                var v49 = _invPmtCpnLoanTrsfToSvcZip; v49.Clean = value; _invPmtCpnLoanTrsfToSvcZip = v49;
                var v50 = _invPmtCpnLoanTrsfToZip; v50.Clean = value; _invPmtCpnLoanTrsfToZip = v50;
                var v51 = _invPmtCpnPayToAdtlTxt; v51.Clean = value; _invPmtCpnPayToAdtlTxt = v51;
                var v52 = _invPmtCpnPayToAdtlTxt2; v52.Clean = value; _invPmtCpnPayToAdtlTxt2 = v52;
                var v53 = _invPmtCpnPayToCty; v53.Clean = value; _invPmtCpnPayToCty = v53;
                var v54 = _invPmtCpnPayToNm; v54.Clean = value; _invPmtCpnPayToNm = v54;
                var v55 = _invPmtCpnPayToStCd; v55.Clean = value; _invPmtCpnPayToStCd = v55;
                var v56 = _invPmtCpnPayToStreetAddr1; v56.Clean = value; _invPmtCpnPayToStreetAddr1 = v56;
                var v57 = _invPmtCpnPayToStreetAddr2; v57.Clean = value; _invPmtCpnPayToStreetAddr2 = v57;
                var v58 = _invPmtCpnPayToZip; v58.Clean = value; _invPmtCpnPayToZip = v58;
                var v59 = _invStCd; v59.Clean = value; _invStCd = v59;
                var v60 = _invStreetAddr1; v60.Clean = value; _invStreetAddr1 = v60;
                var v61 = _invStreetAddr2; v61.Clean = value; _invStreetAddr2 = v61;
                var v62 = _invSvcrAdtlTxt; v62.Clean = value; _invSvcrAdtlTxt = v62;
                var v63 = _invSvcrCntctNm; v63.Clean = value; _invSvcrCntctNm = v63;
                var v64 = _invSvcrCntctPhoneNum; v64.Clean = value; _invSvcrCntctPhoneNum = v64;
                var v65 = _invSvcrCntctTollFreePhoneNum; v65.Clean = value; _invSvcrCntctTollFreePhoneNum = v65;
                var v66 = _invSvcrCty; v66.Clean = value; _invSvcrCty = v66;
                var v67 = _invSvcrDayOp; v67.Clean = value; _invSvcrDayOp = v67;
                var v68 = _invSvcrDayOpAddl; v68.Clean = value; _invSvcrDayOpAddl = v68;
                var v69 = _invSvcrHrsOp; v69.Clean = value; _invSvcrHrsOp = v69;
                var v70 = _invSvcrHrsOpAddl; v70.Clean = value; _invSvcrHrsOpAddl = v70;
                var v71 = _invSvcrJrsdctn; v71.Clean = value; _invSvcrJrsdctn = v71;
                var v72 = _invSvcrNm; v72.Clean = value; _invSvcrNm = v72;
                var v73 = _invSvcrOrgTyp; v73.Clean = value; _invSvcrOrgTyp = v73;
                var v74 = _invSvcrQlfdWrtnRqstMailToAdtlTxt; v74.Clean = value; _invSvcrQlfdWrtnRqstMailToAdtlTxt = v74;
                var v75 = _invSvcrQlfdWrtnRqstMailToCty; v75.Clean = value; _invSvcrQlfdWrtnRqstMailToCty = v75;
                var v76 = _invSvcrQlfdWrtnRqstMailToNm; v76.Clean = value; _invSvcrQlfdWrtnRqstMailToNm = v76;
                var v77 = _invSvcrQlfdWrtnRqstMailToStCd; v77.Clean = value; _invSvcrQlfdWrtnRqstMailToStCd = v77;
                var v78 = _invSvcrQlfdWrtnRqstMailToStreetAddr1; v78.Clean = value; _invSvcrQlfdWrtnRqstMailToStreetAddr1 = v78;
                var v79 = _invSvcrQlfdWrtnRqstMailToStreetAddr2; v79.Clean = value; _invSvcrQlfdWrtnRqstMailToStreetAddr2 = v79;
                var v80 = _invSvcrQlfdWrtnRqstMailToZip; v80.Clean = value; _invSvcrQlfdWrtnRqstMailToZip = v80;
                var v81 = _invSvcrStCd; v81.Clean = value; _invSvcrStCd = v81;
                var v82 = _invSvcrStreetAddr1; v82.Clean = value; _invSvcrStreetAddr1 = v82;
                var v83 = _invSvcrStreetAddr2; v83.Clean = value; _invSvcrStreetAddr2 = v83;
                var v84 = _invSvcrZip; v84.Clean = value; _invSvcrZip = v84;
                var v85 = _invTaxIDNum; v85.Clean = value; _invTaxIDNum = v85;
                var v86 = _invTollFreePhoneNum; v86.Clean = value; _invTollFreePhoneNum = v86;
                var v87 = _invUrl; v87.Clean = value; _invUrl = v87;
                var v88 = _invZip; v88.Clean = value; _invZip = v88;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}