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
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _lndBrchCty; v1.Clean = value; _lndBrchCty = v1;
                var v2 = _lndBrchFax; v2.Clean = value; _lndBrchFax = v2;
                var v3 = _lndBrchJrsdctn; v3.Clean = value; _lndBrchJrsdctn = v3;
                var v4 = _lndBrchNm; v4.Clean = value; _lndBrchNm = v4;
                var v5 = _lndBrchOrgTyp; v5.Clean = value; _lndBrchOrgTyp = v5;
                var v6 = _lndBrchPhone; v6.Clean = value; _lndBrchPhone = v6;
                var v7 = _lndBrchStCd; v7.Clean = value; _lndBrchStCd = v7;
                var v8 = _lndBrchStreetAddr1; v8.Clean = value; _lndBrchStreetAddr1 = v8;
                var v9 = _lndBrchStreetAddr2; v9.Clean = value; _lndBrchStreetAddr2 = v9;
                var v10 = _lndBrchTollFreePhone; v10.Clean = value; _lndBrchTollFreePhone = v10;
                var v11 = _lndBrchUrl; v11.Clean = value; _lndBrchUrl = v11;
                var v12 = _lndBrchZip; v12.Clean = value; _lndBrchZip = v12;
                var v13 = _lndCnty; v13.Clean = value; _lndCnty = v13;
                var v14 = _lndCty; v14.Clean = value; _lndCty = v14;
                var v15 = _lndFaxNum; v15.Clean = value; _lndFaxNum = v15;
                var v16 = _lndFhaOrgntrId; v16.Clean = value; _lndFhaOrgntrId = v16;
                var v17 = _lndFhaSpnsrId; v17.Clean = value; _lndFhaSpnsrId = v17;
                var v18 = _lndJrsdctn; v18.Clean = value; _lndJrsdctn = v18;
                var v19 = _lndLossPayeeAdtlTxt; v19.Clean = value; _lndLossPayeeAdtlTxt = v19;
                var v20 = _lndLossPayeeCntctEmail; v20.Clean = value; _lndLossPayeeCntctEmail = v20;
                var v21 = _lndLossPayeeCntctFax; v21.Clean = value; _lndLossPayeeCntctFax = v21;
                var v22 = _lndLossPayeeCntctNm; v22.Clean = value; _lndLossPayeeCntctNm = v22;
                var v23 = _lndLossPayeeCntctPhone; v23.Clean = value; _lndLossPayeeCntctPhone = v23;
                var v24 = _lndLossPayeeCty; v24.Clean = value; _lndLossPayeeCty = v24;
                var v25 = _lndLossPayeeJrsdctn; v25.Clean = value; _lndLossPayeeJrsdctn = v25;
                var v26 = _lndLossPayeeNm; v26.Clean = value; _lndLossPayeeNm = v26;
                var v27 = _lndLossPayeeOrgTyp; v27.Clean = value; _lndLossPayeeOrgTyp = v27;
                var v28 = _lndLossPayeeScsrsClausTxtDesc; v28.Clean = value; _lndLossPayeeScsrsClausTxtDesc = v28;
                var v29 = _lndLossPayeeStCd; v29.Clean = value; _lndLossPayeeStCd = v29;
                var v30 = _lndLossPayeeStreetAddr1; v30.Clean = value; _lndLossPayeeStreetAddr1 = v30;
                var v31 = _lndLossPayeeStreetAddr2; v31.Clean = value; _lndLossPayeeStreetAddr2 = v31;
                var v32 = _lndLossPayeeZip; v32.Clean = value; _lndLossPayeeZip = v32;
                var v33 = _lndMersIdNum; v33.Clean = value; _lndMersIdNum = v33;
                var v34 = _lndNm; v34.Clean = value; _lndNm = v34;
                var v35 = _lndNmlsIdNum; v35.Clean = value; _lndNmlsIdNum = v35;
                var v36 = _lndNtryCmsnBndNumIdntfr; v36.Clean = value; _lndNtryCmsnBndNumIdntfr = v36;
                var v37 = _lndNtryCmsnCnty; v37.Clean = value; _lndNtryCmsnCnty = v37;
                var v38 = _lndNtryCmsnExprDt; v38.Clean = value; _lndNtryCmsnExprDt = v38;
                var v39 = _lndNtryCmsnNumIdntfr; v39.Clean = value; _lndNtryCmsnNumIdntfr = v39;
                var v40 = _lndNtryCmsnSt; v40.Clean = value; _lndNtryCmsnSt = v40;
                var v41 = _lndNtryCty; v41.Clean = value; _lndNtryCty = v41;
                var v42 = _lndNtryNm; v42.Clean = value; _lndNtryNm = v42;
                var v43 = _lndNtryStCd; v43.Clean = value; _lndNtryStCd = v43;
                var v44 = _lndNtryStreetAddr1; v44.Clean = value; _lndNtryStreetAddr1 = v44;
                var v45 = _lndNtryStreetAddr2; v45.Clean = value; _lndNtryStreetAddr2 = v45;
                var v46 = _lndNtryTtlOrRank; v46.Clean = value; _lndNtryTtlOrRank = v46;
                var v47 = _lndNtryZip; v47.Clean = value; _lndNtryZip = v47;
                var v48 = _lndOrgTyp; v48.Clean = value; _lndOrgTyp = v48;
                var v49 = _lndPhoneNum; v49.Clean = value; _lndPhoneNum = v49;
                var v50 = _lndStCd; v50.Clean = value; _lndStCd = v50;
                var v51 = _lndStreetAddr1; v51.Clean = value; _lndStreetAddr1 = v51;
                var v52 = _lndStreetAddr2; v52.Clean = value; _lndStreetAddr2 = v52;
                var v53 = _lndSvcrAdtlTxt; v53.Clean = value; _lndSvcrAdtlTxt = v53;
                var v54 = _lndSvcrCntctNm; v54.Clean = value; _lndSvcrCntctNm = v54;
                var v55 = _lndSvcrCntctPhoneNum; v55.Clean = value; _lndSvcrCntctPhoneNum = v55;
                var v56 = _lndSvcrCntctTollFreePhoneNum; v56.Clean = value; _lndSvcrCntctTollFreePhoneNum = v56;
                var v57 = _lndSvcrCty; v57.Clean = value; _lndSvcrCty = v57;
                var v58 = _lndSvcrDayOp; v58.Clean = value; _lndSvcrDayOp = v58;
                var v59 = _lndSvcrDayOpAddl; v59.Clean = value; _lndSvcrDayOpAddl = v59;
                var v60 = _lndSvcrHrsOp; v60.Clean = value; _lndSvcrHrsOp = v60;
                var v61 = _lndSvcrHrsOpAddl; v61.Clean = value; _lndSvcrHrsOpAddl = v61;
                var v62 = _lndSvcrJrsdctn; v62.Clean = value; _lndSvcrJrsdctn = v62;
                var v63 = _lndSvcrNm; v63.Clean = value; _lndSvcrNm = v63;
                var v64 = _lndSvcrOrgTyp; v64.Clean = value; _lndSvcrOrgTyp = v64;
                var v65 = _lndSvcrStCd; v65.Clean = value; _lndSvcrStCd = v65;
                var v66 = _lndSvcrStreetAddr1; v66.Clean = value; _lndSvcrStreetAddr1 = v66;
                var v67 = _lndSvcrStreetAddr2; v67.Clean = value; _lndSvcrStreetAddr2 = v67;
                var v68 = _lndSvcrZip; v68.Clean = value; _lndSvcrZip = v68;
                var v69 = _lndTaxIDNum; v69.Clean = value; _lndTaxIDNum = v69;
                var v70 = _lndTollFreePhoneNum; v70.Clean = value; _lndTollFreePhoneNum = v70;
                var v71 = _lndUrl; v71.Clean = value; _lndUrl = v71;
                var v72 = _lndVaIdNum; v72.Clean = value; _lndVaIdNum = v72;
                var v73 = _lndZip; v73.Clean = value; _lndZip = v73;
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