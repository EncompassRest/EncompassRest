using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentLender : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _id.Dirty
                    || _lndBrchCty.Dirty
                    || _lndBrchFax.Dirty
                    || _lndBrchJrsdctn.Dirty
                    || _lndBrchNm.Dirty
                    || _lndBrchOrgTyp.Dirty
                    || _lndBrchPhone.Dirty
                    || _lndBrchStCd.Dirty
                    || _lndBrchStreetAddr1.Dirty
                    || _lndBrchStreetAddr2.Dirty
                    || _lndBrchTollFreePhone.Dirty
                    || _lndBrchUrl.Dirty
                    || _lndBrchZip.Dirty
                    || _lndCnty.Dirty
                    || _lndCty.Dirty
                    || _lndFaxNum.Dirty
                    || _lndFhaOrgntrId.Dirty
                    || _lndFhaSpnsrId.Dirty
                    || _lndJrsdctn.Dirty
                    || _lndLossPayeeAdtlTxt.Dirty
                    || _lndLossPayeeCntctEmail.Dirty
                    || _lndLossPayeeCntctFax.Dirty
                    || _lndLossPayeeCntctNm.Dirty
                    || _lndLossPayeeCntctPhone.Dirty
                    || _lndLossPayeeCty.Dirty
                    || _lndLossPayeeJrsdctn.Dirty
                    || _lndLossPayeeNm.Dirty
                    || _lndLossPayeeOrgTyp.Dirty
                    || _lndLossPayeeScsrsClausTxtDesc.Dirty
                    || _lndLossPayeeStCd.Dirty
                    || _lndLossPayeeStreetAddr1.Dirty
                    || _lndLossPayeeStreetAddr2.Dirty
                    || _lndLossPayeeZip.Dirty
                    || _lndMersIdNum.Dirty
                    || _lndNm.Dirty
                    || _lndNmlsIdNum.Dirty
                    || _lndNtryCmsnBndNumIdntfr.Dirty
                    || _lndNtryCmsnCnty.Dirty
                    || _lndNtryCmsnExprDt.Dirty
                    || _lndNtryCmsnNumIdntfr.Dirty
                    || _lndNtryCmsnSt.Dirty
                    || _lndNtryCty.Dirty
                    || _lndNtryNm.Dirty
                    || _lndNtryStCd.Dirty
                    || _lndNtryStreetAddr1.Dirty
                    || _lndNtryStreetAddr2.Dirty
                    || _lndNtryTtlOrRank.Dirty
                    || _lndNtryZip.Dirty
                    || _lndOrgTyp.Dirty
                    || _lndPhoneNum.Dirty
                    || _lndStCd.Dirty
                    || _lndStreetAddr1.Dirty
                    || _lndStreetAddr2.Dirty
                    || _lndSvcrAdtlTxt.Dirty
                    || _lndSvcrCntctNm.Dirty
                    || _lndSvcrCntctPhoneNum.Dirty
                    || _lndSvcrCntctTollFreePhoneNum.Dirty
                    || _lndSvcrCty.Dirty
                    || _lndSvcrDayOp.Dirty
                    || _lndSvcrDayOpAddl.Dirty
                    || _lndSvcrHrsOp.Dirty
                    || _lndSvcrHrsOpAddl.Dirty
                    || _lndSvcrJrsdctn.Dirty
                    || _lndSvcrNm.Dirty
                    || _lndSvcrOrgTyp.Dirty
                    || _lndSvcrStCd.Dirty
                    || _lndSvcrStreetAddr1.Dirty
                    || _lndSvcrStreetAddr2.Dirty
                    || _lndSvcrZip.Dirty
                    || _lndTaxIDNum.Dirty
                    || _lndTollFreePhoneNum.Dirty
                    || _lndUrl.Dirty
                    || _lndVaIdNum.Dirty
                    || _lndZip.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _id.Dirty = value;
                _lndBrchCty.Dirty = value;
                _lndBrchFax.Dirty = value;
                _lndBrchJrsdctn.Dirty = value;
                _lndBrchNm.Dirty = value;
                _lndBrchOrgTyp.Dirty = value;
                _lndBrchPhone.Dirty = value;
                _lndBrchStCd.Dirty = value;
                _lndBrchStreetAddr1.Dirty = value;
                _lndBrchStreetAddr2.Dirty = value;
                _lndBrchTollFreePhone.Dirty = value;
                _lndBrchUrl.Dirty = value;
                _lndBrchZip.Dirty = value;
                _lndCnty.Dirty = value;
                _lndCty.Dirty = value;
                _lndFaxNum.Dirty = value;
                _lndFhaOrgntrId.Dirty = value;
                _lndFhaSpnsrId.Dirty = value;
                _lndJrsdctn.Dirty = value;
                _lndLossPayeeAdtlTxt.Dirty = value;
                _lndLossPayeeCntctEmail.Dirty = value;
                _lndLossPayeeCntctFax.Dirty = value;
                _lndLossPayeeCntctNm.Dirty = value;
                _lndLossPayeeCntctPhone.Dirty = value;
                _lndLossPayeeCty.Dirty = value;
                _lndLossPayeeJrsdctn.Dirty = value;
                _lndLossPayeeNm.Dirty = value;
                _lndLossPayeeOrgTyp.Dirty = value;
                _lndLossPayeeScsrsClausTxtDesc.Dirty = value;
                _lndLossPayeeStCd.Dirty = value;
                _lndLossPayeeStreetAddr1.Dirty = value;
                _lndLossPayeeStreetAddr2.Dirty = value;
                _lndLossPayeeZip.Dirty = value;
                _lndMersIdNum.Dirty = value;
                _lndNm.Dirty = value;
                _lndNmlsIdNum.Dirty = value;
                _lndNtryCmsnBndNumIdntfr.Dirty = value;
                _lndNtryCmsnCnty.Dirty = value;
                _lndNtryCmsnExprDt.Dirty = value;
                _lndNtryCmsnNumIdntfr.Dirty = value;
                _lndNtryCmsnSt.Dirty = value;
                _lndNtryCty.Dirty = value;
                _lndNtryNm.Dirty = value;
                _lndNtryStCd.Dirty = value;
                _lndNtryStreetAddr1.Dirty = value;
                _lndNtryStreetAddr2.Dirty = value;
                _lndNtryTtlOrRank.Dirty = value;
                _lndNtryZip.Dirty = value;
                _lndOrgTyp.Dirty = value;
                _lndPhoneNum.Dirty = value;
                _lndStCd.Dirty = value;
                _lndStreetAddr1.Dirty = value;
                _lndStreetAddr2.Dirty = value;
                _lndSvcrAdtlTxt.Dirty = value;
                _lndSvcrCntctNm.Dirty = value;
                _lndSvcrCntctPhoneNum.Dirty = value;
                _lndSvcrCntctTollFreePhoneNum.Dirty = value;
                _lndSvcrCty.Dirty = value;
                _lndSvcrDayOp.Dirty = value;
                _lndSvcrDayOpAddl.Dirty = value;
                _lndSvcrHrsOp.Dirty = value;
                _lndSvcrHrsOpAddl.Dirty = value;
                _lndSvcrJrsdctn.Dirty = value;
                _lndSvcrNm.Dirty = value;
                _lndSvcrOrgTyp.Dirty = value;
                _lndSvcrStCd.Dirty = value;
                _lndSvcrStreetAddr1.Dirty = value;
                _lndSvcrStreetAddr2.Dirty = value;
                _lndSvcrZip.Dirty = value;
                _lndTaxIDNum.Dirty = value;
                _lndTollFreePhoneNum.Dirty = value;
                _lndUrl.Dirty = value;
                _lndVaIdNum.Dirty = value;
                _lndZip.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}