using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocumentInvestor
    /// </summary>
    public sealed partial class EmDocumentInvestor : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// EmDocumentInvestor Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _invAsgnCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  City [Closing.InvAsgnCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  City")]
        public string InvAsgnCty { get => _invAsgnCty; set => _invAsgnCty = value; }
        private DirtyValue<string> _invAsgnJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name [Closing.InvAsgnJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Organized Under the Laws Of Jurisdiction Name")]
        public string InvAsgnJrsdctn { get => _invAsgnJrsdctn; set => _invAsgnJrsdctn = value; }
        private DirtyValue<string> _invAsgnNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Name [Closing.InvAsgnNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Name")]
        public string InvAsgnNm { get => _invAsgnNm; set => _invAsgnNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invAsgnOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment Organization Type [Closing.InvAsgnOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment Organization Type")]
        public StringEnumValue<OrgTyp> InvAsgnOrgTyp { get => _invAsgnOrgTyp; set => _invAsgnOrgTyp = value; }
        private DirtyValue<string> _invAsgnStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  State Code [Closing.InvAsgnStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  State Code")]
        public string InvAsgnStCd { get => _invAsgnStCd; set => _invAsgnStCd = value; }
        private DirtyValue<string> _invAsgnStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address [Closing.InvAsgnStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Street Address")]
        public string InvAsgnStreetAddr1 { get => _invAsgnStreetAddr1; set => _invAsgnStreetAddr1 = value; }
        private DirtyValue<string> _invAsgnStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Street Address 2 [Closing.InvAsgnStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Street Address 2")]
        public string InvAsgnStreetAddr2 { get => _invAsgnStreetAddr2; set => _invAsgnStreetAddr2 = value; }
        private DirtyValue<string> _invAsgnZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Assignment  Postal Code [Closing.InvAsgnZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Assignment  Postal Code")]
        public string InvAsgnZip { get => _invAsgnZip; set => _invAsgnZip = value; }
        private DirtyValue<string> _invCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor City [Closing.InvCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor City")]
        public string InvCty { get => _invCty; set => _invCty = value; }
        private DirtyValue<string> _invFaxNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor FAX Number [Closing.InvFaxNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor FAX Number")]
        public string InvFaxNum { get => _invFaxNum; set => _invFaxNum = value; }
        private DirtyValue<string> _invJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Jurisdiction [Closing.InvJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Jurisdiction")]
        public string InvJrsdctn { get => _invJrsdctn; set => _invJrsdctn = value; }
        private DirtyValue<string> _invLossPayeeAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Additional Text [Closing.InvLossPayeeAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Additional Text")]
        public string InvLossPayeeAdtlTxt { get => _invLossPayeeAdtlTxt; set => _invLossPayeeAdtlTxt = value; }
        private DirtyValue<string> _invLossPayeeCntctEmail;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address [Closing.InvLossPayeeCntctEmail]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Email Address")]
        public string InvLossPayeeCntctEmail { get => _invLossPayeeCntctEmail; set => _invLossPayeeCntctEmail = value; }
        private DirtyValue<string> _invLossPayeeCntctFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number [Closing.InvLossPayeeCntctFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Fax Number")]
        public string InvLossPayeeCntctFax { get => _invLossPayeeCntctFax; set => _invLossPayeeCntctFax = value; }
        private DirtyValue<string> _invLossPayeeCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Name [Closing.InvLossPayeeCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Name")]
        public string InvLossPayeeCntctNm { get => _invLossPayeeCntctNm; set => _invLossPayeeCntctNm = value; }
        private DirtyValue<string> _invLossPayeeCntctPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number [Closing.InvLossPayeeCntctPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Contact Telephone Number")]
        public string InvLossPayeeCntctPhone { get => _invLossPayeeCntctPhone; set => _invLossPayeeCntctPhone = value; }
        private DirtyValue<string> _invLossPayeeCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee City [Closing.InvLossPayeeCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee City")]
        public string InvLossPayeeCty { get => _invLossPayeeCty; set => _invLossPayeeCty = value; }
        private DirtyValue<string> _invLossPayeeJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name [Closing.InvLossPayeeJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Organized Under the Laws Of Jurisdiction Name")]
        public string InvLossPayeeJrsdctn { get => _invLossPayeeJrsdctn; set => _invLossPayeeJrsdctn = value; }
        private DirtyValue<string> _invLossPayeeNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Name [Closing.InvLossPayeeNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Name")]
        public string InvLossPayeeNm { get => _invLossPayeeNm; set => _invLossPayeeNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invLossPayeeOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Organization Type [Closing.InvLossPayeeOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Organization Type")]
        public StringEnumValue<OrgTyp> InvLossPayeeOrgTyp { get => _invLossPayeeOrgTyp; set => _invLossPayeeOrgTyp = value; }
        private DirtyValue<string> _invLossPayeeScsrClausTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description [Closing.InvLossPayeeScsrClausTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Successor Clause Text Description")]
        public string InvLossPayeeScsrClausTxtDesc { get => _invLossPayeeScsrClausTxtDesc; set => _invLossPayeeScsrClausTxtDesc = value; }
        private DirtyValue<string> _invLossPayeeStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee State Code [Closing.InvLossPayeeStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee State Code")]
        public string InvLossPayeeStCd { get => _invLossPayeeStCd; set => _invLossPayeeStCd = value; }
        private DirtyValue<string> _invLossPayeeStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address [Closing.InvLossPayeeStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Street Address")]
        public string InvLossPayeeStreetAddr1 { get => _invLossPayeeStreetAddr1; set => _invLossPayeeStreetAddr1 = value; }
        private DirtyValue<string> _invLossPayeeStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2 [Closing.InvLossPayeeStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Street Address 2")]
        public string InvLossPayeeStreetAddr2 { get => _invLossPayeeStreetAddr2; set => _invLossPayeeStreetAddr2 = value; }
        private DirtyValue<string> _invLossPayeeZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Loss Payee Postal Code [Closing.InvLossPayeeZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Loss Payee Postal Code")]
        public string InvLossPayeeZip { get => _invLossPayeeZip; set => _invLossPayeeZip = value; }
        private DirtyValue<string> _invNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Name [Closing.InvNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Name")]
        public string InvNm { get => _invNm; set => _invNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Organization Type [Closing.InvOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Organization Type")]
        public StringEnumValue<OrgTyp> InvOrgTyp { get => _invOrgTyp; set => _invOrgTyp = value; }
        private DirtyValue<string> _invPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Telephone Number [Closing.InvPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Telephone Number")]
        public string InvPhoneNum { get => _invPhoneNum; set => _invPhoneNum = value; }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1 [Closing.InvPmtCpn2PayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 1")]
        public string InvPmtCpn2PayToAdtlTxt { get => _invPmtCpn2PayToAdtlTxt; set => _invPmtCpn2PayToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpn2PayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2 [Closing.InvPmtCpn2PayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Additional Text 2")]
        public string InvPmtCpn2PayToAdtlTxt2 { get => _invPmtCpn2PayToAdtlTxt2; set => _invPmtCpn2PayToAdtlTxt2 = value; }
        private DirtyValue<string> _invPmtCpn2PayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City [Closing.InvPmtCpn2PayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To City")]
        public string InvPmtCpn2PayToCty { get => _invPmtCpn2PayToCty; set => _invPmtCpn2PayToCty = value; }
        private DirtyValue<string> _invPmtCpn2PayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name [Closing.InvPmtCpn2PayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Name")]
        public string InvPmtCpn2PayToNm { get => _invPmtCpn2PayToNm; set => _invPmtCpn2PayToNm = value; }
        private DirtyValue<string> _invPmtCpn2PayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code [Closing.InvPmtCpn2PayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To State Code")]
        public string InvPmtCpn2PayToStCd { get => _invPmtCpn2PayToStCd; set => _invPmtCpn2PayToStCd = value; }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address [Closing.InvPmtCpn2PayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address")]
        public string InvPmtCpn2PayToStreetAddr1 { get => _invPmtCpn2PayToStreetAddr1; set => _invPmtCpn2PayToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpn2PayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2 [Closing.InvPmtCpn2PayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Street Address 2")]
        public string InvPmtCpn2PayToStreetAddr2 { get => _invPmtCpn2PayToStreetAddr2; set => _invPmtCpn2PayToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpn2PayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code [Closing.InvPmtCpn2PayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 2 Pay To Postal Code")]
        public string InvPmtCpn2PayToZip { get => _invPmtCpn2PayToZip; set => _invPmtCpn2PayToZip = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Miscellaneous Text Description ")]
        public string InvPmtCpnLoanTrsfToAdtlTxt { get => _invPmtCpnLoanTrsfToAdtlTxt; set => _invPmtCpnLoanTrsfToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City [Closing.InvPmtCpnLoanTrsfToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To City")]
        public string InvPmtCpnLoanTrsfToCty { get => _invPmtCpnLoanTrsfToCty; set => _invPmtCpnLoanTrsfToCty = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name [Closing.InvPmtCpnLoanTrsfToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Name")]
        public string InvPmtCpnLoanTrsfToNm { get => _invPmtCpnLoanTrsfToNm; set => _invPmtCpnLoanTrsfToNm = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code [Closing.InvPmtCpnLoanTrsfToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To State Code")]
        public string InvPmtCpnLoanTrsfToStCd { get => _invPmtCpnLoanTrsfToStCd; set => _invPmtCpnLoanTrsfToStCd = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address [Closing.InvPmtCpnLoanTrsfToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address")]
        public string InvPmtCpnLoanTrsfToStreetAddr1 { get => _invPmtCpnLoanTrsfToStreetAddr1; set => _invPmtCpnLoanTrsfToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2 [Closing.InvPmtCpnLoanTrsfToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Street Address 2")]
        public string InvPmtCpnLoanTrsfToStreetAddr2 { get => _invPmtCpnLoanTrsfToStreetAddr2; set => _invPmtCpnLoanTrsfToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description  [Closing.InvPmtCpnLoanTrsfToSvcAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Miscellaneous Text Description ")]
        public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get => _invPmtCpnLoanTrsfToSvcAdtlTxt; set => _invPmtCpnLoanTrsfToSvcAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City [Closing.InvPmtCpnLoanTrsfToSvcCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing City")]
        public string InvPmtCpnLoanTrsfToSvcCty { get => _invPmtCpnLoanTrsfToSvcCty; set => _invPmtCpnLoanTrsfToSvcCty = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name [Closing.InvPmtCpnLoanTrsfToSvcNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Name")]
        public string InvPmtCpnLoanTrsfToSvcNm { get => _invPmtCpnLoanTrsfToSvcNm; set => _invPmtCpnLoanTrsfToSvcNm = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code [Closing.InvPmtCpnLoanTrsfToSvcStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing State Code")]
        public string InvPmtCpnLoanTrsfToSvcStCd { get => _invPmtCpnLoanTrsfToSvcStCd; set => _invPmtCpnLoanTrsfToSvcStCd = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address")]
        public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get => _invPmtCpnLoanTrsfToSvcStreetAddr1; set => _invPmtCpnLoanTrsfToSvcStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2 [Closing.InvPmtCpnLoanTrsfToSvcStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Street Address 2")]
        public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get => _invPmtCpnLoanTrsfToSvcStreetAddr2; set => _invPmtCpnLoanTrsfToSvcStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToSvcZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code [Closing.InvPmtCpnLoanTrsfToSvcZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Servicing Postal Code")]
        public string InvPmtCpnLoanTrsfToSvcZip { get => _invPmtCpnLoanTrsfToSvcZip; set => _invPmtCpnLoanTrsfToSvcZip = value; }
        private DirtyValue<string> _invPmtCpnLoanTrsfToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code [Closing.InvPmtCpnLoanTrsfToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon Loan Transfer To Postal Code")]
        public string InvPmtCpnLoanTrsfToZip { get => _invPmtCpnLoanTrsfToZip; set => _invPmtCpnLoanTrsfToZip = value; }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1 [Closing.InvPmtCpnPayToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 1")]
        public string InvPmtCpnPayToAdtlTxt { get => _invPmtCpnPayToAdtlTxt; set => _invPmtCpnPayToAdtlTxt = value; }
        private DirtyValue<string> _invPmtCpnPayToAdtlTxt2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2 [Closing.InvPmtCpnPayToAdtlTxt2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Additional Text 2")]
        public string InvPmtCpnPayToAdtlTxt2 { get => _invPmtCpnPayToAdtlTxt2; set => _invPmtCpnPayToAdtlTxt2 = value; }
        private DirtyValue<string> _invPmtCpnPayToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City [Closing.InvPmtCpnPayToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To City")]
        public string InvPmtCpnPayToCty { get => _invPmtCpnPayToCty; set => _invPmtCpnPayToCty = value; }
        private DirtyValue<string> _invPmtCpnPayToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name [Closing.InvPmtCpnPayToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Name")]
        public string InvPmtCpnPayToNm { get => _invPmtCpnPayToNm; set => _invPmtCpnPayToNm = value; }
        private DirtyValue<string> _invPmtCpnPayToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code [Closing.InvPmtCpnPayToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To State Code")]
        public string InvPmtCpnPayToStCd { get => _invPmtCpnPayToStCd; set => _invPmtCpnPayToStCd = value; }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address [Closing.InvPmtCpnPayToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address")]
        public string InvPmtCpnPayToStreetAddr1 { get => _invPmtCpnPayToStreetAddr1; set => _invPmtCpnPayToStreetAddr1 = value; }
        private DirtyValue<string> _invPmtCpnPayToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2 [Closing.InvPmtCpnPayToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Street Address 2")]
        public string InvPmtCpnPayToStreetAddr2 { get => _invPmtCpnPayToStreetAddr2; set => _invPmtCpnPayToStreetAddr2 = value; }
        private DirtyValue<string> _invPmtCpnPayToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code [Closing.InvPmtCpnPayToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Payment Coupon 1 Pay To Postal Code")]
        public string InvPmtCpnPayToZip { get => _invPmtCpnPayToZip; set => _invPmtCpnPayToZip = value; }
        private DirtyValue<string> _invStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor State Code [Closing.InvStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor State Code")]
        public string InvStCd { get => _invStCd; set => _invStCd = value; }
        private DirtyValue<string> _invStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address [Closing.InvStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Street Address")]
        public string InvStreetAddr1 { get => _invStreetAddr1; set => _invStreetAddr1 = value; }
        private DirtyValue<string> _invStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Street Address 2 [Closing.InvStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Street Address 2")]
        public string InvStreetAddr2 { get => _invStreetAddr2; set => _invStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Additional Text [Closing.InvSvcrAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Additional Text")]
        public string InvSvcrAdtlTxt { get => _invSvcrAdtlTxt; set => _invSvcrAdtlTxt = value; }
        private DirtyValue<string> _invSvcrCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Name [Closing.InvSvcrCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Name")]
        public string InvSvcrCntctNm { get => _invSvcrCntctNm; set => _invSvcrCntctNm = value; }
        private DirtyValue<string> _invSvcrCntctPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number [Closing.InvSvcrCntctPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Telephone Number")]
        public string InvSvcrCntctPhoneNum { get => _invSvcrCntctPhoneNum; set => _invSvcrCntctPhoneNum = value; }
        private DirtyValue<string> _invSvcrCntctTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number [Closing.InvSvcrCntctTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Contact Toll-Free Telephone Number")]
        public string InvSvcrCntctTollFreePhoneNum { get => _invSvcrCntctTollFreePhoneNum; set => _invSvcrCntctTollFreePhoneNum = value; }
        private DirtyValue<string> _invSvcrCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer City [Closing.InvSvcrCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer City")]
        public string InvSvcrCty { get => _invSvcrCty; set => _invSvcrCty = value; }
        private DirtyValue<string> _invSvcrDayOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation [Closing.InvSvcrDayOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Days of Operation")]
        public string InvSvcrDayOp { get => _invSvcrDayOp; set => _invSvcrDayOp = value; }
        private DirtyValue<string> _invSvcrDayOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional) [Closing.InvSvcrDayOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Days of Operation (Additional)")]
        public string InvSvcrDayOpAddl { get => _invSvcrDayOpAddl; set => _invSvcrDayOpAddl = value; }
        private DirtyValue<string> _invSvcrHrsOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation [Closing.InvSvcrHrsOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Hours of Operation")]
        public string InvSvcrHrsOp { get => _invSvcrHrsOp; set => _invSvcrHrsOp = value; }
        private DirtyValue<string> _invSvcrHrsOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional) [Closing.InvSvcrHrsOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Hours of Operation (Additional)")]
        public string InvSvcrHrsOpAddl { get => _invSvcrHrsOpAddl; set => _invSvcrHrsOpAddl = value; }
        private DirtyValue<string> _invSvcrJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Jurisdiction [Closing.InvSvcrJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Jurisdiction")]
        public string InvSvcrJrsdctn { get => _invSvcrJrsdctn; set => _invSvcrJrsdctn = value; }
        private DirtyValue<string> _invSvcrNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Name [Closing.InvSvcrNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Name")]
        public string InvSvcrNm { get => _invSvcrNm; set => _invSvcrNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _invSvcrOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Organization Type [Closing.InvSvcrOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Organization Type")]
        public StringEnumValue<OrgTyp> InvSvcrOrgTyp { get => _invSvcrOrgTyp; set => _invSvcrOrgTyp = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text [Closing.InvSvcrQlfdWrtnRqstMailToAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Additional Text")]
        public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get => _invSvcrQlfdWrtnRqstMailToAdtlTxt; set => _invSvcrQlfdWrtnRqstMailToAdtlTxt = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City [Closing.InvSvcrQlfdWrtnRqstMailToCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To City")]
        public string InvSvcrQlfdWrtnRqstMailToCty { get => _invSvcrQlfdWrtnRqstMailToCty; set => _invSvcrQlfdWrtnRqstMailToCty = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name [Closing.InvSvcrQlfdWrtnRqstMailToNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Name")]
        public string InvSvcrQlfdWrtnRqstMailToNm { get => _invSvcrQlfdWrtnRqstMailToNm; set => _invSvcrQlfdWrtnRqstMailToNm = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code [Closing.InvSvcrQlfdWrtnRqstMailToStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To State Code")]
        public string InvSvcrQlfdWrtnRqstMailToStCd { get => _invSvcrQlfdWrtnRqstMailToStCd; set => _invSvcrQlfdWrtnRqstMailToStCd = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address")]
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr1; set => _invSvcrQlfdWrtnRqstMailToStreetAddr1 = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2 [Closing.InvSvcrQlfdWrtnRqstMailToStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Street Address 2")]
        public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get => _invSvcrQlfdWrtnRqstMailToStreetAddr2; set => _invSvcrQlfdWrtnRqstMailToStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrQlfdWrtnRqstMailToZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code [Closing.InvSvcrQlfdWrtnRqstMailToZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Qualified Written Request Mail To Postal Code")]
        public string InvSvcrQlfdWrtnRqstMailToZip { get => _invSvcrQlfdWrtnRqstMailToZip; set => _invSvcrQlfdWrtnRqstMailToZip = value; }
        private DirtyValue<string> _invSvcrStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer State Code [Closing.InvSvcrStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer State Code")]
        public string InvSvcrStCd { get => _invSvcrStCd; set => _invSvcrStCd = value; }
        private DirtyValue<string> _invSvcrStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address [Closing.InvSvcrStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Street Address")]
        public string InvSvcrStreetAddr1 { get => _invSvcrStreetAddr1; set => _invSvcrStreetAddr1 = value; }
        private DirtyValue<string> _invSvcrStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Street Address 2 [Closing.InvSvcrStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Street Address 2")]
        public string InvSvcrStreetAddr2 { get => _invSvcrStreetAddr2; set => _invSvcrStreetAddr2 = value; }
        private DirtyValue<string> _invSvcrZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Servicer Postal Code [Closing.InvSvcrZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Servicer Postal Code")]
        public string InvSvcrZip { get => _invSvcrZip; set => _invSvcrZip = value; }
        private DirtyValue<string> _invTaxIDNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Tax ID No. [Closing.InvTaxIDNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Tax ID No.")]
        public string InvTaxIDNum { get => _invTaxIDNum; set => _invTaxIDNum = value; }
        private DirtyValue<string> _invTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number [Closing.InvTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Toll-Free Telephone Number")]
        public string InvTollFreePhoneNum { get => _invTollFreePhoneNum; set => _invTollFreePhoneNum = value; }
        private DirtyValue<string> _invUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor URL [Closing.InvUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor URL")]
        public string InvUrl { get => _invUrl; set => _invUrl = value; }
        private DirtyValue<string> _invZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Investor Postal Code [Closing.InvZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Investor Postal Code")]
        public string InvZip { get => _invZip; set => _invZip = value; }
        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _invAsgnCty.Dirty
                || _invAsgnJrsdctn.Dirty
                || _invAsgnNm.Dirty
                || _invAsgnOrgTyp.Dirty
                || _invAsgnStCd.Dirty
                || _invAsgnStreetAddr1.Dirty
                || _invAsgnStreetAddr2.Dirty
                || _invAsgnZip.Dirty
                || _invCty.Dirty
                || _invFaxNum.Dirty
                || _invJrsdctn.Dirty
                || _invLossPayeeAdtlTxt.Dirty
                || _invLossPayeeCntctEmail.Dirty
                || _invLossPayeeCntctFax.Dirty
                || _invLossPayeeCntctNm.Dirty
                || _invLossPayeeCntctPhone.Dirty
                || _invLossPayeeCty.Dirty
                || _invLossPayeeJrsdctn.Dirty
                || _invLossPayeeNm.Dirty
                || _invLossPayeeOrgTyp.Dirty
                || _invLossPayeeScsrClausTxtDesc.Dirty
                || _invLossPayeeStCd.Dirty
                || _invLossPayeeStreetAddr1.Dirty
                || _invLossPayeeStreetAddr2.Dirty
                || _invLossPayeeZip.Dirty
                || _invNm.Dirty
                || _invOrgTyp.Dirty
                || _invPhoneNum.Dirty
                || _invPmtCpn2PayToAdtlTxt.Dirty
                || _invPmtCpn2PayToAdtlTxt2.Dirty
                || _invPmtCpn2PayToCty.Dirty
                || _invPmtCpn2PayToNm.Dirty
                || _invPmtCpn2PayToStCd.Dirty
                || _invPmtCpn2PayToStreetAddr1.Dirty
                || _invPmtCpn2PayToStreetAddr2.Dirty
                || _invPmtCpn2PayToZip.Dirty
                || _invPmtCpnLoanTrsfToAdtlTxt.Dirty
                || _invPmtCpnLoanTrsfToCty.Dirty
                || _invPmtCpnLoanTrsfToNm.Dirty
                || _invPmtCpnLoanTrsfToStCd.Dirty
                || _invPmtCpnLoanTrsfToStreetAddr1.Dirty
                || _invPmtCpnLoanTrsfToStreetAddr2.Dirty
                || _invPmtCpnLoanTrsfToSvcAdtlTxt.Dirty
                || _invPmtCpnLoanTrsfToSvcCty.Dirty
                || _invPmtCpnLoanTrsfToSvcNm.Dirty
                || _invPmtCpnLoanTrsfToSvcStCd.Dirty
                || _invPmtCpnLoanTrsfToSvcStreetAddr1.Dirty
                || _invPmtCpnLoanTrsfToSvcStreetAddr2.Dirty
                || _invPmtCpnLoanTrsfToSvcZip.Dirty
                || _invPmtCpnLoanTrsfToZip.Dirty
                || _invPmtCpnPayToAdtlTxt.Dirty
                || _invPmtCpnPayToAdtlTxt2.Dirty
                || _invPmtCpnPayToCty.Dirty
                || _invPmtCpnPayToNm.Dirty
                || _invPmtCpnPayToStCd.Dirty
                || _invPmtCpnPayToStreetAddr1.Dirty
                || _invPmtCpnPayToStreetAddr2.Dirty
                || _invPmtCpnPayToZip.Dirty
                || _invStCd.Dirty
                || _invStreetAddr1.Dirty
                || _invStreetAddr2.Dirty
                || _invSvcrAdtlTxt.Dirty
                || _invSvcrCntctNm.Dirty
                || _invSvcrCntctPhoneNum.Dirty
                || _invSvcrCntctTollFreePhoneNum.Dirty
                || _invSvcrCty.Dirty
                || _invSvcrDayOp.Dirty
                || _invSvcrDayOpAddl.Dirty
                || _invSvcrHrsOp.Dirty
                || _invSvcrHrsOpAddl.Dirty
                || _invSvcrJrsdctn.Dirty
                || _invSvcrNm.Dirty
                || _invSvcrOrgTyp.Dirty
                || _invSvcrQlfdWrtnRqstMailToAdtlTxt.Dirty
                || _invSvcrQlfdWrtnRqstMailToCty.Dirty
                || _invSvcrQlfdWrtnRqstMailToNm.Dirty
                || _invSvcrQlfdWrtnRqstMailToStCd.Dirty
                || _invSvcrQlfdWrtnRqstMailToStreetAddr1.Dirty
                || _invSvcrQlfdWrtnRqstMailToStreetAddr2.Dirty
                || _invSvcrQlfdWrtnRqstMailToZip.Dirty
                || _invSvcrStCd.Dirty
                || _invSvcrStreetAddr1.Dirty
                || _invSvcrStreetAddr2.Dirty
                || _invSvcrZip.Dirty
                || _invTaxIDNum.Dirty
                || _invTollFreePhoneNum.Dirty
                || _invUrl.Dirty
                || _invZip.Dirty;
            set
            {
                _id.Dirty = value;
                _invAsgnCty.Dirty = value;
                _invAsgnJrsdctn.Dirty = value;
                _invAsgnNm.Dirty = value;
                _invAsgnOrgTyp.Dirty = value;
                _invAsgnStCd.Dirty = value;
                _invAsgnStreetAddr1.Dirty = value;
                _invAsgnStreetAddr2.Dirty = value;
                _invAsgnZip.Dirty = value;
                _invCty.Dirty = value;
                _invFaxNum.Dirty = value;
                _invJrsdctn.Dirty = value;
                _invLossPayeeAdtlTxt.Dirty = value;
                _invLossPayeeCntctEmail.Dirty = value;
                _invLossPayeeCntctFax.Dirty = value;
                _invLossPayeeCntctNm.Dirty = value;
                _invLossPayeeCntctPhone.Dirty = value;
                _invLossPayeeCty.Dirty = value;
                _invLossPayeeJrsdctn.Dirty = value;
                _invLossPayeeNm.Dirty = value;
                _invLossPayeeOrgTyp.Dirty = value;
                _invLossPayeeScsrClausTxtDesc.Dirty = value;
                _invLossPayeeStCd.Dirty = value;
                _invLossPayeeStreetAddr1.Dirty = value;
                _invLossPayeeStreetAddr2.Dirty = value;
                _invLossPayeeZip.Dirty = value;
                _invNm.Dirty = value;
                _invOrgTyp.Dirty = value;
                _invPhoneNum.Dirty = value;
                _invPmtCpn2PayToAdtlTxt.Dirty = value;
                _invPmtCpn2PayToAdtlTxt2.Dirty = value;
                _invPmtCpn2PayToCty.Dirty = value;
                _invPmtCpn2PayToNm.Dirty = value;
                _invPmtCpn2PayToStCd.Dirty = value;
                _invPmtCpn2PayToStreetAddr1.Dirty = value;
                _invPmtCpn2PayToStreetAddr2.Dirty = value;
                _invPmtCpn2PayToZip.Dirty = value;
                _invPmtCpnLoanTrsfToAdtlTxt.Dirty = value;
                _invPmtCpnLoanTrsfToCty.Dirty = value;
                _invPmtCpnLoanTrsfToNm.Dirty = value;
                _invPmtCpnLoanTrsfToStCd.Dirty = value;
                _invPmtCpnLoanTrsfToStreetAddr1.Dirty = value;
                _invPmtCpnLoanTrsfToStreetAddr2.Dirty = value;
                _invPmtCpnLoanTrsfToSvcAdtlTxt.Dirty = value;
                _invPmtCpnLoanTrsfToSvcCty.Dirty = value;
                _invPmtCpnLoanTrsfToSvcNm.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStCd.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStreetAddr1.Dirty = value;
                _invPmtCpnLoanTrsfToSvcStreetAddr2.Dirty = value;
                _invPmtCpnLoanTrsfToSvcZip.Dirty = value;
                _invPmtCpnLoanTrsfToZip.Dirty = value;
                _invPmtCpnPayToAdtlTxt.Dirty = value;
                _invPmtCpnPayToAdtlTxt2.Dirty = value;
                _invPmtCpnPayToCty.Dirty = value;
                _invPmtCpnPayToNm.Dirty = value;
                _invPmtCpnPayToStCd.Dirty = value;
                _invPmtCpnPayToStreetAddr1.Dirty = value;
                _invPmtCpnPayToStreetAddr2.Dirty = value;
                _invPmtCpnPayToZip.Dirty = value;
                _invStCd.Dirty = value;
                _invStreetAddr1.Dirty = value;
                _invStreetAddr2.Dirty = value;
                _invSvcrAdtlTxt.Dirty = value;
                _invSvcrCntctNm.Dirty = value;
                _invSvcrCntctPhoneNum.Dirty = value;
                _invSvcrCntctTollFreePhoneNum.Dirty = value;
                _invSvcrCty.Dirty = value;
                _invSvcrDayOp.Dirty = value;
                _invSvcrDayOpAddl.Dirty = value;
                _invSvcrHrsOp.Dirty = value;
                _invSvcrHrsOpAddl.Dirty = value;
                _invSvcrJrsdctn.Dirty = value;
                _invSvcrNm.Dirty = value;
                _invSvcrOrgTyp.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToAdtlTxt.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToCty.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToNm.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStCd.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStreetAddr1.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToStreetAddr2.Dirty = value;
                _invSvcrQlfdWrtnRqstMailToZip.Dirty = value;
                _invSvcrStCd.Dirty = value;
                _invSvcrStreetAddr1.Dirty = value;
                _invSvcrStreetAddr2.Dirty = value;
                _invSvcrZip.Dirty = value;
                _invTaxIDNum.Dirty = value;
                _invTollFreePhoneNum.Dirty = value;
                _invUrl.Dirty = value;
                _invZip.Dirty = value;
            }
        }
    }
}