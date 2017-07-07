using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentLender : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lndBrchCty;
        public string LndBrchCty { get { return _lndBrchCty; } set { _lndBrchCty = value; } }
        private Value<string> _lndBrchFax;
        public string LndBrchFax { get { return _lndBrchFax; } set { _lndBrchFax = value; } }
        private Value<string> _lndBrchJrsdctn;
        public string LndBrchJrsdctn { get { return _lndBrchJrsdctn; } set { _lndBrchJrsdctn = value; } }
        private Value<string> _lndBrchNm;
        public string LndBrchNm { get { return _lndBrchNm; } set { _lndBrchNm = value; } }
        private Value<string> _lndBrchOrgTyp;
        public string LndBrchOrgTyp { get { return _lndBrchOrgTyp; } set { _lndBrchOrgTyp = value; } }
        private Value<string> _lndBrchPhone;
        public string LndBrchPhone { get { return _lndBrchPhone; } set { _lndBrchPhone = value; } }
        private Value<string> _lndBrchStCd;
        public string LndBrchStCd { get { return _lndBrchStCd; } set { _lndBrchStCd = value; } }
        private Value<string> _lndBrchStreetAddr1;
        public string LndBrchStreetAddr1 { get { return _lndBrchStreetAddr1; } set { _lndBrchStreetAddr1 = value; } }
        private Value<string> _lndBrchStreetAddr2;
        public string LndBrchStreetAddr2 { get { return _lndBrchStreetAddr2; } set { _lndBrchStreetAddr2 = value; } }
        private Value<string> _lndBrchTollFreePhone;
        public string LndBrchTollFreePhone { get { return _lndBrchTollFreePhone; } set { _lndBrchTollFreePhone = value; } }
        private Value<string> _lndBrchUrl;
        public string LndBrchUrl { get { return _lndBrchUrl; } set { _lndBrchUrl = value; } }
        private Value<string> _lndBrchZip;
        public string LndBrchZip { get { return _lndBrchZip; } set { _lndBrchZip = value; } }
        private Value<string> _lndCnty;
        public string LndCnty { get { return _lndCnty; } set { _lndCnty = value; } }
        private Value<string> _lndCty;
        public string LndCty { get { return _lndCty; } set { _lndCty = value; } }
        private Value<string> _lndFaxNum;
        public string LndFaxNum { get { return _lndFaxNum; } set { _lndFaxNum = value; } }
        private Value<string> _lndFhaOrgntrId;
        public string LndFhaOrgntrId { get { return _lndFhaOrgntrId; } set { _lndFhaOrgntrId = value; } }
        private Value<string> _lndFhaSpnsrId;
        public string LndFhaSpnsrId { get { return _lndFhaSpnsrId; } set { _lndFhaSpnsrId = value; } }
        private Value<string> _lndJrsdctn;
        public string LndJrsdctn { get { return _lndJrsdctn; } set { _lndJrsdctn = value; } }
        private Value<string> _lndLossPayeeAdtlTxt;
        public string LndLossPayeeAdtlTxt { get { return _lndLossPayeeAdtlTxt; } set { _lndLossPayeeAdtlTxt = value; } }
        private Value<string> _lndLossPayeeCntctEmail;
        public string LndLossPayeeCntctEmail { get { return _lndLossPayeeCntctEmail; } set { _lndLossPayeeCntctEmail = value; } }
        private Value<string> _lndLossPayeeCntctFax;
        public string LndLossPayeeCntctFax { get { return _lndLossPayeeCntctFax; } set { _lndLossPayeeCntctFax = value; } }
        private Value<string> _lndLossPayeeCntctNm;
        public string LndLossPayeeCntctNm { get { return _lndLossPayeeCntctNm; } set { _lndLossPayeeCntctNm = value; } }
        private Value<string> _lndLossPayeeCntctPhone;
        public string LndLossPayeeCntctPhone { get { return _lndLossPayeeCntctPhone; } set { _lndLossPayeeCntctPhone = value; } }
        private Value<string> _lndLossPayeeCty;
        public string LndLossPayeeCty { get { return _lndLossPayeeCty; } set { _lndLossPayeeCty = value; } }
        private Value<string> _lndLossPayeeJrsdctn;
        public string LndLossPayeeJrsdctn { get { return _lndLossPayeeJrsdctn; } set { _lndLossPayeeJrsdctn = value; } }
        private Value<string> _lndLossPayeeNm;
        public string LndLossPayeeNm { get { return _lndLossPayeeNm; } set { _lndLossPayeeNm = value; } }
        private Value<string> _lndLossPayeeOrgTyp;
        public string LndLossPayeeOrgTyp { get { return _lndLossPayeeOrgTyp; } set { _lndLossPayeeOrgTyp = value; } }
        private Value<string> _lndLossPayeeScsrsClausTxtDesc;
        public string LndLossPayeeScsrsClausTxtDesc { get { return _lndLossPayeeScsrsClausTxtDesc; } set { _lndLossPayeeScsrsClausTxtDesc = value; } }
        private Value<string> _lndLossPayeeStCd;
        public string LndLossPayeeStCd { get { return _lndLossPayeeStCd; } set { _lndLossPayeeStCd = value; } }
        private Value<string> _lndLossPayeeStreetAddr1;
        public string LndLossPayeeStreetAddr1 { get { return _lndLossPayeeStreetAddr1; } set { _lndLossPayeeStreetAddr1 = value; } }
        private Value<string> _lndLossPayeeStreetAddr2;
        public string LndLossPayeeStreetAddr2 { get { return _lndLossPayeeStreetAddr2; } set { _lndLossPayeeStreetAddr2 = value; } }
        private Value<string> _lndLossPayeeZip;
        public string LndLossPayeeZip { get { return _lndLossPayeeZip; } set { _lndLossPayeeZip = value; } }
        private Value<string> _lndMersIdNum;
        public string LndMersIdNum { get { return _lndMersIdNum; } set { _lndMersIdNum = value; } }
        private Value<string> _lndNm;
        public string LndNm { get { return _lndNm; } set { _lndNm = value; } }
        private Value<string> _lndNmlsIdNum;
        public string LndNmlsIdNum { get { return _lndNmlsIdNum; } set { _lndNmlsIdNum = value; } }
        private Value<string> _lndNtryCmsnBndNumIdntfr;
        public string LndNtryCmsnBndNumIdntfr { get { return _lndNtryCmsnBndNumIdntfr; } set { _lndNtryCmsnBndNumIdntfr = value; } }
        private Value<string> _lndNtryCmsnCnty;
        public string LndNtryCmsnCnty { get { return _lndNtryCmsnCnty; } set { _lndNtryCmsnCnty = value; } }
        private Value<DateTime?> _lndNtryCmsnExprDt;
        public DateTime? LndNtryCmsnExprDt { get { return _lndNtryCmsnExprDt; } set { _lndNtryCmsnExprDt = value; } }
        private Value<string> _lndNtryCmsnNumIdntfr;
        public string LndNtryCmsnNumIdntfr { get { return _lndNtryCmsnNumIdntfr; } set { _lndNtryCmsnNumIdntfr = value; } }
        private Value<string> _lndNtryCmsnSt;
        public string LndNtryCmsnSt { get { return _lndNtryCmsnSt; } set { _lndNtryCmsnSt = value; } }
        private Value<string> _lndNtryCty;
        public string LndNtryCty { get { return _lndNtryCty; } set { _lndNtryCty = value; } }
        private Value<string> _lndNtryNm;
        public string LndNtryNm { get { return _lndNtryNm; } set { _lndNtryNm = value; } }
        private Value<string> _lndNtryStCd;
        public string LndNtryStCd { get { return _lndNtryStCd; } set { _lndNtryStCd = value; } }
        private Value<string> _lndNtryStreetAddr1;
        public string LndNtryStreetAddr1 { get { return _lndNtryStreetAddr1; } set { _lndNtryStreetAddr1 = value; } }
        private Value<string> _lndNtryStreetAddr2;
        public string LndNtryStreetAddr2 { get { return _lndNtryStreetAddr2; } set { _lndNtryStreetAddr2 = value; } }
        private Value<string> _lndNtryTtlOrRank;
        public string LndNtryTtlOrRank { get { return _lndNtryTtlOrRank; } set { _lndNtryTtlOrRank = value; } }
        private Value<string> _lndNtryZip;
        public string LndNtryZip { get { return _lndNtryZip; } set { _lndNtryZip = value; } }
        private Value<string> _lndOrgTyp;
        public string LndOrgTyp { get { return _lndOrgTyp; } set { _lndOrgTyp = value; } }
        private Value<string> _lndPhoneNum;
        public string LndPhoneNum { get { return _lndPhoneNum; } set { _lndPhoneNum = value; } }
        private Value<string> _lndStCd;
        public string LndStCd { get { return _lndStCd; } set { _lndStCd = value; } }
        private Value<string> _lndStreetAddr1;
        public string LndStreetAddr1 { get { return _lndStreetAddr1; } set { _lndStreetAddr1 = value; } }
        private Value<string> _lndStreetAddr2;
        public string LndStreetAddr2 { get { return _lndStreetAddr2; } set { _lndStreetAddr2 = value; } }
        private Value<string> _lndSvcrAdtlTxt;
        public string LndSvcrAdtlTxt { get { return _lndSvcrAdtlTxt; } set { _lndSvcrAdtlTxt = value; } }
        private Value<string> _lndSvcrCntctNm;
        public string LndSvcrCntctNm { get { return _lndSvcrCntctNm; } set { _lndSvcrCntctNm = value; } }
        private Value<string> _lndSvcrCntctPhoneNum;
        public string LndSvcrCntctPhoneNum { get { return _lndSvcrCntctPhoneNum; } set { _lndSvcrCntctPhoneNum = value; } }
        private Value<string> _lndSvcrCntctTollFreePhoneNum;
        public string LndSvcrCntctTollFreePhoneNum { get { return _lndSvcrCntctTollFreePhoneNum; } set { _lndSvcrCntctTollFreePhoneNum = value; } }
        private Value<string> _lndSvcrCty;
        public string LndSvcrCty { get { return _lndSvcrCty; } set { _lndSvcrCty = value; } }
        private Value<string> _lndSvcrDayOp;
        public string LndSvcrDayOp { get { return _lndSvcrDayOp; } set { _lndSvcrDayOp = value; } }
        private Value<string> _lndSvcrDayOpAddl;
        public string LndSvcrDayOpAddl { get { return _lndSvcrDayOpAddl; } set { _lndSvcrDayOpAddl = value; } }
        private Value<string> _lndSvcrHrsOp;
        public string LndSvcrHrsOp { get { return _lndSvcrHrsOp; } set { _lndSvcrHrsOp = value; } }
        private Value<string> _lndSvcrHrsOpAddl;
        public string LndSvcrHrsOpAddl { get { return _lndSvcrHrsOpAddl; } set { _lndSvcrHrsOpAddl = value; } }
        private Value<string> _lndSvcrJrsdctn;
        public string LndSvcrJrsdctn { get { return _lndSvcrJrsdctn; } set { _lndSvcrJrsdctn = value; } }
        private Value<string> _lndSvcrNm;
        public string LndSvcrNm { get { return _lndSvcrNm; } set { _lndSvcrNm = value; } }
        private Value<string> _lndSvcrOrgTyp;
        public string LndSvcrOrgTyp { get { return _lndSvcrOrgTyp; } set { _lndSvcrOrgTyp = value; } }
        private Value<string> _lndSvcrStCd;
        public string LndSvcrStCd { get { return _lndSvcrStCd; } set { _lndSvcrStCd = value; } }
        private Value<string> _lndSvcrStreetAddr1;
        public string LndSvcrStreetAddr1 { get { return _lndSvcrStreetAddr1; } set { _lndSvcrStreetAddr1 = value; } }
        private Value<string> _lndSvcrStreetAddr2;
        public string LndSvcrStreetAddr2 { get { return _lndSvcrStreetAddr2; } set { _lndSvcrStreetAddr2 = value; } }
        private Value<string> _lndSvcrZip;
        public string LndSvcrZip { get { return _lndSvcrZip; } set { _lndSvcrZip = value; } }
        private Value<string> _lndTaxIDNum;
        public string LndTaxIDNum { get { return _lndTaxIDNum; } set { _lndTaxIDNum = value; } }
        private Value<string> _lndTollFreePhoneNum;
        public string LndTollFreePhoneNum { get { return _lndTollFreePhoneNum; } set { _lndTollFreePhoneNum = value; } }
        private Value<string> _lndUrl;
        public string LndUrl { get { return _lndUrl; } set { _lndUrl = value; } }
        private Value<string> _lndVaIdNum;
        public string LndVaIdNum { get { return _lndVaIdNum; } set { _lndVaIdNum = value; } }
        private Value<string> _lndZip;
        public string LndZip { get { return _lndZip; } set { _lndZip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _lndBrchCty.Clean
                    && _lndBrchFax.Clean
                    && _lndBrchJrsdctn.Clean
                    && _lndBrchNm.Clean
                    && _lndBrchOrgTyp.Clean
                    && _lndBrchPhone.Clean
                    && _lndBrchStCd.Clean
                    && _lndBrchStreetAddr1.Clean
                    && _lndBrchStreetAddr2.Clean
                    && _lndBrchTollFreePhone.Clean
                    && _lndBrchUrl.Clean
                    && _lndBrchZip.Clean
                    && _lndCnty.Clean
                    && _lndCty.Clean
                    && _lndFaxNum.Clean
                    && _lndFhaOrgntrId.Clean
                    && _lndFhaSpnsrId.Clean
                    && _lndJrsdctn.Clean
                    && _lndLossPayeeAdtlTxt.Clean
                    && _lndLossPayeeCntctEmail.Clean
                    && _lndLossPayeeCntctFax.Clean
                    && _lndLossPayeeCntctNm.Clean
                    && _lndLossPayeeCntctPhone.Clean
                    && _lndLossPayeeCty.Clean
                    && _lndLossPayeeJrsdctn.Clean
                    && _lndLossPayeeNm.Clean
                    && _lndLossPayeeOrgTyp.Clean
                    && _lndLossPayeeScsrsClausTxtDesc.Clean
                    && _lndLossPayeeStCd.Clean
                    && _lndLossPayeeStreetAddr1.Clean
                    && _lndLossPayeeStreetAddr2.Clean
                    && _lndLossPayeeZip.Clean
                    && _lndMersIdNum.Clean
                    && _lndNm.Clean
                    && _lndNmlsIdNum.Clean
                    && _lndNtryCmsnBndNumIdntfr.Clean
                    && _lndNtryCmsnCnty.Clean
                    && _lndNtryCmsnExprDt.Clean
                    && _lndNtryCmsnNumIdntfr.Clean
                    && _lndNtryCmsnSt.Clean
                    && _lndNtryCty.Clean
                    && _lndNtryNm.Clean
                    && _lndNtryStCd.Clean
                    && _lndNtryStreetAddr1.Clean
                    && _lndNtryStreetAddr2.Clean
                    && _lndNtryTtlOrRank.Clean
                    && _lndNtryZip.Clean
                    && _lndOrgTyp.Clean
                    && _lndPhoneNum.Clean
                    && _lndStCd.Clean
                    && _lndStreetAddr1.Clean
                    && _lndStreetAddr2.Clean
                    && _lndSvcrAdtlTxt.Clean
                    && _lndSvcrCntctNm.Clean
                    && _lndSvcrCntctPhoneNum.Clean
                    && _lndSvcrCntctTollFreePhoneNum.Clean
                    && _lndSvcrCty.Clean
                    && _lndSvcrDayOp.Clean
                    && _lndSvcrDayOpAddl.Clean
                    && _lndSvcrHrsOp.Clean
                    && _lndSvcrHrsOpAddl.Clean
                    && _lndSvcrJrsdctn.Clean
                    && _lndSvcrNm.Clean
                    && _lndSvcrOrgTyp.Clean
                    && _lndSvcrStCd.Clean
                    && _lndSvcrStreetAddr1.Clean
                    && _lndSvcrStreetAddr2.Clean
                    && _lndSvcrZip.Clean
                    && _lndTaxIDNum.Clean
                    && _lndTollFreePhoneNum.Clean
                    && _lndUrl.Clean
                    && _lndVaIdNum.Clean
                    && _lndZip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var id = _id; id.Clean = value; _id = id;
                var lndBrchCty = _lndBrchCty; lndBrchCty.Clean = value; _lndBrchCty = lndBrchCty;
                var lndBrchFax = _lndBrchFax; lndBrchFax.Clean = value; _lndBrchFax = lndBrchFax;
                var lndBrchJrsdctn = _lndBrchJrsdctn; lndBrchJrsdctn.Clean = value; _lndBrchJrsdctn = lndBrchJrsdctn;
                var lndBrchNm = _lndBrchNm; lndBrchNm.Clean = value; _lndBrchNm = lndBrchNm;
                var lndBrchOrgTyp = _lndBrchOrgTyp; lndBrchOrgTyp.Clean = value; _lndBrchOrgTyp = lndBrchOrgTyp;
                var lndBrchPhone = _lndBrchPhone; lndBrchPhone.Clean = value; _lndBrchPhone = lndBrchPhone;
                var lndBrchStCd = _lndBrchStCd; lndBrchStCd.Clean = value; _lndBrchStCd = lndBrchStCd;
                var lndBrchStreetAddr1 = _lndBrchStreetAddr1; lndBrchStreetAddr1.Clean = value; _lndBrchStreetAddr1 = lndBrchStreetAddr1;
                var lndBrchStreetAddr2 = _lndBrchStreetAddr2; lndBrchStreetAddr2.Clean = value; _lndBrchStreetAddr2 = lndBrchStreetAddr2;
                var lndBrchTollFreePhone = _lndBrchTollFreePhone; lndBrchTollFreePhone.Clean = value; _lndBrchTollFreePhone = lndBrchTollFreePhone;
                var lndBrchUrl = _lndBrchUrl; lndBrchUrl.Clean = value; _lndBrchUrl = lndBrchUrl;
                var lndBrchZip = _lndBrchZip; lndBrchZip.Clean = value; _lndBrchZip = lndBrchZip;
                var lndCnty = _lndCnty; lndCnty.Clean = value; _lndCnty = lndCnty;
                var lndCty = _lndCty; lndCty.Clean = value; _lndCty = lndCty;
                var lndFaxNum = _lndFaxNum; lndFaxNum.Clean = value; _lndFaxNum = lndFaxNum;
                var lndFhaOrgntrId = _lndFhaOrgntrId; lndFhaOrgntrId.Clean = value; _lndFhaOrgntrId = lndFhaOrgntrId;
                var lndFhaSpnsrId = _lndFhaSpnsrId; lndFhaSpnsrId.Clean = value; _lndFhaSpnsrId = lndFhaSpnsrId;
                var lndJrsdctn = _lndJrsdctn; lndJrsdctn.Clean = value; _lndJrsdctn = lndJrsdctn;
                var lndLossPayeeAdtlTxt = _lndLossPayeeAdtlTxt; lndLossPayeeAdtlTxt.Clean = value; _lndLossPayeeAdtlTxt = lndLossPayeeAdtlTxt;
                var lndLossPayeeCntctEmail = _lndLossPayeeCntctEmail; lndLossPayeeCntctEmail.Clean = value; _lndLossPayeeCntctEmail = lndLossPayeeCntctEmail;
                var lndLossPayeeCntctFax = _lndLossPayeeCntctFax; lndLossPayeeCntctFax.Clean = value; _lndLossPayeeCntctFax = lndLossPayeeCntctFax;
                var lndLossPayeeCntctNm = _lndLossPayeeCntctNm; lndLossPayeeCntctNm.Clean = value; _lndLossPayeeCntctNm = lndLossPayeeCntctNm;
                var lndLossPayeeCntctPhone = _lndLossPayeeCntctPhone; lndLossPayeeCntctPhone.Clean = value; _lndLossPayeeCntctPhone = lndLossPayeeCntctPhone;
                var lndLossPayeeCty = _lndLossPayeeCty; lndLossPayeeCty.Clean = value; _lndLossPayeeCty = lndLossPayeeCty;
                var lndLossPayeeJrsdctn = _lndLossPayeeJrsdctn; lndLossPayeeJrsdctn.Clean = value; _lndLossPayeeJrsdctn = lndLossPayeeJrsdctn;
                var lndLossPayeeNm = _lndLossPayeeNm; lndLossPayeeNm.Clean = value; _lndLossPayeeNm = lndLossPayeeNm;
                var lndLossPayeeOrgTyp = _lndLossPayeeOrgTyp; lndLossPayeeOrgTyp.Clean = value; _lndLossPayeeOrgTyp = lndLossPayeeOrgTyp;
                var lndLossPayeeScsrsClausTxtDesc = _lndLossPayeeScsrsClausTxtDesc; lndLossPayeeScsrsClausTxtDesc.Clean = value; _lndLossPayeeScsrsClausTxtDesc = lndLossPayeeScsrsClausTxtDesc;
                var lndLossPayeeStCd = _lndLossPayeeStCd; lndLossPayeeStCd.Clean = value; _lndLossPayeeStCd = lndLossPayeeStCd;
                var lndLossPayeeStreetAddr1 = _lndLossPayeeStreetAddr1; lndLossPayeeStreetAddr1.Clean = value; _lndLossPayeeStreetAddr1 = lndLossPayeeStreetAddr1;
                var lndLossPayeeStreetAddr2 = _lndLossPayeeStreetAddr2; lndLossPayeeStreetAddr2.Clean = value; _lndLossPayeeStreetAddr2 = lndLossPayeeStreetAddr2;
                var lndLossPayeeZip = _lndLossPayeeZip; lndLossPayeeZip.Clean = value; _lndLossPayeeZip = lndLossPayeeZip;
                var lndMersIdNum = _lndMersIdNum; lndMersIdNum.Clean = value; _lndMersIdNum = lndMersIdNum;
                var lndNm = _lndNm; lndNm.Clean = value; _lndNm = lndNm;
                var lndNmlsIdNum = _lndNmlsIdNum; lndNmlsIdNum.Clean = value; _lndNmlsIdNum = lndNmlsIdNum;
                var lndNtryCmsnBndNumIdntfr = _lndNtryCmsnBndNumIdntfr; lndNtryCmsnBndNumIdntfr.Clean = value; _lndNtryCmsnBndNumIdntfr = lndNtryCmsnBndNumIdntfr;
                var lndNtryCmsnCnty = _lndNtryCmsnCnty; lndNtryCmsnCnty.Clean = value; _lndNtryCmsnCnty = lndNtryCmsnCnty;
                var lndNtryCmsnExprDt = _lndNtryCmsnExprDt; lndNtryCmsnExprDt.Clean = value; _lndNtryCmsnExprDt = lndNtryCmsnExprDt;
                var lndNtryCmsnNumIdntfr = _lndNtryCmsnNumIdntfr; lndNtryCmsnNumIdntfr.Clean = value; _lndNtryCmsnNumIdntfr = lndNtryCmsnNumIdntfr;
                var lndNtryCmsnSt = _lndNtryCmsnSt; lndNtryCmsnSt.Clean = value; _lndNtryCmsnSt = lndNtryCmsnSt;
                var lndNtryCty = _lndNtryCty; lndNtryCty.Clean = value; _lndNtryCty = lndNtryCty;
                var lndNtryNm = _lndNtryNm; lndNtryNm.Clean = value; _lndNtryNm = lndNtryNm;
                var lndNtryStCd = _lndNtryStCd; lndNtryStCd.Clean = value; _lndNtryStCd = lndNtryStCd;
                var lndNtryStreetAddr1 = _lndNtryStreetAddr1; lndNtryStreetAddr1.Clean = value; _lndNtryStreetAddr1 = lndNtryStreetAddr1;
                var lndNtryStreetAddr2 = _lndNtryStreetAddr2; lndNtryStreetAddr2.Clean = value; _lndNtryStreetAddr2 = lndNtryStreetAddr2;
                var lndNtryTtlOrRank = _lndNtryTtlOrRank; lndNtryTtlOrRank.Clean = value; _lndNtryTtlOrRank = lndNtryTtlOrRank;
                var lndNtryZip = _lndNtryZip; lndNtryZip.Clean = value; _lndNtryZip = lndNtryZip;
                var lndOrgTyp = _lndOrgTyp; lndOrgTyp.Clean = value; _lndOrgTyp = lndOrgTyp;
                var lndPhoneNum = _lndPhoneNum; lndPhoneNum.Clean = value; _lndPhoneNum = lndPhoneNum;
                var lndStCd = _lndStCd; lndStCd.Clean = value; _lndStCd = lndStCd;
                var lndStreetAddr1 = _lndStreetAddr1; lndStreetAddr1.Clean = value; _lndStreetAddr1 = lndStreetAddr1;
                var lndStreetAddr2 = _lndStreetAddr2; lndStreetAddr2.Clean = value; _lndStreetAddr2 = lndStreetAddr2;
                var lndSvcrAdtlTxt = _lndSvcrAdtlTxt; lndSvcrAdtlTxt.Clean = value; _lndSvcrAdtlTxt = lndSvcrAdtlTxt;
                var lndSvcrCntctNm = _lndSvcrCntctNm; lndSvcrCntctNm.Clean = value; _lndSvcrCntctNm = lndSvcrCntctNm;
                var lndSvcrCntctPhoneNum = _lndSvcrCntctPhoneNum; lndSvcrCntctPhoneNum.Clean = value; _lndSvcrCntctPhoneNum = lndSvcrCntctPhoneNum;
                var lndSvcrCntctTollFreePhoneNum = _lndSvcrCntctTollFreePhoneNum; lndSvcrCntctTollFreePhoneNum.Clean = value; _lndSvcrCntctTollFreePhoneNum = lndSvcrCntctTollFreePhoneNum;
                var lndSvcrCty = _lndSvcrCty; lndSvcrCty.Clean = value; _lndSvcrCty = lndSvcrCty;
                var lndSvcrDayOp = _lndSvcrDayOp; lndSvcrDayOp.Clean = value; _lndSvcrDayOp = lndSvcrDayOp;
                var lndSvcrDayOpAddl = _lndSvcrDayOpAddl; lndSvcrDayOpAddl.Clean = value; _lndSvcrDayOpAddl = lndSvcrDayOpAddl;
                var lndSvcrHrsOp = _lndSvcrHrsOp; lndSvcrHrsOp.Clean = value; _lndSvcrHrsOp = lndSvcrHrsOp;
                var lndSvcrHrsOpAddl = _lndSvcrHrsOpAddl; lndSvcrHrsOpAddl.Clean = value; _lndSvcrHrsOpAddl = lndSvcrHrsOpAddl;
                var lndSvcrJrsdctn = _lndSvcrJrsdctn; lndSvcrJrsdctn.Clean = value; _lndSvcrJrsdctn = lndSvcrJrsdctn;
                var lndSvcrNm = _lndSvcrNm; lndSvcrNm.Clean = value; _lndSvcrNm = lndSvcrNm;
                var lndSvcrOrgTyp = _lndSvcrOrgTyp; lndSvcrOrgTyp.Clean = value; _lndSvcrOrgTyp = lndSvcrOrgTyp;
                var lndSvcrStCd = _lndSvcrStCd; lndSvcrStCd.Clean = value; _lndSvcrStCd = lndSvcrStCd;
                var lndSvcrStreetAddr1 = _lndSvcrStreetAddr1; lndSvcrStreetAddr1.Clean = value; _lndSvcrStreetAddr1 = lndSvcrStreetAddr1;
                var lndSvcrStreetAddr2 = _lndSvcrStreetAddr2; lndSvcrStreetAddr2.Clean = value; _lndSvcrStreetAddr2 = lndSvcrStreetAddr2;
                var lndSvcrZip = _lndSvcrZip; lndSvcrZip.Clean = value; _lndSvcrZip = lndSvcrZip;
                var lndTaxIDNum = _lndTaxIDNum; lndTaxIDNum.Clean = value; _lndTaxIDNum = lndTaxIDNum;
                var lndTollFreePhoneNum = _lndTollFreePhoneNum; lndTollFreePhoneNum.Clean = value; _lndTollFreePhoneNum = lndTollFreePhoneNum;
                var lndUrl = _lndUrl; lndUrl.Clean = value; _lndUrl = lndUrl;
                var lndVaIdNum = _lndVaIdNum; lndVaIdNum.Clean = value; _lndVaIdNum = lndVaIdNum;
                var lndZip = _lndZip; lndZip.Clean = value; _lndZip = lndZip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public EmDocumentLender()
        {
            Clean = true;
        }
    }
}