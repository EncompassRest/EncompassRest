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
                var v0 = _allngToNtPayToJrsdctn; v0.Clean = value; _allngToNtPayToJrsdctn = v0;
                var v1 = _allngToNtPayToOrdNm; v1.Clean = value; _allngToNtPayToOrdNm = v1;
                var v2 = _allngToNtPayToOrgTyp; v2.Clean = value; _allngToNtPayToOrgTyp = v2;
                var v3 = _allngToNtPayToScsrsClaus; v3.Clean = value; _allngToNtPayToScsrsClaus = v3;
                var v4 = _allngToNtSignedByNm; v4.Clean = value; _allngToNtSignedByNm = v4;
                var v5 = _allngToNtSignedByNm2; v5.Clean = value; _allngToNtSignedByNm2 = v5;
                var v6 = _allngToNtSignedByNm3; v6.Clean = value; _allngToNtSignedByNm3 = v6;
                var v7 = _allngToNtSignedByTtl; v7.Clean = value; _allngToNtSignedByTtl = v7;
                var v8 = _allngToNtSignedByTtl2; v8.Clean = value; _allngToNtSignedByTtl2 = v8;
                var v9 = _allngToNtSignedByTtl3; v9.Clean = value; _allngToNtSignedByTtl3 = v9;
                var v10 = _allngToNtSignedByTyp; v10.Clean = value; _allngToNtSignedByTyp = v10;
                var v11 = _allngToNtWithoutRcrse; v11.Clean = value; _allngToNtWithoutRcrse = v11;
                var v12 = _apnLbl; v12.Clean = value; _apnLbl = v12;
                var v13 = _asgnPrepByLblTxtDesc; v13.Clean = value; _asgnPrepByLblTxtDesc = v13;
                var v14 = _asgnRecRtrnLblTxtDesc; v14.Clean = value; _asgnRecRtrnLblTxtDesc = v14;
                var v15 = _benCty; v15.Clean = value; _benCty = v15;
                var v16 = _benJrsdctn; v16.Clean = value; _benJrsdctn = v16;
                var v17 = _benNm; v17.Clean = value; _benNm = v17;
                var v18 = _benOrgTyp; v18.Clean = value; _benOrgTyp = v18;
                var v19 = _benStCd; v19.Clean = value; _benStCd = v19;
                var v20 = _benStreetAddr1; v20.Clean = value; _benStreetAddr1 = v20;
                var v21 = _benStreetAddr2; v21.Clean = value; _benStreetAddr2 = v21;
                var v22 = _benZip; v22.Clean = value; _benZip = v22;
                var v23 = _closInstrLndCntcInfoCity; v23.Clean = value; _closInstrLndCntcInfoCity = v23;
                var v24 = _closInstrLndCntcInfoCoNm; v24.Clean = value; _closInstrLndCntcInfoCoNm = v24;
                var v25 = _closInstrLndCntcInfoSamePtyTypDesc; v25.Clean = value; _closInstrLndCntcInfoSamePtyTypDesc = v25;
                var v26 = _closInstrLndCntcInfoStCd; v26.Clean = value; _closInstrLndCntcInfoStCd = v26;
                var v27 = _closInstrLndCntcInfoStreetAddr1; v27.Clean = value; _closInstrLndCntcInfoStreetAddr1 = v27;
                var v28 = _closInstrLndCntcInfoStreetAddr2; v28.Clean = value; _closInstrLndCntcInfoStreetAddr2 = v28;
                var v29 = _closInstrLndCntcInfoZip; v29.Clean = value; _closInstrLndCntcInfoZip = v29;
                var v30 = _closInstrPrtInvLossPayee; v30.Clean = value; _closInstrPrtInvLossPayee = v30;
                var v31 = _closInstrStlmtAgtUseLndHud1; v31.Clean = value; _closInstrStlmtAgtUseLndHud1 = v31;
                var v32 = _closInstrTtlPlcyTyp; v32.Clean = value; _closInstrTtlPlcyTyp = v32;
                var v33 = _emxmlVersionId; v33.Clean = value; _emxmlVersionId = v33;
                var v34 = _exeClosDocDlvrdToCty; v34.Clean = value; _exeClosDocDlvrdToCty = v34;
                var v35 = _exeClosDocDlvrdToMiscTxtDesc; v35.Clean = value; _exeClosDocDlvrdToMiscTxtDesc = v35;
                var v36 = _exeClosDocDlvrdToNm; v36.Clean = value; _exeClosDocDlvrdToNm = v36;
                var v37 = _exeClosDocDlvrdToSamePtyTypDesc; v37.Clean = value; _exeClosDocDlvrdToSamePtyTypDesc = v37;
                var v38 = _exeClosDocDlvrdToStCd; v38.Clean = value; _exeClosDocDlvrdToStCd = v38;
                var v39 = _exeClosDocDlvrdToStreetAddr1; v39.Clean = value; _exeClosDocDlvrdToStreetAddr1 = v39;
                var v40 = _exeClosDocDlvrdToStreetAddr2; v40.Clean = value; _exeClosDocDlvrdToStreetAddr2 = v40;
                var v41 = _exeClosDocDlvrdToZip; v41.Clean = value; _exeClosDocDlvrdToZip = v41;
                var v42 = _exeClosDocExprDt; v42.Clean = value; _exeClosDocExprDt = v42;
                var v43 = _exeClosDocToBeRtrnd; v43.Clean = value; _exeClosDocToBeRtrnd = v43;
                var v44 = _exeClosDocToBeRtrndHrs; v44.Clean = value; _exeClosDocToBeRtrndHrs = v44;
                var v45 = _fnlTtlePcyRecDocsSentToAddlLine1; v45.Clean = value; _fnlTtlePcyRecDocsSentToAddlLine1 = v45;
                var v46 = _fnlTtlePcyRecDocsSentToAddlLine2; v46.Clean = value; _fnlTtlePcyRecDocsSentToAddlLine2 = v46;
                var v47 = _fnlTtlePcyRecDocsSentToCty; v47.Clean = value; _fnlTtlePcyRecDocsSentToCty = v47;
                var v48 = _fnlTtlePcyRecDocsSentToNm; v48.Clean = value; _fnlTtlePcyRecDocsSentToNm = v48;
                var v49 = _fnlTtlePcyRecDocsSentToSamePtyTypDesc; v49.Clean = value; _fnlTtlePcyRecDocsSentToSamePtyTypDesc = v49;
                var v50 = _fnlTtlePcyRecDocsSentToStcd; v50.Clean = value; _fnlTtlePcyRecDocsSentToStcd = v50;
                var v51 = _fnlTtlePcyRecDocsSentToStreetAddr1; v51.Clean = value; _fnlTtlePcyRecDocsSentToStreetAddr1 = v51;
                var v52 = _fnlTtlePcyRecDocsSentToStreetAddr2; v52.Clean = value; _fnlTtlePcyRecDocsSentToStreetAddr2 = v52;
                var v53 = _fnlTtlePcyRecDocsSentToZip; v53.Clean = value; _fnlTtlePcyRecDocsSentToZip = v53;
                var v54 = _hazInsurEndsmtMailToAdtlTxt; v54.Clean = value; _hazInsurEndsmtMailToAdtlTxt = v54;
                var v55 = _hazInsurEndsmtMailToCty; v55.Clean = value; _hazInsurEndsmtMailToCty = v55;
                var v56 = _hazInsurEndsmtMailToNm; v56.Clean = value; _hazInsurEndsmtMailToNm = v56;
                var v57 = _hazInsurEndsmtMailToStCd; v57.Clean = value; _hazInsurEndsmtMailToStCd = v57;
                var v58 = _hazInsurEndsmtMailToStreetAddr1; v58.Clean = value; _hazInsurEndsmtMailToStreetAddr1 = v58;
                var v59 = _hazInsurEndsmtMailToStreetAddr2; v59.Clean = value; _hazInsurEndsmtMailToStreetAddr2 = v59;
                var v60 = _hazInsurEndsmtMailToZip; v60.Clean = value; _hazInsurEndsmtMailToZip = v60;
                var v61 = _id; v61.Clean = value; _id = v61;
                var v62 = _mersAdtlCity; v62.Clean = value; _mersAdtlCity = v62;
                var v63 = _mersAdtlStCd; v63.Clean = value; _mersAdtlStCd = v63;
                var v64 = _mersAdtlStreetAddr1; v64.Clean = value; _mersAdtlStreetAddr1 = v64;
                var v65 = _mersAdtlStreetAddr2; v65.Clean = value; _mersAdtlStreetAddr2 = v65;
                var v66 = _mersAdtlZip; v66.Clean = value; _mersAdtlZip = v66;
                var v67 = _mersCty; v67.Clean = value; _mersCty = v67;
                var v68 = _mersJrsdctn; v68.Clean = value; _mersJrsdctn = v68;
                var v69 = _mersName; v69.Clean = value; _mersName = v69;
                var v70 = _mersOrgTyp; v70.Clean = value; _mersOrgTyp = v70;
                var v71 = _mersPhoneNum; v71.Clean = value; _mersPhoneNum = v71;
                var v72 = _mersStCd; v72.Clean = value; _mersStCd = v72;
                var v73 = _mersStreetAddr1; v73.Clean = value; _mersStreetAddr1 = v73;
                var v74 = _mersStreetAddr2; v74.Clean = value; _mersStreetAddr2 = v74;
                var v75 = _mersZip; v75.Clean = value; _mersZip = v75;
                var v76 = _ntEndrsmtPayToJrsdctn; v76.Clean = value; _ntEndrsmtPayToJrsdctn = v76;
                var v77 = _ntEndrsmtPayToOrdNm; v77.Clean = value; _ntEndrsmtPayToOrdNm = v77;
                var v78 = _ntEndrsmtPayToOrgTyp; v78.Clean = value; _ntEndrsmtPayToOrgTyp = v78;
                var v79 = _ntEndrsmtPayToScsrsClaus; v79.Clean = value; _ntEndrsmtPayToScsrsClaus = v79;
                var v80 = _ntEndrsmtSgndBy1MiscTxt; v80.Clean = value; _ntEndrsmtSgndBy1MiscTxt = v80;
                var v81 = _ntEndrsmtSgndBy2MiscTxt; v81.Clean = value; _ntEndrsmtSgndBy2MiscTxt = v81;
                var v82 = _ntEndrsmtSignedByNm; v82.Clean = value; _ntEndrsmtSignedByNm = v82;
                var v83 = _ntEndrsmtSignedByNm2; v83.Clean = value; _ntEndrsmtSignedByNm2 = v83;
                var v84 = _ntEndrsmtSignedByNm3; v84.Clean = value; _ntEndrsmtSignedByNm3 = v84;
                var v85 = _ntEndrsmtSignedByTtl; v85.Clean = value; _ntEndrsmtSignedByTtl = v85;
                var v86 = _ntEndrsmtSignedByTtl2; v86.Clean = value; _ntEndrsmtSignedByTtl2 = v86;
                var v87 = _ntEndrsmtSignedByTtl3; v87.Clean = value; _ntEndrsmtSignedByTtl3 = v87;
                var v88 = _ntEndrsmtSignedByTyp; v88.Clean = value; _ntEndrsmtSignedByTyp = v88;
                var v89 = _ntEndrsmtWithoutRcrse; v89.Clean = value; _ntEndrsmtWithoutRcrse = v89;
                var v90 = _ntEndsmtThrdPtyAddr1; v90.Clean = value; _ntEndsmtThrdPtyAddr1 = v90;
                var v91 = _ntEndsmtThrdPtyAddr2; v91.Clean = value; _ntEndsmtThrdPtyAddr2 = v91;
                var v92 = _ntEndsmtThrdPtyCty; v92.Clean = value; _ntEndsmtThrdPtyCty = v92;
                var v93 = _ntEndsmtThrdPtyJrsdctn; v93.Clean = value; _ntEndsmtThrdPtyJrsdctn = v93;
                var v94 = _ntEndsmtThrdPtyName; v94.Clean = value; _ntEndsmtThrdPtyName = v94;
                var v95 = _ntEndsmtThrdPtyOrgTyp; v95.Clean = value; _ntEndsmtThrdPtyOrgTyp = v95;
                var v96 = _ntEndsmtThrdPtyPhone; v96.Clean = value; _ntEndsmtThrdPtyPhone = v96;
                var v97 = _ntEndsmtThrdPtyScsrClaus; v97.Clean = value; _ntEndsmtThrdPtyScsrClaus = v97;
                var v98 = _ntEndsmtThrdPtyStCd; v98.Clean = value; _ntEndsmtThrdPtyStCd = v98;
                var v99 = _ntEndsmtThrdPtyZip; v99.Clean = value; _ntEndsmtThrdPtyZip = v99;
                var v100 = _ntPayToAdtlTxt; v100.Clean = value; _ntPayToAdtlTxt = v100;
                var v101 = _ntPayToCty; v101.Clean = value; _ntPayToCty = v101;
                var v102 = _ntPayToJrsdctn; v102.Clean = value; _ntPayToJrsdctn = v102;
                var v103 = _ntPayToNm; v103.Clean = value; _ntPayToNm = v103;
                var v104 = _ntPayToOrgTyp; v104.Clean = value; _ntPayToOrgTyp = v104;
                var v105 = _ntPayToStCd; v105.Clean = value; _ntPayToStCd = v105;
                var v106 = _ntPayToStreetAddr1; v106.Clean = value; _ntPayToStreetAddr1 = v106;
                var v107 = _ntPayToStreetAddr2; v107.Clean = value; _ntPayToStreetAddr2 = v107;
                var v108 = _ntPayToZip; v108.Clean = value; _ntPayToZip = v108;
                var v109 = _pmtCpn2PayToAdtlTxt; v109.Clean = value; _pmtCpn2PayToAdtlTxt = v109;
                var v110 = _pmtCpn2PayToAdtlTxt2; v110.Clean = value; _pmtCpn2PayToAdtlTxt2 = v110;
                var v111 = _pmtCpn2PayToCty; v111.Clean = value; _pmtCpn2PayToCty = v111;
                var v112 = _pmtCpn2PayToNm; v112.Clean = value; _pmtCpn2PayToNm = v112;
                var v113 = _pmtCpn2PayToStCd; v113.Clean = value; _pmtCpn2PayToStCd = v113;
                var v114 = _pmtCpn2PayToStreetAddr1; v114.Clean = value; _pmtCpn2PayToStreetAddr1 = v114;
                var v115 = _pmtCpn2PayToStreetAddr2; v115.Clean = value; _pmtCpn2PayToStreetAddr2 = v115;
                var v116 = _pmtCpn2PayToZip; v116.Clean = value; _pmtCpn2PayToZip = v116;
                var v117 = _pmtCpnPayToAdtlTxt; v117.Clean = value; _pmtCpnPayToAdtlTxt = v117;
                var v118 = _pmtCpnPayToAdtlTxt2; v118.Clean = value; _pmtCpnPayToAdtlTxt2 = v118;
                var v119 = _pmtCpnPayToCty; v119.Clean = value; _pmtCpnPayToCty = v119;
                var v120 = _pmtCpnPayToNm; v120.Clean = value; _pmtCpnPayToNm = v120;
                var v121 = _pmtCpnPayToStCd; v121.Clean = value; _pmtCpnPayToStCd = v121;
                var v122 = _pmtCpnPayToStreetAddr1; v122.Clean = value; _pmtCpnPayToStreetAddr1 = v122;
                var v123 = _pmtCpnPayToStreetAddr2; v123.Clean = value; _pmtCpnPayToStreetAddr2 = v123;
                var v124 = _pmtCpnPayToZip; v124.Clean = value; _pmtCpnPayToZip = v124;
                var v125 = _prtAdtlDateHud1; v125.Clean = value; _prtAdtlDateHud1 = v125;
                var v126 = _prtAllngToNtBool; v126.Clean = value; _prtAllngToNtBool = v126;
                var v127 = _prtCorpMsgAsgnBool; v127.Clean = value; _prtCorpMsgAsgnBool = v127;
                var v128 = _prtDocDtSctyIstrmtNtryAprncDt; v128.Clean = value; _prtDocDtSctyIstrmtNtryAprncDt = v128;
                var v129 = _prtIndxTilBool; v129.Clean = value; _prtIndxTilBool = v129;
                var v130 = _prtInitBlckNtBool; v130.Clean = value; _prtInitBlckNtBool = v130;
                var v131 = _prtInitBlckSctyIstrmtBool; v131.Clean = value; _prtInitBlckSctyIstrmtBool = v131;
                var v132 = _prtInvLoanNumBool; v132.Clean = value; _prtInvLoanNumBool = v132;
                var v133 = _prtInvLoanNumPmtCpn2Ind; v133.Clean = value; _prtInvLoanNumPmtCpn2Ind = v133;
                var v134 = _prtInvLoanNumPmtCpnInd; v134.Clean = value; _prtInvLoanNumPmtCpnInd = v134;
                var v135 = _prtInvLossPayeeHazInsurDisBool; v135.Clean = value; _prtInvLossPayeeHazInsurDisBool = v135;
                var v136 = _prtLoanNumDeedBool; v136.Clean = value; _prtLoanNumDeedBool = v136;
                var v137 = _prtNtEndsmtBool; v137.Clean = value; _prtNtEndsmtBool = v137;
                var v138 = _prtNtPayToCorpMsgBool; v138.Clean = value; _prtNtPayToCorpMsgBool = v138;
                var v139 = _prtScsrsClausClosInstBool; v139.Clean = value; _prtScsrsClausClosInstBool = v139;
                var v140 = _prtScsrsClausHazInsurDisBool; v140.Clean = value; _prtScsrsClausHazInsurDisBool = v140;
                var v141 = _prtScsrsClausHazInsurLtrBool; v141.Clean = value; _prtScsrsClausHazInsurLtrBool = v141;
                var v142 = _prtScsrsClausPmtCpnBool; v142.Clean = value; _prtScsrsClausPmtCpnBool = v142;
                var v143 = _prtSctyIstrmtCorpMsgBool; v143.Clean = value; _prtSctyIstrmtCorpMsgBool = v143;
                var v144 = _recRtrnAttnLnNmTxtDesc; v144.Clean = value; _recRtrnAttnLnNmTxtDesc = v144;
                var v145 = _recRtrnCty; v145.Clean = value; _recRtrnCty = v145;
                var v146 = _recRtrnLblTxtDesc; v146.Clean = value; _recRtrnLblTxtDesc = v146;
                var v147 = _recRtrnNm; v147.Clean = value; _recRtrnNm = v147;
                var v148 = _recRtrnNmSamePtyTypDesc; v148.Clean = value; _recRtrnNmSamePtyTypDesc = v148;
                var v149 = _recRtrnPhoneNum; v149.Clean = value; _recRtrnPhoneNum = v149;
                var v150 = _recRtrnStCd; v150.Clean = value; _recRtrnStCd = v150;
                var v151 = _recRtrnStreetAddr1; v151.Clean = value; _recRtrnStreetAddr1 = v151;
                var v152 = _recRtrnStreetAddr2; v152.Clean = value; _recRtrnStreetAddr2 = v152;
                var v153 = _recRtrnTollFreePhoneNum; v153.Clean = value; _recRtrnTollFreePhoneNum = v153;
                var v154 = _recRtrnZip; v154.Clean = value; _recRtrnZip = v154;
                var v155 = _rtrnExeClosPkgToLndBrchBool; v155.Clean = value; _rtrnExeClosPkgToLndBrchBool = v155;
                var v156 = _rtToCancelNtfcAdtlTxt; v156.Clean = value; _rtToCancelNtfcAdtlTxt = v156;
                var v157 = _rtToCancelNtfcCty; v157.Clean = value; _rtToCancelNtfcCty = v157;
                var v158 = _rtToCancelNtfcEmail; v158.Clean = value; _rtToCancelNtfcEmail = v158;
                var v159 = _rtToCancelNtfcFax; v159.Clean = value; _rtToCancelNtfcFax = v159;
                var v160 = _rtToCancelNtfcNm; v160.Clean = value; _rtToCancelNtfcNm = v160;
                var v161 = _rtToCancelNtfcStCd; v161.Clean = value; _rtToCancelNtfcStCd = v161;
                var v162 = _rtToCancelNtfcStreetAddr1; v162.Clean = value; _rtToCancelNtfcStreetAddr1 = v162;
                var v163 = _rtToCancelNtfcStreetAddr2; v163.Clean = value; _rtToCancelNtfcStreetAddr2 = v163;
                var v164 = _rtToCancelNtfcZip; v164.Clean = value; _rtToCancelNtfcZip = v164;
                var v165 = _rtToCancelTransDtTyp; v165.Clean = value; _rtToCancelTransDtTyp = v165;
                var v166 = _sctyIstrmtDCTrstFeePct; v166.Clean = value; _sctyIstrmtDCTrstFeePct = v166;
                var v167 = _sctyIstrmtDEAttyFeePct; v167.Clean = value; _sctyIstrmtDEAttyFeePct = v167;
                var v168 = _sctyIstrmtLAAttyFeePct; v168.Clean = value; _sctyIstrmtLAAttyFeePct = v168;
                var v169 = _sctyIstrmtLAMinAttyFeeAmt; v169.Clean = value; _sctyIstrmtLAMinAttyFeeAmt = v169;
                var v170 = _sctyIstrmtMDTrstFeePct; v170.Clean = value; _sctyIstrmtMDTrstFeePct = v170;
                var v171 = _sctyIstrmtMSTrstFeePct; v171.Clean = value; _sctyIstrmtMSTrstFeePct = v171;
                var v172 = _sctyIstrmtNCAttyFeePct; v172.Clean = value; _sctyIstrmtNCAttyFeePct = v172;
                var v173 = _sctyIstrmtNETrstFeePct; v173.Clean = value; _sctyIstrmtNETrstFeePct = v173;
                var v174 = _sctyIstrmtNVAssmFeeAmt; v174.Clean = value; _sctyIstrmtNVAssmFeeAmt = v174;
                var v175 = _sctyIstrmtNVTrstFeePct; v175.Clean = value; _sctyIstrmtNVTrstFeePct = v175;
                var v176 = _sctyIstrmtOKAssmFeeAmt; v176.Clean = value; _sctyIstrmtOKAssmFeeAmt = v176;
                var v177 = _sctyIstrmtPOBoxAddr1; v177.Clean = value; _sctyIstrmtPOBoxAddr1 = v177;
                var v178 = _sctyIstrmtPOBoxAddr2; v178.Clean = value; _sctyIstrmtPOBoxAddr2 = v178;
                var v179 = _sctyIstrmtPrepByAdtlTxt; v179.Clean = value; _sctyIstrmtPrepByAdtlTxt = v179;
                var v180 = _sctyIstrmtPrepByCoNm; v180.Clean = value; _sctyIstrmtPrepByCoNm = v180;
                var v181 = _sctyIstrmtPrepByCty; v181.Clean = value; _sctyIstrmtPrepByCty = v181;
                var v182 = _sctyIstrmtPrepByIndvNm; v182.Clean = value; _sctyIstrmtPrepByIndvNm = v182;
                var v183 = _sctyIstrmtPrepByIndvTtl; v183.Clean = value; _sctyIstrmtPrepByIndvTtl = v183;
                var v184 = _sctyIstrmtPrepByPhone; v184.Clean = value; _sctyIstrmtPrepByPhone = v184;
                var v185 = _sctyIstrmtPrepBySamePtyTypDesc; v185.Clean = value; _sctyIstrmtPrepBySamePtyTypDesc = v185;
                var v186 = _sctyIstrmtPrepByStCd; v186.Clean = value; _sctyIstrmtPrepByStCd = v186;
                var v187 = _sctyIstrmtPrepByStreetAddr1; v187.Clean = value; _sctyIstrmtPrepByStreetAddr1 = v187;
                var v188 = _sctyIstrmtPrepByStreetAddr2; v188.Clean = value; _sctyIstrmtPrepByStreetAddr2 = v188;
                var v189 = _sctyIstrmtPrepByTxt; v189.Clean = value; _sctyIstrmtPrepByTxt = v189;
                var v190 = _sctyIstrmtPrepByZip; v190.Clean = value; _sctyIstrmtPrepByZip = v190;
                var v191 = _sctyIstrmtTtlAdtlTxt; v191.Clean = value; _sctyIstrmtTtlAdtlTxt = v191;
                var v192 = _sctyIstrmtTtlAdtlTxtAbvTtl; v192.Clean = value; _sctyIstrmtTtlAdtlTxtAbvTtl = v192;
                var v193 = _sctyIstrmtVATrstFeePct; v193.Clean = value; _sctyIstrmtVATrstFeePct = v193;
                var v194 = _trst1Cnty; v194.Clean = value; _trst1Cnty = v194;
                var v195 = _trst1Cty; v195.Clean = value; _trst1Cty = v195;
                var v196 = _trst1IndvBool; v196.Clean = value; _trst1IndvBool = v196;
                var v197 = _trst1Jrsdctn; v197.Clean = value; _trst1Jrsdctn = v197;
                var v198 = _trst1Nm; v198.Clean = value; _trst1Nm = v198;
                var v199 = _trst1OrgTyp; v199.Clean = value; _trst1OrgTyp = v199;
                var v200 = _trst1Phone; v200.Clean = value; _trst1Phone = v200;
                var v201 = _trst1RsdtTxtDesc; v201.Clean = value; _trst1RsdtTxtDesc = v201;
                var v202 = _trst1SamePtyTypDesc; v202.Clean = value; _trst1SamePtyTypDesc = v202;
                var v203 = _trst1StCd; v203.Clean = value; _trst1StCd = v203;
                var v204 = _trst1StreetAddr1; v204.Clean = value; _trst1StreetAddr1 = v204;
                var v205 = _trst1StreetAddr2; v205.Clean = value; _trst1StreetAddr2 = v205;
                var v206 = _trst1Zip; v206.Clean = value; _trst1Zip = v206;
                var v207 = _trst2Cnty; v207.Clean = value; _trst2Cnty = v207;
                var v208 = _trst2Cty; v208.Clean = value; _trst2Cty = v208;
                var v209 = _trst2IndvBool; v209.Clean = value; _trst2IndvBool = v209;
                var v210 = _trst2Jrsdctn; v210.Clean = value; _trst2Jrsdctn = v210;
                var v211 = _trst2Nm; v211.Clean = value; _trst2Nm = v211;
                var v212 = _trst2OrgTyp; v212.Clean = value; _trst2OrgTyp = v212;
                var v213 = _trst2Phone; v213.Clean = value; _trst2Phone = v213;
                var v214 = _trst2RsdtTxtDesc; v214.Clean = value; _trst2RsdtTxtDesc = v214;
                var v215 = _trst2SamePtyTypDesc; v215.Clean = value; _trst2SamePtyTypDesc = v215;
                var v216 = _trst2StCd; v216.Clean = value; _trst2StCd = v216;
                var v217 = _trst2StreetAddr1; v217.Clean = value; _trst2StreetAddr1 = v217;
                var v218 = _trst2StreetAddr2; v218.Clean = value; _trst2StreetAddr2 = v218;
                var v219 = _trst2Zip; v219.Clean = value; _trst2Zip = v219;
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