using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmDocumentLender
    /// </summary>
    public sealed partial class EmDocumentLender : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// EmDocumentLender Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lndBrchCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch City [Closing.LndBrchCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch City")]
        public string LndBrchCty { get => _lndBrchCty; set => _lndBrchCty = value; }
        private DirtyValue<string> _lndBrchFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch FAX Number [Closing.LndBrchFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch FAX Number")]
        public string LndBrchFax { get => _lndBrchFax; set => _lndBrchFax = value; }
        private DirtyValue<string> _lndBrchJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Jurisdiction [Closing.LndBrchJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Jurisdiction")]
        public string LndBrchJrsdctn { get => _lndBrchJrsdctn; set => _lndBrchJrsdctn = value; }
        private DirtyValue<string> _lndBrchNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Name [Closing.LndBrchNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Name")]
        public string LndBrchNm { get => _lndBrchNm; set => _lndBrchNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndBrchOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Organization Type [Closing.LndBrchOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Organization Type")]
        public StringEnumValue<OrgTyp> LndBrchOrgTyp { get => _lndBrchOrgTyp; set => _lndBrchOrgTyp = value; }
        private DirtyValue<string> _lndBrchPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Telephone Number [Closing.LndBrchPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Telephone Number")]
        public string LndBrchPhone { get => _lndBrchPhone; set => _lndBrchPhone = value; }
        private DirtyValue<string> _lndBrchStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch State Code [Closing.LndBrchStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch State Code")]
        public string LndBrchStCd { get => _lndBrchStCd; set => _lndBrchStCd = value; }
        private DirtyValue<string> _lndBrchStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Street Address [Closing.LndBrchStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Street Address")]
        public string LndBrchStreetAddr1 { get => _lndBrchStreetAddr1; set => _lndBrchStreetAddr1 = value; }
        private DirtyValue<string> _lndBrchStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Street Address 2 [Closing.LndBrchStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Street Address 2")]
        public string LndBrchStreetAddr2 { get => _lndBrchStreetAddr2; set => _lndBrchStreetAddr2 = value; }
        private DirtyValue<string> _lndBrchTollFreePhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Toll-Free Telephone Number [Closing.LndBrchTollFreePhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Toll-Free Telephone Number")]
        public string LndBrchTollFreePhone { get => _lndBrchTollFreePhone; set => _lndBrchTollFreePhone = value; }
        private DirtyValue<string> _lndBrchUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch URL [Closing.LndBrchUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch URL")]
        public string LndBrchUrl { get => _lndBrchUrl; set => _lndBrchUrl = value; }
        private DirtyValue<string> _lndBrchZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Branch Postal Code [Closing.LndBrchZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Branch Postal Code")]
        public string LndBrchZip { get => _lndBrchZip; set => _lndBrchZip = value; }
        private DirtyValue<string> _lndCnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender County [Closing.LndCnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender County")]
        public string LndCnty { get => _lndCnty; set => _lndCnty = value; }
        private DirtyValue<string> _lndCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender City [Closing.LndCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender City")]
        public string LndCty { get => _lndCty; set => _lndCty = value; }
        private DirtyValue<string> _lndFaxNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FAX Number [Closing.LndFaxNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FAX Number")]
        public string LndFaxNum { get => _lndFaxNum; set => _lndFaxNum = value; }
        private DirtyValue<string> _lndFhaOrgntrId;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FHA Originator Identifier [Closing.LndFhaOrgntrId]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FHA Originator Identifier")]
        public string LndFhaOrgntrId { get => _lndFhaOrgntrId; set => _lndFhaOrgntrId = value; }
        private DirtyValue<string> _lndFhaSpnsrId;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender FHA Sponsor Identifier [Closing.LndFhaSpnsrId]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender FHA Sponsor Identifier")]
        public string LndFhaSpnsrId { get => _lndFhaSpnsrId; set => _lndFhaSpnsrId = value; }
        private DirtyValue<string> _lndJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Jurisdiction [Closing.LndJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Jurisdiction")]
        public string LndJrsdctn { get => _lndJrsdctn; set => _lndJrsdctn = value; }
        private DirtyValue<string> _lndLossPayeeAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Additional Text [Closing.LndLossPayeeAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Additional Text")]
        public string LndLossPayeeAdtlTxt { get => _lndLossPayeeAdtlTxt; set => _lndLossPayeeAdtlTxt = value; }
        private DirtyValue<string> _lndLossPayeeCntctEmail;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Email Address [Closing.LndLossPayeeCntctEmail]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Email Address")]
        public string LndLossPayeeCntctEmail { get => _lndLossPayeeCntctEmail; set => _lndLossPayeeCntctEmail = value; }
        private DirtyValue<string> _lndLossPayeeCntctFax;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Fax Number [Closing.LndLossPayeeCntctFax]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Fax Number")]
        public string LndLossPayeeCntctFax { get => _lndLossPayeeCntctFax; set => _lndLossPayeeCntctFax = value; }
        private DirtyValue<string> _lndLossPayeeCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Name [Closing.LndLossPayeeCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Name")]
        public string LndLossPayeeCntctNm { get => _lndLossPayeeCntctNm; set => _lndLossPayeeCntctNm = value; }
        private DirtyValue<string> _lndLossPayeeCntctPhone;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Contact Telephone Number [Closing.LndLossPayeeCntctPhone]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Contact Telephone Number")]
        public string LndLossPayeeCntctPhone { get => _lndLossPayeeCntctPhone; set => _lndLossPayeeCntctPhone = value; }
        private DirtyValue<string> _lndLossPayeeCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee City [Closing.LndLossPayeeCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee City")]
        public string LndLossPayeeCty { get => _lndLossPayeeCty; set => _lndLossPayeeCty = value; }
        private DirtyValue<string> _lndLossPayeeJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Jurisdiction [Closing.LndLossPayeeJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Jurisdiction")]
        public string LndLossPayeeJrsdctn { get => _lndLossPayeeJrsdctn; set => _lndLossPayeeJrsdctn = value; }
        private DirtyValue<string> _lndLossPayeeNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Name [Closing.LndLossPayeeNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Name")]
        public string LndLossPayeeNm { get => _lndLossPayeeNm; set => _lndLossPayeeNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndLossPayeeOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Organization Type [Closing.LndLossPayeeOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Organization Type")]
        public StringEnumValue<OrgTyp> LndLossPayeeOrgTyp { get => _lndLossPayeeOrgTyp; set => _lndLossPayeeOrgTyp = value; }
        private DirtyValue<StringEnumValue<ScsrsClaus>> _lndLossPayeeScsrsClausTxtDesc;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Successor Clause [Closing.LndLossPayeeScsrsClausTxtDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Successor Clause")]
        public StringEnumValue<ScsrsClaus> LndLossPayeeScsrsClausTxtDesc { get => _lndLossPayeeScsrsClausTxtDesc; set => _lndLossPayeeScsrsClausTxtDesc = value; }
        private DirtyValue<string> _lndLossPayeeStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee State Code [Closing.LndLossPayeeStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee State Code")]
        public string LndLossPayeeStCd { get => _lndLossPayeeStCd; set => _lndLossPayeeStCd = value; }
        private DirtyValue<string> _lndLossPayeeStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address [Closing.LndLossPayeeStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Street Address")]
        public string LndLossPayeeStreetAddr1 { get => _lndLossPayeeStreetAddr1; set => _lndLossPayeeStreetAddr1 = value; }
        private DirtyValue<string> _lndLossPayeeStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Street Address 2 [Closing.LndLossPayeeStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Street Address 2")]
        public string LndLossPayeeStreetAddr2 { get => _lndLossPayeeStreetAddr2; set => _lndLossPayeeStreetAddr2 = value; }
        private DirtyValue<string> _lndLossPayeeZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Loss Payee Postal Code [Closing.LndLossPayeeZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Loss Payee Postal Code")]
        public string LndLossPayeeZip { get => _lndLossPayeeZip; set => _lndLossPayeeZip = value; }
        private DirtyValue<string> _lndMersIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender MERS ID No. [Closing.LndMersIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender MERS ID No.")]
        public string LndMersIdNum { get => _lndMersIdNum; set => _lndMersIdNum = value; }
        private DirtyValue<string> _lndNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Name [Closing.LndNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Name")]
        public string LndNm { get => _lndNm; set => _lndNm = value; }
        private DirtyValue<string> _lndNmlsIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender NMLS ID No. [Closing.LndNmlsIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender NMLS ID No.")]
        public string LndNmlsIdNum { get => _lndNmlsIdNum; set => _lndNmlsIdNum = value; }
        private DirtyValue<string> _lndNtryCmsnBndNumIdntfr;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Bond Number Identifier [Closing.LndNtryCmsnBndNumIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Bond Number Identifier")]
        public string LndNtryCmsnBndNumIdntfr { get => _lndNtryCmsnBndNumIdntfr; set => _lndNtryCmsnBndNumIdntfr = value; }
        private DirtyValue<string> _lndNtryCmsnCnty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission County/Jurisdiction [Closing.LndNtryCmsnCnty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission County/Jurisdiction")]
        public string LndNtryCmsnCnty { get => _lndNtryCmsnCnty; set => _lndNtryCmsnCnty = value; }
        private DirtyValue<DateTime?> _lndNtryCmsnExprDt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Expiration Date [Closing.LndNtryCmsnExprDt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Expiration Date")]
        public DateTime? LndNtryCmsnExprDt { get => _lndNtryCmsnExprDt; set => _lndNtryCmsnExprDt = value; }
        private DirtyValue<string> _lndNtryCmsnNumIdntfr;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission Number Identifier [Closing.LndNtryCmsnNumIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission Number Identifier")]
        public string LndNtryCmsnNumIdntfr { get => _lndNtryCmsnNumIdntfr; set => _lndNtryCmsnNumIdntfr = value; }
        private DirtyValue<string> _lndNtryCmsnSt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Commission State [Closing.LndNtryCmsnSt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Commission State")]
        public string LndNtryCmsnSt { get => _lndNtryCmsnSt; set => _lndNtryCmsnSt = value; }
        private DirtyValue<string> _lndNtryCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary City [Closing.LndNtryCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary City")]
        public string LndNtryCty { get => _lndNtryCty; set => _lndNtryCty = value; }
        private DirtyValue<string> _lndNtryNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Name [Closing.LndNtryNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Name")]
        public string LndNtryNm { get => _lndNtryNm; set => _lndNtryNm = value; }
        private DirtyValue<string> _lndNtryStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary State Code [Closing.LndNtryStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary State Code")]
        public string LndNtryStCd { get => _lndNtryStCd; set => _lndNtryStCd = value; }
        private DirtyValue<string> _lndNtryStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Street Address [Closing.LndNtryStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Street Address")]
        public string LndNtryStreetAddr1 { get => _lndNtryStreetAddr1; set => _lndNtryStreetAddr1 = value; }
        private DirtyValue<string> _lndNtryStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Street Address 2 [Closing.LndNtryStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Street Address 2")]
        public string LndNtryStreetAddr2 { get => _lndNtryStreetAddr2; set => _lndNtryStreetAddr2 = value; }
        private DirtyValue<string> _lndNtryTtlOrRank;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Title Or Rank [Closing.LndNtryTtlOrRank]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Title Or Rank")]
        public string LndNtryTtlOrRank { get => _lndNtryTtlOrRank; set => _lndNtryTtlOrRank = value; }
        private DirtyValue<string> _lndNtryZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Notary Postal Code [Closing.LndNtryZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Notary Postal Code")]
        public string LndNtryZip { get => _lndNtryZip; set => _lndNtryZip = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Organization Type [Closing.LndOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Organization Type")]
        public StringEnumValue<OrgTyp> LndOrgTyp { get => _lndOrgTyp; set => _lndOrgTyp = value; }
        private DirtyValue<string> _lndPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Telephone Number [Closing.LndPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Telephone Number")]
        public string LndPhoneNum { get => _lndPhoneNum; set => _lndPhoneNum = value; }
        private DirtyValue<string> _lndStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender State Code [Closing.LndStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender State Code")]
        public string LndStCd { get => _lndStCd; set => _lndStCd = value; }
        private DirtyValue<string> _lndStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Street Address [Closing.LndStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Street Address")]
        public string LndStreetAddr1 { get => _lndStreetAddr1; set => _lndStreetAddr1 = value; }
        private DirtyValue<string> _lndStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Street Address 2 [Closing.LndStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Street Address 2")]
        public string LndStreetAddr2 { get => _lndStreetAddr2; set => _lndStreetAddr2 = value; }
        private DirtyValue<string> _lndSvcrAdtlTxt;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Miscellaneous Text Description [Closing.LndSvcrAdtlTxt]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Miscellaneous Text Description")]
        public string LndSvcrAdtlTxt { get => _lndSvcrAdtlTxt; set => _lndSvcrAdtlTxt = value; }
        private DirtyValue<string> _lndSvcrCntctNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Name [Closing.LndSvcrCntctNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Name")]
        public string LndSvcrCntctNm { get => _lndSvcrCntctNm; set => _lndSvcrCntctNm = value; }
        private DirtyValue<string> _lndSvcrCntctPhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Telephone Number [Closing.LndSvcrCntctPhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Telephone Number")]
        public string LndSvcrCntctPhoneNum { get => _lndSvcrCntctPhoneNum; set => _lndSvcrCntctPhoneNum = value; }
        private DirtyValue<string> _lndSvcrCntctTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Contact Toll-Free Telephone Number [Closing.LndSvcrCntctTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Contact Toll-Free Telephone Number")]
        public string LndSvcrCntctTollFreePhoneNum { get => _lndSvcrCntctTollFreePhoneNum; set => _lndSvcrCntctTollFreePhoneNum = value; }
        private DirtyValue<string> _lndSvcrCty;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer City [Closing.LndSvcrCty]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer City")]
        public string LndSvcrCty { get => _lndSvcrCty; set => _lndSvcrCty = value; }
        private DirtyValue<string> _lndSvcrDayOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation [Closing.LndSvcrDayOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Days of Operation")]
        public string LndSvcrDayOp { get => _lndSvcrDayOp; set => _lndSvcrDayOp = value; }
        private DirtyValue<string> _lndSvcrDayOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Days of Operation (Additional) [Closing.LndSvcrDayOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Days of Operation (Additional)")]
        public string LndSvcrDayOpAddl { get => _lndSvcrDayOpAddl; set => _lndSvcrDayOpAddl = value; }
        private DirtyValue<string> _lndSvcrHrsOp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation [Closing.LndSvcrHrsOp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Hours of Operation")]
        public string LndSvcrHrsOp { get => _lndSvcrHrsOp; set => _lndSvcrHrsOp = value; }
        private DirtyValue<string> _lndSvcrHrsOpAddl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Hours of Operation (Additional) [Closing.LndSvcrHrsOpAddl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Hours of Operation (Additional)")]
        public string LndSvcrHrsOpAddl { get => _lndSvcrHrsOpAddl; set => _lndSvcrHrsOpAddl = value; }
        private DirtyValue<string> _lndSvcrJrsdctn;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Organized Under the Laws Of Jurisdiction Name [Closing.LndSvcrJrsdctn]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Organized Under the Laws Of Jurisdiction Name")]
        public string LndSvcrJrsdctn { get => _lndSvcrJrsdctn; set => _lndSvcrJrsdctn = value; }
        private DirtyValue<string> _lndSvcrNm;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Name [Closing.LndSvcrNm]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Name")]
        public string LndSvcrNm { get => _lndSvcrNm; set => _lndSvcrNm = value; }
        private DirtyValue<StringEnumValue<OrgTyp>> _lndSvcrOrgTyp;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Organization Type [Closing.LndSvcrOrgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Organization Type")]
        public StringEnumValue<OrgTyp> LndSvcrOrgTyp { get => _lndSvcrOrgTyp; set => _lndSvcrOrgTyp = value; }
        private DirtyValue<string> _lndSvcrStCd;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer State Code [Closing.LndSvcrStCd]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer State Code")]
        public string LndSvcrStCd { get => _lndSvcrStCd; set => _lndSvcrStCd = value; }
        private DirtyValue<string> _lndSvcrStreetAddr1;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Street Address [Closing.LndSvcrStreetAddr1]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Street Address")]
        public string LndSvcrStreetAddr1 { get => _lndSvcrStreetAddr1; set => _lndSvcrStreetAddr1 = value; }
        private DirtyValue<string> _lndSvcrStreetAddr2;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Street Address 2 [Closing.LndSvcrStreetAddr2]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Street Address 2")]
        public string LndSvcrStreetAddr2 { get => _lndSvcrStreetAddr2; set => _lndSvcrStreetAddr2 = value; }
        private DirtyValue<string> _lndSvcrZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Servicer Postal Code [Closing.LndSvcrZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Servicer Postal Code")]
        public string LndSvcrZip { get => _lndSvcrZip; set => _lndSvcrZip = value; }
        private DirtyValue<string> _lndTaxIDNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Tax ID No. [Closing.LndTaxIDNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Tax ID No.")]
        public string LndTaxIDNum { get => _lndTaxIDNum; set => _lndTaxIDNum = value; }
        private DirtyValue<string> _lndTollFreePhoneNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Toll-Free Telephone Number [Closing.LndTollFreePhoneNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Toll-Free Telephone Number")]
        public string LndTollFreePhoneNum { get => _lndTollFreePhoneNum; set => _lndTollFreePhoneNum = value; }
        private DirtyValue<string> _lndUrl;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender URL [Closing.LndUrl]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender URL")]
        public string LndUrl { get => _lndUrl; set => _lndUrl = value; }
        private DirtyValue<string> _lndVaIdNum;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender VA ID No. [Closing.LndVaIdNum]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender VA ID No.")]
        public string LndVaIdNum { get => _lndVaIdNum; set => _lndVaIdNum = value; }
        private DirtyValue<string> _lndZip;
        /// <summary>
        /// Ellie Mae Closing Document Override - Lender Postal Code [Closing.LndZip]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Closing Document Override - Lender Postal Code")]
        public string LndZip { get => _lndZip; set => _lndZip = value; }
        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _lndBrchCty.Dirty
                || _lndBrchFax.Dirty
                || _lndBrchJrsdctn.Dirty
                || _lndBrchNm.Dirty
                || _lndBrchOrgTyp.Dirty
                || _lndBrchPhone.Dirty
                || _lndBrchStCd.Dirty
                || _lndBrchStreetAddr1.Dirty
                || _lndBrchStreetAddr2.Dirty
                || _lndBrchTollFreePhone.Dirty
                || _lndBrchUrl.Dirty
                || _lndBrchZip.Dirty
                || _lndCnty.Dirty
                || _lndCty.Dirty
                || _lndFaxNum.Dirty
                || _lndFhaOrgntrId.Dirty
                || _lndFhaSpnsrId.Dirty
                || _lndJrsdctn.Dirty
                || _lndLossPayeeAdtlTxt.Dirty
                || _lndLossPayeeCntctEmail.Dirty
                || _lndLossPayeeCntctFax.Dirty
                || _lndLossPayeeCntctNm.Dirty
                || _lndLossPayeeCntctPhone.Dirty
                || _lndLossPayeeCty.Dirty
                || _lndLossPayeeJrsdctn.Dirty
                || _lndLossPayeeNm.Dirty
                || _lndLossPayeeOrgTyp.Dirty
                || _lndLossPayeeScsrsClausTxtDesc.Dirty
                || _lndLossPayeeStCd.Dirty
                || _lndLossPayeeStreetAddr1.Dirty
                || _lndLossPayeeStreetAddr2.Dirty
                || _lndLossPayeeZip.Dirty
                || _lndMersIdNum.Dirty
                || _lndNm.Dirty
                || _lndNmlsIdNum.Dirty
                || _lndNtryCmsnBndNumIdntfr.Dirty
                || _lndNtryCmsnCnty.Dirty
                || _lndNtryCmsnExprDt.Dirty
                || _lndNtryCmsnNumIdntfr.Dirty
                || _lndNtryCmsnSt.Dirty
                || _lndNtryCty.Dirty
                || _lndNtryNm.Dirty
                || _lndNtryStCd.Dirty
                || _lndNtryStreetAddr1.Dirty
                || _lndNtryStreetAddr2.Dirty
                || _lndNtryTtlOrRank.Dirty
                || _lndNtryZip.Dirty
                || _lndOrgTyp.Dirty
                || _lndPhoneNum.Dirty
                || _lndStCd.Dirty
                || _lndStreetAddr1.Dirty
                || _lndStreetAddr2.Dirty
                || _lndSvcrAdtlTxt.Dirty
                || _lndSvcrCntctNm.Dirty
                || _lndSvcrCntctPhoneNum.Dirty
                || _lndSvcrCntctTollFreePhoneNum.Dirty
                || _lndSvcrCty.Dirty
                || _lndSvcrDayOp.Dirty
                || _lndSvcrDayOpAddl.Dirty
                || _lndSvcrHrsOp.Dirty
                || _lndSvcrHrsOpAddl.Dirty
                || _lndSvcrJrsdctn.Dirty
                || _lndSvcrNm.Dirty
                || _lndSvcrOrgTyp.Dirty
                || _lndSvcrStCd.Dirty
                || _lndSvcrStreetAddr1.Dirty
                || _lndSvcrStreetAddr2.Dirty
                || _lndSvcrZip.Dirty
                || _lndTaxIDNum.Dirty
                || _lndTollFreePhoneNum.Dirty
                || _lndUrl.Dirty
                || _lndVaIdNum.Dirty
                || _lndZip.Dirty;
            set
            {
                _id.Dirty = value;
                _lndBrchCty.Dirty = value;
                _lndBrchFax.Dirty = value;
                _lndBrchJrsdctn.Dirty = value;
                _lndBrchNm.Dirty = value;
                _lndBrchOrgTyp.Dirty = value;
                _lndBrchPhone.Dirty = value;
                _lndBrchStCd.Dirty = value;
                _lndBrchStreetAddr1.Dirty = value;
                _lndBrchStreetAddr2.Dirty = value;
                _lndBrchTollFreePhone.Dirty = value;
                _lndBrchUrl.Dirty = value;
                _lndBrchZip.Dirty = value;
                _lndCnty.Dirty = value;
                _lndCty.Dirty = value;
                _lndFaxNum.Dirty = value;
                _lndFhaOrgntrId.Dirty = value;
                _lndFhaSpnsrId.Dirty = value;
                _lndJrsdctn.Dirty = value;
                _lndLossPayeeAdtlTxt.Dirty = value;
                _lndLossPayeeCntctEmail.Dirty = value;
                _lndLossPayeeCntctFax.Dirty = value;
                _lndLossPayeeCntctNm.Dirty = value;
                _lndLossPayeeCntctPhone.Dirty = value;
                _lndLossPayeeCty.Dirty = value;
                _lndLossPayeeJrsdctn.Dirty = value;
                _lndLossPayeeNm.Dirty = value;
                _lndLossPayeeOrgTyp.Dirty = value;
                _lndLossPayeeScsrsClausTxtDesc.Dirty = value;
                _lndLossPayeeStCd.Dirty = value;
                _lndLossPayeeStreetAddr1.Dirty = value;
                _lndLossPayeeStreetAddr2.Dirty = value;
                _lndLossPayeeZip.Dirty = value;
                _lndMersIdNum.Dirty = value;
                _lndNm.Dirty = value;
                _lndNmlsIdNum.Dirty = value;
                _lndNtryCmsnBndNumIdntfr.Dirty = value;
                _lndNtryCmsnCnty.Dirty = value;
                _lndNtryCmsnExprDt.Dirty = value;
                _lndNtryCmsnNumIdntfr.Dirty = value;
                _lndNtryCmsnSt.Dirty = value;
                _lndNtryCty.Dirty = value;
                _lndNtryNm.Dirty = value;
                _lndNtryStCd.Dirty = value;
                _lndNtryStreetAddr1.Dirty = value;
                _lndNtryStreetAddr2.Dirty = value;
                _lndNtryTtlOrRank.Dirty = value;
                _lndNtryZip.Dirty = value;
                _lndOrgTyp.Dirty = value;
                _lndPhoneNum.Dirty = value;
                _lndStCd.Dirty = value;
                _lndStreetAddr1.Dirty = value;
                _lndStreetAddr2.Dirty = value;
                _lndSvcrAdtlTxt.Dirty = value;
                _lndSvcrCntctNm.Dirty = value;
                _lndSvcrCntctPhoneNum.Dirty = value;
                _lndSvcrCntctTollFreePhoneNum.Dirty = value;
                _lndSvcrCty.Dirty = value;
                _lndSvcrDayOp.Dirty = value;
                _lndSvcrDayOpAddl.Dirty = value;
                _lndSvcrHrsOp.Dirty = value;
                _lndSvcrHrsOpAddl.Dirty = value;
                _lndSvcrJrsdctn.Dirty = value;
                _lndSvcrNm.Dirty = value;
                _lndSvcrOrgTyp.Dirty = value;
                _lndSvcrStCd.Dirty = value;
                _lndSvcrStreetAddr1.Dirty = value;
                _lndSvcrStreetAddr2.Dirty = value;
                _lndSvcrZip.Dirty = value;
                _lndTaxIDNum.Dirty = value;
                _lndTollFreePhoneNum.Dirty = value;
                _lndUrl.Dirty = value;
                _lndVaIdNum.Dirty = value;
                _lndZip.Dirty = value;
            }
        }
    }
}