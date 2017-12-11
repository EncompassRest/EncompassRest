#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentLender : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lndBrchCty;
        public string LndBrchCty { get => _lndBrchCty; set => _lndBrchCty = value; }
        private DirtyValue<string> _lndBrchFax;
        public string LndBrchFax { get => _lndBrchFax; set => _lndBrchFax = value; }
        private DirtyValue<string> _lndBrchJrsdctn;
        public string LndBrchJrsdctn { get => _lndBrchJrsdctn; set => _lndBrchJrsdctn = value; }
        private DirtyValue<string> _lndBrchNm;
        public string LndBrchNm { get => _lndBrchNm; set => _lndBrchNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndBrchOrgTyp;
        public StringEnumValue<OrgTyp> LndBrchOrgTyp { get => _lndBrchOrgTyp; set => _lndBrchOrgTyp = value; }
        private DirtyValue<string> _lndBrchPhone;
        public string LndBrchPhone { get => _lndBrchPhone; set => _lndBrchPhone = value; }
        private DirtyValue<string> _lndBrchStCd;
        public string LndBrchStCd { get => _lndBrchStCd; set => _lndBrchStCd = value; }
        private DirtyValue<string> _lndBrchStreetAddr1;
        public string LndBrchStreetAddr1 { get => _lndBrchStreetAddr1; set => _lndBrchStreetAddr1 = value; }
        private DirtyValue<string> _lndBrchStreetAddr2;
        public string LndBrchStreetAddr2 { get => _lndBrchStreetAddr2; set => _lndBrchStreetAddr2 = value; }
        private DirtyValue<string> _lndBrchTollFreePhone;
        public string LndBrchTollFreePhone { get => _lndBrchTollFreePhone; set => _lndBrchTollFreePhone = value; }
        private DirtyValue<string> _lndBrchUrl;
        public string LndBrchUrl { get => _lndBrchUrl; set => _lndBrchUrl = value; }
        private DirtyValue<string> _lndBrchZip;
        public string LndBrchZip { get => _lndBrchZip; set => _lndBrchZip = value; }
        private DirtyValue<string> _lndCnty;
        public string LndCnty { get => _lndCnty; set => _lndCnty = value; }
        private DirtyValue<string> _lndCty;
        public string LndCty { get => _lndCty; set => _lndCty = value; }
        private DirtyValue<string> _lndFaxNum;
        public string LndFaxNum { get => _lndFaxNum; set => _lndFaxNum = value; }
        private DirtyValue<string> _lndFhaOrgntrId;
        public string LndFhaOrgntrId { get => _lndFhaOrgntrId; set => _lndFhaOrgntrId = value; }
        private DirtyValue<string> _lndFhaSpnsrId;
        public string LndFhaSpnsrId { get => _lndFhaSpnsrId; set => _lndFhaSpnsrId = value; }
        private DirtyValue<string> _lndJrsdctn;
        public string LndJrsdctn { get => _lndJrsdctn; set => _lndJrsdctn = value; }
        private DirtyValue<string> _lndLossPayeeAdtlTxt;
        public string LndLossPayeeAdtlTxt { get => _lndLossPayeeAdtlTxt; set => _lndLossPayeeAdtlTxt = value; }
        private DirtyValue<string> _lndLossPayeeCntctEmail;
        public string LndLossPayeeCntctEmail { get => _lndLossPayeeCntctEmail; set => _lndLossPayeeCntctEmail = value; }
        private DirtyValue<string> _lndLossPayeeCntctFax;
        public string LndLossPayeeCntctFax { get => _lndLossPayeeCntctFax; set => _lndLossPayeeCntctFax = value; }
        private DirtyValue<string> _lndLossPayeeCntctNm;
        public string LndLossPayeeCntctNm { get => _lndLossPayeeCntctNm; set => _lndLossPayeeCntctNm = value; }
        private DirtyValue<string> _lndLossPayeeCntctPhone;
        public string LndLossPayeeCntctPhone { get => _lndLossPayeeCntctPhone; set => _lndLossPayeeCntctPhone = value; }
        private DirtyValue<string> _lndLossPayeeCty;
        public string LndLossPayeeCty { get => _lndLossPayeeCty; set => _lndLossPayeeCty = value; }
        private DirtyValue<string> _lndLossPayeeJrsdctn;
        public string LndLossPayeeJrsdctn { get => _lndLossPayeeJrsdctn; set => _lndLossPayeeJrsdctn = value; }
        private DirtyValue<string> _lndLossPayeeNm;
        public string LndLossPayeeNm { get => _lndLossPayeeNm; set => _lndLossPayeeNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndLossPayeeOrgTyp;
        public StringEnumValue<OrgTyp> LndLossPayeeOrgTyp { get => _lndLossPayeeOrgTyp; set => _lndLossPayeeOrgTyp = value; }
        private DirtyValue<StringEnumValue<ScsrsClaus>> _lndLossPayeeScsrsClausTxtDesc;
        public StringEnumValue<ScsrsClaus> LndLossPayeeScsrsClausTxtDesc { get => _lndLossPayeeScsrsClausTxtDesc; set => _lndLossPayeeScsrsClausTxtDesc = value; }
        private DirtyValue<string> _lndLossPayeeStCd;
        public string LndLossPayeeStCd { get => _lndLossPayeeStCd; set => _lndLossPayeeStCd = value; }
        private DirtyValue<string> _lndLossPayeeStreetAddr1;
        public string LndLossPayeeStreetAddr1 { get => _lndLossPayeeStreetAddr1; set => _lndLossPayeeStreetAddr1 = value; }
        private DirtyValue<string> _lndLossPayeeStreetAddr2;
        public string LndLossPayeeStreetAddr2 { get => _lndLossPayeeStreetAddr2; set => _lndLossPayeeStreetAddr2 = value; }
        private DirtyValue<string> _lndLossPayeeZip;
        public string LndLossPayeeZip { get => _lndLossPayeeZip; set => _lndLossPayeeZip = value; }
        private DirtyValue<string> _lndMersIdNum;
        public string LndMersIdNum { get => _lndMersIdNum; set => _lndMersIdNum = value; }
        private DirtyValue<string> _lndNm;
        public string LndNm { get => _lndNm; set => _lndNm = value; }
        private DirtyValue<string> _lndNmlsIdNum;
        public string LndNmlsIdNum { get => _lndNmlsIdNum; set => _lndNmlsIdNum = value; }
        private DirtyValue<string> _lndNtryCmsnBndNumIdntfr;
        public string LndNtryCmsnBndNumIdntfr { get => _lndNtryCmsnBndNumIdntfr; set => _lndNtryCmsnBndNumIdntfr = value; }
        private DirtyValue<string> _lndNtryCmsnCnty;
        public string LndNtryCmsnCnty { get => _lndNtryCmsnCnty; set => _lndNtryCmsnCnty = value; }
        private DirtyValue<DateTime?> _lndNtryCmsnExprDt;
        public DateTime? LndNtryCmsnExprDt { get => _lndNtryCmsnExprDt; set => _lndNtryCmsnExprDt = value; }
        private DirtyValue<string> _lndNtryCmsnNumIdntfr;
        public string LndNtryCmsnNumIdntfr { get => _lndNtryCmsnNumIdntfr; set => _lndNtryCmsnNumIdntfr = value; }
        private DirtyValue<string> _lndNtryCmsnSt;
        public string LndNtryCmsnSt { get => _lndNtryCmsnSt; set => _lndNtryCmsnSt = value; }
        private DirtyValue<string> _lndNtryCty;
        public string LndNtryCty { get => _lndNtryCty; set => _lndNtryCty = value; }
        private DirtyValue<string> _lndNtryNm;
        public string LndNtryNm { get => _lndNtryNm; set => _lndNtryNm = value; }
        private DirtyValue<string> _lndNtryStCd;
        public string LndNtryStCd { get => _lndNtryStCd; set => _lndNtryStCd = value; }
        private DirtyValue<string> _lndNtryStreetAddr1;
        public string LndNtryStreetAddr1 { get => _lndNtryStreetAddr1; set => _lndNtryStreetAddr1 = value; }
        private DirtyValue<string> _lndNtryStreetAddr2;
        public string LndNtryStreetAddr2 { get => _lndNtryStreetAddr2; set => _lndNtryStreetAddr2 = value; }
        private DirtyValue<string> _lndNtryTtlOrRank;
        public string LndNtryTtlOrRank { get => _lndNtryTtlOrRank; set => _lndNtryTtlOrRank = value; }
        private DirtyValue<string> _lndNtryZip;
        public string LndNtryZip { get => _lndNtryZip; set => _lndNtryZip = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndOrgTyp;
        public StringEnumValue<OrgTyp> LndOrgTyp { get => _lndOrgTyp; set => _lndOrgTyp = value; }
        private DirtyValue<string> _lndPhoneNum;
        public string LndPhoneNum { get => _lndPhoneNum; set => _lndPhoneNum = value; }
        private DirtyValue<string> _lndStCd;
        public string LndStCd { get => _lndStCd; set => _lndStCd = value; }
        private DirtyValue<string> _lndStreetAddr1;
        public string LndStreetAddr1 { get => _lndStreetAddr1; set => _lndStreetAddr1 = value; }
        private DirtyValue<string> _lndStreetAddr2;
        public string LndStreetAddr2 { get => _lndStreetAddr2; set => _lndStreetAddr2 = value; }
        private DirtyValue<string> _lndSvcrAdtlTxt;
        public string LndSvcrAdtlTxt { get => _lndSvcrAdtlTxt; set => _lndSvcrAdtlTxt = value; }
        private DirtyValue<string> _lndSvcrCntctNm;
        public string LndSvcrCntctNm { get => _lndSvcrCntctNm; set => _lndSvcrCntctNm = value; }
        private DirtyValue<string> _lndSvcrCntctPhoneNum;
        public string LndSvcrCntctPhoneNum { get => _lndSvcrCntctPhoneNum; set => _lndSvcrCntctPhoneNum = value; }
        private DirtyValue<string> _lndSvcrCntctTollFreePhoneNum;
        public string LndSvcrCntctTollFreePhoneNum { get => _lndSvcrCntctTollFreePhoneNum; set => _lndSvcrCntctTollFreePhoneNum = value; }
        private DirtyValue<string> _lndSvcrCty;
        public string LndSvcrCty { get => _lndSvcrCty; set => _lndSvcrCty = value; }
        private DirtyValue<string> _lndSvcrDayOp;
        public string LndSvcrDayOp { get => _lndSvcrDayOp; set => _lndSvcrDayOp = value; }
        private DirtyValue<string> _lndSvcrDayOpAddl;
        public string LndSvcrDayOpAddl { get => _lndSvcrDayOpAddl; set => _lndSvcrDayOpAddl = value; }
        private DirtyValue<string> _lndSvcrHrsOp;
        public string LndSvcrHrsOp { get => _lndSvcrHrsOp; set => _lndSvcrHrsOp = value; }
        private DirtyValue<string> _lndSvcrHrsOpAddl;
        public string LndSvcrHrsOpAddl { get => _lndSvcrHrsOpAddl; set => _lndSvcrHrsOpAddl = value; }
        private DirtyValue<string> _lndSvcrJrsdctn;
        public string LndSvcrJrsdctn { get => _lndSvcrJrsdctn; set => _lndSvcrJrsdctn = value; }
        private DirtyValue<string> _lndSvcrNm;
        public string LndSvcrNm { get => _lndSvcrNm; set => _lndSvcrNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndSvcrOrgTyp;
        public StringEnumValue<OrgTyp> LndSvcrOrgTyp { get => _lndSvcrOrgTyp; set => _lndSvcrOrgTyp = value; }
        private DirtyValue<string> _lndSvcrStCd;
        public string LndSvcrStCd { get => _lndSvcrStCd; set => _lndSvcrStCd = value; }
        private DirtyValue<string> _lndSvcrStreetAddr1;
        public string LndSvcrStreetAddr1 { get => _lndSvcrStreetAddr1; set => _lndSvcrStreetAddr1 = value; }
        private DirtyValue<string> _lndSvcrStreetAddr2;
        public string LndSvcrStreetAddr2 { get => _lndSvcrStreetAddr2; set => _lndSvcrStreetAddr2 = value; }
        private DirtyValue<string> _lndSvcrZip;
        public string LndSvcrZip { get => _lndSvcrZip; set => _lndSvcrZip = value; }
        private DirtyValue<string> _lndTaxIDNum;
        public string LndTaxIDNum { get => _lndTaxIDNum; set => _lndTaxIDNum = value; }
        private DirtyValue<string> _lndTollFreePhoneNum;
        public string LndTollFreePhoneNum { get => _lndTollFreePhoneNum; set => _lndTollFreePhoneNum = value; }
        private DirtyValue<string> _lndUrl;
        public string LndUrl { get => _lndUrl; set => _lndUrl = value; }
        private DirtyValue<string> _lndVaIdNum;
        public string LndVaIdNum { get => _lndVaIdNum; set => _lndVaIdNum = value; }
        private DirtyValue<string> _lndZip;
        public string LndZip { get => _lndZip; set => _lndZip = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
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
            }
            set
            {
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
            }
        }
    }
}