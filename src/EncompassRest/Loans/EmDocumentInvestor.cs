using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocumentInvestor
    /// </summary>
    public sealed partial class EmDocumentInvestor : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _invAsgnCty;
        private DirtyValue<string?>? _invAsgnJrsdctn;
        private DirtyValue<string?>? _invAsgnNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _invAsgnOrgTyp;
        private DirtyValue<string?>? _invAsgnStCd;
        private DirtyValue<string?>? _invAsgnStreetAddr1;
        private DirtyValue<string?>? _invAsgnStreetAddr2;
        private DirtyValue<string?>? _invAsgnZip;
        private DirtyValue<string?>? _invCty;
        private DirtyValue<string?>? _invFaxNum;
        private DirtyValue<string?>? _invJrsdctn;
        private DirtyValue<string?>? _invLossPayeeAdtlTxt;
        private DirtyValue<string?>? _invLossPayeeCntctEmail;
        private DirtyValue<string?>? _invLossPayeeCntctFax;
        private DirtyValue<string?>? _invLossPayeeCntctNm;
        private DirtyValue<string?>? _invLossPayeeCntctPhone;
        private DirtyValue<string?>? _invLossPayeeCty;
        private DirtyValue<string?>? _invLossPayeeJrsdctn;
        private DirtyValue<string?>? _invLossPayeeNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _invLossPayeeOrgTyp;
        private DirtyValue<string?>? _invLossPayeeScsrClausTxtDesc;
        private DirtyValue<string?>? _invLossPayeeStCd;
        private DirtyValue<string?>? _invLossPayeeStreetAddr1;
        private DirtyValue<string?>? _invLossPayeeStreetAddr2;
        private DirtyValue<string?>? _invLossPayeeZip;
        private DirtyValue<string?>? _invNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _invOrgTyp;
        private DirtyValue<string?>? _invPhoneNum;
        private DirtyValue<string?>? _invPmtCpn2PayToAdtlTxt;
        private DirtyValue<string?>? _invPmtCpn2PayToAdtlTxt2;
        private DirtyValue<string?>? _invPmtCpn2PayToCty;
        private DirtyValue<string?>? _invPmtCpn2PayToNm;
        private DirtyValue<string?>? _invPmtCpn2PayToStCd;
        private DirtyValue<string?>? _invPmtCpn2PayToStreetAddr1;
        private DirtyValue<string?>? _invPmtCpn2PayToStreetAddr2;
        private DirtyValue<string?>? _invPmtCpn2PayToZip;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToAdtlTxt;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToCty;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToNm;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToStCd;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToStreetAddr1;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToStreetAddr2;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcAdtlTxt;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcCty;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcNm;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcStCd;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcStreetAddr1;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcStreetAddr2;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToSvcZip;
        private DirtyValue<string?>? _invPmtCpnLoanTrsfToZip;
        private DirtyValue<string?>? _invPmtCpnPayToAdtlTxt;
        private DirtyValue<string?>? _invPmtCpnPayToAdtlTxt2;
        private DirtyValue<string?>? _invPmtCpnPayToCty;
        private DirtyValue<string?>? _invPmtCpnPayToNm;
        private DirtyValue<string?>? _invPmtCpnPayToStCd;
        private DirtyValue<string?>? _invPmtCpnPayToStreetAddr1;
        private DirtyValue<string?>? _invPmtCpnPayToStreetAddr2;
        private DirtyValue<string?>? _invPmtCpnPayToZip;
        private DirtyValue<string?>? _invStCd;
        private DirtyValue<string?>? _invStreetAddr1;
        private DirtyValue<string?>? _invStreetAddr2;
        private DirtyValue<string?>? _invSvcrAdtlTxt;
        private DirtyValue<string?>? _invSvcrCntctNm;
        private DirtyValue<string?>? _invSvcrCntctPhoneNum;
        private DirtyValue<string?>? _invSvcrCntctTollFreePhoneNum;
        private DirtyValue<string?>? _invSvcrCty;
        private DirtyValue<string?>? _invSvcrDayOp;
        private DirtyValue<string?>? _invSvcrDayOpAddl;
        private DirtyValue<string?>? _invSvcrHrsOp;
        private DirtyValue<string?>? _invSvcrHrsOpAddl;
        private DirtyValue<string?>? _invSvcrJrsdctn;
        private DirtyValue<string?>? _invSvcrNm;
        private DirtyValue<StringEnumValue<OrgTyp>>? _invSvcrOrgTyp;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToCty;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToNm;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToStCd;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        private DirtyValue<string?>? _invSvcrQlfdWrtnRqstMailToZip;
        private DirtyValue<string?>? _invSvcrStCd;
        private DirtyValue<string?>? _invSvcrStreetAddr1;
        private DirtyValue<string?>? _invSvcrStreetAddr2;
        private DirtyValue<string?>? _invSvcrZip;
        private DirtyValue<string?>? _invTaxIDNum;
        private DirtyValue<string?>? _invTollFreePhoneNum;
        private DirtyValue<string?>? _invUrl;
        private DirtyValue<string?>? _invZip;

        /// <summary>
        /// EmDocumentInvestor Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  City [Closing.InvAsgnCty]
        /// </summary>
        public string? InvAsgnCty { get => _invAsgnCty; set => SetField(ref _invAsgnCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name [Closing.InvAsgnJrsdctn]
        /// </summary>
        public string? InvAsgnJrsdctn { get => _invAsgnJrsdctn; set => SetField(ref _invAsgnJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Name [Closing.InvAsgnNm]
        /// </summary>
        public string? InvAsgnNm { get => _invAsgnNm; set => SetField(ref _invAsgnNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment Organization Type [Closing.InvAsgnOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get => _invAsgnOrgTyp; set => SetField(ref _invAsgnOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  State Code [Closing.InvAsgnStCd]
        /// </summary>
        public string? InvAsgnStCd { get => _invAsgnStCd; set => SetField(ref _invAsgnStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address [Closing.InvAsgnStreetAddr1]
        /// </summary>
        public string? InvAsgnStreetAddr1 { get => _invAsgnStreetAddr1; set => SetField(ref _invAsgnStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address 2 [Closing.InvAsgnStreetAddr2]
        /// </summary>
        public string? InvAsgnStreetAddr2 { get => _invAsgnStreetAddr2; set => SetField(ref _invAsgnStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Postal Code [Closing.InvAsgnZip]
        /// </summary>
        public string? InvAsgnZip { get => _invAsgnZip; set => SetField(ref _invAsgnZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor City [Closing.InvCty]
        /// </summary>
        public string? InvCty { get => _invCty; set => SetField(ref _invCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor FAX Number [Closing.InvFaxNum]
        /// </summary>
        public string? InvFaxNum { get => _invFaxNum; set => SetField(ref _invFaxNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Jurisdiction [Closing.InvJrsdctn]
        /// </summary>
        public string? InvJrsdctn { get => _invJrsdctn; set => SetField(ref _invJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Additional Text [Closing.InvLossPayeeAdtlTxt]
        /// </summary>
        public string? InvLossPayeeAdtlTxt { get => _invLossPayeeAdtlTxt; set => SetField(ref _invLossPayeeAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address [Closing.InvLossPayeeCntctEmail]
        /// </summary>
        public string? InvLossPayeeCntctEmail { get => _invLossPayeeCntctEmail; set => SetField(ref _invLossPayeeCntctEmail, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number [Closing.InvLossPayeeCntctFax]
        /// </summary>
        public string? InvLossPayeeCntctFax { get => _invLossPayeeCntctFax; set => SetField(ref _invLossPayeeCntctFax, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Name [Closing.InvLossPayeeCntctNm]
        /// </summary>
        public string? InvLossPayeeCntctNm { get => _invLossPayeeCntctNm; set => SetField(ref _invLossPayeeCntctNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number [Closing.InvLossPayeeCntctPhone]
        /// </summary>
        public string? InvLossPayeeCntctPhone { get => _invLossPayeeCntctPhone; set => SetField(ref _invLossPayeeCntctPhone, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee City [Closing.InvLossPayeeCty]
        /// </summary>
        public string? InvLossPayeeCty { get => _invLossPayeeCty; set => SetField(ref _invLossPayeeCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name [Closing.InvLossPayeeJrsdctn]
        /// </summary>
        public string? InvLossPayeeJrsdctn { get => _invLossPayeeJrsdctn; set => SetField(ref _invLossPayeeJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Name [Closing.InvLossPayeeNm]
        /// </summary>
        public string? InvLossPayeeNm { get => _invLossPayeeNm; set => SetField(ref _invLossPayeeNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organization Type [Closing.InvLossPayeeOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get => _invLossPayeeOrgTyp; set => SetField(ref _invLossPayeeOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description [Closing.InvLossPayeeScsrClausTxtDesc]
        /// </summary>
        public string? InvLossPayeeScsrClausTxtDesc { get => _invLossPayeeScsrClausTxtDesc; set => SetField(ref _invLossPayeeScsrClausTxtDesc, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee State Code [Closing.InvLossPayeeStCd]
        /// </summary>
        public string? InvLossPayeeStCd { get => _invLossPayeeStCd; set => SetField(ref _invLossPayeeStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address [Closing.InvLossPayeeStreetAddr1]
        /// </summary>
        public string? InvLossPayeeStreetAddr1 { get => _invLossPayeeStreetAddr1; set => SetField(ref _invLossPayeeStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2 [Closing.InvLossPayeeStreetAddr2]
        /// </summary>
        public string? InvLossPayeeStreetAddr2 { get => _invLossPayeeStreetAddr2; set => SetField(ref _invLossPayeeStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Postal Code [Closing.InvLossPayeeZip]
        /// </summary>
        public string? InvLossPayeeZip { get => _invLossPayeeZip; set => SetField(ref _invLossPayeeZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Name [Closing.InvNm]
        /// </summary>
        public string? InvNm { get => _invNm; set => SetField(ref _invNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Organization Type [Closing.InvOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> InvOrgTyp { get => _invOrgTyp; set => SetField(ref _invOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Telephone Number [Closing.InvPhoneNum]
        /// </summary>
        public string? InvPhoneNum { get => _invPhoneNum; set => SetField(ref _invPhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1 [Closing.InvPmtCpn2PayToAdtlTxt]
        /// </summary>
        public string? InvPmtCpn2PayToAdtlTxt { get => _invPmtCpn2PayToAdtlTxt; set => SetField(ref _invPmtCpn2PayToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2 [Closing.InvPmtCpn2PayToAdtlTxt2]
        /// </summary>
        public string? InvPmtCpn2PayToAdtlTxt2 { get => _invPmtCpn2PayToAdtlTxt2; set => SetField(ref _invPmtCpn2PayToAdtlTxt2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City [Closing.InvPmtCpn2PayToCty]
        /// </summary>
        public string? InvPmtCpn2PayToCty { get => _invPmtCpn2PayToCty; set => SetField(ref _invPmtCpn2PayToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name [Closing.InvPmtCpn2PayToNm]
        /// </summary>
        public string? InvPmtCpn2PayToNm { get => _invPmtCpn2PayToNm; set => SetField(ref _invPmtCpn2PayToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code [Closing.InvPmtCpn2PayToStCd]
        /// </summary>
        public string? InvPmtCpn2PayToStCd { get => _invPmtCpn2PayToStCd; set => SetField(ref _invPmtCpn2PayToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address [Closing.InvPmtCpn2PayToStreetAddr1]
        /// </summary>
        public string? InvPmtCpn2PayToStreetAddr1 { get => _invPmtCpn2PayToStreetAddr1; set => SetField(ref _invPmtCpn2PayToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2 [Closing.InvPmtCpn2PayToStreetAddr2]
        /// </summary>
        public string? InvPmtCpn2PayToStreetAddr2 { get => _invPmtCpn2PayToStreetAddr2; set => SetField(ref _invPmtCpn2PayToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code [Closing.InvPmtCpn2PayToZip]
        /// </summary>
        public string? InvPmtCpn2PayToZip { get => _invPmtCpn2PayToZip; set => SetField(ref _invPmtCpn2PayToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToAdtlTxt]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToAdtlTxt { get => _invPmtCpnLoanTrsfToAdtlTxt; set => SetField(ref _invPmtCpnLoanTrsfToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City [Closing.InvPmtCpnLoanTrsfToCty]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToCty { get => _invPmtCpnLoanTrsfToCty; set => SetField(ref _invPmtCpnLoanTrsfToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name [Closing.InvPmtCpnLoanTrsfToNm]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToNm { get => _invPmtCpnLoanTrsfToNm; set => SetField(ref _invPmtCpnLoanTrsfToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code [Closing.InvPmtCpnLoanTrsfToStCd]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToStCd { get => _invPmtCpnLoanTrsfToStCd; set => SetField(ref _invPmtCpnLoanTrsfToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address [Closing.InvPmtCpnLoanTrsfToStreetAddr1]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToStreetAddr1 { get => _invPmtCpnLoanTrsfToStreetAddr1; set => SetField(ref _invPmtCpnLoanTrsfToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2 [Closing.InvPmtCpnLoanTrsfToStreetAddr2]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToStreetAddr2 { get => _invPmtCpnLoanTrsfToStreetAddr2; set => SetField(ref _invPmtCpnLoanTrsfToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToSvcAdtlTxt]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcAdtlTxt { get => _invPmtCpnLoanTrsfToSvcAdtlTxt; set => SetField(ref _invPmtCpnLoanTrsfToSvcAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City [Closing.InvPmtCpnLoanTrsfToSvcCty]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcCty { get => _invPmtCpnLoanTrsfToSvcCty; set => SetField(ref _invPmtCpnLoanTrsfToSvcCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name [Closing.InvPmtCpnLoanTrsfToSvcNm]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcNm { get => _invPmtCpnLoanTrsfToSvcNm; set => SetField(ref _invPmtCpnLoanTrsfToSvcNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code [Closing.InvPmtCpnLoanTrsfToSvcStCd]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcStCd { get => _invPmtCpnLoanTrsfToSvcStCd; set => SetField(ref _invPmtCpnLoanTrsfToSvcStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr1]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcStreetAddr1 { get => _invPmtCpnLoanTrsfToSvcStreetAddr1; set => SetField(ref _invPmtCpnLoanTrsfToSvcStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2 [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr2]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcStreetAddr2 { get => _invPmtCpnLoanTrsfToSvcStreetAddr2; set => SetField(ref _invPmtCpnLoanTrsfToSvcStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code [Closing.InvPmtCpnLoanTrsfToSvcZip]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToSvcZip { get => _invPmtCpnLoanTrsfToSvcZip; set => SetField(ref _invPmtCpnLoanTrsfToSvcZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code [Closing.InvPmtCpnLoanTrsfToZip]
        /// </summary>
        public string? InvPmtCpnLoanTrsfToZip { get => _invPmtCpnLoanTrsfToZip; set => SetField(ref _invPmtCpnLoanTrsfToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1 [Closing.InvPmtCpnPayToAdtlTxt]
        /// </summary>
        public string? InvPmtCpnPayToAdtlTxt { get => _invPmtCpnPayToAdtlTxt; set => SetField(ref _invPmtCpnPayToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2 [Closing.InvPmtCpnPayToAdtlTxt2]
        /// </summary>
        public string? InvPmtCpnPayToAdtlTxt2 { get => _invPmtCpnPayToAdtlTxt2; set => SetField(ref _invPmtCpnPayToAdtlTxt2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City [Closing.InvPmtCpnPayToCty]
        /// </summary>
        public string? InvPmtCpnPayToCty { get => _invPmtCpnPayToCty; set => SetField(ref _invPmtCpnPayToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name [Closing.InvPmtCpnPayToNm]
        /// </summary>
        public string? InvPmtCpnPayToNm { get => _invPmtCpnPayToNm; set => SetField(ref _invPmtCpnPayToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code [Closing.InvPmtCpnPayToStCd]
        /// </summary>
        public string? InvPmtCpnPayToStCd { get => _invPmtCpnPayToStCd; set => SetField(ref _invPmtCpnPayToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address [Closing.InvPmtCpnPayToStreetAddr1]
        /// </summary>
        public string? InvPmtCpnPayToStreetAddr1 { get => _invPmtCpnPayToStreetAddr1; set => SetField(ref _invPmtCpnPayToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2 [Closing.InvPmtCpnPayToStreetAddr2]
        /// </summary>
        public string? InvPmtCpnPayToStreetAddr2 { get => _invPmtCpnPayToStreetAddr2; set => SetField(ref _invPmtCpnPayToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code [Closing.InvPmtCpnPayToZip]
        /// </summary>
        public string? InvPmtCpnPayToZip { get => _invPmtCpnPayToZip; set => SetField(ref _invPmtCpnPayToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor State Code [Closing.InvStCd]
        /// </summary>
        public string? InvStCd { get => _invStCd; set => SetField(ref _invStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address [Closing.InvStreetAddr1]
        /// </summary>
        public string? InvStreetAddr1 { get => _invStreetAddr1; set => SetField(ref _invStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address 2 [Closing.InvStreetAddr2]
        /// </summary>
        public string? InvStreetAddr2 { get => _invStreetAddr2; set => SetField(ref _invStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Additional Text [Closing.InvSvcrAdtlTxt]
        /// </summary>
        public string? InvSvcrAdtlTxt { get => _invSvcrAdtlTxt; set => SetField(ref _invSvcrAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Name [Closing.InvSvcrCntctNm]
        /// </summary>
        public string? InvSvcrCntctNm { get => _invSvcrCntctNm; set => SetField(ref _invSvcrCntctNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number [Closing.InvSvcrCntctPhoneNum]
        /// </summary>
        public string? InvSvcrCntctPhoneNum { get => _invSvcrCntctPhoneNum; set => SetField(ref _invSvcrCntctPhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number [Closing.InvSvcrCntctTollFreePhoneNum]
        /// </summary>
        public string? InvSvcrCntctTollFreePhoneNum { get => _invSvcrCntctTollFreePhoneNum; set => SetField(ref _invSvcrCntctTollFreePhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer City [Closing.InvSvcrCty]
        /// </summary>
        public string? InvSvcrCty { get => _invSvcrCty; set => SetField(ref _invSvcrCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation [Closing.InvSvcrDayOp]
        /// </summary>
        public string? InvSvcrDayOp { get => _invSvcrDayOp; set => SetField(ref _invSvcrDayOp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional) [Closing.InvSvcrDayOpAddl]
        /// </summary>
        public string? InvSvcrDayOpAddl { get => _invSvcrDayOpAddl; set => SetField(ref _invSvcrDayOpAddl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation [Closing.InvSvcrHrsOp]
        /// </summary>
        public string? InvSvcrHrsOp { get => _invSvcrHrsOp; set => SetField(ref _invSvcrHrsOp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional) [Closing.InvSvcrHrsOpAddl]
        /// </summary>
        public string? InvSvcrHrsOpAddl { get => _invSvcrHrsOpAddl; set => SetField(ref _invSvcrHrsOpAddl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Jurisdiction [Closing.InvSvcrJrsdctn]
        /// </summary>
        public string? InvSvcrJrsdctn { get => _invSvcrJrsdctn; set => SetField(ref _invSvcrJrsdctn, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Name [Closing.InvSvcrNm]
        /// </summary>
        public string? InvSvcrNm { get => _invSvcrNm; set => SetField(ref _invSvcrNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Organization Type [Closing.InvSvcrOrgTyp]
        /// </summary>
        public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get => _invSvcrOrgTyp; set => SetField(ref _invSvcrOrgTyp, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text [Closing.InvSvcrQlfdWrtnRqstMailToAdtlTxt]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToAdtlTxt { get => _invSvcrQlfdWrtnRqstMailToAdtlTxt; set => SetField(ref _invSvcrQlfdWrtnRqstMailToAdtlTxt, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City [Closing.InvSvcrQlfdWrtnRqstMailToCty]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToCty { get => _invSvcrQlfdWrtnRqstMailToCty; set => SetField(ref _invSvcrQlfdWrtnRqstMailToCty, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name [Closing.InvSvcrQlfdWrtnRqstMailToNm]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToNm { get => _invSvcrQlfdWrtnRqstMailToNm; set => SetField(ref _invSvcrQlfdWrtnRqstMailToNm, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code [Closing.InvSvcrQlfdWrtnRqstMailToStCd]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToStCd { get => _invSvcrQlfdWrtnRqstMailToStCd; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr1]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr1; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2 [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr2]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr2; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code [Closing.InvSvcrQlfdWrtnRqstMailToZip]
        /// </summary>
        public string? InvSvcrQlfdWrtnRqstMailToZip { get => _invSvcrQlfdWrtnRqstMailToZip; set => SetField(ref _invSvcrQlfdWrtnRqstMailToZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer State Code [Closing.InvSvcrStCd]
        /// </summary>
        public string? InvSvcrStCd { get => _invSvcrStCd; set => SetField(ref _invSvcrStCd, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address [Closing.InvSvcrStreetAddr1]
        /// </summary>
        public string? InvSvcrStreetAddr1 { get => _invSvcrStreetAddr1; set => SetField(ref _invSvcrStreetAddr1, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address 2 [Closing.InvSvcrStreetAddr2]
        /// </summary>
        public string? InvSvcrStreetAddr2 { get => _invSvcrStreetAddr2; set => SetField(ref _invSvcrStreetAddr2, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Postal Code [Closing.InvSvcrZip]
        /// </summary>
        public string? InvSvcrZip { get => _invSvcrZip; set => SetField(ref _invSvcrZip, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Tax ID No. [Closing.InvTaxIDNum]
        /// </summary>
        public string? InvTaxIDNum { get => _invTaxIDNum; set => SetField(ref _invTaxIDNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number [Closing.InvTollFreePhoneNum]
        /// </summary>
        public string? InvTollFreePhoneNum { get => _invTollFreePhoneNum; set => SetField(ref _invTollFreePhoneNum, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor URL [Closing.InvUrl]
        /// </summary>
        public string? InvUrl { get => _invUrl; set => SetField(ref _invUrl, value); }

        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Postal Code [Closing.InvZip]
        /// </summary>
        public string? InvZip { get => _invZip; set => SetField(ref _invZip, value); }
    }
}