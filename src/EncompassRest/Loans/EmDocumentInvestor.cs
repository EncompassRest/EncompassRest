using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var id = _id; id.Clean = value; _id = id;
                var invAsgnCty = _invAsgnCty; invAsgnCty.Clean = value; _invAsgnCty = invAsgnCty;
                var invAsgnJrsdctn = _invAsgnJrsdctn; invAsgnJrsdctn.Clean = value; _invAsgnJrsdctn = invAsgnJrsdctn;
                var invAsgnNm = _invAsgnNm; invAsgnNm.Clean = value; _invAsgnNm = invAsgnNm;
                var invAsgnOrgTyp = _invAsgnOrgTyp; invAsgnOrgTyp.Clean = value; _invAsgnOrgTyp = invAsgnOrgTyp;
                var invAsgnStCd = _invAsgnStCd; invAsgnStCd.Clean = value; _invAsgnStCd = invAsgnStCd;
                var invAsgnStreetAddr1 = _invAsgnStreetAddr1; invAsgnStreetAddr1.Clean = value; _invAsgnStreetAddr1 = invAsgnStreetAddr1;
                var invAsgnStreetAddr2 = _invAsgnStreetAddr2; invAsgnStreetAddr2.Clean = value; _invAsgnStreetAddr2 = invAsgnStreetAddr2;
                var invAsgnZip = _invAsgnZip; invAsgnZip.Clean = value; _invAsgnZip = invAsgnZip;
                var invCty = _invCty; invCty.Clean = value; _invCty = invCty;
                var invFaxNum = _invFaxNum; invFaxNum.Clean = value; _invFaxNum = invFaxNum;
                var invJrsdctn = _invJrsdctn; invJrsdctn.Clean = value; _invJrsdctn = invJrsdctn;
                var invLossPayeeAdtlTxt = _invLossPayeeAdtlTxt; invLossPayeeAdtlTxt.Clean = value; _invLossPayeeAdtlTxt = invLossPayeeAdtlTxt;
                var invLossPayeeCntctEmail = _invLossPayeeCntctEmail; invLossPayeeCntctEmail.Clean = value; _invLossPayeeCntctEmail = invLossPayeeCntctEmail;
                var invLossPayeeCntctFax = _invLossPayeeCntctFax; invLossPayeeCntctFax.Clean = value; _invLossPayeeCntctFax = invLossPayeeCntctFax;
                var invLossPayeeCntctNm = _invLossPayeeCntctNm; invLossPayeeCntctNm.Clean = value; _invLossPayeeCntctNm = invLossPayeeCntctNm;
                var invLossPayeeCntctPhone = _invLossPayeeCntctPhone; invLossPayeeCntctPhone.Clean = value; _invLossPayeeCntctPhone = invLossPayeeCntctPhone;
                var invLossPayeeCty = _invLossPayeeCty; invLossPayeeCty.Clean = value; _invLossPayeeCty = invLossPayeeCty;
                var invLossPayeeJrsdctn = _invLossPayeeJrsdctn; invLossPayeeJrsdctn.Clean = value; _invLossPayeeJrsdctn = invLossPayeeJrsdctn;
                var invLossPayeeNm = _invLossPayeeNm; invLossPayeeNm.Clean = value; _invLossPayeeNm = invLossPayeeNm;
                var invLossPayeeOrgTyp = _invLossPayeeOrgTyp; invLossPayeeOrgTyp.Clean = value; _invLossPayeeOrgTyp = invLossPayeeOrgTyp;
                var invLossPayeeScsrClausTxtDesc = _invLossPayeeScsrClausTxtDesc; invLossPayeeScsrClausTxtDesc.Clean = value; _invLossPayeeScsrClausTxtDesc = invLossPayeeScsrClausTxtDesc;
                var invLossPayeeStCd = _invLossPayeeStCd; invLossPayeeStCd.Clean = value; _invLossPayeeStCd = invLossPayeeStCd;
                var invLossPayeeStreetAddr1 = _invLossPayeeStreetAddr1; invLossPayeeStreetAddr1.Clean = value; _invLossPayeeStreetAddr1 = invLossPayeeStreetAddr1;
                var invLossPayeeStreetAddr2 = _invLossPayeeStreetAddr2; invLossPayeeStreetAddr2.Clean = value; _invLossPayeeStreetAddr2 = invLossPayeeStreetAddr2;
                var invLossPayeeZip = _invLossPayeeZip; invLossPayeeZip.Clean = value; _invLossPayeeZip = invLossPayeeZip;
                var invNm = _invNm; invNm.Clean = value; _invNm = invNm;
                var invOrgTyp = _invOrgTyp; invOrgTyp.Clean = value; _invOrgTyp = invOrgTyp;
                var invPhoneNum = _invPhoneNum; invPhoneNum.Clean = value; _invPhoneNum = invPhoneNum;
                var invPmtCpn2PayToAdtlTxt = _invPmtCpn2PayToAdtlTxt; invPmtCpn2PayToAdtlTxt.Clean = value; _invPmtCpn2PayToAdtlTxt = invPmtCpn2PayToAdtlTxt;
                var invPmtCpn2PayToAdtlTxt2 = _invPmtCpn2PayToAdtlTxt2; invPmtCpn2PayToAdtlTxt2.Clean = value; _invPmtCpn2PayToAdtlTxt2 = invPmtCpn2PayToAdtlTxt2;
                var invPmtCpn2PayToCty = _invPmtCpn2PayToCty; invPmtCpn2PayToCty.Clean = value; _invPmtCpn2PayToCty = invPmtCpn2PayToCty;
                var invPmtCpn2PayToNm = _invPmtCpn2PayToNm; invPmtCpn2PayToNm.Clean = value; _invPmtCpn2PayToNm = invPmtCpn2PayToNm;
                var invPmtCpn2PayToStCd = _invPmtCpn2PayToStCd; invPmtCpn2PayToStCd.Clean = value; _invPmtCpn2PayToStCd = invPmtCpn2PayToStCd;
                var invPmtCpn2PayToStreetAddr1 = _invPmtCpn2PayToStreetAddr1; invPmtCpn2PayToStreetAddr1.Clean = value; _invPmtCpn2PayToStreetAddr1 = invPmtCpn2PayToStreetAddr1;
                var invPmtCpn2PayToStreetAddr2 = _invPmtCpn2PayToStreetAddr2; invPmtCpn2PayToStreetAddr2.Clean = value; _invPmtCpn2PayToStreetAddr2 = invPmtCpn2PayToStreetAddr2;
                var invPmtCpn2PayToZip = _invPmtCpn2PayToZip; invPmtCpn2PayToZip.Clean = value; _invPmtCpn2PayToZip = invPmtCpn2PayToZip;
                var invPmtCpnLoanTrsfToAdtlTxt = _invPmtCpnLoanTrsfToAdtlTxt; invPmtCpnLoanTrsfToAdtlTxt.Clean = value; _invPmtCpnLoanTrsfToAdtlTxt = invPmtCpnLoanTrsfToAdtlTxt;
                var invPmtCpnLoanTrsfToCty = _invPmtCpnLoanTrsfToCty; invPmtCpnLoanTrsfToCty.Clean = value; _invPmtCpnLoanTrsfToCty = invPmtCpnLoanTrsfToCty;
                var invPmtCpnLoanTrsfToNm = _invPmtCpnLoanTrsfToNm; invPmtCpnLoanTrsfToNm.Clean = value; _invPmtCpnLoanTrsfToNm = invPmtCpnLoanTrsfToNm;
                var invPmtCpnLoanTrsfToStCd = _invPmtCpnLoanTrsfToStCd; invPmtCpnLoanTrsfToStCd.Clean = value; _invPmtCpnLoanTrsfToStCd = invPmtCpnLoanTrsfToStCd;
                var invPmtCpnLoanTrsfToStreetAddr1 = _invPmtCpnLoanTrsfToStreetAddr1; invPmtCpnLoanTrsfToStreetAddr1.Clean = value; _invPmtCpnLoanTrsfToStreetAddr1 = invPmtCpnLoanTrsfToStreetAddr1;
                var invPmtCpnLoanTrsfToStreetAddr2 = _invPmtCpnLoanTrsfToStreetAddr2; invPmtCpnLoanTrsfToStreetAddr2.Clean = value; _invPmtCpnLoanTrsfToStreetAddr2 = invPmtCpnLoanTrsfToStreetAddr2;
                var invPmtCpnLoanTrsfToSvcAdtlTxt = _invPmtCpnLoanTrsfToSvcAdtlTxt; invPmtCpnLoanTrsfToSvcAdtlTxt.Clean = value; _invPmtCpnLoanTrsfToSvcAdtlTxt = invPmtCpnLoanTrsfToSvcAdtlTxt;
                var invPmtCpnLoanTrsfToSvcCty = _invPmtCpnLoanTrsfToSvcCty; invPmtCpnLoanTrsfToSvcCty.Clean = value; _invPmtCpnLoanTrsfToSvcCty = invPmtCpnLoanTrsfToSvcCty;
                var invPmtCpnLoanTrsfToSvcNm = _invPmtCpnLoanTrsfToSvcNm; invPmtCpnLoanTrsfToSvcNm.Clean = value; _invPmtCpnLoanTrsfToSvcNm = invPmtCpnLoanTrsfToSvcNm;
                var invPmtCpnLoanTrsfToSvcStCd = _invPmtCpnLoanTrsfToSvcStCd; invPmtCpnLoanTrsfToSvcStCd.Clean = value; _invPmtCpnLoanTrsfToSvcStCd = invPmtCpnLoanTrsfToSvcStCd;
                var invPmtCpnLoanTrsfToSvcStreetAddr1 = _invPmtCpnLoanTrsfToSvcStreetAddr1; invPmtCpnLoanTrsfToSvcStreetAddr1.Clean = value; _invPmtCpnLoanTrsfToSvcStreetAddr1 = invPmtCpnLoanTrsfToSvcStreetAddr1;
                var invPmtCpnLoanTrsfToSvcStreetAddr2 = _invPmtCpnLoanTrsfToSvcStreetAddr2; invPmtCpnLoanTrsfToSvcStreetAddr2.Clean = value; _invPmtCpnLoanTrsfToSvcStreetAddr2 = invPmtCpnLoanTrsfToSvcStreetAddr2;
                var invPmtCpnLoanTrsfToSvcZip = _invPmtCpnLoanTrsfToSvcZip; invPmtCpnLoanTrsfToSvcZip.Clean = value; _invPmtCpnLoanTrsfToSvcZip = invPmtCpnLoanTrsfToSvcZip;
                var invPmtCpnLoanTrsfToZip = _invPmtCpnLoanTrsfToZip; invPmtCpnLoanTrsfToZip.Clean = value; _invPmtCpnLoanTrsfToZip = invPmtCpnLoanTrsfToZip;
                var invPmtCpnPayToAdtlTxt = _invPmtCpnPayToAdtlTxt; invPmtCpnPayToAdtlTxt.Clean = value; _invPmtCpnPayToAdtlTxt = invPmtCpnPayToAdtlTxt;
                var invPmtCpnPayToAdtlTxt2 = _invPmtCpnPayToAdtlTxt2; invPmtCpnPayToAdtlTxt2.Clean = value; _invPmtCpnPayToAdtlTxt2 = invPmtCpnPayToAdtlTxt2;
                var invPmtCpnPayToCty = _invPmtCpnPayToCty; invPmtCpnPayToCty.Clean = value; _invPmtCpnPayToCty = invPmtCpnPayToCty;
                var invPmtCpnPayToNm = _invPmtCpnPayToNm; invPmtCpnPayToNm.Clean = value; _invPmtCpnPayToNm = invPmtCpnPayToNm;
                var invPmtCpnPayToStCd = _invPmtCpnPayToStCd; invPmtCpnPayToStCd.Clean = value; _invPmtCpnPayToStCd = invPmtCpnPayToStCd;
                var invPmtCpnPayToStreetAddr1 = _invPmtCpnPayToStreetAddr1; invPmtCpnPayToStreetAddr1.Clean = value; _invPmtCpnPayToStreetAddr1 = invPmtCpnPayToStreetAddr1;
                var invPmtCpnPayToStreetAddr2 = _invPmtCpnPayToStreetAddr2; invPmtCpnPayToStreetAddr2.Clean = value; _invPmtCpnPayToStreetAddr2 = invPmtCpnPayToStreetAddr2;
                var invPmtCpnPayToZip = _invPmtCpnPayToZip; invPmtCpnPayToZip.Clean = value; _invPmtCpnPayToZip = invPmtCpnPayToZip;
                var invStCd = _invStCd; invStCd.Clean = value; _invStCd = invStCd;
                var invStreetAddr1 = _invStreetAddr1; invStreetAddr1.Clean = value; _invStreetAddr1 = invStreetAddr1;
                var invStreetAddr2 = _invStreetAddr2; invStreetAddr2.Clean = value; _invStreetAddr2 = invStreetAddr2;
                var invSvcrAdtlTxt = _invSvcrAdtlTxt; invSvcrAdtlTxt.Clean = value; _invSvcrAdtlTxt = invSvcrAdtlTxt;
                var invSvcrCntctNm = _invSvcrCntctNm; invSvcrCntctNm.Clean = value; _invSvcrCntctNm = invSvcrCntctNm;
                var invSvcrCntctPhoneNum = _invSvcrCntctPhoneNum; invSvcrCntctPhoneNum.Clean = value; _invSvcrCntctPhoneNum = invSvcrCntctPhoneNum;
                var invSvcrCntctTollFreePhoneNum = _invSvcrCntctTollFreePhoneNum; invSvcrCntctTollFreePhoneNum.Clean = value; _invSvcrCntctTollFreePhoneNum = invSvcrCntctTollFreePhoneNum;
                var invSvcrCty = _invSvcrCty; invSvcrCty.Clean = value; _invSvcrCty = invSvcrCty;
                var invSvcrDayOp = _invSvcrDayOp; invSvcrDayOp.Clean = value; _invSvcrDayOp = invSvcrDayOp;
                var invSvcrDayOpAddl = _invSvcrDayOpAddl; invSvcrDayOpAddl.Clean = value; _invSvcrDayOpAddl = invSvcrDayOpAddl;
                var invSvcrHrsOp = _invSvcrHrsOp; invSvcrHrsOp.Clean = value; _invSvcrHrsOp = invSvcrHrsOp;
                var invSvcrHrsOpAddl = _invSvcrHrsOpAddl; invSvcrHrsOpAddl.Clean = value; _invSvcrHrsOpAddl = invSvcrHrsOpAddl;
                var invSvcrJrsdctn = _invSvcrJrsdctn; invSvcrJrsdctn.Clean = value; _invSvcrJrsdctn = invSvcrJrsdctn;
                var invSvcrNm = _invSvcrNm; invSvcrNm.Clean = value; _invSvcrNm = invSvcrNm;
                var invSvcrOrgTyp = _invSvcrOrgTyp; invSvcrOrgTyp.Clean = value; _invSvcrOrgTyp = invSvcrOrgTyp;
                var invSvcrQlfdWrtnRqstMailToAdtlTxt = _invSvcrQlfdWrtnRqstMailToAdtlTxt; invSvcrQlfdWrtnRqstMailToAdtlTxt.Clean = value; _invSvcrQlfdWrtnRqstMailToAdtlTxt = invSvcrQlfdWrtnRqstMailToAdtlTxt;
                var invSvcrQlfdWrtnRqstMailToCty = _invSvcrQlfdWrtnRqstMailToCty; invSvcrQlfdWrtnRqstMailToCty.Clean = value; _invSvcrQlfdWrtnRqstMailToCty = invSvcrQlfdWrtnRqstMailToCty;
                var invSvcrQlfdWrtnRqstMailToNm = _invSvcrQlfdWrtnRqstMailToNm; invSvcrQlfdWrtnRqstMailToNm.Clean = value; _invSvcrQlfdWrtnRqstMailToNm = invSvcrQlfdWrtnRqstMailToNm;
                var invSvcrQlfdWrtnRqstMailToStCd = _invSvcrQlfdWrtnRqstMailToStCd; invSvcrQlfdWrtnRqstMailToStCd.Clean = value; _invSvcrQlfdWrtnRqstMailToStCd = invSvcrQlfdWrtnRqstMailToStCd;
                var invSvcrQlfdWrtnRqstMailToStreetAddr1 = _invSvcrQlfdWrtnRqstMailToStreetAddr1; invSvcrQlfdWrtnRqstMailToStreetAddr1.Clean = value; _invSvcrQlfdWrtnRqstMailToStreetAddr1 = invSvcrQlfdWrtnRqstMailToStreetAddr1;
                var invSvcrQlfdWrtnRqstMailToStreetAddr2 = _invSvcrQlfdWrtnRqstMailToStreetAddr2; invSvcrQlfdWrtnRqstMailToStreetAddr2.Clean = value; _invSvcrQlfdWrtnRqstMailToStreetAddr2 = invSvcrQlfdWrtnRqstMailToStreetAddr2;
                var invSvcrQlfdWrtnRqstMailToZip = _invSvcrQlfdWrtnRqstMailToZip; invSvcrQlfdWrtnRqstMailToZip.Clean = value; _invSvcrQlfdWrtnRqstMailToZip = invSvcrQlfdWrtnRqstMailToZip;
                var invSvcrStCd = _invSvcrStCd; invSvcrStCd.Clean = value; _invSvcrStCd = invSvcrStCd;
                var invSvcrStreetAddr1 = _invSvcrStreetAddr1; invSvcrStreetAddr1.Clean = value; _invSvcrStreetAddr1 = invSvcrStreetAddr1;
                var invSvcrStreetAddr2 = _invSvcrStreetAddr2; invSvcrStreetAddr2.Clean = value; _invSvcrStreetAddr2 = invSvcrStreetAddr2;
                var invSvcrZip = _invSvcrZip; invSvcrZip.Clean = value; _invSvcrZip = invSvcrZip;
                var invTaxIDNum = _invTaxIDNum; invTaxIDNum.Clean = value; _invTaxIDNum = invTaxIDNum;
                var invTollFreePhoneNum = _invTollFreePhoneNum; invTollFreePhoneNum.Clean = value; _invTollFreePhoneNum = invTollFreePhoneNum;
                var invUrl = _invUrl; invUrl.Clean = value; _invUrl = invUrl;
                var invZip = _invZip; invZip.Clean = value; _invZip = invZip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public EmDocumentInvestor()
        {
            Clean = true;
        }
    }
}