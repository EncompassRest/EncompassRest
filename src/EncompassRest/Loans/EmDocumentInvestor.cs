using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocumentInvestor
    /// </summary>
    public sealed partial class EmDocumentInvestor : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// EmDocumentInvestor Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _invAsgnCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  City [Closing.InvAsgnCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  City")]
        public string InvAsgnCty { get => _invAsgnCty; set => SetField(ref _invAsgnCty, value); }
        private DirtyValue<string> _invAsgnJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name [Closing.InvAsgnJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name")]
        public string InvAsgnJrsdctn { get => _invAsgnJrsdctn; set => SetField(ref _invAsgnJrsdctn, value); }
        private DirtyValue<string> _invAsgnNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Name [Closing.InvAsgnNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Name")]
        public string InvAsgnNm { get => _invAsgnNm; set => SetField(ref _invAsgnNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _invAsgnOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment Organization Type [Closing.InvAsgnOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment Organization Type")]
        public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get => _invAsgnOrgTyp; set => SetField(ref _invAsgnOrgTyp, value); }
        private DirtyValue<string> _invAsgnStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  State Code [Closing.InvAsgnStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  State Code")]
        public string InvAsgnStCd { get => _invAsgnStCd; set => SetField(ref _invAsgnStCd, value); }
        private DirtyValue<string> _invAsgnStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address [Closing.InvAsgnStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Street Address")]
        public string InvAsgnStreetAddr1 { get => _invAsgnStreetAddr1; set => SetField(ref _invAsgnStreetAddr1, value); }
        private DirtyValue<string> _invAsgnStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address 2 [Closing.InvAsgnStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Street Address 2")]
        public string InvAsgnStreetAddr2 { get => _invAsgnStreetAddr2; set => SetField(ref _invAsgnStreetAddr2, value); }
        private DirtyValue<string> _invAsgnZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Postal Code [Closing.InvAsgnZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Postal Code")]
        public string InvAsgnZip { get => _invAsgnZip; set => SetField(ref _invAsgnZip, value); }
        private DirtyValue<string> _invCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor City [Closing.InvCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor City")]
        public string InvCty { get => _invCty; set => SetField(ref _invCty, value); }
        private DirtyValue<string> _invFaxNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor FAX Number [Closing.InvFaxNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor FAX Number")]
        public string InvFaxNum { get => _invFaxNum; set => SetField(ref _invFaxNum, value); }
        private DirtyValue<string> _invJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Jurisdiction [Closing.InvJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Jurisdiction")]
        public string InvJrsdctn { get => _invJrsdctn; set => SetField(ref _invJrsdctn, value); }
        private DirtyValue<string> _invLossPayeeAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Additional Text [Closing.InvLossPayeeAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Additional Text")]
        public string InvLossPayeeAdtlTxt { get => _invLossPayeeAdtlTxt; set => SetField(ref _invLossPayeeAdtlTxt, value); }
        private DirtyValue<string> _invLossPayeeCntctEmail;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address [Closing.InvLossPayeeCntctEmail]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address")]
        public string InvLossPayeeCntctEmail { get => _invLossPayeeCntctEmail; set => SetField(ref _invLossPayeeCntctEmail, value); }
        private DirtyValue<string> _invLossPayeeCntctFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number [Closing.InvLossPayeeCntctFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number")]
        public string InvLossPayeeCntctFax { get => _invLossPayeeCntctFax; set => SetField(ref _invLossPayeeCntctFax, value); }
        private DirtyValue<string> _invLossPayeeCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Name [Closing.InvLossPayeeCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Name")]
        public string InvLossPayeeCntctNm { get => _invLossPayeeCntctNm; set => SetField(ref _invLossPayeeCntctNm, value); }
        private DirtyValue<string> _invLossPayeeCntctPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number [Closing.InvLossPayeeCntctPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number")]
        public string InvLossPayeeCntctPhone { get => _invLossPayeeCntctPhone; set => SetField(ref _invLossPayeeCntctPhone, value); }
        private DirtyValue<string> _invLossPayeeCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee City [Closing.InvLossPayeeCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee City")]
        public string InvLossPayeeCty { get => _invLossPayeeCty; set => SetField(ref _invLossPayeeCty, value); }
        private DirtyValue<string> _invLossPayeeJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name [Closing.InvLossPayeeJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name")]
        public string InvLossPayeeJrsdctn { get => _invLossPayeeJrsdctn; set => SetField(ref _invLossPayeeJrsdctn, value); }
        private DirtyValue<string> _invLossPayeeNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Name [Closing.InvLossPayeeNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Name")]
        public string InvLossPayeeNm { get => _invLossPayeeNm; set => SetField(ref _invLossPayeeNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _invLossPayeeOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organization Type [Closing.InvLossPayeeOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Organization Type")]
        public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get => _invLossPayeeOrgTyp; set => SetField(ref _invLossPayeeOrgTyp, value); }
        private DirtyValue<string> _invLossPayeeScsrClausTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description [Closing.InvLossPayeeScsrClausTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description")]
        public string InvLossPayeeScsrClausTxtDesc { get => _invLossPayeeScsrClausTxtDesc; set => SetField(ref _invLossPayeeScsrClausTxtDesc, value); }
        private DirtyValue<string> _invLossPayeeStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee State Code [Closing.InvLossPayeeStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee State Code")]
        public string InvLossPayeeStCd { get => _invLossPayeeStCd; set => SetField(ref _invLossPayeeStCd, value); }
        private DirtyValue<string> _invLossPayeeStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address [Closing.InvLossPayeeStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Street Address")]
        public string InvLossPayeeStreetAddr1 { get => _invLossPayeeStreetAddr1; set => SetField(ref _invLossPayeeStreetAddr1, value); }
        private DirtyValue<string> _invLossPayeeStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2 [Closing.InvLossPayeeStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2")]
        public string InvLossPayeeStreetAddr2 { get => _invLossPayeeStreetAddr2; set => SetField(ref _invLossPayeeStreetAddr2, value); }
        private DirtyValue<string> _invLossPayeeZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Postal Code [Closing.InvLossPayeeZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Postal Code")]
        public string InvLossPayeeZip { get => _invLossPayeeZip; set => SetField(ref _invLossPayeeZip, value); }
        private DirtyValue<string> _invNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Name [Closing.InvNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Name")]
        public string InvNm { get => _invNm; set => SetField(ref _invNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _invOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Organization Type [Closing.InvOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Organization Type")]
        public StringEnumValue<OrgTyp> InvOrgTyp { get => _invOrgTyp; set => SetField(ref _invOrgTyp, value); }
        private DirtyValue<string> _invPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Telephone Number [Closing.InvPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Telephone Number")]
        public string InvPhoneNum { get => _invPhoneNum; set => SetField(ref _invPhoneNum, value); }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1 [Closing.InvPmtCpn2PayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1")]
        public string InvPmtCpn2PayToAdtlTxt { get => _invPmtCpn2PayToAdtlTxt; set => SetField(ref _invPmtCpn2PayToAdtlTxt, value); }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2 [Closing.InvPmtCpn2PayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2")]
        public string InvPmtCpn2PayToAdtlTxt2 { get => _invPmtCpn2PayToAdtlTxt2; set => SetField(ref _invPmtCpn2PayToAdtlTxt2, value); }
        private DirtyValue<string> _invPmtCpn2PayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City [Closing.InvPmtCpn2PayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City")]
        public string InvPmtCpn2PayToCty { get => _invPmtCpn2PayToCty; set => SetField(ref _invPmtCpn2PayToCty, value); }
        private DirtyValue<string> _invPmtCpn2PayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name [Closing.InvPmtCpn2PayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name")]
        public string InvPmtCpn2PayToNm { get => _invPmtCpn2PayToNm; set => SetField(ref _invPmtCpn2PayToNm, value); }
        private DirtyValue<string> _invPmtCpn2PayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code [Closing.InvPmtCpn2PayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code")]
        public string InvPmtCpn2PayToStCd { get => _invPmtCpn2PayToStCd; set => SetField(ref _invPmtCpn2PayToStCd, value); }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address [Closing.InvPmtCpn2PayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address")]
        public string InvPmtCpn2PayToStreetAddr1 { get => _invPmtCpn2PayToStreetAddr1; set => SetField(ref _invPmtCpn2PayToStreetAddr1, value); }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2 [Closing.InvPmtCpn2PayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2")]
        public string InvPmtCpn2PayToStreetAddr2 { get => _invPmtCpn2PayToStreetAddr2; set => SetField(ref _invPmtCpn2PayToStreetAddr2, value); }
        private DirtyValue<string> _invPmtCpn2PayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code [Closing.InvPmtCpn2PayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code")]
        public string InvPmtCpn2PayToZip { get => _invPmtCpn2PayToZip; set => SetField(ref _invPmtCpn2PayToZip, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description ")]
        public string InvPmtCpnLoanTrsfToAdtlTxt { get => _invPmtCpnLoanTrsfToAdtlTxt; set => SetField(ref _invPmtCpnLoanTrsfToAdtlTxt, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City [Closing.InvPmtCpnLoanTrsfToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City")]
        public string InvPmtCpnLoanTrsfToCty { get => _invPmtCpnLoanTrsfToCty; set => SetField(ref _invPmtCpnLoanTrsfToCty, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name [Closing.InvPmtCpnLoanTrsfToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name")]
        public string InvPmtCpnLoanTrsfToNm { get => _invPmtCpnLoanTrsfToNm; set => SetField(ref _invPmtCpnLoanTrsfToNm, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code [Closing.InvPmtCpnLoanTrsfToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code")]
        public string InvPmtCpnLoanTrsfToStCd { get => _invPmtCpnLoanTrsfToStCd; set => SetField(ref _invPmtCpnLoanTrsfToStCd, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address [Closing.InvPmtCpnLoanTrsfToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address")]
        public string InvPmtCpnLoanTrsfToStreetAddr1 { get => _invPmtCpnLoanTrsfToStreetAddr1; set => SetField(ref _invPmtCpnLoanTrsfToStreetAddr1, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2 [Closing.InvPmtCpnLoanTrsfToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2")]
        public string InvPmtCpnLoanTrsfToStreetAddr2 { get => _invPmtCpnLoanTrsfToStreetAddr2; set => SetField(ref _invPmtCpnLoanTrsfToStreetAddr2, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToSvcAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description ")]
        public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get => _invPmtCpnLoanTrsfToSvcAdtlTxt; set => SetField(ref _invPmtCpnLoanTrsfToSvcAdtlTxt, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City [Closing.InvPmtCpnLoanTrsfToSvcCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City")]
        public string InvPmtCpnLoanTrsfToSvcCty { get => _invPmtCpnLoanTrsfToSvcCty; set => SetField(ref _invPmtCpnLoanTrsfToSvcCty, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name [Closing.InvPmtCpnLoanTrsfToSvcNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name")]
        public string InvPmtCpnLoanTrsfToSvcNm { get => _invPmtCpnLoanTrsfToSvcNm; set => SetField(ref _invPmtCpnLoanTrsfToSvcNm, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code [Closing.InvPmtCpnLoanTrsfToSvcStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code")]
        public string InvPmtCpnLoanTrsfToSvcStCd { get => _invPmtCpnLoanTrsfToSvcStCd; set => SetField(ref _invPmtCpnLoanTrsfToSvcStCd, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address")]
        public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get => _invPmtCpnLoanTrsfToSvcStreetAddr1; set => SetField(ref _invPmtCpnLoanTrsfToSvcStreetAddr1, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2 [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2")]
        public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get => _invPmtCpnLoanTrsfToSvcStreetAddr2; set => SetField(ref _invPmtCpnLoanTrsfToSvcStreetAddr2, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code [Closing.InvPmtCpnLoanTrsfToSvcZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code")]
        public string InvPmtCpnLoanTrsfToSvcZip { get => _invPmtCpnLoanTrsfToSvcZip; set => SetField(ref _invPmtCpnLoanTrsfToSvcZip, value); }
        private DirtyValue<string> _invPmtCpnLoanTrsfToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code [Closing.InvPmtCpnLoanTrsfToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code")]
        public string InvPmtCpnLoanTrsfToZip { get => _invPmtCpnLoanTrsfToZip; set => SetField(ref _invPmtCpnLoanTrsfToZip, value); }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1 [Closing.InvPmtCpnPayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1")]
        public string InvPmtCpnPayToAdtlTxt { get => _invPmtCpnPayToAdtlTxt; set => SetField(ref _invPmtCpnPayToAdtlTxt, value); }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2 [Closing.InvPmtCpnPayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2")]
        public string InvPmtCpnPayToAdtlTxt2 { get => _invPmtCpnPayToAdtlTxt2; set => SetField(ref _invPmtCpnPayToAdtlTxt2, value); }
        private DirtyValue<string> _invPmtCpnPayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City [Closing.InvPmtCpnPayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City")]
        public string InvPmtCpnPayToCty { get => _invPmtCpnPayToCty; set => SetField(ref _invPmtCpnPayToCty, value); }
        private DirtyValue<string> _invPmtCpnPayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name [Closing.InvPmtCpnPayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name")]
        public string InvPmtCpnPayToNm { get => _invPmtCpnPayToNm; set => SetField(ref _invPmtCpnPayToNm, value); }
        private DirtyValue<string> _invPmtCpnPayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code [Closing.InvPmtCpnPayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code")]
        public string InvPmtCpnPayToStCd { get => _invPmtCpnPayToStCd; set => SetField(ref _invPmtCpnPayToStCd, value); }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address [Closing.InvPmtCpnPayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address")]
        public string InvPmtCpnPayToStreetAddr1 { get => _invPmtCpnPayToStreetAddr1; set => SetField(ref _invPmtCpnPayToStreetAddr1, value); }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2 [Closing.InvPmtCpnPayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2")]
        public string InvPmtCpnPayToStreetAddr2 { get => _invPmtCpnPayToStreetAddr2; set => SetField(ref _invPmtCpnPayToStreetAddr2, value); }
        private DirtyValue<string> _invPmtCpnPayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code [Closing.InvPmtCpnPayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code")]
        public string InvPmtCpnPayToZip { get => _invPmtCpnPayToZip; set => SetField(ref _invPmtCpnPayToZip, value); }
        private DirtyValue<string> _invStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor State Code [Closing.InvStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor State Code")]
        public string InvStCd { get => _invStCd; set => SetField(ref _invStCd, value); }
        private DirtyValue<string> _invStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address [Closing.InvStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Street Address")]
        public string InvStreetAddr1 { get => _invStreetAddr1; set => SetField(ref _invStreetAddr1, value); }
        private DirtyValue<string> _invStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address 2 [Closing.InvStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Street Address 2")]
        public string InvStreetAddr2 { get => _invStreetAddr2; set => SetField(ref _invStreetAddr2, value); }
        private DirtyValue<string> _invSvcrAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Additional Text [Closing.InvSvcrAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Additional Text")]
        public string InvSvcrAdtlTxt { get => _invSvcrAdtlTxt; set => SetField(ref _invSvcrAdtlTxt, value); }
        private DirtyValue<string> _invSvcrCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Name [Closing.InvSvcrCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Name")]
        public string InvSvcrCntctNm { get => _invSvcrCntctNm; set => SetField(ref _invSvcrCntctNm, value); }
        private DirtyValue<string> _invSvcrCntctPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number [Closing.InvSvcrCntctPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number")]
        public string InvSvcrCntctPhoneNum { get => _invSvcrCntctPhoneNum; set => SetField(ref _invSvcrCntctPhoneNum, value); }
        private DirtyValue<string> _invSvcrCntctTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number [Closing.InvSvcrCntctTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number")]
        public string InvSvcrCntctTollFreePhoneNum { get => _invSvcrCntctTollFreePhoneNum; set => SetField(ref _invSvcrCntctTollFreePhoneNum, value); }
        private DirtyValue<string> _invSvcrCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer City [Closing.InvSvcrCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer City")]
        public string InvSvcrCty { get => _invSvcrCty; set => SetField(ref _invSvcrCty, value); }
        private DirtyValue<string> _invSvcrDayOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation [Closing.InvSvcrDayOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Days of Operation")]
        public string InvSvcrDayOp { get => _invSvcrDayOp; set => SetField(ref _invSvcrDayOp, value); }
        private DirtyValue<string> _invSvcrDayOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional) [Closing.InvSvcrDayOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional)")]
        public string InvSvcrDayOpAddl { get => _invSvcrDayOpAddl; set => SetField(ref _invSvcrDayOpAddl, value); }
        private DirtyValue<string> _invSvcrHrsOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation [Closing.InvSvcrHrsOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Hours of Operation")]
        public string InvSvcrHrsOp { get => _invSvcrHrsOp; set => SetField(ref _invSvcrHrsOp, value); }
        private DirtyValue<string> _invSvcrHrsOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional) [Closing.InvSvcrHrsOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional)")]
        public string InvSvcrHrsOpAddl { get => _invSvcrHrsOpAddl; set => SetField(ref _invSvcrHrsOpAddl, value); }
        private DirtyValue<string> _invSvcrJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Jurisdiction [Closing.InvSvcrJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Jurisdiction")]
        public string InvSvcrJrsdctn { get => _invSvcrJrsdctn; set => SetField(ref _invSvcrJrsdctn, value); }
        private DirtyValue<string> _invSvcrNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Name [Closing.InvSvcrNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Name")]
        public string InvSvcrNm { get => _invSvcrNm; set => SetField(ref _invSvcrNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _invSvcrOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Organization Type [Closing.InvSvcrOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Organization Type")]
        public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get => _invSvcrOrgTyp; set => SetField(ref _invSvcrOrgTyp, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text [Closing.InvSvcrQlfdWrtnRqstMailToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text")]
        public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get => _invSvcrQlfdWrtnRqstMailToAdtlTxt; set => SetField(ref _invSvcrQlfdWrtnRqstMailToAdtlTxt, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City [Closing.InvSvcrQlfdWrtnRqstMailToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City")]
        public string InvSvcrQlfdWrtnRqstMailToCty { get => _invSvcrQlfdWrtnRqstMailToCty; set => SetField(ref _invSvcrQlfdWrtnRqstMailToCty, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name [Closing.InvSvcrQlfdWrtnRqstMailToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name")]
        public string InvSvcrQlfdWrtnRqstMailToNm { get => _invSvcrQlfdWrtnRqstMailToNm; set => SetField(ref _invSvcrQlfdWrtnRqstMailToNm, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code [Closing.InvSvcrQlfdWrtnRqstMailToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code")]
        public string InvSvcrQlfdWrtnRqstMailToStCd { get => _invSvcrQlfdWrtnRqstMailToStCd; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStCd, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address")]
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr1; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStreetAddr1, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2 [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2")]
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr2; set => SetField(ref _invSvcrQlfdWrtnRqstMailToStreetAddr2, value); }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code [Closing.InvSvcrQlfdWrtnRqstMailToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code")]
        public string InvSvcrQlfdWrtnRqstMailToZip { get => _invSvcrQlfdWrtnRqstMailToZip; set => SetField(ref _invSvcrQlfdWrtnRqstMailToZip, value); }
        private DirtyValue<string> _invSvcrStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer State Code [Closing.InvSvcrStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer State Code")]
        public string InvSvcrStCd { get => _invSvcrStCd; set => SetField(ref _invSvcrStCd, value); }
        private DirtyValue<string> _invSvcrStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address [Closing.InvSvcrStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Street Address")]
        public string InvSvcrStreetAddr1 { get => _invSvcrStreetAddr1; set => SetField(ref _invSvcrStreetAddr1, value); }
        private DirtyValue<string> _invSvcrStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address 2 [Closing.InvSvcrStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Street Address 2")]
        public string InvSvcrStreetAddr2 { get => _invSvcrStreetAddr2; set => SetField(ref _invSvcrStreetAddr2, value); }
        private DirtyValue<string> _invSvcrZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Postal Code [Closing.InvSvcrZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Postal Code")]
        public string InvSvcrZip { get => _invSvcrZip; set => SetField(ref _invSvcrZip, value); }
        private DirtyValue<string> _invTaxIDNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Tax ID No. [Closing.InvTaxIDNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Tax ID No.")]
        public string InvTaxIDNum { get => _invTaxIDNum; set => SetField(ref _invTaxIDNum, value); }
        private DirtyValue<string> _invTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number [Closing.InvTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number")]
        public string InvTollFreePhoneNum { get => _invTollFreePhoneNum; set => SetField(ref _invTollFreePhoneNum, value); }
        private DirtyValue<string> _invUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor URL [Closing.InvUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor URL")]
        public string InvUrl { get => _invUrl; set => SetField(ref _invUrl, value); }
        private DirtyValue<string> _invZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Postal Code [Closing.InvZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Postal Code")]
        public string InvZip { get => _invZip; set => SetField(ref _invZip, value); }
    }
}