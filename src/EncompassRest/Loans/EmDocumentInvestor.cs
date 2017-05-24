using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentInvestor
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InvAsgnCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnCty() => !InvAsgnCty.Clean;
        public Value<string> InvAsgnJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnJrsdctn() => !InvAsgnJrsdctn.Clean;
        public Value<string> InvAsgnNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnNm() => !InvAsgnNm.Clean;
        public Value<string> InvAsgnOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnOrgTyp() => !InvAsgnOrgTyp.Clean;
        public Value<string> InvAsgnStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnStCd() => !InvAsgnStCd.Clean;
        public Value<string> InvAsgnStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnStreetAddr1() => !InvAsgnStreetAddr1.Clean;
        public Value<string> InvAsgnStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnStreetAddr2() => !InvAsgnStreetAddr2.Clean;
        public Value<string> InvAsgnZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvAsgnZip() => !InvAsgnZip.Clean;
        public Value<string> InvCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvCty() => !InvCty.Clean;
        public Value<string> InvFaxNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvFaxNum() => !InvFaxNum.Clean;
        public Value<string> InvJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvJrsdctn() => !InvJrsdctn.Clean;
        public Value<string> InvLossPayeeAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeAdtlTxt() => !InvLossPayeeAdtlTxt.Clean;
        public Value<string> InvLossPayeeCntctEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeCntctEmail() => !InvLossPayeeCntctEmail.Clean;
        public Value<string> InvLossPayeeCntctFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeCntctFax() => !InvLossPayeeCntctFax.Clean;
        public Value<string> InvLossPayeeCntctNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeCntctNm() => !InvLossPayeeCntctNm.Clean;
        public Value<string> InvLossPayeeCntctPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeCntctPhone() => !InvLossPayeeCntctPhone.Clean;
        public Value<string> InvLossPayeeCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeCty() => !InvLossPayeeCty.Clean;
        public Value<string> InvLossPayeeJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeJrsdctn() => !InvLossPayeeJrsdctn.Clean;
        public Value<string> InvLossPayeeNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeNm() => !InvLossPayeeNm.Clean;
        public Value<string> InvLossPayeeOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeOrgTyp() => !InvLossPayeeOrgTyp.Clean;
        public Value<string> InvLossPayeeScsrClausTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeScsrClausTxtDesc() => !InvLossPayeeScsrClausTxtDesc.Clean;
        public Value<string> InvLossPayeeStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeStCd() => !InvLossPayeeStCd.Clean;
        public Value<string> InvLossPayeeStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeStreetAddr1() => !InvLossPayeeStreetAddr1.Clean;
        public Value<string> InvLossPayeeStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeStreetAddr2() => !InvLossPayeeStreetAddr2.Clean;
        public Value<string> InvLossPayeeZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvLossPayeeZip() => !InvLossPayeeZip.Clean;
        public Value<string> InvNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvNm() => !InvNm.Clean;
        public Value<string> InvOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvOrgTyp() => !InvOrgTyp.Clean;
        public Value<string> InvPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPhoneNum() => !InvPhoneNum.Clean;
        public Value<string> InvPmtCpn2PayToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToAdtlTxt() => !InvPmtCpn2PayToAdtlTxt.Clean;
        public Value<string> InvPmtCpn2PayToAdtlTxt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToAdtlTxt2() => !InvPmtCpn2PayToAdtlTxt2.Clean;
        public Value<string> InvPmtCpn2PayToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToCty() => !InvPmtCpn2PayToCty.Clean;
        public Value<string> InvPmtCpn2PayToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToNm() => !InvPmtCpn2PayToNm.Clean;
        public Value<string> InvPmtCpn2PayToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToStCd() => !InvPmtCpn2PayToStCd.Clean;
        public Value<string> InvPmtCpn2PayToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToStreetAddr1() => !InvPmtCpn2PayToStreetAddr1.Clean;
        public Value<string> InvPmtCpn2PayToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToStreetAddr2() => !InvPmtCpn2PayToStreetAddr2.Clean;
        public Value<string> InvPmtCpn2PayToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpn2PayToZip() => !InvPmtCpn2PayToZip.Clean;
        public Value<string> InvPmtCpnLoanTrsfToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToAdtlTxt() => !InvPmtCpnLoanTrsfToAdtlTxt.Clean;
        public Value<string> InvPmtCpnLoanTrsfToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToCty() => !InvPmtCpnLoanTrsfToCty.Clean;
        public Value<string> InvPmtCpnLoanTrsfToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToNm() => !InvPmtCpnLoanTrsfToNm.Clean;
        public Value<string> InvPmtCpnLoanTrsfToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToStCd() => !InvPmtCpnLoanTrsfToStCd.Clean;
        public Value<string> InvPmtCpnLoanTrsfToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToStreetAddr1() => !InvPmtCpnLoanTrsfToStreetAddr1.Clean;
        public Value<string> InvPmtCpnLoanTrsfToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToStreetAddr2() => !InvPmtCpnLoanTrsfToStreetAddr2.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcAdtlTxt() => !InvPmtCpnLoanTrsfToSvcAdtlTxt.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcCty() => !InvPmtCpnLoanTrsfToSvcCty.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcNm() => !InvPmtCpnLoanTrsfToSvcNm.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcStCd() => !InvPmtCpnLoanTrsfToSvcStCd.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcStreetAddr1() => !InvPmtCpnLoanTrsfToSvcStreetAddr1.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcStreetAddr2() => !InvPmtCpnLoanTrsfToSvcStreetAddr2.Clean;
        public Value<string> InvPmtCpnLoanTrsfToSvcZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToSvcZip() => !InvPmtCpnLoanTrsfToSvcZip.Clean;
        public Value<string> InvPmtCpnLoanTrsfToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnLoanTrsfToZip() => !InvPmtCpnLoanTrsfToZip.Clean;
        public Value<string> InvPmtCpnPayToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToAdtlTxt() => !InvPmtCpnPayToAdtlTxt.Clean;
        public Value<string> InvPmtCpnPayToAdtlTxt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToAdtlTxt2() => !InvPmtCpnPayToAdtlTxt2.Clean;
        public Value<string> InvPmtCpnPayToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToCty() => !InvPmtCpnPayToCty.Clean;
        public Value<string> InvPmtCpnPayToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToNm() => !InvPmtCpnPayToNm.Clean;
        public Value<string> InvPmtCpnPayToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToStCd() => !InvPmtCpnPayToStCd.Clean;
        public Value<string> InvPmtCpnPayToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToStreetAddr1() => !InvPmtCpnPayToStreetAddr1.Clean;
        public Value<string> InvPmtCpnPayToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToStreetAddr2() => !InvPmtCpnPayToStreetAddr2.Clean;
        public Value<string> InvPmtCpnPayToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvPmtCpnPayToZip() => !InvPmtCpnPayToZip.Clean;
        public Value<string> InvStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvStCd() => !InvStCd.Clean;
        public Value<string> InvStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvStreetAddr1() => !InvStreetAddr1.Clean;
        public Value<string> InvStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvStreetAddr2() => !InvStreetAddr2.Clean;
        public Value<string> InvSvcrAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrAdtlTxt() => !InvSvcrAdtlTxt.Clean;
        public Value<string> InvSvcrCntctNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrCntctNm() => !InvSvcrCntctNm.Clean;
        public Value<string> InvSvcrCntctPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrCntctPhoneNum() => !InvSvcrCntctPhoneNum.Clean;
        public Value<string> InvSvcrCntctTollFreePhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrCntctTollFreePhoneNum() => !InvSvcrCntctTollFreePhoneNum.Clean;
        public Value<string> InvSvcrCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrCty() => !InvSvcrCty.Clean;
        public Value<string> InvSvcrDayOp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrDayOp() => !InvSvcrDayOp.Clean;
        public Value<string> InvSvcrDayOpAddl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrDayOpAddl() => !InvSvcrDayOpAddl.Clean;
        public Value<string> InvSvcrHrsOp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrHrsOp() => !InvSvcrHrsOp.Clean;
        public Value<string> InvSvcrHrsOpAddl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrHrsOpAddl() => !InvSvcrHrsOpAddl.Clean;
        public Value<string> InvSvcrJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrJrsdctn() => !InvSvcrJrsdctn.Clean;
        public Value<string> InvSvcrNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrNm() => !InvSvcrNm.Clean;
        public Value<string> InvSvcrOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrOrgTyp() => !InvSvcrOrgTyp.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToAdtlTxt() => !InvSvcrQlfdWrtnRqstMailToAdtlTxt.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToCty() => !InvSvcrQlfdWrtnRqstMailToCty.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToNm() => !InvSvcrQlfdWrtnRqstMailToNm.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToStCd() => !InvSvcrQlfdWrtnRqstMailToStCd.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToStreetAddr1() => !InvSvcrQlfdWrtnRqstMailToStreetAddr1.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToStreetAddr2() => !InvSvcrQlfdWrtnRqstMailToStreetAddr2.Clean;
        public Value<string> InvSvcrQlfdWrtnRqstMailToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrQlfdWrtnRqstMailToZip() => !InvSvcrQlfdWrtnRqstMailToZip.Clean;
        public Value<string> InvSvcrStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrStCd() => !InvSvcrStCd.Clean;
        public Value<string> InvSvcrStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrStreetAddr1() => !InvSvcrStreetAddr1.Clean;
        public Value<string> InvSvcrStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrStreetAddr2() => !InvSvcrStreetAddr2.Clean;
        public Value<string> InvSvcrZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvSvcrZip() => !InvSvcrZip.Clean;
        public Value<string> InvTaxIDNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvTaxIDNum() => !InvTaxIDNum.Clean;
        public Value<string> InvTollFreePhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvTollFreePhoneNum() => !InvTollFreePhoneNum.Clean;
        public Value<string> InvUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvUrl() => !InvUrl.Clean;
        public Value<string> InvZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvZip() => !InvZip.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && InvAsgnCty.Clean
                    && InvAsgnJrsdctn.Clean
                    && InvAsgnNm.Clean
                    && InvAsgnOrgTyp.Clean
                    && InvAsgnStCd.Clean
                    && InvAsgnStreetAddr1.Clean
                    && InvAsgnStreetAddr2.Clean
                    && InvAsgnZip.Clean
                    && InvCty.Clean
                    && InvFaxNum.Clean
                    && InvJrsdctn.Clean
                    && InvLossPayeeAdtlTxt.Clean
                    && InvLossPayeeCntctEmail.Clean
                    && InvLossPayeeCntctFax.Clean
                    && InvLossPayeeCntctNm.Clean
                    && InvLossPayeeCntctPhone.Clean
                    && InvLossPayeeCty.Clean
                    && InvLossPayeeJrsdctn.Clean
                    && InvLossPayeeNm.Clean
                    && InvLossPayeeOrgTyp.Clean
                    && InvLossPayeeScsrClausTxtDesc.Clean
                    && InvLossPayeeStCd.Clean
                    && InvLossPayeeStreetAddr1.Clean
                    && InvLossPayeeStreetAddr2.Clean
                    && InvLossPayeeZip.Clean
                    && InvNm.Clean
                    && InvOrgTyp.Clean
                    && InvPhoneNum.Clean
                    && InvPmtCpn2PayToAdtlTxt.Clean
                    && InvPmtCpn2PayToAdtlTxt2.Clean
                    && InvPmtCpn2PayToCty.Clean
                    && InvPmtCpn2PayToNm.Clean
                    && InvPmtCpn2PayToStCd.Clean
                    && InvPmtCpn2PayToStreetAddr1.Clean
                    && InvPmtCpn2PayToStreetAddr2.Clean
                    && InvPmtCpn2PayToZip.Clean
                    && InvPmtCpnLoanTrsfToAdtlTxt.Clean
                    && InvPmtCpnLoanTrsfToCty.Clean
                    && InvPmtCpnLoanTrsfToNm.Clean
                    && InvPmtCpnLoanTrsfToStCd.Clean
                    && InvPmtCpnLoanTrsfToStreetAddr1.Clean
                    && InvPmtCpnLoanTrsfToStreetAddr2.Clean
                    && InvPmtCpnLoanTrsfToSvcAdtlTxt.Clean
                    && InvPmtCpnLoanTrsfToSvcCty.Clean
                    && InvPmtCpnLoanTrsfToSvcNm.Clean
                    && InvPmtCpnLoanTrsfToSvcStCd.Clean
                    && InvPmtCpnLoanTrsfToSvcStreetAddr1.Clean
                    && InvPmtCpnLoanTrsfToSvcStreetAddr2.Clean
                    && InvPmtCpnLoanTrsfToSvcZip.Clean
                    && InvPmtCpnLoanTrsfToZip.Clean
                    && InvPmtCpnPayToAdtlTxt.Clean
                    && InvPmtCpnPayToAdtlTxt2.Clean
                    && InvPmtCpnPayToCty.Clean
                    && InvPmtCpnPayToNm.Clean
                    && InvPmtCpnPayToStCd.Clean
                    && InvPmtCpnPayToStreetAddr1.Clean
                    && InvPmtCpnPayToStreetAddr2.Clean
                    && InvPmtCpnPayToZip.Clean
                    && InvStCd.Clean
                    && InvStreetAddr1.Clean
                    && InvStreetAddr2.Clean
                    && InvSvcrAdtlTxt.Clean
                    && InvSvcrCntctNm.Clean
                    && InvSvcrCntctPhoneNum.Clean
                    && InvSvcrCntctTollFreePhoneNum.Clean
                    && InvSvcrCty.Clean
                    && InvSvcrDayOp.Clean
                    && InvSvcrDayOpAddl.Clean
                    && InvSvcrHrsOp.Clean
                    && InvSvcrHrsOpAddl.Clean
                    && InvSvcrJrsdctn.Clean
                    && InvSvcrNm.Clean
                    && InvSvcrOrgTyp.Clean
                    && InvSvcrQlfdWrtnRqstMailToAdtlTxt.Clean
                    && InvSvcrQlfdWrtnRqstMailToCty.Clean
                    && InvSvcrQlfdWrtnRqstMailToNm.Clean
                    && InvSvcrQlfdWrtnRqstMailToStCd.Clean
                    && InvSvcrQlfdWrtnRqstMailToStreetAddr1.Clean
                    && InvSvcrQlfdWrtnRqstMailToStreetAddr2.Clean
                    && InvSvcrQlfdWrtnRqstMailToZip.Clean
                    && InvSvcrStCd.Clean
                    && InvSvcrStreetAddr1.Clean
                    && InvSvcrStreetAddr2.Clean
                    && InvSvcrZip.Clean
                    && InvTaxIDNum.Clean
                    && InvTollFreePhoneNum.Clean
                    && InvUrl.Clean
                    && InvZip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = InvAsgnCty; v1.Clean = value; InvAsgnCty = v1;
                var v2 = InvAsgnJrsdctn; v2.Clean = value; InvAsgnJrsdctn = v2;
                var v3 = InvAsgnNm; v3.Clean = value; InvAsgnNm = v3;
                var v4 = InvAsgnOrgTyp; v4.Clean = value; InvAsgnOrgTyp = v4;
                var v5 = InvAsgnStCd; v5.Clean = value; InvAsgnStCd = v5;
                var v6 = InvAsgnStreetAddr1; v6.Clean = value; InvAsgnStreetAddr1 = v6;
                var v7 = InvAsgnStreetAddr2; v7.Clean = value; InvAsgnStreetAddr2 = v7;
                var v8 = InvAsgnZip; v8.Clean = value; InvAsgnZip = v8;
                var v9 = InvCty; v9.Clean = value; InvCty = v9;
                var v10 = InvFaxNum; v10.Clean = value; InvFaxNum = v10;
                var v11 = InvJrsdctn; v11.Clean = value; InvJrsdctn = v11;
                var v12 = InvLossPayeeAdtlTxt; v12.Clean = value; InvLossPayeeAdtlTxt = v12;
                var v13 = InvLossPayeeCntctEmail; v13.Clean = value; InvLossPayeeCntctEmail = v13;
                var v14 = InvLossPayeeCntctFax; v14.Clean = value; InvLossPayeeCntctFax = v14;
                var v15 = InvLossPayeeCntctNm; v15.Clean = value; InvLossPayeeCntctNm = v15;
                var v16 = InvLossPayeeCntctPhone; v16.Clean = value; InvLossPayeeCntctPhone = v16;
                var v17 = InvLossPayeeCty; v17.Clean = value; InvLossPayeeCty = v17;
                var v18 = InvLossPayeeJrsdctn; v18.Clean = value; InvLossPayeeJrsdctn = v18;
                var v19 = InvLossPayeeNm; v19.Clean = value; InvLossPayeeNm = v19;
                var v20 = InvLossPayeeOrgTyp; v20.Clean = value; InvLossPayeeOrgTyp = v20;
                var v21 = InvLossPayeeScsrClausTxtDesc; v21.Clean = value; InvLossPayeeScsrClausTxtDesc = v21;
                var v22 = InvLossPayeeStCd; v22.Clean = value; InvLossPayeeStCd = v22;
                var v23 = InvLossPayeeStreetAddr1; v23.Clean = value; InvLossPayeeStreetAddr1 = v23;
                var v24 = InvLossPayeeStreetAddr2; v24.Clean = value; InvLossPayeeStreetAddr2 = v24;
                var v25 = InvLossPayeeZip; v25.Clean = value; InvLossPayeeZip = v25;
                var v26 = InvNm; v26.Clean = value; InvNm = v26;
                var v27 = InvOrgTyp; v27.Clean = value; InvOrgTyp = v27;
                var v28 = InvPhoneNum; v28.Clean = value; InvPhoneNum = v28;
                var v29 = InvPmtCpn2PayToAdtlTxt; v29.Clean = value; InvPmtCpn2PayToAdtlTxt = v29;
                var v30 = InvPmtCpn2PayToAdtlTxt2; v30.Clean = value; InvPmtCpn2PayToAdtlTxt2 = v30;
                var v31 = InvPmtCpn2PayToCty; v31.Clean = value; InvPmtCpn2PayToCty = v31;
                var v32 = InvPmtCpn2PayToNm; v32.Clean = value; InvPmtCpn2PayToNm = v32;
                var v33 = InvPmtCpn2PayToStCd; v33.Clean = value; InvPmtCpn2PayToStCd = v33;
                var v34 = InvPmtCpn2PayToStreetAddr1; v34.Clean = value; InvPmtCpn2PayToStreetAddr1 = v34;
                var v35 = InvPmtCpn2PayToStreetAddr2; v35.Clean = value; InvPmtCpn2PayToStreetAddr2 = v35;
                var v36 = InvPmtCpn2PayToZip; v36.Clean = value; InvPmtCpn2PayToZip = v36;
                var v37 = InvPmtCpnLoanTrsfToAdtlTxt; v37.Clean = value; InvPmtCpnLoanTrsfToAdtlTxt = v37;
                var v38 = InvPmtCpnLoanTrsfToCty; v38.Clean = value; InvPmtCpnLoanTrsfToCty = v38;
                var v39 = InvPmtCpnLoanTrsfToNm; v39.Clean = value; InvPmtCpnLoanTrsfToNm = v39;
                var v40 = InvPmtCpnLoanTrsfToStCd; v40.Clean = value; InvPmtCpnLoanTrsfToStCd = v40;
                var v41 = InvPmtCpnLoanTrsfToStreetAddr1; v41.Clean = value; InvPmtCpnLoanTrsfToStreetAddr1 = v41;
                var v42 = InvPmtCpnLoanTrsfToStreetAddr2; v42.Clean = value; InvPmtCpnLoanTrsfToStreetAddr2 = v42;
                var v43 = InvPmtCpnLoanTrsfToSvcAdtlTxt; v43.Clean = value; InvPmtCpnLoanTrsfToSvcAdtlTxt = v43;
                var v44 = InvPmtCpnLoanTrsfToSvcCty; v44.Clean = value; InvPmtCpnLoanTrsfToSvcCty = v44;
                var v45 = InvPmtCpnLoanTrsfToSvcNm; v45.Clean = value; InvPmtCpnLoanTrsfToSvcNm = v45;
                var v46 = InvPmtCpnLoanTrsfToSvcStCd; v46.Clean = value; InvPmtCpnLoanTrsfToSvcStCd = v46;
                var v47 = InvPmtCpnLoanTrsfToSvcStreetAddr1; v47.Clean = value; InvPmtCpnLoanTrsfToSvcStreetAddr1 = v47;
                var v48 = InvPmtCpnLoanTrsfToSvcStreetAddr2; v48.Clean = value; InvPmtCpnLoanTrsfToSvcStreetAddr2 = v48;
                var v49 = InvPmtCpnLoanTrsfToSvcZip; v49.Clean = value; InvPmtCpnLoanTrsfToSvcZip = v49;
                var v50 = InvPmtCpnLoanTrsfToZip; v50.Clean = value; InvPmtCpnLoanTrsfToZip = v50;
                var v51 = InvPmtCpnPayToAdtlTxt; v51.Clean = value; InvPmtCpnPayToAdtlTxt = v51;
                var v52 = InvPmtCpnPayToAdtlTxt2; v52.Clean = value; InvPmtCpnPayToAdtlTxt2 = v52;
                var v53 = InvPmtCpnPayToCty; v53.Clean = value; InvPmtCpnPayToCty = v53;
                var v54 = InvPmtCpnPayToNm; v54.Clean = value; InvPmtCpnPayToNm = v54;
                var v55 = InvPmtCpnPayToStCd; v55.Clean = value; InvPmtCpnPayToStCd = v55;
                var v56 = InvPmtCpnPayToStreetAddr1; v56.Clean = value; InvPmtCpnPayToStreetAddr1 = v56;
                var v57 = InvPmtCpnPayToStreetAddr2; v57.Clean = value; InvPmtCpnPayToStreetAddr2 = v57;
                var v58 = InvPmtCpnPayToZip; v58.Clean = value; InvPmtCpnPayToZip = v58;
                var v59 = InvStCd; v59.Clean = value; InvStCd = v59;
                var v60 = InvStreetAddr1; v60.Clean = value; InvStreetAddr1 = v60;
                var v61 = InvStreetAddr2; v61.Clean = value; InvStreetAddr2 = v61;
                var v62 = InvSvcrAdtlTxt; v62.Clean = value; InvSvcrAdtlTxt = v62;
                var v63 = InvSvcrCntctNm; v63.Clean = value; InvSvcrCntctNm = v63;
                var v64 = InvSvcrCntctPhoneNum; v64.Clean = value; InvSvcrCntctPhoneNum = v64;
                var v65 = InvSvcrCntctTollFreePhoneNum; v65.Clean = value; InvSvcrCntctTollFreePhoneNum = v65;
                var v66 = InvSvcrCty; v66.Clean = value; InvSvcrCty = v66;
                var v67 = InvSvcrDayOp; v67.Clean = value; InvSvcrDayOp = v67;
                var v68 = InvSvcrDayOpAddl; v68.Clean = value; InvSvcrDayOpAddl = v68;
                var v69 = InvSvcrHrsOp; v69.Clean = value; InvSvcrHrsOp = v69;
                var v70 = InvSvcrHrsOpAddl; v70.Clean = value; InvSvcrHrsOpAddl = v70;
                var v71 = InvSvcrJrsdctn; v71.Clean = value; InvSvcrJrsdctn = v71;
                var v72 = InvSvcrNm; v72.Clean = value; InvSvcrNm = v72;
                var v73 = InvSvcrOrgTyp; v73.Clean = value; InvSvcrOrgTyp = v73;
                var v74 = InvSvcrQlfdWrtnRqstMailToAdtlTxt; v74.Clean = value; InvSvcrQlfdWrtnRqstMailToAdtlTxt = v74;
                var v75 = InvSvcrQlfdWrtnRqstMailToCty; v75.Clean = value; InvSvcrQlfdWrtnRqstMailToCty = v75;
                var v76 = InvSvcrQlfdWrtnRqstMailToNm; v76.Clean = value; InvSvcrQlfdWrtnRqstMailToNm = v76;
                var v77 = InvSvcrQlfdWrtnRqstMailToStCd; v77.Clean = value; InvSvcrQlfdWrtnRqstMailToStCd = v77;
                var v78 = InvSvcrQlfdWrtnRqstMailToStreetAddr1; v78.Clean = value; InvSvcrQlfdWrtnRqstMailToStreetAddr1 = v78;
                var v79 = InvSvcrQlfdWrtnRqstMailToStreetAddr2; v79.Clean = value; InvSvcrQlfdWrtnRqstMailToStreetAddr2 = v79;
                var v80 = InvSvcrQlfdWrtnRqstMailToZip; v80.Clean = value; InvSvcrQlfdWrtnRqstMailToZip = v80;
                var v81 = InvSvcrStCd; v81.Clean = value; InvSvcrStCd = v81;
                var v82 = InvSvcrStreetAddr1; v82.Clean = value; InvSvcrStreetAddr1 = v82;
                var v83 = InvSvcrStreetAddr2; v83.Clean = value; InvSvcrStreetAddr2 = v83;
                var v84 = InvSvcrZip; v84.Clean = value; InvSvcrZip = v84;
                var v85 = InvTaxIDNum; v85.Clean = value; InvTaxIDNum = v85;
                var v86 = InvTollFreePhoneNum; v86.Clean = value; InvTollFreePhoneNum = v86;
                var v87 = InvUrl; v87.Clean = value; InvUrl = v87;
                var v88 = InvZip; v88.Clean = value; InvZip = v88;
                _settingClean = 0;
            }
        }
    }
}