using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EmDocumentInvestor
/// </summary>
public sealed partial class EmDocumentInvestor : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  City [Closing.InvAsgnCty]
    /// </summary>
    public string? InvAsgnCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name [Closing.InvAsgnJrsdctn]
    /// </summary>
    public string? InvAsgnJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  Name [Closing.InvAsgnNm]
    /// </summary>
    public string? InvAsgnNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment Organization Type [Closing.InvAsgnOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  State Code [Closing.InvAsgnStCd]
    /// </summary>
    public string? InvAsgnStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  Street Address [Closing.InvAsgnStreetAddr1]
    /// </summary>
    public string? InvAsgnStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  Street Address 2 [Closing.InvAsgnStreetAddr2]
    /// </summary>
    public string? InvAsgnStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Assignment  Postal Code [Closing.InvAsgnZip]
    /// </summary>
    public string? InvAsgnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor City [Closing.InvCty]
    /// </summary>
    public string? InvCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor FAX Number [Closing.InvFaxNum]
    /// </summary>
    public string? InvFaxNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Jurisdiction [Closing.InvJrsdctn]
    /// </summary>
    public string? InvJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Additional Text [Closing.InvLossPayeeAdtlTxt]
    /// </summary>
    public string? InvLossPayeeAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address [Closing.InvLossPayeeCntctEmail]
    /// </summary>
    public string? InvLossPayeeCntctEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number [Closing.InvLossPayeeCntctFax]
    /// </summary>
    public string? InvLossPayeeCntctFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Name [Closing.InvLossPayeeCntctNm]
    /// </summary>
    public string? InvLossPayeeCntctNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number [Closing.InvLossPayeeCntctPhone]
    /// </summary>
    public string? InvLossPayeeCntctPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee City [Closing.InvLossPayeeCty]
    /// </summary>
    public string? InvLossPayeeCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name [Closing.InvLossPayeeJrsdctn]
    /// </summary>
    public string? InvLossPayeeJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Name [Closing.InvLossPayeeNm]
    /// </summary>
    public string? InvLossPayeeNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Organization Type [Closing.InvLossPayeeOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description [Closing.InvLossPayeeScsrClausTxtDesc]
    /// </summary>
    public string? InvLossPayeeScsrClausTxtDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee State Code [Closing.InvLossPayeeStCd]
    /// </summary>
    public string? InvLossPayeeStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address [Closing.InvLossPayeeStreetAddr1]
    /// </summary>
    public string? InvLossPayeeStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2 [Closing.InvLossPayeeStreetAddr2]
    /// </summary>
    public string? InvLossPayeeStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Loss Payee Postal Code [Closing.InvLossPayeeZip]
    /// </summary>
    public string? InvLossPayeeZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Name [Closing.InvNm]
    /// </summary>
    public string? InvNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Organization Type [Closing.InvOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> InvOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Telephone Number [Closing.InvPhoneNum]
    /// </summary>
    public string? InvPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1 [Closing.InvPmtCpn2PayToAdtlTxt]
    /// </summary>
    public string? InvPmtCpn2PayToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2 [Closing.InvPmtCpn2PayToAdtlTxt2]
    /// </summary>
    public string? InvPmtCpn2PayToAdtlTxt2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City [Closing.InvPmtCpn2PayToCty]
    /// </summary>
    public string? InvPmtCpn2PayToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name [Closing.InvPmtCpn2PayToNm]
    /// </summary>
    public string? InvPmtCpn2PayToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code [Closing.InvPmtCpn2PayToStCd]
    /// </summary>
    public string? InvPmtCpn2PayToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address [Closing.InvPmtCpn2PayToStreetAddr1]
    /// </summary>
    public string? InvPmtCpn2PayToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2 [Closing.InvPmtCpn2PayToStreetAddr2]
    /// </summary>
    public string? InvPmtCpn2PayToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code [Closing.InvPmtCpn2PayToZip]
    /// </summary>
    public string? InvPmtCpn2PayToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToAdtlTxt]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City [Closing.InvPmtCpnLoanTrsfToCty]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name [Closing.InvPmtCpnLoanTrsfToNm]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code [Closing.InvPmtCpnLoanTrsfToStCd]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address [Closing.InvPmtCpnLoanTrsfToStreetAddr1]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2 [Closing.InvPmtCpnLoanTrsfToStreetAddr2]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToSvcAdtlTxt]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City [Closing.InvPmtCpnLoanTrsfToSvcCty]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name [Closing.InvPmtCpnLoanTrsfToSvcNm]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code [Closing.InvPmtCpnLoanTrsfToSvcStCd]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr1]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2 [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr2]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code [Closing.InvPmtCpnLoanTrsfToSvcZip]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToSvcZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code [Closing.InvPmtCpnLoanTrsfToZip]
    /// </summary>
    public string? InvPmtCpnLoanTrsfToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1 [Closing.InvPmtCpnPayToAdtlTxt]
    /// </summary>
    public string? InvPmtCpnPayToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2 [Closing.InvPmtCpnPayToAdtlTxt2]
    /// </summary>
    public string? InvPmtCpnPayToAdtlTxt2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City [Closing.InvPmtCpnPayToCty]
    /// </summary>
    public string? InvPmtCpnPayToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name [Closing.InvPmtCpnPayToNm]
    /// </summary>
    public string? InvPmtCpnPayToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code [Closing.InvPmtCpnPayToStCd]
    /// </summary>
    public string? InvPmtCpnPayToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address [Closing.InvPmtCpnPayToStreetAddr1]
    /// </summary>
    public string? InvPmtCpnPayToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2 [Closing.InvPmtCpnPayToStreetAddr2]
    /// </summary>
    public string? InvPmtCpnPayToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code [Closing.InvPmtCpnPayToZip]
    /// </summary>
    public string? InvPmtCpnPayToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor State Code [Closing.InvStCd]
    /// </summary>
    public string? InvStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Street Address [Closing.InvStreetAddr1]
    /// </summary>
    public string? InvStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Street Address 2 [Closing.InvStreetAddr2]
    /// </summary>
    public string? InvStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Additional Text [Closing.InvSvcrAdtlTxt]
    /// </summary>
    public string? InvSvcrAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Contact Name [Closing.InvSvcrCntctNm]
    /// </summary>
    public string? InvSvcrCntctNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number [Closing.InvSvcrCntctPhoneNum]
    /// </summary>
    public string? InvSvcrCntctPhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number [Closing.InvSvcrCntctTollFreePhoneNum]
    /// </summary>
    public string? InvSvcrCntctTollFreePhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer City [Closing.InvSvcrCty]
    /// </summary>
    public string? InvSvcrCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation [Closing.InvSvcrDayOp]
    /// </summary>
    public string? InvSvcrDayOp { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional) [Closing.InvSvcrDayOpAddl]
    /// </summary>
    public string? InvSvcrDayOpAddl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation [Closing.InvSvcrHrsOp]
    /// </summary>
    public string? InvSvcrHrsOp { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional) [Closing.InvSvcrHrsOpAddl]
    /// </summary>
    public string? InvSvcrHrsOpAddl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Jurisdiction [Closing.InvSvcrJrsdctn]
    /// </summary>
    public string? InvSvcrJrsdctn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Name [Closing.InvSvcrNm]
    /// </summary>
    public string? InvSvcrNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Organization Type [Closing.InvSvcrOrgTyp]
    /// </summary>
    public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get => GetValue<StringEnumValue<OrgTyp>>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text [Closing.InvSvcrQlfdWrtnRqstMailToAdtlTxt]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToAdtlTxt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City [Closing.InvSvcrQlfdWrtnRqstMailToCty]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToCty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name [Closing.InvSvcrQlfdWrtnRqstMailToNm]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToNm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code [Closing.InvSvcrQlfdWrtnRqstMailToStCd]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr1]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2 [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr2]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code [Closing.InvSvcrQlfdWrtnRqstMailToZip]
    /// </summary>
    public string? InvSvcrQlfdWrtnRqstMailToZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer State Code [Closing.InvSvcrStCd]
    /// </summary>
    public string? InvSvcrStCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Street Address [Closing.InvSvcrStreetAddr1]
    /// </summary>
    public string? InvSvcrStreetAddr1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Street Address 2 [Closing.InvSvcrStreetAddr2]
    /// </summary>
    public string? InvSvcrStreetAddr2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Servicer Postal Code [Closing.InvSvcrZip]
    /// </summary>
    public string? InvSvcrZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Tax ID No. [Closing.InvTaxIDNum]
    /// </summary>
    public string? InvTaxIdNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number [Closing.InvTollFreePhoneNum]
    /// </summary>
    public string? InvTollFreePhoneNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor URL [Closing.InvUrl]
    /// </summary>
    public string? InvUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Closing Document Override - Investor Postal Code [Closing.InvZip]
    /// </summary>
    public string? InvZip { get => GetValue<string?>(); set => SetValue(value); }
}