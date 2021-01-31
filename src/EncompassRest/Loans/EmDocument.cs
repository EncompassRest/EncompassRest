using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocument
    /// </summary>
    public sealed partial class EmDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _allngToNtPayToJrsdctn;
        private DirtyValue<string?>? _allngToNtPayToOrdNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _allngToNtPayToOrgTyp;
        private DirtyValue<string?>? _allngToNtPayToScsrsClaus;
        private DirtyValue<string?>? _allngToNtSignedByNm;
        private DirtyValue<string?>? _allngToNtSignedByNm2;
        private DirtyValue<string?>? _allngToNtSignedByNm3;
        private DirtyValue<string?>? _allngToNtSignedByTtl;
        private DirtyValue<string?>? _allngToNtSignedByTtl2;
        private DirtyValue<string?>? _allngToNtSignedByTtl3;
        private DirtyValue<StringEnumValue<SignedByTyp>>? _allngToNtSignedByTyp;
        private DirtyValue<string?>? _allngToNtWithoutRcrse;
        private DirtyValue<string?>? _apnLbl;
        private DirtyValue<bool?>? _asgnPrepByLblTxtDesc;
        private DirtyValue<bool?>? _asgnRecRtrnLblTxtDesc;
        private DirtyValue<string?>? _benCty;
        private DirtyValue<string?>? _benJrsdctn;
        private DirtyValue<string?>? _benNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _benOrgTyp;
        private DirtyValue<string?>? _benStCd;
        private DirtyValue<string?>? _benStreetAddr1;
        private DirtyValue<string?>? _benStreetAddr2;
        private DirtyValue<string?>? _benZip;
        private DirtyValue<string?>? _closInstrLndCntcInfoCity;
        private DirtyValue<string?>? _closInstrLndCntcInfoCoNm;
        private DirtyValue<StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc>>? _closInstrLndCntcInfoSamePtyTypDesc;
        private DirtyValue<string?>? _closInstrLndCntcInfoStCd;
        private DirtyValue<string?>? _closInstrLndCntcInfoStreetAddr1;
        private DirtyValue<string?>? _closInstrLndCntcInfoStreetAddr2;
        private DirtyValue<string?>? _closInstrLndCntcInfoZip;
        private DirtyValue<bool?>? _closInstrPrtInvLossPayee;
        private DirtyValue<bool?>? _closInstrStlmtAgtUseLndHud1;
        private DirtyValue<StringEnumValue<ClosInstrTtlPlcyTyp>>? _closInstrTtlPlcyTyp;
        private DirtyValue<string?>? _emxmlVersionId;
        private DirtyValue<string?>? _exeClosDocDlvrdToCty;
        private DirtyValue<string?>? _exeClosDocDlvrdToMiscTxtDesc;
        private DirtyValue<string?>? _exeClosDocDlvrdToNm;
        private DirtyValue<StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc>>? _exeClosDocDlvrdToSamePtyTypDesc;
        private DirtyValue<string?>? _exeClosDocDlvrdToStCd;
        private DirtyValue<string?>? _exeClosDocDlvrdToStreetAddr1;
        private DirtyValue<string?>? _exeClosDocDlvrdToStreetAddr2;
        private DirtyValue<string?>? _exeClosDocDlvrdToZip;
        private DirtyValue<StringEnumValue<ExeClosDocExprDt>>? _exeClosDocExprDt;
        private DirtyValue<StringEnumValue<ExeClosDocToBeRtrnd>>? _exeClosDocToBeRtrnd;
        private DirtyValue<StringEnumValue<ExeClosDocToBeRtrndHrs>>? _exeClosDocToBeRtrndHrs;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToAddlLine1;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToAddlLine2;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToCty;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToNm;
        private DirtyValue<StringEnumValue<RecSamePtyTypeDesc>>? _fnlTtlePcyRecDocsSentToSamePtyTypDesc;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToStcd;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToStreetAddr1;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToStreetAddr2;
        private DirtyValue<string?>? _fnlTtlePcyRecDocsSentToZip;
        private DirtyValue<string?>? _hazInsurEndsmtMailToAdtlTxt;
        private DirtyValue<string?>? _hazInsurEndsmtMailToCty;
        private DirtyValue<string?>? _hazInsurEndsmtMailToNm;
        private DirtyValue<string?>? _hazInsurEndsmtMailToStCd;
        private DirtyValue<string?>? _hazInsurEndsmtMailToStreetAddr1;
        private DirtyValue<string?>? _hazInsurEndsmtMailToStreetAddr2;
        private DirtyValue<string?>? _hazInsurEndsmtMailToZip;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _mersAdtlCity;
        private DirtyValue<string?>? _mersAdtlStCd;
        private DirtyValue<string?>? _mersAdtlStreetAddr1;
        private DirtyValue<string?>? _mersAdtlStreetAddr2;
        private DirtyValue<string?>? _mersAdtlZip;
        private DirtyValue<string?>? _mersCty;
        private DirtyValue<string?>? _mersJrsdctn;
        private DirtyValue<string?>? _mersName;
        private DirtyValue<StringEnumValue<OrgTyp>>? _mersOrgTyp;
        private DirtyValue<string?>? _mersPhoneNum;
        private DirtyValue<string?>? _mersStCd;
        private DirtyValue<string?>? _mersStreetAddr1;
        private DirtyValue<string?>? _mersStreetAddr2;
        private DirtyValue<string?>? _mersZip;
        private DirtyValue<string?>? _ntEndrsmtPayToJrsdctn;
        private DirtyValue<string?>? _ntEndrsmtPayToOrdNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _ntEndrsmtPayToOrgTyp;
        private DirtyValue<string?>? _ntEndrsmtPayToScsrsClaus;
        private DirtyValue<string?>? _ntEndrsmtSgndBy1MiscTxt;
        private DirtyValue<string?>? _ntEndrsmtSgndBy2MiscTxt;
        private DirtyValue<string?>? _ntEndrsmtSignedByNm;
        private DirtyValue<string?>? _ntEndrsmtSignedByNm2;
        private DirtyValue<string?>? _ntEndrsmtSignedByNm3;
        private DirtyValue<string?>? _ntEndrsmtSignedByTtl;
        private DirtyValue<string?>? _ntEndrsmtSignedByTtl2;
        private DirtyValue<string?>? _ntEndrsmtSignedByTtl3;
        private DirtyValue<StringEnumValue<SignedByTyp>>? _ntEndrsmtSignedByTyp;
        private DirtyValue<string?>? _ntEndrsmtWithoutRcrse;
        private DirtyValue<string?>? _ntEndsmtThrdPtyAddr1;
        private DirtyValue<string?>? _ntEndsmtThrdPtyAddr2;
        private DirtyValue<string?>? _ntEndsmtThrdPtyCty;
        private DirtyValue<string?>? _ntEndsmtThrdPtyJrsdctn;
        private DirtyValue<string?>? _ntEndsmtThrdPtyName;
        private DirtyValue<StringEnumValue<OrgTyp>>? _ntEndsmtThrdPtyOrgTyp;
        private DirtyValue<string?>? _ntEndsmtThrdPtyPhone;
        private DirtyValue<StringEnumValue<ScsrsClaus>>? _ntEndsmtThrdPtyScsrClaus;
        private DirtyValue<string?>? _ntEndsmtThrdPtyStCd;
        private DirtyValue<string?>? _ntEndsmtThrdPtyZip;
        private DirtyValue<string?>? _ntPayToAdtlTxt;
        private DirtyValue<string?>? _ntPayToCty;
        private DirtyValue<string?>? _ntPayToJrsdctn;
        private DirtyValue<string?>? _ntPayToNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _ntPayToOrgTyp;
        private DirtyValue<string?>? _ntPayToStCd;
        private DirtyValue<string?>? _ntPayToStreetAddr1;
        private DirtyValue<string?>? _ntPayToStreetAddr2;
        private DirtyValue<string?>? _ntPayToZip;
        private DirtyValue<string?>? _pmtCpn2PayToAdtlTxt;
        private DirtyValue<string?>? _pmtCpn2PayToAdtlTxt2;
        private DirtyValue<string?>? _pmtCpn2PayToCty;
        private DirtyValue<string?>? _pmtCpn2PayToNm;
        private DirtyValue<string?>? _pmtCpn2PayToStCd;
        private DirtyValue<string?>? _pmtCpn2PayToStreetAddr1;
        private DirtyValue<string?>? _pmtCpn2PayToStreetAddr2;
        private DirtyValue<string?>? _pmtCpn2PayToZip;
        private DirtyValue<string?>? _pmtCpnPayToAdtlTxt;
        private DirtyValue<string?>? _pmtCpnPayToAdtlTxt2;
        private DirtyValue<string?>? _pmtCpnPayToCty;
        private DirtyValue<string?>? _pmtCpnPayToNm;
        private DirtyValue<string?>? _pmtCpnPayToStCd;
        private DirtyValue<string?>? _pmtCpnPayToStreetAddr1;
        private DirtyValue<string?>? _pmtCpnPayToStreetAddr2;
        private DirtyValue<string?>? _pmtCpnPayToZip;
        private DirtyValue<StringEnumValue<PrtAdtlDateHud1>>? _prtAdtlDateHud1;
        private DirtyValue<bool?>? _prtAllngToNtBool;
        private DirtyValue<bool?>? _prtCorpMsgAsgnBool;
        private DirtyValue<StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt>>? _prtDocDtSctyIstrmtNtryAprncDt;
        private DirtyValue<bool?>? _prtIndxTilBool;
        private DirtyValue<bool?>? _prtInitBlckNtBool;
        private DirtyValue<bool?>? _prtInitBlckSctyIstrmtBool;
        private DirtyValue<bool?>? _prtInvLoanNumBool;
        private DirtyValue<bool?>? _prtInvLoanNumPmtCpn2Ind;
        private DirtyValue<bool?>? _prtInvLoanNumPmtCpnInd;
        private DirtyValue<bool?>? _prtInvLossPayeeHazInsurDisBool;
        private DirtyValue<bool?>? _prtLoanNumDeedBool;
        private DirtyValue<bool?>? _prtNtEndsmtBool;
        private DirtyValue<bool?>? _prtNtPayToCorpMsgBool;
        private DirtyValue<bool?>? _prtScsrsClausClosInstBool;
        private DirtyValue<bool?>? _prtScsrsClausHazInsurDisBool;
        private DirtyValue<bool?>? _prtScsrsClausHazInsurLtrBool;
        private DirtyValue<bool?>? _prtScsrsClausPmtCpnBool;
        private DirtyValue<bool?>? _prtSctyIstrmtCorpMsgBool;
        private DirtyValue<string?>? _recRtrnAttnLnNmTxtDesc;
        private DirtyValue<string?>? _recRtrnCty;
        private DirtyValue<string?>? _recRtrnLblTxtDesc;
        private DirtyValue<string?>? _recRtrnNm;
        private DirtyValue<StringEnumValue<RecSamePtyTypeDesc>>? _recRtrnNmSamePtyTypDesc;
        private DirtyValue<string?>? _recRtrnPhoneNum;
        private DirtyValue<string?>? _recRtrnStCd;
        private DirtyValue<string?>? _recRtrnStreetAddr1;
        private DirtyValue<string?>? _recRtrnStreetAddr2;
        private DirtyValue<string?>? _recRtrnTollFreePhoneNum;
        private DirtyValue<string?>? _recRtrnZip;
        private DirtyValue<bool?>? _rtrnExeClosPkgToLndBrchBool;
        private DirtyValue<string?>? _rtToCancelNtfcAdtlTxt;
        private DirtyValue<string?>? _rtToCancelNtfcCty;
        private DirtyValue<string?>? _rtToCancelNtfcEmail;
        private DirtyValue<string?>? _rtToCancelNtfcFax;
        private DirtyValue<string?>? _rtToCancelNtfcNm;
        private DirtyValue<string?>? _rtToCancelNtfcStCd;
        private DirtyValue<string?>? _rtToCancelNtfcStreetAddr1;
        private DirtyValue<string?>? _rtToCancelNtfcStreetAddr2;
        private DirtyValue<string?>? _rtToCancelNtfcZip;
        private DirtyValue<StringEnumValue<RtToCancelTransDtTyp>>? _rtToCancelTransDtTyp;
        private DirtyValue<string?>? _sctyIstrmtDCTrstFeePct;
        private DirtyValue<string?>? _sctyIstrmtDEAttyFeePct;
        private DirtyValue<decimal?>? _sctyIstrmtLAAttyFeePct;
        private DirtyValue<decimal?>? _sctyIstrmtLAMinAttyFeeAmt;
        private DirtyValue<string?>? _sctyIstrmtMDTrstFeePct;
        private DirtyValue<string?>? _sctyIstrmtMSTrstFeePct;
        private DirtyValue<string?>? _sctyIstrmtNCAttyFeePct;
        private DirtyValue<string?>? _sctyIstrmtNETrstFeePct;
        private DirtyValue<string?>? _sctyIstrmtNVAssmFeeAmt;
        private DirtyValue<string?>? _sctyIstrmtNVTrstFeePct;
        private DirtyValue<string?>? _sctyIstrmtOKAssmFeeAmt;
        private DirtyValue<string?>? _sctyIstrmtPOBoxAddr1;
        private DirtyValue<string?>? _sctyIstrmtPOBoxAddr2;
        private DirtyValue<string?>? _sctyIstrmtPrepByAdtlTxt;
        private DirtyValue<string?>? _sctyIstrmtPrepByCoNm;
        private DirtyValue<string?>? _sctyIstrmtPrepByCty;
        private DirtyValue<string?>? _sctyIstrmtPrepByIndvNm;
        private DirtyValue<string?>? _sctyIstrmtPrepByIndvTtl;
        private DirtyValue<string?>? _sctyIstrmtPrepByPhone;
        private DirtyValue<StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc>>? _sctyIstrmtPrepBySamePtyTypDesc;
        private DirtyValue<string?>? _sctyIstrmtPrepByStCd;
        private DirtyValue<string?>? _sctyIstrmtPrepByStreetAddr1;
        private DirtyValue<string?>? _sctyIstrmtPrepByStreetAddr2;
        private DirtyValue<string?>? _sctyIstrmtPrepByTxt;
        private DirtyValue<string?>? _sctyIstrmtPrepByZip;
        private DirtyValue<string?>? _sctyIstrmtTtlAdtlTxt;
        private DirtyValue<bool?>? _sctyIstrmtTtlAdtlTxtAbvTtl;
        private DirtyValue<string?>? _sctyIstrmtVATrstFeePct;
        private DirtyValue<string?>? _trst1Cnty;
        private DirtyValue<string?>? _trst1Cty;
        private DirtyValue<bool?>? _trst1IndvBool;
        private DirtyValue<string?>? _trst1Jrsdctn;
        private DirtyValue<string?>? _trst1Nm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _trst1OrgTyp;
        private DirtyValue<string?>? _trst1Phone;
        private DirtyValue<string?>? _trst1RsdtTxtDesc;
        private DirtyValue<StringEnumValue<TrstSamePtyTypDesc>>? _trst1SamePtyTypDesc;
        private DirtyValue<string?>? _trst1StCd;
        private DirtyValue<string?>? _trst1StreetAddr1;
        private DirtyValue<string?>? _trst1StreetAddr2;
        private DirtyValue<string?>? _trst1Zip;
        private DirtyValue<string?>? _trst2Cnty;
        private DirtyValue<string?>? _trst2Cty;
        private DirtyValue<bool?>? _trst2IndvBool;
        private DirtyValue<string?>? _trst2Jrsdctn;
        private DirtyValue<string?>? _trst2Nm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _trst2OrgTyp;
        private DirtyValue<string?>? _trst2Phone;
        private DirtyValue<string?>? _trst2RsdtTxtDesc;
        private DirtyValue<StringEnumValue<TrstSamePtyTypDesc>>? _trst2SamePtyTypDesc;
        private DirtyValue<string?>? _trst2StCd;
        private DirtyValue<string?>? _trst2StreetAddr1;
        private DirtyValue<string?>? _trst2StreetAddr2;
        private DirtyValue<string?>? _trst2Zip;

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Jurisdiction [Closing.AllngToNtPayToJrsdctn]
        /// </summary>
        public string? AllngToNtPayToJrsdctn { get => _allngToNtPayToJrsdctn; set => SetField(ref _allngToNtPayToJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to the Order of Name [Closing.AllngToNtPayToOrdNm]
        /// </summary>
        public string? AllngToNtPayToOrdNm { get => _allngToNtPayToOrdNm; set => SetField(ref _allngToNtPayToOrdNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Organization Type [Closing.AllngToNtPayToOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> AllngToNtPayToOrgTyp { get => _allngToNtPayToOrgTyp; set => SetField(ref _allngToNtPayToOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Successor Clause  [Closing.AllngToNtPayToScsrsClaus]
        /// </summary>
        public string? AllngToNtPayToScsrsClaus { get => _allngToNtPayToScsrsClaus; set => SetField(ref _allngToNtPayToScsrsClaus, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Name [Closing.AllngToNtSignedByNm]
        /// </summary>
        public string? AllngToNtSignedByNm { get => _allngToNtSignedByNm; set => SetField(ref _allngToNtSignedByNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 2 [Closing.AllngToNtSignedByNm2]
        /// </summary>
        public string? AllngToNtSignedByNm2 { get => _allngToNtSignedByNm2; set => SetField(ref _allngToNtSignedByNm2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 3 [Closing.AllngToNtSignedByNm3]
        /// </summary>
        public string? AllngToNtSignedByNm3 { get => _allngToNtSignedByNm3; set => SetField(ref _allngToNtSignedByNm3, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Title [Closing.AllngToNtSignedByTtl]
        /// </summary>
        public string? AllngToNtSignedByTtl { get => _allngToNtSignedByTtl; set => SetField(ref _allngToNtSignedByTtl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 2 [Closing.AllngToNtSignedByTtl2]
        /// </summary>
        public string? AllngToNtSignedByTtl2 { get => _allngToNtSignedByTtl2; set => SetField(ref _allngToNtSignedByTtl2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 3 [Closing.AllngToNtSignedByTtl3]
        /// </summary>
        public string? AllngToNtSignedByTtl3 { get => _allngToNtSignedByTtl3; set => SetField(ref _allngToNtSignedByTtl3, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Type [Closing.AllngToNtSignedByTyp]
        /// </summary>
        public StringEnumValue<SignedByTyp> AllngToNtSignedByTyp { get => _allngToNtSignedByTyp; set => SetField(ref _allngToNtSignedByTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Without Recourse Add'l Text [Closing.AllngToNtWithoutRcrse]
        /// </summary>
        public string? AllngToNtWithoutRcrse { get => _allngToNtWithoutRcrse; set => SetField(ref _allngToNtWithoutRcrse, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - APN # Label [Closing.ApnLbl]
        /// </summary>
        public string? ApnLbl { get => _apnLbl; set => SetField(ref _apnLbl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Assignment Prepared By Label Text [Closing.AsgnPrepByLblTxtDesc]
        /// </summary>
        public bool? AsgnPrepByLblTxtDesc { get => _asgnPrepByLblTxtDesc; set => SetField(ref _asgnPrepByLblTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Assignment Rec. and Return Label Text [Closing.AsgnRecRtrnLblTxtDesc]
        /// </summary>
        public bool? AsgnRecRtrnLblTxtDesc { get => _asgnRecRtrnLblTxtDesc; set => SetField(ref _asgnRecRtrnLblTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary City [Closing.BenCty]
        /// </summary>
        public string? BenCty { get => _benCty; set => SetField(ref _benCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Jurisdiction [Closing.BenJrsdctn]
        /// </summary>
        public string? BenJrsdctn { get => _benJrsdctn; set => SetField(ref _benJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Name [Closing.BenNm]
        /// </summary>
        public string? BenNm { get => _benNm; set => SetField(ref _benNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Organization Type [Closing.BenOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> BenOrgTyp { get => _benOrgTyp; set => SetField(ref _benOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary State Code [Closing.BenStCd]
        /// </summary>
        public string? BenStCd { get => _benStCd; set => SetField(ref _benStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Street Address [Closing.BenStreetAddr1]
        /// </summary>
        public string? BenStreetAddr1 { get => _benStreetAddr1; set => SetField(ref _benStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Street Address 2 [Closing.BenStreetAddr2]
        /// </summary>
        public string? BenStreetAddr2 { get => _benStreetAddr2; set => SetField(ref _benStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Postal Code [Closing.BenZip]
        /// </summary>
        public string? BenZip { get => _benZip; set => SetField(ref _benZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact City [Closing.ClosInstrLndCntcInfoCity]
        /// </summary>
        public string? ClosInstrLndCntcInfoCity { get => _closInstrLndCntcInfoCity; set => SetField(ref _closInstrLndCntcInfoCity, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Company Name [Closing.ClosInstrLndCntcInfoCoNm]
        /// </summary>
        public string? ClosInstrLndCntcInfoCoNm { get => _closInstrLndCntcInfoCoNm; set => SetField(ref _closInstrLndCntcInfoCoNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact-Same as Another Party [Closing.ClosInstrLndCntcInfoSamePtyTypDesc]
        /// </summary>
        public StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc> ClosInstrLndCntcInfoSamePtyTypDesc { get => _closInstrLndCntcInfoSamePtyTypDesc; set => SetField(ref _closInstrLndCntcInfoSamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact State Code [Closing.ClosInstrLndCntcInfoStCd]
        /// </summary>
        public string? ClosInstrLndCntcInfoStCd { get => _closInstrLndCntcInfoStCd; set => SetField(ref _closInstrLndCntcInfoStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 1 [Closing.ClosInstrLndCntcInfoStreetAddr1]
        /// </summary>
        public string? ClosInstrLndCntcInfoStreetAddr1 { get => _closInstrLndCntcInfoStreetAddr1; set => SetField(ref _closInstrLndCntcInfoStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 2 [Closing.ClosInstrLndCntcInfoStreetAddr2]
        /// </summary>
        public string? ClosInstrLndCntcInfoStreetAddr2 { get => _closInstrLndCntcInfoStreetAddr2; set => SetField(ref _closInstrLndCntcInfoStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Zip Code [Closing.ClosInstrLndCntcInfoZip]
        /// </summary>
        public string? ClosInstrLndCntcInfoZip { get => _closInstrLndCntcInfoZip; set => SetField(ref _closInstrLndCntcInfoZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Print Investor Loss Payee [Closing.ClosInstrPrtInvLossPayee]
        /// </summary>
        public bool? ClosInstrPrtInvLossPayee { get => _closInstrPrtInvLossPayee; set => SetField(ref _closInstrPrtInvLossPayee, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Settlement Agent to use Lender HUD-1 [Closing.ClosInstrStlmtAgtUseLndHud1]
        /// </summary>
        public bool? ClosInstrStlmtAgtUseLndHud1 { get => _closInstrStlmtAgtUseLndHud1; set => SetField(ref _closInstrStlmtAgtUseLndHud1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Title Policy Type [Closing.ClosInstrTtlPlcyTyp]
        /// </summary>
        public StringEnumValue<ClosInstrTtlPlcyTyp> ClosInstrTtlPlcyTyp { get => _closInstrTtlPlcyTyp; set => SetField(ref _closInstrTtlPlcyTyp, value); }

        /// <summary>
        /// EmDocument EmxmlVersionId
        /// </summary>
        public string? EmxmlVersionId { get => _emxmlVersionId; set => SetField(ref _emxmlVersionId, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To city [Closing.ExeClosDocDlvrdToCty]
        /// </summary>
        public string? ExeClosDocDlvrdToCty { get => _exeClosDocDlvrdToCty; set => SetField(ref _exeClosDocDlvrdToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Miscellaneous Text Description  [Closing.ExeClosDocDlvrdToMiscTxtDesc]
        /// </summary>
        public string? ExeClosDocDlvrdToMiscTxtDesc { get => _exeClosDocDlvrdToMiscTxtDesc; set => SetField(ref _exeClosDocDlvrdToMiscTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Name [Closing.ExeClosDocDlvrdToNm]
        /// </summary>
        public string? ExeClosDocDlvrdToNm { get => _exeClosDocDlvrdToNm; set => SetField(ref _exeClosDocDlvrdToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Docs to be Delivered to the same party as [Closing.ExeClosDocDlvrdToSamePtyTypDesc]
        /// </summary>
        public StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc> ExeClosDocDlvrdToSamePtyTypDesc { get => _exeClosDocDlvrdToSamePtyTypDesc; set => SetField(ref _exeClosDocDlvrdToSamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To state [Closing.ExeClosDocDlvrdToStCd]
        /// </summary>
        public string? ExeClosDocDlvrdToStCd { get => _exeClosDocDlvrdToStCd; set => SetField(ref _exeClosDocDlvrdToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address [Closing.ExeClosDocDlvrdToStreetAddr1]
        /// </summary>
        public string? ExeClosDocDlvrdToStreetAddr1 { get => _exeClosDocDlvrdToStreetAddr1; set => SetField(ref _exeClosDocDlvrdToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address 2 [Closing.ExeClosDocDlvrdToStreetAddr2]
        /// </summary>
        public string? ExeClosDocDlvrdToStreetAddr2 { get => _exeClosDocDlvrdToStreetAddr2; set => SetField(ref _exeClosDocDlvrdToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Zip [Closing.ExeClosDocDlvrdToZip]
        /// </summary>
        public string? ExeClosDocDlvrdToZip { get => _exeClosDocDlvrdToZip; set => SetField(ref _exeClosDocDlvrdToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Expiration Date [Closing.ExeClosDocExprDt]
        /// </summary>
        public StringEnumValue<ExeClosDocExprDt> ExeClosDocExprDt { get => _exeClosDocExprDt; set => SetField(ref _exeClosDocExprDt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned [Closing.ExeClosDocToBeRtrnd]
        /// </summary>
        public StringEnumValue<ExeClosDocToBeRtrnd> ExeClosDocToBeRtrnd { get => _exeClosDocToBeRtrnd; set => SetField(ref _exeClosDocToBeRtrnd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned Hours [Closing.ExeClosDocToBeRtrndHrs]
        /// </summary>
        public StringEnumValue<ExeClosDocToBeRtrndHrs> ExeClosDocToBeRtrndHrs { get => _exeClosDocToBeRtrndHrs; set => SetField(ref _exeClosDocToBeRtrndHrs, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Addition line 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine1]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToAddlLine1 { get => _fnlTtlePcyRecDocsSentToAddlLine1; set => SetField(ref _fnlTtlePcyRecDocsSentToAddlLine1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Addition line 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine2]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToAddlLine2 { get => _fnlTtlePcyRecDocsSentToAddlLine2; set => SetField(ref _fnlTtlePcyRecDocsSentToAddlLine2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - city of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToCty]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToCty { get => _fnlTtlePcyRecDocsSentToCty; set => SetField(ref _fnlTtlePcyRecDocsSentToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Company Name of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToNm]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToNm { get => _fnlTtlePcyRecDocsSentToNm; set => SetField(ref _fnlTtlePcyRecDocsSentToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Final Title Policy and Recorded Docs to be sent to the same party as  [Closing.FnlTtlePcyRecDocsSentToSamePtyTypDesc]
        /// </summary>
        public StringEnumValue<RecSamePtyTypeDesc> FnlTtlePcyRecDocsSentToSamePtyTypDesc { get => _fnlTtlePcyRecDocsSentToSamePtyTypDesc; set => SetField(ref _fnlTtlePcyRecDocsSentToSamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStcd]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToStcd { get => _fnlTtlePcyRecDocsSentToStcd; set => SetField(ref _fnlTtlePcyRecDocsSentToStcd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - address 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr1]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToStreetAddr1 { get => _fnlTtlePcyRecDocsSentToStreetAddr1; set => SetField(ref _fnlTtlePcyRecDocsSentToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - address 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr2]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToStreetAddr2 { get => _fnlTtlePcyRecDocsSentToStreetAddr2; set => SetField(ref _fnlTtlePcyRecDocsSentToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToZip]
        /// </summary>
        public string? FnlTtlePcyRecDocsSentToZip { get => _fnlTtlePcyRecDocsSentToZip; set => SetField(ref _fnlTtlePcyRecDocsSentToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Additional Text [Closing.HazInsurEndsmtMailToAdtlTxt]
        /// </summary>
        public string? HazInsurEndsmtMailToAdtlTxt { get => _hazInsurEndsmtMailToAdtlTxt; set => SetField(ref _hazInsurEndsmtMailToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To City [Closing.HazInsurEndsmtMailToCty]
        /// </summary>
        public string? HazInsurEndsmtMailToCty { get => _hazInsurEndsmtMailToCty; set => SetField(ref _hazInsurEndsmtMailToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Name [Closing.HazInsurEndsmtMailToNm]
        /// </summary>
        public string? HazInsurEndsmtMailToNm { get => _hazInsurEndsmtMailToNm; set => SetField(ref _hazInsurEndsmtMailToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To State Code [Closing.HazInsurEndsmtMailToStCd]
        /// </summary>
        public string? HazInsurEndsmtMailToStCd { get => _hazInsurEndsmtMailToStCd; set => SetField(ref _hazInsurEndsmtMailToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address [Closing.HazInsurEndsmtMailToStreetAddr1]
        /// </summary>
        public string? HazInsurEndsmtMailToStreetAddr1 { get => _hazInsurEndsmtMailToStreetAddr1; set => SetField(ref _hazInsurEndsmtMailToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address 2 [Closing.HazInsurEndsmtMailToStreetAddr2]
        /// </summary>
        public string? HazInsurEndsmtMailToStreetAddr2 { get => _hazInsurEndsmtMailToStreetAddr2; set => SetField(ref _hazInsurEndsmtMailToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Postal Code [Closing.HazInsurEndsmtMailToZip]
        /// </summary>
        public string? HazInsurEndsmtMailToZip { get => _hazInsurEndsmtMailToZip; set => SetField(ref _hazInsurEndsmtMailToZip, value); }

        /// <summary>
        /// EmDocument Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional City [Closing.MersAdtlCity]
        /// </summary>
        public string? MersAdtlCity { get => _mersAdtlCity; set => SetField(ref _mersAdtlCity, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional State Code [Closing.MersAdtlStCd]
        /// </summary>
        public string? MersAdtlStCd { get => _mersAdtlStCd; set => SetField(ref _mersAdtlStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Street Address line 1 [Closing.MersAdtlStreetAddr1]
        /// </summary>
        public string? MersAdtlStreetAddr1 { get => _mersAdtlStreetAddr1; set => SetField(ref _mersAdtlStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Street Address line 2 [Closing.MersAdtlStreetAddr2]
        /// </summary>
        public string? MersAdtlStreetAddr2 { get => _mersAdtlStreetAddr2; set => SetField(ref _mersAdtlStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Postal Code [Closing.MersAdtlZip]
        /// </summary>
        public string? MersAdtlZip { get => _mersAdtlZip; set => SetField(ref _mersAdtlZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS City [Closing.MersCty]
        /// </summary>
        public string? MersCty { get => _mersCty; set => SetField(ref _mersCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Jurisdiction [Closing.MersJrsdctn]
        /// </summary>
        public string? MersJrsdctn { get => _mersJrsdctn; set => SetField(ref _mersJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Name [Closing.MersName]
        /// </summary>
        public string? MersName { get => _mersName; set => SetField(ref _mersName, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Organization Type [Closing.MersOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> MersOrgTyp { get => _mersOrgTyp; set => SetField(ref _mersOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Telephone No. [Closing.MersPhoneNum]
        /// </summary>
        public string? MersPhoneNum { get => _mersPhoneNum; set => SetField(ref _mersPhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS State Code [Closing.MersStCd]
        /// </summary>
        public string? MersStCd { get => _mersStCd; set => SetField(ref _mersStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Street Address [Closing.MersStreetAddr1]
        /// </summary>
        public string? MersStreetAddr1 { get => _mersStreetAddr1; set => SetField(ref _mersStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Street Address 2 [Closing.MersStreetAddr2]
        /// </summary>
        public string? MersStreetAddr2 { get => _mersStreetAddr2; set => SetField(ref _mersStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Postal Code [Closing.MersZip]
        /// </summary>
        public string? MersZip { get => _mersZip; set => SetField(ref _mersZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Jurisdiction [Closing.NtEndrsmtPayToJrsdctn]
        /// </summary>
        public string? NtEndrsmtPayToJrsdctn { get => _ntEndrsmtPayToJrsdctn; set => SetField(ref _ntEndrsmtPayToJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay to the Order of Name [Closing.NtEndrsmtPayToOrdNm]
        /// </summary>
        public string? NtEndrsmtPayToOrdNm { get => _ntEndrsmtPayToOrdNm; set => SetField(ref _ntEndrsmtPayToOrdNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Organization Type [Closing.NtEndrsmtPayToOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> NtEndrsmtPayToOrgTyp { get => _ntEndrsmtPayToOrgTyp; set => SetField(ref _ntEndrsmtPayToOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Successor Clause [Closing.NtEndrsmtPayToScsrsClaus]
        /// </summary>
        public string? NtEndrsmtPayToScsrsClaus { get => _ntEndrsmtPayToScsrsClaus; set => SetField(ref _ntEndrsmtPayToScsrsClaus, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed Additional text [Closing.NtEndrsmtSgndBy1MiscTxt]
        /// </summary>
        public string? NtEndrsmtSgndBy1MiscTxt { get => _ntEndrsmtSgndBy1MiscTxt; set => SetField(ref _ntEndrsmtSgndBy1MiscTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 additional text [Closing.NtEndrsmtSgndBy2MiscTxt]
        /// </summary>
        public string? NtEndrsmtSgndBy2MiscTxt { get => _ntEndrsmtSgndBy2MiscTxt; set => SetField(ref _ntEndrsmtSgndBy2MiscTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsment Signed By Name [Closing.NtEndrsmtSignedByNm]
        /// </summary>
        public string? NtEndrsmtSignedByNm { get => _ntEndrsmtSignedByNm; set => SetField(ref _ntEndrsmtSignedByNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 2 [Closing.NtEndrsmtSignedByNm2]
        /// </summary>
        public string? NtEndrsmtSignedByNm2 { get => _ntEndrsmtSignedByNm2; set => SetField(ref _ntEndrsmtSignedByNm2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 3 [Closing.NtEndrsmtSignedByNm3]
        /// </summary>
        public string? NtEndrsmtSignedByNm3 { get => _ntEndrsmtSignedByNm3; set => SetField(ref _ntEndrsmtSignedByNm3, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title [Closing.NtEndrsmtSignedByTtl]
        /// </summary>
        public string? NtEndrsmtSignedByTtl { get => _ntEndrsmtSignedByTtl; set => SetField(ref _ntEndrsmtSignedByTtl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 [Closing.NtEndrsmtSignedByTtl2]
        /// </summary>
        public string? NtEndrsmtSignedByTtl2 { get => _ntEndrsmtSignedByTtl2; set => SetField(ref _ntEndrsmtSignedByTtl2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 3 [Closing.NtEndrsmtSignedByTtl3]
        /// </summary>
        public string? NtEndrsmtSignedByTtl3 { get => _ntEndrsmtSignedByTtl3; set => SetField(ref _ntEndrsmtSignedByTtl3, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Type [Closing.NtEndrsmtSignedByTyp]
        /// </summary>
        public StringEnumValue<SignedByTyp> NtEndrsmtSignedByTyp { get => _ntEndrsmtSignedByTyp; set => SetField(ref _ntEndrsmtSignedByTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Without Recourse Add'l Text [Closing.NtEndrsmtWithoutRcrse]
        /// </summary>
        public string? NtEndrsmtWithoutRcrse { get => _ntEndrsmtWithoutRcrse; set => SetField(ref _ntEndrsmtWithoutRcrse, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 1 [Closing.NtEndsmtThrdPtyAddr1]
        /// </summary>
        public string? NtEndsmtThrdPtyAddr1 { get => _ntEndsmtThrdPtyAddr1; set => SetField(ref _ntEndsmtThrdPtyAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 2 [Closing.NtEndsmtThrdPtyAddr2]
        /// </summary>
        public string? NtEndsmtThrdPtyAddr2 { get => _ntEndsmtThrdPtyAddr2; set => SetField(ref _ntEndsmtThrdPtyAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party City [Closing.NtEndsmtThrdPtyCty]
        /// </summary>
        public string? NtEndsmtThrdPtyCty { get => _ntEndsmtThrdPtyCty; set => SetField(ref _ntEndsmtThrdPtyCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Jurisdiction [Closing.NtEndsmtThrdPtyJrsdctn]
        /// </summary>
        public string? NtEndsmtThrdPtyJrsdctn { get => _ntEndsmtThrdPtyJrsdctn; set => SetField(ref _ntEndsmtThrdPtyJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Name [Closing.NtEndsmtThrdPtyName]
        /// </summary>
        public string? NtEndsmtThrdPtyName { get => _ntEndsmtThrdPtyName; set => SetField(ref _ntEndsmtThrdPtyName, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Org Type [Closing.NtEndsmtThrdPtyOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> NtEndsmtThrdPtyOrgTyp { get => _ntEndsmtThrdPtyOrgTyp; set => SetField(ref _ntEndsmtThrdPtyOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Phone [Closing.NtEndsmtThrdPtyPhone]
        /// </summary>
        public string? NtEndsmtThrdPtyPhone { get => _ntEndsmtThrdPtyPhone; set => SetField(ref _ntEndsmtThrdPtyPhone, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Successor Clause [Closing.NtEndsmtThrdPtyScsrClaus]
        /// </summary>
        public StringEnumValue<ScsrsClaus> NtEndsmtThrdPtyScsrClaus { get => _ntEndsmtThrdPtyScsrClaus; set => SetField(ref _ntEndsmtThrdPtyScsrClaus, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party State [Closing.NtEndsmtThrdPtyStCd]
        /// </summary>
        public string? NtEndsmtThrdPtyStCd { get => _ntEndsmtThrdPtyStCd; set => SetField(ref _ntEndsmtThrdPtyStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Zip [Closing.NtEndsmtThrdPtyZip]
        /// </summary>
        public string? NtEndsmtThrdPtyZip { get => _ntEndsmtThrdPtyZip; set => SetField(ref _ntEndsmtThrdPtyZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Additional Text [Closing.NtPayToAdtlTxt]
        /// </summary>
        public string? NtPayToAdtlTxt { get => _ntPayToAdtlTxt; set => SetField(ref _ntPayToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To City [Closing.NtPayToCty]
        /// </summary>
        public string? NtPayToCty { get => _ntPayToCty; set => SetField(ref _ntPayToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Jurisdiction [Closing.NtPayToJrsdctn]
        /// </summary>
        public string? NtPayToJrsdctn { get => _ntPayToJrsdctn; set => SetField(ref _ntPayToJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Name [Closing.NtPayToNm]
        /// </summary>
        public string? NtPayToNm { get => _ntPayToNm; set => SetField(ref _ntPayToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Organization Type [Closing.NtPayToOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> NtPayToOrgTyp { get => _ntPayToOrgTyp; set => SetField(ref _ntPayToOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To State Code [Closing.NtPayToStCd]
        /// </summary>
        public string? NtPayToStCd { get => _ntPayToStCd; set => SetField(ref _ntPayToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Street Address [Closing.NtPayToStreetAddr1]
        /// </summary>
        public string? NtPayToStreetAddr1 { get => _ntPayToStreetAddr1; set => SetField(ref _ntPayToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Street Address 2 [Closing.NtPayToStreetAddr2]
        /// </summary>
        public string? NtPayToStreetAddr2 { get => _ntPayToStreetAddr2; set => SetField(ref _ntPayToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Postal Code [Closing.NtPayToZip]
        /// </summary>
        public string? NtPayToZip { get => _ntPayToZip; set => SetField(ref _ntPayToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text Description  [Closing.PmtCpn2PayToAdtlTxt]
        /// </summary>
        public string? PmtCpn2PayToAdtlTxt { get => _pmtCpn2PayToAdtlTxt; set => SetField(ref _pmtCpn2PayToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text 2 Description [Closing.PmtCpn2PayToAdtlTxt2]
        /// </summary>
        public string? PmtCpn2PayToAdtlTxt2 { get => _pmtCpn2PayToAdtlTxt2; set => SetField(ref _pmtCpn2PayToAdtlTxt2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To City [Closing.PmtCpn2PayToCty]
        /// </summary>
        public string? PmtCpn2PayToCty { get => _pmtCpn2PayToCty; set => SetField(ref _pmtCpn2PayToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Name [Closing.PmtCpn2PayToNm]
        /// </summary>
        public string? PmtCpn2PayToNm { get => _pmtCpn2PayToNm; set => SetField(ref _pmtCpn2PayToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To State Code [Closing.PmtCpn2PayToStCd]
        /// </summary>
        public string? PmtCpn2PayToStCd { get => _pmtCpn2PayToStCd; set => SetField(ref _pmtCpn2PayToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address [Closing.PmtCpn2PayToStreetAddr1]
        /// </summary>
        public string? PmtCpn2PayToStreetAddr1 { get => _pmtCpn2PayToStreetAddr1; set => SetField(ref _pmtCpn2PayToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address 2 [Closing.PmtCpn2PayToStreetAddr2]
        /// </summary>
        public string? PmtCpn2PayToStreetAddr2 { get => _pmtCpn2PayToStreetAddr2; set => SetField(ref _pmtCpn2PayToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Postal Code [Closing.PmtCpn2PayToZip]
        /// </summary>
        public string? PmtCpn2PayToZip { get => _pmtCpn2PayToZip; set => SetField(ref _pmtCpn2PayToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 1 [Closing.PmtCpnPayToAdtlTxt]
        /// </summary>
        public string? PmtCpnPayToAdtlTxt { get => _pmtCpnPayToAdtlTxt; set => SetField(ref _pmtCpnPayToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 2 [Closing.PmtCpnPayToAdtlTxt2]
        /// </summary>
        public string? PmtCpnPayToAdtlTxt2 { get => _pmtCpnPayToAdtlTxt2; set => SetField(ref _pmtCpnPayToAdtlTxt2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To City [Closing.PmtCpnPayToCty]
        /// </summary>
        public string? PmtCpnPayToCty { get => _pmtCpnPayToCty; set => SetField(ref _pmtCpnPayToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Name [Closing.PmtCpnPayToNm]
        /// </summary>
        public string? PmtCpnPayToNm { get => _pmtCpnPayToNm; set => SetField(ref _pmtCpnPayToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To State Code [Closing.PmtCpnPayToStCd]
        /// </summary>
        public string? PmtCpnPayToStCd { get => _pmtCpnPayToStCd; set => SetField(ref _pmtCpnPayToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address [Closing.PmtCpnPayToStreetAddr1]
        /// </summary>
        public string? PmtCpnPayToStreetAddr1 { get => _pmtCpnPayToStreetAddr1; set => SetField(ref _pmtCpnPayToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address 2 [Closing.PmtCpnPayToStreetAddr2]
        /// </summary>
        public string? PmtCpnPayToStreetAddr2 { get => _pmtCpnPayToStreetAddr2; set => SetField(ref _pmtCpnPayToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Postal Code [Closing.PmtCpnPayToZip]
        /// </summary>
        public string? PmtCpnPayToZip { get => _pmtCpnPayToZip; set => SetField(ref _pmtCpnPayToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Additional Settlement Date on HUD1 [Closing.PrtAdtlDateHud1]
        /// </summary>
        public StringEnumValue<PrtAdtlDateHud1> PrtAdtlDateHud1 { get => _prtAdtlDateHud1; set => SetField(ref _prtAdtlDateHud1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Allonge to Note [Closing.PrtAllngToNtBool]
        /// </summary>
        public bool? PrtAllngToNtBool { get => _prtAllngToNtBool; set => SetField(ref _prtAllngToNtBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Assignment Corp. Message [Closing.PrtCorpMsgAsgnBool]
        /// </summary>
        public bool? PrtCorpMsgAsgnBool { get => _prtCorpMsgAsgnBool; set => SetField(ref _prtCorpMsgAsgnBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Document Data as Security Instrument Notary Appearance Date Indicator [Closing.PrtDocDtSctyIstrmtNtryAprncDt]
        /// </summary>
        public StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt> PrtDocDtSctyIstrmtNtryAprncDt { get => _prtDocDtSctyIstrmtNtryAprncDt; set => SetField(ref _prtDocDtSctyIstrmtNtryAprncDt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Index on TIL [Closing.PrtIndxTilBool]
        /// </summary>
        public bool? PrtIndxTilBool { get => _prtIndxTilBool; set => SetField(ref _prtIndxTilBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Borrower Initial Line on Note Indicator [Closing.PrtInitBlckNtBool]
        /// </summary>
        public bool? PrtInitBlckNtBool { get => _prtInitBlckNtBool; set => SetField(ref _prtInitBlckNtBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Initial Line on Sec. Instr. [Closing.PrtInitBlckSctyIstrmtBool]
        /// </summary>
        public bool? PrtInitBlckSctyIstrmtBool { get => _prtInitBlckSctyIstrmtBool; set => SetField(ref _prtInitBlckSctyIstrmtBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number Indicator [Closing.PrtInvLoanNumBool]
        /// </summary>
        public bool? PrtInvLoanNumBool { get => _prtInvLoanNumBool; set => SetField(ref _prtInvLoanNumBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 2 Indicator [Closing.PrtInvLoanNumPmtCpn2Ind]
        /// </summary>
        public bool? PrtInvLoanNumPmtCpn2Ind { get => _prtInvLoanNumPmtCpn2Ind; set => SetField(ref _prtInvLoanNumPmtCpn2Ind, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 1 Indicator [Closing.PrtInvLoanNumPmtCpnInd]
        /// </summary>
        public bool? PrtInvLoanNumPmtCpnInd { get => _prtInvLoanNumPmtCpnInd; set => SetField(ref _prtInvLoanNumPmtCpnInd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loss Payee on Hazard Insurance Disclosure [Closing.PrtInvLossPayeeHazInsurDisBool]
        /// </summary>
        public bool? PrtInvLossPayeeHazInsurDisBool { get => _prtInvLossPayeeHazInsurDisBool; set => SetField(ref _prtInvLossPayeeHazInsurDisBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Loan No. On Sec. Instr. [Closing.PrtLoanNumDeedBool]
        /// </summary>
        public bool? PrtLoanNumDeedBool { get => _prtLoanNumDeedBool; set => SetField(ref _prtLoanNumDeedBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Note Endorsement [Closing.PrtNtEndsmtBool]
        /// </summary>
        public bool? PrtNtEndsmtBool { get => _prtNtEndsmtBool; set => SetField(ref _prtNtEndsmtBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Note Pay To Corp. Message [Closing.PrtNtPayToCorpMsgBool]
        /// </summary>
        public bool? PrtNtPayToCorpMsgBool { get => _prtNtPayToCorpMsgBool; set => SetField(ref _prtNtPayToCorpMsgBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text on Closing Instructions [Closing.PrtScsrsClausClosInstBool]
        /// </summary>
        public bool? PrtScsrsClausClosInstBool { get => _prtScsrsClausClosInstBool; set => SetField(ref _prtScsrsClausClosInstBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause on Hazard Insurance Disclosure [Closing.PrtScsrsClausHazInsurDisBool]
        /// </summary>
        public bool? PrtScsrsClausHazInsurDisBool { get => _prtScsrsClausHazInsurDisBool; set => SetField(ref _prtScsrsClausHazInsurDisBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text Hazard Endorse. Letter [Closing.PrtScsrsClausHazInsurLtrBool]
        /// </summary>
        public bool? PrtScsrsClausHazInsurLtrBool { get => _prtScsrsClausHazInsurLtrBool; set => SetField(ref _prtScsrsClausHazInsurLtrBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text on Payment Coupon [Closing.PrtScsrsClausPmtCpnBool]
        /// </summary>
        public bool? PrtScsrsClausPmtCpnBool { get => _prtScsrsClausPmtCpnBool; set => SetField(ref _prtScsrsClausPmtCpnBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Sec. Instr. Corp. Message [Closing.PrtSctyIstrmtCorpMsgBool]
        /// </summary>
        public bool? PrtSctyIstrmtCorpMsgBool { get => _prtSctyIstrmtCorpMsgBool; set => SetField(ref _prtSctyIstrmtCorpMsgBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Attention Line Name or Text Description [Closing.RecRtrnAttnLnNmTxtDesc]
        /// </summary>
        public string? RecRtrnAttnLnNmTxtDesc { get => _recRtrnAttnLnNmTxtDesc; set => SetField(ref _recRtrnAttnLnNmTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return City [Closing.RecRtrnCty]
        /// </summary>
        public string? RecRtrnCty { get => _recRtrnCty; set => SetField(ref _recRtrnCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Label Text Description [Closing.RecRtrnLblTxtDesc]
        /// </summary>
        public string? RecRtrnLblTxtDesc { get => _recRtrnLblTxtDesc; set => SetField(ref _recRtrnLblTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Name [Closing.RecRtrnNm]
        /// </summary>
        public string? RecRtrnNm { get => _recRtrnNm; set => SetField(ref _recRtrnNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Name same as another party [Closing.RecRtrnNmSamePtyTypDesc]
        /// </summary>
        public StringEnumValue<RecSamePtyTypeDesc> RecRtrnNmSamePtyTypDesc { get => _recRtrnNmSamePtyTypDesc; set => SetField(ref _recRtrnNmSamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Telephone Number [Closing.RecRtrnPhoneNum]
        /// </summary>
        public string? RecRtrnPhoneNum { get => _recRtrnPhoneNum; set => SetField(ref _recRtrnPhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return State Code [Closing.RecRtrnStCd]
        /// </summary>
        public string? RecRtrnStCd { get => _recRtrnStCd; set => SetField(ref _recRtrnStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Street Address [Closing.RecRtrnStreetAddr1]
        /// </summary>
        public string? RecRtrnStreetAddr1 { get => _recRtrnStreetAddr1; set => SetField(ref _recRtrnStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Street Address 2 [Closing.RecRtrnStreetAddr2]
        /// </summary>
        public string? RecRtrnStreetAddr2 { get => _recRtrnStreetAddr2; set => SetField(ref _recRtrnStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Toll-Free Telephone Number [Closing.RecRtrnTollFreePhoneNum]
        /// </summary>
        public string? RecRtrnTollFreePhoneNum { get => _recRtrnTollFreePhoneNum; set => SetField(ref _recRtrnTollFreePhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Postal Code [Closing.RecRtrnZip]
        /// </summary>
        public string? RecRtrnZip { get => _recRtrnZip; set => SetField(ref _recRtrnZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Return Executed Closing Package to Lender Branch Indicator [Closing.RtrnExeClosPkgToLndBrchBool]
        /// </summary>
        public bool? RtrnExeClosPkgToLndBrchBool { get => _rtrnExeClosPkgToLndBrchBool; set => SetField(ref _rtrnExeClosPkgToLndBrchBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Miscellaneous Text Description  [Closing.RtToCancelNtfcAdtlTxt]
        /// </summary>
        public string? RtToCancelNtfcAdtlTxt { get => _rtToCancelNtfcAdtlTxt; set => SetField(ref _rtToCancelNtfcAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification City [Closing.RtToCancelNtfcCty]
        /// </summary>
        public string? RtToCancelNtfcCty { get => _rtToCancelNtfcCty; set => SetField(ref _rtToCancelNtfcCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Email [Closing.RtToCancelNtfcEmail]
        /// </summary>
        public string? RtToCancelNtfcEmail { get => _rtToCancelNtfcEmail; set => SetField(ref _rtToCancelNtfcEmail, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Fax [Closing.RtToCancelNtfcFax]
        /// </summary>
        public string? RtToCancelNtfcFax { get => _rtToCancelNtfcFax; set => SetField(ref _rtToCancelNtfcFax, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Name [Closing.RtToCancelNtfcNm]
        /// </summary>
        public string? RtToCancelNtfcNm { get => _rtToCancelNtfcNm; set => SetField(ref _rtToCancelNtfcNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification State Code [Closing.RtToCancelNtfcStCd]
        /// </summary>
        public string? RtToCancelNtfcStCd { get => _rtToCancelNtfcStCd; set => SetField(ref _rtToCancelNtfcStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address [Closing.RtToCancelNtfcStreetAddr1]
        /// </summary>
        public string? RtToCancelNtfcStreetAddr1 { get => _rtToCancelNtfcStreetAddr1; set => SetField(ref _rtToCancelNtfcStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address 2 [Closing.RtToCancelNtfcStreetAddr2]
        /// </summary>
        public string? RtToCancelNtfcStreetAddr2 { get => _rtToCancelNtfcStreetAddr2; set => SetField(ref _rtToCancelNtfcStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Postal Code [Closing.RtToCancelNtfcZip]
        /// </summary>
        public string? RtToCancelNtfcZip { get => _rtToCancelNtfcZip; set => SetField(ref _rtToCancelNtfcZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Transaction Date [Closing.RtToCancelTransDtTyp]
        /// </summary>
        public StringEnumValue<RtToCancelTransDtTyp> RtToCancelTransDtTyp { get => _rtToCancelTransDtTyp; set => SetField(ref _rtToCancelTransDtTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - DC Trustee Fee [Closing.SctyIstrmtDCTrstFeePct]
        /// </summary>
        public string? SctyIstrmtDCTrstFeePct { get => _sctyIstrmtDCTrstFeePct; set => SetField(ref _sctyIstrmtDCTrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - DE Attorney Fee [Closing.SctyIstrmtDEAttyFeePct]
        /// </summary>
        public string? SctyIstrmtDEAttyFeePct { get => _sctyIstrmtDEAttyFeePct; set => SetField(ref _sctyIstrmtDEAttyFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - LA Attorney Fee Percent [Closing.SctyIstrmtLAAttyFeePct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SctyIstrmtLAAttyFeePct { get => _sctyIstrmtLAAttyFeePct; set => SetField(ref _sctyIstrmtLAAttyFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - LA Minimum Attorney Fee Amount [Closing.SctyIstrmtLAMinAttyFeeAmt]
        /// </summary>
        public decimal? SctyIstrmtLAMinAttyFeeAmt { get => _sctyIstrmtLAMinAttyFeeAmt; set => SetField(ref _sctyIstrmtLAMinAttyFeeAmt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MD Trustee Fee [Closing.SctyIstrmtMDTrstFeePct]
        /// </summary>
        public string? SctyIstrmtMDTrstFeePct { get => _sctyIstrmtMDTrstFeePct; set => SetField(ref _sctyIstrmtMDTrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - MS Trustee Fee [Closing.SctyIstrmtMSTrstFeePct]
        /// </summary>
        public string? SctyIstrmtMSTrstFeePct { get => _sctyIstrmtMSTrstFeePct; set => SetField(ref _sctyIstrmtMSTrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - NC Trustee Fee [Closing.SctyIstrmtNCAttyFeePct]
        /// </summary>
        public string? SctyIstrmtNCAttyFeePct { get => _sctyIstrmtNCAttyFeePct; set => SetField(ref _sctyIstrmtNCAttyFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - NE Trustee Fee [Closing.SctyIstrmtNETrstFeePct]
        /// </summary>
        public string? SctyIstrmtNETrstFeePct { get => _sctyIstrmtNETrstFeePct; set => SetField(ref _sctyIstrmtNETrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - NV Assumption Fee [Closing.SctyIstrmtNVAssmFeeAmt]
        /// </summary>
        public string? SctyIstrmtNVAssmFeeAmt { get => _sctyIstrmtNVAssmFeeAmt; set => SetField(ref _sctyIstrmtNVAssmFeeAmt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - NV Trustee Fee [Closing.SctyIstrmtNVTrstFeePct]
        /// </summary>
        public string? SctyIstrmtNVTrstFeePct { get => _sctyIstrmtNVTrstFeePct; set => SetField(ref _sctyIstrmtNVTrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - OK Assumption Fee [Closing.SctyIstrmtOKAssmFeeAmt]
        /// </summary>
        public string? SctyIstrmtOKAssmFeeAmt { get => _sctyIstrmtOKAssmFeeAmt; set => SetField(ref _sctyIstrmtOKAssmFeeAmt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Lender P.O. Box Address  1 [Closing.SctyIstrmtPOBoxAddr1]
        /// </summary>
        public string? SctyIstrmtPOBoxAddr1 { get => _sctyIstrmtPOBoxAddr1; set => SetField(ref _sctyIstrmtPOBoxAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Lender P.O. Box Address  2 [Closing.SctyIstrmtPOBoxAddr2]
        /// </summary>
        public string? SctyIstrmtPOBoxAddr2 { get => _sctyIstrmtPOBoxAddr2; set => SetField(ref _sctyIstrmtPOBoxAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Additional Text [Closing.SctyIstrmtPrepByAdtlTxt]
        /// </summary>
        public string? SctyIstrmtPrepByAdtlTxt { get => _sctyIstrmtPrepByAdtlTxt; set => SetField(ref _sctyIstrmtPrepByAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Company Name [Closing.SctyIstrmtPrepByCoNm]
        /// </summary>
        public string? SctyIstrmtPrepByCoNm { get => _sctyIstrmtPrepByCoNm; set => SetField(ref _sctyIstrmtPrepByCoNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By City [Closing.SctyIstrmtPrepByCty]
        /// </summary>
        public string? SctyIstrmtPrepByCty { get => _sctyIstrmtPrepByCty; set => SetField(ref _sctyIstrmtPrepByCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Name [Closing.SctyIstrmtPrepByIndvNm]
        /// </summary>
        public string? SctyIstrmtPrepByIndvNm { get => _sctyIstrmtPrepByIndvNm; set => SetField(ref _sctyIstrmtPrepByIndvNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Title [Closing.SctyIstrmtPrepByIndvTtl]
        /// </summary>
        public string? SctyIstrmtPrepByIndvTtl { get => _sctyIstrmtPrepByIndvTtl; set => SetField(ref _sctyIstrmtPrepByIndvTtl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Telephone Number [Closing.SctyIstrmtPrepByPhone]
        /// </summary>
        public string? SctyIstrmtPrepByPhone { get => _sctyIstrmtPrepByPhone; set => SetField(ref _sctyIstrmtPrepByPhone, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Same as Another Party [Closing.SctyIstrmtPrepBySamePtyTypDesc]
        /// </summary>
        public StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc> SctyIstrmtPrepBySamePtyTypDesc { get => _sctyIstrmtPrepBySamePtyTypDesc; set => SetField(ref _sctyIstrmtPrepBySamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By State Code [Closing.SctyIstrmtPrepByStCd]
        /// </summary>
        public string? SctyIstrmtPrepByStCd { get => _sctyIstrmtPrepByStCd; set => SetField(ref _sctyIstrmtPrepByStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 1 [Closing.SctyIstrmtPrepByStreetAddr1]
        /// </summary>
        public string? SctyIstrmtPrepByStreetAddr1 { get => _sctyIstrmtPrepByStreetAddr1; set => SetField(ref _sctyIstrmtPrepByStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 2 [Closing.SctyIstrmtPrepByStreetAddr2]
        /// </summary>
        public string? SctyIstrmtPrepByStreetAddr2 { get => _sctyIstrmtPrepByStreetAddr2; set => SetField(ref _sctyIstrmtPrepByStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Sec. Instr. Prepared By Text [Closing.SctyIstrmtPrepByTxt]
        /// </summary>
        public string? SctyIstrmtPrepByTxt { get => _sctyIstrmtPrepByTxt; set => SetField(ref _sctyIstrmtPrepByTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Postal Code [Closing.SctyIstrmtPrepByZip]
        /// </summary>
        public string? SctyIstrmtPrepByZip { get => _sctyIstrmtPrepByZip; set => SetField(ref _sctyIstrmtPrepByZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Sec. Instr. Title Addl. Text [Closing.SctyIstrmtTtlAdtlTxt]
        /// </summary>
        public string? SctyIstrmtTtlAdtlTxt { get => _sctyIstrmtTtlAdtlTxt; set => SetField(ref _sctyIstrmtTtlAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Print Addl. Text Above Title [Closing.SctyIstrmtTtlAdtlTxtAbvTtl]
        /// </summary>
        public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get => _sctyIstrmtTtlAdtlTxtAbvTtl; set => SetField(ref _sctyIstrmtTtlAdtlTxtAbvTtl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - VA Trustee Fee [Closing.SctyIstrmtVATrstFeePct]
        /// </summary>
        public string? SctyIstrmtVATrstFeePct { get => _sctyIstrmtVATrstFeePct; set => SetField(ref _sctyIstrmtVATrstFeePct, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 County [Closing.Trst1Cnty]
        /// </summary>
        public string? Trst1Cnty { get => _trst1Cnty; set => SetField(ref _trst1Cnty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 City [Closing.Trst1Cty]
        /// </summary>
        public string? Trst1Cty { get => _trst1Cty; set => SetField(ref _trst1Cty, value); }

        /// <summary>
        /// EmDocument Trst1IndvBool
        /// </summary>
        public bool? Trst1IndvBool { get => _trst1IndvBool; set => SetField(ref _trst1IndvBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Jurisdiction [Closing.Trst1Jrsdctn]
        /// </summary>
        public string? Trst1Jrsdctn { get => _trst1Jrsdctn; set => SetField(ref _trst1Jrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Name [Closing.Trst1Nm]
        /// </summary>
        public string? Trst1Nm { get => _trst1Nm; set => SetField(ref _trst1Nm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Organization Type [Closing.Trst1OrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> Trst1OrgTyp { get => _trst1OrgTyp; set => SetField(ref _trst1OrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Phone Number [Closing.Trst1Phone]
        /// </summary>
        public string? Trst1Phone { get => _trst1Phone; set => SetField(ref _trst1Phone, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Is Resident Of Text Description [Closing.Trst1RsdtTxtDesc]
        /// </summary>
        public string? Trst1RsdtTxtDesc { get => _trst1RsdtTxtDesc; set => SetField(ref _trst1RsdtTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Same As Party Type Description [Closing.Trst1SamePtyTypDesc]
        /// </summary>
        public StringEnumValue<TrstSamePtyTypDesc> Trst1SamePtyTypDesc { get => _trst1SamePtyTypDesc; set => SetField(ref _trst1SamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 State Code [Closing.Trst1StCd]
        /// </summary>
        public string? Trst1StCd { get => _trst1StCd; set => SetField(ref _trst1StCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Street Address [Closing.Trst1StreetAddr1]
        /// </summary>
        public string? Trst1StreetAddr1 { get => _trst1StreetAddr1; set => SetField(ref _trst1StreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Street Address 2 [Closing.Trst1StreetAddr2]
        /// </summary>
        public string? Trst1StreetAddr2 { get => _trst1StreetAddr2; set => SetField(ref _trst1StreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Postal Code [Closing.Trst1Zip]
        /// </summary>
        public string? Trst1Zip { get => _trst1Zip; set => SetField(ref _trst1Zip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 County [Closing.Trst2Cnty]
        /// </summary>
        public string? Trst2Cnty { get => _trst2Cnty; set => SetField(ref _trst2Cnty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 City [Closing.Trst2Cty]
        /// </summary>
        public string? Trst2Cty { get => _trst2Cty; set => SetField(ref _trst2Cty, value); }

        /// <summary>
        /// EmDocument Trst2IndvBool
        /// </summary>
        public bool? Trst2IndvBool { get => _trst2IndvBool; set => SetField(ref _trst2IndvBool, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Jurisdiction [Closing.Trst2Jrsdctn]
        /// </summary>
        public string? Trst2Jrsdctn { get => _trst2Jrsdctn; set => SetField(ref _trst2Jrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Name [Closing.Trst2Nm]
        /// </summary>
        public string? Trst2Nm { get => _trst2Nm; set => SetField(ref _trst2Nm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Organization Type [Closing.Trst2OrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> Trst2OrgTyp { get => _trst2OrgTyp; set => SetField(ref _trst2OrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Phone Number [Closing.Trst2Phone]
        /// </summary>
        public string? Trst2Phone { get => _trst2Phone; set => SetField(ref _trst2Phone, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Is Resident Of Text Description [Closing.Trst2RsdtTxtDesc]
        /// </summary>
        public string? Trst2RsdtTxtDesc { get => _trst2RsdtTxtDesc; set => SetField(ref _trst2RsdtTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Same As Party Type Description [Closing.Trst2SamePtyTypDesc]
        /// </summary>
        public StringEnumValue<TrstSamePtyTypDesc> Trst2SamePtyTypDesc { get => _trst2SamePtyTypDesc; set => SetField(ref _trst2SamePtyTypDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 State Code [Closing.Trst2StCd]
        /// </summary>
        public string? Trst2StCd { get => _trst2StCd; set => SetField(ref _trst2StCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Street Address [Closing.Trst2StreetAddr1]
        /// </summary>
        public string? Trst2StreetAddr1 { get => _trst2StreetAddr1; set => SetField(ref _trst2StreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Street Address 2 [Closing.Trst2StreetAddr2]
        /// </summary>
        public string? Trst2StreetAddr2 { get => _trst2StreetAddr2; set => SetField(ref _trst2StreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Postal Code [Closing.Trst2Zip]
        /// </summary>
        public string? Trst2Zip { get => _trst2Zip; set => SetField(ref _trst2Zip, value); }
    }
}