using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocument : IClean
    {
        private Value<string> _allngToNtPayToJrsdctn;
        public string AllngToNtPayToJrsdctn { get { return _allngToNtPayToJrsdctn; } set { _allngToNtPayToJrsdctn = value; } }
        private Value<string> _allngToNtPayToOrdNm;
        public string AllngToNtPayToOrdNm { get { return _allngToNtPayToOrdNm; } set { _allngToNtPayToOrdNm = value; } }
        private Value<string> _allngToNtPayToOrgTyp;
        public string AllngToNtPayToOrgTyp { get { return _allngToNtPayToOrgTyp; } set { _allngToNtPayToOrgTyp = value; } }
        private Value<string> _allngToNtPayToScsrsClaus;
        public string AllngToNtPayToScsrsClaus { get { return _allngToNtPayToScsrsClaus; } set { _allngToNtPayToScsrsClaus = value; } }
        private Value<string> _allngToNtSignedByNm;
        public string AllngToNtSignedByNm { get { return _allngToNtSignedByNm; } set { _allngToNtSignedByNm = value; } }
        private Value<string> _allngToNtSignedByNm2;
        public string AllngToNtSignedByNm2 { get { return _allngToNtSignedByNm2; } set { _allngToNtSignedByNm2 = value; } }
        private Value<string> _allngToNtSignedByNm3;
        public string AllngToNtSignedByNm3 { get { return _allngToNtSignedByNm3; } set { _allngToNtSignedByNm3 = value; } }
        private Value<string> _allngToNtSignedByTtl;
        public string AllngToNtSignedByTtl { get { return _allngToNtSignedByTtl; } set { _allngToNtSignedByTtl = value; } }
        private Value<string> _allngToNtSignedByTtl2;
        public string AllngToNtSignedByTtl2 { get { return _allngToNtSignedByTtl2; } set { _allngToNtSignedByTtl2 = value; } }
        private Value<string> _allngToNtSignedByTtl3;
        public string AllngToNtSignedByTtl3 { get { return _allngToNtSignedByTtl3; } set { _allngToNtSignedByTtl3 = value; } }
        private Value<string> _allngToNtSignedByTyp;
        public string AllngToNtSignedByTyp { get { return _allngToNtSignedByTyp; } set { _allngToNtSignedByTyp = value; } }
        private Value<string> _allngToNtWithoutRcrse;
        public string AllngToNtWithoutRcrse { get { return _allngToNtWithoutRcrse; } set { _allngToNtWithoutRcrse = value; } }
        private Value<string> _apnLbl;
        public string ApnLbl { get { return _apnLbl; } set { _apnLbl = value; } }
        private Value<bool?> _asgnPrepByLblTxtDesc;
        public bool? AsgnPrepByLblTxtDesc { get { return _asgnPrepByLblTxtDesc; } set { _asgnPrepByLblTxtDesc = value; } }
        private Value<bool?> _asgnRecRtrnLblTxtDesc;
        public bool? AsgnRecRtrnLblTxtDesc { get { return _asgnRecRtrnLblTxtDesc; } set { _asgnRecRtrnLblTxtDesc = value; } }
        private Value<string> _benCty;
        public string BenCty { get { return _benCty; } set { _benCty = value; } }
        private Value<string> _benJrsdctn;
        public string BenJrsdctn { get { return _benJrsdctn; } set { _benJrsdctn = value; } }
        private Value<string> _benNm;
        public string BenNm { get { return _benNm; } set { _benNm = value; } }
        private Value<string> _benOrgTyp;
        public string BenOrgTyp { get { return _benOrgTyp; } set { _benOrgTyp = value; } }
        private Value<string> _benStCd;
        public string BenStCd { get { return _benStCd; } set { _benStCd = value; } }
        private Value<string> _benStreetAddr1;
        public string BenStreetAddr1 { get { return _benStreetAddr1; } set { _benStreetAddr1 = value; } }
        private Value<string> _benStreetAddr2;
        public string BenStreetAddr2 { get { return _benStreetAddr2; } set { _benStreetAddr2 = value; } }
        private Value<string> _benZip;
        public string BenZip { get { return _benZip; } set { _benZip = value; } }
        private Value<string> _closInstrLndCntcInfoCity;
        public string ClosInstrLndCntcInfoCity { get { return _closInstrLndCntcInfoCity; } set { _closInstrLndCntcInfoCity = value; } }
        private Value<string> _closInstrLndCntcInfoCoNm;
        public string ClosInstrLndCntcInfoCoNm { get { return _closInstrLndCntcInfoCoNm; } set { _closInstrLndCntcInfoCoNm = value; } }
        private Value<string> _closInstrLndCntcInfoSamePtyTypDesc;
        public string ClosInstrLndCntcInfoSamePtyTypDesc { get { return _closInstrLndCntcInfoSamePtyTypDesc; } set { _closInstrLndCntcInfoSamePtyTypDesc = value; } }
        private Value<string> _closInstrLndCntcInfoStCd;
        public string ClosInstrLndCntcInfoStCd { get { return _closInstrLndCntcInfoStCd; } set { _closInstrLndCntcInfoStCd = value; } }
        private Value<string> _closInstrLndCntcInfoStreetAddr1;
        public string ClosInstrLndCntcInfoStreetAddr1 { get { return _closInstrLndCntcInfoStreetAddr1; } set { _closInstrLndCntcInfoStreetAddr1 = value; } }
        private Value<string> _closInstrLndCntcInfoStreetAddr2;
        public string ClosInstrLndCntcInfoStreetAddr2 { get { return _closInstrLndCntcInfoStreetAddr2; } set { _closInstrLndCntcInfoStreetAddr2 = value; } }
        private Value<string> _closInstrLndCntcInfoZip;
        public string ClosInstrLndCntcInfoZip { get { return _closInstrLndCntcInfoZip; } set { _closInstrLndCntcInfoZip = value; } }
        private Value<bool?> _closInstrPrtInvLossPayee;
        public bool? ClosInstrPrtInvLossPayee { get { return _closInstrPrtInvLossPayee; } set { _closInstrPrtInvLossPayee = value; } }
        private Value<bool?> _closInstrStlmtAgtUseLndHud1;
        public bool? ClosInstrStlmtAgtUseLndHud1 { get { return _closInstrStlmtAgtUseLndHud1; } set { _closInstrStlmtAgtUseLndHud1 = value; } }
        private Value<string> _closInstrTtlPlcyTyp;
        public string ClosInstrTtlPlcyTyp { get { return _closInstrTtlPlcyTyp; } set { _closInstrTtlPlcyTyp = value; } }
        private Value<string> _emxmlVersionId;
        public string EmxmlVersionId { get { return _emxmlVersionId; } set { _emxmlVersionId = value; } }
        private Value<string> _exeClosDocDlvrdToCty;
        public string ExeClosDocDlvrdToCty { get { return _exeClosDocDlvrdToCty; } set { _exeClosDocDlvrdToCty = value; } }
        private Value<string> _exeClosDocDlvrdToMiscTxtDesc;
        public string ExeClosDocDlvrdToMiscTxtDesc { get { return _exeClosDocDlvrdToMiscTxtDesc; } set { _exeClosDocDlvrdToMiscTxtDesc = value; } }
        private Value<string> _exeClosDocDlvrdToNm;
        public string ExeClosDocDlvrdToNm { get { return _exeClosDocDlvrdToNm; } set { _exeClosDocDlvrdToNm = value; } }
        private Value<string> _exeClosDocDlvrdToSamePtyTypDesc;
        public string ExeClosDocDlvrdToSamePtyTypDesc { get { return _exeClosDocDlvrdToSamePtyTypDesc; } set { _exeClosDocDlvrdToSamePtyTypDesc = value; } }
        private Value<string> _exeClosDocDlvrdToStCd;
        public string ExeClosDocDlvrdToStCd { get { return _exeClosDocDlvrdToStCd; } set { _exeClosDocDlvrdToStCd = value; } }
        private Value<string> _exeClosDocDlvrdToStreetAddr1;
        public string ExeClosDocDlvrdToStreetAddr1 { get { return _exeClosDocDlvrdToStreetAddr1; } set { _exeClosDocDlvrdToStreetAddr1 = value; } }
        private Value<string> _exeClosDocDlvrdToStreetAddr2;
        public string ExeClosDocDlvrdToStreetAddr2 { get { return _exeClosDocDlvrdToStreetAddr2; } set { _exeClosDocDlvrdToStreetAddr2 = value; } }
        private Value<string> _exeClosDocDlvrdToZip;
        public string ExeClosDocDlvrdToZip { get { return _exeClosDocDlvrdToZip; } set { _exeClosDocDlvrdToZip = value; } }
        private Value<string> _exeClosDocExprDt;
        public string ExeClosDocExprDt { get { return _exeClosDocExprDt; } set { _exeClosDocExprDt = value; } }
        private Value<string> _exeClosDocToBeRtrnd;
        public string ExeClosDocToBeRtrnd { get { return _exeClosDocToBeRtrnd; } set { _exeClosDocToBeRtrnd = value; } }
        private Value<string> _exeClosDocToBeRtrndHrs;
        public string ExeClosDocToBeRtrndHrs { get { return _exeClosDocToBeRtrndHrs; } set { _exeClosDocToBeRtrndHrs = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToAddlLine1;
        public string FnlTtlePcyRecDocsSentToAddlLine1 { get { return _fnlTtlePcyRecDocsSentToAddlLine1; } set { _fnlTtlePcyRecDocsSentToAddlLine1 = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToAddlLine2;
        public string FnlTtlePcyRecDocsSentToAddlLine2 { get { return _fnlTtlePcyRecDocsSentToAddlLine2; } set { _fnlTtlePcyRecDocsSentToAddlLine2 = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToCty;
        public string FnlTtlePcyRecDocsSentToCty { get { return _fnlTtlePcyRecDocsSentToCty; } set { _fnlTtlePcyRecDocsSentToCty = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToNm;
        public string FnlTtlePcyRecDocsSentToNm { get { return _fnlTtlePcyRecDocsSentToNm; } set { _fnlTtlePcyRecDocsSentToNm = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToSamePtyTypDesc;
        public string FnlTtlePcyRecDocsSentToSamePtyTypDesc { get { return _fnlTtlePcyRecDocsSentToSamePtyTypDesc; } set { _fnlTtlePcyRecDocsSentToSamePtyTypDesc = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToStcd;
        public string FnlTtlePcyRecDocsSentToStcd { get { return _fnlTtlePcyRecDocsSentToStcd; } set { _fnlTtlePcyRecDocsSentToStcd = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToStreetAddr1;
        public string FnlTtlePcyRecDocsSentToStreetAddr1 { get { return _fnlTtlePcyRecDocsSentToStreetAddr1; } set { _fnlTtlePcyRecDocsSentToStreetAddr1 = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToStreetAddr2;
        public string FnlTtlePcyRecDocsSentToStreetAddr2 { get { return _fnlTtlePcyRecDocsSentToStreetAddr2; } set { _fnlTtlePcyRecDocsSentToStreetAddr2 = value; } }
        private Value<string> _fnlTtlePcyRecDocsSentToZip;
        public string FnlTtlePcyRecDocsSentToZip { get { return _fnlTtlePcyRecDocsSentToZip; } set { _fnlTtlePcyRecDocsSentToZip = value; } }
        private Value<string> _hazInsurEndsmtMailToAdtlTxt;
        public string HazInsurEndsmtMailToAdtlTxt { get { return _hazInsurEndsmtMailToAdtlTxt; } set { _hazInsurEndsmtMailToAdtlTxt = value; } }
        private Value<string> _hazInsurEndsmtMailToCty;
        public string HazInsurEndsmtMailToCty { get { return _hazInsurEndsmtMailToCty; } set { _hazInsurEndsmtMailToCty = value; } }
        private Value<string> _hazInsurEndsmtMailToNm;
        public string HazInsurEndsmtMailToNm { get { return _hazInsurEndsmtMailToNm; } set { _hazInsurEndsmtMailToNm = value; } }
        private Value<string> _hazInsurEndsmtMailToStCd;
        public string HazInsurEndsmtMailToStCd { get { return _hazInsurEndsmtMailToStCd; } set { _hazInsurEndsmtMailToStCd = value; } }
        private Value<string> _hazInsurEndsmtMailToStreetAddr1;
        public string HazInsurEndsmtMailToStreetAddr1 { get { return _hazInsurEndsmtMailToStreetAddr1; } set { _hazInsurEndsmtMailToStreetAddr1 = value; } }
        private Value<string> _hazInsurEndsmtMailToStreetAddr2;
        public string HazInsurEndsmtMailToStreetAddr2 { get { return _hazInsurEndsmtMailToStreetAddr2; } set { _hazInsurEndsmtMailToStreetAddr2 = value; } }
        private Value<string> _hazInsurEndsmtMailToZip;
        public string HazInsurEndsmtMailToZip { get { return _hazInsurEndsmtMailToZip; } set { _hazInsurEndsmtMailToZip = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _mersAdtlCity;
        public string MersAdtlCity { get { return _mersAdtlCity; } set { _mersAdtlCity = value; } }
        private Value<string> _mersAdtlStCd;
        public string MersAdtlStCd { get { return _mersAdtlStCd; } set { _mersAdtlStCd = value; } }
        private Value<string> _mersAdtlStreetAddr1;
        public string MersAdtlStreetAddr1 { get { return _mersAdtlStreetAddr1; } set { _mersAdtlStreetAddr1 = value; } }
        private Value<string> _mersAdtlStreetAddr2;
        public string MersAdtlStreetAddr2 { get { return _mersAdtlStreetAddr2; } set { _mersAdtlStreetAddr2 = value; } }
        private Value<string> _mersAdtlZip;
        public string MersAdtlZip { get { return _mersAdtlZip; } set { _mersAdtlZip = value; } }
        private Value<string> _mersCty;
        public string MersCty { get { return _mersCty; } set { _mersCty = value; } }
        private Value<string> _mersJrsdctn;
        public string MersJrsdctn { get { return _mersJrsdctn; } set { _mersJrsdctn = value; } }
        private Value<string> _mersName;
        public string MersName { get { return _mersName; } set { _mersName = value; } }
        private Value<string> _mersOrgTyp;
        public string MersOrgTyp { get { return _mersOrgTyp; } set { _mersOrgTyp = value; } }
        private Value<string> _mersPhoneNum;
        public string MersPhoneNum { get { return _mersPhoneNum; } set { _mersPhoneNum = value; } }
        private Value<string> _mersStCd;
        public string MersStCd { get { return _mersStCd; } set { _mersStCd = value; } }
        private Value<string> _mersStreetAddr1;
        public string MersStreetAddr1 { get { return _mersStreetAddr1; } set { _mersStreetAddr1 = value; } }
        private Value<string> _mersStreetAddr2;
        public string MersStreetAddr2 { get { return _mersStreetAddr2; } set { _mersStreetAddr2 = value; } }
        private Value<string> _mersZip;
        public string MersZip { get { return _mersZip; } set { _mersZip = value; } }
        private Value<string> _ntEndrsmtPayToJrsdctn;
        public string NtEndrsmtPayToJrsdctn { get { return _ntEndrsmtPayToJrsdctn; } set { _ntEndrsmtPayToJrsdctn = value; } }
        private Value<string> _ntEndrsmtPayToOrdNm;
        public string NtEndrsmtPayToOrdNm { get { return _ntEndrsmtPayToOrdNm; } set { _ntEndrsmtPayToOrdNm = value; } }
        private Value<string> _ntEndrsmtPayToOrgTyp;
        public string NtEndrsmtPayToOrgTyp { get { return _ntEndrsmtPayToOrgTyp; } set { _ntEndrsmtPayToOrgTyp = value; } }
        private Value<string> _ntEndrsmtPayToScsrsClaus;
        public string NtEndrsmtPayToScsrsClaus { get { return _ntEndrsmtPayToScsrsClaus; } set { _ntEndrsmtPayToScsrsClaus = value; } }
        private Value<string> _ntEndrsmtSgndBy1MiscTxt;
        public string NtEndrsmtSgndBy1MiscTxt { get { return _ntEndrsmtSgndBy1MiscTxt; } set { _ntEndrsmtSgndBy1MiscTxt = value; } }
        private Value<string> _ntEndrsmtSgndBy2MiscTxt;
        public string NtEndrsmtSgndBy2MiscTxt { get { return _ntEndrsmtSgndBy2MiscTxt; } set { _ntEndrsmtSgndBy2MiscTxt = value; } }
        private Value<string> _ntEndrsmtSignedByNm;
        public string NtEndrsmtSignedByNm { get { return _ntEndrsmtSignedByNm; } set { _ntEndrsmtSignedByNm = value; } }
        private Value<string> _ntEndrsmtSignedByNm2;
        public string NtEndrsmtSignedByNm2 { get { return _ntEndrsmtSignedByNm2; } set { _ntEndrsmtSignedByNm2 = value; } }
        private Value<string> _ntEndrsmtSignedByNm3;
        public string NtEndrsmtSignedByNm3 { get { return _ntEndrsmtSignedByNm3; } set { _ntEndrsmtSignedByNm3 = value; } }
        private Value<string> _ntEndrsmtSignedByTtl;
        public string NtEndrsmtSignedByTtl { get { return _ntEndrsmtSignedByTtl; } set { _ntEndrsmtSignedByTtl = value; } }
        private Value<string> _ntEndrsmtSignedByTtl2;
        public string NtEndrsmtSignedByTtl2 { get { return _ntEndrsmtSignedByTtl2; } set { _ntEndrsmtSignedByTtl2 = value; } }
        private Value<string> _ntEndrsmtSignedByTtl3;
        public string NtEndrsmtSignedByTtl3 { get { return _ntEndrsmtSignedByTtl3; } set { _ntEndrsmtSignedByTtl3 = value; } }
        private Value<string> _ntEndrsmtSignedByTyp;
        public string NtEndrsmtSignedByTyp { get { return _ntEndrsmtSignedByTyp; } set { _ntEndrsmtSignedByTyp = value; } }
        private Value<string> _ntEndrsmtWithoutRcrse;
        public string NtEndrsmtWithoutRcrse { get { return _ntEndrsmtWithoutRcrse; } set { _ntEndrsmtWithoutRcrse = value; } }
        private Value<string> _ntEndsmtThrdPtyAddr1;
        public string NtEndsmtThrdPtyAddr1 { get { return _ntEndsmtThrdPtyAddr1; } set { _ntEndsmtThrdPtyAddr1 = value; } }
        private Value<string> _ntEndsmtThrdPtyAddr2;
        public string NtEndsmtThrdPtyAddr2 { get { return _ntEndsmtThrdPtyAddr2; } set { _ntEndsmtThrdPtyAddr2 = value; } }
        private Value<string> _ntEndsmtThrdPtyCty;
        public string NtEndsmtThrdPtyCty { get { return _ntEndsmtThrdPtyCty; } set { _ntEndsmtThrdPtyCty = value; } }
        private Value<string> _ntEndsmtThrdPtyJrsdctn;
        public string NtEndsmtThrdPtyJrsdctn { get { return _ntEndsmtThrdPtyJrsdctn; } set { _ntEndsmtThrdPtyJrsdctn = value; } }
        private Value<string> _ntEndsmtThrdPtyName;
        public string NtEndsmtThrdPtyName { get { return _ntEndsmtThrdPtyName; } set { _ntEndsmtThrdPtyName = value; } }
        private Value<string> _ntEndsmtThrdPtyOrgTyp;
        public string NtEndsmtThrdPtyOrgTyp { get { return _ntEndsmtThrdPtyOrgTyp; } set { _ntEndsmtThrdPtyOrgTyp = value; } }
        private Value<string> _ntEndsmtThrdPtyPhone;
        public string NtEndsmtThrdPtyPhone { get { return _ntEndsmtThrdPtyPhone; } set { _ntEndsmtThrdPtyPhone = value; } }
        private Value<string> _ntEndsmtThrdPtyScsrClaus;
        public string NtEndsmtThrdPtyScsrClaus { get { return _ntEndsmtThrdPtyScsrClaus; } set { _ntEndsmtThrdPtyScsrClaus = value; } }
        private Value<string> _ntEndsmtThrdPtyStCd;
        public string NtEndsmtThrdPtyStCd { get { return _ntEndsmtThrdPtyStCd; } set { _ntEndsmtThrdPtyStCd = value; } }
        private Value<string> _ntEndsmtThrdPtyZip;
        public string NtEndsmtThrdPtyZip { get { return _ntEndsmtThrdPtyZip; } set { _ntEndsmtThrdPtyZip = value; } }
        private Value<string> _ntPayToAdtlTxt;
        public string NtPayToAdtlTxt { get { return _ntPayToAdtlTxt; } set { _ntPayToAdtlTxt = value; } }
        private Value<string> _ntPayToCty;
        public string NtPayToCty { get { return _ntPayToCty; } set { _ntPayToCty = value; } }
        private Value<string> _ntPayToJrsdctn;
        public string NtPayToJrsdctn { get { return _ntPayToJrsdctn; } set { _ntPayToJrsdctn = value; } }
        private Value<string> _ntPayToNm;
        public string NtPayToNm { get { return _ntPayToNm; } set { _ntPayToNm = value; } }
        private Value<string> _ntPayToOrgTyp;
        public string NtPayToOrgTyp { get { return _ntPayToOrgTyp; } set { _ntPayToOrgTyp = value; } }
        private Value<string> _ntPayToStCd;
        public string NtPayToStCd { get { return _ntPayToStCd; } set { _ntPayToStCd = value; } }
        private Value<string> _ntPayToStreetAddr1;
        public string NtPayToStreetAddr1 { get { return _ntPayToStreetAddr1; } set { _ntPayToStreetAddr1 = value; } }
        private Value<string> _ntPayToStreetAddr2;
        public string NtPayToStreetAddr2 { get { return _ntPayToStreetAddr2; } set { _ntPayToStreetAddr2 = value; } }
        private Value<string> _ntPayToZip;
        public string NtPayToZip { get { return _ntPayToZip; } set { _ntPayToZip = value; } }
        private Value<string> _pmtCpn2PayToAdtlTxt;
        public string PmtCpn2PayToAdtlTxt { get { return _pmtCpn2PayToAdtlTxt; } set { _pmtCpn2PayToAdtlTxt = value; } }
        private Value<string> _pmtCpn2PayToAdtlTxt2;
        public string PmtCpn2PayToAdtlTxt2 { get { return _pmtCpn2PayToAdtlTxt2; } set { _pmtCpn2PayToAdtlTxt2 = value; } }
        private Value<string> _pmtCpn2PayToCty;
        public string PmtCpn2PayToCty { get { return _pmtCpn2PayToCty; } set { _pmtCpn2PayToCty = value; } }
        private Value<string> _pmtCpn2PayToNm;
        public string PmtCpn2PayToNm { get { return _pmtCpn2PayToNm; } set { _pmtCpn2PayToNm = value; } }
        private Value<string> _pmtCpn2PayToStCd;
        public string PmtCpn2PayToStCd { get { return _pmtCpn2PayToStCd; } set { _pmtCpn2PayToStCd = value; } }
        private Value<string> _pmtCpn2PayToStreetAddr1;
        public string PmtCpn2PayToStreetAddr1 { get { return _pmtCpn2PayToStreetAddr1; } set { _pmtCpn2PayToStreetAddr1 = value; } }
        private Value<string> _pmtCpn2PayToStreetAddr2;
        public string PmtCpn2PayToStreetAddr2 { get { return _pmtCpn2PayToStreetAddr2; } set { _pmtCpn2PayToStreetAddr2 = value; } }
        private Value<string> _pmtCpn2PayToZip;
        public string PmtCpn2PayToZip { get { return _pmtCpn2PayToZip; } set { _pmtCpn2PayToZip = value; } }
        private Value<string> _pmtCpnPayToAdtlTxt;
        public string PmtCpnPayToAdtlTxt { get { return _pmtCpnPayToAdtlTxt; } set { _pmtCpnPayToAdtlTxt = value; } }
        private Value<string> _pmtCpnPayToAdtlTxt2;
        public string PmtCpnPayToAdtlTxt2 { get { return _pmtCpnPayToAdtlTxt2; } set { _pmtCpnPayToAdtlTxt2 = value; } }
        private Value<string> _pmtCpnPayToCty;
        public string PmtCpnPayToCty { get { return _pmtCpnPayToCty; } set { _pmtCpnPayToCty = value; } }
        private Value<string> _pmtCpnPayToNm;
        public string PmtCpnPayToNm { get { return _pmtCpnPayToNm; } set { _pmtCpnPayToNm = value; } }
        private Value<string> _pmtCpnPayToStCd;
        public string PmtCpnPayToStCd { get { return _pmtCpnPayToStCd; } set { _pmtCpnPayToStCd = value; } }
        private Value<string> _pmtCpnPayToStreetAddr1;
        public string PmtCpnPayToStreetAddr1 { get { return _pmtCpnPayToStreetAddr1; } set { _pmtCpnPayToStreetAddr1 = value; } }
        private Value<string> _pmtCpnPayToStreetAddr2;
        public string PmtCpnPayToStreetAddr2 { get { return _pmtCpnPayToStreetAddr2; } set { _pmtCpnPayToStreetAddr2 = value; } }
        private Value<string> _pmtCpnPayToZip;
        public string PmtCpnPayToZip { get { return _pmtCpnPayToZip; } set { _pmtCpnPayToZip = value; } }
        private Value<string> _prtAdtlDateHud1;
        public string PrtAdtlDateHud1 { get { return _prtAdtlDateHud1; } set { _prtAdtlDateHud1 = value; } }
        private Value<bool?> _prtAllngToNtBool;
        public bool? PrtAllngToNtBool { get { return _prtAllngToNtBool; } set { _prtAllngToNtBool = value; } }
        private Value<bool?> _prtCorpMsgAsgnBool;
        public bool? PrtCorpMsgAsgnBool { get { return _prtCorpMsgAsgnBool; } set { _prtCorpMsgAsgnBool = value; } }
        private Value<string> _prtDocDtSctyIstrmtNtryAprncDt;
        public string PrtDocDtSctyIstrmtNtryAprncDt { get { return _prtDocDtSctyIstrmtNtryAprncDt; } set { _prtDocDtSctyIstrmtNtryAprncDt = value; } }
        private Value<bool?> _prtIndxTilBool;
        public bool? PrtIndxTilBool { get { return _prtIndxTilBool; } set { _prtIndxTilBool = value; } }
        private Value<bool?> _prtInitBlckNtBool;
        public bool? PrtInitBlckNtBool { get { return _prtInitBlckNtBool; } set { _prtInitBlckNtBool = value; } }
        private Value<bool?> _prtInitBlckSctyIstrmtBool;
        public bool? PrtInitBlckSctyIstrmtBool { get { return _prtInitBlckSctyIstrmtBool; } set { _prtInitBlckSctyIstrmtBool = value; } }
        private Value<bool?> _prtInvLoanNumBool;
        public bool? PrtInvLoanNumBool { get { return _prtInvLoanNumBool; } set { _prtInvLoanNumBool = value; } }
        private Value<bool?> _prtInvLoanNumPmtCpn2Ind;
        public bool? PrtInvLoanNumPmtCpn2Ind { get { return _prtInvLoanNumPmtCpn2Ind; } set { _prtInvLoanNumPmtCpn2Ind = value; } }
        private Value<bool?> _prtInvLoanNumPmtCpnInd;
        public bool? PrtInvLoanNumPmtCpnInd { get { return _prtInvLoanNumPmtCpnInd; } set { _prtInvLoanNumPmtCpnInd = value; } }
        private Value<bool?> _prtInvLossPayeeHazInsurDisBool;
        public bool? PrtInvLossPayeeHazInsurDisBool { get { return _prtInvLossPayeeHazInsurDisBool; } set { _prtInvLossPayeeHazInsurDisBool = value; } }
        private Value<bool?> _prtLoanNumDeedBool;
        public bool? PrtLoanNumDeedBool { get { return _prtLoanNumDeedBool; } set { _prtLoanNumDeedBool = value; } }
        private Value<bool?> _prtNtEndsmtBool;
        public bool? PrtNtEndsmtBool { get { return _prtNtEndsmtBool; } set { _prtNtEndsmtBool = value; } }
        private Value<bool?> _prtNtPayToCorpMsgBool;
        public bool? PrtNtPayToCorpMsgBool { get { return _prtNtPayToCorpMsgBool; } set { _prtNtPayToCorpMsgBool = value; } }
        private Value<bool?> _prtScsrsClausClosInstBool;
        public bool? PrtScsrsClausClosInstBool { get { return _prtScsrsClausClosInstBool; } set { _prtScsrsClausClosInstBool = value; } }
        private Value<bool?> _prtScsrsClausHazInsurDisBool;
        public bool? PrtScsrsClausHazInsurDisBool { get { return _prtScsrsClausHazInsurDisBool; } set { _prtScsrsClausHazInsurDisBool = value; } }
        private Value<bool?> _prtScsrsClausHazInsurLtrBool;
        public bool? PrtScsrsClausHazInsurLtrBool { get { return _prtScsrsClausHazInsurLtrBool; } set { _prtScsrsClausHazInsurLtrBool = value; } }
        private Value<bool?> _prtScsrsClausPmtCpnBool;
        public bool? PrtScsrsClausPmtCpnBool { get { return _prtScsrsClausPmtCpnBool; } set { _prtScsrsClausPmtCpnBool = value; } }
        private Value<bool?> _prtSctyIstrmtCorpMsgBool;
        public bool? PrtSctyIstrmtCorpMsgBool { get { return _prtSctyIstrmtCorpMsgBool; } set { _prtSctyIstrmtCorpMsgBool = value; } }
        private Value<string> _recRtrnAttnLnNmTxtDesc;
        public string RecRtrnAttnLnNmTxtDesc { get { return _recRtrnAttnLnNmTxtDesc; } set { _recRtrnAttnLnNmTxtDesc = value; } }
        private Value<string> _recRtrnCty;
        public string RecRtrnCty { get { return _recRtrnCty; } set { _recRtrnCty = value; } }
        private Value<string> _recRtrnLblTxtDesc;
        public string RecRtrnLblTxtDesc { get { return _recRtrnLblTxtDesc; } set { _recRtrnLblTxtDesc = value; } }
        private Value<string> _recRtrnNm;
        public string RecRtrnNm { get { return _recRtrnNm; } set { _recRtrnNm = value; } }
        private Value<string> _recRtrnNmSamePtyTypDesc;
        public string RecRtrnNmSamePtyTypDesc { get { return _recRtrnNmSamePtyTypDesc; } set { _recRtrnNmSamePtyTypDesc = value; } }
        private Value<string> _recRtrnPhoneNum;
        public string RecRtrnPhoneNum { get { return _recRtrnPhoneNum; } set { _recRtrnPhoneNum = value; } }
        private Value<string> _recRtrnStCd;
        public string RecRtrnStCd { get { return _recRtrnStCd; } set { _recRtrnStCd = value; } }
        private Value<string> _recRtrnStreetAddr1;
        public string RecRtrnStreetAddr1 { get { return _recRtrnStreetAddr1; } set { _recRtrnStreetAddr1 = value; } }
        private Value<string> _recRtrnStreetAddr2;
        public string RecRtrnStreetAddr2 { get { return _recRtrnStreetAddr2; } set { _recRtrnStreetAddr2 = value; } }
        private Value<string> _recRtrnTollFreePhoneNum;
        public string RecRtrnTollFreePhoneNum { get { return _recRtrnTollFreePhoneNum; } set { _recRtrnTollFreePhoneNum = value; } }
        private Value<string> _recRtrnZip;
        public string RecRtrnZip { get { return _recRtrnZip; } set { _recRtrnZip = value; } }
        private Value<bool?> _rtrnExeClosPkgToLndBrchBool;
        public bool? RtrnExeClosPkgToLndBrchBool { get { return _rtrnExeClosPkgToLndBrchBool; } set { _rtrnExeClosPkgToLndBrchBool = value; } }
        private Value<string> _rtToCancelNtfcAdtlTxt;
        public string RtToCancelNtfcAdtlTxt { get { return _rtToCancelNtfcAdtlTxt; } set { _rtToCancelNtfcAdtlTxt = value; } }
        private Value<string> _rtToCancelNtfcCty;
        public string RtToCancelNtfcCty { get { return _rtToCancelNtfcCty; } set { _rtToCancelNtfcCty = value; } }
        private Value<string> _rtToCancelNtfcEmail;
        public string RtToCancelNtfcEmail { get { return _rtToCancelNtfcEmail; } set { _rtToCancelNtfcEmail = value; } }
        private Value<string> _rtToCancelNtfcFax;
        public string RtToCancelNtfcFax { get { return _rtToCancelNtfcFax; } set { _rtToCancelNtfcFax = value; } }
        private Value<string> _rtToCancelNtfcNm;
        public string RtToCancelNtfcNm { get { return _rtToCancelNtfcNm; } set { _rtToCancelNtfcNm = value; } }
        private Value<string> _rtToCancelNtfcStCd;
        public string RtToCancelNtfcStCd { get { return _rtToCancelNtfcStCd; } set { _rtToCancelNtfcStCd = value; } }
        private Value<string> _rtToCancelNtfcStreetAddr1;
        public string RtToCancelNtfcStreetAddr1 { get { return _rtToCancelNtfcStreetAddr1; } set { _rtToCancelNtfcStreetAddr1 = value; } }
        private Value<string> _rtToCancelNtfcStreetAddr2;
        public string RtToCancelNtfcStreetAddr2 { get { return _rtToCancelNtfcStreetAddr2; } set { _rtToCancelNtfcStreetAddr2 = value; } }
        private Value<string> _rtToCancelNtfcZip;
        public string RtToCancelNtfcZip { get { return _rtToCancelNtfcZip; } set { _rtToCancelNtfcZip = value; } }
        private Value<string> _rtToCancelTransDtTyp;
        public string RtToCancelTransDtTyp { get { return _rtToCancelTransDtTyp; } set { _rtToCancelTransDtTyp = value; } }
        private Value<string> _sctyIstrmtDCTrstFeePct;
        public string SctyIstrmtDCTrstFeePct { get { return _sctyIstrmtDCTrstFeePct; } set { _sctyIstrmtDCTrstFeePct = value; } }
        private Value<string> _sctyIstrmtDEAttyFeePct;
        public string SctyIstrmtDEAttyFeePct { get { return _sctyIstrmtDEAttyFeePct; } set { _sctyIstrmtDEAttyFeePct = value; } }
        private Value<decimal?> _sctyIstrmtLAAttyFeePct;
        public decimal? SctyIstrmtLAAttyFeePct { get { return _sctyIstrmtLAAttyFeePct; } set { _sctyIstrmtLAAttyFeePct = value; } }
        private Value<decimal?> _sctyIstrmtLAMinAttyFeeAmt;
        public decimal? SctyIstrmtLAMinAttyFeeAmt { get { return _sctyIstrmtLAMinAttyFeeAmt; } set { _sctyIstrmtLAMinAttyFeeAmt = value; } }
        private Value<string> _sctyIstrmtMDTrstFeePct;
        public string SctyIstrmtMDTrstFeePct { get { return _sctyIstrmtMDTrstFeePct; } set { _sctyIstrmtMDTrstFeePct = value; } }
        private Value<string> _sctyIstrmtMSTrstFeePct;
        public string SctyIstrmtMSTrstFeePct { get { return _sctyIstrmtMSTrstFeePct; } set { _sctyIstrmtMSTrstFeePct = value; } }
        private Value<string> _sctyIstrmtNCAttyFeePct;
        public string SctyIstrmtNCAttyFeePct { get { return _sctyIstrmtNCAttyFeePct; } set { _sctyIstrmtNCAttyFeePct = value; } }
        private Value<string> _sctyIstrmtNETrstFeePct;
        public string SctyIstrmtNETrstFeePct { get { return _sctyIstrmtNETrstFeePct; } set { _sctyIstrmtNETrstFeePct = value; } }
        private Value<string> _sctyIstrmtNVAssmFeeAmt;
        public string SctyIstrmtNVAssmFeeAmt { get { return _sctyIstrmtNVAssmFeeAmt; } set { _sctyIstrmtNVAssmFeeAmt = value; } }
        private Value<string> _sctyIstrmtNVTrstFeePct;
        public string SctyIstrmtNVTrstFeePct { get { return _sctyIstrmtNVTrstFeePct; } set { _sctyIstrmtNVTrstFeePct = value; } }
        private Value<string> _sctyIstrmtOKAssmFeeAmt;
        public string SctyIstrmtOKAssmFeeAmt { get { return _sctyIstrmtOKAssmFeeAmt; } set { _sctyIstrmtOKAssmFeeAmt = value; } }
        private Value<string> _sctyIstrmtPOBoxAddr1;
        public string SctyIstrmtPOBoxAddr1 { get { return _sctyIstrmtPOBoxAddr1; } set { _sctyIstrmtPOBoxAddr1 = value; } }
        private Value<string> _sctyIstrmtPOBoxAddr2;
        public string SctyIstrmtPOBoxAddr2 { get { return _sctyIstrmtPOBoxAddr2; } set { _sctyIstrmtPOBoxAddr2 = value; } }
        private Value<string> _sctyIstrmtPrepByAdtlTxt;
        public string SctyIstrmtPrepByAdtlTxt { get { return _sctyIstrmtPrepByAdtlTxt; } set { _sctyIstrmtPrepByAdtlTxt = value; } }
        private Value<string> _sctyIstrmtPrepByCoNm;
        public string SctyIstrmtPrepByCoNm { get { return _sctyIstrmtPrepByCoNm; } set { _sctyIstrmtPrepByCoNm = value; } }
        private Value<string> _sctyIstrmtPrepByCty;
        public string SctyIstrmtPrepByCty { get { return _sctyIstrmtPrepByCty; } set { _sctyIstrmtPrepByCty = value; } }
        private Value<string> _sctyIstrmtPrepByIndvNm;
        public string SctyIstrmtPrepByIndvNm { get { return _sctyIstrmtPrepByIndvNm; } set { _sctyIstrmtPrepByIndvNm = value; } }
        private Value<string> _sctyIstrmtPrepByIndvTtl;
        public string SctyIstrmtPrepByIndvTtl { get { return _sctyIstrmtPrepByIndvTtl; } set { _sctyIstrmtPrepByIndvTtl = value; } }
        private Value<string> _sctyIstrmtPrepByPhone;
        public string SctyIstrmtPrepByPhone { get { return _sctyIstrmtPrepByPhone; } set { _sctyIstrmtPrepByPhone = value; } }
        private Value<string> _sctyIstrmtPrepBySamePtyTypDesc;
        public string SctyIstrmtPrepBySamePtyTypDesc { get { return _sctyIstrmtPrepBySamePtyTypDesc; } set { _sctyIstrmtPrepBySamePtyTypDesc = value; } }
        private Value<string> _sctyIstrmtPrepByStCd;
        public string SctyIstrmtPrepByStCd { get { return _sctyIstrmtPrepByStCd; } set { _sctyIstrmtPrepByStCd = value; } }
        private Value<string> _sctyIstrmtPrepByStreetAddr1;
        public string SctyIstrmtPrepByStreetAddr1 { get { return _sctyIstrmtPrepByStreetAddr1; } set { _sctyIstrmtPrepByStreetAddr1 = value; } }
        private Value<string> _sctyIstrmtPrepByStreetAddr2;
        public string SctyIstrmtPrepByStreetAddr2 { get { return _sctyIstrmtPrepByStreetAddr2; } set { _sctyIstrmtPrepByStreetAddr2 = value; } }
        private Value<string> _sctyIstrmtPrepByTxt;
        public string SctyIstrmtPrepByTxt { get { return _sctyIstrmtPrepByTxt; } set { _sctyIstrmtPrepByTxt = value; } }
        private Value<string> _sctyIstrmtPrepByZip;
        public string SctyIstrmtPrepByZip { get { return _sctyIstrmtPrepByZip; } set { _sctyIstrmtPrepByZip = value; } }
        private Value<string> _sctyIstrmtTtlAdtlTxt;
        public string SctyIstrmtTtlAdtlTxt { get { return _sctyIstrmtTtlAdtlTxt; } set { _sctyIstrmtTtlAdtlTxt = value; } }
        private Value<bool?> _sctyIstrmtTtlAdtlTxtAbvTtl;
        public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get { return _sctyIstrmtTtlAdtlTxtAbvTtl; } set { _sctyIstrmtTtlAdtlTxtAbvTtl = value; } }
        private Value<string> _sctyIstrmtVATrstFeePct;
        public string SctyIstrmtVATrstFeePct { get { return _sctyIstrmtVATrstFeePct; } set { _sctyIstrmtVATrstFeePct = value; } }
        private Value<string> _trst1Cnty;
        public string Trst1Cnty { get { return _trst1Cnty; } set { _trst1Cnty = value; } }
        private Value<string> _trst1Cty;
        public string Trst1Cty { get { return _trst1Cty; } set { _trst1Cty = value; } }
        private Value<bool?> _trst1IndvBool;
        public bool? Trst1IndvBool { get { return _trst1IndvBool; } set { _trst1IndvBool = value; } }
        private Value<string> _trst1Jrsdctn;
        public string Trst1Jrsdctn { get { return _trst1Jrsdctn; } set { _trst1Jrsdctn = value; } }
        private Value<string> _trst1Nm;
        public string Trst1Nm { get { return _trst1Nm; } set { _trst1Nm = value; } }
        private Value<string> _trst1OrgTyp;
        public string Trst1OrgTyp { get { return _trst1OrgTyp; } set { _trst1OrgTyp = value; } }
        private Value<string> _trst1Phone;
        public string Trst1Phone { get { return _trst1Phone; } set { _trst1Phone = value; } }
        private Value<string> _trst1RsdtTxtDesc;
        public string Trst1RsdtTxtDesc { get { return _trst1RsdtTxtDesc; } set { _trst1RsdtTxtDesc = value; } }
        private Value<string> _trst1SamePtyTypDesc;
        public string Trst1SamePtyTypDesc { get { return _trst1SamePtyTypDesc; } set { _trst1SamePtyTypDesc = value; } }
        private Value<string> _trst1StCd;
        public string Trst1StCd { get { return _trst1StCd; } set { _trst1StCd = value; } }
        private Value<string> _trst1StreetAddr1;
        public string Trst1StreetAddr1 { get { return _trst1StreetAddr1; } set { _trst1StreetAddr1 = value; } }
        private Value<string> _trst1StreetAddr2;
        public string Trst1StreetAddr2 { get { return _trst1StreetAddr2; } set { _trst1StreetAddr2 = value; } }
        private Value<string> _trst1Zip;
        public string Trst1Zip { get { return _trst1Zip; } set { _trst1Zip = value; } }
        private Value<string> _trst2Cnty;
        public string Trst2Cnty { get { return _trst2Cnty; } set { _trst2Cnty = value; } }
        private Value<string> _trst2Cty;
        public string Trst2Cty { get { return _trst2Cty; } set { _trst2Cty = value; } }
        private Value<bool?> _trst2IndvBool;
        public bool? Trst2IndvBool { get { return _trst2IndvBool; } set { _trst2IndvBool = value; } }
        private Value<string> _trst2Jrsdctn;
        public string Trst2Jrsdctn { get { return _trst2Jrsdctn; } set { _trst2Jrsdctn = value; } }
        private Value<string> _trst2Nm;
        public string Trst2Nm { get { return _trst2Nm; } set { _trst2Nm = value; } }
        private Value<string> _trst2OrgTyp;
        public string Trst2OrgTyp { get { return _trst2OrgTyp; } set { _trst2OrgTyp = value; } }
        private Value<string> _trst2Phone;
        public string Trst2Phone { get { return _trst2Phone; } set { _trst2Phone = value; } }
        private Value<string> _trst2RsdtTxtDesc;
        public string Trst2RsdtTxtDesc { get { return _trst2RsdtTxtDesc; } set { _trst2RsdtTxtDesc = value; } }
        private Value<string> _trst2SamePtyTypDesc;
        public string Trst2SamePtyTypDesc { get { return _trst2SamePtyTypDesc; } set { _trst2SamePtyTypDesc = value; } }
        private Value<string> _trst2StCd;
        public string Trst2StCd { get { return _trst2StCd; } set { _trst2StCd = value; } }
        private Value<string> _trst2StreetAddr1;
        public string Trst2StreetAddr1 { get { return _trst2StreetAddr1; } set { _trst2StreetAddr1 = value; } }
        private Value<string> _trst2StreetAddr2;
        public string Trst2StreetAddr2 { get { return _trst2StreetAddr2; } set { _trst2StreetAddr2 = value; } }
        private Value<string> _trst2Zip;
        public string Trst2Zip { get { return _trst2Zip; } set { _trst2Zip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _allngToNtPayToJrsdctn.Clean
                    && _allngToNtPayToOrdNm.Clean
                    && _allngToNtPayToOrgTyp.Clean
                    && _allngToNtPayToScsrsClaus.Clean
                    && _allngToNtSignedByNm.Clean
                    && _allngToNtSignedByNm2.Clean
                    && _allngToNtSignedByNm3.Clean
                    && _allngToNtSignedByTtl.Clean
                    && _allngToNtSignedByTtl2.Clean
                    && _allngToNtSignedByTtl3.Clean
                    && _allngToNtSignedByTyp.Clean
                    && _allngToNtWithoutRcrse.Clean
                    && _apnLbl.Clean
                    && _asgnPrepByLblTxtDesc.Clean
                    && _asgnRecRtrnLblTxtDesc.Clean
                    && _benCty.Clean
                    && _benJrsdctn.Clean
                    && _benNm.Clean
                    && _benOrgTyp.Clean
                    && _benStCd.Clean
                    && _benStreetAddr1.Clean
                    && _benStreetAddr2.Clean
                    && _benZip.Clean
                    && _closInstrLndCntcInfoCity.Clean
                    && _closInstrLndCntcInfoCoNm.Clean
                    && _closInstrLndCntcInfoSamePtyTypDesc.Clean
                    && _closInstrLndCntcInfoStCd.Clean
                    && _closInstrLndCntcInfoStreetAddr1.Clean
                    && _closInstrLndCntcInfoStreetAddr2.Clean
                    && _closInstrLndCntcInfoZip.Clean
                    && _closInstrPrtInvLossPayee.Clean
                    && _closInstrStlmtAgtUseLndHud1.Clean
                    && _closInstrTtlPlcyTyp.Clean
                    && _emxmlVersionId.Clean
                    && _exeClosDocDlvrdToCty.Clean
                    && _exeClosDocDlvrdToMiscTxtDesc.Clean
                    && _exeClosDocDlvrdToNm.Clean
                    && _exeClosDocDlvrdToSamePtyTypDesc.Clean
                    && _exeClosDocDlvrdToStCd.Clean
                    && _exeClosDocDlvrdToStreetAddr1.Clean
                    && _exeClosDocDlvrdToStreetAddr2.Clean
                    && _exeClosDocDlvrdToZip.Clean
                    && _exeClosDocExprDt.Clean
                    && _exeClosDocToBeRtrnd.Clean
                    && _exeClosDocToBeRtrndHrs.Clean
                    && _fnlTtlePcyRecDocsSentToAddlLine1.Clean
                    && _fnlTtlePcyRecDocsSentToAddlLine2.Clean
                    && _fnlTtlePcyRecDocsSentToCty.Clean
                    && _fnlTtlePcyRecDocsSentToNm.Clean
                    && _fnlTtlePcyRecDocsSentToSamePtyTypDesc.Clean
                    && _fnlTtlePcyRecDocsSentToStcd.Clean
                    && _fnlTtlePcyRecDocsSentToStreetAddr1.Clean
                    && _fnlTtlePcyRecDocsSentToStreetAddr2.Clean
                    && _fnlTtlePcyRecDocsSentToZip.Clean
                    && _hazInsurEndsmtMailToAdtlTxt.Clean
                    && _hazInsurEndsmtMailToCty.Clean
                    && _hazInsurEndsmtMailToNm.Clean
                    && _hazInsurEndsmtMailToStCd.Clean
                    && _hazInsurEndsmtMailToStreetAddr1.Clean
                    && _hazInsurEndsmtMailToStreetAddr2.Clean
                    && _hazInsurEndsmtMailToZip.Clean
                    && _id.Clean
                    && _mersAdtlCity.Clean
                    && _mersAdtlStCd.Clean
                    && _mersAdtlStreetAddr1.Clean
                    && _mersAdtlStreetAddr2.Clean
                    && _mersAdtlZip.Clean
                    && _mersCty.Clean
                    && _mersJrsdctn.Clean
                    && _mersName.Clean
                    && _mersOrgTyp.Clean
                    && _mersPhoneNum.Clean
                    && _mersStCd.Clean
                    && _mersStreetAddr1.Clean
                    && _mersStreetAddr2.Clean
                    && _mersZip.Clean
                    && _ntEndrsmtPayToJrsdctn.Clean
                    && _ntEndrsmtPayToOrdNm.Clean
                    && _ntEndrsmtPayToOrgTyp.Clean
                    && _ntEndrsmtPayToScsrsClaus.Clean
                    && _ntEndrsmtSgndBy1MiscTxt.Clean
                    && _ntEndrsmtSgndBy2MiscTxt.Clean
                    && _ntEndrsmtSignedByNm.Clean
                    && _ntEndrsmtSignedByNm2.Clean
                    && _ntEndrsmtSignedByNm3.Clean
                    && _ntEndrsmtSignedByTtl.Clean
                    && _ntEndrsmtSignedByTtl2.Clean
                    && _ntEndrsmtSignedByTtl3.Clean
                    && _ntEndrsmtSignedByTyp.Clean
                    && _ntEndrsmtWithoutRcrse.Clean
                    && _ntEndsmtThrdPtyAddr1.Clean
                    && _ntEndsmtThrdPtyAddr2.Clean
                    && _ntEndsmtThrdPtyCty.Clean
                    && _ntEndsmtThrdPtyJrsdctn.Clean
                    && _ntEndsmtThrdPtyName.Clean
                    && _ntEndsmtThrdPtyOrgTyp.Clean
                    && _ntEndsmtThrdPtyPhone.Clean
                    && _ntEndsmtThrdPtyScsrClaus.Clean
                    && _ntEndsmtThrdPtyStCd.Clean
                    && _ntEndsmtThrdPtyZip.Clean
                    && _ntPayToAdtlTxt.Clean
                    && _ntPayToCty.Clean
                    && _ntPayToJrsdctn.Clean
                    && _ntPayToNm.Clean
                    && _ntPayToOrgTyp.Clean
                    && _ntPayToStCd.Clean
                    && _ntPayToStreetAddr1.Clean
                    && _ntPayToStreetAddr2.Clean
                    && _ntPayToZip.Clean
                    && _pmtCpn2PayToAdtlTxt.Clean
                    && _pmtCpn2PayToAdtlTxt2.Clean
                    && _pmtCpn2PayToCty.Clean
                    && _pmtCpn2PayToNm.Clean
                    && _pmtCpn2PayToStCd.Clean
                    && _pmtCpn2PayToStreetAddr1.Clean
                    && _pmtCpn2PayToStreetAddr2.Clean
                    && _pmtCpn2PayToZip.Clean
                    && _pmtCpnPayToAdtlTxt.Clean
                    && _pmtCpnPayToAdtlTxt2.Clean
                    && _pmtCpnPayToCty.Clean
                    && _pmtCpnPayToNm.Clean
                    && _pmtCpnPayToStCd.Clean
                    && _pmtCpnPayToStreetAddr1.Clean
                    && _pmtCpnPayToStreetAddr2.Clean
                    && _pmtCpnPayToZip.Clean
                    && _prtAdtlDateHud1.Clean
                    && _prtAllngToNtBool.Clean
                    && _prtCorpMsgAsgnBool.Clean
                    && _prtDocDtSctyIstrmtNtryAprncDt.Clean
                    && _prtIndxTilBool.Clean
                    && _prtInitBlckNtBool.Clean
                    && _prtInitBlckSctyIstrmtBool.Clean
                    && _prtInvLoanNumBool.Clean
                    && _prtInvLoanNumPmtCpn2Ind.Clean
                    && _prtInvLoanNumPmtCpnInd.Clean
                    && _prtInvLossPayeeHazInsurDisBool.Clean
                    && _prtLoanNumDeedBool.Clean
                    && _prtNtEndsmtBool.Clean
                    && _prtNtPayToCorpMsgBool.Clean
                    && _prtScsrsClausClosInstBool.Clean
                    && _prtScsrsClausHazInsurDisBool.Clean
                    && _prtScsrsClausHazInsurLtrBool.Clean
                    && _prtScsrsClausPmtCpnBool.Clean
                    && _prtSctyIstrmtCorpMsgBool.Clean
                    && _recRtrnAttnLnNmTxtDesc.Clean
                    && _recRtrnCty.Clean
                    && _recRtrnLblTxtDesc.Clean
                    && _recRtrnNm.Clean
                    && _recRtrnNmSamePtyTypDesc.Clean
                    && _recRtrnPhoneNum.Clean
                    && _recRtrnStCd.Clean
                    && _recRtrnStreetAddr1.Clean
                    && _recRtrnStreetAddr2.Clean
                    && _recRtrnTollFreePhoneNum.Clean
                    && _recRtrnZip.Clean
                    && _rtrnExeClosPkgToLndBrchBool.Clean
                    && _rtToCancelNtfcAdtlTxt.Clean
                    && _rtToCancelNtfcCty.Clean
                    && _rtToCancelNtfcEmail.Clean
                    && _rtToCancelNtfcFax.Clean
                    && _rtToCancelNtfcNm.Clean
                    && _rtToCancelNtfcStCd.Clean
                    && _rtToCancelNtfcStreetAddr1.Clean
                    && _rtToCancelNtfcStreetAddr2.Clean
                    && _rtToCancelNtfcZip.Clean
                    && _rtToCancelTransDtTyp.Clean
                    && _sctyIstrmtDCTrstFeePct.Clean
                    && _sctyIstrmtDEAttyFeePct.Clean
                    && _sctyIstrmtLAAttyFeePct.Clean
                    && _sctyIstrmtLAMinAttyFeeAmt.Clean
                    && _sctyIstrmtMDTrstFeePct.Clean
                    && _sctyIstrmtMSTrstFeePct.Clean
                    && _sctyIstrmtNCAttyFeePct.Clean
                    && _sctyIstrmtNETrstFeePct.Clean
                    && _sctyIstrmtNVAssmFeeAmt.Clean
                    && _sctyIstrmtNVTrstFeePct.Clean
                    && _sctyIstrmtOKAssmFeeAmt.Clean
                    && _sctyIstrmtPOBoxAddr1.Clean
                    && _sctyIstrmtPOBoxAddr2.Clean
                    && _sctyIstrmtPrepByAdtlTxt.Clean
                    && _sctyIstrmtPrepByCoNm.Clean
                    && _sctyIstrmtPrepByCty.Clean
                    && _sctyIstrmtPrepByIndvNm.Clean
                    && _sctyIstrmtPrepByIndvTtl.Clean
                    && _sctyIstrmtPrepByPhone.Clean
                    && _sctyIstrmtPrepBySamePtyTypDesc.Clean
                    && _sctyIstrmtPrepByStCd.Clean
                    && _sctyIstrmtPrepByStreetAddr1.Clean
                    && _sctyIstrmtPrepByStreetAddr2.Clean
                    && _sctyIstrmtPrepByTxt.Clean
                    && _sctyIstrmtPrepByZip.Clean
                    && _sctyIstrmtTtlAdtlTxt.Clean
                    && _sctyIstrmtTtlAdtlTxtAbvTtl.Clean
                    && _sctyIstrmtVATrstFeePct.Clean
                    && _trst1Cnty.Clean
                    && _trst1Cty.Clean
                    && _trst1IndvBool.Clean
                    && _trst1Jrsdctn.Clean
                    && _trst1Nm.Clean
                    && _trst1OrgTyp.Clean
                    && _trst1Phone.Clean
                    && _trst1RsdtTxtDesc.Clean
                    && _trst1SamePtyTypDesc.Clean
                    && _trst1StCd.Clean
                    && _trst1StreetAddr1.Clean
                    && _trst1StreetAddr2.Clean
                    && _trst1Zip.Clean
                    && _trst2Cnty.Clean
                    && _trst2Cty.Clean
                    && _trst2IndvBool.Clean
                    && _trst2Jrsdctn.Clean
                    && _trst2Nm.Clean
                    && _trst2OrgTyp.Clean
                    && _trst2Phone.Clean
                    && _trst2RsdtTxtDesc.Clean
                    && _trst2SamePtyTypDesc.Clean
                    && _trst2StCd.Clean
                    && _trst2StreetAddr1.Clean
                    && _trst2StreetAddr2.Clean
                    && _trst2Zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var allngToNtPayToJrsdctn = _allngToNtPayToJrsdctn; allngToNtPayToJrsdctn.Clean = value; _allngToNtPayToJrsdctn = allngToNtPayToJrsdctn;
                var allngToNtPayToOrdNm = _allngToNtPayToOrdNm; allngToNtPayToOrdNm.Clean = value; _allngToNtPayToOrdNm = allngToNtPayToOrdNm;
                var allngToNtPayToOrgTyp = _allngToNtPayToOrgTyp; allngToNtPayToOrgTyp.Clean = value; _allngToNtPayToOrgTyp = allngToNtPayToOrgTyp;
                var allngToNtPayToScsrsClaus = _allngToNtPayToScsrsClaus; allngToNtPayToScsrsClaus.Clean = value; _allngToNtPayToScsrsClaus = allngToNtPayToScsrsClaus;
                var allngToNtSignedByNm = _allngToNtSignedByNm; allngToNtSignedByNm.Clean = value; _allngToNtSignedByNm = allngToNtSignedByNm;
                var allngToNtSignedByNm2 = _allngToNtSignedByNm2; allngToNtSignedByNm2.Clean = value; _allngToNtSignedByNm2 = allngToNtSignedByNm2;
                var allngToNtSignedByNm3 = _allngToNtSignedByNm3; allngToNtSignedByNm3.Clean = value; _allngToNtSignedByNm3 = allngToNtSignedByNm3;
                var allngToNtSignedByTtl = _allngToNtSignedByTtl; allngToNtSignedByTtl.Clean = value; _allngToNtSignedByTtl = allngToNtSignedByTtl;
                var allngToNtSignedByTtl2 = _allngToNtSignedByTtl2; allngToNtSignedByTtl2.Clean = value; _allngToNtSignedByTtl2 = allngToNtSignedByTtl2;
                var allngToNtSignedByTtl3 = _allngToNtSignedByTtl3; allngToNtSignedByTtl3.Clean = value; _allngToNtSignedByTtl3 = allngToNtSignedByTtl3;
                var allngToNtSignedByTyp = _allngToNtSignedByTyp; allngToNtSignedByTyp.Clean = value; _allngToNtSignedByTyp = allngToNtSignedByTyp;
                var allngToNtWithoutRcrse = _allngToNtWithoutRcrse; allngToNtWithoutRcrse.Clean = value; _allngToNtWithoutRcrse = allngToNtWithoutRcrse;
                var apnLbl = _apnLbl; apnLbl.Clean = value; _apnLbl = apnLbl;
                var asgnPrepByLblTxtDesc = _asgnPrepByLblTxtDesc; asgnPrepByLblTxtDesc.Clean = value; _asgnPrepByLblTxtDesc = asgnPrepByLblTxtDesc;
                var asgnRecRtrnLblTxtDesc = _asgnRecRtrnLblTxtDesc; asgnRecRtrnLblTxtDesc.Clean = value; _asgnRecRtrnLblTxtDesc = asgnRecRtrnLblTxtDesc;
                var benCty = _benCty; benCty.Clean = value; _benCty = benCty;
                var benJrsdctn = _benJrsdctn; benJrsdctn.Clean = value; _benJrsdctn = benJrsdctn;
                var benNm = _benNm; benNm.Clean = value; _benNm = benNm;
                var benOrgTyp = _benOrgTyp; benOrgTyp.Clean = value; _benOrgTyp = benOrgTyp;
                var benStCd = _benStCd; benStCd.Clean = value; _benStCd = benStCd;
                var benStreetAddr1 = _benStreetAddr1; benStreetAddr1.Clean = value; _benStreetAddr1 = benStreetAddr1;
                var benStreetAddr2 = _benStreetAddr2; benStreetAddr2.Clean = value; _benStreetAddr2 = benStreetAddr2;
                var benZip = _benZip; benZip.Clean = value; _benZip = benZip;
                var closInstrLndCntcInfoCity = _closInstrLndCntcInfoCity; closInstrLndCntcInfoCity.Clean = value; _closInstrLndCntcInfoCity = closInstrLndCntcInfoCity;
                var closInstrLndCntcInfoCoNm = _closInstrLndCntcInfoCoNm; closInstrLndCntcInfoCoNm.Clean = value; _closInstrLndCntcInfoCoNm = closInstrLndCntcInfoCoNm;
                var closInstrLndCntcInfoSamePtyTypDesc = _closInstrLndCntcInfoSamePtyTypDesc; closInstrLndCntcInfoSamePtyTypDesc.Clean = value; _closInstrLndCntcInfoSamePtyTypDesc = closInstrLndCntcInfoSamePtyTypDesc;
                var closInstrLndCntcInfoStCd = _closInstrLndCntcInfoStCd; closInstrLndCntcInfoStCd.Clean = value; _closInstrLndCntcInfoStCd = closInstrLndCntcInfoStCd;
                var closInstrLndCntcInfoStreetAddr1 = _closInstrLndCntcInfoStreetAddr1; closInstrLndCntcInfoStreetAddr1.Clean = value; _closInstrLndCntcInfoStreetAddr1 = closInstrLndCntcInfoStreetAddr1;
                var closInstrLndCntcInfoStreetAddr2 = _closInstrLndCntcInfoStreetAddr2; closInstrLndCntcInfoStreetAddr2.Clean = value; _closInstrLndCntcInfoStreetAddr2 = closInstrLndCntcInfoStreetAddr2;
                var closInstrLndCntcInfoZip = _closInstrLndCntcInfoZip; closInstrLndCntcInfoZip.Clean = value; _closInstrLndCntcInfoZip = closInstrLndCntcInfoZip;
                var closInstrPrtInvLossPayee = _closInstrPrtInvLossPayee; closInstrPrtInvLossPayee.Clean = value; _closInstrPrtInvLossPayee = closInstrPrtInvLossPayee;
                var closInstrStlmtAgtUseLndHud1 = _closInstrStlmtAgtUseLndHud1; closInstrStlmtAgtUseLndHud1.Clean = value; _closInstrStlmtAgtUseLndHud1 = closInstrStlmtAgtUseLndHud1;
                var closInstrTtlPlcyTyp = _closInstrTtlPlcyTyp; closInstrTtlPlcyTyp.Clean = value; _closInstrTtlPlcyTyp = closInstrTtlPlcyTyp;
                var emxmlVersionId = _emxmlVersionId; emxmlVersionId.Clean = value; _emxmlVersionId = emxmlVersionId;
                var exeClosDocDlvrdToCty = _exeClosDocDlvrdToCty; exeClosDocDlvrdToCty.Clean = value; _exeClosDocDlvrdToCty = exeClosDocDlvrdToCty;
                var exeClosDocDlvrdToMiscTxtDesc = _exeClosDocDlvrdToMiscTxtDesc; exeClosDocDlvrdToMiscTxtDesc.Clean = value; _exeClosDocDlvrdToMiscTxtDesc = exeClosDocDlvrdToMiscTxtDesc;
                var exeClosDocDlvrdToNm = _exeClosDocDlvrdToNm; exeClosDocDlvrdToNm.Clean = value; _exeClosDocDlvrdToNm = exeClosDocDlvrdToNm;
                var exeClosDocDlvrdToSamePtyTypDesc = _exeClosDocDlvrdToSamePtyTypDesc; exeClosDocDlvrdToSamePtyTypDesc.Clean = value; _exeClosDocDlvrdToSamePtyTypDesc = exeClosDocDlvrdToSamePtyTypDesc;
                var exeClosDocDlvrdToStCd = _exeClosDocDlvrdToStCd; exeClosDocDlvrdToStCd.Clean = value; _exeClosDocDlvrdToStCd = exeClosDocDlvrdToStCd;
                var exeClosDocDlvrdToStreetAddr1 = _exeClosDocDlvrdToStreetAddr1; exeClosDocDlvrdToStreetAddr1.Clean = value; _exeClosDocDlvrdToStreetAddr1 = exeClosDocDlvrdToStreetAddr1;
                var exeClosDocDlvrdToStreetAddr2 = _exeClosDocDlvrdToStreetAddr2; exeClosDocDlvrdToStreetAddr2.Clean = value; _exeClosDocDlvrdToStreetAddr2 = exeClosDocDlvrdToStreetAddr2;
                var exeClosDocDlvrdToZip = _exeClosDocDlvrdToZip; exeClosDocDlvrdToZip.Clean = value; _exeClosDocDlvrdToZip = exeClosDocDlvrdToZip;
                var exeClosDocExprDt = _exeClosDocExprDt; exeClosDocExprDt.Clean = value; _exeClosDocExprDt = exeClosDocExprDt;
                var exeClosDocToBeRtrnd = _exeClosDocToBeRtrnd; exeClosDocToBeRtrnd.Clean = value; _exeClosDocToBeRtrnd = exeClosDocToBeRtrnd;
                var exeClosDocToBeRtrndHrs = _exeClosDocToBeRtrndHrs; exeClosDocToBeRtrndHrs.Clean = value; _exeClosDocToBeRtrndHrs = exeClosDocToBeRtrndHrs;
                var fnlTtlePcyRecDocsSentToAddlLine1 = _fnlTtlePcyRecDocsSentToAddlLine1; fnlTtlePcyRecDocsSentToAddlLine1.Clean = value; _fnlTtlePcyRecDocsSentToAddlLine1 = fnlTtlePcyRecDocsSentToAddlLine1;
                var fnlTtlePcyRecDocsSentToAddlLine2 = _fnlTtlePcyRecDocsSentToAddlLine2; fnlTtlePcyRecDocsSentToAddlLine2.Clean = value; _fnlTtlePcyRecDocsSentToAddlLine2 = fnlTtlePcyRecDocsSentToAddlLine2;
                var fnlTtlePcyRecDocsSentToCty = _fnlTtlePcyRecDocsSentToCty; fnlTtlePcyRecDocsSentToCty.Clean = value; _fnlTtlePcyRecDocsSentToCty = fnlTtlePcyRecDocsSentToCty;
                var fnlTtlePcyRecDocsSentToNm = _fnlTtlePcyRecDocsSentToNm; fnlTtlePcyRecDocsSentToNm.Clean = value; _fnlTtlePcyRecDocsSentToNm = fnlTtlePcyRecDocsSentToNm;
                var fnlTtlePcyRecDocsSentToSamePtyTypDesc = _fnlTtlePcyRecDocsSentToSamePtyTypDesc; fnlTtlePcyRecDocsSentToSamePtyTypDesc.Clean = value; _fnlTtlePcyRecDocsSentToSamePtyTypDesc = fnlTtlePcyRecDocsSentToSamePtyTypDesc;
                var fnlTtlePcyRecDocsSentToStcd = _fnlTtlePcyRecDocsSentToStcd; fnlTtlePcyRecDocsSentToStcd.Clean = value; _fnlTtlePcyRecDocsSentToStcd = fnlTtlePcyRecDocsSentToStcd;
                var fnlTtlePcyRecDocsSentToStreetAddr1 = _fnlTtlePcyRecDocsSentToStreetAddr1; fnlTtlePcyRecDocsSentToStreetAddr1.Clean = value; _fnlTtlePcyRecDocsSentToStreetAddr1 = fnlTtlePcyRecDocsSentToStreetAddr1;
                var fnlTtlePcyRecDocsSentToStreetAddr2 = _fnlTtlePcyRecDocsSentToStreetAddr2; fnlTtlePcyRecDocsSentToStreetAddr2.Clean = value; _fnlTtlePcyRecDocsSentToStreetAddr2 = fnlTtlePcyRecDocsSentToStreetAddr2;
                var fnlTtlePcyRecDocsSentToZip = _fnlTtlePcyRecDocsSentToZip; fnlTtlePcyRecDocsSentToZip.Clean = value; _fnlTtlePcyRecDocsSentToZip = fnlTtlePcyRecDocsSentToZip;
                var hazInsurEndsmtMailToAdtlTxt = _hazInsurEndsmtMailToAdtlTxt; hazInsurEndsmtMailToAdtlTxt.Clean = value; _hazInsurEndsmtMailToAdtlTxt = hazInsurEndsmtMailToAdtlTxt;
                var hazInsurEndsmtMailToCty = _hazInsurEndsmtMailToCty; hazInsurEndsmtMailToCty.Clean = value; _hazInsurEndsmtMailToCty = hazInsurEndsmtMailToCty;
                var hazInsurEndsmtMailToNm = _hazInsurEndsmtMailToNm; hazInsurEndsmtMailToNm.Clean = value; _hazInsurEndsmtMailToNm = hazInsurEndsmtMailToNm;
                var hazInsurEndsmtMailToStCd = _hazInsurEndsmtMailToStCd; hazInsurEndsmtMailToStCd.Clean = value; _hazInsurEndsmtMailToStCd = hazInsurEndsmtMailToStCd;
                var hazInsurEndsmtMailToStreetAddr1 = _hazInsurEndsmtMailToStreetAddr1; hazInsurEndsmtMailToStreetAddr1.Clean = value; _hazInsurEndsmtMailToStreetAddr1 = hazInsurEndsmtMailToStreetAddr1;
                var hazInsurEndsmtMailToStreetAddr2 = _hazInsurEndsmtMailToStreetAddr2; hazInsurEndsmtMailToStreetAddr2.Clean = value; _hazInsurEndsmtMailToStreetAddr2 = hazInsurEndsmtMailToStreetAddr2;
                var hazInsurEndsmtMailToZip = _hazInsurEndsmtMailToZip; hazInsurEndsmtMailToZip.Clean = value; _hazInsurEndsmtMailToZip = hazInsurEndsmtMailToZip;
                var id = _id; id.Clean = value; _id = id;
                var mersAdtlCity = _mersAdtlCity; mersAdtlCity.Clean = value; _mersAdtlCity = mersAdtlCity;
                var mersAdtlStCd = _mersAdtlStCd; mersAdtlStCd.Clean = value; _mersAdtlStCd = mersAdtlStCd;
                var mersAdtlStreetAddr1 = _mersAdtlStreetAddr1; mersAdtlStreetAddr1.Clean = value; _mersAdtlStreetAddr1 = mersAdtlStreetAddr1;
                var mersAdtlStreetAddr2 = _mersAdtlStreetAddr2; mersAdtlStreetAddr2.Clean = value; _mersAdtlStreetAddr2 = mersAdtlStreetAddr2;
                var mersAdtlZip = _mersAdtlZip; mersAdtlZip.Clean = value; _mersAdtlZip = mersAdtlZip;
                var mersCty = _mersCty; mersCty.Clean = value; _mersCty = mersCty;
                var mersJrsdctn = _mersJrsdctn; mersJrsdctn.Clean = value; _mersJrsdctn = mersJrsdctn;
                var mersName = _mersName; mersName.Clean = value; _mersName = mersName;
                var mersOrgTyp = _mersOrgTyp; mersOrgTyp.Clean = value; _mersOrgTyp = mersOrgTyp;
                var mersPhoneNum = _mersPhoneNum; mersPhoneNum.Clean = value; _mersPhoneNum = mersPhoneNum;
                var mersStCd = _mersStCd; mersStCd.Clean = value; _mersStCd = mersStCd;
                var mersStreetAddr1 = _mersStreetAddr1; mersStreetAddr1.Clean = value; _mersStreetAddr1 = mersStreetAddr1;
                var mersStreetAddr2 = _mersStreetAddr2; mersStreetAddr2.Clean = value; _mersStreetAddr2 = mersStreetAddr2;
                var mersZip = _mersZip; mersZip.Clean = value; _mersZip = mersZip;
                var ntEndrsmtPayToJrsdctn = _ntEndrsmtPayToJrsdctn; ntEndrsmtPayToJrsdctn.Clean = value; _ntEndrsmtPayToJrsdctn = ntEndrsmtPayToJrsdctn;
                var ntEndrsmtPayToOrdNm = _ntEndrsmtPayToOrdNm; ntEndrsmtPayToOrdNm.Clean = value; _ntEndrsmtPayToOrdNm = ntEndrsmtPayToOrdNm;
                var ntEndrsmtPayToOrgTyp = _ntEndrsmtPayToOrgTyp; ntEndrsmtPayToOrgTyp.Clean = value; _ntEndrsmtPayToOrgTyp = ntEndrsmtPayToOrgTyp;
                var ntEndrsmtPayToScsrsClaus = _ntEndrsmtPayToScsrsClaus; ntEndrsmtPayToScsrsClaus.Clean = value; _ntEndrsmtPayToScsrsClaus = ntEndrsmtPayToScsrsClaus;
                var ntEndrsmtSgndBy1MiscTxt = _ntEndrsmtSgndBy1MiscTxt; ntEndrsmtSgndBy1MiscTxt.Clean = value; _ntEndrsmtSgndBy1MiscTxt = ntEndrsmtSgndBy1MiscTxt;
                var ntEndrsmtSgndBy2MiscTxt = _ntEndrsmtSgndBy2MiscTxt; ntEndrsmtSgndBy2MiscTxt.Clean = value; _ntEndrsmtSgndBy2MiscTxt = ntEndrsmtSgndBy2MiscTxt;
                var ntEndrsmtSignedByNm = _ntEndrsmtSignedByNm; ntEndrsmtSignedByNm.Clean = value; _ntEndrsmtSignedByNm = ntEndrsmtSignedByNm;
                var ntEndrsmtSignedByNm2 = _ntEndrsmtSignedByNm2; ntEndrsmtSignedByNm2.Clean = value; _ntEndrsmtSignedByNm2 = ntEndrsmtSignedByNm2;
                var ntEndrsmtSignedByNm3 = _ntEndrsmtSignedByNm3; ntEndrsmtSignedByNm3.Clean = value; _ntEndrsmtSignedByNm3 = ntEndrsmtSignedByNm3;
                var ntEndrsmtSignedByTtl = _ntEndrsmtSignedByTtl; ntEndrsmtSignedByTtl.Clean = value; _ntEndrsmtSignedByTtl = ntEndrsmtSignedByTtl;
                var ntEndrsmtSignedByTtl2 = _ntEndrsmtSignedByTtl2; ntEndrsmtSignedByTtl2.Clean = value; _ntEndrsmtSignedByTtl2 = ntEndrsmtSignedByTtl2;
                var ntEndrsmtSignedByTtl3 = _ntEndrsmtSignedByTtl3; ntEndrsmtSignedByTtl3.Clean = value; _ntEndrsmtSignedByTtl3 = ntEndrsmtSignedByTtl3;
                var ntEndrsmtSignedByTyp = _ntEndrsmtSignedByTyp; ntEndrsmtSignedByTyp.Clean = value; _ntEndrsmtSignedByTyp = ntEndrsmtSignedByTyp;
                var ntEndrsmtWithoutRcrse = _ntEndrsmtWithoutRcrse; ntEndrsmtWithoutRcrse.Clean = value; _ntEndrsmtWithoutRcrse = ntEndrsmtWithoutRcrse;
                var ntEndsmtThrdPtyAddr1 = _ntEndsmtThrdPtyAddr1; ntEndsmtThrdPtyAddr1.Clean = value; _ntEndsmtThrdPtyAddr1 = ntEndsmtThrdPtyAddr1;
                var ntEndsmtThrdPtyAddr2 = _ntEndsmtThrdPtyAddr2; ntEndsmtThrdPtyAddr2.Clean = value; _ntEndsmtThrdPtyAddr2 = ntEndsmtThrdPtyAddr2;
                var ntEndsmtThrdPtyCty = _ntEndsmtThrdPtyCty; ntEndsmtThrdPtyCty.Clean = value; _ntEndsmtThrdPtyCty = ntEndsmtThrdPtyCty;
                var ntEndsmtThrdPtyJrsdctn = _ntEndsmtThrdPtyJrsdctn; ntEndsmtThrdPtyJrsdctn.Clean = value; _ntEndsmtThrdPtyJrsdctn = ntEndsmtThrdPtyJrsdctn;
                var ntEndsmtThrdPtyName = _ntEndsmtThrdPtyName; ntEndsmtThrdPtyName.Clean = value; _ntEndsmtThrdPtyName = ntEndsmtThrdPtyName;
                var ntEndsmtThrdPtyOrgTyp = _ntEndsmtThrdPtyOrgTyp; ntEndsmtThrdPtyOrgTyp.Clean = value; _ntEndsmtThrdPtyOrgTyp = ntEndsmtThrdPtyOrgTyp;
                var ntEndsmtThrdPtyPhone = _ntEndsmtThrdPtyPhone; ntEndsmtThrdPtyPhone.Clean = value; _ntEndsmtThrdPtyPhone = ntEndsmtThrdPtyPhone;
                var ntEndsmtThrdPtyScsrClaus = _ntEndsmtThrdPtyScsrClaus; ntEndsmtThrdPtyScsrClaus.Clean = value; _ntEndsmtThrdPtyScsrClaus = ntEndsmtThrdPtyScsrClaus;
                var ntEndsmtThrdPtyStCd = _ntEndsmtThrdPtyStCd; ntEndsmtThrdPtyStCd.Clean = value; _ntEndsmtThrdPtyStCd = ntEndsmtThrdPtyStCd;
                var ntEndsmtThrdPtyZip = _ntEndsmtThrdPtyZip; ntEndsmtThrdPtyZip.Clean = value; _ntEndsmtThrdPtyZip = ntEndsmtThrdPtyZip;
                var ntPayToAdtlTxt = _ntPayToAdtlTxt; ntPayToAdtlTxt.Clean = value; _ntPayToAdtlTxt = ntPayToAdtlTxt;
                var ntPayToCty = _ntPayToCty; ntPayToCty.Clean = value; _ntPayToCty = ntPayToCty;
                var ntPayToJrsdctn = _ntPayToJrsdctn; ntPayToJrsdctn.Clean = value; _ntPayToJrsdctn = ntPayToJrsdctn;
                var ntPayToNm = _ntPayToNm; ntPayToNm.Clean = value; _ntPayToNm = ntPayToNm;
                var ntPayToOrgTyp = _ntPayToOrgTyp; ntPayToOrgTyp.Clean = value; _ntPayToOrgTyp = ntPayToOrgTyp;
                var ntPayToStCd = _ntPayToStCd; ntPayToStCd.Clean = value; _ntPayToStCd = ntPayToStCd;
                var ntPayToStreetAddr1 = _ntPayToStreetAddr1; ntPayToStreetAddr1.Clean = value; _ntPayToStreetAddr1 = ntPayToStreetAddr1;
                var ntPayToStreetAddr2 = _ntPayToStreetAddr2; ntPayToStreetAddr2.Clean = value; _ntPayToStreetAddr2 = ntPayToStreetAddr2;
                var ntPayToZip = _ntPayToZip; ntPayToZip.Clean = value; _ntPayToZip = ntPayToZip;
                var pmtCpn2PayToAdtlTxt = _pmtCpn2PayToAdtlTxt; pmtCpn2PayToAdtlTxt.Clean = value; _pmtCpn2PayToAdtlTxt = pmtCpn2PayToAdtlTxt;
                var pmtCpn2PayToAdtlTxt2 = _pmtCpn2PayToAdtlTxt2; pmtCpn2PayToAdtlTxt2.Clean = value; _pmtCpn2PayToAdtlTxt2 = pmtCpn2PayToAdtlTxt2;
                var pmtCpn2PayToCty = _pmtCpn2PayToCty; pmtCpn2PayToCty.Clean = value; _pmtCpn2PayToCty = pmtCpn2PayToCty;
                var pmtCpn2PayToNm = _pmtCpn2PayToNm; pmtCpn2PayToNm.Clean = value; _pmtCpn2PayToNm = pmtCpn2PayToNm;
                var pmtCpn2PayToStCd = _pmtCpn2PayToStCd; pmtCpn2PayToStCd.Clean = value; _pmtCpn2PayToStCd = pmtCpn2PayToStCd;
                var pmtCpn2PayToStreetAddr1 = _pmtCpn2PayToStreetAddr1; pmtCpn2PayToStreetAddr1.Clean = value; _pmtCpn2PayToStreetAddr1 = pmtCpn2PayToStreetAddr1;
                var pmtCpn2PayToStreetAddr2 = _pmtCpn2PayToStreetAddr2; pmtCpn2PayToStreetAddr2.Clean = value; _pmtCpn2PayToStreetAddr2 = pmtCpn2PayToStreetAddr2;
                var pmtCpn2PayToZip = _pmtCpn2PayToZip; pmtCpn2PayToZip.Clean = value; _pmtCpn2PayToZip = pmtCpn2PayToZip;
                var pmtCpnPayToAdtlTxt = _pmtCpnPayToAdtlTxt; pmtCpnPayToAdtlTxt.Clean = value; _pmtCpnPayToAdtlTxt = pmtCpnPayToAdtlTxt;
                var pmtCpnPayToAdtlTxt2 = _pmtCpnPayToAdtlTxt2; pmtCpnPayToAdtlTxt2.Clean = value; _pmtCpnPayToAdtlTxt2 = pmtCpnPayToAdtlTxt2;
                var pmtCpnPayToCty = _pmtCpnPayToCty; pmtCpnPayToCty.Clean = value; _pmtCpnPayToCty = pmtCpnPayToCty;
                var pmtCpnPayToNm = _pmtCpnPayToNm; pmtCpnPayToNm.Clean = value; _pmtCpnPayToNm = pmtCpnPayToNm;
                var pmtCpnPayToStCd = _pmtCpnPayToStCd; pmtCpnPayToStCd.Clean = value; _pmtCpnPayToStCd = pmtCpnPayToStCd;
                var pmtCpnPayToStreetAddr1 = _pmtCpnPayToStreetAddr1; pmtCpnPayToStreetAddr1.Clean = value; _pmtCpnPayToStreetAddr1 = pmtCpnPayToStreetAddr1;
                var pmtCpnPayToStreetAddr2 = _pmtCpnPayToStreetAddr2; pmtCpnPayToStreetAddr2.Clean = value; _pmtCpnPayToStreetAddr2 = pmtCpnPayToStreetAddr2;
                var pmtCpnPayToZip = _pmtCpnPayToZip; pmtCpnPayToZip.Clean = value; _pmtCpnPayToZip = pmtCpnPayToZip;
                var prtAdtlDateHud1 = _prtAdtlDateHud1; prtAdtlDateHud1.Clean = value; _prtAdtlDateHud1 = prtAdtlDateHud1;
                var prtAllngToNtBool = _prtAllngToNtBool; prtAllngToNtBool.Clean = value; _prtAllngToNtBool = prtAllngToNtBool;
                var prtCorpMsgAsgnBool = _prtCorpMsgAsgnBool; prtCorpMsgAsgnBool.Clean = value; _prtCorpMsgAsgnBool = prtCorpMsgAsgnBool;
                var prtDocDtSctyIstrmtNtryAprncDt = _prtDocDtSctyIstrmtNtryAprncDt; prtDocDtSctyIstrmtNtryAprncDt.Clean = value; _prtDocDtSctyIstrmtNtryAprncDt = prtDocDtSctyIstrmtNtryAprncDt;
                var prtIndxTilBool = _prtIndxTilBool; prtIndxTilBool.Clean = value; _prtIndxTilBool = prtIndxTilBool;
                var prtInitBlckNtBool = _prtInitBlckNtBool; prtInitBlckNtBool.Clean = value; _prtInitBlckNtBool = prtInitBlckNtBool;
                var prtInitBlckSctyIstrmtBool = _prtInitBlckSctyIstrmtBool; prtInitBlckSctyIstrmtBool.Clean = value; _prtInitBlckSctyIstrmtBool = prtInitBlckSctyIstrmtBool;
                var prtInvLoanNumBool = _prtInvLoanNumBool; prtInvLoanNumBool.Clean = value; _prtInvLoanNumBool = prtInvLoanNumBool;
                var prtInvLoanNumPmtCpn2Ind = _prtInvLoanNumPmtCpn2Ind; prtInvLoanNumPmtCpn2Ind.Clean = value; _prtInvLoanNumPmtCpn2Ind = prtInvLoanNumPmtCpn2Ind;
                var prtInvLoanNumPmtCpnInd = _prtInvLoanNumPmtCpnInd; prtInvLoanNumPmtCpnInd.Clean = value; _prtInvLoanNumPmtCpnInd = prtInvLoanNumPmtCpnInd;
                var prtInvLossPayeeHazInsurDisBool = _prtInvLossPayeeHazInsurDisBool; prtInvLossPayeeHazInsurDisBool.Clean = value; _prtInvLossPayeeHazInsurDisBool = prtInvLossPayeeHazInsurDisBool;
                var prtLoanNumDeedBool = _prtLoanNumDeedBool; prtLoanNumDeedBool.Clean = value; _prtLoanNumDeedBool = prtLoanNumDeedBool;
                var prtNtEndsmtBool = _prtNtEndsmtBool; prtNtEndsmtBool.Clean = value; _prtNtEndsmtBool = prtNtEndsmtBool;
                var prtNtPayToCorpMsgBool = _prtNtPayToCorpMsgBool; prtNtPayToCorpMsgBool.Clean = value; _prtNtPayToCorpMsgBool = prtNtPayToCorpMsgBool;
                var prtScsrsClausClosInstBool = _prtScsrsClausClosInstBool; prtScsrsClausClosInstBool.Clean = value; _prtScsrsClausClosInstBool = prtScsrsClausClosInstBool;
                var prtScsrsClausHazInsurDisBool = _prtScsrsClausHazInsurDisBool; prtScsrsClausHazInsurDisBool.Clean = value; _prtScsrsClausHazInsurDisBool = prtScsrsClausHazInsurDisBool;
                var prtScsrsClausHazInsurLtrBool = _prtScsrsClausHazInsurLtrBool; prtScsrsClausHazInsurLtrBool.Clean = value; _prtScsrsClausHazInsurLtrBool = prtScsrsClausHazInsurLtrBool;
                var prtScsrsClausPmtCpnBool = _prtScsrsClausPmtCpnBool; prtScsrsClausPmtCpnBool.Clean = value; _prtScsrsClausPmtCpnBool = prtScsrsClausPmtCpnBool;
                var prtSctyIstrmtCorpMsgBool = _prtSctyIstrmtCorpMsgBool; prtSctyIstrmtCorpMsgBool.Clean = value; _prtSctyIstrmtCorpMsgBool = prtSctyIstrmtCorpMsgBool;
                var recRtrnAttnLnNmTxtDesc = _recRtrnAttnLnNmTxtDesc; recRtrnAttnLnNmTxtDesc.Clean = value; _recRtrnAttnLnNmTxtDesc = recRtrnAttnLnNmTxtDesc;
                var recRtrnCty = _recRtrnCty; recRtrnCty.Clean = value; _recRtrnCty = recRtrnCty;
                var recRtrnLblTxtDesc = _recRtrnLblTxtDesc; recRtrnLblTxtDesc.Clean = value; _recRtrnLblTxtDesc = recRtrnLblTxtDesc;
                var recRtrnNm = _recRtrnNm; recRtrnNm.Clean = value; _recRtrnNm = recRtrnNm;
                var recRtrnNmSamePtyTypDesc = _recRtrnNmSamePtyTypDesc; recRtrnNmSamePtyTypDesc.Clean = value; _recRtrnNmSamePtyTypDesc = recRtrnNmSamePtyTypDesc;
                var recRtrnPhoneNum = _recRtrnPhoneNum; recRtrnPhoneNum.Clean = value; _recRtrnPhoneNum = recRtrnPhoneNum;
                var recRtrnStCd = _recRtrnStCd; recRtrnStCd.Clean = value; _recRtrnStCd = recRtrnStCd;
                var recRtrnStreetAddr1 = _recRtrnStreetAddr1; recRtrnStreetAddr1.Clean = value; _recRtrnStreetAddr1 = recRtrnStreetAddr1;
                var recRtrnStreetAddr2 = _recRtrnStreetAddr2; recRtrnStreetAddr2.Clean = value; _recRtrnStreetAddr2 = recRtrnStreetAddr2;
                var recRtrnTollFreePhoneNum = _recRtrnTollFreePhoneNum; recRtrnTollFreePhoneNum.Clean = value; _recRtrnTollFreePhoneNum = recRtrnTollFreePhoneNum;
                var recRtrnZip = _recRtrnZip; recRtrnZip.Clean = value; _recRtrnZip = recRtrnZip;
                var rtrnExeClosPkgToLndBrchBool = _rtrnExeClosPkgToLndBrchBool; rtrnExeClosPkgToLndBrchBool.Clean = value; _rtrnExeClosPkgToLndBrchBool = rtrnExeClosPkgToLndBrchBool;
                var rtToCancelNtfcAdtlTxt = _rtToCancelNtfcAdtlTxt; rtToCancelNtfcAdtlTxt.Clean = value; _rtToCancelNtfcAdtlTxt = rtToCancelNtfcAdtlTxt;
                var rtToCancelNtfcCty = _rtToCancelNtfcCty; rtToCancelNtfcCty.Clean = value; _rtToCancelNtfcCty = rtToCancelNtfcCty;
                var rtToCancelNtfcEmail = _rtToCancelNtfcEmail; rtToCancelNtfcEmail.Clean = value; _rtToCancelNtfcEmail = rtToCancelNtfcEmail;
                var rtToCancelNtfcFax = _rtToCancelNtfcFax; rtToCancelNtfcFax.Clean = value; _rtToCancelNtfcFax = rtToCancelNtfcFax;
                var rtToCancelNtfcNm = _rtToCancelNtfcNm; rtToCancelNtfcNm.Clean = value; _rtToCancelNtfcNm = rtToCancelNtfcNm;
                var rtToCancelNtfcStCd = _rtToCancelNtfcStCd; rtToCancelNtfcStCd.Clean = value; _rtToCancelNtfcStCd = rtToCancelNtfcStCd;
                var rtToCancelNtfcStreetAddr1 = _rtToCancelNtfcStreetAddr1; rtToCancelNtfcStreetAddr1.Clean = value; _rtToCancelNtfcStreetAddr1 = rtToCancelNtfcStreetAddr1;
                var rtToCancelNtfcStreetAddr2 = _rtToCancelNtfcStreetAddr2; rtToCancelNtfcStreetAddr2.Clean = value; _rtToCancelNtfcStreetAddr2 = rtToCancelNtfcStreetAddr2;
                var rtToCancelNtfcZip = _rtToCancelNtfcZip; rtToCancelNtfcZip.Clean = value; _rtToCancelNtfcZip = rtToCancelNtfcZip;
                var rtToCancelTransDtTyp = _rtToCancelTransDtTyp; rtToCancelTransDtTyp.Clean = value; _rtToCancelTransDtTyp = rtToCancelTransDtTyp;
                var sctyIstrmtDCTrstFeePct = _sctyIstrmtDCTrstFeePct; sctyIstrmtDCTrstFeePct.Clean = value; _sctyIstrmtDCTrstFeePct = sctyIstrmtDCTrstFeePct;
                var sctyIstrmtDEAttyFeePct = _sctyIstrmtDEAttyFeePct; sctyIstrmtDEAttyFeePct.Clean = value; _sctyIstrmtDEAttyFeePct = sctyIstrmtDEAttyFeePct;
                var sctyIstrmtLAAttyFeePct = _sctyIstrmtLAAttyFeePct; sctyIstrmtLAAttyFeePct.Clean = value; _sctyIstrmtLAAttyFeePct = sctyIstrmtLAAttyFeePct;
                var sctyIstrmtLAMinAttyFeeAmt = _sctyIstrmtLAMinAttyFeeAmt; sctyIstrmtLAMinAttyFeeAmt.Clean = value; _sctyIstrmtLAMinAttyFeeAmt = sctyIstrmtLAMinAttyFeeAmt;
                var sctyIstrmtMDTrstFeePct = _sctyIstrmtMDTrstFeePct; sctyIstrmtMDTrstFeePct.Clean = value; _sctyIstrmtMDTrstFeePct = sctyIstrmtMDTrstFeePct;
                var sctyIstrmtMSTrstFeePct = _sctyIstrmtMSTrstFeePct; sctyIstrmtMSTrstFeePct.Clean = value; _sctyIstrmtMSTrstFeePct = sctyIstrmtMSTrstFeePct;
                var sctyIstrmtNCAttyFeePct = _sctyIstrmtNCAttyFeePct; sctyIstrmtNCAttyFeePct.Clean = value; _sctyIstrmtNCAttyFeePct = sctyIstrmtNCAttyFeePct;
                var sctyIstrmtNETrstFeePct = _sctyIstrmtNETrstFeePct; sctyIstrmtNETrstFeePct.Clean = value; _sctyIstrmtNETrstFeePct = sctyIstrmtNETrstFeePct;
                var sctyIstrmtNVAssmFeeAmt = _sctyIstrmtNVAssmFeeAmt; sctyIstrmtNVAssmFeeAmt.Clean = value; _sctyIstrmtNVAssmFeeAmt = sctyIstrmtNVAssmFeeAmt;
                var sctyIstrmtNVTrstFeePct = _sctyIstrmtNVTrstFeePct; sctyIstrmtNVTrstFeePct.Clean = value; _sctyIstrmtNVTrstFeePct = sctyIstrmtNVTrstFeePct;
                var sctyIstrmtOKAssmFeeAmt = _sctyIstrmtOKAssmFeeAmt; sctyIstrmtOKAssmFeeAmt.Clean = value; _sctyIstrmtOKAssmFeeAmt = sctyIstrmtOKAssmFeeAmt;
                var sctyIstrmtPOBoxAddr1 = _sctyIstrmtPOBoxAddr1; sctyIstrmtPOBoxAddr1.Clean = value; _sctyIstrmtPOBoxAddr1 = sctyIstrmtPOBoxAddr1;
                var sctyIstrmtPOBoxAddr2 = _sctyIstrmtPOBoxAddr2; sctyIstrmtPOBoxAddr2.Clean = value; _sctyIstrmtPOBoxAddr2 = sctyIstrmtPOBoxAddr2;
                var sctyIstrmtPrepByAdtlTxt = _sctyIstrmtPrepByAdtlTxt; sctyIstrmtPrepByAdtlTxt.Clean = value; _sctyIstrmtPrepByAdtlTxt = sctyIstrmtPrepByAdtlTxt;
                var sctyIstrmtPrepByCoNm = _sctyIstrmtPrepByCoNm; sctyIstrmtPrepByCoNm.Clean = value; _sctyIstrmtPrepByCoNm = sctyIstrmtPrepByCoNm;
                var sctyIstrmtPrepByCty = _sctyIstrmtPrepByCty; sctyIstrmtPrepByCty.Clean = value; _sctyIstrmtPrepByCty = sctyIstrmtPrepByCty;
                var sctyIstrmtPrepByIndvNm = _sctyIstrmtPrepByIndvNm; sctyIstrmtPrepByIndvNm.Clean = value; _sctyIstrmtPrepByIndvNm = sctyIstrmtPrepByIndvNm;
                var sctyIstrmtPrepByIndvTtl = _sctyIstrmtPrepByIndvTtl; sctyIstrmtPrepByIndvTtl.Clean = value; _sctyIstrmtPrepByIndvTtl = sctyIstrmtPrepByIndvTtl;
                var sctyIstrmtPrepByPhone = _sctyIstrmtPrepByPhone; sctyIstrmtPrepByPhone.Clean = value; _sctyIstrmtPrepByPhone = sctyIstrmtPrepByPhone;
                var sctyIstrmtPrepBySamePtyTypDesc = _sctyIstrmtPrepBySamePtyTypDesc; sctyIstrmtPrepBySamePtyTypDesc.Clean = value; _sctyIstrmtPrepBySamePtyTypDesc = sctyIstrmtPrepBySamePtyTypDesc;
                var sctyIstrmtPrepByStCd = _sctyIstrmtPrepByStCd; sctyIstrmtPrepByStCd.Clean = value; _sctyIstrmtPrepByStCd = sctyIstrmtPrepByStCd;
                var sctyIstrmtPrepByStreetAddr1 = _sctyIstrmtPrepByStreetAddr1; sctyIstrmtPrepByStreetAddr1.Clean = value; _sctyIstrmtPrepByStreetAddr1 = sctyIstrmtPrepByStreetAddr1;
                var sctyIstrmtPrepByStreetAddr2 = _sctyIstrmtPrepByStreetAddr2; sctyIstrmtPrepByStreetAddr2.Clean = value; _sctyIstrmtPrepByStreetAddr2 = sctyIstrmtPrepByStreetAddr2;
                var sctyIstrmtPrepByTxt = _sctyIstrmtPrepByTxt; sctyIstrmtPrepByTxt.Clean = value; _sctyIstrmtPrepByTxt = sctyIstrmtPrepByTxt;
                var sctyIstrmtPrepByZip = _sctyIstrmtPrepByZip; sctyIstrmtPrepByZip.Clean = value; _sctyIstrmtPrepByZip = sctyIstrmtPrepByZip;
                var sctyIstrmtTtlAdtlTxt = _sctyIstrmtTtlAdtlTxt; sctyIstrmtTtlAdtlTxt.Clean = value; _sctyIstrmtTtlAdtlTxt = sctyIstrmtTtlAdtlTxt;
                var sctyIstrmtTtlAdtlTxtAbvTtl = _sctyIstrmtTtlAdtlTxtAbvTtl; sctyIstrmtTtlAdtlTxtAbvTtl.Clean = value; _sctyIstrmtTtlAdtlTxtAbvTtl = sctyIstrmtTtlAdtlTxtAbvTtl;
                var sctyIstrmtVATrstFeePct = _sctyIstrmtVATrstFeePct; sctyIstrmtVATrstFeePct.Clean = value; _sctyIstrmtVATrstFeePct = sctyIstrmtVATrstFeePct;
                var trst1Cnty = _trst1Cnty; trst1Cnty.Clean = value; _trst1Cnty = trst1Cnty;
                var trst1Cty = _trst1Cty; trst1Cty.Clean = value; _trst1Cty = trst1Cty;
                var trst1IndvBool = _trst1IndvBool; trst1IndvBool.Clean = value; _trst1IndvBool = trst1IndvBool;
                var trst1Jrsdctn = _trst1Jrsdctn; trst1Jrsdctn.Clean = value; _trst1Jrsdctn = trst1Jrsdctn;
                var trst1Nm = _trst1Nm; trst1Nm.Clean = value; _trst1Nm = trst1Nm;
                var trst1OrgTyp = _trst1OrgTyp; trst1OrgTyp.Clean = value; _trst1OrgTyp = trst1OrgTyp;
                var trst1Phone = _trst1Phone; trst1Phone.Clean = value; _trst1Phone = trst1Phone;
                var trst1RsdtTxtDesc = _trst1RsdtTxtDesc; trst1RsdtTxtDesc.Clean = value; _trst1RsdtTxtDesc = trst1RsdtTxtDesc;
                var trst1SamePtyTypDesc = _trst1SamePtyTypDesc; trst1SamePtyTypDesc.Clean = value; _trst1SamePtyTypDesc = trst1SamePtyTypDesc;
                var trst1StCd = _trst1StCd; trst1StCd.Clean = value; _trst1StCd = trst1StCd;
                var trst1StreetAddr1 = _trst1StreetAddr1; trst1StreetAddr1.Clean = value; _trst1StreetAddr1 = trst1StreetAddr1;
                var trst1StreetAddr2 = _trst1StreetAddr2; trst1StreetAddr2.Clean = value; _trst1StreetAddr2 = trst1StreetAddr2;
                var trst1Zip = _trst1Zip; trst1Zip.Clean = value; _trst1Zip = trst1Zip;
                var trst2Cnty = _trst2Cnty; trst2Cnty.Clean = value; _trst2Cnty = trst2Cnty;
                var trst2Cty = _trst2Cty; trst2Cty.Clean = value; _trst2Cty = trst2Cty;
                var trst2IndvBool = _trst2IndvBool; trst2IndvBool.Clean = value; _trst2IndvBool = trst2IndvBool;
                var trst2Jrsdctn = _trst2Jrsdctn; trst2Jrsdctn.Clean = value; _trst2Jrsdctn = trst2Jrsdctn;
                var trst2Nm = _trst2Nm; trst2Nm.Clean = value; _trst2Nm = trst2Nm;
                var trst2OrgTyp = _trst2OrgTyp; trst2OrgTyp.Clean = value; _trst2OrgTyp = trst2OrgTyp;
                var trst2Phone = _trst2Phone; trst2Phone.Clean = value; _trst2Phone = trst2Phone;
                var trst2RsdtTxtDesc = _trst2RsdtTxtDesc; trst2RsdtTxtDesc.Clean = value; _trst2RsdtTxtDesc = trst2RsdtTxtDesc;
                var trst2SamePtyTypDesc = _trst2SamePtyTypDesc; trst2SamePtyTypDesc.Clean = value; _trst2SamePtyTypDesc = trst2SamePtyTypDesc;
                var trst2StCd = _trst2StCd; trst2StCd.Clean = value; _trst2StCd = trst2StCd;
                var trst2StreetAddr1 = _trst2StreetAddr1; trst2StreetAddr1.Clean = value; _trst2StreetAddr1 = trst2StreetAddr1;
                var trst2StreetAddr2 = _trst2StreetAddr2; trst2StreetAddr2.Clean = value; _trst2StreetAddr2 = trst2StreetAddr2;
                var trst2Zip = _trst2Zip; trst2Zip.Clean = value; _trst2Zip = trst2Zip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public EmDocument()
        {
            Clean = true;
        }
    }
}