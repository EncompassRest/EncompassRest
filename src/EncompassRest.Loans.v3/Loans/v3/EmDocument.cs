using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EmDocument
/// </summary>
public sealed partial class EmDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to Jurisdiction [Closing.AllngToNtPayToJrsdctn]
    /// </summary>
    public string? AllngToNtPayToJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to the Order of Name [Closing.AllngToNtPayToOrdNm]
    /// </summary>
    public string? AllngToNtPayToOrdNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to Organization Type [Closing.AllngToNtPayToOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> AllngToNtPayToOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to Successor Clause  [Closing.AllngToNtPayToScsrsClaus]
    /// </summary>
    public string? AllngToNtPayToScsrsClaus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Name [Closing.AllngToNtSignedByNm]
    /// </summary>
    public string? AllngToNtSignedByNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 2 [Closing.AllngToNtSignedByNm2]
    /// </summary>
    public string? AllngToNtSignedByNm2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Signed By Name 3 [Closing.AllngToNtSignedByNm3]
    /// </summary>
    public string? AllngToNtSignedByNm3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Pay to Signed By Title [Closing.AllngToNtSignedByTtl]
    /// </summary>
    public string? AllngToNtSignedByTtl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 2 [Closing.AllngToNtSignedByTtl2]
    /// </summary>
    public string? AllngToNtSignedByTtl2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Signed By Title 3 [Closing.AllngToNtSignedByTtl3]
    /// </summary>
    public string? AllngToNtSignedByTtl3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Signed By Type [Closing.AllngToNtSignedByTyp]
    /// </summary>
    public StringEnumValue<SignedByTyp> AllngToNtSignedByTyp { get => GetValue<StringEnumValue<SignedByTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Allonge to Note Without Recourse Add'l Text [Closing.AllngToNtWithoutRcrse]
    /// </summary>
    public string? AllngToNtWithoutRcrse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - APN # Label [Closing.ApnLbl]
    /// </summary>
    public string? ApnLbl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Assignment Prepared By Label Text [Closing.AsgnPrepByLblTxtDesc]
    /// </summary>
    public bool? AsgnPrepByLblTxtDesc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Assignment Rec. and Return Label Text [Closing.AsgnRecRtrnLblTxtDesc]
    /// </summary>
    public bool? AsgnRecRtrnLblTxtDesc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary City [Closing.BenCty]
    /// </summary>
    public string? BenCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Jurisdiction [Closing.BenJrsdctn]
    /// </summary>
    public string? BenJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Name [Closing.BenNm]
    /// </summary>
    public string? BenNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Organization Type [Closing.BenOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> BenOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary State Code [Closing.BenStCd]
    /// </summary>
    public string? BenStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Street Address [Closing.BenStreetAddr1]
    /// </summary>
    public string? BenStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Street Address 2 [Closing.BenStreetAddr2]
    /// </summary>
    public string? BenStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Beneficiary Postal Code [Closing.BenZip]
    /// </summary>
    public string? BenZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact City [Closing.ClosInstrLndCntcInfoCity]
    /// </summary>
    public string? ClosInstrLndCntcInfoCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact Company Name [Closing.ClosInstrLndCntcInfoCoNm]
    /// </summary>
    public string? ClosInstrLndCntcInfoCoNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact-Same as Another Party [Closing.ClosInstrLndCntcInfoSamePtyTypDesc]
    /// </summary>
    public StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc> ClosInstrLndCntcInfoSamePtyTypDesc { get => GetValue<StringEnumValue<ClosInstrLndCntcInfoSamePtyTypDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact State Code [Closing.ClosInstrLndCntcInfoStCd]
    /// </summary>
    public string? ClosInstrLndCntcInfoStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 1 [Closing.ClosInstrLndCntcInfoStreetAddr1]
    /// </summary>
    public string? ClosInstrLndCntcInfoStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact Address 2 [Closing.ClosInstrLndCntcInfoStreetAddr2]
    /// </summary>
    public string? ClosInstrLndCntcInfoStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Contact Zip Code [Closing.ClosInstrLndCntcInfoZip]
    /// </summary>
    public string? ClosInstrLndCntcInfoZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Print Investor Loss Payee [Closing.ClosInstrPrtInvLossPayee]
    /// </summary>
    public bool? ClosInstrPrtInvLossPayee { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Settlement Agent to use Lender HUD-1 [Closing.ClosInstrStlmtAgtUseLndHud1]
    /// </summary>
    public bool? ClosInstrStlmtAgtUseLndHud1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Closing Instructions Title Policy Type [Closing.ClosInstrTtlPlcyTyp]
    /// </summary>
    public StringEnumValue<ClosInstrTtlPlcyTyp> ClosInstrTtlPlcyTyp { get => GetValue<StringEnumValue<ClosInstrTtlPlcyTyp>>(); set => SetValue(value); }

    /// <summary>
    /// EmDocument EmxmlVersionId
    /// </summary>
    public string? EmxmlVersionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To city [Closing.ExeClosDocDlvrdToCty]
    /// </summary>
    public string? ExeClosDocDlvrdToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Miscellaneous Text Description  [Closing.ExeClosDocDlvrdToMiscTxtDesc]
    /// </summary>
    public string? ExeClosDocDlvrdToMiscTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Name [Closing.ExeClosDocDlvrdToNm]
    /// </summary>
    public string? ExeClosDocDlvrdToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Docs to be Delivered to the same party as [Closing.ExeClosDocDlvrdToSamePtyTypDesc]
    /// </summary>
    public StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc> ExeClosDocDlvrdToSamePtyTypDesc { get => GetValue<StringEnumValue<ExeClosDocDlvrdToSamePtyTypDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To state [Closing.ExeClosDocDlvrdToStCd]
    /// </summary>
    public string? ExeClosDocDlvrdToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address [Closing.ExeClosDocDlvrdToStreetAddr1]
    /// </summary>
    public string? ExeClosDocDlvrdToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Street Address 2 [Closing.ExeClosDocDlvrdToStreetAddr2]
    /// </summary>
    public string? ExeClosDocDlvrdToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Delivered To Zip [Closing.ExeClosDocDlvrdToZip]
    /// </summary>
    public string? ExeClosDocDlvrdToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents Expiration Date [Closing.ExeClosDocExprDt]
    /// </summary>
    public StringEnumValue<ExeClosDocExprDt> ExeClosDocExprDt { get => GetValue<StringEnumValue<ExeClosDocExprDt>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned [Closing.ExeClosDocToBeRtrnd]
    /// </summary>
    public StringEnumValue<ExeClosDocToBeRtrnd> ExeClosDocToBeRtrnd { get => GetValue<StringEnumValue<ExeClosDocToBeRtrnd>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Executed Closing Documents to be Returned Hours [Closing.ExeClosDocToBeRtrndHrs]
    /// </summary>
    public StringEnumValue<ExeClosDocToBeRtrndHrs> ExeClosDocToBeRtrndHrs { get => GetValue<StringEnumValue<ExeClosDocToBeRtrndHrs>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Addition line 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine1]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToAddlLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Addition line 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToAddlLine2]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToAddlLine2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - city of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToCty]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Company Name of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToNm]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Final Title Policy and Recorded Docs to be sent to the same party as  [Closing.FnlTtlePcyRecDocsSentToSamePtyTypDesc]
    /// </summary>
    public StringEnumValue<RecSamePtyTypeDesc> FnlTtlePcyRecDocsSentToSamePtyTypDesc { get => GetValue<StringEnumValue<RecSamePtyTypeDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStcd]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToStcd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - address 1 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr1]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - address 2 of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToStreetAddr2]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - state of Final Title Policy and Recorded Docs to be sent to  [Closing.FnlTtlePcyRecDocsSentToZip]
    /// </summary>
    public string? FnlTtlePcyRecDocsSentToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Additional Text [Closing.HazInsurEndsmtMailToAdtlTxt]
    /// </summary>
    public string? HazInsurEndsmtMailToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To City [Closing.HazInsurEndsmtMailToCty]
    /// </summary>
    public string? HazInsurEndsmtMailToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Name [Closing.HazInsurEndsmtMailToNm]
    /// </summary>
    public string? HazInsurEndsmtMailToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To State Code [Closing.HazInsurEndsmtMailToStCd]
    /// </summary>
    public string? HazInsurEndsmtMailToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address [Closing.HazInsurEndsmtMailToStreetAddr1]
    /// </summary>
    public string? HazInsurEndsmtMailToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Street Address 2 [Closing.HazInsurEndsmtMailToStreetAddr2]
    /// </summary>
    public string? HazInsurEndsmtMailToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Hazard Insurance Endorsement Mail To Postal Code [Closing.HazInsurEndsmtMailToZip]
    /// </summary>
    public string? HazInsurEndsmtMailToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Additional City [Closing.MersAdtlCity]
    /// </summary>
    public string? MersAdtlCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Additional State Code [Closing.MersAdtlStCd]
    /// </summary>
    public string? MersAdtlStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Additional Street Address line 1 [Closing.MersAdtlStreetAddr1]
    /// </summary>
    public string? MersAdtlStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Additional Street Address line 2 [Closing.MersAdtlStreetAddr2]
    /// </summary>
    public string? MersAdtlStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Additional Postal Code [Closing.MersAdtlZip]
    /// </summary>
    public string? MersAdtlZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS City [Closing.MersCty]
    /// </summary>
    public string? MersCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Jurisdiction [Closing.MersJrsdctn]
    /// </summary>
    public string? MersJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Name [Closing.MersName]
    /// </summary>
    public string? MersName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Organization Type [Closing.MersOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> MersOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Telephone No. [Closing.MersPhoneNum]
    /// </summary>
    public string? MersPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS State Code [Closing.MersStCd]
    /// </summary>
    public string? MersStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Street Address [Closing.MersStreetAddr1]
    /// </summary>
    public string? MersStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Street Address 2 [Closing.MersStreetAddr2]
    /// </summary>
    public string? MersStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MERS Postal Code [Closing.MersZip]
    /// </summary>
    public string? MersZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Pay To Jurisdiction [Closing.NtEndrsmtPayToJrsdctn]
    /// </summary>
    public string? NtEndrsmtPayToJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Pay to the Order of Name [Closing.NtEndrsmtPayToOrdNm]
    /// </summary>
    public string? NtEndrsmtPayToOrdNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Pay To Organization Type [Closing.NtEndrsmtPayToOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> NtEndrsmtPayToOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Pay To Successor Clause [Closing.NtEndrsmtPayToScsrsClaus]
    /// </summary>
    public string? NtEndrsmtPayToScsrsClaus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed Additional text [Closing.NtEndrsmtSgndBy1MiscTxt]
    /// </summary>
    public string? NtEndrsmtSgndBy1MiscTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 additional text [Closing.NtEndrsmtSgndBy2MiscTxt]
    /// </summary>
    public string? NtEndrsmtSgndBy2MiscTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsment Signed By Name [Closing.NtEndrsmtSignedByNm]
    /// </summary>
    public string? NtEndrsmtSignedByNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 2 [Closing.NtEndrsmtSignedByNm2]
    /// </summary>
    public string? NtEndrsmtSignedByNm2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Name 3 [Closing.NtEndrsmtSignedByNm3]
    /// </summary>
    public string? NtEndrsmtSignedByNm3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title [Closing.NtEndrsmtSignedByTtl]
    /// </summary>
    public string? NtEndrsmtSignedByTtl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 2 [Closing.NtEndrsmtSignedByTtl2]
    /// </summary>
    public string? NtEndrsmtSignedByTtl2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Title 3 [Closing.NtEndrsmtSignedByTtl3]
    /// </summary>
    public string? NtEndrsmtSignedByTtl3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Signed By Type [Closing.NtEndrsmtSignedByTyp]
    /// </summary>
    public StringEnumValue<SignedByTyp> NtEndrsmtSignedByTyp { get => GetValue<StringEnumValue<SignedByTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Endorsement Without Recourse Add'l Text [Closing.NtEndrsmtWithoutRcrse]
    /// </summary>
    public string? NtEndrsmtWithoutRcrse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 1 [Closing.NtEndsmtThrdPtyAddr1]
    /// </summary>
    public string? NtEndsmtThrdPtyAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Address line 2 [Closing.NtEndsmtThrdPtyAddr2]
    /// </summary>
    public string? NtEndsmtThrdPtyAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party City [Closing.NtEndsmtThrdPtyCty]
    /// </summary>
    public string? NtEndsmtThrdPtyCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Jurisdiction [Closing.NtEndsmtThrdPtyJrsdctn]
    /// </summary>
    public string? NtEndsmtThrdPtyJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Name [Closing.NtEndsmtThrdPtyName]
    /// </summary>
    public string? NtEndsmtThrdPtyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Org Type [Closing.NtEndsmtThrdPtyOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> NtEndsmtThrdPtyOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Phone [Closing.NtEndsmtThrdPtyPhone]
    /// </summary>
    public string? NtEndsmtThrdPtyPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Successor Clause [Closing.NtEndsmtThrdPtyScsrClaus]
    /// </summary>
    public StringEnumValue<ScsrsClaus> NtEndsmtThrdPtyScsrClaus { get => GetValue<StringEnumValue<ScsrsClaus>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party State [Closing.NtEndsmtThrdPtyStCd]
    /// </summary>
    public string? NtEndsmtThrdPtyStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - 4506/4506-T Third Party Zip [Closing.NtEndsmtThrdPtyZip]
    /// </summary>
    public string? NtEndsmtThrdPtyZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Additional Text [Closing.NtPayToAdtlTxt]
    /// </summary>
    public string? NtPayToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To City [Closing.NtPayToCty]
    /// </summary>
    public string? NtPayToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Jurisdiction [Closing.NtPayToJrsdctn]
    /// </summary>
    public string? NtPayToJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Name [Closing.NtPayToNm]
    /// </summary>
    public string? NtPayToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Organization Type [Closing.NtPayToOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> NtPayToOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To State Code [Closing.NtPayToStCd]
    /// </summary>
    public string? NtPayToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Street Address [Closing.NtPayToStreetAddr1]
    /// </summary>
    public string? NtPayToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Street Address 2 [Closing.NtPayToStreetAddr2]
    /// </summary>
    public string? NtPayToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Note Pay To Postal Code [Closing.NtPayToZip]
    /// </summary>
    public string? NtPayToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text Description  [Closing.PmtCpn2PayToAdtlTxt]
    /// </summary>
    public string? PmtCpn2PayToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Miscellaneous Text 2 Description [Closing.PmtCpn2PayToAdtlTxt2]
    /// </summary>
    public string? PmtCpn2PayToAdtlTxt2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To City [Closing.PmtCpn2PayToCty]
    /// </summary>
    public string? PmtCpn2PayToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Name [Closing.PmtCpn2PayToNm]
    /// </summary>
    public string? PmtCpn2PayToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To State Code [Closing.PmtCpn2PayToStCd]
    /// </summary>
    public string? PmtCpn2PayToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address [Closing.PmtCpn2PayToStreetAddr1]
    /// </summary>
    public string? PmtCpn2PayToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Street Address 2 [Closing.PmtCpn2PayToStreetAddr2]
    /// </summary>
    public string? PmtCpn2PayToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 2 Pay To Postal Code [Closing.PmtCpn2PayToZip]
    /// </summary>
    public string? PmtCpn2PayToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 1 [Closing.PmtCpnPayToAdtlTxt]
    /// </summary>
    public string? PmtCpnPayToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Additional Text 2 [Closing.PmtCpnPayToAdtlTxt2]
    /// </summary>
    public string? PmtCpnPayToAdtlTxt2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To City [Closing.PmtCpnPayToCty]
    /// </summary>
    public string? PmtCpnPayToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Name [Closing.PmtCpnPayToNm]
    /// </summary>
    public string? PmtCpnPayToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To State Code [Closing.PmtCpnPayToStCd]
    /// </summary>
    public string? PmtCpnPayToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address [Closing.PmtCpnPayToStreetAddr1]
    /// </summary>
    public string? PmtCpnPayToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Street Address 2 [Closing.PmtCpnPayToStreetAddr2]
    /// </summary>
    public string? PmtCpnPayToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Payment Coupon 1 Pay To Postal Code [Closing.PmtCpnPayToZip]
    /// </summary>
    public string? PmtCpnPayToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Additional Settlement Date on HUD1 [Closing.PrtAdtlDateHud1]
    /// </summary>
    public StringEnumValue<PrtAdtlDateHud1> PrtAdtlDateHud1 { get => GetValue<StringEnumValue<PrtAdtlDateHud1>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Allonge to Note [Closing.PrtAllngToNtBool]
    /// </summary>
    public bool? PrtAllngToNtBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Assignment Corp. Message [Closing.PrtCorpMsgAsgnBool]
    /// </summary>
    public bool? PrtCorpMsgAsgnBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Document Data as Security Instrument Notary Appearance Date Indicator [Closing.PrtDocDtSctyIstrmtNtryAprncDt]
    /// </summary>
    public StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt> PrtDocDtSctyIstrmtNtryAprncDt { get => GetValue<StringEnumValue<PrtDocDtSctyIstrmtNtryAprncDt>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Index on TIL [Closing.PrtIndxTilBool]
    /// </summary>
    public bool? PrtIndxTilBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Borrower Initial Line on Note Indicator [Closing.PrtInitBlckNtBool]
    /// </summary>
    public bool? PrtInitBlckNtBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Initial Line on Sec. Instr. [Closing.PrtInitBlckSctyIstrmtBool]
    /// </summary>
    public bool? PrtInitBlckSctyIstrmtBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Investor Loan Number Indicator [Closing.PrtInvLoanNumBool]
    /// </summary>
    public bool? PrtInvLoanNumBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 2 Indicator [Closing.PrtInvLoanNumPmtCpn2Ind]
    /// </summary>
    public bool? PrtInvLoanNumPmtCpn2Ind { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Investor Loan Number On Payment Coupon 1 Indicator [Closing.PrtInvLoanNumPmtCpnInd]
    /// </summary>
    public bool? PrtInvLoanNumPmtCpnInd { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Investor Loss Payee on Hazard Insurance Disclosure [Closing.PrtInvLossPayeeHazInsurDisBool]
    /// </summary>
    public bool? PrtInvLossPayeeHazInsurDisBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Loan No. On Sec. Instr. [Closing.PrtLoanNumDeedBool]
    /// </summary>
    public bool? PrtLoanNumDeedBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Note Endorsement [Closing.PrtNtEndsmtBool]
    /// </summary>
    public bool? PrtNtEndsmtBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Note Pay To Corp. Message [Closing.PrtNtPayToCorpMsgBool]
    /// </summary>
    public bool? PrtNtPayToCorpMsgBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Successors Clause Text on Closing Instructions [Closing.PrtScsrsClausClosInstBool]
    /// </summary>
    public bool? PrtScsrsClausClosInstBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Successors Clause on Hazard Insurance Disclosure [Closing.PrtScsrsClausHazInsurDisBool]
    /// </summary>
    public bool? PrtScsrsClausHazInsurDisBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Successors Clause Text Hazard Endorse. Letter [Closing.PrtScsrsClausHazInsurLtrBool]
    /// </summary>
    public bool? PrtScsrsClausHazInsurLtrBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Successors Clause Text on Payment Coupon [Closing.PrtScsrsClausPmtCpnBool]
    /// </summary>
    public bool? PrtScsrsClausPmtCpnBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Sec. Instr. Corp. Message [Closing.PrtSctyIstrmtCorpMsgBool]
    /// </summary>
    public bool? PrtSctyIstrmtCorpMsgBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Attention Line Name or Text Description [Closing.RecRtrnAttnLnNmTxtDesc]
    /// </summary>
    public string? RecRtrnAttnLnNmTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return City [Closing.RecRtrnCty]
    /// </summary>
    public string? RecRtrnCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Label Text Description [Closing.RecRtrnLblTxtDesc]
    /// </summary>
    public string? RecRtrnLblTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Name [Closing.RecRtrnNm]
    /// </summary>
    public string? RecRtrnNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Name same as another party [Closing.RecRtrnNmSamePtyTypDesc]
    /// </summary>
    public StringEnumValue<RecSamePtyTypeDesc> RecRtrnNmSamePtyTypDesc { get => GetValue<StringEnumValue<RecSamePtyTypeDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Telephone Number [Closing.RecRtrnPhoneNum]
    /// </summary>
    public string? RecRtrnPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return State Code [Closing.RecRtrnStCd]
    /// </summary>
    public string? RecRtrnStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Street Address [Closing.RecRtrnStreetAddr1]
    /// </summary>
    public string? RecRtrnStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Street Address 2 [Closing.RecRtrnStreetAddr2]
    /// </summary>
    public string? RecRtrnStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Toll-Free Telephone Number [Closing.RecRtrnTollFreePhoneNum]
    /// </summary>
    public string? RecRtrnTollFreePhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Record And Return Postal Code [Closing.RecRtrnZip]
    /// </summary>
    public string? RecRtrnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Return Executed Closing Package to Lender Branch Indicator [Closing.RtrnExeClosPkgToLndBrchBool]
    /// </summary>
    public bool? RtrnExeClosPkgToLndBrchBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Miscellaneous Text Description  [Closing.RtToCancelNtfcAdtlTxt]
    /// </summary>
    public string? RtToCancelNtfcAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification City [Closing.RtToCancelNtfcCty]
    /// </summary>
    public string? RtToCancelNtfcCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Email [Closing.RtToCancelNtfcEmail]
    /// </summary>
    public string? RtToCancelNtfcEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Fax [Closing.RtToCancelNtfcFax]
    /// </summary>
    public string? RtToCancelNtfcFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Name [Closing.RtToCancelNtfcNm]
    /// </summary>
    public string? RtToCancelNtfcNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification State Code [Closing.RtToCancelNtfcStCd]
    /// </summary>
    public string? RtToCancelNtfcStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address [Closing.RtToCancelNtfcStreetAddr1]
    /// </summary>
    public string? RtToCancelNtfcStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Street Address 2 [Closing.RtToCancelNtfcStreetAddr2]
    /// </summary>
    public string? RtToCancelNtfcStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Notification Postal Code [Closing.RtToCancelNtfcZip]
    /// </summary>
    public string? RtToCancelNtfcZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Right To Cancel Transaction Date [Closing.RtToCancelTransDtTyp]
    /// </summary>
    public StringEnumValue<RtToCancelTransDtTyp> RtToCancelTransDtTyp { get => GetValue<StringEnumValue<RtToCancelTransDtTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - DC Trustee Fee [Closing.SctyIstrmtDCTrstFeePct]
    /// </summary>
    public string? SctyIstrmtDcTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - DE Attorney Fee [Closing.SctyIstrmtDEAttyFeePct]
    /// </summary>
    public string? SctyIstrmtDeAttyFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - LA Attorney Fee Percent [Closing.SctyIstrmtLAAttyFeePct]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SctyIstrmtLaAttyFeePct { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - LA Minimum Attorney Fee Amount [Closing.SctyIstrmtLAMinAttyFeeAmt]
    /// </summary>
    public decimal? SctyIstrmtLaMinAttyFeeAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MD Trustee Fee [Closing.SctyIstrmtMDTrstFeePct]
    /// </summary>
    public string? SctyIstrmtMdTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - MS Trustee Fee [Closing.SctyIstrmtMSTrstFeePct]
    /// </summary>
    public string? SctyIstrmtMsTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - NC Trustee Fee [Closing.SctyIstrmtNCAttyFeePct]
    /// </summary>
    public string? SctyIstrmtNcAttyFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - NE Trustee Fee [Closing.SctyIstrmtNETrstFeePct]
    /// </summary>
    public string? SctyIstrmtNeTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - NV Assumption Fee [Closing.SctyIstrmtNVAssmFeeAmt]
    /// </summary>
    public string? SctyIstrmtNvAssmFeeAmt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - NV Trustee Fee [Closing.SctyIstrmtNVTrstFeePct]
    /// </summary>
    public string? SctyIstrmtNvTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - OK Assumption Fee [Closing.SctyIstrmtOKAssmFeeAmt]
    /// </summary>
    public string? SctyIstrmtOkAssmFeeAmt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender P.O. Box Address  1 [Closing.SctyIstrmtPOBoxAddr1]
    /// </summary>
    public string? SctyIstrmtPoBoxAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender P.O. Box Address  2 [Closing.SctyIstrmtPOBoxAddr2]
    /// </summary>
    public string? SctyIstrmtPoBoxAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Additional Text [Closing.SctyIstrmtPrepByAdtlTxt]
    /// </summary>
    public string? SctyIstrmtPrepByAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Company Name [Closing.SctyIstrmtPrepByCoNm]
    /// </summary>
    public string? SctyIstrmtPrepByCoNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By City [Closing.SctyIstrmtPrepByCty]
    /// </summary>
    public string? SctyIstrmtPrepByCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Name [Closing.SctyIstrmtPrepByIndvNm]
    /// </summary>
    public string? SctyIstrmtPrepByIndvNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Individual Title [Closing.SctyIstrmtPrepByIndvTtl]
    /// </summary>
    public string? SctyIstrmtPrepByIndvTtl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Telephone Number [Closing.SctyIstrmtPrepByPhone]
    /// </summary>
    public string? SctyIstrmtPrepByPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Same as Another Party [Closing.SctyIstrmtPrepBySamePtyTypDesc]
    /// </summary>
    public StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc> SctyIstrmtPrepBySamePtyTypDesc { get => GetValue<StringEnumValue<SctyIstrmtPrepBySamePtyTypDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By State Code [Closing.SctyIstrmtPrepByStCd]
    /// </summary>
    public string? SctyIstrmtPrepByStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 1 [Closing.SctyIstrmtPrepByStreetAddr1]
    /// </summary>
    public string? SctyIstrmtPrepByStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Street Address 2 [Closing.SctyIstrmtPrepByStreetAddr2]
    /// </summary>
    public string? SctyIstrmtPrepByStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Sec. Instr. Prepared By Text [Closing.SctyIstrmtPrepByTxt]
    /// </summary>
    public string? SctyIstrmtPrepByTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Security Instrument Prepared By Postal Code [Closing.SctyIstrmtPrepByZip]
    /// </summary>
    public string? SctyIstrmtPrepByZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Sec. Instr. Title Addl. Text [Closing.SctyIstrmtTtlAdtlTxt]
    /// </summary>
    public string? SctyIstrmtTtlAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Print Addl. Text Above Title [Closing.SctyIstrmtTtlAdtlTxtAbvTtl]
    /// </summary>
    public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - VA Trustee Fee [Closing.SctyIstrmtVATrstFeePct]
    /// </summary>
    public string? SctyIstrmtVaTrstFeePct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 County [Closing.Trst1Cnty]
    /// </summary>
    public string? Trst1Cnty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 City [Closing.Trst1Cty]
    /// </summary>
    public string? Trst1Cty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmDocument Trst1IndvBool
    /// </summary>
    public bool? Trst1IndvBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Jurisdiction [Closing.Trst1Jrsdctn]
    /// </summary>
    public string? Trst1Jrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Name [Closing.Trst1Nm]
    /// </summary>
    public string? Trst1Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Organization Type [Closing.Trst1OrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> Trst1OrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Phone Number [Closing.Trst1Phone]
    /// </summary>
    public string? Trst1Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Is Resident Of Text Description [Closing.Trst1RsdtTxtDesc]
    /// </summary>
    public string? Trst1RsdtTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Same As Party Type Description [Closing.Trst1SamePtyTypDesc]
    /// </summary>
    public StringEnumValue<TrstSamePtyTypDesc> Trst1SamePtyTypDesc { get => GetValue<StringEnumValue<TrstSamePtyTypDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 State Code [Closing.Trst1StCd]
    /// </summary>
    public string? Trst1StCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Street Address [Closing.Trst1StreetAddr1]
    /// </summary>
    public string? Trst1StreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Street Address 2 [Closing.Trst1StreetAddr2]
    /// </summary>
    public string? Trst1StreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 1 Postal Code [Closing.Trst1Zip]
    /// </summary>
    public string? Trst1Zip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 County [Closing.Trst2Cnty]
    /// </summary>
    public string? Trst2Cnty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 City [Closing.Trst2Cty]
    /// </summary>
    public string? Trst2Cty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EmDocument Trst2IndvBool
    /// </summary>
    public bool? Trst2IndvBool { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Jurisdiction [Closing.Trst2Jrsdctn]
    /// </summary>
    public string? Trst2Jrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Name [Closing.Trst2Nm]
    /// </summary>
    public string? Trst2Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Organization Type [Closing.Trst2OrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> Trst2OrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Phone Number [Closing.Trst2Phone]
    /// </summary>
    public string? Trst2Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Is Resident Of Text Description [Closing.Trst2RsdtTxtDesc]
    /// </summary>
    public string? Trst2RsdtTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Same As Party Type Description [Closing.Trst2SamePtyTypDesc]
    /// </summary>
    public StringEnumValue<TrstSamePtyTypDesc> Trst2SamePtyTypDesc { get => GetValue<StringEnumValue<TrstSamePtyTypDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 State Code [Closing.Trst2StCd]
    /// </summary>
    public string? Trst2StCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Street Address [Closing.Trst2StreetAddr1]
    /// </summary>
    public string? Trst2StreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Street Address 2 [Closing.Trst2StreetAddr2]
    /// </summary>
    public string? Trst2StreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Trustee 2 Postal Code [Closing.Trst2Zip]
    /// </summary>
    public string? Trst2Zip { get => GetValue<string?>(); set => SetValue(value); }
}