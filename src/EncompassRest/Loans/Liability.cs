using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Liability
    /// </summary>
    public sealed partial class Liability : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        /// <summary>
        /// Liability AccountIdentifier [FLNN10]
        /// </summary>
        public string AccountIdentifier { get => _accountIdentifier; set => _accountIdentifier = value; }
        private DirtyValue<bool?> _accountIndicator;
        /// <summary>
        /// Liability AccountIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"true\"}")]
        public bool? AccountIndicator { get => _accountIndicator; set => _accountIndicator = value; }
        private DirtyValue<string> _attention;
        /// <summary>
        /// Liability Creditor Contact [FLNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Contact")]
        public string Attention { get => _attention; set => _attention = value; }
        private EntityReference _contact;
        /// <summary>
        /// Liability Contact
        /// </summary>
        public EntityReference Contact { get => _contact ?? (_contact = new EntityReference()); set => _contact = value; }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// Liability Request Date [FLNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Request Date")]
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// Liabilities Alimony/Child Support Descr [271]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alimony/Child Support Descr")]
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _descriptionOfPurpose;
        /// <summary>
        /// .Description Of Purpose [FLNN43]
        /// </summary>
        [LoanFieldProperty(Description = ".Description Of Purpose")]
        public string DescriptionOfPurpose { get => _descriptionOfPurpose; set => _descriptionOfPurpose = value; }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Liability EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<bool?> _exclusionIndicator;
        /// <summary>
        /// Liability Exclude from URLA Total [FLNN17]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Exclude from URLA Total", OptionsJson = "{\"true\":\"Exclude from URLA page 2 Liabilities Total\"}")]
        public bool? ExclusionIndicator { get => _exclusionIndicator; set => _exclusionIndicator = value; }
        private DirtyValue<string> _holderAddressCity;
        /// <summary>
        /// Liability Creditor City [FLNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor City")]
        public string HolderAddressCity { get => _holderAddressCity; set => _holderAddressCity = value; }
        private DirtyValue<string> _holderAddressPostalCode;
        /// <summary>
        /// Liability Creditor Zipcode [FLNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Liability Creditor Zipcode")]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => _holderAddressPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        /// <summary>
        /// Liability Creditor State [FLNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor State")]
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => _holderAddressState = value; }
        private DirtyValue<string> _holderAddressStreetLine1;
        /// <summary>
        /// Liability Creditor Address [FLNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Address")]
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => _holderAddressStreetLine1 = value; }
        private DirtyValue<string> _holderComments;
        /// <summary>
        /// Liability Creditor Comments [FLNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Comments")]
        public string HolderComments { get => _holderComments; set => _holderComments = value; }
        private DirtyValue<string> _holderEmail;
        /// <summary>
        /// Liability Creditor Email [FLNN22]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Email")]
        public string HolderEmail { get => _holderEmail; set => _holderEmail = value; }
        private DirtyValue<string> _holderFax;
        /// <summary>
        /// Liability Creditor Fax [FLNN21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability Creditor Fax")]
        public string HolderFax { get => _holderFax; set => _holderFax = value; }
        private DirtyValue<string> _holderName;
        /// <summary>
        /// Liability Creditor Name [FLNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Name")]
        public string HolderName { get => _holderName; set => _holderName = value; }
        private DirtyValue<string> _holderPhone;
        /// <summary>
        /// Liability Creditor Phone [FLNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability Creditor Phone")]
        public string HolderPhone { get => _holderPhone; set => _holderPhone = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Liability Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isDebtNotSecuredToSubjectPropertyIndicator;
        /// <summary>
        /// Liability Debt is NOT secured to Subject Property [FLNN61]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Debt is NOT secured to Subject Property", OptionsJson = "{\"true\":\"This Debt is NOT secured to Subject Property?\"}")]
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => _isDebtNotSecuredToSubjectPropertyIndicator; set => _isDebtNotSecuredToSubjectPropertyIndicator = value; }
        private DirtyValue<int?> _lates12Month120Day;
        /// <summary>
        /// Liability 12 Month 120 Day Lates [FLNN55]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 120 Day Lates")]
        public int? Lates12Month120Day { get => _lates12Month120Day; set => _lates12Month120Day = value; }
        private DirtyValue<int?> _lates12Month150Day;
        /// <summary>
        /// Liability 12 Month 150 Day Lates [FLNN58]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 150 Day Lates")]
        public int? Lates12Month150Day { get => _lates12Month150Day; set => _lates12Month150Day = value; }
        private DirtyValue<int?> _lates12Month30Day;
        /// <summary>
        /// Liability 12 Month 30 Day Lates [FLNN46]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 30 Day Lates")]
        public int? Lates12Month30Day { get => _lates12Month30Day; set => _lates12Month30Day = value; }
        private DirtyValue<int?> _lates12Month60Day;
        /// <summary>
        /// Liability 12 Month 60 Day Lates [FLNN49]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 60 Day Lates")]
        public int? Lates12Month60Day { get => _lates12Month60Day; set => _lates12Month60Day = value; }
        private DirtyValue<int?> _lates12Month90Day;
        /// <summary>
        /// Liability 12 Month 90 Day Lates [FLNN52]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 90 Day Lates")]
        public int? Lates12Month90Day { get => _lates12Month90Day; set => _lates12Month90Day = value; }
        private DirtyValue<int?> _lates24Month120Day;
        /// <summary>
        /// Liability 24 Month 120 Day Lates [FLNN56]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 120 Day Lates")]
        public int? Lates24Month120Day { get => _lates24Month120Day; set => _lates24Month120Day = value; }
        private DirtyValue<int?> _lates24Month150Day;
        /// <summary>
        /// Liability 24 Month 150 Day Lates [FLNN59]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 150 Day Lates")]
        public int? Lates24Month150Day { get => _lates24Month150Day; set => _lates24Month150Day = value; }
        private DirtyValue<int?> _lates24Month30Day;
        /// <summary>
        /// Liability 24 Month 30 Day Lates [FLNN47]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 30 Day Lates")]
        public int? Lates24Month30Day { get => _lates24Month30Day; set => _lates24Month30Day = value; }
        private DirtyValue<int?> _lates24Month60Day;
        /// <summary>
        /// Liability 24 Month 60 Day Lates [FLNN50]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 60 Day Lates")]
        public int? Lates24Month60Day { get => _lates24Month60Day; set => _lates24Month60Day = value; }
        private DirtyValue<int?> _lates24Month90Day;
        /// <summary>
        /// Liability 24 Month 90 Day Lates [FLNN53]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 90 Day Lates")]
        public int? Lates24Month90Day { get => _lates24Month90Day; set => _lates24Month90Day = value; }
        private DirtyValue<int?> _lates25Month120Day;
        /// <summary>
        /// Liability 25 Month 120 Day Lates [FLNN57]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 120 Day Lates")]
        public int? Lates25Month120Day { get => _lates25Month120Day; set => _lates25Month120Day = value; }
        private DirtyValue<int?> _lates25Month150Day;
        /// <summary>
        /// Liability 25 Month 150 Day Lates [FLNN60]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 150 Day Lates")]
        public int? Lates25Month150Day { get => _lates25Month150Day; set => _lates25Month150Day = value; }
        private DirtyValue<int?> _lates25Month30Day;
        /// <summary>
        /// Liability 25 Month 30 Day Lates [FLNN48]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 30 Day Lates")]
        public int? Lates25Month30Day { get => _lates25Month30Day; set => _lates25Month30Day = value; }
        private DirtyValue<int?> _lates25Month60Day;
        /// <summary>
        /// Liability 25 Month 60 Day Lates [FLNN51]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 60 Day Lates")]
        public int? Lates25Month60Day { get => _lates25Month60Day; set => _lates25Month60Day = value; }
        private DirtyValue<int?> _lates25Month90Day;
        /// <summary>
        /// Liability 25 Month 90 Day Lates [FLNN54]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 90 Day Lates")]
        public int? Lates25Month90Day { get => _lates25Month90Day; set => _lates25Month90Day = value; }
        private DirtyValue<int?> _liabilityIndex;
        /// <summary>
        /// Liability LiabilityIndex
        /// </summary>
        public int? LiabilityIndex { get => _liabilityIndex; set => _liabilityIndex = value; }
        private DirtyValue<StringEnumValue<LiabilityType>> _liabilityType;
        /// <summary>
        /// Liability Account Type [FLNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Account Type")]
        public StringEnumValue<LiabilityType> LiabilityType { get => _liabilityType; set => _liabilityType = value; }
        private DirtyValue<decimal?> _monthlyPaymentAmount;
        /// <summary>
        /// Liability MonthlyPaymentAmount [FLNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPaymentAmount { get => _monthlyPaymentAmount; set => _monthlyPaymentAmount = value; }
        private DirtyValue<int?> _monthsToExclude;
        /// <summary>
        /// Liabilities Install Mos to Exclude [FLNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Install Mos to Exclude")]
        public int? MonthsToExclude { get => _monthsToExclude; set => _monthsToExclude = value; }
        private DirtyValue<string> _nameInAccount;
        /// <summary>
        /// Liability Account Name [FLNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Account Name")]
        public string NameInAccount { get => _nameInAccount; set => _nameInAccount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Liability No Link to Doc Tracking [FLNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<StringEnumValue<Owner>> _owner;
        /// <summary>
        /// Liability Verif is For [FLNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Verif is For")]
        public StringEnumValue<Owner> Owner { get => _owner; set => _owner = value; }
        private DirtyValue<bool?> _payoffIncludedIndicator;
        /// <summary>
        /// Liability Will be Paid Off and will be included [FLNN63]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off and will be included", OptionsJson = "{\"true\":\"Paid off (*) will be included\"}")]
        public bool? PayoffIncludedIndicator { get => _payoffIncludedIndicator; set => _payoffIncludedIndicator = value; }
        private DirtyValue<bool?> _payoffStatusIndicator;
        /// <summary>
        /// Liability Will be Paid Off [FLNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off", OptionsJson = "{\"true\":\"Will be paid off (*)\"}")]
        public bool? PayoffStatusIndicator { get => _payoffStatusIndicator; set => _payoffStatusIndicator = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        /// <summary>
        /// Liability Prepayment Penalty [FLNN39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Prepayment Penalty")]
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => _prepaymentPenaltyAmount = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        /// <summary>
        /// Liability Print - See Attached Authorization [FLNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Liability Print User Name as Title [FLNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<int?> _remainingTermMonths;
        /// <summary>
        /// Liability RemainingTermMonths [FLNN12]
        /// </summary>
        public int? RemainingTermMonths { get => _remainingTermMonths; set => _remainingTermMonths = value; }
        private DirtyValue<string> _reoId;
        /// <summary>
        /// Liability REO ID [FLNN25]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability REO ID")]
        public string ReoId { get => _reoId; set => _reoId = value; }
        private DirtyValue<string> _requestId;
        /// <summary>
        /// Liability Request ID [FLNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability Request ID")]
        public string RequestId { get => _requestId; set => _requestId = value; }
        private DirtyValue<bool?> _subjectLoanResubordinationIndicator;
        /// <summary>
        /// Liability Resubordinated Indicator [FLNN26]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Resubordinated Indicator", OptionsJson = "{\"true\":\"Resubordinated Indicator\"}")]
        public bool? SubjectLoanResubordinationIndicator { get => _subjectLoanResubordinationIndicator; set => _subjectLoanResubordinationIndicator = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// Liability From Title [FLNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Liability From Title")]
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Liability From Fax [FLNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability From Fax")]
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Liability From Phone [FLNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability From Phone")]
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        private DirtyValue<decimal?> _toBePaidOffAmount;
        /// <summary>
        /// Liability Payoff Amount [FLNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Payoff Amount")]
        public decimal? ToBePaidOffAmount { get => _toBePaidOffAmount; set => _toBePaidOffAmount = value; }
        private DirtyValue<StringEnumValue<UCDPayoffType>> _uCDPayoffType;
        /// <summary>
        /// Liability UCD Payoff Type [FLNN62]
        /// </summary>
        [LoanFieldProperty(Description = "Liability UCD Payoff Type")]
        public StringEnumValue<UCDPayoffType> UCDPayoffType { get => _uCDPayoffType; set => _uCDPayoffType = value; }
        private DirtyValue<decimal?> _unpaidBalanceAmount;
        /// <summary>
        /// Liability Balance [FLNN13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Balance")]
        public decimal? UnpaidBalanceAmount { get => _unpaidBalanceAmount; set => _unpaidBalanceAmount = value; }
        private DirtyValue<int?> _volIndex;
        /// <summary>
        /// Liability VolIndex
        /// </summary>
        public int? VolIndex { get => _volIndex; set => _volIndex = value; }
    }
}