using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EmDocument
    {
        public Value<string> AllngToNtPayToJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtPayToJrsdctn() => !AllngToNtPayToJrsdctn.Clean;
        public Value<string> AllngToNtPayToOrdNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtPayToOrdNm() => !AllngToNtPayToOrdNm.Clean;
        public Value<string> AllngToNtPayToOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtPayToOrgTyp() => !AllngToNtPayToOrgTyp.Clean;
        public Value<string> AllngToNtPayToScsrsClaus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtPayToScsrsClaus() => !AllngToNtPayToScsrsClaus.Clean;
        public Value<string> AllngToNtSignedByNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByNm() => !AllngToNtSignedByNm.Clean;
        public Value<string> AllngToNtSignedByNm2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByNm2() => !AllngToNtSignedByNm2.Clean;
        public Value<string> AllngToNtSignedByNm3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByNm3() => !AllngToNtSignedByNm3.Clean;
        public Value<string> AllngToNtSignedByTtl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByTtl() => !AllngToNtSignedByTtl.Clean;
        public Value<string> AllngToNtSignedByTtl2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByTtl2() => !AllngToNtSignedByTtl2.Clean;
        public Value<string> AllngToNtSignedByTtl3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByTtl3() => !AllngToNtSignedByTtl3.Clean;
        public Value<string> AllngToNtSignedByTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtSignedByTyp() => !AllngToNtSignedByTyp.Clean;
        public Value<string> AllngToNtWithoutRcrse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllngToNtWithoutRcrse() => !AllngToNtWithoutRcrse.Clean;
        public Value<string> ApnLbl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApnLbl() => !ApnLbl.Clean;
        public Value<bool?> AsgnPrepByLblTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsgnPrepByLblTxtDesc() => !AsgnPrepByLblTxtDesc.Clean;
        public Value<bool?> AsgnRecRtrnLblTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsgnRecRtrnLblTxtDesc() => !AsgnRecRtrnLblTxtDesc.Clean;
        public Value<string> BenCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenCty() => !BenCty.Clean;
        public Value<string> BenJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenJrsdctn() => !BenJrsdctn.Clean;
        public Value<string> BenNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenNm() => !BenNm.Clean;
        public Value<string> BenOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenOrgTyp() => !BenOrgTyp.Clean;
        public Value<string> BenStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenStCd() => !BenStCd.Clean;
        public Value<string> BenStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenStreetAddr1() => !BenStreetAddr1.Clean;
        public Value<string> BenStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenStreetAddr2() => !BenStreetAddr2.Clean;
        public Value<string> BenZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenZip() => !BenZip.Clean;
        public Value<string> ClosInstrLndCntcInfoCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoCity() => !ClosInstrLndCntcInfoCity.Clean;
        public Value<string> ClosInstrLndCntcInfoCoNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoCoNm() => !ClosInstrLndCntcInfoCoNm.Clean;
        public Value<string> ClosInstrLndCntcInfoSamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoSamePtyTypDesc() => !ClosInstrLndCntcInfoSamePtyTypDesc.Clean;
        public Value<string> ClosInstrLndCntcInfoStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoStCd() => !ClosInstrLndCntcInfoStCd.Clean;
        public Value<string> ClosInstrLndCntcInfoStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoStreetAddr1() => !ClosInstrLndCntcInfoStreetAddr1.Clean;
        public Value<string> ClosInstrLndCntcInfoStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoStreetAddr2() => !ClosInstrLndCntcInfoStreetAddr2.Clean;
        public Value<string> ClosInstrLndCntcInfoZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrLndCntcInfoZip() => !ClosInstrLndCntcInfoZip.Clean;
        public Value<bool?> ClosInstrPrtInvLossPayee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrPrtInvLossPayee() => !ClosInstrPrtInvLossPayee.Clean;
        public Value<bool?> ClosInstrStlmtAgtUseLndHud1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrStlmtAgtUseLndHud1() => !ClosInstrStlmtAgtUseLndHud1.Clean;
        public Value<string> ClosInstrTtlPlcyTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosInstrTtlPlcyTyp() => !ClosInstrTtlPlcyTyp.Clean;
        public Value<string> EmxmlVersionId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmxmlVersionId() => !EmxmlVersionId.Clean;
        public Value<string> ExeClosDocDlvrdToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToCty() => !ExeClosDocDlvrdToCty.Clean;
        public Value<string> ExeClosDocDlvrdToMiscTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToMiscTxtDesc() => !ExeClosDocDlvrdToMiscTxtDesc.Clean;
        public Value<string> ExeClosDocDlvrdToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToNm() => !ExeClosDocDlvrdToNm.Clean;
        public Value<string> ExeClosDocDlvrdToSamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToSamePtyTypDesc() => !ExeClosDocDlvrdToSamePtyTypDesc.Clean;
        public Value<string> ExeClosDocDlvrdToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToStCd() => !ExeClosDocDlvrdToStCd.Clean;
        public Value<string> ExeClosDocDlvrdToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToStreetAddr1() => !ExeClosDocDlvrdToStreetAddr1.Clean;
        public Value<string> ExeClosDocDlvrdToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToStreetAddr2() => !ExeClosDocDlvrdToStreetAddr2.Clean;
        public Value<string> ExeClosDocDlvrdToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocDlvrdToZip() => !ExeClosDocDlvrdToZip.Clean;
        public Value<string> ExeClosDocExprDt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocExprDt() => !ExeClosDocExprDt.Clean;
        public Value<string> ExeClosDocToBeRtrnd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocToBeRtrnd() => !ExeClosDocToBeRtrnd.Clean;
        public Value<string> ExeClosDocToBeRtrndHrs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExeClosDocToBeRtrndHrs() => !ExeClosDocToBeRtrndHrs.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToAddlLine1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToAddlLine1() => !FnlTtlePcyRecDocsSentToAddlLine1.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToAddlLine2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToAddlLine2() => !FnlTtlePcyRecDocsSentToAddlLine2.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToCty() => !FnlTtlePcyRecDocsSentToCty.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToNm() => !FnlTtlePcyRecDocsSentToNm.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToSamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToSamePtyTypDesc() => !FnlTtlePcyRecDocsSentToSamePtyTypDesc.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToStcd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToStcd() => !FnlTtlePcyRecDocsSentToStcd.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToStreetAddr1() => !FnlTtlePcyRecDocsSentToStreetAddr1.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToStreetAddr2() => !FnlTtlePcyRecDocsSentToStreetAddr2.Clean;
        public Value<string> FnlTtlePcyRecDocsSentToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnlTtlePcyRecDocsSentToZip() => !FnlTtlePcyRecDocsSentToZip.Clean;
        public Value<string> HazInsurEndsmtMailToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToAdtlTxt() => !HazInsurEndsmtMailToAdtlTxt.Clean;
        public Value<string> HazInsurEndsmtMailToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToCty() => !HazInsurEndsmtMailToCty.Clean;
        public Value<string> HazInsurEndsmtMailToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToNm() => !HazInsurEndsmtMailToNm.Clean;
        public Value<string> HazInsurEndsmtMailToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToStCd() => !HazInsurEndsmtMailToStCd.Clean;
        public Value<string> HazInsurEndsmtMailToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToStreetAddr1() => !HazInsurEndsmtMailToStreetAddr1.Clean;
        public Value<string> HazInsurEndsmtMailToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToStreetAddr2() => !HazInsurEndsmtMailToStreetAddr2.Clean;
        public Value<string> HazInsurEndsmtMailToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsurEndsmtMailToZip() => !HazInsurEndsmtMailToZip.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> MersAdtlCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersAdtlCity() => !MersAdtlCity.Clean;
        public Value<string> MersAdtlStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersAdtlStCd() => !MersAdtlStCd.Clean;
        public Value<string> MersAdtlStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersAdtlStreetAddr1() => !MersAdtlStreetAddr1.Clean;
        public Value<string> MersAdtlStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersAdtlStreetAddr2() => !MersAdtlStreetAddr2.Clean;
        public Value<string> MersAdtlZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersAdtlZip() => !MersAdtlZip.Clean;
        public Value<string> MersCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersCty() => !MersCty.Clean;
        public Value<string> MersJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersJrsdctn() => !MersJrsdctn.Clean;
        public Value<string> MersName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersName() => !MersName.Clean;
        public Value<string> MersOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersOrgTyp() => !MersOrgTyp.Clean;
        public Value<string> MersPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersPhoneNum() => !MersPhoneNum.Clean;
        public Value<string> MersStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersStCd() => !MersStCd.Clean;
        public Value<string> MersStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersStreetAddr1() => !MersStreetAddr1.Clean;
        public Value<string> MersStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersStreetAddr2() => !MersStreetAddr2.Clean;
        public Value<string> MersZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersZip() => !MersZip.Clean;
        public Value<string> NtEndrsmtPayToJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtPayToJrsdctn() => !NtEndrsmtPayToJrsdctn.Clean;
        public Value<string> NtEndrsmtPayToOrdNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtPayToOrdNm() => !NtEndrsmtPayToOrdNm.Clean;
        public Value<string> NtEndrsmtPayToOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtPayToOrgTyp() => !NtEndrsmtPayToOrgTyp.Clean;
        public Value<string> NtEndrsmtPayToScsrsClaus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtPayToScsrsClaus() => !NtEndrsmtPayToScsrsClaus.Clean;
        public Value<string> NtEndrsmtSgndBy1MiscTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSgndBy1MiscTxt() => !NtEndrsmtSgndBy1MiscTxt.Clean;
        public Value<string> NtEndrsmtSgndBy2MiscTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSgndBy2MiscTxt() => !NtEndrsmtSgndBy2MiscTxt.Clean;
        public Value<string> NtEndrsmtSignedByNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByNm() => !NtEndrsmtSignedByNm.Clean;
        public Value<string> NtEndrsmtSignedByNm2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByNm2() => !NtEndrsmtSignedByNm2.Clean;
        public Value<string> NtEndrsmtSignedByNm3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByNm3() => !NtEndrsmtSignedByNm3.Clean;
        public Value<string> NtEndrsmtSignedByTtl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByTtl() => !NtEndrsmtSignedByTtl.Clean;
        public Value<string> NtEndrsmtSignedByTtl2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByTtl2() => !NtEndrsmtSignedByTtl2.Clean;
        public Value<string> NtEndrsmtSignedByTtl3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByTtl3() => !NtEndrsmtSignedByTtl3.Clean;
        public Value<string> NtEndrsmtSignedByTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtSignedByTyp() => !NtEndrsmtSignedByTyp.Clean;
        public Value<string> NtEndrsmtWithoutRcrse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndrsmtWithoutRcrse() => !NtEndrsmtWithoutRcrse.Clean;
        public Value<string> NtEndsmtThrdPtyAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyAddr1() => !NtEndsmtThrdPtyAddr1.Clean;
        public Value<string> NtEndsmtThrdPtyAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyAddr2() => !NtEndsmtThrdPtyAddr2.Clean;
        public Value<string> NtEndsmtThrdPtyCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyCty() => !NtEndsmtThrdPtyCty.Clean;
        public Value<string> NtEndsmtThrdPtyJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyJrsdctn() => !NtEndsmtThrdPtyJrsdctn.Clean;
        public Value<string> NtEndsmtThrdPtyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyName() => !NtEndsmtThrdPtyName.Clean;
        public Value<string> NtEndsmtThrdPtyOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyOrgTyp() => !NtEndsmtThrdPtyOrgTyp.Clean;
        public Value<string> NtEndsmtThrdPtyPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyPhone() => !NtEndsmtThrdPtyPhone.Clean;
        public Value<string> NtEndsmtThrdPtyScsrClaus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyScsrClaus() => !NtEndsmtThrdPtyScsrClaus.Clean;
        public Value<string> NtEndsmtThrdPtyStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyStCd() => !NtEndsmtThrdPtyStCd.Clean;
        public Value<string> NtEndsmtThrdPtyZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtEndsmtThrdPtyZip() => !NtEndsmtThrdPtyZip.Clean;
        public Value<string> NtPayToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToAdtlTxt() => !NtPayToAdtlTxt.Clean;
        public Value<string> NtPayToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToCty() => !NtPayToCty.Clean;
        public Value<string> NtPayToJrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToJrsdctn() => !NtPayToJrsdctn.Clean;
        public Value<string> NtPayToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToNm() => !NtPayToNm.Clean;
        public Value<string> NtPayToOrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToOrgTyp() => !NtPayToOrgTyp.Clean;
        public Value<string> NtPayToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToStCd() => !NtPayToStCd.Clean;
        public Value<string> NtPayToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToStreetAddr1() => !NtPayToStreetAddr1.Clean;
        public Value<string> NtPayToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToStreetAddr2() => !NtPayToStreetAddr2.Clean;
        public Value<string> NtPayToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNtPayToZip() => !NtPayToZip.Clean;
        public Value<string> PmtCpn2PayToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToAdtlTxt() => !PmtCpn2PayToAdtlTxt.Clean;
        public Value<string> PmtCpn2PayToAdtlTxt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToAdtlTxt2() => !PmtCpn2PayToAdtlTxt2.Clean;
        public Value<string> PmtCpn2PayToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToCty() => !PmtCpn2PayToCty.Clean;
        public Value<string> PmtCpn2PayToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToNm() => !PmtCpn2PayToNm.Clean;
        public Value<string> PmtCpn2PayToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToStCd() => !PmtCpn2PayToStCd.Clean;
        public Value<string> PmtCpn2PayToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToStreetAddr1() => !PmtCpn2PayToStreetAddr1.Clean;
        public Value<string> PmtCpn2PayToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToStreetAddr2() => !PmtCpn2PayToStreetAddr2.Clean;
        public Value<string> PmtCpn2PayToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpn2PayToZip() => !PmtCpn2PayToZip.Clean;
        public Value<string> PmtCpnPayToAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToAdtlTxt() => !PmtCpnPayToAdtlTxt.Clean;
        public Value<string> PmtCpnPayToAdtlTxt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToAdtlTxt2() => !PmtCpnPayToAdtlTxt2.Clean;
        public Value<string> PmtCpnPayToCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToCty() => !PmtCpnPayToCty.Clean;
        public Value<string> PmtCpnPayToNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToNm() => !PmtCpnPayToNm.Clean;
        public Value<string> PmtCpnPayToStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToStCd() => !PmtCpnPayToStCd.Clean;
        public Value<string> PmtCpnPayToStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToStreetAddr1() => !PmtCpnPayToStreetAddr1.Clean;
        public Value<string> PmtCpnPayToStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToStreetAddr2() => !PmtCpnPayToStreetAddr2.Clean;
        public Value<string> PmtCpnPayToZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmtCpnPayToZip() => !PmtCpnPayToZip.Clean;
        public Value<string> PrtAdtlDateHud1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtAdtlDateHud1() => !PrtAdtlDateHud1.Clean;
        public Value<bool?> PrtAllngToNtBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtAllngToNtBool() => !PrtAllngToNtBool.Clean;
        public Value<bool?> PrtCorpMsgAsgnBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtCorpMsgAsgnBool() => !PrtCorpMsgAsgnBool.Clean;
        public Value<string> PrtDocDtSctyIstrmtNtryAprncDt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtDocDtSctyIstrmtNtryAprncDt() => !PrtDocDtSctyIstrmtNtryAprncDt.Clean;
        public Value<bool?> PrtIndxTilBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtIndxTilBool() => !PrtIndxTilBool.Clean;
        public Value<bool?> PrtInitBlckNtBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInitBlckNtBool() => !PrtInitBlckNtBool.Clean;
        public Value<bool?> PrtInitBlckSctyIstrmtBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInitBlckSctyIstrmtBool() => !PrtInitBlckSctyIstrmtBool.Clean;
        public Value<bool?> PrtInvLoanNumBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInvLoanNumBool() => !PrtInvLoanNumBool.Clean;
        public Value<bool?> PrtInvLoanNumPmtCpn2Ind { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInvLoanNumPmtCpn2Ind() => !PrtInvLoanNumPmtCpn2Ind.Clean;
        public Value<bool?> PrtInvLoanNumPmtCpnInd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInvLoanNumPmtCpnInd() => !PrtInvLoanNumPmtCpnInd.Clean;
        public Value<bool?> PrtInvLossPayeeHazInsurDisBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtInvLossPayeeHazInsurDisBool() => !PrtInvLossPayeeHazInsurDisBool.Clean;
        public Value<bool?> PrtLoanNumDeedBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtLoanNumDeedBool() => !PrtLoanNumDeedBool.Clean;
        public Value<bool?> PrtNtEndsmtBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtNtEndsmtBool() => !PrtNtEndsmtBool.Clean;
        public Value<bool?> PrtNtPayToCorpMsgBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtNtPayToCorpMsgBool() => !PrtNtPayToCorpMsgBool.Clean;
        public Value<bool?> PrtScsrsClausClosInstBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtScsrsClausClosInstBool() => !PrtScsrsClausClosInstBool.Clean;
        public Value<bool?> PrtScsrsClausHazInsurDisBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtScsrsClausHazInsurDisBool() => !PrtScsrsClausHazInsurDisBool.Clean;
        public Value<bool?> PrtScsrsClausHazInsurLtrBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtScsrsClausHazInsurLtrBool() => !PrtScsrsClausHazInsurLtrBool.Clean;
        public Value<bool?> PrtScsrsClausPmtCpnBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtScsrsClausPmtCpnBool() => !PrtScsrsClausPmtCpnBool.Clean;
        public Value<bool?> PrtSctyIstrmtCorpMsgBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrtSctyIstrmtCorpMsgBool() => !PrtSctyIstrmtCorpMsgBool.Clean;
        public Value<string> RecRtrnAttnLnNmTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnAttnLnNmTxtDesc() => !RecRtrnAttnLnNmTxtDesc.Clean;
        public Value<string> RecRtrnCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnCty() => !RecRtrnCty.Clean;
        public Value<string> RecRtrnLblTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnLblTxtDesc() => !RecRtrnLblTxtDesc.Clean;
        public Value<string> RecRtrnNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnNm() => !RecRtrnNm.Clean;
        public Value<string> RecRtrnNmSamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnNmSamePtyTypDesc() => !RecRtrnNmSamePtyTypDesc.Clean;
        public Value<string> RecRtrnPhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnPhoneNum() => !RecRtrnPhoneNum.Clean;
        public Value<string> RecRtrnStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnStCd() => !RecRtrnStCd.Clean;
        public Value<string> RecRtrnStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnStreetAddr1() => !RecRtrnStreetAddr1.Clean;
        public Value<string> RecRtrnStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnStreetAddr2() => !RecRtrnStreetAddr2.Clean;
        public Value<string> RecRtrnTollFreePhoneNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnTollFreePhoneNum() => !RecRtrnTollFreePhoneNum.Clean;
        public Value<string> RecRtrnZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecRtrnZip() => !RecRtrnZip.Clean;
        public Value<bool?> RtrnExeClosPkgToLndBrchBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtrnExeClosPkgToLndBrchBool() => !RtrnExeClosPkgToLndBrchBool.Clean;
        public Value<string> RtToCancelNtfcAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcAdtlTxt() => !RtToCancelNtfcAdtlTxt.Clean;
        public Value<string> RtToCancelNtfcCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcCty() => !RtToCancelNtfcCty.Clean;
        public Value<string> RtToCancelNtfcEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcEmail() => !RtToCancelNtfcEmail.Clean;
        public Value<string> RtToCancelNtfcFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcFax() => !RtToCancelNtfcFax.Clean;
        public Value<string> RtToCancelNtfcNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcNm() => !RtToCancelNtfcNm.Clean;
        public Value<string> RtToCancelNtfcStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcStCd() => !RtToCancelNtfcStCd.Clean;
        public Value<string> RtToCancelNtfcStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcStreetAddr1() => !RtToCancelNtfcStreetAddr1.Clean;
        public Value<string> RtToCancelNtfcStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcStreetAddr2() => !RtToCancelNtfcStreetAddr2.Clean;
        public Value<string> RtToCancelNtfcZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelNtfcZip() => !RtToCancelNtfcZip.Clean;
        public Value<string> RtToCancelTransDtTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRtToCancelTransDtTyp() => !RtToCancelTransDtTyp.Clean;
        public Value<string> SctyIstrmtDCTrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtDCTrstFeePct() => !SctyIstrmtDCTrstFeePct.Clean;
        public Value<string> SctyIstrmtDEAttyFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtDEAttyFeePct() => !SctyIstrmtDEAttyFeePct.Clean;
        public Value<decimal?> SctyIstrmtLAAttyFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtLAAttyFeePct() => !SctyIstrmtLAAttyFeePct.Clean;
        public Value<decimal?> SctyIstrmtLAMinAttyFeeAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtLAMinAttyFeeAmt() => !SctyIstrmtLAMinAttyFeeAmt.Clean;
        public Value<string> SctyIstrmtMDTrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtMDTrstFeePct() => !SctyIstrmtMDTrstFeePct.Clean;
        public Value<string> SctyIstrmtMSTrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtMSTrstFeePct() => !SctyIstrmtMSTrstFeePct.Clean;
        public Value<string> SctyIstrmtNCAttyFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtNCAttyFeePct() => !SctyIstrmtNCAttyFeePct.Clean;
        public Value<string> SctyIstrmtNETrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtNETrstFeePct() => !SctyIstrmtNETrstFeePct.Clean;
        public Value<string> SctyIstrmtNVAssmFeeAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtNVAssmFeeAmt() => !SctyIstrmtNVAssmFeeAmt.Clean;
        public Value<string> SctyIstrmtNVTrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtNVTrstFeePct() => !SctyIstrmtNVTrstFeePct.Clean;
        public Value<string> SctyIstrmtOKAssmFeeAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtOKAssmFeeAmt() => !SctyIstrmtOKAssmFeeAmt.Clean;
        public Value<string> SctyIstrmtPOBoxAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPOBoxAddr1() => !SctyIstrmtPOBoxAddr1.Clean;
        public Value<string> SctyIstrmtPOBoxAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPOBoxAddr2() => !SctyIstrmtPOBoxAddr2.Clean;
        public Value<string> SctyIstrmtPrepByAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByAdtlTxt() => !SctyIstrmtPrepByAdtlTxt.Clean;
        public Value<string> SctyIstrmtPrepByCoNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByCoNm() => !SctyIstrmtPrepByCoNm.Clean;
        public Value<string> SctyIstrmtPrepByCty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByCty() => !SctyIstrmtPrepByCty.Clean;
        public Value<string> SctyIstrmtPrepByIndvNm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByIndvNm() => !SctyIstrmtPrepByIndvNm.Clean;
        public Value<string> SctyIstrmtPrepByIndvTtl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByIndvTtl() => !SctyIstrmtPrepByIndvTtl.Clean;
        public Value<string> SctyIstrmtPrepByPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByPhone() => !SctyIstrmtPrepByPhone.Clean;
        public Value<string> SctyIstrmtPrepBySamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepBySamePtyTypDesc() => !SctyIstrmtPrepBySamePtyTypDesc.Clean;
        public Value<string> SctyIstrmtPrepByStCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByStCd() => !SctyIstrmtPrepByStCd.Clean;
        public Value<string> SctyIstrmtPrepByStreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByStreetAddr1() => !SctyIstrmtPrepByStreetAddr1.Clean;
        public Value<string> SctyIstrmtPrepByStreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByStreetAddr2() => !SctyIstrmtPrepByStreetAddr2.Clean;
        public Value<string> SctyIstrmtPrepByTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByTxt() => !SctyIstrmtPrepByTxt.Clean;
        public Value<string> SctyIstrmtPrepByZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtPrepByZip() => !SctyIstrmtPrepByZip.Clean;
        public Value<string> SctyIstrmtTtlAdtlTxt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtTtlAdtlTxt() => !SctyIstrmtTtlAdtlTxt.Clean;
        public Value<bool?> SctyIstrmtTtlAdtlTxtAbvTtl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtTtlAdtlTxtAbvTtl() => !SctyIstrmtTtlAdtlTxtAbvTtl.Clean;
        public Value<string> SctyIstrmtVATrstFeePct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSctyIstrmtVATrstFeePct() => !SctyIstrmtVATrstFeePct.Clean;
        public Value<string> Trst1Cnty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Cnty() => !Trst1Cnty.Clean;
        public Value<string> Trst1Cty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Cty() => !Trst1Cty.Clean;
        public Value<bool?> Trst1IndvBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1IndvBool() => !Trst1IndvBool.Clean;
        public Value<string> Trst1Jrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Jrsdctn() => !Trst1Jrsdctn.Clean;
        public Value<string> Trst1Nm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Nm() => !Trst1Nm.Clean;
        public Value<string> Trst1OrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1OrgTyp() => !Trst1OrgTyp.Clean;
        public Value<string> Trst1Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Phone() => !Trst1Phone.Clean;
        public Value<string> Trst1RsdtTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1RsdtTxtDesc() => !Trst1RsdtTxtDesc.Clean;
        public Value<string> Trst1SamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1SamePtyTypDesc() => !Trst1SamePtyTypDesc.Clean;
        public Value<string> Trst1StCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1StCd() => !Trst1StCd.Clean;
        public Value<string> Trst1StreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1StreetAddr1() => !Trst1StreetAddr1.Clean;
        public Value<string> Trst1StreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1StreetAddr2() => !Trst1StreetAddr2.Clean;
        public Value<string> Trst1Zip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst1Zip() => !Trst1Zip.Clean;
        public Value<string> Trst2Cnty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Cnty() => !Trst2Cnty.Clean;
        public Value<string> Trst2Cty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Cty() => !Trst2Cty.Clean;
        public Value<bool?> Trst2IndvBool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2IndvBool() => !Trst2IndvBool.Clean;
        public Value<string> Trst2Jrsdctn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Jrsdctn() => !Trst2Jrsdctn.Clean;
        public Value<string> Trst2Nm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Nm() => !Trst2Nm.Clean;
        public Value<string> Trst2OrgTyp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2OrgTyp() => !Trst2OrgTyp.Clean;
        public Value<string> Trst2Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Phone() => !Trst2Phone.Clean;
        public Value<string> Trst2RsdtTxtDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2RsdtTxtDesc() => !Trst2RsdtTxtDesc.Clean;
        public Value<string> Trst2SamePtyTypDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2SamePtyTypDesc() => !Trst2SamePtyTypDesc.Clean;
        public Value<string> Trst2StCd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2StCd() => !Trst2StCd.Clean;
        public Value<string> Trst2StreetAddr1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2StreetAddr1() => !Trst2StreetAddr1.Clean;
        public Value<string> Trst2StreetAddr2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2StreetAddr2() => !Trst2StreetAddr2.Clean;
        public Value<string> Trst2Zip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrst2Zip() => !Trst2Zip.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AllngToNtPayToJrsdctn.Clean
                    && AllngToNtPayToOrdNm.Clean
                    && AllngToNtPayToOrgTyp.Clean
                    && AllngToNtPayToScsrsClaus.Clean
                    && AllngToNtSignedByNm.Clean
                    && AllngToNtSignedByNm2.Clean
                    && AllngToNtSignedByNm3.Clean
                    && AllngToNtSignedByTtl.Clean
                    && AllngToNtSignedByTtl2.Clean
                    && AllngToNtSignedByTtl3.Clean
                    && AllngToNtSignedByTyp.Clean
                    && AllngToNtWithoutRcrse.Clean
                    && ApnLbl.Clean
                    && AsgnPrepByLblTxtDesc.Clean
                    && AsgnRecRtrnLblTxtDesc.Clean
                    && BenCty.Clean
                    && BenJrsdctn.Clean
                    && BenNm.Clean
                    && BenOrgTyp.Clean
                    && BenStCd.Clean
                    && BenStreetAddr1.Clean
                    && BenStreetAddr2.Clean
                    && BenZip.Clean
                    && ClosInstrLndCntcInfoCity.Clean
                    && ClosInstrLndCntcInfoCoNm.Clean
                    && ClosInstrLndCntcInfoSamePtyTypDesc.Clean
                    && ClosInstrLndCntcInfoStCd.Clean
                    && ClosInstrLndCntcInfoStreetAddr1.Clean
                    && ClosInstrLndCntcInfoStreetAddr2.Clean
                    && ClosInstrLndCntcInfoZip.Clean
                    && ClosInstrPrtInvLossPayee.Clean
                    && ClosInstrStlmtAgtUseLndHud1.Clean
                    && ClosInstrTtlPlcyTyp.Clean
                    && EmxmlVersionId.Clean
                    && ExeClosDocDlvrdToCty.Clean
                    && ExeClosDocDlvrdToMiscTxtDesc.Clean
                    && ExeClosDocDlvrdToNm.Clean
                    && ExeClosDocDlvrdToSamePtyTypDesc.Clean
                    && ExeClosDocDlvrdToStCd.Clean
                    && ExeClosDocDlvrdToStreetAddr1.Clean
                    && ExeClosDocDlvrdToStreetAddr2.Clean
                    && ExeClosDocDlvrdToZip.Clean
                    && ExeClosDocExprDt.Clean
                    && ExeClosDocToBeRtrnd.Clean
                    && ExeClosDocToBeRtrndHrs.Clean
                    && FnlTtlePcyRecDocsSentToAddlLine1.Clean
                    && FnlTtlePcyRecDocsSentToAddlLine2.Clean
                    && FnlTtlePcyRecDocsSentToCty.Clean
                    && FnlTtlePcyRecDocsSentToNm.Clean
                    && FnlTtlePcyRecDocsSentToSamePtyTypDesc.Clean
                    && FnlTtlePcyRecDocsSentToStcd.Clean
                    && FnlTtlePcyRecDocsSentToStreetAddr1.Clean
                    && FnlTtlePcyRecDocsSentToStreetAddr2.Clean
                    && FnlTtlePcyRecDocsSentToZip.Clean
                    && HazInsurEndsmtMailToAdtlTxt.Clean
                    && HazInsurEndsmtMailToCty.Clean
                    && HazInsurEndsmtMailToNm.Clean
                    && HazInsurEndsmtMailToStCd.Clean
                    && HazInsurEndsmtMailToStreetAddr1.Clean
                    && HazInsurEndsmtMailToStreetAddr2.Clean
                    && HazInsurEndsmtMailToZip.Clean
                    && Id.Clean
                    && MersAdtlCity.Clean
                    && MersAdtlStCd.Clean
                    && MersAdtlStreetAddr1.Clean
                    && MersAdtlStreetAddr2.Clean
                    && MersAdtlZip.Clean
                    && MersCty.Clean
                    && MersJrsdctn.Clean
                    && MersName.Clean
                    && MersOrgTyp.Clean
                    && MersPhoneNum.Clean
                    && MersStCd.Clean
                    && MersStreetAddr1.Clean
                    && MersStreetAddr2.Clean
                    && MersZip.Clean
                    && NtEndrsmtPayToJrsdctn.Clean
                    && NtEndrsmtPayToOrdNm.Clean
                    && NtEndrsmtPayToOrgTyp.Clean
                    && NtEndrsmtPayToScsrsClaus.Clean
                    && NtEndrsmtSgndBy1MiscTxt.Clean
                    && NtEndrsmtSgndBy2MiscTxt.Clean
                    && NtEndrsmtSignedByNm.Clean
                    && NtEndrsmtSignedByNm2.Clean
                    && NtEndrsmtSignedByNm3.Clean
                    && NtEndrsmtSignedByTtl.Clean
                    && NtEndrsmtSignedByTtl2.Clean
                    && NtEndrsmtSignedByTtl3.Clean
                    && NtEndrsmtSignedByTyp.Clean
                    && NtEndrsmtWithoutRcrse.Clean
                    && NtEndsmtThrdPtyAddr1.Clean
                    && NtEndsmtThrdPtyAddr2.Clean
                    && NtEndsmtThrdPtyCty.Clean
                    && NtEndsmtThrdPtyJrsdctn.Clean
                    && NtEndsmtThrdPtyName.Clean
                    && NtEndsmtThrdPtyOrgTyp.Clean
                    && NtEndsmtThrdPtyPhone.Clean
                    && NtEndsmtThrdPtyScsrClaus.Clean
                    && NtEndsmtThrdPtyStCd.Clean
                    && NtEndsmtThrdPtyZip.Clean
                    && NtPayToAdtlTxt.Clean
                    && NtPayToCty.Clean
                    && NtPayToJrsdctn.Clean
                    && NtPayToNm.Clean
                    && NtPayToOrgTyp.Clean
                    && NtPayToStCd.Clean
                    && NtPayToStreetAddr1.Clean
                    && NtPayToStreetAddr2.Clean
                    && NtPayToZip.Clean
                    && PmtCpn2PayToAdtlTxt.Clean
                    && PmtCpn2PayToAdtlTxt2.Clean
                    && PmtCpn2PayToCty.Clean
                    && PmtCpn2PayToNm.Clean
                    && PmtCpn2PayToStCd.Clean
                    && PmtCpn2PayToStreetAddr1.Clean
                    && PmtCpn2PayToStreetAddr2.Clean
                    && PmtCpn2PayToZip.Clean
                    && PmtCpnPayToAdtlTxt.Clean
                    && PmtCpnPayToAdtlTxt2.Clean
                    && PmtCpnPayToCty.Clean
                    && PmtCpnPayToNm.Clean
                    && PmtCpnPayToStCd.Clean
                    && PmtCpnPayToStreetAddr1.Clean
                    && PmtCpnPayToStreetAddr2.Clean
                    && PmtCpnPayToZip.Clean
                    && PrtAdtlDateHud1.Clean
                    && PrtAllngToNtBool.Clean
                    && PrtCorpMsgAsgnBool.Clean
                    && PrtDocDtSctyIstrmtNtryAprncDt.Clean
                    && PrtIndxTilBool.Clean
                    && PrtInitBlckNtBool.Clean
                    && PrtInitBlckSctyIstrmtBool.Clean
                    && PrtInvLoanNumBool.Clean
                    && PrtInvLoanNumPmtCpn2Ind.Clean
                    && PrtInvLoanNumPmtCpnInd.Clean
                    && PrtInvLossPayeeHazInsurDisBool.Clean
                    && PrtLoanNumDeedBool.Clean
                    && PrtNtEndsmtBool.Clean
                    && PrtNtPayToCorpMsgBool.Clean
                    && PrtScsrsClausClosInstBool.Clean
                    && PrtScsrsClausHazInsurDisBool.Clean
                    && PrtScsrsClausHazInsurLtrBool.Clean
                    && PrtScsrsClausPmtCpnBool.Clean
                    && PrtSctyIstrmtCorpMsgBool.Clean
                    && RecRtrnAttnLnNmTxtDesc.Clean
                    && RecRtrnCty.Clean
                    && RecRtrnLblTxtDesc.Clean
                    && RecRtrnNm.Clean
                    && RecRtrnNmSamePtyTypDesc.Clean
                    && RecRtrnPhoneNum.Clean
                    && RecRtrnStCd.Clean
                    && RecRtrnStreetAddr1.Clean
                    && RecRtrnStreetAddr2.Clean
                    && RecRtrnTollFreePhoneNum.Clean
                    && RecRtrnZip.Clean
                    && RtrnExeClosPkgToLndBrchBool.Clean
                    && RtToCancelNtfcAdtlTxt.Clean
                    && RtToCancelNtfcCty.Clean
                    && RtToCancelNtfcEmail.Clean
                    && RtToCancelNtfcFax.Clean
                    && RtToCancelNtfcNm.Clean
                    && RtToCancelNtfcStCd.Clean
                    && RtToCancelNtfcStreetAddr1.Clean
                    && RtToCancelNtfcStreetAddr2.Clean
                    && RtToCancelNtfcZip.Clean
                    && RtToCancelTransDtTyp.Clean
                    && SctyIstrmtDCTrstFeePct.Clean
                    && SctyIstrmtDEAttyFeePct.Clean
                    && SctyIstrmtLAAttyFeePct.Clean
                    && SctyIstrmtLAMinAttyFeeAmt.Clean
                    && SctyIstrmtMDTrstFeePct.Clean
                    && SctyIstrmtMSTrstFeePct.Clean
                    && SctyIstrmtNCAttyFeePct.Clean
                    && SctyIstrmtNETrstFeePct.Clean
                    && SctyIstrmtNVAssmFeeAmt.Clean
                    && SctyIstrmtNVTrstFeePct.Clean
                    && SctyIstrmtOKAssmFeeAmt.Clean
                    && SctyIstrmtPOBoxAddr1.Clean
                    && SctyIstrmtPOBoxAddr2.Clean
                    && SctyIstrmtPrepByAdtlTxt.Clean
                    && SctyIstrmtPrepByCoNm.Clean
                    && SctyIstrmtPrepByCty.Clean
                    && SctyIstrmtPrepByIndvNm.Clean
                    && SctyIstrmtPrepByIndvTtl.Clean
                    && SctyIstrmtPrepByPhone.Clean
                    && SctyIstrmtPrepBySamePtyTypDesc.Clean
                    && SctyIstrmtPrepByStCd.Clean
                    && SctyIstrmtPrepByStreetAddr1.Clean
                    && SctyIstrmtPrepByStreetAddr2.Clean
                    && SctyIstrmtPrepByTxt.Clean
                    && SctyIstrmtPrepByZip.Clean
                    && SctyIstrmtTtlAdtlTxt.Clean
                    && SctyIstrmtTtlAdtlTxtAbvTtl.Clean
                    && SctyIstrmtVATrstFeePct.Clean
                    && Trst1Cnty.Clean
                    && Trst1Cty.Clean
                    && Trst1IndvBool.Clean
                    && Trst1Jrsdctn.Clean
                    && Trst1Nm.Clean
                    && Trst1OrgTyp.Clean
                    && Trst1Phone.Clean
                    && Trst1RsdtTxtDesc.Clean
                    && Trst1SamePtyTypDesc.Clean
                    && Trst1StCd.Clean
                    && Trst1StreetAddr1.Clean
                    && Trst1StreetAddr2.Clean
                    && Trst1Zip.Clean
                    && Trst2Cnty.Clean
                    && Trst2Cty.Clean
                    && Trst2IndvBool.Clean
                    && Trst2Jrsdctn.Clean
                    && Trst2Nm.Clean
                    && Trst2OrgTyp.Clean
                    && Trst2Phone.Clean
                    && Trst2RsdtTxtDesc.Clean
                    && Trst2SamePtyTypDesc.Clean
                    && Trst2StCd.Clean
                    && Trst2StreetAddr1.Clean
                    && Trst2StreetAddr2.Clean
                    && Trst2Zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AllngToNtPayToJrsdctn; v0.Clean = value; AllngToNtPayToJrsdctn = v0;
                var v1 = AllngToNtPayToOrdNm; v1.Clean = value; AllngToNtPayToOrdNm = v1;
                var v2 = AllngToNtPayToOrgTyp; v2.Clean = value; AllngToNtPayToOrgTyp = v2;
                var v3 = AllngToNtPayToScsrsClaus; v3.Clean = value; AllngToNtPayToScsrsClaus = v3;
                var v4 = AllngToNtSignedByNm; v4.Clean = value; AllngToNtSignedByNm = v4;
                var v5 = AllngToNtSignedByNm2; v5.Clean = value; AllngToNtSignedByNm2 = v5;
                var v6 = AllngToNtSignedByNm3; v6.Clean = value; AllngToNtSignedByNm3 = v6;
                var v7 = AllngToNtSignedByTtl; v7.Clean = value; AllngToNtSignedByTtl = v7;
                var v8 = AllngToNtSignedByTtl2; v8.Clean = value; AllngToNtSignedByTtl2 = v8;
                var v9 = AllngToNtSignedByTtl3; v9.Clean = value; AllngToNtSignedByTtl3 = v9;
                var v10 = AllngToNtSignedByTyp; v10.Clean = value; AllngToNtSignedByTyp = v10;
                var v11 = AllngToNtWithoutRcrse; v11.Clean = value; AllngToNtWithoutRcrse = v11;
                var v12 = ApnLbl; v12.Clean = value; ApnLbl = v12;
                var v13 = AsgnPrepByLblTxtDesc; v13.Clean = value; AsgnPrepByLblTxtDesc = v13;
                var v14 = AsgnRecRtrnLblTxtDesc; v14.Clean = value; AsgnRecRtrnLblTxtDesc = v14;
                var v15 = BenCty; v15.Clean = value; BenCty = v15;
                var v16 = BenJrsdctn; v16.Clean = value; BenJrsdctn = v16;
                var v17 = BenNm; v17.Clean = value; BenNm = v17;
                var v18 = BenOrgTyp; v18.Clean = value; BenOrgTyp = v18;
                var v19 = BenStCd; v19.Clean = value; BenStCd = v19;
                var v20 = BenStreetAddr1; v20.Clean = value; BenStreetAddr1 = v20;
                var v21 = BenStreetAddr2; v21.Clean = value; BenStreetAddr2 = v21;
                var v22 = BenZip; v22.Clean = value; BenZip = v22;
                var v23 = ClosInstrLndCntcInfoCity; v23.Clean = value; ClosInstrLndCntcInfoCity = v23;
                var v24 = ClosInstrLndCntcInfoCoNm; v24.Clean = value; ClosInstrLndCntcInfoCoNm = v24;
                var v25 = ClosInstrLndCntcInfoSamePtyTypDesc; v25.Clean = value; ClosInstrLndCntcInfoSamePtyTypDesc = v25;
                var v26 = ClosInstrLndCntcInfoStCd; v26.Clean = value; ClosInstrLndCntcInfoStCd = v26;
                var v27 = ClosInstrLndCntcInfoStreetAddr1; v27.Clean = value; ClosInstrLndCntcInfoStreetAddr1 = v27;
                var v28 = ClosInstrLndCntcInfoStreetAddr2; v28.Clean = value; ClosInstrLndCntcInfoStreetAddr2 = v28;
                var v29 = ClosInstrLndCntcInfoZip; v29.Clean = value; ClosInstrLndCntcInfoZip = v29;
                var v30 = ClosInstrPrtInvLossPayee; v30.Clean = value; ClosInstrPrtInvLossPayee = v30;
                var v31 = ClosInstrStlmtAgtUseLndHud1; v31.Clean = value; ClosInstrStlmtAgtUseLndHud1 = v31;
                var v32 = ClosInstrTtlPlcyTyp; v32.Clean = value; ClosInstrTtlPlcyTyp = v32;
                var v33 = EmxmlVersionId; v33.Clean = value; EmxmlVersionId = v33;
                var v34 = ExeClosDocDlvrdToCty; v34.Clean = value; ExeClosDocDlvrdToCty = v34;
                var v35 = ExeClosDocDlvrdToMiscTxtDesc; v35.Clean = value; ExeClosDocDlvrdToMiscTxtDesc = v35;
                var v36 = ExeClosDocDlvrdToNm; v36.Clean = value; ExeClosDocDlvrdToNm = v36;
                var v37 = ExeClosDocDlvrdToSamePtyTypDesc; v37.Clean = value; ExeClosDocDlvrdToSamePtyTypDesc = v37;
                var v38 = ExeClosDocDlvrdToStCd; v38.Clean = value; ExeClosDocDlvrdToStCd = v38;
                var v39 = ExeClosDocDlvrdToStreetAddr1; v39.Clean = value; ExeClosDocDlvrdToStreetAddr1 = v39;
                var v40 = ExeClosDocDlvrdToStreetAddr2; v40.Clean = value; ExeClosDocDlvrdToStreetAddr2 = v40;
                var v41 = ExeClosDocDlvrdToZip; v41.Clean = value; ExeClosDocDlvrdToZip = v41;
                var v42 = ExeClosDocExprDt; v42.Clean = value; ExeClosDocExprDt = v42;
                var v43 = ExeClosDocToBeRtrnd; v43.Clean = value; ExeClosDocToBeRtrnd = v43;
                var v44 = ExeClosDocToBeRtrndHrs; v44.Clean = value; ExeClosDocToBeRtrndHrs = v44;
                var v45 = FnlTtlePcyRecDocsSentToAddlLine1; v45.Clean = value; FnlTtlePcyRecDocsSentToAddlLine1 = v45;
                var v46 = FnlTtlePcyRecDocsSentToAddlLine2; v46.Clean = value; FnlTtlePcyRecDocsSentToAddlLine2 = v46;
                var v47 = FnlTtlePcyRecDocsSentToCty; v47.Clean = value; FnlTtlePcyRecDocsSentToCty = v47;
                var v48 = FnlTtlePcyRecDocsSentToNm; v48.Clean = value; FnlTtlePcyRecDocsSentToNm = v48;
                var v49 = FnlTtlePcyRecDocsSentToSamePtyTypDesc; v49.Clean = value; FnlTtlePcyRecDocsSentToSamePtyTypDesc = v49;
                var v50 = FnlTtlePcyRecDocsSentToStcd; v50.Clean = value; FnlTtlePcyRecDocsSentToStcd = v50;
                var v51 = FnlTtlePcyRecDocsSentToStreetAddr1; v51.Clean = value; FnlTtlePcyRecDocsSentToStreetAddr1 = v51;
                var v52 = FnlTtlePcyRecDocsSentToStreetAddr2; v52.Clean = value; FnlTtlePcyRecDocsSentToStreetAddr2 = v52;
                var v53 = FnlTtlePcyRecDocsSentToZip; v53.Clean = value; FnlTtlePcyRecDocsSentToZip = v53;
                var v54 = HazInsurEndsmtMailToAdtlTxt; v54.Clean = value; HazInsurEndsmtMailToAdtlTxt = v54;
                var v55 = HazInsurEndsmtMailToCty; v55.Clean = value; HazInsurEndsmtMailToCty = v55;
                var v56 = HazInsurEndsmtMailToNm; v56.Clean = value; HazInsurEndsmtMailToNm = v56;
                var v57 = HazInsurEndsmtMailToStCd; v57.Clean = value; HazInsurEndsmtMailToStCd = v57;
                var v58 = HazInsurEndsmtMailToStreetAddr1; v58.Clean = value; HazInsurEndsmtMailToStreetAddr1 = v58;
                var v59 = HazInsurEndsmtMailToStreetAddr2; v59.Clean = value; HazInsurEndsmtMailToStreetAddr2 = v59;
                var v60 = HazInsurEndsmtMailToZip; v60.Clean = value; HazInsurEndsmtMailToZip = v60;
                var v61 = Id; v61.Clean = value; Id = v61;
                var v62 = MersAdtlCity; v62.Clean = value; MersAdtlCity = v62;
                var v63 = MersAdtlStCd; v63.Clean = value; MersAdtlStCd = v63;
                var v64 = MersAdtlStreetAddr1; v64.Clean = value; MersAdtlStreetAddr1 = v64;
                var v65 = MersAdtlStreetAddr2; v65.Clean = value; MersAdtlStreetAddr2 = v65;
                var v66 = MersAdtlZip; v66.Clean = value; MersAdtlZip = v66;
                var v67 = MersCty; v67.Clean = value; MersCty = v67;
                var v68 = MersJrsdctn; v68.Clean = value; MersJrsdctn = v68;
                var v69 = MersName; v69.Clean = value; MersName = v69;
                var v70 = MersOrgTyp; v70.Clean = value; MersOrgTyp = v70;
                var v71 = MersPhoneNum; v71.Clean = value; MersPhoneNum = v71;
                var v72 = MersStCd; v72.Clean = value; MersStCd = v72;
                var v73 = MersStreetAddr1; v73.Clean = value; MersStreetAddr1 = v73;
                var v74 = MersStreetAddr2; v74.Clean = value; MersStreetAddr2 = v74;
                var v75 = MersZip; v75.Clean = value; MersZip = v75;
                var v76 = NtEndrsmtPayToJrsdctn; v76.Clean = value; NtEndrsmtPayToJrsdctn = v76;
                var v77 = NtEndrsmtPayToOrdNm; v77.Clean = value; NtEndrsmtPayToOrdNm = v77;
                var v78 = NtEndrsmtPayToOrgTyp; v78.Clean = value; NtEndrsmtPayToOrgTyp = v78;
                var v79 = NtEndrsmtPayToScsrsClaus; v79.Clean = value; NtEndrsmtPayToScsrsClaus = v79;
                var v80 = NtEndrsmtSgndBy1MiscTxt; v80.Clean = value; NtEndrsmtSgndBy1MiscTxt = v80;
                var v81 = NtEndrsmtSgndBy2MiscTxt; v81.Clean = value; NtEndrsmtSgndBy2MiscTxt = v81;
                var v82 = NtEndrsmtSignedByNm; v82.Clean = value; NtEndrsmtSignedByNm = v82;
                var v83 = NtEndrsmtSignedByNm2; v83.Clean = value; NtEndrsmtSignedByNm2 = v83;
                var v84 = NtEndrsmtSignedByNm3; v84.Clean = value; NtEndrsmtSignedByNm3 = v84;
                var v85 = NtEndrsmtSignedByTtl; v85.Clean = value; NtEndrsmtSignedByTtl = v85;
                var v86 = NtEndrsmtSignedByTtl2; v86.Clean = value; NtEndrsmtSignedByTtl2 = v86;
                var v87 = NtEndrsmtSignedByTtl3; v87.Clean = value; NtEndrsmtSignedByTtl3 = v87;
                var v88 = NtEndrsmtSignedByTyp; v88.Clean = value; NtEndrsmtSignedByTyp = v88;
                var v89 = NtEndrsmtWithoutRcrse; v89.Clean = value; NtEndrsmtWithoutRcrse = v89;
                var v90 = NtEndsmtThrdPtyAddr1; v90.Clean = value; NtEndsmtThrdPtyAddr1 = v90;
                var v91 = NtEndsmtThrdPtyAddr2; v91.Clean = value; NtEndsmtThrdPtyAddr2 = v91;
                var v92 = NtEndsmtThrdPtyCty; v92.Clean = value; NtEndsmtThrdPtyCty = v92;
                var v93 = NtEndsmtThrdPtyJrsdctn; v93.Clean = value; NtEndsmtThrdPtyJrsdctn = v93;
                var v94 = NtEndsmtThrdPtyName; v94.Clean = value; NtEndsmtThrdPtyName = v94;
                var v95 = NtEndsmtThrdPtyOrgTyp; v95.Clean = value; NtEndsmtThrdPtyOrgTyp = v95;
                var v96 = NtEndsmtThrdPtyPhone; v96.Clean = value; NtEndsmtThrdPtyPhone = v96;
                var v97 = NtEndsmtThrdPtyScsrClaus; v97.Clean = value; NtEndsmtThrdPtyScsrClaus = v97;
                var v98 = NtEndsmtThrdPtyStCd; v98.Clean = value; NtEndsmtThrdPtyStCd = v98;
                var v99 = NtEndsmtThrdPtyZip; v99.Clean = value; NtEndsmtThrdPtyZip = v99;
                var v100 = NtPayToAdtlTxt; v100.Clean = value; NtPayToAdtlTxt = v100;
                var v101 = NtPayToCty; v101.Clean = value; NtPayToCty = v101;
                var v102 = NtPayToJrsdctn; v102.Clean = value; NtPayToJrsdctn = v102;
                var v103 = NtPayToNm; v103.Clean = value; NtPayToNm = v103;
                var v104 = NtPayToOrgTyp; v104.Clean = value; NtPayToOrgTyp = v104;
                var v105 = NtPayToStCd; v105.Clean = value; NtPayToStCd = v105;
                var v106 = NtPayToStreetAddr1; v106.Clean = value; NtPayToStreetAddr1 = v106;
                var v107 = NtPayToStreetAddr2; v107.Clean = value; NtPayToStreetAddr2 = v107;
                var v108 = NtPayToZip; v108.Clean = value; NtPayToZip = v108;
                var v109 = PmtCpn2PayToAdtlTxt; v109.Clean = value; PmtCpn2PayToAdtlTxt = v109;
                var v110 = PmtCpn2PayToAdtlTxt2; v110.Clean = value; PmtCpn2PayToAdtlTxt2 = v110;
                var v111 = PmtCpn2PayToCty; v111.Clean = value; PmtCpn2PayToCty = v111;
                var v112 = PmtCpn2PayToNm; v112.Clean = value; PmtCpn2PayToNm = v112;
                var v113 = PmtCpn2PayToStCd; v113.Clean = value; PmtCpn2PayToStCd = v113;
                var v114 = PmtCpn2PayToStreetAddr1; v114.Clean = value; PmtCpn2PayToStreetAddr1 = v114;
                var v115 = PmtCpn2PayToStreetAddr2; v115.Clean = value; PmtCpn2PayToStreetAddr2 = v115;
                var v116 = PmtCpn2PayToZip; v116.Clean = value; PmtCpn2PayToZip = v116;
                var v117 = PmtCpnPayToAdtlTxt; v117.Clean = value; PmtCpnPayToAdtlTxt = v117;
                var v118 = PmtCpnPayToAdtlTxt2; v118.Clean = value; PmtCpnPayToAdtlTxt2 = v118;
                var v119 = PmtCpnPayToCty; v119.Clean = value; PmtCpnPayToCty = v119;
                var v120 = PmtCpnPayToNm; v120.Clean = value; PmtCpnPayToNm = v120;
                var v121 = PmtCpnPayToStCd; v121.Clean = value; PmtCpnPayToStCd = v121;
                var v122 = PmtCpnPayToStreetAddr1; v122.Clean = value; PmtCpnPayToStreetAddr1 = v122;
                var v123 = PmtCpnPayToStreetAddr2; v123.Clean = value; PmtCpnPayToStreetAddr2 = v123;
                var v124 = PmtCpnPayToZip; v124.Clean = value; PmtCpnPayToZip = v124;
                var v125 = PrtAdtlDateHud1; v125.Clean = value; PrtAdtlDateHud1 = v125;
                var v126 = PrtAllngToNtBool; v126.Clean = value; PrtAllngToNtBool = v126;
                var v127 = PrtCorpMsgAsgnBool; v127.Clean = value; PrtCorpMsgAsgnBool = v127;
                var v128 = PrtDocDtSctyIstrmtNtryAprncDt; v128.Clean = value; PrtDocDtSctyIstrmtNtryAprncDt = v128;
                var v129 = PrtIndxTilBool; v129.Clean = value; PrtIndxTilBool = v129;
                var v130 = PrtInitBlckNtBool; v130.Clean = value; PrtInitBlckNtBool = v130;
                var v131 = PrtInitBlckSctyIstrmtBool; v131.Clean = value; PrtInitBlckSctyIstrmtBool = v131;
                var v132 = PrtInvLoanNumBool; v132.Clean = value; PrtInvLoanNumBool = v132;
                var v133 = PrtInvLoanNumPmtCpn2Ind; v133.Clean = value; PrtInvLoanNumPmtCpn2Ind = v133;
                var v134 = PrtInvLoanNumPmtCpnInd; v134.Clean = value; PrtInvLoanNumPmtCpnInd = v134;
                var v135 = PrtInvLossPayeeHazInsurDisBool; v135.Clean = value; PrtInvLossPayeeHazInsurDisBool = v135;
                var v136 = PrtLoanNumDeedBool; v136.Clean = value; PrtLoanNumDeedBool = v136;
                var v137 = PrtNtEndsmtBool; v137.Clean = value; PrtNtEndsmtBool = v137;
                var v138 = PrtNtPayToCorpMsgBool; v138.Clean = value; PrtNtPayToCorpMsgBool = v138;
                var v139 = PrtScsrsClausClosInstBool; v139.Clean = value; PrtScsrsClausClosInstBool = v139;
                var v140 = PrtScsrsClausHazInsurDisBool; v140.Clean = value; PrtScsrsClausHazInsurDisBool = v140;
                var v141 = PrtScsrsClausHazInsurLtrBool; v141.Clean = value; PrtScsrsClausHazInsurLtrBool = v141;
                var v142 = PrtScsrsClausPmtCpnBool; v142.Clean = value; PrtScsrsClausPmtCpnBool = v142;
                var v143 = PrtSctyIstrmtCorpMsgBool; v143.Clean = value; PrtSctyIstrmtCorpMsgBool = v143;
                var v144 = RecRtrnAttnLnNmTxtDesc; v144.Clean = value; RecRtrnAttnLnNmTxtDesc = v144;
                var v145 = RecRtrnCty; v145.Clean = value; RecRtrnCty = v145;
                var v146 = RecRtrnLblTxtDesc; v146.Clean = value; RecRtrnLblTxtDesc = v146;
                var v147 = RecRtrnNm; v147.Clean = value; RecRtrnNm = v147;
                var v148 = RecRtrnNmSamePtyTypDesc; v148.Clean = value; RecRtrnNmSamePtyTypDesc = v148;
                var v149 = RecRtrnPhoneNum; v149.Clean = value; RecRtrnPhoneNum = v149;
                var v150 = RecRtrnStCd; v150.Clean = value; RecRtrnStCd = v150;
                var v151 = RecRtrnStreetAddr1; v151.Clean = value; RecRtrnStreetAddr1 = v151;
                var v152 = RecRtrnStreetAddr2; v152.Clean = value; RecRtrnStreetAddr2 = v152;
                var v153 = RecRtrnTollFreePhoneNum; v153.Clean = value; RecRtrnTollFreePhoneNum = v153;
                var v154 = RecRtrnZip; v154.Clean = value; RecRtrnZip = v154;
                var v155 = RtrnExeClosPkgToLndBrchBool; v155.Clean = value; RtrnExeClosPkgToLndBrchBool = v155;
                var v156 = RtToCancelNtfcAdtlTxt; v156.Clean = value; RtToCancelNtfcAdtlTxt = v156;
                var v157 = RtToCancelNtfcCty; v157.Clean = value; RtToCancelNtfcCty = v157;
                var v158 = RtToCancelNtfcEmail; v158.Clean = value; RtToCancelNtfcEmail = v158;
                var v159 = RtToCancelNtfcFax; v159.Clean = value; RtToCancelNtfcFax = v159;
                var v160 = RtToCancelNtfcNm; v160.Clean = value; RtToCancelNtfcNm = v160;
                var v161 = RtToCancelNtfcStCd; v161.Clean = value; RtToCancelNtfcStCd = v161;
                var v162 = RtToCancelNtfcStreetAddr1; v162.Clean = value; RtToCancelNtfcStreetAddr1 = v162;
                var v163 = RtToCancelNtfcStreetAddr2; v163.Clean = value; RtToCancelNtfcStreetAddr2 = v163;
                var v164 = RtToCancelNtfcZip; v164.Clean = value; RtToCancelNtfcZip = v164;
                var v165 = RtToCancelTransDtTyp; v165.Clean = value; RtToCancelTransDtTyp = v165;
                var v166 = SctyIstrmtDCTrstFeePct; v166.Clean = value; SctyIstrmtDCTrstFeePct = v166;
                var v167 = SctyIstrmtDEAttyFeePct; v167.Clean = value; SctyIstrmtDEAttyFeePct = v167;
                var v168 = SctyIstrmtLAAttyFeePct; v168.Clean = value; SctyIstrmtLAAttyFeePct = v168;
                var v169 = SctyIstrmtLAMinAttyFeeAmt; v169.Clean = value; SctyIstrmtLAMinAttyFeeAmt = v169;
                var v170 = SctyIstrmtMDTrstFeePct; v170.Clean = value; SctyIstrmtMDTrstFeePct = v170;
                var v171 = SctyIstrmtMSTrstFeePct; v171.Clean = value; SctyIstrmtMSTrstFeePct = v171;
                var v172 = SctyIstrmtNCAttyFeePct; v172.Clean = value; SctyIstrmtNCAttyFeePct = v172;
                var v173 = SctyIstrmtNETrstFeePct; v173.Clean = value; SctyIstrmtNETrstFeePct = v173;
                var v174 = SctyIstrmtNVAssmFeeAmt; v174.Clean = value; SctyIstrmtNVAssmFeeAmt = v174;
                var v175 = SctyIstrmtNVTrstFeePct; v175.Clean = value; SctyIstrmtNVTrstFeePct = v175;
                var v176 = SctyIstrmtOKAssmFeeAmt; v176.Clean = value; SctyIstrmtOKAssmFeeAmt = v176;
                var v177 = SctyIstrmtPOBoxAddr1; v177.Clean = value; SctyIstrmtPOBoxAddr1 = v177;
                var v178 = SctyIstrmtPOBoxAddr2; v178.Clean = value; SctyIstrmtPOBoxAddr2 = v178;
                var v179 = SctyIstrmtPrepByAdtlTxt; v179.Clean = value; SctyIstrmtPrepByAdtlTxt = v179;
                var v180 = SctyIstrmtPrepByCoNm; v180.Clean = value; SctyIstrmtPrepByCoNm = v180;
                var v181 = SctyIstrmtPrepByCty; v181.Clean = value; SctyIstrmtPrepByCty = v181;
                var v182 = SctyIstrmtPrepByIndvNm; v182.Clean = value; SctyIstrmtPrepByIndvNm = v182;
                var v183 = SctyIstrmtPrepByIndvTtl; v183.Clean = value; SctyIstrmtPrepByIndvTtl = v183;
                var v184 = SctyIstrmtPrepByPhone; v184.Clean = value; SctyIstrmtPrepByPhone = v184;
                var v185 = SctyIstrmtPrepBySamePtyTypDesc; v185.Clean = value; SctyIstrmtPrepBySamePtyTypDesc = v185;
                var v186 = SctyIstrmtPrepByStCd; v186.Clean = value; SctyIstrmtPrepByStCd = v186;
                var v187 = SctyIstrmtPrepByStreetAddr1; v187.Clean = value; SctyIstrmtPrepByStreetAddr1 = v187;
                var v188 = SctyIstrmtPrepByStreetAddr2; v188.Clean = value; SctyIstrmtPrepByStreetAddr2 = v188;
                var v189 = SctyIstrmtPrepByTxt; v189.Clean = value; SctyIstrmtPrepByTxt = v189;
                var v190 = SctyIstrmtPrepByZip; v190.Clean = value; SctyIstrmtPrepByZip = v190;
                var v191 = SctyIstrmtTtlAdtlTxt; v191.Clean = value; SctyIstrmtTtlAdtlTxt = v191;
                var v192 = SctyIstrmtTtlAdtlTxtAbvTtl; v192.Clean = value; SctyIstrmtTtlAdtlTxtAbvTtl = v192;
                var v193 = SctyIstrmtVATrstFeePct; v193.Clean = value; SctyIstrmtVATrstFeePct = v193;
                var v194 = Trst1Cnty; v194.Clean = value; Trst1Cnty = v194;
                var v195 = Trst1Cty; v195.Clean = value; Trst1Cty = v195;
                var v196 = Trst1IndvBool; v196.Clean = value; Trst1IndvBool = v196;
                var v197 = Trst1Jrsdctn; v197.Clean = value; Trst1Jrsdctn = v197;
                var v198 = Trst1Nm; v198.Clean = value; Trst1Nm = v198;
                var v199 = Trst1OrgTyp; v199.Clean = value; Trst1OrgTyp = v199;
                var v200 = Trst1Phone; v200.Clean = value; Trst1Phone = v200;
                var v201 = Trst1RsdtTxtDesc; v201.Clean = value; Trst1RsdtTxtDesc = v201;
                var v202 = Trst1SamePtyTypDesc; v202.Clean = value; Trst1SamePtyTypDesc = v202;
                var v203 = Trst1StCd; v203.Clean = value; Trst1StCd = v203;
                var v204 = Trst1StreetAddr1; v204.Clean = value; Trst1StreetAddr1 = v204;
                var v205 = Trst1StreetAddr2; v205.Clean = value; Trst1StreetAddr2 = v205;
                var v206 = Trst1Zip; v206.Clean = value; Trst1Zip = v206;
                var v207 = Trst2Cnty; v207.Clean = value; Trst2Cnty = v207;
                var v208 = Trst2Cty; v208.Clean = value; Trst2Cty = v208;
                var v209 = Trst2IndvBool; v209.Clean = value; Trst2IndvBool = v209;
                var v210 = Trst2Jrsdctn; v210.Clean = value; Trst2Jrsdctn = v210;
                var v211 = Trst2Nm; v211.Clean = value; Trst2Nm = v211;
                var v212 = Trst2OrgTyp; v212.Clean = value; Trst2OrgTyp = v212;
                var v213 = Trst2Phone; v213.Clean = value; Trst2Phone = v213;
                var v214 = Trst2RsdtTxtDesc; v214.Clean = value; Trst2RsdtTxtDesc = v214;
                var v215 = Trst2SamePtyTypDesc; v215.Clean = value; Trst2SamePtyTypDesc = v215;
                var v216 = Trst2StCd; v216.Clean = value; Trst2StCd = v216;
                var v217 = Trst2StreetAddr1; v217.Clean = value; Trst2StreetAddr1 = v217;
                var v218 = Trst2StreetAddr2; v218.Clean = value; Trst2StreetAddr2 = v218;
                var v219 = Trst2Zip; v219.Clean = value; Trst2Zip = v219;
                _settingClean = 0;
            }
        }
    }
}