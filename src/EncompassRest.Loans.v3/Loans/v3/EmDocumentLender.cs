using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EmDocumentLender
/// </summary>
public sealed partial class EmDocumentLender : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch City [Closing.LndBrchCty]
    /// </summary>
    public string? LndBrchCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch FAX Number [Closing.LndBrchFax]
    /// </summary>
    public string? LndBrchFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Jurisdiction [Closing.LndBrchJrsdctn]
    /// </summary>
    public string? LndBrchJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Name [Closing.LndBrchNm]
    /// </summary>
    public string? LndBrchNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Organization Type [Closing.LndBrchOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> LndBrchOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Telephone Number [Closing.LndBrchPhone]
    /// </summary>
    public string? LndBrchPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch State Code [Closing.LndBrchStCd]
    /// </summary>
    public string? LndBrchStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Street Address [Closing.LndBrchStreetAddr1]
    /// </summary>
    public string? LndBrchStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Street Address 2 [Closing.LndBrchStreetAddr2]
    /// </summary>
    public string? LndBrchStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Toll-Free Telephone Number [Closing.LndBrchTollFreePhone]
    /// </summary>
    public string? LndBrchTollFreePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch URL [Closing.LndBrchUrl]
    /// </summary>
    public string? LndBrchUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Branch Postal Code [Closing.LndBrchZip]
    /// </summary>
    public string? LndBrchZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender County [Closing.LndCnty]
    /// </summary>
    public string? LndCnty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender City [Closing.LndCty]
    /// </summary>
    public string? LndCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender FAX Number [Closing.LndFaxNum]
    /// </summary>
    public string? LndFaxNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender FHA Originator Identifier [Closing.LndFhaOrgntrId]
    /// </summary>
    public string? LndFhaOrgntrId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender FHA Sponsor Identifier [Closing.LndFhaSpnsrId]
    /// </summary>
    public string? LndFhaSpnsrId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Jurisdiction [Closing.LndJrsdctn]
    /// </summary>
    public string? LndJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Additional Text [Closing.LndLossPayeeAdtlTxt]
    /// </summary>
    public string? LndLossPayeeAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Email Address [Closing.LndLossPayeeCntctEmail]
    /// </summary>
    public string? LndLossPayeeCntctEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Fax Number [Closing.LndLossPayeeCntctFax]
    /// </summary>
    public string? LndLossPayeeCntctFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Name [Closing.LndLossPayeeCntctNm]
    /// </summary>
    public string? LndLossPayeeCntctNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Telephone Number [Closing.LndLossPayeeCntctPhone]
    /// </summary>
    public string? LndLossPayeeCntctPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee City [Closing.LndLossPayeeCty]
    /// </summary>
    public string? LndLossPayeeCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Jurisdiction [Closing.LndLossPayeeJrsdctn]
    /// </summary>
    public string? LndLossPayeeJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Name [Closing.LndLossPayeeNm]
    /// </summary>
    public string? LndLossPayeeNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Organization Type [Closing.LndLossPayeeOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> LndLossPayeeOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Successor Clause [Closing.LndLossPayeeScsrsClausTxtDesc]
    /// </summary>
    public StringEnumValue<ScsrsClaus> LndLossPayeeScsrsClausTxtDesc { get => GetValue<StringEnumValue<ScsrsClaus>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee State Code [Closing.LndLossPayeeStCd]
    /// </summary>
    public string? LndLossPayeeStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address [Closing.LndLossPayeeStreetAddr1]
    /// </summary>
    public string? LndLossPayeeStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address 2 [Closing.LndLossPayeeStreetAddr2]
    /// </summary>
    public string? LndLossPayeeStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Loss Payee Postal Code [Closing.LndLossPayeeZip]
    /// </summary>
    public string? LndLossPayeeZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender MERS ID No. [Closing.LndMersIdNum]
    /// </summary>
    public string? LndMersIdNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Name [Closing.LndNm]
    /// </summary>
    public string? LndNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender NMLS ID No. [Closing.LndNmlsIdNum]
    /// </summary>
    public string? LndNmlsIdNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Commission Bond Number Identifier [Closing.LndNtryCmsnBndNumIdntfr]
    /// </summary>
    public string? LndNtryCmsnBndNumIdntfr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Commission County/Jurisdiction [Closing.LndNtryCmsnCnty]
    /// </summary>
    public string? LndNtryCmsnCnty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Commission Expiration Date [Closing.LndNtryCmsnExprDt]
    /// </summary>
    public DateTime? LndNtryCmsnExprDt { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Commission Number Identifier [Closing.LndNtryCmsnNumIdntfr]
    /// </summary>
    public string? LndNtryCmsnNumIdntfr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Commission State [Closing.LndNtryCmsnSt]
    /// </summary>
    public string? LndNtryCmsnSt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary City [Closing.LndNtryCty]
    /// </summary>
    public string? LndNtryCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Name [Closing.LndNtryNm]
    /// </summary>
    public string? LndNtryNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary State Code [Closing.LndNtryStCd]
    /// </summary>
    public string? LndNtryStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Street Address [Closing.LndNtryStreetAddr1]
    /// </summary>
    public string? LndNtryStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Street Address 2 [Closing.LndNtryStreetAddr2]
    /// </summary>
    public string? LndNtryStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Title Or Rank [Closing.LndNtryTtlOrRank]
    /// </summary>
    public string? LndNtryTtlOrRank { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Notary Postal Code [Closing.LndNtryZip]
    /// </summary>
    public string? LndNtryZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Organization Type [Closing.LndOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> LndOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Telephone Number [Closing.LndPhoneNum]
    /// </summary>
    public string? LndPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender State Code [Closing.LndStCd]
    /// </summary>
    public string? LndStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Street Address [Closing.LndStreetAddr1]
    /// </summary>
    public string? LndStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Street Address 2 [Closing.LndStreetAddr2]
    /// </summary>
    public string? LndStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Miscellaneous Text Description [Closing.LndSvcrAdtlTxt]
    /// </summary>
    public string? LndSvcrAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Contact Name [Closing.LndSvcrCntctNm]
    /// </summary>
    public string? LndSvcrCntctNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Contact Telephone Number [Closing.LndSvcrCntctPhoneNum]
    /// </summary>
    public string? LndSvcrCntctPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Contact Toll-Free Telephone Number [Closing.LndSvcrCntctTollFreePhoneNum]
    /// </summary>
    public string? LndSvcrCntctTollFreePhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer City [Closing.LndSvcrCty]
    /// </summary>
    public string? LndSvcrCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation [Closing.LndSvcrDayOp]
    /// </summary>
    public string? LndSvcrDayOp { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation (Additional) [Closing.LndSvcrDayOpAddl]
    /// </summary>
    public string? LndSvcrDayOpAddl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation [Closing.LndSvcrHrsOp]
    /// </summary>
    public string? LndSvcrHrsOp { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation (Additional) [Closing.LndSvcrHrsOpAddl]
    /// </summary>
    public string? LndSvcrHrsOpAddl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Organized Under the Laws Of Jurisdiction Name [Closing.LndSvcrJrsdctn]
    /// </summary>
    public string? LndSvcrJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Name [Closing.LndSvcrNm]
    /// </summary>
    public string? LndSvcrNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Organization Type [Closing.LndSvcrOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> LndSvcrOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer State Code [Closing.LndSvcrStCd]
    /// </summary>
    public string? LndSvcrStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Street Address [Closing.LndSvcrStreetAddr1]
    /// </summary>
    public string? LndSvcrStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Street Address 2 [Closing.LndSvcrStreetAddr2]
    /// </summary>
    public string? LndSvcrStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Servicer Postal Code [Closing.LndSvcrZip]
    /// </summary>
    public string? LndSvcrZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Tax ID No. [Closing.LndTaxIDNum]
    /// </summary>
    public string? LndTaxIdNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Toll-Free Telephone Number [Closing.LndTollFreePhoneNum]
    /// </summary>
    public string? LndTollFreePhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender URL [Closing.LndUrl]
    /// </summary>
    public string? LndUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender VA ID No. [Closing.LndVaIdNum]
    /// </summary>
    public string? LndVaIdNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Lender Postal Code [Closing.LndZip]
    /// </summary>
    public string? LndZip { get => GetValue<string?>(); set => SetValue(value); }
}