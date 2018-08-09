using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocument
    /// </summary>
    public sealed partial class EmDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _allngToNtPayToJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Jurisdiction [Closing.AllngToNtPayToJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to Jurisdiction")]
        public string AllngToNtPayToJrsdctn { get => _allngToNtPayToJrsdctn; set => _allngToNtPayToJrsdctn = value; }
        private DirtyValue<string> _allngToNtPayToOrdNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to the Order of Name [Closing.AllngToNtPayToOrdNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to the Order of Name")]
        public string AllngToNtPayToOrdNm { get => _allngToNtPayToOrdNm; set => _allngToNtPayToOrdNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _allngToNtPayToOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Organization Type [Closing.AllngToNtPayToOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to Organization Type")]
        public StringEnumValue<OrgTyp> AllngToNtPayToOrgTyp { get => _allngToNtPayToOrgTyp; set => _allngToNtPayToOrgTyp = value; }
        private DirtyValue<string> _allngToNtPayToScsrsClaus;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Successor Clause  [Closing.AllngToNtPayToScsrsClaus]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to Successor Clause ")]
        public string AllngToNtPayToScsrsClaus { get => _allngToNtPayToScsrsClaus; set => _allngToNtPayToScsrsClaus = value; }
        private DirtyValue<string> _allngToNtSignedByNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Name [Closing.AllngToNtSignedByNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Name")]
        public string AllngToNtSignedByNm { get => _allngToNtSignedByNm; set => _allngToNtSignedByNm = value; }
        private DirtyValue<string> _allngToNtSignedByNm2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 2 [Closing.AllngToNtSignedByNm2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Signed By Name 2")]
        public string AllngToNtSignedByNm2 { get => _allngToNtSignedByNm2; set => _allngToNtSignedByNm2 = value; }
        private DirtyValue<string> _allngToNtSignedByNm3;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 3 [Closing.AllngToNtSignedByNm3]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Signed By Name 3")]
        public string AllngToNtSignedByNm3 { get => _allngToNtSignedByNm3; set => _allngToNtSignedByNm3 = value; }
        private DirtyValue<string> _allngToNtSignedByTtl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Title [Closing.AllngToNtSignedByTtl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Title")]
        public string AllngToNtSignedByTtl { get => _allngToNtSignedByTtl; set => _allngToNtSignedByTtl = value; }
        private DirtyValue<string> _allngToNtSignedByTtl2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 2 [Closing.AllngToNtSignedByTtl2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Signed By Title 2")]
        public string AllngToNtSignedByTtl2 { get => _allngToNtSignedByTtl2; set => _allngToNtSignedByTtl2 = value; }
        private DirtyValue<string> _allngToNtSignedByTtl3;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 3 [Closing.AllngToNtSignedByTtl3]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Signed By Title 3")]
        public string AllngToNtSignedByTtl3 { get => _allngToNtSignedByTtl3; set => _allngToNtSignedByTtl3 = value; }
        private DirtyValue<StringEnumValue<SignedByTyp>> _allngToNtSignedByTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Signed By Type [Closing.AllngToNtSignedByTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Signed By Type")]
        public StringEnumValue<SignedByTyp> AllngToNtSignedByTyp { get => _allngToNtSignedByTyp; set => _allngToNtSignedByTyp = value; }
        private DirtyValue<string> _allngToNtWithoutRcrse;
        /// <summary>
        /// Ellie Mae Closing Document Override - Allonge to Note Without Recourse Add'l Text [Closing.AllngToNtWithoutRcrse]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Allonge to Note Without Recourse Add'l Text")]
        public string AllngToNtWithoutRcrse { get => _allngToNtWithoutRcrse; set => _allngToNtWithoutRcrse = value; }
        private DirtyValue<string> _apnLbl;
        /// <summary>
        /// Ellie Mae Closing Document Override - APN # Label [Closing.ApnLbl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - APN # Label")]
        public string ApnLbl { get => _apnLbl; set => _apnLbl = value; }
        private DirtyValue<bool?> _asgnPrepByLblTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Assignment Prepared By Label Text [Closing.AsgnPrepByLblTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Assignment Prepared By Label Text")]
        public bool? AsgnPrepByLblTxtDesc { get => _asgnPrepByLblTxtDesc; set => _asgnPrepByLblTxtDesc = value; }
        private DirtyValue<bool?> _asgnRecRtrnLblTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Assignment Rec. and Return Label Text [Closing.AsgnRecRtrnLblTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Assignment Rec. and Return Label Text")]
        public bool? AsgnRecRtrnLblTxtDesc { get => _asgnRecRtrnLblTxtDesc; set => _asgnRecRtrnLblTxtDesc = value; }
        private DirtyValue<string> _benCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary City [Closing.BenCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary City")]
        public string BenCty { get => _benCty; set => _benCty = value; }
        private DirtyValue<string> _benJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Jurisdiction [Closing.BenJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Jurisdiction")]
        public string BenJrsdctn { get => _benJrsdctn; set => _benJrsdctn = value; }
        private DirtyValue<string> _benNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Name [Closing.BenNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Name")]
        public string BenNm { get => _benNm; set => _benNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _benOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Organization Type [Closing.BenOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Organization Type")]
        public StringEnumValue<OrgTyp> BenOrgTyp { get => _benOrgTyp; set => _benOrgTyp = value; }
        private DirtyValue<string> _benStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary State Code [Closing.BenStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary State Code")]
        public string BenStCd { get => _benStCd; set => _benStCd = value; }
        private DirtyValue<string> _benStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Street Address [Closing.BenStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Street Address")]
        public string BenStreetAddr1 { get => _benStreetAddr1; set => _benStreetAddr1 = value; }
        private DirtyValue<string> _benStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Street Address 2 [Closing.BenStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Street Address 2")]
        public string BenStreetAddr2 { get => _benStreetAddr2; set => _benStreetAddr2 = value; }
        private DirtyValue<string> _benZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Beneficiary Postal Code [Closing.BenZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Beneficiary Postal Code")]
        public string BenZip { get => _benZip; set => _benZip = value; }
        private DirtyValue<string> _closInstrLndCntcInfoCity;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact City [Closing.ClosInstrLndCntcInfoCity]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact City")]
        public string ClosInstrLndCntcInfoCity { get => _closInstrLndCntcInfoCity; set => _closInstrLndCntcInfoCity = value; }
        private DirtyValue<string> _closInstrLndCntcInfoCoNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Company Name [Closing.ClosInstrLndCntcInfoCoNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact Company Name")]
        public string ClosInstrLndCntcInfoCoNm { get => _closInstrLndCntcInfoCoNm; set => _closInstrLndCntcInfoCoNm = value; }
        private DirtyValue<StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc>> _closInstrLndCntcInfoSamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact-Same as Another Party [Closing.ClosInstrLndCntcInfoSamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact-Same as Another Party")]
        public StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc> ClosInstrLndCntcInfoSamePtyTypDesc { get => _closInstrLndCntcInfoSamePtyTypDesc; set => _closInstrLndCntcInfoSamePtyTypDesc = value; }
        private DirtyValue<string> _closInstrLndCntcInfoStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact State Code [Closing.ClosInstrLndCntcInfoStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact State Code")]
        public string ClosInstrLndCntcInfoStCd { get => _closInstrLndCntcInfoStCd; set => _closInstrLndCntcInfoStCd = value; }
        private DirtyValue<string> _closInstrLndCntcInfoStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 1 [Closing.ClosInstrLndCntcInfoStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact Address 1")]
        public string ClosInstrLndCntcInfoStreetAddr1 { get => _closInstrLndCntcInfoStreetAddr1; set => _closInstrLndCntcInfoStreetAddr1 = value; }
        private DirtyValue<string> _closInstrLndCntcInfoStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 2 [Closing.ClosInstrLndCntcInfoStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact Address 2")]
        public string ClosInstrLndCntcInfoStreetAddr2 { get => _closInstrLndCntcInfoStreetAddr2; set => _closInstrLndCntcInfoStreetAddr2 = value; }
        private DirtyValue<string> _closInstrLndCntcInfoZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Contact Zip Code [Closing.ClosInstrLndCntcInfoZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Contact Zip Code")]
        public string ClosInstrLndCntcInfoZip { get => _closInstrLndCntcInfoZip; set => _closInstrLndCntcInfoZip = value; }
        private DirtyValue<bool?> _closInstrPrtInvLossPayee;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Print Investor Loss Payee [Closing.ClosInstrPrtInvLossPayee]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Print Investor Loss Payee")]
        public bool? ClosInstrPrtInvLossPayee { get => _closInstrPrtInvLossPayee; set => _closInstrPrtInvLossPayee = value; }
        private DirtyValue<bool?> _closInstrStlmtAgtUseLndHud1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Settlement Agent to use Lender HUD-1 [Closing.ClosInstrStlmtAgtUseLndHud1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Settlement Agent to use Lender HUD-1")]
        public bool? ClosInstrStlmtAgtUseLndHud1 { get => _closInstrStlmtAgtUseLndHud1; set => _closInstrStlmtAgtUseLndHud1 = value; }
        private DirtyValue<StringEnumValue<ClosInstrTtlPlcyTyp>> _closInstrTtlPlcyTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Closing Instructions Title Policy Type [Closing.ClosInstrTtlPlcyTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Closing Instructions Title Policy Type")]
        public StringEnumValue<ClosInstrTtlPlcyTyp> ClosInstrTtlPlcyTyp { get => _closInstrTtlPlcyTyp; set => _closInstrTtlPlcyTyp = value; }
        private DirtyValue<string> _emxmlVersionId;
        /// <summary>
        /// EmDocument EmxmlVersionId
        /// </summary>
        public string EmxmlVersionId { get => _emxmlVersionId; set => _emxmlVersionId = value; }
        private DirtyValue<string> _exeClosDocDlvrdToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To city [Closing.ExeClosDocDlvrdToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To city")]
        public string ExeClosDocDlvrdToCty { get => _exeClosDocDlvrdToCty; set => _exeClosDocDlvrdToCty = value; }
        private DirtyValue<string> _exeClosDocDlvrdToMiscTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Miscellaneous Text Description  [Closing.ExeClosDocDlvrdToMiscTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Miscellaneous Text Description ")]
        public string ExeClosDocDlvrdToMiscTxtDesc { get => _exeClosDocDlvrdToMiscTxtDesc; set => _exeClosDocDlvrdToMiscTxtDesc = value; }
        private DirtyValue<string> _exeClosDocDlvrdToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Name [Closing.ExeClosDocDlvrdToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Name")]
        public string ExeClosDocDlvrdToNm { get => _exeClosDocDlvrdToNm; set => _exeClosDocDlvrdToNm = value; }
        private DirtyValue<StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc>> _exeClosDocDlvrdToSamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Docs to be Delivered to the same party as [Closing.ExeClosDocDlvrdToSamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Docs to be Delivered to the same party as")]
        public StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc> ExeClosDocDlvrdToSamePtyTypDesc { get => _exeClosDocDlvrdToSamePtyTypDesc; set => _exeClosDocDlvrdToSamePtyTypDesc = value; }
        private DirtyValue<string> _exeClosDocDlvrdToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To state [Closing.ExeClosDocDlvrdToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To state")]
        public string ExeClosDocDlvrdToStCd { get => _exeClosDocDlvrdToStCd; set => _exeClosDocDlvrdToStCd = value; }
        private DirtyValue<string> _exeClosDocDlvrdToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address [Closing.ExeClosDocDlvrdToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address")]
        public string ExeClosDocDlvrdToStreetAddr1 { get => _exeClosDocDlvrdToStreetAddr1; set => _exeClosDocDlvrdToStreetAddr1 = value; }
        private DirtyValue<string> _exeClosDocDlvrdToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address 2 [Closing.ExeClosDocDlvrdToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address 2")]
        public string ExeClosDocDlvrdToStreetAddr2 { get => _exeClosDocDlvrdToStreetAddr2; set => _exeClosDocDlvrdToStreetAddr2 = value; }
        private DirtyValue<string> _exeClosDocDlvrdToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Zip [Closing.ExeClosDocDlvrdToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Zip")]
        public string ExeClosDocDlvrdToZip { get => _exeClosDocDlvrdToZip; set => _exeClosDocDlvrdToZip = value; }
        private DirtyValue<StringEnumValue<ExeClosDocExprDt>> _exeClosDocExprDt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents Expiration Date [Closing.ExeClosDocExprDt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents Expiration Date")]
        public StringEnumValue<ExeClosDocExprDt> ExeClosDocExprDt { get => _exeClosDocExprDt; set => _exeClosDocExprDt = value; }
        private DirtyValue<StringEnumValue<ExeClosDocToBeRtrnd>> _exeClosDocToBeRtrnd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned [Closing.ExeClosDocToBeRtrnd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents to be Returned")]
        public StringEnumValue<ExeClosDocToBeRtrnd> ExeClosDocToBeRtrnd { get => _exeClosDocToBeRtrnd; set => _exeClosDocToBeRtrnd = value; }
        private DirtyValue<StringEnumValue<ExeClosDocToBeRtrndHrs>> _exeClosDocToBeRtrndHrs;
        /// <summary>
        /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned Hours [Closing.ExeClosDocToBeRtrndHrs]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Executed Closing Documents to be Returned Hours")]
        public StringEnumValue<ExeClosDocToBeRtrndHrs> ExeClosDocToBeRtrndHrs { get => _exeClosDocToBeRtrndHrs; set => _exeClosDocToBeRtrndHrs = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToAddlLine1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Addition line 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Addition line 1 of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToAddlLine1 { get => _fnlTtlePcyRecDocsSentToAddlLine1; set => _fnlTtlePcyRecDocsSentToAddlLine1 = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToAddlLine2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Addition line 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Addition line 2 of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToAddlLine2 { get => _fnlTtlePcyRecDocsSentToAddlLine2; set => _fnlTtlePcyRecDocsSentToAddlLine2 = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - city of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - city of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToCty { get => _fnlTtlePcyRecDocsSentToCty; set => _fnlTtlePcyRecDocsSentToCty = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Company Name of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Company Name of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToNm { get => _fnlTtlePcyRecDocsSentToNm; set => _fnlTtlePcyRecDocsSentToNm = value; }
        private DirtyValue<StringEnumValue<RecSamePtyTypeDesc>> _fnlTtlePcyRecDocsSentToSamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Final Title Policy and Recorded Docs to be sent to the same party as  [Closing.FnlTtlePcyRecDocsSentToSamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Final Title Policy and Recorded Docs to be sent to the same party as ")]
        public StringEnumValue<RecSamePtyTypeDesc> FnlTtlePcyRecDocsSentToSamePtyTypDesc { get => _fnlTtlePcyRecDocsSentToSamePtyTypDesc; set => _fnlTtlePcyRecDocsSentToSamePtyTypDesc = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStcd;
        /// <summary>
        /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStcd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToStcd { get => _fnlTtlePcyRecDocsSentToStcd; set => _fnlTtlePcyRecDocsSentToStcd = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - address 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - address 1 of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToStreetAddr1 { get => _fnlTtlePcyRecDocsSentToStreetAddr1; set => _fnlTtlePcyRecDocsSentToStreetAddr1 = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - address 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - address 2 of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToStreetAddr2 { get => _fnlTtlePcyRecDocsSentToStreetAddr2; set => _fnlTtlePcyRecDocsSentToStreetAddr2 = value; }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to ")]
        public string FnlTtlePcyRecDocsSentToZip { get => _fnlTtlePcyRecDocsSentToZip; set => _fnlTtlePcyRecDocsSentToZip = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Additional Text [Closing.HazInsurEndsmtMailToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Additional Text")]
        public string HazInsurEndsmtMailToAdtlTxt { get => _hazInsurEndsmtMailToAdtlTxt; set => _hazInsurEndsmtMailToAdtlTxt = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To City [Closing.HazInsurEndsmtMailToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To City")]
        public string HazInsurEndsmtMailToCty { get => _hazInsurEndsmtMailToCty; set => _hazInsurEndsmtMailToCty = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Name [Closing.HazInsurEndsmtMailToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Name")]
        public string HazInsurEndsmtMailToNm { get => _hazInsurEndsmtMailToNm; set => _hazInsurEndsmtMailToNm = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To State Code [Closing.HazInsurEndsmtMailToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To State Code")]
        public string HazInsurEndsmtMailToStCd { get => _hazInsurEndsmtMailToStCd; set => _hazInsurEndsmtMailToStCd = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address [Closing.HazInsurEndsmtMailToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address")]
        public string HazInsurEndsmtMailToStreetAddr1 { get => _hazInsurEndsmtMailToStreetAddr1; set => _hazInsurEndsmtMailToStreetAddr1 = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address 2 [Closing.HazInsurEndsmtMailToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address 2")]
        public string HazInsurEndsmtMailToStreetAddr2 { get => _hazInsurEndsmtMailToStreetAddr2; set => _hazInsurEndsmtMailToStreetAddr2 = value; }
        private DirtyValue<string> _hazInsurEndsmtMailToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Postal Code [Closing.HazInsurEndsmtMailToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Postal Code")]
        public string HazInsurEndsmtMailToZip { get => _hazInsurEndsmtMailToZip; set => _hazInsurEndsmtMailToZip = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// EmDocument Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _mersAdtlCity;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional City [Closing.MersAdtlCity]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Additional City")]
        public string MersAdtlCity { get => _mersAdtlCity; set => _mersAdtlCity = value; }
        private DirtyValue<string> _mersAdtlStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional State Code [Closing.MersAdtlStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Additional State Code")]
        public string MersAdtlStCd { get => _mersAdtlStCd; set => _mersAdtlStCd = value; }
        private DirtyValue<string> _mersAdtlStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Street Address line 1 [Closing.MersAdtlStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Additional Street Address line 1")]
        public string MersAdtlStreetAddr1 { get => _mersAdtlStreetAddr1; set => _mersAdtlStreetAddr1 = value; }
        private DirtyValue<string> _mersAdtlStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Street Address line 2 [Closing.MersAdtlStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Additional Street Address line 2")]
        public string MersAdtlStreetAddr2 { get => _mersAdtlStreetAddr2; set => _mersAdtlStreetAddr2 = value; }
        private DirtyValue<string> _mersAdtlZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Additional Postal Code [Closing.MersAdtlZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Additional Postal Code")]
        public string MersAdtlZip { get => _mersAdtlZip; set => _mersAdtlZip = value; }
        private DirtyValue<string> _mersCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS City [Closing.MersCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS City")]
        public string MersCty { get => _mersCty; set => _mersCty = value; }
        private DirtyValue<string> _mersJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Jurisdiction [Closing.MersJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Jurisdiction")]
        public string MersJrsdctn { get => _mersJrsdctn; set => _mersJrsdctn = value; }
        private DirtyValue<string> _mersName;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Name [Closing.MersName]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Name")]
        public string MersName { get => _mersName; set => _mersName = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _mersOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Organization Type [Closing.MersOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Organization Type")]
        public StringEnumValue<OrgTyp> MersOrgTyp { get => _mersOrgTyp; set => _mersOrgTyp = value; }
        private DirtyValue<string> _mersPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Telephone No. [Closing.MersPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Telephone No.")]
        public string MersPhoneNum { get => _mersPhoneNum; set => _mersPhoneNum = value; }
        private DirtyValue<string> _mersStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS State Code [Closing.MersStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS State Code")]
        public string MersStCd { get => _mersStCd; set => _mersStCd = value; }
        private DirtyValue<string> _mersStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Street Address [Closing.MersStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Street Address")]
        public string MersStreetAddr1 { get => _mersStreetAddr1; set => _mersStreetAddr1 = value; }
        private DirtyValue<string> _mersStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Street Address 2 [Closing.MersStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Street Address 2")]
        public string MersStreetAddr2 { get => _mersStreetAddr2; set => _mersStreetAddr2 = value; }
        private DirtyValue<string> _mersZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - MERS Postal Code [Closing.MersZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MERS Postal Code")]
        public string MersZip { get => _mersZip; set => _mersZip = value; }
        private DirtyValue<string> _ntEndrsmtPayToJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Jurisdiction [Closing.NtEndrsmtPayToJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Pay To Jurisdiction")]
        public string NtEndrsmtPayToJrsdctn { get => _ntEndrsmtPayToJrsdctn; set => _ntEndrsmtPayToJrsdctn = value; }
        private DirtyValue<string> _ntEndrsmtPayToOrdNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay to the Order of Name [Closing.NtEndrsmtPayToOrdNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Pay to the Order of Name")]
        public string NtEndrsmtPayToOrdNm { get => _ntEndrsmtPayToOrdNm; set => _ntEndrsmtPayToOrdNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _ntEndrsmtPayToOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Organization Type [Closing.NtEndrsmtPayToOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Pay To Organization Type")]
        public StringEnumValue<OrgTyp> NtEndrsmtPayToOrgTyp { get => _ntEndrsmtPayToOrgTyp; set => _ntEndrsmtPayToOrgTyp = value; }
        private DirtyValue<string> _ntEndrsmtPayToScsrsClaus;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Pay To Successor Clause [Closing.NtEndrsmtPayToScsrsClaus]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Pay To Successor Clause")]
        public string NtEndrsmtPayToScsrsClaus { get => _ntEndrsmtPayToScsrsClaus; set => _ntEndrsmtPayToScsrsClaus = value; }
        private DirtyValue<string> _ntEndrsmtSgndBy1MiscTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed Additional text [Closing.NtEndrsmtSgndBy1MiscTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed Additional text")]
        public string NtEndrsmtSgndBy1MiscTxt { get => _ntEndrsmtSgndBy1MiscTxt; set => _ntEndrsmtSgndBy1MiscTxt = value; }
        private DirtyValue<string> _ntEndrsmtSgndBy2MiscTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 additional text [Closing.NtEndrsmtSgndBy2MiscTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 additional text")]
        public string NtEndrsmtSgndBy2MiscTxt { get => _ntEndrsmtSgndBy2MiscTxt; set => _ntEndrsmtSgndBy2MiscTxt = value; }
        private DirtyValue<string> _ntEndrsmtSignedByNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsment Signed By Name [Closing.NtEndrsmtSignedByNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsment Signed By Name")]
        public string NtEndrsmtSignedByNm { get => _ntEndrsmtSignedByNm; set => _ntEndrsmtSignedByNm = value; }
        private DirtyValue<string> _ntEndrsmtSignedByNm2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 2 [Closing.NtEndrsmtSignedByNm2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Name 2")]
        public string NtEndrsmtSignedByNm2 { get => _ntEndrsmtSignedByNm2; set => _ntEndrsmtSignedByNm2 = value; }
        private DirtyValue<string> _ntEndrsmtSignedByNm3;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 3 [Closing.NtEndrsmtSignedByNm3]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Name 3")]
        public string NtEndrsmtSignedByNm3 { get => _ntEndrsmtSignedByNm3; set => _ntEndrsmtSignedByNm3 = value; }
        private DirtyValue<string> _ntEndrsmtSignedByTtl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title [Closing.NtEndrsmtSignedByTtl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Title")]
        public string NtEndrsmtSignedByTtl { get => _ntEndrsmtSignedByTtl; set => _ntEndrsmtSignedByTtl = value; }
        private DirtyValue<string> _ntEndrsmtSignedByTtl2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 [Closing.NtEndrsmtSignedByTtl2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2")]
        public string NtEndrsmtSignedByTtl2 { get => _ntEndrsmtSignedByTtl2; set => _ntEndrsmtSignedByTtl2 = value; }
        private DirtyValue<string> _ntEndrsmtSignedByTtl3;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 3 [Closing.NtEndrsmtSignedByTtl3]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Title 3")]
        public string NtEndrsmtSignedByTtl3 { get => _ntEndrsmtSignedByTtl3; set => _ntEndrsmtSignedByTtl3 = value; }
        private DirtyValue<StringEnumValue<SignedByTyp>> _ntEndrsmtSignedByTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Signed By Type [Closing.NtEndrsmtSignedByTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Signed By Type")]
        public StringEnumValue<SignedByTyp> NtEndrsmtSignedByTyp { get => _ntEndrsmtSignedByTyp; set => _ntEndrsmtSignedByTyp = value; }
        private DirtyValue<string> _ntEndrsmtWithoutRcrse;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Endorsement Without Recourse Add'l Text [Closing.NtEndrsmtWithoutRcrse]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Endorsement Without Recourse Add'l Text")]
        public string NtEndrsmtWithoutRcrse { get => _ntEndrsmtWithoutRcrse; set => _ntEndrsmtWithoutRcrse = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 1 [Closing.NtEndsmtThrdPtyAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 1")]
        public string NtEndsmtThrdPtyAddr1 { get => _ntEndsmtThrdPtyAddr1; set => _ntEndsmtThrdPtyAddr1 = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 2 [Closing.NtEndsmtThrdPtyAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 2")]
        public string NtEndsmtThrdPtyAddr2 { get => _ntEndsmtThrdPtyAddr2; set => _ntEndsmtThrdPtyAddr2 = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party City [Closing.NtEndsmtThrdPtyCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party City")]
        public string NtEndsmtThrdPtyCty { get => _ntEndsmtThrdPtyCty; set => _ntEndsmtThrdPtyCty = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Jurisdiction [Closing.NtEndsmtThrdPtyJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Jurisdiction")]
        public string NtEndsmtThrdPtyJrsdctn { get => _ntEndsmtThrdPtyJrsdctn; set => _ntEndsmtThrdPtyJrsdctn = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyName;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Name [Closing.NtEndsmtThrdPtyName]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Name")]
        public string NtEndsmtThrdPtyName { get => _ntEndsmtThrdPtyName; set => _ntEndsmtThrdPtyName = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _ntEndsmtThrdPtyOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Org Type [Closing.NtEndsmtThrdPtyOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Org Type")]
        public StringEnumValue<OrgTyp> NtEndsmtThrdPtyOrgTyp { get => _ntEndsmtThrdPtyOrgTyp; set => _ntEndsmtThrdPtyOrgTyp = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Phone [Closing.NtEndsmtThrdPtyPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Phone")]
        public string NtEndsmtThrdPtyPhone { get => _ntEndsmtThrdPtyPhone; set => _ntEndsmtThrdPtyPhone = value; }
        private DirtyValue<StringEnumValue<ScsrsClaus>> _ntEndsmtThrdPtyScsrClaus;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Successor Clause [Closing.NtEndsmtThrdPtyScsrClaus]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Successor Clause")]
        public StringEnumValue<ScsrsClaus> NtEndsmtThrdPtyScsrClaus { get => _ntEndsmtThrdPtyScsrClaus; set => _ntEndsmtThrdPtyScsrClaus = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party State [Closing.NtEndsmtThrdPtyStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party State")]
        public string NtEndsmtThrdPtyStCd { get => _ntEndsmtThrdPtyStCd; set => _ntEndsmtThrdPtyStCd = value; }
        private DirtyValue<string> _ntEndsmtThrdPtyZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Zip [Closing.NtEndsmtThrdPtyZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - 4506/4506-T Third Party Zip")]
        public string NtEndsmtThrdPtyZip { get => _ntEndsmtThrdPtyZip; set => _ntEndsmtThrdPtyZip = value; }
        private DirtyValue<string> _ntPayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Additional Text [Closing.NtPayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Additional Text")]
        public string NtPayToAdtlTxt { get => _ntPayToAdtlTxt; set => _ntPayToAdtlTxt = value; }
        private DirtyValue<string> _ntPayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To City [Closing.NtPayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To City")]
        public string NtPayToCty { get => _ntPayToCty; set => _ntPayToCty = value; }
        private DirtyValue<string> _ntPayToJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Jurisdiction [Closing.NtPayToJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Jurisdiction")]
        public string NtPayToJrsdctn { get => _ntPayToJrsdctn; set => _ntPayToJrsdctn = value; }
        private DirtyValue<string> _ntPayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Name [Closing.NtPayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Name")]
        public string NtPayToNm { get => _ntPayToNm; set => _ntPayToNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _ntPayToOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Organization Type [Closing.NtPayToOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Organization Type")]
        public StringEnumValue<OrgTyp> NtPayToOrgTyp { get => _ntPayToOrgTyp; set => _ntPayToOrgTyp = value; }
        private DirtyValue<string> _ntPayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To State Code [Closing.NtPayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To State Code")]
        public string NtPayToStCd { get => _ntPayToStCd; set => _ntPayToStCd = value; }
        private DirtyValue<string> _ntPayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Street Address [Closing.NtPayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Street Address")]
        public string NtPayToStreetAddr1 { get => _ntPayToStreetAddr1; set => _ntPayToStreetAddr1 = value; }
        private DirtyValue<string> _ntPayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Street Address 2 [Closing.NtPayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Street Address 2")]
        public string NtPayToStreetAddr2 { get => _ntPayToStreetAddr2; set => _ntPayToStreetAddr2 = value; }
        private DirtyValue<string> _ntPayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Note Pay To Postal Code [Closing.NtPayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Note Pay To Postal Code")]
        public string NtPayToZip { get => _ntPayToZip; set => _ntPayToZip = value; }
        private DirtyValue<string> _pmtCpn2PayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text Description  [Closing.PmtCpn2PayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text Description ")]
        public string PmtCpn2PayToAdtlTxt { get => _pmtCpn2PayToAdtlTxt; set => _pmtCpn2PayToAdtlTxt = value; }
        private DirtyValue<string> _pmtCpn2PayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text 2 Description [Closing.PmtCpn2PayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text 2 Description")]
        public string PmtCpn2PayToAdtlTxt2 { get => _pmtCpn2PayToAdtlTxt2; set => _pmtCpn2PayToAdtlTxt2 = value; }
        private DirtyValue<string> _pmtCpn2PayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To City [Closing.PmtCpn2PayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To City")]
        public string PmtCpn2PayToCty { get => _pmtCpn2PayToCty; set => _pmtCpn2PayToCty = value; }
        private DirtyValue<string> _pmtCpn2PayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Name [Closing.PmtCpn2PayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Name")]
        public string PmtCpn2PayToNm { get => _pmtCpn2PayToNm; set => _pmtCpn2PayToNm = value; }
        private DirtyValue<string> _pmtCpn2PayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To State Code [Closing.PmtCpn2PayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To State Code")]
        public string PmtCpn2PayToStCd { get => _pmtCpn2PayToStCd; set => _pmtCpn2PayToStCd = value; }
        private DirtyValue<string> _pmtCpn2PayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address [Closing.PmtCpn2PayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address")]
        public string PmtCpn2PayToStreetAddr1 { get => _pmtCpn2PayToStreetAddr1; set => _pmtCpn2PayToStreetAddr1 = value; }
        private DirtyValue<string> _pmtCpn2PayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address 2 [Closing.PmtCpn2PayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address 2")]
        public string PmtCpn2PayToStreetAddr2 { get => _pmtCpn2PayToStreetAddr2; set => _pmtCpn2PayToStreetAddr2 = value; }
        private DirtyValue<string> _pmtCpn2PayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Postal Code [Closing.PmtCpn2PayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Postal Code")]
        public string PmtCpn2PayToZip { get => _pmtCpn2PayToZip; set => _pmtCpn2PayToZip = value; }
        private DirtyValue<string> _pmtCpnPayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 1 [Closing.PmtCpnPayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 1")]
        public string PmtCpnPayToAdtlTxt { get => _pmtCpnPayToAdtlTxt; set => _pmtCpnPayToAdtlTxt = value; }
        private DirtyValue<string> _pmtCpnPayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 2 [Closing.PmtCpnPayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 2")]
        public string PmtCpnPayToAdtlTxt2 { get => _pmtCpnPayToAdtlTxt2; set => _pmtCpnPayToAdtlTxt2 = value; }
        private DirtyValue<string> _pmtCpnPayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To City [Closing.PmtCpnPayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To City")]
        public string PmtCpnPayToCty { get => _pmtCpnPayToCty; set => _pmtCpnPayToCty = value; }
        private DirtyValue<string> _pmtCpnPayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Name [Closing.PmtCpnPayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Name")]
        public string PmtCpnPayToNm { get => _pmtCpnPayToNm; set => _pmtCpnPayToNm = value; }
        private DirtyValue<string> _pmtCpnPayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To State Code [Closing.PmtCpnPayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To State Code")]
        public string PmtCpnPayToStCd { get => _pmtCpnPayToStCd; set => _pmtCpnPayToStCd = value; }
        private DirtyValue<string> _pmtCpnPayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address [Closing.PmtCpnPayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address")]
        public string PmtCpnPayToStreetAddr1 { get => _pmtCpnPayToStreetAddr1; set => _pmtCpnPayToStreetAddr1 = value; }
        private DirtyValue<string> _pmtCpnPayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address 2 [Closing.PmtCpnPayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address 2")]
        public string PmtCpnPayToStreetAddr2 { get => _pmtCpnPayToStreetAddr2; set => _pmtCpnPayToStreetAddr2 = value; }
        private DirtyValue<string> _pmtCpnPayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Postal Code [Closing.PmtCpnPayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Postal Code")]
        public string PmtCpnPayToZip { get => _pmtCpnPayToZip; set => _pmtCpnPayToZip = value; }
        private DirtyValue<StringEnumValue<PrtAdtlDateHud1>> _prtAdtlDateHud1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Additional Settlement Date on HUD1 [Closing.PrtAdtlDateHud1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Additional Settlement Date on HUD1")]
        public StringEnumValue<PrtAdtlDateHud1> PrtAdtlDateHud1 { get => _prtAdtlDateHud1; set => _prtAdtlDateHud1 = value; }
        private DirtyValue<bool?> _prtAllngToNtBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Allonge to Note [Closing.PrtAllngToNtBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Allonge to Note")]
        public bool? PrtAllngToNtBool { get => _prtAllngToNtBool; set => _prtAllngToNtBool = value; }
        private DirtyValue<bool?> _prtCorpMsgAsgnBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Assignment Corp. Message [Closing.PrtCorpMsgAsgnBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Assignment Corp. Message")]
        public bool? PrtCorpMsgAsgnBool { get => _prtCorpMsgAsgnBool; set => _prtCorpMsgAsgnBool = value; }
        private DirtyValue<StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt>> _prtDocDtSctyIstrmtNtryAprncDt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Document Data as Security Instrument Notary Appearance Date Indicator [Closing.PrtDocDtSctyIstrmtNtryAprncDt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Document Data as Security Instrument Notary Appearance Date Indicator")]
        public StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt> PrtDocDtSctyIstrmtNtryAprncDt { get => _prtDocDtSctyIstrmtNtryAprncDt; set => _prtDocDtSctyIstrmtNtryAprncDt = value; }
        private DirtyValue<bool?> _prtIndxTilBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Index on TIL [Closing.PrtIndxTilBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Index on TIL")]
        public bool? PrtIndxTilBool { get => _prtIndxTilBool; set => _prtIndxTilBool = value; }
        private DirtyValue<bool?> _prtInitBlckNtBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Borrower Initial Line on Note Indicator [Closing.PrtInitBlckNtBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Borrower Initial Line on Note Indicator")]
        public bool? PrtInitBlckNtBool { get => _prtInitBlckNtBool; set => _prtInitBlckNtBool = value; }
        private DirtyValue<bool?> _prtInitBlckSctyIstrmtBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Initial Line on Sec. Instr. [Closing.PrtInitBlckSctyIstrmtBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Initial Line on Sec. Instr.")]
        public bool? PrtInitBlckSctyIstrmtBool { get => _prtInitBlckSctyIstrmtBool; set => _prtInitBlckSctyIstrmtBool = value; }
        private DirtyValue<bool?> _prtInvLoanNumBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number Indicator [Closing.PrtInvLoanNumBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Investor Loan Number Indicator")]
        public bool? PrtInvLoanNumBool { get => _prtInvLoanNumBool; set => _prtInvLoanNumBool = value; }
        private DirtyValue<bool?> _prtInvLoanNumPmtCpn2Ind;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 2 Indicator [Closing.PrtInvLoanNumPmtCpn2Ind]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 2 Indicator")]
        public bool? PrtInvLoanNumPmtCpn2Ind { get => _prtInvLoanNumPmtCpn2Ind; set => _prtInvLoanNumPmtCpn2Ind = value; }
        private DirtyValue<bool?> _prtInvLoanNumPmtCpnInd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 1 Indicator [Closing.PrtInvLoanNumPmtCpnInd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 1 Indicator")]
        public bool? PrtInvLoanNumPmtCpnInd { get => _prtInvLoanNumPmtCpnInd; set => _prtInvLoanNumPmtCpnInd = value; }
        private DirtyValue<bool?> _prtInvLossPayeeHazInsurDisBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Investor Loss Payee on Hazard Insurance Disclosure [Closing.PrtInvLossPayeeHazInsurDisBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Investor Loss Payee on Hazard Insurance Disclosure")]
        public bool? PrtInvLossPayeeHazInsurDisBool { get => _prtInvLossPayeeHazInsurDisBool; set => _prtInvLossPayeeHazInsurDisBool = value; }
        private DirtyValue<bool?> _prtLoanNumDeedBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Loan No. On Sec. Instr. [Closing.PrtLoanNumDeedBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Loan No. On Sec. Instr.")]
        public bool? PrtLoanNumDeedBool { get => _prtLoanNumDeedBool; set => _prtLoanNumDeedBool = value; }
        private DirtyValue<bool?> _prtNtEndsmtBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Note Endorsement [Closing.PrtNtEndsmtBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Note Endorsement")]
        public bool? PrtNtEndsmtBool { get => _prtNtEndsmtBool; set => _prtNtEndsmtBool = value; }
        private DirtyValue<bool?> _prtNtPayToCorpMsgBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Note Pay To Corp. Message [Closing.PrtNtPayToCorpMsgBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Note Pay To Corp. Message")]
        public bool? PrtNtPayToCorpMsgBool { get => _prtNtPayToCorpMsgBool; set => _prtNtPayToCorpMsgBool = value; }
        private DirtyValue<bool?> _prtScsrsClausClosInstBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text on Closing Instructions [Closing.PrtScsrsClausClosInstBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Successors Clause Text on Closing Instructions")]
        public bool? PrtScsrsClausClosInstBool { get => _prtScsrsClausClosInstBool; set => _prtScsrsClausClosInstBool = value; }
        private DirtyValue<bool?> _prtScsrsClausHazInsurDisBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause on Hazard Insurance Disclosure [Closing.PrtScsrsClausHazInsurDisBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Successors Clause on Hazard Insurance Disclosure")]
        public bool? PrtScsrsClausHazInsurDisBool { get => _prtScsrsClausHazInsurDisBool; set => _prtScsrsClausHazInsurDisBool = value; }
        private DirtyValue<bool?> _prtScsrsClausHazInsurLtrBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text Hazard Endorse. Letter [Closing.PrtScsrsClausHazInsurLtrBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Successors Clause Text Hazard Endorse. Letter")]
        public bool? PrtScsrsClausHazInsurLtrBool { get => _prtScsrsClausHazInsurLtrBool; set => _prtScsrsClausHazInsurLtrBool = value; }
        private DirtyValue<bool?> _prtScsrsClausPmtCpnBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Successors Clause Text on Payment Coupon [Closing.PrtScsrsClausPmtCpnBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Successors Clause Text on Payment Coupon")]
        public bool? PrtScsrsClausPmtCpnBool { get => _prtScsrsClausPmtCpnBool; set => _prtScsrsClausPmtCpnBool = value; }
        private DirtyValue<bool?> _prtSctyIstrmtCorpMsgBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Sec. Instr. Corp. Message [Closing.PrtSctyIstrmtCorpMsgBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Sec. Instr. Corp. Message")]
        public bool? PrtSctyIstrmtCorpMsgBool { get => _prtSctyIstrmtCorpMsgBool; set => _prtSctyIstrmtCorpMsgBool = value; }
        private DirtyValue<string> _recRtrnAttnLnNmTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Attention Line Name or Text Description [Closing.RecRtrnAttnLnNmTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Attention Line Name or Text Description")]
        public string RecRtrnAttnLnNmTxtDesc { get => _recRtrnAttnLnNmTxtDesc; set => _recRtrnAttnLnNmTxtDesc = value; }
        private DirtyValue<string> _recRtrnCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return City [Closing.RecRtrnCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return City")]
        public string RecRtrnCty { get => _recRtrnCty; set => _recRtrnCty = value; }
        private DirtyValue<string> _recRtrnLblTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Label Text Description [Closing.RecRtrnLblTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Label Text Description")]
        public string RecRtrnLblTxtDesc { get => _recRtrnLblTxtDesc; set => _recRtrnLblTxtDesc = value; }
        private DirtyValue<string> _recRtrnNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Name [Closing.RecRtrnNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Name")]
        public string RecRtrnNm { get => _recRtrnNm; set => _recRtrnNm = value; }
        private DirtyValue<StringEnumValue<RecSamePtyTypeDesc>> _recRtrnNmSamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Name same as another party [Closing.RecRtrnNmSamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Name same as another party")]
        public StringEnumValue<RecSamePtyTypeDesc> RecRtrnNmSamePtyTypDesc { get => _recRtrnNmSamePtyTypDesc; set => _recRtrnNmSamePtyTypDesc = value; }
        private DirtyValue<string> _recRtrnPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Telephone Number [Closing.RecRtrnPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Telephone Number")]
        public string RecRtrnPhoneNum { get => _recRtrnPhoneNum; set => _recRtrnPhoneNum = value; }
        private DirtyValue<string> _recRtrnStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return State Code [Closing.RecRtrnStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return State Code")]
        public string RecRtrnStCd { get => _recRtrnStCd; set => _recRtrnStCd = value; }
        private DirtyValue<string> _recRtrnStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Street Address [Closing.RecRtrnStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Street Address")]
        public string RecRtrnStreetAddr1 { get => _recRtrnStreetAddr1; set => _recRtrnStreetAddr1 = value; }
        private DirtyValue<string> _recRtrnStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Street Address 2 [Closing.RecRtrnStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Street Address 2")]
        public string RecRtrnStreetAddr2 { get => _recRtrnStreetAddr2; set => _recRtrnStreetAddr2 = value; }
        private DirtyValue<string> _recRtrnTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Toll-Free Telephone Number [Closing.RecRtrnTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Toll-Free Telephone Number")]
        public string RecRtrnTollFreePhoneNum { get => _recRtrnTollFreePhoneNum; set => _recRtrnTollFreePhoneNum = value; }
        private DirtyValue<string> _recRtrnZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Record And Return Postal Code [Closing.RecRtrnZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Record And Return Postal Code")]
        public string RecRtrnZip { get => _recRtrnZip; set => _recRtrnZip = value; }
        private DirtyValue<bool?> _rtrnExeClosPkgToLndBrchBool;
        /// <summary>
        /// Ellie Mae Closing Document Override - Return Executed Closing Package to Lender Branch Indicator [Closing.RtrnExeClosPkgToLndBrchBool]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Return Executed Closing Package to Lender Branch Indicator")]
        public bool? RtrnExeClosPkgToLndBrchBool { get => _rtrnExeClosPkgToLndBrchBool; set => _rtrnExeClosPkgToLndBrchBool = value; }
        private DirtyValue<string> _rtToCancelNtfcAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Miscellaneous Text Description  [Closing.RtToCancelNtfcAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Miscellaneous Text Description ")]
        public string RtToCancelNtfcAdtlTxt { get => _rtToCancelNtfcAdtlTxt; set => _rtToCancelNtfcAdtlTxt = value; }
        private DirtyValue<string> _rtToCancelNtfcCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification City [Closing.RtToCancelNtfcCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification City")]
        public string RtToCancelNtfcCty { get => _rtToCancelNtfcCty; set => _rtToCancelNtfcCty = value; }
        private DirtyValue<string> _rtToCancelNtfcEmail;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Email [Closing.RtToCancelNtfcEmail]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Email")]
        public string RtToCancelNtfcEmail { get => _rtToCancelNtfcEmail; set => _rtToCancelNtfcEmail = value; }
        private DirtyValue<string> _rtToCancelNtfcFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Fax [Closing.RtToCancelNtfcFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Fax")]
        public string RtToCancelNtfcFax { get => _rtToCancelNtfcFax; set => _rtToCancelNtfcFax = value; }
        private DirtyValue<string> _rtToCancelNtfcNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Name [Closing.RtToCancelNtfcNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Name")]
        public string RtToCancelNtfcNm { get => _rtToCancelNtfcNm; set => _rtToCancelNtfcNm = value; }
        private DirtyValue<string> _rtToCancelNtfcStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification State Code [Closing.RtToCancelNtfcStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification State Code")]
        public string RtToCancelNtfcStCd { get => _rtToCancelNtfcStCd; set => _rtToCancelNtfcStCd = value; }
        private DirtyValue<string> _rtToCancelNtfcStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address [Closing.RtToCancelNtfcStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Street Address")]
        public string RtToCancelNtfcStreetAddr1 { get => _rtToCancelNtfcStreetAddr1; set => _rtToCancelNtfcStreetAddr1 = value; }
        private DirtyValue<string> _rtToCancelNtfcStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address 2 [Closing.RtToCancelNtfcStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Street Address 2")]
        public string RtToCancelNtfcStreetAddr2 { get => _rtToCancelNtfcStreetAddr2; set => _rtToCancelNtfcStreetAddr2 = value; }
        private DirtyValue<string> _rtToCancelNtfcZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Notification Postal Code [Closing.RtToCancelNtfcZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Notification Postal Code")]
        public string RtToCancelNtfcZip { get => _rtToCancelNtfcZip; set => _rtToCancelNtfcZip = value; }
        private DirtyValue<StringEnumValue<RtToCancelTransDtTyp>> _rtToCancelTransDtTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Right To Cancel Transaction Date [Closing.RtToCancelTransDtTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Right To Cancel Transaction Date")]
        public StringEnumValue<RtToCancelTransDtTyp> RtToCancelTransDtTyp { get => _rtToCancelTransDtTyp; set => _rtToCancelTransDtTyp = value; }
        private DirtyValue<string> _sctyIstrmtDCTrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - DC Trustee Fee [Closing.SctyIstrmtDCTrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - DC Trustee Fee")]
        public string SctyIstrmtDCTrstFeePct { get => _sctyIstrmtDCTrstFeePct; set => _sctyIstrmtDCTrstFeePct = value; }
        private DirtyValue<string> _sctyIstrmtDEAttyFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - DE Attorney Fee [Closing.SctyIstrmtDEAttyFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - DE Attorney Fee")]
        public string SctyIstrmtDEAttyFeePct { get => _sctyIstrmtDEAttyFeePct; set => _sctyIstrmtDEAttyFeePct = value; }
        private DirtyValue<decimal?> _sctyIstrmtLAAttyFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - LA Attorney Fee Percent [Closing.SctyIstrmtLAAttyFeePct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Ellie Mae Closing Document Override - LA Attorney Fee Percent")]
        public decimal? SctyIstrmtLAAttyFeePct { get => _sctyIstrmtLAAttyFeePct; set => _sctyIstrmtLAAttyFeePct = value; }
        private DirtyValue<decimal?> _sctyIstrmtLAMinAttyFeeAmt;
        /// <summary>
        /// Ellie Mae Closing Document Override - LA Minimum Attorney Fee Amount [Closing.SctyIstrmtLAMinAttyFeeAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Ellie Mae Closing Document Override - LA Minimum Attorney Fee Amount")]
        public decimal? SctyIstrmtLAMinAttyFeeAmt { get => _sctyIstrmtLAMinAttyFeeAmt; set => _sctyIstrmtLAMinAttyFeeAmt = value; }
        private DirtyValue<string> _sctyIstrmtMDTrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - MD Trustee Fee [Closing.SctyIstrmtMDTrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MD Trustee Fee")]
        public string SctyIstrmtMDTrstFeePct { get => _sctyIstrmtMDTrstFeePct; set => _sctyIstrmtMDTrstFeePct = value; }
        private DirtyValue<string> _sctyIstrmtMSTrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - MS Trustee Fee [Closing.SctyIstrmtMSTrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - MS Trustee Fee")]
        public string SctyIstrmtMSTrstFeePct { get => _sctyIstrmtMSTrstFeePct; set => _sctyIstrmtMSTrstFeePct = value; }
        private DirtyValue<string> _sctyIstrmtNCAttyFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - NC Trustee Fee [Closing.SctyIstrmtNCAttyFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - NC Trustee Fee")]
        public string SctyIstrmtNCAttyFeePct { get => _sctyIstrmtNCAttyFeePct; set => _sctyIstrmtNCAttyFeePct = value; }
        private DirtyValue<string> _sctyIstrmtNETrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - NE Trustee Fee [Closing.SctyIstrmtNETrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - NE Trustee Fee")]
        public string SctyIstrmtNETrstFeePct { get => _sctyIstrmtNETrstFeePct; set => _sctyIstrmtNETrstFeePct = value; }
        private DirtyValue<string> _sctyIstrmtNVAssmFeeAmt;
        /// <summary>
        /// Ellie Mae Closing Document Override - NV Assumption Fee [Closing.SctyIstrmtNVAssmFeeAmt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - NV Assumption Fee")]
        public string SctyIstrmtNVAssmFeeAmt { get => _sctyIstrmtNVAssmFeeAmt; set => _sctyIstrmtNVAssmFeeAmt = value; }
        private DirtyValue<string> _sctyIstrmtNVTrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - NV Trustee Fee [Closing.SctyIstrmtNVTrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - NV Trustee Fee")]
        public string SctyIstrmtNVTrstFeePct { get => _sctyIstrmtNVTrstFeePct; set => _sctyIstrmtNVTrstFeePct = value; }
        private DirtyValue<string> _sctyIstrmtOKAssmFeeAmt;
        /// <summary>
        /// Ellie Mae Closing Document Override - OK Assumption Fee [Closing.SctyIstrmtOKAssmFeeAmt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - OK Assumption Fee")]
        public string SctyIstrmtOKAssmFeeAmt { get => _sctyIstrmtOKAssmFeeAmt; set => _sctyIstrmtOKAssmFeeAmt = value; }
        private DirtyValue<string> _sctyIstrmtPOBoxAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender P.O. Box Address  1 [Closing.SctyIstrmtPOBoxAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender P.O. Box Address  1")]
        public string SctyIstrmtPOBoxAddr1 { get => _sctyIstrmtPOBoxAddr1; set => _sctyIstrmtPOBoxAddr1 = value; }
        private DirtyValue<string> _sctyIstrmtPOBoxAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender P.O. Box Address  2 [Closing.SctyIstrmtPOBoxAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender P.O. Box Address  2")]
        public string SctyIstrmtPOBoxAddr2 { get => _sctyIstrmtPOBoxAddr2; set => _sctyIstrmtPOBoxAddr2 = value; }
        private DirtyValue<string> _sctyIstrmtPrepByAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Additional Text [Closing.SctyIstrmtPrepByAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Additional Text")]
        public string SctyIstrmtPrepByAdtlTxt { get => _sctyIstrmtPrepByAdtlTxt; set => _sctyIstrmtPrepByAdtlTxt = value; }
        private DirtyValue<string> _sctyIstrmtPrepByCoNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Company Name [Closing.SctyIstrmtPrepByCoNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Company Name")]
        public string SctyIstrmtPrepByCoNm { get => _sctyIstrmtPrepByCoNm; set => _sctyIstrmtPrepByCoNm = value; }
        private DirtyValue<string> _sctyIstrmtPrepByCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By City [Closing.SctyIstrmtPrepByCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By City")]
        public string SctyIstrmtPrepByCty { get => _sctyIstrmtPrepByCty; set => _sctyIstrmtPrepByCty = value; }
        private DirtyValue<string> _sctyIstrmtPrepByIndvNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Name [Closing.SctyIstrmtPrepByIndvNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Name")]
        public string SctyIstrmtPrepByIndvNm { get => _sctyIstrmtPrepByIndvNm; set => _sctyIstrmtPrepByIndvNm = value; }
        private DirtyValue<string> _sctyIstrmtPrepByIndvTtl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Title [Closing.SctyIstrmtPrepByIndvTtl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Title")]
        public string SctyIstrmtPrepByIndvTtl { get => _sctyIstrmtPrepByIndvTtl; set => _sctyIstrmtPrepByIndvTtl = value; }
        private DirtyValue<string> _sctyIstrmtPrepByPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Telephone Number [Closing.SctyIstrmtPrepByPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Telephone Number")]
        public string SctyIstrmtPrepByPhone { get => _sctyIstrmtPrepByPhone; set => _sctyIstrmtPrepByPhone = value; }
        private DirtyValue<StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc>> _sctyIstrmtPrepBySamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Same as Another Party [Closing.SctyIstrmtPrepBySamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Same as Another Party")]
        public StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc> SctyIstrmtPrepBySamePtyTypDesc { get => _sctyIstrmtPrepBySamePtyTypDesc; set => _sctyIstrmtPrepBySamePtyTypDesc = value; }
        private DirtyValue<string> _sctyIstrmtPrepByStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By State Code [Closing.SctyIstrmtPrepByStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By State Code")]
        public string SctyIstrmtPrepByStCd { get => _sctyIstrmtPrepByStCd; set => _sctyIstrmtPrepByStCd = value; }
        private DirtyValue<string> _sctyIstrmtPrepByStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 1 [Closing.SctyIstrmtPrepByStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 1")]
        public string SctyIstrmtPrepByStreetAddr1 { get => _sctyIstrmtPrepByStreetAddr1; set => _sctyIstrmtPrepByStreetAddr1 = value; }
        private DirtyValue<string> _sctyIstrmtPrepByStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 2 [Closing.SctyIstrmtPrepByStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 2")]
        public string SctyIstrmtPrepByStreetAddr2 { get => _sctyIstrmtPrepByStreetAddr2; set => _sctyIstrmtPrepByStreetAddr2 = value; }
        private DirtyValue<string> _sctyIstrmtPrepByTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Sec. Instr. Prepared By Text [Closing.SctyIstrmtPrepByTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Sec. Instr. Prepared By Text")]
        public string SctyIstrmtPrepByTxt { get => _sctyIstrmtPrepByTxt; set => _sctyIstrmtPrepByTxt = value; }
        private DirtyValue<string> _sctyIstrmtPrepByZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Security Instrument Prepared By Postal Code [Closing.SctyIstrmtPrepByZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Security Instrument Prepared By Postal Code")]
        public string SctyIstrmtPrepByZip { get => _sctyIstrmtPrepByZip; set => _sctyIstrmtPrepByZip = value; }
        private DirtyValue<string> _sctyIstrmtTtlAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Sec. Instr. Title Addl. Text [Closing.SctyIstrmtTtlAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Sec. Instr. Title Addl. Text")]
        public string SctyIstrmtTtlAdtlTxt { get => _sctyIstrmtTtlAdtlTxt; set => _sctyIstrmtTtlAdtlTxt = value; }
        private DirtyValue<bool?> _sctyIstrmtTtlAdtlTxtAbvTtl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Print Addl. Text Above Title [Closing.SctyIstrmtTtlAdtlTxtAbvTtl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Print Addl. Text Above Title")]
        public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get => _sctyIstrmtTtlAdtlTxtAbvTtl; set => _sctyIstrmtTtlAdtlTxtAbvTtl = value; }
        private DirtyValue<string> _sctyIstrmtVATrstFeePct;
        /// <summary>
        /// Ellie Mae Closing Document Override - VA Trustee Fee [Closing.SctyIstrmtVATrstFeePct]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - VA Trustee Fee")]
        public string SctyIstrmtVATrstFeePct { get => _sctyIstrmtVATrstFeePct; set => _sctyIstrmtVATrstFeePct = value; }
        private DirtyValue<string> _trst1Cnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 County [Closing.Trst1Cnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 County")]
        public string Trst1Cnty { get => _trst1Cnty; set => _trst1Cnty = value; }
        private DirtyValue<string> _trst1Cty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 City [Closing.Trst1Cty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 City")]
        public string Trst1Cty { get => _trst1Cty; set => _trst1Cty = value; }
        private DirtyValue<bool?> _trst1IndvBool;
        /// <summary>
        /// EmDocument Trst1IndvBool
        /// </summary>
        public bool? Trst1IndvBool { get => _trst1IndvBool; set => _trst1IndvBool = value; }
        private DirtyValue<string> _trst1Jrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Jurisdiction [Closing.Trst1Jrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Jurisdiction")]
        public string Trst1Jrsdctn { get => _trst1Jrsdctn; set => _trst1Jrsdctn = value; }
        private DirtyValue<string> _trst1Nm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Name [Closing.Trst1Nm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Name")]
        public string Trst1Nm { get => _trst1Nm; set => _trst1Nm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _trst1OrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Organization Type [Closing.Trst1OrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Organization Type")]
        public StringEnumValue<OrgTyp> Trst1OrgTyp { get => _trst1OrgTyp; set => _trst1OrgTyp = value; }
        private DirtyValue<string> _trst1Phone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Phone Number [Closing.Trst1Phone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Phone Number")]
        public string Trst1Phone { get => _trst1Phone; set => _trst1Phone = value; }
        private DirtyValue<string> _trst1RsdtTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Is Resident Of Text Description [Closing.Trst1RsdtTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Is Resident Of Text Description")]
        public string Trst1RsdtTxtDesc { get => _trst1RsdtTxtDesc; set => _trst1RsdtTxtDesc = value; }
        private DirtyValue<StringEnumValue<TrstSamePtyTypDesc>> _trst1SamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Same As Party Type Description [Closing.Trst1SamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Same As Party Type Description")]
        public StringEnumValue<TrstSamePtyTypDesc> Trst1SamePtyTypDesc { get => _trst1SamePtyTypDesc; set => _trst1SamePtyTypDesc = value; }
        private DirtyValue<string> _trst1StCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 State Code [Closing.Trst1StCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 State Code")]
        public string Trst1StCd { get => _trst1StCd; set => _trst1StCd = value; }
        private DirtyValue<string> _trst1StreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Street Address [Closing.Trst1StreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Street Address")]
        public string Trst1StreetAddr1 { get => _trst1StreetAddr1; set => _trst1StreetAddr1 = value; }
        private DirtyValue<string> _trst1StreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Street Address 2 [Closing.Trst1StreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Street Address 2")]
        public string Trst1StreetAddr2 { get => _trst1StreetAddr2; set => _trst1StreetAddr2 = value; }
        private DirtyValue<string> _trst1Zip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 1 Postal Code [Closing.Trst1Zip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 1 Postal Code")]
        public string Trst1Zip { get => _trst1Zip; set => _trst1Zip = value; }
        private DirtyValue<string> _trst2Cnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 County [Closing.Trst2Cnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 County")]
        public string Trst2Cnty { get => _trst2Cnty; set => _trst2Cnty = value; }
        private DirtyValue<string> _trst2Cty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 City [Closing.Trst2Cty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 City")]
        public string Trst2Cty { get => _trst2Cty; set => _trst2Cty = value; }
        private DirtyValue<bool?> _trst2IndvBool;
        /// <summary>
        /// EmDocument Trst2IndvBool
        /// </summary>
        public bool? Trst2IndvBool { get => _trst2IndvBool; set => _trst2IndvBool = value; }
        private DirtyValue<string> _trst2Jrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Jurisdiction [Closing.Trst2Jrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Jurisdiction")]
        public string Trst2Jrsdctn { get => _trst2Jrsdctn; set => _trst2Jrsdctn = value; }
        private DirtyValue<string> _trst2Nm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Name [Closing.Trst2Nm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Name")]
        public string Trst2Nm { get => _trst2Nm; set => _trst2Nm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _trst2OrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Organization Type [Closing.Trst2OrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Organization Type")]
        public StringEnumValue<OrgTyp> Trst2OrgTyp { get => _trst2OrgTyp; set => _trst2OrgTyp = value; }
        private DirtyValue<string> _trst2Phone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Phone Number [Closing.Trst2Phone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Phone Number")]
        public string Trst2Phone { get => _trst2Phone; set => _trst2Phone = value; }
        private DirtyValue<string> _trst2RsdtTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Is Resident Of Text Description [Closing.Trst2RsdtTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Is Resident Of Text Description")]
        public string Trst2RsdtTxtDesc { get => _trst2RsdtTxtDesc; set => _trst2RsdtTxtDesc = value; }
        private DirtyValue<StringEnumValue<TrstSamePtyTypDesc>> _trst2SamePtyTypDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Same As Party Type Description [Closing.Trst2SamePtyTypDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Same As Party Type Description")]
        public StringEnumValue<TrstSamePtyTypDesc> Trst2SamePtyTypDesc { get => _trst2SamePtyTypDesc; set => _trst2SamePtyTypDesc = value; }
        private DirtyValue<string> _trst2StCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 State Code [Closing.Trst2StCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 State Code")]
        public string Trst2StCd { get => _trst2StCd; set => _trst2StCd = value; }
        private DirtyValue<string> _trst2StreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Street Address [Closing.Trst2StreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Street Address")]
        public string Trst2StreetAddr1 { get => _trst2StreetAddr1; set => _trst2StreetAddr1 = value; }
        private DirtyValue<string> _trst2StreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Street Address 2 [Closing.Trst2StreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Street Address 2")]
        public string Trst2StreetAddr2 { get => _trst2StreetAddr2; set => _trst2StreetAddr2 = value; }
        private DirtyValue<string> _trst2Zip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Trustee 2 Postal Code [Closing.Trst2Zip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Trustee 2 Postal Code")]
        public string Trst2Zip { get => _trst2Zip; set => _trst2Zip = value; }
    }
}