using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocumentLender
    /// </summary>
    public sealed partial class EmDocumentLender : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// EmDocumentLender Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _lndBrchCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch City [Closing.LndBrchCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch City")]
        public string LndBrchCty { get => _lndBrchCty; set => SetField(ref _lndBrchCty, value); }
        private DirtyValue<string> _lndBrchFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch FAX Number [Closing.LndBrchFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch FAX Number")]
        public string LndBrchFax { get => _lndBrchFax; set => SetField(ref _lndBrchFax, value); }
        private DirtyValue<string> _lndBrchJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Jurisdiction [Closing.LndBrchJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Jurisdiction")]
        public string LndBrchJrsdctn { get => _lndBrchJrsdctn; set => SetField(ref _lndBrchJrsdctn, value); }
        private DirtyValue<string> _lndBrchNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Name [Closing.LndBrchNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Name")]
        public string LndBrchNm { get => _lndBrchNm; set => SetField(ref _lndBrchNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndBrchOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Organization Type [Closing.LndBrchOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Organization Type")]
        public StringEnumValue<OrgTyp> LndBrchOrgTyp { get => _lndBrchOrgTyp; set => SetField(ref _lndBrchOrgTyp, value); }
        private DirtyValue<string> _lndBrchPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Telephone Number [Closing.LndBrchPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Telephone Number")]
        public string LndBrchPhone { get => _lndBrchPhone; set => SetField(ref _lndBrchPhone, value); }
        private DirtyValue<string> _lndBrchStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch State Code [Closing.LndBrchStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch State Code")]
        public string LndBrchStCd { get => _lndBrchStCd; set => SetField(ref _lndBrchStCd, value); }
        private DirtyValue<string> _lndBrchStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Street Address [Closing.LndBrchStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Street Address")]
        public string LndBrchStreetAddr1 { get => _lndBrchStreetAddr1; set => SetField(ref _lndBrchStreetAddr1, value); }
        private DirtyValue<string> _lndBrchStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Street Address 2 [Closing.LndBrchStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Street Address 2")]
        public string LndBrchStreetAddr2 { get => _lndBrchStreetAddr2; set => SetField(ref _lndBrchStreetAddr2, value); }
        private DirtyValue<string> _lndBrchTollFreePhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Toll-Free Telephone Number [Closing.LndBrchTollFreePhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Toll-Free Telephone Number")]
        public string LndBrchTollFreePhone { get => _lndBrchTollFreePhone; set => SetField(ref _lndBrchTollFreePhone, value); }
        private DirtyValue<string> _lndBrchUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch URL [Closing.LndBrchUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch URL")]
        public string LndBrchUrl { get => _lndBrchUrl; set => SetField(ref _lndBrchUrl, value); }
        private DirtyValue<string> _lndBrchZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Postal Code [Closing.LndBrchZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Postal Code")]
        public string LndBrchZip { get => _lndBrchZip; set => SetField(ref _lndBrchZip, value); }
        private DirtyValue<string> _lndCnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender County [Closing.LndCnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender County")]
        public string LndCnty { get => _lndCnty; set => SetField(ref _lndCnty, value); }
        private DirtyValue<string> _lndCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender City [Closing.LndCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender City")]
        public string LndCty { get => _lndCty; set => SetField(ref _lndCty, value); }
        private DirtyValue<string> _lndFaxNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FAX Number [Closing.LndFaxNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FAX Number")]
        public string LndFaxNum { get => _lndFaxNum; set => SetField(ref _lndFaxNum, value); }
        private DirtyValue<string> _lndFhaOrgntrId;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FHA Originator Identifier [Closing.LndFhaOrgntrId]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FHA Originator Identifier")]
        public string LndFhaOrgntrId { get => _lndFhaOrgntrId; set => SetField(ref _lndFhaOrgntrId, value); }
        private DirtyValue<string> _lndFhaSpnsrId;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FHA Sponsor Identifier [Closing.LndFhaSpnsrId]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FHA Sponsor Identifier")]
        public string LndFhaSpnsrId { get => _lndFhaSpnsrId; set => SetField(ref _lndFhaSpnsrId, value); }
        private DirtyValue<string> _lndJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Jurisdiction [Closing.LndJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Jurisdiction")]
        public string LndJrsdctn { get => _lndJrsdctn; set => SetField(ref _lndJrsdctn, value); }
        private DirtyValue<string> _lndLossPayeeAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Additional Text [Closing.LndLossPayeeAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Additional Text")]
        public string LndLossPayeeAdtlTxt { get => _lndLossPayeeAdtlTxt; set => SetField(ref _lndLossPayeeAdtlTxt, value); }
        private DirtyValue<string> _lndLossPayeeCntctEmail;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Email Address [Closing.LndLossPayeeCntctEmail]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Email Address")]
        public string LndLossPayeeCntctEmail { get => _lndLossPayeeCntctEmail; set => SetField(ref _lndLossPayeeCntctEmail, value); }
        private DirtyValue<string> _lndLossPayeeCntctFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Fax Number [Closing.LndLossPayeeCntctFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Fax Number")]
        public string LndLossPayeeCntctFax { get => _lndLossPayeeCntctFax; set => SetField(ref _lndLossPayeeCntctFax, value); }
        private DirtyValue<string> _lndLossPayeeCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Name [Closing.LndLossPayeeCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Name")]
        public string LndLossPayeeCntctNm { get => _lndLossPayeeCntctNm; set => SetField(ref _lndLossPayeeCntctNm, value); }
        private DirtyValue<string> _lndLossPayeeCntctPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Telephone Number [Closing.LndLossPayeeCntctPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Telephone Number")]
        public string LndLossPayeeCntctPhone { get => _lndLossPayeeCntctPhone; set => SetField(ref _lndLossPayeeCntctPhone, value); }
        private DirtyValue<string> _lndLossPayeeCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee City [Closing.LndLossPayeeCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee City")]
        public string LndLossPayeeCty { get => _lndLossPayeeCty; set => SetField(ref _lndLossPayeeCty, value); }
        private DirtyValue<string> _lndLossPayeeJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Jurisdiction [Closing.LndLossPayeeJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Jurisdiction")]
        public string LndLossPayeeJrsdctn { get => _lndLossPayeeJrsdctn; set => SetField(ref _lndLossPayeeJrsdctn, value); }
        private DirtyValue<string> _lndLossPayeeNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Name [Closing.LndLossPayeeNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Name")]
        public string LndLossPayeeNm { get => _lndLossPayeeNm; set => SetField(ref _lndLossPayeeNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndLossPayeeOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Organization Type [Closing.LndLossPayeeOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Organization Type")]
        public StringEnumValue<OrgTyp> LndLossPayeeOrgTyp { get => _lndLossPayeeOrgTyp; set => SetField(ref _lndLossPayeeOrgTyp, value); }
        private DirtyValue<StringEnumValue<ScsrsClaus>> _lndLossPayeeScsrsClausTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Successor Clause [Closing.LndLossPayeeScsrsClausTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Successor Clause")]
        public StringEnumValue<ScsrsClaus> LndLossPayeeScsrsClausTxtDesc { get => _lndLossPayeeScsrsClausTxtDesc; set => SetField(ref _lndLossPayeeScsrsClausTxtDesc, value); }
        private DirtyValue<string> _lndLossPayeeStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee State Code [Closing.LndLossPayeeStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee State Code")]
        public string LndLossPayeeStCd { get => _lndLossPayeeStCd; set => SetField(ref _lndLossPayeeStCd, value); }
        private DirtyValue<string> _lndLossPayeeStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address [Closing.LndLossPayeeStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Street Address")]
        public string LndLossPayeeStreetAddr1 { get => _lndLossPayeeStreetAddr1; set => SetField(ref _lndLossPayeeStreetAddr1, value); }
        private DirtyValue<string> _lndLossPayeeStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address 2 [Closing.LndLossPayeeStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Street Address 2")]
        public string LndLossPayeeStreetAddr2 { get => _lndLossPayeeStreetAddr2; set => SetField(ref _lndLossPayeeStreetAddr2, value); }
        private DirtyValue<string> _lndLossPayeeZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Postal Code [Closing.LndLossPayeeZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Postal Code")]
        public string LndLossPayeeZip { get => _lndLossPayeeZip; set => SetField(ref _lndLossPayeeZip, value); }
        private DirtyValue<string> _lndMersIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender MERS ID No. [Closing.LndMersIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender MERS ID No.")]
        public string LndMersIdNum { get => _lndMersIdNum; set => SetField(ref _lndMersIdNum, value); }
        private DirtyValue<string> _lndNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Name [Closing.LndNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Name")]
        public string LndNm { get => _lndNm; set => SetField(ref _lndNm, value); }
        private DirtyValue<string> _lndNmlsIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender NMLS ID No. [Closing.LndNmlsIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender NMLS ID No.")]
        public string LndNmlsIdNum { get => _lndNmlsIdNum; set => SetField(ref _lndNmlsIdNum, value); }
        private DirtyValue<string> _lndNtryCmsnBndNumIdntfr;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Bond Number Identifier [Closing.LndNtryCmsnBndNumIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Bond Number Identifier")]
        public string LndNtryCmsnBndNumIdntfr { get => _lndNtryCmsnBndNumIdntfr; set => SetField(ref _lndNtryCmsnBndNumIdntfr, value); }
        private DirtyValue<string> _lndNtryCmsnCnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission County/Jurisdiction [Closing.LndNtryCmsnCnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission County/Jurisdiction")]
        public string LndNtryCmsnCnty { get => _lndNtryCmsnCnty; set => SetField(ref _lndNtryCmsnCnty, value); }
        private DirtyValue<DateTime?> _lndNtryCmsnExprDt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Expiration Date [Closing.LndNtryCmsnExprDt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Expiration Date")]
        public DateTime? LndNtryCmsnExprDt { get => _lndNtryCmsnExprDt; set => SetField(ref _lndNtryCmsnExprDt, value); }
        private DirtyValue<string> _lndNtryCmsnNumIdntfr;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Number Identifier [Closing.LndNtryCmsnNumIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Number Identifier")]
        public string LndNtryCmsnNumIdntfr { get => _lndNtryCmsnNumIdntfr; set => SetField(ref _lndNtryCmsnNumIdntfr, value); }
        private DirtyValue<string> _lndNtryCmsnSt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission State [Closing.LndNtryCmsnSt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission State")]
        public string LndNtryCmsnSt { get => _lndNtryCmsnSt; set => SetField(ref _lndNtryCmsnSt, value); }
        private DirtyValue<string> _lndNtryCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary City [Closing.LndNtryCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary City")]
        public string LndNtryCty { get => _lndNtryCty; set => SetField(ref _lndNtryCty, value); }
        private DirtyValue<string> _lndNtryNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Name [Closing.LndNtryNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Name")]
        public string LndNtryNm { get => _lndNtryNm; set => SetField(ref _lndNtryNm, value); }
        private DirtyValue<string> _lndNtryStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary State Code [Closing.LndNtryStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary State Code")]
        public string LndNtryStCd { get => _lndNtryStCd; set => SetField(ref _lndNtryStCd, value); }
        private DirtyValue<string> _lndNtryStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Street Address [Closing.LndNtryStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Street Address")]
        public string LndNtryStreetAddr1 { get => _lndNtryStreetAddr1; set => SetField(ref _lndNtryStreetAddr1, value); }
        private DirtyValue<string> _lndNtryStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Street Address 2 [Closing.LndNtryStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Street Address 2")]
        public string LndNtryStreetAddr2 { get => _lndNtryStreetAddr2; set => SetField(ref _lndNtryStreetAddr2, value); }
        private DirtyValue<string> _lndNtryTtlOrRank;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Title Or Rank [Closing.LndNtryTtlOrRank]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Title Or Rank")]
        public string LndNtryTtlOrRank { get => _lndNtryTtlOrRank; set => SetField(ref _lndNtryTtlOrRank, value); }
        private DirtyValue<string> _lndNtryZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Postal Code [Closing.LndNtryZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Postal Code")]
        public string LndNtryZip { get => _lndNtryZip; set => SetField(ref _lndNtryZip, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Organization Type [Closing.LndOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Organization Type")]
        public StringEnumValue<OrgTyp> LndOrgTyp { get => _lndOrgTyp; set => SetField(ref _lndOrgTyp, value); }
        private DirtyValue<string> _lndPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Telephone Number [Closing.LndPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Telephone Number")]
        public string LndPhoneNum { get => _lndPhoneNum; set => SetField(ref _lndPhoneNum, value); }
        private DirtyValue<string> _lndStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender State Code [Closing.LndStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender State Code")]
        public string LndStCd { get => _lndStCd; set => SetField(ref _lndStCd, value); }
        private DirtyValue<string> _lndStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Street Address [Closing.LndStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Street Address")]
        public string LndStreetAddr1 { get => _lndStreetAddr1; set => SetField(ref _lndStreetAddr1, value); }
        private DirtyValue<string> _lndStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Street Address 2 [Closing.LndStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Street Address 2")]
        public string LndStreetAddr2 { get => _lndStreetAddr2; set => SetField(ref _lndStreetAddr2, value); }
        private DirtyValue<string> _lndSvcrAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Miscellaneous Text Description [Closing.LndSvcrAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Miscellaneous Text Description")]
        public string LndSvcrAdtlTxt { get => _lndSvcrAdtlTxt; set => SetField(ref _lndSvcrAdtlTxt, value); }
        private DirtyValue<string> _lndSvcrCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Name [Closing.LndSvcrCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Name")]
        public string LndSvcrCntctNm { get => _lndSvcrCntctNm; set => SetField(ref _lndSvcrCntctNm, value); }
        private DirtyValue<string> _lndSvcrCntctPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Telephone Number [Closing.LndSvcrCntctPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Telephone Number")]
        public string LndSvcrCntctPhoneNum { get => _lndSvcrCntctPhoneNum; set => SetField(ref _lndSvcrCntctPhoneNum, value); }
        private DirtyValue<string> _lndSvcrCntctTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Toll-Free Telephone Number [Closing.LndSvcrCntctTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Toll-Free Telephone Number")]
        public string LndSvcrCntctTollFreePhoneNum { get => _lndSvcrCntctTollFreePhoneNum; set => SetField(ref _lndSvcrCntctTollFreePhoneNum, value); }
        private DirtyValue<string> _lndSvcrCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer City [Closing.LndSvcrCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer City")]
        public string LndSvcrCty { get => _lndSvcrCty; set => SetField(ref _lndSvcrCty, value); }
        private DirtyValue<string> _lndSvcrDayOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation [Closing.LndSvcrDayOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Days of Operation")]
        public string LndSvcrDayOp { get => _lndSvcrDayOp; set => SetField(ref _lndSvcrDayOp, value); }
        private DirtyValue<string> _lndSvcrDayOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation (Additional) [Closing.LndSvcrDayOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Days of Operation (Additional)")]
        public string LndSvcrDayOpAddl { get => _lndSvcrDayOpAddl; set => SetField(ref _lndSvcrDayOpAddl, value); }
        private DirtyValue<string> _lndSvcrHrsOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation [Closing.LndSvcrHrsOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Hours of Operation")]
        public string LndSvcrHrsOp { get => _lndSvcrHrsOp; set => SetField(ref _lndSvcrHrsOp, value); }
        private DirtyValue<string> _lndSvcrHrsOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation (Additional) [Closing.LndSvcrHrsOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Hours of Operation (Additional)")]
        public string LndSvcrHrsOpAddl { get => _lndSvcrHrsOpAddl; set => SetField(ref _lndSvcrHrsOpAddl, value); }
        private DirtyValue<string> _lndSvcrJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Organized Under the Laws Of Jurisdiction Name [Closing.LndSvcrJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Organized Under the Laws Of Jurisdiction Name")]
        public string LndSvcrJrsdctn { get => _lndSvcrJrsdctn; set => SetField(ref _lndSvcrJrsdctn, value); }
        private DirtyValue<string> _lndSvcrNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Name [Closing.LndSvcrNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Name")]
        public string LndSvcrNm { get => _lndSvcrNm; set => SetField(ref _lndSvcrNm, value); }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndSvcrOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Organization Type [Closing.LndSvcrOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Organization Type")]
        public StringEnumValue<OrgTyp> LndSvcrOrgTyp { get => _lndSvcrOrgTyp; set => SetField(ref _lndSvcrOrgTyp, value); }
        private DirtyValue<string> _lndSvcrStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer State Code [Closing.LndSvcrStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer State Code")]
        public string LndSvcrStCd { get => _lndSvcrStCd; set => SetField(ref _lndSvcrStCd, value); }
        private DirtyValue<string> _lndSvcrStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Street Address [Closing.LndSvcrStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Street Address")]
        public string LndSvcrStreetAddr1 { get => _lndSvcrStreetAddr1; set => SetField(ref _lndSvcrStreetAddr1, value); }
        private DirtyValue<string> _lndSvcrStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Street Address 2 [Closing.LndSvcrStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Street Address 2")]
        public string LndSvcrStreetAddr2 { get => _lndSvcrStreetAddr2; set => SetField(ref _lndSvcrStreetAddr2, value); }
        private DirtyValue<string> _lndSvcrZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Postal Code [Closing.LndSvcrZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Postal Code")]
        public string LndSvcrZip { get => _lndSvcrZip; set => SetField(ref _lndSvcrZip, value); }
        private DirtyValue<string> _lndTaxIDNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Tax ID No. [Closing.LndTaxIDNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Tax ID No.")]
        public string LndTaxIDNum { get => _lndTaxIDNum; set => SetField(ref _lndTaxIDNum, value); }
        private DirtyValue<string> _lndTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Toll-Free Telephone Number [Closing.LndTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Toll-Free Telephone Number")]
        public string LndTollFreePhoneNum { get => _lndTollFreePhoneNum; set => SetField(ref _lndTollFreePhoneNum, value); }
        private DirtyValue<string> _lndUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender URL [Closing.LndUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender URL")]
        public string LndUrl { get => _lndUrl; set => SetField(ref _lndUrl, value); }
        private DirtyValue<string> _lndVaIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender VA ID No. [Closing.LndVaIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender VA ID No.")]
        public string LndVaIdNum { get => _lndVaIdNum; set => SetField(ref _lndVaIdNum, value); }
        private DirtyValue<string> _lndZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Postal Code [Closing.LndZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Postal Code")]
        public string LndZip { get => _lndZip; set => SetField(ref _lndZip, value); }
    }
}