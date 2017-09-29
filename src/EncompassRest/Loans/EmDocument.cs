using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocument : IDirty
    {
        private DirtyValue<string> _allngToNtPayToJrsdctn;
        public string AllngToNtPayToJrsdctn { get { return _allngToNtPayToJrsdctn; } set { _allngToNtPayToJrsdctn = value; } }
        private DirtyValue<string> _allngToNtPayToOrdNm;
        public string AllngToNtPayToOrdNm { get { return _allngToNtPayToOrdNm; } set { _allngToNtPayToOrdNm = value; } }
        private DirtyValue<string> _allngToNtPayToOrgTyp;
        public string AllngToNtPayToOrgTyp { get { return _allngToNtPayToOrgTyp; } set { _allngToNtPayToOrgTyp = value; } }
        private DirtyValue<string> _allngToNtPayToScsrsClaus;
        public string AllngToNtPayToScsrsClaus { get { return _allngToNtPayToScsrsClaus; } set { _allngToNtPayToScsrsClaus = value; } }
        private DirtyValue<string> _allngToNtSignedByNm;
        public string AllngToNtSignedByNm { get { return _allngToNtSignedByNm; } set { _allngToNtSignedByNm = value; } }
        private DirtyValue<string> _allngToNtSignedByNm2;
        public string AllngToNtSignedByNm2 { get { return _allngToNtSignedByNm2; } set { _allngToNtSignedByNm2 = value; } }
        private DirtyValue<string> _allngToNtSignedByNm3;
        public string AllngToNtSignedByNm3 { get { return _allngToNtSignedByNm3; } set { _allngToNtSignedByNm3 = value; } }
        private DirtyValue<string> _allngToNtSignedByTtl;
        public string AllngToNtSignedByTtl { get { return _allngToNtSignedByTtl; } set { _allngToNtSignedByTtl = value; } }
        private DirtyValue<string> _allngToNtSignedByTtl2;
        public string AllngToNtSignedByTtl2 { get { return _allngToNtSignedByTtl2; } set { _allngToNtSignedByTtl2 = value; } }
        private DirtyValue<string> _allngToNtSignedByTtl3;
        public string AllngToNtSignedByTtl3 { get { return _allngToNtSignedByTtl3; } set { _allngToNtSignedByTtl3 = value; } }
        private DirtyValue<string> _allngToNtSignedByTyp;
        public string AllngToNtSignedByTyp { get { return _allngToNtSignedByTyp; } set { _allngToNtSignedByTyp = value; } }
        private DirtyValue<string> _allngToNtWithoutRcrse;
        public string AllngToNtWithoutRcrse { get { return _allngToNtWithoutRcrse; } set { _allngToNtWithoutRcrse = value; } }
        private DirtyValue<string> _apnLbl;
        public string ApnLbl { get { return _apnLbl; } set { _apnLbl = value; } }
        private DirtyValue<bool?> _asgnPrepByLblTxtDesc;
        public bool? AsgnPrepByLblTxtDesc { get { return _asgnPrepByLblTxtDesc; } set { _asgnPrepByLblTxtDesc = value; } }
        private DirtyValue<bool?> _asgnRecRtrnLblTxtDesc;
        public bool? AsgnRecRtrnLblTxtDesc { get { return _asgnRecRtrnLblTxtDesc; } set { _asgnRecRtrnLblTxtDesc = value; } }
        private DirtyValue<string> _benCty;
        public string BenCty { get { return _benCty; } set { _benCty = value; } }
        private DirtyValue<string> _benJrsdctn;
        public string BenJrsdctn { get { return _benJrsdctn; } set { _benJrsdctn = value; } }
        private DirtyValue<string> _benNm;
        public string BenNm { get { return _benNm; } set { _benNm = value; } }
        private DirtyValue<string> _benOrgTyp;
        public string BenOrgTyp { get { return _benOrgTyp; } set { _benOrgTyp = value; } }
        private DirtyValue<string> _benStCd;
        public string BenStCd { get { return _benStCd; } set { _benStCd = value; } }
        private DirtyValue<string> _benStreetAddr1;
        public string BenStreetAddr1 { get { return _benStreetAddr1; } set { _benStreetAddr1 = value; } }
        private DirtyValue<string> _benStreetAddr2;
        public string BenStreetAddr2 { get { return _benStreetAddr2; } set { _benStreetAddr2 = value; } }
        private DirtyValue<string> _benZip;
        public string BenZip { get { return _benZip; } set { _benZip = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoCity;
        public string ClosInstrLndCntcInfoCity { get { return _closInstrLndCntcInfoCity; } set { _closInstrLndCntcInfoCity = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoCoNm;
        public string ClosInstrLndCntcInfoCoNm { get { return _closInstrLndCntcInfoCoNm; } set { _closInstrLndCntcInfoCoNm = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoSamePtyTypDesc;
        public string ClosInstrLndCntcInfoSamePtyTypDesc { get { return _closInstrLndCntcInfoSamePtyTypDesc; } set { _closInstrLndCntcInfoSamePtyTypDesc = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoStCd;
        public string ClosInstrLndCntcInfoStCd { get { return _closInstrLndCntcInfoStCd; } set { _closInstrLndCntcInfoStCd = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoStreetAddr1;
        public string ClosInstrLndCntcInfoStreetAddr1 { get { return _closInstrLndCntcInfoStreetAddr1; } set { _closInstrLndCntcInfoStreetAddr1 = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoStreetAddr2;
        public string ClosInstrLndCntcInfoStreetAddr2 { get { return _closInstrLndCntcInfoStreetAddr2; } set { _closInstrLndCntcInfoStreetAddr2 = value; } }
        private DirtyValue<string> _closInstrLndCntcInfoZip;
        public string ClosInstrLndCntcInfoZip { get { return _closInstrLndCntcInfoZip; } set { _closInstrLndCntcInfoZip = value; } }
        private DirtyValue<bool?> _closInstrPrtInvLossPayee;
        public bool? ClosInstrPrtInvLossPayee { get { return _closInstrPrtInvLossPayee; } set { _closInstrPrtInvLossPayee = value; } }
        private DirtyValue<bool?> _closInstrStlmtAgtUseLndHud1;
        public bool? ClosInstrStlmtAgtUseLndHud1 { get { return _closInstrStlmtAgtUseLndHud1; } set { _closInstrStlmtAgtUseLndHud1 = value; } }
        private DirtyValue<string> _closInstrTtlPlcyTyp;
        public string ClosInstrTtlPlcyTyp { get { return _closInstrTtlPlcyTyp; } set { _closInstrTtlPlcyTyp = value; } }
        private DirtyValue<string> _emxmlVersionId;
        public string EmxmlVersionId { get { return _emxmlVersionId; } set { _emxmlVersionId = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToCty;
        public string ExeClosDocDlvrdToCty { get { return _exeClosDocDlvrdToCty; } set { _exeClosDocDlvrdToCty = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToMiscTxtDesc;
        public string ExeClosDocDlvrdToMiscTxtDesc { get { return _exeClosDocDlvrdToMiscTxtDesc; } set { _exeClosDocDlvrdToMiscTxtDesc = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToNm;
        public string ExeClosDocDlvrdToNm { get { return _exeClosDocDlvrdToNm; } set { _exeClosDocDlvrdToNm = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToSamePtyTypDesc;
        public string ExeClosDocDlvrdToSamePtyTypDesc { get { return _exeClosDocDlvrdToSamePtyTypDesc; } set { _exeClosDocDlvrdToSamePtyTypDesc = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToStCd;
        public string ExeClosDocDlvrdToStCd { get { return _exeClosDocDlvrdToStCd; } set { _exeClosDocDlvrdToStCd = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToStreetAddr1;
        public string ExeClosDocDlvrdToStreetAddr1 { get { return _exeClosDocDlvrdToStreetAddr1; } set { _exeClosDocDlvrdToStreetAddr1 = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToStreetAddr2;
        public string ExeClosDocDlvrdToStreetAddr2 { get { return _exeClosDocDlvrdToStreetAddr2; } set { _exeClosDocDlvrdToStreetAddr2 = value; } }
        private DirtyValue<string> _exeClosDocDlvrdToZip;
        public string ExeClosDocDlvrdToZip { get { return _exeClosDocDlvrdToZip; } set { _exeClosDocDlvrdToZip = value; } }
        private DirtyValue<string> _exeClosDocExprDt;
        public string ExeClosDocExprDt { get { return _exeClosDocExprDt; } set { _exeClosDocExprDt = value; } }
        private DirtyValue<string> _exeClosDocToBeRtrnd;
        public string ExeClosDocToBeRtrnd { get { return _exeClosDocToBeRtrnd; } set { _exeClosDocToBeRtrnd = value; } }
        private DirtyValue<string> _exeClosDocToBeRtrndHrs;
        public string ExeClosDocToBeRtrndHrs { get { return _exeClosDocToBeRtrndHrs; } set { _exeClosDocToBeRtrndHrs = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToAddlLine1;
        public string FnlTtlePcyRecDocsSentToAddlLine1 { get { return _fnlTtlePcyRecDocsSentToAddlLine1; } set { _fnlTtlePcyRecDocsSentToAddlLine1 = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToAddlLine2;
        public string FnlTtlePcyRecDocsSentToAddlLine2 { get { return _fnlTtlePcyRecDocsSentToAddlLine2; } set { _fnlTtlePcyRecDocsSentToAddlLine2 = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToCty;
        public string FnlTtlePcyRecDocsSentToCty { get { return _fnlTtlePcyRecDocsSentToCty; } set { _fnlTtlePcyRecDocsSentToCty = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToNm;
        public string FnlTtlePcyRecDocsSentToNm { get { return _fnlTtlePcyRecDocsSentToNm; } set { _fnlTtlePcyRecDocsSentToNm = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToSamePtyTypDesc;
        public string FnlTtlePcyRecDocsSentToSamePtyTypDesc { get { return _fnlTtlePcyRecDocsSentToSamePtyTypDesc; } set { _fnlTtlePcyRecDocsSentToSamePtyTypDesc = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStcd;
        public string FnlTtlePcyRecDocsSentToStcd { get { return _fnlTtlePcyRecDocsSentToStcd; } set { _fnlTtlePcyRecDocsSentToStcd = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStreetAddr1;
        public string FnlTtlePcyRecDocsSentToStreetAddr1 { get { return _fnlTtlePcyRecDocsSentToStreetAddr1; } set { _fnlTtlePcyRecDocsSentToStreetAddr1 = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToStreetAddr2;
        public string FnlTtlePcyRecDocsSentToStreetAddr2 { get { return _fnlTtlePcyRecDocsSentToStreetAddr2; } set { _fnlTtlePcyRecDocsSentToStreetAddr2 = value; } }
        private DirtyValue<string> _fnlTtlePcyRecDocsSentToZip;
        public string FnlTtlePcyRecDocsSentToZip { get { return _fnlTtlePcyRecDocsSentToZip; } set { _fnlTtlePcyRecDocsSentToZip = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToAdtlTxt;
        public string HazInsurEndsmtMailToAdtlTxt { get { return _hazInsurEndsmtMailToAdtlTxt; } set { _hazInsurEndsmtMailToAdtlTxt = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToCty;
        public string HazInsurEndsmtMailToCty { get { return _hazInsurEndsmtMailToCty; } set { _hazInsurEndsmtMailToCty = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToNm;
        public string HazInsurEndsmtMailToNm { get { return _hazInsurEndsmtMailToNm; } set { _hazInsurEndsmtMailToNm = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToStCd;
        public string HazInsurEndsmtMailToStCd { get { return _hazInsurEndsmtMailToStCd; } set { _hazInsurEndsmtMailToStCd = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToStreetAddr1;
        public string HazInsurEndsmtMailToStreetAddr1 { get { return _hazInsurEndsmtMailToStreetAddr1; } set { _hazInsurEndsmtMailToStreetAddr1 = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToStreetAddr2;
        public string HazInsurEndsmtMailToStreetAddr2 { get { return _hazInsurEndsmtMailToStreetAddr2; } set { _hazInsurEndsmtMailToStreetAddr2 = value; } }
        private DirtyValue<string> _hazInsurEndsmtMailToZip;
        public string HazInsurEndsmtMailToZip { get { return _hazInsurEndsmtMailToZip; } set { _hazInsurEndsmtMailToZip = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _mersAdtlCity;
        public string MersAdtlCity { get { return _mersAdtlCity; } set { _mersAdtlCity = value; } }
        private DirtyValue<string> _mersAdtlStCd;
        public string MersAdtlStCd { get { return _mersAdtlStCd; } set { _mersAdtlStCd = value; } }
        private DirtyValue<string> _mersAdtlStreetAddr1;
        public string MersAdtlStreetAddr1 { get { return _mersAdtlStreetAddr1; } set { _mersAdtlStreetAddr1 = value; } }
        private DirtyValue<string> _mersAdtlStreetAddr2;
        public string MersAdtlStreetAddr2 { get { return _mersAdtlStreetAddr2; } set { _mersAdtlStreetAddr2 = value; } }
        private DirtyValue<string> _mersAdtlZip;
        public string MersAdtlZip { get { return _mersAdtlZip; } set { _mersAdtlZip = value; } }
        private DirtyValue<string> _mersCty;
        public string MersCty { get { return _mersCty; } set { _mersCty = value; } }
        private DirtyValue<string> _mersJrsdctn;
        public string MersJrsdctn { get { return _mersJrsdctn; } set { _mersJrsdctn = value; } }
        private DirtyValue<string> _mersName;
        public string MersName { get { return _mersName; } set { _mersName = value; } }
        private DirtyValue<string> _mersOrgTyp;
        public string MersOrgTyp { get { return _mersOrgTyp; } set { _mersOrgTyp = value; } }
        private DirtyValue<string> _mersPhoneNum;
        public string MersPhoneNum { get { return _mersPhoneNum; } set { _mersPhoneNum = value; } }
        private DirtyValue<string> _mersStCd;
        public string MersStCd { get { return _mersStCd; } set { _mersStCd = value; } }
        private DirtyValue<string> _mersStreetAddr1;
        public string MersStreetAddr1 { get { return _mersStreetAddr1; } set { _mersStreetAddr1 = value; } }
        private DirtyValue<string> _mersStreetAddr2;
        public string MersStreetAddr2 { get { return _mersStreetAddr2; } set { _mersStreetAddr2 = value; } }
        private DirtyValue<string> _mersZip;
        public string MersZip { get { return _mersZip; } set { _mersZip = value; } }
        private DirtyValue<string> _ntEndrsmtPayToJrsdctn;
        public string NtEndrsmtPayToJrsdctn { get { return _ntEndrsmtPayToJrsdctn; } set { _ntEndrsmtPayToJrsdctn = value; } }
        private DirtyValue<string> _ntEndrsmtPayToOrdNm;
        public string NtEndrsmtPayToOrdNm { get { return _ntEndrsmtPayToOrdNm; } set { _ntEndrsmtPayToOrdNm = value; } }
        private DirtyValue<string> _ntEndrsmtPayToOrgTyp;
        public string NtEndrsmtPayToOrgTyp { get { return _ntEndrsmtPayToOrgTyp; } set { _ntEndrsmtPayToOrgTyp = value; } }
        private DirtyValue<string> _ntEndrsmtPayToScsrsClaus;
        public string NtEndrsmtPayToScsrsClaus { get { return _ntEndrsmtPayToScsrsClaus; } set { _ntEndrsmtPayToScsrsClaus = value; } }
        private DirtyValue<string> _ntEndrsmtSgndBy1MiscTxt;
        public string NtEndrsmtSgndBy1MiscTxt { get { return _ntEndrsmtSgndBy1MiscTxt; } set { _ntEndrsmtSgndBy1MiscTxt = value; } }
        private DirtyValue<string> _ntEndrsmtSgndBy2MiscTxt;
        public string NtEndrsmtSgndBy2MiscTxt { get { return _ntEndrsmtSgndBy2MiscTxt; } set { _ntEndrsmtSgndBy2MiscTxt = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByNm;
        public string NtEndrsmtSignedByNm { get { return _ntEndrsmtSignedByNm; } set { _ntEndrsmtSignedByNm = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByNm2;
        public string NtEndrsmtSignedByNm2 { get { return _ntEndrsmtSignedByNm2; } set { _ntEndrsmtSignedByNm2 = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByNm3;
        public string NtEndrsmtSignedByNm3 { get { return _ntEndrsmtSignedByNm3; } set { _ntEndrsmtSignedByNm3 = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByTtl;
        public string NtEndrsmtSignedByTtl { get { return _ntEndrsmtSignedByTtl; } set { _ntEndrsmtSignedByTtl = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByTtl2;
        public string NtEndrsmtSignedByTtl2 { get { return _ntEndrsmtSignedByTtl2; } set { _ntEndrsmtSignedByTtl2 = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByTtl3;
        public string NtEndrsmtSignedByTtl3 { get { return _ntEndrsmtSignedByTtl3; } set { _ntEndrsmtSignedByTtl3 = value; } }
        private DirtyValue<string> _ntEndrsmtSignedByTyp;
        public string NtEndrsmtSignedByTyp { get { return _ntEndrsmtSignedByTyp; } set { _ntEndrsmtSignedByTyp = value; } }
        private DirtyValue<string> _ntEndrsmtWithoutRcrse;
        public string NtEndrsmtWithoutRcrse { get { return _ntEndrsmtWithoutRcrse; } set { _ntEndrsmtWithoutRcrse = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyAddr1;
        public string NtEndsmtThrdPtyAddr1 { get { return _ntEndsmtThrdPtyAddr1; } set { _ntEndsmtThrdPtyAddr1 = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyAddr2;
        public string NtEndsmtThrdPtyAddr2 { get { return _ntEndsmtThrdPtyAddr2; } set { _ntEndsmtThrdPtyAddr2 = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyCty;
        public string NtEndsmtThrdPtyCty { get { return _ntEndsmtThrdPtyCty; } set { _ntEndsmtThrdPtyCty = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyJrsdctn;
        public string NtEndsmtThrdPtyJrsdctn { get { return _ntEndsmtThrdPtyJrsdctn; } set { _ntEndsmtThrdPtyJrsdctn = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyName;
        public string NtEndsmtThrdPtyName { get { return _ntEndsmtThrdPtyName; } set { _ntEndsmtThrdPtyName = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyOrgTyp;
        public string NtEndsmtThrdPtyOrgTyp { get { return _ntEndsmtThrdPtyOrgTyp; } set { _ntEndsmtThrdPtyOrgTyp = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyPhone;
        public string NtEndsmtThrdPtyPhone { get { return _ntEndsmtThrdPtyPhone; } set { _ntEndsmtThrdPtyPhone = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyScsrClaus;
        public string NtEndsmtThrdPtyScsrClaus { get { return _ntEndsmtThrdPtyScsrClaus; } set { _ntEndsmtThrdPtyScsrClaus = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyStCd;
        public string NtEndsmtThrdPtyStCd { get { return _ntEndsmtThrdPtyStCd; } set { _ntEndsmtThrdPtyStCd = value; } }
        private DirtyValue<string> _ntEndsmtThrdPtyZip;
        public string NtEndsmtThrdPtyZip { get { return _ntEndsmtThrdPtyZip; } set { _ntEndsmtThrdPtyZip = value; } }
        private DirtyValue<string> _ntPayToAdtlTxt;
        public string NtPayToAdtlTxt { get { return _ntPayToAdtlTxt; } set { _ntPayToAdtlTxt = value; } }
        private DirtyValue<string> _ntPayToCty;
        public string NtPayToCty { get { return _ntPayToCty; } set { _ntPayToCty = value; } }
        private DirtyValue<string> _ntPayToJrsdctn;
        public string NtPayToJrsdctn { get { return _ntPayToJrsdctn; } set { _ntPayToJrsdctn = value; } }
        private DirtyValue<string> _ntPayToNm;
        public string NtPayToNm { get { return _ntPayToNm; } set { _ntPayToNm = value; } }
        private DirtyValue<string> _ntPayToOrgTyp;
        public string NtPayToOrgTyp { get { return _ntPayToOrgTyp; } set { _ntPayToOrgTyp = value; } }
        private DirtyValue<string> _ntPayToStCd;
        public string NtPayToStCd { get { return _ntPayToStCd; } set { _ntPayToStCd = value; } }
        private DirtyValue<string> _ntPayToStreetAddr1;
        public string NtPayToStreetAddr1 { get { return _ntPayToStreetAddr1; } set { _ntPayToStreetAddr1 = value; } }
        private DirtyValue<string> _ntPayToStreetAddr2;
        public string NtPayToStreetAddr2 { get { return _ntPayToStreetAddr2; } set { _ntPayToStreetAddr2 = value; } }
        private DirtyValue<string> _ntPayToZip;
        public string NtPayToZip { get { return _ntPayToZip; } set { _ntPayToZip = value; } }
        private DirtyValue<string> _pmtCpn2PayToAdtlTxt;
        public string PmtCpn2PayToAdtlTxt { get { return _pmtCpn2PayToAdtlTxt; } set { _pmtCpn2PayToAdtlTxt = value; } }
        private DirtyValue<string> _pmtCpn2PayToAdtlTxt2;
        public string PmtCpn2PayToAdtlTxt2 { get { return _pmtCpn2PayToAdtlTxt2; } set { _pmtCpn2PayToAdtlTxt2 = value; } }
        private DirtyValue<string> _pmtCpn2PayToCty;
        public string PmtCpn2PayToCty { get { return _pmtCpn2PayToCty; } set { _pmtCpn2PayToCty = value; } }
        private DirtyValue<string> _pmtCpn2PayToNm;
        public string PmtCpn2PayToNm { get { return _pmtCpn2PayToNm; } set { _pmtCpn2PayToNm = value; } }
        private DirtyValue<string> _pmtCpn2PayToStCd;
        public string PmtCpn2PayToStCd { get { return _pmtCpn2PayToStCd; } set { _pmtCpn2PayToStCd = value; } }
        private DirtyValue<string> _pmtCpn2PayToStreetAddr1;
        public string PmtCpn2PayToStreetAddr1 { get { return _pmtCpn2PayToStreetAddr1; } set { _pmtCpn2PayToStreetAddr1 = value; } }
        private DirtyValue<string> _pmtCpn2PayToStreetAddr2;
        public string PmtCpn2PayToStreetAddr2 { get { return _pmtCpn2PayToStreetAddr2; } set { _pmtCpn2PayToStreetAddr2 = value; } }
        private DirtyValue<string> _pmtCpn2PayToZip;
        public string PmtCpn2PayToZip { get { return _pmtCpn2PayToZip; } set { _pmtCpn2PayToZip = value; } }
        private DirtyValue<string> _pmtCpnPayToAdtlTxt;
        public string PmtCpnPayToAdtlTxt { get { return _pmtCpnPayToAdtlTxt; } set { _pmtCpnPayToAdtlTxt = value; } }
        private DirtyValue<string> _pmtCpnPayToAdtlTxt2;
        public string PmtCpnPayToAdtlTxt2 { get { return _pmtCpnPayToAdtlTxt2; } set { _pmtCpnPayToAdtlTxt2 = value; } }
        private DirtyValue<string> _pmtCpnPayToCty;
        public string PmtCpnPayToCty { get { return _pmtCpnPayToCty; } set { _pmtCpnPayToCty = value; } }
        private DirtyValue<string> _pmtCpnPayToNm;
        public string PmtCpnPayToNm { get { return _pmtCpnPayToNm; } set { _pmtCpnPayToNm = value; } }
        private DirtyValue<string> _pmtCpnPayToStCd;
        public string PmtCpnPayToStCd { get { return _pmtCpnPayToStCd; } set { _pmtCpnPayToStCd = value; } }
        private DirtyValue<string> _pmtCpnPayToStreetAddr1;
        public string PmtCpnPayToStreetAddr1 { get { return _pmtCpnPayToStreetAddr1; } set { _pmtCpnPayToStreetAddr1 = value; } }
        private DirtyValue<string> _pmtCpnPayToStreetAddr2;
        public string PmtCpnPayToStreetAddr2 { get { return _pmtCpnPayToStreetAddr2; } set { _pmtCpnPayToStreetAddr2 = value; } }
        private DirtyValue<string> _pmtCpnPayToZip;
        public string PmtCpnPayToZip { get { return _pmtCpnPayToZip; } set { _pmtCpnPayToZip = value; } }
        private DirtyValue<string> _prtAdtlDateHud1;
        public string PrtAdtlDateHud1 { get { return _prtAdtlDateHud1; } set { _prtAdtlDateHud1 = value; } }
        private DirtyValue<bool?> _prtAllngToNtBool;
        public bool? PrtAllngToNtBool { get { return _prtAllngToNtBool; } set { _prtAllngToNtBool = value; } }
        private DirtyValue<bool?> _prtCorpMsgAsgnBool;
        public bool? PrtCorpMsgAsgnBool { get { return _prtCorpMsgAsgnBool; } set { _prtCorpMsgAsgnBool = value; } }
        private DirtyValue<string> _prtDocDtSctyIstrmtNtryAprncDt;
        public string PrtDocDtSctyIstrmtNtryAprncDt { get { return _prtDocDtSctyIstrmtNtryAprncDt; } set { _prtDocDtSctyIstrmtNtryAprncDt = value; } }
        private DirtyValue<bool?> _prtIndxTilBool;
        public bool? PrtIndxTilBool { get { return _prtIndxTilBool; } set { _prtIndxTilBool = value; } }
        private DirtyValue<bool?> _prtInitBlckNtBool;
        public bool? PrtInitBlckNtBool { get { return _prtInitBlckNtBool; } set { _prtInitBlckNtBool = value; } }
        private DirtyValue<bool?> _prtInitBlckSctyIstrmtBool;
        public bool? PrtInitBlckSctyIstrmtBool { get { return _prtInitBlckSctyIstrmtBool; } set { _prtInitBlckSctyIstrmtBool = value; } }
        private DirtyValue<bool?> _prtInvLoanNumBool;
        public bool? PrtInvLoanNumBool { get { return _prtInvLoanNumBool; } set { _prtInvLoanNumBool = value; } }
        private DirtyValue<bool?> _prtInvLoanNumPmtCpn2Ind;
        public bool? PrtInvLoanNumPmtCpn2Ind { get { return _prtInvLoanNumPmtCpn2Ind; } set { _prtInvLoanNumPmtCpn2Ind = value; } }
        private DirtyValue<bool?> _prtInvLoanNumPmtCpnInd;
        public bool? PrtInvLoanNumPmtCpnInd { get { return _prtInvLoanNumPmtCpnInd; } set { _prtInvLoanNumPmtCpnInd = value; } }
        private DirtyValue<bool?> _prtInvLossPayeeHazInsurDisBool;
        public bool? PrtInvLossPayeeHazInsurDisBool { get { return _prtInvLossPayeeHazInsurDisBool; } set { _prtInvLossPayeeHazInsurDisBool = value; } }
        private DirtyValue<bool?> _prtLoanNumDeedBool;
        public bool? PrtLoanNumDeedBool { get { return _prtLoanNumDeedBool; } set { _prtLoanNumDeedBool = value; } }
        private DirtyValue<bool?> _prtNtEndsmtBool;
        public bool? PrtNtEndsmtBool { get { return _prtNtEndsmtBool; } set { _prtNtEndsmtBool = value; } }
        private DirtyValue<bool?> _prtNtPayToCorpMsgBool;
        public bool? PrtNtPayToCorpMsgBool { get { return _prtNtPayToCorpMsgBool; } set { _prtNtPayToCorpMsgBool = value; } }
        private DirtyValue<bool?> _prtScsrsClausClosInstBool;
        public bool? PrtScsrsClausClosInstBool { get { return _prtScsrsClausClosInstBool; } set { _prtScsrsClausClosInstBool = value; } }
        private DirtyValue<bool?> _prtScsrsClausHazInsurDisBool;
        public bool? PrtScsrsClausHazInsurDisBool { get { return _prtScsrsClausHazInsurDisBool; } set { _prtScsrsClausHazInsurDisBool = value; } }
        private DirtyValue<bool?> _prtScsrsClausHazInsurLtrBool;
        public bool? PrtScsrsClausHazInsurLtrBool { get { return _prtScsrsClausHazInsurLtrBool; } set { _prtScsrsClausHazInsurLtrBool = value; } }
        private DirtyValue<bool?> _prtScsrsClausPmtCpnBool;
        public bool? PrtScsrsClausPmtCpnBool { get { return _prtScsrsClausPmtCpnBool; } set { _prtScsrsClausPmtCpnBool = value; } }
        private DirtyValue<bool?> _prtSctyIstrmtCorpMsgBool;
        public bool? PrtSctyIstrmtCorpMsgBool { get { return _prtSctyIstrmtCorpMsgBool; } set { _prtSctyIstrmtCorpMsgBool = value; } }
        private DirtyValue<string> _recRtrnAttnLnNmTxtDesc;
        public string RecRtrnAttnLnNmTxtDesc { get { return _recRtrnAttnLnNmTxtDesc; } set { _recRtrnAttnLnNmTxtDesc = value; } }
        private DirtyValue<string> _recRtrnCty;
        public string RecRtrnCty { get { return _recRtrnCty; } set { _recRtrnCty = value; } }
        private DirtyValue<string> _recRtrnLblTxtDesc;
        public string RecRtrnLblTxtDesc { get { return _recRtrnLblTxtDesc; } set { _recRtrnLblTxtDesc = value; } }
        private DirtyValue<string> _recRtrnNm;
        public string RecRtrnNm { get { return _recRtrnNm; } set { _recRtrnNm = value; } }
        private DirtyValue<string> _recRtrnNmSamePtyTypDesc;
        public string RecRtrnNmSamePtyTypDesc { get { return _recRtrnNmSamePtyTypDesc; } set { _recRtrnNmSamePtyTypDesc = value; } }
        private DirtyValue<string> _recRtrnPhoneNum;
        public string RecRtrnPhoneNum { get { return _recRtrnPhoneNum; } set { _recRtrnPhoneNum = value; } }
        private DirtyValue<string> _recRtrnStCd;
        public string RecRtrnStCd { get { return _recRtrnStCd; } set { _recRtrnStCd = value; } }
        private DirtyValue<string> _recRtrnStreetAddr1;
        public string RecRtrnStreetAddr1 { get { return _recRtrnStreetAddr1; } set { _recRtrnStreetAddr1 = value; } }
        private DirtyValue<string> _recRtrnStreetAddr2;
        public string RecRtrnStreetAddr2 { get { return _recRtrnStreetAddr2; } set { _recRtrnStreetAddr2 = value; } }
        private DirtyValue<string> _recRtrnTollFreePhoneNum;
        public string RecRtrnTollFreePhoneNum { get { return _recRtrnTollFreePhoneNum; } set { _recRtrnTollFreePhoneNum = value; } }
        private DirtyValue<string> _recRtrnZip;
        public string RecRtrnZip { get { return _recRtrnZip; } set { _recRtrnZip = value; } }
        private DirtyValue<bool?> _rtrnExeClosPkgToLndBrchBool;
        public bool? RtrnExeClosPkgToLndBrchBool { get { return _rtrnExeClosPkgToLndBrchBool; } set { _rtrnExeClosPkgToLndBrchBool = value; } }
        private DirtyValue<string> _rtToCancelNtfcAdtlTxt;
        public string RtToCancelNtfcAdtlTxt { get { return _rtToCancelNtfcAdtlTxt; } set { _rtToCancelNtfcAdtlTxt = value; } }
        private DirtyValue<string> _rtToCancelNtfcCty;
        public string RtToCancelNtfcCty { get { return _rtToCancelNtfcCty; } set { _rtToCancelNtfcCty = value; } }
        private DirtyValue<string> _rtToCancelNtfcEmail;
        public string RtToCancelNtfcEmail { get { return _rtToCancelNtfcEmail; } set { _rtToCancelNtfcEmail = value; } }
        private DirtyValue<string> _rtToCancelNtfcFax;
        public string RtToCancelNtfcFax { get { return _rtToCancelNtfcFax; } set { _rtToCancelNtfcFax = value; } }
        private DirtyValue<string> _rtToCancelNtfcNm;
        public string RtToCancelNtfcNm { get { return _rtToCancelNtfcNm; } set { _rtToCancelNtfcNm = value; } }
        private DirtyValue<string> _rtToCancelNtfcStCd;
        public string RtToCancelNtfcStCd { get { return _rtToCancelNtfcStCd; } set { _rtToCancelNtfcStCd = value; } }
        private DirtyValue<string> _rtToCancelNtfcStreetAddr1;
        public string RtToCancelNtfcStreetAddr1 { get { return _rtToCancelNtfcStreetAddr1; } set { _rtToCancelNtfcStreetAddr1 = value; } }
        private DirtyValue<string> _rtToCancelNtfcStreetAddr2;
        public string RtToCancelNtfcStreetAddr2 { get { return _rtToCancelNtfcStreetAddr2; } set { _rtToCancelNtfcStreetAddr2 = value; } }
        private DirtyValue<string> _rtToCancelNtfcZip;
        public string RtToCancelNtfcZip { get { return _rtToCancelNtfcZip; } set { _rtToCancelNtfcZip = value; } }
        private DirtyValue<string> _rtToCancelTransDtTyp;
        public string RtToCancelTransDtTyp { get { return _rtToCancelTransDtTyp; } set { _rtToCancelTransDtTyp = value; } }
        private DirtyValue<string> _sctyIstrmtDCTrstFeePct;
        public string SctyIstrmtDCTrstFeePct { get { return _sctyIstrmtDCTrstFeePct; } set { _sctyIstrmtDCTrstFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtDEAttyFeePct;
        public string SctyIstrmtDEAttyFeePct { get { return _sctyIstrmtDEAttyFeePct; } set { _sctyIstrmtDEAttyFeePct = value; } }
        private DirtyValue<decimal?> _sctyIstrmtLAAttyFeePct;
        public decimal? SctyIstrmtLAAttyFeePct { get { return _sctyIstrmtLAAttyFeePct; } set { _sctyIstrmtLAAttyFeePct = value; } }
        private DirtyValue<decimal?> _sctyIstrmtLAMinAttyFeeAmt;
        public decimal? SctyIstrmtLAMinAttyFeeAmt { get { return _sctyIstrmtLAMinAttyFeeAmt; } set { _sctyIstrmtLAMinAttyFeeAmt = value; } }
        private DirtyValue<string> _sctyIstrmtMDTrstFeePct;
        public string SctyIstrmtMDTrstFeePct { get { return _sctyIstrmtMDTrstFeePct; } set { _sctyIstrmtMDTrstFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtMSTrstFeePct;
        public string SctyIstrmtMSTrstFeePct { get { return _sctyIstrmtMSTrstFeePct; } set { _sctyIstrmtMSTrstFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtNCAttyFeePct;
        public string SctyIstrmtNCAttyFeePct { get { return _sctyIstrmtNCAttyFeePct; } set { _sctyIstrmtNCAttyFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtNETrstFeePct;
        public string SctyIstrmtNETrstFeePct { get { return _sctyIstrmtNETrstFeePct; } set { _sctyIstrmtNETrstFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtNVAssmFeeAmt;
        public string SctyIstrmtNVAssmFeeAmt { get { return _sctyIstrmtNVAssmFeeAmt; } set { _sctyIstrmtNVAssmFeeAmt = value; } }
        private DirtyValue<string> _sctyIstrmtNVTrstFeePct;
        public string SctyIstrmtNVTrstFeePct { get { return _sctyIstrmtNVTrstFeePct; } set { _sctyIstrmtNVTrstFeePct = value; } }
        private DirtyValue<string> _sctyIstrmtOKAssmFeeAmt;
        public string SctyIstrmtOKAssmFeeAmt { get { return _sctyIstrmtOKAssmFeeAmt; } set { _sctyIstrmtOKAssmFeeAmt = value; } }
        private DirtyValue<string> _sctyIstrmtPOBoxAddr1;
        public string SctyIstrmtPOBoxAddr1 { get { return _sctyIstrmtPOBoxAddr1; } set { _sctyIstrmtPOBoxAddr1 = value; } }
        private DirtyValue<string> _sctyIstrmtPOBoxAddr2;
        public string SctyIstrmtPOBoxAddr2 { get { return _sctyIstrmtPOBoxAddr2; } set { _sctyIstrmtPOBoxAddr2 = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByAdtlTxt;
        public string SctyIstrmtPrepByAdtlTxt { get { return _sctyIstrmtPrepByAdtlTxt; } set { _sctyIstrmtPrepByAdtlTxt = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByCoNm;
        public string SctyIstrmtPrepByCoNm { get { return _sctyIstrmtPrepByCoNm; } set { _sctyIstrmtPrepByCoNm = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByCty;
        public string SctyIstrmtPrepByCty { get { return _sctyIstrmtPrepByCty; } set { _sctyIstrmtPrepByCty = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByIndvNm;
        public string SctyIstrmtPrepByIndvNm { get { return _sctyIstrmtPrepByIndvNm; } set { _sctyIstrmtPrepByIndvNm = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByIndvTtl;
        public string SctyIstrmtPrepByIndvTtl { get { return _sctyIstrmtPrepByIndvTtl; } set { _sctyIstrmtPrepByIndvTtl = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByPhone;
        public string SctyIstrmtPrepByPhone { get { return _sctyIstrmtPrepByPhone; } set { _sctyIstrmtPrepByPhone = value; } }
        private DirtyValue<string> _sctyIstrmtPrepBySamePtyTypDesc;
        public string SctyIstrmtPrepBySamePtyTypDesc { get { return _sctyIstrmtPrepBySamePtyTypDesc; } set { _sctyIstrmtPrepBySamePtyTypDesc = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByStCd;
        public string SctyIstrmtPrepByStCd { get { return _sctyIstrmtPrepByStCd; } set { _sctyIstrmtPrepByStCd = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByStreetAddr1;
        public string SctyIstrmtPrepByStreetAddr1 { get { return _sctyIstrmtPrepByStreetAddr1; } set { _sctyIstrmtPrepByStreetAddr1 = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByStreetAddr2;
        public string SctyIstrmtPrepByStreetAddr2 { get { return _sctyIstrmtPrepByStreetAddr2; } set { _sctyIstrmtPrepByStreetAddr2 = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByTxt;
        public string SctyIstrmtPrepByTxt { get { return _sctyIstrmtPrepByTxt; } set { _sctyIstrmtPrepByTxt = value; } }
        private DirtyValue<string> _sctyIstrmtPrepByZip;
        public string SctyIstrmtPrepByZip { get { return _sctyIstrmtPrepByZip; } set { _sctyIstrmtPrepByZip = value; } }
        private DirtyValue<string> _sctyIstrmtTtlAdtlTxt;
        public string SctyIstrmtTtlAdtlTxt { get { return _sctyIstrmtTtlAdtlTxt; } set { _sctyIstrmtTtlAdtlTxt = value; } }
        private DirtyValue<bool?> _sctyIstrmtTtlAdtlTxtAbvTtl;
        public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get { return _sctyIstrmtTtlAdtlTxtAbvTtl; } set { _sctyIstrmtTtlAdtlTxtAbvTtl = value; } }
        private DirtyValue<string> _sctyIstrmtVATrstFeePct;
        public string SctyIstrmtVATrstFeePct { get { return _sctyIstrmtVATrstFeePct; } set { _sctyIstrmtVATrstFeePct = value; } }
        private DirtyValue<string> _trst1Cnty;
        public string Trst1Cnty { get { return _trst1Cnty; } set { _trst1Cnty = value; } }
        private DirtyValue<string> _trst1Cty;
        public string Trst1Cty { get { return _trst1Cty; } set { _trst1Cty = value; } }
        private DirtyValue<bool?> _trst1IndvBool;
        public bool? Trst1IndvBool { get { return _trst1IndvBool; } set { _trst1IndvBool = value; } }
        private DirtyValue<string> _trst1Jrsdctn;
        public string Trst1Jrsdctn { get { return _trst1Jrsdctn; } set { _trst1Jrsdctn = value; } }
        private DirtyValue<string> _trst1Nm;
        public string Trst1Nm { get { return _trst1Nm; } set { _trst1Nm = value; } }
        private DirtyValue<string> _trst1OrgTyp;
        public string Trst1OrgTyp { get { return _trst1OrgTyp; } set { _trst1OrgTyp = value; } }
        private DirtyValue<string> _trst1Phone;
        public string Trst1Phone { get { return _trst1Phone; } set { _trst1Phone = value; } }
        private DirtyValue<string> _trst1RsdtTxtDesc;
        public string Trst1RsdtTxtDesc { get { return _trst1RsdtTxtDesc; } set { _trst1RsdtTxtDesc = value; } }
        private DirtyValue<string> _trst1SamePtyTypDesc;
        public string Trst1SamePtyTypDesc { get { return _trst1SamePtyTypDesc; } set { _trst1SamePtyTypDesc = value; } }
        private DirtyValue<string> _trst1StCd;
        public string Trst1StCd { get { return _trst1StCd; } set { _trst1StCd = value; } }
        private DirtyValue<string> _trst1StreetAddr1;
        public string Trst1StreetAddr1 { get { return _trst1StreetAddr1; } set { _trst1StreetAddr1 = value; } }
        private DirtyValue<string> _trst1StreetAddr2;
        public string Trst1StreetAddr2 { get { return _trst1StreetAddr2; } set { _trst1StreetAddr2 = value; } }
        private DirtyValue<string> _trst1Zip;
        public string Trst1Zip { get { return _trst1Zip; } set { _trst1Zip = value; } }
        private DirtyValue<string> _trst2Cnty;
        public string Trst2Cnty { get { return _trst2Cnty; } set { _trst2Cnty = value; } }
        private DirtyValue<string> _trst2Cty;
        public string Trst2Cty { get { return _trst2Cty; } set { _trst2Cty = value; } }
        private DirtyValue<bool?> _trst2IndvBool;
        public bool? Trst2IndvBool { get { return _trst2IndvBool; } set { _trst2IndvBool = value; } }
        private DirtyValue<string> _trst2Jrsdctn;
        public string Trst2Jrsdctn { get { return _trst2Jrsdctn; } set { _trst2Jrsdctn = value; } }
        private DirtyValue<string> _trst2Nm;
        public string Trst2Nm { get { return _trst2Nm; } set { _trst2Nm = value; } }
        private DirtyValue<string> _trst2OrgTyp;
        public string Trst2OrgTyp { get { return _trst2OrgTyp; } set { _trst2OrgTyp = value; } }
        private DirtyValue<string> _trst2Phone;
        public string Trst2Phone { get { return _trst2Phone; } set { _trst2Phone = value; } }
        private DirtyValue<string> _trst2RsdtTxtDesc;
        public string Trst2RsdtTxtDesc { get { return _trst2RsdtTxtDesc; } set { _trst2RsdtTxtDesc = value; } }
        private DirtyValue<string> _trst2SamePtyTypDesc;
        public string Trst2SamePtyTypDesc { get { return _trst2SamePtyTypDesc; } set { _trst2SamePtyTypDesc = value; } }
        private DirtyValue<string> _trst2StCd;
        public string Trst2StCd { get { return _trst2StCd; } set { _trst2StCd = value; } }
        private DirtyValue<string> _trst2StreetAddr1;
        public string Trst2StreetAddr1 { get { return _trst2StreetAddr1; } set { _trst2StreetAddr1 = value; } }
        private DirtyValue<string> _trst2StreetAddr2;
        public string Trst2StreetAddr2 { get { return _trst2StreetAddr2; } set { _trst2StreetAddr2 = value; } }
        private DirtyValue<string> _trst2Zip;
        public string Trst2Zip { get { return _trst2Zip; } set { _trst2Zip = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _allngToNtPayToJrsdctn.Dirty
                    || _allngToNtPayToOrdNm.Dirty
                    || _allngToNtPayToOrgTyp.Dirty
                    || _allngToNtPayToScsrsClaus.Dirty
                    || _allngToNtSignedByNm.Dirty
                    || _allngToNtSignedByNm2.Dirty
                    || _allngToNtSignedByNm3.Dirty
                    || _allngToNtSignedByTtl.Dirty
                    || _allngToNtSignedByTtl2.Dirty
                    || _allngToNtSignedByTtl3.Dirty
                    || _allngToNtSignedByTyp.Dirty
                    || _allngToNtWithoutRcrse.Dirty
                    || _apnLbl.Dirty
                    || _asgnPrepByLblTxtDesc.Dirty
                    || _asgnRecRtrnLblTxtDesc.Dirty
                    || _benCty.Dirty
                    || _benJrsdctn.Dirty
                    || _benNm.Dirty
                    || _benOrgTyp.Dirty
                    || _benStCd.Dirty
                    || _benStreetAddr1.Dirty
                    || _benStreetAddr2.Dirty
                    || _benZip.Dirty
                    || _closInstrLndCntcInfoCity.Dirty
                    || _closInstrLndCntcInfoCoNm.Dirty
                    || _closInstrLndCntcInfoSamePtyTypDesc.Dirty
                    || _closInstrLndCntcInfoStCd.Dirty
                    || _closInstrLndCntcInfoStreetAddr1.Dirty
                    || _closInstrLndCntcInfoStreetAddr2.Dirty
                    || _closInstrLndCntcInfoZip.Dirty
                    || _closInstrPrtInvLossPayee.Dirty
                    || _closInstrStlmtAgtUseLndHud1.Dirty
                    || _closInstrTtlPlcyTyp.Dirty
                    || _emxmlVersionId.Dirty
                    || _exeClosDocDlvrdToCty.Dirty
                    || _exeClosDocDlvrdToMiscTxtDesc.Dirty
                    || _exeClosDocDlvrdToNm.Dirty
                    || _exeClosDocDlvrdToSamePtyTypDesc.Dirty
                    || _exeClosDocDlvrdToStCd.Dirty
                    || _exeClosDocDlvrdToStreetAddr1.Dirty
                    || _exeClosDocDlvrdToStreetAddr2.Dirty
                    || _exeClosDocDlvrdToZip.Dirty
                    || _exeClosDocExprDt.Dirty
                    || _exeClosDocToBeRtrnd.Dirty
                    || _exeClosDocToBeRtrndHrs.Dirty
                    || _fnlTtlePcyRecDocsSentToAddlLine1.Dirty
                    || _fnlTtlePcyRecDocsSentToAddlLine2.Dirty
                    || _fnlTtlePcyRecDocsSentToCty.Dirty
                    || _fnlTtlePcyRecDocsSentToNm.Dirty
                    || _fnlTtlePcyRecDocsSentToSamePtyTypDesc.Dirty
                    || _fnlTtlePcyRecDocsSentToStcd.Dirty
                    || _fnlTtlePcyRecDocsSentToStreetAddr1.Dirty
                    || _fnlTtlePcyRecDocsSentToStreetAddr2.Dirty
                    || _fnlTtlePcyRecDocsSentToZip.Dirty
                    || _hazInsurEndsmtMailToAdtlTxt.Dirty
                    || _hazInsurEndsmtMailToCty.Dirty
                    || _hazInsurEndsmtMailToNm.Dirty
                    || _hazInsurEndsmtMailToStCd.Dirty
                    || _hazInsurEndsmtMailToStreetAddr1.Dirty
                    || _hazInsurEndsmtMailToStreetAddr2.Dirty
                    || _hazInsurEndsmtMailToZip.Dirty
                    || _id.Dirty
                    || _mersAdtlCity.Dirty
                    || _mersAdtlStCd.Dirty
                    || _mersAdtlStreetAddr1.Dirty
                    || _mersAdtlStreetAddr2.Dirty
                    || _mersAdtlZip.Dirty
                    || _mersCty.Dirty
                    || _mersJrsdctn.Dirty
                    || _mersName.Dirty
                    || _mersOrgTyp.Dirty
                    || _mersPhoneNum.Dirty
                    || _mersStCd.Dirty
                    || _mersStreetAddr1.Dirty
                    || _mersStreetAddr2.Dirty
                    || _mersZip.Dirty
                    || _ntEndrsmtPayToJrsdctn.Dirty
                    || _ntEndrsmtPayToOrdNm.Dirty
                    || _ntEndrsmtPayToOrgTyp.Dirty
                    || _ntEndrsmtPayToScsrsClaus.Dirty
                    || _ntEndrsmtSgndBy1MiscTxt.Dirty
                    || _ntEndrsmtSgndBy2MiscTxt.Dirty
                    || _ntEndrsmtSignedByNm.Dirty
                    || _ntEndrsmtSignedByNm2.Dirty
                    || _ntEndrsmtSignedByNm3.Dirty
                    || _ntEndrsmtSignedByTtl.Dirty
                    || _ntEndrsmtSignedByTtl2.Dirty
                    || _ntEndrsmtSignedByTtl3.Dirty
                    || _ntEndrsmtSignedByTyp.Dirty
                    || _ntEndrsmtWithoutRcrse.Dirty
                    || _ntEndsmtThrdPtyAddr1.Dirty
                    || _ntEndsmtThrdPtyAddr2.Dirty
                    || _ntEndsmtThrdPtyCty.Dirty
                    || _ntEndsmtThrdPtyJrsdctn.Dirty
                    || _ntEndsmtThrdPtyName.Dirty
                    || _ntEndsmtThrdPtyOrgTyp.Dirty
                    || _ntEndsmtThrdPtyPhone.Dirty
                    || _ntEndsmtThrdPtyScsrClaus.Dirty
                    || _ntEndsmtThrdPtyStCd.Dirty
                    || _ntEndsmtThrdPtyZip.Dirty
                    || _ntPayToAdtlTxt.Dirty
                    || _ntPayToCty.Dirty
                    || _ntPayToJrsdctn.Dirty
                    || _ntPayToNm.Dirty
                    || _ntPayToOrgTyp.Dirty
                    || _ntPayToStCd.Dirty
                    || _ntPayToStreetAddr1.Dirty
                    || _ntPayToStreetAddr2.Dirty
                    || _ntPayToZip.Dirty
                    || _pmtCpn2PayToAdtlTxt.Dirty
                    || _pmtCpn2PayToAdtlTxt2.Dirty
                    || _pmtCpn2PayToCty.Dirty
                    || _pmtCpn2PayToNm.Dirty
                    || _pmtCpn2PayToStCd.Dirty
                    || _pmtCpn2PayToStreetAddr1.Dirty
                    || _pmtCpn2PayToStreetAddr2.Dirty
                    || _pmtCpn2PayToZip.Dirty
                    || _pmtCpnPayToAdtlTxt.Dirty
                    || _pmtCpnPayToAdtlTxt2.Dirty
                    || _pmtCpnPayToCty.Dirty
                    || _pmtCpnPayToNm.Dirty
                    || _pmtCpnPayToStCd.Dirty
                    || _pmtCpnPayToStreetAddr1.Dirty
                    || _pmtCpnPayToStreetAddr2.Dirty
                    || _pmtCpnPayToZip.Dirty
                    || _prtAdtlDateHud1.Dirty
                    || _prtAllngToNtBool.Dirty
                    || _prtCorpMsgAsgnBool.Dirty
                    || _prtDocDtSctyIstrmtNtryAprncDt.Dirty
                    || _prtIndxTilBool.Dirty
                    || _prtInitBlckNtBool.Dirty
                    || _prtInitBlckSctyIstrmtBool.Dirty
                    || _prtInvLoanNumBool.Dirty
                    || _prtInvLoanNumPmtCpn2Ind.Dirty
                    || _prtInvLoanNumPmtCpnInd.Dirty
                    || _prtInvLossPayeeHazInsurDisBool.Dirty
                    || _prtLoanNumDeedBool.Dirty
                    || _prtNtEndsmtBool.Dirty
                    || _prtNtPayToCorpMsgBool.Dirty
                    || _prtScsrsClausClosInstBool.Dirty
                    || _prtScsrsClausHazInsurDisBool.Dirty
                    || _prtScsrsClausHazInsurLtrBool.Dirty
                    || _prtScsrsClausPmtCpnBool.Dirty
                    || _prtSctyIstrmtCorpMsgBool.Dirty
                    || _recRtrnAttnLnNmTxtDesc.Dirty
                    || _recRtrnCty.Dirty
                    || _recRtrnLblTxtDesc.Dirty
                    || _recRtrnNm.Dirty
                    || _recRtrnNmSamePtyTypDesc.Dirty
                    || _recRtrnPhoneNum.Dirty
                    || _recRtrnStCd.Dirty
                    || _recRtrnStreetAddr1.Dirty
                    || _recRtrnStreetAddr2.Dirty
                    || _recRtrnTollFreePhoneNum.Dirty
                    || _recRtrnZip.Dirty
                    || _rtrnExeClosPkgToLndBrchBool.Dirty
                    || _rtToCancelNtfcAdtlTxt.Dirty
                    || _rtToCancelNtfcCty.Dirty
                    || _rtToCancelNtfcEmail.Dirty
                    || _rtToCancelNtfcFax.Dirty
                    || _rtToCancelNtfcNm.Dirty
                    || _rtToCancelNtfcStCd.Dirty
                    || _rtToCancelNtfcStreetAddr1.Dirty
                    || _rtToCancelNtfcStreetAddr2.Dirty
                    || _rtToCancelNtfcZip.Dirty
                    || _rtToCancelTransDtTyp.Dirty
                    || _sctyIstrmtDCTrstFeePct.Dirty
                    || _sctyIstrmtDEAttyFeePct.Dirty
                    || _sctyIstrmtLAAttyFeePct.Dirty
                    || _sctyIstrmtLAMinAttyFeeAmt.Dirty
                    || _sctyIstrmtMDTrstFeePct.Dirty
                    || _sctyIstrmtMSTrstFeePct.Dirty
                    || _sctyIstrmtNCAttyFeePct.Dirty
                    || _sctyIstrmtNETrstFeePct.Dirty
                    || _sctyIstrmtNVAssmFeeAmt.Dirty
                    || _sctyIstrmtNVTrstFeePct.Dirty
                    || _sctyIstrmtOKAssmFeeAmt.Dirty
                    || _sctyIstrmtPOBoxAddr1.Dirty
                    || _sctyIstrmtPOBoxAddr2.Dirty
                    || _sctyIstrmtPrepByAdtlTxt.Dirty
                    || _sctyIstrmtPrepByCoNm.Dirty
                    || _sctyIstrmtPrepByCty.Dirty
                    || _sctyIstrmtPrepByIndvNm.Dirty
                    || _sctyIstrmtPrepByIndvTtl.Dirty
                    || _sctyIstrmtPrepByPhone.Dirty
                    || _sctyIstrmtPrepBySamePtyTypDesc.Dirty
                    || _sctyIstrmtPrepByStCd.Dirty
                    || _sctyIstrmtPrepByStreetAddr1.Dirty
                    || _sctyIstrmtPrepByStreetAddr2.Dirty
                    || _sctyIstrmtPrepByTxt.Dirty
                    || _sctyIstrmtPrepByZip.Dirty
                    || _sctyIstrmtTtlAdtlTxt.Dirty
                    || _sctyIstrmtTtlAdtlTxtAbvTtl.Dirty
                    || _sctyIstrmtVATrstFeePct.Dirty
                    || _trst1Cnty.Dirty
                    || _trst1Cty.Dirty
                    || _trst1IndvBool.Dirty
                    || _trst1Jrsdctn.Dirty
                    || _trst1Nm.Dirty
                    || _trst1OrgTyp.Dirty
                    || _trst1Phone.Dirty
                    || _trst1RsdtTxtDesc.Dirty
                    || _trst1SamePtyTypDesc.Dirty
                    || _trst1StCd.Dirty
                    || _trst1StreetAddr1.Dirty
                    || _trst1StreetAddr2.Dirty
                    || _trst1Zip.Dirty
                    || _trst2Cnty.Dirty
                    || _trst2Cty.Dirty
                    || _trst2IndvBool.Dirty
                    || _trst2Jrsdctn.Dirty
                    || _trst2Nm.Dirty
                    || _trst2OrgTyp.Dirty
                    || _trst2Phone.Dirty
                    || _trst2RsdtTxtDesc.Dirty
                    || _trst2SamePtyTypDesc.Dirty
                    || _trst2StCd.Dirty
                    || _trst2StreetAddr1.Dirty
                    || _trst2StreetAddr2.Dirty
                    || _trst2Zip.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _allngToNtPayToJrsdctn.Dirty = value;
                _allngToNtPayToOrdNm.Dirty = value;
                _allngToNtPayToOrgTyp.Dirty = value;
                _allngToNtPayToScsrsClaus.Dirty = value;
                _allngToNtSignedByNm.Dirty = value;
                _allngToNtSignedByNm2.Dirty = value;
                _allngToNtSignedByNm3.Dirty = value;
                _allngToNtSignedByTtl.Dirty = value;
                _allngToNtSignedByTtl2.Dirty = value;
                _allngToNtSignedByTtl3.Dirty = value;
                _allngToNtSignedByTyp.Dirty = value;
                _allngToNtWithoutRcrse.Dirty = value;
                _apnLbl.Dirty = value;
                _asgnPrepByLblTxtDesc.Dirty = value;
                _asgnRecRtrnLblTxtDesc.Dirty = value;
                _benCty.Dirty = value;
                _benJrsdctn.Dirty = value;
                _benNm.Dirty = value;
                _benOrgTyp.Dirty = value;
                _benStCd.Dirty = value;
                _benStreetAddr1.Dirty = value;
                _benStreetAddr2.Dirty = value;
                _benZip.Dirty = value;
                _closInstrLndCntcInfoCity.Dirty = value;
                _closInstrLndCntcInfoCoNm.Dirty = value;
                _closInstrLndCntcInfoSamePtyTypDesc.Dirty = value;
                _closInstrLndCntcInfoStCd.Dirty = value;
                _closInstrLndCntcInfoStreetAddr1.Dirty = value;
                _closInstrLndCntcInfoStreetAddr2.Dirty = value;
                _closInstrLndCntcInfoZip.Dirty = value;
                _closInstrPrtInvLossPayee.Dirty = value;
                _closInstrStlmtAgtUseLndHud1.Dirty = value;
                _closInstrTtlPlcyTyp.Dirty = value;
                _emxmlVersionId.Dirty = value;
                _exeClosDocDlvrdToCty.Dirty = value;
                _exeClosDocDlvrdToMiscTxtDesc.Dirty = value;
                _exeClosDocDlvrdToNm.Dirty = value;
                _exeClosDocDlvrdToSamePtyTypDesc.Dirty = value;
                _exeClosDocDlvrdToStCd.Dirty = value;
                _exeClosDocDlvrdToStreetAddr1.Dirty = value;
                _exeClosDocDlvrdToStreetAddr2.Dirty = value;
                _exeClosDocDlvrdToZip.Dirty = value;
                _exeClosDocExprDt.Dirty = value;
                _exeClosDocToBeRtrnd.Dirty = value;
                _exeClosDocToBeRtrndHrs.Dirty = value;
                _fnlTtlePcyRecDocsSentToAddlLine1.Dirty = value;
                _fnlTtlePcyRecDocsSentToAddlLine2.Dirty = value;
                _fnlTtlePcyRecDocsSentToCty.Dirty = value;
                _fnlTtlePcyRecDocsSentToNm.Dirty = value;
                _fnlTtlePcyRecDocsSentToSamePtyTypDesc.Dirty = value;
                _fnlTtlePcyRecDocsSentToStcd.Dirty = value;
                _fnlTtlePcyRecDocsSentToStreetAddr1.Dirty = value;
                _fnlTtlePcyRecDocsSentToStreetAddr2.Dirty = value;
                _fnlTtlePcyRecDocsSentToZip.Dirty = value;
                _hazInsurEndsmtMailToAdtlTxt.Dirty = value;
                _hazInsurEndsmtMailToCty.Dirty = value;
                _hazInsurEndsmtMailToNm.Dirty = value;
                _hazInsurEndsmtMailToStCd.Dirty = value;
                _hazInsurEndsmtMailToStreetAddr1.Dirty = value;
                _hazInsurEndsmtMailToStreetAddr2.Dirty = value;
                _hazInsurEndsmtMailToZip.Dirty = value;
                _id.Dirty = value;
                _mersAdtlCity.Dirty = value;
                _mersAdtlStCd.Dirty = value;
                _mersAdtlStreetAddr1.Dirty = value;
                _mersAdtlStreetAddr2.Dirty = value;
                _mersAdtlZip.Dirty = value;
                _mersCty.Dirty = value;
                _mersJrsdctn.Dirty = value;
                _mersName.Dirty = value;
                _mersOrgTyp.Dirty = value;
                _mersPhoneNum.Dirty = value;
                _mersStCd.Dirty = value;
                _mersStreetAddr1.Dirty = value;
                _mersStreetAddr2.Dirty = value;
                _mersZip.Dirty = value;
                _ntEndrsmtPayToJrsdctn.Dirty = value;
                _ntEndrsmtPayToOrdNm.Dirty = value;
                _ntEndrsmtPayToOrgTyp.Dirty = value;
                _ntEndrsmtPayToScsrsClaus.Dirty = value;
                _ntEndrsmtSgndBy1MiscTxt.Dirty = value;
                _ntEndrsmtSgndBy2MiscTxt.Dirty = value;
                _ntEndrsmtSignedByNm.Dirty = value;
                _ntEndrsmtSignedByNm2.Dirty = value;
                _ntEndrsmtSignedByNm3.Dirty = value;
                _ntEndrsmtSignedByTtl.Dirty = value;
                _ntEndrsmtSignedByTtl2.Dirty = value;
                _ntEndrsmtSignedByTtl3.Dirty = value;
                _ntEndrsmtSignedByTyp.Dirty = value;
                _ntEndrsmtWithoutRcrse.Dirty = value;
                _ntEndsmtThrdPtyAddr1.Dirty = value;
                _ntEndsmtThrdPtyAddr2.Dirty = value;
                _ntEndsmtThrdPtyCty.Dirty = value;
                _ntEndsmtThrdPtyJrsdctn.Dirty = value;
                _ntEndsmtThrdPtyName.Dirty = value;
                _ntEndsmtThrdPtyOrgTyp.Dirty = value;
                _ntEndsmtThrdPtyPhone.Dirty = value;
                _ntEndsmtThrdPtyScsrClaus.Dirty = value;
                _ntEndsmtThrdPtyStCd.Dirty = value;
                _ntEndsmtThrdPtyZip.Dirty = value;
                _ntPayToAdtlTxt.Dirty = value;
                _ntPayToCty.Dirty = value;
                _ntPayToJrsdctn.Dirty = value;
                _ntPayToNm.Dirty = value;
                _ntPayToOrgTyp.Dirty = value;
                _ntPayToStCd.Dirty = value;
                _ntPayToStreetAddr1.Dirty = value;
                _ntPayToStreetAddr2.Dirty = value;
                _ntPayToZip.Dirty = value;
                _pmtCpn2PayToAdtlTxt.Dirty = value;
                _pmtCpn2PayToAdtlTxt2.Dirty = value;
                _pmtCpn2PayToCty.Dirty = value;
                _pmtCpn2PayToNm.Dirty = value;
                _pmtCpn2PayToStCd.Dirty = value;
                _pmtCpn2PayToStreetAddr1.Dirty = value;
                _pmtCpn2PayToStreetAddr2.Dirty = value;
                _pmtCpn2PayToZip.Dirty = value;
                _pmtCpnPayToAdtlTxt.Dirty = value;
                _pmtCpnPayToAdtlTxt2.Dirty = value;
                _pmtCpnPayToCty.Dirty = value;
                _pmtCpnPayToNm.Dirty = value;
                _pmtCpnPayToStCd.Dirty = value;
                _pmtCpnPayToStreetAddr1.Dirty = value;
                _pmtCpnPayToStreetAddr2.Dirty = value;
                _pmtCpnPayToZip.Dirty = value;
                _prtAdtlDateHud1.Dirty = value;
                _prtAllngToNtBool.Dirty = value;
                _prtCorpMsgAsgnBool.Dirty = value;
                _prtDocDtSctyIstrmtNtryAprncDt.Dirty = value;
                _prtIndxTilBool.Dirty = value;
                _prtInitBlckNtBool.Dirty = value;
                _prtInitBlckSctyIstrmtBool.Dirty = value;
                _prtInvLoanNumBool.Dirty = value;
                _prtInvLoanNumPmtCpn2Ind.Dirty = value;
                _prtInvLoanNumPmtCpnInd.Dirty = value;
                _prtInvLossPayeeHazInsurDisBool.Dirty = value;
                _prtLoanNumDeedBool.Dirty = value;
                _prtNtEndsmtBool.Dirty = value;
                _prtNtPayToCorpMsgBool.Dirty = value;
                _prtScsrsClausClosInstBool.Dirty = value;
                _prtScsrsClausHazInsurDisBool.Dirty = value;
                _prtScsrsClausHazInsurLtrBool.Dirty = value;
                _prtScsrsClausPmtCpnBool.Dirty = value;
                _prtSctyIstrmtCorpMsgBool.Dirty = value;
                _recRtrnAttnLnNmTxtDesc.Dirty = value;
                _recRtrnCty.Dirty = value;
                _recRtrnLblTxtDesc.Dirty = value;
                _recRtrnNm.Dirty = value;
                _recRtrnNmSamePtyTypDesc.Dirty = value;
                _recRtrnPhoneNum.Dirty = value;
                _recRtrnStCd.Dirty = value;
                _recRtrnStreetAddr1.Dirty = value;
                _recRtrnStreetAddr2.Dirty = value;
                _recRtrnTollFreePhoneNum.Dirty = value;
                _recRtrnZip.Dirty = value;
                _rtrnExeClosPkgToLndBrchBool.Dirty = value;
                _rtToCancelNtfcAdtlTxt.Dirty = value;
                _rtToCancelNtfcCty.Dirty = value;
                _rtToCancelNtfcEmail.Dirty = value;
                _rtToCancelNtfcFax.Dirty = value;
                _rtToCancelNtfcNm.Dirty = value;
                _rtToCancelNtfcStCd.Dirty = value;
                _rtToCancelNtfcStreetAddr1.Dirty = value;
                _rtToCancelNtfcStreetAddr2.Dirty = value;
                _rtToCancelNtfcZip.Dirty = value;
                _rtToCancelTransDtTyp.Dirty = value;
                _sctyIstrmtDCTrstFeePct.Dirty = value;
                _sctyIstrmtDEAttyFeePct.Dirty = value;
                _sctyIstrmtLAAttyFeePct.Dirty = value;
                _sctyIstrmtLAMinAttyFeeAmt.Dirty = value;
                _sctyIstrmtMDTrstFeePct.Dirty = value;
                _sctyIstrmtMSTrstFeePct.Dirty = value;
                _sctyIstrmtNCAttyFeePct.Dirty = value;
                _sctyIstrmtNETrstFeePct.Dirty = value;
                _sctyIstrmtNVAssmFeeAmt.Dirty = value;
                _sctyIstrmtNVTrstFeePct.Dirty = value;
                _sctyIstrmtOKAssmFeeAmt.Dirty = value;
                _sctyIstrmtPOBoxAddr1.Dirty = value;
                _sctyIstrmtPOBoxAddr2.Dirty = value;
                _sctyIstrmtPrepByAdtlTxt.Dirty = value;
                _sctyIstrmtPrepByCoNm.Dirty = value;
                _sctyIstrmtPrepByCty.Dirty = value;
                _sctyIstrmtPrepByIndvNm.Dirty = value;
                _sctyIstrmtPrepByIndvTtl.Dirty = value;
                _sctyIstrmtPrepByPhone.Dirty = value;
                _sctyIstrmtPrepBySamePtyTypDesc.Dirty = value;
                _sctyIstrmtPrepByStCd.Dirty = value;
                _sctyIstrmtPrepByStreetAddr1.Dirty = value;
                _sctyIstrmtPrepByStreetAddr2.Dirty = value;
                _sctyIstrmtPrepByTxt.Dirty = value;
                _sctyIstrmtPrepByZip.Dirty = value;
                _sctyIstrmtTtlAdtlTxt.Dirty = value;
                _sctyIstrmtTtlAdtlTxtAbvTtl.Dirty = value;
                _sctyIstrmtVATrstFeePct.Dirty = value;
                _trst1Cnty.Dirty = value;
                _trst1Cty.Dirty = value;
                _trst1IndvBool.Dirty = value;
                _trst1Jrsdctn.Dirty = value;
                _trst1Nm.Dirty = value;
                _trst1OrgTyp.Dirty = value;
                _trst1Phone.Dirty = value;
                _trst1RsdtTxtDesc.Dirty = value;
                _trst1SamePtyTypDesc.Dirty = value;
                _trst1StCd.Dirty = value;
                _trst1StreetAddr1.Dirty = value;
                _trst1StreetAddr2.Dirty = value;
                _trst1Zip.Dirty = value;
                _trst2Cnty.Dirty = value;
                _trst2Cty.Dirty = value;
                _trst2IndvBool.Dirty = value;
                _trst2Jrsdctn.Dirty = value;
                _trst2Nm.Dirty = value;
                _trst2OrgTyp.Dirty = value;
                _trst2Phone.Dirty = value;
                _trst2RsdtTxtDesc.Dirty = value;
                _trst2SamePtyTypDesc.Dirty = value;
                _trst2StCd.Dirty = value;
                _trst2StreetAddr1.Dirty = value;
                _trst2StreetAddr2.Dirty = value;
                _trst2Zip.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}