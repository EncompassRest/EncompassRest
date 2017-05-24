using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocumentLender
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LndBrchCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchCty() => !LndBrchCty.Clean;
        public Value<string> LndBrchFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchFax() => !LndBrchFax.Clean;
        public Value<string> LndBrchJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchJrsdctn() => !LndBrchJrsdctn.Clean;
        public Value<string> LndBrchNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchNm() => !LndBrchNm.Clean;
        public Value<string> LndBrchOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchOrgTyp() => !LndBrchOrgTyp.Clean;
        public Value<string> LndBrchPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchPhone() => !LndBrchPhone.Clean;
        public Value<string> LndBrchStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchStCd() => !LndBrchStCd.Clean;
        public Value<string> LndBrchStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchStreetAddr1() => !LndBrchStreetAddr1.Clean;
        public Value<string> LndBrchStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchStreetAddr2() => !LndBrchStreetAddr2.Clean;
        public Value<string> LndBrchTollFreePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchTollFreePhone() => !LndBrchTollFreePhone.Clean;
        public Value<string> LndBrchUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchUrl() => !LndBrchUrl.Clean;
        public Value<string> LndBrchZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndBrchZip() => !LndBrchZip.Clean;
        public Value<string> LndCnty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndCnty() => !LndCnty.Clean;
        public Value<string> LndCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndCty() => !LndCty.Clean;
        public Value<string> LndFaxNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndFaxNum() => !LndFaxNum.Clean;
        public Value<string> LndFhaOrgntrId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndFhaOrgntrId() => !LndFhaOrgntrId.Clean;
        public Value<string> LndFhaSpnsrId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndFhaSpnsrId() => !LndFhaSpnsrId.Clean;
        public Value<string> LndJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndJrsdctn() => !LndJrsdctn.Clean;
        public Value<string> LndLossPayeeAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeAdtlTxt() => !LndLossPayeeAdtlTxt.Clean;
        public Value<string> LndLossPayeeCntctEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeCntctEmail() => !LndLossPayeeCntctEmail.Clean;
        public Value<string> LndLossPayeeCntctFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeCntctFax() => !LndLossPayeeCntctFax.Clean;
        public Value<string> LndLossPayeeCntctNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeCntctNm() => !LndLossPayeeCntctNm.Clean;
        public Value<string> LndLossPayeeCntctPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeCntctPhone() => !LndLossPayeeCntctPhone.Clean;
        public Value<string> LndLossPayeeCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeCty() => !LndLossPayeeCty.Clean;
        public Value<string> LndLossPayeeJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeJrsdctn() => !LndLossPayeeJrsdctn.Clean;
        public Value<string> LndLossPayeeNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeNm() => !LndLossPayeeNm.Clean;
        public Value<string> LndLossPayeeOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeOrgTyp() => !LndLossPayeeOrgTyp.Clean;
        public Value<string> LndLossPayeeScsrsClausTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeScsrsClausTxtDesc() => !LndLossPayeeScsrsClausTxtDesc.Clean;
        public Value<string> LndLossPayeeStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeStCd() => !LndLossPayeeStCd.Clean;
        public Value<string> LndLossPayeeStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeStreetAddr1() => !LndLossPayeeStreetAddr1.Clean;
        public Value<string> LndLossPayeeStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeStreetAddr2() => !LndLossPayeeStreetAddr2.Clean;
        public Value<string> LndLossPayeeZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndLossPayeeZip() => !LndLossPayeeZip.Clean;
        public Value<string> LndMersIdNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndMersIdNum() => !LndMersIdNum.Clean;
        public Value<string> LndNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNm() => !LndNm.Clean;
        public Value<string> LndNmlsIdNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNmlsIdNum() => !LndNmlsIdNum.Clean;
        public Value<string> LndNtryCmsnBndNumIdntfr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCmsnBndNumIdntfr() => !LndNtryCmsnBndNumIdntfr.Clean;
        public Value<string> LndNtryCmsnCnty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCmsnCnty() => !LndNtryCmsnCnty.Clean;
        public Value<DateTime?> LndNtryCmsnExprDt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCmsnExprDt() => !LndNtryCmsnExprDt.Clean;
        public Value<string> LndNtryCmsnNumIdntfr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCmsnNumIdntfr() => !LndNtryCmsnNumIdntfr.Clean;
        public Value<string> LndNtryCmsnSt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCmsnSt() => !LndNtryCmsnSt.Clean;
        public Value<string> LndNtryCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryCty() => !LndNtryCty.Clean;
        public Value<string> LndNtryNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryNm() => !LndNtryNm.Clean;
        public Value<string> LndNtryStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryStCd() => !LndNtryStCd.Clean;
        public Value<string> LndNtryStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryStreetAddr1() => !LndNtryStreetAddr1.Clean;
        public Value<string> LndNtryStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryStreetAddr2() => !LndNtryStreetAddr2.Clean;
        public Value<string> LndNtryTtlOrRank { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryTtlOrRank() => !LndNtryTtlOrRank.Clean;
        public Value<string> LndNtryZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndNtryZip() => !LndNtryZip.Clean;
        public Value<string> LndOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndOrgTyp() => !LndOrgTyp.Clean;
        public Value<string> LndPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndPhoneNum() => !LndPhoneNum.Clean;
        public Value<string> LndStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndStCd() => !LndStCd.Clean;
        public Value<string> LndStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndStreetAddr1() => !LndStreetAddr1.Clean;
        public Value<string> LndStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndStreetAddr2() => !LndStreetAddr2.Clean;
        public Value<string> LndSvcrAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrAdtlTxt() => !LndSvcrAdtlTxt.Clean;
        public Value<string> LndSvcrCntctNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrCntctNm() => !LndSvcrCntctNm.Clean;
        public Value<string> LndSvcrCntctPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrCntctPhoneNum() => !LndSvcrCntctPhoneNum.Clean;
        public Value<string> LndSvcrCntctTollFreePhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrCntctTollFreePhoneNum() => !LndSvcrCntctTollFreePhoneNum.Clean;
        public Value<string> LndSvcrCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrCty() => !LndSvcrCty.Clean;
        public Value<string> LndSvcrDayOp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrDayOp() => !LndSvcrDayOp.Clean;
        public Value<string> LndSvcrDayOpAddl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrDayOpAddl() => !LndSvcrDayOpAddl.Clean;
        public Value<string> LndSvcrHrsOp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrHrsOp() => !LndSvcrHrsOp.Clean;
        public Value<string> LndSvcrHrsOpAddl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrHrsOpAddl() => !LndSvcrHrsOpAddl.Clean;
        public Value<string> LndSvcrJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrJrsdctn() => !LndSvcrJrsdctn.Clean;
        public Value<string> LndSvcrNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrNm() => !LndSvcrNm.Clean;
        public Value<string> LndSvcrOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrOrgTyp() => !LndSvcrOrgTyp.Clean;
        public Value<string> LndSvcrStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrStCd() => !LndSvcrStCd.Clean;
        public Value<string> LndSvcrStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrStreetAddr1() => !LndSvcrStreetAddr1.Clean;
        public Value<string> LndSvcrStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrStreetAddr2() => !LndSvcrStreetAddr2.Clean;
        public Value<string> LndSvcrZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndSvcrZip() => !LndSvcrZip.Clean;
        public Value<string> LndTaxIDNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndTaxIDNum() => !LndTaxIDNum.Clean;
        public Value<string> LndTollFreePhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndTollFreePhoneNum() => !LndTollFreePhoneNum.Clean;
        public Value<string> LndUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndUrl() => !LndUrl.Clean;
        public Value<string> LndVaIdNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndVaIdNum() => !LndVaIdNum.Clean;
        public Value<string> LndZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLndZip() => !LndZip.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && LndBrchCty.Clean
                    && LndBrchFax.Clean
                    && LndBrchJrsdctn.Clean
                    && LndBrchNm.Clean
                    && LndBrchOrgTyp.Clean
                    && LndBrchPhone.Clean
                    && LndBrchStCd.Clean
                    && LndBrchStreetAddr1.Clean
                    && LndBrchStreetAddr2.Clean
                    && LndBrchTollFreePhone.Clean
                    && LndBrchUrl.Clean
                    && LndBrchZip.Clean
                    && LndCnty.Clean
                    && LndCty.Clean
                    && LndFaxNum.Clean
                    && LndFhaOrgntrId.Clean
                    && LndFhaSpnsrId.Clean
                    && LndJrsdctn.Clean
                    && LndLossPayeeAdtlTxt.Clean
                    && LndLossPayeeCntctEmail.Clean
                    && LndLossPayeeCntctFax.Clean
                    && LndLossPayeeCntctNm.Clean
                    && LndLossPayeeCntctPhone.Clean
                    && LndLossPayeeCty.Clean
                    && LndLossPayeeJrsdctn.Clean
                    && LndLossPayeeNm.Clean
                    && LndLossPayeeOrgTyp.Clean
                    && LndLossPayeeScsrsClausTxtDesc.Clean
                    && LndLossPayeeStCd.Clean
                    && LndLossPayeeStreetAddr1.Clean
                    && LndLossPayeeStreetAddr2.Clean
                    && LndLossPayeeZip.Clean
                    && LndMersIdNum.Clean
                    && LndNm.Clean
                    && LndNmlsIdNum.Clean
                    && LndNtryCmsnBndNumIdntfr.Clean
                    && LndNtryCmsnCnty.Clean
                    && LndNtryCmsnExprDt.Clean
                    && LndNtryCmsnNumIdntfr.Clean
                    && LndNtryCmsnSt.Clean
                    && LndNtryCty.Clean
                    && LndNtryNm.Clean
                    && LndNtryStCd.Clean
                    && LndNtryStreetAddr1.Clean
                    && LndNtryStreetAddr2.Clean
                    && LndNtryTtlOrRank.Clean
                    && LndNtryZip.Clean
                    && LndOrgTyp.Clean
                    && LndPhoneNum.Clean
                    && LndStCd.Clean
                    && LndStreetAddr1.Clean
                    && LndStreetAddr2.Clean
                    && LndSvcrAdtlTxt.Clean
                    && LndSvcrCntctNm.Clean
                    && LndSvcrCntctPhoneNum.Clean
                    && LndSvcrCntctTollFreePhoneNum.Clean
                    && LndSvcrCty.Clean
                    && LndSvcrDayOp.Clean
                    && LndSvcrDayOpAddl.Clean
                    && LndSvcrHrsOp.Clean
                    && LndSvcrHrsOpAddl.Clean
                    && LndSvcrJrsdctn.Clean
                    && LndSvcrNm.Clean
                    && LndSvcrOrgTyp.Clean
                    && LndSvcrStCd.Clean
                    && LndSvcrStreetAddr1.Clean
                    && LndSvcrStreetAddr2.Clean
                    && LndSvcrZip.Clean
                    && LndTaxIDNum.Clean
                    && LndTollFreePhoneNum.Clean
                    && LndUrl.Clean
                    && LndVaIdNum.Clean
                    && LndZip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = LndBrchCty; v1.Clean = value; LndBrchCty = v1;
                var v2 = LndBrchFax; v2.Clean = value; LndBrchFax = v2;
                var v3 = LndBrchJrsdctn; v3.Clean = value; LndBrchJrsdctn = v3;
                var v4 = LndBrchNm; v4.Clean = value; LndBrchNm = v4;
                var v5 = LndBrchOrgTyp; v5.Clean = value; LndBrchOrgTyp = v5;
                var v6 = LndBrchPhone; v6.Clean = value; LndBrchPhone = v6;
                var v7 = LndBrchStCd; v7.Clean = value; LndBrchStCd = v7;
                var v8 = LndBrchStreetAddr1; v8.Clean = value; LndBrchStreetAddr1 = v8;
                var v9 = LndBrchStreetAddr2; v9.Clean = value; LndBrchStreetAddr2 = v9;
                var v10 = LndBrchTollFreePhone; v10.Clean = value; LndBrchTollFreePhone = v10;
                var v11 = LndBrchUrl; v11.Clean = value; LndBrchUrl = v11;
                var v12 = LndBrchZip; v12.Clean = value; LndBrchZip = v12;
                var v13 = LndCnty; v13.Clean = value; LndCnty = v13;
                var v14 = LndCty; v14.Clean = value; LndCty = v14;
                var v15 = LndFaxNum; v15.Clean = value; LndFaxNum = v15;
                var v16 = LndFhaOrgntrId; v16.Clean = value; LndFhaOrgntrId = v16;
                var v17 = LndFhaSpnsrId; v17.Clean = value; LndFhaSpnsrId = v17;
                var v18 = LndJrsdctn; v18.Clean = value; LndJrsdctn = v18;
                var v19 = LndLossPayeeAdtlTxt; v19.Clean = value; LndLossPayeeAdtlTxt = v19;
                var v20 = LndLossPayeeCntctEmail; v20.Clean = value; LndLossPayeeCntctEmail = v20;
                var v21 = LndLossPayeeCntctFax; v21.Clean = value; LndLossPayeeCntctFax = v21;
                var v22 = LndLossPayeeCntctNm; v22.Clean = value; LndLossPayeeCntctNm = v22;
                var v23 = LndLossPayeeCntctPhone; v23.Clean = value; LndLossPayeeCntctPhone = v23;
                var v24 = LndLossPayeeCty; v24.Clean = value; LndLossPayeeCty = v24;
                var v25 = LndLossPayeeJrsdctn; v25.Clean = value; LndLossPayeeJrsdctn = v25;
                var v26 = LndLossPayeeNm; v26.Clean = value; LndLossPayeeNm = v26;
                var v27 = LndLossPayeeOrgTyp; v27.Clean = value; LndLossPayeeOrgTyp = v27;
                var v28 = LndLossPayeeScsrsClausTxtDesc; v28.Clean = value; LndLossPayeeScsrsClausTxtDesc = v28;
                var v29 = LndLossPayeeStCd; v29.Clean = value; LndLossPayeeStCd = v29;
                var v30 = LndLossPayeeStreetAddr1; v30.Clean = value; LndLossPayeeStreetAddr1 = v30;
                var v31 = LndLossPayeeStreetAddr2; v31.Clean = value; LndLossPayeeStreetAddr2 = v31;
                var v32 = LndLossPayeeZip; v32.Clean = value; LndLossPayeeZip = v32;
                var v33 = LndMersIdNum; v33.Clean = value; LndMersIdNum = v33;
                var v34 = LndNm; v34.Clean = value; LndNm = v34;
                var v35 = LndNmlsIdNum; v35.Clean = value; LndNmlsIdNum = v35;
                var v36 = LndNtryCmsnBndNumIdntfr; v36.Clean = value; LndNtryCmsnBndNumIdntfr = v36;
                var v37 = LndNtryCmsnCnty; v37.Clean = value; LndNtryCmsnCnty = v37;
                var v38 = LndNtryCmsnExprDt; v38.Clean = value; LndNtryCmsnExprDt = v38;
                var v39 = LndNtryCmsnNumIdntfr; v39.Clean = value; LndNtryCmsnNumIdntfr = v39;
                var v40 = LndNtryCmsnSt; v40.Clean = value; LndNtryCmsnSt = v40;
                var v41 = LndNtryCty; v41.Clean = value; LndNtryCty = v41;
                var v42 = LndNtryNm; v42.Clean = value; LndNtryNm = v42;
                var v43 = LndNtryStCd; v43.Clean = value; LndNtryStCd = v43;
                var v44 = LndNtryStreetAddr1; v44.Clean = value; LndNtryStreetAddr1 = v44;
                var v45 = LndNtryStreetAddr2; v45.Clean = value; LndNtryStreetAddr2 = v45;
                var v46 = LndNtryTtlOrRank; v46.Clean = value; LndNtryTtlOrRank = v46;
                var v47 = LndNtryZip; v47.Clean = value; LndNtryZip = v47;
                var v48 = LndOrgTyp; v48.Clean = value; LndOrgTyp = v48;
                var v49 = LndPhoneNum; v49.Clean = value; LndPhoneNum = v49;
                var v50 = LndStCd; v50.Clean = value; LndStCd = v50;
                var v51 = LndStreetAddr1; v51.Clean = value; LndStreetAddr1 = v51;
                var v52 = LndStreetAddr2; v52.Clean = value; LndStreetAddr2 = v52;
                var v53 = LndSvcrAdtlTxt; v53.Clean = value; LndSvcrAdtlTxt = v53;
                var v54 = LndSvcrCntctNm; v54.Clean = value; LndSvcrCntctNm = v54;
                var v55 = LndSvcrCntctPhoneNum; v55.Clean = value; LndSvcrCntctPhoneNum = v55;
                var v56 = LndSvcrCntctTollFreePhoneNum; v56.Clean = value; LndSvcrCntctTollFreePhoneNum = v56;
                var v57 = LndSvcrCty; v57.Clean = value; LndSvcrCty = v57;
                var v58 = LndSvcrDayOp; v58.Clean = value; LndSvcrDayOp = v58;
                var v59 = LndSvcrDayOpAddl; v59.Clean = value; LndSvcrDayOpAddl = v59;
                var v60 = LndSvcrHrsOp; v60.Clean = value; LndSvcrHrsOp = v60;
                var v61 = LndSvcrHrsOpAddl; v61.Clean = value; LndSvcrHrsOpAddl = v61;
                var v62 = LndSvcrJrsdctn; v62.Clean = value; LndSvcrJrsdctn = v62;
                var v63 = LndSvcrNm; v63.Clean = value; LndSvcrNm = v63;
                var v64 = LndSvcrOrgTyp; v64.Clean = value; LndSvcrOrgTyp = v64;
                var v65 = LndSvcrStCd; v65.Clean = value; LndSvcrStCd = v65;
                var v66 = LndSvcrStreetAddr1; v66.Clean = value; LndSvcrStreetAddr1 = v66;
                var v67 = LndSvcrStreetAddr2; v67.Clean = value; LndSvcrStreetAddr2 = v67;
                var v68 = LndSvcrZip; v68.Clean = value; LndSvcrZip = v68;
                var v69 = LndTaxIDNum; v69.Clean = value; LndTaxIDNum = v69;
                var v70 = LndTollFreePhoneNum; v70.Clean = value; LndTollFreePhoneNum = v70;
                var v71 = LndUrl; v71.Clean = value; LndUrl = v71;
                var v72 = LndVaIdNum; v72.Clean = value; LndVaIdNum = v72;
                var v73 = LndZip; v73.Clean = value; LndZip = v73;
                _settingClean = 0;
            }
        }
    }
}